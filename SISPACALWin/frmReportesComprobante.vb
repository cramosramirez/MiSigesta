Public Class frmReportesComprobante

    Private Sub frmReportesComprobante_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmReportesComprobante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Me.rbtTodos.Checked = True
        Me.spNO_DOCTOini.Enabled = False
        Me.spNO_DOCTOfin.Enabled = False
        Me.spNO_DOCTOini.Text = ""
        Me.spNO_DOCTOfin.Text = ""
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
        Dim iNoDoctoIni As Integer = -1
        Dim iNoDoctoFin As Integer = -1
        Dim idComprobConce As Integer = -1

        If Me.rbtRango.Checked Then
            iNoDoctoIni = IIf(Me.spNO_DOCTOini.Value = Nothing, 0, Me.spNO_DOCTOini.Value)
            iNoDoctoFin = IIf(Me.spNO_DOCTOfin.Value = Nothing, 0, Me.spNO_DOCTOfin.Value)
        End If

        idComprobConce = Me.cbxTipoDocumento.SelectedIndex + 1

        frmImpresiones.CargarComprobante(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, Me.cbxTipoDocumento.SelectedIndex + 1, idComprobConce, iNoDoctoIni, iNoDoctoFin, chkFacturaContinua.Checked, Me.cbxRANGO_COMPENSACION1.SelectedValue)
        frmImpresiones.ShowDialog()
    End Sub

    Private Sub cbxTipoDocumento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxTipoDocumento.SelectedIndexChanged
        chkFacturaContinua.Visible = Me.cbxTipoDocumento.SelectedIndex = 3
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
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub CbxTIPO_PLANILLA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxTIPO_PLANILLA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub btnListadoComprobantes_Click(sender As Object, e As EventArgs) Handles btnListadoComprobantes.Click
        Dim f As frmReporteDevExpress
        Dim tipoDocumento As Integer = Me.cbxTipoDocumento.SelectedIndex + 1
        Dim iNoDoctoIni As Integer = -1
        Dim iNoDoctoFin As Integer = -1
        Dim idComprobConce As Integer = cbxTipoDocumento.SelectedIndex + 1

        If Me.rbtRango.Checked Then
            iNoDoctoIni = IIf(Me.spNO_DOCTOini.Value = Nothing, 0, Me.spNO_DOCTOini.Value)
            iNoDoctoFin = IIf(Me.spNO_DOCTOfin.Value = Nothing, 0, Me.spNO_DOCTOfin.Value)
        End If

        f = New frmReporteDevExpress(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedIndex + 1, tipoDocumento, idComprobConce, iNoDoctoIni, iNoDoctoFin)
        f.ShowDialog()
    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged, rbtRango.CheckedChanged
        Me.spNO_DOCTOini.Enabled = Me.rbtRango.Checked
        Me.spNO_DOCTOfin.Enabled = Me.rbtRango.Checked
        Me.spNO_DOCTOini.Text = ""
        Me.spNO_DOCTOfin.Text = ""
    End Sub
End Class