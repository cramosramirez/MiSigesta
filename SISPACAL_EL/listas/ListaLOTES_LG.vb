''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLOTES_LG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LOTES_LG',
''' es una representación en memoria de los registros de la tabla LOTES_LG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLOTES_LG
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLOTES_LG )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LOTES_LG)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LOTES_LG
        Get
            Return CType((List(index)), LOTES_LG)
        End Get
        Set(ByVal Value As LOTES_LG)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LOTES_LG) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_LG = CType(List(i), LOTES_LG)
            If s.ACCESLOTE = value.ACCESLOTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ACCESLOTE As String) As LOTES_LG
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTES_LG = CType(List(i), LOTES_LG)
            If s.ACCESLOTE = ACCESLOTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LOTES_LGEnumerator
        Return New LOTES_LGEnumerator(Me)
    End Function

    Public Class LOTES_LGEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLOTES_LG)
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
