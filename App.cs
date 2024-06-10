using FontAwesome.Sharp;
using GanBuilder.controls;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static GanBuilder.Theme;
using static GanBuilder.Utils;

namespace GanBuilder
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            getSettings();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 84);
            sidebar.Controls.Add(leftBorderBtn);
            watcher.Path = dirname;
            setTheme();

        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentActivity;
        private string filename = dirname + @"\settings.txt";

        private void App_Load(object sender, EventArgs e)
        {

            correctLabels();
            ActivateButton(trainerTab, Theme.trainer);
            changeActivity(new Trainer());

        }

        private void getSettings()
        {
            string[] settings = System.IO.File.ReadAllLines(filename, Encoding.UTF8);
            if (settings.Length == 3)
            {
                language = (Languages)Int16.Parse(settings[0]);
                theme = (Themes)Int16.Parse(settings[2]);
            }
            else
            {
                getLanguage(Thread.CurrentThread);
            }
            
        }

        private void setTheme()
        {
            getTheme();
            this.BackColor = Theme.background;
            sidebar.BackColor = Theme.sidebar;
            sidebar.ForeColor = Theme.titles;
            logoPanel.BackColor = Theme.sidebar;
            logoPanel.ForeColor = Theme.titles;

            IconButton[] buttons = { trainerTab, artistTab, settingsTab, aboutTab };
            foreach (IconButton button in buttons)
            {
                button.BackColor = Theme.sidebar;
                button.ForeColor = Theme.titles;
                button.IconColor = Theme.titles;
            }

        }

        private void correctLabels()
        {
            if(language == Languages.Spanish)
            {
                this.Text = "GAN Builder - Creado por Monica Cue";
                trainerTab.Text = "Entrenador";
                artistTab.Text = "Artista";
                settingsTab.Text = "Ajustes";
                aboutTab.Text = "Acerca de";
            }
            else
            {
                this.Text = "GAN Builder - Created by Monica Cue";
                trainerTab.Text = "Trainer";
                artistTab.Text = "Artist";
                settingsTab.Text = "Settings";
                aboutTab.Text = "About";
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                Console.WriteLine(senderBtn);
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Theme.sidebar_selected;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Theme.sidebar;
                currentBtn.ForeColor = Theme.titles;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = Theme.titles;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void changeActivity(Form activity)
        {
            
            if (currentActivity != null)
            {
                currentActivity.Close();
            }
            currentActivity = activity;
            activity.TopLevel = false;
            activity.FormBorderStyle = FormBorderStyle.None;
            activity.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(activity);
            contentPanel.Tag = activity;
            activity.BringToFront();
            activity.Show();

            
        }

        private void trainerButton_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Theme.trainer);
            changeActivity(new Trainer());
        }

        private void artistButton_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Theme.artist);
            changeActivity(new Artist());
        }

        private void settingsButton_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Theme.settings);
            changeActivity(new Settings());
        }

        private void aboutButton_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Theme.about);
            changeActivity(new About());
        }


        private void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);
            Thread.Sleep(100);

            try
            {
                if (file.Name == "settings.txt")
                {
                    setTheme();
                    getLanguage(Thread.CurrentThread);
                    correctLabels();
                    ActivateButton(settingsTab, Theme.settings);
                    changeActivity(new Settings());
                }

            }
            catch (IOException)
            {
                Console.WriteLine("Error on IO");
            }
        }
    }
}
