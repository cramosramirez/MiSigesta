''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_TEXTURA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_TEXTURA',
''' es una representación en memoria de los registros de la tabla TIPO_TEXTURA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_TEXTURA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_TEXTURA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_TEXTURA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_TEXTURA
        Get
            Return CType((List(index)), TIPO_TEXTURA)
        End Get
        Set(ByVal Value As TIPO_TEXTURA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_TEXTURA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_TEXTURA = CType(List(i), TIPO_TEXTURA)
            If s.CODI_TEXTURA = value.CODI_TEXTURA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODI_TEXTURA As String) As TIPO_TEXTURA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_TEXTURA = CType(List(i), TIPO_TEXTURA)
            If s.CODI_TEXTURA = CODI_TEXTURA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_TEXTURAEnumerator
        Return New TIPO_TEXTURAEnumerator(Me)
    End Function

    Public Class TIPO_TEXTURAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_TEXTURA)
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
