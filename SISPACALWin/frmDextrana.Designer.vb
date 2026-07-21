<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDextrana
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
        Me.lblDEXTRANA = New System.Windows.Forms.Label()
        Me.txtABSORBANCIA = New System.Windows.Forms.TextBox()
        Me.etAbsorbancia = New System.Windows.Forms.Label()
        Me.etdAnalisisDextrana = New System.Windows.Forms.Label()
        Me.etDextrana = New System.Windows.Forms.Label()
        Me.txtTACO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDEXTRANA
        '
        Me.lblDEXTRANA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDEXTRANA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDEXTRANA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblDEXTRANA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDEXTRANA.Location = New System.Drawing.Point(437, 167)
        Me.lblDEXTRANA.Name = "lblDEXTRANA"
        Me.lblDEXTRANA.Size = New System.Drawing.Size(157, 27)
        Me.lblDEXTRANA.TabIndex = 3
        Me.lblDEXTRANA.Tag = "AnalisisDextrana"
        Me.lblDEXTRANA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtABSORBANCIA
        '
        Me.txtABSORBANCIA.BackColor = System.Drawing.Color.White
        Me.txtABSORBANCIA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtABSORBANCIA.ForeColor = System.Drawing.Color.Navy
        Me.txtABSORBANCIA.Location = New System.Drawing.Point(437, 124)
        Me.txtABSORBANCIA.Name = "txtABSORBANCIA"
        Me.txtABSORBANCIA.Size = New System.Drawing.Size(157, 26)
        Me.txtABSORBANCIA.TabIndex = 2
        Me.txtABSORBANCIA.Tag = "AnalisisDextrana"
        Me.txtABSORBANCIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etAbsorbancia
        '
        Me.etAbsorbancia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etAbsorbancia.AutoSize = True
        Me.etAbsorbancia.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.etAbsorbancia.Location = New System.Drawing.Point(322, 127)
        Me.etAbsorbancia.Name = "etAbsorbancia"
        Me.etAbsorbancia.Size = New System.Drawing.Size(100, 18)
        Me.etAbsorbancia.TabIndex = 103
        Me.etAbsorbancia.Text = "Absorbancia"
        Me.etAbsorbancia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etdAnalisisDextrana
        '
        Me.etdAnalisisDextrana.BackColor = System.Drawing.Color.Black
        Me.etdAnalisisDextrana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etdAnalisisDextrana.Dock = System.Windows.Forms.DockStyle.Top
        Me.etdAnalisisDextrana.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.etdAnalisisDextrana.ForeColor = System.Drawing.Color.White
        Me.etdAnalisisDextrana.Location = New System.Drawing.Point(0, 0)
        Me.etdAnalisisDextrana.Name = "etdAnalisisDextrana"
        Me.etdAnalisisDextrana.Size = New System.Drawing.Size(1037, 35)
        Me.etdAnalisisDextrana.TabIndex = 102
        Me.etdAnalisisDextrana.Text = "ANALISIS DE DEXTRANA"
        Me.etdAnalisisDextrana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'etDextrana
        '
        Me.etDextrana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDextrana.AutoSize = True
        Me.etDextrana.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.etDextrana.Location = New System.Drawing.Point(294, 171)
        Me.etDextrana.Name = "etDextrana"
        Me.etDextrana.Size = New System.Drawing.Size(128, 18)
        Me.etDextrana.TabIndex = 101
        Me.etDextrana.Text = "Dextrana (PPM)"
        Me.etDextrana.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTACO
        '
        Me.txtTACO.BackColor = System.Drawing.Color.White
        Me.txtTACO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTACO.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTACO.Location = New System.Drawing.Point(437, 80)
        Me.txtTACO.MaxLength = 7
        Me.txtTACO.Name = "txtTACO"
        Me.txtTACO.Size = New System.Drawing.Size(157, 26)
        Me.txtTACO.TabIndex = 0
        Me.txtTACO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(345, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "N°  TACO"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(748, 160)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 34)
        Me.btnCancelar.TabIndex = 6
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
        Me.btnGuardar.Location = New System.Drawing.Point(748, 80)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(153, 34)
        Me.btnGuardar.TabIndex = 4
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
        Me.btnNuevo.Location = New System.Drawing.Point(748, 120)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 34)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'frmDextrana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 592)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTACO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDEXTRANA)
        Me.Controls.Add(Me.txtABSORBANCIA)
        Me.Controls.Add(Me.etAbsorbancia)
        Me.Controls.Add(Me.etdAnalisisDextrana)
        Me.Controls.Add(Me.etDextrana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDextrana"
        Me.Text = "DEXTRANA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDEXTRANA As System.Windows.Forms.Label
    Friend WithEvents txtABSORBANCIA As System.Windows.Forms.TextBox
    Friend WithEvents etAbsorbancia As System.Windows.Forms.Label
    Friend WithEvents etdAnalisisDextrana As System.Windows.Forms.Label
    Friend WithEvents etDextrana As System.Windows.Forms.Label
    Friend WithEvents txtTACO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
