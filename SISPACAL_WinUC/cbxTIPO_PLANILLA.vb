Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WinUC
''' Class	 : WinUC.ddlTIPO_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla TIPO_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxTIPO_PLANILLA
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_PLANILLA
        Dim Lista As New listaTIPO_PLANILLA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_TIPO_PLANILLA"
        Me.ValueMember = "ID_TIPO_PLANILLA"
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

End Class
