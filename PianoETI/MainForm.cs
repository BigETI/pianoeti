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
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-boss.wav", pictureBoxSyntesizerA1);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/mariorpg-forestmaze.wav", pictureBoxSyntesizerA2);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-bowserscastle.wav", pictureBoxSyntesizerA3);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-castle.wav", pictureBoxSyntesizerA4);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-cave.wav", pictureBoxSyntesizerA5);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-forestofillusion.wav", pictureBoxSyntesizerA6);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-ghosthouse.wav", pictureBoxSyntesizerA7);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-overworld.wav", pictureBoxSyntesizerA8);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-sky.wav", pictureBoxSyntesizerA9);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-special.wav", pictureBoxSyntesizerA10);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-starroad.wav", pictureBoxSyntesizerB1);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-switch.wav", pictureBoxSyntesizerB2);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-vanilladome.wav", pictureBoxSyntesizerB3);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-water.wav", pictureBoxSyntesizerB4);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-worldmap.wav", pictureBoxSyntesizerB5);
            soundboard.createButton(SoundboardButton.Mode.Toggle, 1.0f, 1.0f, true, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw-yoshisisland.wav", pictureBoxSyntesizerB6);
            soundboard.createButton(SoundboardButton.Mode.Click, 1.0f, 1.0f, false, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw_1-up.wav", pictureBoxSyntesizerB7);
            soundboard.createButton(SoundboardButton.Mode.Click, 1.0f, 1.0f, false, new Fraction(1), imageListSoundboardButton.Images[0], "./sounds/smw_jump.wav", pictureBoxSyntesizerB8);
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
