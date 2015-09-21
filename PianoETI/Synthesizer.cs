using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    public class Synthesizer
    {
        #region Attributes
        private Dictionary<PictureBox, SynthesizerButton> button_map = null;
        #endregion

        #region Constructors
        public Synthesizer()
        {
            button_map = new Dictionary<PictureBox, SynthesizerButton>();
        }
        #endregion

        #region Methods
        public void registerButton(PictureBox button, SynthesizerButton.Mode button_mode, Image pressed_image, string sound_file_name)
        {
            button_map.Add(button, new SynthesizerButton(button, button_mode, pressed_image, sound_file_name));
        }
        #endregion
    }
}
