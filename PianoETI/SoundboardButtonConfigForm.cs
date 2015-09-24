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
        private Soundboard soundboard = null;

        private SoundboardButton soundboard_button = null;

        private string backup_file_name;

        private float backup_volume;

        private float backup_pitch;

        private SoundboardButton.Mode backup_button_mode;

        private bool backup_loop;

        private Fraction backup_fraction;

        private bool create_new = false;

        public SoundboardButtonConfigForm(Soundboard soundboard, SoundboardButton soundboard_button = null)
        {
            this.soundboard = soundboard;
            if (soundboard_button == null)
            {
                create_new = true;
                this.soundboard_button = soundboard.createButton(SoundboardButton.Mode.PressOnly, 0.0f, 1.0f, false, new Fraction(1), Properties.Resources.SoundboardButton, "");
            }
            else
            {
                this.soundboard_button = soundboard_button;
                backup_file_name = soundboard_button.FileName;
                backup_volume = soundboard_button.Volume;
                backup_pitch = soundboard_button.Pitch;
                backup_button_mode = soundboard_button.ButtonMode;
                backup_loop = soundboard_button.Loop;
                backup_fraction = soundboard_button.Fraction;
            }
            InitializeComponent();
        }

        public Soundboard Soundboard
        {
            get
            {
                return soundboard;
            }
        }

        public SoundboardButton SoundboardButton
        {
            get
            {
                return soundboard_button;
            }
        }

        private void SoundboardButtonConfigForm_Load(object sender, EventArgs e)
        {
            radioButtonModePressOnly.Tag = SoundboardButton.Mode.PressOnly;
            radioButtonToggle.Tag = SoundboardButton.Mode.Toggle;
            radioButtonClick.Tag = SoundboardButton.Mode.Click;
        }

        private void SoundboardButtonConfigForm_Shown(object sender, EventArgs e)
        {
            //
        }

        private void SoundboardButtonConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if (create_new)
                {
                    soundboard.removeButton(soundboard_button);
                    soundboard_button = null;
                }
                else
                {
                    soundboard_button.FileName = backup_file_name;
                    soundboard_button.Volume = backup_volume;
                    soundboard_button.Pitch = backup_pitch;
                    soundboard_button.ButtonMode = backup_button_mode;
                    soundboard_button.Loop = backup_loop;
                    soundboard_button.Fraction = backup_fraction;
                }
            }
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelLoadFileFileName.Text = openFileDialog.FileName;
                soundboard_button.FileName = openFileDialog.FileName;
            }
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            // Start Test
            soundboard_button.play();
        }

        private void buttonStopTest_Click(object sender, EventArgs e)
        {
            // Stop test
            soundboard_button.stop();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            soundboard_button.stop();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            soundboard_button.stop();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            soundboard_button.Volume = ((float)(trackBarVolume.Value)) * 0.01f;
        }

        private void trackBarPitch_ValueChanged(object sender, EventArgs e)
        {
            soundboard_button.Pitch = ((float)(trackBarPitch.Value)) * 0.01f;
        }

        private void radioButtonModeGeneric_Click(object sender, EventArgs e)
        {
            soundboard_button.ButtonMode = (SoundboardButton.Mode)(((RadioButton)sender).Tag);
        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            soundboard_button.Loop = checkBoxLoop.Checked;
        }

        private void numericUpDownNumerator_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownDivisor.Value < numericUpDownNumerator.Value)
                numericUpDownDivisor.Value = numericUpDownNumerator.Value;
            soundboard_button.Fraction = new Fraction((int)(numericUpDownNumerator.Value), (uint)(numericUpDownDivisor.Value));
        }

        private void numericUpDownDivisor_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownDivisor.Value < numericUpDownNumerator.Value)
                numericUpDownDivisor.Value = numericUpDownNumerator.Value;
            soundboard_button.Fraction = new Fraction((int)(numericUpDownNumerator.Value), (uint)(numericUpDownDivisor.Value));
        }
    }
}
