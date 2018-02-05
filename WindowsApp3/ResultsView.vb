Imports MySql.Data.MySqlClient

Public Class ResultsView
    Dim Type() As String = New String(4) {"Debiut", "MiniLL", "LL", "L", "L1"}
    Dim Type_counter As Integer = 0
    Dim command As MySqlCommand
    Dim connection As New MySqlConnection
    Dim SDA As New MySqlDataAdapter
    Dim READ As MySqlDataReader
    Dim dbDataSet As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        StartView.Visible = True

    End Sub

    Private Sub ResultsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Results()
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        For i As Integer = 0 To 4
            If StartingDataView.Times(i)(0) = -1 Then
                Try
                    Dim Query As String
                    connection.Open()
                    Query = "Select S.ID,S.HorseID,S.PlayerID,S.Type,S.Time,S.Points,P.Name,P.Surname,H.Name,Hundredth as ABS(" & StartingDataView.Times(i)(1) & "*100-S.Hunderdth) from StartList S, Players P, Horses H where TYPE='" & Type(i) & "' AND S.PlayerID=P.ID AND S.HorseID=H.ID order by S.Points,Hundredth"
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
                Try
                    Dim Query As String
                    connection.Open()
                    Query = "Select S.ID,S.HorseID,S.PlayerID,S.Type,S.Time,S.Points,P.Name,P.Surname,H.Name,S.Hundredth from StartList S, Players P, Horses H where TYPE='" & Type(i) & "' AND S.PlayerID=P.ID AND S.HorseID=H.ID order by S.Points,S.TIME"
                    command = New MySqlCommand(Query, connection)
                    SDA.SelectCommand = command
                    SDA.Fill(dbDataSet)
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                Finally
                    connection.Dispose()
                End Try
            End If
            For a As Integer = 0 To dbDataSet.Rows.Count - 1
                For b As Integer = 0 To a
                    If dbDataSet.Rows(a)(2) = dbDataSet.Rows(b)(2) And dbDataSet.Rows(a)(1) = dbDataSet.Rows(b)(1) Then
                        a = a + 1
                    End If
                Next
                Try
                    Dim Query As String
                        connection.Open()
                        Query = "INSERT INTO `Tournament`(`PlayerID`, `HorseID`, `Stud`, `Name`, `Date`, `Type`, `Position`, `Time`, `Points`, `HITT`) VALUES ('" & dbDataSet.Rows(a)(2).ToString & "','" & dbDataSet.Rows(a)(1).ToString & "','" & StartingDataView.Label_Stud.Text & "','" & StartingDataView.Label_Name.Text & "','" & DateTime.Today & "','" & dbDataSet.Rows(a)(3).ToString & "','" & a + 1 & "','" & dbDataSet.Rows(a)(4).ToString & "','" & dbDataSet.Rows(a)(5).ToString & "','" & StartingDataView.Times(i)(1) & "')"
                        command = New MySqlCommand(Query, connection)
                        READ = command.ExecuteReader
                        READ.Close()
                        connection.Close()
                        Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")
                        Finally
                        connection.Dispose()
                        End Try
                        If i = 0 Then
                            If a < 9 Then
                                ListBox_Debiuts.Items.Add(a + 1 & " " & dbDataSet.Rows(a)(6) & " " & dbDataSet.Rows(a)(7) & " " & dbDataSet.Rows(a)(8))
                                ListBox_Debiuts.Items.Add("")
                            End If
                        End If
                        If i = 1 Then
                            If a < 9 Then
                                ListBox_MiniLL.Items.Add(a + 1 & " " & dbDataSet.Rows(a)(6) & " " & dbDataSet.Rows(a)(7) & " " & dbDataSet.Rows(a)(8))
                                ListBox_MiniLL.Items.Add("")
                            End If
                        End If
                        If i = 2 Then
                            If a < 9 Then
                                ListBox_LL.Items.Add(a + 1 & " " & dbDataSet.Rows(a)(6) & " " & dbDataSet.Rows(a)(7) & " " & dbDataSet.Rows(a)(8))
                                ListBox_LL.Items.Add("")
                            End If
                        End If
                        If i = 3 Then
                            If a < 9 Then
                                ListBox_L.Items.Add(a + 1 & " " & dbDataSet.Rows(a)(6) & " " & dbDataSet.Rows(a)(7) & " " & dbDataSet.Rows(a)(8))
                                ListBox_L.Items.Add("")
                            End If
                        End If
                        If i = 4 Then
                            If a < 9 Then
                                ListBox_L1.Items.Add(a + 1 & " " & dbDataSet.Rows(a)(6) & " " & dbDataSet.Rows(a)(7) & " " & dbDataSet.Rows(a)(8))
                                ListBox_L1.Items.Add("")
                            End If
                        End If
            Next
                dbDataSet.Clear()
        Next
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        Application.Exit()
    End Sub
End Class