Imports Logica

Public Class Listadodecocios

    Sub mes()

        Grillasociosmes.Rows.Clear()

        For Each f As SociosClass In ListadoSocios.ListaSoci

            If txtfecha.Text = f.FechaNacimiento.Month Then



                Grillasociosmes.Rows.Add(f.Cedula, f.Nombres, f.FechaNacimiento)

            End If

        Next

        If Grillasociosmes.RowCount = 0 Then

            MsgBox("No hay datos")

        End If



    End Sub

    

    Private Sub txtfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfecha.KeyPress
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

   

    Private Sub txtfecha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfecha.SelectedIndexChanged
        mes()
    End Sub
End Class