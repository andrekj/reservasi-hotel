Public Class FrmReservation
    Dim modeproses As Integer
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolReservasi.tampilData.ToTable
        DGReservasi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGReservasi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGReservasi.CurrentCell = DGReservasi.Item(1, baris)
        End If
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGReservasi.Rows(br)
                TxtKdRes.Text = .Cells(0).Value.ToString
            End With
        End If
        LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGReservasi.RowCount - 1 & " data "

    End Sub
    Public Sub R()
        RefreshGrid()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Home As New FrmHome
        Home.Show()
        Hide()
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUBAH.Click
        Dim UpdateRes As New FrmUpdateRes
        UpdateRes.txtKd_reservasi.Text = DGReservasi.CurrentRow.Cells(0).Value.ToString
        UpdateRes.txtKd_tamu.Text = DGReservasi.CurrentRow.Cells(1).Value.ToString
        UpdateRes.txtKd_kamar.Text = DGReservasi.CurrentRow.Cells(2).Value.ToString
        UpdateRes.DTPCheckin.Text = DGReservasi.CurrentRow.Cells(3).Value.Date
        UpdateRes.DTPCheckout.Text = DGReservasi.CurrentRow.Cells(4).Value.Date
        UpdateRes.txtSpesial_request.Text = DGReservasi.CurrentRow.Cells(5).Value.ToString
        UpdateRes.txtHarga_kamar.Text = DGReservasi.CurrentRow.Cells(6).Value.ToString
        UpdateRes.txtTotal_price.Text = DGReservasi.CurrentRow.Cells(7).Value.ToString
        UpdateRes.CmbStatus.Text = DGReservasi.CurrentRow.Cells(8).Value.ToString
        UpdateRes.Show()
        Hide()
        RefreshGrid()
    End Sub

    Private Sub btnHAPUS_Click(sender As Object, e As EventArgs) Handles btnHAPUS.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolReservasi.cekResvDireferensi(TxtKdRes.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If


        If MsgBox("Apakah Anda yakin akan menghapus reservasi " & TxtKdRes.Text & " ?",
                         MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then

            KontrolReservasi.deleteData(TxtKdRes.Text)
        End If


        Call RefreshGrid()
    End Sub



    Private Sub DGReservasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReservasi.CellClick
        If modeproses = 0 Then
            baris = e.RowIndex
            DGReservasi.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        CRReservation.Show()

    End Sub
End Class