''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCARGADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CARGADOR',
''' es una representación en memoria de los registros de la tabla CARGADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCARGADOR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCARGADOR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CARGADOR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CARGADOR
        Get
            Return CType((List(index)), CARGADOR)
        End Get
        Set(ByVal Value As CARGADOR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CARGADOR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CARGADOR = CType(List(i), CARGADOR)
            If s.ID_CARGADOR = value.ID_CARGADOR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CARGADOR As Int32) As CARGADOR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CARGADOR = CType(List(i), CARGADOR)
            If s.ID_CARGADOR = ID_CARGADOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CARGADOREnumerator
        Return New CARGADOREnumerator(Me)
    End Function

    Public Class CARGADOREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCARGADOR)
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
