<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlComprobantes
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_COMPROBANTES1 = New SISPACAL.DL.DS_COMPROBANTES()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_PLANILLA_COMPROB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCATORCENA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_PLANILLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_TIPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNO_DOCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LISTADO_COMPROBANTESTableAdapter1 = New SISPACAL.DL.DS_COMPROBANTESTableAdapters.LISTADO_COMPROBANTESTableAdapter()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxTIPO_PLANILLA1 = New SISPACAL.WinUC.cbxTIPO_PLANILLA()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerarNuevoComprobante = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAnularComprobantes = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_COMPROBANTES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.Location = New System.Drawing.Point(0, 187)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1020, 449)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "LISTADO_COMPROBANTES"
        Me.BindingSource1.DataSource = Me.DS_COMPROBANTES1
        '
        'DS_COMPROBANTES1
        '
        Me.DS_COMPROBANTES1.DataSetName = "DS_COMPROBANTES"
        Me.DS_COMPROBANTES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PLANILLA_COMPROB, Me.colCATORCENA, Me.colTIPO_PLANILLA, Me.colCODIGO, Me.colNOMBRE_CLIENTE, Me.colNOMBRE_TIPO, Me.colSERIE, Me.colNO_DOCTO, Me.colESTADO, Me.colTOTAL})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colID_PLANILLA_COMPROB
        '
        Me.colID_PLANILLA_COMPROB.Caption = "ID."
        Me.colID_PLANILLA_COMPROB.FieldName = "ID_PLANILLA_COMPROB"
        Me.colID_PLANILLA_COMPROB.Name = "colID_PLANILLA_COMPROB"
        Me.colID_PLANILLA_COMPROB.Visible = True
        Me.colID_PLANILLA_COMPROB.VisibleIndex = 1
        Me.colID_PLANILLA_COMPROB.Width = 50
        '
        'colCATORCENA
        '
        Me.colCATORCENA.Caption = "Catorcena"
        Me.colCATORCENA.FieldName = "CATORCENA"
        Me.colCATORCENA.Name = "colCATORCENA"
        Me.colCATORCENA.Visible = True
        Me.colCATORCENA.VisibleIndex = 2
        Me.colCATORCENA.Width = 70
        '
        'colTIPO_PLANILLA
        '
        Me.colTIPO_PLANILLA.Caption = "Planilla"
        Me.colTIPO_PLANILLA.FieldName = "TIPO_PLANILLA"
        Me.colTIPO_PLANILLA.Name = "colTIPO_PLANILLA"
        Me.colTIPO_PLANILLA.Visible = True
        Me.colTIPO_PLANILLA.VisibleIndex = 3
        Me.colTIPO_PLANILLA.Width = 120
        '
        'colCODIGO
        '
        Me.colCODIGO.Caption = "Código"
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 4
        Me.colCODIGO.Width = 51
        '
        'colNOMBRE_CLIENTE
        '
        Me.colNOMBRE_CLIENTE.Caption = "Nombre"
        Me.colNOMBRE_CLIENTE.FieldName = "NOMBRE_CLIENTE"
        Me.colNOMBRE_CLIENTE.Name = "colNOMBRE_CLIENTE"
        Me.colNOMBRE_CLIENTE.Visible = True
        Me.colNOMBRE_CLIENTE.VisibleIndex = 5
        Me.colNOMBRE_CLIENTE.Width = 200
        '
        'colNOMBRE_TIPO
        '
        Me.colNOMBRE_TIPO.Caption = "Tipo comprobante"
        Me.colNOMBRE_TIPO.FieldName = "NOMBRE_TIPO"
        Me.colNOMBRE_TIPO.Name = "colNOMBRE_TIPO"
        Me.colNOMBRE_TIPO.Visible = True
        Me.colNOMBRE_TIPO.VisibleIndex = 6
        Me.colNOMBRE_TIPO.Width = 106
        '
        'colSERIE
        '
        Me.colSERIE.Caption = "Serie"
        Me.colSERIE.FieldName = "SERIE"
        Me.colSERIE.Name = "colSERIE"
        Me.colSERIE.Visible = True
        Me.colSERIE.VisibleIndex = 7
        Me.colSERIE.Width = 70
        '
        'colNO_DOCTO
        '
        Me.colNO_DOCTO.Caption = "N° Documento"
        Me.colNO_DOCTO.FieldName = "NO_DOCTO"
        Me.colNO_DOCTO.Name = "colNO_DOCTO"
        Me.colNO_DOCTO.Visible = True
        Me.colNO_DOCTO.VisibleIndex = 8
        Me.colNO_DOCTO.Width = 84
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "Estado"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 9
        Me.colESTADO.Width = 60
        '
        'colTOTAL
        '
        Me.colTOTAL.Caption = "Total"
        Me.colTOTAL.DisplayFormat.FormatString = "#,##0.00"
        Me.colTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTOTAL.FieldName = "TOTAL"
        Me.colTOTAL.Name = "colTOTAL"
        Me.colTOTAL.Visible = True
        Me.colTOTAL.VisibleIndex = 10
        Me.colTOTAL.Width = 91
        '
        'LISTADO_COMPROBANTESTableAdapter1
        '
        Me.LISTADO_COMPROBANTESTableAdapter1.ClearBeforeFill = True
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(142, 91)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(327, 21)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 64
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(13, 95)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(112, 13)
        Me.lblRangoCompensacion.TabIndex = 63
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(142, 118)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(327, 21)
        Me.cbxTipoDocumento.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Tipo de Documento"
        '
        'CbxTIPO_PLANILLA1
        '
        Me.CbxTIPO_PLANILLA1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PLANILLA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PLANILLA1.Location = New System.Drawing.Point(142, 64)
        Me.CbxTIPO_PLANILLA1.Name = "CbxTIPO_PLANILLA1"
        Me.CbxTIPO_PLANILLA1.Size = New System.Drawing.Size(327, 21)
        Me.CbxTIPO_PLANILLA1.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Tipo de Planilla"
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(142, 38)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(109, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Catorcena"
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(142, 12)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(109, 21)
        Me.CbxZAFRA1.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Zafra"
        '
        'btnGenerarNuevoComprobante
        '
        Me.btnGenerarNuevoComprobante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarNuevoComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerarNuevoComprobante.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarNuevoComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarNuevoComprobante.Location = New System.Drawing.Point(789, 91)
        Me.btnGenerarNuevoComprobante.Name = "btnGenerarNuevoComprobante"
        Me.btnGenerarNuevoComprobante.Size = New System.Drawing.Size(219, 32)
        Me.btnGenerarNuevoComprobante.TabIndex = 67
        Me.btnGenerarNuevoComprobante.Text = "Generar nuevo comprobante"
        Me.btnGenerarNuevoComprobante.UseVisualStyleBackColor = False
        Me.btnGenerarNuevoComprobante.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(789, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(219, 34)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAnularComprobantes
        '
        Me.btnAnularComprobantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnularComprobantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnularComprobantes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnularComprobantes.Location = New System.Drawing.Point(789, 54)
        Me.btnAnularComprobantes.Name = "btnAnularComprobantes"
        Me.btnAnularComprobantes.Size = New System.Drawing.Size(219, 32)
        Me.btnAnularComprobantes.TabIndex = 65
        Me.btnAnularComprobantes.Text = "Anular comprobantes"
        Me.btnAnularComprobantes.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(16, 149)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(219, 32)
        Me.btnBuscar.TabIndex = 68
        Me.btnBuscar.Text = "Ver comprobantes"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'frmControlComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 636)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnGenerarNuevoComprobante)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnularComprobantes)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.cbxTipoDocumento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxTIPO_PLANILLA1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmControlComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de comprobantes"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_COMPROBANTES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DS_COMPROBANTES1 As SISPACAL.DL.DS_COMPROBANTES
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colID_PLANILLA_COMPROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCATORCENA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_PLANILLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_TIPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_DOCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LISTADO_COMPROBANTESTableAdapter1 As SISPACAL.DL.DS_COMPROBANTESTableAdapters.LISTADO_COMPROBANTESTableAdapter
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
    Friend WithEvents cbxTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbxTIPO_PLANILLA1 As SISPACAL.WinUC.cbxTIPO_PLANILLA
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarNuevoComprobante As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAnularComprobantes As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
