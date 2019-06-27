Imports System.Data.OleDb

Public Class Room
#Region "select harga, fasilitas"
    Sub TampilDataPD()
        CMD = New OleDbCommand("select * from kamar where kd_tipe='TP001' and nama_kamar='Presidential'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            lblFasPD.Text = DTR.Item("fasilitas")
            txtHargaPD.Text = DTR.Item("harga_kamar")
        End If
    End Sub
    Sub TampilDataPS()
        CMD = New OleDbCommand("select * from kamar where kd_tipe='TP002' and nama_kamar='Presidential'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            lblFasPS.Text = DTR.Item("fasilitas")
            txtHargaPS.Text = DTR.Item("harga_kamar")
        End If
    End Sub
    Sub TampilDataDD()
        CMD = New OleDbCommand("select * from kamar where kd_tipe='TP001' and nama_kamar='Deluxe'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            lblFasDD.Text = DTR.Item("fasilitas")
            txtHargaDD.Text = DTR.Item("harga_kamar")
        End If
    End Sub
    Sub TampilDataDS()
        CMD = New OleDbCommand("select * from kamar where kd_tipe='TP002' and nama_kamar='Deluxe'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            lblFasDS.Text = DTR.Item("fasilitas")
            txtHargaDS.Text = DTR.Item("harga_kamar")
        End If
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Checkin As New FrmCheckin
        Checkin.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Informasi As New FrmInformasi
        Informasi.Show()
        Hide()
    End Sub

    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        'stock tersedia ComboBox , TextBox, NumericUpDown
        'KontrolKamar.tersediaPD(txtStokPD)
        ' KontrolKamar.tersediaPS(txtStokPS)
        'KontrolKamar.tersediaDD(txtStokDD)
        'KontrolKamar.tersediaDS(txtStokDS)



        TampilDataPD()
        TampilDataPS()
        TampilDataDD()
        TampilDataDS()
    End Sub

    Private Sub BtnTbPD_Click(sender As Object, e As EventArgs) Handles BtnTbPD.Click

        'BtnTbPD.Enabled = True
        'BtnTbPS.Enabled = False
        'BtnTbDD.Enabled = False
        'BtnTbDS.Enabled = False

        'udwPD.Value.ToString()
        Dim strMenu(3) As String
        strMenu(0) = txtPRESI.Text
        strMenu(1) = udwPD.Value.ToString()
        strMenu(2) = txtHargaPD.Text * udwPD.Value.ToString()

        'Review.lvROOM.Items.Add(New ListViewItem(strMenu))
        MsgBox("Kamar telah ditambah", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub BtnTbPS_Click(sender As Object, e As EventArgs) Handles BtnTbPS.Click
        'BtnTbPD.Enabled = False
        'BtnTbPS.Enabled = True
        'BtnTbDD.Enabled = False
        'BtnTbDS.Enabled = False

        Dim strMenu(3) As String
        strMenu(0) = txtPRESI.Text
        strMenu(1) = udwPS.Value.ToString()
        strMenu(2) = txtHargaPS.Text * udwPS.Value.ToString()

        'Review.lvROOM.Items.Add(New ListViewItem(strMenu))
        MsgBox("Kamar telah ditambah", MsgBoxStyle.Information, "Info")
    End Sub
End Class