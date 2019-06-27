Public Class FrmHome
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Reservation As New FrmReservation
        Reservation.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Checkin As New FrmCheckin
        Checkin.Show()
        Hide()
    End Sub



    Private Sub btnBILL_Click(sender As Object, e As EventArgs) Handles btnBILL.Click
        Dim Bill As New FrmBill
        Bill.Show()
        Hide()
    End Sub

    Private Sub btnKAR_Click(sender As Object, e As EventArgs) Handles btnKAR.Click
        Dim Karyawan As New FrmEmployee
        Karyawan.Show()
        Hide()
    End Sub

    Private Sub btnTAMU_Click(sender As Object, e As EventArgs) Handles btnTAMU.Click
        Dim Tamu As New FrmGuest
        Tamu.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim RoomManagement As New FrmRoomManagement
        RoomManagement.Show()
        Hide()
    End Sub
End Class