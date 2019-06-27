Imports System.Data.OleDb
Public Class FrmAddRoom

    Dim modeproses As Integer
    Private Sub FrmAddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtKdKamar.Text = KontrolKamar.idBaru()
        CenterToScreen()
        Call TampilKategori()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RoomManagement As New FrmRoomManagement
        RoomManagement.R()
        RoomManagement.Show()
        Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub CmbTipe_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CmbTipe.SelectedIndexChanged
        CMD = New OleDbCommand("select * from tipe_kamar where kd_tipe='" & CmbTipe.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            TxtNamaTp.Text = DTR.Item("nama_tipe")
        Else
            MsgBox("Kode Kategori tidak terdaftar")
        End If
    End Sub
    Sub TampilKategori()
        CMD = New OleDbCommand("select kd_tipe from tipe_kamar", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        CmbTipe.Items.Clear()
        Do While DTR.Read
            CmbTipe.Items.Add(DTR.Item("kd_tipe"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub btnTmbh_Click(sender As Object, e As EventArgs) Handles btnTmbh.Click
        With EntitasKamar
            .idKamar = TxtKdKamar.Text
            .id_tipeKamar = CmbTipe.Text
            .namaKamar = TxtNama.Text
            .hargaKamar = TxtHarga.Text
            .fasilitasKamar = TxtFasilitas.Text
            .tersediaKamar = CmbTersedia.Text

        End With
        modeproses = 1

        If modeproses = 1 Then
            KontrolKamar.InsertData(EntitasKamar)
        End If
        MsgBox("Berhasil Menambahkan Kamar", MsgBoxStyle.Information, "Info")

    End Sub
End Class