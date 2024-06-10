
namespace GanBuilder
{
    partial class Progress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progress));
            this.cancelButton = new RJCodeAdvance.RJControls.RJButton();
            this.predictedBox = new System.Windows.Forms.PictureBox();
            this.targetBox = new System.Windows.Forms.PictureBox();
            this.predictedLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.epochsLabel = new System.Windows.Forms.Label();
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.watcher = new System.IO.FileSystemWatcher();
            this.barLabel = new System.Windows.Forms.Label();
            this.progressBar = new GanBuilder.controls.CueProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.predictedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // predictedBox
            // 
            this.predictedBox.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.predictedBox, "predictedBox");
            this.predictedBox.Name = "predictedBox";
            this.predictedBox.TabStop = false;
            // 
            // targetBox
            // 
            this.targetBox.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.targetBox, "targetBox");
            this.targetBox.Name = "targetBox";
            this.targetBox.TabStop = false;
            // 
            // predictedLabel
            // 
            resources.ApplyResources(this.predictedLabel, "predictedLabel");
            this.predictedLabel.ForeColor = System.Drawing.Color.White;
            this.predictedLabel.Name = "predictedLabel";
            // 
            // targetLabel
            // 
            resources.ApplyResources(this.targetLabel, "targetLabel");
            this.targetLabel.ForeColor = System.Drawing.Color.White;
            this.targetLabel.Name = "targetLabel";
            // 
            // epochsLabel
            // 
            resources.ApplyResources(this.epochsLabel, "epochsLabel");
            this.epochsLabel.ForeColor = System.Drawing.Color.White;
            this.epochsLabel.Name = "epochsLabel";
            // 
            // icon
            // 
            this.icon.ForeColor = System.Drawing.SystemColors.Control;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.icon.IconColor = System.Drawing.SystemColors.Control;
            this.icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon.IconSize = 67;
            resources.ApplyResources(this.icon, "icon");
            this.icon.Name = "icon";
            this.icon.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.Filter = "*.png";
            this.watcher.SynchronizingObject = this;
            this.watcher.Created += new System.IO.FileSystemEventHandler(this.watcher_Created);
            // 
            // barLabel
            // 
            resources.ApplyResources(this.barLabel, "barLabel");
            this.barLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.barLabel.ForeColor = System.Drawing.Color.White;
            this.barLabel.Name = "barLabel";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Gray;
            this.progressBar.ChannelHeight = 21;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.SliderHeight = 20;
            this.progressBar.Value = 100;
            // 
            // Progress
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.epochsLabel);
            this.Controls.Add(this.predictedLabel);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.predictedBox);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Progress";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Progress_FormClosed);
            this.Load += new System.EventHandler(this.Progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predictedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton cancelButton;
        private System.Windows.Forms.PictureBox predictedBox;
        private System.Windows.Forms.PictureBox targetBox;
        private System.Windows.Forms.Label predictedLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label epochsLabel;
        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Timer timer;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.Label barLabel;
        private controls.CueProgressbar progressBar;
    }
}