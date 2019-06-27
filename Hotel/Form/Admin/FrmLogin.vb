Imports System.Data.OleDb

Public Class FrmLogin
    Dim kesempatan As Integer = 0

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLoginAd.Click
        If TxtUname.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Username and Password must be inserted", MsgBoxStyle.Critical, "Attention")
        Else
            Dim status As Boolean
            status = KontrolKaryawan.loginUser(TxtUname.Text, TxtPass.Text)
            If status Then
                MsgBox("Login Success", MsgBoxStyle.Information, "Info")
                FrmHome.Show()
                Me.Hide()

            Else
                TxtUname.Text = ""
                TxtPass.Text = ""
                TxtUname.Focus()
                kesempatan += 1
                If kesempatan >= 3 Then
                    MsgBox("Sorry !, you have been wrong " & kesempatan & " time!", MsgBoxStyle.Information, "Login Failed")
                    Me.Close()
                Else
                    MsgBox("Wrong Username and Password ", MsgBoxStyle.Exclamation, "Attention")
                End If
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUname.Focus()
        CenterToScreen()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim Checkin As New FrmCheckin
        Checkin.Show()
        Hide()
    End Sub

    Private Sub BtnLoginCu_Click(sender As Object, e As EventArgs) Handles BtnLoginCu.Click
        If TxtUname.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Username and Password must be inserted", MsgBoxStyle.Critical, "Attention")
        Else
            Dim status As Boolean
            FrmReview.TxtUnameR.Text = TxtUname.Text
            status = KontrolKaryawan.loginUser(TxtUname.Text, TxtPass.Text)
            If status Then
                MsgBox("Login Success", MsgBoxStyle.Information, "Info")
                FrmCheckin.Show()
                Me.Hide()
            Else
                TxtUname.Text = ""
                TxtPass.Text = ""
                TxtUname.Focus()
                kesempatan += 1
                If kesempatan >= 3 Then
                    MsgBox("Sorry !, you have been wrong " & kesempatan & " time!", MsgBoxStyle.Information, "Login Failed")
                    Me.Close()
                Else
                    MsgBox("Wrong Username and Password ", MsgBoxStyle.Exclamation, "Attention")
                End If
            End If
        End If
    End Sub


End Class
