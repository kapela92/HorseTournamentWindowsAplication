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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Debiut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_L1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_MiniLL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(720, 517)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exit.TabIndex = 0
        Me.Button_Exit.Text = "Exit"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Location = New System.Drawing.Point(86, 77)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(616, 189)
        Me.DataGridView1.TabIndex = 1
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(29, 9)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(40, 13)
        Me.Label_Name.TabIndex = 2
        Me.Label_Name.Text = "Nazwa"
        '
        'Label_Limit
        '
        Me.Label_Limit.AutoSize = True
        Me.Label_Limit.Location = New System.Drawing.Point(164, 329)
        Me.Label_Limit.Name = "Label_Limit"
        Me.Label_Limit.Size = New System.Drawing.Size(65, 26)
        Me.Label_Limit.TabIndex = 3
        Me.Label_Limit.Text = "Limit Czasu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "w sekudach"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Debiuty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MiniLL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "L"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "L1"
        '
        'NumericUpDown_Debiut
        '
        Me.NumericUpDown_Debiut.Location = New System.Drawing.Point(176, 367)
        Me.NumericUpDown_Debiut.Name = "NumericUpDown_Debiut"
        Me.NumericUpDown_Debiut.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_Debiut.TabIndex = 9
        Me.NumericUpDown_Debiut.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_L1
        '
        Me.NumericUpDown_L1.Location = New System.Drawing.Point(176, 474)
        Me.NumericUpDown_L1.Name = "NumericUpDown_L1"
        Me.NumericUpDown_L1.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_L1.TabIndex = 10
        Me.NumericUpDown_L1.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_L
        '
        Me.NumericUpDown_L.Location = New System.Drawing.Point(176, 445)
        Me.NumericUpDown_L.Name = "NumericUpDown_L"
        Me.NumericUpDown_L.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_L.TabIndex = 11
        Me.NumericUpDown_L.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_LL
        '
        Me.NumericUpDown_LL.Location = New System.Drawing.Point(176, 419)
        Me.NumericUpDown_LL.Name = "NumericUpDown_LL"
        Me.NumericUpDown_LL.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_LL.TabIndex = 12
        Me.NumericUpDown_LL.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NumericUpDown_MiniLL
        '
        Me.NumericUpDown_MiniLL.Location = New System.Drawing.Point(176, 394)
        Me.NumericUpDown_MiniLL.Name = "NumericUpDown_MiniLL"
        Me.NumericUpDown_MiniLL.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_MiniLL.TabIndex = 13
        Me.NumericUpDown_MiniLL.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'CheckBox_Debiut
        '
        Me.CheckBox_Debiut.AutoSize = True
        Me.CheckBox_Debiut.Location = New System.Drawing.Point(254, 368)
        Me.CheckBox_Debiut.Name = "CheckBox_Debiut"
        Me.CheckBox_Debiut.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox_Debiut.TabIndex = 14
        Me.CheckBox_Debiut.Text = "Trafienie w czas"
        Me.CheckBox_Debiut.UseVisualStyleBackColor = True
        '
        'CheckBox_MiniLL
        '
        Me.CheckBox_MiniLL.AutoSize = True
        Me.CheckBox_MiniLL.Location = New System.Drawing.Point(254, 395)
        Me.CheckBox_MiniLL.Name = "CheckBox_MiniLL"
        Me.CheckBox_MiniLL.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox_MiniLL.TabIndex = 15
        Me.CheckBox_MiniLL.Text = "Trafienie w czas"
        Me.CheckBox_MiniLL.UseVisualStyleBackColor = True
        '
        'CheckBox_LL
        '
        Me.CheckBox_LL.AutoSize = True
        Me.CheckBox_LL.Location = New System.Drawing.Point(254, 420)
        Me.CheckBox_LL.Name = "CheckBox_LL"
        Me.CheckBox_LL.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox_LL.TabIndex = 16
        Me.CheckBox_LL.Text = "Trafienie w czas"
        Me.CheckBox_LL.UseVisualStyleBackColor = True
        '
        'CheckBox_L
        '
        Me.CheckBox_L.AutoSize = True
        Me.CheckBox_L.Location = New System.Drawing.Point(254, 446)
        Me.CheckBox_L.Name = "CheckBox_L"
        Me.CheckBox_L.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox_L.TabIndex = 17
        Me.CheckBox_L.Text = "Trafienie w czas"
        Me.CheckBox_L.UseVisualStyleBackColor = True
        '
        'CheckBox_L1
        '
        Me.CheckBox_L1.AutoSize = True
        Me.CheckBox_L1.Location = New System.Drawing.Point(254, 475)
        Me.CheckBox_L1.Name = "CheckBox_L1"
        Me.CheckBox_L1.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox_L1.TabIndex = 18
        Me.CheckBox_L1.Text = "Trafienie w czas"
        Me.CheckBox_L1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Lista Uczestników"
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(720, 77)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 20
        Me.Button_Add.Text = "Dodaj"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(720, 106)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Delete.TabIndex = 21
        Me.Button_Delete.Text = "Usuń"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Label_Stud
        '
        Me.Label_Stud.AutoSize = True
        Me.Label_Stud.Location = New System.Drawing.Point(30, 31)
        Me.Label_Stud.Name = "Label_Stud"
        Me.Label_Stud.Size = New System.Drawing.Size(39, 13)
        Me.Label_Stud.TabIndex = 23
        Me.Label_Stud.Text = "Stajnia"
        '
        'Button_Ok
        '
        Me.Button_Ok.Location = New System.Drawing.Point(626, 521)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ok.TabIndex = 24
        Me.Button_Ok.Text = "Ok"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(676, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Label7"
        '
        'StartingDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Label_Stud)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox_L1)
        Me.Controls.Add(Me.CheckBox_L)
        Me.Controls.Add(Me.CheckBox_LL)
        Me.Controls.Add(Me.CheckBox_MiniLL)
        Me.Controls.Add(Me.CheckBox_Debiut)
        Me.Controls.Add(Me.NumericUpDown_MiniLL)
        Me.Controls.Add(Me.NumericUpDown_LL)
        Me.Controls.Add(Me.NumericUpDown_L)
        Me.Controls.Add(Me.NumericUpDown_L1)
        Me.Controls.Add(Me.NumericUpDown_Debiut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Limit)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartingDataView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartingDataView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Debiut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_L1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_MiniLL, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
