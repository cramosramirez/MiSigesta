Partial Public Class ddlCARGADOR
    Public Sub RecuperarListaPorCargadora(ByVal ID_CARGADORA As Integer)
        Dim miComponente As New cCARGADOR
        Dim Lista As listaCARGADOR = (New cCARGADOR).ObtenerListaPorCARGADORA(ID_CARGADORA)
        Dim lEntidad As New CARGADOR
        lEntidad.ID_CARGADOR = 0
        lEntidad.NOMBRE_CARGADOR = " "
        Lista.Insertar(0, lEntidad)

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_CARGADOR"
        Me.DataValueField = "ID_CARGADOR"

        Me.DataBind()
    End Sub
End Class
