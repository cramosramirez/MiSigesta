''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSALBODE_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SALBODE_DETA',
''' es una representación en memoria de los registros de la tabla SALBODE_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSALBODE_DETA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSALBODE_DETA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SALBODE_DETA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SALBODE_DETA
        Get
            Return CType((List(index)), SALBODE_DETA)
        End Get
        Set(ByVal Value As SALBODE_DETA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SALBODE_DETA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SALBODE_DETA = CType(List(i), SALBODE_DETA)
            If s.ID_SALBODE_DETA = value.ID_SALBODE_DETA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SALBODE_DETA As Int32) As SALBODE_DETA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SALBODE_DETA = CType(List(i), SALBODE_DETA)
            If s.ID_SALBODE_DETA = ID_SALBODE_DETA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SALBODE_DETAEnumerator
        Return New SALBODE_DETAEnumerator(Me)
    End Function

    Public Class SALBODE_DETAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSALBODE_DETA)
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
