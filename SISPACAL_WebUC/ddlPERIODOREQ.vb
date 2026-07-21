Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPERIODOREQ
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PERIODOREQ
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PERIODOREQ"), ToolboxData("<{0}:ddlPERIODOREQ runat=server></{0}:ddlPERIODOREQ>")> _
Public Class ddlPERIODOREQ
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPERIODOREQ
        Dim Lista As New ListaPERIODOREQ

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DESCRIP_PERIODO"
        Me.DataValueField = "ID_PERIODOREQ"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PERIODOREQ.
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
