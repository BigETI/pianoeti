using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PianoETI
{
    /// <summary>
    /// MIDI class
    /// </summary>
    class MIDI
    {
        #region DLL imports
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

        [DllImport("winmm.dll")]
        private static extern int midiOutGetNumDevs();

        [DllImport("winmm.dll")]
        private static extern int midiOutGetDevCaps(Int32 uDeviceID, ref MIDIOutCaps lpMidiOutCaps, UInt32 cbMidiOutCaps);

        [DllImport("winmm.dll")]
        private static extern int midiOutOpen(ref int handle, int deviceID, MidiCallBack proc, int instance, int flags);

        [DllImport("winmm.dll")]
        protected static extern int midiOutShortMsg(int handle, int message);

        [DllImport("winmm.dll")]
        protected static extern int midiOutClose(int handle);
        #endregion

        #region Events
        private delegate void MidiCallBack(int handle, int msg, int instance, int param1, int param2);
        #endregion

        #region Enums
        public enum Instrument
        {
            Piano = 0x90
        };

        public enum Note
        {
            CM1, CFM1, DM1, DFM1, EM1, FM1, FFM1, GM1, GFM1, AM1, AFM1, BM1,
            C0, CF0, D0, DF0, E0, F0, FF0, G0, GF0, A0, AF0, B0,
            C1, CF1, D1, DF1, E1, F1, FF1, G1, GF1, A1, AF1, B1,
            C2, CF2, D2, DF2, E2, F2, FF2, G2, GF2, A2, AF2, B2,
            C3, CF3, D3, DF3, E3, F3, FF3, G3, GF3, A3, AF3, B3,
            C4, CF4, D4, DF4, E4, F4, FF4, G4, GF4, A4, AF4, B4,
            C5, CF5, D5, DF5, E5, F5, FF5, G5, GF5, A5, AF5, B5,
            C6, CF6, D6, DF6, E6, F6, FF6, G6, GF6, A6, AF6, B6,
            C7, CF7, D7, DF7, E7, F7, FF7, G7, GF7, A7, AF7, B7,
            C8, CF8, D8, DF8, E8, F8, FF8, G8, GF8, A8, AF8, B8,
            C9, CF9, D9, DF9, E9, F9, FF9, G9
        }
        #endregion

        #region Attributes
        private int midi_handle = 0;
        #endregion

        #region Constructors
        public MIDI()
        {
            open();
        }
        #endregion

        #region Methods
        public void close()
        {
            if (midi_handle != 0)
                midiOutClose(midi_handle);
                midi_handle = 0;
        }

        public void open()
        {
            if (midi_handle == 0)
                midiOutOpen(ref midi_handle, 0, null, 0, 0);
        }

        public bool isOpen()
        {
            return (midi_handle != 0);
        }

        public void playNote(Instrument instrument, Note note, byte velocity)
        {
            if (midi_handle != 0)
                midiOutShortMsg(midi_handle, (((int)velocity) << 16) | (((int)note) << 8) | ((int)(instrument)));
        }
        #endregion
    }
}
