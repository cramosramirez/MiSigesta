Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesSubLote_ucMantSUBLOTES
    Inherits ucBase

    Public Property ID_MAESTRO As Integer
        Set(value As Integer)
            Me.ViewState("ID_MAESTRO") = value
        End Set
        Get
            If Me.ViewState("ID_MAESTRO") Is Nothing Then
                Return -1
            Else
                Return Convert.ToInt32(Me.ViewState("ID_MAESTRO"))
            End If
        End Get
    End Property
    Public Property ID_SUBLOTES As Integer
        Set(value As Integer)
            Me.ViewState("ID_SUBLOTES") = value
            Nuevo()
            Dim resultado() As String
            resultado = CargarSubLote().Split("|")
            If resultado(0) <> "1" Then
                Me.AsignarMensaje("Error al cargar datos del sublote: " + resultado(1), False, True, True)
            End If
        End Set
        Get
            If Me.ViewState("ID_SUBLOTES") Is Nothing Then
                Return -1
            Else
                Return Convert.ToInt32(Me.ViewState("ID_SUBLOTES"))
            End If
        End Get
    End Property

    Private Sub controlesSubLote_ucMantSUBLOTES_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
            InicializarLista()
            ucListaSUBLOTES1.CargarDatosPoCriterios(ID_MAESTRO)
        End If
    End Sub

    Private Function CargarSubLote() As String
        Dim bEntidad As New cSUBLOTES
        Dim lEntidad As SUBLOTES

        Try
            If ID_SUBLOTES > 0 Then
                lEntidad = bEntidad.ObtenerSUBLOTES(ID_SUBLOTES)
                CODIGOtxt.Text = lEntidad.CODIGO
                CORRELATIVOtxt.Text = lEntidad.CORRELATIVO
                NOMBRE_PORCIONtxt.Text = lEntidad.NOMBRE_PORCION
                CODIVARIEDAcbx.Value = IIf(String.IsNullOrEmpty(lEntidad.CODIVARIEDA), Nothing, lEntidad.CODIVARIEDA)
                ID_TIPO_SIEMBRAcbx.Value = IIf(lEntidad.ID_TIPO_SIEMBRA <= 0, Nothing, lEntidad.ID_TIPO_SIEMBRA)
                FECHA_SIEMBRAdte.Value = IIf(lEntidad.FECHA_SIEMBRA = Nothing, Nothing, lEntidad.FECHA_SIEMBRA)
                DISTANCIAMIENTOspin.Value = IIf(lEntidad.DISTANCIAMIENTO <= 0, Nothing, lEntidad.DISTANCIAMIENTO)
                CICLOspin.Value = IIf(lEntidad.CICLO <= 0, Nothing, lEntidad.CICLO)
                ZONA_RAMSARchk.Checked = lEntidad.ZONA_RAMSAR
                LONGITUDtxt.Text = lEntidad.LONGITUD.Trim.ToUpper
                LATITUDtxt.Text = lEntidad.LATITUD.Trim.ToUpper
                ALTITUDtxt.Text = lEntidad.ALTITUD.Trim.ToUpper
                ID_TIPOSUELOcbx.Value = IIf(lEntidad.ID_TIPO_SUELO <= 0, Nothing, lEntidad.ID_TIPO_SUELO)
                ID_RIESGO_PIEDRAcbx.Value = IIf(lEntidad.ID_RIESGO_PIEDRA <= 0, Nothing, lEntidad.ID_RIESGO_PIEDRA)
                ID_ESTRATOcbx.Value = IIf(lEntidad.ID_ESTRATO <= 0, Nothing, lEntidad.ID_ESTRATO)
                ID_TOPOGRAFIAcbx.Value = IIf(lEntidad.ID_TOPOGRAFIA <= 0, Nothing, lEntidad.ID_TOPOGRAFIA)
                VIABILIDAD_RIEGOchk.Checked = lEntidad.VIABILIDAD_RIEGO
                AREA_CONTRATOspin.Value = IIf(lEntidad.AREA_CONTRATO <= 0, Nothing, lEntidad.AREA_CONTRATO)
                AREA_PRODUCTIVAspin.Value = IIf(lEntidad.AREA_PRODUCTIVA <= 0, Nothing, lEntidad.AREA_PRODUCTIVA)
                AREA_EFECspin.Value = IIf(lEntidad.AREA_EFEC <= 0, Nothing, lEntidad.AREA_EFEC)
                TC_MZ_EFECspin.Value = IIf(lEntidad.TC_MZ_EFEC <= 0, Nothing, lEntidad.TC_MZ_EFEC)
                TC_EFECspin.Value = IIf(lEntidad.TC_EFEC <= 0, Nothing, lEntidad.TC_EFEC)
                ID_USO_MADcbx.Value = IIf(lEntidad.ID_USO_MAD <= 0, Nothing, lEntidad.ID_USO_MAD)
                ID_TIPOcbx.Value = IIf(lEntidad.ID_TIPO <= 0, Nothing, lEntidad.ID_TIPO)
                POTENCIAL_COSECHA_MECAchk.Checked = lEntidad.POTENCIAL_COSECHA_MECA
                TIPO_QUEMAcbx.Value = IIf(lEntidad.TIPO_QUEMA = Nothing, Nothing, lEntidad.TIPO_QUEMA)
                ID_TIPO_TRANS_VMTcbx.Value = IIf(lEntidad.ID_TIPO_TRANS_VMT <= 0, Nothing, lEntidad.ID_TIPO_TRANS_VMT)
                CIRCUITOspin.Value = IIf(lEntidad.CIRCUITO <= 0, Nothing, lEntidad.CIRCUITO)
                TARIFAspin.Value = IIf(lEntidad.TARIFA <= 0, Nothing, lEntidad.TARIFA)
                CARRET_PPALspin.Value = IIf(lEntidad.CARRET_PPAL <= 0, Nothing, lEntidad.CARRET_PPAL)
                CARRET_SECspin.Value = IIf(lEntidad.CARRET_SEC <= 0, Nothing, lEntidad.CARRET_SEC)
                REPARA_ACCESOchk.Checked = lEntidad.REPARA_ACCESO
                FECHA_COSECHAdte.Value = IIf(lEntidad.FECHA_COSECHA = Nothing, Nothing, lEntidad.FECHA_COSECHA)
                ES_CERRADOchk.Checked = lEntidad.ES_CERRADO
            End If
            Return "1|Carga exitosa"

        Catch ex As Exception
            Return "2|" & ex.Message.ToString
        End Try
    End Function

    Private Sub Nuevo()
        CODIGOtxt.ClientEnabled = False
        CORRELATIVOtxt.ClientEnabled = False
        CODIGOtxt.Text = ""
        CORRELATIVOtxt.Text = ""
        NOMBRE_PORCIONtxt.Text = ""
        CODIVARIEDAcbx.SelectedIndex = -1
        ID_TIPO_SIEMBRAcbx.SelectedIndex = -1
        FECHA_SIEMBRAdte.Value = Nothing
        DISTANCIAMIENTOspin.Value = Nothing
        CICLOspin.Value = Nothing
        ZONA_RAMSARchk.Checked = False
        LONGITUDtxt.Text = ""
        LATITUDtxt.Text = ""
        ALTITUDtxt.Text = ""
        ID_TIPOSUELOcbx.SelectedIndex = -1
        ID_RIESGO_PIEDRAcbx.SelectedIndex = -1
        ID_ESTRATOcbx.SelectedIndex = -1
        ID_TOPOGRAFIAcbx.SelectedIndex = -1
        VIABILIDAD_RIEGOchk.Checked = False
        AREA_CONTRATOspin.Value = Nothing
        AREA_CONTRATOspin.ClientEnabled = False
        AREA_PRODUCTIVAspin.Value = Nothing
        AREA_EFECspin.Value = Nothing
        TC_MZ_EFECspin.Value = Nothing
        TC_EFECspin.Value = Nothing
        TC_EFECspin.ClientEnabled = False
        ID_USO_MADcbx.SelectedIndex = -1
        ID_TIPOcbx.SelectedIndex = -1
        POTENCIAL_COSECHA_MECAchk.Checked = False
        TIPO_QUEMAcbx.SelectedIndex = -1
        ID_TIPO_TRANS_VMTcbx.SelectedIndex = -1
        CIRCUITOspin.Value = Nothing
        TARIFAspin.Value = Nothing
        CARRET_PPALspin.Value = Nothing
        CARRET_SECspin.Value = Nothing
        REPARA_ACCESOchk.Checked = False
        FECHA_COSECHAdte.Value = Nothing
        ES_CERRADOchk.Checked = False

        Me.Cargar_TM_Contratada()

    End Sub

    Private Sub Cargar_TM_Contratada()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        If lZafraActiva IsNot Nothing Then
            Dim lstLotes As listaLOTES = (New cLOTES).ObtenerListaPorZAFRA_MAESTRO_LOTES(lZafraActiva.ID_ZAFRA, Me.ID_MAESTRO)
            If lstLotes IsNot Nothing AndAlso lstLotes.Count > 0 Then
                Me.AREA_CONTRATOspin.Value = lstLotes(0).AREA
            End If
        End If
    End Sub

    Private Sub Total_TM_EFECTIVA()
        Dim ha_efeciva As Decimal = 0
        Dim TCH_efectiva As Decimal = 0
        Dim TM_efectiva As Decimal = 0

        If Decimal.TryParse(Me.AREA_EFECspin.Value, ha_efeciva) Then
            If Decimal.TryParse(Me.TC_MZ_EFECspin.Value, TCH_efectiva) Then
                TM_efectiva = Math.Round(ha_efeciva * TCH_efectiva, 2)
            End If
        End If
        Me.TC_EFECspin.Value = TM_efectiva
    End Sub

    Private Function Actualizar() As String
        Dim bEntidad As New cSUBLOTES
        Dim lEntidad As SUBLOTES
        Dim resultado As String = ""

        Try
            If ID_SUBLOTES > 0 Then
                lEntidad = bEntidad.ObtenerSUBLOTES(ID_SUBLOTES)
            Else
                lEntidad = New SUBLOTES
                lEntidad.ID_SUBLOTES = 0
                lEntidad.CORRELATIVO = bEntidad.ObtenerCorrelativoPorMaestro(Me.ID_MAESTRO)
                If lEntidad.CORRELATIVO.ToString.Length = 1 Then
                    lEntidad.CODIGO = Me.ID_MAESTRO.ToString + "-0" + lEntidad.CORRELATIVO.ToString
                Else
                    lEntidad.CODIGO = Me.ID_MAESTRO.ToString + "-" + lEntidad.CORRELATIVO.ToString
                End If
            End If

            If lEntidad IsNot Nothing Then
                lEntidad.ID_MAESTRO = ID_MAESTRO
                lEntidad.NOMBRE_PORCION = NOMBRE_PORCIONtxt.Text.Trim.ToUpper
                lEntidad.CODIVARIEDA = CODIVARIEDAcbx.Value.ToString
                lEntidad.ID_TIPO_SIEMBRA = CInt(ID_TIPO_SIEMBRAcbx.Value)
                lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRAdte.Date
                lEntidad.DISTANCIAMIENTO = IIf(String.IsNullOrEmpty(DISTANCIAMIENTOspin.Text), -1, DISTANCIAMIENTOspin.Text)
                lEntidad.CICLO = IIf(String.IsNullOrEmpty(CICLOspin.Text), -1, CICLOspin.Text)
                lEntidad.ZONA_RAMSAR = ZONA_RAMSARchk.Checked
                lEntidad.LONGITUD = LONGITUDtxt.Text.Trim
                lEntidad.LATITUD = LATITUDtxt.Text.Trim
                lEntidad.ALTITUD = ALTITUDtxt.Text.Trim
                lEntidad.ID_TIPO_SUELO = IIf(ID_TIPOSUELOcbx.Value = Nothing, -1, ID_TIPOSUELOcbx.Value)
                lEntidad.ID_RIESGO_PIEDRA = IIf(ID_RIESGO_PIEDRAcbx.Value = Nothing, -1, ID_RIESGO_PIEDRAcbx.Value)
                lEntidad.ID_ESTRATO = IIf(ID_ESTRATOcbx.Value = Nothing, -1, ID_ESTRATOcbx.Value)
                lEntidad.ID_TOPOGRAFIA = IIf(ID_TOPOGRAFIAcbx.Value = Nothing, -1, ID_TOPOGRAFIAcbx.Value)
                lEntidad.VIABILIDAD_RIEGO = VIABILIDAD_RIEGOchk.Checked
                lEntidad.AREA_CONTRATO = IIf(String.IsNullOrEmpty(AREA_CONTRATOspin.Text), -1, AREA_CONTRATOspin.Text)
                lEntidad.AREA_PRODUCTIVA = IIf(String.IsNullOrEmpty(AREA_PRODUCTIVAspin.Text), -1, AREA_PRODUCTIVAspin.Text)
                lEntidad.AREA_EFEC = IIf(String.IsNullOrEmpty(AREA_EFECspin.Text), -1, AREA_EFECspin.Text)
                lEntidad.TC_MZ_EFEC = IIf(String.IsNullOrEmpty(TC_MZ_EFECspin.Text), -1, TC_MZ_EFECspin.Text)
                lEntidad.TC_EFEC = IIf(String.IsNullOrEmpty(TC_EFECspin.Text), -1, TC_EFECspin.Text)
                lEntidad.ID_USO_MAD = IIf(ID_USO_MADcbx.Value = Nothing, -1, ID_USO_MADcbx.Value)
                lEntidad.ID_TIPO = IIf(ID_TIPOcbx.Value = Nothing, -1, ID_TIPOcbx.Value)
                lEntidad.POTENCIAL_COSECHA_MECA = POTENCIAL_COSECHA_MECAchk.Checked
                lEntidad.TIPO_QUEMA = If(TIPO_QUEMAcbx.Value = Nothing, "", TIPO_QUEMAcbx.Value.ToString)
                lEntidad.ID_TIPO_TRANS_VMT = IIf(ID_TIPO_TRANS_VMTcbx.Value = Nothing, -1, ID_TIPO_TRANS_VMTcbx.Value)
                lEntidad.CIRCUITO = IIf(String.IsNullOrEmpty(CIRCUITOspin.Text), -1, CIRCUITOspin.Text)
                lEntidad.TARIFA = IIf(String.IsNullOrEmpty(TARIFAspin.Text), -1, TARIFAspin.Text)
                lEntidad.CARRET_PPAL = IIf(String.IsNullOrEmpty(CARRET_PPALspin.Text), -1, CARRET_PPALspin.Text)
                lEntidad.CARRET_SEC = IIf(String.IsNullOrEmpty(CARRET_SECspin.Text), -1, CARRET_SECspin.Text)
                lEntidad.REPARA_ACCESO = REPARA_ACCESOchk.Checked
                lEntidad.FECHA_COSECHA = FECHA_COSECHAdte.Date
                lEntidad.ES_CERRADO = ES_CERRADOchk.Checked

                If bEntidad.ActualizarSUBLOTES(lEntidad) >= 1 Then
                    resultado = "1|Actualización completada"
                    Nuevo()
                Else
                    resultado = "2|Fallo al crear o actualizar sublote: " + bEntidad.sError
                End If
            Else
                resultado = "2|Error al recuperar el sublote"
            End If
            Return resultado

        Catch ex As Exception
            Return "2|" & ex.Message.ToString
        End Try
    End Function

    Private Sub Inicializar()
        If Me.Request.QueryString.Count > 0 AndAlso Me.Request.QueryString("maestro").ToString <> "" AndAlso IsNumeric(Me.Request.QueryString("maestro").ToString) Then
            Me.ID_MAESTRO = Convert.ToInt32(Me.Request.QueryString("maestro").ToString)
            Dim lEntidad As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(Me.ID_MAESTRO)
            If lEntidad IsNot Nothing Then
                Me.NOMBRE_MAESTRO.Text = "ID Maestro: " + lEntidad.ID_MAESTRO.ToString + "   Lote Maestro: " + lEntidad.NOMBRE_COMER
            Else
                Me.NOMBRE_MAESTRO.Text = "[HAGA REFERENCIA A UN MAESTRO DE LOTE]"
            End If
        Else
            Me.ID_MAESTRO = 0
            Me.NOMBRE_MAESTRO.Text = "[HAGA REFERENCIA A UN MAESTRO DE LOTE]"
        End If
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nuevo sublote", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Private Sub InicializarLista()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaSUBLOTES1.Visible = True
        Me.frmVistaSUBLOTES.Visible = False
    End Sub

    Private Sub InicializarVista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucListaSUBLOTES1.Visible = False
        Me.frmVistaSUBLOTES.Visible = True
    End Sub

    Private Sub ucListaSUBLOTES1_Editando(ID_SUBLOTES As Integer) Handles ucListaSUBLOTES1.Editando
        InicializarVista()
        ucListaSUBLOTES1.Visible = False
        frmVistaSUBLOTES.Visible = True
        Me.ID_SUBLOTES = ID_SUBLOTES
    End Sub

    Private Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Agregar"
                InicializarVista()
                ID_SUBLOTES = 0

            Case "Guardar"
                Dim resultado() As String
                resultado = Actualizar().Split("|")
                If resultado(0) = "1" Then
                    AsignarMensaje("Registro exitoso", False, True, True)
                    InicializarLista()
                    ucListaSUBLOTES1.DataBind()
                Else
                    AsignarMensaje("Error: " + resultado(1), False, True, True)
                End If

            Case "Cancelar"
                InicializarLista()
                ucListaSUBLOTES1.DataBind()
        End Select
    End Sub

    Private Sub AREA_EFECspin_ValueChanged(sender As Object, e As EventArgs) Handles AREA_EFECspin.ValueChanged
        Me.Total_TM_EFECTIVA()
        TC_MZ_EFECspin.Focus()
    End Sub

    Private Sub TC_MZ_EFECspin_ValueChanged(sender As Object, e As EventArgs) Handles TC_MZ_EFECspin.ValueChanged
        Me.Total_TM_EFECTIVA()
        Me.TC_EFECspin.Focus()
    End Sub
End Class
