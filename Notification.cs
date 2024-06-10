using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GanBuilder.Theme;

namespace GanBuilder
{
    public partial class Notification : Form
    {
        private Color color;
        public Notification(alertType type, string message, string windowTitle = null, int destroy = 0)
        {
            InitializeComponent();
            switch (type)
            {
                case alertType.success:
                    title.Text = "Success!";
                    color = Color.SeaGreen;
                    icon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    break;

                case alertType.info:
                    title.Text = "Info:";
                    color = Color.SteelBlue;
                    icon.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                    break;

                case alertType.warning:
                    title.Text = "Warning!";
                    color = Color.Goldenrod;
                    icon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    break;

                case alertType.error:
                    title.Text = "Error!";
                    color = Color.Crimson;
                    icon.IconChar = FontAwesome.Sharp.IconChar.Bug;
                    break;
            }

            textBox.Text = message;
            if (windowTitle != null)
            {
                this.Text = windowTitle;
            }
            else
            {
                this.Text = title.Text;
            }
            this.BackColor = Theme.sidebar;
            icon.IconColor = color;
            title.ForeColor = color;
            textBox.ForeColor = Theme.titles;
            icon.BackColor = this.BackColor;
            textBox.BackColor = this.BackColor;
            if (destroy != 0)
            {
                timer.Interval = destroy;
                timer.Start();
            }
        }

        public enum alertType{success, info, warning, error}

        private void notification_Load(object sender, EventArgs e)
        {
            this.Left += 100;
            title.Left = (this.Width - title.Width) / 2;
            setTextBoxHeight();
            this.Height = textBox.Height + 180;
            acceptButton.Top = this.Height - acceptButton.Height - 50;
        }

        private void setTextBoxHeight()
        {
            int characterHeight = 20;
            int charactersPerLine = 35;
            int numberOfLines = textBox.Text.Length / charactersPerLine;
            if (textBox.Text.Length > charactersPerLine)
            {
                textBox.Height = numberOfLines * characterHeight;
            }
            else 
            { 
                textBox.Height = characterHeight; 
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
