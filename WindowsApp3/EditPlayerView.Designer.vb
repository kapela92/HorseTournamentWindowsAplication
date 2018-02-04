<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPlayerView
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Surname = New System.Windows.Forms.Label()
        Me.Label_Date = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Surname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(124, 263)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 23)
        Me.Button_Back.TabIndex = 0
        Me.Button_Back.Text = "Cofnij"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'Button_Ok
        '
        Me.Button_Ok.Location = New System.Drawing.Point(269, 263)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ok.TabIndex = 1
        Me.Button_Ok.Text = "Ok"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Imie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nazwisko"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Urodzenia "
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(181, 84)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(39, 13)
        Me.Label_Name.TabIndex = 5
        Me.Label_Name.Text = "Label4"
        '
        'Label_Surname
        '
        Me.Label_Surname.AutoSize = True
        Me.Label_Surname.Location = New System.Drawing.Point(181, 133)
        Me.Label_Surname.Name = "Label_Surname"
        Me.Label_Surname.Size = New System.Drawing.Size(39, 13)
        Me.Label_Surname.TabIndex = 6
        Me.Label_Surname.Text = "Label5"
        '
        'Label_Date
        '
        Me.Label_Date.AutoSize = True
        Me.Label_Date.Location = New System.Drawing.Point(181, 192)
        Me.Label_Date.Name = "Label_Date"
        Me.Label_Date.Size = New System.Drawing.Size(39, 13)
        Me.Label_Date.TabIndex = 7
        Me.Label_Date.Text = "Label6"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(293, 85)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(137, 20)
        Me.TextBox_Name.TabIndex = 8
        '
        'TextBox_Surname
        '
        Me.TextBox_Surname.Location = New System.Drawing.Point(293, 130)
        Me.TextBox_Surname.Name = "TextBox_Surname"
        Me.TextBox_Surname.Size = New System.Drawing.Size(137, 20)
        Me.TextBox_Surname.TabIndex = 9
        '
        'DateTimePicker_Date
        '
        Me.DateTimePicker_Date.Location = New System.Drawing.Point(293, 185)
        Me.DateTimePicker_Date.Name = "DateTimePicker_Date"
        Me.DateTimePicker_Date.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker_Date.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nowe dane "
        '
        'EditPlayerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 338)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker_Date)
        Me.Controls.Add(Me.TextBox_Surname)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label_Date)
        Me.Controls.Add(Me.Label_Surname)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Button_Back)
        Me.Name = "EditPlayerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditPlayer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Back As Button
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_Surname As Label
    Friend WithEvents Label_Date As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_Surname As TextBox
    Friend WithEvents DateTimePicker_Date As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
