Imports Logica


Public Class MovimientosPorConcepto

    Sub cargar()

        Grillaconceptos.Rows.Clear()

        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If txtconcepto.Text = s.CodigoConcepto Then

                Grillaconceptos.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)


            End If



        Next







    End Sub






    Private Sub MovimientosPorConcepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtconcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconcepto.TextChanged
        cargar()

    End Sub
End Class