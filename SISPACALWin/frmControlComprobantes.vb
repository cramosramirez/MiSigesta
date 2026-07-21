Imports DevExpress.XtraGrid.Views.Base

Public Class frmControlComprobantes

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

    Private Sub CargarComprobantes()
        Dim idTipoDocto As Integer = 0
        Dim tipoContrib As Integer = -1
        Dim idComprobConce As Integer = -1

        idComprobConce = Me.cbxTipoDocumento.SelectedIndex + 1
        Select Case Me.cbxTipoDocumento.SelectedIndex
            Case 0  '  COMPROBANTE DE RETENCION 1% IVA
                idTipoDocto = 9
                tipoContrib = 1
            Case 1  '  COMPROBANTE DE RETENCION - NO CONTRIBUYENTES
                idTipoDocto = 9
                tipoContrib = 0
            Case 2  '  CREDITO FISCAL SERVICIOS DEL INGENIO
                idTipoDocto = 1
                tipoContrib = 1
            Case 3  '  FACTURA POR SERVICIOS DEL INGENIO
                idTipoDocto = 2
                tipoContrib = 0
            Case 4  '  FACTURA DE SUJETO EXCLUIDO
                idTipoDocto = 10
                tipoContrib = 0
            Case 5  '  CREDITO FISCAL (FRENTE CALIDAD AT / SDV)
                idTipoDocto = 1
                tipoContrib = 1
            Case 6  '  FACTURA (FRENTE CALIDAD AT / SDV)
                idTipoDocto = 2
                tipoContrib = 0
        End Select

        Me.DS_COMPROBANTES1.Clear()
        Me.LISTADO_COMPROBANTESTableAdapter1.FillPorCriterios(Me.DS_COMPROBANTES1.LISTADO_COMPROBANTES, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, idTipoDocto, idComprobConce, tipoContrib)
        Me.GridView1.ClearSelection()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.CargarComprobantes()
    End Sub

    Private Sub btnAnularComprobantes_Click(sender As Object, e As EventArgs) Handles btnAnularComprobantes.Click
        If Me.GridView1.SelectedRowsCount > 0 Then
            If MessageBox.Show("¿Está segur(o)(a) de anular los comprobantes seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.AnularComprobantes()
                Me.CargarComprobantes()
                MessageBox.Show("Los comprobantes han sido anulados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub AnularComprobantes()
        Dim filasSelec() As Integer
        Dim vista As ColumnView = CType(GridControl1.MainView, ColumnView)
        Dim bComprob As New cPLANILLA_COMPROB
        Dim lComprob As PLANILLA_COMPROB

        If vista IsNot Nothing Then
            filasSelec = vista.GetSelectedRows
            For i As Integer = 0 To filasSelec.Length - 1
                Dim rowHandle As Integer = filasSelec(i)
                Dim idPlaComprob As Integer = 0

                idPlaComprob = vista.GetRowCellValue(rowHandle, "ID_PLANILLA_COMPROB")
                lComprob = (New cPLANILLA_COMPROB).ObtenerPLANILLA_COMPROB(idPlaComprob)

                If lComprob IsNot Nothing AndAlso lComprob.ESTADO = "E" Then
                    lComprob.ESTADO = "A"
                    lComprob.USUARIO_ACT = configuracion.usuarioActualiza
                    lComprob.FECHA_ACT = Now
                    bComprob.ActualizarPLANILLA_COMPROB(lComprob)
                End If
            Next
        End If

    End Sub

  
    Private Sub btnGenerarNuevoComprobante_Click(sender As Object, e As EventArgs) Handles btnGenerarNuevoComprobante.Click

    End Sub
End Class