Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbDISTRIBUCION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla DISTRIBUCION_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DISTRIB_DESCTO"), ToolboxData("<{0}:lbDISTRIBUCION_DESCTO runat=server></{0}:lbDISTRIBUCION_DESCTO>")> _
Public Class lbDISTRIBUCION_DESCTO
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla DISTRIBUCION_DESCTO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cDISTRIBUCION_DESCTO
        Dim Lista As New ListaDISTRIBUCION_DESCTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DISTRIB_DESCTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CONTRATO .
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCONTRATO(ByVal CODICONTRATO As String)
        Dim miComponente As New cDISTRIBUCION_DESCTO
        Dim Lista As New ListaDISTRIBUCION_DESCTO

        Lista = miComponente.ObtenerListaPorCONTRATO(CODICONTRATO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DISTRIB_DESCTO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LOTES .
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLOTES(ByVal ACCESLOTE As String)
        Dim miComponente As New cDISTRIBUCION_DESCTO
        Dim Lista As New ListaDISTRIBUCION_DESCTO

        Lista = miComponente.ObtenerListaPorLOTES(ACCESLOTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DISTRIB_DESCTO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DESCUENTOS_PLANILLA .
    ''' </summary>
    ''' <param name="ID_DESCUENTO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32)
        Dim miComponente As New cDISTRIBUCION_DESCTO
        Dim Lista As New ListaDISTRIBUCION_DESCTO

        Lista = miComponente.ObtenerListaPorDESCUENTOS_PLANILLA(ID_DESCUENTO_PLANILLA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESCUENTO"
        Me.DataValueField = "ID_DISTRIB_DESCTO"

        Me.DataBind()

    End Sub

End Class
