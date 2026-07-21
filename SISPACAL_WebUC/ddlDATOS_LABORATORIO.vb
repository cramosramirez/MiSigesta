Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlDATOS_LABORATORIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla DATOS_LABORATORIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DATOS_LAB"), ToolboxData("<{0}:ddlDATOS_LABORATORIO runat=server></{0}:ddlDATOS_LABORATORIO>")> _
Public Class ddlDATOS_LABORATORIO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cDATOS_LABORATORIO
        Dim Lista As New ListaDATOS_LABORATORIO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANALISTA"
        Me.DataValueField = "ID_DATOS_LAB"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla DATOS_LABORATORIO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ANALISIS .
    ''' </summary>
    ''' <param name="ID_ANALISIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorANALISIS(ByVal ID_ANALISIS As Int32)
        Dim miComponente As New cDATOS_LABORATORIO
        Dim Lista As New ListaDATOS_LABORATORIO

        Lista = miComponente.ObtenerListaPorANALISIS(ID_ANALISIS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ANALISTA"
        Me.DataValueField = "ID_DATOS_LAB"

        Me.DataBind()

    End Sub

End Class
