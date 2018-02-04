Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class TrainingView
    Dim myPort As Array
    Dim minute, second, hundredth, counter As Int64

    Dim data As UInt16
    Delegate Sub SetTextCallBack(ByVal [text] As String)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Close()
        Me.Close()
        StartView.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hundredth = hundredth + 1
        If hundredth = 100 Then
            second = second + 1
            hundredth = 0
            If second = 60 Then
                second = 0
                minute = minute + 1
            End If
        End If
        Label1.Text = minute
        Label2.Text = second
        Label3.Text = hundredth
    End Sub

    Private Sub TrainingView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        SerialPort1.PortName = ConfigurationView.ComboBox_Port.Text
        SerialPort1.BaudRate = "9600"
        'SerialPort1.Parity = Parity.None
        'SerialPort1.DataBits = 6
        'SerialPort1.StopBits = StopBits.One
        'SerialPort1.Handshake = Handshake.None
        'SerialPort1.RtsEnable = True
        Try
            SerialPort1.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        data = "0"
        minute = 0
        second = 0
        hundredth = 0
        counter = 0
        Try
            data = SerialPort1.ReadByte()
            Label6.Text = data
            If data = 49 Then
                Timer1.Enabled = True
            ElseIf data = 48 Then
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Me.Invoke(New EventHandler(AddressOf dispalydata_event))
    End Sub
    Private Sub dispalydata_event(sender As Object, e As EventArgs)
        Try
            data = SerialPort1.ReadByte()
            Label6.Text = data
            If data = 49 Then
                Timer1.Enabled = True
            ElseIf data = 48 Then
                Timer1.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class