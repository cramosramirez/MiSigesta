Imports System.Reflection
Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBase
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase Base para las colecciones de Entidades Empresariales
''' </summary>
''' <remarks>
''' Esta Clase incluye funcionalidad genérica de manejo de una colección, permitiendo
''' de esta forma mover un set de registros entre las capas. También pueden ser 
''' utilizadas como Origen de Datos de Controles en Web tales como DataGrid, 
''' DropDownList, DataList, etc. asi también como en Windows en controles como el 
''' DataGrid, ComboBox, etc.
''' </remarks>
''' <history>
''' 	[GenApp]	29/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public MustInherit Class listaBase
    Inherits CollectionBase
    Implements IBindingList

    Private _bindingList As IBindingList
    Private _supportsBinding As Boolean
    Private _PropertyHash As New System.Collections.Hashtable
    Private _filteredList As listaBase
    Private _OldList As listaBase
    Private _isFiltered As Boolean = False
    Private _listaCriteria() As Criteria
    Private _sortedList As listaBase
    Private _isSorted As Boolean = False
    Private _sortBy As PropertyDescriptor
    Private _fullPropertyName As String = String.Empty
    Private _sortDirection As ListSortDirection = ListSortDirection.Ascending

    Public ReadOnly Property BaseList() As IList
        Get
            Return IIf(_isFiltered, _filteredList, list)
        End Get
    End Property

    Public Sub New()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite agregar una Entidad a la Colección en la posición final.
    ''' </summary>
    ''' <param name="value">Objeto de Tipo entidadBase (o de una clase que herede
    ''' de la misma) que será agregado a la colección.</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Posición en la que se agregó el nuevo elemento.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Add(ByVal value As entidadBase) As Integer
        Return List.Add(value)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite Agregar un arreglo de Entidades en la posición final
    ''' </summary>
    ''' <param name="value">Arreglo de Objetos del Tipo entidadBase (o de una clase 
    ''' que herede de la misma) que será agregado a la colección.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub AgregarRango(ByVal value() As entidadBase)
        Dim counter As Integer = 0
        While (counter < value.Length)
            Me.Add(value(counter))
            counter += 1
        End While
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite Agregar una Colección de Entidades en la posición final
    ''' </summary>
    ''' <param name="value">Colección del Tipo listaBase (o de una clase 
    ''' que herede de la misma) que será agregado a la colección.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub AgregarRango(ByVal value As listaBase)
        Dim counter As Integer = 0
        While (counter < value.Count)
            Me.Add(value.List(counter))
            counter += 1
        End While
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Determina si la colección contiene una Entidad específica. 
    ''' </summary>
    ''' <param name="value">Objeto del tipo entidadBase que se va a buscar en la colección.</param>
    ''' <returns>true si la entidad se encuentra en la colección; en caso contrario, 
    ''' false.</returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Contiene(ByVal value As entidadBase) As Boolean
        Return List.Contains(value)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite que las entidades de la colección se copien en un arreglo del tipo 
    ''' entidadBase (o de una clase que herede de la misma) desde una posición 
    ''' específica de la colección. 
    ''' </summary>
    ''' <param name="array">Arreglo de Objetos del Tipo entidadBase (o de una clase 
    ''' que herede de la misma) donde se copiarán las entidades.</param>
    ''' <param name="index">Índice de base cero de la colección donde se comienza la 
    ''' copia de entidades.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CopiarHacia(ByVal array() As entidadBase, ByVal index As Integer)
        List.CopyTo(array, index)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite Insertar una entidad en la posición especificada
    ''' </summary>
    ''' <param name="index">Índice basado en cero en el que debe insertarse la entidad.</param>
    ''' <param name="value">Objeto del tipo entidadBase (o de una clase que herede de 
    ''' la misma) que sera insertado.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Insertar(ByVal index As Integer, ByVal value As entidadBase)
        List.Insert(index, value)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite eliminar la primera aparición de una entidad en la colección.
    ''' </summary>
    ''' <param name="value">Objeto del tipo entidadBase (o de una clase que herede de 
    ''' la misma) que sera eliminado de la colección</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Remover(ByVal value As entidadBase)
        List.Remove(value)
    End Sub

#Region "Ordenamiento, Busqueda y Filtro"

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite Ordenar la Lista por la Columna que recibe de parametro.
    ''' </summary>
    ''' <param name="nombreColumna">Columna por la cual se ordenara la lista</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub OrdenarPorColumna(ByVal nombreColumna As String)
        Me.OrdenarPorColumna(nombreColumna, SortOrder.Ascending)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Ordena la lista en base al comparador especificado!
    ''' </summary>
    ''' <param name="Comparador"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub OrdenarPorColumna(ByVal Comparador As IComparer)
        Me.InnerList.Sort(Comparador)
        Me._isSorted = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Ordena la lista en base a la propiedad especificada
    ''' </summary>
    ''' <param name="nombreColumna">Nombre de la propiedad</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub OrdenarPorColumna(ByVal nombreColumna As String, ByVal Orden As SortOrder)
        Me.InnerList.Sort(New Comparador(nombreColumna, Orden))
        Me._isSorted = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve una lista ordenada por la Columna que recibe de parametro.
    ''' </summary>
    ''' <param name="nombreColumna">Columna por la cual se ordenara la lista</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function DevolverListaOrdenadaPorColumna(ByVal nombreColumna As String) As listaBase
        Me.DevolverListaOrdenadaPorColumna(nombreColumna, SortOrder.Ascending)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve una lista con el orden especificado
    ''' </summary>
    ''' <param name="nombreColumna">Nombre de Propiedad de la entidad</param>
    ''' <param name="Orden">Indica el tipo de ordenacion de la lista</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function DevolverListaOrdenadaPorColumna(ByVal nombreColumna As String, ByVal Orden As SortOrder) As listaBase
        If InnerList.Count > 0 Then
            Dim arr As New ArrayList(Me.InnerList)
            Dim lista As listaBase = System.Activator.CreateInstance(Me.GetType)
            arr.Sort(New Comparador(nombreColumna, Orden))
            lista.AgregarRango(arr.ToArray(arr(0).GetType))
            Return lista
        End If
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve la Entidad en la Colección buscando por la columna y valor que recibe 
    ''' de parametro.
    ''' </summary>
    ''' <param name="nombreColumna">Columna por la cual se buscara la lista</param>
    ''' <param name="valor">Valor a buscar en la columna</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function BuscarPorColumna(ByVal nombreColumna As String, ByVal valor As Object, ByVal Ordenar As Boolean) As entidadBase
        Dim entity As entidadBase = Nothing
        Dim lista As IList
        If Not Me.IsSorted Then
            lista = Me.DevolverListaOrdenadaPorColumna(nombreColumna, SortOrder.Ascending)
        End If
        If lista Is Nothing Then
            Return Nothing
        End If
        Dim upperBound, lowerBound, mid As Integer
        upperBound = lista.Count - 1
        lowerBound = 0
        While (lowerBound <= upperBound)
            Dim tipoEntidad As Type = lista(lowerBound).GetType()
            Dim Propiedad As PropertyInfo = tipoEntidad.GetProperty(nombreColumna)
            mid = (upperBound + lowerBound) \ 2
            If (Propiedad.GetValue(lista(mid), Nothing) = valor) Then
                Return lista(mid)
            ElseIf (valor < Propiedad.GetValue(lista(mid), Nothing)) Then
                upperBound = mid - 1
            Else
                lowerBound = mid + 1
            End If
        End While
        Return Nothing
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve el Indice de la Entidad en la Colección buscando por la columna y 
    ''' valor que recibe de parametro.
    ''' </summary>
    ''' <param name="nombreColumna">Columna por la cual se buscara la lista</param>
    ''' <param name="valor">Valor a buscar en la columna</param>
    ''' <remarks>
    ''' sdfsdf
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function BuscarIndicePorColumna(ByVal nombreColumna As String, ByVal valor As Object, ByVal Ordenar As Boolean) As Integer
        Dim entity As entidadBase = Nothing
        Dim lista As IList
        If Not Me.IsSorted Then
            lista = Me.DevolverListaOrdenadaPorColumna(nombreColumna, SortOrder.Ascending)
        End If
        If lista Is Nothing Then
            Return -1
        End If
        Dim upperBound, lowerBound, mid, index As Integer
        index = -1
        upperBound = lista.Count - 1
        lowerBound = 0
        While (lowerBound <= upperBound)
            Dim tipoEntidad As Type = lista(lowerBound).GetType()
            Dim Propiedad As PropertyInfo = tipoEntidad.GetProperty(nombreColumna)
            mid = (upperBound + lowerBound) \ 2
            If (Propiedad.GetValue(lista(mid), Nothing) = valor) Then
                index = mid
                Exit While
            ElseIf (valor < Propiedad.GetValue(lista(mid), Nothing)) Then
                upperBound = mid - 1
            Else
                lowerBound = mid + 1
            End If
        End While
        If index = -1 Then Return -1
        If Not Me.IsSorted Then
            Return Me.InnerList.IndexOf(lista(index))
        End If
        Return index
    End Function

#End Region


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Obtener el Enumerador de la colección
    ''' </summary>
    ''' <returns>Devuelve el enumerador de la clase</returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shadows Function GetEnumerator() As entidadBaseEnumerator
        Return New entidadBaseEnumerator(Me)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' Project	 : SISPACAL_EL
    ''' Class	 : EL.listaBase.entidadBaseEnumerator
    ''' 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Clase que implementa un Enumerador Base de la Colección
    ''' </summary>
    ''' <remarks>
    ''' Esta implementación permite realizar iteraciones simples a través de la colección
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class entidadBaseEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Mappings"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[GenApp]	29/08/2013	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub New(ByVal Mappings As listaBase)
            Me.Local = Mappings
            Me.Base = Local.GetEnumerator()
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[GenApp]	29/08/2013	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Return Base.Current
            End Get
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[GenApp]	29/08/2013	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Return Base.MoveNext()
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[GenApp]	29/08/2013	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub Reset() Implements IEnumerator.Reset
            Base.Reset()
        End Sub
    End Class

    Public Sub AddIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.AddIndex
        If _supportsBinding Then
            _bindingList.AddIndex([property])
        End If
    End Sub

    Public Function AddNew() As Object Implements System.ComponentModel.IBindingList.AddNew
        If _supportsBinding Then
            Return _bindingList.AddNew()
        End If
        Return Nothing
    End Function

    Public Sub ApplyFilter(ByVal [property] As String, ByVal compareValue As Object)
        Me.ApplyFilter([property], compareValue, FilterOperand.Igual)
    End Sub

    Public Enum FilterOperand
        Igual = 1
        Diferente = 2
        Incluye = 3
        EmpiezaCon = 5
        TerminaCon = 6
        EsMayorA = 7
        EsMayorOIgualA = 8
        EsMenorQue = 9
        EsMenorOIgualQue = 10
    End Enum

    Public Sub ApplyFilter(ByVal [property] As String, ByVal compareValue As Object, ByVal operand As FilterOperand)

        Dim comparator As String
        Select Case operand
            Case FilterOperand.Igual
                comparator = "="
            Case FilterOperand.Diferente
                comparator = "<>"
            Case FilterOperand.Incluye
                comparator = "%*%"
            Case FilterOperand.EmpiezaCon
                comparator = "*%"
            Case FilterOperand.TerminaCon
                comparator = "%*"
            Case FilterOperand.EsMayorA
                comparator = ">"
            Case FilterOperand.EsMayorOIgualA
                comparator = ">="
            Case FilterOperand.EsMenorQue
                comparator = "<"
            Case FilterOperand.EsMenorOIgualQue
                comparator = "<="
        End Select

        If Me._listaCriteria Is Nothing Then
            ReDim _listaCriteria(0)
        End If

        _listaCriteria(0) = New Criteria([property], comparator, compareValue, "AND")

        Dim filterBy As PropertyDescriptor = GetPropertyDescriptor([property])

        If Not filterBy Is Nothing Then

            _filteredList = Reflection.Assembly.GetAssembly(CType(BaseList, listaBase).GetType).CreateInstance(CType(BaseList, listaBase).GetType.FullName)
            _OldList = Reflection.Assembly.GetAssembly(CType(BaseList, listaBase).GetType).CreateInstance(CType(BaseList, listaBase).GetType.FullName)

            For Each obj As Object In BaseList

                Dim f As Object = GetValue(obj, filterBy, [property])
                Select Case operand
                    Case FilterOperand.Igual
                        If f.Equals(compareValue) Then _filteredList.Add(obj)
                    Case FilterOperand.Diferente
                        If Not f.Equals(compareValue) Then _filteredList.Add(obj)
                    Case FilterOperand.Incluye
                        Try
                            Dim s1 As String = f.ToString()
                            Dim s2 As String = compareValue.ToString()
                            If s1.LastIndexOf(s2) <> -1 Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                    Case FilterOperand.EmpiezaCon
                        Try
                            Dim s1 As String = f.ToString()
                            Dim s2 As String = compareValue.ToString()
                            If s1.IndexOf(s2) = 0 Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                    Case FilterOperand.TerminaCon
                        Try
                            Dim s1 As String = f.ToString()
                            Dim s2 As String = compareValue.ToString()
                            If s1.LastIndexOf(s2) = s1.Length - s2.Length Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                    Case FilterOperand.EsMayorA
                        Try
                            'fdsafdsa()
                            If f > compareValue Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                    Case FilterOperand.EsMayorOIgualA
                        Try
                            If f >= compareValue Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                    Case FilterOperand.EsMenorQue
                        Try
                            If f < compareValue Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                    Case FilterOperand.EsMenorOIgualQue
                        Try
                            If f <= compareValue Then _filteredList.Add(obj)
                        Catch ex As Exception
                        End Try
                        'Case FilterOperand.NotIncludes
                        '    Try
                        '        Dim s1 As String = f.ToString()
                        '        Dim s2 As String = compareValue.ToString()
                        '        If s1.LastIndexOf(s2) = -1 Then _filteredList.Add(obj)
                        '    Catch ex As Exception
                        '    End Try

                End Select
            Next

            _isFiltered = True
            _OldList.AgregarRango(CType(List,listaBase))

            Me.Clear()
            Me.AgregarRango(_filteredList)

            If (_isSorted) Then DoSort()
            RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))
        End If

    End Sub

    Public Sub RemoveFilter()
        If _isFiltered Then
            _filteredList = Nothing
            _isFiltered = False
            Me.Clear()
            Me.AgregarRango(_OldList)
            _OldList = Nothing
            If _isSorted Then DoSort()
            RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))
        End If
    End Sub

    Public ReadOnly Property IsFiltered() As Boolean
        Get
            Return _isFiltered
        End Get
    End Property

    Public ReadOnly Property FilterCriteria() As Criteria
        Get

        End Get
    End Property

    Private Class ListItem
        Implements IComparable

        Public Item As Object
        Public Key As Object

        Public Sub New(ByVal aKey As Object, ByVal aItem As Object)
            Me.Key = aKey
            Me.Item = aItem
        End Sub

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim target As Object = CType(obj, ListItem).Key

            If TypeOf Key Is IComparable Then
                Return CType(Key, IComparable).CompareTo(target)
            Else
                If (Key.Equals(target)) Then
                    Return 0
                Else
                    Return Key.ToString().CompareTo(target.ToString())
                End If
            End If

        End Function

    End Class

    Private Sub DoSort()

        _sortedList.Clear()
        If (_sortBy Is Nothing) Then
            For Each obj As Object In BaseList
                '_sortedList.Add(New ListItem(obj, obj))
                _sortedList.Add(obj)
            Next
        Else
            Dim objectType As System.Type = Nothing
            For Each obj As Object In BaseList
                Dim sorter As Object = GetValue(obj, _sortBy, _fullPropertyName)
                If Not sorter Is Nothing And objectType Is Nothing Then
                    objectType = sorter.GetType()
                ElseIf sorter Is Nothing And Not objectType Is Nothing Then
                    sorter = GetNullEquivalent(objectType)
                ElseIf sorter Is Nothing And objectType Is Nothing Then
                    For Each obj2 As Object In BaseList
                        Dim sorter2 As Object = GetValue(obj2, _sortBy, _fullPropertyName)
                        If Not sorter2 Is Nothing Then
                            objectType = sorter2.GetType()
                            Exit For
                        End If
                    Next

                    If (objectType Is Nothing) Then objectType = GetType(String)

                    sorter = GetNullEquivalent(objectType)
                End If
                _sortedList.Add(obj)
                '_sortedList.Add(New ListItem(sorter, obj))
            Next
        End If

        '_sortedList.Sort()
        _isSorted = True

        RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))

    End Sub

    Private Sub UndoSort()
        _sortedList.Clear()
        _sortBy = Nothing
        _sortDirection = ListSortDirection.Ascending
        _isSorted = False
        RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))
    End Sub

    Private Function GetNullEquivalent(ByVal aType As Type) As Object
        If (aType Is GetType(System.DateTime)) Then Return DateTime.MinValue
        If (aType Is GetType(System.String)) Then Return String.Empty
        Return Nothing
    End Function

    Private Function GetPropertyDescriptor(ByVal [property] As String) As PropertyDescriptor

        Dim itemType As Type = Nothing
        If [property].Length > 0 Then
            If _PropertyHash.Count = 0 Then

                Dim props As PropertyDescriptorCollection = Nothing

                Dim t As Type = (CType(BaseList, Object)).GetType()
                Dim defaultMembers As MemberInfo() = t.GetDefaultMembers()
                For Each member As MemberInfo In defaultMembers
                    If member.MemberType = MemberTypes.Property Then
                        itemType = (CType(member, PropertyInfo)).GetGetMethod().ReturnType
                        GetProperties(itemType, _PropertyHash)
                        Exit For
                    End If
                Next
                ' if it is not a strongly-typed collection (eg if arraylist, etc)
                ' then just get the base type of the zeroth elt and assume all elts are the same. 
                If _PropertyHash.Count = 0 Then
                    If (BaseList.Count > 0) Then
                        itemType = BaseList(0).GetType()
                        props = TypeDescriptor.GetProperties(itemType)
                        For Each prop As PropertyDescriptor In props
                            _PropertyHash(prop.Name) = prop
                        Next
                    Else
                        Throw New Exception("Can not determine collection item type")
                    End If
                End If
            End If

            If _PropertyHash.ContainsKey([property]) Then
                Return CType(_PropertyHash([property]), PropertyDescriptor)
            End If
        End If
        Return Nothing
    End Function

    Private Sub GetProperties(ByVal itemType As Type, ByVal aPropertyHash As Hashtable)
        GetProperties(String.Empty, itemType, aPropertyHash)
    End Sub

    Private Sub GetProperties(ByVal propertyNamePrefix As String, ByVal itemType As Type, ByVal aPropertyHash As Hashtable)

        Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(itemType)
        For Each pd As PropertyDescriptor In props
            If pd.PropertyType Is itemType Then
                Throw New SystemException("Due to the crappy implemetation, nested types are not allowed")
            End If
            If IsSortableType(pd.PropertyType) Then
                Dim propertyName As String = IIf(propertyNamePrefix.Length > 0, propertyNamePrefix + "." + pd.Name, pd.Name)
                If IsNestedType(pd.PropertyType) Then
                    GetProperties(propertyName, pd.PropertyType, _PropertyHash)
                Else
                    _PropertyHash.Add(propertyName, pd)
                End If
            End If
        Next
    End Sub

    Private Function IsSortableType(ByVal aType As Type) As Boolean
        Return (Not (aType.Equals(GetType(ArrayList))) And Not (aType.IsSubclassOf(GetType(CollectionBase))))
    End Function

    Private Function IsNestedType(ByVal aType As Type) As Boolean
        Return (Not aType.IsValueType And Not (aType.Equals(GetType(String))) And Not (aType.Equals(GetType(Object))))
    End Function

    Private Function GetValue(ByVal obj As Object, ByVal [property] As PropertyDescriptor, ByVal fullPropertyName As String) As Object

        ' Object is type, just return it's value
        If obj.GetType() Is [property].ComponentType Then
            Return [property].GetValue(obj)
        End If
        '' Must be a child
        Dim child As Object = FindChild(obj, [property], fullPropertyName)
        If child <> Nothing Then Return [property].GetValue(child)

        Throw New Exception("Reflection Error: Couldn't Find Child Property")
    End Function

    Private Function FindChild(ByVal obj As Object, ByVal [property] As PropertyDescriptor, ByVal fullPropertyName As String) As Object
        Return FindChild(obj, [property], fullPropertyName, String.Empty)
    End Function

    Private Function FindChild(ByVal obj As Object, ByVal [property] As PropertyDescriptor, ByVal fullPropertyName As String, ByVal recursiveName As String) As Object
        Dim pi As PropertyInfo() = obj.GetType().GetProperties()
        For Each prop As PropertyInfo In pi

            Dim lMethodInfo As MethodInfo = prop.GetGetMethod()
            ' If name and type are the same, we gotta asume we have the right object
            If (recursiveName + prop.Name = fullPropertyName And lMethodInfo.ReturnType Is [property].PropertyType) Then
                Return obj
            ElseIf (IsSortableType(lMethodInfo.ReturnType) And IsNestedType(lMethodInfo.ReturnType)) Then
                Dim o As Object = FindChild(prop.GetGetMethod().Invoke(obj, Nothing), [property], fullPropertyName, recursiveName + prop.Name + ".")
                If o <> Nothing Then Return o
            End If
        Next

        Return Nothing
    End Function

    Public ReadOnly Property AllowEdit() As Boolean Implements System.ComponentModel.IBindingList.AllowEdit
        Get
            If _supportsBinding Then
                Return _bindingList.AllowEdit
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property AllowNew() As Boolean Implements System.ComponentModel.IBindingList.AllowNew
        Get
            If _supportsBinding Then
                Return _bindingList.AllowNew
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property AllowRemove() As Boolean Implements System.ComponentModel.IBindingList.AllowRemove
        Get
            If _supportsBinding Then
                Return _bindingList.AllowRemove
            Else
                Return False
            End If
        End Get
    End Property

    Public Sub ApplySort(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements System.ComponentModel.IBindingList.ApplySort
        _sortBy = [property]
        _sortDirection = direction
        DoSort()
    End Sub

    Public Sub ApplySort(ByVal [property] As String, ByVal direction As System.ComponentModel.ListSortDirection)
        _sortBy = GetPropertyDescriptor([property])
        _fullPropertyName = [property]
        ApplySort(_sortBy, direction)
    End Sub

    Public Function Find(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal key As Object) As Integer Implements System.ComponentModel.IBindingList.Find
        If (_supportsBinding) Then
            Return _bindingList.Find([property], key)
        Else
            Return -1
        End If
    End Function

    Public ReadOnly Property IsSorted() As Boolean Implements System.ComponentModel.IBindingList.IsSorted
        Get
            Return _isSorted
        End Get
    End Property

    Public Event ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Implements System.ComponentModel.IBindingList.ListChanged

    Public Sub RemoveIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.RemoveIndex
        If _supportsBinding Then _bindingList.RemoveIndex([property])
    End Sub

    Public Sub RemoveSort() Implements System.ComponentModel.IBindingList.RemoveSort
        If (_isSorted) Then UndoSort()
    End Sub

    Public ReadOnly Property SortDirection() As System.ComponentModel.ListSortDirection Implements System.ComponentModel.IBindingList.SortDirection
        Get
            Return _sortDirection
        End Get
    End Property

    Public ReadOnly Property SortProperty() As System.ComponentModel.PropertyDescriptor Implements System.ComponentModel.IBindingList.SortProperty
        Get
            Return _sortBy
        End Get
    End Property

    Public ReadOnly Property SupportsChangeNotification() As Boolean Implements System.ComponentModel.IBindingList.SupportsChangeNotification
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property SupportsSearching() As Boolean Implements System.ComponentModel.IBindingList.SupportsSearching
        Get
            If (_supportsBinding) Then
                Return _bindingList.SupportsSearching
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property SupportsSorting() As Boolean Implements System.ComponentModel.IBindingList.SupportsSorting
        Get
            Return True
        End Get
    End Property


End Class

Public Class SimpleSortCompare
    Implements IComparer
    Private _PropDesc As PropertyDescriptor = Nothing
    Private _Direction As ListSortDirection = ListSortDirection.Ascending

    Public Sub New(ByVal propDesc As PropertyDescriptor, ByVal direction As ListSortDirection)
        _PropDesc = propDesc
        _Direction = direction
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        If Not _PropDesc Is Nothing Then
            Dim xValue As Object = _PropDesc.GetValue(x)
            Dim yValue As Object = _PropDesc.GetValue(y)
            Return ComparerValues(xValue, yValue, _Direction)
        End If
    End Function

    Private Function ComparerValues(ByVal xValue As Object, ByVal yValue As Object, ByVal direction As ListSortDirection)
        Dim retValue As Integer = 0
        If TypeOf xValue Is IComparable Then
            retValue = (DirectCast(xValue, IComparable)).CompareTo(yValue)
        Else
            If TypeOf yValue Is IComparable Then
                retValue = (DirectCast(yValue, IComparable)).CompareTo(xValue)
            Else
                If Not xValue.Equals(yValue) Then
                    retValue = xValue.ToString().CompareTo(yValue.ToString())
                End If
            End If
        End If
        If direction = ListSortDirection.Ascending Then
            Return retValue
        Else
            Return retValue * -1
        End If
    End Function

End Class
