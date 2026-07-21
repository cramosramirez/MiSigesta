Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WinUC
''' Class	 : WinUC.ddlZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxZAFRA
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cZAFRA
        Dim Lista As New listaZAFRA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ZAFRA"
        Me.ValueMember = "ID_ZAFRA"
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

    Public Sub RecuperarZafraActiva()
        Dim miComponente As New cZAFRA
        Dim Lista As New listaZAFRA
        Dim lEntidad As ZAFRA

        lEntidad = miComponente.ObtenerZafraActiva
        If lEntidad Is Nothing Then
            Me.Items.Clear()
            Return
        End If
        Lista.Add(lEntidad)

        Me.DisplayMember = "NOMBRE_ZAFRA"
        Me.ValueMember = "ID_ZAFRA"
        Me.DataSource = Lista
    End Sub
End Class
