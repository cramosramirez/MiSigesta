''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaANALISIS_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ANALISIS_PRECOSECHA',
''' es una representación en memoria de los registros de la tabla ANALISIS_PRECOSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaANALISIS_PRECOSECHA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaANALISIS_PRECOSECHA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ANALISIS_PRECOSECHA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ANALISIS_PRECOSECHA
        Get
            Return CType((List(index)), ANALISIS_PRECOSECHA)
        End Get
        Set(ByVal Value As ANALISIS_PRECOSECHA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ANALISIS_PRECOSECHA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ANALISIS_PRECOSECHA = CType(List(i), ANALISIS_PRECOSECHA)
            If s.ID_ANALISIS_PRE = value.ID_ANALISIS_PRE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANALISIS_PRE As Int32) As ANALISIS_PRECOSECHA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ANALISIS_PRECOSECHA = CType(List(i), ANALISIS_PRECOSECHA)
            If s.ID_ANALISIS_PRE = ID_ANALISIS_PRE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ANALISIS_PRECOSECHAEnumerator
        Return New ANALISIS_PRECOSECHAEnumerator(Me)
    End Function

    Public Class ANALISIS_PRECOSECHAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaANALISIS_PRECOSECHA)
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
