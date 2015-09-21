using System;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    public class PianoButton : IDisposable
    {
        #region Attributes
        private MIDISync parent = null;
        private PictureBox button = null;
        private MIDI.Note note = 0;
        private byte velocity = 0;
        private Image default_image = null;
        private Image pressed_image = null;
        #endregion

        #region Constructors
        public PianoButton(MIDISync parent, PictureBox button, MIDI.Note note, byte velocity, Image pressed_image)
        {
            this.parent = parent;
            this.button = button;
            this.note = note;
            this.velocity = velocity;
            default_image = button.Image;
            this.pressed_image = pressed_image;
            button.MouseDown += onMouseDown;
            button.MouseUp += onMouseUp;
            button.MouseLeave += onMouseLeave;
        }
        #endregion

        #region Getter/Setter
        public MIDISync Parent
        {
            get
            {
                return parent;
            }
        }

        public PictureBox Button
        {
            get
            {
                return button;
            }
        }

        public MIDI.Note Note
        {
            get
            {
                return note;
            }
        }

        public byte Velocity
        {
            get
            {
                return velocity;
            }
        }

        public Image DefaultImage
        {
            get
            {
                return default_image;
            }
        }

        public Image PressedImage
        {
            get
            {
                return pressed_image;
            }
        }
        #endregion

        #region Events
        private void onMouseDown(object sender, MouseEventArgs e)
        {
            button.Image = pressed_image;
            parent.MIDI.playNote(MIDI.Instrument.PianoC1, note, velocity);
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            button.Image = default_image;
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            button.Image = default_image;
        }
        #endregion

        #region Override
        public void Dispose()
        {
            button.MouseDown -= onMouseDown;
            button.MouseUp -= onMouseUp;
            button.MouseLeave -= onMouseLeave;
        }
        #endregion
    }
}
