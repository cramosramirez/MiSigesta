Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbMOTORISTA_VEHICULO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla MOTORISTA_VEHICULO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_MOTORISTA_VEHI"), ToolboxData("<{0}:lbMOTORISTA_VEHICULO runat=server></{0}:lbMOTORISTA_VEHICULO>")> _
Public Class lbMOTORISTA_VEHICULO
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla MOTORISTA_VEHICULO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cMOTORISTA_VEHICULO
        Dim Lista As New ListaMOTORISTA_VEHICULO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PLACAVEHIC"
        Me.DataValueField = "ID_MOTORISTA_VEHI"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla MOTORISTA .
    ''' </summary>
    ''' <param name="ID_MOTORISTA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMOTORISTA(ByVal ID_MOTORISTA As Int32)
        Dim miComponente As New cMOTORISTA_VEHICULO
        Dim Lista As New ListaMOTORISTA_VEHICULO

        Lista = miComponente.ObtenerListaPorMOTORISTA(ID_MOTORISTA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PLACAVEHIC"
        Me.DataValueField = "ID_MOTORISTA_VEHI"

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
    ''' 	[GenApp]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_TRANSPORTE(ByVal ID_TIPOTRANS As Int32)
        Dim miComponente As New cMOTORISTA_VEHICULO
        Dim Lista As New ListaMOTORISTA_VEHICULO

        'Lista = miComponente.ObtenerListaPorTIPO_TRANSPORTE(ID_TIPOTRANS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "PLACAVEHIC"
        Me.DataValueField = "ID_MOTORISTA_VEHI"

        Me.DataBind()

    End Sub

End Class
