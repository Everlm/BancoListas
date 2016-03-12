Public Class ConceptosClass


    Private Consecu As Integer
    Public Property Consecutivo As Integer
        Get
            Return Consecu
        End Get
        Set(ByVal value As Integer)
            Consecu = value
        End Set
    End Property

    Private Descripci As String
    Public Property Descripcion As String
        Get
            Return Descripci
        End Get
        Set(ByVal value As String)
            Descripci = value
        End Set
    End Property

End Class
