''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaREQETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REQETAPA',
''' es una representación en memoria de los registros de la tabla REQETAPA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREQETAPA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaREQETAPA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As REQETAPA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As REQETAPA
        Get
            Return CType((List(index)), REQETAPA)
        End Get
        Set(ByVal Value As REQETAPA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As REQETAPA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REQETAPA = CType(List(i), REQETAPA)
            If s.ID_REQETAPA = value.ID_REQETAPA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_REQETAPA As Int32) As REQETAPA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REQETAPA = CType(List(i), REQETAPA)
            If s.ID_REQETAPA = ID_REQETAPA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As REQETAPAEnumerator
        Return New REQETAPAEnumerator(Me)
    End Function

    Public Class REQETAPAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaREQETAPA)
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
