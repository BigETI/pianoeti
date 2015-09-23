using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// MainForm class
    /// </summary>
    public partial class MainForm : Form
    {
        #region Attributes
        private MIDISync midi_sync = null;

        private Soundboard soundboard = null;

        private Dictionary<PianoForm.PitchType, PianoForm> piano_form_map;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes an "MainForm" instance
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Getter/Setter
        public MIDISync MIDISync
        {
            get
            {
                return midi_sync;
            }
        }

        public Dictionary<PianoForm.PitchType, PianoForm> PianoFormMap
        {
            get
            {
                return piano_form_map;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// "Exit" Button Event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            Text = "PianoETI - Version " + version.Major + "." + version.Minor + "." + version.Revision + " Build " + version.Build;

            midi_sync = new MIDISync();

            piano_form_map = new Dictionary<PianoForm.PitchType, PianoForm>();

            toolStripMenuItemViewPianoLowest.Tag = PianoForm.PitchType.Lowest;
            toolStripMenuItemViewPianoLower.Tag = PianoForm.PitchType.Lower;
            toolStripMenuItemViewPianoLow.Tag = PianoForm.PitchType.Low;
            toolStripMenuItemViewPianoMedium.Tag = PianoForm.PitchType.Medium;
            toolStripMenuItemViewPianoHigh.Tag = PianoForm.PitchType.High;
            toolStripMenuItemViewPianoHigher.Tag = PianoForm.PitchType.Higher;
            toolStripMenuItemViewPianoHighest.Tag = PianoForm.PitchType.Highest;

            soundboard = new Soundboard();
            soundboard.registerButton(pictureBoxSyntesizerA1, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-boss.wav");
            soundboard.registerButton(pictureBoxSyntesizerA2, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/mariorpg-forestmaze.wav");
            soundboard.registerButton(pictureBoxSyntesizerA3, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-bowserscastle.wav");
            soundboard.registerButton(pictureBoxSyntesizerA4, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-castle.wav");
            soundboard.registerButton(pictureBoxSyntesizerA5, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-cave.wav");
            soundboard.registerButton(pictureBoxSyntesizerA6, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-forestofillusion.wav");
            soundboard.registerButton(pictureBoxSyntesizerA7, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-ghosthouse.wav");
            soundboard.registerButton(pictureBoxSyntesizerA8, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-overworld.wav");
            soundboard.registerButton(pictureBoxSyntesizerA9, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-sky.wav");
            soundboard.registerButton(pictureBoxSyntesizerA10, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-special.wav");
            soundboard.registerButton(pictureBoxSyntesizerB1, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-starroad.wav");
            soundboard.registerButton(pictureBoxSyntesizerB2, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-switch.wav");
            soundboard.registerButton(pictureBoxSyntesizerB3, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-vanilladome.wav");
            soundboard.registerButton(pictureBoxSyntesizerB4, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-water.wav");
            soundboard.registerButton(pictureBoxSyntesizerB5, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-worldmap.wav");
            soundboard.registerButton(pictureBoxSyntesizerB6, SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw-yoshisisland.wav");
            soundboard.registerButton(pictureBoxSyntesizerC1, SoundboardButton.Mode.Click, 1.0f, 1.0f, false, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw_1-up.wav");
            soundboard.registerButton(pictureBoxSyntesizerC2, SoundboardButton.Mode.Click, 1.0f, 1.0f, false, new Fraction(1), imageListSyntesizer.Images[0], "./sounds/smw_jump.wav");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (KeyValuePair<PianoForm.PitchType, PianoForm> i in piano_form_map)
                i.Value.Close();
        }

        private void toolStripMenuItemViewPianoGeneric_Click(object sender, EventArgs e)
        {
            PianoForm.PitchType pitch_type = (PianoForm.PitchType)(((ToolStripMenuItem)sender).Tag);
            if (piano_form_map.ContainsKey(pitch_type))
            {
                PianoForm pf = piano_form_map[pitch_type];
                if (pf.Showing)
                {
                    pf.Close();
                    piano_form_map.Remove(pitch_type);
                }
                else
                {
                    piano_form_map.Remove(pitch_type);
                    pf = new PianoForm(pitch_type, (ToolStripMenuItem)sender, this);
                    piano_form_map.Add(pitch_type, pf);
                    pf.Show();
                    Focus();
                }
            }
            else
            {
                PianoForm pf = new PianoForm(pitch_type, (ToolStripMenuItem)sender, this);
                piano_form_map.Add(pitch_type, pf);
                pf.Show();
                Focus();
            }
        }

        private void toolStripMenuItemSoundboardNew_Click(object sender, EventArgs e)
        {
            SoundboardForm sbf = new SoundboardForm(true, "");
            sbf.Show();
        }

        private void onSoundboardLoadClick(object sender, EventArgs e)
        {
            SoundboardForm sbf = new SoundboardForm(false, (string)(((ToolStripMenuItem)sender).Tag));
            sbf.Show();
        }
        #endregion
    }
}
