''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR_QUERQUEO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_QUERQUEO',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_QUERQUEO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_QUERQUEO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR_QUERQUEO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR_QUERQUEO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR_QUERQUEO
        Get
            Return CType((List(index)), PROVEEDOR_QUERQUEO)
        End Get
        Set(ByVal Value As PROVEEDOR_QUERQUEO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR_QUERQUEO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_QUERQUEO = CType(List(i), PROVEEDOR_QUERQUEO)
            If s.ID_PROVEE_QQ = value.ID_PROVEE_QQ Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROVEE_QQ As Int32) As PROVEEDOR_QUERQUEO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_QUERQUEO = CType(List(i), PROVEEDOR_QUERQUEO)
            If s.ID_PROVEE_QQ = ID_PROVEE_QQ Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOR_QUERQUEOEnumerator
        Return New PROVEEDOR_QUERQUEOEnumerator(Me)
    End Function

    Public Class PROVEEDOR_QUERQUEOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR_QUERQUEO)
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
