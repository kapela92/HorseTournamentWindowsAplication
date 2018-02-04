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
        Me.TextBox_MomsName = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.TextBox_FathersName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Year = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_MomsName
        '
        Me.TextBox_MomsName.Location = New System.Drawing.Point(175, 123)
        Me.TextBox_MomsName.Name = "TextBox_MomsName"
        Me.TextBox_MomsName.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_MomsName.TabIndex = 17
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(175, 80)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_Name.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Imie Ojca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Imie Matki"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Imię"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Podaj:"
        '
        'Button_Ok
        '
        Me.Button_Ok.Location = New System.Drawing.Point(266, 286)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ok.TabIndex = 11
        Me.Button_Ok.Text = "OK"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(117, 286)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 23)
        Me.Button_Back.TabIndex = 10
        Me.Button_Back.Text = "Cofnji"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'TextBox_FathersName
        '
        Me.TextBox_FathersName.Location = New System.Drawing.Point(175, 165)
        Me.TextBox_FathersName.Name = "TextBox_FathersName"
        Me.TextBox_FathersName.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_FathersName.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Rok urodzenia"
        '
        'NumericUpDown_Year
        '
        Me.NumericUpDown_Year.Location = New System.Drawing.Point(175, 212)
        Me.NumericUpDown_Year.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown_Year.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.NumericUpDown_Year.Name = "NumericUpDown_Year"
        Me.NumericUpDown_Year.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown_Year.TabIndex = 20
        Me.NumericUpDown_Year.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'AddHorseToDatabaseView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 338)
        Me.Controls.Add(Me.NumericUpDown_Year)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_FathersName)
        Me.Controls.Add(Me.TextBox_MomsName)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Button_Back)
        Me.Name = "AddHorseToDatabaseView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddHorseToDatabase"
        CType(Me.NumericUpDown_Year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_MomsName As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents TextBox_FathersName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_Year As NumericUpDown
End Class
