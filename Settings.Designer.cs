
using System;

namespace GanBuilder
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pythonBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.searchButton = new RJCodeAdvance.RJControls.RJButton();
            this.librariesButton = new RJCodeAdvance.RJControls.RJButton();
            this.pythonButton = new RJCodeAdvance.RJControls.RJButton();
            this.languageLabel = new System.Windows.Forms.Label();
            this.pythonLabel = new System.Windows.Forms.Label();
            this.languageBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.themeLabel = new System.Windows.Forms.Label();
            this.themeBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.environmentButton = new RJCodeAdvance.RJControls.RJButton();
            this.settingsButton = new GanBuilder.controls.CueButton();
            this.pythonBox = new GanBuilder.controls.CueTextbox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gray;
            this.searchButton.BackgroundColor = System.Drawing.Color.Gray;
            this.searchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchButton.BorderRadius = 20;
            this.searchButton.BorderSize = 0;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Name = "searchButton";
            this.searchButton.TextColor = System.Drawing.Color.White;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // librariesButton
            // 
            this.librariesButton.BackColor = System.Drawing.Color.Gray;
            this.librariesButton.BackgroundColor = System.Drawing.Color.Gray;
            this.librariesButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.librariesButton.BorderRadius = 20;
            this.librariesButton.BorderSize = 0;
            this.librariesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.librariesButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.librariesButton, "librariesButton");
            this.librariesButton.ForeColor = System.Drawing.Color.White;
            this.librariesButton.Name = "librariesButton";
            this.librariesButton.TextColor = System.Drawing.Color.White;
            this.librariesButton.UseVisualStyleBackColor = false;
            this.librariesButton.Click += new System.EventHandler(this.librariesButton_Click);
            // 
            // pythonButton
            // 
            this.pythonButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pythonButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pythonButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pythonButton.BorderRadius = 5;
            this.pythonButton.BorderSize = 0;
            this.pythonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pythonButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.pythonButton, "pythonButton");
            this.pythonButton.ForeColor = System.Drawing.Color.White;
            this.pythonButton.Name = "pythonButton";
            this.pythonButton.TextColor = System.Drawing.Color.White;
            this.pythonButton.UseVisualStyleBackColor = false;
            this.pythonButton.Click += new System.EventHandler(this.pythonButton_Click);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.languageLabel.Name = "languageLabel";
            // 
            // pythonLabel
            // 
            resources.ApplyResources(this.pythonLabel, "pythonLabel");
            this.pythonLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.pythonLabel.Name = "pythonLabel";
            // 
            // languageBox
            // 
            this.languageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.languageBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.languageBox.BorderSize = 1;
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            resources.ApplyResources(this.languageBox, "languageBox");
            this.languageBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.languageBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.languageBox.Items.AddRange(new object[] {
            resources.GetString("languageBox.Items"),
            resources.GetString("languageBox.Items1"),
            resources.GetString("languageBox.Items2")});
            this.languageBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.languageBox.ListTextColor = System.Drawing.Color.DimGray;
            this.languageBox.Name = "languageBox";
            this.languageBox.Texts = "English / Ingles";
            this.languageBox.OnSelectedIndexChanged += new System.EventHandler(this.languageBox_OnSelectedIndexChanged);
            this.languageBox.Enter += new System.EventHandler(this.languageBox_Enter);
            this.languageBox.Leave += new System.EventHandler(this.languageBox_Leave);
            // 
            // themeLabel
            // 
            resources.ApplyResources(this.themeLabel, "themeLabel");
            this.themeLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.themeLabel.Name = "themeLabel";
            // 
            // themeBox
            // 
            this.themeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.themeBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.themeBox.BorderSize = 1;
            this.themeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            resources.ApplyResources(this.themeBox, "themeBox");
            this.themeBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.themeBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.themeBox.Items.AddRange(new object[] {
            resources.GetString("themeBox.Items"),
            resources.GetString("themeBox.Items1")});
            this.themeBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.themeBox.ListTextColor = System.Drawing.Color.DimGray;
            this.themeBox.Name = "themeBox";
            this.themeBox.Texts = "PurpleDark";
            this.themeBox.OnSelectedIndexChanged += new System.EventHandler(this.themeBox_OnSelectedIndexChanged);
            this.themeBox.Enter += new System.EventHandler(this.themeBox_Enter);
            this.themeBox.Leave += new System.EventHandler(this.themeBox_Leave);
            // 
            // environmentButton
            // 
            this.environmentButton.BackColor = System.Drawing.Color.Gray;
            this.environmentButton.BackgroundColor = System.Drawing.Color.Gray;
            this.environmentButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.environmentButton.BorderRadius = 20;
            this.environmentButton.BorderSize = 0;
            this.environmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.environmentButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.environmentButton, "environmentButton");
            this.environmentButton.ForeColor = System.Drawing.Color.White;
            this.environmentButton.Name = "environmentButton";
            this.environmentButton.TextColor = System.Drawing.Color.White;
            this.environmentButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.settingsButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.settingsButton.BorderRadius = 20;
            this.settingsButton.BorderSize = 0;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.settingsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 40;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.TextColor = System.Drawing.Color.White;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pythonBox
            // 
            this.pythonBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.pythonBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pythonBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pythonBox.BorderRadius = 10;
            this.pythonBox.BorderSize = 1;
            resources.ApplyResources(this.pythonBox, "pythonBox");
            this.pythonBox.ForeColor = System.Drawing.Color.White;
            this.pythonBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.pythonBox.HintFont = null;
            this.pythonBox.HintForegroundColor = System.Drawing.Color.White;
            this.pythonBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.pythonBox.HintText = "...";
            this.pythonBox.Multiline = false;
            this.pythonBox.Name = "pythonBox";
            this.pythonBox.PasswordChar = false;
            this.pythonBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pythonBox.PlaceholderText = "";
            this.pythonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pythonBox.UnderlinedStyle = false;
            this.pythonBox.Enter += new System.EventHandler(this.pythonBox_Enter);
            this.pythonBox.Leave += new System.EventHandler(this.pythonBox_Leave);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.themeBox);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.pythonLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.pythonButton);
            this.Controls.Add(this.pythonBox);
            this.Controls.Add(this.environmentButton);
            this.Controls.Add(this.librariesButton);
            this.Controls.Add(this.searchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.FolderBrowserDialog pythonBrowser;
        private RJCodeAdvance.RJControls.RJButton searchButton;
        private RJCodeAdvance.RJControls.RJButton librariesButton;
        private controls.CueTextbox pythonBox;
        private RJCodeAdvance.RJControls.RJButton pythonButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label pythonLabel;
        private RJCodeAdvance.RJControls.RJComboBox languageBox;
        private System.Windows.Forms.Label themeLabel;
        private RJCodeAdvance.RJControls.RJComboBox themeBox;
        private RJCodeAdvance.RJControls.RJButton environmentButton;
        private controls.CueButton settingsButton;
    }
}