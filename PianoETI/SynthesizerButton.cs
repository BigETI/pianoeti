using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;

namespace PianoETI
{
    public class SynthesizerButton
    {
        public enum Mode
        {
            Default,
            Toggle
        };

        #region Attributes
        private PictureBox button = null;
        private Mode button_mode = Mode.Default;
        private Image default_image = null;
        private Image pressed_image = null;
        private SoundEffect sound_effect = null;
        private SoundEffectInstance sound_effect_instance = null;
        private string file_name = "";
        private bool playing = false;
        #endregion

        #region Constructors
        public SynthesizerButton(PictureBox button, Mode button_mode, Image pressed_image, string file_name)
        {
            this.button = button;
            this.button_mode = button_mode;
            default_image = button.Image;
            this.pressed_image = pressed_image;
            this.file_name = file_name;
            loadSound(file_name);
            button.MouseDown += new MouseEventHandler(onButtonMouseDown);
            button.MouseUp += new MouseEventHandler(onButtonMouseUp);
            button.MouseLeave += new EventHandler(onButtonMouseLeave);
        }
        #endregion

        #region Methods
        public void play()
        {
            button.Image = pressed_image;
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
                    sound_effect_instance.Pitch = 0.0f;
                    sound_effect_instance.Volume = 1.0f;
                    sound_effect_instance.IsLooped = true;
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
            button.Image = default_image;
            playing = false;
        }

        public void loadSound(string content_name)
        {
            if (sound_effect != null)
            {
                sound_effect.Dispose();
                sound_effect = null;
            }
            try
            {
                WAV wav = new WAV(file_name);
                int len = wav.PCM.Length / ((wav.Channels > 0) ? (((int)(wav.Channels)) * 2) : 1);
                sound_effect = new SoundEffect(wav.PCM, 0, len, (int)(wav.SampleRate), wav.Channels, 0, len);
            }
            catch
            {
                //
            }
        }
        #endregion

        #region Getter/Setter
        public PictureBox Button
        {
            get
            {
                return button;
            }
        }

        public Mode ButtonMode
        {
            get
            {
                return button_mode;
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
                case Mode.Default:
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
            if (button_mode == Mode.Default)
                stop();
        }

        private void onButtonMouseLeave(object sender, EventArgs e)
        {
            if (button_mode == Mode.Default)
                stop();
        }
        #endregion
    }
}
