''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_CTAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_CTAS',
''' es una representación en memoria de los registros de la tabla CONTRATO_CTAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_CTAS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_CTAS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_CTAS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_CTAS
        Get
            Return CType((List(index)), CONTRATO_CTAS)
        End Get
        Set(ByVal Value As CONTRATO_CTAS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_CTAS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_CTAS = CType(List(i), CONTRATO_CTAS)
            If s.ID_CONTRATO_CTAS = value.ID_CONTRATO_CTAS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTRATO_CTAS As Int32) As CONTRATO_CTAS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_CTAS = CType(List(i), CONTRATO_CTAS)
            If s.ID_CONTRATO_CTAS = ID_CONTRATO_CTAS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_CTASEnumerator
        Return New CONTRATO_CTASEnumerator(Me)
    End Function

    Public Class CONTRATO_CTASEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_CTAS)
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
