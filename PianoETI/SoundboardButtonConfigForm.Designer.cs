namespace PianoETI
{
    partial class SoundboardButtonConfigForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelLoadFile = new System.Windows.Forms.Label();
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.labelLoadFileFileName = new System.Windows.Forms.Label();
            this.groupBoxPitch = new System.Windows.Forms.GroupBox();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonClick = new System.Windows.Forms.RadioButton();
            this.radioButtonToggle = new System.Windows.Forms.RadioButton();
            this.radioButtonModePressOnly = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revertToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonStopTest = new System.Windows.Forms.Button();
            this.numericUpDownNumerator = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDivisor = new System.Windows.Forms.NumericUpDown();
            this.labelFraction = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.groupBoxVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.groupBoxPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            this.groupBoxMode.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisor)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "WAV (*.wav)|*.wav";
            this.openFileDialog.InitialDirectory = "./soundeffects/";
            // 
            // labelLoadFile
            // 
            this.labelLoadFile.AutoSize = true;
            this.labelLoadFile.Location = new System.Drawing.Point(12, 15);
            this.labelLoadFile.Name = "labelLoadFile";
            this.labelLoadFile.Size = new System.Drawing.Size(48, 13);
            this.labelLoadFile.TabIndex = 0;
            this.labelLoadFile.Text = "WAV file";
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVolume.Controls.Add(this.trackBarVolume);
            this.groupBoxVolume.Location = new System.Drawing.Point(12, 38);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(433, 70);
            this.groupBoxVolume.TabIndex = 3;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "Volume";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarVolume.Location = new System.Drawing.Point(3, 16);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(427, 51);
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(66, 10);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(30, 23);
            this.buttonLoadFile.TabIndex = 4;
            this.buttonLoadFile.Text = "...";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // labelLoadFileFileName
            // 
            this.labelLoadFileFileName.AutoSize = true;
            this.labelLoadFileFileName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelLoadFileFileName.Location = new System.Drawing.Point(102, 15);
            this.labelLoadFileFileName.Name = "labelLoadFileFileName";
            this.labelLoadFileFileName.Size = new System.Drawing.Size(63, 13);
            this.labelLoadFileFileName.TabIndex = 5;
            this.labelLoadFileFileName.Text = "undefined...";
            // 
            // groupBoxPitch
            // 
            this.groupBoxPitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPitch.Controls.Add(this.trackBarPitch);
            this.groupBoxPitch.Location = new System.Drawing.Point(12, 114);
            this.groupBoxPitch.Name = "groupBoxPitch";
            this.groupBoxPitch.Size = new System.Drawing.Size(433, 70);
            this.groupBoxPitch.TabIndex = 6;
            this.groupBoxPitch.TabStop = false;
            this.groupBoxPitch.Text = "Pitch";
            // 
            // trackBarPitch
            // 
            this.trackBarPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarPitch.Location = new System.Drawing.Point(3, 16);
            this.trackBarPitch.Maximum = 100;
            this.trackBarPitch.Minimum = -100;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.Size = new System.Drawing.Size(427, 51);
            this.trackBarPitch.TabIndex = 3;
            this.trackBarPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarPitch.ValueChanged += new System.EventHandler(this.trackBarPitch_ValueChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMode.Controls.Add(this.radioButtonClick);
            this.groupBoxMode.Controls.Add(this.radioButtonToggle);
            this.groupBoxMode.Controls.Add(this.radioButtonModePressOnly);
            this.groupBoxMode.Location = new System.Drawing.Point(12, 190);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(433, 42);
            this.groupBoxMode.TabIndex = 8;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // radioButtonClick
            // 
            this.radioButtonClick.AutoSize = true;
            this.radioButtonClick.Location = new System.Drawing.Point(207, 19);
            this.radioButtonClick.Name = "radioButtonClick";
            this.radioButtonClick.Size = new System.Drawing.Size(77, 17);
            this.radioButtonClick.TabIndex = 10;
            this.radioButtonClick.Text = "Click mode";
            this.radioButtonClick.UseVisualStyleBackColor = true;
            this.radioButtonClick.Click += new System.EventHandler(this.radioButtonModeGeneric_Click);
            // 
            // radioButtonToggle
            // 
            this.radioButtonToggle.AutoSize = true;
            this.radioButtonToggle.Location = new System.Drawing.Point(114, 19);
            this.radioButtonToggle.Name = "radioButtonToggle";
            this.radioButtonToggle.Size = new System.Drawing.Size(87, 17);
            this.radioButtonToggle.TabIndex = 9;
            this.radioButtonToggle.Text = "Toggle mode";
            this.radioButtonToggle.UseVisualStyleBackColor = true;
            this.radioButtonToggle.Click += new System.EventHandler(this.radioButtonModeGeneric_Click);
            // 
            // radioButtonModePressOnly
            // 
            this.radioButtonModePressOnly.AutoSize = true;
            this.radioButtonModePressOnly.Checked = true;
            this.radioButtonModePressOnly.Location = new System.Drawing.Point(6, 19);
            this.radioButtonModePressOnly.Name = "radioButtonModePressOnly";
            this.radioButtonModePressOnly.Size = new System.Drawing.Size(102, 17);
            this.radioButtonModePressOnly.TabIndex = 8;
            this.radioButtonModePressOnly.TabStop = true;
            this.radioButtonModePressOnly.Text = "Press only mode";
            this.radioButtonModePressOnly.UseVisualStyleBackColor = true;
            this.radioButtonModePressOnly.Click += new System.EventHandler(this.radioButtonModeGeneric_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revertToDefaultToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(162, 26);
            // 
            // revertToDefaultToolStripMenuItem
            // 
            this.revertToDefaultToolStripMenuItem.Name = "revertToDefaultToolStripMenuItem";
            this.revertToDefaultToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.revertToDefaultToolStripMenuItem.Text = "Revert to default";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 366);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(111, 366);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(334, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(12, 238);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(86, 17);
            this.checkBoxLoop.TabIndex = 12;
            this.checkBoxLoop.Text = "Enable Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartTest.Location = new System.Drawing.Point(12, 287);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(433, 23);
            this.buttonStartTest.TabIndex = 13;
            this.buttonStartTest.Text = "Test";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // buttonStopTest
            // 
            this.buttonStopTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopTest.Location = new System.Drawing.Point(12, 316);
            this.buttonStopTest.Name = "buttonStopTest";
            this.buttonStopTest.Size = new System.Drawing.Size(433, 23);
            this.buttonStopTest.TabIndex = 14;
            this.buttonStopTest.Text = "Stop";
            this.buttonStopTest.UseVisualStyleBackColor = true;
            this.buttonStopTest.Click += new System.EventHandler(this.buttonStopTest_Click);
            // 
            // numericUpDownNumerator
            // 
            this.numericUpDownNumerator.Location = new System.Drawing.Point(60, 261);
            this.numericUpDownNumerator.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNumerator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumerator.Name = "numericUpDownNumerator";
            this.numericUpDownNumerator.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownNumerator.TabIndex = 15;
            this.numericUpDownNumerator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumerator.ValueChanged += new System.EventHandler(this.numericUpDownNumerator_ValueChanged);
            // 
            // numericUpDownDivisor
            // 
            this.numericUpDownDivisor.Location = new System.Drawing.Point(124, 261);
            this.numericUpDownDivisor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDivisor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDivisor.Name = "numericUpDownDivisor";
            this.numericUpDownDivisor.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownDivisor.TabIndex = 16;
            this.numericUpDownDivisor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDivisor.ValueChanged += new System.EventHandler(this.numericUpDownDivisor_ValueChanged);
            // 
            // labelFraction
            // 
            this.labelFraction.AutoSize = true;
            this.labelFraction.Location = new System.Drawing.Point(9, 263);
            this.labelFraction.Name = "labelFraction";
            this.labelFraction.Size = new System.Drawing.Size(45, 13);
            this.labelFraction.TabIndex = 17;
            this.labelFraction.Text = "Fraction";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Location = new System.Drawing.Point(106, 263);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(12, 13);
            this.labelSlash.TabIndex = 18;
            this.labelSlash.Text = "/";
            // 
            // SoundboardButtonConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 401);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.labelFraction);
            this.Controls.Add(this.numericUpDownDivisor);
            this.Controls.Add(this.numericUpDownNumerator);
            this.Controls.Add(this.buttonStopTest);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.checkBoxLoop);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.groupBoxPitch);
            this.Controls.Add(this.labelLoadFileFileName);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.groupBoxVolume);
            this.Controls.Add(this.labelLoadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SoundboardButtonConfigForm";
            this.Text = "Configurate soundboard button";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundboardButtonConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.SoundboardButtonConfigForm_Load);
            this.Shown += new System.EventHandler(this.SoundboardButtonConfigForm_Shown);
            this.groupBoxVolume.ResumeLayout(false);
            this.groupBoxVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.groupBoxPitch.ResumeLayout(false);
            this.groupBoxPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelLoadFile;
        private System.Windows.Forms.GroupBox groupBoxVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label labelLoadFileFileName;
        private System.Windows.Forms.GroupBox groupBoxPitch;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonClick;
        private System.Windows.Forms.RadioButton radioButtonToggle;
        private System.Windows.Forms.RadioButton radioButtonModePressOnly;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem revertToDefaultToolStripMenuItem;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.Button buttonStopTest;
        private System.Windows.Forms.NumericUpDown numericUpDownNumerator;
        private System.Windows.Forms.NumericUpDown numericUpDownDivisor;
        private System.Windows.Forms.Label labelFraction;
        private System.Windows.Forms.Label labelSlash;
    }
}