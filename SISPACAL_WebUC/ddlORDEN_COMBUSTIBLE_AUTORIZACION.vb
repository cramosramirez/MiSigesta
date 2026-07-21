Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlORDEN_COMBUSTIBLE_AUTORIZACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/02/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ORDEN_COMBUS_AUTO"), ToolboxData("<{0}:ddlORDEN_COMBUSTIBLE_AUTORIZACION runat=server></{0}:ddlORDEN_COMBUSTIBLE_AUTORIZACION>")> _
Public Class ddlORDEN_COMBUSTIBLE_AUTORIZACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cORDEN_COMBUSTIBLE_AUTORIZACION
        Dim Lista As New ListaORDEN_COMBUSTIBLE_AUTORIZACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO"
        Me.DataValueField = "ID_ORDEN_COMBUS_AUTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ORDEN_COMBUSTIBLE_AUTORIZACION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_PROVEEDOR .
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE_AUTORIZACION
        Dim Lista As New ListaORDEN_COMBUSTIBLE_AUTORIZACION

        Lista = miComponente.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO"
        Me.DataValueField = "ID_ORDEN_COMBUS_AUTO"

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
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE_AUTORIZACION
        Dim Lista As New ListaORDEN_COMBUSTIBLE_AUTORIZACION

        Lista = miComponente.ObtenerListaPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO"
        Me.DataValueField = "ID_ORDEN_COMBUS_AUTO"

        Me.DataBind()

    End Sub

End Class
