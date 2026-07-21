<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarPlantilla
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarPlantilla = New System.Windows.Forms.Button()
        Me.btnSeleccionarDirectorio = New System.Windows.Forms.Button()
        Me.txtDirectorio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstTiposDescuentos = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dteFechaCalcInteres = New DevExpress.XtraEditors.DateEdit()
        Me.CbxTIPO_PLANILLA1 = New SISPACAL.WinUC.cbxTIPO_PLANILLA()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        CType(Me.dteFechaCalcInteres.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaCalcInteres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Catorcena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Zafra"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(621, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(173, 34)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGenerarPlantilla
        '
        Me.btnGenerarPlantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarPlantilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerarPlantilla.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarPlantilla.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnGenerarPlantilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarPlantilla.Location = New System.Drawing.Point(621, 62)
        Me.btnGenerarPlantilla.Name = "btnGenerarPlantilla"
        Me.btnGenerarPlantilla.Size = New System.Drawing.Size(173, 32)
        Me.btnGenerarPlantilla.TabIndex = 21
        Me.btnGenerarPlantilla.Text = "Generar plantilla"
        Me.btnGenerarPlantilla.UseVisualStyleBackColor = False
        '
        'btnSeleccionarDirectorio
        '
        Me.btnSeleccionarDirectorio.Location = New System.Drawing.Point(438, 144)
        Me.btnSeleccionarDirectorio.Name = "btnSeleccionarDirectorio"
        Me.btnSeleccionarDirectorio.Size = New System.Drawing.Size(23, 22)
        Me.btnSeleccionarDirectorio.TabIndex = 37
        Me.btnSeleccionarDirectorio.Text = "?"
        Me.btnSeleccionarDirectorio.UseVisualStyleBackColor = True
        '
        'txtDirectorio
        '
        Me.txtDirectorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirectorio.Location = New System.Drawing.Point(14, 144)
        Me.txtDirectorio.Name = "txtDirectorio"
        Me.txtDirectorio.Size = New System.Drawing.Size(428, 21)
        Me.txtDirectorio.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Seleccione el directorio de generación de la plantilla"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Tipo de planilla"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Marque los descuentos que se incluirán en la plantilla"
        Me.Label5.Visible = False
        '
        'lstTiposDescuentos
        '
        Me.lstTiposDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTiposDescuentos.FormattingEnabled = True
        Me.lstTiposDescuentos.ItemHeight = 15
        Me.lstTiposDescuentos.Location = New System.Drawing.Point(12, 201)
        Me.lstTiposDescuentos.Name = "lstTiposDescuentos"
        Me.lstTiposDescuentos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTiposDescuentos.Size = New System.Drawing.Size(449, 244)
        Me.lstTiposDescuentos.TabIndex = 41
        Me.lstTiposDescuentos.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Fecha cálculo interes:"
        '
        'dteFechaCalcInteres
        '
        Me.dteFechaCalcInteres.EditValue = Nothing
        Me.dteFechaCalcInteres.Enabled = False
        Me.dteFechaCalcInteres.Location = New System.Drawing.Point(128, 92)
        Me.dteFechaCalcInteres.Name = "dteFechaCalcInteres"
        Me.dteFechaCalcInteres.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dteFechaCalcInteres.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.dteFechaCalcInteres.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dteFechaCalcInteres.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dteFechaCalcInteres.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaCalcInteres.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaCalcInteres.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaCalcInteres.Size = New System.Drawing.Size(149, 20)
        Me.dteFechaCalcInteres.TabIndex = 43
        '
        'CbxTIPO_PLANILLA1
        '
        Me.CbxTIPO_PLANILLA1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PLANILLA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PLANILLA1.Location = New System.Drawing.Point(128, 65)
        Me.CbxTIPO_PLANILLA1.Name = "CbxTIPO_PLANILLA1"
        Me.CbxTIPO_PLANILLA1.Size = New System.Drawing.Size(314, 21)
        Me.CbxTIPO_PLANILLA1.TabIndex = 38
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(128, 38)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(314, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 20
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(128, 12)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(314, 21)
        Me.CbxZAFRA1.TabIndex = 17
        '
        'frmGenerarPlantilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 481)
        Me.Controls.Add(Me.dteFechaCalcInteres)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstTiposDescuentos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxTIPO_PLANILLA1)
        Me.Controls.Add(Me.btnSeleccionarDirectorio)
        Me.Controls.Add(Me.txtDirectorio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarPlantilla)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerarPlantilla"
        Me.Text = "Generación de Plantilla de Descuentos"
        CType(Me.dteFechaCalcInteres.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaCalcInteres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGenerarPlantilla As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarDirectorio As System.Windows.Forms.Button
    Friend WithEvents txtDirectorio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CbxTIPO_PLANILLA1 As SISPACAL.WinUC.cbxTIPO_PLANILLA
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstTiposDescuentos As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dteFechaCalcInteres As DevExpress.XtraEditors.DateEdit
End Class
