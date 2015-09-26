using System;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="PianoButton"/> class
    /// </summary>
    public class PianoButton : IDisposable
    {
        #region Attributes
        /// <summary>
        /// Parent <see cref="MIDISync"/>
        /// </summary>
        private MIDISync parent = null;

        /// <summary>
        /// Button <see cref="PictureBox"/>
        /// </summary>
        private PictureBox button = null;

        /// <summary>
        /// Note <see cref="MIDI.Note"/>
        /// </summary>
        private MIDI.Note note = 0;

        /// <summary>
        /// Velocity (0 - 127)
        /// </summary>
        private byte velocity = 0;

        /// <summary>
        /// Default image <see cref="Image"/>
        /// </summary>
        private Image default_image = null;

        /// <summary>
        /// Pressed image <see cref="Image"/>
        /// </summary>
        private Image pressed_image = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Create a <see cref="PianoButton"/> instance
        /// </summary>
        /// <param name="parent">Parent <see cref="MIDISync"/></param>
        /// <param name="button">Button <see cref="PictureBox"/></param>
        /// <param name="note">Note <see cref="MIDI.Note"/></param>
        /// <param name="velocity">Velocity (0 - 127)</param>
        /// <param name="pressed_image">Pressed image <see cref="Image"/></param>
        public PianoButton(MIDISync parent, PictureBox button, MIDI.Note note, byte velocity, Image pressed_image)
        {
            this.parent = parent;
            this.button = button;
            this.note = note;
            this.velocity = ((velocity > ((byte)0x7F)) ? ((byte)0x7F) : velocity);
            default_image = button.Image;
            this.pressed_image = pressed_image;
            button.MouseDown += onMouseDown;
            button.MouseUp += onMouseUp;
            button.MouseLeave += onMouseLeave;
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// Parent <see cref="MIDISync"/>
        /// </summary>
        public MIDISync Parent
        {
            get
            {
                return parent;
            }
        }

        /// <summary>
        /// Button <see cref="PictureBox"/>
        /// </summary>
        public PictureBox Button
        {
            get
            {
                return button;
            }
        }

        /// <summary>
        /// Note <see cref="MIDI.Note"/>
        /// </summary>
        public MIDI.Note Note
        {
            get
            {
                return note;
            }
        }

        /// <summary>
        /// Velocity (0 - 127)
        /// </summary>
        public byte Velocity
        {
            get
            {
                return velocity;
            }
        }

        /// <summary>
        /// Default image <see cref="Image"/>
        /// </summary>
        public Image DefaultImage
        {
            get
            {
                return default_image;
            }
        }

        /// <summary>
        /// Pressed image <see cref="Image"/>
        /// </summary>
        public Image PressedImage
        {
            get
            {
                return pressed_image;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="PictureBox"/> "MouseDown" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PictureBox"/></param>
        /// <param name="e">Arguments <see cref="MouseEventArgs"/></param>
        private void onMouseDown(object sender, MouseEventArgs e)
        {
            button.Image = pressed_image;
            parent.MIDI.playNote(MIDI.Instrument.PianoC1, note, velocity);
        }

        /// <summary>
        /// <see cref="PictureBox"/> "MouseUp" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PictureBox"/></param>
        /// <param name="e">Arguments <see cref="MouseEventArgs"/></param>
        private void onMouseUp(object sender, MouseEventArgs e)
        {
            button.Image = default_image;
        }

        /// <summary>
        /// <see cref="PictureBox"/> "MouseLeave" event
        /// </summary>
        /// <param name="sender">Sender <see cref="PictureBox"/></param>
        /// <param name="e">Arguments</param>
        private void onMouseLeave(object sender, EventArgs e)
        {
            button.Image = default_image;
        }
        #endregion

        #region Override
        /// <summary>
        /// Dispose PianoButton
        /// </summary>
        public void Dispose()
        {
            button.MouseDown -= onMouseDown;
            button.MouseUp -= onMouseUp;
            button.MouseLeave -= onMouseLeave;
        }
        #endregion
    }
}
