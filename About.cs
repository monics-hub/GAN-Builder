using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GanBuilder.Utils;
using static GanBuilder.Theme;
using GanBuilder.controls;
using System.IO;
using System.Diagnostics;

namespace GanBuilder
{
    public partial class About : Form
    {   
        private CueProgressbar[] bars = new CueProgressbar[8];
        private int[] values = { 100, 80, 90, 40, 50, 90, 70, 60 };

        public About()
        {
            getLanguage(Thread.CurrentThread);
            InitializeComponent();
            setTheme();
            colorText();
            
        }

        private void About_Load(object sender, EventArgs e)
        {
            timer.Start();
            bars[0] = mathBar;
            bars[1] = tensorflowBar;
            bars[2] = pandasBar;
            bars[3] = numpyBar;
            bars[4] = mathplotlibBar;
            bars[5] = pythonBar;
            bars[6] = csBar;
            bars[7] = javaBar;

            foreach (CueProgressbar bar in bars)
            {
                bar.Value = 0;
            }

            pictureBox.Load(dirname + @"\resources\developer_photo.jpg");
        }

        private void setTheme()
        {
            getTheme();
            this.BackColor = Theme.background;
            Color ideColor = Color.FromArgb(40, 44, 70);
            ide.BackColor = ideColor;
            idePanel.BackColor = ideColor;
            slogan.BackColor = Theme.background;
            slogan.ForeColor = Theme.text;
            executeButton.BackColor = Theme.gray;
            executeButton.ForeColor = Theme.textButton;
            aboutButton.BackColor = Theme.about;
            aboutButton.ForeColor = Theme.textButton;
            aboutButton.IconColor = Theme.textButton;
            Label[] labels = {nameLabel, mathLabel, tensorflowLabel, pandasLabel,
                                numpyLabel, mathplotlibLabel, pythonLabel, csLabel, javaLabel};
            foreach(Label label in labels)
            {
                label.ForeColor = Theme.text;
            }
        }

        private void colorText()
        {
            //getting keywords, functions
            string keywords = @"\b(and|as|assert|break|class|continue|def|del|elif|else|except|finally|for|from|global|if|import|in|is|
                                lambda|nonlocal|not|or|pass|raise|return|try|while|with|yield)\b";
            MatchCollection keywordMatches = Regex.Matches(ide.Text, keywords);

            //getting special characters
            string characters = @"\=|\+|\-|\*|\/";
            MatchCollection charactersMatches = Regex.Matches(ide.Text, characters);

            //getting integers
            string numbers = "[0-9]|True|False";
            MatchCollection numbersMatches = Regex.Matches(ide.Text, numbers);

            //getting methods
            string methods = @"(?<=(\.| )).*?(?=\()";
            MatchCollection methodsMatches = Regex.Matches(ide.Text, methods);

            // getting special methods
            string spMethods = @"\b(print|len|long|int|__init__|append|range)\b";
            MatchCollection spMethodsMatches = Regex.Matches(ide.Text, spMethods);

            //getting comments
            string comments = @"#.+";
            MatchCollection commentMatches = Regex.Matches(ide.Text, comments);

            //getting strings
            string strings = "\".+\"";
            MatchCollection stringMatches = Regex.Matches(ide.Text, strings);

            //saving original carret position + forecolor
            int originalIndex = ide.SelectionStart;
            int originalLenght = ide.SelectionLength;
            Color originalColor = Color.LightGray;

            //removes any previous highlighting
            ide.SelectionStart = 0;
            ide.SelectionLength = ide.Text.Length;
            ide.SelectionColor = originalColor;

            //scanning ...
            foreach (Match m in methodsMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.DodgerBlue;
            }
            foreach (Match m in spMethodsMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.FromArgb(83, 172, 183);
            }
            
            foreach (Match m in numbersMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.DarkOrange;
            }
            foreach (Match m in commentMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.Gray;
            }
            foreach (Match m in stringMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.FromArgb(130, 166, 108);
            }

            foreach (Match m in keywordMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.DarkOrchid;
            }

            foreach (Match m in charactersMatches)
            {
                ide.SelectionStart = m.Index;
                ide.SelectionLength = m.Length;
                ide.SelectionColor = Color.DarkOrchid;
            }

            //restoring the original colors, for further writting
            ide.SelectionStart = originalIndex;
            ide.SelectionLength = originalLenght;
            ide.SelectionColor = originalColor;

            //giving back the focus
            ide.Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            byte index = 0;
            foreach(CueProgressbar bar in bars)
            {
                if(bar.Value < values[index])
                {
                    bar.Value++;
                }
                index++;
            }
            
        }

        private void ide_KeyUp(object sender, KeyEventArgs e)
        {
            ideTimer.Stop();
            ideTimer.Start();
        }

        private void ideTimer_Tick(object sender, EventArgs e)
        {
            colorText();
            ideTimer.Stop();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string file = dirname + @"\ide.py";
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (string i in ide.Lines)
                {
                    outputFile.WriteLine(i);
                }
            }

            Thread.Sleep(100);

            try
            {
                Process.Start(dirname + @"\ide.bat");
                Console.WriteLine("Correct");
            }
            catch (System.Exception err)
            {
                MessageBox.Show("There is an exception: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("WRONG");
            }
        }
    }
}
