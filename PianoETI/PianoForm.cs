using System;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    public partial class PianoForm : Form
    {
        /// <summary>
        /// Piano pitch type
        /// </summary>
        public enum PitchType
        {
            /// <summary>
            /// CM1 - EM1
            /// </summary>
            Lowest = -19,

            /// <summary>
            /// FM1 - E1
            /// </summary>
            Lower = MIDI.Note.FM1,

            /// <summary>
            /// F1 - E3
            /// </summary>
            Low = MIDI.Note.F1,

            /// <summary>
            /// F3 - E5
            /// </summary>
            Medium = MIDI.Note.F3,

            /// <summary>
            /// F5 - E7
            /// </summary>
            High = MIDI.Note.F5,

            /// <summary>
            /// F7 - E9
            /// </summary>
            Higher = MIDI.Note.F7,

            /// <summary>
            /// F9 - G9
            /// </summary>
            Highest = MIDI.Note.F9
        };

        private PitchType pitch_type = PitchType.Medium;

        private ToolStripMenuItem tool_strip_menu_item = null;

        private MainForm parent = null;

        private PictureBox[] picture_box_arr = null;

        private bool showing = false;

        public PianoForm(PitchType pitch_type, ToolStripMenuItem tool_strip_menu_item, MainForm parent)
        {
            this.pitch_type = pitch_type;
            this.tool_strip_menu_item = tool_strip_menu_item;
            this.parent = parent;
            InitializeComponent();
        }

        public bool Showing
        {
            get
            {
                return showing;
            }
        }

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

        private void PianoForm_Shown(object sender, EventArgs e)
        {
            tool_strip_menu_item.Checked = true;
            showing = true;
        }

        private void PianoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int note = (int)pitch_type;
            foreach (PictureBox i in picture_box_arr)
                parent.MIDISync.removePianoButtons((MIDI.Note)note);
            tool_strip_menu_item.Checked = false;
            showing = false;
        }
    }
}
