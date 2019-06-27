Imports System.Data.OleDb

Public Class FrmPayment
    Sub print()
        If MessageBox.Show("Do you want to print a invoice?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CRNota.Show()
            CRNota.NotaReservation1.RecordSelectionFormula = "{RESERVASI.KD_RESERVASI}='" & TxtTransaksiP.Text & "'"
            CRNota.NotaReservation1.Refresh()
        Else
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 99, 110, 114)
        CenterToScreen()
        TxtKdBillP.Text = KontrolBill.idBaru
        LblTanggal.Text = Format(Now, " yyyy/MM/dd H:m:s")

    End Sub

    Private Sub BtnBNI_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnBCA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnMANDIRI_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnBNI_Click_1(sender As Object, e As EventArgs) Handles BtnBNI.Click
        With EntitasBill
            .idbill_bill = TxtKdBillP.Text
            .idres_bill = TxtTransaksiP.Text
            .tglbyr_bill = LblTanggal.Text
            .jenisByr_bill = "Bank BNI, Jakarta Nomor Rek :  023 827 2088 a.n PT. LongLife"

        End With
        KontrolBill.InsertData(EntitasBill)

        print()
        Dim Thankyou1 As New FrmThankyou
        FrmThankyou.Show()
        Hide()
    End Sub

    Private Sub BtnBCA_Click_1(sender As Object, e As EventArgs) Handles BtnBCA.Click
        With EntitasBill
            .idbill_bill = TxtKdBillP.Text
            .idres_bill = TxtTransaksiP.Text
            .tglbyr_bill = LblTanggal.Text
            .jenisByr_bill = "Bank BCA, Jakarta Nomor Rek :  023 827 2088 a.n PT. LongLife"

        End With
        KontrolBill.InsertData(EntitasBill)
        print()
        Dim Thankyou1 As New FrmThankyou
        FrmThankyou.Show()
        Hide()
    End Sub

    Private Sub BtnMANDIRI_Click_1(sender As Object, e As EventArgs) Handles BtnMANDIRI.Click
        With EntitasBill
            .idbill_bill = TxtKdBillP.Text
            .idres_bill = TxtTransaksiP.Text
            .tglbyr_bill = LblTanggal.Text
            .jenisByr_bill = "Bank MANDIRI, Jakarta Nomor Rek :  023 827 2088 a.n PT. LongLife"

        End With
        KontrolBill.InsertData(EntitasBill)
        print()
        Dim Thankyou1 As New FrmThankyou
        FrmThankyou.Show()
        Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmReview.TxtTransaksiR.Text = TxtTransaksiP.Text
        FrmReview.TxtKdTamuR.Text = TxtKdTamuP.Text
        FrmReview.lblTotal.Text = lblTotal.Text

        Dim Review1 As New FrmReview
        FrmReview.Show()
        Hide()
    End Sub
End Class