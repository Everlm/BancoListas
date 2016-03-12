Public Class ListadoConceptosClass

    Public listaConcepto As New List(Of ConceptosClass)

    Public ReadOnly Property ListaConce() As List(Of ConceptosClass)
        Get
            Return listaConcepto
        End Get
    End Property


    Public Function Adicionar(ByVal Soc As ConceptosClass) As Integer
        Try
            listaConcepto.Add(Soc)
            Return listaConcepto.Count

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function ultimo() As Integer
        Try
            Dim a As Integer = 1
            For i As Integer = 1 To listaConcepto.Count
                a = a + 1
            Next
            Return a


        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function TotalConceptos() As Integer
        Return listaConcepto.Count
    End Function

    Function Buscar(ByVal cl As ULong) As ConceptosClass
        For i = 0 To TotalConceptos() - 1
            If listaConcepto.Item(i).Consecutivo = cl Then
                Return listaConcepto.Item(i)
            End If
        Next
        Return Nothing
    End Function



    Public Function Eliminar(ByVal codce As Long) As Boolean
        For i As Integer = 0 To listaConcepto.Count - 1
            If listaConcepto.Item(i).Consecutivo = codce Then
                listaConcepto.RemoveAt(i)
                Return True
            End If
        Next
        Return False
    End Function

    
    Public Function listaGrillSocios(ByVal i As Integer) As String()

        Dim s(3) As String
        s(0) = listaConcepto.Item(i).Consecutivo
        s(1) = listaConcepto.Item(i).Descripcion


        Return s

    End Function





End Class
