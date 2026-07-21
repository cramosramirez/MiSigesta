<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ResultadoAnalisisMuestras
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrZAFRA = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.DS_SIGESTA1 = New SISPACAL.DL.DS_SIGESTA()
        Me.ResultadoS_ANALISIS_PRECOSECHATableAdapter1 = New SISPACAL.DL.DS_SIGESTATableAdapters.RESULTADOS_ANALISIS_PRECOSECHATableAdapter()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.xrZONA = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_SIGESTA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("FECHA_LEE_POL", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("NO_ANALISIS", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrTable1
        '
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(16.99997!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1014.0!, 25.0!)
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.XrTableCell8, Me.XrTableCell11, Me.XrTableCell6, Me.XrTableCell10, Me.XrTableCell7, Me.XrTableCell14, Me.XrTableCell1, Me.XrTableCell15, Me.XrTableCell2, Me.XrTableCell9, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell13, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.FECHA_LEE_POL", "{0:dd/MM/yy HH:mm}")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell12.Weight = 1.2400004577636719R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.NO_ANALISIS", "{0}")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 0.56291633605957025R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.POL", "{0:#,##0.00}")})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Weight = 0.60708343505859363R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.BRIX", "{0:#,##0.00}")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Weight = 0.50000000000000011R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.BAGAZO_NETO", "{0:#,##0.00}")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Weight = 0.58000030517578127R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.FIBRA_CANA", "{0:0.000000}")})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Weight = 0.6458331298828125R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.JUGO_CANA", "{0:0.000000}")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Weight = 0.8541674804687498R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.POL_CANA", "{0:#.000000}")})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Weight = 0.75000007629394538R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.PUREZA_JUGO", "{0:0.000000}")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Weight = 0.74999938964843749R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.PUREZA_AZUCAR", "{0:0.00}")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Weight = 0.59R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.SJM", "{0:0.000000}")})
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Weight = 0.689583740234375R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.PH", "{0:0.00}")})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Weight = 0.55R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.RENDIA_CALC2", "{0:0.00}")})
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Visible = False
        Me.XrTableCell5.Weight = 0.25041687011718761R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RESULTADOS_ANALISIS_PRECOSECHA.DEXTRANA", "{0:0.00}")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Weight = 0.789998779296875R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Weight = 0.78R
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "V_LABORA_PAGO_CALIDAD01", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT * FROM V_LABORA_PAGO_CALIDAD01"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DS_DS1"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrZONA, Me.XrLabel4, Me.XrPageInfo2, Me.XrPageInfo1, Me.Text1, Me.Text2, Me.Text3, Me.xrZAFRA, Me.Line1, Me.Line2, Me.Text5, Me.Text6, Me.Text7, Me.Text8, Me.Text9, Me.Text10, Me.Text11, Me.Text12, Me.Text13, Me.Text14, Me.Text15, Me.Text17, Me.Text18, Me.Text23, Me.Text26})
        Me.PageHeader.HeightF = 121.875!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(940.7082!, 10.00001!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(32.29169!, 19.875!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Pág."
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(972.9998!, 10.00001!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(50.48956!, 19.875!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yy HH:mm}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 10.00001!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(114.5833!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.White
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.CanGrow = False
        Me.Text1.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(141.0!, 8.0!)
        Me.Text1.Name = "Text1"
        Me.Text1.SizeF = New System.Drawing.SizeF(733.0!, 15.0!)
        Me.Text1.Text = "INGENIO CENTRAL AZUCARERO JIBOA S.A. DE C.V."
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text2
        '
        Me.Text2.BackColor = System.Drawing.Color.White
        Me.Text2.BorderColor = System.Drawing.Color.Black
        Me.Text2.CanGrow = False
        Me.Text2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Text2.ForeColor = System.Drawing.Color.Black
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(141.0!, 32.58332!)
        Me.Text2.Name = "Text2"
        Me.Text2.SizeF = New System.Drawing.SizeF(733.0!, 15.0!)
        Me.Text2.Text = "REPORTE ANALISIS EN MUESTRAS DE PRECOSECHA"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.White
        Me.Text3.BorderColor = System.Drawing.Color.Black
        Me.Text3.CanGrow = False
        Me.Text3.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 47.58332!)
        Me.Text3.Name = "Text3"
        Me.Text3.SizeF = New System.Drawing.SizeF(50.0!, 21.41667!)
        Me.Text3.Text = "ZAFRA:"
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrZAFRA
        '
        Me.xrZAFRA.BackColor = System.Drawing.Color.White
        Me.xrZAFRA.BorderColor = System.Drawing.Color.Black
        Me.xrZAFRA.CanGrow = False
        Me.xrZAFRA.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.xrZAFRA.ForeColor = System.Drawing.Color.Black
        Me.xrZAFRA.LocationFloat = New DevExpress.Utils.PointFloat(67.00001!, 47.58332!)
        Me.xrZAFRA.Name = "xrZAFRA"
        Me.xrZAFRA.SizeF = New System.Drawing.SizeF(111.5416!, 21.41667!)
        Me.xrZAFRA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.White
        Me.Line1.BorderColor = System.Drawing.Color.Black
        Me.Line1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line1.ForeColor = System.Drawing.Color.Black
        Me.Line1.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 78.91666!)
        Me.Line1.Name = "Line1"
        Me.Line1.SizeF = New System.Drawing.SizeF(1014.0!, 4.083328!)
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.White
        Me.Line2.BorderColor = System.Drawing.Color.Black
        Me.Line2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line2.ForeColor = System.Drawing.Color.Black
        Me.Line2.LocationFloat = New DevExpress.Utils.PointFloat(16.0!, 118.25!)
        Me.Line2.Name = "Line2"
        Me.Line2.SizeF = New System.Drawing.SizeF(1015.0!, 3.624977!)
        '
        'Text5
        '
        Me.Text5.BackColor = System.Drawing.Color.White
        Me.Text5.BorderColor = System.Drawing.Color.Black
        Me.Text5.CanGrow = False
        Me.Text5.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text5.ForeColor = System.Drawing.Color.Black
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(16.0!, 90.99998!)
        Me.Text5.Name = "Text5"
        Me.Text5.SizeF = New System.Drawing.SizeF(125.0!, 17.00001!)
        Me.Text5.Text = "Fecha Lectura" & Global.Microsoft.VisualBasic.ChrW(10) & " Pol"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text6
        '
        Me.Text6.BackColor = System.Drawing.Color.White
        Me.Text6.BorderColor = System.Drawing.Color.Black
        Me.Text6.CanGrow = False
        Me.Text6.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text6.ForeColor = System.Drawing.Color.Black
        Me.Text6.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 91.0!)
        Me.Text6.Name = "Text6"
        Me.Text6.SizeF = New System.Drawing.SizeF(50.0!, 11.0!)
        Me.Text6.Text = "Taco"
        Me.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text7
        '
        Me.Text7.BackColor = System.Drawing.Color.White
        Me.Text7.BorderColor = System.Drawing.Color.Black
        Me.Text7.CanGrow = False
        Me.Text7.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text7.ForeColor = System.Drawing.Color.Black
        Me.Text7.LocationFloat = New DevExpress.Utils.PointFloat(208.0!, 91.0!)
        Me.Text7.Name = "Text7"
        Me.Text7.SizeF = New System.Drawing.SizeF(41.0!, 11.0!)
        Me.Text7.Text = "Pol"
        Me.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text8
        '
        Me.Text8.BackColor = System.Drawing.Color.White
        Me.Text8.BorderColor = System.Drawing.Color.Black
        Me.Text8.CanGrow = False
        Me.Text8.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text8.ForeColor = System.Drawing.Color.Black
        Me.Text8.LocationFloat = New DevExpress.Utils.PointFloat(258.0!, 91.0!)
        Me.Text8.Name = "Text8"
        Me.Text8.SizeF = New System.Drawing.SizeF(42.0!, 11.0!)
        Me.Text8.Text = "% Brix"
        Me.Text8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.White
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.CanGrow = False
        Me.Text9.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(308.0!, 91.0!)
        Me.Text9.Name = "Text9"
        Me.Text9.SizeF = New System.Drawing.SizeF(50.0!, 11.0!)
        Me.Text9.Text = "PBH"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.White
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.CanGrow = False
        Me.Text10.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(366.0!, 84.99998!)
        Me.Text10.Name = "Text10"
        Me.Text10.SizeF = New System.Drawing.SizeF(66.0!, 31.33337!)
        Me.Text10.Text = "Fibra caña"
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text11
        '
        Me.Text11.BackColor = System.Drawing.Color.White
        Me.Text11.BorderColor = System.Drawing.Color.Black
        Me.Text11.CanGrow = False
        Me.Text11.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text11.ForeColor = System.Drawing.Color.Black
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(441.0!, 84.99998!)
        Me.Text11.Name = "Text11"
        Me.Text11.SizeF = New System.Drawing.SizeF(65.99997!, 31.33335!)
        Me.Text11.Text = "Jugo Abs% Caña"
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text12
        '
        Me.Text12.BackColor = System.Drawing.Color.White
        Me.Text12.BorderColor = System.Drawing.Color.Black
        Me.Text12.CanGrow = False
        Me.Text12.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text12.ForeColor = System.Drawing.Color.Black
        Me.Text12.LocationFloat = New DevExpress.Utils.PointFloat(516.0!, 85.87501!)
        Me.Text12.Multiline = True
        Me.Text12.Name = "Text12"
        Me.Text12.SizeF = New System.Drawing.SizeF(66.0!, 32.37502!)
        Me.Text12.Text = "pol % " & Global.Microsoft.VisualBasic.ChrW(10) & "caña"
        Me.Text12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text13
        '
        Me.Text13.BackColor = System.Drawing.Color.White
        Me.Text13.BorderColor = System.Drawing.Color.Black
        Me.Text13.CanGrow = False
        Me.Text13.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text13.ForeColor = System.Drawing.Color.Black
        Me.Text13.LocationFloat = New DevExpress.Utils.PointFloat(591.0!, 82.99999!)
        Me.Text13.Multiline = True
        Me.Text13.Name = "Text13"
        Me.Text13.SizeF = New System.Drawing.SizeF(75.0!, 33.33334!)
        Me.Text13.Text = "pureza " & Global.Microsoft.VisualBasic.ChrW(10) & "jugo"
        Me.Text13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text14
        '
        Me.Text14.BackColor = System.Drawing.Color.White
        Me.Text14.BorderColor = System.Drawing.Color.Black
        Me.Text14.CanGrow = False
        Me.Text14.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text14.ForeColor = System.Drawing.Color.Black
        Me.Text14.LocationFloat = New DevExpress.Utils.PointFloat(666.0!, 82.99999!)
        Me.Text14.Multiline = True
        Me.Text14.Name = "Text14"
        Me.Text14.SizeF = New System.Drawing.SizeF(58.0!, 33.04169!)
        Me.Text14.Text = "pureza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "azúcar"
        Me.Text14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text15
        '
        Me.Text15.BackColor = System.Drawing.Color.White
        Me.Text15.BorderColor = System.Drawing.Color.Black
        Me.Text15.CanGrow = False
        Me.Text15.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text15.ForeColor = System.Drawing.Color.Black
        Me.Text15.LocationFloat = New DevExpress.Utils.PointFloat(743.9584!, 91.0!)
        Me.Text15.Name = "Text15"
        Me.Text15.SizeF = New System.Drawing.SizeF(50.0!, 16.0!)
        Me.Text15.Text = "sjm"
        Me.Text15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text17
        '
        Me.Text17.BackColor = System.Drawing.Color.White
        Me.Text17.BorderColor = System.Drawing.Color.Black
        Me.Text17.CanGrow = False
        Me.Text17.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text17.ForeColor = System.Drawing.Color.Black
        Me.Text17.LocationFloat = New DevExpress.Utils.PointFloat(862.0!, 82.99999!)
        Me.Text17.Multiline = True
        Me.Text17.Name = "Text17"
        Me.Text17.SizeF = New System.Drawing.SizeF(12.00006!, 33.33334!)
        Me.Text17.Text = "rend." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "85%"
        Me.Text17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Text17.Visible = False
        '
        'Text18
        '
        Me.Text18.BackColor = System.Drawing.Color.White
        Me.Text18.BorderColor = System.Drawing.Color.Black
        Me.Text18.CanGrow = False
        Me.Text18.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text18.ForeColor = System.Drawing.Color.Black
        Me.Text18.LocationFloat = New DevExpress.Utils.PointFloat(807.5!, 90.99998!)
        Me.Text18.Name = "Text18"
        Me.Text18.SizeF = New System.Drawing.SizeF(33.0!, 16.0!)
        Me.Text18.Text = "PH"
        Me.Text18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text23
        '
        Me.Text23.BackColor = System.Drawing.Color.White
        Me.Text23.BorderColor = System.Drawing.Color.Black
        Me.Text23.CanGrow = False
        Me.Text23.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text23.ForeColor = System.Drawing.Color.Black
        Me.Text23.LocationFloat = New DevExpress.Utils.PointFloat(895.0!, 91.0!)
        Me.Text23.Name = "Text23"
        Me.Text23.SizeF = New System.Drawing.SizeF(58.0!, 16.0!)
        Me.Text23.Text = "Dextrana"
        Me.Text23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text26
        '
        Me.Text26.BackColor = System.Drawing.Color.White
        Me.Text26.BorderColor = System.Drawing.Color.Black
        Me.Text26.CanGrow = False
        Me.Text26.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Text26.ForeColor = System.Drawing.Color.Black
        Me.Text26.LocationFloat = New DevExpress.Utils.PointFloat(972.9999!, 82.99999!)
        Me.Text26.Multiline = True
        Me.Text26.Name = "Text26"
        Me.Text26.SizeF = New System.Drawing.SizeF(58.0!, 33.33334!)
        Me.Text26.Text = "Horas" & Global.Microsoft.VisualBasic.ChrW(10) & "quema"
        Me.Text26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 26.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 22.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'DS_SIGESTA1
        '
        Me.DS_SIGESTA1.DataSetName = "DS_SIGESTA"
        Me.DS_SIGESTA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResultadoS_ANALISIS_PRECOSECHATableAdapter1
        '
        Me.ResultadoS_ANALISIS_PRECOSECHATableAdapter1.ClearBeforeFill = True
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 33.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 25.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'xrZONA
        '
        Me.xrZONA.BackColor = System.Drawing.Color.White
        Me.xrZONA.BorderColor = System.Drawing.Color.Black
        Me.xrZONA.CanGrow = False
        Me.xrZONA.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.xrZONA.ForeColor = System.Drawing.Color.Black
        Me.xrZONA.LocationFloat = New DevExpress.Utils.PointFloat(246.4584!, 47.58332!)
        Me.xrZONA.Name = "xrZONA"
        Me.xrZONA.SizeF = New System.Drawing.SizeF(143.8333!, 21.41667!)
        Me.xrZONA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ResultadoAnalisisMuestras
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataAdapter = Me.ResultadoS_ANALISIS_PRECOSECHATableAdapter1
        Me.DataMember = "RESULTADOS_ANALISIS_PRECOSECHA"
        Me.DataSource = Me.DS_SIGESTA1
        Me.Margins = New System.Drawing.Printing.Margins(25, 33, 33, 25)
        Me.PageHeight = 849
        Me.PageWidth = 1099
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_SIGESTA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrZAFRA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DS_SIGESTA1 As SISPACAL.DL.DS_SIGESTA
    Friend WithEvents ResultadoS_ANALISIS_PRECOSECHATableAdapter1 As SISPACAL.DL.DS_SIGESTATableAdapters.RESULTADOS_ANALISIS_PRECOSECHATableAdapter
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xrZONA As DevExpress.XtraReports.UI.XRLabel
End Class
