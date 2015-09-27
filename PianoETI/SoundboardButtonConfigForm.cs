using System;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="SoundboardButtonConfigForm"/> class
    /// </summary>
    public partial class SoundboardButtonConfigForm : Form
    {
        #region Attributes
        /// <summary>
        /// <see cref="PianoETI.Soundboard"/> instance
        /// </summary>
        private Soundboard soundboard = null;

        /// <summary>
        /// <see cref="PianoETI.SoundboardButton"/> instance
        /// </summary>
        private SoundboardButton soundboard_button = null;

        /// <summary>
        /// Backup file name
        /// </summary>
        private string backup_file_name;

        /// <summary>
        /// Backup volume (factor)
        /// </summary>
        private float backup_volume;

        /// <summary>
        /// Backup pitch (factor)
        /// </summary>
        private float backup_pitch;

        /// <summary>
        /// Backup button mode <see cref="SoundboardButton.Mode"/>
        /// </summary>
        private SoundboardButton.Mode backup_button_mode;

        /// <summary>
        /// Backup is looping
        /// </summary>
        private bool backup_loop;

        /// <summary>
        /// Backup time fraction <see cref="Fraction"/>
        /// </summary>
        private Fraction backup_fraction;

        /// <summary>
        /// Is newly created?
        /// </summary>
        private bool create_new = false;

        /// <summary>
        /// Allow update?
        /// </summary>
        private bool allow_update = true;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="SoundboardButtonConfigForm"/> instance
        /// </summary>
        /// <param name="soundboard"><see cref="PianoETI.Soundboard"/> instance</param>
        /// <param name="soundboard_button"><see cref="PianoETI.SoundboardButton"/> instance</param>
        public SoundboardButtonConfigForm(Soundboard soundboard, SoundboardButton soundboard_button = null)
        {
            this.soundboard = soundboard;
            if (soundboard_button == null)
            {
                create_new = true;
                this.soundboard_button = soundboard.createButton(SoundboardButton.Mode.PressOnly, 0.0f, 1.0f, false, new Fraction(1), Properties.Resources.SoundboardButton_pressed, "");
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
        #endregion

        #region Methods
        /// <summary>
        /// Updates all controls
        /// </summary>
        public void updateControls()
        {
            allow_update = false;
            labelLoadFileFileName.Text = (soundboard_button.FileName.Trim() == "") ? "undefined..." : soundboard_button.FileName;
            trackBarVolume.Value = (int)(soundboard_button.Volume * 100.0);
            trackBarPitch.Value = (int)(soundboard_button.Pitch * 100.0);
            switch (soundboard_button.ButtonMode)
            {
                case SoundboardButton.Mode.PressOnly:
                    radioButtonModePressOnly.Checked = true;
                    break;
                case SoundboardButton.Mode.Toggle:
                    radioButtonToggle.Checked = true;
                    break;
                case SoundboardButton.Mode.Click:
                    radioButtonClick.Checked = true;
                    break;
            }
            checkBoxLoop.Checked = soundboard_button.Loop;
            numericUpDownNumerator.Value = 1;
            numericUpDownDivisor.Value = soundboard_button.Fraction.Divisor;
            numericUpDownNumerator.Value = soundboard_button.Fraction.Numerator;
            allow_update = true;
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

        /// <summary>
        /// <see cref="PianoETI.SoundboardButton"/> instance
        /// </summary>
        public SoundboardButton SoundboardButton
        {
            get
            {
                return soundboard_button;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="SoundboardButtonConfigForm"/> "Load" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardButtonConfigForm"/></param>
        /// <param name="e">Arguments</param>
        private void SoundboardButtonConfigForm_Load(object sender, EventArgs e)
        {
            radioButtonModePressOnly.Tag = SoundboardButton.Mode.PressOnly;
            radioButtonToggle.Tag = SoundboardButton.Mode.Toggle;
            radioButtonClick.Tag = SoundboardButton.Mode.Click;
            updateControls();
        }

        /// <summary>
        /// <see cref="SoundboardButtonConfigForm"/> "Shown" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardButtonConfigForm"/></param>
        /// <param name="e">Arguments</param>
        private void SoundboardButtonConfigForm_Shown(object sender, EventArgs e)
        {
            //
        }

        /// <summary>
        /// <see cref="SoundboardButtonConfigForm"/> "FormClosed" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardButtonConfigForm"/></param>
        /// <param name="e">Arguments <see cref="FormClosedEventArgs"/></param>
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

        /// <summary>
        /// <see cref="Button"/> "..." "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelLoadFileFileName.Text = openFileDialog.FileName;
                soundboard_button.FileName = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// <see cref="Button"/> "Start" "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            soundboard_button.play();
        }

        /// <summary>
        /// <see cref="Button"/> "Stop" "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonStopTest_Click(object sender, EventArgs e)
        {
            soundboard_button.stop();
        }

        /// <summary>
        /// <see cref="Button"/> "OK" "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            soundboard_button.stop();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// <see cref="Button"/> "Cancel" "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            soundboard_button.stop();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// <see cref="TrackBar"/> volume "ValueChanged" event
        /// </summary>
        /// <param name="sender">Sender <see cref="TrackBar"/></param>
        /// <param name="e">Arguments</param>
        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            if (allow_update)
                soundboard_button.Volume = ((float)(trackBarVolume.Value)) * 0.01f;
        }

        /// <summary>
        /// <see cref="TrackBar"/> pitch "ValueChanged" event
        /// </summary>
        /// <param name="sender">Sender <see cref="TrackBar"/></param>
        /// <param name="e">Arguments</param>
        private void trackBarPitch_ValueChanged(object sender, EventArgs e)
        {
            if (allow_update)
                soundboard_button.Pitch = ((float)(trackBarPitch.Value)) * 0.01f;
        }

        /// <summary>
        /// <see cref="RadioButton"/> "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="RadioButton"/></param>
        /// <param name="e">Arguments</param>
        private void radioButtonModeGeneric_Click(object sender, EventArgs e)
        {
            if (allow_update)
                soundboard_button.ButtonMode = (SoundboardButton.Mode)(((RadioButton)sender).Tag);
        }

        /// <summary>
        /// <see cref="CheckBox"/> "Loop" "CheckedChanged" event
        /// </summary>
        /// <param name="sender">Sender <see cref="CheckBox"/></param>
        /// <param name="e">Arguments</param>
        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (allow_update)
                soundboard_button.Loop = checkBoxLoop.Checked;
        }

        /// <summary>
        /// <see cref="NumericUpDown"/> numerator "ValueChanged" event
        /// </summary>
        /// <param name="sender">Sender <see cref="NumericUpDown"/></param>
        /// <param name="e">Arguments</param>
        private void numericUpDownNumerator_ValueChanged(object sender, EventArgs e)
        {
            if (allow_update)
            {
                if (numericUpDownDivisor.Value < numericUpDownNumerator.Value)
                    numericUpDownDivisor.Value = numericUpDownNumerator.Value;
                soundboard_button.Fraction = new Fraction((int)(numericUpDownNumerator.Value), (uint)(numericUpDownDivisor.Value));
            }
        }

        /// <summary>
        /// <see cref="NumericUpDown"/> divisor "ValueChanged" event
        /// </summary>
        /// <param name="sender">Sender <see cref="NumericUpDown"/></param>
        /// <param name="e">Arguments</param>
        private void numericUpDownDivisor_ValueChanged(object sender, EventArgs e)
        {
            if (allow_update)
            {
                if (numericUpDownDivisor.Value < numericUpDownNumerator.Value)
                    numericUpDownDivisor.Value = numericUpDownNumerator.Value;
                soundboard_button.Fraction = new Fraction((int)(numericUpDownNumerator.Value), (uint)(numericUpDownDivisor.Value));
            }
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Revert to default" "Click" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemRevert_Click(object sender, EventArgs e)
        {
            if (create_new)
            {
                soundboard_button.FileName = "";
                soundboard_button.Volume = 1.0f;
                soundboard_button.Pitch = 0.0f;
                soundboard_button.ButtonMode = SoundboardButton.Mode.PressOnly;
                soundboard_button.Loop = backup_loop;
                soundboard_button.Fraction = backup_fraction;
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
            updateControls();
        }
        #endregion
    }
}
