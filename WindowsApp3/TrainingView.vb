Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class TrainingView
    Dim myPort As Array
    Dim minute, second, hundredth, counter, lap, millisecond, millisecond_atualy As Integer

    Dim data As UInt16
    Delegate Sub SetTextCallBack(ByVal [text] As String)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_End.Click
        SerialPort1.Close()
        Me.Close()
        StartView.Visible = True
    End Sub

    Private Sub Button_Clean_Click(sender As Object, e As EventArgs) Handles Button_Clean.Click
        lap = 1
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Okrążenia:")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'hundredth = hundredth + 1
        'If hundredth = 100 Then
        '    second = second + 1
        '    hundredth = 0
        '    If second = 60 Then
        '        second = 0
        '        minute = minute + 1
        '    End If
        'End If
        If DateTime.Now.Millisecond >= millisecond Then
            millisecond_atualy = DateTime.Now.Millisecond - millisecond
        Else
            millisecond_atualy = DateTime.Now.Millisecond + (1000 - millisecond)
        End If
        If Fix(millisecond_atualy / 10) <> hundredth Then
            hundredth = Fix(millisecond_atualy / 10)
            Label3.Text = hundredth
            If hundredth = 0 Then
                second = second + 1
                If second = 60 Then
                    second = 0
                    minute = minute + 1
                End If
            End If
            Label2.Text = second
            Label1.Text = minute
        End If
        'If DateTime.Now.Second >= second Then
        '    Label2.Text = DateTime.Now.Second - second
        'Else
        '    Label2.Text = DateTime.Now.Second + (60 - second)
        'End If
        'If DateTime.Now.Minute >= minute Then
        '    Label1.Text = DateTime.Now.Minute - minute
        'Else
        '    Label1.Text = DateTime.Now.Minute - (60 - minute)
        'End If
        'Label1.Text = minute
        'Label2.Text = second
        'Label3.Text = hundredth
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        Application.Exit()
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        Timer1.Enabled = False
        counter = 0
        Label1.Text = "00"
        Label2.Text = "00"
        Label3.Text = "00"
        minute = 0
        second = 0
        hundredth = 0
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
        lap = 1
        'Try
        '    data = SerialPort1.ReadByte()
        '    Label6.Text = data
        '    If data = 49 Then
        '        Timer1.Enabled = True
        '    ElseIf data = 48 Then
        '        Timer1.Enabled = False
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error")
        'End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Me.Invoke(New EventHandler(AddressOf dispalydata_event))
    End Sub
    Private Sub Dispalydata_event(sender As Object, e As EventArgs)
        'Try
        '    data = SerialPort1.ReadByte()
        '    Label6.Text = data
        '    If data = 49 Then
        '        Timer1.Enabled = True
        '    ElseIf data = 48 Then
        '        Timer1.Enabled = False
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error")
        'End Try
        'data = SerialPort1.ReadByte()
        If counter = 0 Then
            Timer1.Enabled = True
            millisecond = DateTime.Now.Millisecond
            counter = 1
        ElseIf counter = 1 Then
            ListBox1.Items.Add(lap & ". " & Label1.Text & ":" & Label2.Text & ":" & Label3.Text)
            millisecond = DateTime.Now.Millisecond
            Label1.Text = "00"
            Label2.Text = "00"
            Label3.Text = "00"
            hundredth = 0
            second = 0
            minute = 0
            lap = lap + 1
        End If
    End Sub
End Class