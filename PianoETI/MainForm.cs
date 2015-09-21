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

        private Synthesizer synthesizer = null;

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

            synthesizer = new Synthesizer();
            synthesizer.registerButton(pictureBoxSyntesizerA1, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-boss.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA2, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/mariorpg-forestmaze.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA3, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-bowserscastle.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA4, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-castle.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA5, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-cave.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA6, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-forestofillusion.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA7, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-ghosthouse.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA8, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-overworld.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA9, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-sky.wav");
            synthesizer.registerButton(pictureBoxSyntesizerA10, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-special.wav");
            synthesizer.registerButton(pictureBoxSyntesizerB1, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-starroad.wav");
            synthesizer.registerButton(pictureBoxSyntesizerB2, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-switch.wav");
            synthesizer.registerButton(pictureBoxSyntesizerB3, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-vanilladome.wav");
            synthesizer.registerButton(pictureBoxSyntesizerB4, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-water.wav");
            synthesizer.registerButton(pictureBoxSyntesizerB5, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-worldmap.wav");
            synthesizer.registerButton(pictureBoxSyntesizerB6, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-yoshisisland.wav");
            synthesizer.registerButton(pictureBoxSyntesizerC1, SynthesizerButton.Mode.Default, imageListSyntesizer.Images[0], "./sounds/smw_1-up.wav");
            synthesizer.registerButton(pictureBoxSyntesizerC2, SynthesizerButton.Mode.Default, imageListSyntesizer.Images[0], "./sounds/smw_jump.wav");
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
        #endregion
    }
}
