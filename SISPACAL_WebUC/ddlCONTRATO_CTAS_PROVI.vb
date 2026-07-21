Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlCONTRATO_CTAS_PROVI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CONTRATO_CTAS_PROVI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CONTRATO_CTAS_PROVI"), ToolboxData("<{0}:ddlCONTRATO_CTAS_PROVI runat=server></{0}:ddlCONTRATO_CTAS_PROVI>")> _
Public Class ddlCONTRATO_CTAS_PROVI
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCONTRATO_CTAS_PROVI
        Dim Lista As New ListaCONTRATO_CTAS_PROVI

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_APLICA"
        Me.DataValueField = "ID_CONTRATO_CTAS_PROVI"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CONTRATO_CTAS_PROVI.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CONTRATO_FINAN .
    ''' </summary>
    ''' <param name="ID_CONTRATO_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32)
        Dim miComponente As New cCONTRATO_CTAS_PROVI
        Dim Lista As New ListaCONTRATO_CTAS_PROVI

        Lista = miComponente.ObtenerListaPorCONTRATO_FINAN(ID_CONTRATO_FINAN)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_APLICA"
        Me.DataValueField = "ID_CONTRATO_CTAS_PROVI"

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
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCONTRATO(ByVal CODICONTRATO As String)
        Dim miComponente As New cCONTRATO_CTAS_PROVI
        Dim Lista As New ListaCONTRATO_CTAS_PROVI

        Lista = miComponente.ObtenerListaPorCONTRATO(CODICONTRATO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_APLICA"
        Me.DataValueField = "ID_CONTRATO_CTAS_PROVI"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZAFRA(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cCONTRATO_CTAS_PROVI
        Dim Lista As New ListaCONTRATO_CTAS_PROVI

        Lista = miComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_APLICA"
        Me.DataValueField = "ID_CONTRATO_CTAS_PROVI"

        Me.DataBind()

    End Sub

End Class
