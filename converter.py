import os
from PIL import Image, ImageFilter
images_path = "C:/Users/Mónica Emmanuelle/Documents/Datasets/Flickr/target/"
save_path = "C:/Users/Mónica Emmanuelle/Documents/Datasets/Flickr/blurred/"
files = os.listdir(images_path)

for name in files:
    image = Image.open(images_path+name)
    gaussImage = image.filter(ImageFilter.GaussianBlur(10))
    gaussImage.save(save_path+name)
