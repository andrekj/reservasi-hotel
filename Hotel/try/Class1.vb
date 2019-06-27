Imports System.Data.OleDb
Imports Hotel
Public Class Class1
#Region "oot"

    Public Function isiTipe(tipe As ComboBox) As Boolean
        Try
            CMD = New OleDbCommand("select DISTINCT nama_tipe from kamar order by nama_kamar desc", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()

            Do While DTR.Read
                tipe.Items.Add(DTR.Item(0))
            Loop
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function isiKamar(tipe As String, kamar As ComboBox) As Boolean
        Try
            CMD = New OleDbCommand("select DISTINCT kd_kamar from kd_kamar where nama_kamar = '" & tipe & "' and tersedia = 'y'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()
            Do While DTR.Read
                kamar.Items.Add(DTR.Item(0))
            Loop
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Function
#End Region

#Region "update"
    Public Function updatekeKosong(no_kamar As String) As OleDbCommand
        Dim data As New ClsEntKamar
        CMD = New OleDbCommand("update kamar set tersedia ='N' where kd_kamar ='" & no_kamar & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updatekeAda(no_kamar As String) As OleDbCommand
        Dim data As New ClsEntKamar
        CMD = New OleDbCommand("update kamar set tersedia ='Y' where kd_kamar ='" & no_kamar & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    '"select k.kd_kamar,  k.nama_kamar,t.nama_tipe,k.harga_kamar,k.fasilitas from kamar k join tipe_kamar t on k.kd_tipe = t.kd_tipe where tersedia = 'y'", BUKAKONEKSI)
    Public Function tampilRooms1(pilih As DataGridViewCheckBoxColumn) As DataView
        Try
            DTA = New OleDbDataAdapter("select k.kd_kamar,  k.nama_kamar,t.nama_tipe,k.harga_kamar,k.fasilitas from kamar k join tipe_kamar t on k.kd_tipe = t.kd_tipe where tersedia = 'y'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Table_RoomManagement")
            Dim grid As New DataView(DTS.Tables("Table_RoomManagement"))
            Do While DTR.Read
                For tersedia = 0 To DTR.Item(0)
                    'pilih
                Next
            Loop
            Return grid
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function
    'OPTIONAL
    Public Function inserttamu(id_tamu As String) As OleDbCommand
        Dim data As New ClsEntReservasi

        CMD = New OleDbCommand("update reservasi set kd_tamu='" & id_tamu & "' where kd_reservasi ='" & data.idRes_Resv & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function tampilKamar(no_kamar As String, TxtHarga As TextBox, TxtKelas As TextBox, TxtFasilitas As TextBox) As OleDbCommand
        CMD = New OleDbCommand("SELECT * FROM tipe_kamar WHERE kd_tipe ='" & no_kamar & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader()
        DTR.Read()

        If DTR.HasRows Then
            TxtHarga.Text = DTR("harga_kamar")
            TxtKelas.Text = DTR("kelas_kamar")
            TxtFasilitas.Text = DTR("fasilitas")

        End If
        Return CMD

    End Function

#End Region
End Class
