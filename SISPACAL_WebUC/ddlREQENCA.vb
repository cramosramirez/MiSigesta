Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlREQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_REQENCA"), ToolboxData("<{0}:ddlREQENCA runat=server></{0}:ddlREQENCA>")> _
Public Class ddlREQENCA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cREQENCA
        Dim Lista As New ListaREQENCA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_REQ"
        Me.DataValueField = "ID_REQENCA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla REQENCA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PERIODOREQ .
    ''' </summary>
    ''' <param name="ID_PERIODOREQ"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPERIODOREQ(ByVal ID_PERIODOREQ As Int32)
        Dim miComponente As New cREQENCA
        Dim Lista As New ListaREQENCA

        Lista = miComponente.ObtenerListaPorPERIODOREQ(ID_PERIODOREQ)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_REQ"
        Me.DataValueField = "ID_REQENCA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SECCION .
    ''' </summary>
    ''' <param name="ID_SECCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSECCION(ByVal ID_SECCION As Int32)
        Dim miComponente As New cREQENCA
        Dim Lista As New ListaREQENCA

        Lista = miComponente.ObtenerListaPorSECCION(ID_SECCION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_REQ"
        Me.DataValueField = "ID_REQENCA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SOLICITANTE .
    ''' </summary>
    ''' <param name="ID_SOLICITANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLICITANTE(ByVal ID_SOLICITANTE As Int32)
        Dim miComponente As New cREQENCA
        Dim Lista As New ListaREQENCA

        Lista = miComponente.ObtenerListaPorSOLICITANTE(ID_SOLICITANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_REQ"
        Me.DataValueField = "ID_REQENCA"

        Me.DataBind()

    End Sub

End Class
