Imports MySql.Data.MySqlClient

Public Class TournamentView
    Dim Deb, miniLL, LL, L, L1 As Int16
    Public Type() As String = New String(4) {"Debiut", "MiniLL", "LL", "L", "L1"}
    ' Dim Times()() As Integer = {New Integer() {StartingDataView.NumericUpDown_Debiut.Value, StartingDataView.CheckBox_Debiut.Checked}, New Integer() {StartingDataView.NumericUpDown_MiniLL.Value, StartingDataView.CheckBox_MiniLL.Checked}, New Integer() {StartingDataView.NumericUpDown_LL.Value, StartingDataView.CheckBox_LL.Checked}, New Integer() {StartingDataView.NumericUpDown_L.Value, StartingDataView.CheckBox_L.Checked}, New Integer() {StartingDataView.NumericUpDown_L1.Value, StartingDataView.CheckBox_L1.Checked}}
    Public Type_counter As Integer = 0
    Dim command As MySqlCommand
    Dim connection As New MySqlConnection
    Dim SDA As New MySqlDataAdapter
    Dim READ As MySqlDataReader
    Dim dbDataSet As New DataTable
    Dim points As Integer = 0
    Public Row As Integer = 0
    Dim Second_Counter As Integer = 0
    Dim Hundredth_Counter As Integer = 0
    Dim minute, second, hundredth, counter, millisecond, millisecond_actualy As Int64
    Dim minute1, second1, hundredth1 As Int64
    Dim data As UInt16
    Dim Points_Description As String

    Private Sub Button_Discard_Click(sender As Object, e As EventArgs) Handles Button_Discard.Click
        If StartingDataView.Times(Type_counter)(1) = -1 Then
            points = points + 0.5
        Else
            points = points + 1
        End If
        Label_Points.Text = points
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_Discard.Text)
        Points_Description = Points_Description & "1"
        Button_FaultBack.Enabled = True
    End Sub

    Private Sub Button_Disobedience1_Click(sender As Object, e As EventArgs) Handles Button_Disobedience1.Click
        If StartingDataView.Times(Type_counter)(1) = -1 Then
            points = points + 1
        Else
            points = points + 2
        End If
        Label_Points.Text = points
        Button_Disobedience1.Enabled = False
        Button_Disobedience2.Enabled = True
        Button_DisobedienceDis2.Enabled = True
        Button_DisobedienceDis1.Enabled = False
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_Disobedience1.Text)
        Points_Description = Points_Description & "2"
        Button_FaultBack.Enabled = True
    End Sub

    Private Sub Button_Disobedience2_Click(sender As Object, e As EventArgs) Handles Button_Disobedience2.Click
        If StartingDataView.Times(Type_counter)(1) = -1 Then
            points = points + 2
        Else
            points = points + 4
        End If
        Label_Points.Text = points
        Button_Disobedience2.Enabled = False
        Button_Disobedience3.Enabled = True
        Button_DisobedienceDis2.Enabled = False
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_Disobedience2.Text)
        Points_Description = Points_Description & "3"
    End Sub

    Private Sub Button_Disobedience3_Click(sender As Object, e As EventArgs) Handles Button_Disobedience3.Click
        Timer1.Stop()
        points = 99
        Button_Disobedience1.Enabled = False
        Button_Disobedience2.Enabled = False
        Button_Disobedience3.Enabled = False
        Button_DisobedienceDis1.Enabled = False
        Button_DisobedienceDis2.Enabled = False
        Button_Fall.Enabled = False
        Button_Discard.Enabled = False
        Button_Stop.Enabled = False
        Button_Next.Enabled = True
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_Disobedience3.Text)
        Points_Description = Points_Description & "4"
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        points = points + 1
        Label_Points.Text = points
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_Stop.Text)
        Points_Description = Points_Description & "5"
    End Sub

    Private Sub Button_DisobedienceDis1_Click(sender As Object, e As EventArgs) Handles Button_DisobedienceDis1.Click
        If StartingDataView.Times(Type_counter)(1) = -1 Then
            points = points + 1
            If second >= 54 Then
                second = second + 6 - 60
                minute = minute + 1
            Else
                second = second + 6
            End If
            If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
                If second1 >= 54 Then
                    second1 = second1 + 6 - 60
                    minute1 = minute1 + 1
                Else
                    second1 = second1 + 6
                End If
            End If
        Else
            points = points + 2
            If second >= 54 Then
                second = second + 6 - 60
                minute = minute + 1
            Else
                second = second + 6
            End If
            If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
                If second1 >= 54 Then
                    second1 = second1 + 6 - 60
                    minute1 = minute1 + 1
                Else
                    second1 = second1 + 6
                End If
            End If
        End If
        Label_Points.Text = points
        Button_Disobedience1.Enabled = False
        Button_Disobedience2.Enabled = True
        Button_DisobedienceDis1.Enabled = False
        Button_DisobedienceDis2.Enabled = True
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_DisobedienceDis1.Text)
        Points_Description = Points_Description & "6"
        Button_FaultBack.Enabled = True
    End Sub

    Private Sub Button_DisobedienceDis2_Click(sender As Object, e As EventArgs) Handles Button_DisobedienceDis2.Click
        If StartingDataView.Times(Type_counter)(1) = -1 Then
            points = points + 2
            If second >= 54 Then
                second = second + 6 - 60
                minute = minute + 1
            Else
                second = second + 6
            End If
            If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
                If second1 >= 54 Then
                    second1 = second1 + 6 - 60
                    minute1 = minute1 + 1
                Else
                    second1 = second1 + 6
                End If
            End If
        Else
            points = points + 4
            If second >= 54 Then
                second = second + 6 - 60
                minute = minute + 1
            Else
                second = second + 6
            End If
            If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
                If second1 >= 54 Then
                    second1 = second1 + 6 - 60
                    minute1 = minute1 + 1
                Else
                    second1 = second1 + 6
                End If
            End If
        End If
        Label_Points.Text = points
        Button_Disobedience2.Enabled = False
        Button_DisobedienceDis2.Enabled = False
        Button_Disobedience3.Enabled = True
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_DisobedienceDis2.Text)
        Points_Description = Points_Description & "7"
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        Application.Exit()
    End Sub

    Private Sub Button_Fall_Click(sender As Object, e As EventArgs) Handles Button_Fall.Click
        Timer1.Stop()
        points = 99
        Button_Disobedience1.Enabled = False
        Button_Disobedience2.Enabled = False
        Button_Disobedience3.Enabled = False
        Button_DisobedienceDis1.Enabled = False
        Button_DisobedienceDis2.Enabled = False
        Button_Fall.Enabled = False
        Button_Discard.Enabled = False
        Button_Stop.Enabled = False
        Button_Next.Enabled = True
        ListBox_Fault.Items.Add(ListBox_Fault.Items.Count & ". " & Button_Fall.Text)
        Points_Description = Points_Description & "8"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_FaultBack.Click
        ListBox_Fault.Items.Remove(ListBox_Fault.Items.Item(ListBox_Fault.Items.Count - 1))
        If Points_Description.Last = "1" Then
            If StartingDataView.Times(Type_counter)(1) = -1 Then
                points = points - 0.5
            Else
                points = points - 1
            End If

        ElseIf Points_Description.Last = "2" Then
            If StartingDataView.Times(Type_counter)(1) = -1 Then
                points = points - 1
            Else
                points = points - 2
            End If
            Button_Disobedience1.Enabled = True
            Button_Disobedience2.Enabled = False
            Button_DisobedienceDis1.Enabled = True
            Button_DisobedienceDis2.Enabled = False

        ElseIf Points_Description.Last = "3" Then
            If StartingDataView.Times(Type_counter)(1) = -1 Then
                points = points - 2
            Else
                points = points - 4
            End If
            Button_Disobedience2.Enabled = True
            Button_Disobedience3.Enabled = False
            Button_DisobedienceDis2.Enabled = True

        ElseIf Points_Description.Last = "5" Then
            points = points - 1


        ElseIf Points_Description.Last = "6" Then
            If StartingDataView.Times(Type_counter)(1) = -1 Then
                points = points - 1
            Else
                points = points - 2
            End If
            If second < 6 Then
                second = second - 6 + 60
                minute = minute - 1
            Else
                second = second - 6
            End If
            If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
                If second1 < 6 Then
                    second1 = second1 - 6 + 60
                    minute1 = minute1 - 1
                Else
                    second1 = second1 - 6
                End If
            End If
            Button_Disobedience1.Enabled = True
            Button_Disobedience2.Enabled = False
            Button_DisobedienceDis1.Enabled = True
            Button_DisobedienceDis2.Enabled = False

        ElseIf Points_Description.Last = "7" Then
            If StartingDataView.Times(Type_counter)(1) = -1 Then
                points = points - 2
            Else
                points = points - 4
            End If
            If second < 6 Then
                second = second - 6 + 60
                minute = minute - 1
            Else
                second = second - 6
            End If
            If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
                If second1 < 6 Then
                    second1 = second1 - 6 + 60
                    minute1 = minute1 - 1
                Else
                    second1 = second1 - 6
                End If
            End If
            Button_Disobedience2.Enabled = True
            Button_Disobedience3.Enabled = False
            Button_DisobedienceDis2.Enabled = True
        End If
        Label_Points.Text = points
        Points_Description = Points_Description.Remove(ListBox_Fault.Items.Count - 1, 1)
        If Points_Description = "" Then
            Button_FaultBack.Enabled = False
        End If
    End Sub

    Private Sub Button_RoundStart_Click(sender As Object, e As EventArgs) Handles Button_RoundStart.Click
        Fill_DataTable()
        Button_Start.Enabled = True
        Label_Type.Text = dbDataSet.Rows(Row)(3).ToString
        Label_Name.Text = dbDataSet.Rows(Row)(4).ToString
        Label_Surname.Text = dbDataSet.Rows(Row)(5).ToString
        Label_Horse.Text = dbDataSet.Rows(Row)(6).ToString
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Button_Next.Enabled = False
        counter = 0
        Try
            Dim Query As String
            connection.Open()
            Query = "UPDATE StartList SET Time='" & minute & ":" & second & ":" & hundredth & "', Points='" & points & "', Hundredth='" & Hundredth_Counter & "',POINTS_DESCRIPTION='" & Points_Description & "' WHERE ID='" & dbDataSet.Rows(Row)(0) & "'"
            command = New MySqlCommand(Query, connection)
            READ = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        Points_Description = ""
        SerialPort1.Close()
        ListBox_Fault.Items.Clear()
        ListBox_Fault.Items.Add("Błędy:")
        Row = Row + 1
        If Row = dbDataSet.Rows.Count Then
            Row = 0
            points = 0
            minute = 0
            second = 0
            hundredth = 0
            minute1 = 0
            hundredth1 = 0
            second1 = 0
            Type_counter = Type_counter + 1
            If Type_counter > 4 Then
                Me.Visible = False
                ResultsView.Visible = True
                ResultsView.Results()
            Else
                MessageBox.Show("Koniec rundy:" & Type(Type_counter - 1))
                Button_RoundStart.Enabled = True
                Label_Name.Text = ""
                Label_Surname.Text = ""
                Label_Horse.Text = ""
                Label_Second.Text = "00"
                Label_SecondLimit.Text = "00"
                Label_Minute.Text = "00"
                Label_MinuteLimit.Text = "00"
                Label_Hundredth.Text = "00"
                Label_HundredthLimit.Text = "00"
                Label_Points.Text = "0"
                Label_HitTime.Text = ""
                Label_TimeLimit.Text = ""
                Label_Type.Text = Type(Type_counter)

                If StartingDataView.Times(Type_counter)(1) = -1 Then
                    Label_HitTime.Text = "z trafieniem w normę czasu"
                End If
                Label_TimeLimit.Text = StartingDataView.Times(Type_counter)(0)
                dbDataSet.Reset()
                Fill_DataTable()
            End If
        Else
            points = 0
            minute = 0
            second = 0
            hundredth = 0
            minute1 = 0
            hundredth1 = 0
            second1 = 0
            Label_Name.Text = dbDataSet.Rows(Row)(4).ToString
            Label_Surname.Text = dbDataSet.Rows(Row)(5).ToString
            Label_Horse.Text = dbDataSet.Rows(Row)(6).ToString
            Label_Second.Text = "00"
            Label_SecondLimit.Text = "00"
            Label_Minute.Text = "00"
            Label_MinuteLimit.Text = "00"
            Label_Hundredth.Text = "00"
            Label_HundredthLimit.Text = "00"
            Label_Points.Text = "0"
            Label_HitTime.Text = ""
            Label_TimeLimit.Text = ""
            Button_Start.Enabled = True
        End If
        Button_Disobedience1.Enabled = False
        Button_Disobedience2.Enabled = False
        Button_Disobedience3.Enabled = False
        Button_DisobedienceDis1.Enabled = False
        Button_DisobedienceDis2.Enabled = False
        Button_Fall.Enabled = False
        Button_Discard.Enabled = False
        Button_Stop.Enabled = False
        Button_FaultBack.Enabled = False
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        If Row <= dbDataSet.Rows.Count Then
            Try
                SerialPort1.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
            Button_Start.Enabled = False
        Else
            counter = 0
        End If
        Button_RoundStart.Enabled = False
        Button_Disobedience1.Enabled = True
        Button_DisobedienceDis1.Enabled = True
        Button_Fall.Enabled = True
        Button_Discard.Enabled = True
        If StartingDataView.Times(Type_counter)(1) = -1 Then
            Button_Stop.Enabled = True
        End If
    End Sub

    Private Sub TournamentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "

        If StartingDataView.Times(Type_counter)(1) = -1 Then
            Label_HitTime.Text = "z trafieniem w normę czasu"
        End If
        Label_TimeLimit.Text = StartingDataView.Times(Type_counter)(0)
        SerialPort1.PortName = ConfigurationView.ComboBox_Port.Text
        SerialPort1.BaudRate = "9600"
        Button_FaultBack.Enabled = False
    End Sub

    Private Sub Fill_DataTable()
        If Type_counter <= 4 Then
            Try
                dbDataSet.Reset()
                connection.Open()
                Dim Query As String
                Query = "select S.ID,S.HORSEID,S.PLAYERID,S.TYPE,P.NAME,P.SURNAME,H.NAME,S.TIME from StartList S, Players P, Horses H where S.HORSEID=H.ID AND S.PLAYERID=P.ID AND S.TYPE='" & Type(Type_counter) & "' ORDER BY S.ID"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try

        Else
            Me.Visible = False
            ResultsView.Visible = True
            ResultsView.Results()
        End If
        If dbDataSet.Rows.Count = 0 Then
            If Type_counter <= 4 Then
                Type_counter = Type_counter + 1
                Fill_DataTable()
            End If
        Else
            While (dbDataSet.Rows(Row)(7).ToString <> "00:00:00")
                Row = Row + 1
            End While
        End If
            End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Visible = False
        StartView.Visible = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'hundredth = hundredth + 1
        'Hundredth_Counter = Hundredth_Counter + 1
        'If hundredth = 100 Then
        '    second = second + 1
        '    Second_Counter = Second_Counter + 1
        '    hundredth = 0
        '    If second = 60 Then
        '        second = 0
        '        minute = minute + 1
        '    End If
        'End If
        If DateTime.Now.Millisecond >= millisecond Then
            millisecond_actualy = DateTime.Now.Millisecond - millisecond
        Else
            millisecond_actualy = DateTime.Now.Millisecond + (1000 - millisecond)
        End If
        If Fix(millisecond_actualy / 10) <> hundredth Then
            hundredth = Fix(millisecond_actualy / 10)
            If hundredth = 0 Then
                second = second + 1
                Second_Counter = Second_Counter + 1
                If second = 60 Then
                    second = 0
                    minute = minute + 1
                End If
            End If
        End If
        If Second_Counter >= StartingDataView.Times(Type_counter)(0) Then
            If Fix(millisecond_actualy / 10) <> hundredth1 Then
                hundredth1 = Fix(millisecond_actualy / 10)
                If hundredth1 = 0 Then
                    second1 = second1 + 1
                    If StartingDataView.Times(Type_counter)(0) = 0 Then
                        points = points + 0.1
                    End If
                    Label_Points.Text = points
                    If second1 = 60 Then
                        second1 = 0
                        minute1 = minute1 + 1
                    End If
                End If
                Label_MinuteLimit.Text = minute1
                Label_SecondLimit.Text = second1
                Label_HundredthLimit.Text = hundredth1
            End If
        End If
        Label_Minute.Text = minute
        Label_Second.Text = second
        Label_Hundredth.Text = hundredth
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Me.Invoke(New EventHandler(AddressOf Dispalydata_event))
    End Sub

    Private Sub Dispalydata_event(sender As Object, e As EventArgs)
        ''Try
        ''    data = SerialPort1.ReadByte()
        ''    If data = 49 Then
        ''        Timer1.Start()
        ''    ElseIf data = 48 Then
        ''        Timer1.Stop()
        ''        Timer2.Stop()
        ''        Second_Counter = 0
        ''        Button_Next.Enabled = True

        ''    End If

        ''Catch ex As Exception
        ''    MessageBox.Show(ex.Message, "Error")
        ''End 
        If counter = 0 Then
            Timer1.Enabled = True
            millisecond = DateTime.Now.Millisecond
            counter = 1
        ElseIf counter = 1 Then
            Timer1.Enabled = False
            Button_Next.Enabled = True
        End If

    End Sub

End Class