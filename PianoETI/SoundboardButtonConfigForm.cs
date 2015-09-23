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
    public partial class SoundboardButtonConfigForm : Form
    {
        SoundboardWizardForm parent = null;

        public SoundboardButtonConfigForm(SoundboardWizardForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void SoundboardButtonConfigForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void SoundboardButtonConfigForm_Shown(object sender, EventArgs e)
        {
            //
        }

        private void SoundboardButtonConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelLoadFileFileName.Text = openFileDialog.FileName;
            }
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonStopTest_Click(object sender, EventArgs e)
        {
            //
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
    }
}
