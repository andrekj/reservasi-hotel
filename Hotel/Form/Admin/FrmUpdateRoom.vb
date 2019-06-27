Public Class FrmUpdateRoom
    Dim modeproses As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With EntitasKamar
            .idKamar = TxtKdKamar.Text
            .namaKamar = TxtNama_Kmr.Text
            .id_tipeKamar = TxtTipeKmr.Text
            .hargaKamar = txtHarga_Kmr.Text
            .fasilitasKamar = txtFasilitas.Text
            .tersediaKamar = CmbTersedia.Text
        End With
        CmbTersedia.Focus()
        modeproses = 1

        If modeproses = 1 Then
            KontrolKamar.updateData(EntitasKamar)
        End If
        MsgBox("Data Telah Terupdate", MsgBoxStyle.Information, "Info")
        Refresh()
    End Sub

    Private Sub UpdateRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim RoomManagement As New FrmRoomManagement
        RoomManagement.R()
        RoomManagement.Show()
        Hide()
    End Sub


End Class