Imports Logica
Public Class MovimientosPorCedula

    Sub cargar()
        grillacedu.Rows.Clear()

        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If txtcedulal.Text = s.CedulaOperacion Then

                grillacedu.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)


            End If


        Next



    End Sub


    Private Sub MovimientosPorCedula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcedulal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcedulal.TextChanged
        cargar()

    End Sub
End Class