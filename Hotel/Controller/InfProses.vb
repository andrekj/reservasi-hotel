Imports System.Data.OleDb
Imports Hotel
Public Interface InfProses

    Function InsertData(Ob As Object) As OleDbCommand
    Function updateData(Ob As Object) As OleDbCommand
    Function deleteData(kunci As String) As OleDbCommand
    Function tampilData() As DataView
    Function cariData(kunci As String) As DataView
End Interface
