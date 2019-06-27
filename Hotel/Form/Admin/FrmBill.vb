Public Class FrmBill
    Dim modeproses As Integer
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolBill.tampilData.ToTable
        DGBill.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBill.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBill.CurrentCell = DGBill.Item(1, baris)

        End If
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBill.Rows(br)
                txtKDBILL.Text = .Cells(0).Value.ToString
            End With
        End If
        LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGBill.RowCount - 1 & " data "

    End Sub
    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Call RefreshGrid()
    End Sub



    Private Sub DGBill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBill.CellClick
        If modeproses = 0 Then
            baris = e.RowIndex
            DGBill.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus data pembayaran " & txtKDBILL.Text & " ?",
                         MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBill.deleteData(txtKDBILL.Text)
        End If
        Call RefreshGrid()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim Home As New FrmHome
        Home.Show()
        Hide()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        CRBill.show()

    End Sub
End Class