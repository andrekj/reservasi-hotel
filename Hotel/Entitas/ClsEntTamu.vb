Public Class ClsEntTamu
    Private id As String
    Private first_name As String
    Private last_name As String
    Private no_identity As String
    Private email As String
    Private telpon As String
    Private spesial_request As String


    Public Property idTamu() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property identitasTamu() As String
        Get
            Return no_identity
        End Get
        Set(value As String)
            no_identity = value
        End Set
    End Property
    Public Property first_nameTamu() As String
        Get
            Return first_name
        End Get
        Set(value As String)
            first_name = value
        End Set
    End Property
    Public Property last_nameTamu() As String
        Get
            Return last_name
        End Get
        Set(value As String)
            last_name = value
        End Set
    End Property

    Public Property telponTamu() As String
        Get
            Return telpon
        End Get
        Set(value As String)
            telpon = value
        End Set
    End Property
    Public Property emailTamu() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property spesial_requestTamu() As String
        Get
            Return spesial_request
        End Get
        Set(value As String)
            spesial_request = value
        End Set
    End Property

End Class
