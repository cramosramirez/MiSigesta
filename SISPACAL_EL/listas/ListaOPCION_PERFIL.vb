''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaOPCION_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OPCION_PERFIL',
''' es una representación en memoria de los registros de la tabla OPCION_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOPCION_PERFIL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaOPCION_PERFIL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As OPCION_PERFIL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As OPCION_PERFIL
        Get
            Return CType((List(index)), OPCION_PERFIL)
        End Get
        Set(ByVal Value As OPCION_PERFIL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As OPCION_PERFIL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As OPCION_PERFIL = CType(List(i), OPCION_PERFIL)
            If s.ID_OPCION_PERFIL = value.ID_OPCION_PERFIL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_OPCION_PERFIL As Int32) As OPCION_PERFIL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As OPCION_PERFIL = CType(List(i), OPCION_PERFIL)
            If s.ID_OPCION_PERFIL = ID_OPCION_PERFIL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As OPCION_PERFILEnumerator
        Return New OPCION_PERFILEnumerator(Me)
    End Function

    Public Class OPCION_PERFILEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaOPCION_PERFIL)
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
