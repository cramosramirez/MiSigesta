Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlSECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla SECCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_SECCION"), ToolboxData("<{0}:ddlSECCION runat=server></{0}:ddlSECCION>")> _
Public Class ddlSECCION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSECCION
        Dim Lista As New ListaSECCION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SECCION"
        Me.DataValueField = "ID_SECCION"

        Me.DataBind()
    End Sub


    Public Sub RecuperarListaParaRequisicion(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cSECCION
        Dim Lista As New listaSECCION
        Dim lEntidad As SECCION

        Lista = miComponente.ObtenerListaParaRequisicion()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            lEntidad = New SECCION
            lEntidad.ID_SECCION = -1
            lEntidad.NOMBRE_SECCION = ""
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            lEntidad = New SECCION
            lEntidad.ID_SECCION = -1
            lEntidad.NOMBRE_SECCION = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SECCION"
        Me.DataValueField = "ID_SECCION"

        Me.DataBind()
    End Sub

    Public Sub RecuperarListaParaOrdenCombustible(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cSECCION
        Dim Lista As New listaSECCION
        Dim lEntidad As SECCION

        Lista = miComponente.ObtenerListaParaOrdenCombustible()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            lEntidad = New SECCION
            lEntidad.ID_SECCION = -1
            lEntidad.NOMBRE_SECCION = ""
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            lEntidad = New SECCION
            lEntidad.ID_SECCION = -1
            lEntidad.NOMBRE_SECCION = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SECCION"
        Me.DataValueField = "ID_SECCION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla SECCION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
