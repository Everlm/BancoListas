Imports Logica
Public Class ListadoDeSociosGeneral


    Sub CargarGrilla()

        Grillagene.Rows.Clear()
        For i = 0 To ListadoSocios.TotalSocios - 1
            Grillagene.Rows.Add(ListadoSocios.listaGrillSocios(i))
        Next

        Grillagene.Sort(Grillagene.Columns(2), System.ComponentModel.ListSortDirection.Descending)

    End Sub


    Private Sub ListadoDeSociosGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CargarGrilla()

    End Sub
End Class