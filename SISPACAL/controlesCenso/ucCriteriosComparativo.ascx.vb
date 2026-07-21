Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesCenso_ucCriteriosComparativo
    Inherits ucBase


    Public Property VerRENDIMIENTO() As Boolean
        Get
            Return Me.trRENDIMIENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRENDIMIENTO.Visible = value
        End Set
    End Property

    Public Property VerVIP() As Boolean
        Get
            Return Me.trVIP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVIP.Visible = value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Public Property VerTIPO_REPORTE() As Boolean
        Get
            Return Me.trTIPO_REPORTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_REPORTE.Visible = value
        End Set
    End Property

    Public Property ID_ZAFRA1 As Int32
        Get
            If Me.cbxZAFRA1.Value IsNot Nothing Then
                Return CInt(Me.cbxZAFRA1.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxZAFRA1.Value = value
        End Set
    End Property

    Public Property ID_ZAFRA2 As Int32
        Get
            If Me.cbxZAFRA2.Value IsNot Nothing Then
                Return CInt(Me.cbxZAFRA2.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxZAFRA2.Value = value
        End Set
    End Property

    Public Property TIPO_REPORTE As Int32
        Get
            If Me.cbxTIPO_REPORTE.Value IsNot Nothing Then
                Return CInt(Me.cbxTIPO_REPORTE.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxTIPO_REPORTE.Value = value
        End Set
    End Property

    Public Property CODIPROVEE As String
        Get
            If Me.speCODIPROVEE.Value IsNot Nothing Then
                Return Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value)
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            Me.speCODIPROVEE.Value = CInt(value)
        End Set
    End Property

    Public Property ZONA As String
        Get
            If Me.cbxZONA.Value IsNot Nothing Then
                Return Me.cbxZONA.Value
            Else
                Return ""
            End If
        End Get
        Set(value As String)
            Me.cbxZONA.Value = value
        End Set
    End Property

    Public Property CODISOCIO As String
        Get
            Return lblCodiSocio.Text
        End Get
        Set(value As String)
            Me.lblCodiSocio.Text = value
        End Set
    End Property

    Public Property RENDIMIENTO As Decimal
        Get
            If Me.speRENDIMIENTO.Value IsNot Nothing Then
                Return CDec(Me.speRENDIMIENTO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Decimal)
            Me.speRENDIMIENTO.Value = value
        End Set
    End Property

    Public Property VIP As Decimal
        Get
            If Me.speVIP.Value IsNot Nothing Then
                Return CDec(Me.speVIP.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Decimal)
            Me.speVIP.Value = value
        End Set
    End Property

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.lblCodiSocio.Text = IIf(lProveedor.CODISOCIO <> "0000", lProveedor.CODISOCIO, "")
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            If lZafra IsNot Nothing Then
                Me.speRENDIMIENTO.Value = lZafra.REND_MODFINAN
                Me.speVIP.Value = lZafra.PRECIO_LIBRA_AZUCAR
            End If
            Me.cbxZAFRA1.Value = lZafra.ID_ZAFRA - 1
            Me.cbxZAFRA2.Value = lZafra.ID_ZAFRA
        End If
    End Sub
End Class
