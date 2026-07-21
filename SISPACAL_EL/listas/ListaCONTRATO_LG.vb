''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_LG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_LG',
''' es una representación en memoria de los registros de la tabla CONTRATO_LG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_LG
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_LG )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_LG)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_LG
        Get
            Return CType((List(index)), CONTRATO_LG)
        End Get
        Set(ByVal Value As CONTRATO_LG)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_LG) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_LG = CType(List(i), CONTRATO_LG)
            If s.CODICONTRATO = value.CODICONTRATO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODICONTRATO As String) As CONTRATO_LG
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_LG = CType(List(i), CONTRATO_LG)
            If s.CODICONTRATO = CODICONTRATO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_LGEnumerator
        Return New CONTRATO_LGEnumerator(Me)
    End Function

    Public Class CONTRATO_LGEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_LG)
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
