Public Class ClsEntDetail_Res
    Private idKamar As String
    Private idRes As String
    Private harga_perkamar As Integer

    Public Property idKamar_Res() As String
        Get
            Return idKamar
        End Get
        Set(value As String)
            idKamar = value
        End Set
    End Property
    Public Property idDetRes_Res() As String
        Get
            Return idRes
        End Get
        Set(value As String)
            idRes = value
        End Set
    End Property

    Public Property harga_perkamarDet_Res() As Integer
        Get
            Return harga_perkamar
        End Get
        Set(value As Integer)
            harga_perkamar = value
        End Set
    End Property
End Class
