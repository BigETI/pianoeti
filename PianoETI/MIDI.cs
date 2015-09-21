using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PianoETI
{
    /// <summary>
    /// MIDI class
    /// </summary>
    public class MIDI
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

        #region Enums
        public enum Instrument
        {
            PianoOffC1 = 0x80,
            PianoOffC2 = 0x81,
            PianoOffC3 = 0x82,
            PianoOffC4 = 0x83,
            PianoOffC5 = 0x84,
            PianoOffC6 = 0x85,
            PianoOffC7 = 0x86,
            PianoOffC8 = 0x87,
            PianoOffC9 = 0x88,
            PianoOffC10 = 0x89,
            PianoOffC11 = 0x8A,
            PianoOffC12 = 0x8B,
            PianoOffC13 = 0x8C,
            PianoOffC14 = 0x8D,
            PianoOffC15 = 0x8E,
            PianoOffC16 = 0x8F,

            PianoC1 = 0x90,
            PianoC2 = 0x91,
            PianoC3 = 0x92,
            PianoC4 = 0x93,
            PianoC5 = 0x94,
            PianoC6 = 0x95,
            PianoC7 = 0x96,
            PianoC8 = 0x97,
            PianoC9 = 0x98,
            PianoC10 = 0x99,
            PianoC11 = 0x9A,
            PianoC12 = 0x9B,
            PianoC13 = 0x9C,
            PianoC14 = 0x9D,
            PianoC15 = 0x9E,
            PianoC16 = 0x9F,

            PianoAftertouchC1 = 0xA0,
            PianoAftertouchC2 = 0xA1,
            PianoAftertouchC3 = 0xA2,
            PianoAftertouchC4 = 0xA3,
            PianoAftertouchC5 = 0xA4,
            PianoAftertouchC6 = 0xA5,
            PianoAftertouchC7 = 0xA6,
            PianoAftertouchC8 = 0xA7,
            PianoAftertouchC9 = 0xA8,
            PianoAftertouchC10 = 0xA9,
            PianoAftertouchC11 = 0xAA,
            PianoAftertouchC12 = 0xAB,
            PianoAftertouchC13 = 0xAC,
            PianoAftertouchC14 = 0xAD,
            PianoAftertouchC15 = 0xAE,
            PianoAftertouchC16 = 0xAF,
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

        #region Delegates
        private delegate void MidiCallBack(int handle, int msg, int instance, int param1, int param2);

        public delegate void MessageCallback(object sender, MIDIEventArgs e);
        #endregion

        #region Attributes
        private int midi_handle = 0;

        public event MessageCallback MessageEvent;
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
