''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBODEGA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'BODEGA',
''' es una representación en memoria de los registros de la tabla BODEGA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaBODEGA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBODEGA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BODEGA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BODEGA
        Get
            Return CType((List(index)), BODEGA)
        End Get
        Set(ByVal Value As BODEGA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BODEGA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BODEGA = CType(List(i), BODEGA)
            If s.ID_BODEGA = value.ID_BODEGA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_BODEGA As Int32) As BODEGA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BODEGA = CType(List(i), BODEGA)
            If s.ID_BODEGA = ID_BODEGA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BODEGAEnumerator
        Return New BODEGAEnumerator(Me)
    End Function

    Public Class BODEGAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBODEGA)
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
