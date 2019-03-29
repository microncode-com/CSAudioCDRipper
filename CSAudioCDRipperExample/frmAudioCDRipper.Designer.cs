namespace CSAudioCDRipperExample
{
    partial class frmAudioCDRipper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioCDRipper));
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lstTracks = new System.Windows.Forms.ListView();
            this.cTrackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdID3Tags = new System.Windows.Forms.Button();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.pnlACM = new System.Windows.Forms.Panel();
            this.cboACMFormats = new System.Windows.Forms.ComboBox();
            this.cboACMTags = new System.Windows.Forms.ComboBox();
            this.lblACMTag = new System.Windows.Forms.Label();
            this.lblACMFormats = new System.Windows.Forms.Label();
            this.cboChannels = new System.Windows.Forms.ComboBox();
            this.cboBitrate = new System.Windows.Forms.ComboBox();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.cboSamplerate = new System.Windows.Forms.ComboBox();
            this.lblSamplerate = new System.Windows.Forms.Label();
            this.cboBits = new System.Windows.Forms.ComboBox();
            this.lblBits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestinationFormat = new System.Windows.Forms.Label();
            this.cboDestinationFormat = new System.Windows.Forms.ComboBox();
            this.grpID3Tags = new System.Windows.Forms.GroupBox();
            this.lblTagComment = new System.Windows.Forms.Label();
            this.txtTagTitle = new System.Windows.Forms.TextBox();
            this.lblTagTrackNum = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.txtTagTrackNum = new System.Windows.Forms.TextBox();
            this.txtTagYear = new System.Windows.Forms.TextBox();
            this.lblTagCopyright = new System.Windows.Forms.Label();
            this.lblTagYear = new System.Windows.Forms.Label();
            this.txtTagCopyright = new System.Windows.Forms.TextBox();
            this.txtTagComment = new System.Windows.Forms.TextBox();
            this.lblTagAlbum = new System.Windows.Forms.Label();
            this.txtTagAlbum = new System.Windows.Forms.TextBox();
            this.grpDestinationFile = new System.Windows.Forms.GroupBox();
            this.cmdPlayWithDefaultPlayer = new System.Windows.Forms.Button();
            this.cmdOpenFileLocation = new System.Windows.Forms.Button();
            this.lblDestinationFile = new System.Windows.Forms.Label();
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdResume = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpProgress = new System.Windows.Forms.GroupBox();
            this.prgCurrentProgress = new System.Windows.Forms.ProgressBar();
            this.lblCurrentProgress = new System.Windows.Forms.Label();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmdLoadFreeDB = new System.Windows.Forms.Button();
            this.cmdLoadFreeDBAsync = new System.Windows.Forms.Button();
            this.cmdRip = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.audioCDRipper1 = new CSAudioCDRipper.AudioCDRipper();
            this.freeDB1 = new CSAudioCDRipper.FreeDB();
            this.cmdCheckLicense = new System.Windows.Forms.Button();
            this.grpDestination.SuspendLayout();
            this.pnlACM.SuspendLayout();
            this.grpID3Tags.SuspendLayout();
            this.grpDestinationFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpProgress.SuspendLayout();
            this.grpSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(22, 46);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(750, 21);
            this.cboDevice.TabIndex = 175;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(22, 27);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 174;
            this.lblDevice.Text = "Device:";
            // 
            // lstTracks
            // 
            this.lstTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTrackNum,
            this.cTrackName,
            this.cTrackTime,
            this.cTrackSize,
            this.cTrackType,
            this.cTrackFile});
            this.lstTracks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTracks.FullRowSelect = true;
            this.lstTracks.GridLines = true;
            this.lstTracks.HideSelection = false;
            this.lstTracks.Location = new System.Drawing.Point(22, 82);
            this.lstTracks.MultiSelect = false;
            this.lstTracks.Name = "lstTracks";
            this.lstTracks.Size = new System.Drawing.Size(750, 232);
            this.lstTracks.TabIndex = 176;
            this.lstTracks.UseCompatibleStateImageBehavior = false;
            this.lstTracks.View = System.Windows.Forms.View.Details;
            // 
            // cTrackNum
            // 
            this.cTrackNum.Text = "Track Num";
            this.cTrackNum.Width = 80;
            // 
            // cTrackName
            // 
            this.cTrackName.Text = "Track Name";
            this.cTrackName.Width = 120;
            // 
            // cTrackTime
            // 
            this.cTrackTime.Text = "Track Time";
            this.cTrackTime.Width = 120;
            // 
            // cTrackSize
            // 
            this.cTrackSize.Text = "Track Size";
            this.cTrackSize.Width = 100;
            // 
            // cTrackType
            // 
            this.cTrackType.Text = "Track Type";
            this.cTrackType.Width = 100;
            // 
            // cTrackFile
            // 
            this.cTrackFile.Text = "Track File";
            this.cTrackFile.Width = 160;
            // 
            // cmdID3Tags
            // 
            this.cmdID3Tags.Location = new System.Drawing.Point(489, 784);
            this.cmdID3Tags.Name = "cmdID3Tags";
            this.cmdID3Tags.Size = new System.Drawing.Size(145, 23);
            this.cmdID3Tags.TabIndex = 181;
            this.cmdID3Tags.Text = "ID3 Tags Editor";
            this.cmdID3Tags.UseVisualStyleBackColor = true;
            this.cmdID3Tags.Click += new System.EventHandler(this.cmdID3Tags_Click);
            // 
            // grpDestination
            // 
            this.grpDestination.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestination.Controls.Add(this.pnlACM);
            this.grpDestination.Controls.Add(this.cboChannels);
            this.grpDestination.Controls.Add(this.cboBitrate);
            this.grpDestination.Controls.Add(this.lblBitrate);
            this.grpDestination.Controls.Add(this.cboSamplerate);
            this.grpDestination.Controls.Add(this.lblSamplerate);
            this.grpDestination.Controls.Add(this.cboBits);
            this.grpDestination.Controls.Add(this.lblBits);
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.lblDestinationFormat);
            this.grpDestination.Controls.Add(this.cboDestinationFormat);
            this.grpDestination.Location = new System.Drawing.Point(15, 438);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(441, 140);
            this.grpDestination.TabIndex = 183;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // pnlACM
            // 
            this.pnlACM.Controls.Add(this.cboACMFormats);
            this.pnlACM.Controls.Add(this.cboACMTags);
            this.pnlACM.Controls.Add(this.lblACMTag);
            this.pnlACM.Controls.Add(this.lblACMFormats);
            this.pnlACM.Location = new System.Drawing.Point(223, 15);
            this.pnlACM.Name = "pnlACM";
            this.pnlACM.Size = new System.Drawing.Size(398, 64);
            this.pnlACM.TabIndex = 189;
            // 
            // cboACMFormats
            // 
            this.cboACMFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACMFormats.FormattingEnabled = true;
            this.cboACMFormats.Location = new System.Drawing.Point(197, 29);
            this.cboACMFormats.Name = "cboACMFormats";
            this.cboACMFormats.Size = new System.Drawing.Size(188, 21);
            this.cboACMFormats.TabIndex = 72;
            // 
            // cboACMTags
            // 
            this.cboACMTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACMTags.FormattingEnabled = true;
            this.cboACMTags.Location = new System.Drawing.Point(3, 29);
            this.cboACMTags.Name = "cboACMTags";
            this.cboACMTags.Size = new System.Drawing.Size(188, 21);
            this.cboACMTags.TabIndex = 70;
            this.cboACMTags.SelectedIndexChanged += new System.EventHandler(this.cboACMTags_SelectedIndexChanged);
            // 
            // lblACMTag
            // 
            this.lblACMTag.AutoSize = true;
            this.lblACMTag.Location = new System.Drawing.Point(3, 13);
            this.lblACMTag.Name = "lblACMTag";
            this.lblACMTag.Size = new System.Drawing.Size(60, 13);
            this.lblACMTag.TabIndex = 69;
            this.lblACMTag.Text = "ACM Tags:";
            // 
            // lblACMFormats
            // 
            this.lblACMFormats.AutoSize = true;
            this.lblACMFormats.Location = new System.Drawing.Point(197, 13);
            this.lblACMFormats.Name = "lblACMFormats";
            this.lblACMFormats.Size = new System.Drawing.Size(73, 13);
            this.lblACMFormats.TabIndex = 71;
            this.lblACMFormats.Text = "ACM Formats:";
            // 
            // cboChannels
            // 
            this.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChannels.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboChannels.FormattingEnabled = true;
            this.cboChannels.Location = new System.Drawing.Point(214, 99);
            this.cboChannels.Name = "cboChannels";
            this.cboChannels.Size = new System.Drawing.Size(91, 21);
            this.cboChannels.TabIndex = 12;
            // 
            // cboBitrate
            // 
            this.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitrate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBitrate.FormattingEnabled = true;
            this.cboBitrate.Location = new System.Drawing.Point(20, 99);
            this.cboBitrate.Name = "cboBitrate";
            this.cboBitrate.Size = new System.Drawing.Size(91, 21);
            this.cboBitrate.TabIndex = 10;
            // 
            // lblBitrate
            // 
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(17, 83);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(37, 13);
            this.lblBitrate.TabIndex = 31;
            this.lblBitrate.Text = "Bitrate";
            // 
            // cboSamplerate
            // 
            this.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSamplerate.FormattingEnabled = true;
            this.cboSamplerate.Location = new System.Drawing.Point(117, 99);
            this.cboSamplerate.Name = "cboSamplerate";
            this.cboSamplerate.Size = new System.Drawing.Size(91, 21);
            this.cboSamplerate.TabIndex = 11;
            // 
            // lblSamplerate
            // 
            this.lblSamplerate.AutoSize = true;
            this.lblSamplerate.Location = new System.Drawing.Point(114, 83);
            this.lblSamplerate.Name = "lblSamplerate";
            this.lblSamplerate.Size = new System.Drawing.Size(60, 13);
            this.lblSamplerate.TabIndex = 33;
            this.lblSamplerate.Text = "Samplerate";
            // 
            // cboBits
            // 
            this.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBits.FormattingEnabled = true;
            this.cboBits.Location = new System.Drawing.Point(311, 98);
            this.cboBits.Name = "cboBits";
            this.cboBits.Size = new System.Drawing.Size(91, 21);
            this.cboBits.TabIndex = 13;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(308, 82);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(49, 13);
            this.lblBits.TabIndex = 35;
            this.lblBits.Text = "Bit depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Channels";
            // 
            // lblDestinationFormat
            // 
            this.lblDestinationFormat.AutoSize = true;
            this.lblDestinationFormat.Location = new System.Drawing.Point(17, 28);
            this.lblDestinationFormat.Name = "lblDestinationFormat";
            this.lblDestinationFormat.Size = new System.Drawing.Size(95, 13);
            this.lblDestinationFormat.TabIndex = 39;
            this.lblDestinationFormat.Text = "Destination Format";
            // 
            // cboDestinationFormat
            // 
            this.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinationFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDestinationFormat.FormattingEnabled = true;
            this.cboDestinationFormat.Location = new System.Drawing.Point(20, 44);
            this.cboDestinationFormat.Name = "cboDestinationFormat";
            this.cboDestinationFormat.Size = new System.Drawing.Size(188, 21);
            this.cboDestinationFormat.TabIndex = 8;
            this.cboDestinationFormat.SelectedIndexChanged += new System.EventHandler(this.cboDestinationFormat_SelectedIndexChanged);
            // 
            // grpID3Tags
            // 
            this.grpID3Tags.BackColor = System.Drawing.SystemColors.Control;
            this.grpID3Tags.Controls.Add(this.lblTagComment);
            this.grpID3Tags.Controls.Add(this.txtTagTitle);
            this.grpID3Tags.Controls.Add(this.lblTagTrackNum);
            this.grpID3Tags.Controls.Add(this.lblTagTitle);
            this.grpID3Tags.Controls.Add(this.txtTagTrackNum);
            this.grpID3Tags.Controls.Add(this.txtTagYear);
            this.grpID3Tags.Controls.Add(this.lblTagCopyright);
            this.grpID3Tags.Controls.Add(this.lblTagYear);
            this.grpID3Tags.Controls.Add(this.txtTagCopyright);
            this.grpID3Tags.Controls.Add(this.txtTagComment);
            this.grpID3Tags.Controls.Add(this.lblTagAlbum);
            this.grpID3Tags.Controls.Add(this.txtTagAlbum);
            this.grpID3Tags.Location = new System.Drawing.Point(462, 438);
            this.grpID3Tags.Name = "grpID3Tags";
            this.grpID3Tags.Size = new System.Drawing.Size(346, 140);
            this.grpID3Tags.TabIndex = 184;
            this.grpID3Tags.TabStop = false;
            this.grpID3Tags.Text = "ID3 Tags";
            // 
            // lblTagComment
            // 
            this.lblTagComment.AutoSize = true;
            this.lblTagComment.Location = new System.Drawing.Point(14, 82);
            this.lblTagComment.Name = "lblTagComment";
            this.lblTagComment.Size = new System.Drawing.Size(51, 13);
            this.lblTagComment.TabIndex = 76;
            this.lblTagComment.Text = "Comment";
            // 
            // txtTagTitle
            // 
            this.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagTitle.Location = new System.Drawing.Point(17, 44);
            this.txtTagTitle.Name = "txtTagTitle";
            this.txtTagTitle.Size = new System.Drawing.Size(98, 20);
            this.txtTagTitle.TabIndex = 14;
            this.txtTagTitle.Text = "CSAudioCDRipper";
            // 
            // lblTagTrackNum
            // 
            this.lblTagTrackNum.AutoSize = true;
            this.lblTagTrackNum.Location = new System.Drawing.Point(222, 28);
            this.lblTagTrackNum.Name = "lblTagTrackNum";
            this.lblTagTrackNum.Size = new System.Drawing.Size(42, 13);
            this.lblTagTrackNum.TabIndex = 75;
            this.lblTagTrackNum.Text = "Track#";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Location = new System.Drawing.Point(14, 28);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTagTitle.TabIndex = 66;
            this.lblTagTitle.Text = "Title";
            // 
            // txtTagTrackNum
            // 
            this.txtTagTrackNum.Location = new System.Drawing.Point(225, 44);
            this.txtTagTrackNum.Name = "txtTagTrackNum";
            this.txtTagTrackNum.Size = new System.Drawing.Size(98, 20);
            this.txtTagTrackNum.TabIndex = 16;
            this.txtTagTrackNum.Text = "1";
            // 
            // txtTagYear
            // 
            this.txtTagYear.Location = new System.Drawing.Point(121, 98);
            this.txtTagYear.Name = "txtTagYear";
            this.txtTagYear.Size = new System.Drawing.Size(98, 20);
            this.txtTagYear.TabIndex = 18;
            // 
            // lblTagCopyright
            // 
            this.lblTagCopyright.AutoSize = true;
            this.lblTagCopyright.Location = new System.Drawing.Point(222, 82);
            this.lblTagCopyright.Name = "lblTagCopyright";
            this.lblTagCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblTagCopyright.TabIndex = 73;
            this.lblTagCopyright.Text = "Copyright";
            // 
            // lblTagYear
            // 
            this.lblTagYear.AutoSize = true;
            this.lblTagYear.Location = new System.Drawing.Point(118, 82);
            this.lblTagYear.Name = "lblTagYear";
            this.lblTagYear.Size = new System.Drawing.Size(29, 13);
            this.lblTagYear.TabIndex = 68;
            this.lblTagYear.Text = "Year";
            // 
            // txtTagCopyright
            // 
            this.txtTagCopyright.Location = new System.Drawing.Point(225, 98);
            this.txtTagCopyright.Name = "txtTagCopyright";
            this.txtTagCopyright.Size = new System.Drawing.Size(98, 20);
            this.txtTagCopyright.TabIndex = 19;
            // 
            // txtTagComment
            // 
            this.txtTagComment.Location = new System.Drawing.Point(19, 98);
            this.txtTagComment.Name = "txtTagComment";
            this.txtTagComment.Size = new System.Drawing.Size(96, 20);
            this.txtTagComment.TabIndex = 17;
            // 
            // lblTagAlbum
            // 
            this.lblTagAlbum.AutoSize = true;
            this.lblTagAlbum.Location = new System.Drawing.Point(118, 28);
            this.lblTagAlbum.Name = "lblTagAlbum";
            this.lblTagAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblTagAlbum.TabIndex = 71;
            this.lblTagAlbum.Text = "Album";
            // 
            // txtTagAlbum
            // 
            this.txtTagAlbum.Location = new System.Drawing.Point(121, 44);
            this.txtTagAlbum.Name = "txtTagAlbum";
            this.txtTagAlbum.Size = new System.Drawing.Size(98, 20);
            this.txtTagAlbum.TabIndex = 15;
            // 
            // grpDestinationFile
            // 
            this.grpDestinationFile.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestinationFile.Controls.Add(this.cmdPlayWithDefaultPlayer);
            this.grpDestinationFile.Controls.Add(this.cmdOpenFileLocation);
            this.grpDestinationFile.Controls.Add(this.lblDestinationFile);
            this.grpDestinationFile.Location = new System.Drawing.Point(15, 679);
            this.grpDestinationFile.Name = "grpDestinationFile";
            this.grpDestinationFile.Size = new System.Drawing.Size(793, 71);
            this.grpDestinationFile.TabIndex = 190;
            this.grpDestinationFile.TabStop = false;
            this.grpDestinationFile.Text = "Destination File";
            // 
            // cmdPlayWithDefaultPlayer
            // 
            this.cmdPlayWithDefaultPlayer.Location = new System.Drawing.Point(545, 24);
            this.cmdPlayWithDefaultPlayer.Name = "cmdPlayWithDefaultPlayer";
            this.cmdPlayWithDefaultPlayer.Size = new System.Drawing.Size(74, 23);
            this.cmdPlayWithDefaultPlayer.TabIndex = 20;
            this.cmdPlayWithDefaultPlayer.Text = "Play";
            this.toolTip1.SetToolTip(this.cmdPlayWithDefaultPlayer, "Playe with the default system player.");
            this.cmdPlayWithDefaultPlayer.UseVisualStyleBackColor = true;
            this.cmdPlayWithDefaultPlayer.Click += new System.EventHandler(this.cmdPlayWithDefaultPlayer_Click);
            // 
            // cmdOpenFileLocation
            // 
            this.cmdOpenFileLocation.Location = new System.Drawing.Point(625, 24);
            this.cmdOpenFileLocation.Name = "cmdOpenFileLocation";
            this.cmdOpenFileLocation.Size = new System.Drawing.Size(145, 23);
            this.cmdOpenFileLocation.TabIndex = 21;
            this.cmdOpenFileLocation.Text = "Open file Location";
            this.toolTip1.SetToolTip(this.cmdOpenFileLocation, "Open file Location.");
            this.cmdOpenFileLocation.UseVisualStyleBackColor = true;
            this.cmdOpenFileLocation.Click += new System.EventHandler(this.cmdOpenFileLocation_Click);
            // 
            // lblDestinationFile
            // 
            this.lblDestinationFile.Location = new System.Drawing.Point(27, 24);
            this.lblDestinationFile.Name = "lblDestinationFile";
            this.lblDestinationFile.Size = new System.Drawing.Size(512, 29);
            this.lblDestinationFile.TabIndex = 74;
            this.lblDestinationFile.Text = "C:\\";
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(188, 784);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 178;
            this.cmdPause.Text = "Pause";
            this.toolTip1.SetToolTip(this.cmdPause, "Pause the entry progress.");
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdResume
            // 
            this.cmdResume.Location = new System.Drawing.Point(269, 784);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(75, 23);
            this.cmdResume.TabIndex = 179;
            this.cmdResume.Text = "Resume";
            this.toolTip1.SetToolTip(this.cmdResume, "Resume the progress.");
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(350, 784);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(92, 23);
            this.cmdCancel.TabIndex = 180;
            this.cmdCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cmdCancel, "Cancel the progress.");
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(235, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 16);
            this.label3.TabIndex = 188;
            this.label3.Text = ".NET component to rip audio cd tracks with FreeDB and ID3 tags support.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 187;
            this.label2.Text = "CSAudioCDRipper |";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-33, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 45);
            this.pictureBox1.TabIndex = 186;
            this.pictureBox1.TabStop = false;
            // 
            // grpProgress
            // 
            this.grpProgress.BackColor = System.Drawing.SystemColors.Control;
            this.grpProgress.Controls.Add(this.prgCurrentProgress);
            this.grpProgress.Controls.Add(this.lblCurrentProgress);
            this.grpProgress.Location = new System.Drawing.Point(15, 584);
            this.grpProgress.Name = "grpProgress";
            this.grpProgress.Size = new System.Drawing.Size(793, 89);
            this.grpProgress.TabIndex = 185;
            this.grpProgress.TabStop = false;
            this.grpProgress.Text = "Progress";
            // 
            // prgCurrentProgress
            // 
            this.prgCurrentProgress.Location = new System.Drawing.Point(20, 43);
            this.prgCurrentProgress.Name = "prgCurrentProgress";
            this.prgCurrentProgress.Size = new System.Drawing.Size(750, 23);
            this.prgCurrentProgress.TabIndex = 6;
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Location = new System.Drawing.Point(17, 27);
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(41, 13);
            this.lblCurrentProgress.TabIndex = 55;
            this.lblCurrentProgress.Text = "Ready.";
            // 
            // grpSource
            // 
            this.grpSource.BackColor = System.Drawing.SystemColors.Control;
            this.grpSource.Controls.Add(this.lblArtist);
            this.grpSource.Controls.Add(this.lblAlbum);
            this.grpSource.Controls.Add(this.btnRefresh);
            this.grpSource.Controls.Add(this.btnClose);
            this.grpSource.Controls.Add(this.btnOpen);
            this.grpSource.Controls.Add(this.cmdLoadFreeDB);
            this.grpSource.Controls.Add(this.cmdLoadFreeDBAsync);
            this.grpSource.Controls.Add(this.lstTracks);
            this.grpSource.Controls.Add(this.cboDevice);
            this.grpSource.Controls.Add(this.lblDevice);
            this.grpSource.Location = new System.Drawing.Point(15, 58);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(793, 374);
            this.grpSource.TabIndex = 182;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(372, 336);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 201;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(519, 336);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblAlbum.TabIndex = 200;
            this.lblAlbum.Text = "Album";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(672, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 199;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(563, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 23);
            this.btnClose.TabIndex = 198;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpen.Location = new System.Drawing.Point(454, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 23);
            this.btnOpen.TabIndex = 197;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmdLoadFreeDB
            // 
            this.cmdLoadFreeDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdLoadFreeDB.Location = new System.Drawing.Point(20, 329);
            this.cmdLoadFreeDB.Name = "cmdLoadFreeDB";
            this.cmdLoadFreeDB.Size = new System.Drawing.Size(132, 27);
            this.cmdLoadFreeDB.TabIndex = 196;
            this.cmdLoadFreeDB.Text = "Load FreeDB";
            this.cmdLoadFreeDB.UseVisualStyleBackColor = true;
            this.cmdLoadFreeDB.Click += new System.EventHandler(this.cmdLoadFreeDB_Click);
            // 
            // cmdLoadFreeDBAsync
            // 
            this.cmdLoadFreeDBAsync.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdLoadFreeDBAsync.Location = new System.Drawing.Point(158, 329);
            this.cmdLoadFreeDBAsync.Name = "cmdLoadFreeDBAsync";
            this.cmdLoadFreeDBAsync.Size = new System.Drawing.Size(132, 27);
            this.cmdLoadFreeDBAsync.TabIndex = 195;
            this.cmdLoadFreeDBAsync.Text = "Load FreeDB Async";
            this.cmdLoadFreeDBAsync.UseVisualStyleBackColor = true;
            this.cmdLoadFreeDBAsync.Click += new System.EventHandler(this.cmdLoadFreeDBAsync_Click);
            // 
            // cmdRip
            // 
            this.cmdRip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdRip.Location = new System.Drawing.Point(15, 784);
            this.cmdRip.Name = "cmdRip";
            this.cmdRip.Size = new System.Drawing.Size(167, 23);
            this.cmdRip.TabIndex = 177;
            this.cmdRip.Text = "Rip";
            this.toolTip1.SetToolTip(this.cmdRip, "Convert and join.");
            this.cmdRip.UseVisualStyleBackColor = true;
            this.cmdRip.Click += new System.EventHandler(this.cmdRip_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-23, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 45);
            this.pictureBox2.TabIndex = 191;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 847);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 201;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Ready.";
            // 
            // audioCDRipper1
            // 
            this.audioCDRipper1.About = null;
            this.audioCDRipper1.BitrateVal = 0;
            this.audioCDRipper1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioCDRipper1.DestinatioFile = null;
            this.audioCDRipper1.Drives = null;
            this.audioCDRipper1.Location = new System.Drawing.Point(654, 35);
            this.audioCDRipper1.Name = "audioCDRipper1";
            this.audioCDRipper1.RatingStars = 0F;
            this.audioCDRipper1.RatingUser = "Windows Media Player 9 Series";
            this.audioCDRipper1.SamplerateVal = 0;
            this.audioCDRipper1.SelectedDriveIndex = 0;
            this.audioCDRipper1.Size = new System.Drawing.Size(52, 52);
            this.audioCDRipper1.TabIndex = 0;
            this.audioCDRipper1.TagAlbum = null;
            this.audioCDRipper1.TagArtists = ((System.Collections.Generic.List<string>)(resources.GetObject("audioCDRipper1.TagArtists")));
            this.audioCDRipper1.TagComment = null;
            this.audioCDRipper1.TagComposers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioCDRipper1.TagComposers")));
            this.audioCDRipper1.TagCopyright = null;
            this.audioCDRipper1.TagGenres = ((System.Collections.Generic.List<string>)(resources.GetObject("audioCDRipper1.TagGenres")));
            this.audioCDRipper1.TagLyrics = null;
            this.audioCDRipper1.TagPerformers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioCDRipper1.TagPerformers")));
            this.audioCDRipper1.TagRating = ((short)(0));
            this.audioCDRipper1.TagTitle = null;
            this.audioCDRipper1.TagTrack = ((uint)(0u));
            this.audioCDRipper1.TagYear = null;
            this.audioCDRipper1.UserKey = "Your registration key";
            this.audioCDRipper1.UserName = "Your email";
            this.audioCDRipper1.RipProgress += new CSAudioCDRipper.AudioCDRipper.RipProgressEventHandler(this.audioCDRipper1_RipProgress);
            this.audioCDRipper1.RipError += new CSAudioCDRipper.AudioCDRipper.RipErrorEventHandler(this.audioCDRipper1_RipError);
            this.audioCDRipper1.RipStart += new CSAudioCDRipper.AudioCDRipper.RipStartEventHandler(this.audioCDRipper1_RipStart);
            this.audioCDRipper1.RipDone += new CSAudioCDRipper.AudioCDRipper.RipDoneEventHandler(this.audioCDRipper1_RipDone);
            // 
            // freeDB1
            // 
            this.freeDB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.freeDB1.FreeDBClientName = "FreedbDemo";
            this.freeDB1.FreeDBHostname = "abc.company";
            this.freeDB1.FreeDBSiteAddress = "us.freedb.org";
            this.freeDB1.FreeDBUserName = "test";
            this.freeDB1.FreeDBVersion = "1.0";
            this.freeDB1.Location = new System.Drawing.Point(717, 32);
            this.freeDB1.Name = "freeDB1";
            this.freeDB1.Size = new System.Drawing.Size(52, 52);
            this.freeDB1.TabIndex = 202;
            this.freeDB1.FreeDBStatus += new CSFreeDBLib.FreeDB.FreeDBStatusEventHandler(this.freeDB1_FreeDBStatus);
            this.freeDB1.FreeDBError += new CSFreeDBLib.FreeDB.FreeDBErrorEventHandler(this.freeDB1_FreeDBError);
            this.freeDB1.FreeDBTracks += new CSFreeDBLib.FreeDB.FreeDBTracksEventHandler(this.freeDB1_FreeDBTracks);
            this.freeDB1.FreeDBDone += new CSFreeDBLib.FreeDB.FreeDBDoneEventHandler(this.freeDB1_FreeDBDone);
            // 
            // cmdCheckLicense
            // 
            this.cmdCheckLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdCheckLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckLicense.Image")));
            this.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckLicense.Location = new System.Drawing.Point(640, 784);
            this.cmdCheckLicense.Name = "cmdCheckLicense";
            this.cmdCheckLicense.Size = new System.Drawing.Size(168, 23);
            this.cmdCheckLicense.TabIndex = 285;
            this.cmdCheckLicense.Text = "Order a license online";
            this.cmdCheckLicense.UseVisualStyleBackColor = true;
            this.cmdCheckLicense.Click += new System.EventHandler(this.cmdCheckLicense_Click);
            // 
            // frmAudioCDRipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 869);
            this.Controls.Add(this.cmdCheckLicense);
            this.Controls.Add(this.freeDB1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.audioCDRipper1);
            this.Controls.Add(this.cmdID3Tags);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.grpID3Tags);
            this.Controls.Add(this.grpDestinationFile);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdResume);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpProgress);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.cmdRip);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioCDRipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioCDRipper - Full Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioCDRipper_FormClosing);
            this.Load += new System.EventHandler(this.frmAudioCDRipper_Load);
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.pnlACM.ResumeLayout(false);
            this.pnlACM.PerformLayout();
            this.grpID3Tags.ResumeLayout(false);
            this.grpID3Tags.PerformLayout();
            this.grpDestinationFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpProgress.ResumeLayout(false);
            this.grpProgress.PerformLayout();
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSAudioCDRipper.AudioCDRipper audioCDRipper1;
        internal System.Windows.Forms.ComboBox cboDevice;
        internal System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ListView lstTracks;
        private System.Windows.Forms.ColumnHeader cTrackNum;
        private System.Windows.Forms.ColumnHeader cTrackName;
        private System.Windows.Forms.ColumnHeader cTrackTime;
        private System.Windows.Forms.ColumnHeader cTrackType;
        private System.Windows.Forms.Button cmdID3Tags;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.ComboBox cboChannels;
        private System.Windows.Forms.ComboBox cboBitrate;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.ComboBox cboSamplerate;
        private System.Windows.Forms.Label lblSamplerate;
        private System.Windows.Forms.ComboBox cboBits;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestinationFormat;
        private System.Windows.Forms.ComboBox cboDestinationFormat;
        private System.Windows.Forms.GroupBox grpID3Tags;
        private System.Windows.Forms.Label lblTagComment;
        private System.Windows.Forms.TextBox txtTagTitle;
        private System.Windows.Forms.Label lblTagTrackNum;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.TextBox txtTagTrackNum;
        private System.Windows.Forms.TextBox txtTagYear;
        private System.Windows.Forms.Label lblTagCopyright;
        private System.Windows.Forms.Label lblTagYear;
        private System.Windows.Forms.TextBox txtTagCopyright;
        private System.Windows.Forms.TextBox txtTagComment;
        private System.Windows.Forms.Label lblTagAlbum;
        private System.Windows.Forms.TextBox txtTagAlbum;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpDestinationFile;
        private System.Windows.Forms.Button cmdPlayWithDefaultPlayer;
        private System.Windows.Forms.Button cmdOpenFileLocation;
        private System.Windows.Forms.Label lblDestinationFile;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.ComboBox cboACMFormats;
        internal System.Windows.Forms.ComboBox cboACMTags;
        private System.Windows.Forms.Panel pnlACM;
        internal System.Windows.Forms.Label lblACMTag;
        internal System.Windows.Forms.Label lblACMFormats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpProgress;
        private System.Windows.Forms.ProgressBar prgCurrentProgress;
        private System.Windows.Forms.Label lblCurrentProgress;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.Button cmdLoadFreeDB;
        private System.Windows.Forms.Button cmdLoadFreeDBAsync;
        private System.Windows.Forms.Button cmdRip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnOpen;
        internal System.Windows.Forms.Label lblArtist;
        internal System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader cTrackSize;
        private System.Windows.Forms.ColumnHeader cTrackFile;
        private CSAudioCDRipper.FreeDB freeDB1;
        private System.Windows.Forms.Button cmdCheckLicense;
    }
}

