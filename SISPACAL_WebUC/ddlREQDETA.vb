Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlREQDETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla REQDETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_REQDETA"), ToolboxData("<{0}:ddlREQDETA runat=server></{0}:ddlREQDETA>")> _
Public Class ddlREQDETA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cREQDETA
        Dim Lista As New ListaREQDETA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO"
        Me.DataValueField = "ID_REQDETA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla REQDETA.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla REQENCA .
    ''' </summary>
    ''' <param name="ID_REQENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorREQENCA(ByVal ID_REQENCA As Int32)
        Dim miComponente As New cREQDETA
        Dim Lista As New ListaREQDETA

        Lista = miComponente.ObtenerListaPorREQENCA(ID_REQENCA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO"
        Me.DataValueField = "ID_REQDETA"

        Me.DataBind()

    End Sub

End Class
