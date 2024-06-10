import tensorflow as tf
import os
import pathlib
import time
import datetime
from keras.models import load_model
from matplotlib import pyplot as plt

BATCH_SIZE = 1
IMG_WIDTH = 256
IMG_HEIGHT = 256

def load(image_file):
    image = tf.io.read_file(image_file)
    image = tf.image.decode_jpeg(image, 3)
    image = tf.cast(image, tf.float32)
    return image

def resize(input_image, height, width):
    input_image = tf.image.resize(input_image, [height, width], method=tf.image.ResizeMethod.NEAREST_NEIGHBOR)
    return input_image

def normalize(input_image):
    input_image = (input_image / 127.5) - 1
    return input_image

def load_image(image_file):
    input_image = load(input_path + "/" + image_file)
    input_image = resize(input_image, IMG_HEIGHT, IMG_WIDTH)
    input_image = normalize(input_image)
    return input_image

def generate_images(model, test_input, filename):
    prediction = model(test_input, training=True)
    tf.keras.preprocessing.image.save_img(output_path + "/" + filename, prediction[0])


index = 0
keras_model = load_model(os.path.join(project_path, "generator.h5"))
for input in user_dataset.take(len(user_files)):
    generate_images(keras_model, input, user_files[index])
    index +=1
