''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_PLANILLA_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_PLANILLA_DESCTO',
''' es una representación en memoria de los registros de la tabla TIPO_PLANILLA_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_PLANILLA_DESCTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_PLANILLA_DESCTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_PLANILLA_DESCTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_PLANILLA_DESCTO
        Get
            Return CType((List(index)), TIPO_PLANILLA_DESCTO)
        End Get
        Set(ByVal Value As TIPO_PLANILLA_DESCTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_PLANILLA_DESCTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_PLANILLA_DESCTO = CType(List(i), TIPO_PLANILLA_DESCTO)
            If s.ID_TIPO_PLANILLA_DESCTO = value.ID_TIPO_PLANILLA_DESCTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_PLANILLA_DESCTO As Int32) As TIPO_PLANILLA_DESCTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_PLANILLA_DESCTO = CType(List(i), TIPO_PLANILLA_DESCTO)
            If s.ID_TIPO_PLANILLA_DESCTO = ID_TIPO_PLANILLA_DESCTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_PLANILLA_DESCTOEnumerator
        Return New TIPO_PLANILLA_DESCTOEnumerator(Me)
    End Function

    Public Class TIPO_PLANILLA_DESCTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_PLANILLA_DESCTO)
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
