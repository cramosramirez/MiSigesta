<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UcCriterios1 = New SISPACAL.ucCriterios()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.gOrdenCombustible = New System.Windows.Forms.GroupBox()
        Me.grdOrdenes = New System.Windows.Forms.DataGridView()
        Me.ORDENCOMBUSTIBLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVerReporte = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IDORDENCOMBUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAEMISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLACADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRESMOTORISTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_CREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gOrdenCombustible.SuspendLayout()
        CType(Me.grdOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDENCOMBUSTIBLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcCriterios1
        '
        Me.UcCriterios1.FECHA_CORTE = New Date(2014, 1, 24, 0, 0, 0, 0)
        Me.UcCriterios1.ID_ZAFRA = 0
        Me.UcCriterios1.Location = New System.Drawing.Point(0, 3)
        Me.UcCriterios1.Name = "UcCriterios1"
        Me.UcCriterios1.Size = New System.Drawing.Size(278, 91)
        Me.UcCriterios1.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1005, 493)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnActualizar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gOrdenCombustible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSalir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnVerReporte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcCriterios1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1005, 683)
        Me.SplitContainer1.SplitterDistance = 186
        Me.SplitContainer1.TabIndex = 2
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.SISPACAL.My.Resources.Resources.refresh_icon
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(836, 136)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(156, 32)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Actualizar Ordenes"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'gOrdenCombustible
        '
        Me.gOrdenCombustible.Controls.Add(Me.grdOrdenes)
        Me.gOrdenCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gOrdenCombustible.Location = New System.Drawing.Point(12, 12)
        Me.gOrdenCombustible.Name = "gOrdenCombustible"
        Me.gOrdenCombustible.Size = New System.Drawing.Size(761, 159)
        Me.gOrdenCombustible.TabIndex = 15
        Me.gOrdenCombustible.TabStop = False
        Me.gOrdenCombustible.Text = "Seleccione la Orden de Combustible que desea imprimir"
        '
        'grdOrdenes
        '
        Me.grdOrdenes.AllowUserToAddRows = False
        Me.grdOrdenes.AllowUserToDeleteRows = False
        Me.grdOrdenes.AutoGenerateColumns = False
        Me.grdOrdenes.BackgroundColor = System.Drawing.Color.White
        Me.grdOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDORDENCOMBUSDataGridViewTextBoxColumn, Me.FECHAEMISIONDataGridViewTextBoxColumn, Me.CODIGO, Me.PLACADataGridViewTextBoxColumn, Me.NOMBRESMOTORISTADataGridViewTextBoxColumn, Me.DUIDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn, Me.FECHA_CREA})
        Me.grdOrdenes.DataSource = Me.ORDENCOMBUSTIBLEBindingSource
        Me.grdOrdenes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdOrdenes.Location = New System.Drawing.Point(3, 29)
        Me.grdOrdenes.MultiSelect = False
        Me.grdOrdenes.Name = "grdOrdenes"
        Me.grdOrdenes.ReadOnly = True
        Me.grdOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrdenes.Size = New System.Drawing.Size(755, 127)
        Me.grdOrdenes.TabIndex = 0
        '
        'ORDENCOMBUSTIBLEBindingSource
        '
        Me.ORDENCOMBUSTIBLEBindingSource.DataSource = GetType(SISPACAL.EL.ORDEN_COMBUSTIBLE)
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(836, 23)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(156, 34)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerReporte.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerReporte.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnVerReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerReporte.Location = New System.Drawing.Point(836, 63)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(156, 32)
        Me.btnVerReporte.TabIndex = 13
        Me.btnVerReporte.Text = "Ver reporte"
        Me.btnVerReporte.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'IDORDENCOMBUSDataGridViewTextBoxColumn
        '
        Me.IDORDENCOMBUSDataGridViewTextBoxColumn.DataPropertyName = "ID_ORDEN_COMBUS"
        Me.IDORDENCOMBUSDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.IDORDENCOMBUSDataGridViewTextBoxColumn.Name = "IDORDENCOMBUSDataGridViewTextBoxColumn"
        Me.IDORDENCOMBUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDORDENCOMBUSDataGridViewTextBoxColumn.Width = 50
        '
        'FECHAEMISIONDataGridViewTextBoxColumn
        '
        Me.FECHAEMISIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_EMISION"
        Me.FECHAEMISIONDataGridViewTextBoxColumn.HeaderText = "Fecha emisión"
        Me.FECHAEMISIONDataGridViewTextBoxColumn.Name = "FECHAEMISIONDataGridViewTextBoxColumn"
        Me.FECHAEMISIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAEMISIONDataGridViewTextBoxColumn.Width = 80
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "Codigo Proveedor"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Width = 70
        '
        'PLACADataGridViewTextBoxColumn
        '
        Me.PLACADataGridViewTextBoxColumn.DataPropertyName = "PLACA"
        Me.PLACADataGridViewTextBoxColumn.HeaderText = "Placa"
        Me.PLACADataGridViewTextBoxColumn.Name = "PLACADataGridViewTextBoxColumn"
        Me.PLACADataGridViewTextBoxColumn.ReadOnly = True
        Me.PLACADataGridViewTextBoxColumn.Width = 70
        '
        'NOMBRESMOTORISTADataGridViewTextBoxColumn
        '
        Me.NOMBRESMOTORISTADataGridViewTextBoxColumn.DataPropertyName = "NOMBRES_MOTORISTA"
        Me.NOMBRESMOTORISTADataGridViewTextBoxColumn.HeaderText = "Nombre Motorista"
        Me.NOMBRESMOTORISTADataGridViewTextBoxColumn.Name = "NOMBRESMOTORISTADataGridViewTextBoxColumn"
        Me.NOMBRESMOTORISTADataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBRESMOTORISTADataGridViewTextBoxColumn.Width = 150
        '
        'DUIDataGridViewTextBoxColumn
        '
        Me.DUIDataGridViewTextBoxColumn.DataPropertyName = "DUI"
        Me.DUIDataGridViewTextBoxColumn.HeaderText = "Dui"
        Me.DUIDataGridViewTextBoxColumn.Name = "DUIDataGridViewTextBoxColumn"
        Me.DUIDataGridViewTextBoxColumn.ReadOnly = True
        Me.DUIDataGridViewTextBoxColumn.Width = 80
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTALDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALDataGridViewTextBoxColumn.Width = 70
        '
        'FECHA_CREA
        '
        Me.FECHA_CREA.DataPropertyName = "FECHA_CREA"
        Me.FECHA_CREA.HeaderText = "Fecha creación"
        Me.FECHA_CREA.Name = "FECHA_CREA"
        Me.FECHA_CREA.ReadOnly = True
        Me.FECHA_CREA.Width = 120
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 683)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportes"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gOrdenCombustible.ResumeLayout(False)
        CType(Me.grdOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDENCOMBUSTIBLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcCriterios1 As SISPACAL.ucCriterios
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVerReporte As System.Windows.Forms.Button
    Friend WithEvents gOrdenCombustible As System.Windows.Forms.GroupBox
    Friend WithEvents grdOrdenes As System.Windows.Forms.DataGridView
    Friend WithEvents ORDENCOMBUSTIBLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CODTRANSPORTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDORDENCOMBUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAEMISIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRESMOTORISTADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DUIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_CREA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
