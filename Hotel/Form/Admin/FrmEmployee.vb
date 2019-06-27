Public Class FrmEmployee
    'o=no proses, 1= insert new data , 2= update data 
    Dim modeproses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambah.Enabled = st
        BtnUbah.Enabled = st
        BtnHapus.Enabled = st
        BtnSimpan.Enabled = Not st
        BtnBatal.Enabled = Not st


        GroupBoxkary.Enabled = Not st

        TxtCari.Enabled = st
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolKaryawan.tampilData.ToTable
        DGKaryawan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKaryawan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKaryawan.CurrentCell = DGKaryawan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolKaryawan.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKaryawan.DataSource = DTGrid
            DGKaryawan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKaryawan.CurrentCell = DGKaryawan.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolKaryawan.cekKaryawanDireferensi(TxtIdkaryawan.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus karyawan " & TxtIdkaryawan.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKaryawan.deleteData(TxtIdkaryawan.Text)
        End If
        Call RefreshGrid()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        AturButton(False)
        modeproses = 1
        TxtIdkaryawan.Text = KontrolKaryawan.idBaru
        'random()
        TxtPass.Text = ""
        TxtNama.Text = ""
        TxtTelpon.Text = ""
        TxtAlamat.Text = ""
        TxtNama.Focus()
    End Sub
    Private Sub FrmKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
        Call RefreshGrid()

        GroupBoxkary.Enabled = False
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKaryawan.Rows(br)
                TxtIdkaryawan.Text = .Cells(0).Value.ToString
                TxtNama.Text = .Cells(1).Value.ToString
                TxtPass.Text = .Cells(2).Value.ToString
                TxtTelpon.Text = .Cells(3).Value.ToString
                TxtAlamat.Text = .Cells(4).Value.ToString
            End With
        End If
        LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGKaryawan.RowCount - 1 & " data "

    End Sub
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        AturButton(False)
        TxtIdkaryawan.Focus()
        'jika random() dipakai
        TxtPass.Enabled = True
        '=====================
        modeproses = 2
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call RefreshGrid()
        AturButton(True)
        'jika random() dipakai
        TxtPass.Enabled = False
        '=====================
        modeproses = 0
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasKaryawan
            .kdKaryawan = TxtIdkaryawan.Text
            .namaKaryawan = TxtNama.Text
            .passKaryawan = TxtPass.Text
            .telponKaryawan = TxtTelpon.Text
            .alamatKaryawan = TxtAlamat.Text
        End With

        If modeproses = 1 Then
            KontrolKaryawan.InsertData(EntitasKaryawan)
        ElseIf modeproses = 2 Then
            KontrolKaryawan.updateData(EntitasKaryawan)
        End If
        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Info")
        Call RefreshGrid()
        modeproses = 0
    End Sub

    'bisa dipakai atau tidak
    'dipakai => set enable = false di properties
    Private Sub random()
        Dim s As String = "abcde"
        Dim r As New Random
        Const panjang As Integer = 10
        Dim passwordChars() As Char = New Char(panjang - 1) {}
        Dim charIndex As Integer

        For i As Integer = 0 To panjang - 1
            charIndex = r.Next(s.Length)
            passwordChars(i) = s(charIndex)
        Next

        Dim password As New String(passwordChars)
        TxtPass.Text = password
    End Sub



    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim Home As New FrmHome
        Home.Show()
        Hide()
    End Sub


    Private Sub DGKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKaryawan.CellClick
        If modeproses = 0 Then
            baris = e.RowIndex
            DGKaryawan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        CREmployee.Show()
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
End Class