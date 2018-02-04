<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPlayerView
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
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Approved = New System.Windows.Forms.Button()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Surname = New System.Windows.Forms.Label()
        Me.ComboBox_Type1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Type2 = New System.Windows.Forms.ComboBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Label_Horse = New System.Windows.Forms.Label()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Remove = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Ok.Location = New System.Drawing.Point(763, 61)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ok.TabIndex = 1
        Me.Button_Ok.Text = "OK"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(763, 555)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exit.TabIndex = 2
        Me.Button_Exit.Text = "Exit"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(58, 44)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(339, 250)
        Me.DataGridView1.TabIndex = 3
        '
        'Button_Approved
        '
        Me.Button_Approved.Enabled = False
        Me.Button_Approved.Location = New System.Drawing.Point(605, 455)
        Me.Button_Approved.Name = "Button_Approved"
        Me.Button_Approved.Size = New System.Drawing.Size(75, 23)
        Me.Button_Approved.TabIndex = 4
        Me.Button_Approved.Text = "Zatwierdź"
        Me.Button_Approved.UseVisualStyleBackColor = True
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(170, 460)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(19, 13)
        Me.Label_Name.TabIndex = 8
        Me.Label_Name.Text = "----"
        '
        'Label_Surname
        '
        Me.Label_Surname.AutoSize = True
        Me.Label_Surname.Location = New System.Drawing.Point(236, 460)
        Me.Label_Surname.Name = "Label_Surname"
        Me.Label_Surname.Size = New System.Drawing.Size(19, 13)
        Me.Label_Surname.TabIndex = 9
        Me.Label_Surname.Text = "----"
        '
        'ComboBox_Type1
        '
        Me.ComboBox_Type1.FormattingEnabled = True
        Me.ComboBox_Type1.Items.AddRange(New Object() {"Debiut", "MiniLL", "LL", "L", "L1"})
        Me.ComboBox_Type1.Location = New System.Drawing.Point(366, 455)
        Me.ComboBox_Type1.Name = "ComboBox_Type1"
        Me.ComboBox_Type1.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox_Type1.TabIndex = 11
        Me.ComboBox_Type1.Text = "MiniLL"
        '
        'ComboBox_Type2
        '
        Me.ComboBox_Type2.FormattingEnabled = True
        Me.ComboBox_Type2.Items.AddRange(New Object() {"Debiut", "MiniLL", "LL", "L", "L1"})
        Me.ComboBox_Type2.Location = New System.Drawing.Point(476, 455)
        Me.ComboBox_Type2.Name = "ComboBox_Type2"
        Me.ComboBox_Type2.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox_Type2.TabIndex = 12
        Me.ComboBox_Type2.Text = "MiniLL"
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(58, 318)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(128, 23)
        Me.Button_Add.TabIndex = 13
        Me.Button_Add.Text = "Dodaj Do Bazy"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Label_Horse
        '
        Me.Label_Horse.AutoSize = True
        Me.Label_Horse.Location = New System.Drawing.Point(300, 460)
        Me.Label_Horse.Name = "Label_Horse"
        Me.Label_Horse.Size = New System.Drawing.Size(19, 13)
        Me.Label_Horse.TabIndex = 14
        Me.Label_Horse.Text = "----"
        '
        'Button_Back
        '
        Me.Button_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_Back.Location = New System.Drawing.Point(763, 106)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 23)
        Me.Button_Back.TabIndex = 15
        Me.Button_Back.Text = "Cofnij"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(221, 318)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 16
        Me.Button_Edit.Text = "Edytuj"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Remove
        '
        Me.Button_Remove.Location = New System.Drawing.Point(322, 318)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(75, 23)
        Me.Button_Remove.TabIndex = 17
        Me.Button_Remove.Text = "Usuń"
        Me.Button_Remove.UseVisualStyleBackColor = True
        '
        'AddPlayerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Button_Remove)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Back)
        Me.Controls.Add(Me.Label_Horse)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.ComboBox_Type2)
        Me.Controls.Add(Me.ComboBox_Type1)
        Me.Controls.Add(Me.Label_Surname)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Button_Approved)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Button_Ok)
        Me.Name = "AddPlayerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartingOptionsView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Button_Approved As Button
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_Surname As Label
    Friend WithEvents ComboBox_Type1 As ComboBox
    Friend WithEvents ComboBox_Type2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Add As Button
    Friend WithEvents Label_Horse As Label
    Friend WithEvents Button_Back As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Remove As Button
End Class
