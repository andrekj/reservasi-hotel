Imports System.Data.OleDb
Imports Hotel

Public Class ClsCtlReservasi : Implements InfProses
    Dim SQL As String
    Function idBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kd_reservasi,4))from reservasi", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "R" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekResvDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(kd_reservasi) from reservasi where kd_reservasi ='" & kunci & "' ", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from reservasi " & " where kd_reservasi ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntReservasi
        data = Ob
        CMD = New OleDbCommand("insert reservasi values('" & data.idRes_Resv & "', '" & data.id_tamu_Resv & "' ,'K0001','" & data.tglchekin_Resv & "','" _
                               & data.tglchekout_Resv & "',default, '" & data.tot_Resv & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from tampil", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Table_Reservasi")
            Dim grid As New DataView(DTS.Tables("Table_Reservasi"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntReservasi
        data = Ob
        CMD = New OleDbCommand("update reservasi set status='" & data.statusReservasi _
                               & "' where kd_reservasi ='" & data.idRes_Resv & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    'd.karyawan kd tamu,tgl cekin,tgl cekout,total
    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntReservasi, ByVal _item As List(Of ClsEntDetail_Res)) As OleDbCommand
        Dim IDP As String
        IDP = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "SP_INSERTRESV '" _
                & .id_tamu_Resv & "','" & .id_kar_Resv & "','" & .tglchekin_Resv _
                & "','" & .tglchekout_Resv & "','Unconfirmed', " & .tot_Resv

            MsgBox(SQL)
            Try
                DTA = New OleDbDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_ID_RESERVASI")
                IDP = DTS.Tables("TABEL_ID_RESERVASI").Rows(0)(0).ToString
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into Detail_Reservasi values ('" _
                    & IDP & "','" & .idKamar_Res _
                    & "'," & .harga_perkamarDet_Res & ")"

                CMD = New OleDbCommand(SQL, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", TUTUPKONEKSI)
                MsgBox(SQL)
            End With
        Next
        Return CMD
    End Function
End Class

