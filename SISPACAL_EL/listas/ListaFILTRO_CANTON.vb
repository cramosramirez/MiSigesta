''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaFILTRO_CANTON
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FILTRO_CANTON',
''' es una representación en memoria de los registros de la tabla FILTRO_CANTON
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFILTRO_CANTON
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaFILTRO_CANTON )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As FILTRO_CANTON)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As FILTRO_CANTON
        Get
            Return CType((List(index)), FILTRO_CANTON)
        End Get
        Set(ByVal Value As FILTRO_CANTON)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As FILTRO_CANTON) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As FILTRO_CANTON = CType(List(i), FILTRO_CANTON)
            If s.ID_FILTRO_CANTON = value.ID_FILTRO_CANTON Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_FILTRO_CANTON As Int32) As FILTRO_CANTON
        Dim i As Integer = 0
        While i < List.Count
            Dim s As FILTRO_CANTON = CType(List(i), FILTRO_CANTON)
            If s.ID_FILTRO_CANTON = ID_FILTRO_CANTON Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As FILTRO_CANTONEnumerator
        Return New FILTRO_CANTONEnumerator(Me)
    End Function

    Public Class FILTRO_CANTONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaFILTRO_CANTON)
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
