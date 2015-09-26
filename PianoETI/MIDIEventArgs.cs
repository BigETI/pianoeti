namespace PianoETI
{
    /// <summary>
    /// <see cref="MIDIEventArgs"/> class
    /// </summary>
    public class MIDIEventArgs
    {
        #region Attributes
        /// <summary>
        /// MIDI instance
        /// </summary>
        private MIDI midi;

        /// <summary>
        /// MIDI message
        /// </summary>
        private int msg;

        /// <summary>
        /// MIDI instance
        /// </summary>
        private int instance;

        /// <summary>
        /// MIDI 1. param
        /// </summary>
        private int param1;

        /// <summary>
        /// MIDI 2. param
        /// </summary>
        private int param2;
        #endregion

        #region Getter/Setter
        /// <summary>
        /// <see cref="MIDI"/> instance
        /// </summary>
        public MIDI Midi
        {
            get
            {
                return midi;
            }
        }

        /// <summary>
        /// MIDI message
        /// </summary>
        public int Msg
        {
            get
            {
                return msg;
            }
        }

        /// <summary>
        /// MIDI instance
        /// </summary>
        public int Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// MIDI 1. param
        /// </summary>
        public int Param1
        {
            get
            {
                return param1;
            }
        }

        /// <summary>
        /// MIDI 2. param
        /// </summary>
        public int Param2
        {
            get
            {
                return param2;
            }
        }

        /// <summary>
        /// MIDI note <see cref="MIDI.Note"/>
        /// </summary>
        public MIDI.Note Note
        {
            get
            {
                return (MIDI.Note)((msg >> 8) & 0xFF);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="MIDIEventArgs"/> instance
        /// </summary>
        /// <param name="midi"><see cref="MIDI"/> instance</param>
        /// <param name="msg">MIDI message</param>
        /// <param name="instance">MIDI instance</param>
        /// <param name="param1">MIDI 1. param</param>
        /// <param name="param2">MIDI 2. param</param>
        public MIDIEventArgs(MIDI midi, int msg, int instance, int param1, int param2)
        {
            this.midi = midi;
            this.msg = msg;
            this.instance = instance;
            this.param1 = param1;
            this.param2 = param2;
        }
        #endregion
    }
}
