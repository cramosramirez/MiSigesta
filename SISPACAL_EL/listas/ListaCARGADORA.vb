''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CARGADORA',
''' es una representación en memoria de los registros de la tabla CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCARGADORA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCARGADORA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CARGADORA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CARGADORA
        Get
            Return CType((List(index)), CARGADORA)
        End Get
        Set(ByVal Value As CARGADORA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CARGADORA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CARGADORA = CType(List(i), CARGADORA)
            If s.ID_CARGADORA = value.ID_CARGADORA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CARGADORA As Int32) As CARGADORA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CARGADORA = CType(List(i), CARGADORA)
            If s.ID_CARGADORA = ID_CARGADORA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CARGADORAEnumerator
        Return New CARGADORAEnumerator(Me)
    End Function

    Public Class CARGADORAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCARGADORA)
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
