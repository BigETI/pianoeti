using System;
using System.Runtime.InteropServices;

namespace PianoETI
{
    /// <summary>
    /// <see cref="MIDIOutCaps"/> class
    /// </summary>
    public class MIDIOutCaps
    {
        /// <summary>
        /// wMid
        /// </summary>
        public UInt16 wMid;

        /// <summary>
        /// wPid
        /// </summary>
        public UInt16 wPid;

        /// <summary>
        /// vDriverVersion
        /// </summary>
        public UInt32 vDriverVersion;

        /// <summary>
        /// szPname
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr,
           SizeConst = 32)]
        public String szPname;

        /// <summary>
        /// wTechnology
        /// </summary>
        public UInt16 wTechnology;

        /// <summary>
        /// wVoices
        /// </summary>
        public UInt16 wVoices;

        /// <summary>
        /// wNotes
        /// </summary>
        public UInt16 wNotes;

        /// <summary>
        /// wChannelMask
        /// </summary>
        public UInt16 wChannelMask;

        /// <summary>
        /// dwSupport
        /// </summary>
        public UInt32 dwSupport;
    }
}
