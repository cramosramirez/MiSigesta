Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbDESCUENTOS_PLANILLA_OC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla DESCUENTOS_PLANILLA_OC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DESC_PLA_OC"), ToolboxData("<{0}:lbDESCUENTOS_PLANILLA_OC runat=server></{0}:lbDESCUENTOS_PLANILLA_OC>")> _
Public Class lbDESCUENTOS_PLANILLA_OC
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla DESCUENTOS_PLANILLA_OC.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cDESCUENTOS_PLANILLA_OC
        Dim Lista As New ListaDESCUENTOS_PLANILLA_OC

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_DESC_PLA_OC"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DESCUENTOS_PLANILLA .
    ''' </summary>
    ''' <param name="ID_DESCUENTO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA_OC
        Dim Lista As New ListaDESCUENTOS_PLANILLA_OC

        Lista = miComponente.ObtenerListaPorDESCUENTOS_PLANILLA(ID_DESCUENTO_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_DESC_PLA_OC"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ORDEN_COMBUSTIBLE .
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA_OC
        Dim Lista As New ListaDESCUENTOS_PLANILLA_OC

        Lista = miComponente.ObtenerListaPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_DESC_PLA_OC"

        Me.DataBind()

    End Sub

End Class
