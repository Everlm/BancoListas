Imports Logica
Public Class ListaDeMovimientosPorValor


    Sub cargar()

        grillavalor.Rows.Clear()

        For Each s As MovimientosClass In ListadoMovimientos.ListaMovi

            If s.Valorr <= txtvalor.Text And s.Valorr >= txtvalor.Text Then

                grillavalor.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)

                'ElseIf s.Valorr > txtvalor.Text Then

                '    grillavalor.Rows.Add(s.Consecutivo, s.FechaRegistro, s.NombreSocio, s.CedulaOperacion, s.CodigoConcepto, s.TipoOperacion, s.Valorr)

            End If


        Next



    End Sub

    Private Sub txtvalor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalor.TextChanged
        If txtvalor.Text = "" Then
        Else
            cargar()
        End If

    End Sub

    Private Sub ListaDeMovimientosPorValor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtvalor.Text = "" Then
        Else
            cargar()
        End If
    End Sub
End Class