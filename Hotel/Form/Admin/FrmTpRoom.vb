Public Class FrmTpRoom
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        btnTmbh.Enabled = st
        BtnHapus.Enabled = st
        BtnSimpan.Enabled = Not st


    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGTipe.Rows(br)
                txtKdTipe.Text = .Cells(0).Value.ToString
                txtNamaTipe.Text = .Cells(1).Value.ToString
            End With
            'LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGKategori.RowCount - 1 & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolTipeKamar.tampilData.ToTable
        DGTipe.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTipe.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTipe.CurrentCell = DGTipe.Item(1, baris)
            '  AturButton(True)
            IsiBox(baris)
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RoomManagement As New FrmRoomManagement
        RoomManagement.R()
        RoomManagement.Show()
        Hide()
    End Sub

    Private Sub AddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        'txtKdTipe.Text = KontrolTipeKamar.idBaru()
        CenterToScreen()
    End Sub

    Private Sub btnTmbh_Click(sender As Object, e As EventArgs) Handles btnTmbh.Click
        AturButton(False)
        modeProses = 1

        txtKdTipe.Text = ""
        txtNamaTipe.Text = ""

        txtKdTipe.Text = KontrolTipeKamar.idBaru()

        txtNamaTipe.Focus()

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus " & txtKdTipe.Text & "-" & txtNamaTipe.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolTipeKamar.deleteData(txtKdTipe.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasTipeKamar
            .idTipeKamar = txtKdTipe.Text
            .nama_tipeKamar = txtNamaTipe.Text

        End With
        KontrolTipeKamar.InsertData(EntitasTipeKamar)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub


    Private Sub DGTipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTipe.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGTipe.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
End Class