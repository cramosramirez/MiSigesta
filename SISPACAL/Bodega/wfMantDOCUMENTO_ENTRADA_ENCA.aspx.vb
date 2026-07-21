Imports SISPACAL.BL

Partial Class Bodega_wfMantDOCUMENTO_ENTRADA_ENCA
    Inherits wfBase

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim bOpcion As New cOPCION
        If Not bOpcion.UsuarioTienePermiso(Me.ObtenerUsuario, Me.NombrePagina) Then Response.Redirect("~/Default.aspx")
    End Sub
End Class
