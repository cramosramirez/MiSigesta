Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlORDEN_ROZA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ORDEN_ROZA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ORDEN"), ToolboxData("<{0}:ddlORDEN_ROZA_ENCA runat=server></{0}:ddlORDEN_ROZA_ENCA>")> _
Public Class ddlORDEN_ROZA_ENCA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cORDEN_ROZA_ENCA
        Dim Lista As New ListaORDEN_ROZA_ENCA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_ORDEN"
        Me.DataValueField = "ID_ORDEN"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ORDEN_ROZA_ENCA.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PLAN_SEMANAL .
    ''' </summary>
    ''' <param name="ID_PLAN_SEMANAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLAN_SEMANAL(ByVal ID_PLAN_SEMANAL As Int32)
        Dim miComponente As New cORDEN_ROZA_ENCA
        Dim Lista As New ListaORDEN_ROZA_ENCA

        Lista = miComponente.ObtenerListaPorPLAN_SEMANAL(ID_PLAN_SEMANAL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_ORDEN"
        Me.DataValueField = "ID_ORDEN"

        Me.DataBind()

    End Sub

End Class
