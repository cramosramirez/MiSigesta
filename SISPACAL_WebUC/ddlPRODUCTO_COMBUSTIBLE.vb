Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPRODUCTO_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PRODUCTO_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PRODUCTO"), ToolboxData("<{0}:ddlPRODUCTO_COMBUSTIBLE runat=server></{0}:ddlPRODUCTO_COMBUSTIBLE>")> _
Public Class ddlPRODUCTO_COMBUSTIBLE
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPRODUCTO_COMBUSTIBLE
        Dim Lista As New ListaPRODUCTO_COMBUSTIBLE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PRODUCTO"
        Me.DataValueField = "ID_PRODUCTO"

        Me.DataBind()
    End Sub
    
End Class
