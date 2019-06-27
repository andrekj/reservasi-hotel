Public Class ClsEntKamar
    Private id As String
    Private id_tipe As String
    Private nama_kamar As String
    Private harga As String
    Private fasilitas As String
    Private tersedia As String
    Private gambar As String


    Public Property idKamar() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property id_tipeKamar() As String
        Get
            Return id_tipe
        End Get
        Set(value As String)
            id_tipe = value
        End Set
    End Property
    Public Property namaKamar() As String
        Get
            Return nama_kamar
        End Get
        Set(value As String)
            nama_kamar = value
        End Set
    End Property

    Public Property hargaKamar() As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property

    Public Property gambarKamar() As String
        Get
            Return gambar
        End Get
        Set(value As String)
            gambar = value
        End Set
    End Property

    Public Property fasilitasKamar() As String
        Get
            Return fasilitas
        End Get
        Set(value As String)
            fasilitas = value
        End Set
    End Property
    Public Property tersediaKamar() As String
        Get
            Return tersedia
        End Get
        Set(value As String)
            tersedia = value
        End Set
    End Property
End Class
