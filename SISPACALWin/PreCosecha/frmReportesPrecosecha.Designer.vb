<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesPrecosecha
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnVerReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dteFechaHoraInicial = New System.Windows.Forms.DateTimePicker()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dteFechaHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbxPreCosecha = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbxPreCosecha)
        Me.LayoutControl1.Controls.Add(Me.dteFechaHoraFinal)
        Me.LayoutControl1.Controls.Add(Me.dteFechaHoraInicial)
        Me.LayoutControl1.Controls.Add(Me.btnVerReporte)
        Me.LayoutControl1.Controls.Add(Me.btnCancelar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(440, 249, 399, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(461, 194)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(12, 85)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(221, 22)
        Me.btnVerReporte.StyleController = Me.LayoutControl1
        Me.btnVerReporte.TabIndex = 10
        Me.btnVerReporte.Text = "Ver Reporte"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(237, 85)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(212, 22)
        Me.btnCancelar.StyleController = Me.LayoutControl1
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(461, 194)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnVerReporte
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 101)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnCancelar
        Me.LayoutControlItem1.CustomizationFormText = "Cancelar"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(225, 73)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(216, 101)
        Me.LayoutControlItem1.Text = "Cancelar"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'dteFechaHoraInicial
        '
        Me.dteFechaHoraInicial.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dteFechaHoraInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dteFechaHoraInicial.Location = New System.Drawing.Point(106, 37)
        Me.dteFechaHoraInicial.Name = "dteFechaHoraInicial"
        Me.dteFechaHoraInicial.Size = New System.Drawing.Size(343, 21)
        Me.dteFechaHoraInicial.TabIndex = 11
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dteFechaHoraInicial
        Me.LayoutControlItem3.CustomizationFormText = "Fecha/Hora Inicial:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem3.Text = "Fecha/Hora Inicial:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(90, 13)
        '
        'dteFechaHoraFinal
        '
        Me.dteFechaHoraFinal.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dteFechaHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dteFechaHoraFinal.Location = New System.Drawing.Point(106, 61)
        Me.dteFechaHoraFinal.Name = "dteFechaHoraFinal"
        Me.dteFechaHoraFinal.Size = New System.Drawing.Size(343, 21)
        Me.dteFechaHoraFinal.TabIndex = 12
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dteFechaHoraFinal
        Me.LayoutControlItem4.CustomizationFormText = "Fecha/Hora Final:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem4.Text = "Fecha/Hora Final:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(90, 13)
        '
        'cbxPreCosecha
        '
        Me.cbxPreCosecha.FormattingEnabled = True
        Me.cbxPreCosecha.Location = New System.Drawing.Point(106, 12)
        Me.cbxPreCosecha.Name = "cbxPreCosecha"
        Me.cbxPreCosecha.Size = New System.Drawing.Size(343, 21)
        Me.cbxPreCosecha.TabIndex = 13
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbxPreCosecha
        Me.LayoutControlItem6.CustomizationFormText = "Pre Cosecha:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(441, 25)
        Me.LayoutControlItem6.Text = "Pre Cosecha:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(90, 13)
        '
        'frmReportesPrecosecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 194)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.Name = "frmReportesPrecosecha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Muestras de Precosecha"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnVerReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbxPreCosecha As System.Windows.Forms.ComboBox
    Friend WithEvents dteFechaHoraFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaHoraInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
