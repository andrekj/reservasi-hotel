
Public Class FrmInformasi
    Dim modeproses As Integer
    Dim baris As Integer
    Private Sub Informasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 99, 110, 114)
        BtnRefresh.BackColor = Color.FromArgb(200, 116, 153, 45)

        CenterToScreen()
        TxtKdTamu.Text = KontrolTamu.idBaru

    End Sub

    Sub bersih()
        TxtFristNm.Text = ""
        TxtLastNm.Text = ""
        TxtIdTamu.Text = ""
        TxtEmail.Text = ""
        TxtNoTelp.Text = ""
        TxtSpecialReq.Text = ""

        modeproses = 1
        TxtFristNm.Focus()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSaveNext.Click
        If TxtIdTamu.Text = "" Then
            MsgBox("Please Insert Your Identity Information")
            Exit Sub
        End If



        FrmReview.TxtKdTamuR.Text = TxtKdTamu.Text
        FrmReview.TxtFristNmR.Text = TxtFristNm.Text
        FrmReview.TxtLastNmR.Text = TxtLastNm.Text
        FrmReview.TxtIdTamuR.Text = TxtIdTamu.Text

        FrmReview.TxtEmailR.Text = TxtEmail.Text
        FrmReview.TxtNoTelpR.Text = TxtNoTelp.Text
        FrmReview.TxtSpecialReqR.Text = TxtSpecialReq.Text



        Dim Review1 As New FrmReview
        FrmReview.Show()
        Hide()


    End Sub


    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        bersih()
    End Sub

    Private Sub BtnBackBatal_Click(sender As Object, e As EventArgs) Handles BtnBackBatal.Click

        modeproses = 0

        Dim Room As New FrmRooms
        Room.Show()
        Hide()
    End Sub
End Class