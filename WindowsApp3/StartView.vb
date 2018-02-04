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
            connection.Open()
            Dim Query As String
            Query = "select * from Temporary"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
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
        StartingDataView.Visible = True
        Me.Visible = False

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
        TournamentView.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ResultsView.Visible = True
        ResultsView.Results()
    End Sub

    Private Sub Button_Continuation_Click(sender As Object, e As EventArgs) Handles Button_Continuation.Click
        Dim Row As Integer = 0
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        Try
            connection.Open()
            Dim Query As String
            Query = "select * from StartList"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        If dbDataSet.Rows.Count <> 0 Then
            While (dbDataSet.Rows(Row)(4).ToString <> "00:00:00")
                Row = Row + 1
            End While
            TournamentView.Row = Row
            TournamentView.Type_counter = 0
        End If
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        Close()
    End Sub
End Class
