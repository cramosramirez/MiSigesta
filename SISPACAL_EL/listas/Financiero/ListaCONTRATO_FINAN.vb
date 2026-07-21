''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_FINAN
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_FINAN',
''' es una representación en memoria de los registros de la tabla CONTRATO_FINAN
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_FINAN
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_FINAN )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_FINAN)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_FINAN
        Get
            Return CType((List(index)), CONTRATO_FINAN)
        End Get
        Set(ByVal Value As CONTRATO_FINAN)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_FINAN) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_FINAN = CType(List(i), CONTRATO_FINAN)
            If s.ID_CONTRATO_FINAN = value.ID_CONTRATO_FINAN Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTRATO_FINAN As Int32) As CONTRATO_FINAN
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_FINAN = CType(List(i), CONTRATO_FINAN)
            If s.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_FINANEnumerator
        Return New CONTRATO_FINANEnumerator(Me)
    End Function

    Public Class CONTRATO_FINANEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_FINAN)
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
