Public Class ClsEntKaryawan
    Private id As String
    Private nama As String
    Private pass As String
    Private alamat As String
    Private telpon As String

    Private idlogin As String
    Private namalogin As String
    Private passlogin As String
    Private alamatlogin As String
    Private telponlogin As String

    Public Property kdKaryawan() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property passKaryawan() As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property
    Public Property namaKaryawan() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property telponKaryawan() As String
        Get
            Return telpon
        End Get
        Set(value As String)
            telpon = value
        End Set
    End Property

    Public Property alamatKaryawan() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
    Public Property idKaryawanLogin() As String
        Get
            Return idlogin
        End Get
        Set(value As String)
            idlogin = value
        End Set
    End Property

    Public Property passKaryawanLogin() As String
        Get
            Return passlogin
        End Get
        Set(value As String)
            passlogin = value
        End Set
    End Property

    Public Property namaKaryawanLogin() As String
        Get
            Return namalogin
        End Get
        Set(value As String)
            namalogin = value
        End Set
    End Property

    Public Property telponKaryawanLogin() As String
        Get
            Return telponlogin
        End Get
        Set(value As String)
            telponlogin = value
        End Set
    End Property

    Public Property alamatKaryawanLogin() As String
        Get
            Return alamatlogin
        End Get
        Set(value As String)
            alamatlogin = value
        End Set
    End Property


End Class
