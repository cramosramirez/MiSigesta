Public Class frmEmisionComprobantes

    Private Sub frmEmisionComprobantes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmEmisionComprobantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Inicializar()
    End Sub

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.CbxTIPO_PLANILLA1.Recuperar()
        Me.cbxTipoDocumento.Items.Clear()
        Me.cbxTipoDocumento.Items.Add("COMPROBANTE DE RETENCION 1% IVA")
        Me.cbxTipoDocumento.Items.Add("COMPROBANTE DE RETENCION - NO CONTRIBUYENTES")
        Me.cbxTipoDocumento.Items.Add("CREDITO FISCAL SERVICIOS DEL INGENIO")
        Me.cbxTipoDocumento.Items.Add("FACTURA POR SERVICIOS DEL INGENIO")
        Me.cbxTipoDocumento.Items.Add("FACTURA DE SUJETO EXCLUIDO")
        Me.cbxTipoDocumento.Items.Add("CREDITO FISCAL (FRENTE CALIDAD AT / SDV)")
        Me.cbxTipoDocumento.Items.Add("FACTURA (FRENTE CALIDAD AT / SDV)")
        Me.cbxTipoDocumento.SelectedIndex = 0
        Me.lblRangoCompensacion.Visible = False
        Me.cbxRANGO_COMPENSACION1.Visible = False

        Me.AsignarFechaComprobantesSugerida()
    End Sub

    Private Sub AsignarFechaComprobantesSugerida()
        Dim lstPlanillaBase As listaPLANILLA_BASE

        Me.dteFechaComprobante.Text = ""
        lstPlanillaBase = (New cPLANILLA_BASE).ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(CbxZAFRA1.SelectedValue, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue)
        If lstPlanillaBase IsNot Nothing AndAlso lstPlanillaBase.Count > 0 Then
            Me.dteFechaComprobante.DateTime = lstPlanillaBase(0).FECHA_COMPROB
        End If
    End Sub

    Private Function ObtenerID_TIPO_COMPROB(ByVal indice As Integer) As Integer
        Dim idTipoComprob As Integer = 0

        Select Case indice
            Case 0
                idTipoComprob = 9
            Case 1
                idTipoComprob = 9
            Case 2
                idTipoComprob = 1
            Case 3
                idTipoComprob = 2
            Case 4
                idTipoComprob = 10
            Case 5
                idTipoComprob = 1
            Case 6
                idTipoComprob = 2
        End Select

        Return idTipoComprob
    End Function

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVerComprobante_Click(sender As System.Object, e As System.EventArgs) Handles btnVerComprobante.Click
        Dim lPlanillaBase As PLANILLA_BASE
        Dim bPlanilla As New cPLANILLA
        Dim lstPlanilla As listaPLANILLA
        Dim sResult As String = ""
        Dim idComprobConce As Integer = 0

        If txtNO_DOCUMENTO.Text = "" Then
            MsgBox("* Ingrese el numero inicial de comprobante", True)
            Return
        End If
        If Me.cbxCOMPROB_NUMERACION1.SelectedValue Is Nothing Then
            MsgBox("* Seleccione la serie del documento", True)
            Return
        End If
        If Not Utilerias.EsNumeroEntero(txtNO_DOCUMENTO.Text) Then
            MsgBox("* El numero de comprobante debe ser un numero entero", True)
            Return
        End If
        If dteFechaComprobante.Text = "" Then
            MsgBox("* Ingrese la fecha de emisión de los comprobantes", True)
            Return
        End If
        lstPlanilla = bPlanilla.ObtenerListaPorCRITERIOS(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, "", "")
        If lstPlanilla IsNot Nothing AndAlso lstPlanilla.Count > 0 Then

            lPlanillaBase = (New cPLANILLA_BASE).ObtenerPLANILLA_BASE(lstPlanilla(0).ID_PLANILLA_BASE)
            If lPlanillaBase IsNot Nothing AndAlso lPlanillaBase.FECHA_PAGO = #12:00:00 AM# Then
                MsgBox("* Debe registrar la fecha de pago de la planilla", True)
                Return
            End If

            idComprobConce = Me.cbxTipoDocumento.SelectedIndex + 1
            Select Case idComprobConce
                Case 1  '  COMPROBANTE DE RETENCION 1% IVA
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, 1, 1, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
                Case 2  '  COMPROBANTE DE RETENCION - NO CONTRIBUYENTES
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, 2, 0, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
                Case 3  '  CREDITO FISCAL SERVICIOS DEL INGENIO
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, -1, 1, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
                Case 4  '  FACTURA POR SERVICIOS DEL INGENIO
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, -1, 0, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
                Case 5  '  FACTURA DE SUJETO EXCLUIDO
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, -1, 0, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
                Case 6  '  CREDITO FISCAL (FRENTE CALIDAD AT / SDV)
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, -1, 1, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
                Case 7  '  FACTURA (FRENTE CALIDAD AT / SDV)
                    sResult = bPlanilla.PROC_GenerarCOMPROBANTES(lstPlanilla(0).ID_PLANILLA_BASE, Me.cbxCOMPROB_NUMERACION1.SelectedValue, Me.txtNO_DOCUMENTO.Text, -1, 0, configuracion.usuarioActualiza, idComprobConce, dteFechaComprobante.DateTime)
            End Select

            If sResult <> "" Then
                MsgBox("* " + sResult, MsgBoxStyle.Critical, "Notificación")
                Return
            End If
        End If
        Me.UltimoNumeroSerie()
        MsgBox("¡Se ha realizado la emisión de los comprobantes seleccionados!" + sResult, MsgBoxStyle.Information, "Notificación")
    End Sub

    Private Sub cbxTipoDocumento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxTipoDocumento.SelectedIndexChanged
        chkFacturaContinua.Visible = Me.cbxTipoDocumento.SelectedIndex = 3
        Me.cbxCOMPROB_NUMERACION1.RecuperarPorTIPO_DOCUMENTO(Me.ObtenerID_TIPO_COMPROB(Me.cbxTipoDocumento.SelectedIndex))
    End Sub

    Private Sub ConfigRangoCompensacion()
        If CInt(CbxTIPO_PLANILLA1.SelectedValue) = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
            If Me.CbxCATORCENA_ZAFRA1.SelectedValue IsNot Nothing Then
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
            Else
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(-1)
            End If
            Me.lblRangoCompensacion.Visible = True
            Me.cbxRANGO_COMPENSACION1.Visible = True
        Else
            Me.lblRangoCompensacion.Visible = False
            Me.cbxRANGO_COMPENSACION1.Visible = False
        End If
        Me.AsignarFechaComprobantesSugerida()
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub CbxTIPO_PLANILLA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxTIPO_PLANILLA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub cbxCOMPROB_NUMERACION1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCOMPROB_NUMERACION1.SelectedIndexChanged
        Me.UltimoNumeroSerie()
    End Sub

    Private Sub UltimoNumeroSerie()
        Dim bPlanillaComprob As New cPLANILLA_COMPROB
        Dim iUltNumero As Integer = 0

        iUltNumero = bPlanillaComprob.fObtenerUltimoNumeroSerie(cbxCOMPROB_NUMERACION1.SelectedValue)
        If iUltNumero > -1 Then
            Me.txtNO_DOCUMENTO.Text = CStr(iUltNumero + 1)
        End If
    End Sub
End Class