''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCCF_DETA_SALBODE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CCF_DETA_SALBODE',
''' es una representación en memoria de los registros de la tabla CCF_DETA_SALBODE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCCF_DETA_SALBODE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCCF_DETA_SALBODE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CCF_DETA_SALBODE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CCF_DETA_SALBODE
        Get
            Return CType((List(index)), CCF_DETA_SALBODE)
        End Get
        Set(ByVal Value As CCF_DETA_SALBODE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CCF_DETA_SALBODE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CCF_DETA_SALBODE = CType(List(i), CCF_DETA_SALBODE)
            If s.ID_CCF_DETA_SAL = value.ID_CCF_DETA_SAL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CCF_DETA_SAL As Int32) As CCF_DETA_SALBODE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CCF_DETA_SALBODE = CType(List(i), CCF_DETA_SALBODE)
            If s.ID_CCF_DETA_SAL = ID_CCF_DETA_SAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CCF_DETA_SALBODEEnumerator
        Return New CCF_DETA_SALBODEEnumerator(Me)
    End Function

    Public Class CCF_DETA_SALBODEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCCF_DETA_SALBODE)
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
