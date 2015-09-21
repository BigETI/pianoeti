namespace PianoETI
{
    class MIDIEventArgs
    {
        #region Attributes
        private MIDI midi;
        private int msg;
        private int instance;
        private int param1;
        private int param2;
        #endregion

        #region Getter/Setter
        public MIDI Midi
        {
            get
            {
                return midi;
            }
        }

        public int Msg
        {
            get
            {
                return msg;
            }
        }

        public int Instance
        {
            get
            {
                return instance;
            }
        }

        public int Param1
        {
            get
            {
                return param1;
            }
        }

        public int Param2
        {
            get
            {
                return param2;
            }
        }

        public MIDI.Note Note
        {
            get
            {
                return (MIDI.Note)((msg >> 8) & 0xFF);
            }
        }
        #endregion

        #region Constructors
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
