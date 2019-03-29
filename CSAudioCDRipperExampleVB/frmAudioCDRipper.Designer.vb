<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioCDRipper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioCDRipper))
        Me.lblTagComment = New System.Windows.Forms.Label()
        Me.txtTagTitle = New System.Windows.Forms.TextBox()
        Me.lblTagTrackNum = New System.Windows.Forms.Label()
        Me.txtTagTrackNum = New System.Windows.Forms.TextBox()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdPlayWithDefaultPlayer = New System.Windows.Forms.Button()
        Me.cmdOpenFileLocation = New System.Windows.Forms.Button()
        Me.lblDestinationFile = New System.Windows.Forms.Label()
        Me.lblTagTitle = New System.Windows.Forms.Label()
        Me.prgCurrentProgress = New System.Windows.Forms.ProgressBar()
        Me.lblCurrentProgress = New System.Windows.Forms.Label()
        Me.cmdCheckLicense = New System.Windows.Forms.Button()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdRip = New System.Windows.Forms.Button()
        Me.grpDestinationFile = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdLoadFreeDB = New System.Windows.Forms.Button()
        Me.cmdLoadFreeDBAsync = New System.Windows.Forms.Button()
        Me.grpProgress = New System.Windows.Forms.GroupBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.grpSource = New System.Windows.Forms.GroupBox()
        Me.lstTracks = New System.Windows.Forms.ListView()
        Me.cTrackNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboDevice = New System.Windows.Forms.ComboBox()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.txtTagYear = New System.Windows.Forms.TextBox()
        Me.cmdID3Tags = New System.Windows.Forms.Button()
        Me.grpDestination = New System.Windows.Forms.GroupBox()
        Me.pnlACM = New System.Windows.Forms.Panel()
        Me.cboACMFormats = New System.Windows.Forms.ComboBox()
        Me.cboACMTags = New System.Windows.Forms.ComboBox()
        Me.lblACMTag = New System.Windows.Forms.Label()
        Me.lblACMFormats = New System.Windows.Forms.Label()
        Me.cboChannels = New System.Windows.Forms.ComboBox()
        Me.cboBitrate = New System.Windows.Forms.ComboBox()
        Me.lblBitrate = New System.Windows.Forms.Label()
        Me.cboSamplerate = New System.Windows.Forms.ComboBox()
        Me.lblSamplerate = New System.Windows.Forms.Label()
        Me.cboBits = New System.Windows.Forms.ComboBox()
        Me.lblBits = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblDestinationFormat = New System.Windows.Forms.Label()
        Me.cboDestinationFormat = New System.Windows.Forms.ComboBox()
        Me.grpID3Tags = New System.Windows.Forms.GroupBox()
        Me.lblTagCopyright = New System.Windows.Forms.Label()
        Me.lblTagYear = New System.Windows.Forms.Label()
        Me.txtTagCopyright = New System.Windows.Forms.TextBox()
        Me.txtTagComment = New System.Windows.Forms.TextBox()
        Me.lblTagAlbum = New System.Windows.Forms.Label()
        Me.txtTagAlbum = New System.Windows.Forms.TextBox()
        Me.AudioCDRipper1 = New CSAudioCDRipper.AudioCDRipper()
        Me.FreeDB1 = New CSAudioCDRipper.FreeDB()
        Me.statusStrip1.SuspendLayout()
        Me.grpDestinationFile.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProgress.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSource.SuspendLayout()
        Me.grpDestination.SuspendLayout()
        Me.pnlACM.SuspendLayout()
        Me.grpID3Tags.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTagComment
        '
        Me.lblTagComment.AutoSize = True
        Me.lblTagComment.Location = New System.Drawing.Point(14, 82)
        Me.lblTagComment.Name = "lblTagComment"
        Me.lblTagComment.Size = New System.Drawing.Size(51, 13)
        Me.lblTagComment.TabIndex = 76
        Me.lblTagComment.Text = "Comment"
        '
        'txtTagTitle
        '
        Me.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTagTitle.Location = New System.Drawing.Point(17, 44)
        Me.txtTagTitle.Name = "txtTagTitle"
        Me.txtTagTitle.Size = New System.Drawing.Size(98, 20)
        Me.txtTagTitle.TabIndex = 14
        Me.txtTagTitle.Text = "CSAudioCDRipper"
        '
        'lblTagTrackNum
        '
        Me.lblTagTrackNum.AutoSize = True
        Me.lblTagTrackNum.Location = New System.Drawing.Point(222, 28)
        Me.lblTagTrackNum.Name = "lblTagTrackNum"
        Me.lblTagTrackNum.Size = New System.Drawing.Size(42, 13)
        Me.lblTagTrackNum.TabIndex = 75
        Me.lblTagTrackNum.Text = "Track#"
        '
        'txtTagTrackNum
        '
        Me.txtTagTrackNum.Location = New System.Drawing.Point(225, 44)
        Me.txtTagTrackNum.Name = "txtTagTrackNum"
        Me.txtTagTrackNum.Size = New System.Drawing.Size(98, 20)
        Me.txtTagTrackNum.TabIndex = 16
        Me.txtTagTrackNum.Text = "1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.toolStripStatusLabel1.Text = "Ready."
        '
        'cmdPlayWithDefaultPlayer
        '
        Me.cmdPlayWithDefaultPlayer.Location = New System.Drawing.Point(545, 24)
        Me.cmdPlayWithDefaultPlayer.Name = "cmdPlayWithDefaultPlayer"
        Me.cmdPlayWithDefaultPlayer.Size = New System.Drawing.Size(74, 23)
        Me.cmdPlayWithDefaultPlayer.TabIndex = 20
        Me.cmdPlayWithDefaultPlayer.Text = "Play"
        Me.toolTip1.SetToolTip(Me.cmdPlayWithDefaultPlayer, "Playe with the default system player.")
        Me.cmdPlayWithDefaultPlayer.UseVisualStyleBackColor = True
        '
        'cmdOpenFileLocation
        '
        Me.cmdOpenFileLocation.Location = New System.Drawing.Point(625, 24)
        Me.cmdOpenFileLocation.Name = "cmdOpenFileLocation"
        Me.cmdOpenFileLocation.Size = New System.Drawing.Size(145, 23)
        Me.cmdOpenFileLocation.TabIndex = 21
        Me.cmdOpenFileLocation.Text = "Open file Location"
        Me.toolTip1.SetToolTip(Me.cmdOpenFileLocation, "Open file Location.")
        Me.cmdOpenFileLocation.UseVisualStyleBackColor = True
        '
        'lblDestinationFile
        '
        Me.lblDestinationFile.Location = New System.Drawing.Point(27, 24)
        Me.lblDestinationFile.Name = "lblDestinationFile"
        Me.lblDestinationFile.Size = New System.Drawing.Size(512, 29)
        Me.lblDestinationFile.TabIndex = 74
        Me.lblDestinationFile.Text = "C:\"
        '
        'lblTagTitle
        '
        Me.lblTagTitle.AutoSize = True
        Me.lblTagTitle.Location = New System.Drawing.Point(14, 28)
        Me.lblTagTitle.Name = "lblTagTitle"
        Me.lblTagTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTagTitle.TabIndex = 66
        Me.lblTagTitle.Text = "Title"
        '
        'prgCurrentProgress
        '
        Me.prgCurrentProgress.Location = New System.Drawing.Point(20, 43)
        Me.prgCurrentProgress.Name = "prgCurrentProgress"
        Me.prgCurrentProgress.Size = New System.Drawing.Size(750, 23)
        Me.prgCurrentProgress.TabIndex = 6
        '
        'lblCurrentProgress
        '
        Me.lblCurrentProgress.AutoSize = True
        Me.lblCurrentProgress.Location = New System.Drawing.Point(17, 27)
        Me.lblCurrentProgress.Name = "lblCurrentProgress"
        Me.lblCurrentProgress.Size = New System.Drawing.Size(41, 13)
        Me.lblCurrentProgress.TabIndex = 55
        Me.lblCurrentProgress.Text = "Ready."
        '
        'cmdCheckLicense
        '
        Me.cmdCheckLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCheckLicense.Image = CType(resources.GetObject("cmdCheckLicense.Image"), System.Drawing.Image)
        Me.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheckLicense.Location = New System.Drawing.Point(637, 786)
        Me.cmdCheckLicense.Name = "cmdCheckLicense"
        Me.cmdCheckLicense.Size = New System.Drawing.Size(168, 23)
        Me.cmdCheckLicense.TabIndex = 301
        Me.cmdCheckLicense.Text = "Order a license online"
        Me.cmdCheckLicense.UseVisualStyleBackColor = True
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 847)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(820, 22)
        Me.statusStrip1.TabIndex = 300
        Me.statusStrip1.Text = "statusStrip1"
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(185, 786)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 287
        Me.cmdPause.Text = "Pause"
        Me.toolTip1.SetToolTip(Me.cmdPause, "Pause the entry progress.")
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'cmdResume
        '
        Me.cmdResume.Location = New System.Drawing.Point(266, 786)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(75, 23)
        Me.cmdResume.TabIndex = 288
        Me.cmdResume.Text = "Resume"
        Me.toolTip1.SetToolTip(Me.cmdResume, "Resume the progress.")
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(347, 786)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 23)
        Me.cmdCancel.TabIndex = 289
        Me.cmdCancel.Text = "Cancel"
        Me.toolTip1.SetToolTip(Me.cmdCancel, "Cancel the progress.")
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdRip
        '
        Me.cmdRip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdRip.Location = New System.Drawing.Point(12, 786)
        Me.cmdRip.Name = "cmdRip"
        Me.cmdRip.Size = New System.Drawing.Size(167, 23)
        Me.cmdRip.TabIndex = 286
        Me.cmdRip.Text = "Rip"
        Me.toolTip1.SetToolTip(Me.cmdRip, "Convert and join.")
        Me.cmdRip.UseVisualStyleBackColor = True
        '
        'grpDestinationFile
        '
        Me.grpDestinationFile.BackColor = System.Drawing.SystemColors.Control
        Me.grpDestinationFile.Controls.Add(Me.cmdPlayWithDefaultPlayer)
        Me.grpDestinationFile.Controls.Add(Me.cmdOpenFileLocation)
        Me.grpDestinationFile.Controls.Add(Me.lblDestinationFile)
        Me.grpDestinationFile.Location = New System.Drawing.Point(12, 681)
        Me.grpDestinationFile.Name = "grpDestinationFile"
        Me.grpDestinationFile.Size = New System.Drawing.Size(793, 71)
        Me.grpDestinationFile.TabIndex = 298
        Me.grpDestinationFile.TabStop = False
        Me.grpDestinationFile.Text = "Destination File"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(232, 18)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(510, 16)
        Me.label3.TabIndex = 297
        Me.label3.Text = ".NET component to rip audio cd tracks with FreeDB and ID3 tags support."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(7, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(217, 25)
        Me.label2.TabIndex = 296
        Me.label2.Text = "CSAudioCDRipper |"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox1.Location = New System.Drawing.Point(-36, 1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox1.TabIndex = 295
        Me.pictureBox1.TabStop = False
        '
        'cmdLoadFreeDB
        '
        Me.cmdLoadFreeDB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdLoadFreeDB.Location = New System.Drawing.Point(20, 329)
        Me.cmdLoadFreeDB.Name = "cmdLoadFreeDB"
        Me.cmdLoadFreeDB.Size = New System.Drawing.Size(132, 27)
        Me.cmdLoadFreeDB.TabIndex = 196
        Me.cmdLoadFreeDB.Text = "Load FreeDB"
        Me.cmdLoadFreeDB.UseVisualStyleBackColor = True
        '
        'cmdLoadFreeDBAsync
        '
        Me.cmdLoadFreeDBAsync.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdLoadFreeDBAsync.Location = New System.Drawing.Point(158, 329)
        Me.cmdLoadFreeDBAsync.Name = "cmdLoadFreeDBAsync"
        Me.cmdLoadFreeDBAsync.Size = New System.Drawing.Size(132, 27)
        Me.cmdLoadFreeDBAsync.TabIndex = 195
        Me.cmdLoadFreeDBAsync.Text = "Load FreeDB Async"
        Me.cmdLoadFreeDBAsync.UseVisualStyleBackColor = True
        '
        'grpProgress
        '
        Me.grpProgress.BackColor = System.Drawing.SystemColors.Control
        Me.grpProgress.Controls.Add(Me.prgCurrentProgress)
        Me.grpProgress.Controls.Add(Me.lblCurrentProgress)
        Me.grpProgress.Location = New System.Drawing.Point(12, 586)
        Me.grpProgress.Name = "grpProgress"
        Me.grpProgress.Size = New System.Drawing.Size(793, 89)
        Me.grpProgress.TabIndex = 294
        Me.grpProgress.TabStop = False
        Me.grpProgress.Text = "Progress"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist.Location = New System.Drawing.Point(372, 336)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(30, 13)
        Me.lblArtist.TabIndex = 201
        Me.lblArtist.Text = "Artist"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnClose.Location = New System.Drawing.Point(563, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 23)
        Me.btnClose.TabIndex = 198
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pictureBox2.Location = New System.Drawing.Point(-26, 9)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox2.TabIndex = 299
        Me.pictureBox2.TabStop = False
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbum.Location = New System.Drawing.Point(519, 336)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(36, 13)
        Me.lblAlbum.TabIndex = 200
        Me.lblAlbum.Text = "Album"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(672, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 23)
        Me.btnRefresh.TabIndex = 199
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(454, 19)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(103, 23)
        Me.btnOpen.TabIndex = 197
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'grpSource
        '
        Me.grpSource.BackColor = System.Drawing.SystemColors.Control
        Me.grpSource.Controls.Add(Me.lblArtist)
        Me.grpSource.Controls.Add(Me.lblAlbum)
        Me.grpSource.Controls.Add(Me.btnRefresh)
        Me.grpSource.Controls.Add(Me.btnClose)
        Me.grpSource.Controls.Add(Me.btnOpen)
        Me.grpSource.Controls.Add(Me.cmdLoadFreeDB)
        Me.grpSource.Controls.Add(Me.cmdLoadFreeDBAsync)
        Me.grpSource.Controls.Add(Me.lstTracks)
        Me.grpSource.Controls.Add(Me.cboDevice)
        Me.grpSource.Controls.Add(Me.lblDevice)
        Me.grpSource.Location = New System.Drawing.Point(12, 60)
        Me.grpSource.Name = "grpSource"
        Me.grpSource.Size = New System.Drawing.Size(793, 374)
        Me.grpSource.TabIndex = 291
        Me.grpSource.TabStop = False
        Me.grpSource.Text = "Source"
        '
        'lstTracks
        '
        Me.lstTracks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cTrackNum, Me.cTrackName, Me.cTrackTime, Me.cTrackSize, Me.cTrackType, Me.cTrackFile})
        Me.lstTracks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTracks.FullRowSelect = True
        Me.lstTracks.GridLines = True
        Me.lstTracks.HideSelection = False
        Me.lstTracks.Location = New System.Drawing.Point(22, 82)
        Me.lstTracks.MultiSelect = False
        Me.lstTracks.Name = "lstTracks"
        Me.lstTracks.Size = New System.Drawing.Size(750, 232)
        Me.lstTracks.TabIndex = 176
        Me.lstTracks.UseCompatibleStateImageBehavior = False
        Me.lstTracks.View = System.Windows.Forms.View.Details
        '
        'cTrackNum
        '
        Me.cTrackNum.Text = "Track Num"
        Me.cTrackNum.Width = 80
        '
        'cTrackName
        '
        Me.cTrackName.Text = "Track Name"
        Me.cTrackName.Width = 120
        '
        'cTrackTime
        '
        Me.cTrackTime.Text = "Track Time"
        Me.cTrackTime.Width = 120
        '
        'cTrackSize
        '
        Me.cTrackSize.Text = "Track Size"
        Me.cTrackSize.Width = 100
        '
        'cTrackType
        '
        Me.cTrackType.Text = "Track Type"
        Me.cTrackType.Width = 100
        '
        'cTrackFile
        '
        Me.cTrackFile.Text = "Track File"
        Me.cTrackFile.Width = 160
        '
        'cboDevice
        '
        Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboDevice.FormattingEnabled = True
        Me.cboDevice.Location = New System.Drawing.Point(22, 46)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.Size = New System.Drawing.Size(750, 21)
        Me.cboDevice.TabIndex = 175
        '
        'lblDevice
        '
        Me.lblDevice.AutoSize = True
        Me.lblDevice.Location = New System.Drawing.Point(22, 27)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(44, 13)
        Me.lblDevice.TabIndex = 174
        Me.lblDevice.Text = "Device:"
        '
        'txtTagYear
        '
        Me.txtTagYear.Location = New System.Drawing.Point(121, 98)
        Me.txtTagYear.Name = "txtTagYear"
        Me.txtTagYear.Size = New System.Drawing.Size(98, 20)
        Me.txtTagYear.TabIndex = 18
        '
        'cmdID3Tags
        '
        Me.cmdID3Tags.Location = New System.Drawing.Point(486, 786)
        Me.cmdID3Tags.Name = "cmdID3Tags"
        Me.cmdID3Tags.Size = New System.Drawing.Size(145, 23)
        Me.cmdID3Tags.TabIndex = 290
        Me.cmdID3Tags.Text = "ID3 Tags Editor"
        Me.cmdID3Tags.UseVisualStyleBackColor = True
        '
        'grpDestination
        '
        Me.grpDestination.BackColor = System.Drawing.SystemColors.Control
        Me.grpDestination.Controls.Add(Me.pnlACM)
        Me.grpDestination.Controls.Add(Me.cboChannels)
        Me.grpDestination.Controls.Add(Me.cboBitrate)
        Me.grpDestination.Controls.Add(Me.lblBitrate)
        Me.grpDestination.Controls.Add(Me.cboSamplerate)
        Me.grpDestination.Controls.Add(Me.lblSamplerate)
        Me.grpDestination.Controls.Add(Me.cboBits)
        Me.grpDestination.Controls.Add(Me.lblBits)
        Me.grpDestination.Controls.Add(Me.label1)
        Me.grpDestination.Controls.Add(Me.lblDestinationFormat)
        Me.grpDestination.Controls.Add(Me.cboDestinationFormat)
        Me.grpDestination.Location = New System.Drawing.Point(12, 440)
        Me.grpDestination.Name = "grpDestination"
        Me.grpDestination.Size = New System.Drawing.Size(441, 140)
        Me.grpDestination.TabIndex = 292
        Me.grpDestination.TabStop = False
        Me.grpDestination.Text = "Destination"
        '
        'pnlACM
        '
        Me.pnlACM.Controls.Add(Me.cboACMFormats)
        Me.pnlACM.Controls.Add(Me.cboACMTags)
        Me.pnlACM.Controls.Add(Me.lblACMTag)
        Me.pnlACM.Controls.Add(Me.lblACMFormats)
        Me.pnlACM.Location = New System.Drawing.Point(223, 15)
        Me.pnlACM.Name = "pnlACM"
        Me.pnlACM.Size = New System.Drawing.Size(398, 64)
        Me.pnlACM.TabIndex = 189
        '
        'cboACMFormats
        '
        Me.cboACMFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACMFormats.FormattingEnabled = True
        Me.cboACMFormats.Location = New System.Drawing.Point(197, 29)
        Me.cboACMFormats.Name = "cboACMFormats"
        Me.cboACMFormats.Size = New System.Drawing.Size(188, 21)
        Me.cboACMFormats.TabIndex = 72
        '
        'cboACMTags
        '
        Me.cboACMTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACMTags.FormattingEnabled = True
        Me.cboACMTags.Location = New System.Drawing.Point(3, 29)
        Me.cboACMTags.Name = "cboACMTags"
        Me.cboACMTags.Size = New System.Drawing.Size(188, 21)
        Me.cboACMTags.TabIndex = 70
        '
        'lblACMTag
        '
        Me.lblACMTag.AutoSize = True
        Me.lblACMTag.Location = New System.Drawing.Point(3, 13)
        Me.lblACMTag.Name = "lblACMTag"
        Me.lblACMTag.Size = New System.Drawing.Size(60, 13)
        Me.lblACMTag.TabIndex = 69
        Me.lblACMTag.Text = "ACM Tags:"
        '
        'lblACMFormats
        '
        Me.lblACMFormats.AutoSize = True
        Me.lblACMFormats.Location = New System.Drawing.Point(197, 13)
        Me.lblACMFormats.Name = "lblACMFormats"
        Me.lblACMFormats.Size = New System.Drawing.Size(73, 13)
        Me.lblACMFormats.TabIndex = 71
        Me.lblACMFormats.Text = "ACM Formats:"
        '
        'cboChannels
        '
        Me.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChannels.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboChannels.FormattingEnabled = True
        Me.cboChannels.Location = New System.Drawing.Point(214, 99)
        Me.cboChannels.Name = "cboChannels"
        Me.cboChannels.Size = New System.Drawing.Size(91, 21)
        Me.cboChannels.TabIndex = 12
        '
        'cboBitrate
        '
        Me.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBitrate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboBitrate.FormattingEnabled = True
        Me.cboBitrate.Location = New System.Drawing.Point(20, 99)
        Me.cboBitrate.Name = "cboBitrate"
        Me.cboBitrate.Size = New System.Drawing.Size(91, 21)
        Me.cboBitrate.TabIndex = 10
        '
        'lblBitrate
        '
        Me.lblBitrate.AutoSize = True
        Me.lblBitrate.Location = New System.Drawing.Point(17, 83)
        Me.lblBitrate.Name = "lblBitrate"
        Me.lblBitrate.Size = New System.Drawing.Size(37, 13)
        Me.lblBitrate.TabIndex = 31
        Me.lblBitrate.Text = "Bitrate"
        '
        'cboSamplerate
        '
        Me.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSamplerate.FormattingEnabled = True
        Me.cboSamplerate.Location = New System.Drawing.Point(117, 99)
        Me.cboSamplerate.Name = "cboSamplerate"
        Me.cboSamplerate.Size = New System.Drawing.Size(91, 21)
        Me.cboSamplerate.TabIndex = 11
        '
        'lblSamplerate
        '
        Me.lblSamplerate.AutoSize = True
        Me.lblSamplerate.Location = New System.Drawing.Point(114, 83)
        Me.lblSamplerate.Name = "lblSamplerate"
        Me.lblSamplerate.Size = New System.Drawing.Size(60, 13)
        Me.lblSamplerate.TabIndex = 33
        Me.lblSamplerate.Text = "Samplerate"
        '
        'cboBits
        '
        Me.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBits.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboBits.FormattingEnabled = True
        Me.cboBits.Location = New System.Drawing.Point(311, 98)
        Me.cboBits.Name = "cboBits"
        Me.cboBits.Size = New System.Drawing.Size(91, 21)
        Me.cboBits.TabIndex = 13
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Location = New System.Drawing.Point(308, 82)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(49, 13)
        Me.lblBits.TabIndex = 35
        Me.lblBits.Text = "Bit depth"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(211, 83)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Channels"
        '
        'lblDestinationFormat
        '
        Me.lblDestinationFormat.AutoSize = True
        Me.lblDestinationFormat.Location = New System.Drawing.Point(17, 28)
        Me.lblDestinationFormat.Name = "lblDestinationFormat"
        Me.lblDestinationFormat.Size = New System.Drawing.Size(95, 13)
        Me.lblDestinationFormat.TabIndex = 39
        Me.lblDestinationFormat.Text = "Destination Format"
        '
        'cboDestinationFormat
        '
        Me.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestinationFormat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDestinationFormat.FormattingEnabled = True
        Me.cboDestinationFormat.Location = New System.Drawing.Point(20, 44)
        Me.cboDestinationFormat.Name = "cboDestinationFormat"
        Me.cboDestinationFormat.Size = New System.Drawing.Size(188, 21)
        Me.cboDestinationFormat.TabIndex = 8
        '
        'grpID3Tags
        '
        Me.grpID3Tags.BackColor = System.Drawing.SystemColors.Control
        Me.grpID3Tags.Controls.Add(Me.lblTagComment)
        Me.grpID3Tags.Controls.Add(Me.txtTagTitle)
        Me.grpID3Tags.Controls.Add(Me.lblTagTrackNum)
        Me.grpID3Tags.Controls.Add(Me.lblTagTitle)
        Me.grpID3Tags.Controls.Add(Me.txtTagTrackNum)
        Me.grpID3Tags.Controls.Add(Me.txtTagYear)
        Me.grpID3Tags.Controls.Add(Me.lblTagCopyright)
        Me.grpID3Tags.Controls.Add(Me.lblTagYear)
        Me.grpID3Tags.Controls.Add(Me.txtTagCopyright)
        Me.grpID3Tags.Controls.Add(Me.txtTagComment)
        Me.grpID3Tags.Controls.Add(Me.lblTagAlbum)
        Me.grpID3Tags.Controls.Add(Me.txtTagAlbum)
        Me.grpID3Tags.Location = New System.Drawing.Point(459, 440)
        Me.grpID3Tags.Name = "grpID3Tags"
        Me.grpID3Tags.Size = New System.Drawing.Size(346, 140)
        Me.grpID3Tags.TabIndex = 293
        Me.grpID3Tags.TabStop = False
        Me.grpID3Tags.Text = "ID3 Tags"
        '
        'lblTagCopyright
        '
        Me.lblTagCopyright.AutoSize = True
        Me.lblTagCopyright.Location = New System.Drawing.Point(222, 82)
        Me.lblTagCopyright.Name = "lblTagCopyright"
        Me.lblTagCopyright.Size = New System.Drawing.Size(51, 13)
        Me.lblTagCopyright.TabIndex = 73
        Me.lblTagCopyright.Text = "Copyright"
        '
        'lblTagYear
        '
        Me.lblTagYear.AutoSize = True
        Me.lblTagYear.Location = New System.Drawing.Point(118, 82)
        Me.lblTagYear.Name = "lblTagYear"
        Me.lblTagYear.Size = New System.Drawing.Size(29, 13)
        Me.lblTagYear.TabIndex = 68
        Me.lblTagYear.Text = "Year"
        '
        'txtTagCopyright
        '
        Me.txtTagCopyright.Location = New System.Drawing.Point(225, 98)
        Me.txtTagCopyright.Name = "txtTagCopyright"
        Me.txtTagCopyright.Size = New System.Drawing.Size(98, 20)
        Me.txtTagCopyright.TabIndex = 19
        '
        'txtTagComment
        '
        Me.txtTagComment.Location = New System.Drawing.Point(19, 98)
        Me.txtTagComment.Name = "txtTagComment"
        Me.txtTagComment.Size = New System.Drawing.Size(96, 20)
        Me.txtTagComment.TabIndex = 17
        '
        'lblTagAlbum
        '
        Me.lblTagAlbum.AutoSize = True
        Me.lblTagAlbum.Location = New System.Drawing.Point(118, 28)
        Me.lblTagAlbum.Name = "lblTagAlbum"
        Me.lblTagAlbum.Size = New System.Drawing.Size(36, 13)
        Me.lblTagAlbum.TabIndex = 71
        Me.lblTagAlbum.Text = "Album"
        '
        'txtTagAlbum
        '
        Me.txtTagAlbum.Location = New System.Drawing.Point(121, 44)
        Me.txtTagAlbum.Name = "txtTagAlbum"
        Me.txtTagAlbum.Size = New System.Drawing.Size(98, 20)
        Me.txtTagAlbum.TabIndex = 15
        '
        'AudioCDRipper1
        '
        Me.AudioCDRipper1.About = Nothing
        Me.AudioCDRipper1.BitrateVal = 0
        Me.AudioCDRipper1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioCDRipper1.DestinatioFile = Nothing
        Me.AudioCDRipper1.Drives = Nothing
        Me.AudioCDRipper1.Location = New System.Drawing.Point(626, 21)
        Me.AudioCDRipper1.Name = "AudioCDRipper1"
        Me.AudioCDRipper1.RatingStars = 0!
        Me.AudioCDRipper1.RatingUser = "Windows Media Player 9 Series"
        Me.AudioCDRipper1.SamplerateVal = 0
        Me.AudioCDRipper1.SelectedDriveIndex = 0
        Me.AudioCDRipper1.Size = New System.Drawing.Size(52, 52)
        Me.AudioCDRipper1.TabIndex = 302
        Me.AudioCDRipper1.TagAlbum = Nothing
        Me.AudioCDRipper1.TagArtists = CType(resources.GetObject("AudioCDRipper1.TagArtists"), System.Collections.Generic.List(Of String))
        Me.AudioCDRipper1.TagComment = Nothing
        Me.AudioCDRipper1.TagComposers = CType(resources.GetObject("AudioCDRipper1.TagComposers"), System.Collections.Generic.List(Of String))
        Me.AudioCDRipper1.TagCopyright = Nothing
        Me.AudioCDRipper1.TagGenres = CType(resources.GetObject("AudioCDRipper1.TagGenres"), System.Collections.Generic.List(Of String))
        Me.AudioCDRipper1.TagLyrics = Nothing
        Me.AudioCDRipper1.TagPerformers = CType(resources.GetObject("AudioCDRipper1.TagPerformers"), System.Collections.Generic.List(Of String))
        Me.AudioCDRipper1.TagRating = CType(0, Short)
        Me.AudioCDRipper1.TagTitle = Nothing
        Me.AudioCDRipper1.TagTrack = CType(0UI, UInteger)
        Me.AudioCDRipper1.TagYear = Nothing
        Me.AudioCDRipper1.UserKey = "Your registration key"
        Me.AudioCDRipper1.UserName = "Your email"
        '
        'FreeDB1
        '
        Me.FreeDB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FreeDB1.FreeDBClientName = "FreedbDemo"
        Me.FreeDB1.FreeDBHostname = "abc.company"
        Me.FreeDB1.FreeDBSiteAddress = "us.freedb.org"
        Me.FreeDB1.FreeDBUserName = "test"
        Me.FreeDB1.FreeDBVersion = "1.0"
        Me.FreeDB1.Location = New System.Drawing.Point(680, 21)
        Me.FreeDB1.Name = "FreeDB1"
        Me.FreeDB1.Size = New System.Drawing.Size(52, 52)
        Me.FreeDB1.TabIndex = 303
        '
        'frmAudioCDRipper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 869)
        Me.Controls.Add(Me.FreeDB1)
        Me.Controls.Add(Me.AudioCDRipper1)
        Me.Controls.Add(Me.cmdCheckLicense)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.grpDestinationFile)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.grpProgress)
        Me.Controls.Add(Me.cmdRip)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.grpSource)
        Me.Controls.Add(Me.cmdID3Tags)
        Me.Controls.Add(Me.grpDestination)
        Me.Controls.Add(Me.grpID3Tags)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioCDRipper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioCDRipper - VB Full Example"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.grpDestinationFile.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProgress.ResumeLayout(False)
        Me.grpProgress.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSource.ResumeLayout(False)
        Me.grpSource.PerformLayout()
        Me.grpDestination.ResumeLayout(False)
        Me.grpDestination.PerformLayout()
        Me.pnlACM.ResumeLayout(False)
        Me.pnlACM.PerformLayout()
        Me.grpID3Tags.ResumeLayout(False)
        Me.grpID3Tags.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTagComment As Label
    Private WithEvents txtTagTitle As TextBox
    Private WithEvents lblTagTrackNum As Label
    Private WithEvents txtTagTrackNum As TextBox
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents cmdPlayWithDefaultPlayer As Button
    Private WithEvents toolTip1 As ToolTip
    Private WithEvents cmdOpenFileLocation As Button
    Private WithEvents lblDestinationFile As Label
    Private WithEvents lblTagTitle As Label
    Private WithEvents prgCurrentProgress As ProgressBar
    Private WithEvents lblCurrentProgress As Label
    Private WithEvents cmdCheckLicense As Button
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents cmdPause As Button
    Private WithEvents cmdResume As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdRip As Button
    Private WithEvents grpDestinationFile As GroupBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents cmdLoadFreeDB As Button
    Private WithEvents cmdLoadFreeDBAsync As Button
    Private WithEvents grpProgress As GroupBox
    Friend WithEvents lblArtist As Label
    Friend WithEvents btnClose As Button
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents lblAlbum As Label
    Private WithEvents btnRefresh As Button
    Friend WithEvents btnOpen As Button
    Private WithEvents grpSource As GroupBox
    Private WithEvents lstTracks As ListView
    Private WithEvents cTrackNum As ColumnHeader
    Private WithEvents cTrackName As ColumnHeader
    Private WithEvents cTrackTime As ColumnHeader
    Private WithEvents cTrackSize As ColumnHeader
    Private WithEvents cTrackType As ColumnHeader
    Private WithEvents cTrackFile As ColumnHeader
    Friend WithEvents cboDevice As ComboBox
    Friend WithEvents lblDevice As Label
    Private WithEvents txtTagYear As TextBox
    Private WithEvents cmdID3Tags As Button
    Private WithEvents grpDestination As GroupBox
    Private WithEvents pnlACM As Panel
    Friend WithEvents cboACMFormats As ComboBox
    Friend WithEvents cboACMTags As ComboBox
    Friend WithEvents lblACMTag As Label
    Friend WithEvents lblACMFormats As Label
    Private WithEvents cboChannels As ComboBox
    Private WithEvents cboBitrate As ComboBox
    Private WithEvents lblBitrate As Label
    Private WithEvents cboSamplerate As ComboBox
    Private WithEvents lblSamplerate As Label
    Private WithEvents cboBits As ComboBox
    Private WithEvents lblBits As Label
    Private WithEvents label1 As Label
    Private WithEvents lblDestinationFormat As Label
    Private WithEvents cboDestinationFormat As ComboBox
    Private WithEvents grpID3Tags As GroupBox
    Private WithEvents lblTagCopyright As Label
    Private WithEvents lblTagYear As Label
    Private WithEvents txtTagCopyright As TextBox
    Private WithEvents txtTagComment As TextBox
    Private WithEvents lblTagAlbum As Label
    Private WithEvents txtTagAlbum As TextBox
    Friend WithEvents AudioCDRipper1 As CSAudioCDRipper.AudioCDRipper
    Friend WithEvents FreeDB1 As CSAudioCDRipper.FreeDB
End Class
