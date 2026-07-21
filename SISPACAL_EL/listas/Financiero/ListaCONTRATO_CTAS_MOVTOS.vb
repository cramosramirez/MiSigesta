''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_CTAS_MOVTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_CTAS_MOVTOS',
''' es una representación en memoria de los registros de la tabla CONTRATO_CTAS_MOVTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_CTAS_MOVTOS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_CTAS_MOVTOS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_CTAS_MOVTOS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_CTAS_MOVTOS
        Get
            Return CType((List(index)), CONTRATO_CTAS_MOVTOS)
        End Get
        Set(ByVal Value As CONTRATO_CTAS_MOVTOS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_CTAS_MOVTOS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_CTAS_MOVTOS = CType(List(i), CONTRATO_CTAS_MOVTOS)
            If s.ID_CONTRATO_CTAS_MOVTOS = value.ID_CONTRATO_CTAS_MOVTOS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTRATO_CTAS_MOVTOS As Int32) As CONTRATO_CTAS_MOVTOS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_CTAS_MOVTOS = CType(List(i), CONTRATO_CTAS_MOVTOS)
            If s.ID_CONTRATO_CTAS_MOVTOS = ID_CONTRATO_CTAS_MOVTOS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_CTAS_MOVTOSEnumerator
        Return New CONTRATO_CTAS_MOVTOSEnumerator(Me)
    End Function

    Public Class CONTRATO_CTAS_MOVTOSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_CTAS_MOVTOS)
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
