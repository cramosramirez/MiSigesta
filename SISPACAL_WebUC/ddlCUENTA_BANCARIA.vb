Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlCUENTA_BANCARIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CUENTA_BANCARIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("NO_CUENTA"), ToolboxData("<{0}:ddlCUENTA_BANCARIA runat=server></{0}:ddlCUENTA_BANCARIA>")> _
Public Class ddlCUENTA_BANCARIA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCUENTA_BANCARIA
        Dim Lista As New ListaCUENTA_BANCARIA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CUENTA"
        Me.DataValueField = "ID_CUENTA"

        Me.DataBind()
    End Sub

    Private Sub RecuperarListaActivas()
        Dim miComponente As New cCUENTA_BANCARIA
        Dim Lista As New listaCUENTA_BANCARIA

        Lista = miComponente.ObtenerCuentasBancariasActivas()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CUENTA"
        Me.DataValueField = "ID_CUENTA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CUENTA_BANCARIA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla BANCOS .
    ''' </summary>
    ''' <param name="CODIBANCO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorBANCOS(ByVal CODIBANCO As Int32)
        Dim miComponente As New cCUENTA_BANCARIA
        Dim Lista As New ListaCUENTA_BANCARIA

        Lista = miComponente.ObtenerListaPorBANCOS(CODIBANCO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CUENTA"
        Me.DataValueField = "ID_CUENTA"

        Me.DataBind()

    End Sub

End Class
