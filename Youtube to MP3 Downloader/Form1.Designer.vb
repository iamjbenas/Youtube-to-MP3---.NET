<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.vidid = New System.Windows.Forms.Label()
        Me.BonfireTabControl1 = New Youtube_to_MP3_Downloader.BonfireTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.savepath = New System.Windows.Forms.LinkLabel()
        Me.BonfireLabel5 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BonfireLabel7 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.BonfireLabel6 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.uploaderr = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.BonfireLabel3 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dur = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.BonfireLabel4 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.titles = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.BonfireLabel2 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.BonfireLabel1 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.TextBoxYouTubeLink = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New Youtube_to_MP3_Downloader.BonfireProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BonfireLabel8 = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.hh = New Youtube_to_MP3_Downloader.BonfireLabel()
        Me.BonfireTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vidid
        '
        Me.vidid.AutoSize = True
        Me.vidid.Location = New System.Drawing.Point(425, 273)
        Me.vidid.Name = "vidid"
        Me.vidid.Size = New System.Drawing.Size(39, 13)
        Me.vidid.TabIndex = 14
        Me.vidid.Text = "Label1"
        '
        'BonfireTabControl1
        '
        Me.BonfireTabControl1.Controls.Add(Me.TabPage1)
        Me.BonfireTabControl1.Controls.Add(Me.TabPage2)
        Me.BonfireTabControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.BonfireTabControl1.Location = New System.Drawing.Point(-1, -3)
        Me.BonfireTabControl1.Name = "BonfireTabControl1"
        Me.BonfireTabControl1.SelectedIndex = 0
        Me.BonfireTabControl1.Size = New System.Drawing.Size(489, 251)
        Me.BonfireTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.savepath)
        Me.TabPage1.Controls.Add(Me.BonfireLabel5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BonfireLabel1)
        Me.TabPage1.Controls.Add(Me.TextBoxYouTubeLink)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(481, 213)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Downloader"
        '
        'savepath
        '
        Me.savepath.AutoEllipsis = True
        Me.savepath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Youtube_to_MP3_Downloader.My.MySettings.Default, "location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.savepath.Location = New System.Drawing.Point(145, 187)
        Me.savepath.Name = "savepath"
        Me.savepath.Size = New System.Drawing.Size(322, 14)
        Me.savepath.TabIndex = 16
        Me.savepath.TabStop = True
        Me.savepath.Text = Global.Youtube_to_MP3_Downloader.My.MySettings.Default.location
        '
        'BonfireLabel5
        '
        Me.BonfireLabel5.AutoSize = True
        Me.BonfireLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel5.Location = New System.Drawing.Point(93, 187)
        Me.BonfireLabel5.Name = "BonfireLabel5"
        Me.BonfireLabel5.Size = New System.Drawing.Size(49, 15)
        Me.BonfireLabel5.TabIndex = 15
        Me.BonfireLabel5.Text = "Save to:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(401, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 22)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Convert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.uploaderr)
        Me.GroupBox1.Controls.Add(Me.BonfireLabel3)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.dur)
        Me.GroupBox1.Controls.Add(Me.BonfireLabel4)
        Me.GroupBox1.Controls.Add(Me.titles)
        Me.GroupBox1.Controls.Add(Me.BonfireLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 96)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BonfireLabel7)
        Me.Panel1.Controls.Add(Me.BonfireLabel6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 71)
        Me.Panel1.TabIndex = 15
        Me.Panel1.Visible = False
        '
        'BonfireLabel7
        '
        Me.BonfireLabel7.AutoSize = True
        Me.BonfireLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel7.Location = New System.Drawing.Point(127, 41)
        Me.BonfireLabel7.Name = "BonfireLabel7"
        Me.BonfireLabel7.Size = New System.Drawing.Size(164, 15)
        Me.BonfireLabel7.TabIndex = 17
        Me.BonfireLabel7.Text = "Please be patient with me :( ..."
        '
        'BonfireLabel6
        '
        Me.BonfireLabel6.AutoSize = True
        Me.BonfireLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel6.Location = New System.Drawing.Point(125, 11)
        Me.BonfireLabel6.Name = "BonfireLabel6"
        Me.BonfireLabel6.Size = New System.Drawing.Size(120, 30)
        Me.BonfireLabel6.TabIndex = 8
        Me.BonfireLabel6.Text = "Converting"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(75, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'uploaderr
        '
        Me.uploaderr.AutoEllipsis = True
        Me.uploaderr.BackColor = System.Drawing.Color.Transparent
        Me.uploaderr.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploaderr.ForeColor = System.Drawing.Color.Black
        Me.uploaderr.Location = New System.Drawing.Point(153, 58)
        Me.uploaderr.Name = "uploaderr"
        Me.uploaderr.Size = New System.Drawing.Size(212, 15)
        Me.uploaderr.TabIndex = 14
        Me.uploaderr.Text = "IDLE"
        '
        'BonfireLabel3
        '
        Me.BonfireLabel3.AutoSize = True
        Me.BonfireLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel3.Location = New System.Drawing.Point(93, 57)
        Me.BonfireLabel3.Name = "BonfireLabel3"
        Me.BonfireLabel3.Size = New System.Drawing.Size(58, 15)
        Me.BonfireLabel3.TabIndex = 13
        Me.BonfireLabel3.Text = "Uploader:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(81, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'dur
        '
        Me.dur.BackColor = System.Drawing.Color.Transparent
        Me.dur.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dur.ForeColor = System.Drawing.Color.Black
        Me.dur.Location = New System.Drawing.Point(153, 39)
        Me.dur.Name = "dur"
        Me.dur.Size = New System.Drawing.Size(212, 15)
        Me.dur.TabIndex = 12
        Me.dur.Text = "IDLE"
        '
        'BonfireLabel4
        '
        Me.BonfireLabel4.AutoSize = True
        Me.BonfireLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel4.Location = New System.Drawing.Point(93, 39)
        Me.BonfireLabel4.Name = "BonfireLabel4"
        Me.BonfireLabel4.Size = New System.Drawing.Size(57, 15)
        Me.BonfireLabel4.TabIndex = 11
        Me.BonfireLabel4.Text = "Duration:"
        '
        'titles
        '
        Me.titles.AutoEllipsis = True
        Me.titles.BackColor = System.Drawing.Color.Transparent
        Me.titles.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titles.ForeColor = System.Drawing.Color.Black
        Me.titles.Location = New System.Drawing.Point(153, 21)
        Me.titles.Name = "titles"
        Me.titles.Size = New System.Drawing.Size(212, 15)
        Me.titles.TabIndex = 10
        Me.titles.Text = "IDLE"
        '
        'BonfireLabel2
        '
        Me.BonfireLabel2.AutoSize = True
        Me.BonfireLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel2.Location = New System.Drawing.Point(93, 21)
        Me.BonfireLabel2.Name = "BonfireLabel2"
        Me.BonfireLabel2.Size = New System.Drawing.Size(42, 15)
        Me.BonfireLabel2.TabIndex = 9
        Me.BonfireLabel2.Text = "Name:"
        '
        'BonfireLabel1
        '
        Me.BonfireLabel1.AutoSize = True
        Me.BonfireLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel1.Location = New System.Drawing.Point(93, 14)
        Me.BonfireLabel1.Name = "BonfireLabel1"
        Me.BonfireLabel1.Size = New System.Drawing.Size(78, 15)
        Me.BonfireLabel1.TabIndex = 3
        Me.BonfireLabel1.Text = "Youtube URL:"
        '
        'TextBoxYouTubeLink
        '
        Me.TextBoxYouTubeLink.Location = New System.Drawing.Point(96, 31)
        Me.TextBoxYouTubeLink.Name = "TextBoxYouTubeLink"
        Me.TextBoxYouTubeLink.Size = New System.Drawing.Size(302, 20)
        Me.TextBoxYouTubeLink.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(343, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(96, 155)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(245, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Value = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.BonfireLabel8)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(481, 213)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "About"
        '
        'BonfireLabel8
        '
        Me.BonfireLabel8.AutoSize = True
        Me.BonfireLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonfireLabel8.ForeColor = System.Drawing.Color.Black
        Me.BonfireLabel8.Location = New System.Drawing.Point(140, 114)
        Me.BonfireLabel8.Name = "BonfireLabel8"
        Me.BonfireLabel8.Size = New System.Drawing.Size(199, 40)
        Me.BonfireLabel8.TabIndex = 8
        Me.BonfireLabel8.Text = "Developed by Joshua Beñas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ZyberPH Developers"
        Me.BonfireLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(185, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(101, 84)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'hh
        '
        Me.hh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.hh.Location = New System.Drawing.Point(5, 286)
        Me.hh.Name = "hh"
        Me.hh.Size = New System.Drawing.Size(479, 19)
        Me.hh.TabIndex = 13
        Me.hh.Text = "IDLE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 250)
        Me.Controls.Add(Me.vidid)
        Me.Controls.Add(Me.BonfireTabControl1)
        Me.Controls.Add(Me.hh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube to MP3 Downloader"
        Me.BonfireTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BonfireTabControl1 As BonfireTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dur As BonfireLabel
    Friend WithEvents BonfireLabel4 As BonfireLabel
    Friend WithEvents titles As BonfireLabel
    Friend WithEvents BonfireLabel2 As BonfireLabel
    Friend WithEvents BonfireLabel1 As BonfireLabel
    Friend WithEvents TextBoxYouTubeLink As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As BonfireProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents hh As BonfireLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents uploaderr As BonfireLabel
    Friend WithEvents BonfireLabel3 As BonfireLabel
    Friend WithEvents BonfireLabel5 As BonfireLabel
    Friend WithEvents savepath As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BonfireLabel7 As BonfireLabel
    Friend WithEvents BonfireLabel6 As BonfireLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents vidid As Label
    Friend WithEvents BonfireLabel8 As BonfireLabel
    Friend WithEvents PictureBox4 As PictureBox
End Class
