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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPlayerView))
        Me.Button_Ok = New System.Windows.Forms.Button()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.Color.Green
        Me.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ok.ForeColor = System.Drawing.Color.White
        Me.Button_Ok.Location = New System.Drawing.Point(425, 133)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 25)
        Me.Button_Ok.TabIndex = 1
        Me.Button_Ok.Text = "OK"
        Me.Button_Ok.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Location = New System.Drawing.Point(56, 108)
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
        Me.Button_Approved.BackColor = System.Drawing.Color.Olive
        Me.Button_Approved.Enabled = False
        Me.Button_Approved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Approved.ForeColor = System.Drawing.Color.White
        Me.Button_Approved.Location = New System.Drawing.Point(459, 430)
        Me.Button_Approved.Name = "Button_Approved"
        Me.Button_Approved.Size = New System.Drawing.Size(75, 25)
        Me.Button_Approved.TabIndex = 4
        Me.Button_Approved.Text = "Dalej"
        Me.Button_Approved.UseVisualStyleBackColor = False
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(9, 430)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(24, 17)
        Me.Label_Name.TabIndex = 8
        Me.Label_Name.Text = "----"
        '
        'Label_Surname
        '
        Me.Label_Surname.AutoSize = True
        Me.Label_Surname.Location = New System.Drawing.Point(114, 430)
        Me.Label_Surname.Name = "Label_Surname"
        Me.Label_Surname.Size = New System.Drawing.Size(24, 17)
        Me.Label_Surname.TabIndex = 9
        Me.Label_Surname.Text = "----"
        '
        'ComboBox_Type1
        '
        Me.ComboBox_Type1.FormattingEnabled = True
        Me.ComboBox_Type1.Items.AddRange(New Object() {"Debiut", "MiniLL", "LL", "L", "L1"})
        Me.ComboBox_Type1.Location = New System.Drawing.Point(294, 427)
        Me.ComboBox_Type1.Name = "ComboBox_Type1"
        Me.ComboBox_Type1.Size = New System.Drawing.Size(75, 25)
        Me.ComboBox_Type1.TabIndex = 11
        Me.ComboBox_Type1.Text = "MiniLL"
        '
        'ComboBox_Type2
        '
        Me.ComboBox_Type2.FormattingEnabled = True
        Me.ComboBox_Type2.Items.AddRange(New Object() {"Debiut", "MiniLL", "LL", "L", "L1"})
        Me.ComboBox_Type2.Location = New System.Drawing.Point(375, 427)
        Me.ComboBox_Type2.Name = "ComboBox_Type2"
        Me.ComboBox_Type2.Size = New System.Drawing.Size(75, 25)
        Me.ComboBox_Type2.TabIndex = 12
        Me.ComboBox_Type2.Text = "MiniLL"
        '
        'Button_Add
        '
        Me.Button_Add.BackColor = System.Drawing.Color.Teal
        Me.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add.ForeColor = System.Drawing.Color.White
        Me.Button_Add.Location = New System.Drawing.Point(56, 380)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(128, 25)
        Me.Button_Add.TabIndex = 13
        Me.Button_Add.Text = "Nowa pozycja"
        Me.Button_Add.UseVisualStyleBackColor = False
        '
        'Label_Horse
        '
        Me.Label_Horse.AutoSize = True
        Me.Label_Horse.Location = New System.Drawing.Point(222, 430)
        Me.Label_Horse.Name = "Label_Horse"
        Me.Label_Horse.Size = New System.Drawing.Size(24, 17)
        Me.Label_Horse.TabIndex = 14
        Me.Label_Horse.Text = "----"
        '
        'Button_Back
        '
        Me.Button_Back.BackColor = System.Drawing.Color.Maroon
        Me.Button_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Back.ForeColor = System.Drawing.Color.White
        Me.Button_Back.Location = New System.Drawing.Point(425, 162)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 25)
        Me.Button_Back.TabIndex = 15
        Me.Button_Back.Text = "Cofnij"
        Me.Button_Back.UseVisualStyleBackColor = False
        '
        'Button_Edit
        '
        Me.Button_Edit.BackColor = System.Drawing.Color.Olive
        Me.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Edit.ForeColor = System.Drawing.Color.White
        Me.Button_Edit.Location = New System.Drawing.Point(214, 380)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 25)
        Me.Button_Edit.TabIndex = 16
        Me.Button_Edit.Text = "Edytuj"
        Me.Button_Edit.UseVisualStyleBackColor = False
        '
        'Button_Remove
        '
        Me.Button_Remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Remove.ForeColor = System.Drawing.Color.White
        Me.Button_Remove.Location = New System.Drawing.Point(320, 380)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(75, 25)
        Me.Button_Remove.TabIndex = 17
        Me.Button_Remove.Text = "Usuń"
        Me.Button_Remove.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonX)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 60)
        Me.Panel1.TabIndex = 27
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
        Me.Label1.Size = New System.Drawing.Size(110, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zawodnicy"
        '
        'AddPlayerView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(534, 462)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.Button_Ok)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPlayerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartingOptionsView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Ok As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonX As Button
    Friend WithEvents Label1 As Label
End Class
