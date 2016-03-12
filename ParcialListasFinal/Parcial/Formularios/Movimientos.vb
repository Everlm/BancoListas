Imports Logica

Public Class Movimientos

    Sub guardar()

        Dim p As Long

        p = ListadoMovimientos.BuscarTotL(txtcedula.Text)

        Dim objmovimiento As MovimientosClass
        objmovimiento = New MovimientosClass
        Dim So, movii As New MovimientosClass
        Dim n As Integer

        p = ListadoMovimientos.BuscarTotL(txtcedula.Text)

        So = ListadoMovimientos.Buscar(txtconsecutivo.Text)


        If IsNothing(So) Then

            If txtconsecutivo.Text = "" Or txtfecha.Text = "" Or combonombre.Text = "" Or txtcedula.Text = "" Or txtcodiconce.Text = "" Or txttipo.Text = "" Or txtvalor.Text = "" Then
                MsgBox("Complete todos los campos", vbExclamation)
            Else
                movii.Consecutivo = txtconsecutivo.Text
                movii.FechaRegistro = txtfecha.Text
                movii.NombreSocio = combonombre.Text
                movii.CedulaOperacion = txtcedula.Text
                movii.CodigoConcepto = txtcodiconce.Text
                movii.TipoOperacion = txttipo.Text
                movii.Valorr = txtvalor.Text


                If txttipo.Text = "Ingresos" Then

                    objmovimiento.SaldoTotal = txtvalor.Text + p

                    movii.SaldoTotal = p + txtvalor.Text

                    ListadoMovimientos.modificarsal(objmovimiento, txtcedula.Text)

                End If


                If txttipo.Text = "Egresos" Then

                    objmovimiento.SaldoTotal = p - txtvalor.Text

                    movii.SaldoTotal = p - txtvalor.Text
                    'n = ListadoMovimientos.Adicionar(movii)
                    ListadoMovimientos.modificarsal(objmovimiento, txtcedula.Text)

                End If

                n = ListadoMovimientos.Adicionar(movii)
                CargarGrilla()

                If n <> -1 Then
                    MsgBox("Guardado", vbInformation)
                    nuevo()
                Else
                    MsgBox("Error, en guardar", vbExclamation)
                End If
            End If

        Else
            MsgBox("movimiento ya registrado", vbExclamation)
        End If

        txtconsecutivo.Text = ListadoMovimientos.ultimo
       
    End Sub



    Sub CargarGrilla()

        Grillamovimientos.Rows.Clear()
        For i = 0 To ListadoMovimientos.TotalMovimientos - 1
            Grillamovimientos.Rows.Add(ListadoMovimientos.listaGrillaMovi(i))
        Next

    End Sub


    Sub Buscar()

        Try
            Dim ess As New MovimientosClass

            If txtconsecutivo.Text = "" Then

                txtconsecutivo.Clear()
                txtfecha.ResetText()
                combonombre.SelectedIndex = -1
                txtcedula.Clear()
                txtcodiconce.SelectedIndex = -1
                txttipo.SelectedIndex = -1
                txtvalor.Clear()

                btnmodificar.Enabled = False
                btneliminar.Enabled = False

            Else
                ess = ListadoMovimientos.Buscar((txtconsecutivo.Text))
                If ess Is Nothing Then

                    txtconsecutivo.Clear()
                    txtfecha.ResetText()
                    combonombre.SelectedIndex = -1
                    txtcedula.Clear()
                    txtcodiconce.SelectedIndex = -1
                    txttipo.SelectedIndex = -1
                    txtvalor.Clear()

                    btnmodificar.Enabled = False
                    btneliminar.Enabled = False
                Else
                    Ver(ess)
                    btnmodificar.Enabled = True
                    btneliminar.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub Ver(ByVal So As MovimientosClass)

        txtconsecutivo.Text = So.Consecutivo
        txtfecha.Text = So.FechaRegistro
        combonombre.Text = So.NombreSocio
        txtcedula.Text = So.CedulaOperacion
        txtcodiconce.Text = So.CodigoConcepto
        txttipo.Text = So.TipoOperacion
        txtvalor.Text = So.Valorr



    End Sub


    Sub nuevo()

        txtfecha.ResetText()
        combonombre.SelectedIndex = -1
        txtcedula.Clear()
        txtcodiconce.SelectedIndex = -1
        txttipo.SelectedIndex = -1
        txtvalor.Clear()


    End Sub

    Sub elimina()

        Try
            For i As Integer = 0 To ListadoMovimientos.TotalMovimientos - 1

                ListadoMovimientos.Eliminar(txtconsecutivo.Text)

            Next

            MsgBox("Eliminado", vbInformation)
            CargarGrilla()
            nuevo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        guardar()
        nuevo()

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        elimina()

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Buscar()

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim p As Long
        p = ListadoMovimientos.BuscarTotL(txtcedula.Text)
        Dim objmovimiento As MovimientosClass
        objmovimiento = New MovimientosClass



        If txttipo.Text = "Ingresos" Then
            objmovimiento.Consecutivo = txtconsecutivo.Text
            objmovimiento.FechaRegistro = txtfecha.Value.ToShortDateString
            objmovimiento.NombreSocio = combonombre.Text
            objmovimiento.CedulaOperacion = txtcedula.Text
            objmovimiento.CodigoConcepto = txtcodiconce.Text
            objmovimiento.TipoOperacion = txttipo.Text
            'objmovimiento.Valorr = txtvalor.Text
            objmovimiento.SaldoTotal = txtvalor.Text + p

            ListadoMovimientos.modificar(objmovimiento, txtcedula.Text)

        End If


        If txttipo.Text = "Egresos" Then

            objmovimiento.Consecutivo = txtconsecutivo.Text
            objmovimiento.FechaRegistro = txtfecha.Value.ToShortDateString
            objmovimiento.NombreSocio = combonombre.Text
            objmovimiento.CedulaOperacion = txtcedula.Text
            objmovimiento.CodigoConcepto = txtcodiconce.Text
            objmovimiento.TipoOperacion = txttipo.Text
            'objmovimiento.Valorr = txtvalor.Text
            objmovimiento.SaldoTotal = txtvalor.Text - p

            ListadoMovimientos.modificar(objmovimiento, txtcedula.Text)

        End If

        CargarGrilla()


        
        nuevo()


    End Sub

    Sub mostrarnombre()

        Dim nom As SociosClass

        If combonombre.Text = "" Then
            txtcedula.Text = ""
        Else
            nom = ListadoSocios.Buscarnom(combonombre.Text)
            Ver(nom)
        End If

    End Sub

    Sub ver(ByVal ce As SociosClass)
        txtcedula.Text = ce.Cedula
    End Sub

    Private Sub Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtconsecutivo.Text = ListadoMovimientos.ultimo
        CargarGrilla()


    End Sub

    Private Sub combonombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combonombre.KeyPress
        If Char.IsLetter(e.KeyChar) And Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub combonombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combonombre.SelectedIndexChanged
        mostrarnombre()

    End Sub


    Sub soloNum(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub soloLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'solo letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodiconce_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodiconce.KeyPress
        If Char.IsLetter(e.KeyChar) And Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress
        If Char.IsLetter(e.KeyChar) And Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcedula.KeyPress
        soloNum(e)

    End Sub



    Private Sub txtvalor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalor.KeyPress
        soloNum(e)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub



End Class