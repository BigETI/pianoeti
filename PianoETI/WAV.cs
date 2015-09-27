using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="WAV"/> class
    /// </summary>
    public class WAV
    {
        #region Attributes
        /// <summary>
        /// Header data
        /// </summary>
        public static readonly byte[] header_data = { (byte)'R', (byte)'I', (byte)'F', (byte)'F' };

        /// <summary>
        /// File size
        /// </summary>
        private uint file_size = 0;

        /// <summary>
        /// Sample rate
        /// </summary>
        private uint sample_rate = 0;

        /// <summary>
        /// Audio channels <see cref="AudioChannels"/>
        /// </summary>
        private AudioChannels channels;

        /// <summary>
        /// PCM
        /// </summary>
        private byte[] pcm;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="WAV"/> instance
        /// </summary>
        /// <param name="file_name">File name</param>
        public WAV(string file_name)
        {
            byte[] buf = new byte[4];
            try
            {
                FileStream fs = new FileStream(file_name, FileMode.Open);
                pcm = new byte[fs.Length - 0x2C];
                fs.Read(buf, 0, 0x4);
                if(((IStructuralEquatable)buf).Equals(header_data, StructuralComparisons.StructuralEqualityComparer))
                {
                    fs.Read(buf, 0x0, 0x4);
                    file_size = buf[0] | (((uint)(buf[1])) << 8) | (((uint)(buf[2])) << 16) | (((uint)(buf[3])) << 24);

                    fs.Seek(0x16, SeekOrigin.Begin);
                    fs.Read(buf, 0x0, 0x2);
                    channels = (AudioChannels)(buf[0] | (((uint)(buf[1])) << 8));

                    fs.Read(buf, 0x0, 0x4);
                    sample_rate = buf[0] | (((uint)(buf[1])) << 8) | (((uint)(buf[2])) << 16) | (((uint)(buf[3])) << 24);

                    fs.Seek(0x2C, SeekOrigin.Begin);
                    fs.Read(pcm, 0x0, (int)(fs.Length - 0x2C));
                }
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Runtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates a <see cref="WAV"/> instance
        /// </summary>
        /// <param name="wav"><see cref="WAV"/> instance</param>
        public WAV(WAV wav)
        {
            file_size = wav.file_size;
            sample_rate = wav.sample_rate;
            channels = wav.channels;
            pcm = (byte[])(wav.pcm.Clone());
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// File size
        /// </summary>
        public uint FileSize
        {
            get
            {
                return file_size;
            }
        }

        /// <summary>
        /// Sample rate
        /// </summary>
        public uint SampleRate
        {
            get
            {
                return sample_rate;
            }
        }

        /// <summary>
        /// Audio channels <see cref="AudioChannels"/>
        /// </summary>
        public AudioChannels Channels
        {
            get
            {
                return channels;
            }
        }

        /// <summary>
        /// PCM
        /// </summary>
        public byte[] PCM
        {
            get
            {
                return pcm;
            }
        }
        #endregion
    }
}
