import os, sys
import socket
#import pix2pix

dirname = os.path.dirname(__file__)
temp_path = dirname + "/temp/"

train_path = "C:/Users/Monica/Documents/Datasets/Pets/blurred10"
target_path = "C:/Users/Monica/Documents/Datasets/Pets/target"
model_path = "C:/Users/Monica/Documents/Datasets/Pets"
model_name = "model"
epochs = 1000
num_test = 3
display_each = 10
save_each = 1000

#pix2pix.start(train_path, target_path, model_path, model_name, epochs, num_test, display_each, save_each, temp_path)
files = os.listdir(train_path)
for i in range(10):
    print(files[i])
