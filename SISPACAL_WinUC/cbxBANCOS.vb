Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WinUC
''' Class	 : WinUC.ddlBANCOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla BANCOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxBANCOS
    Inherits cbxBase

    Public Sub RecuperarPorCatorcena_Planilla_TipoContribuyente(ByVal ID_CATORCENA As Integer, _
                                                                 ByVal ID_TIPO_PLANILLA As Integer, _
                                                                 ByVal TIPO_CONTRIBUYENTE As Integer)
        Dim miComponente As New cBANCOS
        Dim Lista As New listaBANCOS

        Lista = miComponente.ObtenerPorCATORCENA_PLANILLA_tipoCONTRIBUYENTE(ID_CATORCENA, ID_TIPO_PLANILLA, TIPO_CONTRIBUYENTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_BANCO"
        Me.ValueMember = "CODIBANCO"
        Me.DataSource = Lista

    End Sub

    Private Sub RecuperarLista()
        Dim miComponente As New cBANCOS
        Dim Lista As New listaBANCOS

        Lista = miComponente.ObtenerLista(False, "NOMBRE_BANCO")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_BANCO"
        Me.ValueMember = "CODIBANCO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
