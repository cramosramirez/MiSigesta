''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLICITANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLICITANTE',
''' es una representación en memoria de los registros de la tabla SOLICITANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLICITANTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLICITANTE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLICITANTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLICITANTE
        Get
            Return CType((List(index)), SOLICITANTE)
        End Get
        Set(ByVal Value As SOLICITANTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLICITANTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLICITANTE = CType(List(i), SOLICITANTE)
            If s.ID_SOLICITANTE = value.ID_SOLICITANTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLICITANTE As Int32) As SOLICITANTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLICITANTE = CType(List(i), SOLICITANTE)
            If s.ID_SOLICITANTE = ID_SOLICITANTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLICITANTEEnumerator
        Return New SOLICITANTEEnumerator(Me)
    End Function

    Public Class SOLICITANTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLICITANTE)
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
