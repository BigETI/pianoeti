﻿using System;
using System.Runtime.InteropServices;

namespace PianoETI
{
    /// <summary>
    /// <see cref="MIDIOutCaps"/> class
    /// </summary>
    public class MIDIOutCaps
    {
        public UInt16 wMid;
        public UInt16 wPid;
        public UInt32 vDriverVersion;

        [MarshalAs(UnmanagedType.ByValTStr,
           SizeConst = 32)]
        public String szPname;

        public UInt16 wTechnology;
        public UInt16 wVoices;
        public UInt16 wNotes;
        public UInt16 wChannelMask;
        public UInt32 dwSupport;
    }
}
