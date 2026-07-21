Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlCHEQUERA_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CHEQUERA_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CHEQUERA"), ToolboxData("<{0}:ddlCHEQUERA_PLANILLA runat=server></{0}:ddlCHEQUERA_PLANILLA>")> _
Public Class ddlCHEQUERA_PLANILLA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCHEQUERA_PLANILLA
        Dim Lista As New ListaCHEQUERA_PLANILLA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "SERIE"
        Me.DataValueField = "ID_CHEQUERA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CHEQUERA_PLANILLA.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CUENTA_BANCARIA .
    ''' </summary>
    ''' <param name="ID_CUENTA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCUENTA_BANCARIA(ByVal ID_CUENTA As Int32)
        Dim miComponente As New cCHEQUERA_PLANILLA
        Dim Lista As New ListaCHEQUERA_PLANILLA

        Lista = miComponente.ObtenerListaPorCUENTA_BANCARIA(ID_CUENTA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "SERIE"
        Me.DataValueField = "ID_CHEQUERA"

        Me.DataBind()

    End Sub

End Class
