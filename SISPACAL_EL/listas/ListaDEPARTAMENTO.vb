''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDEPARTAMENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DEPARTAMENTO',
''' es una representación en memoria de los registros de la tabla DEPARTAMENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDEPARTAMENTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDEPARTAMENTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DEPARTAMENTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DEPARTAMENTO
        Get
            Return CType((List(index)), DEPARTAMENTO)
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DEPARTAMENTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DEPARTAMENTO = CType(List(i), DEPARTAMENTO)
            If s.CODI_DEPTO = value.CODI_DEPTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODI_DEPTO As String) As DEPARTAMENTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DEPARTAMENTO = CType(List(i), DEPARTAMENTO)
            If s.CODI_DEPTO = CODI_DEPTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DEPARTAMENTOEnumerator
        Return New DEPARTAMENTOEnumerator(Me)
    End Function

    Public Class DEPARTAMENTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDEPARTAMENTO)
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
