Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlLOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ACCESLOTE"), ToolboxData("<{0}:ddlLOTES runat=server></{0}:ddlLOTES>")> _
Public Class ddlLOTES
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cLOTES
        Dim Lista As New ListaLOTES

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANIOZAFRA"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla LOTES.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR .
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR(ByVal CODIPROVEEDOR As String)
        Dim miComponente As New cLOTES
        Dim Lista As New ListaLOTES

        Lista = miComponente.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANIOZAFRA"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla AGRONOMO .
    ''' </summary>
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorAGRONOMO(ByVal CODIAGRON As String)
        Dim miComponente As New cLOTES
        Dim Lista As New ListaLOTES

        Lista = miComponente.ObtenerListaPorAGRONOMO(CODIAGRON)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANIOZAFRA"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla VARIEDAD .
    ''' </summary>
    ''' <param name="CODIVARIEDA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorVARIEDAD(ByVal CODIVARIEDA As String)
        Dim miComponente As New cLOTES
        Dim Lista As New ListaLOTES

        Lista = miComponente.ObtenerListaPorVARIEDAD(CODIVARIEDA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANIOZAFRA"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla UBICACION .
    ''' </summary>
    ''' <param name="CODIUBICACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorUBICACION(ByVal CODIUBICACION As String)
        Dim miComponente As New cLOTES
        Dim Lista As New ListaLOTES

        Lista = miComponente.ObtenerListaPorUBICACION(CODIUBICACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANIOZAFRA"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CONTRATO .
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCONTRATO(ByVal CODICONTRATO As String)
        Dim miComponente As New cLOTES
        Dim Lista As New ListaLOTES

        Lista = miComponente.ObtenerListaPorCONTRATO(CODICONTRATO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANIOZAFRA"
        Me.DataValueField = "ACCESLOTE"

        Me.DataBind()

    End Sub

End Class
