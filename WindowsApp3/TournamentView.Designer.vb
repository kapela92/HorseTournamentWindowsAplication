<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TournamentView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TournamentView))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Surname = New System.Windows.Forms.Label()
        Me.Label_Type = New System.Windows.Forms.Label()
        Me.Label_Minute = New System.Windows.Forms.Label()
        Me.Label_Hundredth = New System.Windows.Forms.Label()
        Me.Label_Second = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_SecondLimit = New System.Windows.Forms.Label()
        Me.Label_HundredthLimit = New System.Windows.Forms.Label()
        Me.Label_MinuteLimit = New System.Windows.Forms.Label()
        Me.Button_Discard = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.Button_Disobedience1 = New System.Windows.Forms.Button()
        Me.Button_DisobedienceDis1 = New System.Windows.Forms.Button()
        Me.Button_Disobedience2 = New System.Windows.Forms.Button()
        Me.Button_DisobedienceDis2 = New System.Windows.Forms.Button()
        Me.Button_Disobedience3 = New System.Windows.Forms.Button()
        Me.Button_Fall = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Button_RoundStart = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label_Points = New System.Windows.Forms.Label()
        Me.Label_Horse = New System.Windows.Forms.Label()
        Me.Label_HitTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_TimeLimit = New System.Windows.Forms.Label()
        Me.ListBox_Fault = New System.Windows.Forms.ListBox()
        Me.Button_FaultBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(776, 558)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(41, 97)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(45, 25)
        Me.Label_Name.TabIndex = 1
        Me.Label_Name.Text = "Imię"
        '
        'Label_Surname
        '
        Me.Label_Surname.AutoSize = True
        Me.Label_Surname.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Surname.Location = New System.Drawing.Point(115, 97)
        Me.Label_Surname.Name = "Label_Surname"
        Me.Label_Surname.Size = New System.Drawing.Size(93, 25)
        Me.Label_Surname.TabIndex = 2
        Me.Label_Surname.Text = " Nazwisko"
        '
        'Label_Type
        '
        Me.Label_Type.AutoSize = True
        Me.Label_Type.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Type.ForeColor = System.Drawing.Color.White
        Me.Label_Type.Location = New System.Drawing.Point(143, 12)
        Me.Label_Type.Name = "Label_Type"
        Me.Label_Type.Size = New System.Drawing.Size(65, 33)
        Me.Label_Type.TabIndex = 3
        Me.Label_Type.Text = "Type"
        '
        'Label_Minute
        '
        Me.Label_Minute.AutoSize = True
        Me.Label_Minute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Minute.Location = New System.Drawing.Point(100, 128)
        Me.Label_Minute.Name = "Label_Minute"
        Me.Label_Minute.Size = New System.Drawing.Size(30, 24)
        Me.Label_Minute.TabIndex = 4
        Me.Label_Minute.Text = "00"
        '
        'Label_Hundredth
        '
        Me.Label_Hundredth.AutoSize = True
        Me.Label_Hundredth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Hundredth.Location = New System.Drawing.Point(214, 128)
        Me.Label_Hundredth.Name = "Label_Hundredth"
        Me.Label_Hundredth.Size = New System.Drawing.Size(30, 24)
        Me.Label_Hundredth.TabIndex = 5
        Me.Label_Hundredth.Text = "00"
        '
        'Label_Second
        '
        Me.Label_Second.AutoSize = True
        Me.Label_Second.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Second.Location = New System.Drawing.Point(157, 128)
        Me.Label_Second.Name = "Label_Second"
        Me.Label_Second.Size = New System.Drawing.Size(30, 24)
        Me.Label_Second.TabIndex = 6
        Me.Label_Second.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Przekroczenie limitu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(404, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(347, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = ":"
        '
        'Label_SecondLimit
        '
        Me.Label_SecondLimit.AutoSize = True
        Me.Label_SecondLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_SecondLimit.Location = New System.Drawing.Point(368, 128)
        Me.Label_SecondLimit.Name = "Label_SecondLimit"
        Me.Label_SecondLimit.Size = New System.Drawing.Size(30, 24)
        Me.Label_SecondLimit.TabIndex = 12
        Me.Label_SecondLimit.Text = "00"
        '
        'Label_HundredthLimit
        '
        Me.Label_HundredthLimit.AutoSize = True
        Me.Label_HundredthLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_HundredthLimit.Location = New System.Drawing.Point(425, 128)
        Me.Label_HundredthLimit.Name = "Label_HundredthLimit"
        Me.Label_HundredthLimit.Size = New System.Drawing.Size(30, 24)
        Me.Label_HundredthLimit.TabIndex = 11
        Me.Label_HundredthLimit.Text = "00"
        '
        'Label_MinuteLimit
        '
        Me.Label_MinuteLimit.AutoSize = True
        Me.Label_MinuteLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_MinuteLimit.Location = New System.Drawing.Point(311, 128)
        Me.Label_MinuteLimit.Name = "Label_MinuteLimit"
        Me.Label_MinuteLimit.Size = New System.Drawing.Size(30, 24)
        Me.Label_MinuteLimit.TabIndex = 10
        Me.Label_MinuteLimit.Text = "00"
        '
        'Button_Discard
        '
        Me.Button_Discard.BackColor = System.Drawing.Color.SlateGray
        Me.Button_Discard.Enabled = False
        Me.Button_Discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Discard.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Discard.ForeColor = System.Drawing.Color.White
        Me.Button_Discard.Location = New System.Drawing.Point(36, 181)
        Me.Button_Discard.Name = "Button_Discard"
        Me.Button_Discard.Size = New System.Drawing.Size(140, 120)
        Me.Button_Discard.TabIndex = 15
        Me.Button_Discard.Text = "Zrzutka"
        Me.Button_Discard.UseVisualStyleBackColor = False
        '
        'Button_Stop
        '
        Me.Button_Stop.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_Stop.Enabled = False
        Me.Button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Stop.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Stop.ForeColor = System.Drawing.Color.White
        Me.Button_Stop.Location = New System.Drawing.Point(36, 307)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(140, 120)
        Me.Button_Stop.TabIndex = 16
        Me.Button_Stop.Text = "Zatrzymanie," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Przejącie do stępa," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Przejście z galopu do kłusa na wiecej niż 3 kr" &
    "oki"
        Me.Button_Stop.UseVisualStyleBackColor = False
        '
        'Button_Disobedience1
        '
        Me.Button_Disobedience1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button_Disobedience1.Enabled = False
        Me.Button_Disobedience1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Disobedience1.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Disobedience1.ForeColor = System.Drawing.Color.White
        Me.Button_Disobedience1.Location = New System.Drawing.Point(182, 181)
        Me.Button_Disobedience1.Name = "Button_Disobedience1"
        Me.Button_Disobedience1.Size = New System.Drawing.Size(140, 120)
        Me.Button_Disobedience1.TabIndex = 17
        Me.Button_Disobedience1.Text = "Pierwsze nieposłuszeństwo"
        Me.Button_Disobedience1.UseVisualStyleBackColor = False
        '
        'Button_DisobedienceDis1
        '
        Me.Button_DisobedienceDis1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button_DisobedienceDis1.Enabled = False
        Me.Button_DisobedienceDis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DisobedienceDis1.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_DisobedienceDis1.ForeColor = System.Drawing.Color.White
        Me.Button_DisobedienceDis1.Location = New System.Drawing.Point(182, 307)
        Me.Button_DisobedienceDis1.Name = "Button_DisobedienceDis1"
        Me.Button_DisobedienceDis1.Size = New System.Drawing.Size(140, 120)
        Me.Button_DisobedienceDis1.TabIndex = 18
        Me.Button_DisobedienceDis1.Text = "Pierwsze nieposłuszeństwo z rozbudową przeskody"
        Me.Button_DisobedienceDis1.UseVisualStyleBackColor = False
        '
        'Button_Disobedience2
        '
        Me.Button_Disobedience2.BackColor = System.Drawing.Color.MediumBlue
        Me.Button_Disobedience2.Enabled = False
        Me.Button_Disobedience2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Disobedience2.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Disobedience2.ForeColor = System.Drawing.Color.White
        Me.Button_Disobedience2.Location = New System.Drawing.Point(328, 181)
        Me.Button_Disobedience2.Name = "Button_Disobedience2"
        Me.Button_Disobedience2.Size = New System.Drawing.Size(140, 120)
        Me.Button_Disobedience2.TabIndex = 19
        Me.Button_Disobedience2.Text = "Drugie nieposłuszeństwo"
        Me.Button_Disobedience2.UseVisualStyleBackColor = False
        '
        'Button_DisobedienceDis2
        '
        Me.Button_DisobedienceDis2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button_DisobedienceDis2.Enabled = False
        Me.Button_DisobedienceDis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DisobedienceDis2.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_DisobedienceDis2.ForeColor = System.Drawing.Color.White
        Me.Button_DisobedienceDis2.Location = New System.Drawing.Point(328, 307)
        Me.Button_DisobedienceDis2.Name = "Button_DisobedienceDis2"
        Me.Button_DisobedienceDis2.Size = New System.Drawing.Size(140, 120)
        Me.Button_DisobedienceDis2.TabIndex = 20
        Me.Button_DisobedienceDis2.Text = "Drugie nieposłuszeństwo z rozbudową przeskody"
        Me.Button_DisobedienceDis2.UseVisualStyleBackColor = False
        '
        'Button_Disobedience3
        '
        Me.Button_Disobedience3.BackColor = System.Drawing.Color.CadetBlue
        Me.Button_Disobedience3.Enabled = False
        Me.Button_Disobedience3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Disobedience3.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Disobedience3.ForeColor = System.Drawing.Color.White
        Me.Button_Disobedience3.Location = New System.Drawing.Point(474, 181)
        Me.Button_Disobedience3.Name = "Button_Disobedience3"
        Me.Button_Disobedience3.Size = New System.Drawing.Size(140, 120)
        Me.Button_Disobedience3.TabIndex = 21
        Me.Button_Disobedience3.Text = "Trzecie nieposłuszeństwo"
        Me.Button_Disobedience3.UseVisualStyleBackColor = False
        '
        'Button_Fall
        '
        Me.Button_Fall.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Fall.Enabled = False
        Me.Button_Fall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Fall.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Fall.ForeColor = System.Drawing.Color.White
        Me.Button_Fall.Location = New System.Drawing.Point(474, 307)
        Me.Button_Fall.Name = "Button_Fall"
        Me.Button_Fall.Size = New System.Drawing.Size(140, 120)
        Me.Button_Fall.TabIndex = 22
        Me.Button_Fall.Text = "Upadek"
        Me.Button_Fall.UseVisualStyleBackColor = False
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 7
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.Color.Green
        Me.Button_Start.Enabled = False
        Me.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Start.ForeColor = System.Drawing.Color.White
        Me.Button_Start.Location = New System.Drawing.Point(269, 485)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(129, 41)
        Me.Button_Start.TabIndex = 23
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Button_Next
        '
        Me.Button_Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Next.Enabled = False
        Me.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Next.ForeColor = System.Drawing.Color.White
        Me.Button_Next.Location = New System.Drawing.Point(474, 485)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(129, 41)
        Me.Button_Next.TabIndex = 24
        Me.Button_Next.Text = "Następny"
        Me.Button_Next.UseVisualStyleBackColor = False
        '
        'Button_RoundStart
        '
        Me.Button_RoundStart.BackColor = System.Drawing.Color.Teal
        Me.Button_RoundStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_RoundStart.ForeColor = System.Drawing.Color.White
        Me.Button_RoundStart.Location = New System.Drawing.Point(79, 485)
        Me.Button_RoundStart.Name = "Button_RoundStart"
        Me.Button_RoundStart.Size = New System.Drawing.Size(129, 41)
        Me.Button_RoundStart.TabIndex = 25
        Me.Button_RoundStart.Text = "Start Rundy"
        Me.Button_RoundStart.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(512, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 21)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Punkty"
        '
        'Label_Points
        '
        Me.Label_Points.AutoSize = True
        Me.Label_Points.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Points.Location = New System.Drawing.Point(524, 131)
        Me.Label_Points.Name = "Label_Points"
        Me.Label_Points.Size = New System.Drawing.Size(19, 21)
        Me.Label_Points.TabIndex = 27
        Me.Label_Points.Text = "0"
        '
        'Label_Horse
        '
        Me.Label_Horse.AutoSize = True
        Me.Label_Horse.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Horse.Location = New System.Drawing.Point(228, 97)
        Me.Label_Horse.Name = "Label_Horse"
        Me.Label_Horse.Size = New System.Drawing.Size(44, 25)
        Me.Label_Horse.TabIndex = 28
        Me.Label_Horse.Text = "Koń"
        '
        'Label_HitTime
        '
        Me.Label_HitTime.AutoSize = True
        Me.Label_HitTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_HitTime.Location = New System.Drawing.Point(100, 27)
        Me.Label_HitTime.Name = "Label_HitTime"
        Me.Label_HitTime.Size = New System.Drawing.Size(0, 24)
        Me.Label_HitTime.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(542, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 33)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Limit czasu:"
        '
        'Label_TimeLimit
        '
        Me.Label_TimeLimit.AutoSize = True
        Me.Label_TimeLimit.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_TimeLimit.ForeColor = System.Drawing.Color.White
        Me.Label_TimeLimit.Location = New System.Drawing.Point(685, 12)
        Me.Label_TimeLimit.Name = "Label_TimeLimit"
        Me.Label_TimeLimit.Size = New System.Drawing.Size(28, 33)
        Me.Label_TimeLimit.TabIndex = 31
        Me.Label_TimeLimit.Text = "0"
        '
        'ListBox_Fault
        '
        Me.ListBox_Fault.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListBox_Fault.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Fault.FormattingEnabled = True
        Me.ListBox_Fault.ItemHeight = 21
        Me.ListBox_Fault.Items.AddRange(New Object() {"Błędy:"})
        Me.ListBox_Fault.Location = New System.Drawing.Point(629, 150)
        Me.ListBox_Fault.Name = "ListBox_Fault"
        Me.ListBox_Fault.Size = New System.Drawing.Size(222, 273)
        Me.ListBox_Fault.TabIndex = 32
        '
        'Button_FaultBack
        '
        Me.Button_FaultBack.BackColor = System.Drawing.Color.Maroon
        Me.Button_FaultBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_FaultBack.ForeColor = System.Drawing.Color.White
        Me.Button_FaultBack.Location = New System.Drawing.Point(757, 114)
        Me.Button_FaultBack.Name = "Button_FaultBack"
        Me.Button_FaultBack.Size = New System.Drawing.Size(94, 30)
        Me.Button_FaultBack.TabIndex = 33
        Me.Button_FaultBack.Text = "Cofnij Błąd"
        Me.Button_FaultBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.ButtonX)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label_Type)
        Me.Panel1.Controls.Add(Me.Label_TimeLimit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 60)
        Me.Panel1.TabIndex = 34
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
        'TournamentView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_FaultBack)
        Me.Controls.Add(Me.ListBox_Fault)
        Me.Controls.Add(Me.Label_HitTime)
        Me.Controls.Add(Me.Label_Horse)
        Me.Controls.Add(Me.Label_Points)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button_RoundStart)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.Button_Fall)
        Me.Controls.Add(Me.Button_Disobedience3)
        Me.Controls.Add(Me.Button_DisobedienceDis2)
        Me.Controls.Add(Me.Button_Disobedience2)
        Me.Controls.Add(Me.Button_DisobedienceDis1)
        Me.Controls.Add(Me.Button_Disobedience1)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.Button_Discard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_SecondLimit)
        Me.Controls.Add(Me.Label_HundredthLimit)
        Me.Controls.Add(Me.Label_MinuteLimit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_Second)
        Me.Controls.Add(Me.Label_Hundredth)
        Me.Controls.Add(Me.Label_Minute)
        Me.Controls.Add(Me.Label_Surname)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TournamentView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_Surname As Label
    Friend WithEvents Label_Type As Label
    Friend WithEvents Label_Minute As Label
    Friend WithEvents Label_Hundredth As Label
    Friend WithEvents Label_Second As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_SecondLimit As Label
    Friend WithEvents Label_HundredthLimit As Label
    Friend WithEvents Label_MinuteLimit As Label
    Friend WithEvents Button_Discard As Button
    Friend WithEvents Button_Stop As Button
    Friend WithEvents Button_Disobedience1 As Button
    Friend WithEvents Button_DisobedienceDis1 As Button
    Friend WithEvents Button_Disobedience2 As Button
    Friend WithEvents Button_DisobedienceDis2 As Button
    Friend WithEvents Button_Disobedience3 As Button
    Friend WithEvents Button_Fall As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_RoundStart As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label_Points As Label
    Friend WithEvents Label_Horse As Label
    Friend WithEvents Label_HitTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_TimeLimit As Label
    Friend WithEvents ListBox_Fault As ListBox
    Friend WithEvents Button_FaultBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonX As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
