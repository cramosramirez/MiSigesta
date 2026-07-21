Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbPLAN_SEMANAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla PLAN_SEMANAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PLAN_SEMANAL"), ToolboxData("<{0}:lbPLAN_SEMANAL runat=server></{0}:lbPLAN_SEMANAL>")> _
Public Class lbPLAN_SEMANAL
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla PLAN_SEMANAL.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cPLAN_SEMANAL
        Dim Lista As New ListaPLAN_SEMANAL

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_INICIO"
        Me.DataValueField = "ID_PLAN_SEMANAL"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PLAN_CATORCENA .
    ''' </summary>
    ''' <param name="ID_PLAN_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLAN_CATORCENA(ByVal ID_PLAN_CATORCENA As Int32)
        Dim miComponente As New cPLAN_SEMANAL
        Dim Lista As New ListaPLAN_SEMANAL

        Lista = miComponente.ObtenerListaPorPLAN_CATORCENA(ID_PLAN_CATORCENA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_INICIO"
        Me.DataValueField = "ID_PLAN_SEMANAL"

        Me.DataBind()

    End Sub

End Class
