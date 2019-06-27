Public Class FrmReview
    Dim modeproses As Integer
    Sub Buattabel()
        LVMenu.Columns.Add("ID Room", 80, HorizontalAlignment.Center)
        LVMenu.Columns.Add("Name", 80, HorizontalAlignment.Center)
        LVMenu.Columns.Add("Type", 80, HorizontalAlignment.Center)
        LVMenu.Columns.Add("Price/Night", 80, HorizontalAlignment.Center)

        LVMenu.View = View.Details
        LVMenu.GridLines = True
        LVMenu.FullRowSelect = True
    End Sub
    Sub JumlahTotal()
        Dim jumtotHarga As Integer = 0
        Dim Total As String = lblRTotal.Text
        Dim Hari As String = FrmCheckin.txthari.Text

        Dim valueTotal As Integer = CInt(Total)
        Dim valueHari As Integer = CInt(Hari)

        jumtotHarga = jumtotHarga + valueTotal * valueHari

        lblTotal.Text = jumtotHarga
        lblTotal.Text = Format(jumtotHarga, "###.###.###")
        FrmPayment.lblTotal.Text = Format(jumtotHarga, "###.###.###")
    End Sub
    Sub bersih()

    End Sub


    Private Sub Review_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = Color.FromArgb(100, 99, 110, 114)
        BtnAccept.BackColor = Color.FromArgb(200, 116, 153, 45)
        JumlahTotal()
        Buattabel()
        CenterToScreen()
    End Sub

    Private Sub BtnHapusMenu_Click(sender As Object, e As EventArgs) Handles BtnHapusMenu.Click
        LVMenu.SelectedItems(0).Remove()
        FrmRooms.JumlahsubTotal()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        FrmPayment.lblTotal.Text = lblTotal.Text
        FrmPayment.TxtTransaksiP.Text = TxtTransaksiR.Text
        FrmPayment.TxtKdTamuP.Text = TxtKdTamuR.Text

        Dim Payment1 As New FrmPayment
        FrmPayment.Show()
        Hide()
    End Sub

    Private Sub btnBACK_Click(sender As Object, e As EventArgs) Handles btnBACK.Click
        FrmInformasi.TxtKdTamu.Text = TxtKdTamuR.Text
        FrmInformasi.TxtFristNm.Text = TxtFristNmR.Text
        FrmInformasi.TxtLastNm.Text = TxtLastNmR.Text
        FrmInformasi.TxtIdTamu.Text = TxtIdTamuR.Text

        FrmInformasi.TxtEmail.Text = TxtEmailR.Text
        FrmInformasi.TxtNoTelp.Text = TxtNoTelpR.Text
        FrmInformasi.TxtSpecialReq.Text = TxtSpecialReqR.Text

        Dim Informasi1 As New FrmInformasi
        FrmInformasi.Show()
        Hide()
    End Sub

    Private Sub BtnAccept_Click_1(sender As Object, e As EventArgs) Handles BtnAccept.Click
        If lblRTotal.Text = "" Then
            MsgBox("Please Choose Your Room(s)")
            Exit Sub
        End If

        'simpan data tamu
        With EntitasTamu
            .idTamu = TxtKdTamuR.Text
            .first_nameTamu = TxtFristNmR.Text
            .last_nameTamu = TxtLastNmR.Text
            .identitasTamu = TxtIdTamuR.Text
            .emailTamu = TxtEmailR.Text
            .telponTamu = TxtNoTelpR.Text
            .spesial_requestTamu = TxtSpecialReqR.Text
        End With
        KontrolTamu.InsertData(EntitasTamu)

        'simpan data reservasi
        'simpan data kamar > 1
        Dim lsdetail As New List(Of ClsEntDetail_Res)()
        With EntitasReservasi
            .idRes_Resv = TxtTransaksiR.Text
            .id_tamu_Resv = TxtKdTamuR.Text
            .id_kar_Resv = TxtUnameR.Text
            .tglchekin_Resv = TxtCInR.Text
            .tglchekout_Resv = TxtCOutR.Text
            .tot_Resv = lblTotal.Text
        End With

        For i = 0 To LVMenu.Items.Count - 1
            EntitasDetail_Res = New ClsEntDetail_Res
            With LVMenu.Items(i)
                EntitasDetail_Res.idKamar_Res = .SubItems(0).Text
                EntitasDetail_Res.harga_perkamarDet_Res = .SubItems(3).Text
            End With
            lsdetail.Add(EntitasDetail_Res)
        Next i

        KontrolReservasi.SIMPAN_DATA(EntitasReservasi, lsdetail)

        MsgBox("Data has been saved", MsgBoxStyle.Information, "Info")
        modeproses = 0
    End Sub
End Class