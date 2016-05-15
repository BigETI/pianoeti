namespace PianoETI
{
    partial class SoundboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundboardForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.menuStrip.SuspendLayout();
            this.panelMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(668, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileClose});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemFileClose
            // 
            this.toolStripMenuItemFileClose.Name = "toolStripMenuItemFileClose";
            this.toolStripMenuItemFileClose.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemFileClose.Text = "Close";
            this.toolStripMenuItemFileClose.Click += new System.EventHandler(this.toolStripMenuItemFileClose_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemSettings.Text = "Settings";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.toolStripMenuItemSettings_Click);
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.labelPitch);
            this.panelMaster.Controls.Add(this.trackBarPitch);
            this.panelMaster.Controls.Add(this.labelVolume);
            this.panelMaster.Controls.Add(this.trackBarVolume);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMaster.Location = new System.Drawing.Point(548, 24);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(120, 406);
            this.panelMaster.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(548, 406);
            this.panelMain.TabIndex = 4;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.LargeChange = 1;
            this.trackBarVolume.Location = new System.Drawing.Point(12, 27);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 227);
            this.trackBarVolume.TabIndex = 0;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.Location = new System.Drawing.Point(12, 11);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(45, 13);
            this.labelVolume.TabIndex = 1;
            this.labelVolume.Text = "Volume";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPitch
            // 
            this.labelPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPitch.Location = new System.Drawing.Point(63, 11);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(45, 13);
            this.labelPitch.TabIndex = 3;
            this.labelPitch.Text = "Pitch";
            this.labelPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarPitch
            // 
            this.trackBarPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPitch.LargeChange = 1;
            this.trackBarPitch.Location = new System.Drawing.Point(63, 27);
            this.trackBarPitch.Maximum = 100;
            this.trackBarPitch.Minimum = -100;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPitch.Size = new System.Drawing.Size(45, 227);
            this.trackBarPitch.TabIndex = 2;
            this.trackBarPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // SoundboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 430);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMaster);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SoundboardForm";
            this.Text = "Soundboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundboardForm_FormClosed);
            this.Load += new System.EventHandler(this.SoundboardForm_Load);
            this.Shown += new System.EventHandler(this.SoundboardForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileClose;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
    }
}