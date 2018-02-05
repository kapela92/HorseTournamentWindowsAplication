Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports MySql.Data.MySqlClient





Public Class AddPlayerView
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Dim PlayerID As String
    Dim HorseID As String
    Public row As DataGridViewRow
    Dim Counter As Boolean


    Private Sub StartingOptionsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Button_Approved.Enabled = False
        Try
            Counter = False
            connection.Open()
            Dim Query As String
            Query = "select * from kapela92.Players"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            DataGridView1.Columns("ID").Visible = False
            Button_Back.Visible = False
            row = Me.DataGridView1.Rows(0)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public Sub AddPlayerView_TableUpdate()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        If Counter = False Then
            Try
                Dim Query As String
                Query = "select * from kapela92.Players"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                DataGridView1.Columns("ID").Visible = False
                row = Me.DataGridView1.Rows(0)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
        ElseIf Counter = True Then
            Try
                Dim Query As String
                Query = "select * from kapela92.Horses"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                DataGridView1.Columns("ID").Visible = False
                connection.Close()
                row = Me.DataGridView1.Rows(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        connection.Close()
        Me.Visible = False
        StartingDataView.Enabled = True
        StartingDataView.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            row = Me.DataGridView1.Rows(e.RowIndex)

        End If
    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        If Counter = False Then
            Label_Name.Text = row.Cells("NAME").Value.ToString
            Label_Surname.Text = row.Cells("SURNAME").Value.ToString
            Label1.Text = "Konie"
            Counter = True
            PlayerID = row.Cells("ID").Value.ToString
            Try
                Dim Query As String
                Query = "select * from kapela92.Horses"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                DataGridView1.Columns("ID").Visible = False
                Button_Back.Visible = True
                connection.Close()
                row = Me.DataGridView1.Rows(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
        Else
            Label_Horse.Text = row.Cells("NAME").Value.ToString
            HorseID = row.Cells("ID").Value.ToString
            Button_Approved.Enabled = True
        End If
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Label_Name.Text = "----"
        Label_Surname.Text = "----"
        Label_Horse.Text = "----"
        Button_Back.Visible = False
        Button_Approved.Enabled = False
        Try
            Dim Query As String
            Query = "select * from kapela92.Players"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            DataGridView1.Columns("ID").Visible = False
            Counter = False
            Button_Back.Visible = False
            row = Me.DataGridView1.Rows(0)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        If Counter = False Then
            ' Me.Enabled = False
            AddPlayerToDatabaseView.Visible = True


        ElseIf Counter = True Then
            Me.Enabled = False
            AddHorseToDatabaseView.Visible = True

        End If

    End Sub

    Private Sub Button_Approved_Click(sender As Object, e As EventArgs) Handles Button_Approved.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Label_Name.Text = "----"
        Label_Surname.Text = "----"
        Label_Horse.Text = "----"
        Button_Back.Visible = False
        Try


            Dim Query As String
            Query = "insert into kapela92.Temporary (PlayerID,HorseID,FirstRound,SecondRound,Stud,Name) values ('" & PlayerID & "','" & HorseID & "','" & ComboBox_Type1.Text & "','" & ComboBox_Type2.Text & "','" & StartingDataView.Label_Stud.Text & "','" & StartingDataView.Label_Name.Text & "')"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            'bSource.DataSource = dbDataSet
            'DataGridView1.DataSource = bSource
            'DataGridView1.Columns("ID").Visible = False
            Counter = False
            Button_Back.Visible = False
            'row = Me.DataGridView1.Rows(0)
            connection.Close()
            Me.Close()
            StartingDataView.Visible = True
            Button_Approved.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If Counter = False Then
            Me.Enabled = False
            EditPlayerView.Visible = True


        ElseIf Counter = True Then
            Me.Enabled = False
            EditHorseView.Visible = True

        End If
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        If Counter = False Then
            Try
                Dim Query As String
                Query = "delete from Players where ID='" & row.Cells("ID").Value.ToString & "'"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                connection.Close()
                AddPlayerView_TableUpdate()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
        ElseIf Counter = True Then
            Try
                Dim Query As String
                Query = "delete from Horses where ID='" & row.Cells("ID").Value.ToString & "'"
                command = New MySqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                connection.Close()
                AddPlayerView_TableUpdate()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            Finally
                connection.Dispose()
            End Try
        End If

    End Sub
End Class