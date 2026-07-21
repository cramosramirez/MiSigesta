''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaREQDETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REQDETA',
''' es una representación en memoria de los registros de la tabla REQDETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREQDETA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaREQDETA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As REQDETA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As REQDETA
        Get
            Return CType((List(index)), REQDETA)
        End Get
        Set(ByVal Value As REQDETA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As REQDETA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REQDETA = CType(List(i), REQDETA)
            If s.ID_REQDETA = value.ID_REQDETA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_REQDETA As Int32) As REQDETA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REQDETA = CType(List(i), REQDETA)
            If s.ID_REQDETA = ID_REQDETA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As REQDETAEnumerator
        Return New REQDETAEnumerator(Me)
    End Function

    Public Class REQDETAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaREQDETA)
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
