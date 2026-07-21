Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPROVEEDOR_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PROVEEDOR_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PROVEEDOR_COMBUS"), ToolboxData("<{0}:ddlPROVEEDOR_COMBUSTIBLE runat=server></{0}:ddlPROVEEDOR_COMBUSTIBLE>")> _
Public Class ddlPROVEEDOR_COMBUSTIBLE
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPROVEEDOR_COMBUSTIBLE
        Dim Lista As New ListaPROVEEDOR_COMBUSTIBLE

        Lista = miComponente.ObtenerLista(False, "NOMBRE_PROVEEDOR_COMBUS")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR_COMBUS"
        Me.DataValueField = "ID_PROVEEDOR_COMBUS"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PROVEEDOR_COMBUSTIBLE.
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
