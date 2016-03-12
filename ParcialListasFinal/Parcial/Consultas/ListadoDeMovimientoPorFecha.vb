Imports Logica
Public Class ListadoDeMovimientoPorFecha


    Sub cargar()

        Grillamovimiento.Rows.Clear()
        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If txtfecha.Text = s.FechaRegistro Then


                Grillamovimiento.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)



            End If





        Next






    End Sub











    Private Sub ListadoDeMovimientoPorFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfecha.ValueChanged
        cargar()

    End Sub
End Class