#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

Imports System.Threading

Public Class frmAudioCDRipper

    ''' <summary>
    ''' Load the CD tracks to the list view.
    ''' </summary>
    ''' <returns></returns>
    Private Function LoadCDTracks() As Integer

        If AudioCDRipper1.CDIsReady(cboDevice.SelectedIndex) = False Then
            MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
            Return -1

        Else

            lstTracks.Items.Clear()
            Dim arr As String() = New String(5) {}
            Dim itm As ListViewItem

            For Each track As CSAudioCDRipper.AudioCDRipper.TrackInfo In AudioCDRipper1.GetTracks(cboDevice.SelectedIndex)
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

    ''' <summary>
    ''' Set the destination file. This example use the default music folder of Windows:
    ''' </summary>
    Private Sub SetDestinationFileName()

        'Get the default music directory of Windows:
        Dim sDestinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) & "\out." & cboDestinationFormat.Text.ToLower()

        'If the destination is ACM add the .WAV ext.
        If cboDestinationFormat.Text = "ACM" Then sDestinationFile = sDestinationFile & ".wav"

        'Set the lblDestinationFile:
        lblDestinationFile.Text = sDestinationFile

        'Set the destination file of the control:
        lblDestinationFile.Text = sDestinationFile

    End Sub

    Private Sub frmAudioCDRipper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioCDRipper1.UserName = "Your email"
        AudioCDRipper1.UserKey = "Your registration key"

        'Get the CD drives:
        cboDevice.DataSource = AudioCDRipper1.GetDevices()
        If cboDevice.Items.Count > 0 Then cboDevice.SelectedIndex = 0

#Region "LoadAudioProperties"
        'Formats:
        cboDestinationFormat.DataSource = AudioCDRipper1.GetFormats()
        cboDestinationFormat.Text = "MP3"

        'Bitrate
        cboBitrate.DataSource = AudioCDRipper1.GetBitrates()
        cboBitrate.Text = "192"

        'Samplerate
        cboSamplerate.DataSource = AudioCDRipper1.GetSamplerates()
        cboSamplerate.Text = "44100"

        'Bit depth
        cboBits.DataSource = AudioCDRipper1.GetBits()
        cboBits.Text = "16"

        'Channels
        cboChannels.DataSource = AudioCDRipper1.GetChannels()
        cboChannels.Text = "2"

        'Get all the ACM Tags that installed in the system (for ACM WAV) according to the sample-rate, bits-depth and channels:
        cboACMTags.DataSource = AudioCDRipper1.GetACMTags(CSAudioCDRipper.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16)
        cboACMTags.Text = "PCM"
#End Region

#Region "FreeDB"
        FreeDB1.FreeDBClientName = "FreedbDemo"
        FreeDB1.FreeDBHostname = "abc.company"
        FreeDB1.FreeDBSiteAddress = "us.freedb.org"
        FreeDB1.FreeDBUserName = "test"
        FreeDB1.FreeDBVersion = "1.0"
        txtTagYear.Text = DateTime.Now.Year.ToString()
#End Region

    End Sub

    Private Sub cboDevice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDevice.SelectedIndexChanged

        LoadCDTracks()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadCDTracks()

    End Sub

    ''' <summary>
    ''' When selecting the ACM WAV format, display the ACM Tags and Formats.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboDestinationFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestinationFormat.SelectedIndexChanged

        'Set the destination:
        SetDestinationFileName()

        lblBits.Visible = False
        cboBits.Visible = False
        pnlACM.Visible = False

        If cboDestinationFormat.Text = "ACM" Then

            'Display the ACM settings
            pnlACM.Visible = True
            pnlACM.Left = 20
            pnlACM.Top = 71

        End If

        If cboDestinationFormat.Text = "WAV" Then

            'Display the bit-depth combo box
            lblBits.Visible = True
            cboBits.Visible = True

        End If

    End Sub

    ''' <summary>
    ''' Get ACM formats according to the selected tag.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboACMTags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboACMTags.SelectedIndexChanged

        cboACMFormats.DataSource = AudioCDRipper1.GetACMFormats(cboACMTags.Text)
        cboACMFormats.SelectedIndex = 0

    End Sub

    ''' <summary>
    ''' Open the CD door.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        AudioCDRipper1.EjectCD(cboDevice.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Close the CD door.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        AudioCDRipper1.CloseCD(cboDevice.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Load the FreeDB information using the events.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdLoadFreeDB_Click(sender As Object, e As EventArgs) Handles cmdLoadFreeDB.Click

        If FreeDB1.CDIsReady(cboDevice.SelectedIndex) = False Then
            MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
            Return
        Else
            FreeDB1.GetFreeDBInfo(cboDevice.SelectedIndex)
        End If

    End Sub

    Private Sub FreeDB1_FreeDBAlbum(sender As Object, e As CSFreeDBLib.FreeDB.AlbumInfo) Handles FreeDB1.FreeDBAlbum

        Console.WriteLine(e.AlbumName)
        lblArtist.Text = e.AlbumArtist
        lblAlbum.Text = e.AlbumName
        txtTagAlbum.Text = e.AlbumName
        txtTagYear.Text = e.AlbumYear
        txtTagComment.Text = e.AlbumDiscID

    End Sub

    Private Sub FreeDB1_FreeDBDone(sender As Object) Handles FreeDB1.FreeDBDone

        toolStripStatusLabel1.Text = "Done."

    End Sub

    Private Sub FreeDB1_FreeDBError(sender As Object, e As CSFreeDB.Core.MessageArgs) Handles FreeDB1.FreeDBError

        MessageBox.Show(e.String & "(" & e.Number & ")")
        toolStripStatusLabel1.Text = e.String & "(" & e.Number & ")"

    End Sub

    Private Sub FreeDB1_FreeDBStatus(sender As Object, e As CSFreeDB.Core.MessageArgs) Handles FreeDB1.FreeDBStatus

        Console.WriteLine(e.String)
        toolStripStatusLabel1.Text = e.String

    End Sub

    Private Sub FreeDB1_FreeDBTracks(sender As Object, e As CSFreeDBLib.FreeDB.TrackInfo) Handles FreeDB1.FreeDBTracks

        Console.WriteLine(e.TrackName)
        lstTracks.Items(e.TrackNumber - 1).SubItems(1).Text = e.TrackName

    End Sub

    ''' <summary>
    ''' Load the FreeDB information in async mode.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdLoadFreeDBAsync_Click(sender As Object, e As EventArgs) Handles cmdLoadFreeDBAsync.Click

        Dim cntr As Integer = 0

        'Tracks names:
        For Each trckFreeDB As String In FreeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).FreeDBTracksInfo
            lstTracks.Items(cntr).SubItems(1).Text = trckFreeDB.ToString()
            cntr = cntr + 1
        Next

        'Album / Artist name:
        If cntr > 0 Then
            lblArtist.Text = "Artist: " & FreeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).Artist
            lblAlbum.Text = "Album: " & FreeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).AlbumName
        End If

    End Sub

    Private Sub AudioCDRipper1_RipAborted() Handles AudioCDRipper1.RipAborted

    End Sub

    Private Sub AudioCDRipper1_RipDone(sender As Object, e As EventArgs) Handles AudioCDRipper1.RipDone

        If (cboDestinationFormat.Text IsNot "WAV") AndAlso (cboDestinationFormat.Text IsNot "ACM") Then
            AudioCDRipper1.TagTitle = txtTagTitle.Text
            AudioCDRipper1.TagAlbum = txtTagAlbum.Text
            AudioCDRipper1.TagTrack = UInteger.Parse(txtTagTrackNum.Text)
            AudioCDRipper1.TagComment = txtTagComment.Text
            AudioCDRipper1.TagYear = txtTagYear.Text
            AudioCDRipper1.TagCopyright = txtTagCopyright.Text
            AudioCDRipper1.SetID3Tags(lblDestinationFile.Text)
        End If

        lblCurrentProgress.Text = "Done"
        toolStripStatusLabel1.Text = "Done"
        cmdRip.Enabled = True

    End Sub

    Private Sub AudioCDRipper1_RipError(sender As Object, e As CSAudioCDRipper.MessageArgs) Handles AudioCDRipper1.RipError

        Console.WriteLine("Error " & e.String)
        lblCurrentProgress.Text = "Error " & e.String & "(" & e.Number & ")"
        toolStripStatusLabel1.Text = lblCurrentProgress.Text
        cmdRip.Enabled = True

    End Sub

    Private Sub AudioCDRipper1_RipProgress(sender As Object, e As CSAudioCDRipper.PercentArgs) Handles AudioCDRipper1.RipProgress

        lblCurrentProgress.Text = e.Number & "%"
        toolStripStatusLabel1.Text = lblCurrentProgress.Text
        prgCurrentProgress.Value = e.Number

    End Sub

    Private Sub AudioCDRipper1_RipStart(sender As Object, e As EventArgs) Handles AudioCDRipper1.RipStart

        lblCurrentProgress.Text = "Ripping..."
        toolStripStatusLabel1.Text = "Ripping..."

    End Sub

    Private Sub cmdRip_Click(sender As Object, e As EventArgs) Handles cmdRip.Click

        'Check if already running:
        If AudioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Running Then
            MessageBox.Show("Already running.")
            Return
        End If

        'Select the drive index to rip from:
        AudioCDRipper1.SelectedDriveIndex = cboDevice.SelectedIndex

        'Set the destination properties:
        SetDestinationFileName()

        'Set the destination file:
        AudioCDRipper1.DestinatioFile = lblDestinationFile.Text

        '[Optional Default is MP3]
        'Set the destination audio format, this can be AAC, APE, MP2, MP3, OGG, PCM WAV, ACM WAV And WMA
        AudioCDRipper1.Format = CType([Enum].Parse(GetType(CSAudioCDRipper.Format), cboDestinationFormat.Text), CSAudioCDRipper.Format)

#Region "MoreOptionalProperties"

        'If the destination format is ACM (WAV) set the ACM tag and format.
        If cboDestinationFormat.Text = "ACM" Then

            'Set the ACM tag and format:

            '[Optional: Default is WAV]
            AudioCDRipper1.ACMTag = cboACMTags.Text

            '[Optional: Default is 44100, 16, Stereo]
            AudioCDRipper1.ACMFormat = cboACMFormats.Text

        End If

        '[Optional: Default is 192]
        'Set the bitrate of the destination
        AudioCDRipper1.Bitrate = CType([Enum].Parse(GetType(CSAudioCDRipper.Bitrate), cboBitrate.Text), CSAudioCDRipper.Bitrate)
        'Or set by value
        'audioCDRipper1.BitrateVal = 192

        '[Optional Default is 44100]
        'Set the sample rate of the destination (from 8000 to 48000)
        AudioCDRipper1.Samplerate = CType([Enum].Parse(GetType(CSAudioCDRipper.Samplerate), cboSamplerate.Text), CSAudioCDRipper.Samplerate)
        'Or set by value
        'audioCDRipper1.SamplerateVal = 48000;

        '[Optional: Default is 16]
        'Set the bit-depth of the destination file (8, 16, 24, 32)
        AudioCDRipper1.Bits = CType([Enum].Parse(GetType(CSAudioCDRipper.Bits), cboBits.Text), CSAudioCDRipper.Bits)

        '[Optional: Default is 2]
        'Set the number of the channels of the destination file (1 Or 2)
        AudioCDRipper1.Channels = CType([Enum].Parse(GetType(CSAudioCDRipper.Channels), cboChannels.Text), CSAudioCDRipper.Channels)

#End Region

        'First clear the SourceTracks list:
        AudioCDRipper1.SourceTracks.Clear()

#Region "JoinAndCutTracks"

        'Add one Or more tracks to the SourceTracks list. 
        'If you will add more then one source multimedia file to the list, 
        'the control will join them all into one multimedia file

        'Set the time length of the track to rip
        'TimeSpan from_time = New TimeSpan(0, 01, 30);
        'TimeSpan to_time = New TimeSpan(0, 02, 30);

        'Add one Or more tracks to the list
        'audioCDRipper1.SourceTracks.Add(New Options.Core.SourceTrack(0, from_time, to_time));
        'audioCDRipper1.SourceTracks.Add(New Options.Core.SourceTrack(1, from_time, to_time));

#End Region

        'Get the selected track to rip:
        Dim selected_track As Integer = lstTracks.Items.IndexOf(lstTracks.SelectedItems(0))

        'Add the selected track to the SourceTracks list:
        AudioCDRipper1.SourceTracks.Add(New Options.Core.SourceTrack(selected_track))

        'Rip
        AudioCDRipper1.Rip()

        'Disable the buttons controls until the process has ended:
        cmdRip.Enabled = False

    End Sub

    ''' <summary>
    ''' Pause the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click

        'Check if the process is running:
        If AudioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Running Then
            AudioCDRipper1.Pause()
        End If

    End Sub

    ''' <summary>
    ''' Resume the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdResume_Click(sender As Object, e As EventArgs) Handles cmdResume.Click

        'Check if the process is paused:
        If AudioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Paused Then
            AudioCDRipper1.[Resume]()
        End If

    End Sub

    ''' <summary>
    ''' Cancel the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        'Cancel:
        AudioCDRipper1.Cancel()

    End Sub

    ''' <summary>
    ''' Open the destination multimedia file with the default multimedia player of the system.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPlayWithDefaultPlayer_Click(sender As Object, e As EventArgs) Handles cmdPlayWithDefaultPlayer.Click

        If lblDestinationFile.Text = "" Then Return
        Process.Start(lblDestinationFile.Text)

    End Sub

    ''' <summary>
    ''' Open the directory of the destination multimedia file with the WIndows Explorer.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOpenFileLocation_Click(sender As Object, e As EventArgs) Handles cmdOpenFileLocation.Click

        Dim argument As String = "/select, """ & lblDestinationFile.Text & """"
        Process.Start("explorer.exe", argument)

    End Sub

    ''' <summary>
    ''' Safe exit.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioCDRipper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

#Region "SafeExit"

        'Check if already running:
        If AudioCDRipper1.OperationState = CSAudioCDRipper.OperationState.Running Then

            'Stop:
            AudioCDRipper1.Cancel()

            'Wait for the ready state
            While AudioCDRipper1.OperationState <> CSAudioCDRipper.OperationState.Ready
                Application.DoEvents()
                Thread.Sleep(100)
            End While
        End If

#End Region

    End Sub

    ''' <summary>
    ''' Check the license.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCheckLicense_Click(sender As Object, e As EventArgs) Handles cmdCheckLicense.Click

        If AudioCDRipper1.CheckLicense() Then MessageBox.Show("Registration is OK")

    End Sub

End Class
