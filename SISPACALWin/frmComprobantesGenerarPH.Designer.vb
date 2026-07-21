<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobantesGenerarPH
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtDirectorio = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarDirectorio = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarArchivos = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.rbtAnticipo = New System.Windows.Forms.RadioButton()
        Me.rbtComplemento = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtIncentivo = New System.Windows.Forms.RadioButton()
        Me.rbtCompensacion = New System.Windows.Forms.RadioButton()
        Me.rbtPlanillaCana = New System.Windows.Forms.RadioButton()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Catorcena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Zafra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Ingrese o seleccione el directorio de generación"
        '
        'txtDirectorio
        '
        Me.txtDirectorio.Location = New System.Drawing.Point(16, 216)
        Me.txtDirectorio.Name = "txtDirectorio"
        Me.txtDirectorio.Size = New System.Drawing.Size(379, 20)
        Me.txtDirectorio.TabIndex = 33
        '
        'btnSeleccionarDirectorio
        '
        Me.btnSeleccionarDirectorio.Location = New System.Drawing.Point(395, 214)
        Me.btnSeleccionarDirectorio.Name = "btnSeleccionarDirectorio"
        Me.btnSeleccionarDirectorio.Size = New System.Drawing.Size(23, 22)
        Me.btnSeleccionarDirectorio.TabIndex = 34
        Me.btnSeleccionarDirectorio.Text = "?"
        Me.btnSeleccionarDirectorio.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(614, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(151, 34)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGenerarArchivos
        '
        Me.btnGenerarArchivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarArchivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerarArchivos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarArchivos.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnGenerarArchivos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGenerarArchivos.Location = New System.Drawing.Point(614, 62)
        Me.btnGenerarArchivos.Name = "btnGenerarArchivos"
        Me.btnGenerarArchivos.Size = New System.Drawing.Size(151, 64)
        Me.btnGenerarArchivos.TabIndex = 30
        Me.btnGenerarArchivos.Text = "Generar archivos para PH"
        Me.btnGenerarArchivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGenerarArchivos.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(767, 67)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(173, 32)
        Me.btnGenerar.TabIndex = 30
        Me.btnGenerar.Text = "Generar archivos"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'rbtAnticipo
        '
        Me.rbtAnticipo.AutoSize = True
        Me.rbtAnticipo.Location = New System.Drawing.Point(102, 19)
        Me.rbtAnticipo.Name = "rbtAnticipo"
        Me.rbtAnticipo.Size = New System.Drawing.Size(63, 17)
        Me.rbtAnticipo.TabIndex = 38
        Me.rbtAnticipo.TabStop = True
        Me.rbtAnticipo.Text = "Anticipo"
        Me.rbtAnticipo.UseVisualStyleBackColor = True
        '
        'rbtComplemento
        '
        Me.rbtComplemento.AutoSize = True
        Me.rbtComplemento.Location = New System.Drawing.Point(171, 19)
        Me.rbtComplemento.Name = "rbtComplemento"
        Me.rbtComplemento.Size = New System.Drawing.Size(141, 17)
        Me.rbtComplemento.TabIndex = 39
        Me.rbtComplemento.TabStop = True
        Me.rbtComplemento.Text = "Complemento Valor Final"
        Me.rbtComplemento.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtIncentivo)
        Me.GroupBox1.Controls.Add(Me.rbtCompensacion)
        Me.GroupBox1.Controls.Add(Me.rbtPlanillaCana)
        Me.GroupBox1.Controls.Add(Me.rbtAnticipo)
        Me.GroupBox1.Controls.Add(Me.rbtComplemento)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 53)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'rbtIncentivo
        '
        Me.rbtIncentivo.AutoSize = True
        Me.rbtIncentivo.Location = New System.Drawing.Point(487, 18)
        Me.rbtIncentivo.Name = "rbtIncentivo"
        Me.rbtIncentivo.Size = New System.Drawing.Size(69, 17)
        Me.rbtIncentivo.TabIndex = 43
        Me.rbtIncentivo.TabStop = True
        Me.rbtIncentivo.Text = "Incentivo"
        Me.rbtIncentivo.UseVisualStyleBackColor = True
        '
        'rbtCompensacion
        '
        Me.rbtCompensacion.AutoSize = True
        Me.rbtCompensacion.Location = New System.Drawing.Point(318, 18)
        Me.rbtCompensacion.Name = "rbtCompensacion"
        Me.rbtCompensacion.Size = New System.Drawing.Size(163, 17)
        Me.rbtCompensacion.TabIndex = 42
        Me.rbtCompensacion.TabStop = True
        Me.rbtCompensacion.Text = "Compensacion Entrega Caña"
        Me.rbtCompensacion.UseVisualStyleBackColor = True
        '
        'rbtPlanillaCana
        '
        Me.rbtPlanillaCana.AutoSize = True
        Me.rbtPlanillaCana.Location = New System.Drawing.Point(15, 19)
        Me.rbtPlanillaCana.Name = "rbtPlanillaCana"
        Me.rbtPlanillaCana.Size = New System.Drawing.Size(85, 17)
        Me.rbtPlanillaCana.TabIndex = 41
        Me.rbtPlanillaCana.TabStop = True
        Me.rbtPlanillaCana.Text = "Planilla caña"
        Me.rbtPlanillaCana.UseVisualStyleBackColor = True
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(11, 73)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(112, 13)
        Me.lblRangoCompensacion.TabIndex = 57
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(158, 65)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(261, 21)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 58
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(158, 38)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(260, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 27
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(158, 12)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(260, 21)
        Me.CbxZAFRA1.TabIndex = 24
        '
        'frmComprobantesGenerarPH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 429)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSeleccionarDirectorio)
        Me.Controls.Add(Me.txtDirectorio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarArchivos)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComprobantesGenerarPH"
        Me.Text = "Generar archivos de comprobantes para PH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGenerarArchivos As System.Windows.Forms.Button
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtDirectorio As System.Windows.Forms.TextBox
    Friend WithEvents btnSeleccionarDirectorio As System.Windows.Forms.Button
    Friend WithEvents rbtAnticipo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtComplemento As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtPlanillaCana As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCompensacion As System.Windows.Forms.RadioButton
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
    Friend WithEvents rbtIncentivo As System.Windows.Forms.RadioButton
End Class
