using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;
using System.IO;

namespace PianoETI
{
    /// <summary>
    /// <see cref="SoundboardButton"/> class
    /// </summary>
    public class SoundboardButton
    {
        #region Enums
        /// <summary>
        /// Button mode
        /// </summary>
        public enum Mode
        {
            /// <summary>
            /// Press only mode
            /// </summary>
            PressOnly,

            /// <summary>
            /// Toggle mode
            /// </summary>
            Toggle,

            /// <summary>
            /// Click mode
            /// </summary>
            Click
        };
        #endregion

        #region Attributes
        /// <summary>
        /// Parent <see cref="Soundboard"/>
        /// </summary>
        private Soundboard parent = null;

        /// <summary>
        /// Button <see cref="PictureBox"/>
        /// </summary>
        private PictureBox picture_box = null;

        /// <summary>
        /// Button mode <see cref="Mode"/>
        /// </summary>
        private Mode button_mode = Mode.PressOnly;

        /// <summary>
        /// Pitch (factor)
        /// </summary>
        private float pitch = 0.0f;

        /// <summary>
        /// Volume (factor)
        /// </summary>
        private float volume = 1.0f;

        /// <summary>
        /// Is looping?
        /// </summary>
        private bool loop = false;

        /// <summary>
        /// Time fraction <see cref="PianoETI.Fraction"/>
        /// </summary>
        private Fraction fraction = null;

        /// <summary>
        /// Default image <see cref="Image"/>
        /// </summary>
        private Image default_image = null;

        /// <summary>
        /// Pressed Image <see cref="Image"/>
        /// </summary>
        private Image pressed_image = null;

        /// <summary>
        /// <see cref="Microsoft.Xna.Framework.Audio.SoundEffect"/> instance
        /// </summary>
        private SoundEffect sound_effect = null;

        /// <summary>
        /// <see cref="SoundEffectInstance"/> instance
        /// </summary>
        private SoundEffectInstance sound_effect_instance = null;

        /// <summary>
        /// File name
        /// </summary>
        private string file_name = "";

        /// <summary>
        /// Is playing?
        /// </summary>
        private bool playing = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="SoundboardButton"/> instance
        /// </summary>
        /// <param name="parent">Parent <see cref="Soundboard"/></param>
        /// <param name="soundboard_button"><see cref="SoundboardButton"/> instance</param>
        public SoundboardButton(Soundboard parent, SoundboardButton soundboard_button)
        {
            this.parent = parent;
            button_mode = soundboard_button.button_mode;
            pitch = soundboard_button.pitch;
            volume = soundboard_button.volume;
            loop = soundboard_button.loop;
            PictureBox = soundboard_button.picture_box;
            fraction = new Fraction(soundboard_button.fraction);
            if (fraction.get() > 1.0)
                fraction = new Fraction(1);
            pressed_image = soundboard_button.pressed_image;
            FileName = soundboard_button.file_name;
        }

        /// <summary>
        /// Creates a <see cref="SoundboardButton"/> instance
        /// </summary>
        /// <param name="parent">Parent <see cref="Soundboard"/></param>
        /// <param name="button_mode">Button mode <see cref="Mode"/></param>
        /// <param name="pitch">Pitch (fraction)</param>
        /// <param name="volume">Volume (fraction)</param>
        /// <param name="loop">Is looping?</param>
        /// <param name="fraction">Fraction <see cref="PianoETI.Fraction"/></param>
        /// <param name="pressed_image">Pressed image <see cref="Image"/></param>
        /// <param name="file_name">File name</param>
        /// <param name="picture_box"><see cref="PictureBox"/> instance</param>
        public SoundboardButton(Soundboard parent, Mode button_mode, float pitch, float volume, bool loop, Fraction fraction, Image pressed_image, string file_name, PictureBox picture_box)
        {
            this.parent = parent;
            this.button_mode = button_mode;
            this.pitch = pitch;
            this.volume = volume;
            this.loop = loop;
            PictureBox = picture_box;
            this.fraction = new Fraction(fraction);
            if (this.fraction.get() > 1.0)
                this.fraction = new Fraction(1);
            this.pressed_image = pressed_image;
            FileName = file_name;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets name by button mode <see cref="Mode"/>
        /// </summary>
        /// <param name="mode">Button mode <see cref="Mode"/></param>
        /// <returns>Button mode name</returns>
        public static string getNameByMode(Mode mode)
        {
            string ret = "unknown";
            switch(mode)
            {
                case Mode.PressOnly:
                    ret = "press_only";
                    break;
                case Mode.Toggle:
                    ret = "toggle";
                    return ret;
                case Mode.Click:
                    ret = "click";
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Gets button mode <see cref="Mode"/> by button mode name
        /// </summary>
        /// <param name="mode_name">button mode name</param>
        /// <returns>Button mode <see cref="Mode"/></returns>
        public static Mode getModeByName(string mode_name)
        {
            Mode ret = Mode.PressOnly;
            switch (mode_name.Trim().ToLower())
            {
                case "press_only":
                    ret = Mode.PressOnly;
                    break;
                case "toggle":
                    ret = Mode.Toggle;
                    return ret;
                case "click":
                    ret = Mode.Click;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Plays the sound effect
        /// </summary>
        public void play()
        {
            if (picture_box != null) picture_box.Image = pressed_image;
            try
            {
                if (sound_effect_instance != null)
                {
                    sound_effect_instance.Stop();
                    sound_effect_instance.Dispose();
                }
                if (sound_effect != null)
                {
                    sound_effect_instance = sound_effect.CreateInstance();
                    sound_effect_instance.Pitch = pitch;
                    sound_effect_instance.Volume = volume;
                    sound_effect_instance.IsLooped = loop;
                    sound_effect_instance.Play();
                }
            }
            catch
            {
                //
            }
            playing = true;
        }

        /// <summary>
        /// Stops the sound effect
        /// </summary>
        public void stop()
        {
            if (sound_effect_instance != null)
                sound_effect_instance.Stop();
            if (picture_box != null) picture_box.Image = default_image;
            playing = false;
        }

        /// <summary>
        /// Reloads sound effect
        /// </summary>
        public void reloadSoundEffect()
        {
            if (sound_effect_instance != null)
            {
                sound_effect_instance.Stop();
                sound_effect_instance.Dispose();
                sound_effect_instance = null;
            }
            if (sound_effect != null)
            {
                sound_effect.Dispose();
                sound_effect = null;
            }
            try
            {
                if (File.Exists(file_name))
                {
                    WAV wav = new WAV(file_name);
                    int len = (int)(((wav.PCM.Length / ((wav.Channels > 0) ? (((int)(wav.Channels)) * 2) : 1)) * fraction.Numerator) / fraction.Divisor);
                    sound_effect = new SoundEffect(wav.PCM, 0, len, (int)(wav.SampleRate), wav.Channels, 0, len);
                    if (playing)
                        play();
                }
            }
            catch
            {
                //
            }
        }

        /// <summary>
        /// Disposes <see cref="SoundboardButton"/>
        /// </summary>
        public void dispose()
        {
            if (picture_box != null)
            {
                picture_box.MouseDown -= onButtonMouseDown;
                picture_box.MouseUp -= onButtonMouseUp;
                picture_box.MouseLeave -= onButtonMouseLeave;
            }
            stop();
            if (sound_effect != null)
                sound_effect.Dispose();
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// <see cref="System.Windows.Forms.PictureBox"/> instance
        /// </summary>
        public PictureBox PictureBox
        {
            get
            {
                return picture_box;
            }
            set
            {
                if (picture_box != value)
                {
                    if (picture_box != null)
                    {
                        picture_box.MouseDown -= onButtonMouseDown;
                        picture_box.MouseUp -= onButtonMouseUp;
                        picture_box.MouseLeave -= onButtonMouseLeave;
                        picture_box.Image = default_image;
                    }
                    picture_box = value;
                    if (picture_box != null)
                    {
                        picture_box.MouseDown += onButtonMouseDown;
                        picture_box.MouseUp += onButtonMouseUp;
                        picture_box.MouseLeave += onButtonMouseLeave;
                        default_image = picture_box.Image;
                    }
                    parent.assignPictureBox(this, picture_box);
                }
            }
        }

        /// <summary>
        /// Parent <see cref="Soundboard"/>
        /// </summary>
        public Soundboard Parent
        {
            get
            {
                return parent;
            }
        }

        /// <summary>
        /// Button mode <see cref="Mode"/>
        /// </summary>
        public Mode ButtonMode
        {
            get
            {
                return button_mode;
            }
            set
            {
                stop();
                button_mode = value;
            }
        }

        /// <summary>
        /// Pitch (factor)
        /// </summary>
        public float Pitch
        {
            get
            {
                return pitch;
            }
            set
            {
                pitch = value;
                if (sound_effect_instance != null)
                    sound_effect_instance.Pitch = value;
            }
        }

        /// <summary>
        /// Volume (factor)
        /// </summary>
        public float Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
                if (sound_effect_instance != null)
                    sound_effect_instance.Volume = value;
            }
        }

        /// <summary>
        /// Is looping?
        /// </summary>
        public bool Loop
        {
            get
            {
                return loop;
            }
            set
            {
                loop = value;
                if (sound_effect_instance != null)
                    sound_effect_instance.IsLooped = value;
            }
        }

        /// <summary>
        /// Time fraction <see cref="PianoETI.Fraction"/>
        /// </summary>
        public Fraction Fraction
        {
            get
            {
                return fraction;
            }
            set
            {
                fraction = new Fraction(value);
                if (fraction.Divisor < fraction.Numerator)
                    fraction = new Fraction(1);
                reloadSoundEffect();
            }
        }

        /// <summary>
        /// File name
        /// </summary>
        public string FileName
        {
            get
            {
                return file_name;
            }
            set
            {
                file_name = value;
                reloadSoundEffect();
            }
        }

        /// <summary>
        /// Default image <see cref="Image"/>
        /// </summary>
        public Image DefaultImage
        {
            get
            {
                return default_image;
            }
        }

        /// <summary>
        /// Presse image <see cref="Image"/>
        /// </summary>
        public Image PressedImage
        {
            get
            {
                return pressed_image;
            }
        }

        /// <summary>
        /// <see cref="Microsoft.Xna.Framework.Audio.SoundEffect"/> instance
        /// </summary>
        public SoundEffect SoundEffect
        {
            get
            {
                return sound_effect;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="System.Windows.Forms.PictureBox"/> "MouseDown" event
        /// </summary>
        /// <param name="sender">Sender <see cref="System.Windows.Forms.PictureBox"/></param>
        /// <param name="e">Arguments <see cref="MouseEventArgs"/></param>
        private void onButtonMouseDown(object sender, MouseEventArgs e)
        {
            switch(button_mode)
            {
                case Mode.PressOnly:
                case Mode.Click:
                    play();
                    break;
                case Mode.Toggle:
                    if (playing)
                        stop();
                    else
                        play();
                    break;
            }
            
        }

        /// <summary>
        /// <see cref="System.Windows.Forms.PictureBox"/> "MouseUo" event
        /// </summary>
        /// <param name="sender">Sender <see cref="System.Windows.Forms.PictureBox"/></param>
        /// <param name="e">Arguments <see cref="MouseEventArgs"/></param>
        private void onButtonMouseUp(object sender, MouseEventArgs e)
        {
            switch (button_mode)
            {
                case Mode.PressOnly:
                    stop();
                    break;
                case Mode.Click:
                    picture_box.Image = default_image;
                    break;
            }
        }

        /// <summary>
        /// <see cref="System.Windows.Forms.PictureBox"/> "MouseLeave" event
        /// </summary>
        /// <param name="sender">Sender <see cref="System.Windows.Forms.PictureBox"/></param>
        /// <param name="e">Arguments</param>
        private void onButtonMouseLeave(object sender, EventArgs e)
        {
            switch(button_mode)
            {
                case Mode.PressOnly:
                    stop();
                    break;
                case Mode.Click:
                    picture_box.Image = default_image;
                    break;
            }
        }
        #endregion
    }
}
