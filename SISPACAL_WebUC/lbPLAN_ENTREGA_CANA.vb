Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbPLAN_ENTREGA_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla PLAN_ENTREGA_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PLAN_ENTREGA_CANA"), ToolboxData("<{0}:lbPLAN_ENTREGA_CANA runat=server></{0}:lbPLAN_ENTREGA_CANA>")> _
Public Class lbPLAN_ENTREGA_CANA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla PLAN_ENTREGA_CANA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cPLAN_ENTREGA_CANA
        Dim Lista As New ListaPLAN_ENTREGA_CANA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_PLAN_ENTREGA_CANA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PLAN_SEMANAL .
    ''' </summary>
    ''' <param name="ID_PLAN_SEMANAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLAN_SEMANAL(ByVal ID_PLAN_SEMANAL As Int32)
        Dim miComponente As New cPLAN_ENTREGA_CANA
        Dim Lista As New ListaPLAN_ENTREGA_CANA

        Lista = miComponente.ObtenerListaPorPLAN_SEMANAL(ID_PLAN_SEMANAL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_PLAN_ENTREGA_CANA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LOTES .
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLOTES(ByVal ACCESLOTE As String)
        Dim miComponente As New cPLAN_ENTREGA_CANA
        Dim Lista As New ListaPLAN_ENTREGA_CANA

        Lista = miComponente.ObtenerListaPorLOTES(ACCESLOTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_PLAN_ENTREGA_CANA"

        Me.DataBind()

    End Sub

End Class
