Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbLABFAB_INFOVARSXDIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla LABFAB_INFOVARSXDIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_INFOVARSXDIA"), ToolboxData("<{0}:lbLABFAB_INFOVARSXDIA runat=server></{0}:lbLABFAB_INFOVARSXDIA>")> _
Public Class lbLABFAB_INFOVARSXDIA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla LABFAB_INFOVARSXDIA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cLABFAB_INFOVARSXDIA
        Dim Lista As New ListaLABFAB_INFOVARSXDIA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_INFOVAR"
        Me.DataValueField = "ID_INFOVARSXDIA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LABFAB_INFORME .
    ''' </summary>
    ''' <param name="ID_INFO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLABFAB_INFORME(ByVal ID_INFO As Int32)
        Dim miComponente As New cLABFAB_INFOVARSXDIA
        Dim Lista As New ListaLABFAB_INFOVARSXDIA

        Lista = miComponente.ObtenerListaPorLABFAB_INFORME(ID_INFO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_INFOVAR"
        Me.DataValueField = "ID_INFOVARSXDIA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LABFAB_DIAZAFRA .
    ''' </summary>
    ''' <param name="ID_DIAZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLABFAB_DIAZAFRA(ByVal ID_DIAZAFRA As Int32)
        Dim miComponente As New cLABFAB_INFOVARSXDIA
        Dim Lista As New ListaLABFAB_INFOVARSXDIA

        Lista = miComponente.ObtenerListaPorLABFAB_DIAZAFRA(ID_DIAZAFRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_INFOVAR"
        Me.DataValueField = "ID_INFOVARSXDIA"

        Me.DataBind()

    End Sub

End Class
