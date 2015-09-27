using System;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="SoundboardWizardForm"/> class
    /// </summary>
    public partial class SoundboardWizardForm : Form
    {
        #region Attributes
        /// <summary>
        /// Parent <see cref="SoundboardForm"/>
        /// </summary>
        private SoundboardForm parent = null;

        /// <summary>
        /// <see cref="PianoETI.Soundboard"/> instance
        /// </summary>
        private Soundboard soundboard = null;

        /// <summary>
        /// <see cref="Button"/> array
        /// </summary>
        private Button[] button_arr = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Cretes a <see cref="SoundboardWizardForm"/> instance
        /// </summary>
        /// <param name="parent">Parent <see cref="SoundboardForm"/></param>
        /// <param name="soundboard"><see cref="PianoETI.Soundboard"/> instance</param>
        public SoundboardWizardForm(SoundboardForm parent, Soundboard soundboard = null)
        {
            this.parent = parent;
            this.soundboard = new Soundboard(soundboard);
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates all buttons
        /// </summary>
        private void updateButtons()
        {
            int count = 0;
            if (button_arr != null)
            {
                for (int i = 0; i < button_arr.Length; i++)
                {
                    groupBoxButtons.Controls.Remove(button_arr[i]);
                    button_arr[i].Dispose();
                }
                button_arr = null;
            }
            if (soundboard.Count > 0)
            {
                button_arr = new Button[soundboard.Count];
                foreach (var i in soundboard.ButtonMap)
                {
                    button_arr[count] = new Button();
                    groupBoxButtons.Controls.Add(button_arr[count]);
                    button_arr[count].Location = new Point(6 + ((count % 10) * 46), 19 + ((count / 10) * 46));
                    button_arr[count].Name = "button_arr[" + count + "]";
                    button_arr[count].Size = new Size(40, 40);
                    button_arr[count].TabIndex = count;
                    button_arr[count].UseVisualStyleBackColor = true;
                    button_arr[count].ContextMenuStrip = contextMenuStripButton;
                    button_arr[count].Tag = i.Key;
                    button_arr[count].Click += onButtonClick;
                    count++;
                }
            }
            pictureBoxNewButton.Location = new Point(6 + ((count % 10) * 46), 19 + ((count / 10) * 46));
        }

        /// <summary>
        /// Adds a new button
        /// </summary>
        private void addNewButton()
        {
            (new SoundboardButtonConfigForm(soundboard)).ShowDialog();
            DialogResult = DialogResult.None;
            updateButtons();
        }

        /// <summary>
        /// Edits the button
        /// </summary>
        /// <param name="button"></param>
        void editButton(Button button)
        {
            (new SoundboardButtonConfigForm(soundboard, (SoundboardButton)(button.Tag))).ShowDialog();
            DialogResult = DialogResult.None;
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// <see cref="PianoETI.Soundboard"/> instance
        /// </summary>
        public Soundboard Soundboard
        {
            get
            {
                return soundboard;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="Button"/> "Load template" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!soundboard.loadFromFile(openFileDialog.FileName))
                {
                    MessageBox.Show("Die Datei \"" + openFileDialog.FileName + "\" konnte nicht geöffnet werden.");
                }
                updateButtons();
                textBoxProfileName.Text = soundboard.ProfileName;
            }
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// <see cref="Button"/> "Save template as..." event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!soundboard.saveToFile(saveFileDialog.FileName))
                {
                    MessageBox.Show("Die Datei \"" + saveFileDialog.FileName + "\" konnte nicht gespeichert werden.");
                }
            }
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// <see cref="Button"/> "OK" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// <see cref="Button"/> "Cancel" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Add" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemEditNew_Click(object sender, EventArgs e)
        {
            addNewButton();
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Edit" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemMainNew_Click(object sender, EventArgs e)
        {
            addNewButton();
        }

        /// <summary>
        /// <see cref="SoundboardWizardForm"/> "FormClosed" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardWizardForm"/></param>
        /// <param name="e">Arguments <see cref="FormClosedEventArgs"/></param>
        private void SoundboardWizardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                soundboard.dispose();
                soundboard = null;
            }
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Cancel" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// <see cref="Button"/> "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void onButtonClick(object sender, EventArgs e)
        {
            editButton((Button)sender);
        }

        /// <summary>
        /// <see cref="TextBox"/> "TextChanged" event
        /// </summary>
        /// <param name="sender">Sender <see cref="TextBox"/></param>
        /// <param name="e">Arguments</param>
        private void textBoxProfileName_TextChanged(object sender, EventArgs e)
        {
            soundboard.ProfileName = textBoxProfileName.Text;
            if (soundboard.ProfileName != textBoxProfileName.Text)
            {
                int selection_start = textBoxProfileName.SelectionStart;
                textBoxProfileName.Text = soundboard.ProfileName;
                textBoxProfileName.Select(selection_start, 0);
            }
        }

        /// <summary>
        /// <see cref="SoundboardWizardForm"/> "Load" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardWizardForm"/></param>
        /// <param name="e">Arguments</param>
        private void SoundboardWizardForm_Load(object sender, EventArgs e)
        {
            updateButtons();
            textBoxProfileName.Text = soundboard.ProfileName;
        }

        /// <summary>
        /// <see cref="PictureBox"/> "+" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PictureBox"/></param>
        /// <param name="e">Arguments</param>
        private void pictureBoxNewButton_Click(object sender, EventArgs e)
        {
            addNewButton();
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Edit" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            editButton((Button)(contextMenuStripButton.SourceControl));
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Remove" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to remove this button?", "Remove button", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
            if (result == DialogResult.Yes) soundboard.removeButton((SoundboardButton)(((Button)(contextMenuStripButton.SourceControl)).Tag));
            updateButtons();
        }
        #endregion
    }
}
