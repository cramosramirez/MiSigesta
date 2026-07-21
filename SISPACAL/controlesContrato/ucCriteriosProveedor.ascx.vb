Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesMaestro_ucCriteriosProveedor
    Inherits ucBase


#Region "Propiedades"
    Public ReadOnly Property CODIPROVEE As String
        Get
            Return Me.txtCODIPROVEE.Text
        End Get
    End Property

    Public ReadOnly Property CODISOCIO As String
        Get
            Return Me.txtCODISOCIO.Text
        End Get
    End Property

    Public ReadOnly Property NOMBRES As String
        Get
            If Me.txtNOMBRES.Value Is Nothing Then Return ""
            Return Me.txtNOMBRES.Value
        End Get
    End Property

    Public ReadOnly Property APELLIDOS As String
        Get
            If Me.txtAPELLIDOS.Value Is Nothing Then Return ""
            Return Me.txtAPELLIDOS.Value
        End Get
    End Property

    Public ReadOnly Property DUI As String
        Get
            If Me.txtDUI.Value Is Nothing Then Return ""
            Return Me.txtDUI.Value.ToString.Trim
        End Get
    End Property

    Public ReadOnly Property NIT As String
        Get
            If Me.txtNIT.Value Is Nothing Then Return ""
            Return Me.txtNIT.Value
        End Get
    End Property

    Public ReadOnly Property ZAFRA As Integer
        Get
            If Me.cbxZAFRA.Value Is Nothing Then Return -1
            Return Convert.ToInt32(Me.cbxZAFRA.Value)
        End Get
    End Property

    Public ReadOnly Property NRC As String
        Get
            If Me.txtNRC.Value Is Nothing Then Return ""
            Return Me.txtNRC.Value
        End Get
    End Property

    Private Sub controlesMaestro_ucCriteriosProveedor_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        '    If lZafra IsNot Nothing Then
        '        Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        '    End If
        'End If
    End Sub


#End Region


End Class
