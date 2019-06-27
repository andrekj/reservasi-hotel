Public Class FrmCheckin
    Dim modeproses As Integer


    Private Sub TglCheckin_ValueChanged(sender As Object, e As EventArgs)
        If TglCheckin.Value > TglCheckout.Value Then
            TglCheckin.Value = TglCheckout.Value
        Else
            txthari.Text = DateDiff(DateInterval.Day, CDate(TglCheckin.Text), CDate(TglCheckout.Text))
        End If
    End Sub

    Private Sub TglCheckout_ValueChanged(sender As Object, e As EventArgs) Handles TglCheckout.ValueChanged
        If TglCheckout.Value < TglCheckin.Value Then
            TglCheckout.Value = TglCheckin.Value
        Else
            txthari.Text = DateDiff(DateInterval.Day, CDate(TglCheckin.Text), CDate(TglCheckout.Text))
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Login As New FrmLogin
        Login.Show()
        Hide()
    End Sub



    Private Sub Checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 99, 110, 114)
        TxtTransaksi.Text = KontrolReservasi.idBaru
        CenterToScreen()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSaveNext_Click(sender As Object, e As EventArgs) Handles BtnSaveNext.Click
        If txthari.Text = "" Then
            MsgBox("Please Insert Your Night Count")
            Exit Sub
        End If
        FrmReview.TxtTransaksiR.Text = TxtTransaksi.Text
        FrmReview.TxtCInR.Text = TglCheckin.Value.Date.ToString("yyyy-MM-dd")
        FrmReview.TxtCOutR.Text = TglCheckout.Value.Date.ToString("yyyy-MM-dd")

        FrmReview.lblRNIGHT.Text = txthari.Text
        Dim Room As New FrmRooms
        Room.Show()
        Hide()


    End Sub

    Private Sub FrmCheckin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim widhthform As Integer = Me.Width
        Dim heightform As Integer = Me.Height
        Panel1.Size = New Drawing.Size(widhthform - 140, heightform - 350)
    End Sub
End Class