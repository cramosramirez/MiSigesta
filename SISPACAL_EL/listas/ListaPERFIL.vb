''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PERFIL',
''' es una representación en memoria de los registros de la tabla PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPERFIL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPERFIL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PERFIL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PERFIL
        Get
            Return CType((List(index)), PERFIL)
        End Get
        Set(ByVal Value As PERFIL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PERFIL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PERFIL = CType(List(i), PERFIL)
            If s.ID_PERFIL = value.ID_PERFIL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PERFIL As Int32) As PERFIL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PERFIL = CType(List(i), PERFIL)
            If s.ID_PERFIL = ID_PERFIL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PERFILEnumerator
        Return New PERFILEnumerator(Me)
    End Function

    Public Class PERFILEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPERFIL)
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
