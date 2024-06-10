
namespace GanBuilder
{
    partial class Notification
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
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.title = new System.Windows.Forms.Label();
            this.acceptButton = new GanBuilder.controls.CueButton();
            this.textBox = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.ForeColor = System.Drawing.SystemColors.Control;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.icon.IconColor = System.Drawing.SystemColors.Control;
            this.icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon.IconSize = 52;
            this.icon.Location = new System.Drawing.Point(16, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(53, 52);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(132, 12);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(122, 33);
            this.title.TabIndex = 1;
            this.title.Text = "Warning!";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Gray;
            this.acceptButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.acceptButton.BorderRadius = 20;
            this.acceptButton.BorderSize = 0;
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.acceptButton.IconColor = System.Drawing.Color.Black;
            this.acceptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acceptButton.Location = new System.Drawing.Point(115, 162);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(150, 40);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.TextColor = System.Drawing.Color.White;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(16, 67);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(350, 31);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "message";
            this.textBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(378, 214);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notification";
            this.Load += new System.EventHandler(this.notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label title;
        private controls.CueButton acceptButton;
        private System.Windows.Forms.Label textBox;
        private System.Windows.Forms.Timer timer;
    }
}