import os, sys
import socket
import time
import random
import shutil

architecture = sys.argv[1]
train_path = sys.argv[2]
target_path = sys.argv[3]
model_path = sys.argv[4]
epochs = int(sys.argv[5])
dirname = os.path.dirname(__file__)
temp_path = dirname + "/temp/"

TCP_IP = '127.0.0.1'
TCP_PORT = 5005
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((TCP_IP, TCP_PORT))

def send_picture():
    images = os.listdir(target_path)
    item = random.choice(images)
    origin = target_path + "/" + item
    destination = temp_path + "/" + item
    shutil.copy(origin, destination)

for i in range(epochs+1):
    text = str(i)
    s.send(bytes(text, "utf-8"))
    if (i % 10 == 0):
        send_picture()
    time.sleep(1)

s.send(b"<end>")
s.close()
