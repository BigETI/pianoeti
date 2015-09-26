using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PianoETI
{
    /// <summary>
    /// MainForm class
    /// </summary>
    public partial class MainForm : Form
    {
        #region Attributes
        /// <summary>
        /// <see cref="MIDISync"/> instance
        /// </summary>
        private MIDISync midi_sync = null;

        /// <summary>
        /// <see cref="PianoForm.PitchType"/> <see cref="PianoForm"/> dictionary
        /// </summary>
        private Dictionary<PianoForm.PitchType, PianoForm> piano_form_map;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes an "MainForm" instance
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Toggles a piano
        /// </summary>
        /// <param name="pitch_type"></param>
        private void togglePiano(PianoForm.PitchType pitch_type)
        {
            ToolStripMenuItem tool_strip_menu_item = null;
            switch (pitch_type)
            {
                case PianoForm.PitchType.Lowest:
                    tool_strip_menu_item = toolStripMenuItemViewPianoLowest;
                    break;
                case PianoForm.PitchType.Lower:
                    tool_strip_menu_item = toolStripMenuItemViewPianoLower;
                    break;
                case PianoForm.PitchType.Low:
                    tool_strip_menu_item = toolStripMenuItemViewPianoLow;
                    break;
                case PianoForm.PitchType.Medium:
                    tool_strip_menu_item = toolStripMenuItemViewPianoMedium;
                    break;
                case PianoForm.PitchType.High:
                    tool_strip_menu_item = toolStripMenuItemViewPianoHigh;
                    break;
                case PianoForm.PitchType.Higher:
                    tool_strip_menu_item = toolStripMenuItemViewPianoHigher;
                    break;
                case PianoForm.PitchType.Highest:
                    tool_strip_menu_item = toolStripMenuItemViewPianoHighest;
                    break;
            }
            if (piano_form_map.ContainsKey(pitch_type))
            {
                PianoForm pf = piano_form_map[pitch_type];
                if (pf.Showing)
                {
                    pf.Close();
                    piano_form_map.Remove(pitch_type);
                }
                else
                {
                    piano_form_map.Remove(pitch_type);
                    pf = new PianoForm(pitch_type, tool_strip_menu_item, this);
                    piano_form_map.Add(pitch_type, pf);
                    pf.Show();
                    Focus();
                }
            }
            else
            {
                PianoForm pf = new PianoForm(pitch_type, tool_strip_menu_item, this);
                piano_form_map.Add(pitch_type, pf);
                pf.Show();
                Focus();
            }
        }

        /// <summary>
        /// Updates the file list
        /// </summary>
        private void updateFileList()
        {
            ListViewItem item;
            listViewFiles.Items.Clear();
            string[] files = Directory.GetFiles("./templates/");
            foreach (string i in files)
            {
                item = new ListViewItem(Path.GetFileNameWithoutExtension(i));
                item.ImageIndex = 0;
                item.Tag = i;
                listViewFiles.Items.Add(item);
            }
        }

        /// <summary>
        /// Creates a new Soundboard
        /// </summary>
        private void createNewSoundboard()
        {
            SoundboardForm sbf = new SoundboardForm(true, "");
            sbf.Show();
        }

        /// <summary>
        /// Loads a soundboard template file
        /// </summary>
        private void loadSoundboard()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                loadSoundboard(openFileDialog.FileName);
        }

        /// <summary>
        /// Loads a soundboard template file by "file_name"
        /// </summary>
        /// <param name="file_name">File name</param>
        private void loadSoundboard(string file_name)
        {
            SoundboardForm sbf = new SoundboardForm(false, file_name);
            sbf.Show();
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// <see cref="MIDISync"/> instance
        /// </summary>
        public MIDISync MIDISync
        {
            get
            {
                return midi_sync;
            }
        }

        /// <summary>
        /// <see cref="PianoForm.PitchType"/> <see cref="PianoForm"/> dictionary
        /// </summary>
        public Dictionary<PianoForm.PitchType, PianoForm> PianoFormMap
        {
            get
            {
                return piano_form_map;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "Exit" Button Event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// <see cref="MainForm"/> "Load" event
        /// </summary>
        /// <param name="sender">Sender <see cref="MainForm"/></param>
        /// <param name="e">Arguments</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            Text = "PianoETI - Version " + version.Major + "." + version.Minor + "." + version.Revision + " Build " + version.Build;

            midi_sync = new MIDISync();

            piano_form_map = new Dictionary<PianoForm.PitchType, PianoForm>();

            toolStripMenuItemViewPianoLowest.Tag = PianoForm.PitchType.Lowest;
            toolStripMenuItemViewPianoLower.Tag = PianoForm.PitchType.Lower;
            toolStripMenuItemViewPianoLow.Tag = PianoForm.PitchType.Low;
            toolStripMenuItemViewPianoMedium.Tag = PianoForm.PitchType.Medium;
            toolStripMenuItemViewPianoHigh.Tag = PianoForm.PitchType.High;
            toolStripMenuItemViewPianoHigher.Tag = PianoForm.PitchType.Higher;
            toolStripMenuItemViewPianoHighest.Tag = PianoForm.PitchType.Highest;

            buttonLowestPiano.Tag = PianoForm.PitchType.Lowest;
            buttonLowerPiano.Tag = PianoForm.PitchType.Lower;
            buttonLowPiano.Tag = PianoForm.PitchType.Low;
            buttonMediumPiano.Tag = PianoForm.PitchType.Medium;
            buttonHighPiano.Tag = PianoForm.PitchType.High;
            buttonHigherPiano.Tag = PianoForm.PitchType.Higher;
            buttonHighestPiano.Tag = PianoForm.PitchType.Highest;

            updateFileList();
        }

        /// <summary>
        /// <see cref="MainForm"/> "FormClosed" event
        /// </summary>
        /// <param name="sender">Sender <see cref="MainForm"/></param>
        /// <param name="e">Arguments</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (KeyValuePair<PianoForm.PitchType, PianoForm> i in piano_form_map)
                i.Value.Close();
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "x piano" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemViewPianoGeneric_Click(object sender, EventArgs e)
        {
            togglePiano((PianoForm.PitchType)(((ToolStripMenuItem)sender).Tag));
        }

        /// <summary>
        /// <see cref="ToolStripMenuItem"/> "New soundboard" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ToolStripMenuItem"/></param>
        /// <param name="e">Arguments</param>
        private void toolStripMenuItemSoundboardNew_Click(object sender, EventArgs e)
        {
            createNewSoundboard();
        }

        /// <summary>
        /// <see cref="Button"/> "x piano" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonGenericPiano_Click(object sender, EventArgs e)
        {
            togglePiano((PianoForm.PitchType)(((Button)sender).Tag));
        }

        /// <summary>
        /// <see cref="Button"/> "Create new soundboard" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonCreateNewSoundboard_Click(object sender, EventArgs e)
        {
            createNewSoundboard();
        }

        /// <summary>
        /// <see cref="Button"/> "Load soundboard" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonLoadSoundboard_Click(object sender, EventArgs e)
        {
            loadSoundboard();
        }

        /// <summary>
        /// <see cref="Button"/> "Refresh list" event
        /// </summary>
        /// <param name="sender">Sender <see cref="Button"/></param>
        /// <param name="e">Arguments</param>
        private void buttonRefreshFilesList_Click(object sender, EventArgs e)
        {
            updateFileList();
        }

        /// <summary>
        /// <see cref="ListView"/> listViewFiles "DoubleClick" event
        /// </summary>
        /// <param name="sender">Sender <see cref="ListView"/></param>
        /// <param name="e">Arguments</param>
        private void listViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listViewFiles.Items.Count > 0)
                loadSoundboard((string)(listViewFiles.SelectedItems[0].Tag));
        }
        #endregion
    }
}
