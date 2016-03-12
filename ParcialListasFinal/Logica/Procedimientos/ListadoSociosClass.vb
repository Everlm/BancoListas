Public Class ListadoSociosClass


    Private listaSocios As New List(Of SociosClass)

    Public ReadOnly Property ListaSoci() As List(Of SociosClass)
        Get
            Return listaSocios
        End Get
    End Property


    Public Function Adicionar(ByVal Soc As SociosClass) As Integer
        Try
            listaSocios.Add(Soc)
            Return listaSocios.Count

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function TotalSocios() As Integer
        Return listaSocios.Count
    End Function

    Function Buscar(ByVal cl As ULong) As SociosClass
        Dim i As Integer
        For i = 0 To TotalSocios() - 1
            If listaSocios.Item(i).Cedula = cl Then
                Return listaSocios.Item(i)
            End If
        Next
        Return Nothing
    End Function
    Function Buscarnom(ByVal cl As String) As SociosClass
        Dim i As Integer
        For i = 0 To TotalSocios() - 1
            If listaSocios.Item(i).Nombres = cl Then
                Return listaSocios.Item(i)
            End If
        Next
        Return Nothing
    End Function



    Public Function Eliminar(ByVal codce As Long) As Boolean
        For i As Integer = 0 To listaSocios.Count - 1
            If listaSocios.Item(i).Cedula = codce Then
                listaSocios.RemoveAt(i)
                Return True
            End If
        Next
        Return False
    End Function

    'Public Function socio(ByVal indice As Integer) As SociosClass
    '    Return listaSocios(indice)
    'End Function



    Public Function listaGrillSocios(ByVal i As Integer) As String()

        Dim s(3) As String
        s(0) = listaSocios.Item(i).Cedula
        s(1) = listaSocios.Item(i).Nombres
        s(2) = listaSocios.Item(i).FechaNacimiento

        Return s

    End Function
  


End Class
