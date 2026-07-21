Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlLECTURA_POR_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla LECTURA_POR_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_LECTURA_PERFIL"), ToolboxData("<{0}:ddlLECTURA_POR_PERFIL runat=server></{0}:ddlLECTURA_POR_PERFIL>")> _
Public Class ddlLECTURA_POR_PERFIL
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cLECTURA_POR_PERFIL
        Dim Lista As New ListaLECTURA_POR_PERFIL

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_LECTURA_PERFIL"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla LECTURA_POR_PERFIL.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PERFIL .
    ''' </summary>
    ''' <param name="ID_PERFIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPERFIL(ByVal ID_PERFIL As Int32)
        Dim miComponente As New cLECTURA_POR_PERFIL
        Dim Lista As New ListaLECTURA_POR_PERFIL

        Lista = miComponente.ObtenerListaPorPERFIL(ID_PERFIL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_LECTURA_PERFIL"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_LECTURA .
    ''' </summary>
    ''' <param name="ID_TIPO_LECTURA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_LECTURA(ByVal ID_TIPO_LECTURA As Int32)
        Dim miComponente As New cLECTURA_POR_PERFIL
        Dim Lista As New ListaLECTURA_POR_PERFIL

        Lista = miComponente.ObtenerListaPorTIPO_LECTURA(ID_TIPO_LECTURA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_LECTURA_PERFIL"

        Me.DataBind()

    End Sub

End Class
