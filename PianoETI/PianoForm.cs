using System;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="PianoForm"/> class
    /// </summary>
    public partial class PianoForm : Form
    {
        #region Enums
        /// <summary>
        /// Piano pitch type
        /// </summary>
        public enum PitchType
        {
            /// <summary>
            /// CM1 - EM1 <see cref="MIDI.Note"/>
            /// </summary>
            Lowest = -19,

            /// <summary>
            /// FM1 - E1 <see cref="MIDI.Note"/>
            /// </summary>
            Lower = MIDI.Note.FM1,

            /// <summary>
            /// F1 - E3 <see cref="MIDI.Note"/>
            /// </summary>
            Low = MIDI.Note.F1,

            /// <summary>
            /// F3 - E5 <see cref="MIDI.Note"/>
            /// </summary>
            Medium = MIDI.Note.F3,

            /// <summary>
            /// F5 - E7 <see cref="MIDI.Note"/>
            /// </summary>
            High = MIDI.Note.F5,

            /// <summary>
            /// F7 - E9 <see cref="MIDI.Note"/>
            /// </summary>
            Higher = MIDI.Note.F7,

            /// <summary>
            /// F9 - G9 <see cref="MIDI.Note"/>
            /// </summary>
            Highest = MIDI.Note.F9
        };
        #endregion

        #region Attributes
        /// <summary>
        /// Pitch type <see cref="PitchType"/>
        /// </summary>
        private PitchType pitch_type = PitchType.Medium;

        /// <summary>
        /// <see cref="ToolStripMenuItem"/>
        /// </summary>
        private ToolStripMenuItem tool_strip_menu_item = null;

        /// <summary>
        /// Parent <see cref="MainForm"/>
        /// </summary>
        private MainForm parent = null;

        /// <summary>
        /// PictureBox <see cref="PictureBox"/>
        /// </summary>
        private PictureBox[] picture_box_arr = null;

        /// <summary>
        /// Showing
        /// </summary>
        private bool showing = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="PianoForm"/> instance
        /// </summary>
        /// <param name="pitch_type">Pitch type <see cref="PitchType"/></param>
        /// <param name="tool_strip_menu_item"><see cref="ToolStripMenuItem"/> instance</param>
        /// <param name="parent">Parent <see cref="MainForm"/></param>
        public PianoForm(PitchType pitch_type, ToolStripMenuItem tool_strip_menu_item, MainForm parent)
        {
            this.pitch_type = pitch_type;
            this.tool_strip_menu_item = tool_strip_menu_item;
            this.parent = parent;
            InitializeComponent();
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// Is showing?
        /// </summary>
        public bool Showing
        {
            get
            {
                return showing;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="PianoForm"/> "Load" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PianoForm"/></param>
        /// <param name="e">Arguments</param>
        private void PianoForm_Load(object sender, EventArgs e)
        {
            string pitch_type_name = "Unknown";
            switch(pitch_type)
            {
                case PitchType.Lowest:
                    pitch_type_name = "Lowest";
                    break;
                case PitchType.Lower:
                    pitch_type_name = "Lower";
                    break;
                case PitchType.Low:
                    pitch_type_name = "Low";
                    break;
                case PitchType.Medium:
                    pitch_type_name = "Medium";
                    break;
                case PitchType.High:
                    pitch_type_name = "High";
                    break;
                case PitchType.Higher:
                    pitch_type_name = "Higher";
                    break;
                case PitchType.Highest:
                    pitch_type_name = "Highest";
                    break;
            }
            Text = "Piano - " + pitch_type_name + " - " + parent.Text;
            picture_box_arr = new PictureBox[24];
            (picture_box_arr[0] = pictureBoxF1).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[1] = pictureBoxFF1).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[2] = pictureBoxG1).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[3] = pictureBoxGF1).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[4] = pictureBoxA1).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[5] = pictureBoxAF1).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[6] = pictureBoxB1).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[7] = pictureBoxC2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[8] = pictureBoxCF2).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[9] = pictureBoxD2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[10] = pictureBoxDF2).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[11] = pictureBoxE2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[12] = pictureBoxF2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[13] = pictureBoxFF2).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[14] = pictureBoxG2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[15] = pictureBoxGF2).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[16] = pictureBoxA2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[17] = pictureBoxAF2).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[18] = pictureBoxB2).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[19] = pictureBoxC3).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[20] = pictureBoxCF3).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[21] = pictureBoxD3).Tag = imageListPianoLarge.Images[0];
            (picture_box_arr[22] = pictureBoxDF3).Tag = imageListPianoSmall.Images[0];
            (picture_box_arr[23] = pictureBoxE3).Tag = imageListPianoLarge.Images[0];
            int note = (int)(pitch_type), i;
            for(i = 0; i < picture_box_arr.Length; i++)
            {
                if ((note >= 0x0) && (note <= 0x7F)) parent.MIDISync.registerPianoButton(picture_box_arr[i], (MIDI.Note)note, 0x7F, (Image)(picture_box_arr[i].Tag));
                note++;
            }
            note++;
        }

        /// <summary>
        /// <see cref="PianoForm"/> "Shown" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PianoForm"/></param>
        /// <param name="e">Arguments</param>
        private void PianoForm_Shown(object sender, EventArgs e)
        {
            tool_strip_menu_item.Checked = true;
            showing = true;
        }

        /// <summary>
        /// <see cref="PianoForm"/> "FormClosed" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PianoForm"/></param>
        /// <param name="e">Arguments <see cref="FormClosedEventArgs"/></param>
        private void PianoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int note = (int)pitch_type;
            foreach (PictureBox i in picture_box_arr)
                parent.MIDISync.removePianoButtons((MIDI.Note)note);
            tool_strip_menu_item.Checked = false;
            showing = false;
        }
        #endregion
    }
}
