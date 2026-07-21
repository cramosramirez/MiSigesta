Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlORDEN_COMBUSTIBLE_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ORDEN_COMBUSTIBLE_NUMERACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ORDEN_COMBUSTIBLE_NUM"), ToolboxData("<{0}:ddlORDEN_COMBUSTIBLE_NUMERACION runat=server></{0}:ddlORDEN_COMBUSTIBLE_NUMERACION>")> _
Public Class ddlORDEN_COMBUSTIBLE_NUMERACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cORDEN_COMBUSTIBLE_NUMERACION
        Dim Lista As New ListaORDEN_COMBUSTIBLE_NUMERACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "SERIE_ORDEN_COMBUSTIBLE"
        Me.DataValueField = "ID_ORDEN_COMBUSTIBLE_NUM"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ORDEN_COMBUSTIBLE_NUMERACION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZAFRA(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cORDEN_COMBUSTIBLE_NUMERACION
        Dim Lista As New ListaORDEN_COMBUSTIBLE_NUMERACION

        Lista = miComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "SERIE_ORDEN_COMBUSTIBLE"
        Me.DataValueField = "ID_ORDEN_COMBUSTIBLE_NUM"

        Me.DataBind()

    End Sub

End Class
