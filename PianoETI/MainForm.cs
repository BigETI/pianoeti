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
    /// <summary>
    /// MainForm class
    /// </summary>
    public partial class MainForm : Form
    {
        #region Attributes
        /// <summary>
        /// MIDI instance
        /// </summary>
        MIDI midi = null;
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
            midi = new MIDI();
            pictureBoxF1.Tag = MIDI.Note.F1;
            pictureBoxFF1.Tag = MIDI.Note.FF1;
            pictureBoxG1.Tag = MIDI.Note.G1;
            pictureBoxGF1.Tag = MIDI.Note.GF1;
            pictureBoxA1.Tag = MIDI.Note.A1;
            pictureBoxAF1.Tag = MIDI.Note.AF1;
            pictureBoxB1.Tag = MIDI.Note.B1;
            pictureBoxC2.Tag = MIDI.Note.C2;
            pictureBoxCF2.Tag = MIDI.Note.CF2;
            pictureBoxD2.Tag = MIDI.Note.D2;
            pictureBoxDF2.Tag = MIDI.Note.DF2;
            pictureBoxE2.Tag = MIDI.Note.E2;
            pictureBoxF2.Tag = MIDI.Note.F2;
            pictureBoxFF2.Tag = MIDI.Note.FF2;
            pictureBoxG2.Tag = MIDI.Note.G2;
            pictureBoxGF2.Tag = MIDI.Note.GF2;
            pictureBoxA2.Tag = MIDI.Note.A2;
            pictureBoxAF2.Tag = MIDI.Note.AF2;
            pictureBoxB2.Tag = MIDI.Note.B2;
            pictureBoxC3.Tag = MIDI.Note.C3;
            pictureBoxCF3.Tag = MIDI.Note.CF3;
            pictureBoxD3.Tag = MIDI.Note.D3;
            pictureBoxDF3.Tag = MIDI.Note.DF3;
            pictureBoxE3.Tag = MIDI.Note.E3;

            pictureBoxF3.Tag = MIDI.Note.F3;
            pictureBoxFF3.Tag = MIDI.Note.FF3;
            pictureBoxG3.Tag = MIDI.Note.G3;
            pictureBoxGF3.Tag = MIDI.Note.GF3;
            pictureBoxA3.Tag = MIDI.Note.A3;
            pictureBoxAF3.Tag = MIDI.Note.AF3;
            pictureBoxB3.Tag = MIDI.Note.B3;
            pictureBoxC4.Tag = MIDI.Note.C4;
            pictureBoxCF4.Tag = MIDI.Note.CF4;
            pictureBoxD4.Tag = MIDI.Note.D4;
            pictureBoxDF4.Tag = MIDI.Note.DF4;
            pictureBoxE4.Tag = MIDI.Note.E4;
            pictureBoxF4.Tag = MIDI.Note.F4;
            pictureBoxFF4.Tag = MIDI.Note.FF4;
            pictureBoxG4.Tag = MIDI.Note.G4;
            pictureBoxGF4.Tag = MIDI.Note.GF4;
            pictureBoxA4.Tag = MIDI.Note.A4;
            pictureBoxAF4.Tag = MIDI.Note.AF4;
            pictureBoxB4.Tag = MIDI.Note.B4;
            pictureBoxC5.Tag = MIDI.Note.C5;
            pictureBoxCF5.Tag = MIDI.Note.CF5;
            pictureBoxD5.Tag = MIDI.Note.D5;
            pictureBoxDF5.Tag = MIDI.Note.DF5;
            pictureBoxE5.Tag = MIDI.Note.E5;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            midi.close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            midi.playNote(MIDI.Instrument.Piano, (MIDI.Note)(((PictureBox)sender).Tag), 0x7F);
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            midi.playNote(MIDI.Instrument.Piano, (MIDI.Note)(((PictureBox)sender).Tag), 0x3F);
        }
    }
}
