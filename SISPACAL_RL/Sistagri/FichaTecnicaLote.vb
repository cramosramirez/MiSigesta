Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class FichaTecnicaLote

    Public Sub CargarDatos(ByVal CODIPROVEEDOR As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        If lZafra IsNot Nothing Then
            xrZAFRA.Text = lZafra.NOMBRE_ZAFRA
        End If

        Me.DS_SISTAGRI1.Clear()
        Me.FICHA_TECNICA_LOTETableAdapter1.FillPorProveedor(DS_SISTAGRI1.FICHA_TECNICA_LOTE, CODIPROVEEDOR)
    End Sub


End Class