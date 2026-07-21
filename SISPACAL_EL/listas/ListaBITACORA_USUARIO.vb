''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBITACORA_USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'BITACORA_USUARIO',
''' es una representación en memoria de los registros de la tabla BITACORA_USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaBITACORA_USUARIO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBITACORA_USUARIO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BITACORA_USUARIO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BITACORA_USUARIO
        Get
            Return CType((List(index)), BITACORA_USUARIO)
        End Get
        Set(ByVal Value As BITACORA_USUARIO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BITACORA_USUARIO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BITACORA_USUARIO = CType(List(i), BITACORA_USUARIO)
            If s.ID_BITACORA = value.ID_BITACORA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_BITACORA As Int32) As BITACORA_USUARIO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BITACORA_USUARIO = CType(List(i), BITACORA_USUARIO)
            If s.ID_BITACORA = ID_BITACORA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BITACORA_USUARIOEnumerator
        Return New BITACORA_USUARIOEnumerator(Me)
    End Function

    Public Class BITACORA_USUARIOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBITACORA_USUARIO)
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
