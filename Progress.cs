using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GanBuilder.Utils;
using static GanBuilder.Theme;
using System.Threading;

namespace GanBuilder
{
    public partial class Progress : Form
    {
        private int epochs;
        public Progress(int epochs)
        {
            getLanguage(Thread.CurrentThread);
            InitializeComponent();
            setTheme();
            this.epochs = epochs;
            
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            watcher.Path = imgPath;
            timer.Start();

        }

        private void setTheme()
        {
            getTheme();
            this.BackColor = Theme.background;
            cancelButton.ForeColor = Theme.titles;
            cancelButton.BackColor = Theme.gray;
            predictedBox.BackColor = Theme.inside;
            targetBox.BackColor = Theme.inside;
            progressBar.BackColor = Theme.inside;
            Color forecolor = Theme.text;
            icon.BackColor = this.BackColor;
            icon.ForeColor = forecolor;
            predictedLabel.ForeColor = forecolor;
            targetLabel.ForeColor = forecolor;
            epochsLabel.ForeColor = forecolor;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int step = 0;
            try
            {
                step = Int16.Parse(serverMessage);
            }
            catch(FormatException)
            {
                string exception = "The server sends an non numerical value that is not captured. " +
                    "Contact the developer.";
                showMessage(Mstype.Error, exception, "Non numerical value exception: ");
                this.Close();
            }

            if (step == -1)
            {
                string message = "C# correctly connect with python. The AI training process will start now."; 
                showMessage(Mstype.Success, message, "Connection stablished:", 5000);
                serverMessage = "0";
            }

            else
            {
                epochsLabel.Text = step + " / " + epochs + " Epochs";
                progressBar.Value = step * 100 / epochs;
                barLabel.Text = progressBar.Value + "%";
            }
            
            if (step == epochs) 
            {
                if(language == Languages.Spanish)
                {
                    cancelButton.Text = "CERRAR";
                }
                else
                {
                    cancelButton.Text = "EXIT";
                }
                showMessage(Mstype.Success, "The model was correctly trained.", "Output:");
            }
        }

        private void Progress_FormClosed(object sender, FormClosedEventArgs e)
        {
            serverRunning = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }

        private void watcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);
            System.Threading.Thread.Sleep(100);

            try
            {

                if (file.Name.StartsWith("t"))
                {
                    targetBox.Load(imgPath + file.Name);
                }
                else 
                {
                    predictedBox.Load(imgPath + file.Name);
                }
                
            }
            catch
            {
                string exception = "The trained process image cannot be correctly capture. Check 'progress.cs'" +
                    "or contact the developer.";
                showMessage(Mstype.Error, exception, "File system watcher exception:");
                this.Close();
            }
        }
    }
}
