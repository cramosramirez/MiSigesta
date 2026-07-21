Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PRODUCTO"), ToolboxData("<{0}:ddlPRODUCTO runat=server></{0}:ddlPRODUCTO>")> _
Public Class ddlPRODUCTO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPRODUCTO
        Dim Lista As New ListaPRODUCTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PRODUCTO"
        Me.DataValueField = "ID_PRODUCTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PRODUCTO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CATEGORIA_PROD .
    ''' </summary>
    ''' <param name="ID_CATEGORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCATEGORIA_PROD(ByVal ID_CATEGORIA As Int32)
        Dim miComponente As New cPRODUCTO
        Dim Lista As New ListaPRODUCTO

        Lista = miComponente.ObtenerListaPorCATEGORIA_PROD(ID_CATEGORIA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PRODUCTO"
        Me.DataValueField = "ID_PRODUCTO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla UNIDAD_MEDIDA .
    ''' </summary>
    ''' <param name="ID_UNIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorUNIDAD_MEDIDA(ByVal ID_UNIDAD As Int32)
        Dim miComponente As New cPRODUCTO
        Dim Lista As New ListaPRODUCTO

        Lista = miComponente.ObtenerListaPorUNIDAD_MEDIDA(ID_UNIDAD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PRODUCTO"
        Me.DataValueField = "ID_PRODUCTO"

        Me.DataBind()

    End Sub

End Class
