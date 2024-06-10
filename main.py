import os, sys
import time
dirname = os.path.dirname(__file__)

for i in range(100):
    text = "Second " + str(i)
    i += 1
    fp = open(os.path.join(dirname, "numbers.txt"), 'w')
    fp.write(text)
    time.sleep(0.1)
