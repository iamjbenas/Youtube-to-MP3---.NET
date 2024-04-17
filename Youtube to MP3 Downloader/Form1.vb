Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1

    '/ Please give proper credits :), It's a simple way to say thank you. 
    'Made by Josh.
    'Purchase API key here > https://api.c99.nl/
    'based on API it can only download a maximum of 10 minutes :(. I hope they'll find a way to increase it more like
    '1 hour or 2 or maybe 3.


    Private WithEvents downloadClient As WebClient
    Private downloadPath As String
    Dim apiKey As String = "XXXXX-XXXXX-XXXXX-XXXXX" 'Your API Key here.
    Private WithEvents typingTimer As New Timer()
    Private currentIndex As Integer = 0
    Private labelText As String
    Private Sub typingTimer_Tick(sender As Object, e As EventArgs) Handles typingTimer.Tick
        If currentIndex < labelText.Length Then
            BonfireLabel8.Text &= labelText(currentIndex)
            currentIndex += 1
        Else
            typingTimer.Stop()
        End If
    End Sub
    Public Function ConvertSecondsToTime(seconds As Integer) As String
        Dim hours As Integer = seconds \ 3600
        Dim remainingSeconds As Integer = seconds Mod 3600
        Dim minutes As Integer = remainingSeconds \ 60
        Dim remainingSecondsFinal As Integer = remainingSeconds Mod 60
        If seconds > 600 Then
            MessageBox.Show("The youtube video is exceeded over 10 minutes, please take note that Joshua's youtube downloader can only download 10 minutes below as of the moment.")
        End If
        Dim timeString As String = String.Format("{0}:{1:D2}", minutes, remainingSecondsFinal)
        If hours > 0 Then
            timeString = hours.ToString() & ":" & timeString
        End If
        Return timeString
    End Function
    Private Async Function FetchDataAsync() As Task
        Dim videoId As String = vidid.Text
        Dim apiUrl As String = $"https://api.c99.nl/youtubedetails?key={apiKey}&videoid={videoId}&json"
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim jsonObj As JObject = JObject.Parse(jsonResponse)
                    Dim title As String = jsonObj("title").ToString()
                    Dim duration As String = jsonObj("duration").ToString()
                    Dim thumbnail As String = jsonObj("thumbnail").ToString()
                    Dim uploader As String = jsonObj("uploader").ToString()
                    Me.Invoke(Async Sub()
                                  titles.Text = title
                                  Dim seconds As Integer = duration
                                  Dim timeString As String = ConvertSecondsToTime(seconds)
                                  dur.Text = timeString
                                  PictureBox3.Load(thumbnail)
                                  uploaderr.Text = uploader
                                  Await Download()
                              End Sub)
                Else
                    MessageBox.Show($"Failed to fetch data. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Function
    Private Async Function Download() As Task
        Dim videoId As String = vidid.Text
        Dim apiUrl As String = $"https://api.c99.nl/youtubemp3?key={apiKey}&videoid={videoId}&json"
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim jsonObj As JObject = JObject.Parse(jsonResponse)
                    Dim url As String = jsonObj("url").ToString()
                    Me.Invoke(Async Sub()
                                  hh.Text = url
                                  Button1.Enabled = True
                                  Panel1.Visible = False
                                  Button2.Enabled = True
                                  TextBoxYouTubeLink.Enabled = True
                              End Sub)
                Else
                    MessageBox.Show($"Failed to fetch data. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Function

    Private Async Function Button2_ClickAsync(sender As Object, e As EventArgs) As Task Handles Button2.Click
        Button2.Enabled = False
        TextBoxYouTubeLink.Enabled = False

        Dim youtubeLink As String = TextBoxYouTubeLink.Text
        Dim videoId As String = ExtractVideoId(youtubeLink)
        vidid.Text = videoId
        Await FetchDataAsync()
        Button1.Enabled = False
        Panel1.Visible = True
    End Function
    Private Function ExtractVideoId(youtubeLink As String) As String
        Dim pattern As String = "(?<=v=)[a-zA-Z0-9_-]+"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(youtubeLink)
        If match.Success Then
            Return match.Value
        Else
            Return "Video ID not found"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Function ReplaceIllegalCharacters(inputText As String) As String
        Dim illegalChars As String = New String(Path.GetInvalidFileNameChars()) & New String(Path.GetInvalidPathChars())
        Dim validChar As Char = "_"c
        For Each c As Char In illegalChars
            inputText = inputText.Replace(c, validChar)
        Next
        Return inputText
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxYouTubeLink.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Dim url As String = hh.Text
        ProgressBar1.Text = "Downloading...."
        downloadPath = savepath.Text & "\" & ReplaceIllegalCharacters(titles.Text) & ".mp3"
        Dim downloadThread As New System.Threading.Thread(Sub()
                                                              DownloadFile(url)
                                                          End Sub)
        downloadThread.Start()
    End Sub
    Private Sub DownloadFile(url As String)
        Try
            Dim request As HttpWebRequest = WebRequest.Create(url)
            request.Method = WebRequestMethods.Http.Get
            Dim response As HttpWebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Using fileStream As New FileStream(downloadPath, FileMode.Create)
                Dim buffer(4096) As Byte
                Dim bytesRead As Integer
                Dim totalBytesRead As Long = 0
                Dim totalSize As Long = response.ContentLength
                Do
                    bytesRead = dataStream.Read(buffer, 0, buffer.Length)
                    If bytesRead = 0 Then
                        Exit Do
                    End If
                    fileStream.Write(buffer, 0, bytesRead)
                    totalBytesRead += bytesRead
                    Dim progressPercentage As Integer = CInt((totalBytesRead / totalSize) * 100)
                    UpdateProgressBar(progressPercentage)
                Loop While True
            End Using
            response.Close()
            dataStream.Close()
            Me.Invoke(Sub()
                          ProgressBar1.Value = 0
                          ProgressBar1.Text = "Download Completed..."
                          TextBoxYouTubeLink.Enabled = True
                          Button1.Enabled = False
                          Button2.Enabled = True
                      End Sub)
            MessageBox.Show("Download completed successfully.")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub UpdateProgressBar(progressPercentage As Integer)
        Me.Invoke(Sub()
                      ProgressBar1.Value = progressPercentage
                  End Sub)
    End Sub
    Private Sub DownloadCompleted(sender As Object, e As AsyncCompletedEventArgs)
        downloadClient.Dispose()
        Me.Invoke(Sub()
                      If e.Error IsNot Nothing Then
                          MessageBox.Show($"Download failed: {e.Error.Message}")
                      Else

                      End If
                  End Sub)
    End Sub
    Private WithEvents clipboardCheckTimer As New Timer()
    Private lastClipboardText As String = ""
    Private Sub clipboardCheckTimer_Tick(sender As Object, e As EventArgs) Handles clipboardCheckTimer.Tick
        Dim clipboardText As String = GetClipboardText()
        If clipboardText <> lastClipboardText AndAlso IsYouTubeLink(clipboardText) Then
            TextBoxYouTubeLink.Text = clipboardText
        End If
        lastClipboardText = clipboardText
    End Sub

    Private Function GetClipboardText() As String
        Dim clipboardText As String = ""
        If Clipboard.ContainsText() Then

            clipboardText = Clipboard.GetText()
        End If

        Return clipboardText
    End Function
    Private Function IsYouTubeLink(text As String) As Boolean
        Return text.ToLower().Contains("youtube.com") OrElse text.ToLower().Contains("youtu.be")
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clipboardCheckTimer.Interval = 500
        clipboardCheckTimer.Start()
        labelText = BonfireLabel8.Text
        BonfireLabel8.Text = ""
        typingTimer.Interval = 100
        If My.Settings.location = "" Then
            savepath.Text = Application.StartupPath
        Else
            savepath.Text = My.Settings.location
        End If

    End Sub

    Private Sub savepath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles savepath.LinkClicked
        Dim folder As New FolderBrowserDialog
        With folder
            .Description = "Select where to save."
            If folder.ShowDialog = DialogResult.OK Then
                savepath.Text = folder.SelectedPath.TrimEnd
                My.Settings.location = folder.SelectedPath.TrimEnd
                My.Settings.Save()

            End If
        End With
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        typingTimer.Start()
    End Sub
End Class
