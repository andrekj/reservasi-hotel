Imports System.Data.OleDb
Imports Hotel

Public Class ClsCtlKaryawan : Implements InfProses
    Function idBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kd_Karyawan,4))from karyawan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "K" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekKaryawanDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(kd_karyawan) from karyawan where kd_karyawan='" & kunci & "'", BUKAKONEKSI)
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
            DTA = New OleDbDataAdapter("Select * From karyawan Where nama_karyawan Like '%" & kunci & "%'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Karyawan")
            Dim grid As New DataView(DTS.Tables("Cari_Karyawan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from karyawan where kd_karyawan='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKaryawan
        data = Ob
        CMD = New OleDbCommand("insert into karyawan values('" & data.kdKaryawan & "','" _
                               & data.namaKaryawan & "','" & data.passKaryawan & "','" _
                               & data.alamatKaryawan & "','" & data.telponKaryawan & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from karyawan", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Karyawan")
            Dim grid As New DataView(DTS.Tables("Tabel_Karyawan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKaryawan
        data = Ob
        CMD = New OleDbCommand("update karyawan set nama_karyawan='" & data.namaKaryawan _
                               & "',password_karyawan='" & data.passKaryawan & "',no_tlp='" _
                               & data.telponKaryawan & "',alamat_karyawan='" & data.alamatKaryawan _
                               & "' where kd_karyawan ='" & data.kdKaryawan & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function loginUser(uname As String, pass As String) As Boolean
        Dim login As Boolean
        login = False
        Try
            CMD = New OleDbCommand("SELECT * FROM karyawan WHERE kd_karyawan='" & uname & "' AND password_karyawan = '" & pass & "'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()

            If DTR.Read() Then
                'data user yg login

                With EntitasKaryawan
                    .idKaryawanLogin = DTR(0).ToString
                    .namaKaryawanLogin = DTR(1).ToString
                    .passKaryawanLogin = DTR(2).ToString
                    .telponKaryawanLogin = DTR(3).ToString
                    .alamatKaryawanLogin = DTR(4).ToString
                End With

                'data validasi login
                Dim user, pwd As String
                user = DTR(0)
                pwd = DTR(2)
                If uname = user And pass = pwd Then
                    login = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return login
    End Function
    Public Function updateDataLogin(Ob As Object) As OleDbCommand
        Dim data As New ClsEntKaryawan
        data = Ob
        CMD = New OleDbCommand("update karyawan set nama_karyawan='" & data.namaKaryawanLogin _
                               & "',password_karyawan='" & data.passKaryawanLogin & "',no_tlp='" _
                               & data.telponKaryawanLogin & "',alamat_karyawan='" & data.alamatKaryawanLogin _
                               & "' where kd_karyawan ='" & data.idKaryawanLogin & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()

        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function


End Class
