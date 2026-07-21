Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesFinanciero_ucCriteriosServiciosEsp
    Inherits ucBase

    Public Property ID_ZAFRA() As Integer
        Get
            If Me.cbxZAFRA.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxZAFRA.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property NO_CATORCENA() As Integer
        Get
            If Me.cbxCATORCENA_ZAFRA.Text = "" Then
                Return -1
            Else
                Return CInt(Me.cbxCATORCENA_ZAFRA.Text)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxCATORCENA_ZAFRA.Value = value
        End Set
    End Property

    Public Property ID_CATORCENA() As Integer
        Get
            If cbxCATORCENA_ZAFRA.Value Is Nothing Then
                Return -1
            Else
                Return CInt(Me.cbxCATORCENA_ZAFRA.Value)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxCATORCENA_ZAFRA.Value = value
        End Set
    End Property

    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            If CBXcontribuyente.Value IsNot Nothing Then
                Return CBool(CBXcontribuyente.Value)
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            Me.cbxCATORCENA_ZAFRA.Value = value
        End Set
    End Property

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZAFRA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_HORA_CIERRE() As Boolean
        Get
            Return Me.trFECHA_HORA_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_HORA_CIERRE.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR() As Boolean
        Get
            Return Me.trCODIPROVEE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEE.Visible = value
        End Set
    End Property

    Public Property VerCONTRIBUYENTE() As Boolean
        Get
            Return Me.trCONTRIBUYENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONTRIBUYENTE.Visible = value
        End Set
    End Property

    Public Property VerCATORCENA() As Boolean
        Get
            Return Me.trCATORCENA_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCATORCENA_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerSERVICIO_ESPECIAL() As Boolean
        Get
            Return Me.trSERVICIO_ESPECIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSERVICIO_ESPECIAL.Visible = value
        End Set
    End Property

    Public Property SERVICIO_ESPECIAL() As Integer
        Get
            If Me.cbxSERVICIO_ESPECIAL.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxSERVICIO_ESPECIAL.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxSERVICIO_ESPECIAL.Value = value
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            If Me.speCODIPROVEE.Value Is Nothing Then
                Return ""
            Else
                Return Utilerias.FormatoCODIPROVEE(Me.speCODIPROVEE.Value)
            End If
        End Get
        Set(ByVal value As String)
            Me.speCODIPROVEE.Value = value
        End Set
    End Property

    Public ReadOnly Property FECHA_HORA_CIERRE() As String
        Get
            If Me.dteFECHA_HORA_CIERRE.Value Is Nothing Then
                Return ""
            Else
                Return Me.dteFECHA_HORA_CIERRE.Date.ToString("dd/MM/yyyy HH:mm")
            End If
        End Get
    End Property

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Public Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim listaCatorcena As New listaCATORCENA_ZAFRA

        If lZafraActiva IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
            Me.CargarCatorcenas()
        End If
    End Sub

    Private Sub CargarCatorcenas()
        Dim listaCatorcena As New listaCATORCENA_ZAFRA

        If Me.cbxZAFRA.Value IsNot Nothing Then
            listaCatorcena = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
            If listaCatorcena Is Nothing Then listaCatorcena = New listaCATORCENA_ZAFRA
        End If
        Me.cbxCATORCENA_ZAFRA.DataSource = listaCatorcena
        Me.cbxCATORCENA_ZAFRA.DataBind()
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCatorcenas()
    End Sub
End Class
