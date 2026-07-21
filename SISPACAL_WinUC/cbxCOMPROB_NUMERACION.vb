Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WinUC
''' Class	 : WinUC.ddlCATORCENA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla CATORCENA_ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxCOMPROB_NUMERACION
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCOMPROB_NUMERACION
        Dim Lista As New listaCOMPROB_NUMERACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "SERIE"
        Me.ValueMember = "ID_COMPROB_NUME"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_TIPO_COMPROB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_DOCUMENTO(ByVal ID_TIPO_COMPROB As Int32)
        Dim miComponente As New cCOMPROB_NUMERACION
        Dim Lista As New listaCOMPROB_NUMERACION

        Lista = miComponente.ObtenerListaPorTIPO_COMPROB(ID_TIPO_COMPROB)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "SERIE"
        Me.ValueMember = "ID_COMPROB_NUME"
        Me.DataSource = Lista
    End Sub

End Class
