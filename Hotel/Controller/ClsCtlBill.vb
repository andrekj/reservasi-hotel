Imports System.Data.OleDb
Imports Hotel

Public Class ClsCtlBill : Implements InfProses
        Function idBaru() As String
            Dim baru As String
            Dim kodeakhir As Integer
            Try
            DTA = New OleDbDataAdapter("select max(right(kd_bill,4))from bill", BUKAKONEKSI)
            DTS = New DataSet()
                DTA.Fill(DTS, "max_kode")
                kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "B" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from bill where kd_bill = '" & kunci & "' ", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntBill
        data = Ob
        CMD = New OleDbCommand("insert into bill values('" & data.idbill_bill & "','" _
                               & data.idres_bill & "','" & data.tglbyr_bill & "','" & data.jenisByr_bill & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function


    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from bill", BUKAKONEKSI)

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
        CMD = New OleDbCommand("update bill set kd_reservasi = NULL", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

  
End Class
