Imports Logica
Public Class ListadoIngresosYEgresosvb



    Sub Ingresos()
        grillaingre.Rows.Clear()
        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If s.TipoOperacion = comboigre.Text Then

                grillaingre.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)

            ElseIf s.TipoOperacion = comboigre.Text Then

                grillaingre.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)

            ElseIf s.TipoOperacion = comboigre.Text Then

                grillaingre.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)

            End If





        Next









    End Sub
















    Private Sub ListadoIngresosYEgresosvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub comboigre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboigre.KeyPress
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

    Private Sub comboigre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboigre.SelectedIndexChanged
        Ingresos()

    End Sub

    Private Sub grillaingre_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grillaingre.CellContentClick

    End Sub
End Class