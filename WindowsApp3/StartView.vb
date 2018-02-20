Imports MySql.Data.MySqlClient

Public Class StartView
    Dim command As MySqlCommand
    Dim connection As New MySqlConnection
    Dim SDA As New MySqlDataAdapter
    Dim READ As MySqlDataReader
    Dim dbDataSet As New DataTable
    Private Sub StartView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SDA As New MySqlDataAdapter
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        Try
            dbDataSet.Reset()
            connection.Open()
            Dim Query As String
            Query = "select * from Temporary"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        If dbDataSet.Rows.Count <> 0 Then
            Button_Continuation.Visible = True
        Else
        End If
    End Sub

    Private Sub ButtonNewTournament_Click(sender As Object, e As EventArgs) Handles ButtonNewTournament.Click
        StartingDataView.Label_Name.Text = Interaction.InputBox("Podaj nazwę zawodów", "Nazwa zawodów", "", -1, -1)
        StartingDataView.Label_Stud.Text = Interaction.InputBox("Podaj nazwę stajni", "Stajnia", "", -1, -1)
        Try
            Dim Query As String
            connection.Open()
            Query = "TRUNCATE TABLE StartList"
            command = New MySqlCommand(Query, connection)
            READ = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        Try
            Dim Query As String
            connection.Open()
            Query = "TRUNCATE TABLE Temporary"
            command = New MySqlCommand(Query, connection)
            READ = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        Me.Visible = False
        StartingDataView.Visible = True
        StartingDataView.Enabled = True

    End Sub

    Private Sub ButtonTraining_Click(sender As Object, e As EventArgs) Handles ButtonTraining.Click
        TrainingView.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button_Configuration_Click(sender As Object, e As EventArgs) Handles Button_Configuration.Click
        ConfigurationView.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnectionTestView.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.Visible = False
        'ResultsView.Visible = True
        'ResultsView.Results()
        System.Diagnostics.Process.Start("http://horsetournament.apphb.com/Home/Tournament")
    End Sub

    Private Sub Button_Continuation_Click(sender As Object, e As EventArgs) Handles Button_Continuation.Click
        Dim Row As Integer = 0
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        Try
            dbDataSet.Reset()
            connection.Open()
            Dim Query As String
            Query = "select * from StartList"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        If dbDataSet.Rows.Count <> 0 Then
            While (dbDataSet.Rows(Row)(4).ToString <> "00:00:00")
                Row = Row + 1
            End While
            TournamentView.Type_counter = Array.IndexOf(TournamentView.Type, dbDataSet.Rows(Row)(3).ToString)

            Try
                dbDataSet.Reset()
                connection.Open()
                Dim Query As String
                Query = "select * from TimeLimit WHERE DATE='" & DateTime.Today.Date.ToString("yyyy-MM-dd") & "'"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
            StartingDataView.Label_Stud.Text = dbDataSet.Rows(0)(2).ToString
            StartingDataView.Label_Name.Text = dbDataSet.Rows(0)(1).ToString
            StartingDataView.Times = {New Integer() {Convert.ToInt64(dbDataSet.Rows(0)(4).ToString), Convert.ToInt64(dbDataSet.Rows(0)(5).ToString)}, New Integer() {Convert.ToInt64(dbDataSet.Rows(0)(6)), Convert.ToInt64(dbDataSet.Rows(0)(7))}, New Integer() {Convert.ToInt64(dbDataSet.Rows(0)(8)), Convert.ToInt64(dbDataSet.Rows(0)(9))}, New Integer() {Convert.ToInt64(dbDataSet.Rows(0)(10)), Convert.ToInt64(dbDataSet.Rows(0)(11))}, New Integer() {Convert.ToInt64(dbDataSet.Rows(0)(12)), Convert.ToInt64(dbDataSet.Rows(0)(13))}}
            Me.Visible = False
            TournamentView.Visible = True

        Else
            Try
                dbDataSet.Reset()
                connection.Open()
                Dim Query As String
                Query = "select * from Temporary"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
            StartingDataView.Label_Name.Text = dbDataSet.Rows(0)(6).ToString
            StartingDataView.Label_Stud.Text = dbDataSet.Rows(0)(5).ToString
            Me.Visible = False
            StartingDataView.Visible = True

        End If
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        Application.Exit()
    End Sub
End Class
