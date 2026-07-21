''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_ZAFRAS_LG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_ZAFRAS_LG',
''' es una representación en memoria de los registros de la tabla CONTRATO_ZAFRAS_LG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_ZAFRAS_LG
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_ZAFRAS_LG )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_ZAFRAS_LG)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_ZAFRAS_LG
        Get
            Return CType((List(index)), CONTRATO_ZAFRAS_LG)
        End Get
        Set(ByVal Value As CONTRATO_ZAFRAS_LG)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_ZAFRAS_LG) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_ZAFRAS_LG = CType(List(i), CONTRATO_ZAFRAS_LG)
            If s.ID_CONTRATO_ZAFRAS = value.ID_CONTRATO_ZAFRAS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTRATO_ZAFRAS As Int32) As CONTRATO_ZAFRAS_LG
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_ZAFRAS_LG = CType(List(i), CONTRATO_ZAFRAS_LG)
            If s.ID_CONTRATO_ZAFRAS = ID_CONTRATO_ZAFRAS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_ZAFRAS_LGEnumerator
        Return New CONTRATO_ZAFRAS_LGEnumerator(Me)
    End Function

    Public Class CONTRATO_ZAFRAS_LGEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_ZAFRAS_LG)
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
