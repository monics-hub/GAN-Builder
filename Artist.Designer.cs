
namespace GanBuilder
{
    partial class Artist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artist));
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.testBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.modelButton = new RJCodeAdvance.RJControls.RJButton();
            this.testButton = new RJCodeAdvance.RJControls.RJButton();
            this.outputButton = new RJCodeAdvance.RJControls.RJButton();
            this.testLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.radioButton1 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.writeButton = new RJCodeAdvance.RJControls.RJButton();
            this.writeLabel = new System.Windows.Forms.Label();
            this.artistButton = new GanBuilder.controls.CueButton();
            this.outputBox = new GanBuilder.controls.CueTextbox();
            this.testBox = new GanBuilder.controls.CueTextbox();
            this.modelBox = new GanBuilder.controls.CueTextbox();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            resources.ApplyResources(this.modelLabel, "modelLabel");
            this.modelLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.modelLabel.Name = "modelLabel";
            // 
            // modelButton
            // 
            this.modelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.modelButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.modelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.modelButton.BorderRadius = 5;
            this.modelButton.BorderSize = 0;
            this.modelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modelButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.modelButton, "modelButton");
            this.modelButton.ForeColor = System.Drawing.Color.White;
            this.modelButton.Name = "modelButton";
            this.modelButton.TextColor = System.Drawing.Color.White;
            this.modelButton.UseVisualStyleBackColor = false;
            this.modelButton.Click += new System.EventHandler(this.modelButton_Click);
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.testButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.testButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.testButton.BorderRadius = 5;
            this.testButton.BorderSize = 0;
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.testButton, "testButton");
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.Name = "testButton";
            this.testButton.TextColor = System.Drawing.Color.White;
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.outputButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.outputButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.outputButton.BorderRadius = 5;
            this.outputButton.BorderSize = 0;
            this.outputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.outputButton, "outputButton");
            this.outputButton.ForeColor = System.Drawing.Color.White;
            this.outputButton.Name = "outputButton";
            this.outputButton.TextColor = System.Drawing.Color.White;
            this.outputButton.UseVisualStyleBackColor = false;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // testLabel
            // 
            resources.ApplyResources(this.testLabel, "testLabel");
            this.testLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.testLabel.Name = "testLabel";
            // 
            // outputLabel
            // 
            resources.ApplyResources(this.outputLabel, "outputLabel");
            this.outputLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.outputLabel.Name = "outputLabel";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.writeButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.writeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.writeButton.BorderRadius = 20;
            this.writeButton.BorderSize = 0;
            this.writeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.writeButton, "writeButton");
            this.writeButton.ForeColor = System.Drawing.Color.White;
            this.writeButton.Name = "writeButton";
            this.writeButton.TextColor = System.Drawing.Color.White;
            this.writeButton.UseVisualStyleBackColor = false;
            // 
            // writeLabel
            // 
            resources.ApplyResources(this.writeLabel, "writeLabel");
            this.writeLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.writeLabel.Name = "writeLabel";
            // 
            // artistButton
            // 
            this.artistButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.artistButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.artistButton.BorderRadius = 20;
            this.artistButton.BorderSize = 0;
            this.artistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.artistButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.artistButton, "artistButton");
            this.artistButton.ForeColor = System.Drawing.Color.White;
            this.artistButton.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.artistButton.IconColor = System.Drawing.Color.AliceBlue;
            this.artistButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.artistButton.IconSize = 40;
            this.artistButton.Name = "artistButton";
            this.artistButton.TextColor = System.Drawing.Color.White;
            this.artistButton.UseVisualStyleBackColor = false;
            this.artistButton.Click += new System.EventHandler(this.artistButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.outputBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.outputBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.outputBox.BorderRadius = 10;
            this.outputBox.BorderSize = 1;
            resources.ApplyResources(this.outputBox, "outputBox");
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.outputBox.HintFont = null;
            this.outputBox.HintForegroundColor = System.Drawing.Color.White;
            this.outputBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.outputBox.HintText = "...";
            this.outputBox.Multiline = false;
            this.outputBox.Name = "outputBox";
            this.outputBox.PasswordChar = false;
            this.outputBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.outputBox.PlaceholderText = "";
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.outputBox.UnderlinedStyle = false;
            this.outputBox._TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            this.outputBox.Enter += new System.EventHandler(this.outputBox_Enter);
            this.outputBox.Leave += new System.EventHandler(this.outputBox_Leave);
            // 
            // testBox
            // 
            this.testBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.testBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.testBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.testBox.BorderRadius = 10;
            this.testBox.BorderSize = 1;
            resources.ApplyResources(this.testBox, "testBox");
            this.testBox.ForeColor = System.Drawing.Color.White;
            this.testBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.testBox.HintFont = null;
            this.testBox.HintForegroundColor = System.Drawing.Color.White;
            this.testBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.testBox.HintText = "...";
            this.testBox.Multiline = false;
            this.testBox.Name = "testBox";
            this.testBox.PasswordChar = false;
            this.testBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.testBox.PlaceholderText = "";
            this.testBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.testBox.UnderlinedStyle = false;
            this.testBox._TextChanged += new System.EventHandler(this.testBox_TextChanged);
            this.testBox.Enter += new System.EventHandler(this.testBox_Enter);
            this.testBox.Leave += new System.EventHandler(this.testBox_Leave);
            // 
            // modelBox
            // 
            this.modelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.modelBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.modelBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.modelBox.BorderRadius = 10;
            this.modelBox.BorderSize = 1;
            resources.ApplyResources(this.modelBox, "modelBox");
            this.modelBox.ForeColor = System.Drawing.Color.White;
            this.modelBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.modelBox.HintFont = null;
            this.modelBox.HintForegroundColor = System.Drawing.Color.White;
            this.modelBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.modelBox.HintText = "...";
            this.modelBox.Multiline = false;
            this.modelBox.Name = "modelBox";
            this.modelBox.PasswordChar = false;
            this.modelBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modelBox.PlaceholderText = "";
            this.modelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.modelBox.UnderlinedStyle = false;
            this.modelBox._TextChanged += new System.EventHandler(this.modelBox_TextChanged);
            this.modelBox.Enter += new System.EventHandler(this.modelBox_Enter);
            this.modelBox.Leave += new System.EventHandler(this.modelBox_Leave);
            // 
            // Artist
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.artistButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.writeLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.modelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Artist";
            this.Load += new System.EventHandler(this.Artist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.FolderBrowserDialog modelBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog testBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog outputBrowserDialog;
        private controls.CueTextbox modelBox;
        private controls.CueTextbox testBox;
        private controls.CueTextbox outputBox;
        private RJCodeAdvance.RJControls.RJButton modelButton;
        private RJCodeAdvance.RJControls.RJButton testButton;
        private RJCodeAdvance.RJControls.RJButton outputButton;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label outputLabel;
        private RJCodeAdvance.RJControls.RJRadioButton radioButton2;
        private RJCodeAdvance.RJControls.RJRadioButton radioButton1;
        private RJCodeAdvance.RJControls.RJButton writeButton;
        private System.Windows.Forms.Label writeLabel;
        private controls.CueButton artistButton;
    }
}