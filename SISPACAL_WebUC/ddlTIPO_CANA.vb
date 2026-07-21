Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlTIPO_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_CANA"), ToolboxData("<{0}:ddlTIPO_CANA runat=server></{0}:ddlTIPO_CANA>")> _
Public Class ddlTIPO_CANA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_CANA
        Dim Lista As New ListaTIPO_CANA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_CANA"
        Me.DataValueField = "ID_TIPO_CANA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_CANA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    Public Sub RecuperarCanaCorta()
        Dim miComponente As New cTIPO_CANA
        Dim Lista As New listaTIPO_CANA

        Lista.Add(miComponente.ObtenerTIPO_CANA(35))
        Lista.Add(miComponente.ObtenerTIPO_CANA(43))

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_CANA"
        Me.DataValueField = "ID_TIPO_CANA"

        Me.DataBind()
    End Sub

    Public Sub RecuperarCanaLarga()
        Dim miComponente As New cTIPO_CANA
        Dim Lista As New listaTIPO_CANA

        Lista.Add(miComponente.ObtenerTIPO_CANA(19))
        Lista.Add(miComponente.ObtenerTIPO_CANA(27))

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_CANA"
        Me.DataValueField = "ID_TIPO_CANA"

        Me.DataBind()
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_CANA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cTIPO_CANA
        Dim Lista As New listaTIPO_CANA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New TIPO_CANA
            lEntidad.ID_TIPO_CANA = 0
            lEntidad.NOMBRE_CANA = " "
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New TIPO_CANA
            lEntidad.ID_TIPO_CANA = 0
            lEntidad.NOMBRE_CANA = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_CANA"
        Me.DataValueField = "ID_TIPO_CANA"

        Me.DataBind()
    End Sub
End Class
