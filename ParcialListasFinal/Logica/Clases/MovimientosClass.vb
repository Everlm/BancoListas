Public Class MovimientosClass


    Private Ceduope As Integer
    Public Property CedulaOperacion As Integer
        Get
            Return Ceduope
        End Get
        Set(ByVal value As Integer)
            Ceduope = value
        End Set
    End Property


    Private CodigoConce As String
    Public Property CodigoConcepto As String
        Get
            Return CodigoConce
        End Get
        Set(ByVal value As String)
            CodigoConce = value
        End Set
    End Property


    Private FechaRegis As Date
    Public Property FechaRegistro As Date
        Get
            Return FechaRegis
        End Get
        Set(ByVal value As Date)
            FechaRegis = value
        End Set
    End Property


    Private Consecu As Integer
    Public Property Consecutivo As Integer
        Get
            Return Consecu
        End Get
        Set(ByVal value As Integer)
            Consecu = value
        End Set
    End Property


    Private TipoOpe As String
    Public Property TipoOperacion As String
        Get
            Return TipoOpe
        End Get
        Set(ByVal value As String)
            TipoOpe = value
        End Set
    End Property

    Private Valor As Integer
    Public Property Valorr As Integer
        Get
            Return Valor
        End Get
        Set(ByVal value As Integer)
            Valor = value
        End Set
    End Property

    Private NombreSoci As String
    Public Property NombreSocio As String
        Get
            Return NombreSoci
        End Get
        Set(ByVal value As String)
            NombreSoci = value
        End Set
    End Property

    Private SaldoTo As Integer

    Public Property SaldoTotal As Integer
        Get
            Return SaldoTo
        End Get
        Set(ByVal value As Integer)
            SaldoTo = value
        End Set
    End Property


End Class
