<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.AgregarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FiltrarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.dgvCriteria = New System.Windows.Forms.DataGridView
        Me.Donde = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ColumnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comparacion = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.StringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Que = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Operador = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.QueryOperatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrar = New System.Windows.Forms.DataGridViewButtonColumn
        Me.DateTimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryOperatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripButton, Me.BuscarToolStripButton, Me.FiltrarToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(476, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AgregarToolStripButton
        '
        Me.AgregarToolStripButton.Image = Global.SISPACAL.WinUC.My.Resources.Resources.add_file
        Me.AgregarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AgregarToolStripButton.Name = "AgregarToolStripButton"
        Me.AgregarToolStripButton.Size = New System.Drawing.Size(66, 22)
        Me.AgregarToolStripButton.Text = "Agregar"
        Me.AgregarToolStripButton.ToolTipText = "Agregar Criterio"
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.SISPACAL.WinUC.My.Resources.Resources.view
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(59, 22)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'FiltrarToolStripButton
        '
        Me.FiltrarToolStripButton.Image = Global.SISPACAL.WinUC.My.Resources.Resources.filter
        Me.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FiltrarToolStripButton.Name = "FiltrarToolStripButton"
        Me.FiltrarToolStripButton.Size = New System.Drawing.Size(55, 22)
        Me.FiltrarToolStripButton.Text = "Filtrar"
        Me.FiltrarToolStripButton.Visible = False
        '
        'dgvCriteria
        '
        Me.dgvCriteria.AllowUserToOrderColumns = True
        Me.dgvCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCriteria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Donde, Me.Comparacion, Me.Que, Me.Operador, Me.Borrar})
        Me.dgvCriteria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCriteria.Location = New System.Drawing.Point(0, 25)
        Me.dgvCriteria.Name = "dgvCriteria"
        Me.dgvCriteria.Size = New System.Drawing.Size(476, 208)
        Me.dgvCriteria.TabIndex = 1
        '
        'Donde
        '
        Me.Donde.DataPropertyName = "ColumnName"
        Me.Donde.DataSource = Me.ColumnBindingSource
        Me.Donde.DisplayMember = "FriendlyName"
        Me.Donde.ValueMember = "Name"
        Me.Donde.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Donde.DropDownWidth = 3
        Me.Donde.HeaderText = "Donde"
        Me.Donde.Name = "Donde"
        Me.Donde.Width = 80
        '
        'Comparacion
        '
        Me.Comparacion.DataPropertyName = "Compare"
        Me.Comparacion.DataSource = Me.StringBindingSource
        Me.Comparacion.DisplayMember = "Text"
        Me.Comparacion.ValueMember = "Value"
        Me.Comparacion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Comparacion.DropDownWidth = 3
        Me.Comparacion.HeaderText = "Comparacion"
        Me.Comparacion.Name = "Comparacion"
        Me.Comparacion.Width = 80
        '
        'Que
        '
        Me.Que.DataPropertyName = "DataValue"
        Me.Que.HeaderText = "Que"
        Me.Que.Name = "Que"
        '
        'Operador
        '
        Me.Operador.DataPropertyName = "QueryOperator"
        Me.Operador.DataSource = Me.QueryOperatorBindingSource
        Me.Operador.DisplayMember = "Text"
        Me.Operador.ValueMember = "Value"
        Me.Operador.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Operador.DropDownWidth = 3
        Me.Operador.HeaderText = "Operador"
        Me.Operador.Name = "Operador"
        Me.Operador.Visible = False
        Me.Operador.Width = 60
        '
        'Borrar
        '
        Me.Borrar.HeaderText = ""
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseColumnTextForButtonValue = True
        Me.Borrar.Visible = False
        Me.Borrar.Width = 50
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 233)
        Me.Controls.Add(Me.dgvCriteria)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmFind"
        Me.Text = "Busqueda"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryOperatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FiltrarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AgregarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvCriteria As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueryOperatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Donde As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comparacion As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Que As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operador As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Borrar As System.Windows.Forms.DataGridViewButtonColumn
End Class

