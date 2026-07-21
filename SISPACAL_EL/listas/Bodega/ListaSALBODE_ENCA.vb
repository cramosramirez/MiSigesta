''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSALBODE_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SALBODE_ENCA',
''' es una representación en memoria de los registros de la tabla SALBODE_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSALBODE_ENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSALBODE_ENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SALBODE_ENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SALBODE_ENCA
        Get
            Return CType((List(index)), SALBODE_ENCA)
        End Get
        Set(ByVal Value As SALBODE_ENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SALBODE_ENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SALBODE_ENCA = CType(List(i), SALBODE_ENCA)
            If s.ID_SALBODE_ENCA = value.ID_SALBODE_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SALBODE_ENCA As Int32) As SALBODE_ENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SALBODE_ENCA = CType(List(i), SALBODE_ENCA)
            If s.ID_SALBODE_ENCA = ID_SALBODE_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SALBODE_ENCAEnumerator
        Return New SALBODE_ENCAEnumerator(Me)
    End Function

    Public Class SALBODE_ENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSALBODE_ENCA)
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
