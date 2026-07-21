Imports SISPACAL.BL
Imports SISPACAL.EL


Partial Class controlesFrentes_ucCriteriosFrentes
    Inherits System.Web.UI.UserControl

    Public Property VerZAFRA As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(value As Boolean)
            Me.trZAFRA.Visible = value
        End Set
    End Property

    Public Property VerTIPO_FRENTE As Boolean
        Get
            Return Me.trTIPO_FRENTE.Visible
        End Get
        Set(value As Boolean)
            Me.trTIPO_FRENTE.Visible = value
        End Set
    End Property

    Public Property VerCUENTA_FINAN As Boolean
        Get
            Return Me.trCUENTA_FINANCIAMIENTO_FRENTE.Visible
        End Get
        Set(value As Boolean)
            Me.trCUENTA_FINANCIAMIENTO_FRENTE.Visible = value
        End Set
    End Property

    Public Property VerFRENTE As Boolean
        Get
            Return Me.trFRENTE.Visible
        End Get
        Set(value As Boolean)
            Me.trFRENTE.Visible = value
        End Set
    End Property

    Public Property ID_ZAFRA As Int32
        Get
            If Me.cbxZAFRA.Value IsNot Nothing Then
                Return CInt(Me.cbxZAFRA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property ID_TIPO_FRENTE As Int32
        Get
            If Me.cbxTIPO_FRENTE.Value IsNot Nothing Then
                Return CInt(Me.cbxTIPO_FRENTE.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxTIPO_FRENTE.Value = value
        End Set
    End Property

    Public Property ID_CUENTA_FINAN As Int32
        Get
            If Me.cbxCUENTA_FINANCIAMIENTO_FRENTE.Value IsNot Nothing Then
                Return CInt(Me.cbxCUENTA_FINANCIAMIENTO_FRENTE.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxCUENTA_FINANCIAMIENTO_FRENTE.Value = value
        End Set
    End Property

    Public Property COD_FRENTE As String
        Get
            If Not Me.txtCOD_FRENTE.Text = "" Then
                Return Me.txtCOD_FRENTE.Text.Trim.ToUpper
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            Me.txtCOD_FRENTE.Text = value
        End Set
    End Property

    Public ReadOnly Property ID_FRENTE As String
        Get
            If Not Me.txtCOD_FRENTE.Text = "" Then
                Dim IdFrente As Integer
                If Convert.ToInt32(Me.cbxTIPO_FRENTE.Value) = Enumeradores.TipoProveedor.FrenteRoza Then
                    Dim lFrente As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPorCODIGO(txtCOD_FRENTE.Text.Trim.ToUpper)
                    If lFrente IsNot Nothing Then IdFrente = lFrente.ID_PROVEEDOR_ROZA
                ElseIf Convert.ToInt32(Me.cbxTIPO_FRENTE.Value) = Enumeradores.TipoProveedor.FrenteQuerqueo Then
                    Dim listalFrente As listaPROVEEDOR_QUERQUEO = (New cPROVEEDOR_QUERQUEO).ObtenerListaPorCODISIS(txtCOD_FRENTE.Text.Trim.ToUpper)
                    If listalFrente IsNot Nothing AndAlso listalFrente.Count > 0 Then IdFrente = listalFrente(0).ID_PROVEE_QQ
                End If
                Return IdFrente
            Else
                Return -1
            End If
        End Get
    End Property

    Protected Sub txtCOD_FRENTE_ValueChanged(sender As Object, e As EventArgs) Handles txtCOD_FRENTE.ValueChanged
        Me.txtNOM_FRENTE.Text = ""
        If txtCOD_FRENTE.Value IsNot Nothing AndAlso Me.cbxTIPO_FRENTE.Value IsNot Nothing Then
            If Convert.ToInt32(Me.cbxTIPO_FRENTE.Value) = Enumeradores.TipoProveedor.FrenteRoza Then
                Dim lFrente As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPorCODIGO(txtCOD_FRENTE.Text.Trim.ToUpper)
                If lFrente IsNot Nothing Then Me.txtNOM_FRENTE.Text = Replace(Replace(lFrente.NOMBRE_PROVEEDOR_ROZA, lFrente.CODIGO, "").Trim, "-", "").Trim
            ElseIf Convert.ToInt32(Me.cbxTIPO_FRENTE.Value) = Enumeradores.TipoProveedor.FrenteQuerqueo Then
                Dim listalFrente As listaPROVEEDOR_QUERQUEO = (New cPROVEEDOR_QUERQUEO).ObtenerListaPorCODISIS(txtCOD_FRENTE.Text.Trim.ToUpper)
                If listalFrente IsNot Nothing AndAlso listalFrente.Count > 0 Then Me.txtNOM_FRENTE.Text = listalFrente(0).NOMBRES + " " + listalFrente(0).APELLIDOS
            End If

        End If
    End Sub

    Private Sub controlesFrentes_ucCriteriosFrentes_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not IsPostBack Then
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                If lZafra IsNot Nothing Then Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            End If
        End If
    End Sub

    Private Sub cbxTIPO_FRENTE_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_FRENTE.ValueChanged
        Me.txtCOD_FRENTE.Text = ""
        Me.txtNOM_FRENTE.Text = ""
    End Sub
End Class
