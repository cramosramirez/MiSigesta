<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchivosPH
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNO_PARTIDA_PH = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarArchivos = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.rbtAnticipo = New System.Windows.Forms.RadioButton()
        Me.rbtComplemento = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtFrenteRozaParticular = New System.Windows.Forms.RadioButton()
        Me.rbtComplementoAdicional = New System.Windows.Forms.RadioButton()
        Me.rbtCompensacionTransporte = New System.Windows.Forms.RadioButton()
        Me.rbtIncentivo = New System.Windows.Forms.RadioButton()
        Me.rbtCompensacion = New System.Windows.Forms.RadioButton()
        Me.rbtPlanillaNormal = New System.Windows.Forms.RadioButton()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.rbtFrenteRozaINJIBOA = New System.Windows.Forms.RadioButton()
        Me.rbtFrenteQuerqueoParticular = New System.Windows.Forms.RadioButton()
        Me.rbtFrenteQuerqueoINJIBOA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Catorcena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Zafra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 357)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Ingrese o seleccione el directorio de generación"
        '
        'txtDirectorio
        '
        Me.txtDirectorio.Location = New System.Drawing.Point(21, 377)
        Me.txtDirectorio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirectorio.Name = "txtDirectorio"
        Me.txtDirectorio.Size = New System.Drawing.Size(504, 22)
        Me.txtDirectorio.TabIndex = 33
        '
        'btnSeleccionarDirectorio
        '
        Me.btnSeleccionarDirectorio.Location = New System.Drawing.Point(527, 376)
        Me.btnSeleccionarDirectorio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeleccionarDirectorio.Name = "btnSeleccionarDirectorio"
        Me.btnSeleccionarDirectorio.Size = New System.Drawing.Size(31, 27)
        Me.btnSeleccionarDirectorio.TabIndex = 34
        Me.btnSeleccionarDirectorio.Text = "?"
        Me.btnSeleccionarDirectorio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "No. de Partida Inicial del PH"
        '
        'txtNO_PARTIDA_PH
        '
        Me.txtNO_PARTIDA_PH.Location = New System.Drawing.Point(211, 165)
        Me.txtNO_PARTIDA_PH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNO_PARTIDA_PH.Name = "txtNO_PARTIDA_PH"
        Me.txtNO_PARTIDA_PH.Size = New System.Drawing.Size(181, 22)
        Me.txtNO_PARTIDA_PH.TabIndex = 36
        Me.txtNO_PARTIDA_PH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(819, 15)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(201, 42)
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
        Me.btnGenerarArchivos.Location = New System.Drawing.Point(819, 112)
        Me.btnGenerarArchivos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerarArchivos.Name = "btnGenerarArchivos"
        Me.btnGenerarArchivos.Size = New System.Drawing.Size(201, 79)
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
        Me.rbtAnticipo.Location = New System.Drawing.Point(151, 23)
        Me.rbtAnticipo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtAnticipo.Name = "rbtAnticipo"
        Me.rbtAnticipo.Size = New System.Drawing.Size(76, 21)
        Me.rbtAnticipo.TabIndex = 38
        Me.rbtAnticipo.TabStop = True
        Me.rbtAnticipo.Text = "Anticipo"
        Me.rbtAnticipo.UseVisualStyleBackColor = True
        '
        'rbtComplemento
        '
        Me.rbtComplemento.AutoSize = True
        Me.rbtComplemento.Location = New System.Drawing.Point(243, 23)
        Me.rbtComplemento.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtComplemento.Name = "rbtComplemento"
        Me.rbtComplemento.Size = New System.Drawing.Size(183, 21)
        Me.rbtComplemento.TabIndex = 39
        Me.rbtComplemento.TabStop = True
        Me.rbtComplemento.Text = "Complemento Valor Final"
        Me.rbtComplemento.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtFrenteQuerqueoINJIBOA)
        Me.GroupBox1.Controls.Add(Me.rbtFrenteQuerqueoParticular)
        Me.GroupBox1.Controls.Add(Me.rbtFrenteRozaINJIBOA)
        Me.GroupBox1.Controls.Add(Me.rbtFrenteRozaParticular)
        Me.GroupBox1.Controls.Add(Me.rbtComplementoAdicional)
        Me.GroupBox1.Controls.Add(Me.rbtCompensacionTransporte)
        Me.GroupBox1.Controls.Add(Me.rbtIncentivo)
        Me.GroupBox1.Controls.Add(Me.rbtCompensacion)
        Me.GroupBox1.Controls.Add(Me.rbtPlanillaNormal)
        Me.GroupBox1.Controls.Add(Me.rbtAnticipo)
        Me.GroupBox1.Controls.Add(Me.rbtComplemento)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 197)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(999, 141)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'rbtFrenteRozaParticular
        '
        Me.rbtFrenteRozaParticular.AutoSize = True
        Me.rbtFrenteRozaParticular.Location = New System.Drawing.Point(20, 81)
        Me.rbtFrenteRozaParticular.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtFrenteRozaParticular.Name = "rbtFrenteRozaParticular"
        Me.rbtFrenteRozaParticular.Size = New System.Drawing.Size(168, 21)
        Me.rbtFrenteRozaParticular.TabIndex = 46
        Me.rbtFrenteRozaParticular.TabStop = True
        Me.rbtFrenteRozaParticular.Text = "Frente Roza Particular"
        Me.rbtFrenteRozaParticular.UseVisualStyleBackColor = True
        '
        'rbtComplementoAdicional
        '
        Me.rbtComplementoAdicional.AutoSize = True
        Me.rbtComplementoAdicional.Location = New System.Drawing.Point(20, 52)
        Me.rbtComplementoAdicional.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtComplementoAdicional.Name = "rbtComplementoAdicional"
        Me.rbtComplementoAdicional.Size = New System.Drawing.Size(254, 21)
        Me.rbtComplementoAdicional.TabIndex = 45
        Me.rbtComplementoAdicional.TabStop = True
        Me.rbtComplementoAdicional.Text = "Complemento Valor Final (Adicional)"
        Me.rbtComplementoAdicional.UseVisualStyleBackColor = True
        '
        'rbtCompensacionTransporte
        '
        Me.rbtCompensacionTransporte.AutoSize = True
        Me.rbtCompensacionTransporte.Location = New System.Drawing.Point(764, 22)
        Me.rbtCompensacionTransporte.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtCompensacionTransporte.Name = "rbtCompensacionTransporte"
        Me.rbtCompensacionTransporte.Size = New System.Drawing.Size(219, 21)
        Me.rbtCompensacionTransporte.TabIndex = 44
        Me.rbtCompensacionTransporte.TabStop = True
        Me.rbtCompensacionTransporte.Text = "Complemento a Transportistas"
        Me.rbtCompensacionTransporte.UseVisualStyleBackColor = True
        '
        'rbtIncentivo
        '
        Me.rbtIncentivo.AutoSize = True
        Me.rbtIncentivo.Location = New System.Drawing.Point(664, 22)
        Me.rbtIncentivo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtIncentivo.Name = "rbtIncentivo"
        Me.rbtIncentivo.Size = New System.Drawing.Size(82, 21)
        Me.rbtIncentivo.TabIndex = 43
        Me.rbtIncentivo.TabStop = True
        Me.rbtIncentivo.Text = "Incentivo"
        Me.rbtIncentivo.UseVisualStyleBackColor = True
        '
        'rbtCompensacion
        '
        Me.rbtCompensacion.AutoSize = True
        Me.rbtCompensacion.Location = New System.Drawing.Point(439, 22)
        Me.rbtCompensacion.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtCompensacion.Name = "rbtCompensacion"
        Me.rbtCompensacion.Size = New System.Drawing.Size(210, 21)
        Me.rbtCompensacion.TabIndex = 42
        Me.rbtCompensacion.TabStop = True
        Me.rbtCompensacion.Text = "Compensacion Entrega Caña"
        Me.rbtCompensacion.UseVisualStyleBackColor = True
        '
        'rbtPlanillaNormal
        '
        Me.rbtPlanillaNormal.AutoSize = True
        Me.rbtPlanillaNormal.Location = New System.Drawing.Point(20, 23)
        Me.rbtPlanillaNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtPlanillaNormal.Name = "rbtPlanillaNormal"
        Me.rbtPlanillaNormal.Size = New System.Drawing.Size(118, 21)
        Me.rbtPlanillaNormal.TabIndex = 41
        Me.rbtPlanillaNormal.TabStop = True
        Me.rbtPlanillaNormal.Text = "Planilla normal"
        Me.rbtPlanillaNormal.UseVisualStyleBackColor = True
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(15, 126)
        Me.lblRangoCompensacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(147, 17)
        Me.lblRangoCompensacion.TabIndex = 57
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(211, 116)
        Me.cbxRANGO_COMPENSACION1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(347, 24)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 58
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(211, 47)
        Me.CbxCATORCENA_ZAFRA1.Margin = New System.Windows.Forms.Padding(4)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(345, 24)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 27
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(211, 15)
        Me.CbxZAFRA1.Margin = New System.Windows.Forms.Padding(4)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(345, 24)
        Me.CbxZAFRA1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Documento"
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(211, 80)
        Me.cbxTipoDocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(347, 24)
        Me.cbxTipoDocumento.TabIndex = 65
        '
        'rbtFrenteRozaINJIBOA
        '
        Me.rbtFrenteRozaINJIBOA.AutoSize = True
        Me.rbtFrenteRozaINJIBOA.Location = New System.Drawing.Point(243, 81)
        Me.rbtFrenteRozaINJIBOA.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtFrenteRozaINJIBOA.Name = "rbtFrenteRozaINJIBOA"
        Me.rbtFrenteRozaINJIBOA.Size = New System.Drawing.Size(160, 21)
        Me.rbtFrenteRozaINJIBOA.TabIndex = 47
        Me.rbtFrenteRozaINJIBOA.TabStop = True
        Me.rbtFrenteRozaINJIBOA.Text = "Frente Roza INJIBOA"
        Me.rbtFrenteRozaINJIBOA.UseVisualStyleBackColor = True
        '
        'rbtFrenteQuerqueoParticular
        '
        Me.rbtFrenteQuerqueoParticular.AutoSize = True
        Me.rbtFrenteQuerqueoParticular.Location = New System.Drawing.Point(439, 81)
        Me.rbtFrenteQuerqueoParticular.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtFrenteQuerqueoParticular.Name = "rbtFrenteQuerqueoParticular"
        Me.rbtFrenteQuerqueoParticular.Size = New System.Drawing.Size(199, 21)
        Me.rbtFrenteQuerqueoParticular.TabIndex = 48
        Me.rbtFrenteQuerqueoParticular.TabStop = True
        Me.rbtFrenteQuerqueoParticular.Text = "Frente Querqueo Particular"
        Me.rbtFrenteQuerqueoParticular.UseVisualStyleBackColor = True
        '
        'rbtFrenteQuerqueoINJIBOA
        '
        Me.rbtFrenteQuerqueoINJIBOA.AutoSize = True
        Me.rbtFrenteQuerqueoINJIBOA.Location = New System.Drawing.Point(664, 81)
        Me.rbtFrenteQuerqueoINJIBOA.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtFrenteQuerqueoINJIBOA.Name = "rbtFrenteQuerqueoINJIBOA"
        Me.rbtFrenteQuerqueoINJIBOA.Size = New System.Drawing.Size(195, 21)
        Me.rbtFrenteQuerqueoINJIBOA.TabIndex = 49
        Me.rbtFrenteQuerqueoINJIBOA.TabStop = True
        Me.rbtFrenteQuerqueoINJIBOA.Text = "Frente Querqueo  INJIBOA"
        Me.rbtFrenteQuerqueoINJIBOA.UseVisualStyleBackColor = True
        '
        'frmArchivosPH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 583)
        Me.Controls.Add(Me.cbxTipoDocumento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNO_PARTIDA_PH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSeleccionarDirectorio)
        Me.Controls.Add(Me.txtDirectorio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarArchivos)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArchivosPH"
        Me.Text = "Generar archivos para Contabilidad PH"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNO_PARTIDA_PH As System.Windows.Forms.TextBox
    Friend WithEvents rbtAnticipo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtComplemento As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtPlanillaNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCompensacion As System.Windows.Forms.RadioButton
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
    Friend WithEvents rbtIncentivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCompensacionTransporte As System.Windows.Forms.RadioButton
    Friend WithEvents rbtComplementoAdicional As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxTipoDocumento As ComboBox
    Friend WithEvents rbtFrenteRozaParticular As RadioButton
    Friend WithEvents rbtFrenteQuerqueoINJIBOA As RadioButton
    Friend WithEvents rbtFrenteQuerqueoParticular As RadioButton
    Friend WithEvents rbtFrenteRozaINJIBOA As RadioButton
End Class
