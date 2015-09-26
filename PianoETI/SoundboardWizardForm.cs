using System;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    public partial class SoundboardWizardForm : Form
    {
        #region Attributes
        private SoundboardForm parent = null;

        private Soundboard soundboard = null;

        private Button[] button_arr = null;
        #endregion

        #region Constructors
        public SoundboardWizardForm(SoundboardForm parent, Soundboard soundboard = null)
        {
            this.parent = parent;
            this.soundboard = new Soundboard(soundboard);
            InitializeComponent();
        }
        #endregion

        #region Methods
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

        private void addNewButton()
        {
            (new SoundboardButtonConfigForm(soundboard)).ShowDialog();
            DialogResult = DialogResult.None;
            updateButtons();
        }

        void editButton(Button button)
        {
            (new SoundboardButtonConfigForm(soundboard, (SoundboardButton)(button.Tag))).ShowDialog();
            DialogResult = DialogResult.None;
        }
        #endregion

        #region Getter/Setter
        public Soundboard Soundboard
        {
            get
            {
                return soundboard;
            }
        }
        #endregion

        #region Events
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Load
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Save
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!soundboard.saveToFile(saveFileDialog.FileName))
                {
                    MessageBox.Show("Die Datei \"" + saveFileDialog.FileName + "\" konnte nicht gespeichert werden.");
                }
            }
            DialogResult = DialogResult.None;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void toolStripMenuItemEditNew_Click(object sender, EventArgs e)
        {
            addNewButton();
        }

        private void toolStripMenuItemMainNew_Click(object sender, EventArgs e)
        {
            addNewButton();
        }

        private void SoundboardWizardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                soundboard.dispose();
                soundboard = null;
            }
        }

        private void toolStripMenuItemCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            editButton((Button)sender);
        }

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

        private void SoundboardWizardForm_Load(object sender, EventArgs e)
        {
            updateButtons();
            textBoxProfileName.Text = soundboard.ProfileName;
        }
        #endregion

        private void pictureBoxNewButton_Click(object sender, EventArgs e)
        {
            addNewButton();
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            editButton((Button)(contextMenuStripButton.SourceControl));
        }

        private void toolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to remove this button?", "Remove button", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
            if (result == DialogResult.Yes) soundboard.removeButton((SoundboardButton)(((Button)(contextMenuStripButton.SourceControl)).Tag));
            updateButtons();
        }
    }
}
