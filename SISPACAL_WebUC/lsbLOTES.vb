Imports System.ComponentModel
Imports System.Web.UI

<DefaultProperty("ACCESLOTE"), ToolboxData("<{0}:lsbLOTES runat=server></{0}:lsbLOTES>")> _
Public Class lsbLOTES
    Inherits System.Web.UI.WebControls.ListBox

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ZONAS .
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCriterios(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal ID_PLAN_SEMANAL As Integer, ByVal CODIPROVEE As String, _
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal INCLUIR_LOTES_NO_PROGRAMADOS As Boolean, _
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC")
        Dim miComponente As New cLOTES
        Dim Lista As New listaLOTES

        Lista = miComponente.ObtenerListaPorCriterios(NOMBRE_ZAFRA, ZONA, ID_PLAN_SEMANAL, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, INCLUIR_LOTES_NO_PROGRAMADOS, asColumnaOrden, asTipoOrden)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()

    End Sub
End Class
