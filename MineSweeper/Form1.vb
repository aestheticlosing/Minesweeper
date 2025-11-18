Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Form2.Show()
            Hide()
        ElseIf RadioButton2.Checked Then
            Form3.Show()
            Hide()
        Else
            Form4.Show()
            Hide()
        End If
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class