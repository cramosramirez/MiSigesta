''' -----------------------------------------------------------------------------
''' Project	 : INJIBOA_EL
''' Class	 : EL.listaLOTES_COSECHA_GESTION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LOTES_COSECHA_GESTION',
''' es una representación en memoria de los registros de la tabla LOTES_COSECHA_GESTION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/09/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLOTES_COSECHA_GESTION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLOTES_COSECHA_GESTION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LOTES_COSECHA_GESTION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LOTES_COSECHA_GESTION
        Get
            Return CType((List(index)), LOTES_COSECHA_GESTION)
        End Get
        Set(ByVal Value As LOTES_COSECHA_GESTION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LOTES_COSECHA_GESTION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_COSECHA_GESTION = CType(List(i), LOTES_COSECHA_GESTION)
            If s.ID_LOTE_COSE_GESTION = value.ID_LOTE_COSE_GESTION Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_LOTE_COSE_GESTION As Int32) As LOTES_COSECHA_GESTION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_COSECHA_GESTION = CType(List(i), LOTES_COSECHA_GESTION)
            If s.ID_LOTE_COSE_GESTION = ID_LOTE_COSE_GESTION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LOTES_COSECHA_GESTIONEnumerator
        Return New LOTES_COSECHA_GESTIONEnumerator(Me)
    End Function

    Public Class LOTES_COSECHA_GESTIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLOTES_COSECHA_GESTION)
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
