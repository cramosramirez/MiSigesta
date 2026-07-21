''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR_CARGA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_CARGA',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_CARGA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_CARGA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR_CARGA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR_CARGA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR_CARGA
        Get
            Return CType((List(index)), PROVEEDOR_CARGA)
        End Get
        Set(ByVal Value As PROVEEDOR_CARGA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR_CARGA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_CARGA = CType(List(i), PROVEEDOR_CARGA)
            If s.ID_PROVEEDOR_CARGA = value.ID_PROVEEDOR_CARGA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROVEEDOR_CARGA As Int32) As PROVEEDOR_CARGA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_CARGA = CType(List(i), PROVEEDOR_CARGA)
            If s.ID_PROVEEDOR_CARGA = ID_PROVEEDOR_CARGA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOR_CARGAEnumerator
        Return New PROVEEDOR_CARGAEnumerator(Me)
    End Function

    Public Class PROVEEDOR_CARGAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR_CARGA)
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
