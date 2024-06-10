using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GanBuilder.Utils;
using static GanBuilder.Theme;
using System.Threading;
using GanBuilder.controls;
using RJCodeAdvance.RJControls;

namespace GanBuilder
{
    public partial class Artist : Form
    {
        private string filename = dirname + @"\artist_parameters.txt";
        private string[] parameters;
        public Artist()
        {
            getLanguage(Thread.CurrentThread);
            InitializeComponent();
            setTheme();
        }

        
        private void Artist_Load(object sender, EventArgs e)
        {
            try
            {
                parameters = System.IO.File.ReadAllLines(filename, Encoding.UTF8);
                modelBox.Text = parameters[1];
                testBox.Text = parameters[2];
                outputBox.Text = parameters[3];
            }
            catch
            {
                MessageBox.Show("IO Error");
            }

        }

        private void setTheme()
        {
            getTheme();
            this.BackColor = Theme.background;
            artistButton.BackColor = Theme.artist;
            artistButton.ForeColor = Theme.textButton;
            artistButton.IconColor = Theme.textButton;
            writeButton.BackColor = Theme.highlight;
            writeButton.ForeColor = Theme.textButton;

            CueTextbox[] boxes = { modelBox, testBox, outputBox };
            foreach(CueTextbox box in boxes)
            {
                box.BackColor = Theme.inside;
                box.BorderColor = Theme.highlight;
                box.BorderFocusColor = Theme.artist;
                box.ForeColor = Theme.text;
            }
            RJButton[] buttons = { modelButton, testButton, outputButton };
            foreach(RJButton button in buttons)
            {
                button.BackColor = Theme.highlight;
            }

            Label[] labels = { modelLabel, testLabel, outputLabel, writeLabel };
            foreach(Label label in labels)
            {
                label.ForeColor = Theme.text;
            }
            RJRadioButton[] radios = { radioButton1, radioButton2 };
            foreach (RadioButton radio in radios)
            {
                radio.ForeColor = Theme.text;
            }
        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {
            parameters[1] = modelBox.Text;
        }

        private void testBox_TextChanged(object sender, EventArgs e)
        {
            parameters[2] = testBox.Text;
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            parameters[3] = outputBox.Text;
        }

        private void modelButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(modelBrowserDialog, modelBox);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(testBrowserDialog, testBox);
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(outputBrowserDialog, outputBox);
        }

        private void modelBox_Enter(object sender, EventArgs e)
        {
            modelButton.BackColor = Theme.artist;
        }

        private void modelBox_Leave(object sender, EventArgs e)
        {
            modelButton.BackColor = Theme.highlight;
        }

        private void testBox_Enter(object sender, EventArgs e)
        {
            testButton.BackColor = Theme.artist;
        }

        private void testBox_Leave(object sender, EventArgs e)
        {
            testButton.BackColor = Theme.highlight;
        }

        private void outputBox_Enter(object sender, EventArgs e)
        {
            outputButton.BackColor = Theme.artist;
        }

        private void outputBox_Leave(object sender, EventArgs e)
        {
            outputButton.BackColor = Theme.highlight;
        }
        private void artistButton_Click(object sender, EventArgs e)
        {
            saveParameters(filename, parameters);
            runScript("artist", parameters);
        }

    }
}
