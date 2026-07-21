Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlMOTORISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla MOTORISTA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_MOTORISTA"), ToolboxData("<{0}:ddlMOTORISTA runat=server></{0}:ddlMOTORISTA>")> _
Public Class ddlMOTORISTA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cMOTORISTA
        Dim Lista As New ListaMOTORISTA

        Lista = miComponente.ObtenerLista(False, "NOMBRES, APELLIDOS")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_COMPLETO"
        Me.DataValueField = "ID_MOTORISTA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla MOTORISTA.
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

    Public Sub RecuperarPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32)
        Dim miComponente As New cMOTORISTA
        Dim Lista As New listaMOTORISTA

        Lista = miComponente.ObtenerListaPorTRANSPORTE(ID_TRANSPORTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        'If agregarVacio Then
        '    Dim lEntidad As New MOTORISTA
        '    lEntidad.ID_MOTORISTA = 0
        '    lEntidad.NOMBRE_COMPLETO = " "
        '    Lista.Insertar(0, lEntidad)
        'End If

        'If agregarTodos Then
        '    Dim lEntidad As New MOTORISTA
        '    lEntidad.ID_MOTORISTA = 0
        '    lEntidad.NOMBRE_COMPLETO = "[Todos]"
        '    Lista.Insertar(0, lEntidad)
        'End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_COMPLETO"
        Me.DataValueField = "ID_MOTORISTA"

        Me.DataBind()
    End Sub

End Class
