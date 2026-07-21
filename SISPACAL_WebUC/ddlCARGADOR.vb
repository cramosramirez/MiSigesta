Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlCARGADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CARGADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CARGADOR"), ToolboxData("<{0}:ddlCARGADOR runat=server></{0}:ddlCARGADOR>")> _
Public Class ddlCARGADOR
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCARGADOR
        Dim Lista As New ListaCARGADOR

        Lista = miComponente.ObtenerLista(False, "NOMBRE_CARGADOR")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_CARGADOR"
        Me.DataValueField = "ID_CARGADOR"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CARGADOR.
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

End Class
