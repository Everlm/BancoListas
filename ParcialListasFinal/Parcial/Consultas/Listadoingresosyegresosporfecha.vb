Imports Logica


Public Class Listadoingresosyegresosporfecha

    Sub fechas()

        grilla.Rows.Clear()

        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If txtigreso.Text = s.TipoOperacion Then
                
                If txtfecha.Value.Day <= s.FechaRegistro.Day And txtfecha2.Value.Day >= s.FechaRegistro.Day Then

                    If txtfecha.Value.Month <= s.FechaRegistro.Month And txtfecha2.Value.Month >= s.FechaRegistro.Month Then
                        If txtfecha.Value.Year <= s.FechaRegistro.Year And txtfecha2.Value.Year >= s.FechaRegistro.Year Then

                            grilla.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)

                        End If
                    End If
                End If
            End If
        Next



    End Sub

    Private Sub Listadoingresosyegresosporfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        fechas()
    End Sub
End Class