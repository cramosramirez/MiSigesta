Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbOPCION_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla OPCION_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_OPCION_PERFIL"), ToolboxData("<{0}:lbOPCION_PERFIL runat=server></{0}:lbOPCION_PERFIL>")> _
Public Class lbOPCION_PERFIL
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla OPCION_PERFIL.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cOPCION_PERFIL
        Dim Lista As New ListaOPCION_PERFIL

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ACTIVO"
        Me.DataValueField = "ID_OPCION_PERFIL"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PERFIL .
    ''' </summary>
    ''' <param name="ID_PERFIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPERFIL(ByVal ID_PERFIL As Int32)
        Dim miComponente As New cOPCION_PERFIL
        Dim Lista As New ListaOPCION_PERFIL

        Lista = miComponente.ObtenerListaPorPERFIL(ID_PERFIL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ACTIVO"
        Me.DataValueField = "ID_OPCION_PERFIL"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla OPCION .
    ''' </summary>
    ''' <param name="ID_OPCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorOPCION(ByVal ID_OPCION As Int32)
        Dim miComponente As New cOPCION_PERFIL
        Dim Lista As New ListaOPCION_PERFIL

        Lista = miComponente.ObtenerListaPorOPCION(ID_OPCION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ACTIVO"
        Me.DataValueField = "ID_OPCION_PERFIL"

        Me.DataBind()

    End Sub

End Class
