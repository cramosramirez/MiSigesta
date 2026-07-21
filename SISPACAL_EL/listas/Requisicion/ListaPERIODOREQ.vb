''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPERIODOREQ
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PERIODOREQ',
''' es una representación en memoria de los registros de la tabla PERIODOREQ
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPERIODOREQ
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPERIODOREQ )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PERIODOREQ)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PERIODOREQ
        Get
            Return CType((List(index)), PERIODOREQ)
        End Get
        Set(ByVal Value As PERIODOREQ)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PERIODOREQ) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PERIODOREQ = CType(List(i), PERIODOREQ)
            If s.ID_PERIODOREQ = value.ID_PERIODOREQ Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PERIODOREQ As Int32) As PERIODOREQ
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PERIODOREQ = CType(List(i), PERIODOREQ)
            If s.ID_PERIODOREQ = ID_PERIODOREQ Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PERIODOREQEnumerator
        Return New PERIODOREQEnumerator(Me)
    End Function

    Public Class PERIODOREQEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPERIODOREQ)
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
