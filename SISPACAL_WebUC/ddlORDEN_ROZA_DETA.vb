Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlORDEN_ROZA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ORDEN_ROZA_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ORDEN_DETA"), ToolboxData("<{0}:ddlORDEN_ROZA_DETA runat=server></{0}:ddlORDEN_ROZA_DETA>")> _
Public Class ddlORDEN_ROZA_DETA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cORDEN_ROZA_DETA
        Dim Lista As New ListaORDEN_ROZA_DETA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ACCESLOTE"
        Me.DataValueField = "ID_ORDEN_DETA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ORDEN_ROZA_DETA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ORDEN_ROZA_ENCA .
    ''' </summary>
    ''' <param name="ID_ORDEN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorORDEN_ROZA_ENCA(ByVal ID_ORDEN As Int32)
        Dim miComponente As New cORDEN_ROZA_DETA
        Dim Lista As New ListaORDEN_ROZA_DETA

        Lista = miComponente.ObtenerListaPorORDEN_ROZA_ENCA(ID_ORDEN)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ACCESLOTE"
        Me.DataValueField = "ID_ORDEN_DETA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PLAN_ENTREGA_CANA .
    ''' </summary>
    ''' <param name="ID_PLAN_ENTREGA_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLAN_ENTREGA_CANA(ByVal ID_PLAN_ENTREGA_CANA As Int32)
        Dim miComponente As New cORDEN_ROZA_DETA
        Dim Lista As New ListaORDEN_ROZA_DETA

        Lista = miComponente.ObtenerListaPorPLAN_ENTREGA_CANA(ID_PLAN_ENTREGA_CANA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ACCESLOTE"
        Me.DataValueField = "ID_ORDEN_DETA"

        Me.DataBind()

    End Sub

End Class
