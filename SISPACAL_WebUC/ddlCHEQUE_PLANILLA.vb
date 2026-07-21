Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlCHEQUE_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CHEQUE_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CHEQUE_PLANILLA"), ToolboxData("<{0}:ddlCHEQUE_PLANILLA runat=server></{0}:ddlCHEQUE_PLANILLA>")> _
Public Class ddlCHEQUE_PLANILLA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCHEQUE_PLANILLA
        Dim Lista As New ListaCHEQUE_PLANILLA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CHEQUE"
        Me.DataValueField = "ID_CHEQUE_PLANILLA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CHEQUE_PLANILLA.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CHEQUERA_PLANILLA .
    ''' </summary>
    ''' <param name="ID_CHEQUERA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCHEQUERA_PLANILLA(ByVal ID_CHEQUERA As Int32)
        Dim miComponente As New cCHEQUE_PLANILLA
        Dim Lista As New ListaCHEQUE_PLANILLA

        Lista = miComponente.ObtenerListaPorCHEQUERA_PLANILLA(ID_CHEQUERA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CHEQUE"
        Me.DataValueField = "ID_CHEQUE_PLANILLA"

        Me.DataBind()

    End Sub

End Class
