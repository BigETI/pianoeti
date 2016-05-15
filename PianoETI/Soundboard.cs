using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace PianoETI
{
    /// <summary>
    /// <see cref="Soundboard"/> class
    /// </summary>
    public class Soundboard
    {
        #region Attributes
        /// <summary>
        /// <see cref="SoundboardButton"/> <see cref="PictureBox"/> dictionary
        /// </summary>
        private Dictionary<SoundboardButton, PictureBox> button_map = null;

        /// <summary>
        /// Profile name
        /// </summary>
        private string profile_name;

        /// <summary>
        /// Button count
        /// </summary>
        private uint count = 0;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="Soundboard"/> instance
        /// </summary>
        /// <param name="soundboard"><see cref="Soundboard"/></param>
        public Soundboard(Soundboard soundboard)
        {
            button_map = new Dictionary<SoundboardButton, PictureBox>();
            if (soundboard == null)
                profile_name = "";
            else
            {
                profile_name = soundboard.profile_name;
                foreach (KeyValuePair<SoundboardButton, PictureBox> i in soundboard.button_map)
                {
                    button_map.Add(new SoundboardButton(this, i.Key), i.Value);
                    count++;
                }
            }
        }

        /// <summary>
        /// Creates a <see cref="Soundboard"/> instance
        /// </summary>
        /// <param name="profile_name">Profile name</param>
        public Soundboard(string profile_name = "")
        {
            ProfileName = profile_name;
            button_map = new Dictionary<SoundboardButton, PictureBox>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Loads from a (*.pest) file
        /// </summary>
        /// <param name="file_name">File name (*.pest)</param>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool loadFromFile(string file_name)
        {
            bool ret = false;
            string profile_name = "", _file_name;
            float volume, pitch;
            bool loop;
            Fraction fraction;
            SoundboardButton.Mode mode;
            XmlReader sub_xml_reader, sub_sub_xml_reader;
            removeAllButtons();
            using (XmlReader reader = XmlReader.Create(file_name))
            {
                if (reader.ReadToFollowing("soundboard"))
                {
                    sub_xml_reader = reader.ReadSubtree();
                    if (sub_xml_reader.ReadToFollowing("profile"))
                    {
                        profile_name = sub_xml_reader.ReadElementContentAsString();
                        while (sub_xml_reader.ReadToFollowing("button"))
                        {
                            _file_name = "";
                            volume = 1.0f;
                            pitch = 0.0f;
                            mode = SoundboardButton.Mode.PressOnly;
                            loop = false;
                            fraction = new Fraction(1);
                            sub_sub_xml_reader = sub_xml_reader.ReadSubtree();
                            while (!sub_sub_xml_reader.EOF)
                            {
                                if (sub_sub_xml_reader.NodeType == XmlNodeType.Element)
                                {
                                    switch (sub_sub_xml_reader.Name.ToLower().Trim())
                                    {
                                        case "file":
                                            _file_name = sub_sub_xml_reader.ReadElementContentAsString();
                                            break;
                                        case "volume":
                                            volume = (float)(Convert.ToDouble(sub_sub_xml_reader.ReadElementContentAsString()));
                                            break;
                                        case "pitch":
                                            pitch = (float)(Convert.ToDouble(sub_sub_xml_reader.ReadElementContentAsString()));
                                            break;
                                        case "mode":
                                            mode = SoundboardButton.getModeByName(sub_sub_xml_reader.ReadElementContentAsString());
                                            break;
                                        case "loop":
                                            loop = Convert.ToBoolean(sub_sub_xml_reader.ReadElementContentAsString());
                                            break;
                                        case "fraction":
                                            fraction = Fraction.parse(sub_sub_xml_reader.ReadElementContentAsString());
                                            break;
                                        default:
                                            sub_sub_xml_reader.Read();
                                            break;
                                    }
                                }
                                else
                                    sub_sub_xml_reader.Read();
                            }
                            createButton(mode, pitch, volume, loop, fraction, Properties.Resources.SoundboardButton_pressed, _file_name);
                        }
                        ProfileName = profile_name;
                        ret = true;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Saves to a (*.pest) file
        /// </summary>
        /// <param name="file_name">File name (*.pest)</param>
        /// <returns>"true" if successful, otherwise "false"</returns>
        public bool saveToFile(string file_name)
        {
            bool ret = false;
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using (XmlWriter writer = XmlWriter.Create(file_name, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("soundboard");
                writer.WriteElementString("profile", profile_name);
                foreach (KeyValuePair<SoundboardButton, PictureBox> i in button_map)
                {
                    writer.WriteStartElement("button");
                    writer.WriteElementString("file", i.Key.FileName);
                    writer.WriteElementString("volume", i.Key.Volume.ToString());
                    writer.WriteElementString("pitch", i.Key.Pitch.ToString());
                    writer.WriteElementString("mode", SoundboardButton.getNameByMode(i.Key.ButtonMode));
                    writer.WriteElementString("loop", i.Key.Loop.ToString());
                    writer.WriteElementString("fraction", i.Key.Fraction.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                ret = true;
            }
            return ret;
        }

        /// <summary>
        /// Creates a button <see cref="SoundboardButton"/>
        /// </summary>
        /// <param name="button_mode">Button mode <see cref="SoundboardButton.Mode"/></param>
        /// <param name="pitch">Pitch (factor)</param>
        /// <param name="volume">Volume (factor)</param>
        /// <param name="loop">Loop (factor)</param>
        /// <param name="fraction">Fraction (length) <see cref="Fraction"/></param>
        /// <param name="pressed_image">Pressed image <see cref="Image"/></param>
        /// <param name="sound_file_name">Sound file name</param>
        /// <param name="picture_box">Button <see cref="PictureBox"/></param>
        /// <returns></returns>
        public SoundboardButton createButton(SoundboardButton.Mode button_mode, float pitch, float volume, bool loop, Fraction fraction, Image pressed_image, string sound_file_name, PictureBox picture_box = null)
        {
            SoundboardButton ret = new SoundboardButton(this, button_mode, pitch, volume, loop, fraction, pressed_image, sound_file_name, picture_box);
            button_map.Add(ret, picture_box);
            count++;
            return ret;
        }

        /// <summary>
        /// Assigns a <see cref="PictureBox"/> button to a <see cref="SoundboardButton"/> instance
        /// </summary>
        /// <param name="soundboard_button"><see cref="SoundboardButton"/> instance</param>
        /// <param name="picture_box">Button <see cref="PictureBox"/></param>
        public void assignPictureBox(SoundboardButton soundboard_button, PictureBox picture_box)
        {
            if (button_map.ContainsKey(soundboard_button))
            {
                button_map[soundboard_button] = picture_box;
                soundboard_button.PictureBox = picture_box;
            }
        }

        /// <summary>
        /// Unassigns all <see cref="PictureBox"/> buttons
        /// </summary>
        public void unassignAllPictureBoxes()
        {
            Dictionary<SoundboardButton, PictureBox> button_map = new Dictionary<SoundboardButton, PictureBox>();
            foreach (KeyValuePair<SoundboardButton, PictureBox> i in this.button_map)
            {
                button_map.Add(i.Key, null);
            }
            foreach(KeyValuePair<SoundboardButton, PictureBox> i in button_map)
            {
                i.Key.PictureBox = null;
            }
            this.button_map.Clear();
            this.button_map = button_map;
        }

        /// <summary>
        /// Removes a <see cref="PictureBox"/> button to a <see cref="SoundboardButton"/> instance
        /// </summary>
        /// <param name="button"><see cref="SoundboardButton"/> instance</param>
        public void removeButton(SoundboardButton button)
        {
            if (button_map.ContainsKey(button))
            {
                button.dispose();
                button_map.Remove(button);
                count--;
            }
        }

        /// <summary>
        /// Removes all buttons
        /// </summary>
        public void removeAllButtons()
        {
            foreach (KeyValuePair<SoundboardButton, PictureBox> i in button_map)
                i.Key.dispose();
            button_map.Clear();
            count = 0;
        }

        /// <summary>
        /// Disposes this instance
        /// </summary>
        public void dispose()
        {
            removeAllButtons();
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// Button count
        /// </summary>
        public uint Count
        {
            get
            {
                return count;
            }
        }

        /// <summary>
        /// <see cref="SoundboardButton"/> <see cref="PictureBox"/> dictionary
        /// </summary>
        public Dictionary<SoundboardButton, PictureBox> ButtonMap
        {
            get
            {
                return button_map;
            }
        }

        /// <summary>
        /// Profile name
        /// </summary>
        public string ProfileName
        {
            get
            {
                return profile_name;
            }
            set
            {
                char[] c = value.ToCharArray();
                for (int i = 0; i < c.Length; i++)
                {
                    if ((c[i] == '<') || (c[i] == '>'))
                        c[i] = '_';
                }
                profile_name = new string(c);
            }
        }
        #endregion
    }
}
