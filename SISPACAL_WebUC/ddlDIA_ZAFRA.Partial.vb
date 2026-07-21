Partial Public Class ddlDIA_ZAFRA


    Public Sub RecuperarDiaZafraActivo(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cDIA_ZAFRA
        Dim Lista As New listaDIA_ZAFRA
        Dim lEntidad As DIA_ZAFRA = miComponente.ObtenerDiaZafraActivo(ID_ZAFRA)

        If lEntidad IsNot Nothing Then
            Lista.Add(lEntidad)
        End If
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DIAZAFRA"
        Me.DataValueField = "ID_DIA_ZAFRA"

        Me.DataBind()

    End Sub

    Public Sub RecuperarDiaZafraFechaCierre(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cDIA_ZAFRA
        Dim Lista As listaDIA_ZAFRA
        Lista = miComponente.ObtenerListaPorZafraFechaCierre(ID_ZAFRA)

        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION_DIA"
        Me.DataValueField = "DIAZAFRA"

        Me.DataBind()

    End Sub
End Class
