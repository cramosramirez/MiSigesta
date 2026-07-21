<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.lstLecturas = New System.Windows.Forms.ListBox()
        Me.gbAnalisisLab = New System.Windows.Forms.GroupBox()
        Me.lblFECHA_APLICA_MADURANTE = New System.Windows.Forms.Label()
        Me.lblMADURANTE = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkQuemaProgramada = New System.Windows.Forms.CheckBox()
        Me.chkQuemaNoProgramada = New System.Windows.Forms.CheckBox()
        Me.txtPH = New System.Windows.Forms.TextBox()
        Me.etPH = New System.Windows.Forms.Label()
        Me.lblPOL_Lectura = New System.Windows.Forms.Label()
        Me.lblTIPO_CAÑA = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etBrix = New System.Windows.Forms.Label()
        Me.etPolAjustado = New System.Windows.Forms.Label()
        Me.lblBRIX = New System.Windows.Forms.Label()
        Me.lblPOL = New System.Windows.Forms.Label()
        Me.lblBAGAZO_NETO = New System.Windows.Forms.Label()
        Me.lblBAGAZO_BRUTO = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbxTipoLectura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbBascula = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFechaPatio = New System.Windows.Forms.Label()
        Me.lblFechaCarga = New System.Windows.Forms.Label()
        Me.lblFechaCorta = New System.Windows.Forms.Label()
        Me.lblFechaQuema = New System.Windows.Forms.Label()
        Me.lblTipoTransporte = New System.Windows.Forms.Label()
        Me.lblTipoCana = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gReciboCana = New System.Windows.Forms.GroupBox()
        Me.lblReciboCana = New System.Windows.Forms.Label()
        Me.btnVerRecibo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBASCULA_NETOToneladas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBASCULA_NETOLibras = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBASCULA_TARA = New System.Windows.Forms.TextBox()
        Me.txtBASCULA_BRUTO = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbLecturas = New System.Windows.Forms.GroupBox()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnLeerPuerto = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTACO = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblTonsRecibidas = New System.Windows.Forms.Label()
        Me.gbAnalisisLab.SuspendLayout()
        Me.gbBascula.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gReciboCana.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLecturas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstLecturas
        '
        Me.lstLecturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLecturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLecturas.ForeColor = System.Drawing.Color.DarkBlue
        Me.lstLecturas.FormattingEnabled = True
        Me.lstLecturas.ItemHeight = 25
        Me.lstLecturas.Location = New System.Drawing.Point(13, 25)
        Me.lstLecturas.Name = "lstLecturas"
        Me.lstLecturas.Size = New System.Drawing.Size(793, 104)
        Me.lstLecturas.TabIndex = 1
        '
        'gbAnalisisLab
        '
        Me.gbAnalisisLab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAnalisisLab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbAnalisisLab.Controls.Add(Me.lblFECHA_APLICA_MADURANTE)
        Me.gbAnalisisLab.Controls.Add(Me.lblMADURANTE)
        Me.gbAnalisisLab.Controls.Add(Me.Label16)
        Me.gbAnalisisLab.Controls.Add(Me.Label17)
        Me.gbAnalisisLab.Controls.Add(Me.chkQuemaProgramada)
        Me.gbAnalisisLab.Controls.Add(Me.chkQuemaNoProgramada)
        Me.gbAnalisisLab.Controls.Add(Me.txtPH)
        Me.gbAnalisisLab.Controls.Add(Me.etPH)
        Me.gbAnalisisLab.Controls.Add(Me.lblPOL_Lectura)
        Me.gbAnalisisLab.Controls.Add(Me.lblTIPO_CAÑA)
        Me.gbAnalisisLab.Controls.Add(Me.Label4)
        Me.gbAnalisisLab.Controls.Add(Me.Label1)
        Me.gbAnalisisLab.Controls.Add(Me.etBrix)
        Me.gbAnalisisLab.Controls.Add(Me.etPolAjustado)
        Me.gbAnalisisLab.Controls.Add(Me.lblBRIX)
        Me.gbAnalisisLab.Controls.Add(Me.lblPOL)
        Me.gbAnalisisLab.Controls.Add(Me.lblBAGAZO_NETO)
        Me.gbAnalisisLab.Controls.Add(Me.lblBAGAZO_BRUTO)
        Me.gbAnalisisLab.Controls.Add(Me.Label25)
        Me.gbAnalisisLab.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAnalisisLab.Location = New System.Drawing.Point(12, 265)
        Me.gbAnalisisLab.Name = "gbAnalisisLab"
        Me.gbAnalisisLab.Size = New System.Drawing.Size(1008, 357)
        Me.gbAnalisisLab.TabIndex = 5
        Me.gbAnalisisLab.TabStop = False
        Me.gbAnalisisLab.Text = "Laboratorio"
        '
        'lblFECHA_APLICA_MADURANTE
        '
        Me.lblFECHA_APLICA_MADURANTE.AutoSize = True
        Me.lblFECHA_APLICA_MADURANTE.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_APLICA_MADURANTE.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFECHA_APLICA_MADURANTE.Location = New System.Drawing.Point(202, 168)
        Me.lblFECHA_APLICA_MADURANTE.Name = "lblFECHA_APLICA_MADURANTE"
        Me.lblFECHA_APLICA_MADURANTE.Size = New System.Drawing.Size(0, 18)
        Me.lblFECHA_APLICA_MADURANTE.TabIndex = 116
        '
        'lblMADURANTE
        '
        Me.lblMADURANTE.AutoSize = True
        Me.lblMADURANTE.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMADURANTE.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblMADURANTE.Location = New System.Drawing.Point(202, 137)
        Me.lblMADURANTE.Name = "lblMADURANTE"
        Me.lblMADURANTE.Size = New System.Drawing.Size(0, 18)
        Me.lblMADURANTE.TabIndex = 115
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(34, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 18)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Fecha aplicación:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 18)
        Me.Label17.TabIndex = 112
        Me.Label17.Text = "Madurante:"
        '
        'chkQuemaProgramada
        '
        Me.chkQuemaProgramada.AutoSize = True
        Me.chkQuemaProgramada.Enabled = False
        Me.chkQuemaProgramada.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuemaProgramada.Location = New System.Drawing.Point(34, 67)
        Me.chkQuemaProgramada.Name = "chkQuemaProgramada"
        Me.chkQuemaProgramada.Size = New System.Drawing.Size(173, 22)
        Me.chkQuemaProgramada.TabIndex = 111
        Me.chkQuemaProgramada.Text = "Quema programada"
        Me.chkQuemaProgramada.UseVisualStyleBackColor = True
        '
        'chkQuemaNoProgramada
        '
        Me.chkQuemaNoProgramada.AutoSize = True
        Me.chkQuemaNoProgramada.Enabled = False
        Me.chkQuemaNoProgramada.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuemaNoProgramada.Location = New System.Drawing.Point(34, 102)
        Me.chkQuemaNoProgramada.Name = "chkQuemaNoProgramada"
        Me.chkQuemaNoProgramada.Size = New System.Drawing.Size(195, 22)
        Me.chkQuemaNoProgramada.TabIndex = 110
        Me.chkQuemaNoProgramada.Text = "Quema no programada"
        Me.chkQuemaNoProgramada.UseVisualStyleBackColor = True
        '
        'txtPH
        '
        Me.txtPH.BackColor = System.Drawing.Color.White
        Me.txtPH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPH.ForeColor = System.Drawing.Color.Navy
        Me.txtPH.Location = New System.Drawing.Point(570, 177)
        Me.txtPH.Name = "txtPH"
        Me.txtPH.Size = New System.Drawing.Size(172, 26)
        Me.txtPH.TabIndex = 101
        Me.txtPH.Tag = "LecturaAparatos"
        Me.txtPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etPH
        '
        Me.etPH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etPH.AutoSize = True
        Me.etPH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPH.Location = New System.Drawing.Point(523, 182)
        Me.etPH.Name = "etPH"
        Me.etPH.Size = New System.Drawing.Size(29, 18)
        Me.etPH.TabIndex = 102
        Me.etPH.Text = "PH"
        Me.etPH.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPOL_Lectura
        '
        Me.lblPOL_Lectura.BackColor = System.Drawing.Color.White
        Me.lblPOL_Lectura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOL_Lectura.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOL_Lectura.ForeColor = System.Drawing.Color.Navy
        Me.lblPOL_Lectura.Location = New System.Drawing.Point(760, 132)
        Me.lblPOL_Lectura.Name = "lblPOL_Lectura"
        Me.lblPOL_Lectura.Size = New System.Drawing.Size(231, 39)
        Me.lblPOL_Lectura.TabIndex = 53
        Me.lblPOL_Lectura.Tag = "LecturaAparatos"
        Me.lblPOL_Lectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPOL_Lectura.Visible = False
        '
        'lblTIPO_CAÑA
        '
        Me.lblTIPO_CAÑA.AutoSize = True
        Me.lblTIPO_CAÑA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIPO_CAÑA.ForeColor = System.Drawing.Color.Navy
        Me.lblTIPO_CAÑA.Location = New System.Drawing.Point(187, 33)
        Me.lblTIPO_CAÑA.Name = "lblTIPO_CAÑA"
        Me.lblTIPO_CAÑA.Size = New System.Drawing.Size(0, 18)
        Me.lblTIPO_CAÑA.TabIndex = 52
        Me.lblTIPO_CAÑA.Tag = "Dato"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PESO TORTA"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PESO BAGAZO"
        '
        'etBrix
        '
        Me.etBrix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etBrix.AutoSize = True
        Me.etBrix.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBrix.Location = New System.Drawing.Point(506, 146)
        Me.etBrix.Name = "etBrix"
        Me.etBrix.Size = New System.Drawing.Size(46, 18)
        Me.etBrix.TabIndex = 7
        Me.etBrix.Text = "BRIX"
        Me.etBrix.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etPolAjustado
        '
        Me.etPolAjustado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etPolAjustado.AutoSize = True
        Me.etPolAjustado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPolAjustado.Location = New System.Drawing.Point(428, 110)
        Me.etPolAjustado.Name = "etPolAjustado"
        Me.etPolAjustado.Size = New System.Drawing.Size(124, 18)
        Me.etPolAjustado.TabIndex = 5
        Me.etPolAjustado.Text = "POL AJUSTADO"
        Me.etPolAjustado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBRIX
        '
        Me.lblBRIX.BackColor = System.Drawing.Color.White
        Me.lblBRIX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBRIX.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRIX.ForeColor = System.Drawing.Color.Navy
        Me.lblBRIX.Location = New System.Drawing.Point(570, 141)
        Me.lblBRIX.Name = "lblBRIX"
        Me.lblBRIX.Size = New System.Drawing.Size(172, 29)
        Me.lblBRIX.TabIndex = 3
        Me.lblBRIX.Tag = "LecturaAparatos"
        Me.lblBRIX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPOL
        '
        Me.lblPOL.BackColor = System.Drawing.Color.White
        Me.lblPOL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOL.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOL.ForeColor = System.Drawing.Color.Navy
        Me.lblPOL.Location = New System.Drawing.Point(570, 105)
        Me.lblPOL.Name = "lblPOL"
        Me.lblPOL.Size = New System.Drawing.Size(172, 29)
        Me.lblPOL.TabIndex = 2
        Me.lblPOL.Tag = "LecturaAparatos"
        Me.lblPOL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBAGAZO_NETO
        '
        Me.lblBAGAZO_NETO.BackColor = System.Drawing.Color.White
        Me.lblBAGAZO_NETO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBAGAZO_NETO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAGAZO_NETO.ForeColor = System.Drawing.Color.Navy
        Me.lblBAGAZO_NETO.Location = New System.Drawing.Point(570, 69)
        Me.lblBAGAZO_NETO.Name = "lblBAGAZO_NETO"
        Me.lblBAGAZO_NETO.Size = New System.Drawing.Size(172, 29)
        Me.lblBAGAZO_NETO.TabIndex = 1
        Me.lblBAGAZO_NETO.Tag = "LecturaAparatos"
        Me.lblBAGAZO_NETO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBAGAZO_BRUTO
        '
        Me.lblBAGAZO_BRUTO.BackColor = System.Drawing.Color.White
        Me.lblBAGAZO_BRUTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBAGAZO_BRUTO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAGAZO_BRUTO.ForeColor = System.Drawing.Color.Navy
        Me.lblBAGAZO_BRUTO.Location = New System.Drawing.Point(570, 33)
        Me.lblBAGAZO_BRUTO.Name = "lblBAGAZO_BRUTO"
        Me.lblBAGAZO_BRUTO.Size = New System.Drawing.Size(172, 29)
        Me.lblBAGAZO_BRUTO.TabIndex = 0
        Me.lblBAGAZO_BRUTO.Tag = "LecturaAparatos"
        Me.lblBAGAZO_BRUTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(30, 33)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 18)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Tipo de caña"
        '
        'cbxTipoLectura
        '
        Me.cbxTipoLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoLectura.Enabled = False
        Me.cbxTipoLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cbxTipoLectura.FormattingEnabled = True
        Me.cbxTipoLectura.Location = New System.Drawing.Point(525, 47)
        Me.cbxTipoLectura.Name = "cbxTipoLectura"
        Me.cbxTipoLectura.Size = New System.Drawing.Size(235, 32)
        Me.cbxTipoLectura.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(396, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Lectura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N°  TACO:"
        '
        'gbBascula
        '
        Me.gbBascula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBascula.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbBascula.Controls.Add(Me.GroupBox1)
        Me.gbBascula.Controls.Add(Me.gReciboCana)
        Me.gbBascula.Controls.Add(Me.btnVerRecibo)
        Me.gbBascula.Controls.Add(Me.Label11)
        Me.gbBascula.Controls.Add(Me.txtBASCULA_NETOToneladas)
        Me.gbBascula.Controls.Add(Me.Label15)
        Me.gbBascula.Controls.Add(Me.txtBASCULA_NETOLibras)
        Me.gbBascula.Controls.Add(Me.Label14)
        Me.gbBascula.Controls.Add(Me.Label13)
        Me.gbBascula.Controls.Add(Me.txtBASCULA_TARA)
        Me.gbBascula.Controls.Add(Me.txtBASCULA_BRUTO)
        Me.gbBascula.Controls.Add(Me.PictureBox2)
        Me.gbBascula.Controls.Add(Me.PictureBox1)
        Me.gbBascula.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBascula.Location = New System.Drawing.Point(12, 265)
        Me.gbBascula.Name = "gbBascula"
        Me.gbBascula.Size = New System.Drawing.Size(1008, 359)
        Me.gbBascula.TabIndex = 8
        Me.gbBascula.TabStop = False
        Me.gbBascula.Text = "Bascula"
        Me.gbBascula.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFechaPatio)
        Me.GroupBox1.Controls.Add(Me.lblFechaCarga)
        Me.GroupBox1.Controls.Add(Me.lblFechaCorta)
        Me.GroupBox1.Controls.Add(Me.lblFechaQuema)
        Me.GroupBox1.Controls.Add(Me.lblTipoTransporte)
        Me.GroupBox1.Controls.Add(Me.lblTipoCana)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(514, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 181)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del envío"
        '
        'lblFechaPatio
        '
        Me.lblFechaPatio.AutoSize = True
        Me.lblFechaPatio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPatio.Location = New System.Drawing.Point(118, 154)
        Me.lblFechaPatio.Name = "lblFechaPatio"
        Me.lblFechaPatio.Size = New System.Drawing.Size(0, 16)
        Me.lblFechaPatio.TabIndex = 11
        '
        'lblFechaCarga
        '
        Me.lblFechaCarga.AutoSize = True
        Me.lblFechaCarga.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCarga.Location = New System.Drawing.Point(118, 129)
        Me.lblFechaCarga.Name = "lblFechaCarga"
        Me.lblFechaCarga.Size = New System.Drawing.Size(0, 16)
        Me.lblFechaCarga.TabIndex = 10
        '
        'lblFechaCorta
        '
        Me.lblFechaCorta.AutoSize = True
        Me.lblFechaCorta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCorta.Location = New System.Drawing.Point(118, 104)
        Me.lblFechaCorta.Name = "lblFechaCorta"
        Me.lblFechaCorta.Size = New System.Drawing.Size(0, 16)
        Me.lblFechaCorta.TabIndex = 9
        '
        'lblFechaQuema
        '
        Me.lblFechaQuema.AutoSize = True
        Me.lblFechaQuema.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaQuema.Location = New System.Drawing.Point(118, 79)
        Me.lblFechaQuema.Name = "lblFechaQuema"
        Me.lblFechaQuema.Size = New System.Drawing.Size(0, 16)
        Me.lblFechaQuema.TabIndex = 8
        '
        'lblTipoTransporte
        '
        Me.lblTipoTransporte.AutoSize = True
        Me.lblTipoTransporte.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTransporte.Location = New System.Drawing.Point(118, 54)
        Me.lblTipoTransporte.Name = "lblTipoTransporte"
        Me.lblTipoTransporte.Size = New System.Drawing.Size(0, 16)
        Me.lblTipoTransporte.TabIndex = 7
        '
        'lblTipoCana
        '
        Me.lblTipoCana.AutoSize = True
        Me.lblTipoCana.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCana.Location = New System.Drawing.Point(118, 29)
        Me.lblTipoCana.Name = "lblTipoCana"
        Me.lblTipoCana.Size = New System.Drawing.Size(0, 16)
        Me.lblTipoCana.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fecha patio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Fecha carga:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Fecha corta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha quema:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tipo Transporte:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo de Caña:"
        '
        'gReciboCana
        '
        Me.gReciboCana.Controls.Add(Me.lblReciboCana)
        Me.gReciboCana.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gReciboCana.Location = New System.Drawing.Point(34, 27)
        Me.gReciboCana.Name = "gReciboCana"
        Me.gReciboCana.Size = New System.Drawing.Size(238, 60)
        Me.gReciboCana.TabIndex = 11
        Me.gReciboCana.TabStop = False
        Me.gReciboCana.Text = "N° de Recibo de Caña"
        '
        'lblReciboCana
        '
        Me.lblReciboCana.BackColor = System.Drawing.Color.White
        Me.lblReciboCana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReciboCana.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReciboCana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReciboCana.Location = New System.Drawing.Point(13, 24)
        Me.lblReciboCana.Name = "lblReciboCana"
        Me.lblReciboCana.Size = New System.Drawing.Size(208, 26)
        Me.lblReciboCana.TabIndex = 0
        Me.lblReciboCana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerRecibo
        '
        Me.btnVerRecibo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerRecibo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRecibo.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnVerRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerRecibo.Location = New System.Drawing.Point(832, 30)
        Me.btnVerRecibo.Name = "btnVerRecibo"
        Me.btnVerRecibo.Size = New System.Drawing.Size(153, 32)
        Me.btnVerRecibo.TabIndex = 10
        Me.btnVerRecibo.Text = "Ver recibo"
        Me.btnVerRecibo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(311, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "PESO NETO (Ton. métrica)"
        '
        'txtBASCULA_NETOToneladas
        '
        Me.txtBASCULA_NETOToneladas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBASCULA_NETOToneladas.ForeColor = System.Drawing.Color.Navy
        Me.txtBASCULA_NETOToneladas.Location = New System.Drawing.Point(314, 172)
        Me.txtBASCULA_NETOToneladas.Name = "txtBASCULA_NETOToneladas"
        Me.txtBASCULA_NETOToneladas.Size = New System.Drawing.Size(142, 26)
        Me.txtBASCULA_NETOToneladas.TabIndex = 8
        Me.txtBASCULA_NETOToneladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(309, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 18)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "PESO NETO (kg)"
        '
        'txtBASCULA_NETOLibras
        '
        Me.txtBASCULA_NETOLibras.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBASCULA_NETOLibras.ForeColor = System.Drawing.Color.Navy
        Me.txtBASCULA_NETOLibras.Location = New System.Drawing.Point(312, 117)
        Me.txtBASCULA_NETOLibras.Name = "txtBASCULA_NETOLibras"
        Me.txtBASCULA_NETOLibras.Size = New System.Drawing.Size(142, 26)
        Me.txtBASCULA_NETOLibras.TabIndex = 6
        Me.txtBASCULA_NETOLibras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(152, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 18)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "PESO TARA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(152, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "PESO BRUTO"
        '
        'txtBASCULA_TARA
        '
        Me.txtBASCULA_TARA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBASCULA_TARA.ForeColor = System.Drawing.Color.Navy
        Me.txtBASCULA_TARA.Location = New System.Drawing.Point(155, 172)
        Me.txtBASCULA_TARA.Name = "txtBASCULA_TARA"
        Me.txtBASCULA_TARA.Size = New System.Drawing.Size(132, 26)
        Me.txtBASCULA_TARA.TabIndex = 3
        Me.txtBASCULA_TARA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBASCULA_BRUTO
        '
        Me.txtBASCULA_BRUTO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBASCULA_BRUTO.ForeColor = System.Drawing.Color.Navy
        Me.txtBASCULA_BRUTO.Location = New System.Drawing.Point(152, 118)
        Me.txtBASCULA_BRUTO.Name = "txtBASCULA_BRUTO"
        Me.txtBASCULA_BRUTO.Size = New System.Drawing.Size(135, 26)
        Me.txtBASCULA_BRUTO.TabIndex = 2
        Me.txtBASCULA_BRUTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.SISPACAL.My.Resources.Resources.rastraVacia
        Me.PictureBox2.Location = New System.Drawing.Point(32, 158)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.SISPACAL.My.Resources.Resources.rastraLLena
        Me.PictureBox1.Location = New System.Drawing.Point(34, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gbLecturas
        '
        Me.gbLecturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLecturas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbLecturas.Controls.Add(Me.btnCapturar)
        Me.gbLecturas.Controls.Add(Me.btnLeerPuerto)
        Me.gbLecturas.Controls.Add(Me.btnGuardar)
        Me.gbLecturas.Controls.Add(Me.lstLecturas)
        Me.gbLecturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbLecturas.Location = New System.Drawing.Point(12, 96)
        Me.gbLecturas.Name = "gbLecturas"
        Me.gbLecturas.Size = New System.Drawing.Size(1018, 157)
        Me.gbLecturas.TabIndex = 4
        Me.gbLecturas.TabStop = False
        Me.gbLecturas.Text = "Lectura:"
        '
        'btnCapturar
        '
        Me.btnCapturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapturar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.Image = Global.SISPACAL.My.Resources.Resources.Target
        Me.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapturar.Location = New System.Drawing.Point(832, 67)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(153, 33)
        Me.btnCapturar.TabIndex = 2
        Me.btnCapturar.Text = "Capturar"
        Me.btnCapturar.UseVisualStyleBackColor = False
        '
        'btnLeerPuerto
        '
        Me.btnLeerPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLeerPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeerPuerto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeerPuerto.Image = Global.SISPACAL.My.Resources.Resources.ico_SerialInput
        Me.btnLeerPuerto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeerPuerto.Location = New System.Drawing.Point(832, 27)
        Me.btnLeerPuerto.Name = "btnLeerPuerto"
        Me.btnLeerPuerto.Size = New System.Drawing.Size(153, 34)
        Me.btnLeerPuerto.TabIndex = 0
        Me.btnLeerPuerto.Text = "Leer puerto"
        Me.btnLeerPuerto.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SISPACAL.My.Resources.Resources.RP_Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(832, 106)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(153, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'txtTACO
        '
        Me.txtTACO.BackColor = System.Drawing.Color.White
        Me.txtTACO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTACO.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTACO.Location = New System.Drawing.Point(94, 47)
        Me.txtTACO.MaxLength = 7
        Me.txtTACO.Name = "txtTACO"
        Me.txtTACO.Size = New System.Drawing.Size(178, 38)
        Me.txtTACO.TabIndex = 0
        Me.txtTACO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Black
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1020, 35)
        Me.lblTitulo.TabIndex = 56
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(844, 43)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(153, 34)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Image = Global.SISPACAL.My.Resources.Resources.new_file_btn
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(272, 47)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(97, 38)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lblTonsRecibidas
        '
        Me.lblTonsRecibidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTonsRecibidas.BackColor = System.Drawing.Color.Black
        Me.lblTonsRecibidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTonsRecibidas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTonsRecibidas.ForeColor = System.Drawing.Color.Lime
        Me.lblTonsRecibidas.Location = New System.Drawing.Point(557, 0)
        Me.lblTonsRecibidas.Name = "lblTonsRecibidas"
        Me.lblTonsRecibidas.Size = New System.Drawing.Size(394, 33)
        Me.lblTonsRecibidas.TabIndex = 57
        Me.lblTonsRecibidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTonsRecibidas.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1020, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTonsRecibidas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTACO)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbLecturas)
        Me.Controls.Add(Me.cbxTipoLectura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbBascula)
        Me.Controls.Add(Me.gbAnalisisLab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sistema de Pago por Calidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbAnalisisLab.ResumeLayout(False)
        Me.gbAnalisisLab.PerformLayout()
        Me.gbBascula.ResumeLayout(False)
        Me.gbBascula.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gReciboCana.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLecturas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLecturas As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoLectura As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbAnalisisLab As System.Windows.Forms.GroupBox
    Friend WithEvents etBrix As System.Windows.Forms.Label
    Friend WithEvents etPolAjustado As System.Windows.Forms.Label
    Friend WithEvents gbBascula As System.Windows.Forms.GroupBox
    Friend WithEvents gbLecturas As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBASCULA_TARA As System.Windows.Forms.TextBox
    Friend WithEvents txtBASCULA_BRUTO As System.Windows.Forms.TextBox
    Friend WithEvents btnLeerPuerto As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents txtTACO As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBASCULA_NETOLibras As System.Windows.Forms.TextBox
    Friend WithEvents lblTIPO_CAÑA As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblBAGAZO_BRUTO As System.Windows.Forms.Label
    Friend WithEvents lblBRIX As System.Windows.Forms.Label
    Friend WithEvents lblPOL As System.Windows.Forms.Label
    Friend WithEvents lblBAGAZO_NETO As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBASCULA_NETOToneladas As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnVerRecibo As System.Windows.Forms.Button
    Friend WithEvents lblPOL_Lectura As System.Windows.Forms.Label
    Friend WithEvents txtPH As System.Windows.Forms.TextBox
    Friend WithEvents etPH As System.Windows.Forms.Label
    Friend WithEvents gReciboCana As System.Windows.Forms.GroupBox
    Friend WithEvents lblReciboCana As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFechaPatio As System.Windows.Forms.Label
    Friend WithEvents lblFechaCarga As System.Windows.Forms.Label
    Friend WithEvents lblFechaCorta As System.Windows.Forms.Label
    Friend WithEvents lblFechaQuema As System.Windows.Forms.Label
    Friend WithEvents lblTipoTransporte As System.Windows.Forms.Label
    Friend WithEvents lblTipoCana As System.Windows.Forms.Label
    Friend WithEvents lblTonsRecibidas As System.Windows.Forms.Label
    Friend WithEvents lblFECHA_APLICA_MADURANTE As System.Windows.Forms.Label
    Friend WithEvents lblMADURANTE As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkQuemaProgramada As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuemaNoProgramada As System.Windows.Forms.CheckBox

End Class
