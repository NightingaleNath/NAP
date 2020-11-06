Imports System.IO
Imports System
Imports TagReaderLibrary
Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.Security
Imports NAP.MetadataCollector
Imports System.Speech
Imports System.Runtime.InteropServices

Public Class MainForm

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Dim dtmTest As Date = TimeValue(Now)
    Dim dd As Date = DateValue(Now)
    Private Sub textrec(ByVal text As System.String)

        Dim s As String
        s = "Yes Sir"
        Dim synth As New Synthesis.SpeechSynthesizer

        synth.SpeakAsync(s)




    End Sub
    Private Enum RecycleFlags As UInteger
        SHRB_NOCONFIRMATION = &H1
        SHRB_NOPROGRESSUI = &H2
        SHRB_NOSOUND = &H4
    End Enum
    <DllImport("Shell32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function SHEmptyRecycleBin(ByVal hwnd As IntPtr, ByVal pszRootPath As String, ByVal dwFlags As RecycleFlags) As UInteger
    End Function



#Region " Private Members "

    Private WithEvents _MediaPlayer As New MediaPlayer(0)
    Private _PlaylistFolder As String
    Private _CurrentVolume As Integer
    Private _PlayingIndex As Integer
    Private _IsLoading As Boolean
    Private _Error As Boolean
    Private _MouseOffset As Point
    Private _Songs As New Microsoft.VisualBasic.Collection

#End Region

#Region " Constructor "

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()
        Me.ListBoxMedia.DrawMode = DrawMode.OwnerDrawVariable
    End Sub

#End Region

#Region " Form Event Handlers "

    ' If there is no title bar, you can move the form just by dragging it.
    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        _MouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(_MouseOffset.X, _MouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _IsLoading Then
            _MediaPlayer.StopPlay()
            _MediaPlayer.Close()
            _MediaPlayer.Dispose()
            If My.Settings.SaveCurrentPlaylistOnShutdown Then
                If Directory.Exists(_PlaylistFolder) Then
                    ExportPlaylist(_PlaylistFolder & "\Default.m3u")
                End If
            End If
            ' Save volume.
            My.Settings.Volume = _CurrentVolume
            My.Settings.Save()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Loading the spwwch commands
        reco.SetInputToDefaultAudioDevice()

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim cmdRule As New Recognition.SrgsGrammar.SrgsRule("cmdrec")

        Dim cmdList As New Recognition.SrgsGrammar.SrgsOneOf("Hello Nightingale", "Open playlist", "Open", "Add playlist", "Play music", "Start music", "Play", "Stop music", "Stop")

        cmdRule.Add(cmdList)

        gram.Rules.Add(cmdRule)

        gram.Root = cmdRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()


        Me.Text = My.Application.Info.Title

        ' Set priority.
        Dim myProcess As Process = Process.GetCurrentProcess
        myProcess.PriorityClass = ProcessPriorityClass.AboveNormal

        ' Get settings.
        My.Settings.Reload()

        ' Get the playlist folder and if it doesn't exist then create a default one under "My Documents."
        _PlaylistFolder = My.Settings.PlaylistFolder
        If String.IsNullOrEmpty(_PlaylistFolder) Then
            _PlaylistFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Playlists"
            If Not Directory.Exists(_PlaylistFolder) Then
                Directory.CreateDirectory(_PlaylistFolder)
            End If
        End If

        ' If we start in the notification area, take care of that now.
        If My.Settings.StartInNotificationArea Then
            ToolStripMenuItemStartInNotificationArea.Checked = True
            NotifyIcon1.Visible = True
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
        End If

        ' If we start with Windows, take care of that now.
        If My.Settings.StartWithWindows Then
            ToolStripMenuItemStartWithWindows.Checked = True
            StartWindows()
        Else
            NoStartWindows()
        End If

        ' If we load the default (last used) playlist at startup, take care of that now.
        If My.Settings.LoadCurrentPlaylistOnStartup Then
            ToolStripMenuItemLoadCurrentPlaylistOnStartup.Checked = True
            If File.Exists(_PlaylistFolder & "\Default.m3u") Then
                ImportPlaylist(_PlaylistFolder & "\Default.m3u")
                Application.DoEvents()
            End If
        End If

        ' If we shuffle the default (last used) playlist at startup, take care of that now.
        If My.Settings.ShuffleCurrentPlaylistOnStartup Then
            ToolStripMenuItemShuffleCurrentPlaylistOnStartup.Checked = True
            ' Just click the button.
            ButtonShuffle.PerformClick()
            Application.DoEvents()
        End If

        ' If we save the current playlist as the default on shutdown, take care of that now.
        If My.Settings.SaveCurrentPlaylistOnShutdown Then
            ToolStripMenuItemSaveCurrentPlaylistOnShutdown.Checked = True
        End If

        ' Restore the last used volume setting.
        _CurrentVolume = My.Settings.Volume
        ColorSliderVolume.Value = _CurrentVolume
        _MediaPlayer.Volume = _CurrentVolume

        ' Start playing music if there is a playlist.
        If ListBoxMedia.Items.Count > 0 Then
            ' Just click the button.
            ButtonPlay.PerformClick()
            Application.DoEvents()
        End If

    End Sub

#End Region

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Dim synth As New Synthesis.SpeechSynthesizer

        Try

            Select Case e.Result.Text

                Case "Hello Nightingale"

                    Dim a1 As String
                    a1 = "Hello Sir"

                    synth.SpeakAsync(a1)

                Case "Open playlist"
                Case "Add playlist"
                Case "Open"
                    Dim a As String
                    a = "Select music from your drive and click open"
                    synth.SpeakAsync(a)
                    ButtonOpen.PerformClick()

                Case "Play music"
                Case "Start music"
                Case "Play"
                    Dim a2 As String
                    ButtonPlay.PerformClick()
                    textrec("a2")

                Case "Stop music"
                Case "Stop"
                    Dim a3 As String
                    ButtonStop.PerformClick()

            End Select

        Catch ex As Exception



            MsgBox("Invalid Command")

        End Try



    End Sub

#Region " Button Event Handlers "

    Private Sub ButtonPlay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContextToolStripMenuItemPlay.Click, ButtonPlay.Click

        If ListBoxMedia.Items.Count <= 0 Then Exit Sub
        If ListBoxMedia.SelectedItems.Count <= 0 Then ListBoxMedia.SelectedIndex = 0

        Dim selectedIndex As Integer
        Dim listItem As PlaylistData = CType(ListBoxMedia.SelectedItem(), PlaylistData)

        TimerMain.Enabled = True
        TimerTick.Enabled = True

        If Path.GetExtension(listItem.ReturnFileName).ToLower() = ".mp3" Then
            ' Display ID3 Tag data.
            Dim id3Data As Id3TagReader = New Id3TagReader()

            ' Read the tag information and get any error code.
            ' An empty string means success.
            Dim returnValue As String = id3Data.ReturnMetadata(listItem.ReturnFileName)

            If String.IsNullOrEmpty(returnValue) Then
                LabelArtist.Text = id3Data.TrackArtist
                LabelSong.Text = id3Data.TrackName
                PictureBoxAlbumArt.Image = id3Data.AttachedPicture
                ' Display artist and title as text on NotifyIcon (maximum length is 64 characters).
                NotifyIcon1.Text = Microsoft.VisualBasic.Left((id3Data.TrackArtist & " - " & id3Data.TrackName), 63)
                Application.DoEvents()
            End If

            ' dispose of tagreader.
            id3Data.Dispose()
        ElseIf Path.GetExtension(listItem.ReturnFileName).ToLower() = ".wma" Then
            ' Display WMA tag data.
            Dim wmaData As NAP.MetadataCollector = New NAP.MetadataCollector

            ' Read the tag information and get any error code.
            ' An empty string means success.
            Dim returnValue As String = wmaData.ReturnMetadata(listItem.ReturnFileName)

            If String.IsNullOrEmpty(returnValue) Then
                LabelArtist.Text = wmaData.Author
                LabelSong.Text = wmaData.Title
                PictureBoxAlbumArt.Image = wmaData.Picture
                ' Display artist and title as text on NotifyIcon (maximum length is 64 characters).
                NotifyIcon1.Text = Microsoft.VisualBasic.Left((wmaData.Author & " - " & wmaData.Title), 63)
                Application.DoEvents()
            End If

        End If

        _MediaPlayer.StopPlay()
        _MediaPlayer.Close()
        _MediaPlayer.Open(listItem.ReturnFileName)

        If listItem.Length = -1 Then
            Dim itemNew As New PlaylistData(listItem.FileName, listItem.Title & " (" & _MediaPlayer.FormatTime(_MediaPlayer.Duration) & ")", CLng(_MediaPlayer.Duration / 1000))
            selectedIndex = ListBoxMedia.SelectedIndex
            ListBoxMedia.Items.RemoveAt(selectedIndex)
            ListBoxMedia.Items.Insert(selectedIndex, itemNew)
            ListBoxMedia.SelectedIndex = selectedIndex
        Else
            Dim itemNew As New PlaylistData(listItem.FileName, listItem.Title, CLng(_MediaPlayer.Duration / 1000))
            selectedIndex = ListBoxMedia.SelectedIndex
            ListBoxMedia.Items.RemoveAt(selectedIndex)
            ListBoxMedia.Items.Insert(selectedIndex, itemNew)
            ListBoxMedia.SelectedIndex = selectedIndex
        End If

        _MediaPlayer.Play()
        _MediaPlayer.Volume = _CurrentVolume
        Me._PlayingIndex = ListBoxMedia.SelectedIndex
        ColorSliderProgress.Maximum = CInt(_MediaPlayer.Duration / 100)
        ColorSliderProgress.Value = 0
        LabelTotalTime.Text = "Time: " & _MediaPlayer.FormatTime(_MediaPlayer.CurrentPosition) & " / " & _MediaPlayer.FormatTime(_MediaPlayer.Duration)
    End Sub

    Private Sub ButtonStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonStop.Click
        ColorSliderProgress.Value = 0
        LabelTotalTime.Text = "Time: 00:00 / " & _MediaPlayer.FormatTime(_MediaPlayer.Duration)
        TimerMain.Enabled = False
        TimerTick.Enabled = False
        _MediaPlayer.StopPlay()
        _MediaPlayer.Close()


    End Sub

    Private Sub ButtonPause_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonPause.Click
        If ListBoxMedia.Items.Count <= 0 Then Exit Sub

        If _MediaPlayer.Playing Then
            _MediaPlayer.Pause()
            If _MediaPlayer.Paused Then
                TimerMain.Enabled = False
                TimerTick.Enabled = False
            Else
                TimerMain.Enabled = True
                TimerTick.Enabled = True
            End If
        End If

    End Sub

    Private Sub ButtonOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonOpen.Click

        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        OpenFileDialog1.Filter = "Music Files|*.mp3;*.wma;*.avi|WinAmp Playlist M3U|*.m3u"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not String.IsNullOrEmpty(OpenFileDialog1.FileNames(0)) Then
                ' Display wait message.
                ToolStripStatusLabelInfo.Text = "Processing songs, please wait..."
                ToolStripProgressBarLoading.Value = 0
                ToolStripProgressBarLoading.Visible = True
                _IsLoading = True
                ' Disable form and disallow listbox layout.
                Me.Enabled = False
                ListBoxMedia.SuspendLayout()
                Dim max As Integer = UBound(OpenFileDialog1.FileNames)
                ToolStripProgressBarLoading.Maximum = max
                Application.DoEvents()
                ' Adding this line and not reading the file names from OpenFileDialog1 made a dramatic increase in speed
                ' when open several hundred files at once.
                Dim fileNames() As String = OpenFileDialog1.FileNames
                For i As Integer = 0 To max
                    ToolStripProgressBarLoading.Value = i
                    AddSongToListBox(fileNames(i))
                    Application.DoEvents()
                Next
                ListBoxMedia.ResumeLayout()
                Me.Enabled = True
                ToolStripProgressBarLoading.Visible = False
            End If
        End If
        _IsLoading = False
        Me.Enabled = True
        ToolStripStatusLabelInfo.Text = "Songs: " & ListBoxMedia.Items.Count.ToString()
    End Sub

    Private Sub ButtonSeekBeginning_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSeekBeginning.Click

        If ListBoxMedia.Items.Count <= 0 Then Exit Sub

        ListBoxMedia.SelectedItems.Clear()
        If Me._PlayingIndex <= 0 Then
            ListBoxMedia.SelectedIndex = ListBoxMedia.Items.Count - 1
        Else
            ListBoxMedia.SelectedIndex = Me._PlayingIndex - 1
            ListBoxMedia.SetSelected(ListBoxMedia.SelectedIndex + 1, False)
        End If
        Me._PlayingIndex = ListBoxMedia.SelectedIndex
        If Not _MediaPlayer.Playing Then Exit Sub
        _MediaPlayer.StopPlay()
        _MediaPlayer.Close()
        ButtonPlay.PerformClick()
    End Sub

    Private Sub ButtonSeekEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSeekEnd.Click

        If ListBoxMedia.Items.Count <= 0 Then Exit Sub

        ListBoxMedia.SelectedItems.Clear()
        If Me._PlayingIndex >= ListBoxMedia.Items.Count - 1 Then
            ListBoxMedia.SelectedIndex = 0
        Else
            ListBoxMedia.SelectedIndex = Me._PlayingIndex + 1
            ListBoxMedia.SetSelected(ListBoxMedia.SelectedIndex - 1, False)
        End If
        Me._PlayingIndex = ListBoxMedia.SelectedIndex
        If Not _MediaPlayer.Playing Then Exit Sub
        _MediaPlayer.StopPlay()
        _MediaPlayer.Close()
        ButtonPlay.PerformClick()
    End Sub

    Private Sub ButtonShuffle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonShuffle.Click, ToolStripMenuItemShuffle.Click
        ' Disable form while shuffling.
        Me.Enabled = False
        ListBoxMedia.SuspendLayout()
        ' Display message.
        ToolStripStatusLabelInfo.Text = "Shuffling, please wait..."
        ' Add all the items in the list box to the collection.
        For i As Integer = 0 To ListBoxMedia.Items.Count - 1
            _Songs.Add(ListBoxMedia.Items(i))
        Next

        ' Seed the random number generator.
        Randomize()

        ' Clear the listbox.
        ListBoxMedia.Items.Clear()

        ' Now add the list data back to the listbox in random order.
        For i As Integer = 1 To _Songs.Count - 1
            ' Pick a random number between 1 and the end of the collection.
            Dim index As Integer = CInt(Int(((_Songs.Count - 1) * Rnd()) + 1))
            ListBoxMedia.Items.Add(_Songs(index))
            ' Remove the song from the collection so there are no repeats.
            _Songs.Remove(index)
        Next
        ListBoxMedia.ResumeLayout()
        Me.Enabled = True
        ToolStripStatusLabelInfo.Text = "Songs: " & ListBoxMedia.Items.Count.ToString()


    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click

        If Directory.Exists(_PlaylistFolder) Then
            SaveFileDialog1.InitialDirectory = _PlaylistFolder
        Else
            SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        End If

        SaveFileDialog1.Title = "Save Playlist"
        SaveFileDialog1.Filter = "Music Files|*.mp3;*.wma;*.avi|WinAmp Playlist M3U|*.m3u"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ExportPlaylist(SaveFileDialog1.FileName)
        End If

    End Sub

#End Region

#Region " ColorSlider Event Handlers "

    Private Sub ColorSliderProgress_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        TimerTick.Enabled = False
    End Sub

    Private Sub ColorSliderProgress_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _MediaPlayer.Seek(ColorSliderProgress.Value * 100)
        TimerTick.Enabled = True
    End Sub

    Private Sub ColorSliderVolume_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles ColorSliderVolume.Scroll
        Try
            _MediaPlayer.Volume = ColorSliderVolume.Value
            _CurrentVolume = ColorSliderVolume.Value
        Catch ex As ApplicationException
        End Try
    End Sub

#End Region

#Region " ListBox Event Handlers "

    Private Sub ListBoxMedia_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ListBoxMedia.DoubleClick
        _MediaPlayer.StopPlay()
        _MediaPlayer.Close()
        TimerMain.Enabled = True
        TimerTick.Enabled = True
        ButtonPlay.PerformClick()
    End Sub

    Private Sub ListBoxMedia_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxMedia.MouseDown
        Dim index As Integer, pt As New Point(e.X, e.Y)
        index = ListBoxMedia.IndexFromPoint(pt)
        If e.Button = MouseButtons.Right And index >= 0 And index < ListBoxMedia.Items.Count And Control.ModifierKeys <> Keys.Shift Then
            ListBoxMedia.SelectedItems.Clear()
            ListBoxMedia.SelectedIndex = index
            ContextMenuStripListBox.Show(Me.ListBoxMedia, pt)
        ElseIf e.Button = MouseButtons.Left And index >= 0 And index < ListBoxMedia.Items.Count And Control.ModifierKeys <> Keys.Shift Then
            ListBoxMedia.ClearSelected()
            ListBoxMedia.SelectedIndex = index
            If Not _MediaPlayer.Playing Then
                Me._PlayingIndex = index
            End If
        End If
    End Sub

    Private Sub ListBoxMedia_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBoxMedia.DrawItem
        Dim brush As New SolidBrush(Color.FromArgb(64, 64, 64))
        Dim selectedBrush As New SolidBrush(Color.FromArgb(255, 192, 192))
        Dim myFont As New Font("Verdana", 7.5)

        e.DrawBackground()
        If e.Index < 0 Then Exit Sub

        If e.Index = Me._PlayingIndex Then
            e.Graphics.DrawString(ListBoxMedia.Items(e.Index).ToString, myFont, selectedBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            ' If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle()
        Else
            e.Graphics.DrawString(ListBoxMedia.Items(e.Index).ToString, myFont, brush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            ' If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle()
        End If
    End Sub

#End Region

#Region " MediaPlayer Event Handlers "

    Private Sub _MediaPlayer_ErrorNumber(ByVal sender As Object, ByVal e As ErrorEventArgs) Handles _MediaPlayer.ErrorNumber
        If Not _Error Then
            MessageBox.Show("The media player has encountered an error: " & e.ErrorNumber.ToString(), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ' Flag error so we don't get multiple message boxes.
        _Error = True
    End Sub

#End Region

#Region " MenuStrip Event Handlers "

    ' If there is no title bar, you can move the form just by dragging it.
    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        _MouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(_MouseOffset.X, _MouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

#End Region

#Region " NotifyIcon Event Handlers "

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

#End Region

#Region " PictureBox Event Handlers "

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        NotifyIcon1.Visible = True
    End Sub

#End Region

#Region " Timer Event Handlers "

    Private Sub TimerMain_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerMain.Tick
        LabelTotalTime.Text = "Time: " & _MediaPlayer.FormatTime(_MediaPlayer.CurrentPosition) _
                                       & " / " & _MediaPlayer.FormatTime(_MediaPlayer.Duration)
        If _MediaPlayer.CurrentPosition >= _MediaPlayer.Duration And _MediaPlayer.Playing Then
            ButtonSeekEnd.PerformClick()
        End If
    End Sub

    Private Sub TimerTick_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerTick.Tick
        ColorSliderProgress.Value = CInt(_MediaPlayer.CurrentPosition / 100)
    End Sub

#End Region

#Region " ToolStripMenuItem Event Handlers "

    Private Sub ContextToolStripMenuItemDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContextToolStripMenuItemDelete.Click
        ListBoxMedia.Items.Remove(ListBoxMedia.SelectedItem)
    End Sub

    Private Sub ContextToolStripMenuItemClearPlaylist_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContextToolStripMenuItemClearPlaylist.Click
        ListBoxMedia.Items.Clear()
        ToolStripStatusLabelInfo.Text = "Songs: 0"
    End Sub

    Private Sub ToolStripMenuItemOpenFiles_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemOpenFiles.Click
        ButtonOpen.PerformClick()
    End Sub

    Private Sub ToolStripMenuItemExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemExit.Click
        _MediaPlayer.StopPlay()
        _MediaPlayer.Close()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItemSavePlaylistAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemSavePlaylistAs.Click
        ButtonSave.PerformClick()
    End Sub

    Private Sub ToolStripMenuItemPlay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemPlay.Click
        ButtonPlay.PerformClick()
        ToolStripMenuItemPause.Checked = False
    End Sub

    Private Sub ToolStripMenuItemClearPlaylist_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemClearPlaylist.Click
        ListBoxMedia.Items.Clear()
        ToolStripStatusLabelInfo.Text = "Songs: 0"
    End Sub

    Private Sub ToolStripMenuItemAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemAbout.Click
        AboutDialog.ShowDialog()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StopToolStripMenuItem.Click
        ButtonStop.PerformClick()
        ToolStripMenuItemPause.Checked = False
    End Sub

    Private Sub ToolStripMenuItemPause_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemPause.Click, ToolStripMenuItemPause2.Click
        ButtonPause.PerformClick()
        ToolStripMenuItemPause.Checked = _MediaPlayer.Paused
        ToolStripMenuItemPause2.Checked = _MediaPlayer.Paused
    End Sub

    Private Sub ToolStripMenuItemNextTrack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemNextTrack.Click
        ButtonSeekEnd.PerformClick()
    End Sub

    Private Sub ToolStripMenuItemPreviousTrack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItemPreviousTrack.Click
        ButtonSeekBeginning.PerformClick()
    End Sub

    Private Sub ToolStripMenuItemShowForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemShowForm.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ToolStripMenuItemMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemMute.Click, ButtonMute.Click
        If ToolStripMenuItemMute.Checked Then
            ToolStripMenuItemMute.Image = My.Resources.UnMute
            ToolStripMenuItemMute.Checked = False
            ButtonMute.Text = "&Mute"
            _MediaPlayer.MuteAll = False


        Else

            ToolStripMenuItemMute.Image = My.Resources.Mute
            ToolStripMenuItemMute.Checked = True
            ButtonMute.Text = "&Unmute"
            _MediaPlayer.MuteAll = True

        End If
    End Sub

    Private Sub ToolStripMenuItemExit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemExit2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItemChangePlaylistFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemChangePlaylistFolder.Click
        If Directory.Exists(_PlaylistFolder) Then
            FolderBrowserDialog1.SelectedPath = _PlaylistFolder
        Else
            FolderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        End If
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
        FolderBrowserDialog1.Description = "Select default playlist folder"
        Dim results As DialogResult = FolderBrowserDialog1.ShowDialog()
        If results = Windows.Forms.DialogResult.OK Then
            _PlaylistFolder = FolderBrowserDialog1.SelectedPath
            My.Settings.PlaylistFolder = _PlaylistFolder
            My.Settings.Save()
        Else
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Playlists")
            _PlaylistFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Playlists"
            My.Settings.PlaylistFolder = _PlaylistFolder
            My.Settings.Save()
        End If

    End Sub

    Private Sub ToolStripMenuItemLoadCurrentPlaylistOnStartup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemLoadCurrentPlaylistOnStartup.Click
        If ToolStripMenuItemLoadCurrentPlaylistOnStartup.Checked Then
            ToolStripMenuItemLoadCurrentPlaylistOnStartup.Checked = False
            My.Settings.LoadCurrentPlaylistOnStartup = False
            My.Settings.Save()
        Else
            ToolStripMenuItemLoadCurrentPlaylistOnStartup.Checked = True
            My.Settings.LoadCurrentPlaylistOnStartup = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub ToolStripMenuItemSaveCurrentPlaylistOnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemSaveCurrentPlaylistOnShutdown.Click
        If ToolStripMenuItemSaveCurrentPlaylistOnShutdown.Checked Then
            ToolStripMenuItemSaveCurrentPlaylistOnShutdown.Checked = False
            My.Settings.SaveCurrentPlaylistOnShutdown = False
            My.Settings.Save()
        Else
            ToolStripMenuItemSaveCurrentPlaylistOnShutdown.Checked = True
            My.Settings.SaveCurrentPlaylistOnShutdown = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub ToolStripMenuItemStartInNotificationArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemStartInNotificationArea.Click
        If ToolStripMenuItemStartInNotificationArea.Checked Then
            ToolStripMenuItemStartInNotificationArea.Checked = False
            My.Settings.StartInNotificationArea = False
            My.Settings.Save()
        Else
            ToolStripMenuItemStartInNotificationArea.Checked = True
            My.Settings.StartInNotificationArea = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub ToolStripMenuItemShuffleCurrentPlaylistOnStartup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemShuffleCurrentPlaylistOnStartup.Click
        If ToolStripMenuItemShuffleCurrentPlaylistOnStartup.Checked Then
            ToolStripMenuItemShuffleCurrentPlaylistOnStartup.Checked = False
            My.Settings.ShuffleCurrentPlaylistOnStartup = False
            My.Settings.Save()
        Else
            ToolStripMenuItemShuffleCurrentPlaylistOnStartup.Checked = True
            My.Settings.ShuffleCurrentPlaylistOnStartup = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub ToolStripMenuItemStartWithWindows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemStartWithWindows.Click
        If ToolStripMenuItemStartWithWindows.Checked Then
            ToolStripMenuItemStartWithWindows.Checked = False
            My.Settings.StartWithWindows = False
            My.Settings.Save()
            NoStartWindows()
        Else
            ToolStripMenuItemStartWithWindows.Checked = True
            My.Settings.StartWithWindows = True
            My.Settings.Save()
            StartWindows()
        End If
    End Sub

#End Region

#Region " Private Methods "

    Private Shared Sub NoStartWindows()

        Const registryPath As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Dim rk As RegistryKey = Nothing

        Try
            rk = Registry.CurrentUser.OpenSubKey(registryPath, True)
            rk.DeleteValue(My.Application.Info.Title)
        Catch ex As Win32Exception
            ' Ignore
        Catch ex As ArgumentException
            ' Ignore
        Catch ex As SecurityException
            ' Ignore
        Catch ex As ObjectDisposedException
            ' Ignore
        Catch ex As UnauthorizedAccessException
            ' Ignore
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

    End Sub

    Private Shared Sub StartWindows()

        Const registryPath As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Dim rk As RegistryKey = Nothing

        Try
            rk = Registry.CurrentUser.OpenSubKey(registryPath, True)
            rk.SetValue(My.Application.Info.Title, Application.ExecutablePath)
        Catch ex As Win32Exception
            ' Ignore
        Catch ex As ArgumentException
            ' Ignore
        Catch ex As SecurityException
            ' Ignore
        Catch ex As ObjectDisposedException
            ' Ignore
        Catch ex As UnauthorizedAccessException
            ' Ignore
        Catch ex As IOException
            ' Ignore
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

    End Sub

    Private Sub AddSongToListBox(ByVal fileName As String)
        If LCase(Path.GetExtension(fileName)) = ".m3u" Then
            ImportPlaylist(fileName)
        Else
            Dim listItem As New PlaylistData(fileName, Path.GetFileNameWithoutExtension(fileName), -1)
            ListBoxMedia.Items.Add(listItem)
        End If
    End Sub

    Private Sub ImportPlaylist(ByVal fileName As String)
        Dim playlist As New PlaylistManager(fileName), x As Integer, time As Long
        playlist.Read()
        If playlist.Songs < 1 Then Exit Sub
        For x = 0 To playlist.Songs - 1
            time = CLng(CDbl(playlist.SongLength(x)) * 1000)
            If time > 0 Then
                Dim listitem As New PlaylistData(playlist.SongFile(x), playlist.SongTitle(x) & " (" & _MediaPlayer.FormatTime(CInt(time)) & ")", CLng(playlist.SongLength(x)))
                ListBoxMedia.Items.Add(listitem)
            Else
                Dim listitem As New PlaylistData(playlist.SongFile(x), playlist.SongTitle(x), -1)
                ListBoxMedia.Items.Add(listitem)
            End If
        Next
    End Sub

    Private Sub ExportPlaylist(ByVal filePath As String)

        Dim playlistMgr As New PlaylistManager(filePath)
        Dim fileName(ListBoxMedia.Items.Count) As String
        Dim songTitle(ListBoxMedia.Items.Count) As String
        Dim songLength(ListBoxMedia.Items.Count) As Long
        Dim x As Integer

        For x = 1 To ListBoxMedia.Items.Count
            Dim listitem As PlaylistData = CType(ListBoxMedia.Items.Item(x - 1), PlaylistData)

            fileName(x - 1) = listitem.ReturnFileName
            If listitem.Length > 0 Then
                songTitle(x - 1) = listitem.Title.Substring(0, Len(listitem.Title) - 8)
            End If
            songLength(x - 1) = listitem.ReturnLength
        Next
        playlistMgr.SaveToM3U(fileName, songTitle, songLength)

    End Sub

#End Region

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ColorSliderVolume_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBoxMedia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMedia.SelectedIndexChanged

    End Sub

    Private Sub PictureBoxClose_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxClose.MouseHover
        PictureBoxClose.BackgroundImage = My.Resources.BTN_SYS_CLOSE2
    End Sub

    Private Sub PictureBoxClose_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxClose.MouseLeave
        PictureBoxClose.BackgroundImage = My.Resources.BTN_SYS_CLOSE1
    End Sub

    Private Sub PictureBoxMinimize_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxMinimize.MouseHover
        PictureBoxMinimize.BackgroundImage = My.Resources.BTN_SYS_MINIMIZE2
    End Sub

    Private Sub PictureBoxMinimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMinimize.MouseLeave
        PictureBoxMinimize.BackgroundImage = My.Resources.BTN_SYS_MINIMIZE1
    End Sub

    Private Sub ToolStripStatusLabelInfo_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabelInfo.Click

    End Sub

    Private Sub ColorSliderProgress_Scroll(sender As Object, e As ScrollEventArgs) Handles ColorSliderProgress.Scroll

    End Sub
End Class

