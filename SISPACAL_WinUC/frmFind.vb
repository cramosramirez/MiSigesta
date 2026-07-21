Imports System.Reflection
Imports System.Collections.Generic

Public Class frmFind

    Public Enum TipoAccion As Integer
        Busqueda = 1
        Filtro = 2
        Consulta = 3
    End Enum

    Private _tipoAccion As TipoAccion = TipoAccion.Busqueda
    Private ColumnList As List(Of Column)
    Private CriteriaList As List(Of Criteria)
    Dim lPredicado As New PredicateColumn
    Public control As cbxBase
    Public BindingSourceControl As System.Windows.Forms.BindingSource
    Public listaDatos As IList
    Public entityType As Type
    Private entidadAsignada As entidadBase
    Private controller As New controladorBase

    Private Sub AgregarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripButton.Click
        Dim lCount As Integer = Me.dgvCriteria.Rows.Count
        If lCount >= 1 Then
            Me.dgvCriteria.Columns(3).Visible = True
            Me.dgvCriteria.Columns(4).Visible = True
        End If
        Me.CriteriaList.Add(New Criteria(ColumnList(0).Name, "=", "", "AND"))
        Me.CargarDatos()
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        If _tipoAccion = TipoAccion.Busqueda Then
            If Me.control Is Nothing Then
                Dim index As Integer
                index = Me.BindingSourceControl.Find(Me.CriteriaList(0).ColumnName, Me.CriteriaList(0).DataValue)
                If index = -1 Then
                    System.Windows.Forms.MessageBox.Show("No se encuentra ningun registro con ese criterio", configuracion.tituloAplicacion, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    Return
                End If
                Me.BindingSourceControl.Position = index
            Else
                Dim index As Integer
                index = CType(listaDatos, listaBase).BuscarIndicePorColumna(Me.CriteriaList(0).ColumnName, Me.CriteriaList(0).DataValue, True)
                If index = -1 Then
                    System.Windows.Forms.MessageBox.Show(Me.control.AllowFindMessageError, configuracion.tituloAplicacion, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                    Return
                End If
                Dim Propiedad As PropertyInfo = Me.entidadAsignada.GetType().GetProperty(Me.control.ValueMember)
                Me.control.SelectedValue = Propiedad.GetValue(Me.listaDatos(index), Nothing)
            End If
        ElseIf _tipoAccion = TipoAccion.Consulta Then
            Dim listaResultante As EL.listaBase
            If Not Me.control.listaCriteriosSeleccionados Is Nothing AndAlso Me.control.listaCriteriosSeleccionados.Count > 0 Then
                Me.CriteriaList.InsertRange(0, Me.control.listaCriteriosSeleccionados)
            End If
            listaResultante = controller.ObtenerListaPorBusqueda(entidadAsignada, Me.CriteriaList.ToArray)
            Me.control.CargarPorLista(listaResultante)
        End If
        Me.Close()
    End Sub

    Private Sub FiltrarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrarToolStripButton.Click
        Me.BindingSourceControl.RemoveFilter()
        Me.BindingSourceControl.Filter = Me.CriteriaList(0).ColumnName + " " + Me.CriteriaList(0).Compare + " " + Me.CriteriaList(0).DataValue
        Me.Close()
    End Sub

    Public Sub Inicializar(Optional ByVal aTipoAccion As TipoAccion = TipoAccion.Busqueda)
        _tipoAccion = aTipoAccion
        Select Case aTipoAccion
            Case TipoAccion.Filtro
                Me.BuscarToolStripButton.Visible = False
                Me.FiltrarToolStripButton.Visible = True
                Me.Comparacion.Visible = False
                Me.Que.HeaderText = "Es Igual a"
                Me.AgregarToolStripButton.Visible = False
            Case TipoAccion.Consulta
                Me.BuscarToolStripButton.Visible = True
                Me.BuscarToolStripButton.Text = "Consultar"
                Me.FiltrarToolStripButton.Visible = False
                Me.Que.HeaderText = "Que"
                Me.Comparacion.Visible = True
            Case TipoAccion.Busqueda
                Me.AgregarToolStripButton.Visible = False
                Me.Comparacion.Visible = False
                Me.Que.HeaderText = "Es Igual a"
        End Select

        If Me.entityType Is Nothing Then Me.Close()
        If Me.control Is Nothing And Me.BindingSourceControl Is Nothing Then Me.Close()
        entidadAsignada = System.Reflection.Assembly.GetAssembly(entityType).CreateInstance(entityType.FullName)
        Me.CargarEntidad()
        CriteriaList = New List(Of Criteria)
        CriteriaList.Add(New Criteria(ColumnList(0).Name, "=", "", "AND"))
        Me.StringBindingSource.DataSource = Me.ListStringComparator
        Me.DateTimeBindingSource.DataSource = Me.ListDateTimeComparator
        Me.OtherBindingSource.DataSource = Me.ListOtherComparator
        Me.QueryOperatorBindingSource.DataSource = Me.ListQueryOperator
        Me.ColumnBindingSource.DataSource = Me.ColumnList
        Me.CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Me.dgvCriteria.DataSource = Me.CriteriaList
    End Sub

    Private Sub CargarEntidad()
        Dim tipoEntidad As Type = Me.entityType
        Me.ColumnList = New List(Of Column)
        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()
            Dim atributoColumna As ColumnAttribute
            Dim atributoDataObject As System.ComponentModel.DataObjectFieldAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
            atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(System.ComponentModel.DataObjectFieldAttribute)), System.ComponentModel.DataObjectFieldAttribute)
            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If atributoDataObject Is Nothing Then
                    ColumnList.Add(New Column(atributoColumna.Storage, atributoColumna.Name, atributoColumna.DBType, PropiedadDestino.PropertyType.Name, True, 0, False))
                Else
                    ColumnList.Add(New Column(atributoColumna.Storage, atributoColumna.Name, atributoColumna.DBType, PropiedadDestino.PropertyType.Name, atributoDataObject.IsNullable, atributoDataObject.Length, atributoDataObject.PrimaryKey))
                End If
            End If
        Next
    End Sub

    Private Function ListStringComparator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Es Igual a", "="))
        lSelectCriteria.Add(New SelectCriteria("Contiene a", "%*%"))
        lSelectCriteria.Add(New SelectCriteria("Empieza con", "*%"))
        lSelectCriteria.Add(New SelectCriteria("Termina con", "%*"))
        lSelectCriteria.Add(New SelectCriteria("Es Diferente de", "<>"))
        Return lSelectCriteria
    End Function

    Private Function ListDateTimeComparator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Es Igual a", "="))
        lSelectCriteria.Add(New SelectCriteria("Es Mayor a", ">"))
        lSelectCriteria.Add(New SelectCriteria("Es mayor o Igual a", ">="))
        lSelectCriteria.Add(New SelectCriteria("Es Menor a", "<"))
        lSelectCriteria.Add(New SelectCriteria("Es Menor o Igual a", "<="))
        lSelectCriteria.Add(New SelectCriteria("Es Diferente de", "<>"))
        Return lSelectCriteria
    End Function

    Private Function ListOtherComparator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Es Igual a", "="))
        lSelectCriteria.Add(New SelectCriteria("Es Mayor a", ">"))
        lSelectCriteria.Add(New SelectCriteria("Es Mayor o Igual a", ">="))
        lSelectCriteria.Add(New SelectCriteria("Es Menor a", "<"))
        lSelectCriteria.Add(New SelectCriteria("Es Menor o Igual a", "<="))
        lSelectCriteria.Add(New SelectCriteria("Es Diferente de", "<>"))
        Return lSelectCriteria
    End Function

    Private Function ListQueryOperator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Y", "AND"))
        lSelectCriteria.Add(New SelectCriteria("O", "OR"))
        Return lSelectCriteria
    End Function

End Class

''' -----------------------------------------------------------------------------
''' Project	 : GeneraApp
''' Class	 : Columna
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que representa una Columna de una Tabla
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[ecarias]	15/11/2006	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class Column
    Inherits entidadBase

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
        End Set
    End Property

    Private _FriendlyName As String
    Public Property FriendlyName() As String
        Get
            Return _FriendlyName
        End Get
        Set(ByVal Value As String)
            _FriendlyName = Value
        End Set
    End Property

    Private _DBType As String
    Public Property DBType() As String
        Get
            If _DBType.IndexOf("[") > 0 Then
                _DBType.Replace("[", "(")
                _DBType.Replace("]", ")")
            End If
            Return _DBType
        End Get
        Set(ByVal Value As String)
            _DBType = Value
        End Set
    End Property

    Private _DataType As String
    Public Property DataType() As String
        Get
            If _DataType.IndexOf("[") > 0 Then
                _DataType.Replace("[", "(")
                _DataType.Replace("]", ")")
            End If
            Return _DataType
        End Get
        Set(ByVal Value As String)
            _DataType = Value
        End Set
    End Property

    Private _AllowNull As Boolean
    Public Property AllowNull() As Boolean
        Get
            Return _AllowNull
        End Get
        Set(ByVal Value As Boolean)
            _AllowNull = Value
        End Set
    End Property

    Private _Length As Integer
    Public Property Length() As Integer
        Get
            Return _Length
        End Get
        Set(ByVal Value As Integer)
            _Length = Value
        End Set
    End Property

    Private _IsPrimaryKey As Boolean
    Public Property IsPrimaryKey() As Boolean
        Get
            Return _IsPrimaryKey
        End Get
        Set(ByVal Value As Boolean)
            _IsPrimaryKey = Value
        End Set
    End Property

    Public Sub New(ByVal asName As String, ByVal asFriendlyName As String, ByVal asDBType As String, ByVal asDataType As String, ByVal abAllowNull As Boolean, ByVal aiLength As Integer, ByVal abIsPrimaryKey As Boolean)
        Me._Name = asName
        Me._FriendlyName = asFriendlyName
        Me._DBType = asDBType
        Me._DataType = asDataType
        Me._AllowNull = abAllowNull
        Me._Length = aiLength
        Me._IsPrimaryKey = abIsPrimaryKey
    End Sub

End Class

<Serializable()> Public Class PredicateColumn
    Public Name As String
    Public Function ExistColumn(ByVal aColumn As Column) As Boolean
        Return aColumn.Name = Name
    End Function
End Class

<Serializable()> Public Class SelectCriteria
    Private _Text As String
    Public Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal Value As String)
            _Text = Value
        End Set
    End Property

    Private _Value As String
    Public Property Value() As String
        Get
            Return _Value
        End Get
        Set(ByVal Value As String)
            _Value = Value
        End Set
    End Property

    Public Sub New(ByVal asText As String, ByVal asValue As String)
        Me._Text = asText
        Me._Value = asValue
    End Sub
End Class
