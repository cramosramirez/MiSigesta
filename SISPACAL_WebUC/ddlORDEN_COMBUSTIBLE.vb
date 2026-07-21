Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlORDEN_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ORDEN_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ORDEN_COMBUS"), ToolboxData("<{0}:ddlORDEN_COMBUSTIBLE runat=server></{0}:ddlORDEN_COMBUSTIBLE>")> _
Public Class ddlORDEN_COMBUSTIBLE
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cORDEN_COMBUSTIBLE
        Dim Lista As New ListaORDEN_COMBUSTIBLE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_TRANSPORTE"
        Me.DataValueField = "ID_ORDEN_COMBUS"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ORDEN_COMBUSTIBLE.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZAFRA(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE
        Dim Lista As New ListaORDEN_COMBUSTIBLE

        Lista = miComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_TRANSPORTE"
        Me.DataValueField = "ID_ORDEN_COMBUS"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_COMBUSTIBLE .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_COMBUSTIBLE(ByVal ID_PROVEEDOR_COMBUS As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE
        Dim Lista As New ListaORDEN_COMBUSTIBLE

        Lista = miComponente.ObtenerListaPorPROVEEDOR_COMBUSTIBLE(ID_PROVEEDOR_COMBUS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_TRANSPORTE"
        Me.DataValueField = "ID_ORDEN_COMBUS"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_PROVEEDOR .
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE
        Dim Lista As New ListaORDEN_COMBUSTIBLE

        Lista = miComponente.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_TRANSPORTE"
        Me.DataValueField = "ID_ORDEN_COMBUS"

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
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE
        Dim Lista As New ListaORDEN_COMBUSTIBLE

        Lista = miComponente.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_TRANSPORTE"
        Me.DataValueField = "ID_ORDEN_COMBUS"

        Me.DataBind()

    End Sub

End Class
