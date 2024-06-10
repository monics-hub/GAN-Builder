import os, sys
import tensorflow as tf
import pathlib
import random
import math
from matplotlib import pyplot as plt
from IPython import display


# 1. LOADING THE IMAGES  .........................................................................................................................................


def load(image_file):
    image = tf.io.read_file(image_file)
    image = tf.image.decode_jpeg(image, 3)
    image = tf.cast(image, tf.float32)
    return image

BUFFER_SIZE = 60
BATCH_SIZE = 1

def get_size(image):
    width = image[0]
    print("\n\n START")
    print(width)
    print(type(width))
    print("END \n\n")
    height = tf.gather(image, 1)
    if width < height:
        bigger_side = height
    else:
        bigger_side =  width
    power = math.log(bigger_side, 2)
    power = math.ceil(power)
    if power < 9:
        power = 8
    size = 2**power
    return size

def resize(input_image, real_image, height, width):
    input_image = tf.image.resize(input_image, [height, width], method=tf.image.ResizeMethod.NEAREST_NEIGHBOR)
    real_image = tf.image.resize(real_image, [height, width], method=tf.image.ResizeMethod.NEAREST_NEIGHBOR)
    return input_image, real_image

def random_crop(input_image, real_image):
    stacked_image = tf.stack([input_image, real_image], axis=0)
    cropped_image = tf.image.random_crop(stacked_image, size=[2, IMG_HEIGHT, IMG_WIDTH, 3])
    return cropped_image[0], cropped_image[1]

def normalize(input_image, real_image):
    input_image = (input_image / 127.5) - 1
    real_image = (real_image / 127.5) - 1
    return input_image, real_image

#@tf.function()
def random_jitter(input_image, real_image):
    input_image, real_image = random_crop(input_image, real_image)
    if tf.random.uniform(()) > 0.5:
        input_image = tf.image.flip_left_right(input_image)
        real_image = tf.image.flip_left_right(real_image)
    return input_image, real_image


def create_datasets(train_path, target_path, train_files, test_files):
    def load_image_train(image_file):
        input_image = load(train_path + "/" + image_file)
        real_image = load(target_path + "/" +  image_file)
        size = get_size(input_image)
        input_image, real_image = resize(input_image, real_image, size, size)
        #input_image, real_image = random_jitter(input_image, real_image)
        input_image, real_image = normalize(input_image, real_image)
        return input_image, real_image

    def load_image_test(image_file):
        input_image = load(train_path + "/" + image_file)
        real_image = load(target_path + "/" +  image_file)
        size = get_size(input_image)
        input_image, real_image = resize(input_image, real_image, size, size)
        input_image, real_image = normalize(input_image, real_image)
        return input_image, real_image

    train_dataset = tf.data.Dataset.from_tensor_slices(train_files)
    train_dataset = train_dataset.map(load_image_train, num_parallel_calls = tf.data.experimental.AUTOTUNE)
    train_dataset = train_dataset.batch(BATCH_SIZE)
    test_dataset = tf.data.Dataset.from_tensor_slices(test_files)
    test_dataset = test_dataset.map(load_image_test, num_parallel_calls = tf.data.experimental.AUTOTUNE)
    test_dataset = test_dataset.batch(BATCH_SIZE)

    return train_dataset, test_dataset


# 2. NETWORK ............................................................................................................................................


OUTPUT_CHANNELS = 3
def downsample(filters, size, apply_batchnorm=True):
    initializer = tf.random_normal_initializer(0., 0.02)
    result = tf.keras.Sequential()
    result.add(tf.keras.layers.Conv2D(filters, size, strides=2, padding='same', kernel_initializer=initializer, use_bias=False))
    if apply_batchnorm:
        result.add(tf.keras.layers.BatchNormalization())
    result.add(tf.keras.layers.LeakyReLU())
    return result

def upsample(filters, size, apply_dropout=False):
    initializer = tf.random_normal_initializer(0., 0.02)
    result = tf.keras.Sequential()
    result.add(tf.keras.layers.Conv2DTranspose(filters, size, strides=2, padding='same', kernel_initializer=initializer, use_bias=False))
    result.add(tf.keras.layers.BatchNormalization())
    if apply_dropout:
        result.add(tf.keras.layers.Dropout(0.5))
    result.add(tf.keras.layers.ReLU())
    return result


# 3. GENERATOR ..........................................................................................................................................................


def Generator():
    inputs = tf.keras.layers.Input(shape=[None, None, 3])
    down_stack = [
        downsample(64, 4, apply_batchnorm=False),  # (batch_size, 128, 128, 64)
        downsample(128, 4),  # (batch_size, 64, 64, 128)
        downsample(256, 4),  # (batch_size, 32, 32, 256)
        downsample(512, 4),  # (batch_size, 16, 16, 512)
        downsample(512, 4),  # (batch_size, 8, 8, 512)
        downsample(512, 4),  # (batch_size, 4, 4, 512)
        downsample(512, 4),  # (batch_size, 2, 2, 512)
        downsample(512, 4),  # (batch_size, 1, 1, 512)
        ]
    up_stack = [
        upsample(512, 4, apply_dropout=True),  # (batch_size, 2, 2, 1024)
        upsample(512, 4, apply_dropout=True),  # (batch_size, 4, 4, 1024)
        upsample(512, 4, apply_dropout=True),  # (batch_size, 8, 8, 1024)
        upsample(512, 4),  # (batch_size, 16, 16, 1024)
        upsample(256, 4),  # (batch_size, 32, 32, 512)
        upsample(128, 4),  # (batch_size, 64, 64, 256)
        upsample(64, 4),  # (batch_size, 128, 128, 128)
        ]
    initializer = tf.random_normal_initializer(0., 0.02)
    last = tf.keras.layers.Conv2DTranspose(OUTPUT_CHANNELS, 4, strides=2, padding='same', kernel_initializer=initializer, activation='tanh')  # (batch_size, 256, 256, 3)
    x = inputs
    skips = []
    for down in down_stack:
        x = down(x)
        skips.append(x)
    skips = reversed(skips[:-1])
    for up, skip in zip(up_stack, skips):
        x = up(x)
        x = tf.keras.layers.Concatenate()([x, skip])
    x = last(x)
    return tf.keras.Model(inputs=inputs, outputs=x)

generator = Generator()

LAMBDA = 100
loss_object = tf.keras.losses.BinaryCrossentropy(from_logits=True)

def generator_loss(disc_generated_output, gen_output, target):
    gan_loss = loss_object(tf.ones_like(disc_generated_output), disc_generated_output)
    l1_loss = tf.reduce_mean(tf.abs(target - gen_output))
    total_gen_loss = gan_loss + (LAMBDA * l1_loss)
    return total_gen_loss, gan_loss, l1_loss


# 4. DISCRIMINATOR ......................................................................................................................................................


def Discriminator():
    initializer = tf.random_normal_initializer(0., 0.02)
    inp = tf.keras.layers.Input(shape=[None, None, 3], name='input_image')
    tar = tf.keras.layers.Input(shape=[None, None, 3], name='target_image')
    x = tf.keras.layers.concatenate([inp, tar])  # (batch_size, 256, 256, channels*2)
    down1 = downsample(64, 4, False)(x)  # (batch_size, 128, 128, 64)
    down2 = downsample(128, 4)(down1)  # (batch_size, 64, 64, 128)
    down3 = downsample(256, 4)(down2)  # (batch_size, 32, 32, 256)
    zero_pad1 = tf.keras.layers.ZeroPadding2D()(down3)  # (batch_size, 34, 34, 256)
    conv = tf.keras.layers.Conv2D(512, 4, strides=1, kernel_initializer=initializer, use_bias=False)(zero_pad1)  # (batch_size, 31, 31, 512)
    batchnorm1 = tf.keras.layers.BatchNormalization()(conv)
    leaky_relu = tf.keras.layers.LeakyReLU()(batchnorm1)
    zero_pad2 = tf.keras.layers.ZeroPadding2D()(leaky_relu)  # (batch_size, 33, 33, 512)
    last = tf.keras.layers.Conv2D(1, 4, strides=1, kernel_initializer=initializer)(zero_pad2)  # (batch_size, 30, 30, 1)
    return tf.keras.Model(inputs=[inp, tar], outputs=last)

discriminator = Discriminator()

def discriminator_loss(disc_real_output, disc_generated_output):
    real_loss = loss_object(tf.ones_like(disc_real_output), disc_real_output)
    generated_loss = loss_object(tf.zeros_like(disc_generated_output), disc_generated_output)
    total_disc_loss = real_loss + generated_loss
    return total_disc_loss

generator_optimizer = tf.keras.optimizers.Adam(2e-4, beta_1=0.5)
discriminator_optimizer = tf.keras.optimizers.Adam(2e-4, beta_1=0.5)


# 5. CONTROLLER ..........................................................................................................................................................


#@tf.function
def train_step(input_image, target, step):
    with tf.GradientTape() as gen_tape, tf.GradientTape() as disc_tape:
        gen_output = generator(input_image, training=True)
        disc_real_output = discriminator([input_image, target], training=True)
        disc_generated_output = discriminator([input_image, gen_output], training=True)
        gen_total_loss, gen_gan_loss, gen_l1_loss = generator_loss(disc_generated_output, gen_output, target)
        disc_loss = discriminator_loss(disc_real_output, disc_generated_output)
    generator_gradients = gen_tape.gradient(gen_total_loss, generator.trainable_variables)
    discriminator_gradients = disc_tape.gradient(disc_loss, discriminator.trainable_variables)
    generator_optimizer.apply_gradients(zip(generator_gradients, generator.trainable_variables))
    discriminator_optimizer.apply_gradients(zip(discriminator_gradients, discriminator.trainable_variables))


def draw_image(image, path, name):
    tf.keras.preprocessing.image.save_img(path + "/" + name, image[0])

checkpoint = tf.train.Checkpoint(generator_optimizer=generator_optimizer,
                                 discriminator_optimizer=discriminator_optimizer,
                                 generator=generator,
                                 discriminator=discriminator)

def split_dataset(train_path, target_path, num_test):
    files = os.listdir(train_path)
    train_files = files[num_test:len(files)]
    test_files = files[:num_test]
    train_dataset, test_dataset = create_datasets(train_path, target_path, train_files, test_files)
    unpacked_test_dataset = []
    for element in test_dataset:
        unpacked_test_dataset.append(element)
    return train_dataset, unpacked_test_dataset

def display_images(test_dataset, epoch, temp_path, num_test):
    example_input, example_target = random.choice(test_dataset)
    example_input = generator(example_input, training=True)
    input_name = "image_"+str(epoch)+".png"
    target_name = "target_"+str(epoch)+".png"
    draw_image(example_target, temp_path, target_name)
    draw_image(example_input, temp_path, input_name)

def restore_model(model_path):
    checkpoint.restore(tf.train.latest_checkpoint(model_path))

def save_model(model_path, model_name):
    checkpoint.save(file_prefix=os.path.join(model_path, "ckpt"))
    generator.save(os.path.join(model_path, model_name+".h5"))

def start(train_path, target_path, model_path, model_name, epochs, num_test, display_each, save_each, temp_path, socket = None):
    train_dataset, test_dataset = split_dataset(train_path, target_path, num_test)
    restore_model(model_path)
    epoch = 0
    for step, (input_image, target) in train_dataset.repeat().take(epochs).enumerate():
        train_step(input_image, target, step)
        if socket != None:
            socket.send(bytes(str(epoch+1), "utf-8"))
        else:
            print(epoch+1)
        if epoch % save_each == 0:
            save_model(model_path, model_name)
        if epoch % display_each == 0:
            display_images(test_dataset, epoch, temp_path, num_test)
        epoch += 1
    save_model(model_path, model_name)
