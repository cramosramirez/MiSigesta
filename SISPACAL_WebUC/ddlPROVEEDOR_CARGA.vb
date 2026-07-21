Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPROVEEDOR_CARGA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PROVEEDOR_CARGA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PROVEEDOR_CARGA"), ToolboxData("<{0}:ddlPROVEEDOR_CARGA runat=server></{0}:ddlPROVEEDOR_CARGA>")> _
Public Class ddlPROVEEDOR_CARGA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPROVEEDOR_CARGA
        Dim Lista As New ListaPROVEEDOR_CARGA

        Lista = miComponente.ObtenerLista(False, "NOMBRE_PROVEEDOR_CARGA", "ASC")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR_CARGA"
        Me.DataValueField = "ID_PROVEEDOR_CARGA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PROVEEDOR_CARGA.
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
