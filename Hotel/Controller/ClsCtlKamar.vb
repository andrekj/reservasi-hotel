Imports System.Data.OleDb
Imports Hotel

Public Class ClsCtlKamar : Implements InfProses
    Function idBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kd_kamar,3))from kamar", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KM" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekKamarDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(kd_kamar) from kamar where kd_kamar='" & kunci & "' and tersedia != 'Y'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("select k.kd_kamar,  k.nama_kamar,t.nama_tipe,k.harga_kamar,k.fasilitas from kamar k join tipe_kamar t on k.kd_tipe = t.kd_tipe where tersedia = 'y' and nama_kamar " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Menu")
            Dim grid As New DataView(DTS.Tables("Cari_Menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from kamar where kd_kamar ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKamar
        data = Ob
        CMD = New OleDbCommand("insert into kamar values('" & data.idKamar & "','" _
                               & data.id_tipeKamar & "','" & data.namaKamar & "','" _
                               & data.hargaKamar & "','" & data.fasilitasKamar & "','" _
                               & data.tersediaKamar & "', NULL)", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select k.kd_kamar, k.kd_tipe, k.nama_kamar,t.nama_tipe,k.harga_kamar,k.fasilitas,k.tersedia from kamar k join tipe_kamar t on k.kd_tipe = t.kd_tipe", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Table_RoomManagement")
            Dim grid As New DataView(DTS.Tables("Table_RoomManagement"))
            Return grid
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKamar
        data = Ob
        CMD = New OleDbCommand("update kamar set harga_kamar='" & data.hargaKamar & "', fasilitas='" & data.fasilitasKamar & "', tersedia ='" & data.tersediaKamar & "' where kd_kamar ='" & data.idKamar & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

#Region "tersedia"
    'stock tersedia ComboBox , TextBox, NumericUpDown
    Public Function tersediaPD(txtKamar As Label) As Boolean
        Try
            CMD = New OleDbCommand("SELECT COUNT (TERSEDIA)FROM KAMAR WHERE TERSEDIA = 'Y' AND NAMA_KAMAR = 'PRESIDENTIAL' AND KD_TIPE='TP001'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()
            Do While DTR.Read
                For tersedia = 0 To DTR.Item(0)
                    txtKamar.Text = tersedia
                Next
            Loop
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function tersediaPS(txtKamar As Label) As Boolean
        Try
            CMD = New OleDbCommand("SELECT COUNT (TERSEDIA)FROM KAMAR WHERE TERSEDIA = 'Y' AND NAMA_KAMAR = 'PRESIDENTIAL' AND KD_TIPE='TP002'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()
            Do While DTR.Read
                For tersedia = 0 To DTR.Item(0)
                    txtKamar.Text = tersedia
                Next
            Loop
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function tersediaDD(txtKamar As Label) As Boolean
        Try
            CMD = New OleDbCommand("SELECT COUNT (TERSEDIA)FROM KAMAR WHERE TERSEDIA = 'Y' AND NAMA_KAMAR = 'DELUXE' AND KD_TIPE='TP001'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()
            Do While DTR.Read
                For tersedia = 0 To DTR.Item(0)
                    txtKamar.Text = tersedia
                Next
            Loop
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function tersediaDS(txtKamar As Label) As Boolean
        Try
            CMD = New OleDbCommand("SELECT COUNT (TERSEDIA)FROM KAMAR WHERE TERSEDIA = 'Y' AND NAMA_KAMAR = 'DELUXE' AND KD_TIPE='TP002'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()
            Do While DTR.Read
                For tersedia = 0 To DTR.Item(0)
                    txtKamar.Text = tersedia
                Next
            Loop
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
    Public Function tampilRooms() As DataView
        Try
            DTA = New OleDbDataAdapter("select k.kd_kamar,  k.nama_kamar,t.nama_tipe,k.harga_kamar,k.fasilitas from kamar k join tipe_kamar t on k.kd_tipe = t.kd_tipe where tersedia = 'Y'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Table_RoomManagement")
            Dim grid As New DataView(DTS.Tables("Table_RoomManagement"))

            Return grid
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

End Class
