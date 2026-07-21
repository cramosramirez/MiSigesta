''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaRECIBO_CANA_ANULADO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'RECIBO_CANA_ANULADO',
''' es una representación en memoria de los registros de la tabla RECIBO_CANA_ANULADO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaRECIBO_CANA_ANULADO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaRECIBO_CANA_ANULADO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As RECIBO_CANA_ANULADO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As RECIBO_CANA_ANULADO
        Get
            Return CType((List(index)), RECIBO_CANA_ANULADO)
        End Get
        Set(ByVal Value As RECIBO_CANA_ANULADO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As RECIBO_CANA_ANULADO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RECIBO_CANA_ANULADO = CType(List(i), RECIBO_CANA_ANULADO)
            If s.ID_RECIBO_CANA_ANUL = value.ID_RECIBO_CANA_ANUL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_RECIBO_CANA_ANUL As Int32) As RECIBO_CANA_ANULADO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RECIBO_CANA_ANULADO = CType(List(i), RECIBO_CANA_ANULADO)
            If s.ID_RECIBO_CANA_ANUL = ID_RECIBO_CANA_ANUL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As RECIBO_CANA_ANULADOEnumerator
        Return New RECIBO_CANA_ANULADOEnumerator(Me)
    End Function

    Public Class RECIBO_CANA_ANULADOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaRECIBO_CANA_ANULADO)
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
