''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSUB_ZONAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SUB_ZONAS',
''' es una representación en memoria de los registros de la tabla SUB_ZONAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSUB_ZONAS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSUB_ZONAS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SUB_ZONAS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SUB_ZONAS
        Get
            Return CType((List(index)), SUB_ZONAS)
        End Get
        Set(ByVal Value As SUB_ZONAS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SUB_ZONAS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SUB_ZONAS = CType(List(i), SUB_ZONAS)
            If s.ZONA = value.ZONA _
            And s.SUB_ZONA = value.SUB_ZONA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ZONA As String, ByVal SUB_ZONA As String) As SUB_ZONAS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SUB_ZONAS = CType(List(i), SUB_ZONAS)
            If s.ZONA = ZONA _
            And s.SUB_ZONA = SUB_ZONA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SUB_ZONASEnumerator
        Return New SUB_ZONASEnumerator(Me)
    End Function

    Public Class SUB_ZONASEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSUB_ZONAS)
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
