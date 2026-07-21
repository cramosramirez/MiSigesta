Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports SISPACAL.RL

Public Class frmReportesPrecosecha
    Private _tipoReporte As Int32

    Public Sub New(ByVal tipoReporte As Int32)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _tipoReporte = tipoReporte
    End Sub

    Private Sub CargarZafras()
        Dim listaZafras As listaZAFRA = (New cZAFRA).ObtenerLista(False, "NOMBRE_ZAFRA", "ASC")
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        Me.cbxPreCosecha.ValueMember = "ID_ZAFRA"
        Me.cbxPreCosecha.DisplayMember = "NOMBRE_ZAFRA"
        Me.cbxPreCosecha.DataSource = listaZafras
        If lZafraActiva IsNot Nothing Then Me.cbxPreCosecha.SelectedValue = lZafraActiva.ID_ZAFRA
    End Sub

    Private Sub btnVerReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnVerReporte.Click
        Dim tool As ReportPrintTool

        If _tipoReporte = 1 Then
            Dim reporte As New ResultadoAnalisisPreCosecha
            If IsNothing(Me.cbxPreCosecha.SelectedValue) Then
                MsgBox("Seleccione la precosecha", MsgBoxStyle.Critical, "Validación")
                Return
            End If
            reporte.CargarDatos(Me.cbxPreCosecha.SelectedValue, Me.dteFechaHoraInicial.Value, Me.dteFechaHoraFinal.Value)
            tool = New ReportPrintTool(reporte)
        Else
            Dim reporte As New ResultadoAnalisisPreCosechaAlmidon
            If IsNothing(Me.cbxPreCosecha.SelectedValue) Then
                MsgBox("Seleccione la precosecha", MsgBoxStyle.Critical, "Validación")
                Return
            End If
            reporte.CargarDatos(Me.cbxPreCosecha.SelectedValue, Me.dteFechaHoraInicial.Value, Me.dteFechaHoraFinal.Value)
            tool = New ReportPrintTool(reporte)
        End If
        tool.ShowPreview()
    End Sub

    Private Sub frmReportesPrecosecha_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmReportesPrecosecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If _tipoReporte = 1 Then
            Me.Text = "Resultado de Análisis de Dextrana"
        Else
            Me.Text = "Resultado de Análisis de Almidón"
        End If
        Me.dteFechaHoraInicial.Value = Today
        Me.dteFechaHoraFinal.Value = Today
        Me.CargarZafras()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class