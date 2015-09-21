using System;
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
        /// <summary>
        /// MIDISync instance
        /// </summary>
        MIDISync midi_sync = null;

        Synthesizer syntesizer = null;
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
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            Text = "PianoETI - Version " + version.Major + "." + version.Minor + "." + version.Revision + " Build " + version.Build;

            midi_sync = new MIDISync();
            syntesizer = new Synthesizer();
            syntesizer.registerButton(pictureBoxSyntesizerA1, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-boss.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA2, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/mariorpg-forestmaze.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA3, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-bowserscastle.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA4, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-castle.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA5, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-cave.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA6, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-forestofillusion.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA7, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-ghosthouse.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA8, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-overworld.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA9, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-sky.wav");
            syntesizer.registerButton(pictureBoxSyntesizerA10, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-special.wav");
            syntesizer.registerButton(pictureBoxSyntesizerB1, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-starroad.wav");
            syntesizer.registerButton(pictureBoxSyntesizerB2, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-switch.wav");
            syntesizer.registerButton(pictureBoxSyntesizerB3, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-vanilladome.wav");
            syntesizer.registerButton(pictureBoxSyntesizerB4, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-water.wav");
            syntesizer.registerButton(pictureBoxSyntesizerB5, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-worldmap.wav");
            syntesizer.registerButton(pictureBoxSyntesizerB6, SynthesizerButton.Mode.Toggle, imageListSyntesizer.Images[0], "./sounds/smw-yoshisisland.wav");
            syntesizer.registerButton(pictureBoxSyntesizerC1, SynthesizerButton.Mode.Default, imageListSyntesizer.Images[0], "./sounds/smw_1-up.wav");
            syntesizer.registerButton(pictureBoxSyntesizerC2, SynthesizerButton.Mode.Default, imageListSyntesizer.Images[0], "./sounds/smw_jump.wav");
            midi_sync.registerPianoButton(pictureBoxF1, MIDI.Note.F1, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxFF1, MIDI.Note.FF1, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxG1, MIDI.Note.G1, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxGF1, MIDI.Note.GF1, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxA1, MIDI.Note.A1, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxAF1, MIDI.Note.AF1, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxB1, MIDI.Note.B1, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxC2, MIDI.Note.C2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxCF2, MIDI.Note.CF2, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxD2, MIDI.Note.D2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxDF2, MIDI.Note.DF2, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxE2, MIDI.Note.E2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxF2, MIDI.Note.F2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxFF2, MIDI.Note.FF2, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxG2, MIDI.Note.G2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxGF2, MIDI.Note.GF2, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxA2, MIDI.Note.A2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxAF2, MIDI.Note.AF2, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxB2, MIDI.Note.B2, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxC3, MIDI.Note.C3, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxCF3, MIDI.Note.CF3, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxD3, MIDI.Note.D3, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxDF3, MIDI.Note.DF3, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxE3, MIDI.Note.E3, 0x7F, imageListPianoLarge.Images[0]);

            midi_sync.registerPianoButton(pictureBoxF3, MIDI.Note.F3, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxFF3, MIDI.Note.FF3, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxG3, MIDI.Note.G3, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxGF3, MIDI.Note.GF3, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxA3, MIDI.Note.A3, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxAF3, MIDI.Note.AF3, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxB3, MIDI.Note.B3, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxC4, MIDI.Note.C4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxCF4, MIDI.Note.CF4, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxD4, MIDI.Note.D4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxDF4, MIDI.Note.DF4, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxE4, MIDI.Note.E4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxF4, MIDI.Note.F4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxFF4, MIDI.Note.FF4, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxG4, MIDI.Note.G4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxGF4, MIDI.Note.GF4, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxA4, MIDI.Note.A4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxAF4, MIDI.Note.AF4, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxB4, MIDI.Note.B4, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxC5, MIDI.Note.C5, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxCF5, MIDI.Note.CF5, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxD5, MIDI.Note.D5, 0x7F, imageListPianoLarge.Images[0]);
            midi_sync.registerPianoButton(pictureBoxDF5, MIDI.Note.DF5, 0x7F, imageListPianoSmall.Images[0]);
            midi_sync.registerPianoButton(pictureBoxE5, MIDI.Note.E5, 0x7F, imageListPianoLarge.Images[0]);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            midi_sync.close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            midi_sync.MIDI.playNote(MIDI.Instrument.PianoC1, (MIDI.Note)(((PictureBox)sender).Tag), 0x7F);
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            midi_sync.MIDI.playNote(MIDI.Instrument.PianoC1, (MIDI.Note)(((PictureBox)sender).Tag), 0x3F);
        }
    }
}
