''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCANTON
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CANTON',
''' es una representación en memoria de los registros de la tabla CANTON
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCANTON
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCANTON )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CANTON)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CANTON
        Get
            Return CType((List(index)), CANTON)
        End Get
        Set(ByVal Value As CANTON)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CANTON) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CANTON = CType(List(i), CANTON)
            If s.CODI_CANTON = value.CODI_CANTON _
            And s.CODI_DEPTO = value.CODI_DEPTO _
            And s.CODI_MUNI = value.CODI_MUNI Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) As CANTON
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CANTON = CType(List(i), CANTON)
            If s.CODI_CANTON = CODI_CANTON _
            And s.CODI_DEPTO = CODI_DEPTO _
            And s.CODI_MUNI = CODI_MUNI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CANTONEnumerator
        Return New CANTONEnumerator(Me)
    End Function

    Public Class CANTONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCANTON)
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
