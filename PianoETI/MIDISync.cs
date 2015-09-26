using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="MIDISync"/> class
    /// </summary>
    public class MIDISync
    {
        #region Attributes
        /// <summary>
        /// <see cref="MIDI"/> instance
        /// </summary>
        private MIDI midi = null;

        /// <summary>
        /// <see cref="MIDI.Note"/> <see cref="LinkedList{PianoButton}"/> dictionary
        /// </summary>
        private Dictionary<MIDI.Note, LinkedList<PianoButton>> midi_control_map = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="MIDISync"/> instance
        /// </summary>
        public MIDISync()
        {
            midi_control_map = new Dictionary<MIDI.Note, LinkedList<PianoButton>>();
            midi = new MIDI();
            midi.MessageEvent += new MIDI.MessageCallback(onMessage);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Opens the MIDI handle
        /// </summary>
        public void open()
        {
            midi.open();
        }

        /// <summary>
        /// Closes the MIDI handle
        /// </summary>
        public void close()
        {
            midi.close();
        }

        /// <summary>
        /// Registers a piano button
        /// </summary>
        /// <param name="button">Button <see cref="PictureBox"/></param>
        /// <param name="note">Note <see cref="MIDI.Note"/></param>
        /// <param name="velocity">Velocity (0 - 127)</param>
        /// <param name="pressed_image">Pressed image <see cref="Image"/></param>
        public void registerPianoButton(PictureBox button, MIDI.Note note, byte velocity, Image pressed_image)
        {
            if (!midi_control_map.ContainsKey(note))
                midi_control_map.Add(note, new LinkedList<PianoButton>());
            midi_control_map[note].AddLast(new PianoButton(this, button, note, velocity, pressed_image));
        }

        /// <summary>
        /// Removes a piano button
        /// </summary>
        /// <param name="note">Note <see cref="MIDI.Note"/></param>
        public void removePianoButtons(MIDI.Note note)
        {
            if (midi_control_map.ContainsKey(note))
            {
                LinkedList<PianoButton> button_list = midi_control_map[note];
                foreach (PianoButton i in button_list)
                    i.Dispose();
                button_list.Clear();
                midi_control_map.Remove(note);
            }
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// MIDI instance
        /// </summary>
        public MIDI MIDI
        {
            get
            {
                return midi;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="MIDI"/> MessageEvent event (To-Do)
        /// </summary>
        /// <param name="sender">Sender <see cref="MIDI"/></param>
        /// <param name="e">Arguments</param>
        private void onMessage(object sender, MIDIEventArgs e)
        {
            if (midi_control_map.ContainsKey(e.Note))
            {
                foreach (PianoButton i in midi_control_map[e.Note])
                {
                    //i.Image = 
                }
            }
        }
        #endregion
    }
}
