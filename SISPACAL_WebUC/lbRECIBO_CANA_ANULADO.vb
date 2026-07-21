Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbRECIBO_CANA_ANULADO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla RECIBO_CANA_ANULADO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_RECIBO_CANA_ANUL"), ToolboxData("<{0}:lbRECIBO_CANA_ANULADO runat=server></{0}:lbRECIBO_CANA_ANULADO>")> _
Public Class lbRECIBO_CANA_ANULADO
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla RECIBO_CANA_ANULADO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cRECIBO_CANA_ANULADO
        Dim Lista As New ListaRECIBO_CANA_ANULADO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMRECIBO_CANA"
        Me.DataValueField = "ID_RECIBO_CANA_ANUL"

        Me.DataBind()
    End Sub

End Class
