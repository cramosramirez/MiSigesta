''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MUNICIPIO',
''' es una representación en memoria de los registros de la tabla MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMUNICIPIO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMUNICIPIO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MUNICIPIO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MUNICIPIO
        Get
            Return CType((List(index)), MUNICIPIO)
        End Get
        Set(ByVal Value As MUNICIPIO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MUNICIPIO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MUNICIPIO = CType(List(i), MUNICIPIO)
            If s.CODI_DEPTO = value.CODI_DEPTO _
            And s.CODI_MUNI = value.CODI_MUNI Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) As MUNICIPIO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MUNICIPIO = CType(List(i), MUNICIPIO)
            If s.CODI_DEPTO = CODI_DEPTO _
            And s.CODI_MUNI = CODI_MUNI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MUNICIPIOEnumerator
        Return New MUNICIPIOEnumerator(Me)
    End Function

    Public Class MUNICIPIOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMUNICIPIO)
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
