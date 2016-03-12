Public Class ListadoMovimientosClass

    'Ever
    Public listaMovimiento As New List(Of MovimientosClass)

    Public ReadOnly Property ListaMovi() As List(Of MovimientosClass)
        Get
            Return listaMovimiento
        End Get
    End Property


    Public Function Adicionar(ByVal Soc As MovimientosClass) As Integer
        Try
            listaMovimiento.Add(Soc)
            Return listaMovimiento.Count

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function TotalMovimientos() As Integer
        Return listaMovimiento.Count
    End Function

    Function Buscar(ByVal cl As ULong) As MovimientosClass
        For i = 0 To TotalMovimientos() - 1
            If listaMovimiento.Item(i).Consecutivo = cl Then
                Return listaMovimiento.Item(i)
            End If
        Next
        Return Nothing
    End Function

    Function BuscarTotL(ByVal cl As Integer) As Integer

        For Each z As MovimientosClass In ListaMovi
            If z.CedulaOperacion = cl Then
                Return z.SaldoTotal
            End If
        Next
        


        Return Nothing
    End Function

    Public Function Eliminar(ByVal codce As Long) As Boolean
        For i As Integer = 0 To listaMovimiento.Count - 1
            If listaMovimiento.Item(i).Consecutivo = codce Then
                listaMovimiento.RemoveAt(i)
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ultimo() As Integer
        Try
            Dim a As Integer = 1
            For i As Integer = 1 To listaMovimiento.Count
                a = a + 1
            Next
            Return a
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Function BuscarRsta(ByVal cl As Integer) As Integer

        For Each z As MovimientosClass In ListaMovi
            If z.CedulaOperacion = cl - 1 Then
                Return z.Valorr
            End If
        Next



        Return Nothing
    End Function


    Public Function listaGrillaMovi(ByVal i As Integer) As String()

        Dim s(10) As String

        s(0) = listaMovimiento.Item(i).Consecutivo
        s(1) = listaMovimiento.Item(i).FechaRegistro
        s(2) = listaMovimiento.Item(i).NombreSocio
        s(3) = listaMovimiento.Item(i).CedulaOperacion
        s(4) = listaMovimiento.Item(i).CodigoConcepto
        s(5) = listaMovimiento.Item(i).TipoOperacion
        s(6) = listaMovimiento.Item(i).Valorr
        s(7) = listaMovimiento.Item(i).SaldoTotal

        Return s

    End Function

    Function validarDatos(ByVal dato As String) As Integer
        Dim i As Integer
        If IsNothing(ListaMovi) Then
            Return -1
        Else
            For Each item As MovimientosClass In listaMovimiento
                If item.CedulaOperacion = dato Then
                    Return i
                End If
                i += 1
            Next
        End If
        Return -1
    End Function


    Function modificar(ByVal objmovi As MovimientosClass, ByVal cm As Long) As MovimientosClass

        If validarDatos(cm) <> -1 Then
            listaMovimiento.Item(validarDatos(cm)).Consecutivo = objmovi.Consecutivo
            listaMovimiento.Item(validarDatos(cm)).FechaRegistro = objmovi.FechaRegistro
            listaMovimiento.Item(validarDatos(cm)).NombreSocio = objmovi.NombreSocio
            listaMovimiento.Item(validarDatos(cm)).CedulaOperacion = objmovi.CedulaOperacion
            listaMovimiento.Item(validarDatos(cm)).CodigoConcepto = objmovi.CodigoConcepto
            listaMovimiento.Item(validarDatos(cm)).TipoOperacion = objmovi.TipoOperacion
            listaMovimiento.Item(validarDatos(cm)).Valorr = objmovi.Valorr
            listaMovimiento.Item(validarDatos(cm)).SaldoTotal = objmovi.SaldoTotal

        End If
        Return Nothing
    End Function


    Function validar(ByVal dato As String) As Integer
        Dim i As Integer
        If IsNothing(ListaMovi) Then
            Return -1
        Else
            For Each item As MovimientosClass In listaMovimiento
                If item.CedulaOperacion = dato Then
                    Return i
                End If
                i += 1
            Next
        End If
        Return -1
    End Function


    Function modificarsal(ByVal objmovi As MovimientosClass, ByVal cm As Long) As MovimientosClass

        If validar(cm) <> -1 Then

            listaMovimiento.Item(validar(cm)).SaldoTotal = objmovi.SaldoTotal

        End If
        Return Nothing
    End Function






End Class
