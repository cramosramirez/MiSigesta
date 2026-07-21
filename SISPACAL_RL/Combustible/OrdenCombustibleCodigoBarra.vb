Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class OrdenCombustibleCodigoBarra
    Public Sub CargarDatos(ByVal ID_ORDEN_COMBUS As Int32)
        Me.Orden_COMBUSTIBLETableAdapter1.FillPorORDEN_COMBUS(DS_DS11.ORDEN_COMBUSTIBLE, ID_ORDEN_COMBUS)
        Dim lOrden As ORDEN_COMBUSTIBLE = (New cORDEN_COMBUSTIBLE).ObtenerORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        If lOrden IsNot Nothing Then
            If lOrden.NRC = Nothing OrElse lOrden.NRC.Trim = "" Then
                xrTipoDoctoEmitir.Text = "** EMITIR FACTURA **"
            Else
                xrTipoDoctoEmitir.Text = "** EMITIR CREDITO FISCAL **"
            End If
        End If
        Me.DisplayName = "ORDEN DE ENTREGA DE COMBUSTIBLE Y OTROS PRODUCTOS"
    End Sub
End Class