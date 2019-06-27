Imports System.Data.OleDb
Public Class FrmCoba

    Sub isicombo()
        Try
            CMD = New OleDbCommand("SELECT COUNT (TERSEDIA)FROM KAMAR WHERE TERSEDIA = 'Y' AND NAMA_KAMAR = 'PRESIDENTIAL' AND KD_TIPE='TP001'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader()
            Do While DTR.Read
                For tersedia = 0 To DTR.Item(0)
                    cbSediaPS.Items.Add(tersedia)
                    updKamar.Maximum = tersedia
                Next
            Loop

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Private Sub FrmCoba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' KontrolKamar.tersediaPD(txtSTOK)
        isicombo()
        updKamar.TabIndex = TextBoxHASIL.TabIndex
    End Sub
End Class