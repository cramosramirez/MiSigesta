Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePLANILLA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CATORCENA As Int32
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CATORCENA = Value
        End Set
    End Property

    Private _CODIPROVEEDOR_TRANSPORTISTA As String
    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIPROVEEDOR_TRANSPORTISTA = Value
            Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text = Value
            If Me._CODIPROVEEDOR_TRANSPORTISTA <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _ID_TIPO_PLANILLA As Int32
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            Me._ID_TIPO_PLANILLA = Value
        End Set
    End Property

    Public Property NOMBRE_ZAFRA() As String
        Get
            Return Me.txtNOMBRE_ZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_ZAFRA.Text = value.ToString()
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

    Public Property CANT_RECIBOS() As Int32
        Get
            If Me.txtCANT_RECIBOS.Text ="" Then Return -1
            Return CInt(Me.txtCANT_RECIBOS.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtCANT_RECIBOS.Text = value.ToString()
        End Set
    End Property

    Public Property TONEL_CANA_ENTREGADA() As Decimal
        Get
            If Me.txtTONEL_CANA_ENTREGADA.Text ="" Then Return -1
            Return Me.txtTONEL_CANA_ENTREGADA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_CANA_ENTREGADA.Text = value.ToString()
        End Set
    End Property

    Public Property AZUCAR_CATORCENA_REAL() As Decimal
        Get
            If Me.txtAZUCAR_CATORCENA_REAL.Text ="" Then Return -1
            Return Me.txtAZUCAR_CATORCENA_REAL.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtAZUCAR_CATORCENA_REAL.Text = value.ToString()
        End Set
    End Property

    Public Property VALOR() As Decimal
        Get
            If Me.txtVALOR.Text ="" Then Return -1
            Return Me.txtVALOR.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR.Text = value.ToString()
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            If Me.txtIVA.Text ="" Then Return -1
            Return Me.txtIVA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtIVA.Text = value.ToString()
        End Set
    End Property

    Public Property VALOR_BRUTO() As Decimal
        Get
            If Me.txtVALOR_BRUTO.Text ="" Then Return -1
            Return Me.txtVALOR_BRUTO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_BRUTO.Text = value.ToString()
        End Set
    End Property

    Public Property RENTA() As Decimal
        Get
            If Me.txtRENTA.Text ="" Then Return -1
            Return Me.txtRENTA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtRENTA.Text = value.ToString()
        End Set
    End Property

    Public Property RETENCION_IVA() As Decimal
        Get
            If Me.txtRETENCION_IVA.Text ="" Then Return -1
            Return Me.txtRETENCION_IVA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtRETENCION_IVA.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_FLETE() As Decimal
        Get
            If Me.txtDESC_FLETE.Text ="" Then Return -1
            Return Me.txtDESC_FLETE.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_FLETE.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_CARGA() As Decimal
        Get
            If Me.txtDESC_CARGA.Text ="" Then Return -1
            Return Me.txtDESC_CARGA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_CARGA.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_CARGA_CONTRA() As Decimal
        Get
            If Me.txtDESC_CARGA_CONTRA.Text ="" Then Return -1
            Return Me.txtDESC_CARGA_CONTRA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_CARGA_CONTRA.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_BANCOS() As Decimal
        Get
            If Me.txtDESC_BANCOS.Text ="" Then Return -1
            Return Me.txtDESC_BANCOS.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_BANCOS.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_COMBUSTIBLE() As Decimal
        Get
            If Me.txtDESC_COMBUSTIBLE.Text ="" Then Return -1
            Return Me.txtDESC_COMBUSTIBLE.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_COMBUSTIBLE.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_ANTICIPO() As Decimal
        Get
            If Me.txtDESC_ANTICIPO.Text ="" Then Return -1
            Return Me.txtDESC_ANTICIPO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_ANTICIPO.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_INTERES() As Decimal
        Get
            If Me.txtDESC_INTERES.Text ="" Then Return -1
            Return Me.txtDESC_INTERES.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_INTERES.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_AGROQUIMICO() As Decimal
        Get
            If Me.txtDESC_AGROQUIMICO.Text ="" Then Return -1
            Return Me.txtDESC_AGROQUIMICO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_AGROQUIMICO.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_SEGURO() As Decimal
        Get
            If Me.txtDESC_SEGURO.Text ="" Then Return -1
            Return Me.txtDESC_SEGURO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_SEGURO.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_RESPUESTOS() As Decimal
        Get
            If Me.txtDESC_RESPUESTOS.Text ="" Then Return -1
            Return Me.txtDESC_RESPUESTOS.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_RESPUESTOS.Text = value.ToString()
        End Set
    End Property

    Public Property DESC_OTROS() As Decimal
        Get
            If Me.txtDESC_OTROS.Text ="" Then Return -1
            Return Me.txtDESC_OTROS.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_OTROS.Text = value.ToString()
        End Set
    End Property

    Public Property PAGO_NETO() As Decimal
        Get
            If Me.txtPAGO_NETO.Text ="" Then Return -1
            Return Me.txtPAGO_NETO.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPAGO_NETO.Text = value.ToString()
        End Set
    End Property

    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            Return Me.cbxES_CONTRIBUYENTE.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxES_CONTRIBUYENTE.Checked = value
        End Set
    End Property

    Public Property USUARIO_CREA() As String
        Get
            Return Me.txtUSUARIO_CREA.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREA() As DateTime
        Get
            Return Me.txtFECHA_CREA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CREA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property USUARIO_ACT() As String
        Get
            Return Me.txtUSUARIO_ACT.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_ACT.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_ACT() As DateTime
        Get
            Return Me.txtFECHA_ACT.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ACT.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property DESC_SERVICIO_ROZA() As Decimal
        Get
            If Me.txtDESC_SERVICIO_ROZA.Text ="" Then Return -1
            Return Me.txtDESC_SERVICIO_ROZA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDESC_SERVICIO_ROZA.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_PROVEE_TRANS() As String
        Get
            Return Me.txtNOMBRE_PROVEE_TRANS.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEE_TRANS.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.trID_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR_TRANSPORTISTA() As Boolean
        Get
            Return Me.trCODIPROVEEDOR_TRANSPORTISTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR_TRANSPORTISTA.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.trID_TIPO_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_ZAFRA() As Boolean
        Get
            Return Me.trNOMBRE_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEE() As Boolean
        Get
            Return Me.trCODIPROVEE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEE.Visible = value
        End Set
    End Property

    Public Property VerCODISOCIO() As Boolean
        Get
            Return Me.trCODISOCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODISOCIO.Visible = value
        End Set
    End Property

    Public Property VerCANT_RECIBOS() As Boolean
        Get
            Return Me.trCANT_RECIBOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCANT_RECIBOS.Visible = value
        End Set
    End Property

    Public Property VerTONEL_CANA_ENTREGADA() As Boolean
        Get
            Return Me.trTONEL_CANA_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_CANA_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerAZUCAR_CATORCENA_REAL() As Boolean
        Get
            Return Me.trAZUCAR_CATORCENA_REAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAZUCAR_CATORCENA_REAL.Visible = value
        End Set
    End Property

    Public Property VerVALOR() As Boolean
        Get
            Return Me.trVALOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR.Visible = value
        End Set
    End Property

    Public Property VerIVA() As Boolean
        Get
            Return Me.trIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trIVA.Visible = value
        End Set
    End Property

    Public Property VerVALOR_BRUTO() As Boolean
        Get
            Return Me.trVALOR_BRUTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_BRUTO.Visible = value
        End Set
    End Property

    Public Property VerRENTA() As Boolean
        Get
            Return Me.trRENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRENTA.Visible = value
        End Set
    End Property

    Public Property VerRETENCION_IVA() As Boolean
        Get
            Return Me.trRETENCION_IVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRETENCION_IVA.Visible = value
        End Set
    End Property

    Public Property VerDESC_FLETE() As Boolean
        Get
            Return Me.trDESC_FLETE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_FLETE.Visible = value
        End Set
    End Property

    Public Property VerDESC_CARGA() As Boolean
        Get
            Return Me.trDESC_CARGA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_CARGA.Visible = value
        End Set
    End Property

    Public Property VerDESC_CARGA_CONTRA() As Boolean
        Get
            Return Me.trDESC_CARGA_CONTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_CARGA_CONTRA.Visible = value
        End Set
    End Property

    Public Property VerDESC_BANCOS() As Boolean
        Get
            Return Me.trDESC_BANCOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_BANCOS.Visible = value
        End Set
    End Property

    Public Property VerDESC_COMBUSTIBLE() As Boolean
        Get
            Return Me.trDESC_COMBUSTIBLE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_COMBUSTIBLE.Visible = value
        End Set
    End Property

    Public Property VerDESC_ANTICIPO() As Boolean
        Get
            Return Me.trDESC_ANTICIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_ANTICIPO.Visible = value
        End Set
    End Property

    Public Property VerDESC_INTERES() As Boolean
        Get
            Return Me.trDESC_INTERES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_INTERES.Visible = value
        End Set
    End Property

    Public Property VerDESC_AGROQUIMICO() As Boolean
        Get
            Return Me.trDESC_AGROQUIMICO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_AGROQUIMICO.Visible = value
        End Set
    End Property

    Public Property VerDESC_SEGURO() As Boolean
        Get
            Return Me.trDESC_SEGURO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_SEGURO.Visible = value
        End Set
    End Property

    Public Property VerDESC_RESPUESTOS() As Boolean
        Get
            Return Me.trDESC_RESPUESTOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_RESPUESTOS.Visible = value
        End Set
    End Property

    Public Property VerDESC_OTROS() As Boolean
        Get
            Return Me.trDESC_OTROS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_OTROS.Visible = value
        End Set
    End Property

    Public Property VerPAGO_NETO() As Boolean
        Get
            Return Me.trPAGO_NETO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPAGO_NETO.Visible = value
        End Set
    End Property

    Public Property VerES_CONTRIBUYENTE() As Boolean
        Get
            Return Me.trES_CONTRIBUYENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_CONTRIBUYENTE.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.trUSUARIO_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.trFECHA_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.trUSUARIO_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_ACT.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.trFECHA_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ACT.Visible = value
        End Set
    End Property

    Public Property VerDESC_SERVICIO_ROZA() As Boolean
        Get
            Return Me.trDESC_SERVICIO_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESC_SERVICIO_ROZA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROVEE_TRANS() As Boolean
        Get
            Return Me.trNOMBRE_PROVEE_TRANS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_PROVEE_TRANS.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPLANILLA
    Private mEntidad As PLANILLA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_CATORCENA") Is Nothing Then Me._ID_CATORCENA = Me.ViewState("ID_CATORCENA")
        If Not Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA") Is Nothing Then Me._CODIPROVEEDOR_TRANSPORTISTA = Me.ViewState("CODIPROVEEDOR_TRANSPORTISTA")
        If Not Me.ViewState("ID_TIPO_PLANILLA") Is Nothing Then Me._ID_TIPO_PLANILLA = Me.ViewState("ID_TIPO_PLANILLA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PLANILLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PLANILLA
        mEntidad.ID_CATORCENA = ID_CATORCENA
        mEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
        mEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
 
        If mComponente.ObtenerPLANILLA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.ddlCATORCENA_ZAFRAID_CATORCENA.Recuperar()
        Me.ddlCATORCENA_ZAFRAID_CATORCENA.SelectedValue = mEntidad.ID_CATORCENA
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.Recuperar()
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue = mEntidad.ID_TIPO_PLANILLA
        Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text = mEntidad.CODIPROVEEDOR_TRANSPORTISTA
        Me.txtNOMBRE_ZAFRA.Text = mEntidad.NOMBRE_ZAFRA
        Me.txtCODIPROVEE.Text = mEntidad.CODIPROVEE
        Me.txtCODISOCIO.Text = mEntidad.CODISOCIO
        Me.txtCANT_RECIBOS.Text = mEntidad.CANT_RECIBOS
        Me.txtTONEL_CANA_ENTREGADA.Text = mEntidad.TONEL_CANA_ENTREGADA
        Me.txtAZUCAR_CATORCENA_REAL.Text = mEntidad.AZUCAR_CATORCENA_REAL
        Me.txtVALOR.Text = mEntidad.VALOR
        Me.txtIVA.Text = mEntidad.IVA
        Me.txtVALOR_BRUTO.Text = mEntidad.VALOR_BRUTO
        Me.txtRENTA.Text = mEntidad.RENTA
        Me.txtRETENCION_IVA.Text = mEntidad.RETENCION_IVA
        Me.txtDESC_FLETE.Text = mEntidad.DESC_FLETE
        Me.txtDESC_CARGA.Text = mEntidad.DESC_CARGA
        Me.txtDESC_CARGA_CONTRA.Text = mEntidad.DESC_CARGA_CONTRA
        Me.txtDESC_BANCOS.Text = mEntidad.DESC_BANCOS
        Me.txtDESC_COMBUSTIBLE.Text = mEntidad.DESC_COMBUSTIBLE
        Me.txtDESC_ANTICIPO.Text = mEntidad.DESC_ANTICIPO
        Me.txtDESC_INTERES.Text = mEntidad.DESC_INTERES
        Me.txtDESC_AGROQUIMICO.Text = mEntidad.DESC_AGROQUIMICO
        Me.txtDESC_SEGURO.Text = mEntidad.DESC_SEGURO
        Me.txtDESC_RESPUESTOS.Text = mEntidad.DESC_RESPUESTOS
        Me.txtDESC_OTROS.Text = mEntidad.DESC_OTROS
        Me.txtPAGO_NETO.Text = mEntidad.PAGO_NETO
        Me.cbxES_CONTRIBUYENTE.Checked = mEntidad.ES_CONTRIBUYENTE
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
        Me.txtDESC_SERVICIO_ROZA.Text = mEntidad.DESC_SERVICIO_ROZA
        Me.txtNOMBRE_PROVEE_TRANS.Text = mEntidad.NOMBRE_PROVEE_TRANS
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_ZAFRA.Enabled = edicion
        Me.txtCODIPROVEE.Enabled = edicion
        Me.txtCODISOCIO.Enabled = edicion
        Me.txtCANT_RECIBOS.Enabled = edicion
        Me.txtTONEL_CANA_ENTREGADA.Enabled = edicion
        Me.txtAZUCAR_CATORCENA_REAL.Enabled = edicion
        Me.txtVALOR.Enabled = edicion
        Me.txtIVA.Enabled = edicion
        Me.txtVALOR_BRUTO.Enabled = edicion
        Me.txtRENTA.Enabled = edicion
        Me.txtRETENCION_IVA.Enabled = edicion
        Me.txtDESC_FLETE.Enabled = edicion
        Me.txtDESC_CARGA.Enabled = edicion
        Me.txtDESC_CARGA_CONTRA.Enabled = edicion
        Me.txtDESC_BANCOS.Enabled = edicion
        Me.txtDESC_COMBUSTIBLE.Enabled = edicion
        Me.txtDESC_ANTICIPO.Enabled = edicion
        Me.txtDESC_INTERES.Enabled = edicion
        Me.txtDESC_AGROQUIMICO.Enabled = edicion
        Me.txtDESC_SEGURO.Enabled = edicion
        Me.txtDESC_RESPUESTOS.Enabled = edicion
        Me.txtDESC_OTROS.Enabled = edicion
        Me.txtPAGO_NETO.Enabled = edicion
        Me.cbxES_CONTRIBUYENTE.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
        Me.txtDESC_SERVICIO_ROZA.Enabled = edicion
        Me.txtNOMBRE_PROVEE_TRANS.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlCATORCENA_ZAFRAID_CATORCENA.Recuperar()
        Me.ddlCATORCENA_ZAFRAID_CATORCENA.SelectedValue = Me.ID_CATORCENA
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.Recuperar()
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue = Me.ID_TIPO_PLANILLA
        Me.txtNOMBRE_ZAFRA.Text = ""
        Me.txtCODIPROVEE.Text = ""
        Me.txtCODISOCIO.Text = ""
        Me.txtCANT_RECIBOS.Text = ""
        Me.txtTONEL_CANA_ENTREGADA.Text = ""
        Me.txtAZUCAR_CATORCENA_REAL.Text = ""
        Me.txtVALOR.Text = ""
        Me.txtIVA.Text = ""
        Me.txtVALOR_BRUTO.Text = ""
        Me.txtRENTA.Text = ""
        Me.txtRETENCION_IVA.Text = ""
        Me.txtDESC_FLETE.Text = ""
        Me.txtDESC_CARGA.Text = ""
        Me.txtDESC_CARGA_CONTRA.Text = ""
        Me.txtDESC_BANCOS.Text = ""
        Me.txtDESC_COMBUSTIBLE.Text = ""
        Me.txtDESC_ANTICIPO.Text = ""
        Me.txtDESC_INTERES.Text = ""
        Me.txtDESC_AGROQUIMICO.Text = ""
        Me.txtDESC_SEGURO.Text = ""
        Me.txtDESC_RESPUESTOS.Text = ""
        Me.txtDESC_OTROS.Text = ""
        Me.txtPAGO_NETO.Text = ""
        Me.cbxES_CONTRIBUYENTE.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
        Me.txtDESC_SERVICIO_ROZA.Text = ""
        Me.txtNOMBRE_PROVEE_TRANS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PLANILLA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PLANILLA
        If Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Codiproveedor transportista que sea valido", True, True)
            Return "Error"
        End If
        mEntidad.ID_CATORCENA = Me.ddlCATORCENA_ZAFRAID_CATORCENA.SelectedValue
        mEntidad.ID_TIPO_PLANILLA = Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue
            mEntidad.CODIPROVEEDOR_TRANSPORTISTA = Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text
        mEntidad.NOMBRE_ZAFRA = Me.txtNOMBRE_ZAFRA.Text
        mEntidad.CODIPROVEE = Me.txtCODIPROVEE.Text
        mEntidad.CODISOCIO = Me.txtCODISOCIO.Text
        mEntidad.CANT_RECIBOS = Val(Me.txtCANT_RECIBOS.Text)
        mEntidad.TONEL_CANA_ENTREGADA = Val(Me.txtTONEL_CANA_ENTREGADA.Text)
        mEntidad.AZUCAR_CATORCENA_REAL = Val(Me.txtAZUCAR_CATORCENA_REAL.Text)
        mEntidad.VALOR = Val(Me.txtVALOR.Text)
        mEntidad.IVA = Val(Me.txtIVA.Text)
        mEntidad.VALOR_BRUTO = Val(Me.txtVALOR_BRUTO.Text)
        mEntidad.RENTA = Val(Me.txtRENTA.Text)
        mEntidad.RETENCION_IVA = Val(Me.txtRETENCION_IVA.Text)
        mEntidad.DESC_FLETE = Val(Me.txtDESC_FLETE.Text)
        mEntidad.DESC_CARGA = Val(Me.txtDESC_CARGA.Text)
        mEntidad.DESC_CARGA_CONTRA = Val(Me.txtDESC_CARGA_CONTRA.Text)
        mEntidad.DESC_BANCOS = Val(Me.txtDESC_BANCOS.Text)
        mEntidad.DESC_COMBUSTIBLE = Val(Me.txtDESC_COMBUSTIBLE.Text)
        mEntidad.DESC_ANTICIPO = Val(Me.txtDESC_ANTICIPO.Text)
        mEntidad.DESC_INTERES = Val(Me.txtDESC_INTERES.Text)
        mEntidad.DESC_AGROQUIMICO = Val(Me.txtDESC_AGROQUIMICO.Text)
        mEntidad.DESC_SEGURO = Val(Me.txtDESC_SEGURO.Text)
        mEntidad.DESC_RESPUESTOS = Val(Me.txtDESC_RESPUESTOS.Text)
        mEntidad.DESC_OTROS = Val(Me.txtDESC_OTROS.Text)
        mEntidad.PAGO_NETO = Val(Me.txtPAGO_NETO.Text)
        mEntidad.ES_CONTRIBUYENTE = Me.cbxES_CONTRIBUYENTE.Checked
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.DESC_SERVICIO_ROZA = Val(Me.txtDESC_SERVICIO_ROZA.Text)
        mEntidad.NOMBRE_PROVEE_TRANS = Me.txtNOMBRE_PROVEE_TRANS.Text

        If Me._nuevo Then
            If mComponente.AgregarPLANILLA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarPLANILLA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCODIPROVEEDOR_TRANSPORTISTA.Text = mEntidad.CODIPROVEEDOR_TRANSPORTISTA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
