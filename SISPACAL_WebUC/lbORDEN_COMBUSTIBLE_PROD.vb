Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbORDEN_COMBUSTIBLE_PROD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla ORDEN_COMBUSTIBLE_PROD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ORDEN_COMBUSTIBLE_PROD"), ToolboxData("<{0}:lbORDEN_COMBUSTIBLE_PROD runat=server></{0}:lbORDEN_COMBUSTIBLE_PROD>")> _
Public Class lbORDEN_COMBUSTIBLE_PROD
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla ORDEN_COMBUSTIBLE_PROD.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cORDEN_COMBUSTIBLE_PROD
        Dim Lista As New ListaORDEN_COMBUSTIBLE_PROD

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CANTIDAD"
        Me.DataValueField = "ID_ORDEN_COMBUSTIBLE_PROD"

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
    ''' 	[GenApp]	03/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE_PROD
        Dim Lista As New ListaORDEN_COMBUSTIBLE_PROD

        Lista = miComponente.ObtenerListaPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CANTIDAD"
        Me.DataValueField = "ID_ORDEN_COMBUSTIBLE_PROD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PRODUCTO_COMBUSTIBLE .
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPRODUCTO_COMBUSTIBLE(ByVal ID_PRODUCTO As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE_PROD
        Dim Lista As New ListaORDEN_COMBUSTIBLE_PROD

        Lista = miComponente.ObtenerListaPorPRODUCTO_COMBUSTIBLE(ID_PRODUCTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CANTIDAD"
        Me.DataValueField = "ID_ORDEN_COMBUSTIBLE_PROD"

        Me.DataBind()

    End Sub

End Class
