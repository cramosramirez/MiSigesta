Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlSOLIC_AGRICOLA_PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla SOLIC_AGRICOLA_PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_SOLIC_AGRI_PROD"), ToolboxData("<{0}:ddlSOLIC_AGRICOLA_PRODUCTO runat=server></{0}:ddlSOLIC_AGRICOLA_PRODUCTO>")> _
Public Class ddlSOLIC_AGRICOLA_PRODUCTO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSOLIC_AGRICOLA_PRODUCTO
        Dim Lista As New ListaSOLIC_AGRICOLA_PRODUCTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PRECIO_UNITARIO"
        Me.DataValueField = "ID_SOLIC_AGRI_PROD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla SOLIC_AGRICOLA_PRODUCTO.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SOLIC_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32)
        Dim miComponente As New cSOLIC_AGRICOLA_PRODUCTO
        Dim Lista As New ListaSOLIC_AGRICOLA_PRODUCTO

        Lista = miComponente.ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PRECIO_UNITARIO"
        Me.DataValueField = "ID_SOLIC_AGRI_PROD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PRODUCTO .
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPRODUCTO(ByVal ID_PRODUCTO As Int32)
        Dim miComponente As New cSOLIC_AGRICOLA_PRODUCTO
        Dim Lista As New ListaSOLIC_AGRICOLA_PRODUCTO

        Lista = miComponente.ObtenerListaPorPRODUCTO(ID_PRODUCTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PRECIO_UNITARIO"
        Me.DataValueField = "ID_SOLIC_AGRI_PROD"

        Me.DataBind()

    End Sub

End Class
