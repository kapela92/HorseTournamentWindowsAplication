<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigurationView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigurationView))
        Me.ComboBox_Port = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Check = New System.Windows.Forms.Label()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_Port
        '
        Me.ComboBox_Port.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Port.FormattingEnabled = True
        Me.ComboBox_Port.Location = New System.Drawing.Point(376, 188)
        Me.ComboBox_Port.Name = "ComboBox_Port"
        Me.ComboBox_Port.Size = New System.Drawing.Size(121, 29)
        Me.ComboBox_Port.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Konfiguracja"
        '
        'Label_Check
        '
        Me.Label_Check.AutoSize = True
        Me.Label_Check.Location = New System.Drawing.Point(419, 249)
        Me.Label_Check.Name = "Label_Check"
        Me.Label_Check.Size = New System.Drawing.Size(36, 21)
        Me.Label_Check.TabIndex = 3
        Me.Label_Check.Text = "NO"
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.Color.Olive
        Me.Button_Ok.Enabled = False
        Me.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ok.Location = New System.Drawing.Point(465, 301)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(89, 40)
        Me.Button_Ok.TabIndex = 4
        Me.Button_Ok.Text = "Dalej"
        Me.Button_Ok.UseVisualStyleBackColor = False
        '
        'Button_Back
        '
        Me.Button_Back.BackColor = System.Drawing.Color.Maroon
        Me.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Back.Location = New System.Drawing.Point(317, 301)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(89, 40)
        Me.Button_Back.TabIndex = 5
        Me.Button_Back.Text = "Cofnij"
        Me.Button_Back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(361, 244)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 31)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.ButtonX)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 60)
        Me.Panel1.TabIndex = 7
        '
        'ButtonX
        '
        Me.ButtonX.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonX.Location = New System.Drawing.Point(837, 13)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(35, 35)
        Me.ButtonX.TabIndex = 8
        Me.ButtonX.Text = "X"
        Me.ButtonX.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(356, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Wybież port COM"
        '
        'ConfigurationView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Back)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Label_Check)
        Me.Controls.Add(Me.ComboBox_Port)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfigurationView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfigurationView"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_Port As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Check As Label
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonX As Button
End Class
