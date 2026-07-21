<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmisionComprobantes
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxCOMPROB_NUMERACION1 = New SISPACAL.WinUC.cbxCOMPROB_NUMERACION()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.chkFacturaContinua = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVerComprobante = New System.Windows.Forms.Button()
        Me.txtNO_DOCUMENTO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxTIPO_PLANILLA1 = New SISPACAL.WinUC.cbxTIPO_PLANILLA()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dteFechaComprobante = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dteFechaComprobante.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Serie"
        '
        'cbxCOMPROB_NUMERACION1
        '
        Me.cbxCOMPROB_NUMERACION1.AllowFindEntityType = Nothing
        Me.cbxCOMPROB_NUMERACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCOMPROB_NUMERACION1.Location = New System.Drawing.Point(140, 170)
        Me.cbxCOMPROB_NUMERACION1.Name = "cbxCOMPROB_NUMERACION1"
        Me.cbxCOMPROB_NUMERACION1.Size = New System.Drawing.Size(327, 21)
        Me.cbxCOMPROB_NUMERACION1.TabIndex = 72
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(140, 91)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(327, 21)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 71
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(11, 95)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(112, 13)
        Me.lblRangoCompensacion.TabIndex = 70
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'chkFacturaContinua
        '
        Me.chkFacturaContinua.AutoSize = True
        Me.chkFacturaContinua.Checked = True
        Me.chkFacturaContinua.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFacturaContinua.Location = New System.Drawing.Point(473, 147)
        Me.chkFacturaContinua.Name = "chkFacturaContinua"
        Me.chkFacturaContinua.Size = New System.Drawing.Size(118, 17)
        Me.chkFacturaContinua.TabIndex = 69
        Me.chkFacturaContinua.Text = "Es factura continua"
        Me.chkFacturaContinua.UseVisualStyleBackColor = True
        Me.chkFacturaContinua.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(620, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(201, 34)
        Me.btnSalir.TabIndex = 68
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
        Me.btnVerComprobante.Location = New System.Drawing.Point(620, 62)
        Me.btnVerComprobante.Name = "btnVerComprobante"
        Me.btnVerComprobante.Size = New System.Drawing.Size(201, 32)
        Me.btnVerComprobante.TabIndex = 67
        Me.btnVerComprobante.Text = "Emitir comprobantes"
        Me.btnVerComprobante.UseVisualStyleBackColor = False
        '
        'txtNO_DOCUMENTO
        '
        Me.txtNO_DOCUMENTO.Location = New System.Drawing.Point(140, 199)
        Me.txtNO_DOCUMENTO.Name = "txtNO_DOCUMENTO"
        Me.txtNO_DOCUMENTO.Size = New System.Drawing.Size(327, 20)
        Me.txtNO_DOCUMENTO.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "N° de Documento Inicial"
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(140, 143)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(327, 21)
        Me.cbxTipoDocumento.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Tipo de Documento"
        '
        'CbxTIPO_PLANILLA1
        '
        Me.CbxTIPO_PLANILLA1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PLANILLA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PLANILLA1.Location = New System.Drawing.Point(140, 64)
        Me.CbxTIPO_PLANILLA1.Name = "CbxTIPO_PLANILLA1"
        Me.CbxTIPO_PLANILLA1.Size = New System.Drawing.Size(327, 21)
        Me.CbxTIPO_PLANILLA1.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Tipo de Planilla"
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(140, 38)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(109, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Catorcena"
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(140, 12)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(109, 21)
        Me.CbxZAFRA1.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Zafra"
        '
        'dteFechaComprobante
        '
        Me.dteFechaComprobante.EditValue = Nothing
        Me.dteFechaComprobante.Location = New System.Drawing.Point(140, 118)
        Me.dteFechaComprobante.Name = "dteFechaComprobante"
        Me.dteFechaComprobante.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dteFechaComprobante.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.dteFechaComprobante.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dteFechaComprobante.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dteFechaComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaComprobante.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaComprobante.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaComprobante.Size = New System.Drawing.Size(149, 20)
        Me.dteFechaComprobante.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Fecha comprobante"
        '
        'frmEmisionComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 450)
        Me.Controls.Add(Me.dteFechaComprobante)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxCOMPROB_NUMERACION1)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.chkFacturaContinua)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVerComprobante)
        Me.Controls.Add(Me.txtNO_DOCUMENTO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxTipoDocumento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxTIPO_PLANILLA1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmisionComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de comprobantes de ley"
        CType(Me.dteFechaComprobante.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxCOMPROB_NUMERACION1 As SISPACAL.WinUC.cbxCOMPROB_NUMERACION
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
    Friend WithEvents chkFacturaContinua As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVerComprobante As System.Windows.Forms.Button
    Friend WithEvents txtNO_DOCUMENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbxTIPO_PLANILLA1 As SISPACAL.WinUC.cbxTIPO_PLANILLA
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dteFechaComprobante As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As Label
End Class
