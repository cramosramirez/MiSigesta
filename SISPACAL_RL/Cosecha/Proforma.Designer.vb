<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Proforma
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DS_SIGESTA1 = New SISPACAL.DL.DS_SIGESTA()
        Me.ProformaTableAdapter1 = New SISPACAL.DL.DS_SIGESTATableAdapters.PROFORMATableAdapter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblFrenteQuerqueo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrES_BARRIDO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrES_QUERQUEO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrHacienda = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrEDAD_LOTE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.xrCARGA_CARGADORA_PRODUCTOR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrQUEMA_MES = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrQUEMA_ANIO = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrQUEMA_HORA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_DIA = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_MES = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_ANIO = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_HORA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrQUEMA_DIA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable9 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrROZA_COSECHADORA_PRODUCTOR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTecnico = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_OPERADOR_CODI = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_OPERADOR_NOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel98 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel104 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_OPERADOR_CODI = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_OPERADOR_NOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel101 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel95 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable10 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xtrNOMBRE_MES = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrNOMBRE_USUARIO = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_COSECHADORA_JIBOA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_COSECHADORA_PARTICULAR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_MANUAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_MANUAL_CODI = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_MANUAL_NOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_MANUAL_PRODUCTOR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_COSECHADORA_NOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_MANUAL_PARTICULAR = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_CARGADORA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_CARGADORA_CODI = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_CARGADORA_NOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_CARGADORA_JIBOA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCARGA_CARGADORA_PARTICULAR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTipoTransporte = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_COSECHADORA_CODI = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_MANUAL_PARTICULAR = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_MANUAL_CODI = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_MANUAL_NOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_MANUAL_PRODUCTOR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_MANUAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrROZA_COSECHADORA = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DS_SIGESTA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 7.291667!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 1.833471!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseTextAlignment = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 26.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DS_SIGESTA1
        '
        Me.DS_SIGESTA1.DataSetName = "DS_SIGESTA"
        Me.DS_SIGESTA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProformaTableAdapter1
        '
        Me.ProformaTableAdapter1.ClearBeforeFill = True
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 19.79167!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.lblFrenteQuerqueo, Me.XrLabel20, Me.XrLabel19, Me.xrES_BARRIDO, Me.XrLabel16, Me.xrES_QUERQUEO, Me.XrLabel14, Me.XrTable4, Me.XrTable2, Me.XrTable1, Me.XrBarCode1, Me.xrCARGA_CARGADORA_PRODUCTOR, Me.XrLabel3, Me.XrLabel5, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrTable5, Me.XrLabel12, Me.xrQUEMA_MES, Me.xrQUEMA_ANIO, Me.xrQUEMA_HORA, Me.XrLabel17, Me.xrROZA_DIA, Me.xrROZA_MES, Me.xrROZA_ANIO, Me.xrROZA_HORA, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24, Me.XrLabel25, Me.xrQUEMA_DIA, Me.XrLabel26, Me.XrLabel34, Me.XrTable9, Me.xrROZA_COSECHADORA_PRODUCTOR, Me.XrLabel15, Me.xrTecnico, Me.XrLabel13, Me.xrCARGA_OPERADOR_CODI, Me.xrCARGA_OPERADOR_NOM, Me.XrLabel98, Me.XrLabel104, Me.xrROZA_OPERADOR_CODI, Me.xrROZA_OPERADOR_NOM, Me.XrLabel101, Me.XrLabel95, Me.XrLabel33, Me.XrLabel51, Me.XrLabel44, Me.XrLabel2, Me.XrLabel43, Me.XrTable6, Me.XrLabel38, Me.XrLabel42, Me.XrLabel41, Me.XrLabel37, Me.XrLabel36, Me.XrLabel35, Me.XrLabel32, Me.XrTable10, Me.XrLabel48, Me.XrLabel27, Me.XrLabel1, Me.XrLabel29, Me.XrLabel28, Me.XrLabel70, Me.xrROZA_COSECHADORA_JIBOA, Me.XrLabel72, Me.xrROZA_COSECHADORA_PARTICULAR, Me.XrLabel74, Me.XrLabel75, Me.xrCARGA_MANUAL, Me.XrLabel77, Me.xrCARGA_MANUAL_CODI, Me.xrCARGA_MANUAL_NOM, Me.XrLabel80, Me.xrCARGA_MANUAL_PRODUCTOR, Me.XrLabel82, Me.xrROZA_COSECHADORA_NOM, Me.xrCARGA_MANUAL_PARTICULAR, Me.xrCARGA_CARGADORA, Me.XrLabel87, Me.xrCARGA_CARGADORA_CODI, Me.xrCARGA_CARGADORA_NOM, Me.XrLabel90, Me.xrCARGA_CARGADORA_JIBOA, Me.XrLabel92, Me.xrCARGA_CARGADORA_PARTICULAR, Me.XrLabel64, Me.xrTipoTransporte, Me.XrLabel85, Me.xrROZA_COSECHADORA_CODI, Me.XrLabel18, Me.xrROZA_MANUAL_PARTICULAR, Me.xrROZA_MANUAL_CODI, Me.xrROZA_MANUAL_NOM, Me.XrLabel60, Me.xrROZA_MANUAL_PRODUCTOR, Me.XrLabel67, Me.XrLabel65, Me.XrLabel57, Me.XrLabel62, Me.xrROZA_MANUAL, Me.XrLabel55, Me.XrLabel54, Me.XrLabel52, Me.XrLabel53, Me.XrLabel49, Me.XrLabel47, Me.XrLabel46, Me.xrROZA_COSECHADORA, Me.XrLabel45, Me.XrLabel40, Me.XrLabel39, Me.XrLabel6, Me.XrLabel4, Me.XrLabel31, Me.XrLabel30, Me.XrLabel50})
        Me.PageHeader.HeightF = 580.2083!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 127.5832!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(631.1127!, 16.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell32, Me.XrTableCell37})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.Text = "PORCION:"
        Me.XrTableCell30.Weight = 0.23514731025434826R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UsePadding = False
        Me.XrTableCell32.Weight = 0.079981608946103677R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.SUBLOTE")})
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.Weight = 2.2346379151344151R
        '
        'lblFrenteQuerqueo
        '
        Me.lblFrenteQuerqueo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFrenteQuerqueo.CanGrow = False
        Me.lblFrenteQuerqueo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrenteQuerqueo.LocationFloat = New DevExpress.Utils.PointFloat(517.8621!, 397.3333!)
        Me.lblFrenteQuerqueo.Name = "lblFrenteQuerqueo"
        Me.lblFrenteQuerqueo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFrenteQuerqueo.SizeF = New System.Drawing.SizeF(242.138!, 20.0!)
        Me.lblFrenteQuerqueo.StylePriority.UseBorders = False
        Me.lblFrenteQuerqueo.StylePriority.UseFont = False
        Me.lblFrenteQuerqueo.StylePriority.UsePadding = False
        Me.lblFrenteQuerqueo.StylePriority.UseTextAlignment = False
        Me.lblFrenteQuerqueo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(420.6067!, 397.3333!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(97.25546!, 20.0!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UsePadding = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Frente querqueo:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(526.8622!, 376.3333!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(64.01813!, 20.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UsePadding = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Barrido"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrES_BARRIDO
        '
        Me.xrES_BARRIDO.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrES_BARRIDO.CanGrow = False
        Me.xrES_BARRIDO.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrES_BARRIDO.LocationFloat = New DevExpress.Utils.PointFloat(590.8802!, 376.3333!)
        Me.xrES_BARRIDO.Name = "xrES_BARRIDO"
        Me.xrES_BARRIDO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrES_BARRIDO.SizeF = New System.Drawing.SizeF(18.52808!, 20.0!)
        Me.xrES_BARRIDO.StylePriority.UseBorders = False
        Me.xrES_BARRIDO.StylePriority.UseFont = False
        Me.xrES_BARRIDO.StylePriority.UsePadding = False
        Me.xrES_BARRIDO.StylePriority.UseTextAlignment = False
        Me.xrES_BARRIDO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(420.5371!, 376.3333!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(64.0181!, 20.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Querqueo"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrES_QUERQUEO
        '
        Me.xrES_QUERQUEO.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrES_QUERQUEO.CanGrow = False
        Me.xrES_QUERQUEO.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrES_QUERQUEO.LocationFloat = New DevExpress.Utils.PointFloat(484.5552!, 376.3333!)
        Me.xrES_QUERQUEO.Name = "xrES_QUERQUEO"
        Me.xrES_QUERQUEO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrES_QUERQUEO.SizeF = New System.Drawing.SizeF(18.52808!, 20.0!)
        Me.xrES_QUERQUEO.StylePriority.UseBorders = False
        Me.xrES_QUERQUEO.StylePriority.UseFont = False
        Me.xrES_QUERQUEO.StylePriority.UsePadding = False
        Me.xrES_QUERQUEO.StylePriority.UseTextAlignment = False
        Me.xrES_QUERQUEO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.BorderColor = System.Drawing.Color.Black
        Me.XrLabel14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel14.BorderWidth = 1.0!
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(631.1126!, 164.3749!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(138.8871!, 19.99997!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorderDashStyle = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "FECHA APLICACION"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.00002466399!, 143.5832!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(631.1127!, 20.79173!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell17})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.Text = "COD TRANS:"
        Me.XrTableCell14.Weight = 0.30429133504320421R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.CODTRANSPORT")})
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell15.Weight = 0.16937583822532831R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.Text = "TRANSPORTISTA:"
        Me.XrTableCell16.Weight = 0.395562450751326R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.NOMBRE_TRANSPORTISTA")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.Weight = 0.97151518418895777R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "Productor"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell19.Weight = 0.21853556776018035R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.TRANSPORTE_PROPIO")})
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UsePadding = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell20.Weight = 0.085045951497772651R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UsePadding = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "Particular"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.Weight = 0.23241492113269041R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.TRANSPORTE_PARTICULAR")})
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell17.Weight = 0.085337080520130226R
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.000007629395!, 107.3749!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(631.1127!, 20.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell31, Me.xrHacienda, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell28, Me.XrTableCell29, Me.xrEDAD_LOTE})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.Text = "HACIENDA"
        Me.XrTableCell31.Weight = 0.22706039448882587R
        '
        'xrHacienda
        '
        Me.xrHacienda.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrHacienda.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrHacienda.Name = "xrHacienda"
        Me.xrHacienda.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.xrHacienda.StylePriority.UseBorders = False
        Me.xrHacienda.StylePriority.UseFont = False
        Me.xrHacienda.StylePriority.UsePadding = False
        Me.xrHacienda.Weight = 0.45523814769211818R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UsePadding = False
        Me.XrTableCell8.Text = "COD LOTE:"
        Me.XrTableCell8.Weight = 0.26210981129052757R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.CODILOTE")})
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.15027653039192654R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.Text = "LOTE:"
        Me.XrTableCell10.Weight = 0.18404580026980527R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.NOMBLOTE")})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.Weight = 0.91029655921459474R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBorders = False
        Me.XrTableCell29.Text = "EDAD:"
        Me.XrTableCell29.Weight = 0.14707706475047694R
        '
        'xrEDAD_LOTE
        '
        Me.xrEDAD_LOTE.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrEDAD_LOTE.Name = "xrEDAD_LOTE"
        Me.xrEDAD_LOTE.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.xrEDAD_LOTE.StylePriority.UseBorders = False
        Me.xrEDAD_LOTE.StylePriority.UsePadding = False
        Me.xrEDAD_LOTE.Weight = 0.12597425912986254R
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 87.37493!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(631.1129!, 20.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell7, Me.XrTableCell5, Me.XrTableCell4})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.Text = "CONTRATO:"
        Me.XrTableCell1.Weight = 0.30429136675572982R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "[NO_CONTRATO]"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.Weight = 0.16937577801966075R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.Text = "CODIGO:"
        Me.XrTableCell3.Weight = 0.20863133940182055R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "[CODIPROVEE]  [CODISOCIO]"
        Me.XrTableCell7.Weight = 0.30112153252947621R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.Text = "PROVEEDOR:"
        Me.XrTableCell5.Weight = 0.33432224296004309R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.Text = "[NOMBRE_PROVEEDOR]"
        Me.XrTableCell4.Weight = 1.1443367326833183R
        '
        'XrBarCode1
        '
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.NOPROFORMA")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.20825!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(291.0208!, 61.95834!)
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator1
        Me.XrBarCode1.Text = "12"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'xrCARGA_CARGADORA_PRODUCTOR
        '
        Me.xrCARGA_CARGADORA_PRODUCTOR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_CARGADORA_PRODUCTOR.CanGrow = False
        Me.xrCARGA_CARGADORA_PRODUCTOR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_CARGADORA_PRODUCTOR.LocationFloat = New DevExpress.Utils.PointFloat(466.0967!, 264.3749!)
        Me.xrCARGA_CARGADORA_PRODUCTOR.Name = "xrCARGA_CARGADORA_PRODUCTOR"
        Me.xrCARGA_CARGADORA_PRODUCTOR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_CARGADORA_PRODUCTOR.SizeF = New System.Drawing.SizeF(18.52808!, 20.0!)
        Me.xrCARGA_CARGADORA_PRODUCTOR.StylePriority.UseBorders = False
        Me.xrCARGA_CARGADORA_PRODUCTOR.StylePriority.UseFont = False
        Me.xrCARGA_CARGADORA_PRODUCTOR.StylePriority.UsePadding = False
        Me.xrCARGA_CARGADORA_PRODUCTOR.StylePriority.UseTextAlignment = False
        Me.xrCARGA_CARGADORA_PRODUCTOR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 364.3749!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(410.0789!, 16.95831!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorderDashStyle = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "CONTROL GENERAL"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Black
        Me.XrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(105.4166!, 381.3333!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(185.604!, 18.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorderDashStyle = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "FECHA"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Black
        Me.XrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 381.3333!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(105.4166!, 36.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorderDashStyle = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "CONCEPTO"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Black
        Me.XrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(105.4166!, 399.3333!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(39.27085!, 18.0!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorderDashStyle = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "DIA"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(144.6875!, 399.3333!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(51.33328!, 18.0!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorderDashStyle = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "MES"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.BorderColor = System.Drawing.Color.Black
        Me.XrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(196.0208!, 399.3333!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(94.99995!, 18.0!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorderDashStyle = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "AÑO"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.BorderColor = System.Drawing.Color.Black
        Me.XrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(291.0208!, 381.3333!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(119.058!, 36.0!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorderDashStyle = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "HORA"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable5
        '
        Me.XrTable5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0.0001033147!, 164.3749!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(631.1127!, 20.0!)
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UsePadding = False
        Me.XrTableCell22.Text = "PLACA:"
        Me.XrTableCell22.Weight = 0.30429100764392075R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.PLACAVEHIC")})
        Me.XrTableCell23.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell23.Weight = 0.26015928432861429R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.StylePriority.UsePadding = False
        Me.XrTableCell24.Text = "MOTORISTA:"
        Me.XrTableCell24.Weight = 0.30477902833165554R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.NOMBRES_MOTORISTA")})
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBorders = False
        Me.XrTableCell25.Weight = 1.5928491278696619R
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.BorderColor = System.Drawing.Color.Black
        Me.XrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.BorderWidth = 1.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 417.3333!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(105.4166!, 22.0!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorderDashStyle = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "QUEMA"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrQUEMA_MES
        '
        Me.xrQUEMA_MES.BackColor = System.Drawing.Color.Transparent
        Me.xrQUEMA_MES.BorderColor = System.Drawing.Color.Black
        Me.xrQUEMA_MES.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrQUEMA_MES.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrQUEMA_MES.BorderWidth = 1.0!
        Me.xrQUEMA_MES.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrQUEMA_MES.ForeColor = System.Drawing.Color.Black
        Me.xrQUEMA_MES.LocationFloat = New DevExpress.Utils.PointFloat(144.6875!, 417.3333!)
        Me.xrQUEMA_MES.Name = "xrQUEMA_MES"
        Me.xrQUEMA_MES.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrQUEMA_MES.SizeF = New System.Drawing.SizeF(51.33328!, 22.0!)
        Me.xrQUEMA_MES.StylePriority.UseBackColor = False
        Me.xrQUEMA_MES.StylePriority.UseBorderColor = False
        Me.xrQUEMA_MES.StylePriority.UseBorderDashStyle = False
        Me.xrQUEMA_MES.StylePriority.UseBorders = False
        Me.xrQUEMA_MES.StylePriority.UseBorderWidth = False
        Me.xrQUEMA_MES.StylePriority.UseFont = False
        Me.xrQUEMA_MES.StylePriority.UseForeColor = False
        Me.xrQUEMA_MES.StylePriority.UsePadding = False
        Me.xrQUEMA_MES.StylePriority.UseTextAlignment = False
        Me.xrQUEMA_MES.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrQUEMA_ANIO
        '
        Me.xrQUEMA_ANIO.BackColor = System.Drawing.Color.Transparent
        Me.xrQUEMA_ANIO.BorderColor = System.Drawing.Color.Black
        Me.xrQUEMA_ANIO.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrQUEMA_ANIO.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrQUEMA_ANIO.BorderWidth = 1.0!
        Me.xrQUEMA_ANIO.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrQUEMA_ANIO.ForeColor = System.Drawing.Color.Black
        Me.xrQUEMA_ANIO.LocationFloat = New DevExpress.Utils.PointFloat(196.0208!, 417.3333!)
        Me.xrQUEMA_ANIO.Name = "xrQUEMA_ANIO"
        Me.xrQUEMA_ANIO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrQUEMA_ANIO.SizeF = New System.Drawing.SizeF(94.99983!, 22.0!)
        Me.xrQUEMA_ANIO.StylePriority.UseBackColor = False
        Me.xrQUEMA_ANIO.StylePriority.UseBorderColor = False
        Me.xrQUEMA_ANIO.StylePriority.UseBorderDashStyle = False
        Me.xrQUEMA_ANIO.StylePriority.UseBorders = False
        Me.xrQUEMA_ANIO.StylePriority.UseBorderWidth = False
        Me.xrQUEMA_ANIO.StylePriority.UseFont = False
        Me.xrQUEMA_ANIO.StylePriority.UseForeColor = False
        Me.xrQUEMA_ANIO.StylePriority.UsePadding = False
        Me.xrQUEMA_ANIO.StylePriority.UseTextAlignment = False
        Me.xrQUEMA_ANIO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrQUEMA_HORA
        '
        Me.xrQUEMA_HORA.BackColor = System.Drawing.Color.Transparent
        Me.xrQUEMA_HORA.BorderColor = System.Drawing.Color.Black
        Me.xrQUEMA_HORA.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrQUEMA_HORA.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrQUEMA_HORA.BorderWidth = 1.0!
        Me.xrQUEMA_HORA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrQUEMA_HORA.ForeColor = System.Drawing.Color.Black
        Me.xrQUEMA_HORA.LocationFloat = New DevExpress.Utils.PointFloat(291.0208!, 417.3333!)
        Me.xrQUEMA_HORA.Name = "xrQUEMA_HORA"
        Me.xrQUEMA_HORA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrQUEMA_HORA.SizeF = New System.Drawing.SizeF(119.0579!, 22.0!)
        Me.xrQUEMA_HORA.StylePriority.UseBackColor = False
        Me.xrQUEMA_HORA.StylePriority.UseBorderColor = False
        Me.xrQUEMA_HORA.StylePriority.UseBorderDashStyle = False
        Me.xrQUEMA_HORA.StylePriority.UseBorders = False
        Me.xrQUEMA_HORA.StylePriority.UseBorderWidth = False
        Me.xrQUEMA_HORA.StylePriority.UseFont = False
        Me.xrQUEMA_HORA.StylePriority.UseForeColor = False
        Me.xrQUEMA_HORA.StylePriority.UsePadding = False
        Me.xrQUEMA_HORA.StylePriority.UseTextAlignment = False
        Me.xrQUEMA_HORA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel17.BorderColor = System.Drawing.Color.Black
        Me.XrLabel17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.BorderWidth = 1.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel17.ForeColor = System.Drawing.Color.Black
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 439.3332!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(105.4166!, 22.0!)
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorderDashStyle = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "ROZA"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrROZA_DIA
        '
        Me.xrROZA_DIA.BackColor = System.Drawing.Color.Transparent
        Me.xrROZA_DIA.BorderColor = System.Drawing.Color.Black
        Me.xrROZA_DIA.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrROZA_DIA.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_DIA.BorderWidth = 1.0!
        Me.xrROZA_DIA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrROZA_DIA.ForeColor = System.Drawing.Color.Black
        Me.xrROZA_DIA.LocationFloat = New DevExpress.Utils.PointFloat(105.4166!, 439.3332!)
        Me.xrROZA_DIA.Name = "xrROZA_DIA"
        Me.xrROZA_DIA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_DIA.SizeF = New System.Drawing.SizeF(39.27085!, 22.0!)
        Me.xrROZA_DIA.StylePriority.UseBackColor = False
        Me.xrROZA_DIA.StylePriority.UseBorderColor = False
        Me.xrROZA_DIA.StylePriority.UseBorderDashStyle = False
        Me.xrROZA_DIA.StylePriority.UseBorders = False
        Me.xrROZA_DIA.StylePriority.UseBorderWidth = False
        Me.xrROZA_DIA.StylePriority.UseFont = False
        Me.xrROZA_DIA.StylePriority.UseForeColor = False
        Me.xrROZA_DIA.StylePriority.UsePadding = False
        Me.xrROZA_DIA.StylePriority.UseTextAlignment = False
        Me.xrROZA_DIA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrROZA_MES
        '
        Me.xrROZA_MES.BackColor = System.Drawing.Color.Transparent
        Me.xrROZA_MES.BorderColor = System.Drawing.Color.Black
        Me.xrROZA_MES.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrROZA_MES.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_MES.BorderWidth = 1.0!
        Me.xrROZA_MES.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrROZA_MES.ForeColor = System.Drawing.Color.Black
        Me.xrROZA_MES.LocationFloat = New DevExpress.Utils.PointFloat(144.6875!, 439.3332!)
        Me.xrROZA_MES.Name = "xrROZA_MES"
        Me.xrROZA_MES.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_MES.SizeF = New System.Drawing.SizeF(51.33328!, 22.0!)
        Me.xrROZA_MES.StylePriority.UseBackColor = False
        Me.xrROZA_MES.StylePriority.UseBorderColor = False
        Me.xrROZA_MES.StylePriority.UseBorderDashStyle = False
        Me.xrROZA_MES.StylePriority.UseBorders = False
        Me.xrROZA_MES.StylePriority.UseBorderWidth = False
        Me.xrROZA_MES.StylePriority.UseFont = False
        Me.xrROZA_MES.StylePriority.UseForeColor = False
        Me.xrROZA_MES.StylePriority.UsePadding = False
        Me.xrROZA_MES.StylePriority.UseTextAlignment = False
        Me.xrROZA_MES.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrROZA_ANIO
        '
        Me.xrROZA_ANIO.BackColor = System.Drawing.Color.Transparent
        Me.xrROZA_ANIO.BorderColor = System.Drawing.Color.Black
        Me.xrROZA_ANIO.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrROZA_ANIO.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_ANIO.BorderWidth = 1.0!
        Me.xrROZA_ANIO.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrROZA_ANIO.ForeColor = System.Drawing.Color.Black
        Me.xrROZA_ANIO.LocationFloat = New DevExpress.Utils.PointFloat(196.0208!, 439.3332!)
        Me.xrROZA_ANIO.Name = "xrROZA_ANIO"
        Me.xrROZA_ANIO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_ANIO.SizeF = New System.Drawing.SizeF(94.99983!, 22.0!)
        Me.xrROZA_ANIO.StylePriority.UseBackColor = False
        Me.xrROZA_ANIO.StylePriority.UseBorderColor = False
        Me.xrROZA_ANIO.StylePriority.UseBorderDashStyle = False
        Me.xrROZA_ANIO.StylePriority.UseBorders = False
        Me.xrROZA_ANIO.StylePriority.UseBorderWidth = False
        Me.xrROZA_ANIO.StylePriority.UseFont = False
        Me.xrROZA_ANIO.StylePriority.UseForeColor = False
        Me.xrROZA_ANIO.StylePriority.UsePadding = False
        Me.xrROZA_ANIO.StylePriority.UseTextAlignment = False
        Me.xrROZA_ANIO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrROZA_HORA
        '
        Me.xrROZA_HORA.BackColor = System.Drawing.Color.Transparent
        Me.xrROZA_HORA.BorderColor = System.Drawing.Color.Black
        Me.xrROZA_HORA.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrROZA_HORA.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_HORA.BorderWidth = 1.0!
        Me.xrROZA_HORA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrROZA_HORA.ForeColor = System.Drawing.Color.Black
        Me.xrROZA_HORA.LocationFloat = New DevExpress.Utils.PointFloat(291.0207!, 439.3332!)
        Me.xrROZA_HORA.Name = "xrROZA_HORA"
        Me.xrROZA_HORA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_HORA.SizeF = New System.Drawing.SizeF(119.0581!, 21.99997!)
        Me.xrROZA_HORA.StylePriority.UseBackColor = False
        Me.xrROZA_HORA.StylePriority.UseBorderColor = False
        Me.xrROZA_HORA.StylePriority.UseBorderDashStyle = False
        Me.xrROZA_HORA.StylePriority.UseBorders = False
        Me.xrROZA_HORA.StylePriority.UseBorderWidth = False
        Me.xrROZA_HORA.StylePriority.UseFont = False
        Me.xrROZA_HORA.StylePriority.UseForeColor = False
        Me.xrROZA_HORA.StylePriority.UsePadding = False
        Me.xrROZA_HORA.StylePriority.UseTextAlignment = False
        Me.xrROZA_HORA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel22.BorderColor = System.Drawing.Color.Black
        Me.XrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.BorderWidth = 1.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel22.ForeColor = System.Drawing.Color.Black
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0!, 461.3332!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(105.4166!, 22.0!)
        Me.XrLabel22.StylePriority.UseBackColor = False
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorderDashStyle = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseBorderWidth = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UsePadding = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "CARGADO"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel23.BorderColor = System.Drawing.Color.Black
        Me.XrLabel23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.BorderWidth = 1.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel23.ForeColor = System.Drawing.Color.Black
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(105.4166!, 461.3332!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(39.27094!, 22.0!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorderDashStyle = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseBorderWidth = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UsePadding = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel24.BorderColor = System.Drawing.Color.Black
        Me.XrLabel24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.BorderWidth = 1.0!
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel24.ForeColor = System.Drawing.Color.Black
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(144.6877!, 461.3332!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(51.33327!, 22.0!)
        Me.XrLabel24.StylePriority.UseBackColor = False
        Me.XrLabel24.StylePriority.UseBorderColor = False
        Me.XrLabel24.StylePriority.UseBorderDashStyle = False
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseBorderWidth = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseForeColor = False
        Me.XrLabel24.StylePriority.UsePadding = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel25.BorderColor = System.Drawing.Color.Black
        Me.XrLabel25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.BorderWidth = 1.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel25.ForeColor = System.Drawing.Color.Black
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(196.021!, 461.3332!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(94.99983!, 22.0!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseBorderDashStyle = False
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseBorderWidth = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrQUEMA_DIA
        '
        Me.xrQUEMA_DIA.BackColor = System.Drawing.Color.Transparent
        Me.xrQUEMA_DIA.BorderColor = System.Drawing.Color.Black
        Me.xrQUEMA_DIA.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.xrQUEMA_DIA.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrQUEMA_DIA.BorderWidth = 1.0!
        Me.xrQUEMA_DIA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrQUEMA_DIA.ForeColor = System.Drawing.Color.Black
        Me.xrQUEMA_DIA.LocationFloat = New DevExpress.Utils.PointFloat(105.4166!, 417.3333!)
        Me.xrQUEMA_DIA.Name = "xrQUEMA_DIA"
        Me.xrQUEMA_DIA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrQUEMA_DIA.SizeF = New System.Drawing.SizeF(39.27085!, 22.0!)
        Me.xrQUEMA_DIA.StylePriority.UseBackColor = False
        Me.xrQUEMA_DIA.StylePriority.UseBorderColor = False
        Me.xrQUEMA_DIA.StylePriority.UseBorderDashStyle = False
        Me.xrQUEMA_DIA.StylePriority.UseBorders = False
        Me.xrQUEMA_DIA.StylePriority.UseBorderWidth = False
        Me.xrQUEMA_DIA.StylePriority.UseFont = False
        Me.xrQUEMA_DIA.StylePriority.UseForeColor = False
        Me.xrQUEMA_DIA.StylePriority.UsePadding = False
        Me.xrQUEMA_DIA.StylePriority.UseTextAlignment = False
        Me.xrQUEMA_DIA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel26.BorderColor = System.Drawing.Color.Black
        Me.XrLabel26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel26.BorderWidth = 1.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel26.ForeColor = System.Drawing.Color.Black
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(291.0208!, 461.3332!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(119.0581!, 22.0!)
        Me.XrLabel26.StylePriority.UseBackColor = False
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorderDashStyle = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UsePadding = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel34.BorderColor = System.Drawing.Color.Black
        Me.XrLabel34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel34.BorderWidth = 1.0!
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel34.ForeColor = System.Drawing.Color.Black
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(631.1129!, 229.3749!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(120.137!, 26.79167!)
        Me.XrLabel34.StylePriority.UseBackColor = False
        Me.XrLabel34.StylePriority.UseBorderColor = False
        Me.XrLabel34.StylePriority.UseBorderDashStyle = False
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseBorderWidth = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseForeColor = False
        Me.XrLabel34.StylePriority.UsePadding = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "QUEMA NO PROGRAMADA"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable9
        '
        Me.XrTable9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable9.LocationFloat = New DevExpress.Utils.PointFloat(631.1126!, 281.1666!)
        Me.XrTable9.Name = "XrTable9"
        Me.XrTable9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11})
        Me.XrTable9.SizeF = New System.Drawing.SizeF(138.8871!, 23.20836!)
        Me.XrTable9.StylePriority.UseBorders = False
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.XrTableCell41})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.3113729330982462R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell13.Multiline = True
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "FIN DE LOTE"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell13.Weight = 2.5949934213012726R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.FIN_LOTE")})
        Me.XrTableCell41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBorders = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell41.Weight = 0.40500657869872714R
        '
        'xrROZA_COSECHADORA_PRODUCTOR
        '
        Me.xrROZA_COSECHADORA_PRODUCTOR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_COSECHADORA_PRODUCTOR.CanGrow = False
        Me.xrROZA_COSECHADORA_PRODUCTOR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_COSECHADORA_PRODUCTOR.LocationFloat = New DevExpress.Utils.PointFloat(466.097!, 204.3749!)
        Me.xrROZA_COSECHADORA_PRODUCTOR.Name = "xrROZA_COSECHADORA_PRODUCTOR"
        Me.xrROZA_COSECHADORA_PRODUCTOR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_COSECHADORA_PRODUCTOR.SizeF = New System.Drawing.SizeF(18.52808!, 20.0!)
        Me.xrROZA_COSECHADORA_PRODUCTOR.StylePriority.UseBorders = False
        Me.xrROZA_COSECHADORA_PRODUCTOR.StylePriority.UseFont = False
        Me.xrROZA_COSECHADORA_PRODUCTOR.StylePriority.UsePadding = False
        Me.xrROZA_COSECHADORA_PRODUCTOR.StylePriority.UseTextAlignment = False
        Me.xrROZA_COSECHADORA_PRODUCTOR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(410.0789!, 204.3749!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(56.01801!, 20.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UsePadding = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Productor"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrTecnico
        '
        Me.xrTecnico.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTecnico.CanGrow = False
        Me.xrTecnico.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTecnico.LocationFloat = New DevExpress.Utils.PointFloat(410.0787!, 304.3749!)
        Me.xrTecnico.Name = "xrTecnico"
        Me.xrTecnico.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrTecnico.SizeF = New System.Drawing.SizeF(359.921!, 20.0!)
        Me.xrTecnico.StylePriority.UseBorders = False
        Me.xrTecnico.StylePriority.UseFont = False
        Me.xrTecnico.StylePriority.UsePadding = False
        Me.xrTecnico.StylePriority.UseTextAlignment = False
        Me.xrTecnico.Text = "TECNICO:"
        Me.xrTecnico.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.BorderColor = System.Drawing.Color.Black
        Me.XrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel13.BorderWidth = 1.0!
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.FECHA_MADURANTE", "{0:dd/MM/yyyy}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(631.1126!, 184.3749!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(138.8871!, 19.99998!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorderDashStyle = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UsePadding = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrCARGA_OPERADOR_CODI
        '
        Me.xrCARGA_OPERADOR_CODI.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrCARGA_OPERADOR_CODI.CanGrow = False
        Me.xrCARGA_OPERADOR_CODI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrCARGA_OPERADOR_CODI.LocationFloat = New DevExpress.Utils.PointFloat(212.2704!, 284.3749!)
        Me.xrCARGA_OPERADOR_CODI.Name = "xrCARGA_OPERADOR_CODI"
        Me.xrCARGA_OPERADOR_CODI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_OPERADOR_CODI.SizeF = New System.Drawing.SizeF(24.58337!, 20.0!)
        Me.xrCARGA_OPERADOR_CODI.StylePriority.UseBorders = False
        Me.xrCARGA_OPERADOR_CODI.StylePriority.UseFont = False
        Me.xrCARGA_OPERADOR_CODI.StylePriority.UsePadding = False
        Me.xrCARGA_OPERADOR_CODI.StylePriority.UseTextAlignment = False
        Me.xrCARGA_OPERADOR_CODI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_OPERADOR_NOM
        '
        Me.xrCARGA_OPERADOR_NOM.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_OPERADOR_NOM.CanGrow = False
        Me.xrCARGA_OPERADOR_NOM.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrCARGA_OPERADOR_NOM.LocationFloat = New DevExpress.Utils.PointFloat(236.8538!, 284.3749!)
        Me.xrCARGA_OPERADOR_NOM.Name = "xrCARGA_OPERADOR_NOM"
        Me.xrCARGA_OPERADOR_NOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_OPERADOR_NOM.SizeF = New System.Drawing.SizeF(394.2589!, 20.0!)
        Me.xrCARGA_OPERADOR_NOM.StylePriority.UseBorders = False
        Me.xrCARGA_OPERADOR_NOM.StylePriority.UseFont = False
        Me.xrCARGA_OPERADOR_NOM.StylePriority.UsePadding = False
        Me.xrCARGA_OPERADOR_NOM.StylePriority.UseTextAlignment = False
        Me.xrCARGA_OPERADOR_NOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel98
        '
        Me.XrLabel98.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel98.CanGrow = False
        Me.XrLabel98.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel98.LocationFloat = New DevExpress.Utils.PointFloat(55.08321!, 284.3749!)
        Me.XrLabel98.Name = "XrLabel98"
        Me.XrLabel98.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel98.SizeF = New System.Drawing.SizeF(118.0208!, 20.00002!)
        Me.XrLabel98.StylePriority.UseBorders = False
        Me.XrLabel98.StylePriority.UseFont = False
        Me.XrLabel98.StylePriority.UsePadding = False
        Me.XrLabel98.StylePriority.UseTextAlignment = False
        Me.XrLabel98.Text = "OPERADOR"
        Me.XrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel104
        '
        Me.XrLabel104.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel104.CanGrow = False
        Me.XrLabel104.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel104.LocationFloat = New DevExpress.Utils.PointFloat(173.1037!, 284.3749!)
        Me.XrLabel104.Name = "XrLabel104"
        Me.XrLabel104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel104.SizeF = New System.Drawing.SizeF(39.16666!, 20.0!)
        Me.XrLabel104.StylePriority.UseBorders = False
        Me.XrLabel104.StylePriority.UseFont = False
        Me.XrLabel104.StylePriority.UsePadding = False
        Me.XrLabel104.StylePriority.UseTextAlignment = False
        Me.XrLabel104.Text = "COD.:"
        Me.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrROZA_OPERADOR_CODI
        '
        Me.xrROZA_OPERADOR_CODI.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrROZA_OPERADOR_CODI.CanGrow = False
        Me.xrROZA_OPERADOR_CODI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrROZA_OPERADOR_CODI.LocationFloat = New DevExpress.Utils.PointFloat(212.2704!, 224.3749!)
        Me.xrROZA_OPERADOR_CODI.Name = "xrROZA_OPERADOR_CODI"
        Me.xrROZA_OPERADOR_CODI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_OPERADOR_CODI.SizeF = New System.Drawing.SizeF(24.58347!, 20.00002!)
        Me.xrROZA_OPERADOR_CODI.StylePriority.UseBorders = False
        Me.xrROZA_OPERADOR_CODI.StylePriority.UseFont = False
        Me.xrROZA_OPERADOR_CODI.StylePriority.UsePadding = False
        Me.xrROZA_OPERADOR_CODI.StylePriority.UseTextAlignment = False
        Me.xrROZA_OPERADOR_CODI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrROZA_OPERADOR_NOM
        '
        Me.xrROZA_OPERADOR_NOM.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_OPERADOR_NOM.CanGrow = False
        Me.xrROZA_OPERADOR_NOM.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrROZA_OPERADOR_NOM.LocationFloat = New DevExpress.Utils.PointFloat(236.8538!, 224.3749!)
        Me.xrROZA_OPERADOR_NOM.Name = "xrROZA_OPERADOR_NOM"
        Me.xrROZA_OPERADOR_NOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrROZA_OPERADOR_NOM.SizeF = New System.Drawing.SizeF(394.2589!, 20.00002!)
        Me.xrROZA_OPERADOR_NOM.StylePriority.UseBorders = False
        Me.xrROZA_OPERADOR_NOM.StylePriority.UseFont = False
        Me.xrROZA_OPERADOR_NOM.StylePriority.UsePadding = False
        Me.xrROZA_OPERADOR_NOM.StylePriority.UseTextAlignment = False
        Me.xrROZA_OPERADOR_NOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel101
        '
        Me.XrLabel101.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel101.CanGrow = False
        Me.XrLabel101.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel101.LocationFloat = New DevExpress.Utils.PointFloat(173.1037!, 224.3749!)
        Me.XrLabel101.Name = "XrLabel101"
        Me.XrLabel101.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel101.SizeF = New System.Drawing.SizeF(39.16666!, 20.00002!)
        Me.XrLabel101.StylePriority.UseBorders = False
        Me.XrLabel101.StylePriority.UseFont = False
        Me.XrLabel101.StylePriority.UsePadding = False
        Me.XrLabel101.StylePriority.UseTextAlignment = False
        Me.XrLabel101.Text = "COD.:"
        Me.XrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel95
        '
        Me.XrLabel95.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel95.CanGrow = False
        Me.XrLabel95.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel95.LocationFloat = New DevExpress.Utils.PointFloat(55.08321!, 224.3749!)
        Me.XrLabel95.Name = "XrLabel95"
        Me.XrLabel95.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel95.SizeF = New System.Drawing.SizeF(118.0208!, 20.00002!)
        Me.XrLabel95.StylePriority.UseBorders = False
        Me.XrLabel95.StylePriority.UseFont = False
        Me.XrLabel95.StylePriority.UsePadding = False
        Me.XrLabel95.StylePriority.UseTextAlignment = False
        Me.XrLabel95.Text = "OPERADOR"
        Me.XrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel33.BorderColor = System.Drawing.Color.Black
        Me.XrLabel33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel33.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.BorderWidth = 1.0!
        Me.XrLabel33.CanGrow = False
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.QUEMAPROG")})
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.ForeColor = System.Drawing.Color.Black
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(751.25!, 204.3749!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(18.75!, 25.0!)
        Me.XrLabel33.StylePriority.UseBackColor = False
        Me.XrLabel33.StylePriority.UseBorderColor = False
        Me.XrLabel33.StylePriority.UseBorderDashStyle = False
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseBorderWidth = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseForeColor = False
        Me.XrLabel33.StylePriority.UsePadding = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel51
        '
        Me.XrLabel51.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel51.BorderColor = System.Drawing.Color.Black
        Me.XrLabel51.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel51.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel51.BorderWidth = 1.0!
        Me.XrLabel51.CanGrow = False
        Me.XrLabel51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.CANA_VERDE")})
        Me.XrLabel51.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel51.ForeColor = System.Drawing.Color.Black
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(751.2498!, 256.1666!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(18.74994!, 25.0!)
        Me.XrLabel51.StylePriority.UseBackColor = False
        Me.XrLabel51.StylePriority.UseBorderColor = False
        Me.XrLabel51.StylePriority.UseBorderDashStyle = False
        Me.XrLabel51.StylePriority.UseBorders = False
        Me.XrLabel51.StylePriority.UseBorderWidth = False
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseForeColor = False
        Me.XrLabel51.StylePriority.UsePadding = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.NOPROFORMA")})
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(637.8623!, 34.58322!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(132.1377!, 25.08334!)
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(527.8623!, 34.58323!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(110.0!, 25.08334!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "N° Proforma:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(527.8622!, 61.66657!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(242.1376!, 25.08334!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "N° Envío:________________ "
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable6
        '
        Me.XrTable6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(421.5371!, 417.3333!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow6, Me.XrTableRow8, Me.XrTableRow9})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(338.4629!, 78.99969!)
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell26, Me.XrTableCell6})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.25R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.Text = "OBSERVACIONES:"
        Me.XrTableCell26.Weight = 0.14920737932889105R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 0.32576197106825655R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.StylePriority.UseBorders = False
        Me.XrTableRow6.Weight = 1.25R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.Weight = 0.47496935039714772R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.StylePriority.UseBorders = False
        Me.XrTableRow8.Weight = 1.25R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.Weight = 0.47496935039714772R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.25R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.Weight = 0.47496935039714772R
        '
        'XrLabel38
        '
        Me.XrLabel38.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel38.BorderColor = System.Drawing.Color.Black
        Me.XrLabel38.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel38.BorderWidth = 1.0!
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel38.ForeColor = System.Drawing.Color.Black
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(444.0934!, 355.5416!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(288.5105!, 17.83331!)
        Me.XrLabel38.StylePriority.UseBackColor = False
        Me.XrLabel38.StylePriority.UseBorderColor = False
        Me.XrLabel38.StylePriority.UseBorderDashStyle = False
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseBorderWidth = False
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseForeColor = False
        Me.XrLabel38.StylePriority.UsePadding = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "CHEQUERO INJIBOA"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel42
        '
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(301.3229!, 64.66657!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(209.625!, 18.0!)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "ZAFRA [ZAFRA]"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel41
        '
        Me.XrLabel41.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel41.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(314.8646!, 20.20825!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(182.5416!, 20.0!)
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "INJIBOA S.A. DE C.V."
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel37
        '
        Me.XrLabel37.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel37.BorderColor = System.Drawing.Color.Black
        Me.XrLabel37.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel37.BorderWidth = 1.0!
        Me.XrLabel37.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel37.ForeColor = System.Drawing.Color.Black
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(444.0934!, 533.0834!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(83.76886!, 17.83334!)
        Me.XrLabel37.StylePriority.UseBackColor = False
        Me.XrLabel37.StylePriority.UseBorderColor = False
        Me.XrLabel37.StylePriority.UseBorderDashStyle = False
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseBorderWidth = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseForeColor = False
        Me.XrLabel37.StylePriority.UsePadding = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "RECIBI:"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel36
        '
        Me.XrLabel36.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel36.BorderColor = System.Drawing.Color.Black
        Me.XrLabel36.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel36.BorderWidth = 1.0!
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel36.ForeColor = System.Drawing.Color.Black
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(527.8622!, 554.9167!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(228.7686!, 17.83331!)
        Me.XrLabel36.StylePriority.UseBackColor = False
        Me.XrLabel36.StylePriority.UseBorderColor = False
        Me.XrLabel36.StylePriority.UseBorderDashStyle = False
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseBorderWidth = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseForeColor = False
        Me.XrLabel36.StylePriority.UsePadding = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "MOTORISTA"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel35
        '
        Me.XrLabel35.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel35.BorderColor = System.Drawing.Color.Black
        Me.XrLabel35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel35.BorderWidth = 1.0!
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel35.ForeColor = System.Drawing.Color.Black
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(239.7137!, 554.9167!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(201.0105!, 17.83331!)
        Me.XrLabel35.StylePriority.UseBackColor = False
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorderDashStyle = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseBorderWidth = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseForeColor = False
        Me.XrLabel35.StylePriority.UsePadding = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "CARGADOR"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel32.BorderColor = System.Drawing.Color.Black
        Me.XrLabel32.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel32.BorderWidth = 1.0!
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel32.ForeColor = System.Drawing.Color.Black
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(6.630866!, 554.9167!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(212.8125!, 17.83331!)
        Me.XrLabel32.StylePriority.UseBackColor = False
        Me.XrLabel32.StylePriority.UseBorderColor = False
        Me.XrLabel32.StylePriority.UseBorderDashStyle = False
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseBorderWidth = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseForeColor = False
        Me.XrLabel32.StylePriority.UsePadding = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "CHEQUERO DE CAÑICULTOR"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable10
        '
        Me.XrTable10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable10.LocationFloat = New DevExpress.Utils.PointFloat(0.0002463659!, 505.3332!)
        Me.XrTable10.Name = "XrTable10"
        Me.XrTable10.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow22})
        Me.XrTable10.SizeF = New System.Drawing.SizeF(769.9996!, 27.0!)
        Me.XrTable10.StylePriority.UseBorders = False
        Me.XrTable10.StylePriority.UseFont = False
        Me.XrTable10.StylePriority.UseTextAlignment = False
        Me.XrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65, Me.xtrNOMBRE_MES, Me.XrTableCell61, Me.XrTableCell67, Me.XrTableCell11, Me.xrNOMBRE_USUARIO})
        Me.XrTableRow22.Name = "XrTableRow22"
        Me.XrTableRow22.StylePriority.UseBorders = False
        Me.XrTableRow22.Weight = 1.35R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.StylePriority.UseBorders = False
        Me.XrTableCell63.Text = "FECHA: "
        Me.XrTableCell63.Weight = 0.17262591643121802R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.FECHA_EMISION", "{0:dd}")})
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.StylePriority.UseBorders = False
        Me.XrTableCell64.StylePriority.UseTextAlignment = False
        Me.XrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell64.Weight = 0.19798437510113162R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.StylePriority.UseTextAlignment = False
        Me.XrTableCell65.Text = "DE"
        Me.XrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell65.Weight = 0.15320224323696885R
        '
        'xtrNOMBRE_MES
        '
        Me.xtrNOMBRE_MES.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xtrNOMBRE_MES.Name = "xtrNOMBRE_MES"
        Me.xtrNOMBRE_MES.StylePriority.UseBorders = False
        Me.xtrNOMBRE_MES.StylePriority.UseTextAlignment = False
        Me.xtrNOMBRE_MES.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xtrNOMBRE_MES.Weight = 0.51202872859808823R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.Text = "DE"
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell61.Weight = 0.13560641718278621R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.FECHA_EMISION", "{0:yyyy}")})
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.StylePriority.UseBorders = False
        Me.XrTableCell67.Weight = 0.428339892944432R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "EMISOR:"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 0.24095674837693315R
        '
        'xrNOMBRE_USUARIO
        '
        Me.xrNOMBRE_USUARIO.Name = "xrNOMBRE_USUARIO"
        Me.xrNOMBRE_USUARIO.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrNOMBRE_USUARIO.StylePriority.UsePadding = False
        Me.xrNOMBRE_USUARIO.Weight = 1.1631560369845941R
        '
        'XrLabel48
        '
        Me.XrLabel48.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel48.BorderColor = System.Drawing.Color.Black
        Me.XrLabel48.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel48.BorderWidth = 1.0!
        Me.XrLabel48.CanGrow = False
        Me.XrLabel48.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel48.ForeColor = System.Drawing.Color.Black
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(631.1127!, 256.1666!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(120.137!, 25.0!)
        Me.XrLabel48.StylePriority.UseBackColor = False
        Me.XrLabel48.StylePriority.UseBorderColor = False
        Me.XrLabel48.StylePriority.UseBorderDashStyle = False
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseBorderWidth = False
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseForeColor = False
        Me.XrLabel48.StylePriority.UsePadding = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "CAÑA VERDE"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel27.BorderColor = System.Drawing.Color.Black
        Me.XrLabel27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel27.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.BorderWidth = 1.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel27.ForeColor = System.Drawing.Color.Black
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(0!, 483.3332!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(105.4166!, 22.0!)
        Me.XrLabel27.StylePriority.UseBackColor = False
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorderDashStyle = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseBorderWidth = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.StylePriority.UsePadding = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "INGRESO JIBOA"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(301.3229!, 46.66657!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(209.625!, 18.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "PROFORMA DE ENVIO DE CAÑA"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel29.BorderColor = System.Drawing.Color.Black
        Me.XrLabel29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel29.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel29.BorderWidth = 1.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel29.ForeColor = System.Drawing.Color.Black
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(144.6877!, 483.3332!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(51.33327!, 22.0!)
        Me.XrLabel29.StylePriority.UseBackColor = False
        Me.XrLabel29.StylePriority.UseBorderColor = False
        Me.XrLabel29.StylePriority.UseBorderDashStyle = False
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseBorderWidth = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseForeColor = False
        Me.XrLabel29.StylePriority.UsePadding = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel28.BorderColor = System.Drawing.Color.Black
        Me.XrLabel28.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.BorderWidth = 1.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel28.ForeColor = System.Drawing.Color.Black
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(105.4166!, 483.3332!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(39.27094!, 22.0!)
        Me.XrLabel28.StylePriority.UseBackColor = False
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseBorderDashStyle = False
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseBorderWidth = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UsePadding = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel70
        '
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel70.CanGrow = False
        Me.XrLabel70.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(484.6251!, 204.3749!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(43.23724!, 20.0!)
        Me.XrLabel70.StylePriority.UseBorders = False
        Me.XrLabel70.StylePriority.UseFont = False
        Me.XrLabel70.StylePriority.UsePadding = False
        Me.XrLabel70.StylePriority.UseTextAlignment = False
        Me.XrLabel70.Text = "Jiboa"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrROZA_COSECHADORA_JIBOA
        '
        Me.xrROZA_COSECHADORA_JIBOA.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_COSECHADORA_JIBOA.CanGrow = False
        Me.xrROZA_COSECHADORA_JIBOA.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_COSECHADORA_JIBOA.LocationFloat = New DevExpress.Utils.PointFloat(527.8623!, 204.3749!)
        Me.xrROZA_COSECHADORA_JIBOA.Name = "xrROZA_COSECHADORA_JIBOA"
        Me.xrROZA_COSECHADORA_JIBOA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_COSECHADORA_JIBOA.SizeF = New System.Drawing.SizeF(21.79993!, 20.0!)
        Me.xrROZA_COSECHADORA_JIBOA.StylePriority.UseBorders = False
        Me.xrROZA_COSECHADORA_JIBOA.StylePriority.UseFont = False
        Me.xrROZA_COSECHADORA_JIBOA.StylePriority.UsePadding = False
        Me.xrROZA_COSECHADORA_JIBOA.StylePriority.UseTextAlignment = False
        Me.xrROZA_COSECHADORA_JIBOA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel72
        '
        Me.XrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel72.CanGrow = False
        Me.XrLabel72.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(549.6622!, 204.3749!)
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(59.5757!, 20.0!)
        Me.XrLabel72.StylePriority.UseBorders = False
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UsePadding = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.Text = "Particular"
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrROZA_COSECHADORA_PARTICULAR
        '
        Me.xrROZA_COSECHADORA_PARTICULAR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_COSECHADORA_PARTICULAR.CanGrow = False
        Me.xrROZA_COSECHADORA_PARTICULAR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_COSECHADORA_PARTICULAR.LocationFloat = New DevExpress.Utils.PointFloat(609.2379!, 204.3749!)
        Me.xrROZA_COSECHADORA_PARTICULAR.Name = "xrROZA_COSECHADORA_PARTICULAR"
        Me.xrROZA_COSECHADORA_PARTICULAR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_COSECHADORA_PARTICULAR.SizeF = New System.Drawing.SizeF(21.87476!, 20.0!)
        Me.xrROZA_COSECHADORA_PARTICULAR.StylePriority.UseBorders = False
        Me.xrROZA_COSECHADORA_PARTICULAR.StylePriority.UseFont = False
        Me.xrROZA_COSECHADORA_PARTICULAR.StylePriority.UsePadding = False
        Me.xrROZA_COSECHADORA_PARTICULAR.StylePriority.UseTextAlignment = False
        Me.xrROZA_COSECHADORA_PARTICULAR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel74
        '
        Me.XrLabel74.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel74.CanGrow = False
        Me.XrLabel74.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(0!, 244.3749!)
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(55.08336!, 59.99997!)
        Me.XrLabel74.StylePriority.UseBorders = False
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UsePadding = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "CARGA"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel75
        '
        Me.XrLabel75.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel75.CanGrow = False
        Me.XrLabel75.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(55.08337!, 244.3749!)
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(96.89582!, 20.0!)
        Me.XrLabel75.StylePriority.UseBorders = False
        Me.XrLabel75.StylePriority.UseFont = False
        Me.XrLabel75.StylePriority.UsePadding = False
        Me.XrLabel75.StylePriority.UseTextAlignment = False
        Me.XrLabel75.Text = "MANUAL"
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_MANUAL
        '
        Me.xrCARGA_MANUAL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_MANUAL.CanGrow = False
        Me.xrCARGA_MANUAL.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_MANUAL.LocationFloat = New DevExpress.Utils.PointFloat(151.979!, 244.3749!)
        Me.xrCARGA_MANUAL.Name = "xrCARGA_MANUAL"
        Me.xrCARGA_MANUAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_MANUAL.SizeF = New System.Drawing.SizeF(21.12497!, 20.0!)
        Me.xrCARGA_MANUAL.StylePriority.UseBorders = False
        Me.xrCARGA_MANUAL.StylePriority.UseFont = False
        Me.xrCARGA_MANUAL.StylePriority.UsePadding = False
        Me.xrCARGA_MANUAL.StylePriority.UseTextAlignment = False
        Me.xrCARGA_MANUAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel77
        '
        Me.XrLabel77.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel77.CanGrow = False
        Me.XrLabel77.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(173.1039!, 244.3749!)
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(39.16669!, 19.99998!)
        Me.XrLabel77.StylePriority.UseBorders = False
        Me.XrLabel77.StylePriority.UseFont = False
        Me.XrLabel77.StylePriority.UsePadding = False
        Me.XrLabel77.StylePriority.UseTextAlignment = False
        Me.XrLabel77.Text = "COD.:"
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_MANUAL_CODI
        '
        Me.xrCARGA_MANUAL_CODI.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrCARGA_MANUAL_CODI.CanGrow = False
        Me.xrCARGA_MANUAL_CODI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrCARGA_MANUAL_CODI.LocationFloat = New DevExpress.Utils.PointFloat(212.2706!, 244.3749!)
        Me.xrCARGA_MANUAL_CODI.Name = "xrCARGA_MANUAL_CODI"
        Me.xrCARGA_MANUAL_CODI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_MANUAL_CODI.SizeF = New System.Drawing.SizeF(24.58322!, 19.99998!)
        Me.xrCARGA_MANUAL_CODI.StylePriority.UseBorders = False
        Me.xrCARGA_MANUAL_CODI.StylePriority.UseFont = False
        Me.xrCARGA_MANUAL_CODI.StylePriority.UsePadding = False
        Me.xrCARGA_MANUAL_CODI.StylePriority.UseTextAlignment = False
        Me.xrCARGA_MANUAL_CODI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_MANUAL_NOM
        '
        Me.xrCARGA_MANUAL_NOM.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrCARGA_MANUAL_NOM.CanGrow = False
        Me.xrCARGA_MANUAL_NOM.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrCARGA_MANUAL_NOM.LocationFloat = New DevExpress.Utils.PointFloat(236.8539!, 244.3749!)
        Me.xrCARGA_MANUAL_NOM.Name = "xrCARGA_MANUAL_NOM"
        Me.xrCARGA_MANUAL_NOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_MANUAL_NOM.SizeF = New System.Drawing.SizeF(229.2428!, 19.99998!)
        Me.xrCARGA_MANUAL_NOM.StylePriority.UseBorders = False
        Me.xrCARGA_MANUAL_NOM.StylePriority.UseFont = False
        Me.xrCARGA_MANUAL_NOM.StylePriority.UsePadding = False
        Me.xrCARGA_MANUAL_NOM.StylePriority.UseTextAlignment = False
        Me.xrCARGA_MANUAL_NOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel80
        '
        Me.XrLabel80.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel80.CanGrow = False
        Me.XrLabel80.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(466.097!, 244.3749!)
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(61.76523!, 19.99998!)
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UsePadding = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "Productor"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrCARGA_MANUAL_PRODUCTOR
        '
        Me.xrCARGA_MANUAL_PRODUCTOR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_MANUAL_PRODUCTOR.CanGrow = False
        Me.xrCARGA_MANUAL_PRODUCTOR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_MANUAL_PRODUCTOR.LocationFloat = New DevExpress.Utils.PointFloat(527.8622!, 244.3749!)
        Me.xrCARGA_MANUAL_PRODUCTOR.Name = "xrCARGA_MANUAL_PRODUCTOR"
        Me.xrCARGA_MANUAL_PRODUCTOR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_MANUAL_PRODUCTOR.SizeF = New System.Drawing.SizeF(21.79999!, 20.0!)
        Me.xrCARGA_MANUAL_PRODUCTOR.StylePriority.UseBorders = False
        Me.xrCARGA_MANUAL_PRODUCTOR.StylePriority.UseFont = False
        Me.xrCARGA_MANUAL_PRODUCTOR.StylePriority.UsePadding = False
        Me.xrCARGA_MANUAL_PRODUCTOR.StylePriority.UseTextAlignment = False
        Me.xrCARGA_MANUAL_PRODUCTOR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel82.CanGrow = False
        Me.XrLabel82.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(549.6622!, 244.3749!)
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(59.57568!, 20.0!)
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UsePadding = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "Particular"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrROZA_COSECHADORA_NOM
        '
        Me.xrROZA_COSECHADORA_NOM.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrROZA_COSECHADORA_NOM.CanGrow = False
        Me.xrROZA_COSECHADORA_NOM.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrROZA_COSECHADORA_NOM.LocationFloat = New DevExpress.Utils.PointFloat(236.8539!, 204.3749!)
        Me.xrROZA_COSECHADORA_NOM.Name = "xrROZA_COSECHADORA_NOM"
        Me.xrROZA_COSECHADORA_NOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_COSECHADORA_NOM.SizeF = New System.Drawing.SizeF(173.2251!, 20.0!)
        Me.xrROZA_COSECHADORA_NOM.StylePriority.UseBorders = False
        Me.xrROZA_COSECHADORA_NOM.StylePriority.UseFont = False
        Me.xrROZA_COSECHADORA_NOM.StylePriority.UsePadding = False
        Me.xrROZA_COSECHADORA_NOM.StylePriority.UseTextAlignment = False
        Me.xrROZA_COSECHADORA_NOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_MANUAL_PARTICULAR
        '
        Me.xrCARGA_MANUAL_PARTICULAR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_MANUAL_PARTICULAR.CanGrow = False
        Me.xrCARGA_MANUAL_PARTICULAR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_MANUAL_PARTICULAR.LocationFloat = New DevExpress.Utils.PointFloat(609.2379!, 244.3749!)
        Me.xrCARGA_MANUAL_PARTICULAR.Name = "xrCARGA_MANUAL_PARTICULAR"
        Me.xrCARGA_MANUAL_PARTICULAR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_MANUAL_PARTICULAR.SizeF = New System.Drawing.SizeF(21.87476!, 20.0!)
        Me.xrCARGA_MANUAL_PARTICULAR.StylePriority.UseBorders = False
        Me.xrCARGA_MANUAL_PARTICULAR.StylePriority.UseFont = False
        Me.xrCARGA_MANUAL_PARTICULAR.StylePriority.UsePadding = False
        Me.xrCARGA_MANUAL_PARTICULAR.StylePriority.UseTextAlignment = False
        Me.xrCARGA_MANUAL_PARTICULAR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrCARGA_CARGADORA
        '
        Me.xrCARGA_CARGADORA.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_CARGADORA.CanGrow = False
        Me.xrCARGA_CARGADORA.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_CARGADORA.LocationFloat = New DevExpress.Utils.PointFloat(151.9789!, 264.3749!)
        Me.xrCARGA_CARGADORA.Name = "xrCARGA_CARGADORA"
        Me.xrCARGA_CARGADORA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_CARGADORA.SizeF = New System.Drawing.SizeF(21.125!, 20.0!)
        Me.xrCARGA_CARGADORA.StylePriority.UseBorders = False
        Me.xrCARGA_CARGADORA.StylePriority.UseFont = False
        Me.xrCARGA_CARGADORA.StylePriority.UsePadding = False
        Me.xrCARGA_CARGADORA.StylePriority.UseTextAlignment = False
        Me.xrCARGA_CARGADORA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel87
        '
        Me.XrLabel87.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel87.CanGrow = False
        Me.XrLabel87.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(173.1039!, 264.3749!)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(39.16669!, 20.0!)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UsePadding = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "COD.:"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_CARGADORA_CODI
        '
        Me.xrCARGA_CARGADORA_CODI.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrCARGA_CARGADORA_CODI.CanGrow = False
        Me.xrCARGA_CARGADORA_CODI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrCARGA_CARGADORA_CODI.LocationFloat = New DevExpress.Utils.PointFloat(212.2706!, 264.3749!)
        Me.xrCARGA_CARGADORA_CODI.Name = "xrCARGA_CARGADORA_CODI"
        Me.xrCARGA_CARGADORA_CODI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_CARGADORA_CODI.SizeF = New System.Drawing.SizeF(24.58319!, 20.0!)
        Me.xrCARGA_CARGADORA_CODI.StylePriority.UseBorders = False
        Me.xrCARGA_CARGADORA_CODI.StylePriority.UseFont = False
        Me.xrCARGA_CARGADORA_CODI.StylePriority.UsePadding = False
        Me.xrCARGA_CARGADORA_CODI.StylePriority.UseTextAlignment = False
        Me.xrCARGA_CARGADORA_CODI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCARGA_CARGADORA_NOM
        '
        Me.xrCARGA_CARGADORA_NOM.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrCARGA_CARGADORA_NOM.CanGrow = False
        Me.xrCARGA_CARGADORA_NOM.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrCARGA_CARGADORA_NOM.LocationFloat = New DevExpress.Utils.PointFloat(236.8539!, 264.3749!)
        Me.xrCARGA_CARGADORA_NOM.Name = "xrCARGA_CARGADORA_NOM"
        Me.xrCARGA_CARGADORA_NOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_CARGADORA_NOM.SizeF = New System.Drawing.SizeF(173.2251!, 20.0!)
        Me.xrCARGA_CARGADORA_NOM.StylePriority.UseBorders = False
        Me.xrCARGA_CARGADORA_NOM.StylePriority.UseFont = False
        Me.xrCARGA_CARGADORA_NOM.StylePriority.UsePadding = False
        Me.xrCARGA_CARGADORA_NOM.StylePriority.UseTextAlignment = False
        Me.xrCARGA_CARGADORA_NOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel90
        '
        Me.XrLabel90.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel90.CanGrow = False
        Me.XrLabel90.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(484.6252!, 264.3749!)
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(43.23694!, 20.0!)
        Me.XrLabel90.StylePriority.UseBorders = False
        Me.XrLabel90.StylePriority.UseFont = False
        Me.XrLabel90.StylePriority.UsePadding = False
        Me.XrLabel90.StylePriority.UseTextAlignment = False
        Me.XrLabel90.Text = "Jiboa"
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrCARGA_CARGADORA_JIBOA
        '
        Me.xrCARGA_CARGADORA_JIBOA.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_CARGADORA_JIBOA.CanGrow = False
        Me.xrCARGA_CARGADORA_JIBOA.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_CARGADORA_JIBOA.LocationFloat = New DevExpress.Utils.PointFloat(527.8622!, 264.3749!)
        Me.xrCARGA_CARGADORA_JIBOA.Name = "xrCARGA_CARGADORA_JIBOA"
        Me.xrCARGA_CARGADORA_JIBOA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_CARGADORA_JIBOA.SizeF = New System.Drawing.SizeF(21.8!, 20.0!)
        Me.xrCARGA_CARGADORA_JIBOA.StylePriority.UseBorders = False
        Me.xrCARGA_CARGADORA_JIBOA.StylePriority.UseFont = False
        Me.xrCARGA_CARGADORA_JIBOA.StylePriority.UsePadding = False
        Me.xrCARGA_CARGADORA_JIBOA.StylePriority.UseTextAlignment = False
        Me.xrCARGA_CARGADORA_JIBOA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel92
        '
        Me.XrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel92.CanGrow = False
        Me.XrLabel92.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(549.6622!, 264.3749!)
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(59.57574!, 20.0!)
        Me.XrLabel92.StylePriority.UseBorders = False
        Me.XrLabel92.StylePriority.UseFont = False
        Me.XrLabel92.StylePriority.UsePadding = False
        Me.XrLabel92.StylePriority.UseTextAlignment = False
        Me.XrLabel92.Text = "Particular"
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrCARGA_CARGADORA_PARTICULAR
        '
        Me.xrCARGA_CARGADORA_PARTICULAR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrCARGA_CARGADORA_PARTICULAR.CanGrow = False
        Me.xrCARGA_CARGADORA_PARTICULAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrCARGA_CARGADORA_PARTICULAR.LocationFloat = New DevExpress.Utils.PointFloat(609.2379!, 264.3749!)
        Me.xrCARGA_CARGADORA_PARTICULAR.Name = "xrCARGA_CARGADORA_PARTICULAR"
        Me.xrCARGA_CARGADORA_PARTICULAR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCARGA_CARGADORA_PARTICULAR.SizeF = New System.Drawing.SizeF(21.87476!, 20.0!)
        Me.xrCARGA_CARGADORA_PARTICULAR.StylePriority.UseBorders = False
        Me.xrCARGA_CARGADORA_PARTICULAR.StylePriority.UseFont = False
        Me.xrCARGA_CARGADORA_PARTICULAR.StylePriority.UsePadding = False
        Me.xrCARGA_CARGADORA_PARTICULAR.StylePriority.UseTextAlignment = False
        Me.xrCARGA_CARGADORA_PARTICULAR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel64
        '
        Me.XrLabel64.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel64.CanGrow = False
        Me.XrLabel64.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(0!, 304.3749!)
        Me.XrLabel64.Multiline = True
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(55.08336!, 59.99994!)
        Me.XrLabel64.StylePriority.UseBorders = False
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UsePadding = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.Text = "TRANS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PORTE"
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrTipoTransporte
        '
        Me.xrTipoTransporte.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTipoTransporte.CanGrow = False
        Me.xrTipoTransporte.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrTipoTransporte.LocationFloat = New DevExpress.Utils.PointFloat(55.08337!, 304.3749!)
        Me.xrTipoTransporte.Name = "xrTipoTransporte"
        Me.xrTipoTransporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrTipoTransporte.SizeF = New System.Drawing.SizeF(118.0203!, 59.99994!)
        Me.xrTipoTransporte.StylePriority.UseBorders = False
        Me.xrTipoTransporte.StylePriority.UseFont = False
        Me.xrTipoTransporte.StylePriority.UsePadding = False
        Me.xrTipoTransporte.StylePriority.UseTextAlignment = False
        Me.xrTipoTransporte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel85
        '
        Me.XrLabel85.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel85.CanGrow = False
        Me.XrLabel85.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(55.08334!, 264.3749!)
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(96.89581!, 20.0!)
        Me.XrLabel85.StylePriority.UseBorders = False
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UsePadding = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = "CARGADORA"
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrROZA_COSECHADORA_CODI
        '
        Me.xrROZA_COSECHADORA_CODI.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrROZA_COSECHADORA_CODI.CanGrow = False
        Me.xrROZA_COSECHADORA_CODI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrROZA_COSECHADORA_CODI.LocationFloat = New DevExpress.Utils.PointFloat(212.2706!, 204.3749!)
        Me.xrROZA_COSECHADORA_CODI.Name = "xrROZA_COSECHADORA_CODI"
        Me.xrROZA_COSECHADORA_CODI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_COSECHADORA_CODI.SizeF = New System.Drawing.SizeF(24.58328!, 20.0!)
        Me.xrROZA_COSECHADORA_CODI.StylePriority.UseBorders = False
        Me.xrROZA_COSECHADORA_CODI.StylePriority.UseFont = False
        Me.xrROZA_COSECHADORA_CODI.StylePriority.UsePadding = False
        Me.xrROZA_COSECHADORA_CODI.StylePriority.UseTextAlignment = False
        Me.xrROZA_COSECHADORA_CODI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(410.0787!, 264.3749!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(56.01801!, 20.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UsePadding = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Productor"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrROZA_MANUAL_PARTICULAR
        '
        Me.xrROZA_MANUAL_PARTICULAR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_MANUAL_PARTICULAR.CanGrow = False
        Me.xrROZA_MANUAL_PARTICULAR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_MANUAL_PARTICULAR.LocationFloat = New DevExpress.Utils.PointFloat(609.2379!, 184.3749!)
        Me.xrROZA_MANUAL_PARTICULAR.Name = "xrROZA_MANUAL_PARTICULAR"
        Me.xrROZA_MANUAL_PARTICULAR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_MANUAL_PARTICULAR.SizeF = New System.Drawing.SizeF(21.87476!, 20.0!)
        Me.xrROZA_MANUAL_PARTICULAR.StylePriority.UseBorders = False
        Me.xrROZA_MANUAL_PARTICULAR.StylePriority.UseFont = False
        Me.xrROZA_MANUAL_PARTICULAR.StylePriority.UsePadding = False
        Me.xrROZA_MANUAL_PARTICULAR.StylePriority.UseTextAlignment = False
        Me.xrROZA_MANUAL_PARTICULAR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrROZA_MANUAL_CODI
        '
        Me.xrROZA_MANUAL_CODI.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrROZA_MANUAL_CODI.CanGrow = False
        Me.xrROZA_MANUAL_CODI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrROZA_MANUAL_CODI.LocationFloat = New DevExpress.Utils.PointFloat(212.2706!, 184.3749!)
        Me.xrROZA_MANUAL_CODI.Name = "xrROZA_MANUAL_CODI"
        Me.xrROZA_MANUAL_CODI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_MANUAL_CODI.SizeF = New System.Drawing.SizeF(24.58313!, 20.0!)
        Me.xrROZA_MANUAL_CODI.StylePriority.UseBorders = False
        Me.xrROZA_MANUAL_CODI.StylePriority.UseFont = False
        Me.xrROZA_MANUAL_CODI.StylePriority.UsePadding = False
        Me.xrROZA_MANUAL_CODI.StylePriority.UseTextAlignment = False
        Me.xrROZA_MANUAL_CODI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrROZA_MANUAL_NOM
        '
        Me.xrROZA_MANUAL_NOM.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrROZA_MANUAL_NOM.CanGrow = False
        Me.xrROZA_MANUAL_NOM.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrROZA_MANUAL_NOM.LocationFloat = New DevExpress.Utils.PointFloat(236.8539!, 184.3749!)
        Me.xrROZA_MANUAL_NOM.Name = "xrROZA_MANUAL_NOM"
        Me.xrROZA_MANUAL_NOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.xrROZA_MANUAL_NOM.SizeF = New System.Drawing.SizeF(229.2431!, 20.0!)
        Me.xrROZA_MANUAL_NOM.StylePriority.UseBorders = False
        Me.xrROZA_MANUAL_NOM.StylePriority.UseFont = False
        Me.xrROZA_MANUAL_NOM.StylePriority.UsePadding = False
        Me.xrROZA_MANUAL_NOM.StylePriority.UseTextAlignment = False
        Me.xrROZA_MANUAL_NOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel60
        '
        Me.XrLabel60.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel60.CanGrow = False
        Me.XrLabel60.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(466.097!, 184.3749!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(61.76523!, 20.0!)
        Me.XrLabel60.StylePriority.UseBorders = False
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UsePadding = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "Productor"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrROZA_MANUAL_PRODUCTOR
        '
        Me.xrROZA_MANUAL_PRODUCTOR.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_MANUAL_PRODUCTOR.CanGrow = False
        Me.xrROZA_MANUAL_PRODUCTOR.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_MANUAL_PRODUCTOR.LocationFloat = New DevExpress.Utils.PointFloat(527.8622!, 184.3749!)
        Me.xrROZA_MANUAL_PRODUCTOR.Name = "xrROZA_MANUAL_PRODUCTOR"
        Me.xrROZA_MANUAL_PRODUCTOR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_MANUAL_PRODUCTOR.SizeF = New System.Drawing.SizeF(21.79993!, 20.0!)
        Me.xrROZA_MANUAL_PRODUCTOR.StylePriority.UseBorders = False
        Me.xrROZA_MANUAL_PRODUCTOR.StylePriority.UseFont = False
        Me.xrROZA_MANUAL_PRODUCTOR.StylePriority.UsePadding = False
        Me.xrROZA_MANUAL_PRODUCTOR.StylePriority.UseTextAlignment = False
        Me.xrROZA_MANUAL_PRODUCTOR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel67
        '
        Me.XrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel67.CanGrow = False
        Me.XrLabel67.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(173.1039!, 204.3749!)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(39.16669!, 20.0!)
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UsePadding = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "COD.:"
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel65
        '
        Me.XrLabel65.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel65.CanGrow = False
        Me.XrLabel65.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(55.08335!, 204.3749!)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(96.89581!, 20.0!)
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UsePadding = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "COSECHADORA"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel57.CanGrow = False
        Me.XrLabel57.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(173.1039!, 184.3749!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(39.16669!, 20.0!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UsePadding = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "COD.:"
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel62
        '
        Me.XrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel62.CanGrow = False
        Me.XrLabel62.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(549.6622!, 184.3749!)
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(59.57575!, 20.0!)
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UsePadding = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.Text = "Particular"
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrROZA_MANUAL
        '
        Me.xrROZA_MANUAL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_MANUAL.CanGrow = False
        Me.xrROZA_MANUAL.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_MANUAL.LocationFloat = New DevExpress.Utils.PointFloat(151.9789!, 184.3749!)
        Me.xrROZA_MANUAL.Name = "xrROZA_MANUAL"
        Me.xrROZA_MANUAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_MANUAL.SizeF = New System.Drawing.SizeF(21.12497!, 20.0!)
        Me.xrROZA_MANUAL.StylePriority.UseBorders = False
        Me.xrROZA_MANUAL.StylePriority.UseFont = False
        Me.xrROZA_MANUAL.StylePriority.UsePadding = False
        Me.xrROZA_MANUAL.StylePriority.UseTextAlignment = False
        Me.xrROZA_MANUAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.CanGrow = False
        Me.XrLabel55.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(55.08337!, 184.3749!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(96.89582!, 20.0!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UsePadding = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "MANUAL"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(0!, 184.3749!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(55.08336!, 60.00002!)
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UsePadding = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "ROZA"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel52
        '
        Me.XrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel52.CanGrow = False
        Me.XrLabel52.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(291.0205!, 344.3749!)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(98.29967!, 20.0!)
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UsePadding = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "MECANIZADA"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel53.CanGrow = False
        Me.XrLabel53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.CANA_PICADA")})
        Me.XrLabel53.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(389.3202!, 344.3749!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(20.75845!, 20.0!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UsePadding = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "XrLabel53"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel49.CanGrow = False
        Me.XrLabel49.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(291.0205!, 324.3749!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(98.29967!, 20.0!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UsePadding = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "LARGA/ROLLO"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel47
        '
        Me.XrLabel47.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel47.CanGrow = False
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.CANA_CORTA")})
        Me.XrLabel47.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(389.3203!, 304.3749!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(20.75839!, 20.0!)
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UsePadding = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "XrLabel47"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel46.CanGrow = False
        Me.XrLabel46.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(291.0205!, 304.3749!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(98.29968!, 20.0!)
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UsePadding = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "PICADA/CORTA"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrROZA_COSECHADORA
        '
        Me.xrROZA_COSECHADORA.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrROZA_COSECHADORA.CanGrow = False
        Me.xrROZA_COSECHADORA.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrROZA_COSECHADORA.LocationFloat = New DevExpress.Utils.PointFloat(151.9789!, 204.3749!)
        Me.xrROZA_COSECHADORA.Name = "xrROZA_COSECHADORA"
        Me.xrROZA_COSECHADORA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrROZA_COSECHADORA.SizeF = New System.Drawing.SizeF(21.125!, 20.0!)
        Me.xrROZA_COSECHADORA.StylePriority.UseBorders = False
        Me.xrROZA_COSECHADORA.StylePriority.UseFont = False
        Me.xrROZA_COSECHADORA.StylePriority.UsePadding = False
        Me.xrROZA_COSECHADORA.StylePriority.UseTextAlignment = False
        Me.xrROZA_COSECHADORA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel45
        '
        Me.XrLabel45.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel45.CanGrow = False
        Me.XrLabel45.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(173.104!, 304.3749!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(117.9165!, 59.99997!)
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UsePadding = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "FORMA DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COSECHA"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel40.BorderColor = System.Drawing.Color.Black
        Me.XrLabel40.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel40.BorderWidth = 1.0!
        Me.XrLabel40.CanGrow = False
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel40.ForeColor = System.Drawing.Color.Black
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(631.1129!, 112.5833!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(138.8871!, 51.79164!)
        Me.XrLabel40.StylePriority.UseBackColor = False
        Me.XrLabel40.StylePriority.UseBorderColor = False
        Me.XrLabel40.StylePriority.UseBorderDashStyle = False
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseBorderWidth = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UsePadding = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "[NOMBRE_MADURANTE]"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel39.BorderColor = System.Drawing.Color.Black
        Me.XrLabel39.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel39.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel39.BorderWidth = 1.0!
        Me.XrLabel39.CanGrow = False
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.ForeColor = System.Drawing.Color.Black
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(631.1129!, 87.58327!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(138.8871!, 25.0!)
        Me.XrLabel39.StylePriority.UseBackColor = False
        Me.XrLabel39.StylePriority.UseBorderColor = False
        Me.XrLabel39.StylePriority.UseBorderDashStyle = False
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseBorderWidth = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseForeColor = False
        Me.XrLabel39.StylePriority.UsePadding = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "NOMBRE DE MADURANTE"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.QUEMANOPROG")})
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(751.25!, 229.3749!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(18.74994!, 26.79167!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorderDashStyle = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(631.1129!, 204.3749!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(120.137!, 25.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorderDashStyle = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "QUEMA PROGRAMADA"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel31.BorderColor = System.Drawing.Color.Black
        Me.XrLabel31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.BorderWidth = 1.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel31.ForeColor = System.Drawing.Color.Black
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(291.0208!, 483.3332!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(119.0581!, 22.0!)
        Me.XrLabel31.StylePriority.UseBackColor = False
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseBorderDashStyle = False
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseBorderWidth = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel30.BorderColor = System.Drawing.Color.Black
        Me.XrLabel30.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.BorderWidth = 1.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel30.ForeColor = System.Drawing.Color.Black
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(196.021!, 483.3332!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(94.99983!, 22.0!)
        Me.XrLabel30.StylePriority.UseBackColor = False
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseBorderDashStyle = False
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseBorderWidth = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UsePadding = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel50.CanGrow = False
        Me.XrLabel50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PROFORMA.CANA_LARGA")})
        Me.XrLabel50.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(389.3202!, 324.3749!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(20.75845!, 20.0!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UsePadding = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "XrLabel50"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Proforma
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
        Me.DataAdapter = Me.ProformaTableAdapter1
        Me.DataMember = "PROFORMA"
        Me.DataSource = Me.DS_SIGESTA1
        Me.Margins = New System.Drawing.Printing.Margins(39, 41, 2, 26)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.DS_SIGESTA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DS_SIGESTA1 As SISPACAL.DL.DS_SIGESTA
    Friend WithEvents ProformaTableAdapter1 As SISPACAL.DL.DS_SIGESTATableAdapters.PROFORMATableAdapter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrEDAD_LOTE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents xrCARGA_CARGADORA_PRODUCTOR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrQUEMA_MES As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrQUEMA_ANIO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrQUEMA_HORA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_DIA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_MES As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_ANIO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_HORA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrQUEMA_DIA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable9 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrROZA_COSECHADORA_PRODUCTOR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTecnico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_OPERADOR_CODI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_OPERADOR_NOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel98 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel104 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_OPERADOR_CODI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_OPERADOR_NOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel101 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel95 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable10 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow22 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xtrNOMBRE_MES As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrNOMBRE_USUARIO As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_COSECHADORA_JIBOA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_COSECHADORA_PARTICULAR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_MANUAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_MANUAL_CODI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_MANUAL_NOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_MANUAL_PRODUCTOR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_COSECHADORA_NOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_MANUAL_PARTICULAR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_CARGADORA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_CARGADORA_CODI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_CARGADORA_NOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_CARGADORA_JIBOA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCARGA_CARGADORA_PARTICULAR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTipoTransporte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_COSECHADORA_CODI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_MANUAL_PARTICULAR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_MANUAL_CODI As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_MANUAL_NOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_MANUAL_PRODUCTOR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_MANUAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrROZA_COSECHADORA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrES_QUERQUEO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrES_BARRIDO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrHacienda As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFrenteQuerqueo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
End Class
