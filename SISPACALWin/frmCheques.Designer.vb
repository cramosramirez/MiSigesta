<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheques
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVerCheques = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbTodos = New System.Windows.Forms.RadioButton()
        Me.rdbContribuyente = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbNoContribuyente = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumChequeInicial = New System.Windows.Forms.TextBox()
        Me.txtNumChequeFinal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbxBANCOS1 = New SISPACAL.WinUC.cbxBANCOS()
        Me.CbxTIPO_PLANILLA1 = New SISPACAL.WinUC.cbxTIPO_PLANILLA()
        Me.CbxCATORCENA_ZAFRA1 = New SISPACAL.WinUC.cbxCATORCENA_ZAFRA()
        Me.CbxZAFRA1 = New SISPACAL.WinUC.cbxZAFRA()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxRANGO_COMPENSACION1 = New SISPACAL.WinUC.cbxRANGO_COMPENSACION()
        Me.lblRangoCompensacion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(766, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(173, 34)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVerCheques
        '
        Me.btnVerCheques.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerCheques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerCheques.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerCheques.Image = Global.SISPACAL.My.Resources.Resources.lhs_search
        Me.btnVerCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerCheques.Location = New System.Drawing.Point(766, 67)
        Me.btnVerCheques.Name = "btnVerCheques"
        Me.btnVerCheques.Size = New System.Drawing.Size(173, 32)
        Me.btnVerCheques.TabIndex = 19
        Me.btnVerCheques.Text = "Ver cheques"
        Me.btnVerCheques.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo de Planilla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Catorcena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Zafra"
        '
        'rdbTodos
        '
        Me.rdbTodos.AutoSize = True
        Me.rdbTodos.Checked = True
        Me.rdbTodos.Location = New System.Drawing.Point(16, 3)
        Me.rdbTodos.Name = "rdbTodos"
        Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rdbTodos.TabIndex = 21
        Me.rdbTodos.TabStop = True
        Me.rdbTodos.Text = "Todos"
        Me.rdbTodos.UseVisualStyleBackColor = True
        '
        'rdbContribuyente
        '
        Me.rdbContribuyente.AutoSize = True
        Me.rdbContribuyente.Location = New System.Drawing.Point(77, 3)
        Me.rdbContribuyente.Name = "rdbContribuyente"
        Me.rdbContribuyente.Size = New System.Drawing.Size(90, 17)
        Me.rdbContribuyente.TabIndex = 22
        Me.rdbContribuyente.Text = "Contribuyente"
        Me.rdbContribuyente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbNoContribuyente)
        Me.Panel1.Controls.Add(Me.rdbTodos)
        Me.Panel1.Controls.Add(Me.rdbContribuyente)
        Me.Panel1.Location = New System.Drawing.Point(438, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 23)
        Me.Panel1.TabIndex = 23
        '
        'rdbNoContribuyente
        '
        Me.rdbNoContribuyente.AutoSize = True
        Me.rdbNoContribuyente.Location = New System.Drawing.Point(173, 3)
        Me.rdbNoContribuyente.Name = "rdbNoContribuyente"
        Me.rdbNoContribuyente.Size = New System.Drawing.Size(106, 17)
        Me.rdbNoContribuyente.TabIndex = 23
        Me.rdbNoContribuyente.Text = "No contribuyente"
        Me.rdbNoContribuyente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Banco"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Del cheque "
        Me.Label5.Visible = False
        '
        'txtNumChequeInicial
        '
        Me.txtNumChequeInicial.Location = New System.Drawing.Point(125, 145)
        Me.txtNumChequeInicial.Name = "txtNumChequeInicial"
        Me.txtNumChequeInicial.Size = New System.Drawing.Size(87, 20)
        Me.txtNumChequeInicial.TabIndex = 27
        Me.txtNumChequeInicial.Visible = False
        '
        'txtNumChequeFinal
        '
        Me.txtNumChequeFinal.Location = New System.Drawing.Point(289, 145)
        Me.txtNumChequeFinal.Name = "txtNumChequeFinal"
        Me.txtNumChequeFinal.Size = New System.Drawing.Size(96, 20)
        Me.txtNumChequeFinal.TabIndex = 29
        Me.txtNumChequeFinal.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "al cheque"
        Me.Label6.Visible = False
        '
        'CbxBANCOS1
        '
        Me.CbxBANCOS1.AllowFindEntityType = Nothing
        Me.CbxBANCOS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxBANCOS1.Location = New System.Drawing.Point(125, 118)
        Me.CbxBANCOS1.Name = "CbxBANCOS1"
        Me.CbxBANCOS1.Size = New System.Drawing.Size(300, 21)
        Me.CbxBANCOS1.TabIndex = 24
        '
        'CbxTIPO_PLANILLA1
        '
        Me.CbxTIPO_PLANILLA1.AllowFindEntityType = Nothing
        Me.CbxTIPO_PLANILLA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTIPO_PLANILLA1.Location = New System.Drawing.Point(125, 64)
        Me.CbxTIPO_PLANILLA1.Name = "CbxTIPO_PLANILLA1"
        Me.CbxTIPO_PLANILLA1.Size = New System.Drawing.Size(300, 21)
        Me.CbxTIPO_PLANILLA1.TabIndex = 18
        '
        'CbxCATORCENA_ZAFRA1
        '
        Me.CbxCATORCENA_ZAFRA1.AllowFindEntityType = Nothing
        Me.CbxCATORCENA_ZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCATORCENA_ZAFRA1.Location = New System.Drawing.Point(125, 38)
        Me.CbxCATORCENA_ZAFRA1.Name = "CbxCATORCENA_ZAFRA1"
        Me.CbxCATORCENA_ZAFRA1.Size = New System.Drawing.Size(125, 21)
        Me.CbxCATORCENA_ZAFRA1.TabIndex = 16
        '
        'CbxZAFRA1
        '
        Me.CbxZAFRA1.AllowFindEntityType = Nothing
        Me.CbxZAFRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxZAFRA1.Location = New System.Drawing.Point(125, 12)
        Me.CbxZAFRA1.Name = "CbxZAFRA1"
        Me.CbxZAFRA1.Size = New System.Drawing.Size(125, 21)
        Me.CbxZAFRA1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(391, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 32)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "(Si no especifica numeros de cheque se imprimirán todos los cheques generados del" & _
    " banco seleccionado)"
        Me.Label7.Visible = False
        '
        'cbxRANGO_COMPENSACION1
        '
        Me.cbxRANGO_COMPENSACION1.AllowFindEntityType = Nothing
        Me.cbxRANGO_COMPENSACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRANGO_COMPENSACION1.Location = New System.Drawing.Point(125, 91)
        Me.cbxRANGO_COMPENSACION1.Name = "cbxRANGO_COMPENSACION1"
        Me.cbxRANGO_COMPENSACION1.Size = New System.Drawing.Size(300, 21)
        Me.cbxRANGO_COMPENSACION1.TabIndex = 56
        Me.cbxRANGO_COMPENSACION1.Visible = False
        '
        'lblRangoCompensacion
        '
        Me.lblRangoCompensacion.AutoSize = True
        Me.lblRangoCompensacion.Location = New System.Drawing.Point(11, 95)
        Me.lblRangoCompensacion.Name = "lblRangoCompensacion"
        Me.lblRangoCompensacion.Size = New System.Drawing.Size(112, 13)
        Me.lblRangoCompensacion.TabIndex = 55
        Me.lblRangoCompensacion.Text = "Rango Compensación"
        Me.lblRangoCompensacion.Visible = False
        '
        'frmCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 484)
        Me.Controls.Add(Me.cbxRANGO_COMPENSACION1)
        Me.Controls.Add(Me.lblRangoCompensacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumChequeFinal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumChequeInicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxBANCOS1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVerCheques)
        Me.Controls.Add(Me.CbxTIPO_PLANILLA1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxCATORCENA_ZAFRA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxZAFRA1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheques"
        Me.Text = "Cheques"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVerCheques As System.Windows.Forms.Button
    Friend WithEvents CbxTIPO_PLANILLA1 As SISPACAL.WinUC.cbxTIPO_PLANILLA
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxCATORCENA_ZAFRA1 As SISPACAL.WinUC.cbxCATORCENA_ZAFRA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxZAFRA1 As SISPACAL.WinUC.cbxZAFRA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rdbContribuyente As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdbNoContribuyente As System.Windows.Forms.RadioButton
    Friend WithEvents CbxBANCOS1 As SISPACAL.WinUC.cbxBANCOS
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumChequeInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtNumChequeFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxRANGO_COMPENSACION1 As SISPACAL.WinUC.cbxRANGO_COMPENSACION
    Friend WithEvents lblRangoCompensacion As System.Windows.Forms.Label
End Class
