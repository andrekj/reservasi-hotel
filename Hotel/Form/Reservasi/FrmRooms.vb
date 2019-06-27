Public Class FrmRooms
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolKamar.tampilRooms.ToTable
        LVCariMenu.Items.Clear()
        Dim strItem(4) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString
                strItem(4) = DTGrid.Rows(i).Item(4).ToString

                LVCariMenu.Items.Add(New ListViewItem(strItem))
            Next
        End If
    End Sub
    Sub BuattabelCari()
        LVCariMenu.Columns.Add("ID Room", 100, HorizontalAlignment.Center)
        LVCariMenu.Columns.Add("Name", 120, HorizontalAlignment.Center)
        LVCariMenu.Columns.Add("Type", 120, HorizontalAlignment.Center)
        LVCariMenu.Columns.Add("Price", 120, HorizontalAlignment.Center)
        LVCariMenu.Columns.Add("Facility", 120, HorizontalAlignment.Center)
        LVCariMenu.View = View.Details
        LVCariMenu.GridLines = True
        LVCariMenu.FullRowSelect = True
    End Sub
    Sub JumlahsubTotal()
        Dim jumHarga As Integer = 0
        For baris As Integer = 0 To FrmReview.LVMenu.Items.Count - 1
            jumHarga = jumHarga + FrmReview.LVMenu.Items(baris).SubItems(3).Text
        Next
        FrmReview.lblRTotal.Text = jumHarga
        FrmReview.lblRTotal.Text = Format(jumHarga, "###,###,###")
    End Sub
    Sub bersih()
        TxtIDMenu.Text = ""
        TxtNamaMenu.Text = ""
        TxtTipe.Text = ""
        TxtHargaMenu.Text = ""
    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KontrolKamar.tersediaPD(txtStokPD)
        KontrolKamar.tersediaPS(txtStokPS)
        KontrolKamar.tersediaDD(txtStokDD)
        KontrolKamar.tersediaDS(txtStokDS)
        RefreshGrid()
        BuattabelCari()
        Panel1.BackColor = Color.FromArgb(100, 99, 110, 114)
        btnCari.BackColor = Color.FromArgb(200, 116, 153, 45)
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolKamar.cariData(txtCari.Text).ToTable
        LVCariMenu.Items.Clear()
        Dim strItem(4) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString
                strItem(4) = DTGrid.Rows(i).Item(4).ToString

                LVCariMenu.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub LVCariMenu_DoubleClick(sender As Object, e As EventArgs) Handles LVCariMenu.DoubleClick

        TxtIDMenu.Text = LVCariMenu.SelectedItems(0).SubItems(0).Text
        TxtNamaMenu.Text = LVCariMenu.SelectedItems(0).SubItems(1).Text
        TxtTipe.Text = LVCariMenu.SelectedItems(0).SubItems(2).Text
        TxtHargaMenu.Text = LVCariMenu.SelectedItems(0).SubItems(3).Text


    End Sub

    Private Sub BtnTambahMenu_Click(sender As Object, e As EventArgs) Handles BtnTambahMenu.Click
        If TxtIDMenu.Text = "" Then
            MsgBox("Please Choose Your Room(s)")
            Exit Sub
        End If

        Dim strMenu(4) As String
        strMenu(0) = TxtIDMenu.Text
        strMenu(1) = TxtNamaMenu.Text
        strMenu(2) = TxtTipe.Text
        strMenu(3) = TxtHargaMenu.Text

        FrmReview.LVMenu.Items.Add(New ListViewItem(strMenu))
        LVCariMenu.SelectedItems(0).Remove()
        JumlahsubTotal()

        MsgBox("Room added", MsgBoxStyle.Information, "Info")
        bersih()
    End Sub

    Private Sub BtnHapusMenu_Click(sender As Object, e As EventArgs)
        bersih()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FrmCheckin.Show()
        Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        FrmInformasi.TxtKdTamu.Text = FrmReview.TxtKdTamuR.Text
        FrmInformasi.TxtFristNm.Text = FrmReview.TxtFristNmR.Text
        FrmInformasi.TxtLastNm.Text = FrmReview.TxtLastNmR.Text
        FrmInformasi.TxtIdTamu.Text = FrmReview.TxtIdTamuR.Text

        FrmInformasi.TxtEmail.Text = FrmReview.TxtEmailR.Text
        FrmInformasi.TxtNoTelp.Text = FrmReview.TxtNoTelpR.Text
        FrmInformasi.TxtSpecialReq.Text = FrmReview.TxtSpecialReqR.Text

        If FrmReview.lblRTotal.Text = "" Then
            MsgBox("Please Choose Your Room(s)")
            Exit Sub
        Else
            Dim Informasi1 As New FrmInformasi
            FrmInformasi.Show()
            Hide()
        End If
    End Sub




End Class