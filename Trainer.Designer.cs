
namespace GanBuilder
{
    partial class Trainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            this.modelLabel = new System.Windows.Forms.Label();
            this.architectureLabel = new System.Windows.Forms.Label();
            this.epochsLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.trainLabel = new System.Windows.Forms.Label();
            this.iconFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.projectBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.trainBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkpointsBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.modelBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.modelButton = new RJCodeAdvance.RJControls.RJButton();
            this.targetButton = new RJCodeAdvance.RJControls.RJButton();
            this.imagesButton = new RJCodeAdvance.RJControls.RJButton();
            this.imageEachLabel = new System.Windows.Forms.Label();
            this.architectureBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.radioButton1 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.radioButton2 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.writeLabel = new System.Windows.Forms.Label();
            this.saveEachLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.nameBox = new GanBuilder.controls.CueTextbox();
            this.saveEachBox = new GanBuilder.controls.CueTextbox();
            this.imageEachBox = new GanBuilder.controls.CueTextbox();
            this.testBox = new GanBuilder.controls.CueTextbox();
            this.epochsBox = new GanBuilder.controls.CueTextbox();
            this.modelBox = new GanBuilder.controls.CueTextbox();
            this.targetBox = new GanBuilder.controls.CueTextbox();
            this.imagesBox = new GanBuilder.controls.CueTextbox();
            this.trainButton = new GanBuilder.controls.CueButton();
            this.writeButton = new GanBuilder.controls.CueButton();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            resources.ApplyResources(this.modelLabel, "modelLabel");
            this.modelLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.modelLabel.Name = "modelLabel";
            // 
            // architectureLabel
            // 
            resources.ApplyResources(this.architectureLabel, "architectureLabel");
            this.architectureLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.architectureLabel.Name = "architectureLabel";
            // 
            // epochsLabel
            // 
            resources.ApplyResources(this.epochsLabel, "epochsLabel");
            this.epochsLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.epochsLabel.Name = "epochsLabel";
            // 
            // targetLabel
            // 
            resources.ApplyResources(this.targetLabel, "targetLabel");
            this.targetLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.targetLabel.Name = "targetLabel";
            // 
            // trainLabel
            // 
            resources.ApplyResources(this.trainLabel, "trainLabel");
            this.trainLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.trainLabel.Name = "trainLabel";
            // 
            // iconFileDialog
            // 
            this.iconFileDialog.FileName = "my_image.ico";
            resources.ApplyResources(this.iconFileDialog, "iconFileDialog");
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "image.jpg";
            resources.ApplyResources(this.imageFileDialog, "imageFileDialog");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
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
            // targetButton
            // 
            this.targetButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.targetButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.targetButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.targetButton.BorderRadius = 5;
            this.targetButton.BorderSize = 0;
            this.targetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.targetButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.targetButton, "targetButton");
            this.targetButton.ForeColor = System.Drawing.Color.White;
            this.targetButton.Name = "targetButton";
            this.targetButton.TextColor = System.Drawing.Color.White;
            this.targetButton.UseVisualStyleBackColor = false;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // imagesButton
            // 
            this.imagesButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.imagesButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.imagesButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.imagesButton.BorderRadius = 5;
            this.imagesButton.BorderSize = 0;
            this.imagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagesButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.imagesButton, "imagesButton");
            this.imagesButton.ForeColor = System.Drawing.Color.White;
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.TextColor = System.Drawing.Color.White;
            this.imagesButton.UseVisualStyleBackColor = false;
            this.imagesButton.Click += new System.EventHandler(this.imagesButton_Click);
            // 
            // imageEachLabel
            // 
            resources.ApplyResources(this.imageEachLabel, "imageEachLabel");
            this.imageEachLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.imageEachLabel.Name = "imageEachLabel";
            // 
            // architectureBox
            // 
            this.architectureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.architectureBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.architectureBox.BorderSize = 1;
            this.architectureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            resources.ApplyResources(this.architectureBox, "architectureBox");
            this.architectureBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.architectureBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.architectureBox.Items.AddRange(new object[] {
            resources.GetString("architectureBox.Items"),
            resources.GetString("architectureBox.Items1")});
            this.architectureBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.architectureBox.ListTextColor = System.Drawing.Color.DimGray;
            this.architectureBox.Name = "architectureBox";
            this.architectureBox.Texts = "One to one";
            this.architectureBox.Enter += new System.EventHandler(this.architectureBox_Enter);
            this.architectureBox.Leave += new System.EventHandler(this.architectureBox_Leave);
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
            // writeLabel
            // 
            resources.ApplyResources(this.writeLabel, "writeLabel");
            this.writeLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.writeLabel.Name = "writeLabel";
            // 
            // saveEachLabel
            // 
            resources.ApplyResources(this.saveEachLabel, "saveEachLabel");
            this.saveEachLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.saveEachLabel.Name = "saveEachLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.nameLabel.Name = "nameLabel";
            // 
            // testLabel
            // 
            resources.ApplyResources(this.testLabel, "testLabel");
            this.testLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.testLabel.Name = "testLabel";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.nameBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameBox.BorderRadius = 10;
            this.nameBox.BorderSize = 1;
            resources.ApplyResources(this.nameBox, "nameBox");
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.nameBox.HintFont = null;
            this.nameBox.HintForegroundColor = System.Drawing.Color.White;
            this.nameBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.nameBox.HintText = "...";
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = false;
            this.nameBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameBox.PlaceholderText = "";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameBox.UnderlinedStyle = false;
            this.nameBox._TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // saveEachBox
            // 
            this.saveEachBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.saveEachBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.saveEachBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.saveEachBox.BorderRadius = 10;
            this.saveEachBox.BorderSize = 1;
            resources.ApplyResources(this.saveEachBox, "saveEachBox");
            this.saveEachBox.ForeColor = System.Drawing.Color.White;
            this.saveEachBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.saveEachBox.HintFont = null;
            this.saveEachBox.HintForegroundColor = System.Drawing.Color.White;
            this.saveEachBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.saveEachBox.HintText = "...";
            this.saveEachBox.Multiline = false;
            this.saveEachBox.Name = "saveEachBox";
            this.saveEachBox.PasswordChar = false;
            this.saveEachBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.saveEachBox.PlaceholderText = "";
            this.saveEachBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveEachBox.UnderlinedStyle = false;
            this.saveEachBox._TextChanged += new System.EventHandler(this.saveEachBox_TextChanged);
            // 
            // imageEachBox
            // 
            this.imageEachBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.imageEachBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.imageEachBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.imageEachBox.BorderRadius = 10;
            this.imageEachBox.BorderSize = 1;
            resources.ApplyResources(this.imageEachBox, "imageEachBox");
            this.imageEachBox.ForeColor = System.Drawing.Color.White;
            this.imageEachBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.imageEachBox.HintFont = null;
            this.imageEachBox.HintForegroundColor = System.Drawing.Color.White;
            this.imageEachBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.imageEachBox.HintText = "...";
            this.imageEachBox.Multiline = false;
            this.imageEachBox.Name = "imageEachBox";
            this.imageEachBox.PasswordChar = false;
            this.imageEachBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.imageEachBox.PlaceholderText = "";
            this.imageEachBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.imageEachBox.UnderlinedStyle = false;
            this.imageEachBox._TextChanged += new System.EventHandler(this.imageEachBox_TextChanged);
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
            // 
            // epochsBox
            // 
            this.epochsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.epochsBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.epochsBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.epochsBox.BorderRadius = 10;
            this.epochsBox.BorderSize = 1;
            resources.ApplyResources(this.epochsBox, "epochsBox");
            this.epochsBox.ForeColor = System.Drawing.Color.White;
            this.epochsBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.epochsBox.HintFont = null;
            this.epochsBox.HintForegroundColor = System.Drawing.Color.White;
            this.epochsBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.epochsBox.HintText = "...";
            this.epochsBox.Multiline = false;
            this.epochsBox.Name = "epochsBox";
            this.epochsBox.PasswordChar = false;
            this.epochsBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.epochsBox.PlaceholderText = "";
            this.epochsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.epochsBox.UnderlinedStyle = false;
            this.epochsBox._TextChanged += new System.EventHandler(this.epochsBox_TextChanged);
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
            // targetBox
            // 
            this.targetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.targetBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.targetBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.targetBox.BorderRadius = 10;
            this.targetBox.BorderSize = 1;
            resources.ApplyResources(this.targetBox, "targetBox");
            this.targetBox.ForeColor = System.Drawing.Color.White;
            this.targetBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.targetBox.HintFont = null;
            this.targetBox.HintForegroundColor = System.Drawing.Color.White;
            this.targetBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.targetBox.HintText = "...";
            this.targetBox.Multiline = false;
            this.targetBox.Name = "targetBox";
            this.targetBox.PasswordChar = false;
            this.targetBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.targetBox.PlaceholderText = "";
            this.targetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.targetBox.UnderlinedStyle = false;
            this.targetBox._TextChanged += new System.EventHandler(this.targetBox_TextChanged);
            this.targetBox.Enter += new System.EventHandler(this.targetBox_Enter);
            this.targetBox.Leave += new System.EventHandler(this.targetBox_Leave);
            // 
            // imagesBox
            // 
            this.imagesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.imagesBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.imagesBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.imagesBox.BorderRadius = 10;
            this.imagesBox.BorderSize = 1;
            resources.ApplyResources(this.imagesBox, "imagesBox");
            this.imagesBox.ForeColor = System.Drawing.Color.White;
            this.imagesBox.HintBackgroundColor = System.Drawing.Color.AliceBlue;
            this.imagesBox.HintFont = null;
            this.imagesBox.HintForegroundColor = System.Drawing.Color.White;
            this.imagesBox.HintStyle1 = GanBuilder.controls.CueTextbox.HintStyle.Invisible;
            this.imagesBox.HintText = "...";
            this.imagesBox.Multiline = false;
            this.imagesBox.Name = "imagesBox";
            this.imagesBox.PasswordChar = false;
            this.imagesBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.imagesBox.PlaceholderText = "";
            this.imagesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.imagesBox.UnderlinedStyle = false;
            this.imagesBox._TextChanged += new System.EventHandler(this.trainBox_TextChanged);
            this.imagesBox.Enter += new System.EventHandler(this.trainBox_Enter);
            this.imagesBox.Leave += new System.EventHandler(this.trainBox_Leave);
            // 
            // trainButton
            // 
            this.trainButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.trainButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.trainButton.BorderRadius = 20;
            this.trainButton.BorderSize = 0;
            this.trainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.trainButton, "trainButton");
            this.trainButton.ForeColor = System.Drawing.Color.White;
            this.trainButton.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.trainButton.IconColor = System.Drawing.Color.AliceBlue;
            this.trainButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trainButton.Name = "trainButton";
            this.trainButton.TextColor = System.Drawing.Color.White;
            this.trainButton.UseVisualStyleBackColor = false;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.writeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.writeButton.BorderRadius = 20;
            this.writeButton.BorderSize = 0;
            this.writeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.writeButton, "writeButton");
            this.writeButton.ForeColor = System.Drawing.Color.White;
            this.writeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.writeButton.IconColor = System.Drawing.Color.Black;
            this.writeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.writeButton.Name = "writeButton";
            this.writeButton.TextColor = System.Drawing.Color.White;
            this.writeButton.UseVisualStyleBackColor = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // Trainer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.saveEachBox);
            this.Controls.Add(this.imageEachBox);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.epochsBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.imagesBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.architectureBox);
            this.Controls.Add(this.imagesButton);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.imageEachLabel);
            this.Controls.Add(this.architectureLabel);
            this.Controls.Add(this.saveEachLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.writeLabel);
            this.Controls.Add(this.epochsLabel);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.trainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainer";
            this.Load += new System.EventHandler(this.Trainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label architectureLabel;
        private System.Windows.Forms.Label epochsLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label trainLabel;
        private System.Windows.Forms.OpenFileDialog iconFileDialog;
        private System.Windows.Forms.FolderBrowserDialog projectBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog trainBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog targetBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog checkpointsBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog modelBrowserDialog;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
        private System.Windows.Forms.Timer timer;
        private RJCodeAdvance.RJControls.RJButton modelButton;
        private RJCodeAdvance.RJControls.RJButton targetButton;
        private RJCodeAdvance.RJControls.RJButton imagesButton;
        private System.Windows.Forms.Label imageEachLabel;
        private RJCodeAdvance.RJControls.RJComboBox architectureBox;
        private RJCodeAdvance.RJControls.RJRadioButton radioButton1;
        private RJCodeAdvance.RJControls.RJRadioButton radioButton2;
        private System.Windows.Forms.Label writeLabel;
        private System.Windows.Forms.Label saveEachLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label testLabel;
        private controls.CueTextbox imagesBox;
        private controls.CueTextbox targetBox;
        private controls.CueTextbox modelBox;
        private controls.CueTextbox nameBox;
        private controls.CueTextbox epochsBox;
        private controls.CueTextbox testBox;
        private controls.CueTextbox imageEachBox;
        private controls.CueTextbox saveEachBox;
        private controls.CueButton trainButton;
        private controls.CueButton writeButton;
    }
}