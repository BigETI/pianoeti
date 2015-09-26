namespace PianoETI
{
    partial class SoundboardWizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundboardWizardForm));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditNew = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.pictureBoxNewButton = new System.Windows.Forms.PictureBox();
            this.contextMenuStripButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemMainNew = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewButton)).BeginInit();
            this.contextMenuStripButton.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 27);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(200, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load template...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PianoETI soundboard template file (*.pest)|*.pest";
            this.openFileDialog.InitialDirectory = "./templates/";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(218, 27);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save template as...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pes";
            this.saveFileDialog.Filter = "PianoETI soundboard template file (*.pest)|*.pest";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(430, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCancel});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemCancel
            // 
            this.toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            this.toolStripMenuItemCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemCancel.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemCancel.Text = "Cancel";
            this.toolStripMenuItemCancel.Click += new System.EventHandler(this.toolStripMenuItemCancel_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditNew});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItemEditNew
            // 
            this.toolStripMenuItemEditNew.Name = "toolStripMenuItemEditNew";
            this.toolStripMenuItemEditNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemEditNew.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemEditNew.Text = "Add new button";
            this.toolStripMenuItemEditNew.Click += new System.EventHandler(this.toolStripMenuItemEditNew_Click);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxButtons.Controls.Add(this.pictureBoxNewButton);
            this.groupBoxButtons.Location = new System.Drawing.Point(12, 82);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(406, 338);
            this.groupBoxButtons.TabIndex = 3;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Button configuration";
            // 
            // pictureBoxNewButton
            // 
            this.pictureBoxNewButton.Image = global::PianoETI.Properties.Resources.add_button;
            this.pictureBoxNewButton.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxNewButton.Name = "pictureBoxNewButton";
            this.pictureBoxNewButton.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxNewButton.TabIndex = 0;
            this.pictureBoxNewButton.TabStop = false;
            this.pictureBoxNewButton.Click += new System.EventHandler(this.pictureBoxNewButton_Click);
            // 
            // contextMenuStripButton
            // 
            this.contextMenuStripButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemRemove});
            this.contextMenuStripButton.Name = "contextMenuStripButton";
            this.contextMenuStripButton.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEdit.Text = "Edit";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemRemove.Text = "Remove";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(111, 426);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(307, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMainNew});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(204, 26);
            // 
            // toolStripMenuItemMainNew
            // 
            this.toolStripMenuItemMainNew.Name = "toolStripMenuItemMainNew";
            this.toolStripMenuItemMainNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemMainNew.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemMainNew.Text = "Add new Button";
            this.toolStripMenuItemMainNew.Click += new System.EventHandler(this.toolStripMenuItemMainNew_Click);
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(54, 56);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.Size = new System.Drawing.Size(364, 20);
            this.textBoxProfileName.TabIndex = 8;
            this.textBoxProfileName.TextChanged += new System.EventHandler(this.textBoxProfileName_TextChanged);
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(12, 59);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(36, 13);
            this.labelProfileName.TabIndex = 9;
            this.labelProfileName.Text = "Profile";
            // 
            // SoundboardWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 461);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.textBoxProfileName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(446, 300);
            this.Name = "SoundboardWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundboard Wizard";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoundboardWizardForm_FormClosed);
            this.Load += new System.EventHandler(this.SoundboardWizardForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewButton)).EndInit();
            this.contextMenuStripButton.ResumeLayout(false);
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancel;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainNew;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxNewButton;
    }
}