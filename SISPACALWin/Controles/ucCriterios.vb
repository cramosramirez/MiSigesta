Public Class ucCriterios

    Public Property FECHA_CORTE As Date
        Get
            Return dtpFechaCorte.Value
        End Get
        Set(value As Date)
            dtpFechaCorte.Value = value
        End Set
    End Property

    Public Property ID_ZAFRA As Integer
        Get
            Return Me.CbxZAFRA1.SelectedValue
        End Get
        Set(value As Integer)
            Me.CbxZAFRA1.SelectedValue = value
        End Set
    End Property


    Private Sub ucCriterios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CbxZAFRA1.RecuperarZafraActiva()
        Dim listaDiaZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(Me.CbxZAFRA1.SelectedValue, False, "FECHA", "DESC")
        If listaDiaZafra IsNot Nothing AndAlso listaDiaZafra.Count > 0 Then
            Me.dtpFechaCorte.Value = listaDiaZafra(0).FECHA
        End If
    End Sub
End Class
