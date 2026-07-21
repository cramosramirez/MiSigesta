''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLECTURA_POR_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LECTURA_POR_PERFIL',
''' es una representación en memoria de los registros de la tabla LECTURA_POR_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLECTURA_POR_PERFIL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLECTURA_POR_PERFIL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LECTURA_POR_PERFIL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LECTURA_POR_PERFIL
        Get
            Return CType((List(index)), LECTURA_POR_PERFIL)
        End Get
        Set(ByVal Value As LECTURA_POR_PERFIL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LECTURA_POR_PERFIL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LECTURA_POR_PERFIL = CType(List(i), LECTURA_POR_PERFIL)
            If s.ID_LECTURA_PERFIL = value.ID_LECTURA_PERFIL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_LECTURA_PERFIL As Int32) As LECTURA_POR_PERFIL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LECTURA_POR_PERFIL = CType(List(i), LECTURA_POR_PERFIL)
            If s.ID_LECTURA_PERFIL = ID_LECTURA_PERFIL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LECTURA_POR_PERFILEnumerator
        Return New LECTURA_POR_PERFILEnumerator(Me)
    End Function

    Public Class LECTURA_POR_PERFILEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLECTURA_POR_PERFIL)
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
