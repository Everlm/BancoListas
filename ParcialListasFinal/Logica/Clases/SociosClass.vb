Public Class SociosClass

    Public Cedu As Long
    Public Property Cedula As Long
        Get
            Return Cedu
        End Get
        Set(ByVal value As Long)
            Cedu = value
        End Set
    End Property


    Public Nombre As String
    Public Property Nombres As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public FechaNaci As Date
    Public Property FechaNacimiento As Date
        Get
            Return FechaNaci
        End Get
        Set(ByVal value As Date)
            FechaNaci = value
        End Set
    End Property
    'Public Function fila() As String()

    '    Dim s(6) As String

    '    s(0) = Cedula
    '    s(1) = Nombre
    '    s(2) = FechaNacimiento

    '    Return s

    'End Function

End Class
