using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// <see cref="SoundboardForm"/> class
    /// </summary>
    public partial class SoundboardForm : Form
    {
        #region Attributes
        /// <summary>
        /// <see cref="PianoETI.Soundboard"/> instance
        /// </summary>
        private Soundboard soundboard = null;

        /// <summary>
        /// Show wizard?
        /// </summary>
        private bool show_wizard = false;

        /// <summary>
        /// File name
        /// </summary>
        private string file_name = "";

        /// <summary>
        /// <see cref="PictureBox"/> buttons
        /// </summary>
        private PictureBox[] picture_box_arr;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="SoundboardForm"/> instance
        /// </summary>
        /// <param name="show_wizard">Show wizard?</param>
        /// <param name="file_name">File name</param>
        public SoundboardForm(bool show_wizard, string file_name)
        {
            this.show_wizard = show_wizard;
            this.file_name = file_name;
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates all buttons
        /// </summary>
        public void updateButtons()
        {
            int count = 0;
            if (soundboard != null)
            {
                soundboard.unassignAllPictureBoxes();
                if (picture_box_arr != null)
                {
                    for (int i = 0; i < picture_box_arr.Length; i++)
                    {
                        Controls.Remove(picture_box_arr[i]);
                        picture_box_arr[i].Dispose();
                    }
                }
                if (soundboard.Count > 0)
                {
                    picture_box_arr = new PictureBox[soundboard.Count];
                    SoundboardButton[] soundboard_arr = new SoundboardButton[soundboard.Count];
                    foreach (KeyValuePair<SoundboardButton, PictureBox> i in soundboard.ButtonMap)
                    {
                        picture_box_arr[count] = new PictureBox();
                        ((ISupportInitialize)(picture_box_arr[count])).BeginInit();
                        panelMain.Controls.Add(picture_box_arr[count]);
                        picture_box_arr[count].Image = Properties.Resources.SoundboardButton;
                        picture_box_arr[count].Location = new Point((count % 10) * 80, (count / 10) * 80);
                        picture_box_arr[count].Name = "picture_box_arr[" + count + "]";
                        picture_box_arr[count].Size = new Size(80, 80);
                        picture_box_arr[count].TabIndex = count;
                        picture_box_arr[count].TabStop = false;
                        soundboard_arr[count] = i.Key;
                        count++;
                    }
                    for(int i = 0; i < soundboard_arr.Length; i++)
                    {
                        soundboard_arr[i].PictureBox = picture_box_arr[i];
                    }
                }
                Size sz = new Size(((count > 10) ? 800 : (count * 80)) + (Size.Width - panelMain.Size.Width), (((count / 10) + 1) * 80) + (Size.Height - panelMain.Size.Height));
                MinimumSize = new Size(sz.Width, sz.Height);
                MaximumSize = new Size(sz.Width, sz.Height);
                Text = "Soundboard - " + soundboard.ProfileName;
            }
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// <see cref="PianoETI.Soundboard"/> instance
        /// </summary>
        public Soundboard Soundboard
        {
            get
            {
                return soundboard;
            }
            set
            {
                if (soundboard != value)
                {
                    if (soundboard != null)
                        soundboard.unassignAllPictureBoxes();
                    soundboard = value;
                    updateButtons();
                }
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="SoundboardForm"/> "Load" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardForm"/></param>
        /// <param name="e">Arguments</param>
        private void SoundboardForm_Load(object sender, EventArgs e)
        {
            if (show_wizard)
            {
                SoundboardWizardForm swf = new SoundboardWizardForm(this);
                if (swf.ShowDialog() == DialogResult.OK) Soundboard = swf.Soundboard;
                else Close();
            }
            else
            {
                soundboard = new Soundboard();
                soundboard.loadFromFile(file_name);
                updateButtons();
            }
        }

        /// <summary>
        /// <see cref="SoundboardForm"/> "Shown" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardForm"/></param>
        /// <param name="e">Arguments</param>
        private void SoundboardForm_Shown(object sender, EventArgs e)
        {
            //
        }

        /// <summary>
        /// <see cref="SoundboardForm"/> "FormClosed" event
        /// </summary>
        /// <param name="sender">Sender <see cref="SoundboardForm"/></param>
        /// <param name="e">Arguments</param>
        private void SoundboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (soundboard != null)
                soundboard.dispose();
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Close" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemFileClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Settings" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            SoundboardWizardForm swf = new SoundboardWizardForm(this, soundboard);
            if (swf.ShowDialog() == DialogResult.OK)
                Soundboard = swf.Soundboard;
        }
        #endregion
    }
}
