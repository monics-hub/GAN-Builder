import os, sys
import socket
import pix2pix

dirname = os.path.dirname(__file__)
temp_path = dirname + "/temp/"

architecture = sys.argv[1]
train_path = sys.argv[2]
target_path = sys.argv[3]
model_path = sys.argv[4]
model_name = sys.argv[5]
epochs = int(sys.argv[6])
num_test = int(sys.argv[7])
display_each = int(sys.argv[8])
save_each = int(sys.argv[9])

TCP_IP = '127.0.0.1'
TCP_PORT = 5005
skt = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
skt.connect((TCP_IP, TCP_PORT))
skt.send(b"connected")

pix2pix.start(train_path, target_path, model_path, model_name, epochs, num_test, display_each, save_each, temp_path, skt)
skt.send(b"closed")
skt.close()
