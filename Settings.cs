using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static GanBuilder.Utils;
using static GanBuilder.Theme;
using System.Diagnostics;
using FontAwesome.Sharp;
using System.Threading;
using RJCodeAdvance.RJControls;

namespace GanBuilder
{
    public partial class Settings : Form
    {
        private string filename = dirname + @"\settings.txt";
        private Languages selectedLanguage = language;
        private Themes selectedTheme = theme;
        private string[] parameters;

        public Settings()
        {
            getLanguage(Thread.CurrentThread);
            InitializeComponent(); 
            setTheme();
            
        }
        
        private void Settings_Load(object sender, EventArgs e)
        {
            parameters = System.IO.File.ReadAllLines(filename, Encoding.UTF8);
            if (parameters.Length == 3)
            {
                pythonBox.Text = parameters[1];
            }
            else
            {
                pythonBox.Text = "...";
            }

            if(language == Languages.Spanish)
            {
                languageBox.Texts = (string)languageBox.Items[1];

            }
            else if(language == Languages.French)
            {
                languageBox.Texts = (string)languageBox.Items[2];
            }
            else
            {
                languageBox.Texts = (string)languageBox.Items[0];
            }
            
            if(theme == Themes.Light)
            {
                themeBox.Texts = (string)themeBox.Items[1];
            }
            else
            {
                themeBox.Texts = (string)themeBox.Items[0];
            }

        }

        private void setTheme()
        {
            getTheme();
            this.BackColor = Theme.background;
            settingsButton.BackColor = Theme.settings;
            settingsButton.ForeColor = Theme.textButton;
            settingsButton.IconColor = Theme.textButton;
            RJButton[] buttons = { searchButton, librariesButton, environmentButton };
            foreach(RJButton button in buttons)
            {
                button.BackColor = Theme.gray;
                button.ForeColor = Theme.textButton;
            }
            
            pythonBox.BackColor = Theme.inside;
            pythonBox.BorderColor = Theme.highlight;
            pythonBox.BorderFocusColor = Theme.settings;
            pythonBox.ForeColor = Theme.text;
            
            pythonButton.BackColor = Theme.highlight;
            pythonButton.ForeColor = Theme.text;

            Label[] labels = { languageLabel, pythonLabel, themeLabel };
            foreach(Label label in labels)
            {
                label.ForeColor = Theme.text;
            }

            RJComboBox[] boxes = { languageBox, themeBox };
            foreach(RJComboBox box in boxes)
            {
                box.BackColor = Theme.inside;
                box.BorderColor = Theme.highlight;
                box.ForeColor = Theme.text;
            }
        }

        private string searchPython()
        {
            string[] commands = new string[1];
            commands[0] = "where python";
            return executeCommands(commands, false);
        }

        

        private void pythonButton_Click(object sender, EventArgs e)
        {
            setFolder_Box(pythonBrowser, pythonBox);
        }


        private void librariesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dirname + @"\libraries.bat");
            }
            catch (System.Exception err)
            {
                MessageBox.Show("There is an exception: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pythonBox_Enter(object sender, EventArgs e)
        {
            pythonButton.BackColor = Theme.settings;
        }

        private void pythonBox_Leave(object sender, EventArgs e)
        {
            pythonButton.BackColor = Theme.highlight;
        }

        private void languageBox_Enter(object sender, EventArgs e)
        {
            languageBox.BorderColor = Theme.settings;
            languageBox.IconColor = Theme.settings;
        }

        private void languageBox_Leave(object sender, EventArgs e)
        {
            languageBox.BorderColor = Theme.highlight;
            languageBox.IconColor = Theme.highlight;
        }

        private void themeBox_Enter(object sender, EventArgs e)
        {
            themeBox.BorderColor = Theme.settings;
            themeBox.IconColor = Theme.settings;
        }

        private void themeBox_Leave(object sender, EventArgs e)
        {
            themeBox.BorderColor = Theme.highlight;
            themeBox.IconColor = Theme.highlight;
        }

        private void languageBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Thread thread = Thread.CurrentThread;
            switch (languageBox.SelectedIndex)
            {
                case 0:
                    selectedLanguage = Languages.English;
                    break;
                case 1:
                    selectedLanguage = Languages.Spanish;
                    break;
                case 2:
                    selectedLanguage = Languages.French;
                    break;
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            pythonBox.Text = searchPython();
        }

        private void themeBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeBox.SelectedIndex)
            {
                case 0:
                    selectedTheme = Themes.Dark;
                    break;
                case 1:
                    selectedTheme = Themes.Light;
                    break;

            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            language = selectedLanguage;
            theme = selectedTheme;
            if (pythonBox.Text.Contains("?"))
            {
                string message;
                if (language == Languages.Spanish)
                {
                    message = "La ruta de python contiene algunos caracters extraños " +
                        "marcados con un símbolo de '?'. Favor de corregirla manualmente, o de lo contrario " +
                        "ocurrirá un error al tratar de entrenar o utilizar algún modelo.";
                }
                else
                {
                    message = "The python path that we found contains some non-english characters" +
                    " marked with a '?' symbol. Please correct them manually, otherwise there will be an error " +
                    "when trying to train or use models.";
                }
                showMessage(Mstype.Warning, message, "Non-english characters found:");
            }

            else
            {
                parameters[0] = Convert.ToString(languageBox.SelectedIndex);
                parameters[1] = pythonBox.Text;
                parameters[2] = Convert.ToString(themeBox.SelectedIndex);
                saveParameters(filename, parameters);

            }

        }
    }
}
