Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlCHEQUE_PARTIDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CHEQUE_PARTIDA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CHEQUE_PARTIDA"), ToolboxData("<{0}:ddlCHEQUE_PARTIDA runat=server></{0}:ddlCHEQUE_PARTIDA>")> _
Public Class ddlCHEQUE_PARTIDA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCHEQUE_PARTIDA
        Dim Lista As New ListaCHEQUE_PARTIDA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ORDEN"
        Me.DataValueField = "ID_CHEQUE_PARTIDA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CHEQUE_PARTIDA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CHEQUE_PLANILLA .
    ''' </summary>
    ''' <param name="ID_CHEQUE_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCHEQUE_PLANILLA(ByVal ID_CHEQUE_PLANILLA As Int32)
        Dim miComponente As New cCHEQUE_PARTIDA
        Dim Lista As New ListaCHEQUE_PARTIDA

        Lista = miComponente.ObtenerListaPorCHEQUE_PLANILLA(ID_CHEQUE_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ORDEN"
        Me.DataValueField = "ID_CHEQUE_PARTIDA"

        Me.DataBind()

    End Sub

End Class
