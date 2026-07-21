''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPRE_ANALISIS_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PRE_ANALISIS_ENCA',
''' es una representación en memoria de los registros de la tabla PRE_ANALISIS_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPRE_ANALISIS_ENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPRE_ANALISIS_ENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PRE_ANALISIS_ENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PRE_ANALISIS_ENCA
        Get
            Return CType((List(index)), PRE_ANALISIS_ENCA)
        End Get
        Set(ByVal Value As PRE_ANALISIS_ENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PRE_ANALISIS_ENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRE_ANALISIS_ENCA = CType(List(i), PRE_ANALISIS_ENCA)
            If s.ID_ENCA = value.ID_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ENCA As Int32) As PRE_ANALISIS_ENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRE_ANALISIS_ENCA = CType(List(i), PRE_ANALISIS_ENCA)
            If s.ID_ENCA = ID_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PRE_ANALISIS_ENCAEnumerator
        Return New PRE_ANALISIS_ENCAEnumerator(Me)
    End Function

    Public Class PRE_ANALISIS_ENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPRE_ANALISIS_ENCA)
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
