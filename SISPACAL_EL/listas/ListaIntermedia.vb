''' -----------------------------------------------------------------------------
''' Project	 : SADPRO_EL
''' Class	 : EL.listaIntermedia
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'Intermedia',
''' es una representación en memoria de los registros de la tabla Intermedia
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaIntermedia
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaIntermedia )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As Intermedia)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As Intermedia
        Get
            Return CType((List(index)), Intermedia)
        End Get
        Set(ByVal Value As Intermedia)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As Intermedia) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As Intermedia = CType(List(i), Intermedia)
            If s.Envio = value.Envio Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal Envio As Int32) As Intermedia
        Dim i As Integer = 0
        While i < List.Count
            Dim s As Intermedia = CType(List(i), Intermedia)
            If s.Envio = Envio Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As IntermediaEnumerator
        Return New IntermediaEnumerator(Me)
    End Function

    Public Class IntermediaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaIntermedia)
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
