''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCENSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CENSO',
''' es una representación en memoria de los registros de la tabla CENSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCENSO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCENSO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CENSO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CENSO
        Get
            Return CType((List(index)), CENSO)
        End Get
        Set(ByVal Value As CENSO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CENSO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CENSO = CType(List(i), CENSO)
            If s.ID_CENSO = value.ID_CENSO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CENSO As Int32) As CENSO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CENSO = CType(List(i), CENSO)
            If s.ID_CENSO = ID_CENSO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CENSOEnumerator
        Return New CENSOEnumerator(Me)
    End Function

    Public Class CENSOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCENSO)
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
