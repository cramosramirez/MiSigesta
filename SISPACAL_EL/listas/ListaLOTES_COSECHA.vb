''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLOTES_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LOTES_COSECHA',
''' es una representación en memoria de los registros de la tabla LOTES_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLOTES_COSECHA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLOTES_COSECHA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LOTES_COSECHA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LOTES_COSECHA
        Get
            Return CType((List(index)), LOTES_COSECHA)
        End Get
        Set(ByVal Value As LOTES_COSECHA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LOTES_COSECHA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_COSECHA = CType(List(i), LOTES_COSECHA)
            If s.ID_LOTES_COSECHA = value.ID_LOTES_COSECHA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_LOTES_COSECHA As Int32) As LOTES_COSECHA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_COSECHA = CType(List(i), LOTES_COSECHA)
            If s.ID_LOTES_COSECHA = ID_LOTES_COSECHA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LOTES_COSECHAEnumerator
        Return New LOTES_COSECHAEnumerator(Me)
    End Function

    Public Class LOTES_COSECHAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLOTES_COSECHA)
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
