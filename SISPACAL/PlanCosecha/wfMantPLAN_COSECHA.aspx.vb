Imports SISPACAL.BL

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : wfMantPLAN_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de la Página para el Mantenimiento de Registros
''' de la tabla PLAN_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class wfMantPLAN_COSECHA
    Inherits wfBase

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim bOpcion As New cOPCION
        If Not bOpcion.UsuarioTienePermiso(Me.ObtenerUsuario, Me.NombrePagina) Then Response.Redirect("~/Default.aspx")
    End Sub
End Class
