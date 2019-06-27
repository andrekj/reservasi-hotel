Public Class ClsEntBill

    Private idbill As String
    Private idres As String
    Private tglbyr As Date
    Private jenisByr As String


    Public Property idbill_bill() As String
        Get
            Return idbill
        End Get
        Set(value As String)
            idbill = value
        End Set
    End Property
    Public Property idres_bill() As String
        Get
            Return idres
        End Get
        Set(value As String)
            idres = value
        End Set
    End Property
    Public Property tglbyr_bill() As Date
        Get
            Return tglbyr
        End Get
        Set(value As Date)
            tglbyr = value
        End Set
    End Property
    Public Property jenisByr_bill() As String
        Get
            Return jenisByr
        End Get
        Set(value As String)
            jenisByr = value
        End Set
    End Property
End Class
