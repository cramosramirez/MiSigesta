<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnSedimento
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
        Me.txtTACO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSEDIMENTO = New System.Windows.Forms.Label()
        Me.txtVOLUMEN_SEDIMENTO = New System.Windows.Forms.TextBox()
        Me.etVolumenSedimento = New System.Windows.Forms.Label()
        Me.etdAnalisisSedimento = New System.Windows.Forms.Label()
        Me.etDextrana = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTACO
        '
        Me.txtTACO.BackColor = System.Drawing.Color.White
        Me.txtTACO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTACO.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTACO.Location = New System.Drawing.Point(437, 77)
        Me.txtTACO.MaxLength = 7
        Me.txtTACO.Name = "txtTACO"
        Me.txtTACO.Size = New System.Drawing.Size(157, 26)
        Me.txtTACO.TabIndex = 107
        Me.txtTACO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(345, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "N°  Boleta"
        '
        'lblSEDIMENTO
        '
        Me.lblSEDIMENTO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSEDIMENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSEDIMENTO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblSEDIMENTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSEDIMENTO.Location = New System.Drawing.Point(437, 164)
        Me.lblSEDIMENTO.Name = "lblSEDIMENTO"
        Me.lblSEDIMENTO.Size = New System.Drawing.Size(157, 27)
        Me.lblSEDIMENTO.TabIndex = 109
        Me.lblSEDIMENTO.Tag = "AnalisisDextrana"
        Me.lblSEDIMENTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVOLUMEN_SEDIMENTO
        '
        Me.txtVOLUMEN_SEDIMENTO.BackColor = System.Drawing.Color.White
        Me.txtVOLUMEN_SEDIMENTO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtVOLUMEN_SEDIMENTO.ForeColor = System.Drawing.Color.Navy
        Me.txtVOLUMEN_SEDIMENTO.Location = New System.Drawing.Point(437, 121)
        Me.txtVOLUMEN_SEDIMENTO.Name = "txtVOLUMEN_SEDIMENTO"
        Me.txtVOLUMEN_SEDIMENTO.Size = New System.Drawing.Size(157, 26)
        Me.txtVOLUMEN_SEDIMENTO.TabIndex = 108
        Me.txtVOLUMEN_SEDIMENTO.Tag = "AnalisisDextrana"
        Me.txtVOLUMEN_SEDIMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etVolumenSedimento
        '
        Me.etVolumenSedimento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etVolumenSedimento.AutoSize = True
        Me.etVolumenSedimento.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.etVolumenSedimento.Location = New System.Drawing.Point(211, 124)
        Me.etVolumenSedimento.Name = "etVolumenSedimento"
        Me.etVolumenSedimento.Size = New System.Drawing.Size(215, 18)
        Me.etVolumenSedimento.TabIndex = 115
        Me.etVolumenSedimento.Text = "Volumen de sedimento (mL)"
        Me.etVolumenSedimento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etdAnalisisSedimento
        '
        Me.etdAnalisisSedimento.BackColor = System.Drawing.Color.Black
        Me.etdAnalisisSedimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etdAnalisisSedimento.Dock = System.Windows.Forms.DockStyle.Top
        Me.etdAnalisisSedimento.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.etdAnalisisSedimento.ForeColor = System.Drawing.Color.White
        Me.etdAnalisisSedimento.Location = New System.Drawing.Point(0, 0)
        Me.etdAnalisisSedimento.Name = "etdAnalisisSedimento"
        Me.etdAnalisisSedimento.Size = New System.Drawing.Size(1044, 35)
        Me.etdAnalisisSedimento.TabIndex = 114
        Me.etdAnalisisSedimento.Text = "SEDIMENTO"
        Me.etdAnalisisSedimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'etDextrana
        '
        Me.etDextrana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDextrana.AutoSize = True
        Me.etDextrana.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.etDextrana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.etDextrana.Location = New System.Drawing.Point(335, 168)
        Me.etDextrana.Name = "etDextrana"
        Me.etDextrana.Size = New System.Drawing.Size(87, 18)
        Me.etDextrana.TabIndex = 113
        Me.etDextrana.Text = "Sedimento"
        Me.etDextrana.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(758, 157)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 34)
        Me.btnCancelar.TabIndex = 112
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Image = Global.SISPACAL.My.Resources.Resources.RP_Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(758, 77)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(153, 34)
        Me.btnGuardar.TabIndex = 110
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Image = Global.SISPACAL.My.Resources.Resources.new_file_btn
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(758, 117)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 34)
        Me.btnNuevo.TabIndex = 111
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'frnSedimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTACO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSEDIMENTO)
        Me.Controls.Add(Me.txtVOLUMEN_SEDIMENTO)
        Me.Controls.Add(Me.etVolumenSedimento)
        Me.Controls.Add(Me.etdAnalisisSedimento)
        Me.Controls.Add(Me.etDextrana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frnSedimento"
        Me.Text = "SEDIMENTO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtTACO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSEDIMENTO As Label
    Friend WithEvents txtVOLUMEN_SEDIMENTO As TextBox
    Friend WithEvents etVolumenSedimento As Label
    Friend WithEvents etdAnalisisSedimento As Label
    Friend WithEvents etDextrana As Label
End Class
