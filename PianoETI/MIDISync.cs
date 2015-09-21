using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    class MIDISync
    {
        #region Attributes
        private MIDI midi = null;
        private Dictionary<MIDI.Note, LinkedList<PianoButton>> midi_control_map = null;
        #endregion

        #region Constructors
        public MIDISync()
        {
            midi_control_map = new Dictionary<MIDI.Note, LinkedList<PianoButton>>();
            midi = new MIDI();
            midi.MessageEvent += new MIDI.MessageCallback(onMessage);
        }
        #endregion

        #region Methods
        public void open()
        {
            midi.open();
        }

        public void close()
        {
            midi.close();
        }

        public void registerPianoButton(PictureBox button, MIDI.Note note, byte velocity, Image pressed_image)
        {
            if (!midi_control_map.ContainsKey(note))
                midi_control_map.Add(note, new LinkedList<PianoButton>());
            midi_control_map[note].AddLast(new PianoButton(this, button, note, velocity, pressed_image));
        }
        #endregion

        #region Getter/Setter
        public MIDI MIDI
        {
            get
            {
                return midi;
            }
        }
        #endregion

        #region Events
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
