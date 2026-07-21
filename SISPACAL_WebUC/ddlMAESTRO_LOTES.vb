Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlMAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_MAESTRO"), ToolboxData("<{0}:ddlMAESTRO_LOTES runat=server></{0}:ddlMAESTRO_LOTES>")> _
Public Class ddlMAESTRO_LOTES
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla MAESTRO_LOTES.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CANTON .
    ''' </summary>
    ''' <param name="CODI_CANTON"></param>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCANTON(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorCANTON(CODI_CANTON, CODI_DEPTO, CODI_MUNI)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ZONAS .
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZONAS(ByVal ZONA As String)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorZONAS(ZONA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SUB_ZONAS .
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <param name="SUB_ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSUB_ZONAS(ByVal ZONA As String, ByVal SUB_ZONA As String)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorSUB_ZONAS(ZONA, SUB_ZONA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla COMPORTAMIENTO_CANA .
    ''' </summary>
    ''' <param name="ID_COMPOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCOMPORTAMIENTO_CANA(ByVal ID_COMPOR As Int32)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorCOMPORTAMIENTO_CANA(ID_COMPOR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_SUELO .
    ''' </summary>
    ''' <param name="COD_TIPO_SUELO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_SUELO(ByVal COD_TIPO_SUELO As String)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorTIPO_SUELO(COD_TIPO_SUELO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CONDICION_SIEMBRA .
    ''' </summary>
    ''' <param name="ID_COND_SIEMBRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCONDICION_SIEMBRA(ByVal ID_COND_SIEMBRA As Int32)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorCONDICION_SIEMBRA(ID_COND_SIEMBRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla NIVEL_HUMEDAD .
    ''' </summary>
    ''' <param name="ID_NIVEL_HUMEDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorNIVEL_HUMEDAD(ByVal ID_NIVEL_HUMEDAD As Int32)
        Dim miComponente As New cMAESTRO_LOTES
        Dim Lista As New listaMAESTRO_LOTES

        Lista = miComponente.ObtenerListaPorNIVEL_HUMEDAD(ID_NIVEL_HUMEDAD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CUI"
        Me.DataValueField = "ID_MAESTRO"

        Me.DataBind()

    End Sub

End Class
