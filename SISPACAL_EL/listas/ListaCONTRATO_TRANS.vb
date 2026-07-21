''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_TRANS',
''' es una representación en memoria de los registros de la tabla CONTRATO_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_TRANS
        Get
            Return CType((List(index)), CONTRATO_TRANS)
        End Get
        Set(ByVal Value As CONTRATO_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_TRANS = CType(List(i), CONTRATO_TRANS)
            If s.ID_CONTRA_TRANS = value.ID_CONTRA_TRANS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTRA_TRANS As Int32) As CONTRATO_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_TRANS = CType(List(i), CONTRATO_TRANS)
            If s.ID_CONTRA_TRANS = ID_CONTRA_TRANS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_TRANSEnumerator
        Return New CONTRATO_TRANSEnumerator(Me)
    End Function

    Public Class CONTRATO_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_TRANS)
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
