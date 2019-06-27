Public Class FrmThankyou
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Checkin As New FrmCheckin
        Checkin.Show()
        Hide()
    End Sub

    Private Sub Thankyou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 99, 110, 114)
        CenterToScreen()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs)
        CRNota.Show()

    End Sub
End Class