Public Class ClsEntTipeKamar
    Private id As String
    Private nama_tipe As String






    Public Property idTipeKamar() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property nama_tipeKamar() As String
        Get
            Return nama_tipe
        End Get
        Set(value As String)
            nama_tipe = value
        End Set
    End Property



End Class


