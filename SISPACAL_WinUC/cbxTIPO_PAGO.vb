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
Public Class cbxTIPO_PAGO
    Inherits cbxBase

    Private Sub RecuperarLista()
        Me.Items.Add("[TODOS]")
        Me.Items.Add("PAGO CON CHEQUE")
        Me.Items.Add("PAGO A CUENTA")
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
