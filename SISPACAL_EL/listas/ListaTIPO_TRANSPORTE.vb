''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_TRANSPORTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_TRANSPORTE',
''' es una representación en memoria de los registros de la tabla TIPO_TRANSPORTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_TRANSPORTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_TRANSPORTE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_TRANSPORTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_TRANSPORTE
        Get
            Return CType((List(index)), TIPO_TRANSPORTE)
        End Get
        Set(ByVal Value As TIPO_TRANSPORTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_TRANSPORTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_TRANSPORTE = CType(List(i), TIPO_TRANSPORTE)
            If s.ID_TIPOTRANS = value.ID_TIPOTRANS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPOTRANS As Int32) As TIPO_TRANSPORTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_TRANSPORTE = CType(List(i), TIPO_TRANSPORTE)
            If s.ID_TIPOTRANS = ID_TIPOTRANS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_TRANSPORTEEnumerator
        Return New TIPO_TRANSPORTEEnumerator(Me)
    End Function

    Public Class TIPO_TRANSPORTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_TRANSPORTE)
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
