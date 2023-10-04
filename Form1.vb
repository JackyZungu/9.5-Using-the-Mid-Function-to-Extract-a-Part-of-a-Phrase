Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim myPhrase As String
        myPhrase = InputBox("Enter your phrase")

        lbPhrase.Text = myPhrase
        lbExtract.Text = Mid(myPhrase, 2, 6)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
