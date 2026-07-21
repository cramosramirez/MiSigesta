Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

Partial Class controlesCenso_ucCriteriosPlanCosecha
    Inherits ucBase


#Region "Visibilidad"
    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerID_CENSO() As Boolean
        Get
            Return Me.lblCENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblCENSO.Visible = value
            Me.cbxCENSO.Visible = value
        End Set
    End Property

    Public Property VerEDAD_LOTE() As Boolean
        Get
            Return Me.lblEDAD_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblEDAD_LOTE.Visible = value
            Me.speEDAD_LOTE.Visible = value
        End Set
    End Property

    Public Property VerMOLIENDA_DIARIA_AJUSTADA() As Boolean
        Get
            Return Me.lblMoliendaDiaria.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblMoliendaDiaria.Visible = value
            Me.txtMOLIENDA_DIARIA_AJUSTADA.Visible = value
        End Set
    End Property

    Public Property VerVARIEDAD() As Boolean
        Get
            Return Me.trVARIEDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVARIEDAD.Visible = value
        End Set
    End Property

    Public Property VerCODIGOS_RELACIONADOS() As Boolean
        Get
            Return Me.trCODIGOS_RELACIONADOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGOS_RELACIONADOS.Visible = value
        End Set
    End Property

    Public Property VerFORMA_COSECHA() As Boolean
        Get
            Return Me.trFORMA_COSECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFORMA_COSECHA.Visible = value
        End Set
    End Property

    Public Property VerMULTICANTON() As Boolean
        Get
            Return Me.trMULTICANTON1.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMULTICANTON1.Visible = value
            Me.trMULTICANTON2.Visible = value
        End Set
    End Property

    Public Property VerTERCIO() As Boolean
        Get
            Return Me.trTERCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTERCIO.Visible = value
        End Set
    End Property

    Public Property VerVARIEDADitem() As Boolean
        Get
            Return Me.lblVARIEDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblVARIEDAD.Visible = value
            Me.cbxVARIEDAD.Visible = value
        End Set
    End Property

    Public Property VerTIPOitem() As Boolean
        Get
            Return Me.lblTIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblTIPO.Visible = value
            Me.cbxTIPO.Visible = value
        End Set
    End Property

    Public Property VerSUB_TIPOitem() As Boolean
        Get
            Return Me.lblSUB_TIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblSUB_TIPO.Visible = value
            Me.cbxSUB_TIPO.Visible = value
        End Set
    End Property

    Public Property VerTERCIOitem() As Boolean
        Get
            Return Me.lblTERCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblTERCIO.Visible = value
            Me.cbxTERCIO.Visible = value
        End Set
    End Property

    Public Property VerSUB_TERCIOitem() As Boolean
        Get
            Return Me.lblSUB_TERCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblSUB_TERCIO.Visible = value
            Me.cbxSUB_TERCIO.Visible = value
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

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.trCODIPROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerTIPO_DETALLE() As Boolean
        Get
            Return Me.trTIPO_DETALLE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_DETALLE.Visible = value
        End Set
    End Property

    Public Property VerTIPO_DETALLE2() As Boolean
        Get
            Return Me.trTIPO_DETALLE2.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_DETALLE2.Visible = value
        End Set
    End Property
#End Region

#Region "Valores"
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

    Public Property ID_CENSO() As Integer
        Get
            If Me.cbxCENSO.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxCENSO.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxCENSO.Value = value
        End Set
    End Property

    Public Property ZONA() As String
        Get
            If Me.cbxZONA.Value Is Nothing Then Return ""
            Return Me.cbxZONA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxZONA.Value = value.ToString()
        End Set
    End Property

    Public Property FORMA_COSECHA() As Int32
        Get
            If Me.cbxFORMA_COSECHA.Value Is Nothing Then Return -1
            Return Me.cbxFORMA_COSECHA.Value
        End Get
        Set(ByVal value As Int32)
            Me.cbxFORMA_COSECHA.Value = value
        End Set
    End Property

    Public Property ESTADO_LOTE() As Int32
        Get
            If Me.cbxESTADO_LOTE.Value Is Nothing Then Return -1
            Return Me.cbxESTADO_LOTE.Value
        End Get
        Set(ByVal value As Int32)
            Me.cbxESTADO_LOTE.Value = value
        End Set
    End Property

    Public Property MOLIENDA_DIARIA_AJUSTADA() As Decimal
        Get
            If Me.txtMOLIENDA_DIARIA_AJUSTADA.Value Is Nothing Then Return 0
            Return CDec(Me.txtMOLIENDA_DIARIA_AJUSTADA.Value)
        End Get
        Set(ByVal value As Decimal)
            Me.txtMOLIENDA_DIARIA_AJUSTADA.Value = value
        End Set
    End Property

    Public Property SUB_ZONA() As String
        Get
            If Me.cbxSUB_ZONA.Value Is Nothing Then Return ""
            Return Me.cbxSUB_ZONA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxSUB_ZONA.Value = value.ToString()
        End Set
    End Property

    Public Property CODI_DEPTO() As String
        Get
            If Me.cbxDEPARTAMENTO.Value Is Nothing Then Return ""
            Return Me.cbxDEPARTAMENTO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxDEPARTAMENTO.Value = value.ToString()
        End Set
    End Property

    Public Property TIPO_DETALLE() As Integer
        Get
            If Me.cbxTipoDetalle.Value Is Nothing OrElse Not IsNumeric(Me.cbxTipoDetalle.Value) Then
                Return -1
            End If
            Return Me.cbxTipoDetalle.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxTipoDetalle.Value = value
        End Set
    End Property

    Public Property TIPO_DETALLE2() As Integer
        Get
            If Me.cbxTipoDetalle2.Value Is Nothing OrElse Not IsNumeric(Me.cbxTipoDetalle2.Value) Then
                Return -1
            End If
            Return Me.cbxTipoDetalle2.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxTipoDetalle2.Value = value
        End Set
    End Property

    Public Property CODI_MUNI() As String
        Get
            If Me.cbxMUNICIPIO.Value Is Nothing Then Return ""
            Return Me.cbxMUNICIPIO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxMUNICIPIO.Value = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            Return Me.txtCODIPROVEE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEE.Text = value.ToString()
        End Set
    End Property

    Public Property CODISOCIO() As String
        Get
            Return Me.txtCODISOCIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODISOCIO.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR.Text = value.ToString()
        End Set
    End Property

    Public Property CODIVARIEDAD() As String
        Get
            If Me.cbxVARIEDAD.Value Is Nothing Then Return ""
            Return Me.cbxVARIEDAD.Value
        End Get
        Set(ByVal value As String)
            Me.cbxVARIEDAD.Value = value
        End Set
    End Property

    Public Property ID_TIPO_CANA() As Int32
        Get
            If Me.cbxTIPO.Value Is Nothing Then Return -1
            Return Me.cbxTIPO.Value
        End Get
        Set(ByVal value As Int32)
            Me.cbxTIPO.Value = value
        End Set
    End Property

    Public Property ID_SUB_TIPO_CANA() As Int32
        Get
            If Me.cbxSUB_TIPO.Value Is Nothing Then Return -1
            Return Me.cbxSUB_TIPO.Value
        End Get
        Set(ByVal value As Int32)
            Me.cbxSUB_TIPO.Value = value
        End Set
    End Property

    Public Property FECHA1() As Date
        Get
            If dteFecha1.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFecha1.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFecha1.Date = value
        End Set
    End Property

    Public Property FECHA2() As Date
        Get
            If dteFecha2.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFecha2.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFecha2.Date = value
        End Set
    End Property

    Public Property SEMANA() As Int32
        Get
            If Me.txtSEMANA.Text Is Nothing OrElse Me.txtSEMANA.Text = "" Then
                Return -1
            End If
            Return Convert.ToInt32(Me.txtSEMANA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtSEMANA.Text = value.ToString()
        End Set
    End Property

    Public Property HORAS_AJUSTE() As Int32
        Get
            If Me.txtHORAS_AJUSTE.Text Is Nothing OrElse Me.txtHORAS_AJUSTE.Text = "" Then
                Return 0
            End If
            Return Convert.ToInt32(Me.txtHORAS_AJUSTE.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtHORAS_AJUSTE.Text = value.ToString()
        End Set
    End Property

    Public Property CATORCENA() As Int32
        Get
            If Me.txtCATORCENA.Text Is Nothing OrElse Me.txtCATORCENA.Text = "" Then
                Return -1
            End If
            Return Convert.ToInt32(Me.txtCATORCENA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtCATORCENA.Text = value.ToString()
        End Set
    End Property

    Public Property SUB_TERCIO() As String
        Get
            If Me.cbxSUB_TERCIO.Value Is Nothing OrElse Me.cbxSUB_TERCIO.Value = -1 Then Return ""
            Return Me.cbxSUB_TERCIO.Text
        End Get
        Set(ByVal value As String)
            Me.cbxSUB_TERCIO.Value = value
        End Set
    End Property

    Public Property CODIGOS_RELACIONADOS() As Boolean
        Get
            Return Me.chkCodigosRelacionados.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkCodigosRelacionados.Checked = value
        End Set
    End Property

    Public Property TERCIO() As Int32
        Get
            Return Convert.ToInt32(Me.cbxTERCIO.Value)
        End Get
        Set(ByVal value As Int32)
            Me.cbxTERCIO.Value = value
        End Set
    End Property

    Public Property EDAD_LOTE() As Int32
        Get
            If speEDAD_LOTE.Value Is Nothing Then
                Return -1
            Else
                Return speEDAD_LOTE.Value
            End If
        End Get
        Set(ByVal value As Int32)
            Me.speEDAD_LOTE.Value = value
        End Set
    End Property

    Public Property ID_ZAFRA_AUTOPOSTBACK As Boolean
        Get
            Return Me.cbxZAFRA.AutoPostBack
        End Get
        Set(value As Boolean)
            Me.cbxZAFRA.AutoPostBack = value
        End Set
    End Property

    Public Property ID_CICLO() As Integer
        Get
            If Me.cbxCICLO.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxCICLO.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxCICLO.Value = value
        End Set
    End Property

    Private _lista As listaCANTON
    Public ReadOnly Property CANTONES As listaCANTON
        Get
            _lista = New listaCANTON
            If Me.hfCantones.Contains("Cantones") AndAlso Me.hfCantones.Get("Cantones") <> "" Then
                Dim codigos As String() = Me.hfCantones.Get("Cantones").ToString.Split(",")

                For i As Integer = 0 To codigos.Length - 1
                    Dim lEntidad As New CANTON
                    Dim codigo As String() = codigos(i).Split(";")
                    lEntidad.CODI_DEPTO = codigo(0)
                    lEntidad.CODI_MUNI = codigo(1)
                    lEntidad.CODI_CANTON = codigo(2)

                    _lista.Add(lEntidad)
                Next
            End If

            Return _lista
        End Get
    End Property
#End Region

    Protected Sub cbxCENSO_DataBound(sender As Object, e As System.EventArgs) Handles cbxCENSO.DataBound
        Dim censos As ASPxComboBox = CType(sender, ASPxComboBox)
        If censos IsNot Nothing Then
            If censos.Items.Count > 0 Then
                For Each item As ListEditItem In censos.Items
                    'If IsDate(item.Text) Then item.Text = Format(CDate(item.Text), "dd/MM/yyyy")
                Next
            Else
                Me.cbxCENSO.Text = ""
            End If
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.CargarSubTercios()
        If Not IsPostBack Then
            Me.Inicializar()
            Me.CargarCliclos()
        End If
        Me.CargarMultiCantones()
        Me.CargarVariedades()
        If Me.cbxTIPO.Value IsNot Nothing Then Me.CargarSubTiposCana(Me.cbxTIPO.Value) Else CargarSubTiposCana()
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.cbxTIPO.Value = -1
        If cbxSUB_TERCIO.Items.Count > 0 Then Me.cbxSUB_TERCIO.SelectedIndex = 0
    End Sub

    Private Sub CargarPlanCosecha()
        Dim lCensos As listaCENSO = New listaCENSO
        Dim lCenso As New CENSO
        If Me.cbxZAFRA.Value IsNot Nothing Then
            lCensos = (New cCENSO).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "FECHA_CENSO", "DESC")
            'lCenso.ID_CENSO = -2
            'lCenso.FECHA_CENSO = cFechaHora.ObtenerFecha
            'lCensos.Insertar(0, lCenso)
        End If
        'Me.cbxCENSO.DataSource = lCensos
        'Me.cbxCENSO.DataBind()
    End Sub

    Private Sub CargarMultiCantones()
        Dim lCantones As New listaCANTON
        Dim idZafra As Int32 = -1
        Dim codiDepto As String = ""
        Dim codiMuni As String = ""

        If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = Me.cbxZAFRA.Value
        If Me.cbxDEPARTAMENTO.Value <> "" Then codiDepto = Me.cbxDEPARTAMENTO.Value
        If Me.cbxMUNICIPIO.Value <> "" Then codiMuni = Me.cbxMUNICIPIO.Value

        lCantones = (New cCANTON).ObtenerListaPorZAFRA(idZafra, codiDepto, codiMuni)
        If Me.cbxCANTONES.FindControl("listBox") IsNot Nothing Then
            Dim listControl As New ASPxListBox
            listControl = Me.cbxCANTONES.FindControl("listBox")
            listControl.DataSource = lCantones
            listControl.DataBind()
        End If
    End Sub

    Private Sub CargarVariedades(Optional CODIVARIEDA As String = "")
        Dim mListaVariedades As listaVARIEDAD
        mListaVariedades = (New cVARIEDAD).RecuperarPorTipo(False, True, Me.cbxTIPO.Value)

        Me.cbxVARIEDAD.ValueField = "CODIVARIEDA"
        Me.cbxVARIEDAD.TextField = "NOM_VARIEDAD"
        Me.cbxVARIEDAD.DataSource = mListaVariedades
        Me.cbxVARIEDAD.DataBind()
        If CODIVARIEDA <> "" Then
            Me.cbxVARIEDAD.SelectedItem = Me.cbxVARIEDAD.Items.FindByValue(CODIVARIEDA)
        End If
    End Sub

    Private Sub CargarSubTiposCana(Optional ID_TIPO_PADRE As Int32 = 0)
        Dim mListaSubTipoCana As listaTIPOS_GENERALES
        Dim idSubTipo As Int32

        If Me.cbxSUB_TIPO.Value IsNot Nothing Then idSubTipo = Me.cbxSUB_TIPO.Value
        If ID_TIPO_PADRE = -1 Then ID_TIPO_PADRE = -5
        mListaSubTipoCana = (New cTIPOS_GENERALES).RecuperarPorTipo(False, True, -1, Enumeradores.TiposTabla.SubTiposVariedad, ID_TIPO_PADRE)
        Me.cbxSUB_TIPO.ValueField = "ID_TIPO"
        Me.cbxSUB_TIPO.TextField = "NOM_TIPO"
        Me.cbxSUB_TIPO.DataSource = mListaSubTipoCana
        Me.cbxSUB_TIPO.DataBind()
        If mListaSubTipoCana.Count > 0 Then
            If mListaSubTipoCana.BuscarPorId(idSubTipo) IsNot Nothing AndAlso idSubTipo <> -1 Then
                Me.cbxSUB_TIPO.SelectedItem = Me.cbxSUB_TIPO.Items.FindByValue(idSubTipo)
            Else
                Me.cbxSUB_TIPO.SelectedIndex = 0
            End If
        End If
    End Sub

   
    Private Sub CargarSubTercios()
        Dim mListaSubTercios As listaTIPOS_GENERALES
        mListaSubTercios = (New cTIPOS_GENERALES).RecuperarPorTipo(False, True, -1, 12, -1)
        Me.cbxSUB_TERCIO.ValueField = "ID_TIPO"
        Me.cbxSUB_TERCIO.TextField = "NOM_TIPO"
        Me.cbxSUB_TERCIO.DataSource = mListaSubTercios
        Me.cbxSUB_TERCIO.DataBind()
    End Sub

    Private Sub CargarCliclos()
        Dim mListaCiclos As listaCICLO
        mListaCiclos = (New cCICLO).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value)

        Me.cbxCICLO.ValueField = "ID_CICLO"
        Me.cbxCICLO.TextField = "NOM_CICLO"
        Me.cbxCICLO.DataSource = mListaCiclos
        Me.cbxCICLO.DataBind()
        If mListaCiclos.Count > 0 Then
            Me.cbxCICLO.SelectedIndex = 0
        End If
    End Sub

    Protected Sub cbxDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxDEPARTAMENTO.SelectedIndexChanged
        Me.cbxMUNICIPIO.Text = ""
        Me.cbxCANTONES.Text = ""
        Me.hfCantones.Clear()
    End Sub

    Protected Sub cbxMUNICIPIO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxMUNICIPIO.SelectedIndexChanged
        Me.cbxCANTONES.Text = ""
        Me.hfCantones.Clear()
    End Sub

    Protected Sub cbxZONA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxZONA.SelectedIndexChanged
        Me.cbxSUB_ZONA.Text = ""
    End Sub

    Protected Sub cbxVARIEDAD_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxVARIEDAD.ValueChanged
        If cbxVARIEDAD.Value IsNot Nothing Then
            Dim lEntidad As VARIEDAD = (New cVARIEDAD).ObtenerVARIEDAD(cbxVARIEDAD.Value)
            If lEntidad IsNot Nothing Then
                Me.cbxTIPO.Value = lEntidad.ID_TIPO
                CargarSubTiposCana(lEntidad.ID_TIPO)
                Me.cbxSUB_TIPO.Value = lEntidad.ID_SUB_TIPO
            End If
        Else
            Me.cbxTIPO.SelectedIndex = 0
            Me.cbxSUB_TIPO.SelectedIndex = 0
        End If
    End Sub

    Protected Sub cbxTIPO_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxTIPO.ValueChanged
        Me.CargarVariedades(Me.cbxVARIEDAD.Value)
        Me.CargarSubTiposCana(Me.cbxTIPO.Value)
    End Sub

    Protected Sub cbxFORMA_COSECHA_DataBound(sender As Object, e As System.EventArgs) Handles cbxFORMA_COSECHA.DataBound
        If cbxFORMA_COSECHA.Items.Count > 0 Then
            cbxFORMA_COSECHA.SelectedIndex = 0
        End If
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCliclos()
    End Sub
End Class
