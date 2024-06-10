import os, sys
dirname = os.path.dirname(__file__)
architecture = sys.argv[1]
model_path = sys.argv[2]
test_path = sys.argv[3]
output_path = sys.argv[4]

fp = open(os.path.join(dirname, "my_name2.txt"), 'w')
fp.write("Monica")
fp.close()
