''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTRANSPORTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TRANSPORTE',
''' es una representación en memoria de los registros de la tabla TRANSPORTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTRANSPORTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTRANSPORTE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TRANSPORTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TRANSPORTE
        Get
            Return CType((List(index)), TRANSPORTE)
        End Get
        Set(ByVal Value As TRANSPORTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TRANSPORTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TRANSPORTE = CType(List(i), TRANSPORTE)
            If s.ID_TRANSPORTE = value.ID_TRANSPORTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TRANSPORTE As Int32) As TRANSPORTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TRANSPORTE = CType(List(i), TRANSPORTE)
            If s.ID_TRANSPORTE = ID_TRANSPORTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TRANSPORTEEnumerator
        Return New TRANSPORTEEnumerator(Me)
    End Function

    Public Class TRANSPORTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTRANSPORTE)
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
