Imports System.Data.OleDb

Public Class FrmRoomManagement
    Dim modeproses As Integer
    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolKamar.tampilData.ToTable
        DGKamar.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKamar.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKamar.CurrentCell = DGKamar.Item(1, baris)

        End If
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKamar.Rows(br)
                TxtKdKamar.Text = .Cells(0).Value.ToString
            End With
        End If
        LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGKamar.RowCount - 1 & " data "

    End Sub
    Public Sub R()
        RefreshGrid()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Home As New FrmHome
        Home.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FrmAddRoom As New FrmAddRoom
        FrmAddRoom.Show()
        Hide()

    End Sub



    Private Sub RoomManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshGrid()
        CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UpdateRoom As New FrmUpdateRoom
        UpdateRoom.TxtKdKamar.Text = DGKamar.CurrentRow.Cells(0).Value.ToString
        UpdateRoom.TxtNama_Kmr.Text = DGKamar.CurrentRow.Cells(2).Value.ToString
        UpdateRoom.TxtKdTipe.Text = DGKamar.CurrentRow.Cells(1).Value.ToString
        UpdateRoom.TxtTipeKmr.Text = DGKamar.CurrentRow.Cells(3).Value.ToString
        UpdateRoom.txtHarga_Kmr.Text = DGKamar.CurrentRow.Cells(4).Value.ToString
        UpdateRoom.txtFasilitas.Text = DGKamar.CurrentRow.Cells(5).Value.ToString
        UpdateRoom.CmbTersedia.Text = DGKamar.CurrentRow.Cells(6).Value.ToString
        UpdateRoom.Show()
        Hide()
    End Sub

    Private Sub btnTmbhTp_Click(sender As Object, e As EventArgs) Handles btnTmbhTp.Click
        Dim AddTipeKamar1 As New FrmTpRoom
        AddTipeKamar1.Show()
        Hide()
    End Sub



    Private Sub DGKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKamar.CellClick
        If modeproses = 0 Then
            baris = e.RowIndex
            DGKamar.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnHps_Click(sender As Object, e As EventArgs) Handles btnHps.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolKamar.cekKamarDireferensi(TxtKdKamar.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus kamar " & TxtKdKamar.Text & " ?",
                         MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKamar.deleteData(TxtKdKamar.Text)
        End If
        Call RefreshGrid()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        CRRooms.Show()

    End Sub
End Class