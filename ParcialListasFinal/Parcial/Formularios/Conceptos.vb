Imports Logica

Public Class Conceptos


    Sub guardar()

        Dim co, conce As New ConceptosClass
        Dim n As Integer
        Dim conp As New MovimientosClass

       

        If txtconcep.Text = "" Then
            MsgBox("Complete todos los campos", vbExclamation)

           
        Else


            conce.Consecutivo = txtconsecutivo.Text
            conce.Descripcion = txtconcep.Text
            conp.CodigoConcepto = txtconcep.Text


            Movimientos.txtcodiconce.Items.Add(txtconcep.Text)


            n = ListadoConceptos.Adicionar(conce)


            CargarGrilla()

            If n <> -1 Then
                MsgBox("Guardado", vbInformation)
                nuevo()
            Else
                MsgBox("Error, en guardar", vbExclamation)
            End If
        End If


        txtconsecutivo.Text = ListadoConceptos.ultimo



    End Sub



    Sub CargarGrilla()

        Grillaconceptos.Rows.Clear()
        For i = 0 To ListadoConceptos.TotalConceptos - 1
            Grillaconceptos.Rows.Add(ListadoConceptos.listaGrillSocios(i))
        Next

      
    End Sub


    Sub Buscar()

        Try
            Dim ess As New ConceptosClass

            If txtconsecutivo.Text = "" Then

                txtconsecutivo.Clear()
                txtconcep.Clear()


                btnmodificar.Enabled = False
                btneliminar.Enabled = False

            Else
                ess = ListadoConceptos.Buscar((txtconsecutivo.Text))
                If ess Is Nothing Then

                    txtconsecutivo.Clear()
                    txtconcep.Clear()

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

    Sub Ver(ByVal So As ConceptosClass)

        txtconsecutivo.Text = So.Consecutivo
        txtconcep.Text = So.Descripcion

    End Sub


    Sub nuevo()
        txtconsecutivo.Clear()
        txtconcep.Clear()

    End Sub

    Sub elimina()

        Try
            For i As Integer = 0 To ListadoConceptos.TotalConceptos - 1

                ListadoConceptos.Eliminar(txtconsecutivo.Text)

            Next

            MsgBox("Eliminado", vbInformation)
            CargarGrilla()
            nuevo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub modificar()

        ListadoConceptos.Eliminar(ListadoConceptos.Eliminar(txtconsecutivo.Text))

        Dim soo As New ConceptosClass
        Dim n As Integer

        soo.Consecutivo = txtconsecutivo.Text
        soo.Descripcion = txtconcep.Text


        n = ListadoConceptos.Adicionar(soo)
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

    Private Sub Grillaconceptos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grillaconceptos.CellContentClick
        CargarGrilla()
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Buscar()
    End Sub


    Private Sub Conceptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtconsecutivo.Text = ListadoConceptos.ultimo
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

    Private Sub txtconcep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconcep.KeyPress
        soloLetras(e)

    End Sub

   
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub
End Class