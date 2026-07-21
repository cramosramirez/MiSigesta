<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBASCULA = New System.Windows.Forms.ToolStripButton()
        Me.tsbPESO_MUESTRA = New System.Windows.Forms.ToolStripButton()
        Me.tsbPOL_BRIX = New System.Windows.Forms.ToolStripButton()
        Me.tsbDEXTRANA = New System.Windows.Forms.ToolStripButton()
        Me.tsbMATERIA_EXTRA = New System.Windows.Forms.ToolStripButton()
        Me.tsdbProcesos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReportesDePlanillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarPlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChequesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarArchivosParaPHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarArchivoParaCONSAAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsdbReportes = New System.Windows.Forms.ToolStripSplitButton()
        Me.OrdenDeCombustibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaDeCañaBasculaCorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaDeCañaBasculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCERRAR_SESION = New System.Windows.Forms.ToolStripButton()
        Me.tsbSALIR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBASCULA, Me.tsbPESO_MUESTRA, Me.tsbPOL_BRIX, Me.tsbDEXTRANA, Me.tsbMATERIA_EXTRA, Me.tsdbProcesos, Me.tsdbReportes, Me.ToolStripSeparator1, Me.tsbCERRAR_SESION, Me.tsbSALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.MinimumSize = New System.Drawing.Size(0, 75)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(994, 75)
        Me.ToolStrip1.TabIndex = 3
        '
        'tsbBASCULA
        '
        Me.tsbBASCULA.Image = Global.SISPACAL.My.Resources.Resources.DAF_Tipper_Container_Truck
        Me.tsbBASCULA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbBASCULA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBASCULA.Name = "tsbBASCULA"
        Me.tsbBASCULA.Size = New System.Drawing.Size(62, 72)
        Me.tsbBASCULA.Text = "BASCULA"
        Me.tsbBASCULA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPESO_MUESTRA
        '
        Me.tsbPESO_MUESTRA.Image = Global.SISPACAL.My.Resources.Resources.balanzaOhausIco
        Me.tsbPESO_MUESTRA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPESO_MUESTRA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPESO_MUESTRA.Name = "tsbPESO_MUESTRA"
        Me.tsbPESO_MUESTRA.Size = New System.Drawing.Size(95, 72)
        Me.tsbPESO_MUESTRA.Text = "PESO MUESTRA"
        Me.tsbPESO_MUESTRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPOL_BRIX
        '
        Me.tsbPOL_BRIX.Image = Global.SISPACAL.My.Resources.Resources.Measurement
        Me.tsbPOL_BRIX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPOL_BRIX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPOL_BRIX.Name = "tsbPOL_BRIX"
        Me.tsbPOL_BRIX.Size = New System.Drawing.Size(68, 72)
        Me.tsbPOL_BRIX.Text = "POL / BRIX"
        Me.tsbPOL_BRIX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDEXTRANA
        '
        Me.tsbDEXTRANA.Image = Global.SISPACAL.My.Resources.Resources._1381525307_applications_science
        Me.tsbDEXTRANA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDEXTRANA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDEXTRANA.Name = "tsbDEXTRANA"
        Me.tsbDEXTRANA.Size = New System.Drawing.Size(71, 72)
        Me.tsbDEXTRANA.Text = "DEXTRANA"
        Me.tsbDEXTRANA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbMATERIA_EXTRA
        '
        Me.tsbMATERIA_EXTRA.Image = Global.SISPACAL.My.Resources.Resources.matextrana
        Me.tsbMATERIA_EXTRA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbMATERIA_EXTRA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMATERIA_EXTRA.Name = "tsbMATERIA_EXTRA"
        Me.tsbMATERIA_EXTRA.Size = New System.Drawing.Size(116, 72)
        Me.tsbMATERIA_EXTRA.Text = "MATERIA EXTRAÑA"
        Me.tsbMATERIA_EXTRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsdbProcesos
        '
        Me.tsdbProcesos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesDePlanillaToolStripMenuItem, Me.GenerarPlantillaToolStripMenuItem, Me.CargarPlantillaToolStripMenuItem, Me.ComprobantesToolStripMenuItem, Me.ChequesToolStripMenuItem, Me.GenerarArchivosParaPHToolStripMenuItem, Me.GenerarArchivoParaCONSAAToolStripMenuItem})
        Me.tsdbProcesos.Image = Global.SISPACAL.My.Resources.Resources.Report
        Me.tsdbProcesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsdbProcesos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdbProcesos.Name = "tsdbProcesos"
        Me.tsdbProcesos.Size = New System.Drawing.Size(126, 72)
        Me.tsdbProcesos.Text = "PROCESOS"
        '
        'ReportesDePlanillaToolStripMenuItem
        '
        Me.ReportesDePlanillaToolStripMenuItem.Name = "ReportesDePlanillaToolStripMenuItem"
        Me.ReportesDePlanillaToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReportesDePlanillaToolStripMenuItem.Text = "Reportes de Planilla"
        '
        'GenerarPlantillaToolStripMenuItem
        '
        Me.GenerarPlantillaToolStripMenuItem.Name = "GenerarPlantillaToolStripMenuItem"
        Me.GenerarPlantillaToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.GenerarPlantillaToolStripMenuItem.Text = "Generar Plantilla de descuentos"
        '
        'CargarPlantillaToolStripMenuItem
        '
        Me.CargarPlantillaToolStripMenuItem.Name = "CargarPlantillaToolStripMenuItem"
        Me.CargarPlantillaToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.CargarPlantillaToolStripMenuItem.Text = "Cargar Plantilla de descuentos"
        '
        'ComprobantesToolStripMenuItem
        '
        Me.ComprobantesToolStripMenuItem.Name = "ComprobantesToolStripMenuItem"
        Me.ComprobantesToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ComprobantesToolStripMenuItem.Text = "Impresión de Comprobantes"
        '
        'ChequesToolStripMenuItem
        '
        Me.ChequesToolStripMenuItem.Name = "ChequesToolStripMenuItem"
        Me.ChequesToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ChequesToolStripMenuItem.Text = "Impresión de Cheques"
        '
        'GenerarArchivosParaPHToolStripMenuItem
        '
        Me.GenerarArchivosParaPHToolStripMenuItem.Name = "GenerarArchivosParaPHToolStripMenuItem"
        Me.GenerarArchivosParaPHToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.GenerarArchivosParaPHToolStripMenuItem.Text = "Generar archivos para PH"
        '
        'GenerarArchivoParaCONSAAToolStripMenuItem
        '
        Me.GenerarArchivoParaCONSAAToolStripMenuItem.Name = "GenerarArchivoParaCONSAAToolStripMenuItem"
        Me.GenerarArchivoParaCONSAAToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.GenerarArchivoParaCONSAAToolStripMenuItem.Text = "Generar archivo entrega de Caña"
        '
        'tsdbReportes
        '
        Me.tsdbReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenDeCombustibleToolStripMenuItem, Me.EntregaDeCañaBasculaCorteToolStripMenuItem, Me.EntregaDeCañaBasculaToolStripMenuItem})
        Me.tsdbReportes.Image = Global.SISPACAL.My.Resources.Resources.documento1
        Me.tsdbReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsdbReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdbReportes.Name = "tsdbReportes"
        Me.tsdbReportes.Size = New System.Drawing.Size(108, 72)
        Me.tsdbReportes.Text = "REPORTES"
        '
        'OrdenDeCombustibleToolStripMenuItem
        '
        Me.OrdenDeCombustibleToolStripMenuItem.Name = "OrdenDeCombustibleToolStripMenuItem"
        Me.OrdenDeCombustibleToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.OrdenDeCombustibleToolStripMenuItem.Text = "Orden de Combustible"
        '
        'EntregaDeCañaBasculaCorteToolStripMenuItem
        '
        Me.EntregaDeCañaBasculaCorteToolStripMenuItem.Name = "EntregaDeCañaBasculaCorteToolStripMenuItem"
        Me.EntregaDeCañaBasculaCorteToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.EntregaDeCañaBasculaCorteToolStripMenuItem.Text = "Entrega de Caña Bascula - Corte"
        '
        'EntregaDeCañaBasculaToolStripMenuItem
        '
        Me.EntregaDeCañaBasculaToolStripMenuItem.Name = "EntregaDeCañaBasculaToolStripMenuItem"
        Me.EntregaDeCañaBasculaToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.EntregaDeCañaBasculaToolStripMenuItem.Text = "Entrega de Caña Bascula"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 75)
        '
        'tsbCERRAR_SESION
        '
        Me.tsbCERRAR_SESION.Image = Global.SISPACAL.My.Resources.Resources.login
        Me.tsbCERRAR_SESION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCERRAR_SESION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCERRAR_SESION.Name = "tsbCERRAR_SESION"
        Me.tsbCERRAR_SESION.Size = New System.Drawing.Size(96, 72)
        Me.tsbCERRAR_SESION.Text = "CERRAR SESIÓN"
        Me.tsbCERRAR_SESION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbSALIR
        '
        Me.tsbSALIR.Image = Global.SISPACAL.My.Resources.Resources._1381527116_Log_Out
        Me.tsbSALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSALIR.Name = "tsbSALIR"
        Me.tsbSALIR.Size = New System.Drawing.Size(52, 72)
        Me.tsbSALIR.Text = "SALIR"
        Me.tsbSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(994, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Sistema Pago por Calidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBASCULA As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPESO_MUESTRA As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPOL_BRIX As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDEXTRANA As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMATERIA_EXTRA As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCERRAR_SESION As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsdbProcesos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ComprobantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarPlantillaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChequesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPlantillaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarArchivosParaPHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesDePlanillaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsdbReportes As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents OrdenDeCombustibleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntregaDeCañaBasculaCorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntregaDeCañaBasculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarArchivoParaCONSAAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
