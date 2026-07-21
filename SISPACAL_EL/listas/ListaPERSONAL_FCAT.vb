''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPERSONAL_FCAT
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PERSONAL_FCAT',
''' es una representación en memoria de los registros de la tabla PERSONAL_FCAT
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPERSONAL_FCAT
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPERSONAL_FCAT )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PERSONAL_FCAT)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PERSONAL_FCAT
        Get
            Return CType((List(index)), PERSONAL_FCAT)
        End Get
        Set(ByVal Value As PERSONAL_FCAT)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PERSONAL_FCAT) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PERSONAL_FCAT = CType(List(i), PERSONAL_FCAT)
            If s.ID_PERSO_AT = value.ID_PERSO_AT Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PERSO_AT As Int32) As PERSONAL_FCAT
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PERSONAL_FCAT = CType(List(i), PERSONAL_FCAT)
            If s.ID_PERSO_AT = ID_PERSO_AT Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PERSONAL_FCATEnumerator
        Return New PERSONAL_FCATEnumerator(Me)
    End Function

    Public Class PERSONAL_FCATEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPERSONAL_FCAT)
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
