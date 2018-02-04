Imports MySql.Data.MySqlClient

Public Class EditHorseView

    Private Sub EditHorseView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Name.Text = AddPlayerView.row.Cells("NAME").Value.ToString
        TextBox_Name.Text = AddPlayerView.row.Cells("NAME").Value.ToString
        Label_Mother.Text = AddPlayerView.row.Cells("MOTHER").Value.ToString
        TextBox_Mother.Text = AddPlayerView.row.Cells("MOTHER").Value.ToString
        Label_Father.Text = AddPlayerView.row.Cells("FATHER").Value.ToString
        TextBox_Father.Text = AddPlayerView.row.Cells("FATHER").Value.ToString
        Label_Year.Text = AddPlayerView.row.Cells("YEAR").Value.ToString
        NumericUpDown1.Value = AddPlayerView.row.Cells("YEAR").Value.ToString
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
            Query = "update Horses set NAME='" & TextBox_Name.Text & "',MOTHER='" & TextBox_Mother.Text & "',FATHER='" & TextBox_Father.Text & "',YEAR='" & NumericUpDown1.Value.ToString & "' where ID='" & AddPlayerView.row.Cells("ID").Value.ToString & "'"
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