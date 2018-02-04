Imports MySql.Data.MySqlClient


Public Class StartingDataView
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Dim row As DataGridViewRow
    Public Times()() As Integer


    Private Sub StartingDataView_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        connection.ConnectionString = "server=kapela92.cba.pl; userid=HorseTournament; Password=Yamahar1; database=kapela92 "
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try

            connection.Open()
            Dim Query As String
            Query = "select T.ID,P.NAME,P.SURNAME,H.NAME,T.FIRSTROUND,T.SECONDROUND from Temporary T, Players P, Horses H WHERE T.PLAYERID=P.ID AND T.HORSEID=H.ID"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            connection.Close()
            DataGridView1.Columns("ID").Visible = False
            'DataGridView1.Columns("NAME").Visible = False
            'DataGridView1.Columns("STUD").Visible = False
            Try
                row = Me.DataGridView1.Rows(0)
            Catch ex As Exception
                Button_Add.PerformClick()
            End Try


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub StartingDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Name.Text = Interaction.InputBox("Podaj nazwę zawodów", "Nazwa zawodów", "", -1, -1)
        Label_Stud.Text = Interaction.InputBox("Podaj nazwę stajni", "Stajnia", "", -1, -1)
        Label7.Text = CheckBox_Debiut.Checked
    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Visible = False
        StartView.Visible = True
        Times = {New Integer() {NumericUpDown_Debiut.Value, CheckBox_Debiut.Checked}, New Integer() {NumericUpDown_MiniLL.Value, CheckBox_MiniLL.Checked}, New Integer() {NumericUpDown_LL.Value, CheckBox_LL.Checked}, New Integer() {NumericUpDown_L.Value, CheckBox_L.Checked}, New Integer() {NumericUpDown_L1.Value, CheckBox_L1.Checked}}

    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        AddPlayerView.Visible = True
        Me.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            row = Me.DataGridView1.Rows(e.RowIndex)

        End If
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            connection.Open()
            Dim Query As String
            Query = "Delete from Temporary where ID='" & row.Cells("ID").Value.ToString & "'"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            Query = "select T.ID,P.NAME,P.SURNAME,H.NAME,T.FIRSTROUND,T.SECONDROUND from Temporary T, Players P, Horses H WHERE T.PLAYERID=P.ID AND T.HORSEID=H.ID"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            DataGridView1.Columns("ID").Visible = False
            'DataGridView1.Columns("NAME").Visible = False
            'DataGridView1.Columns("STUD").Visible = False
            Try
                row = Me.DataGridView1.Rows(0)
            Catch ex As Exception
                Button_Add.Select()
            End Try

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        Dim SDA As New MySqlDataAdapter
        Dim READ As MySqlDataReader
        Dim dbDataSet As New DataTable

        Dim Type() As String = New String(4) {"Debiut", "MiniLL", "LL", "L", "L1"}
        Dim Round() As String = New String(1) {"FIRSTROUND", "SECONDROUND"}
        Try
            connection.Open()
            Dim Query As String
            For i As Integer = 0 To 4
                For a As Integer = 0 To 1
                    Query = "select * from Temporary WHERE " & Round(a) & "='" & Type(i) & "'"
                    command = New MySqlCommand(Query, connection)
                    SDA.SelectCommand = command
                    SDA.Fill(dbDataSet)
                    Dim counter As Integer = dbDataSet.Rows.Count
                    If dbDataSet.Rows.Count > 0 Then
                        For b As Integer = 1 To counter
                            Dim Rand As Integer = New Random().Next(1, dbDataSet.Rows.Count) - 1
                            Query = "INSERT INTO `StartList` (`HorseID`, `PlayerID`, `Type`, `Time`, `Points`,'Hundredth') VALUES ('" & dbDataSet.Rows(Rand)(2).ToString & "','" & dbDataSet.Rows(Rand)(1).ToString & "','" & Type(i) & "','00:00:00','0','0')"
                            command = New MySqlCommand(Query, connection)
                            READ = command.ExecuteReader
                            dbDataSet.Rows(Rand).Delete()
                            READ.Close()
                        Next
                    End If
                    dbDataSet.Clear()
                Next
            Next
            Query = "INSERT INTO `TimeLimit` (`NAME`, `PLEACE`, `DATE`, `DEBIUT`, `MINILL`,'LL','L','L1') VALUES ('" & Label_Name.Text & "','" & Label_Stud.Text & "','" & DateAndTime.Today & "','" & NumericUpDown_Debiut.Value & "','" & NumericUpDown_MiniLL.Value & "','" & NumericUpDown_LL.Value & "','" & NumericUpDown_L.Value & "','" & NumericUpDown_L1.Value & "')"
            command = New MySqlCommand(Query, connection)
            READ = command.ExecuteReader
            READ.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            connection.Dispose()
        End Try
        Times = {New Integer() {NumericUpDown_Debiut.Value, CheckBox_Debiut.Checked}, New Integer() {NumericUpDown_MiniLL.Value, CheckBox_MiniLL.Checked}, New Integer() {NumericUpDown_LL.Value, CheckBox_LL.Checked}, New Integer() {NumericUpDown_L.Value, CheckBox_L.Checked}, New Integer() {NumericUpDown_L1.Value, CheckBox_L1.Checked}}
        Me.Visible = False
        TournamentView.Visible = True
        connection.Close()
    End Sub

    Private Sub CheckBox_Debiut_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Debiut.CheckedChanged
        Label7.Text = CheckBox_Debiut.Checked
    End Sub
End Class