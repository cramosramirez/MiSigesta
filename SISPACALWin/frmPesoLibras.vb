Public Class frmPesoLibras

    Public Property PESO_LIBRAS As String
        Get
            Return Me.lblPESO_LIBRAS.Text
        End Get
        Set(value As String)
            Me.lblPESO_LIBRAS.Text = value
        End Set
    End Property

End Class