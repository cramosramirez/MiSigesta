<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InventarioRozaDiariaProveedor
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1 = New SISPACAL.DL.DS_SIGESTATableAdapters.INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter()
        Me.DS_SIGESTA1 = New SISPACAL.DL.DS_SIGESTA()
        Me.fieldZONA = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldCODIPROVEE = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldCODISOCIO = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldPROVEEDOR = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldCODILOTE = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldNOMBLOTE = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldCODIPROVEEDORROZA = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldTC = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.txtTITULO = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrZafra = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xlblSubtitulo = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DS_SIGESTA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 5.208333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 14.58333!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 34.375!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrPivotGrid1.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrPivotGrid1.DataAdapter = Me.INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1
        Me.XrPivotGrid1.DataMember = "INVENTARIO_ROZA_DIARIA_PROVEEDOR"
        Me.XrPivotGrid1.DataSource = Me.DS_SIGESTA1
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.fieldZONA, Me.fieldCODIPROVEE, Me.fieldCODISOCIO, Me.fieldPROVEEDOR, Me.fieldCODILOTE, Me.fieldNOMBLOTE, Me.fieldCODIPROVEEDORROZA, Me.fieldTC})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsDataField.RowValueLineCount = 3
        Me.XrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.XrPivotGrid1.OptionsView.ShowColumnGrandTotals = False
        Me.XrPivotGrid1.OptionsView.ShowDataHeaders = False
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(1061.0!, 152.0833!)
        '
        'INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1
        '
        Me.INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1.ClearBeforeFill = True
        '
        'DS_SIGESTA1
        '
        Me.DS_SIGESTA1.DataSetName = "DS_SIGESTA"
        Me.DS_SIGESTA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldZONA
        '
        Me.fieldZONA.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldZONA.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fieldZONA.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldZONA.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldZONA.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldZONA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldZONA.AreaIndex = 0
        Me.fieldZONA.Caption = "Zona"
        Me.fieldZONA.FieldName = "ZONA"
        Me.fieldZONA.Name = "fieldZONA"
        Me.fieldZONA.Width = 50
        '
        'fieldCODIPROVEE
        '
        Me.fieldCODIPROVEE.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldCODIPROVEE.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fieldCODIPROVEE.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldCODIPROVEE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCODIPROVEE.AreaIndex = 1
        Me.fieldCODIPROVEE.Caption = "Cod"
        Me.fieldCODIPROVEE.FieldName = "CODIPROVEE"
        Me.fieldCODIPROVEE.Name = "fieldCODIPROVEE"
        Me.fieldCODIPROVEE.Options.ShowTotals = False
        Me.fieldCODIPROVEE.Width = 50
        '
        'fieldCODISOCIO
        '
        Me.fieldCODISOCIO.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldCODISOCIO.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fieldCODISOCIO.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldCODISOCIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCODISOCIO.AreaIndex = 2
        Me.fieldCODISOCIO.Caption = "Socio"
        Me.fieldCODISOCIO.FieldName = "CODISOCIO"
        Me.fieldCODISOCIO.Name = "fieldCODISOCIO"
        Me.fieldCODISOCIO.Options.ShowTotals = False
        Me.fieldCODISOCIO.Width = 50
        '
        'fieldPROVEEDOR
        '
        Me.fieldPROVEEDOR.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldPROVEEDOR.Appearance.Cell.WordWrap = True
        Me.fieldPROVEEDOR.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fieldPROVEEDOR.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.fieldPROVEEDOR.Appearance.FieldValue.WordWrap = True
        Me.fieldPROVEEDOR.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPROVEEDOR.AreaIndex = 3
        Me.fieldPROVEEDOR.Caption = "Productor"
        Me.fieldPROVEEDOR.ColumnValueLineCount = 3
        Me.fieldPROVEEDOR.FieldName = "PROVEEDOR"
        Me.fieldPROVEEDOR.Name = "fieldPROVEEDOR"
        Me.fieldPROVEEDOR.Options.ShowTotals = False
        Me.fieldPROVEEDOR.Width = 150
        '
        'fieldCODILOTE
        '
        Me.fieldCODILOTE.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fieldCODILOTE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCODILOTE.AreaIndex = 4
        Me.fieldCODILOTE.Caption = "Cod"
        Me.fieldCODILOTE.FieldName = "CODILOTE"
        Me.fieldCODILOTE.Name = "fieldCODILOTE"
        Me.fieldCODILOTE.Options.ShowTotals = False
        Me.fieldCODILOTE.Width = 30
        '
        'fieldNOMBLOTE
        '
        Me.fieldNOMBLOTE.Appearance.Cell.WordWrap = True
        Me.fieldNOMBLOTE.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fieldNOMBLOTE.Appearance.FieldValue.WordWrap = True
        Me.fieldNOMBLOTE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBLOTE.AreaIndex = 5
        Me.fieldNOMBLOTE.Caption = "Lote"
        Me.fieldNOMBLOTE.ColumnValueLineCount = 2
        Me.fieldNOMBLOTE.FieldName = "NOMBLOTE"
        Me.fieldNOMBLOTE.Name = "fieldNOMBLOTE"
        Me.fieldNOMBLOTE.Options.ShowTotals = False
        '
        'fieldCODIPROVEEDORROZA
        '
        Me.fieldCODIPROVEEDORROZA.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldCODIPROVEEDORROZA.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldCODIPROVEEDORROZA.Appearance.Cell.WordWrap = True
        Me.fieldCODIPROVEEDORROZA.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldCODIPROVEEDORROZA.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldCODIPROVEEDORROZA.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldCODIPROVEEDORROZA.Appearance.FieldHeader.WordWrap = True
        Me.fieldCODIPROVEEDORROZA.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldCODIPROVEEDORROZA.Appearance.FieldValue.WordWrap = True
        Me.fieldCODIPROVEEDORROZA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCODIPROVEEDORROZA.AreaIndex = 0
        Me.fieldCODIPROVEEDORROZA.Caption = "Código de Frente de Roza"
        Me.fieldCODIPROVEEDORROZA.ColumnValueLineCount = 2
        Me.fieldCODIPROVEEDORROZA.FieldName = "CODI_PROVEEDOR_ROZA"
        Me.fieldCODIPROVEEDORROZA.Name = "fieldCODIPROVEEDORROZA"
        Me.fieldCODIPROVEEDORROZA.RowValueLineCount = 3
        Me.fieldCODIPROVEEDORROZA.Width = 48
        '
        'fieldTC
        '
        Me.fieldTC.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldTC.Appearance.Cell.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldTC.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldTC.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTC.AreaIndex = 0
        Me.fieldTC.CellFormat.FormatString = "#,##0.00"
        Me.fieldTC.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldTC.FieldName = "TC"
        Me.fieldTC.Name = "fieldTC"
        Me.fieldTC.RowValueLineCount = 3
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xlblSubtitulo, Me.XrLabel3, Me.XrPageInfo1, Me.txtTITULO, Me.xrZafra})
        Me.PageHeader.HeightF = 91.66663!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(17.74505!, 9.999959!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Fecha impresión"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yy HH:mm}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(117.7452!, 10.00001!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(95.83328!, 20.00001!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTITULO
        '
        Me.txtTITULO.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTITULO.LocationFloat = New DevExpress.Utils.PointFloat(230.3184!, 10.00001!)
        Me.txtTITULO.Name = "txtTITULO"
        Me.txtTITULO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTITULO.SizeF = New System.Drawing.SizeF(692.1032!, 25.79165!)
        Me.txtTITULO.StylePriority.UseFont = False
        Me.txtTITULO.StylePriority.UseTextAlignment = False
        Me.txtTITULO.Text = "ROZA DIARIA EJECUTADA POR FRENTE DE ROZA"
        Me.txtTITULO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrZafra
        '
        Me.xrZafra.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrZafra.LocationFloat = New DevExpress.Utils.PointFloat(230.3184!, 35.79163!)
        Me.xrZafra.Name = "xrZafra"
        Me.xrZafra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrZafra.SizeF = New System.Drawing.SizeF(692.1032!, 24.04167!)
        Me.xrZafra.StylePriority.UseFont = False
        Me.xrZafra.StylePriority.UseTextAlignment = False
        Me.xrZafra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1})
        Me.GroupHeader1.HeightF = 152.0833!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xlblSubtitulo
        '
        Me.xlblSubtitulo.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xlblSubtitulo.LocationFloat = New DevExpress.Utils.PointFloat(230.3184!, 60.83329!)
        Me.xlblSubtitulo.Name = "xlblSubtitulo"
        Me.xlblSubtitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblSubtitulo.SizeF = New System.Drawing.SizeF(692.1032!, 18.83334!)
        Me.xlblSubtitulo.StylePriority.UseFont = False
        Me.xlblSubtitulo.StylePriority.UseTextAlignment = False
        Me.xlblSubtitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'InventarioRozaDiariaProveedor
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1})
        Me.DataAdapter = Me.INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1
        Me.DataMember = "INVENTARIO_ROZA_DIARIA_PROVEEDOR"
        Me.DataSource = Me.DS_SIGESTA1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(18, 21, 15, 34)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "14.2"
        CType(Me.DS_SIGESTA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1 As SISPACAL.DL.DS_SIGESTATableAdapters.INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter
    Friend WithEvents DS_SIGESTA1 As SISPACAL.DL.DS_SIGESTA
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents fieldZONA As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCODIPROVEE As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCODISOCIO As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldPROVEEDOR As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCODILOTE As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldNOMBLOTE As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCODIPROVEEDORROZA As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldTC As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtTITULO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrZafra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xlblSubtitulo As DevExpress.XtraReports.UI.XRLabel
End Class
