Imports Logica
Public Class MovimientosPorSocio

    Sub cargar()

        grillasoci.Rows.Clear()

        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If txtsocio.Text = s.NombreSocio Then

                grillasoci.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)


            End If

        Next

    End Sub


    Private Sub MovimientosPorSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()

    End Sub

   

    Private Sub txtsocio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsocio.TextChanged
        If txtsocio.Text = "" Then

        Else
            cargar()
        End If

    End Sub
End Class