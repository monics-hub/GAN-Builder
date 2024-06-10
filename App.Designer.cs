
namespace GanBuilder
{
    partial class App
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.sidebar = new System.Windows.Forms.Panel();
            this.aboutTab = new FontAwesome.Sharp.IconButton();
            this.settingsTab = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.artistTab = new FontAwesome.Sharp.IconButton();
            this.trainerTab = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.watcher = new System.IO.FileSystemWatcher();
            this.sidebar.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.sidebar.Controls.Add(this.aboutTab);
            this.sidebar.Controls.Add(this.settingsTab);
            this.sidebar.Controls.Add(this.iconButton3);
            this.sidebar.Controls.Add(this.artistTab);
            this.sidebar.Controls.Add(this.trainerTab);
            this.sidebar.Controls.Add(this.logoPanel);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            // 
            // aboutTab
            // 
            this.aboutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.aboutTab.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.aboutTab, "aboutTab");
            this.aboutTab.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutTab.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.aboutTab.IconColor = System.Drawing.Color.White;
            this.aboutTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.UseVisualStyleBackColor = false;
            this.aboutTab.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.settingsTab.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.settingsTab, "settingsTab");
            this.settingsTab.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsTab.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.settingsTab.IconColor = System.Drawing.Color.White;
            this.settingsTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.UseVisualStyleBackColor = false;
            this.settingsTab.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.iconButton3, "iconButton3");
            this.iconButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // artistTab
            // 
            this.artistTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.artistTab.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.artistTab, "artistTab");
            this.artistTab.ForeColor = System.Drawing.SystemColors.Control;
            this.artistTab.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.artistTab.IconColor = System.Drawing.Color.White;
            this.artistTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.artistTab.Name = "artistTab";
            this.artistTab.UseVisualStyleBackColor = false;
            this.artistTab.Click += new System.EventHandler(this.artistButton_Click);
            // 
            // trainerTab
            // 
            this.trainerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.trainerTab.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.trainerTab, "trainerTab");
            this.trainerTab.ForeColor = System.Drawing.SystemColors.Control;
            this.trainerTab.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.trainerTab.IconColor = System.Drawing.Color.White;
            this.trainerTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trainerTab.Name = "trainerTab";
            this.trainerTab.UseVisualStyleBackColor = false;
            this.trainerTab.Click += new System.EventHandler(this.trainerButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.tabsPanel);
            this.logoPanel.Controls.Add(this.appLogo);
            resources.ApplyResources(this.logoPanel, "logoPanel");
            this.logoPanel.Name = "logoPanel";
            // 
            // tabsPanel
            // 
            resources.ApplyResources(this.tabsPanel, "tabsPanel");
            this.tabsPanel.Name = "tabsPanel";
            // 
            // appLogo
            // 
            resources.ApplyResources(this.appLogo, "appLogo");
            this.appLogo.Name = "appLogo";
            this.appLogo.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Black;
            this.contentPanel.Controls.Add(this.label1);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.Name = "contentPanel";
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.Filter = "*.txt";
            this.watcher.SynchronizingObject = this;
            this.watcher.Changed += new System.IO.FileSystemEventHandler(this.watcher_Changed);
            // 
            // App
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.sidebar.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel tabsPanel;
        private FontAwesome.Sharp.IconButton trainerTab;
        private FontAwesome.Sharp.IconButton aboutTab;
        private FontAwesome.Sharp.IconButton settingsTab;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton artistTab;
        private System.IO.FileSystemWatcher watcher;
    }
}

