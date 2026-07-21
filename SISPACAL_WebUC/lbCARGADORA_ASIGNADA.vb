Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbCARGADORA_ASIGNADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla CARGADORA_ASIGNADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CARGADORA_ASIG"), ToolboxData("<{0}:lbCARGADORA_ASIGNADA runat=server></{0}:lbCARGADORA_ASIGNADA>")> _
Public Class lbCARGADORA_ASIGNADA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla CARGADORA_ASIGNADA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cCARGADORA_ASIGNADA
        Dim Lista As New ListaCARGADORA_ASIGNADA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_CARGADORA_ASIG"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CARGADORA .
    ''' </summary>
    ''' <param name="ID_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCARGADORA(ByVal ID_CARGADORA As Int32)
        Dim miComponente As New cCARGADORA_ASIGNADA
        Dim Lista As New ListaCARGADORA_ASIGNADA

        Lista = miComponente.ObtenerListaPorCARGADORA(ID_CARGADORA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_CARGADORA_ASIG"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CARGADOR .
    ''' </summary>
    ''' <param name="ID_CARGADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCARGADOR(ByVal ID_CARGADOR As Int32)
        Dim miComponente As New cCARGADORA_ASIGNADA
        Dim Lista As New ListaCARGADORA_ASIGNADA

        Lista = miComponente.ObtenerListaPorCARGADOR(ID_CARGADOR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USUARIO_CREA"
        Me.DataValueField = "ID_CARGADORA_ASIG"

        Me.DataBind()

    End Sub

End Class
