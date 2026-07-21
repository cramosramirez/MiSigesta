Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbCUENTA_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla CUENTA_PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CUENTA_PROVEEDOR"), ToolboxData("<{0}:lbCUENTA_PROVEEDOR runat=server></{0}:lbCUENTA_PROVEEDOR>")> _
Public Class lbCUENTA_PROVEEDOR
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla CUENTA_PROVEEDOR.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cCUENTA_PROVEEDOR
        Dim Lista As New ListaCUENTA_PROVEEDOR

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUENTA"
        Me.DataValueField = "ID_CUENTA_PROVEEDOR"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_PROVEEDOR .
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32)
        Dim miComponente As New cCUENTA_PROVEEDOR
        Dim Lista As New ListaCUENTA_PROVEEDOR

        Lista = miComponente.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUENTA"
        Me.DataValueField = "ID_CUENTA_PROVEEDOR"

        Me.DataBind()

    End Sub

End Class
