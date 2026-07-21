''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR_CODIGOREL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_CODIGOREL',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_CODIGOREL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_CODIGOREL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR_CODIGOREL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR_CODIGOREL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR_CODIGOREL
        Get
            Return CType((List(index)), PROVEEDOR_CODIGOREL)
        End Get
        Set(ByVal Value As PROVEEDOR_CODIGOREL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR_CODIGOREL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_CODIGOREL = CType(List(i), PROVEEDOR_CODIGOREL)
            If s.ID_PROVEE_CODIGOREL = value.ID_PROVEE_CODIGOREL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROVEE_CODIGOREL As Int32) As PROVEEDOR_CODIGOREL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_CODIGOREL = CType(List(i), PROVEEDOR_CODIGOREL)
            If s.ID_PROVEE_CODIGOREL = ID_PROVEE_CODIGOREL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOR_CODIGORELEnumerator
        Return New PROVEEDOR_CODIGORELEnumerator(Me)
    End Function

    Public Class PROVEEDOR_CODIGORELEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR_CODIGOREL)
            Me.Local = Mappings
            Me.Base = Local.GetEnumerator()
        End Sub

        ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Return Base.Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Return Base.MoveNext()
        End Function

        Sub Reset() Implements IEnumerator.Reset
            Base.Reset()
        End Sub
    End Class
End Class
