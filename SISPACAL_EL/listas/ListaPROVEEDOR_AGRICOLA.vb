''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_AGRICOLA',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_AGRICOLA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR_AGRICOLA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR_AGRICOLA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR_AGRICOLA
        Get
            Return CType((List(index)), PROVEEDOR_AGRICOLA)
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR_AGRICOLA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_AGRICOLA = CType(List(i), PROVEEDOR_AGRICOLA)
            If s.ID_PROVEE = value.ID_PROVEE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROVEE As Int32) As PROVEEDOR_AGRICOLA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_AGRICOLA = CType(List(i), PROVEEDOR_AGRICOLA)
            If s.ID_PROVEE = ID_PROVEE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOR_AGRICOLAEnumerator
        Return New PROVEEDOR_AGRICOLAEnumerator(Me)
    End Function

    Public Class PROVEEDOR_AGRICOLAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR_AGRICOLA)
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
