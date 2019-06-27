Public Class ClsEntReservasi
    Private idRes As String
    Private id_tamu As String
    Private id_kar As String
    Private tglchekin As Date
    Private tglchekout As Date
    Private status As String
    Private tot As Integer


    Public Property idRes_Resv() As String
        Get
            Return idRes
        End Get
        Set(value As String)
            idRes = value
        End Set
    End Property
    Public Property id_tamu_Resv() As String
        Get
            Return id_tamu
        End Get
        Set(value As String)
            id_tamu = value
        End Set
    End Property
    Public Property id_kar_Resv() As String
        Get
            Return id_kar
        End Get
        Set(value As String)
            id_kar = value
        End Set
    End Property
    Public Property tglchekin_Resv() As Date
        Get
            Return tglchekin
        End Get
        Set(value As Date)
            tglchekin = value
        End Set
    End Property
    Public Property tglchekout_Resv() As Date
        Get
            Return tglchekout
        End Get
        Set(value As Date)
            tglchekout = value
        End Set
    End Property


    Public Property statusReservasi() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
    Public Property tot_Resv() As String
        Get
            Return tot
        End Get
        Set(value As String)
            tot = value
        End Set
    End Property
End Class
