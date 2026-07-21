<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesPlanilla
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbNoContribuyente = New System.Windows.Forms.RadioButton()
        Me.rdbContribuyente = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVerPlanilla = New System.Windows.Forms.Button()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.CbxTIPO_PLANILLA1 = New SISPACAL.WinUC.cbxTIPO_PLANILLA()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.CbxTIPO_PAGO1 = New SISPACAL.WinUC.cbxTIPO_PAGO()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbNoContribuyente)
        Me.Panel1.Controls.Add(Me.rdbContribuyente)
        Me.Panel1.Location = New System.Drawing.Point(126, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 39)
        Me.Panel1.TabIndex = 30
        '
        'rdbNoContribuyente
        '
        Me.rdbNoContribuyente.AutoSize = True
        Me.rdbNoContribuyente.Location = New System.Drawing.Point(112, 11)
        Me.rdbNoContribuyente.Name = "rdbNoContribuyente"
        Me.rdbNoContribuyente.Size = New System.Drawing.Size(106, 17)
        Me.rdbNoContribuyente.TabIndex = 23
        Me.rdbNoContribuyente.Text = "No contribuyente"
        Me.rdbNoContribuyente.UseVisualStyleBackColor = True
        '
        'rdbContribuyente
        '
        Me.rdbContribuyente.AutoSize = True
        Me.rdbContribuyente.Checked = True
        Me.rdbContribuyente.Location = New System.Drawing.Point(16, 11)
        Me.rdbContribuyente.Name = "rdbContribuyente"
        Me.rdbContribuyente.Size = New System.Drawing.Size(90, 17)
        Me.rdbContribuyente.TabIndex = 22
        Me.rdbContribuyente.TabStop = True
        Me.rdbContribuyente.Text = "Contribuyente"
        Me.rdbContribuyente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Tipo de Planilla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Catorcena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Zafra"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(716, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(173, 34)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVerPlanilla
        '
        Me.btnVerPlanilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerPlanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerPlanilla.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPlanilla.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnVerPlanilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerPlanilla.Location = New System.Drawing.Point(716, 62)
        Me.btnVerPlanilla.Name = "btnVerPlanilla"
        Me.btnVerPlanilla.Size = New System.Drawing.Size(173, 32)
        Me.btnVerPlanilla.TabIndex = 31
        Me.btnVerPlanilla.Text = "Ver planilla"
        Me.btnVerPlanilla.UseVisualStyleBackColor = False
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(10, 96)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(112, 13)
        Me.lblRangoCompensacion.TabIndex = 44
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(126, 91)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(315, 21)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 45
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'CbxTIPO_PLANILLA1
        '
        Me.CbxTIPO_PLANILLA1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PLANILLA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PLANILLA1.Location = New System.Drawing.Point(126, 64)
        Me.CbxTIPO_PLANILLA1.Name = "CbxTIPO_PLANILLA1"
        Me.CbxTIPO_PLANILLA1.Size = New System.Drawing.Size(315, 21)
        Me.CbxTIPO_PLANILLA1.TabIndex = 29
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(126, 38)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(112, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 27
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(126, 12)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(112, 21)
        Me.CbxZAFRA1.TabIndex = 24
        '
        'CbxTIPO_PAGO1
        '
        Me.CbxTIPO_PAGO1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PAGO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PAGO1.Location = New System.Drawing.Point(126, 163)
        Me.CbxTIPO_PAGO1.Name = "CbxTIPO_PAGO1"
        Me.CbxTIPO_PAGO1.Size = New System.Drawing.Size(315, 21)
        Me.CbxTIPO_PAGO1.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Tipo de pago"
        '
        'frmReportesPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 452)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxTIPO_PAGO1)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVerPlanilla)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbxTIPO_PLANILLA1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportesPlanilla"
        Me.Text = "Reportes de Planilla"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdbNoContribuyente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbContribuyente As System.Windows.Forms.RadioButton
    Friend WithEvents CbxTIPO_PLANILLA1 As SISPACAL.WinUC.cbxTIPO_PLANILLA
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVerPlanilla As System.Windows.Forms.Button
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
    Friend WithEvents CbxTIPO_PAGO1 As SISPACAL.WinUC.cbxTIPO_PAGO
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
