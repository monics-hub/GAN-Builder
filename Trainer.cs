using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;
using static GanBuilder.Utils;
using static GanBuilder.Theme;
using System.Threading;
using GanBuilder.controls;
using RJCodeAdvance.RJControls;

namespace GanBuilder
{
    public partial class Trainer : Form
    {
        private string filename = dirname + @"\trainer_parameters.txt";
        private string[] parameters;
        private int epochs;
        private int testImagesValue;
        private int imageEachValue;
        private int saveEachValue;
        private int maxTestImages = 20;

        public Trainer()
        {
            getLanguage(Thread.CurrentThread);
            InitializeComponent();
            setTheme();
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            parameters = System.IO.File.ReadAllLines(filename, Encoding.UTF8);
            int p0 = Int16.Parse(parameters[0]);
            architectureBox.Texts = (string)architectureBox.Items[p0];
            imagesBox.Text = parameters[1];
            targetBox.Text = parameters[2];
            modelBox.Text = parameters[3];
            nameBox.Text = parameters[4];
            epochsBox.Text = parameters[5];
            testBox.Text = parameters[6];
            imageEachBox.Text = parameters[7];
            saveEachBox.Text = parameters[8];
        }
            
        private void setTheme()
        {
            getTheme();
            this.BackColor = Theme.background;
            writeButton.BackColor = Theme.highlight;
            writeButton.ForeColor = Theme.textButton;
            trainButton.BackColor = Theme.trainer;
            trainButton.ForeColor = Theme.textButton;
            trainButton.IconColor = Theme.textButton;
            
            CueTextbox[] textboxes = { imagesBox, targetBox, modelBox, nameBox, epochsBox, testBox, 
                                        imageEachBox, saveEachBox };

            foreach(CueTextbox box in textboxes)
            {
                box.BackColor = Theme.inside;
                box.BorderColor = Theme.highlight;
                box.BorderFocusColor = Theme.trainer;
                box.HintBackgroundColor = Theme.trainer;
                box.ForeColor = Theme.text;
            }

            architectureBox.BackColor = Theme.inside;
            architectureBox.BorderColor = Theme.highlight;
            architectureBox.ForeColor = Theme.text;

            RJButton[] buttons = { imagesButton, targetButton, modelButton };
            foreach(RJButton button in buttons)
            {
                button.BackColor = Theme.highlight;
                button.ForeColor = Theme.text;
            }

            Label[] labels = {architectureLabel, trainLabel, targetLabel, modelLabel, nameLabel,
                                epochsLabel, testLabel, imageEachLabel, saveEachLabel, writeLabel};
            foreach(Label label in labels)
            {
                label.ForeColor = Theme.text;
            }

            RJRadioButton[] radios = { radioButton1, radioButton2 };
            foreach(RJRadioButton radio in radios)
            {
                radio.ForeColor = Theme.text;
            }
        }

        private void trainBox_TextChanged(object sender, EventArgs e)
        {
            parameters[1] = imagesBox.Text;
        }

        private void targetBox_TextChanged(object sender, EventArgs e)
        {
            parameters[2] = targetBox.Text;
        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {
            parameters[3] = modelBox.Text;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            parameters[4] = nameBox.Text;
        }

        private void epochsBox_TextChanged(object sender, EventArgs e)
        {
            parameters[5] = epochsBox.Text;
        }

        private void testBox_TextChanged(object sender, EventArgs e)
        {
            parameters[6] = testBox.Text;
        }

        private void imageEachBox_TextChanged(object sender, EventArgs e)
        {
            parameters[7] = imageEachBox.Text;
        }

        private void saveEachBox_TextChanged(object sender, EventArgs e)
        {
            parameters[8] = saveEachBox.Text;
        }

        private void imagesButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(trainBrowserDialog, imagesBox);
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(targetBrowserDialog, targetBox);
        }


        private void modelButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(modelBrowserDialog, modelBox);
        }

        private void trainBox_Enter(object sender, EventArgs e)
        {
            imagesButton.BackColor = Theme.trainer;
        }

        private void trainBox_Leave(object sender, EventArgs e)
        {
            imagesButton.BackColor = Theme.highlight;
        }

        private void targetBox_Enter(object sender, EventArgs e)
        {
            targetButton.BackColor = Theme.trainer;
        }

        private void targetBox_Leave(object sender, EventArgs e)
        {
            targetButton.BackColor = Theme.highlight;
        }

        private void modelBox_Enter(object sender, EventArgs e)
        {
            modelButton.BackColor = Theme.trainer;
        }

        private void modelBox_Leave(object sender, EventArgs e)
        {
            modelButton.BackColor = Theme.highlight;
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            modelButton.BackColor = Theme.trainer;
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            modelButton.BackColor = Theme.highlight;
        }

        private void architectureBox_Enter(object sender, EventArgs e)
        {
            architectureBox.BorderColor = Theme.trainer;
            architectureBox.IconColor = Theme.trainer;
        }

        private void architectureBox_Leave(object sender, EventArgs e)
        {
            architectureBox.BorderColor = Theme.highlight;
            architectureBox.IconColor = Theme.highlight;
        }

        private int getFolderFiles(string path, string name = "*.jpg")
        {
            try
            {
                string[] jpgFiles = Directory.GetFiles(path, name);
                return jpgFiles.Length;
            }
            catch
            {
                return -1;
            }
            
        }

        private void startTraining()
        {
            int trainImages = 0;
            int targetImages = 0;
            int modelExists = 0;

            while (true)
            {
                //try to access images path: make sure it contain jpg files
                trainImages = getFolderFiles(parameters[1]);
                if (trainImages == -1)
                {
                    string exception = "The train images path isn't correct or dosen't exist. To continue please correct " +
                        "it manually.";
                    showMessage(Mstype.Warning, exception, "Missing path: ");
                    break;
                }

                //try to access target path
                targetImages = getFolderFiles(parameters[2]);
                if (targetImages == -1)
                {
                    string exception = "The target images path isn't correct or dosen't exist. Check it again";
                    showMessage(Mstype.Warning, exception, "Missing path: ");
                    break;
                }

                //make sure the number of jpg files is the same in both folders
                if (trainImages != targetImages)
                {
                    string exception = "The number of jpg files in train and target paths is not the same. Please correct them!";
                    showMessage(Mstype.Warning, exception, "Images don't match: ");
                    break;
                }

                // try to access the model path and check whether or not the model file exists
                modelExists = getFolderFiles(parameters[3], parameters[4]);
                if(modelExists == -1)
                {
                    string exception = "The model path isn't correct or dosen't exist. Check it again";
                    showMessage(Mstype.Warning, exception, "Missing path: ");
                    break;
                }

                //make sure imageEach and saveEach values are less than the total number epochs
                try
                {
                    epochs = Int16.Parse(parameters[5]);
                    testImagesValue = Int16.Parse(parameters[6]);
                    imageEachValue = Int16.Parse(parameters[7]);
                    saveEachValue = Int16.Parse(parameters[8]);
                }
                catch
                {
                    string exception = "One of the numerical boxes contain non numerical values. Please correct them";
                    showMessage(Mstype.Warning, exception, "Non numerical values: ");
                    break;
                }
                if(imageEachValue > epochs | saveEachValue > epochs)
                {
                    string exception = "Display image each box or save image each box values are bigger than the number of epochs. They must be lesser. Please correct them";
                    showMessage(Mstype.Warning, exception, "Nonsence values detected: ");
                    break;
                }

                // make sure the number of test images is not bigger than the number of total images
                if(testImagesValue >= trainImages)
                {
                    string exception = "There could not be more test images than the total numeber of images";
                    showMessage(Mstype.Warning, exception, "Nonsence values detected: ");
                    break;
                }
                else if(testImagesValue > maxTestImages)
                {
                    string exception = "The number number of test images could not be bigger than 20!";
                    showMessage(Mstype.Warning, exception, "Too many test images: ");
                    break;
                }

                break;
      
            }

        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            saveParameters(filename, parameters);
            clearFolder(imgPath);
            startTraining();
            try
            {
                runServer("trainer", parameters);
                new Progress(epochs).Show();
                
            }
            catch
            {
                string exception = "The model cannot train because the server connection with " +
                "python script failed. Please check the python path is correct. If it is, make sure 'settings.txt'" +
                "is avaible for use. If it is, make sure the python file 'trainer.py' is correct." +
                "If it is, please contact the developer. Thanks.";
                showMessage(Mstype.Error, exception, "The model cannot be trained:");
                
            }
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            saveParameters(filename, parameters);
        }
    }
}
