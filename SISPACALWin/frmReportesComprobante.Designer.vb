<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesComprobante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.chkFacturaContinua = New System.Windows.Forms.CheckBox()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.CbxTIPO_PLANILLA1 = New SISPACAL.WinUC.cbxTIPO_PLANILLA()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVerComprobante = New System.Windows.Forms.Button()
        Me.btnListadoComprobantes = New System.Windows.Forms.Button()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.rbtRango = New System.Windows.Forms.RadioButton()
        Me.spNO_DOCTOini = New DevExpress.XtraEditors.SpinEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.spNO_DOCTOfin = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.spNO_DOCTOini.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spNO_DOCTOfin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Zafra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Catorcena"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Planilla"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de Documento"
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(141, 120)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(327, 21)
        Me.cbxTipoDocumento.TabIndex = 7
        '
        'chkFacturaContinua
        '
        Me.chkFacturaContinua.AutoSize = True
        Me.chkFacturaContinua.Checked = True
        Me.chkFacturaContinua.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFacturaContinua.Location = New System.Drawing.Point(474, 124)
        Me.chkFacturaContinua.Name = "chkFacturaContinua"
        Me.chkFacturaContinua.Size = New System.Drawing.Size(118, 17)
        Me.chkFacturaContinua.TabIndex = 13
        Me.chkFacturaContinua.Text = "Es factura continua"
        Me.chkFacturaContinua.UseVisualStyleBackColor = True
        Me.chkFacturaContinua.Visible = False
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(12, 97)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(112, 13)
        Me.lblRangoCompensacion.TabIndex = 53
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(141, 93)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(327, 21)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 54
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'CbxTIPO_PLANILLA1
        '
        Me.CbxTIPO_PLANILLA1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PLANILLA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PLANILLA1.Location = New System.Drawing.Point(141, 66)
        Me.CbxTIPO_PLANILLA1.Name = "CbxTIPO_PLANILLA1"
        Me.CbxTIPO_PLANILLA1.Size = New System.Drawing.Size(327, 21)
        Me.CbxTIPO_PLANILLA1.TabIndex = 5
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(141, 40)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(109, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 3
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(141, 14)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(109, 21)
        Me.CbxZAFRA1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(689, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(201, 34)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVerComprobante
        '
        Me.btnVerComprobante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerComprobante.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerComprobante.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnVerComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerComprobante.Location = New System.Drawing.Point(689, 69)
        Me.btnVerComprobante.Name = "btnVerComprobante"
        Me.btnVerComprobante.Size = New System.Drawing.Size(201, 32)
        Me.btnVerComprobante.TabIndex = 11
        Me.btnVerComprobante.Text = "Imprimir comprobantes"
        Me.btnVerComprobante.UseVisualStyleBackColor = False
        '
        'btnListadoComprobantes
        '
        Me.btnListadoComprobantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListadoComprobantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListadoComprobantes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoComprobantes.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnListadoComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadoComprobantes.Location = New System.Drawing.Point(689, 113)
        Me.btnListadoComprobantes.Name = "btnListadoComprobantes"
        Me.btnListadoComprobantes.Size = New System.Drawing.Size(201, 32)
        Me.btnListadoComprobantes.TabIndex = 55
        Me.btnListadoComprobantes.Text = "Imprimir listado"
        Me.btnListadoComprobantes.UseVisualStyleBackColor = False
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Location = New System.Drawing.Point(15, 165)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(89, 17)
        Me.rbtTodos.TabIndex = 57
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Imprimir todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'rbtRango
        '
        Me.rbtRango.AutoSize = True
        Me.rbtRango.Location = New System.Drawing.Point(15, 188)
        Me.rbtRango.Name = "rbtRango"
        Me.rbtRango.Size = New System.Drawing.Size(90, 17)
        Me.rbtRango.TabIndex = 58
        Me.rbtRango.TabStop = True
        Me.rbtRango.Text = "Imprimir rango"
        Me.rbtRango.UseVisualStyleBackColor = True
        '
        'spNO_DOCTOini
        '
        Me.spNO_DOCTOini.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spNO_DOCTOini.Location = New System.Drawing.Point(185, 187)
        Me.spNO_DOCTOini.Name = "spNO_DOCTOini"
        Me.spNO_DOCTOini.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spNO_DOCTOini.Size = New System.Drawing.Size(100, 20)
        Me.spNO_DOCTOini.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Del:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "al:"
        '
        'spNO_DOCTOfin
        '
        Me.spNO_DOCTOfin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spNO_DOCTOfin.Location = New System.Drawing.Point(330, 187)
        Me.spNO_DOCTOfin.Name = "spNO_DOCTOfin"
        Me.spNO_DOCTOfin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spNO_DOCTOfin.Size = New System.Drawing.Size(100, 20)
        Me.spNO_DOCTOfin.TabIndex = 61
        '
        'frmReportesComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 491)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.spNO_DOCTOfin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.spNO_DOCTOini)
        Me.Controls.Add(Me.rbtRango)
        Me.Controls.Add(Me.rbtTodos)
        Me.Controls.Add(Me.btnListadoComprobantes)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.chkFacturaContinua)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVerComprobante)
        Me.Controls.Add(Me.cbxTipoDocumento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxTIPO_PLANILLA1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportesComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes de Ley"
        CType(Me.spNO_DOCTOini.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spNO_DOCTOfin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxTIPO_PLANILLA1 As SISPACAL.WinUC.cbxTIPO_PLANILLA
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents btnVerComprobante As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chkFacturaContinua As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
    Friend WithEvents btnListadoComprobantes As System.Windows.Forms.Button
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtRango As System.Windows.Forms.RadioButton
    Friend WithEvents spNO_DOCTOini As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents spNO_DOCTOfin As DevExpress.XtraEditors.SpinEdit
End Class
