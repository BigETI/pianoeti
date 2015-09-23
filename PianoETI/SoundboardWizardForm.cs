using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoETI
{
    public partial class SoundboardWizardForm : Form
    {
        #region Attributes
        private SoundboardForm parent = null;
        private Soundboard soundboard = null;
        #endregion

        #region Constructors
        public SoundboardWizardForm(SoundboardForm parent)
        {
            this.parent = parent;
            soundboard = new Soundboard();
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void addNewButton()
        {
            SoundboardButtonConfigForm sbcf = new SoundboardButtonConfigForm(this);
            DialogResult result = sbcf.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                //
            }
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
                if (!parent.Soundboard.loadFromFile(openFileDialog.FileName))
                {
                    MessageBox.Show("Die Datei \"" + openFileDialog.FileName + "\" konnte nicht geöffnet werden.");
                }
            }
            DialogResult = DialogResult.None;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Save
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!parent.Soundboard.saveToFile(saveFileDialog.FileName))
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
        #endregion

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
    }
}
