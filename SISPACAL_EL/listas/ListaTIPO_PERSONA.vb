''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_PERSONA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_PERSONA',
''' es una representación en memoria de los registros de la tabla TIPO_PERSONA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_PERSONA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_PERSONA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_PERSONA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_PERSONA
        Get
            Return CType((List(index)), TIPO_PERSONA)
        End Get
        Set(ByVal Value As TIPO_PERSONA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_PERSONA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_PERSONA = CType(List(i), TIPO_PERSONA)
            If s.ID_TIPO_PERSONA = value.ID_TIPO_PERSONA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_PERSONA As Int32) As TIPO_PERSONA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_PERSONA = CType(List(i), TIPO_PERSONA)
            If s.ID_TIPO_PERSONA = ID_TIPO_PERSONA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_PERSONAEnumerator
        Return New TIPO_PERSONAEnumerator(Me)
    End Function

    Public Class TIPO_PERSONAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_PERSONA)
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
