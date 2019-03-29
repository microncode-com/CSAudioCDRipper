#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSAudioCDRipper.AudioCDRipper;

namespace CSAudioCDRipperExample
{
    public partial class frmAudioCDRipper : Form
    {
        public frmAudioCDRipper()
        {
            Console.WriteLine("Hello");
            InitializeComponent();
        }

        /// <summary>
        /// Load the track from the selected audio CD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCDTracks();
        }

        /// <summary>
        /// Load the CD tracks to the list view.
        /// </summary>
        /// <returns></returns>
        int LoadCDTracks()
        {

            if (audioCDRipper1.CDIsReady(cboDevice.SelectedIndex) == false)
            {
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.");
                return -1;
            }
            else
            {

                lstTracks.Items.Clear();

                string[] arr = new string[6];
                ListViewItem itm;

                foreach (CSAudioCDRipper.AudioCDRipper.TrackInfo track in audioCDRipper1.GetTracks(cboDevice.SelectedIndex))
                {
                    arr[0] = track.TrackNumber.ToString();
                    arr[1] = "Track" + track.TrackNumber.ToString("D2") + ".cda";
                    arr[2] = track.TrackLengthTime.ToString("hh\\:mm\\:ss\\.ff");
                    arr[3] = track.TrackSizeString;
                    arr[4] = track.TrackType;
                    arr[5] = track.TrackFile;

                    itm = new ListViewItem(arr);

                    lstTracks.Items.Add(itm);
                }

                if (lstTracks.Items.Count > 0)
                {
                    lstTracks.Items[0].Selected = true;

                }

                return 0;
            }
        }

        /// <summary>
        /// Refresh the CD tracks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCDTracks();
        }
        
        /// <summary>
        /// Set the destination file. This example use the default music folder of Windows:
        /// </summary>
        private void SetDestinationFileName()
        {
            //Get the default music directory of Windows:
            string sDestinationFile = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\out." + cboDestinationFormat.Text.ToLower();

            //If the destination is ACM add the .WAV ext.
            if (cboDestinationFormat.Text == "ACM")
                sDestinationFile = sDestinationFile + ".wav";

            //Set the lblDestinationFile:
            lblDestinationFile.Text = sDestinationFile;

            //Set the destination file of the control:
            lblDestinationFile.Text = sDestinationFile;
        }

        private void frmAudioCDRipper_Load(object sender, EventArgs e)
        {
            audioCDRipper1.UserName = "Your email";
            audioCDRipper1.UserKey = "Your registration key";

            //Get the CD drives:
            cboDevice.DataSource = audioCDRipper1.GetDevices();
            if (cboDevice.Items.Count > 0) cboDevice.SelectedIndex = 0;

            #region LoadAudioProperties

            //Formats:
            cboDestinationFormat.DataSource = audioCDRipper1.GetFormats();
            cboDestinationFormat.Text = "MP3";

            //Bitrate
            cboBitrate.DataSource = audioCDRipper1.GetBitrates();
            cboBitrate.Text = "192";

            //Samplerate
            cboSamplerate.DataSource = audioCDRipper1.GetSamplerates();
            cboSamplerate.Text = "44100";

            //Bit depth
            cboBits.DataSource = audioCDRipper1.GetBits();
            cboBits.Text = "16";

            //Channels
            cboChannels.DataSource = audioCDRipper1.GetChannels();
            cboChannels.Text = "2";

            //Get all the ACM Tags that installed in the system (for ACM WAV) according to the sample-rate, bits-depth and channels:
            cboACMTags.DataSource = audioCDRipper1.GetACMTags(CSAudioCDRipper.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16);
            cboACMTags.Text = "PCM";

            #endregion

            #region FreeDBProperties

            //Set the FreeDB properties:
            freeDB1.FreeDBClientName = "FreedbDemo";
            freeDB1.FreeDBHostname = "abc.company";
            freeDB1.FreeDBSiteAddress = "us.freedb.org";
            freeDB1.FreeDBUserName = "test";
            freeDB1.FreeDBVersion = "1.0";
            
            #endregion

            //Set the current year of the ID3 tag:
            txtTagYear.Text = DateTime.Now.Year.ToString();
        }
        
        /// <summary>
        /// When selecting the ACM WAV format, display the ACM Tags and Formats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDestinationFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Set the destination:
            SetDestinationFileName();

            lblBits.Visible = false;
            cboBits.Visible = false;
            pnlACM.Visible = false;

            if (cboDestinationFormat.Text == "ACM")
            {
                //Display the ACM settings
                pnlACM.Visible = true;
                pnlACM.Left = 20;
                pnlACM.Top = 71;
            }

            if (cboDestinationFormat.Text == "WAV")
            {
                //Display the bit-depth combo box
                lblBits.Visible = true;
                cboBits.Visible = true;
            }
        }

        /// <summary>
        /// Get ACM formats according to the selected tag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboACMTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboACMFormats.DataSource = audioCDRipper1.GetACMFormats(cboACMTags.Text);
            
            cboACMFormats.SelectedIndex = 0;
        }

        /// <summary>
        /// Open the CD door.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            audioCDRipper1.EjectCD(cboDevice.SelectedIndex);
        }
        
        /// <summary>
        /// Close the CD door.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            audioCDRipper1.CloseCD(cboDevice.SelectedIndex);
        }

        /// <summary>
        /// Load the FreeDB information using events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoadFreeDB_Click(object sender, EventArgs e)
        {
            
            if (freeDB1.CDIsReady(cboDevice.SelectedIndex) == false)
            {
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.");
                return;
            }
            else
            {
                //Call the FreeDB and receive the data in the events:
                freeDB1.GetFreeDBInfo(cboDevice.SelectedIndex);

            }
        }

        private void freeDB1_FreeDBDone(object sender)
        {
            toolStripStatusLabel1.Text = "Done.";
        }

        private void freeDB1_FreeDBError(object sender, CSFreeDB.Core.MessageArgs e)
        {
            MessageBox.Show(e.String + "(" + e.Number + ")");

            toolStripStatusLabel1.Text = e.String + "(" + e.Number + ")";
        }

        private void freeDB1_FreeDBStatus(object sender, CSFreeDB.Core.MessageArgs e)
        {
            Console.WriteLine(e.String);
            toolStripStatusLabel1.Text = e.String;
        }

        private void freeDB1_FreeDBAlbum(object sender, CSFreeDBLib.FreeDB.AlbumInfo e)
        {
            Console.WriteLine(e.AlbumName);
            lblArtist.Text = e.AlbumArtist;
            lblAlbum.Text = e.AlbumName;

            //Set the ID3 tags:
            txtTagAlbum.Text = e.AlbumName;
            txtTagYear.Text = e.AlbumYear;

            txtTagComment.Text = e.AlbumDiscID;
        }

        private void freeDB1_FreeDBTracks(object sender, CSFreeDBLib.FreeDB.TrackInfo e)
        {

            Console.WriteLine(e.TrackName);

            lstTracks.Items[e.TrackNumber - 1].SubItems[1].Text = e.TrackName;
        }

        /// <summary>
        /// Load the FreeDB information in async mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoadFreeDBAsync_Click(object sender, EventArgs e)
        {
            int cntr = 0;

            // Tracks names:
            foreach (string trckFreeDB in freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).FreeDBTracksInfo)
            {
                lstTracks.Items[cntr].SubItems[1].Text = trckFreeDB.ToString();
                cntr = cntr + 1;
            }
            
            //Album / Artist name:
            if (cntr > 0)
            {
                lblArtist.Text = "Artist: " + freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).Artist;
                lblAlbum.Text = "Album: " + freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).AlbumName;
            }
        }

        private void audioCDRipper1_RipProgress(object sender, CSAudioCDRipper.PercentArgs e)
        {
            lblCurrentProgress.Text = e.Number + "%";
            toolStripStatusLabel1.Text = lblCurrentProgress.Text;
            prgCurrentProgress.Value = e.Number;
        }

        private void audioCDRipper1_RipError(object sender, CSAudioCDRipper.MessageArgs e)
        {
            Console.WriteLine("Error " + e.String);
            lblCurrentProgress.Text = "Error " + e.String + "(" + e.Number + ")";
            toolStripStatusLabel1.Text = lblCurrentProgress.Text;
            cmdRip.Enabled = true;
        }

        private void audioCDRipper1_RipDone(object sender, EventArgs e)
        {
            //Set the ID3 tags
            if ((cboDestinationFormat.Text != "WAV") && (cboDestinationFormat.Text != "ACM"))
            {
                //Set the ID3 tags of the destination file:
                audioCDRipper1.TagTitle = txtTagTitle.Text;
                audioCDRipper1.TagAlbum = txtTagAlbum.Text;
                audioCDRipper1.TagTrack = uint.Parse(txtTagTrackNum.Text);
                audioCDRipper1.TagComment = txtTagComment.Text;
                audioCDRipper1.TagYear = txtTagYear.Text;
                audioCDRipper1.TagCopyright = txtTagCopyright.Text;
                audioCDRipper1.SetID3Tags(lblDestinationFile.Text);
            }

            lblCurrentProgress.Text = "Done";
            toolStripStatusLabel1.Text = "Done";

            cmdRip.Enabled = true;
        }

        private void audioCDRipper1_RipStart(object sender, EventArgs e)
        {
            lblCurrentProgress.Text = "Ripping...";
            toolStripStatusLabel1.Text = "Ripping...";
        }

        private void cmdRip_Click(object sender, EventArgs e)
        {
            //Check if already running:
            if (audioCDRipper1.OperationState == CSAudioCDRipper.OperationState.Running)
            {
                MessageBox.Show("Already running.");
                return;
            }

            //Select the drive index to rip from:
            audioCDRipper1.SelectedDriveIndex = cboDevice.SelectedIndex;

            //Set the destination properties:
            SetDestinationFileName();

            //Set the destination file:
            audioCDRipper1.DestinatioFile = lblDestinationFile.Text;

            //[Optional: Default is MP3]
            //Set the destination audio format, this can be AAC, APE, MP2, MP3, OGG, PCM WAV, ACM WAV and WMA:
            audioCDRipper1.Format = (CSAudioCDRipper.Format)Enum.Parse(typeof(CSAudioCDRipper.Format), cboDestinationFormat.Text);

            #region MoreOptionalProperties

            //If the destination format is ACM (WAV) set the ACM tag and format.
            if (cboDestinationFormat.Text == "ACM")
            {
                //Set the ACM tag and format:

                //[Optional: Default is WAV]
                audioCDRipper1.ACMTag = cboACMTags.Text;

                //[Optional: Default is 44100, 16, Stereo]
                audioCDRipper1.ACMFormat = cboACMFormats.Text;
            }

            //[Optional: Default is 192]
            //Set the bitrate of the destination:
            audioCDRipper1.Bitrate = (CSAudioCDRipper.Bitrate)Enum.Parse(typeof(CSAudioCDRipper.Bitrate), cboBitrate.Text);
            //Or set by value
            //audioCDRipper1.BitrateVal = 192;

            //[Optional: Default is 44100]
            //Set the sample rate of the destination (from 8000 to 48000):
            audioCDRipper1.Samplerate = (CSAudioCDRipper.Samplerate)Enum.Parse(typeof(CSAudioCDRipper.Samplerate), cboSamplerate.Text);
            //Or set by value
            //audioCDRipper1.SamplerateVal = 48000;

            //[Optional: Default is 16]
            //Set the bit-depth of the destination file (8, 16, 24, 32):
            audioCDRipper1.Bits = (CSAudioCDRipper.Bits)Enum.Parse(typeof(CSAudioCDRipper.Bits), cboBits.Text);

            //[Optional: Default is 2]
            //Set the number of the channels of the destination file (1 or 2):
            audioCDRipper1.Channels = (CSAudioCDRipper.Channels)Enum.Parse(typeof(CSAudioCDRipper.Channels), cboChannels.Text);

            #endregion

            //First clear the SourceTracks list:
            audioCDRipper1.SourceTracks.Clear();

            #region JoinAndCutTracks

            //Add one or more tracks to the SourceTracks list. 
            //If you will add more then one source multimedia file to the list, 
            //the control will join them all into one multimedia file:

            //Set the time length of the track to rip:
            //TimeSpan from_time = new TimeSpan(0, 01, 30);
            //TimeSpan to_time = new TimeSpan(0, 02, 30);

            //Add one or more tracks to the list
            //audioCDRipper1.SourceTracks.Add(new Options.Core.SourceTrack(0, from_time, to_time));
            //audioCDRipper1.SourceTracks.Add(new Options.Core.SourceTrack(1, from_time, to_time));

            #endregion

            //Get the selected track to rip:
            int selected_track = lstTracks.Items.IndexOf(lstTracks.SelectedItems[0]);

            //Add the selected track to the SourceTracks list:
            audioCDRipper1.SourceTracks.Add(new Options.Core.SourceTrack(selected_track));
            
            //Rip
            audioCDRipper1.Rip();

            //Disable the buttons controls until the process has ended:
            cmdRip.Enabled = false;
        }

        /// <summary>
        /// Pause the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPause_Click(object sender, EventArgs e)
        {
            //Check if the process is running:
            if (audioCDRipper1.OperationState == CSAudioCDRipper.OperationState.Running)
            {
                audioCDRipper1.Pause();
            }
        }

        /// <summary>
        /// Resume the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdResume_Click(object sender, EventArgs e)
        {
            //Check if the process is paused:
            if (audioCDRipper1.OperationState == CSAudioCDRipper.OperationState.Paused)
            {
                audioCDRipper1.Resume();
            }
        }

        /// <summary>
        /// Cancel the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //Cancel:
            audioCDRipper1.Cancel();
        }
        
        /// <summary>
        /// Open the destination multimedia file with the default multimedia player of the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlayWithDefaultPlayer_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            Process.Start(lblDestinationFile.Text);
        }

        /// <summary>
        /// Open the directory of the destination multimedia file with the WIndows Explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOpenFileLocation_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + lblDestinationFile.Text + "\"";

            Process.Start("explorer.exe", argument);
        }

        /// <summary>
        /// Safe exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioCDRipper_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region SafeExit

            //Check if already running:
            if (audioCDRipper1.OperationState == CSAudioCDRipper.OperationState.Running)
            {
                //Stop:
                audioCDRipper1.Cancel();

                //Wait for the ready state
                while (audioCDRipper1.OperationState != CSAudioCDRipper.OperationState.Ready)
                {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            }

            #endregion
        }

        /// <summary>
        /// Show the frmID3TagsEditor:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdID3Tags_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            frmID3TagsEditor frmAllID3Tags = new frmID3TagsEditor();

            //frmAllID3Tags.LoadFile(lblDestinationFile.Text);
            frmAllID3Tags.ShowDialog(this);
        }

        /// <summary>
        /// Check the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCheckLicense_Click(object sender, EventArgs e)
        {
            if (audioCDRipper1.CheckLicense())
                MessageBox.Show("Registration is OK");
        }
    }
}
