<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddHorseToDatabaseView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddHorseToDatabaseView))
        Me.TextBox_MomsName = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.TextBox_FathersName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Year = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_MomsName
        '
        Me.TextBox_MomsName.Location = New System.Drawing.Point(177, 138)
        Me.TextBox_MomsName.Name = "TextBox_MomsName"
        Me.TextBox_MomsName.Size = New System.Drawing.Size(200, 23)
        Me.TextBox_MomsName.TabIndex = 17
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(177, 95)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(200, 23)
        Me.TextBox_Name.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Imie Ojca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Imie Matki"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Imię"
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.Color.Olive
        Me.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ok.ForeColor = System.Drawing.Color.White
        Me.Button_Ok.Location = New System.Drawing.Point(266, 286)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 25)
        Me.Button_Ok.TabIndex = 11
        Me.Button_Ok.Text = "Dalej"
        Me.Button_Ok.UseVisualStyleBackColor = False
        '
        'Button_Back
        '
        Me.Button_Back.BackColor = System.Drawing.Color.Maroon
        Me.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Back.ForeColor = System.Drawing.Color.White
        Me.Button_Back.Location = New System.Drawing.Point(117, 286)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 25)
        Me.Button_Back.TabIndex = 10
        Me.Button_Back.Text = "Cofnji"
        Me.Button_Back.UseVisualStyleBackColor = False
        '
        'TextBox_FathersName
        '
        Me.TextBox_FathersName.Location = New System.Drawing.Point(177, 180)
        Me.TextBox_FathersName.Name = "TextBox_FathersName"
        Me.TextBox_FathersName.Size = New System.Drawing.Size(200, 23)
        Me.TextBox_FathersName.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Rok urodzenia"
        '
        'NumericUpDown_Year
        '
        Me.NumericUpDown_Year.Location = New System.Drawing.Point(177, 227)
        Me.NumericUpDown_Year.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown_Year.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.NumericUpDown_Year.Name = "NumericUpDown_Year"
        Me.NumericUpDown_Year.Size = New System.Drawing.Size(64, 23)
        Me.NumericUpDown_Year.TabIndex = 20
        Me.NumericUpDown_Year.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonX)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 60)
        Me.Panel1.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ButtonX
        '
        Me.ButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonX.Location = New System.Drawing.Point(487, 8)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(35, 35)
        Me.ButtonX.TabIndex = 0
        Me.ButtonX.Text = "X"
        Me.ButtonX.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(136, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dane Konia"
        '
        'AddHorseToDatabaseView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(470, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NumericUpDown_Year)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_FathersName)
        Me.Controls.Add(Me.TextBox_MomsName)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Button_Back)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddHorseToDatabaseView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddHorseToDatabase"
        CType(Me.NumericUpDown_Year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_MomsName As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents TextBox_FathersName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_Year As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonX As Button
    Friend WithEvents Label1 As Label
End Class
