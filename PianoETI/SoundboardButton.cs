using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;
using System.IO;

namespace PianoETI
{
    public class SoundboardButton
    {
        public enum Mode
        {
            PressOnly,
            Toggle,
            Click
        };

        #region Attributes
        private Soundboard parent = null;
        private PictureBox picture_box = null;
        private Mode button_mode = Mode.PressOnly;
        private float pitch = 0.0f;
        private float volume = 1.0f;
        private bool loop = false;
        private Fraction fraction = null;
        private Image default_image = null;
        private Image pressed_image = null;
        private SoundEffect sound_effect = null;
        private SoundEffectInstance sound_effect_instance = null;
        private string file_name = "";
        private bool playing = false;
        #endregion

        #region Constructors
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

        public void stop()
        {
            if (sound_effect_instance != null)
                sound_effect_instance.Stop();
            if (picture_box != null) picture_box.Image = default_image;
            playing = false;
        }

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

        public Soundboard Parent
        {
            get
            {
                return parent;
            }
        }

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

        public Image DefaultImage
        {
            get
            {
                return default_image;
            }
        }

        public Image PressedImage
        {
            get
            {
                return pressed_image;
            }
        }

        public SoundEffect SoundEffect
        {
            get
            {
                return sound_effect;
            }
        }
        #endregion

        #region Events
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
