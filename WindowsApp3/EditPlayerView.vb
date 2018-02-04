Imports MySql.Data.MySqlClient

Public Class EditPlayerView

    Private Sub EditPlayerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Name.Text = AddPlayerView.row.Cells("NAME").Value.ToString
        TextBox_Name.Text = AddPlayerView.row.Cells("NAME").Value.ToString
        Label_Surname.Text = AddPlayerView.row.Cells("SURNAME").Value.ToString
        TextBox_Surname.Text = AddPlayerView.row.Cells("SURNAME").Value.ToString
        Label_Date.Text = AddPlayerView.row.Cells("BIRTH").Value.ToString.Remove(11)
        DateTimePicker_Date.Value = AddPlayerView.row.Cells("BIRTH").Value.ToString
    End Sub
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click, MyBase.FormClosed
        Me.Visible = False
        AddPlayerView.Enabled = True
        AddPlayerView.Activate()
        AddPlayerView.AddPlayerView_TableUpdate()

    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        Dim connection As New MySqlConnection
        Dim command As MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        Try
            Dim Query As String
            Query = "update Players set NAME='" & TextBox_Name.Text & "',SURNAME='" & TextBox_Surname.Text & "',BIRTH='" & DateTimePicker_Date.Value.ToShortDateString & "' where ID='" & AddPlayerView.row.Cells("ID").Value.ToString & "'"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            connection.Close()
            Me.Close()
            AddPlayerView.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
    End Sub


End Class