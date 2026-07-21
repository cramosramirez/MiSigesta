Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbDESCUENTOS_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla DESCUENTOS_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DESCUENTO_PLANILLA"), ToolboxData("<{0}:lbDESCUENTOS_PLANILLA runat=server></{0}:lbDESCUENTOS_PLANILLA>")> _
Public Class lbDESCUENTOS_PLANILLA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla DESCUENTOS_PLANILLA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cDESCUENTOS_PLANILLA
        Dim Lista As New ListaDESCUENTOS_PLANILLA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DESCUENTO_PLANILLA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CATORCENA_ZAFRA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA
        Dim Lista As New ListaDESCUENTOS_PLANILLA

        Lista = miComponente.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DESCUENTO_PLANILLA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PLANILLA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA
        Dim Lista As New ListaDESCUENTOS_PLANILLA

        Lista = miComponente.ObtenerListaPorPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DESCUENTO_PLANILLA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_PLANILLA .
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA
        Dim Lista As New ListaDESCUENTOS_PLANILLA

        Lista = miComponente.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DESCUENTO_PLANILLA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_DESCUENTO .
    ''' </summary>
    ''' <param name="ID_TIPO_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_DESCUENTO(ByVal ID_TIPO_DESCTO As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA
        Dim Lista As New ListaDESCUENTOS_PLANILLA

        Lista = miComponente.ObtenerListaPorTIPO_DESCUENTO(ID_TIPO_DESCTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DESCUENTO_PLANILLA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla APLICACION_DESCTO .
    ''' </summary>
    ''' <param name="ID_APLICACION_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorAPLICACION_DESCTO(ByVal ID_APLICACION_DESCTO As Int32)
        Dim miComponente As New cDESCUENTOS_PLANILLA
        Dim Lista As New ListaDESCUENTOS_PLANILLA

        Lista = miComponente.ObtenerListaPorAPLICACION_DESCTO(ID_APLICACION_DESCTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DESCUENTO_PLANILLA"

        Me.DataBind()

    End Sub

End Class
