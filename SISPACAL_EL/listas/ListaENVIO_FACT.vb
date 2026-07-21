''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaENVIO_FACT
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ENVIO_FACT',
''' es una representación en memoria de los registros de la tabla ENVIO_FACT
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaENVIO_FACT
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaENVIO_FACT )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ENVIO_FACT)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ENVIO_FACT
        Get
            Return CType((List(index)), ENVIO_FACT)
        End Get
        Set(ByVal Value As ENVIO_FACT)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ENVIO_FACT) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_FACT = CType(List(i), ENVIO_FACT)
            If s.ID_ENVIO_FACT = value.ID_ENVIO_FACT Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ENVIO_FACT As Int32) As ENVIO_FACT
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_FACT = CType(List(i), ENVIO_FACT)
            If s.ID_ENVIO_FACT = ID_ENVIO_FACT Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ENVIO_FACTEnumerator
        Return New ENVIO_FACTEnumerator(Me)
    End Function

    Public Class ENVIO_FACTEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaENVIO_FACT)
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
