namespace PianoETI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPiano = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoLowest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoLower = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoLow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoHigher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewPianoHighest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewSoundboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSoundboardNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSoundboardSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSelectPiano = new System.Windows.Forms.GroupBox();
            this.buttonHighestPiano = new System.Windows.Forms.Button();
            this.buttonHigherPiano = new System.Windows.Forms.Button();
            this.buttonHighPiano = new System.Windows.Forms.Button();
            this.buttonMediumPiano = new System.Windows.Forms.Button();
            this.buttonLowPiano = new System.Windows.Forms.Button();
            this.buttonLowerPiano = new System.Windows.Forms.Button();
            this.buttonLowestPiano = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonRefreshFilesList = new System.Windows.Forms.Button();
            this.buttonLoadSoundboard = new System.Windows.Forms.Button();
            this.buttonCreateNewSoundboard = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.groupBoxSelectPiano.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItemFileExit.Text = "Exit";
            this.toolStripMenuItemFileExit.Click += new System.EventHandler(this.toolStripMenuItemFileExit_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewPiano,
            this.toolStripMenuItemViewSoundboard});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemViewPiano
            // 
            this.toolStripMenuItemViewPiano.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewPianoLowest,
            this.toolStripMenuItemViewPianoLower,
            this.toolStripMenuItemViewPianoLow,
            this.toolStripMenuItemViewPianoMedium,
            this.toolStripMenuItemViewPianoHigh,
            this.toolStripMenuItemViewPianoHigher,
            this.toolStripMenuItemViewPianoHighest});
            this.toolStripMenuItemViewPiano.Name = "toolStripMenuItemViewPiano";
            this.toolStripMenuItemViewPiano.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemViewPiano.Text = "Piano";
            // 
            // toolStripMenuItemViewPianoLowest
            // 
            this.toolStripMenuItemViewPianoLowest.Name = "toolStripMenuItemViewPianoLowest";
            this.toolStripMenuItemViewPianoLowest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.toolStripMenuItemViewPianoLowest.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoLowest.Text = "Lowest piano";
            this.toolStripMenuItemViewPianoLowest.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewPianoLower
            // 
            this.toolStripMenuItemViewPianoLower.Name = "toolStripMenuItemViewPianoLower";
            this.toolStripMenuItemViewPianoLower.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.toolStripMenuItemViewPianoLower.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoLower.Text = "Lower piano";
            this.toolStripMenuItemViewPianoLower.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewPianoLow
            // 
            this.toolStripMenuItemViewPianoLow.Name = "toolStripMenuItemViewPianoLow";
            this.toolStripMenuItemViewPianoLow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.toolStripMenuItemViewPianoLow.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoLow.Text = "Low piano";
            this.toolStripMenuItemViewPianoLow.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewPianoMedium
            // 
            this.toolStripMenuItemViewPianoMedium.Name = "toolStripMenuItemViewPianoMedium";
            this.toolStripMenuItemViewPianoMedium.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemViewPianoMedium.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoMedium.Text = "Medium piano";
            this.toolStripMenuItemViewPianoMedium.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewPianoHigh
            // 
            this.toolStripMenuItemViewPianoHigh.Name = "toolStripMenuItemViewPianoHigh";
            this.toolStripMenuItemViewPianoHigh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.toolStripMenuItemViewPianoHigh.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoHigh.Text = "High piano";
            this.toolStripMenuItemViewPianoHigh.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewPianoHigher
            // 
            this.toolStripMenuItemViewPianoHigher.Name = "toolStripMenuItemViewPianoHigher";
            this.toolStripMenuItemViewPianoHigher.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.toolStripMenuItemViewPianoHigher.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoHigher.Text = "Higher piano";
            this.toolStripMenuItemViewPianoHigher.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewPianoHighest
            // 
            this.toolStripMenuItemViewPianoHighest.Name = "toolStripMenuItemViewPianoHighest";
            this.toolStripMenuItemViewPianoHighest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.toolStripMenuItemViewPianoHighest.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemViewPianoHighest.Text = "Highest piano";
            this.toolStripMenuItemViewPianoHighest.Click += new System.EventHandler(this.toolStripMenuItemViewPianoGeneric_Click);
            // 
            // toolStripMenuItemViewSoundboard
            // 
            this.toolStripMenuItemViewSoundboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSoundboardNew,
            this.toolStripMenuItemSoundboardSeperator1,
            this.toolStripMenuItemLoadFile});
            this.toolStripMenuItemViewSoundboard.Name = "toolStripMenuItemViewSoundboard";
            this.toolStripMenuItemViewSoundboard.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemViewSoundboard.Text = "Soundboard";
            // 
            // toolStripMenuItemSoundboardNew
            // 
            this.toolStripMenuItemSoundboardNew.Name = "toolStripMenuItemSoundboardNew";
            this.toolStripMenuItemSoundboardNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.toolStripMenuItemSoundboardNew.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemSoundboardNew.Text = "New soundboard";
            this.toolStripMenuItemSoundboardNew.Click += new System.EventHandler(this.toolStripMenuItemSoundboardNew_Click);
            // 
            // toolStripMenuItemSoundboardSeperator1
            // 
            this.toolStripMenuItemSoundboardSeperator1.Name = "toolStripMenuItemSoundboardSeperator1";
            this.toolStripMenuItemSoundboardSeperator1.Size = new System.Drawing.Size(265, 6);
            // 
            // toolStripMenuItemLoadFile
            // 
            this.toolStripMenuItemLoadFile.Name = "toolStripMenuItemLoadFile";
            this.toolStripMenuItemLoadFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.toolStripMenuItemLoadFile.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemLoadFile.Text = "Load soundboard template";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // groupBoxSelectPiano
            // 
            this.groupBoxSelectPiano.Controls.Add(this.buttonHighestPiano);
            this.groupBoxSelectPiano.Controls.Add(this.buttonHigherPiano);
            this.groupBoxSelectPiano.Controls.Add(this.buttonHighPiano);
            this.groupBoxSelectPiano.Controls.Add(this.buttonMediumPiano);
            this.groupBoxSelectPiano.Controls.Add(this.buttonLowPiano);
            this.groupBoxSelectPiano.Controls.Add(this.buttonLowerPiano);
            this.groupBoxSelectPiano.Controls.Add(this.buttonLowestPiano);
            this.groupBoxSelectPiano.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSelectPiano.Location = new System.Drawing.Point(0, 24);
            this.groupBoxSelectPiano.Name = "groupBoxSelectPiano";
            this.groupBoxSelectPiano.Size = new System.Drawing.Size(200, 222);
            this.groupBoxSelectPiano.TabIndex = 1;
            this.groupBoxSelectPiano.TabStop = false;
            this.groupBoxSelectPiano.Text = "Select piano";
            // 
            // buttonHighestPiano
            // 
            this.buttonHighestPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHighestPiano.Location = new System.Drawing.Point(6, 193);
            this.buttonHighestPiano.Name = "buttonHighestPiano";
            this.buttonHighestPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonHighestPiano.TabIndex = 6;
            this.buttonHighestPiano.Text = "Highest piano";
            this.buttonHighestPiano.UseVisualStyleBackColor = true;
            this.buttonHighestPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // buttonHigherPiano
            // 
            this.buttonHigherPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHigherPiano.Location = new System.Drawing.Point(6, 164);
            this.buttonHigherPiano.Name = "buttonHigherPiano";
            this.buttonHigherPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonHigherPiano.TabIndex = 5;
            this.buttonHigherPiano.Text = "Higher piano";
            this.buttonHigherPiano.UseVisualStyleBackColor = true;
            this.buttonHigherPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // buttonHighPiano
            // 
            this.buttonHighPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHighPiano.Location = new System.Drawing.Point(6, 135);
            this.buttonHighPiano.Name = "buttonHighPiano";
            this.buttonHighPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonHighPiano.TabIndex = 4;
            this.buttonHighPiano.Text = "High piano";
            this.buttonHighPiano.UseVisualStyleBackColor = true;
            this.buttonHighPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // buttonMediumPiano
            // 
            this.buttonMediumPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMediumPiano.Location = new System.Drawing.Point(6, 106);
            this.buttonMediumPiano.Name = "buttonMediumPiano";
            this.buttonMediumPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonMediumPiano.TabIndex = 3;
            this.buttonMediumPiano.Text = "Medium piano";
            this.buttonMediumPiano.UseVisualStyleBackColor = true;
            this.buttonMediumPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // buttonLowPiano
            // 
            this.buttonLowPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLowPiano.Location = new System.Drawing.Point(6, 77);
            this.buttonLowPiano.Name = "buttonLowPiano";
            this.buttonLowPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonLowPiano.TabIndex = 2;
            this.buttonLowPiano.Text = "Low piano";
            this.buttonLowPiano.UseVisualStyleBackColor = true;
            this.buttonLowPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // buttonLowerPiano
            // 
            this.buttonLowerPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLowerPiano.Location = new System.Drawing.Point(6, 48);
            this.buttonLowerPiano.Name = "buttonLowerPiano";
            this.buttonLowerPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonLowerPiano.TabIndex = 1;
            this.buttonLowerPiano.Text = "Lower piano";
            this.buttonLowerPiano.UseVisualStyleBackColor = true;
            this.buttonLowerPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // buttonLowestPiano
            // 
            this.buttonLowestPiano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLowestPiano.Location = new System.Drawing.Point(6, 19);
            this.buttonLowestPiano.Name = "buttonLowestPiano";
            this.buttonLowestPiano.Size = new System.Drawing.Size(188, 23);
            this.buttonLowestPiano.TabIndex = 0;
            this.buttonLowestPiano.Text = "Lowest piano";
            this.buttonLowestPiano.UseVisualStyleBackColor = true;
            this.buttonLowestPiano.Click += new System.EventHandler(this.buttonGenericPiano_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonRefreshFilesList);
            this.groupBoxMain.Controls.Add(this.buttonLoadSoundboard);
            this.groupBoxMain.Controls.Add(this.buttonCreateNewSoundboard);
            this.groupBoxMain.Controls.Add(this.listViewFiles);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.Location = new System.Drawing.Point(200, 24);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(600, 222);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Soundboard";
            // 
            // buttonRefreshFilesList
            // 
            this.buttonRefreshFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshFilesList.Location = new System.Drawing.Point(444, 77);
            this.buttonRefreshFilesList.Name = "buttonRefreshFilesList";
            this.buttonRefreshFilesList.Size = new System.Drawing.Size(150, 23);
            this.buttonRefreshFilesList.TabIndex = 3;
            this.buttonRefreshFilesList.Text = "Refresh list";
            this.buttonRefreshFilesList.UseVisualStyleBackColor = true;
            this.buttonRefreshFilesList.Click += new System.EventHandler(this.buttonRefreshFilesList_Click);
            // 
            // buttonLoadSoundboard
            // 
            this.buttonLoadSoundboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadSoundboard.Location = new System.Drawing.Point(444, 48);
            this.buttonLoadSoundboard.Name = "buttonLoadSoundboard";
            this.buttonLoadSoundboard.Size = new System.Drawing.Size(150, 23);
            this.buttonLoadSoundboard.TabIndex = 2;
            this.buttonLoadSoundboard.Text = "Load soundboard";
            this.buttonLoadSoundboard.UseVisualStyleBackColor = true;
            this.buttonLoadSoundboard.Click += new System.EventHandler(this.buttonLoadSoundboard_Click);
            // 
            // buttonCreateNewSoundboard
            // 
            this.buttonCreateNewSoundboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateNewSoundboard.Location = new System.Drawing.Point(444, 19);
            this.buttonCreateNewSoundboard.Name = "buttonCreateNewSoundboard";
            this.buttonCreateNewSoundboard.Size = new System.Drawing.Size(150, 23);
            this.buttonCreateNewSoundboard.TabIndex = 1;
            this.buttonCreateNewSoundboard.Text = "Create new soundboard";
            this.buttonCreateNewSoundboard.UseVisualStyleBackColor = true;
            this.buttonCreateNewSoundboard.Click += new System.EventHandler(this.buttonCreateNewSoundboard_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.LargeImageList = this.imageList;
            this.listViewFiles.Location = new System.Drawing.Point(6, 19);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(432, 197);
            this.listViewFiles.SmallImageList = this.imageList;
            this.listViewFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.SmallIcon;
            this.listViewFiles.DoubleClick += new System.EventHandler(this.listViewFiles_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "PianoETI_icon_32_32.png");
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PianoETI soundboard template file (*.pest)|*.pest";
            this.openFileDialog.InitialDirectory = "./templates/";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.groupBoxSelectPiano);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "PianoETI - Unknown Version";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxSelectPiano.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPiano;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoLowest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoLower;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoLow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoMedium;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoHigh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoHigher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewPianoHighest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewSoundboard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSoundboardNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSoundboardSeperator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadFile;
        private System.Windows.Forms.GroupBox groupBoxSelectPiano;
        private System.Windows.Forms.Button buttonHighestPiano;
        private System.Windows.Forms.Button buttonHigherPiano;
        private System.Windows.Forms.Button buttonHighPiano;
        private System.Windows.Forms.Button buttonMediumPiano;
        private System.Windows.Forms.Button buttonLowPiano;
        private System.Windows.Forms.Button buttonLowerPiano;
        private System.Windows.Forms.Button buttonLowestPiano;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonRefreshFilesList;
        private System.Windows.Forms.Button buttonLoadSoundboard;
        private System.Windows.Forms.Button buttonCreateNewSoundboard;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

