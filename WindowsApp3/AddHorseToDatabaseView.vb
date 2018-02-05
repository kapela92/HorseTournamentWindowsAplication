Imports MySql.Data.MySqlClient

Public Class AddHorseToDatabaseView

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
            Query = "insert into kapela92.Horses(NAME,YEAR,MOTHER,FATHER) values ('" & TextBox_Name.Text & "','" & NumericUpDown_Year.Value.ToString & "','" & TextBox_MomsName.Text & "','" & TextBox_FathersName.Text & "')"
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

    Private Sub AddHorseToDatabaseView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class