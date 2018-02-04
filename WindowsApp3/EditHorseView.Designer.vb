<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditHorseView
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Mother = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Year = New System.Windows.Forms.Label()
        Me.Label_Mother = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Father = New System.Windows.Forms.Label()
        Me.TextBox_Father = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nowe dane "
        '
        'TextBox_Mother
        '
        Me.TextBox_Mother.Location = New System.Drawing.Point(291, 116)
        Me.TextBox_Mother.Name = "TextBox_Mother"
        Me.TextBox_Mother.Size = New System.Drawing.Size(137, 20)
        Me.TextBox_Mother.TabIndex = 21
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(291, 84)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(137, 20)
        Me.TextBox_Name.TabIndex = 20
        '
        'Label_Year
        '
        Me.Label_Year.AutoSize = True
        Me.Label_Year.Location = New System.Drawing.Point(179, 188)
        Me.Label_Year.Name = "Label_Year"
        Me.Label_Year.Size = New System.Drawing.Size(39, 13)
        Me.Label_Year.TabIndex = 19
        Me.Label_Year.Text = "Label6"
        '
        'Label_Mother
        '
        Me.Label_Mother.AutoSize = True
        Me.Label_Mother.Location = New System.Drawing.Point(179, 119)
        Me.Label_Mother.Name = "Label_Mother"
        Me.Label_Mother.Size = New System.Drawing.Size(39, 13)
        Me.Label_Mother.TabIndex = 18
        Me.Label_Mother.Text = "Label5"
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(179, 87)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(39, 13)
        Me.Label_Name.TabIndex = 17
        Me.Label_Name.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Rok Urodzenia "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Imie Matki"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Imie"
        '
        'Button_Ok
        '
        Me.Button_Ok.Location = New System.Drawing.Point(267, 266)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ok.TabIndex = 13
        Me.Button_Ok.Text = "Ok"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(122, 266)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 23)
        Me.Button_Back.TabIndex = 12
        Me.Button_Back.Text = "Cofnij"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Imie Ojca"
        '
        'Label_Father
        '
        Me.Label_Father.AutoSize = True
        Me.Label_Father.Location = New System.Drawing.Point(179, 154)
        Me.Label_Father.Name = "Label_Father"
        Me.Label_Father.Size = New System.Drawing.Size(39, 13)
        Me.Label_Father.TabIndex = 25
        Me.Label_Father.Text = "Label5"
        '
        'TextBox_Father
        '
        Me.TextBox_Father.Location = New System.Drawing.Point(291, 151)
        Me.TextBox_Father.Name = "TextBox_Father"
        Me.TextBox_Father.Size = New System.Drawing.Size(137, 20)
        Me.TextBox_Father.TabIndex = 26
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(291, 186)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(137, 20)
        Me.NumericUpDown1.TabIndex = 27
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1950, 0, 0, 0})
        '
        'EditHorseView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 338)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox_Father)
        Me.Controls.Add(Me.Label_Father)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Mother)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label_Year)
        Me.Controls.Add(Me.Label_Mother)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Button_Back)
        Me.HelpButton = True
        Me.Name = "EditHorseView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditHorse"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Mother As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label_Year As Label
    Friend WithEvents Label_Mother As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_Father As Label
    Friend WithEvents TextBox_Father As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
