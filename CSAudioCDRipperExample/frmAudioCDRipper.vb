Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CSAudioCDRipper.AudioCDRipper

Namespace CSAudioCDRipperExample
    Public Partial Class frmAudioCDRipper
        Inherits Form

        Public Sub New()
            Console.WriteLine("Hello")
            InitializeComponent()
        End Sub

        Private Sub cboDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            LoadCDTracks()
        End Sub

        Private Function LoadCDTracks() As Integer
            If audioCDRipper1.CDIsReady(cboDevice.SelectedIndex) = False Then
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
                Return -1
            Else
                lstTracks.Items.Clear()
                Dim arr As String() = New String(5) {}
                Dim itm As ListViewItem

                For Each track As CSAudioCDRipper.AudioCDRipper.TrackInfo In audioCDRipper1.GetTracks(cboDevice.SelectedIndex)
                    arr(0) = track.TrackNumber.ToString()
                    arr(1) = "Track" & track.TrackNumber.ToString("D2") & ".cda"
                    arr(2) = track.TrackLengthTime.ToString("hh\:mm\:ss\.ff")
                    arr(3) = track.TrackSizeString
                    arr(4) = track.TrackType
                    arr(5) = track.TrackFile
                    itm = New ListViewItem(arr)
                    lstTracks.Items.Add(itm)
                Next

                If lstTracks.Items.Count > 0 Then
                    lstTracks.Items(0).Selected = True
                End If

                Return 0
            End If
        End Function

        Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadCDTracks()
        End Sub

        Private Sub SetDestinationFileName()
            Dim sDestinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) & "\out." & cboDestinationFormat.Text.ToLower()
            If cboDestinationFormat.Text Is "ACM" Then sDestinationFile = sDestinationFile & ".wav"
            lblDestinationFile.Text = sDestinationFile
            lblDestinationFile.Text = sDestinationFile
        End Sub

        Private Sub frmAudioCDRipper_Load(ByVal sender As Object, ByVal e As EventArgs)
            cboDevice.DataSource = audioCDRipper1.GetDevices()
            If cboDevice.Items.Count > 0 Then cboDevice.SelectedIndex = 0
            audioCDRipper1.UserName = "Your email"
            audioCDRipper1.UserKey = "Your registration key"
            cboDestinationFormat.DataSource = audioCDRipper1.GetFormats()
            cboDestinationFormat.Text = "MP3"
            cboBitrate.DataSource = audioCDRipper1.GetBitrates()
            cboBitrate.Text = "192"
            cboSamplerate.DataSource = audioCDRipper1.GetSamplerates()
            cboSamplerate.Text = "44100"
            cboBits.DataSource = audioCDRipper1.GetBits()
            cboBits.Text = "16"
            cboChannels.DataSource = audioCDRipper1.GetChannels()
            cboChannels.Text = "2"
            cboACMTags.DataSource = audioCDRipper1.GetACMTags(CSAudioCDRipper.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16)
            cboACMTags.Text = "PCM"
            freeDB1.FreeDBClientName = "FreedbDemo"
            freeDB1.FreeDBHostname = "abc.company"
            freeDB1.FreeDBSiteAddress = "us.freedb.org"
            freeDB1.FreeDBUserName = "test"
            freeDB1.FreeDBVersion = "1.0"
            txtTagYear.Text = DateTime.Now.Year.ToString()
        End Sub

        Private Sub cboDestinationFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetDestinationFileName()
            lblBits.Visible = False
            cboBits.Visible = False
            pnlACM.Visible = False

            If cboDestinationFormat.Text Is "ACM" Then
                pnlACM.Visible = True
                pnlACM.Left = 20
                pnlACM.Top = 71
            End If

            If cboDestinationFormat.Text Is "WAV" Then
                lblBits.Visible = True
                cboBits.Visible = True
            End If
        End Sub

        Private Sub cboACMTags_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            cboACMFormats.DataSource = audioCDRipper1.GetACMFormats(cboACMTags.Text)
            cboACMFormats.SelectedIndex = 0
        End Sub

        Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDRipper1.EjectCD(cboDevice.SelectedIndex)
        End Sub

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDRipper1.CloseCD(cboDevice.SelectedIndex)
        End Sub

        Private Sub cmdLoadFreeDB_Click(ByVal sender As Object, ByVal e As EventArgs)
            If freeDB1.CDIsReady(cboDevice.SelectedIndex) = False Then
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
                Return
            Else
                freeDB1.GetFreeDBInfo(cboDevice.SelectedIndex)
            End If
        End Sub

        Private Sub cmdLoadFreeDBAsync_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim cntr As Integer = 0

            For Each trckFreeDB As String In freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).FreeDBTracksInfo
                lstTracks.Items(cntr).SubItems(1).Text = trckFreeDB.ToString()
                cntr = cntr + 1
            Next

            If cntr > 0 Then
                lblArtist.Text = "Artist: " & freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).Artist
                lblAlbum.Text = "Album: " & freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).AlbumName
            End If
        End Sub

        Private Sub freeDB1_FreeDBDone(ByVal sender As Object)
            toolStripStatusLabel1.Text = "Done."
        End Sub

        Private Sub freeDB1_FreeDBError(ByVal sender As Object, ByVal e As CSFreeDB.Core.MessageArgs)
            MessageBox.Show(e.String & "(" & e.Number & ")")
            toolStripStatusLabel1.Text = e.String & "(" & e.Number & ")"
        End Sub

        Private Sub freeDB1_FreeDBStatus(ByVal sender As Object, ByVal e As CSFreeDB.Core.MessageArgs)
            Console.WriteLine(e.String)
            toolStripStatusLabel1.Text = e.String
        End Sub

        Private Sub freeDB1_FreeDBAlbum(ByVal sender As Object, ByVal e As CSFreeDBLib.FreeDB.AlbumInfo)
            Console.WriteLine(e.AlbumName)
            lblArtist.Text = e.AlbumArtist
            lblAlbum.Text = e.AlbumName
            txtTagAlbum.Text = e.AlbumName
            txtTagYear.Text = e.AlbumYear
            txtTagComment.Text = e.AlbumDiscID
        End Sub

        Private Sub freeDB1_FreeDBTracks(ByVal sender As Object, ByVal e As CSFreeDBLib.FreeDB.TrackInfo)
            Console.WriteLine(e.TrackName)
            lstTracks.Items(e.TrackNumber - 1).SubItems(1).Text = e.TrackName
        End Sub

        Private Sub audioCDRipper1_RipProgress(ByVal sender As Object, ByVal e As CSAudioCDRipper.PercentArgs)
            lblCurrentProgress.Text = e.Number & "%"
            toolStripStatusLabel1.Text = lblCurrentProgress.Text
            prgCurrentProgress.Value = e.Number
        End Sub

        Private Sub audioCDRipper1_RipError(ByVal sender As Object, ByVal e As CSAudioCDRipper.MessageArgs)
            Console.WriteLine("Error " & e.String)
            lblCurrentProgress.Text = "Error " & e.String & "(" & e.Number & ")"
            toolStripStatusLabel1.Text = lblCurrentProgress.Text
            cmdRip.Enabled = True
        End Sub

        Private Sub audioCDRipper1_RipDone(ByVal sender As Object, ByVal e As EventArgs)
            If (cboDestinationFormat.Text IsNot "WAV") AndAlso (cboDestinationFormat.Text IsNot "ACM") Then
                audioCDRipper1.TagTitle = txtTagTitle.Text
                audioCDRipper1.TagAlbum = txtTagAlbum.Text
                audioCDRipper1.TagTrack = UInteger.Parse(txtTagTrackNum.Text)
                audioCDRipper1.TagComment = txtTagComment.Text
                audioCDRipper1.TagYear = txtTagYear.Text
                audioCDRipper1.TagCopyright = txtTagCopyright.Text
                audioCDRipper1.SetID3Tags(lblDestinationFile.Text)
            End If

            lblCurrentProgress.Text = "Done"
            toolStripStatusLabel1.Text = "Done"
            cmdRip.Enabled = True
        End Sub

        Private Sub audioCDRipper1_RipStart(ByVal sender As Object, ByVal e As EventArgs)
            lblCurrentProgress.Text = "Ripping..."
            toolStripStatusLabel1.Text = "Ripping..."
        End Sub

        Private Sub cmdRip_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Running Then
                MessageBox.Show("Already running.")
                Return
            End If

            audioCDRipper1.SelectedDriveIndex = cboDevice.SelectedIndex
            SetDestinationFileName()
            audioCDRipper1.DestinatioFile = lblDestinationFile.Text
            audioCDRipper1.Format = CType([Enum].Parse(GetType(CSAudioCDRipper.Format), cboDestinationFormat.Text), CSAudioCDRipper.Format)

            If cboDestinationFormat.Text Is "ACM" Then
                audioCDRipper1.ACMTag = cboACMTags.Text
                audioCDRipper1.ACMFormat = cboACMFormats.Text
            End If

            audioCDRipper1.Bitrate = CType([Enum].Parse(GetType(CSAudioCDRipper.Bitrate), cboBitrate.Text), CSAudioCDRipper.Bitrate)
            audioCDRipper1.Samplerate = CType([Enum].Parse(GetType(CSAudioCDRipper.Samplerate), cboSamplerate.Text), CSAudioCDRipper.Samplerate)
            audioCDRipper1.Bits = CType([Enum].Parse(GetType(CSAudioCDRipper.Bits), cboBits.Text), CSAudioCDRipper.Bits)
            audioCDRipper1.Channels = CType([Enum].Parse(GetType(CSAudioCDRipper.Channels), cboChannels.Text), CSAudioCDRipper.Channels)
            audioCDRipper1.SourceTracks.Clear()
            Dim selected_track As Integer = lstTracks.Items.IndexOf(lstTracks.SelectedItems(0))
            audioCDRipper1.SourceTracks.Add(New Options.Core.SourceTrack(selected_track))
            audioCDRipper1.Rip()
            cmdRip.Enabled = False
        End Sub

        Private Sub cmdPause_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Running Then
                audioCDRipper1.Pause()
            End If
        End Sub

        Private Sub cmdResume_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Paused Then
                audioCDRipper1.[Resume]()
            End If
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDRipper1.Cancel()
        End Sub

        Private Sub cmdPlayWithDefaultPlayer_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lblDestinationFile.Text Is "" Then Return
            Process.Start(lblDestinationFile.Text)
        End Sub

        Private Sub cmdOpenFileLocation_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim argument As String = "/select, """ & lblDestinationFile.Text & """"
            Process.Start("explorer.exe", argument)
        End Sub

        Private Sub frmAudioCDRipper_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If audioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Running Then
                audioCDRipper1.Cancel()

                While audioCDRipper1.OperationState <> CSAudioCDRipper.OperationState.Ready
                    Application.DoEvents()
                    Thread.Sleep(100)
                End While
            End If
        End Sub

        Private Sub cmdID3Tags_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lblDestinationFile.Text Is "" Then Return
            Dim frmAllID3Tags As frmID3TagsEditor = New frmID3TagsEditor()
            frmAllID3Tags.ShowDialog(Me)
        End Sub

        Private Sub cmdCheckLicense_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDRipper1.CheckLicense() Then MessageBox.Show("Registration is OK")
        End Sub
    End Class
End Namespace
