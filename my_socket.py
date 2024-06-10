import os, sys
import socket
import time
import socket_child

epochs = int(sys.argv[1])
TCP_IP = '127.0.0.1'
TCP_PORT = 5005
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((TCP_IP, TCP_PORT))

socket_child.run(s, epochs)

s.send(b"<end>")
s.close()
