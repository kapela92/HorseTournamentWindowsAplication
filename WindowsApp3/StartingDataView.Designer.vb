<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartingDataView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartingDataView))
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Limit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Debiut = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_L1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_L = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_LL = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_MiniLL = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_Debiut = New System.Windows.Forms.CheckBox()
        Me.CheckBox_MiniLL = New System.Windows.Forms.CheckBox()
        Me.CheckBox_LL = New System.Windows.Forms.CheckBox()
        Me.CheckBox_L = New System.Windows.Forms.CheckBox()
        Me.CheckBox_L1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Label_Stud = New System.Windows.Forms.Label()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Debiut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_L1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_MiniLL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Exit
        '
        Me.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Exit.Location = New System.Drawing.Point(837, 13)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(35, 35)
        Me.Button_Exit.TabIndex = 0
        Me.Button_Exit.Text = "X"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 120)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(445, 458)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.VirtualMode = True
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Name.ForeColor = System.Drawing.Color.White
        Me.Label_Name.Location = New System.Drawing.Point(136, 15)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(77, 28)
        Me.Label_Name.TabIndex = 2
        Me.Label_Name.Text = "Nazwa"
        '
        'Label_Limit
        '
        Me.Label_Limit.AutoSize = True
        Me.Label_Limit.BackColor = System.Drawing.Color.Transparent
        Me.Label_Limit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Limit.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Limit.Location = New System.Drawing.Point(100, 7)
        Me.Label_Limit.Name = "Label_Limit"
        Me.Label_Limit.Size = New System.Drawing.Size(110, 50)
        Me.Label_Limit.TabIndex = 3
        Me.Label_Limit.Text = "Limit Czasu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "w sekudach"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Debiuty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MiniLL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "L"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "L1"
        '
        'NumericUpDown_Debiut
        '
        Me.NumericUpDown_Debiut.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDown_Debiut.Location = New System.Drawing.Point(83, 22)
        Me.NumericUpDown_Debiut.Name = "NumericUpDown_Debiut"
        Me.NumericUpDown_Debiut.Size = New System.Drawing.Size(46, 31)
        Me.NumericUpDown_Debiut.TabIndex = 9
        Me.NumericUpDown_Debiut.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_L1
        '
        Me.NumericUpDown_L1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDown_L1.Location = New System.Drawing.Point(82, 217)
        Me.NumericUpDown_L1.Name = "NumericUpDown_L1"
        Me.NumericUpDown_L1.Size = New System.Drawing.Size(47, 31)
        Me.NumericUpDown_L1.TabIndex = 10
        Me.NumericUpDown_L1.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_L
        '
        Me.NumericUpDown_L.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDown_L.Location = New System.Drawing.Point(83, 168)
        Me.NumericUpDown_L.Name = "NumericUpDown_L"
        Me.NumericUpDown_L.Size = New System.Drawing.Size(46, 31)
        Me.NumericUpDown_L.TabIndex = 11
        Me.NumericUpDown_L.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_LL
        '
        Me.NumericUpDown_LL.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDown_LL.Location = New System.Drawing.Point(83, 119)
        Me.NumericUpDown_LL.Name = "NumericUpDown_LL"
        Me.NumericUpDown_LL.Size = New System.Drawing.Size(46, 31)
        Me.NumericUpDown_LL.TabIndex = 12
        Me.NumericUpDown_LL.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_MiniLL
        '
        Me.NumericUpDown_MiniLL.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDown_MiniLL.Location = New System.Drawing.Point(83, 70)
        Me.NumericUpDown_MiniLL.Name = "NumericUpDown_MiniLL"
        Me.NumericUpDown_MiniLL.Size = New System.Drawing.Size(46, 31)
        Me.NumericUpDown_MiniLL.TabIndex = 13
        Me.NumericUpDown_MiniLL.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'CheckBox_Debiut
        '
        Me.CheckBox_Debiut.AutoSize = True
        Me.CheckBox_Debiut.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBox_Debiut.Location = New System.Drawing.Point(161, 23)
        Me.CheckBox_Debiut.Name = "CheckBox_Debiut"
        Me.CheckBox_Debiut.Size = New System.Drawing.Size(154, 29)
        Me.CheckBox_Debiut.TabIndex = 14
        Me.CheckBox_Debiut.Text = "Trafienie w czas"
        Me.CheckBox_Debiut.UseVisualStyleBackColor = True
        '
        'CheckBox_MiniLL
        '
        Me.CheckBox_MiniLL.AutoSize = True
        Me.CheckBox_MiniLL.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBox_MiniLL.Location = New System.Drawing.Point(161, 71)
        Me.CheckBox_MiniLL.Name = "CheckBox_MiniLL"
        Me.CheckBox_MiniLL.Size = New System.Drawing.Size(154, 29)
        Me.CheckBox_MiniLL.TabIndex = 15
        Me.CheckBox_MiniLL.Text = "Trafienie w czas"
        Me.CheckBox_MiniLL.UseVisualStyleBackColor = True
        '
        'CheckBox_LL
        '
        Me.CheckBox_LL.AutoSize = True
        Me.CheckBox_LL.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBox_LL.Location = New System.Drawing.Point(161, 120)
        Me.CheckBox_LL.Name = "CheckBox_LL"
        Me.CheckBox_LL.Size = New System.Drawing.Size(154, 29)
        Me.CheckBox_LL.TabIndex = 16
        Me.CheckBox_LL.Text = "Trafienie w czas"
        Me.CheckBox_LL.UseVisualStyleBackColor = True
        '
        'CheckBox_L
        '
        Me.CheckBox_L.AutoSize = True
        Me.CheckBox_L.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBox_L.Location = New System.Drawing.Point(161, 169)
        Me.CheckBox_L.Name = "CheckBox_L"
        Me.CheckBox_L.Size = New System.Drawing.Size(154, 29)
        Me.CheckBox_L.TabIndex = 17
        Me.CheckBox_L.Text = "Trafienie w czas"
        Me.CheckBox_L.UseVisualStyleBackColor = True
        '
        'CheckBox_L1
        '
        Me.CheckBox_L1.AutoSize = True
        Me.CheckBox_L1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBox_L1.Location = New System.Drawing.Point(160, 218)
        Me.CheckBox_L1.Name = "CheckBox_L1"
        Me.CheckBox_L1.Size = New System.Drawing.Size(154, 29)
        Me.CheckBox_L1.TabIndex = 18
        Me.CheckBox_L1.Text = "Trafienie w czas"
        Me.CheckBox_L1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Lista Uczestników"
        '
        'Button_Add
        '
        Me.Button_Add.BackColor = System.Drawing.Color.Green
        Me.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Add.ForeColor = System.Drawing.Color.White
        Me.Button_Add.Location = New System.Drawing.Point(463, 138)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(85, 35)
        Me.Button_Add.TabIndex = 20
        Me.Button_Add.Text = "Dodaj"
        Me.Button_Add.UseVisualStyleBackColor = False
        '
        'Button_Delete
        '
        Me.Button_Delete.BackColor = System.Drawing.Color.Maroon
        Me.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Delete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Delete.ForeColor = System.Drawing.Color.White
        Me.Button_Delete.Location = New System.Drawing.Point(463, 186)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(85, 35)
        Me.Button_Delete.TabIndex = 21
        Me.Button_Delete.Text = "Usuń"
        Me.Button_Delete.UseVisualStyleBackColor = False
        '
        'Label_Stud
        '
        Me.Label_Stud.AutoSize = True
        Me.Label_Stud.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Stud.ForeColor = System.Drawing.Color.White
        Me.Label_Stud.Location = New System.Drawing.Point(341, 15)
        Me.Label_Stud.Name = "Label_Stud"
        Me.Label_Stud.Size = New System.Drawing.Size(73, 28)
        Me.Label_Stud.TabIndex = 23
        Me.Label_Stud.Text = "Stajnia"
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.Color.Olive
        Me.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ok.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Ok.Location = New System.Drawing.Point(659, 511)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(104, 42)
        Me.Button_Ok.TabIndex = 24
        Me.Button_Ok.Text = "Dalej"
        Me.Button_Ok.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(793, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Label7"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button_Exit)
        Me.Panel1.Controls.Add(Me.Label_Name)
        Me.Panel1.Controls.Add(Me.Label_Stud)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 60)
        Me.Panel1.TabIndex = 26
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.Label_Limit)
        Me.Panel2.Location = New System.Drawing.Point(554, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 62)
        Me.Panel2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Khaki
        Me.Panel3.Controls.Add(Me.CheckBox_Debiut)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.NumericUpDown_Debiut)
        Me.Panel3.Controls.Add(Me.NumericUpDown_L1)
        Me.Panel3.Controls.Add(Me.CheckBox_L1)
        Me.Panel3.Controls.Add(Me.NumericUpDown_L)
        Me.Panel3.Controls.Add(Me.CheckBox_L)
        Me.Panel3.Controls.Add(Me.NumericUpDown_LL)
        Me.Panel3.Controls.Add(Me.CheckBox_LL)
        Me.Panel3.Controls.Add(Me.NumericUpDown_MiniLL)
        Me.Panel3.Controls.Add(Me.CheckBox_MiniLL)
        Me.Panel3.Location = New System.Drawing.Point(554, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 272)
        Me.Panel3.TabIndex = 28
        '
        'StartingDataView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartingDataView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartingDataView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Debiut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_L1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_MiniLL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Exit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_Limit As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_Debiut As NumericUpDown
    Friend WithEvents NumericUpDown_L1 As NumericUpDown
    Friend WithEvents NumericUpDown_L As NumericUpDown
    Friend WithEvents NumericUpDown_LL As NumericUpDown
    Friend WithEvents NumericUpDown_MiniLL As NumericUpDown
    Friend WithEvents CheckBox_Debiut As CheckBox
    Friend WithEvents CheckBox_MiniLL As CheckBox
    Friend WithEvents CheckBox_LL As CheckBox
    Friend WithEvents CheckBox_L As CheckBox
    Friend WithEvents CheckBox_L1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Label_Stud As Label
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
