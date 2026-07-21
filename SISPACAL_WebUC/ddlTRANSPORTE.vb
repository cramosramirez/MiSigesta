Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlTRANSPORTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TRANSPORTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TRANSPORTE"), ToolboxData("<{0}:ddlTRANSPORTE runat=server></{0}:ddlTRANSPORTE>")> _
Public Class ddlTRANSPORTE
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTRANSPORTE
        Dim Lista As New ListaTRANSPORTE

        Lista = miComponente.ObtenerLista(False, False, "PLACA")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PLACA"
        Me.DataValueField = "ID_TRANSPORTE"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TRANSPORTE.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TRANSPORTISTA .
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32)
        Dim miComponente As New cTRANSPORTE
        Dim Lista As New ListaTRANSPORTE

        Lista = miComponente.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PLACA"
        Me.DataValueField = "ID_TRANSPORTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_TRANSPORTE .
    ''' </summary>
    ''' <param name="ID_TIPOTRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_TRANSPORTE(ByVal ID_TIPOTRANS As Int32)
        Dim miComponente As New cTRANSPORTE
        Dim Lista As New ListaTRANSPORTE

        Lista = miComponente.ObtenerListaPorTIPO_TRANSPORTE(ID_TIPOTRANS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PLACA"
        Me.DataValueField = "ID_TRANSPORTE"

        Me.DataBind()

    End Sub

End Class
