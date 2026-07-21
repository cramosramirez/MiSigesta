Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROFORMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROFORMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROFORMA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PROFORMA As Int32
    Public Property ID_PROFORMA() As Int32
        Get
            Return Me.txtID_PROFORMA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PROFORMA = Value
            Me.txtID_PROFORMA.Text = CStr(Value)
            If Me._ID_PROFORMA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.ddlZAFRAID_ZAFRA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlZAFRAID_ZAFRA.Items.FindByValue(value) Is Nothing Then
                Me.ddlZAFRAID_ZAFRA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property DIAZAFRA() As Int32
        Get
            If Me.txtDIAZAFRA.Value Is Nothing Then Return -1
            Return CInt(Me.txtDIAZAFRA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtDIAZAFRA.Value = value
        End Set
    End Property

    Public Property NOPROFORMA() As Int32
        Get
            If Me.txtNOPROFORMA.Value Is Nothing Then Return -1
            Return CInt(Me.txtNOPROFORMA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtNOPROFORMA.Value = value
        End Set
    End Property

    Public Property CODICONTRATO() As String
        Get
            Return Me.txtCODICONTRATO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODICONTRATO.Text = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.txtCODIPROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEEDOR.Text = value.ToString()
        End Set
    End Property

    Public Property ACCESLOTE() As String
        Get
            Return Me.txtACCESLOTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtACCESLOTE.Text = value.ToString()
        End Set
    End Property

    Public Property CODTRANSPORT() As Int32
        Get
            If Me.txtCODTRANSPORT.Value Is Nothing Then Return -1
            Return CInt(Me.txtCODTRANSPORT.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtCODTRANSPORT.Value = value
        End Set
    End Property

    Public Property NOMBRES_MOTORISTA() As String
        Get
            Return Me.txtNOMBRES_MOTORISTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRES_MOTORISTA.Text = value.ToString()
        End Set
    End Property

    Public Property ID_TIPO_CANA() As Int32
        Get
            Return Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_CANAID_TIPO_CANA.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CARGADORA() As Int32
        Get
            Return Me.ddlCARGADORAID_CARGADORA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCARGADORAID_CARGADORA.Items.FindByValue(value) Is Nothing Then
                Me.ddlCARGADORAID_CARGADORA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_SUPERVISOR() As Int32
        Get
            Return Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlSUPERVISORID_SUPERVISOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_QUEMA() As DateTime
        Get
            Return Me.deFECHA_QUEMA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_QUEMA.Value = value
        End Set
    End Property

    Public Property FECHA_CORTA() As DateTime
        Get
            Return Me.deFECHA_CORTA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CORTA.Value = value
        End Set
    End Property

    Public Property QUEMAPROG() As Boolean
        Get
            Return Me.cbxQUEMAPROG.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxQUEMAPROG.Checked = value
        End Set
    End Property

    Public Property QUEMANOPROG() As Boolean
        Get
            Return Me.cbxQUEMANOPROG.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxQUEMANOPROG.Checked = value
        End Set
    End Property

    Public Property FECHA_CARGA() As DateTime
        Get
            Return Me.deFECHA_CARGA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CARGA.Value = value
        End Set
    End Property

    Public Property FECHA_PATIO() As DateTime
        Get
            Return Me.deFECHA_PATIO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_PATIO.Value = value
        End Set
    End Property

    Public Property ID_PRODUCTO() As Int32
        Get
            Return Me.ddlPRODUCTOID_PRODUCTO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlPRODUCTOID_PRODUCTO.Items.FindByValue(value) Is Nothing Then
                Me.ddlPRODUCTOID_PRODUCTO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FIN_LOTE() As Boolean
        Get
            Return Me.cbxFIN_LOTE.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxFIN_LOTE.Checked = value
        End Set
    End Property

    Public Property FECHA_ENTRADA() As DateTime
        Get
            Return Me.deFECHA_ENTRADA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ENTRADA.Value = value
        End Set
    End Property

    Public Property PLACAVEHIC() As String
        Get
            Return Me.txtPLACAVEHIC.Text
        End Get
        Set(ByVal value As String)
            Me.txtPLACAVEHIC.Text = value.ToString()
        End Set
    End Property

    Public Property ID_TIPOTRANS() As Int32
        Get
            Return Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.SelectedValue = value
            End If
        End Set
    End Property

    Public Property SERVICIO_ROZA() As Boolean
        Get
            Return Me.cbxSERVICIO_ROZA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxSERVICIO_ROZA.Checked = value
        End Set
    End Property

    Public Property TRANSPORTE_PROPIO() As Boolean
        Get
            Return Me.cbxTRANSPORTE_PROPIO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxTRANSPORTE_PROPIO.Checked = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_ROZA() As Int32
        Get
            Return Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Items.FindByValue(value) Is Nothing Then
                Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CARGADOR() As Int32
        Get
            Return Me.ddlCARGADORID_CARGADOR.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCARGADORID_CARGADOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlCARGADORID_CARGADOR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property TIPO_TARIFA_CARGADORA() As Int32
        Get
            If Me.txtTIPO_TARIFA_CARGADORA.Value Is Nothing Then Return -1
            Return CInt(Me.txtTIPO_TARIFA_CARGADORA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtTIPO_TARIFA_CARGADORA.Value = value
        End Set
    End Property

    Public Property ID_MOTORISTA() As Int32
        Get
            If Me.txtID_MOTORISTA.Value Is Nothing Then Return -1
            Return CInt(Me.txtID_MOTORISTA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtID_MOTORISTA.Value = value
        End Set
    End Property

    Public Property OBSERVACIONES() As String
        Get
            Return Me.txtOBSERVACIONES.Text
        End Get
        Set(ByVal value As String)
            Me.txtOBSERVACIONES.Text = value.ToString()
        End Set
    End Property

    Public Property ID_ENVIO() As Int32
        Get
            Return Me.ddlENVIOID_ENVIO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlENVIOID_ENVIO.Items.FindByValue(value) Is Nothing Then
                Me.ddlENVIOID_ENVIO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ESTADO() As String
        Get
            Return Me.txtESTADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtESTADO.Text = value.ToString()
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
            Return Me.deFECHA_CREA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREA.Value = value
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
            Return Me.deFECHA_ACT.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ACT.Value = value
        End Set
    End Property

    Public Property VerID_PROFORMA() As Boolean
        Get
            Return Me.trID_PROFORMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROFORMA.Visible = value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.trDIAZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIAZAFRA.Visible = value
        End Set
    End Property

    Public Property VerNOPROFORMA() As Boolean
        Get
            Return Me.trNOPROFORMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOPROFORMA.Visible = value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.trCODICONTRATO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODICONTRATO.Visible = value
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

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.trACCESLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACCESLOTE.Visible = value
        End Set
    End Property

    Public Property VerCODTRANSPORT() As Boolean
        Get
            Return Me.trCODTRANSPORT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODTRANSPORT.Visible = value
        End Set
    End Property

    Public Property VerNOMBRES_MOTORISTA() As Boolean
        Get
            Return Me.trNOMBRES_MOTORISTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRES_MOTORISTA.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_CANA() As Boolean
        Get
            Return Me.trID_TIPO_CANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_CANA.Visible = value
        End Set
    End Property

    Public Property VerID_CARGADORA() As Boolean
        Get
            Return Me.trID_CARGADORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CARGADORA.Visible = value
        End Set
    End Property

    Public Property VerID_SUPERVISOR() As Boolean
        Get
            Return Me.trID_SUPERVISOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SUPERVISOR.Visible = value
        End Set
    End Property

    Public Property VerFECHA_QUEMA() As Boolean
        Get
            Return Me.trFECHA_QUEMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_QUEMA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CORTA() As Boolean
        Get
            Return Me.trFECHA_CORTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CORTA.Visible = value
        End Set
    End Property

    Public Property VerQUEMAPROG() As Boolean
        Get
            Return Me.trQUEMAPROG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trQUEMAPROG.Visible = value
        End Set
    End Property

    Public Property VerQUEMANOPROG() As Boolean
        Get
            Return Me.trQUEMANOPROG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trQUEMANOPROG.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CARGA() As Boolean
        Get
            Return Me.trFECHA_CARGA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CARGA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_PATIO() As Boolean
        Get
            Return Me.trFECHA_PATIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_PATIO.Visible = value
        End Set
    End Property

    Public Property VerID_PRODUCTO() As Boolean
        Get
            Return Me.trID_PRODUCTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PRODUCTO.Visible = value
        End Set
    End Property

    Public Property VerFIN_LOTE() As Boolean
        Get
            Return Me.trFIN_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFIN_LOTE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA() As Boolean
        Get
            Return Me.trFECHA_ENTRADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ENTRADA.Visible = value
        End Set
    End Property

    Public Property VerPLACAVEHIC() As Boolean
        Get
            Return Me.trPLACAVEHIC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPLACAVEHIC.Visible = value
        End Set
    End Property

    Public Property VerID_TIPOTRANS() As Boolean
        Get
            Return Me.trID_TIPOTRANS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPOTRANS.Visible = value
        End Set
    End Property

    Public Property VerSERVICIO_ROZA() As Boolean
        Get
            Return Me.trSERVICIO_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSERVICIO_ROZA.Visible = value
        End Set
    End Property

    Public Property VerTRANSPORTE_PROPIO() As Boolean
        Get
            Return Me.trTRANSPORTE_PROPIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTRANSPORTE_PROPIO.Visible = value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_ROZA() As Boolean
        Get
            Return Me.trID_PROVEEDOR_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_ROZA.Visible = value
        End Set
    End Property

    Public Property VerID_CARGADOR() As Boolean
        Get
            Return Me.trID_CARGADOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CARGADOR.Visible = value
        End Set
    End Property

    Public Property VerTIPO_TARIFA_CARGADORA() As Boolean
        Get
            Return Me.trTIPO_TARIFA_CARGADORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_TARIFA_CARGADORA.Visible = value
        End Set
    End Property

    Public Property VerID_MOTORISTA() As Boolean
        Get
            Return Me.trID_MOTORISTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_MOTORISTA.Visible = value
        End Set
    End Property

    Public Property VerOBSERVACIONES() As Boolean
        Get
            Return Me.trOBSERVACIONES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBSERVACIONES.Visible = value
        End Set
    End Property

    Public Property VerID_ENVIO() As Boolean
        Get
            Return Me.trID_ENVIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ENVIO.Visible = value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.trESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO.Visible = value
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

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROFORMA
    Private mEntidad As PROFORMA
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
        If Not Me.ViewState("ID_PROFORMA") Is Nothing Then Me._ID_PROFORMA = Me.ViewState("ID_PROFORMA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROFORMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROFORMA
        mEntidad.ID_PROFORMA = ID_PROFORMA
 
        If mComponente.ObtenerPROFORMA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PROFORMA.Text = mEntidad.ID_PROFORMA.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.txtDIAZAFRA.Value = mEntidad.DIAZAFRA
        Me.txtNOPROFORMA.Value = mEntidad.NOPROFORMA
        Me.txtCODICONTRATO.Text = mEntidad.CODICONTRATO
        Me.txtCODIPROVEEDOR.Text = mEntidad.CODIPROVEEDOR
        Me.txtACCESLOTE.Text = mEntidad.ACCESLOTE
        Me.txtCODTRANSPORT.Value = mEntidad.CODTRANSPORT
        Me.txtNOMBRES_MOTORISTA.Text = mEntidad.NOMBRES_MOTORISTA
        Me.ddlTIPO_CANAID_TIPO_CANA.Recuperar()
        Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue = mEntidad.ID_TIPO_CANA
        Me.ddlCARGADORAID_CARGADORA.Recuperar()
        Me.ddlCARGADORAID_CARGADORA.SelectedValue = mEntidad.ID_CARGADORA
        Me.ddlSUPERVISORID_SUPERVISOR.Recuperar()
        Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue = mEntidad.ID_SUPERVISOR
        Me.deFECHA_QUEMA.Value = mEntidad.FECHA_QUEMA
        Me.deFECHA_CORTA.Value = mEntidad.FECHA_CORTA
        Me.cbxQUEMAPROG.Checked = mEntidad.QUEMAPROG
        Me.cbxQUEMANOPROG.Checked = mEntidad.QUEMANOPROG
        Me.deFECHA_PATIO.Value = mEntidad.FECHA_PATIO
        Me.ddlPRODUCTOID_PRODUCTO.Recuperar()
        Me.ddlPRODUCTOID_PRODUCTO.SelectedValue = mEntidad.ID_PRODUCTO
        Me.cbxFIN_LOTE.Checked = mEntidad.FIN_LOTE
        Me.txtPLACAVEHIC.Text = mEntidad.PLACAVEHIC
        Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.Recuperar()
        Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.SelectedValue = mEntidad.ID_TIPOTRANS
        Me.cbxSERVICIO_ROZA.Checked = mEntidad.SERVICIO_ROZA
        Me.cbxTRANSPORTE_PROPIO.Checked = mEntidad.TRANSPORTE_PROPIO
        Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Recuperar()
        Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.SelectedValue = mEntidad.ID_PROVEEDOR_ROZA
        Me.ddlCARGADORID_CARGADOR.Recuperar()
        Me.ddlCARGADORID_CARGADOR.SelectedValue = mEntidad.ID_CARGADOR
        Me.txtTIPO_TARIFA_CARGADORA.Value = mEntidad.TIPO_TARIFA_CARGADORA
        Me.txtID_MOTORISTA.Value = mEntidad.ID_MOTORISTA
        Me.txtOBSERVACIONES.Text = mEntidad.OBSERVACIONES
        Me.ddlENVIOID_ENVIO.Recuperar()
        Me.ddlENVIOID_ENVIO.SelectedValue = mEntidad.ID_ENVIO
        Me.txtESTADO.Text = mEntidad.ESTADO
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT

    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlTIPO_CANAID_TIPO_CANA.Enabled = edicion
        Me.ddlCARGADORAID_CARGADORA.Enabled = edicion
        Me.ddlSUPERVISORID_SUPERVISOR.Enabled = edicion
        Me.ddlPRODUCTOID_PRODUCTO.Enabled = edicion
        Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.Enabled = edicion
        Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Enabled = edicion
        Me.ddlCARGADORID_CARGADOR.Enabled = edicion
        Me.ddlENVIOID_ENVIO.Enabled = edicion
        Me.txtDIAZAFRA.Enabled = edicion
        Me.txtNOPROFORMA.Enabled = edicion
        Me.txtCODICONTRATO.Enabled = edicion
        Me.txtCODIPROVEEDOR.Enabled = edicion
        Me.txtACCESLOTE.Enabled = edicion
        Me.txtCODTRANSPORT.Enabled = edicion
        Me.txtNOMBRES_MOTORISTA.Enabled = edicion
        Me.deFECHA_QUEMA.Enabled = edicion
        Me.deFECHA_CORTA.Enabled = edicion
        Me.cbxQUEMAPROG.Enabled = edicion
        Me.cbxQUEMANOPROG.Enabled = edicion
        Me.deFECHA_CARGA.Enabled = edicion
        Me.deFECHA_PATIO.Enabled = edicion
        Me.cbxFIN_LOTE.Enabled = edicion
        Me.deFECHA_ENTRADA.Enabled = edicion
        Me.txtPLACAVEHIC.Enabled = edicion
        Me.cbxSERVICIO_ROZA.Enabled = edicion
        Me.cbxTRANSPORTE_PROPIO.Enabled = edicion
        Me.txtTIPO_TARIFA_CARGADORA.Enabled = edicion
        Me.txtID_MOTORISTA.Enabled = edicion
        Me.txtOBSERVACIONES.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlTIPO_CANAID_TIPO_CANA.Recuperar()
        Me.ddlCARGADORAID_CARGADORA.Recuperar()
        Me.ddlSUPERVISORID_SUPERVISOR.Recuperar()
        Me.ddlPRODUCTOID_PRODUCTO.Recuperar()
        Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.Recuperar()
        Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.Recuperar()
        Me.ddlCARGADORID_CARGADOR.Recuperar()
        Me.ddlENVIOID_ENVIO.Recuperar()
        Me.txtDIAZAFRA.Value = Nothing
        Me.txtNOPROFORMA.Value = Nothing
        Me.txtCODICONTRATO.Text = ""
        Me.txtCODIPROVEEDOR.Text = ""
        Me.txtACCESLOTE.Text = ""
        Me.txtCODTRANSPORT.Value = Nothing
        Me.txtNOMBRES_MOTORISTA.Text = ""
        Me.deFECHA_QUEMA.Value = Nothing
        Me.deFECHA_CORTA.Value = Nothing
        Me.cbxQUEMAPROG.Checked = False
        Me.cbxQUEMANOPROG.Checked = False
        Me.deFECHA_CARGA.Value = Nothing
        Me.deFECHA_PATIO.Value = Nothing
        Me.cbxFIN_LOTE.Checked = False
        Me.deFECHA_ENTRADA.Value = Nothing
        Me.txtPLACAVEHIC.Text = ""
        Me.cbxSERVICIO_ROZA.Checked = False
        Me.cbxTRANSPORTE_PROPIO.Checked = False
        Me.txtTIPO_TARIFA_CARGADORA.Value = Nothing
        Me.txtID_MOTORISTA.Value = Nothing
        Me.txtOBSERVACIONES.Text = ""
        Me.txtESTADO.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROFORMA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROFORMA
        If Me._nuevo Then
            mEntidad.ID_PROFORMA = 0
        Else
            mEntidad = (New cPROFORMA).obtenerproforma(CInt(Me.txtID_PROFORMA.Text))
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.DIAZAFRA = Me.txtDIAZAFRA.Value
        mEntidad.NOPROFORMA = Me.txtNOPROFORMA.Value
        mEntidad.CODICONTRATO = Me.txtCODICONTRATO.Text
        mEntidad.CODIPROVEEDOR = Me.txtCODIPROVEEDOR.Text
        mEntidad.ACCESLOTE = Me.txtACCESLOTE.Text
        mEntidad.CODTRANSPORT = Me.txtCODTRANSPORT.Value
        mEntidad.NOMBRES_MOTORISTA = Me.txtNOMBRES_MOTORISTA.Text
        mEntidad.ID_TIPO_CANA = Me.ddlTIPO_CANAID_TIPO_CANA.SelectedValue
        mEntidad.ID_CARGADORA = Me.ddlCARGADORAID_CARGADORA.SelectedValue
        mEntidad.ID_SUPERVISOR = Me.ddlSUPERVISORID_SUPERVISOR.SelectedValue
        mEntidad.FECHA_QUEMA = Me.deFECHA_QUEMA.Value
        mEntidad.FECHA_CORTA = Me.deFECHA_CORTA.Value
        mEntidad.QUEMAPROG = Me.cbxQUEMAPROG.Checked
        mEntidad.QUEMANOPROG = Me.cbxQUEMANOPROG.Checked
        mEntidad.FECHA_PATIO = Me.deFECHA_PATIO.Value
        mEntidad.ID_PRODUCTO = Me.ddlPRODUCTOID_PRODUCTO.SelectedValue
        mEntidad.FIN_LOTE = Me.cbxFIN_LOTE.Checked
        mEntidad.PLACAVEHIC = Me.txtPLACAVEHIC.Text
        mEntidad.ID_TIPOTRANS = Me.ddlTIPO_TRANSPORTEID_TIPOTRANS.SelectedValue
        mEntidad.SERVICIO_ROZA = Me.cbxSERVICIO_ROZA.Checked
        mEntidad.TRANSPORTE_PROPIO = Me.cbxTRANSPORTE_PROPIO.Checked
        mEntidad.ID_PROVEEDOR_ROZA = Me.ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA.SelectedValue
        mEntidad.ID_CARGADOR = Me.ddlCARGADORID_CARGADOR.SelectedValue
        mEntidad.TIPO_TARIFA_CARGADORA = Me.txtTIPO_TARIFA_CARGADORA.Value
        mEntidad.ID_MOTORISTA = Me.txtID_MOTORISTA.Value
        mEntidad.OBSERVACIONES = Me.txtOBSERVACIONES.Text
        mEntidad.ID_ENVIO = Me.ddlENVIOID_ENVIO.SelectedValue
        mEntidad.ESTADO = Me.txtESTADO.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarPROFORMA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PROFORMA.Text = mEntidad.ID_PROFORMA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
