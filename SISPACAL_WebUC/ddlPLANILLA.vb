Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("CODIPROVEEDOR_TRANSPORTISTA"), ToolboxData("<{0}:ddlPLANILLA runat=server></{0}:ddlPLANILLA>")> _
Public Class ddlPLANILLA
    Inherits ddlBase

    Private Sub RecuperarLista(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32)
        Dim miComponente As New cPLANILLA
        Dim Lista As New ListaPLANILLA

        Lista = miComponente.ObtenerLista(ID_CATORCENA, ID_TIPO_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ZAFRA"
        Me.DataValueField = "CODIPROVEEDOR_TRANSPORTISTA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PLANILLA.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32)
        RecuperarLista(ID_CATORCENA, ID_TIPO_PLANILLA)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CATORCENA_ZAFRA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32)
        Dim miComponente As New cPLANILLA
        Dim Lista As New ListaPLANILLA

        Lista = miComponente.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ZAFRA"
        Me.DataValueField = "CODIPROVEEDOR_TRANSPORTISTA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_PLANILLA .
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32)
        Dim miComponente As New cPLANILLA
        Dim Lista As New ListaPLANILLA

        Lista = miComponente.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ZAFRA"
        Me.DataValueField = "CODIPROVEEDOR_TRANSPORTISTA"

        Me.DataBind()

    End Sub

End Class
