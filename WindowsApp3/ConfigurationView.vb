Public Class ConfigurationView


    Private Sub ConfigurationView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox_Port.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Me.Close()
        StartView.Visible = True
    End Sub

    Private Sub ComboBox_Port_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Port.SelectedIndexChanged
        Dim data As UInt16
        SerialPort1.PortName = ComboBox_Port.Text
        SerialPort1.BaudRate = "9600"
        Try
            SerialPort1.Open()
            data = SerialPort1.ReadByte()
            If data = 49 Or data = 48 Then
                PictureBox1.BackColor = Color.Green
                Label_Check.Text = "OK"
                Button_Ok.Enabled = True
            Else
                PictureBox1.BackColor = Color.Red
                Label_Check.Text = "ERROR"
                Button_Ok.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        SerialPort1.Close()
    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        Me.Visible = False
        StartView.Visible = True
        StartView.Button_Continuation.Enabled = True
        StartView.ButtonNewTournament.Enabled = True
        StartView.ButtonTraining.Enabled = True
        SerialPort1.Close()

    End Sub



    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        Application.Exit()
    End Sub
End Class