''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLOTES_TRASPASO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LOTES_TRASPASO',
''' es una representación en memoria de los registros de la tabla LOTES_TRASPASO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLOTES_TRASPASO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLOTES_TRASPASO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LOTES_TRASPASO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LOTES_TRASPASO
        Get
            Return CType((List(index)), LOTES_TRASPASO)
        End Get
        Set(ByVal Value As LOTES_TRASPASO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LOTES_TRASPASO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_TRASPASO = CType(List(i), LOTES_TRASPASO)
            If s.ID_LOTE_TRASPASO = value.ID_LOTE_TRASPASO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_LOTE_TRASPASO As Int32) As LOTES_TRASPASO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_TRASPASO = CType(List(i), LOTES_TRASPASO)
            If s.ID_LOTE_TRASPASO = ID_LOTE_TRASPASO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LOTES_TRASPASOEnumerator
        Return New LOTES_TRASPASOEnumerator(Me)
    End Function

    Public Class LOTES_TRASPASOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLOTES_TRASPASO)
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
