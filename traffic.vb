Public Class Form1
    Dim signalIndex As Integer = 0 ' Variable to track the current signal state

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000 ' Set the interval of the timer (in milliseconds)
        Timer1.Start() ' Start the timer
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment signalIndex to switch to the next signal
        signalIndex = (signalIndex + 1) Mod 3

        ' Update the signal
        Select Case signalIndex
            Case 0 ' Red Signal
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
            Case 1 ' Yellow Signal
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox3.Visible = False
            Case 2 ' Green Signal
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = True
        End Select
    End Sub
End Class

