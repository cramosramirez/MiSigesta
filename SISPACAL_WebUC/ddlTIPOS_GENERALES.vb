Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlTIPO_TRANSPORTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_TRANSPORTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO"), ToolboxData("<{0}:ddlTIPOS_GENERALES runat=server></{0}:ddlTIPOS_GENERALES>")> _
Public Class ddlTIPOS_GENERALES
    Inherits ddlBase


    Private Sub RecuperarListaPorTipoCAT(ByVal ID_TIPO_TABLA As Int32)
        Dim miComponente As New cTIPOS_GENERALES
        Dim Lista As New listaTIPOS_GENERALES
        Dim ListaFinal As New listaTIPOS_GENERALES

        Lista = miComponente.ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Alza, -1)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOM_TIPO"
        Me.DataValueField = "ID_TIPO"

        Me.DataBind()
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_TRANSPORTE.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTipoCAT(ByVal ID_TIPO_TABLA As Int32)
        RecuperarListaPorTipoCAT(ID_TIPO_TABLA)
    End Sub

End Class
