''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaESTADO_SOLIC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTADO_SOLIC',
''' es una representación en memoria de los registros de la tabla ESTADO_SOLIC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTADO_SOLIC
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaESTADO_SOLIC )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ESTADO_SOLIC)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ESTADO_SOLIC
        Get
            Return CType((List(index)), ESTADO_SOLIC)
        End Get
        Set(ByVal Value As ESTADO_SOLIC)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ESTADO_SOLIC) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTADO_SOLIC = CType(List(i), ESTADO_SOLIC)
            If s.ID_ESTADO_SOLIC = value.ID_ESTADO_SOLIC Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ESTADO_SOLIC As Int32) As ESTADO_SOLIC
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTADO_SOLIC = CType(List(i), ESTADO_SOLIC)
            If s.ID_ESTADO_SOLIC = ID_ESTADO_SOLIC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ESTADO_SOLICEnumerator
        Return New ESTADO_SOLICEnumerator(Me)
    End Function

    Public Class ESTADO_SOLICEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaESTADO_SOLIC)
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
