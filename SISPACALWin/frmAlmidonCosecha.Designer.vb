<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmidonCosecha
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
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.speBrixDiluido = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.speAbsorbanciaAlmidon = New DevExpress.XtraEditors.SpinEdit()
        Me.lblAlmidon = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTACO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.speBrixDiluido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speAbsorbanciaAlmidon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.LabelControl13)
        Me.GroupControl4.Controls.Add(Me.speBrixDiluido)
        Me.GroupControl4.Controls.Add(Me.LabelControl10)
        Me.GroupControl4.Controls.Add(Me.speAbsorbanciaAlmidon)
        Me.GroupControl4.Controls.Add(Me.lblAlmidon)
        Me.GroupControl4.Controls.Add(Me.LabelControl12)
        Me.GroupControl4.Location = New System.Drawing.Point(12, 69)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(426, 151)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "ALMIDON EN JUGO PRIMARIO"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(17, 68)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(115, 18)
        Me.LabelControl13.TabIndex = 20
        Me.LabelControl13.Text = "BRIX DILUIDO:"
        '
        'speBrixDiluido
        '
        Me.speBrixDiluido.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speBrixDiluido.Location = New System.Drawing.Point(161, 67)
        Me.speBrixDiluido.Name = "speBrixDiluido"
        Me.speBrixDiluido.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.speBrixDiluido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speBrixDiluido.Properties.Appearance.Options.UseFont = True
        Me.speBrixDiluido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.speBrixDiluido.Size = New System.Drawing.Size(198, 24)
        Me.speBrixDiluido.TabIndex = 19
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(17, 34)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(117, 18)
        Me.LabelControl10.TabIndex = 18
        Me.LabelControl10.Text = "ABSORBANCIA:"
        '
        'speAbsorbanciaAlmidon
        '
        Me.speAbsorbanciaAlmidon.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speAbsorbanciaAlmidon.Location = New System.Drawing.Point(161, 32)
        Me.speAbsorbanciaAlmidon.Name = "speAbsorbanciaAlmidon"
        Me.speAbsorbanciaAlmidon.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.speAbsorbanciaAlmidon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speAbsorbanciaAlmidon.Properties.Appearance.Options.UseFont = True
        Me.speAbsorbanciaAlmidon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.speAbsorbanciaAlmidon.Size = New System.Drawing.Size(198, 24)
        Me.speAbsorbanciaAlmidon.TabIndex = 17
        '
        'lblAlmidon
        '
        Me.lblAlmidon.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmidon.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAlmidon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAlmidon.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lblAlmidon.Location = New System.Drawing.Point(161, 103)
        Me.lblAlmidon.Name = "lblAlmidon"
        Me.lblAlmidon.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblAlmidon.Size = New System.Drawing.Size(186, 25)
        Me.lblAlmidon.TabIndex = 9
        Me.lblAlmidon.Text = "0.00"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(17, 101)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(128, 18)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "ALMIDON (ppm):"
        '
        'txtTACO
        '
        Me.txtTACO.BackColor = System.Drawing.Color.White
        Me.txtTACO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTACO.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTACO.Location = New System.Drawing.Point(101, 16)
        Me.txtTACO.MaxLength = 7
        Me.txtTACO.Name = "txtTACO"
        Me.txtTACO.Size = New System.Drawing.Size(232, 26)
        Me.txtTACO.TabIndex = 143
        Me.txtTACO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "N°  TACO"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(453, 168)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 34)
        Me.btnCancelar.TabIndex = 147
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SISPACAL.My.Resources.Resources.RP_Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(453, 84)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(153, 34)
        Me.btnGuardar.TabIndex = 145
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SISPACAL.My.Resources.Resources.new_file_btn
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(453, 126)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 34)
        Me.btnNuevo.TabIndex = 146
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'frmAlmidonCosecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 232)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTACO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupControl4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlmidonCosecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almidón en Jugo Primario"
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.speBrixDiluido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speAbsorbanciaAlmidon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents speBrixDiluido As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents speAbsorbanciaAlmidon As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblAlmidon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTACO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
