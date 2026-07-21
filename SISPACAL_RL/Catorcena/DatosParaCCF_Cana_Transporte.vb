Imports System.Drawing.Printing
Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class DatosParaCCF_Cana_Transporte
    Private gID_CATORCENA As Integer
    Private gID_TIPO_PLANILLA As Integer
    Private gCODIGO As String


    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, ByVal CODIGO As String)
        Me.DS_CATORCENA1.Clear()
        Me.DATOS_EMISION_CCFTableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.DATOS_EMISION_CCF, ID_CATORCENA, ID_TIPO_PLANILLA, CODIGO)

        Dim lEntidad As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        If lEntidad IsNot Nothing Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lEntidad.ID_ZAFRA)
            Me.xrTitulo.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA + " CATORCENA #" + lEntidad.CATORCENA.ToString
        End If

        gID_CATORCENA = ID_CATORCENA
        gID_TIPO_PLANILLA = ID_TIPO_PLANILLA
        gCODIGO = CODIGO
    End Sub

    Private Sub sbrLiquidacionContribuyente_BeforePrint(sender As Object, e As PrintEventArgs) Handles sbrLiquidacionContribuyente.BeforePrint
        Dim detalle As LiquidacionContribuyentePlanilla = TryCast(Me.sbrLiquidacionContribuyente.ReportSource, LiquidacionContribuyentePlanilla)
        If detalle IsNot Nothing Then
            If Not GetCurrentColumnValue("CODIPROVEEDOR") Is DBNull.Value Then
                detalle.CargarDatos(gID_CATORCENA, gID_TIPO_PLANILLA, gCODIGO)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class