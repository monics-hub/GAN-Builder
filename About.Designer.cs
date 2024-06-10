
namespace GanBuilder
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slogan = new System.Windows.Forms.TextBox();
            this.mathLabel = new System.Windows.Forms.Label();
            this.tensorflowLabel = new System.Windows.Forms.Label();
            this.pandasLabel = new System.Windows.Forms.Label();
            this.pythonLabel = new System.Windows.Forms.Label();
            this.csLabel = new System.Windows.Forms.Label();
            this.mathplotlibLabel = new System.Windows.Forms.Label();
            this.javaLabel = new System.Windows.Forms.Label();
            this.numpyLabel = new System.Windows.Forms.Label();
            this.ide = new System.Windows.Forms.RichTextBox();
            this.idePanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.javaBar = new GanBuilder.controls.CueProgressbar();
            this.csBar = new GanBuilder.controls.CueProgressbar();
            this.pythonBar = new GanBuilder.controls.CueProgressbar();
            this.mathplotlibBar = new GanBuilder.controls.CueProgressbar();
            this.numpyBar = new GanBuilder.controls.CueProgressbar();
            this.pandasBar = new GanBuilder.controls.CueProgressbar();
            this.tensorflowBar = new GanBuilder.controls.CueProgressbar();
            this.mathBar = new GanBuilder.controls.CueProgressbar();
            this.aboutButton = new GanBuilder.controls.CueButton();
            this.executeButton = new GanBuilder.controls.CueButton();
            this.ideTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.idePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBox.BorderSize = 2;
            this.pictureBox.GradientAngle = 50F;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.nameLabel.Name = "nameLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            // 
            // slogan
            // 
            this.slogan.BackColor = System.Drawing.Color.Black;
            this.slogan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.slogan, "slogan");
            this.slogan.ForeColor = System.Drawing.Color.LightGray;
            this.slogan.Name = "slogan";
            // 
            // mathLabel
            // 
            resources.ApplyResources(this.mathLabel, "mathLabel");
            this.mathLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.mathLabel.Name = "mathLabel";
            // 
            // tensorflowLabel
            // 
            resources.ApplyResources(this.tensorflowLabel, "tensorflowLabel");
            this.tensorflowLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.tensorflowLabel.Name = "tensorflowLabel";
            // 
            // pandasLabel
            // 
            resources.ApplyResources(this.pandasLabel, "pandasLabel");
            this.pandasLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.pandasLabel.Name = "pandasLabel";
            // 
            // pythonLabel
            // 
            resources.ApplyResources(this.pythonLabel, "pythonLabel");
            this.pythonLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.pythonLabel.Name = "pythonLabel";
            // 
            // csLabel
            // 
            resources.ApplyResources(this.csLabel, "csLabel");
            this.csLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.csLabel.Name = "csLabel";
            // 
            // mathplotlibLabel
            // 
            resources.ApplyResources(this.mathplotlibLabel, "mathplotlibLabel");
            this.mathplotlibLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.mathplotlibLabel.Name = "mathplotlibLabel";
            // 
            // javaLabel
            // 
            resources.ApplyResources(this.javaLabel, "javaLabel");
            this.javaLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.javaLabel.Name = "javaLabel";
            // 
            // numpyLabel
            // 
            resources.ApplyResources(this.numpyLabel, "numpyLabel");
            this.numpyLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.numpyLabel.Name = "numpyLabel";
            // 
            // ide
            // 
            this.ide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.ide, "ide");
            this.ide.ForeColor = System.Drawing.Color.White;
            this.ide.Name = "ide";
            this.ide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ide_KeyUp);
            // 
            // idePanel
            // 
            this.idePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.idePanel.Controls.Add(this.ide);
            resources.ApplyResources(this.idePanel, "idePanel");
            this.idePanel.Name = "idePanel";
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // javaBar
            // 
            this.javaBar.BackColor = System.Drawing.Color.Gray;
            this.javaBar.ChannelHeight = 12;
            resources.ApplyResources(this.javaBar, "javaBar");
            this.javaBar.Name = "javaBar";
            this.javaBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.javaBar.SliderHeight = 20;
            this.javaBar.Value = 60;
            // 
            // csBar
            // 
            this.csBar.BackColor = System.Drawing.Color.Gray;
            this.csBar.ChannelHeight = 12;
            resources.ApplyResources(this.csBar, "csBar");
            this.csBar.Name = "csBar";
            this.csBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.csBar.SliderHeight = 20;
            this.csBar.Value = 70;
            // 
            // pythonBar
            // 
            this.pythonBar.BackColor = System.Drawing.Color.Gray;
            this.pythonBar.ChannelHeight = 12;
            resources.ApplyResources(this.pythonBar, "pythonBar");
            this.pythonBar.Name = "pythonBar";
            this.pythonBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.pythonBar.SliderHeight = 20;
            this.pythonBar.Value = 90;
            // 
            // mathplotlibBar
            // 
            this.mathplotlibBar.BackColor = System.Drawing.Color.Gray;
            this.mathplotlibBar.ChannelHeight = 12;
            resources.ApplyResources(this.mathplotlibBar, "mathplotlibBar");
            this.mathplotlibBar.Name = "mathplotlibBar";
            this.mathplotlibBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.mathplotlibBar.SliderHeight = 20;
            this.mathplotlibBar.Value = 50;
            // 
            // numpyBar
            // 
            this.numpyBar.BackColor = System.Drawing.Color.Gray;
            this.numpyBar.ChannelHeight = 12;
            resources.ApplyResources(this.numpyBar, "numpyBar");
            this.numpyBar.Name = "numpyBar";
            this.numpyBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.numpyBar.SliderHeight = 20;
            this.numpyBar.Value = 40;
            // 
            // pandasBar
            // 
            this.pandasBar.BackColor = System.Drawing.Color.Gray;
            this.pandasBar.ChannelHeight = 12;
            resources.ApplyResources(this.pandasBar, "pandasBar");
            this.pandasBar.Name = "pandasBar";
            this.pandasBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.pandasBar.SliderHeight = 20;
            this.pandasBar.Value = 90;
            // 
            // tensorflowBar
            // 
            this.tensorflowBar.BackColor = System.Drawing.Color.Gray;
            this.tensorflowBar.ChannelHeight = 12;
            resources.ApplyResources(this.tensorflowBar, "tensorflowBar");
            this.tensorflowBar.Name = "tensorflowBar";
            this.tensorflowBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.tensorflowBar.SliderHeight = 20;
            this.tensorflowBar.Value = 80;
            // 
            // mathBar
            // 
            this.mathBar.BackColor = System.Drawing.Color.Gray;
            this.mathBar.ChannelHeight = 12;
            resources.ApplyResources(this.mathBar, "mathBar");
            this.mathBar.Name = "mathBar";
            this.mathBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.mathBar.SliderHeight = 20;
            this.mathBar.Value = 100;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.aboutButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aboutButton.BorderRadius = 20;
            this.aboutButton.BorderSize = 0;
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.aboutButton.IconColor = System.Drawing.Color.AliceBlue;
            this.aboutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.TextColor = System.Drawing.Color.White;
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.Gray;
            this.executeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.executeButton.BorderRadius = 20;
            this.executeButton.BorderSize = 0;
            this.executeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.executeButton, "executeButton");
            this.executeButton.ForeColor = System.Drawing.Color.White;
            this.executeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.executeButton.IconColor = System.Drawing.Color.Black;
            this.executeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.executeButton.Name = "executeButton";
            this.executeButton.TextColor = System.Drawing.Color.White;
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // ideTimer
            // 
            this.ideTimer.Interval = 3000;
            this.ideTimer.Tick += new System.EventHandler(this.ideTimer_Tick);
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.javaBar);
            this.Controls.Add(this.csBar);
            this.Controls.Add(this.pythonBar);
            this.Controls.Add(this.mathplotlibBar);
            this.Controls.Add(this.numpyBar);
            this.Controls.Add(this.pandasBar);
            this.Controls.Add(this.tensorflowBar);
            this.Controls.Add(this.mathBar);
            this.Controls.Add(this.idePanel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tensorflowLabel);
            this.Controls.Add(this.numpyLabel);
            this.Controls.Add(this.mathplotlibLabel);
            this.Controls.Add(this.csLabel);
            this.Controls.Add(this.javaLabel);
            this.Controls.Add(this.pythonLabel);
            this.Controls.Add(this.pandasLabel);
            this.Controls.Add(this.mathLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.slogan);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.idePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox pictureBox;
        private controls.CueButton executeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox slogan;
        private System.Windows.Forms.Label mathLabel;
        private System.Windows.Forms.Label tensorflowLabel;
        private System.Windows.Forms.Label pandasLabel;
        private System.Windows.Forms.Label pythonLabel;
        private System.Windows.Forms.Label csLabel;
        private System.Windows.Forms.Label mathplotlibLabel;
        private System.Windows.Forms.Label javaLabel;
        private System.Windows.Forms.Label numpyLabel;
        private controls.CueButton aboutButton;
        private System.Windows.Forms.RichTextBox ide;
        private System.Windows.Forms.Panel idePanel;
        private controls.CueProgressbar mathBar;
        private controls.CueProgressbar tensorflowBar;
        private controls.CueProgressbar pandasBar;
        private controls.CueProgressbar numpyBar;
        private controls.CueProgressbar mathplotlibBar;
        private controls.CueProgressbar pythonBar;
        private controls.CueProgressbar csBar;
        private controls.CueProgressbar javaBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer ideTimer;
    }
}