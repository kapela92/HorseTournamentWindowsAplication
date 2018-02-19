<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartView
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartView))
        Me.ButtonNewTournament = New System.Windows.Forms.Button()
        Me.ButtonTraining = New System.Windows.Forms.Button()
        Me.Button_Continuation = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button_Configuration = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonNewTournament
        '
        Me.ButtonNewTournament.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonNewTournament.Enabled = False
        Me.ButtonNewTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNewTournament.ForeColor = System.Drawing.Color.White
        Me.ButtonNewTournament.Location = New System.Drawing.Point(450, 190)
        Me.ButtonNewTournament.Name = "ButtonNewTournament"
        Me.ButtonNewTournament.Size = New System.Drawing.Size(133, 34)
        Me.ButtonNewTournament.TabIndex = 0
        Me.ButtonNewTournament.Text = "Nowe Zawody"
        Me.ButtonNewTournament.UseVisualStyleBackColor = False
        '
        'ButtonTraining
        '
        Me.ButtonTraining.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonTraining.Enabled = False
        Me.ButtonTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTraining.ForeColor = System.Drawing.Color.White
        Me.ButtonTraining.Location = New System.Drawing.Point(516, 259)
        Me.ButtonTraining.Name = "ButtonTraining"
        Me.ButtonTraining.Size = New System.Drawing.Size(133, 31)
        Me.ButtonTraining.TabIndex = 1
        Me.ButtonTraining.Text = "Trening"
        Me.ButtonTraining.UseVisualStyleBackColor = False
        '
        'Button_Continuation
        '
        Me.Button_Continuation.BackColor = System.Drawing.Color.Maroon
        Me.Button_Continuation.Enabled = False
        Me.Button_Continuation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Continuation.ForeColor = System.Drawing.Color.White
        Me.Button_Continuation.Location = New System.Drawing.Point(675, 260)
        Me.Button_Continuation.Name = "Button_Continuation"
        Me.Button_Continuation.Size = New System.Drawing.Size(164, 28)
        Me.Button_Continuation.TabIndex = 2
        Me.Button_Continuation.Text = "Kontynuuj Zawody"
        Me.Button_Continuation.UseVisualStyleBackColor = False
        Me.Button_Continuation.Visible = False
        '
        'Button_Configuration
        '
        Me.Button_Configuration.BackColor = System.Drawing.Color.Teal
        Me.Button_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Configuration.ForeColor = System.Drawing.Color.White
        Me.Button_Configuration.Location = New System.Drawing.Point(634, 191)
        Me.Button_Configuration.Name = "Button_Configuration"
        Me.Button_Configuration.Size = New System.Drawing.Size(133, 33)
        Me.Button_Configuration.TabIndex = 3
        Me.Button_Configuration.Text = "Konfiguracja "
        Me.Button_Configuration.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(499, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Więcej informacji"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Olive
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(675, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Wyniki Online"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 90)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(149, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HorseTournament"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(426, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(446, 72)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = """Jeździć konno może nauczyć się każdy " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ale jazda w harmonii z koniem jest sztuką" &
    """"
        '
        'ButtonX
        '
        Me.ButtonX.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonX.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonX.Location = New System.Drawing.Point(835, 12)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(37, 33)
        Me.ButtonX.TabIndex = 10
        Me.ButtonX.Text = "X"
        Me.ButtonX.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 158)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(416, 465)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.UseWaitCursor = True
        '
        'StartView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.ButtonX)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_Configuration)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_Continuation)
        Me.Controls.Add(Me.ButtonTraining)
        Me.Controls.Add(Me.ButtonNewTournament)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonNewTournament As Button
    Friend WithEvents ButtonTraining As Button
    Friend WithEvents Button_Continuation As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button_Configuration As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonX As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
