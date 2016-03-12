Imports Logica

Public Class Socios

    Sub guardar()

        Dim So, Socii As New SociosClass
        Dim n As Integer
        Dim soci As New MovimientosClass

        So = ListadoSocios.Buscar(txtcedula.Text)

        If IsNothing(So) Then

            If String.IsNullOrEmpty(txtcedula.Text) Or txtnombre.Text = "" Or txtfecha.Text = "" Then
                MsgBox("Complete todos los campos", vbExclamation)
            Else
                Socii.Cedula = txtcedula.Text
                Socii.Nombres = txtnombre.Text
                Socii.FechaNacimiento = txtfecha.Text
                soci.NombreSocio = txtnombre.Text

                Movimientos.combonombre.Items.Add(txtnombre.Text)

                n = ListadoSocios.Adicionar(Socii)

                CargarGrilla()

                If n <> -1 Then
                    MsgBox("Guardado", vbInformation)
                    nuevo()
                Else
                    MsgBox("Error, en guardar", vbExclamation)
                End If
            End If

        Else
            MsgBox("Socio ya registrado", vbExclamation)
        End If


    End Sub



    Sub CargarGrilla()

        GrillaSocios.Rows.Clear()
        For i = 0 To ListadoSocios.TotalSocios - 1
            GrillaSocios.Rows.Add(ListadoSocios.listaGrillSocios(i))
        Next

        GrillaSocios.Sort(GrillaSocios.Columns(2), System.ComponentModel.ListSortDirection.Descending)

    End Sub


    Sub Buscar()

        Try
            Dim ess As New SociosClass

            If txtcedula.Text = "" Then

                txtcedula.Clear()
                txtnombre.Clear()
                txtfecha.ResetText()

                btnmodificar.Enabled = False
                btneliminar.Enabled = False

            Else
                ess = ListadoSocios.Buscar((txtcedula.Text))
                If ess Is Nothing Then

                    txtcedula.Clear()
                    txtnombre.Clear()
                    txtfecha.ResetText()

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

    Sub Ver(ByVal So As SociosClass)

        txtcedula.Text = So.Cedula
        txtnombre.Text = So.Nombres
        txtfecha.Text = So.FechaNacimiento

    End Sub


    Sub nuevo()
        txtcedula.Clear()
        txtnombre.Clear()
        txtfecha.ResetText()
    End Sub

    Sub elimina()

        Try
            For i As Integer = 0 To ListadoSocios.TotalSocios - 1

                ListadoSocios.Eliminar(txtcedula.Text)

            Next

            MsgBox("Eliminado", vbInformation)
            CargarGrilla()
            nuevo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub modificar()

        ListadoSocios.Eliminar(ListadoSocios.Eliminar(txtcedula.Text))

        Dim soo As New SociosClass
        Dim n As Integer

        soo.Cedula = txtcedula.Text
        soo.Nombres = txtnombre.Text
        soo.FechaNacimiento = txtfecha.Text

        n = ListadoSocios.Adicionar(soo)
        If n <> -1 Then
            MsgBox("Modificado", vbInformation)
            nuevo()
        Else
            MsgBox("Error, en Modificar", vbExclamation)

        End If

    End Sub


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        guardar()
        CargarGrilla()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        elimina()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        modificar()

    End Sub

    Private Sub GrillaSocios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaSocios.CellContentClick
        CargarGrilla()
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Buscar()
    End Sub

    Private Sub Socios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcedula.KeyPress
        soloNum(e)

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        soloLetras(e)

    End Sub

    





   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class