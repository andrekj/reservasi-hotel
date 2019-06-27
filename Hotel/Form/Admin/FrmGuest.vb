Public Class FrmGuest
    'o=no proses, 1= insert new data , 2= update data 
    Dim modeproses As Integer
    Dim baris As Integer
    Private Sub FrmGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Call RefreshGrid()
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGTamu.Rows(br)
                TxtIdtamu.Text = .Cells(0).Value.ToString
            End With
        End If
        LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGTamu.RowCount - 1 & " data "

    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolTamu.tampilData.ToTable
        DGTamu.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTamu.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTamu.CurrentCell = DGTamu.Item(1, baris)
            IsiBox(baris)

        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolTamu.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTamu.DataSource = DTGrid
            DGTamu.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTamu.CurrentCell = DGTamu.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub
    Private Sub TxtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCari.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            If TxtCari.Text = "" Then
                Call RefreshGrid()
            Else
                Call TampilCari(TxtCari.Text)
                TxtCari.Focus()
            End If
        End If
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim Home As New FrmHome
        Home.Show()
        Hide()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolTamu.cekTamuDireferensi(TxtIdtamu.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus tamu " & TxtIdtamu.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolTamu.deleteData(TxtIdtamu.Text)
        End If
        Call RefreshGrid()
    End Sub



    Private Sub DGTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTamu.CellClick
        If modeproses = 0 Then
            baris = e.RowIndex
            DGTamu.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        CRGuest.Show()

    End Sub


End Class