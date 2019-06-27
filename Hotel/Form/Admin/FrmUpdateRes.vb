Public Class FrmUpdateRes
    Dim modeProses As Integer


    Private Sub UpdateRes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPCheckin.Enabled = False
        DTPCheckout.Enabled = False
        CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With EntitasReservasi
            .idRes_Resv = txtKd_reservasi.Text
            .statusReservasi = CmbStatus.Text
        End With
        CmbStatus.Focus()
        modeProses = 1

        If modeProses = 1 Then
            KontrolReservasi.updateData(EntitasReservasi)
        End If
        MsgBox("Data Telah Terupdate", MsgBoxStyle.Information, "Info")
        Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmReservation.R()
        FrmReservation.Show()
        Hide()
    End Sub
End Class