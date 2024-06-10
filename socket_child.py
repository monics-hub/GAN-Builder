import os, sys
import time

def run(socket, epochs):
    for i in range(epochs+1):
        text = str(i)
        socket.send(bytes(text, "utf-8"))
        i += 1
        time.sleep(1)
