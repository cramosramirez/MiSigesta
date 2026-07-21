''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_SUELO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_SUELO',
''' es una representación en memoria de los registros de la tabla TIPO_SUELO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_SUELO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_SUELO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_SUELO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_SUELO
        Get
            Return CType((List(index)), TIPO_SUELO)
        End Get
        Set(ByVal Value As TIPO_SUELO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_SUELO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_SUELO = CType(List(i), TIPO_SUELO)
            If s.COD_TIPO_SUELO = value.COD_TIPO_SUELO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal COD_TIPO_SUELO As String) As TIPO_SUELO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_SUELO = CType(List(i), TIPO_SUELO)
            If s.COD_TIPO_SUELO = COD_TIPO_SUELO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_SUELOEnumerator
        Return New TIPO_SUELOEnumerator(Me)
    End Function

    Public Class TIPO_SUELOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_SUELO)
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
