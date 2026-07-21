''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaESTICANA_XLS_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTICANA_XLS_DETA',
''' es una representación en memoria de los registros de la tabla ESTICANA_XLS_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/12/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTICANA_XLS_DETA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaESTICANA_XLS_DETA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ESTICANA_XLS_DETA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ESTICANA_XLS_DETA
        Get
            Return CType((List(index)), ESTICANA_XLS_DETA)
        End Get
        Set(ByVal Value As ESTICANA_XLS_DETA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ESTICANA_XLS_DETA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTICANA_XLS_DETA = CType(List(i), ESTICANA_XLS_DETA)
            If s.ID_DETA = value.ID_DETA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DETA As Int32) As ESTICANA_XLS_DETA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTICANA_XLS_DETA = CType(List(i), ESTICANA_XLS_DETA)
            If s.ID_DETA = ID_DETA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ESTICANA_XLS_DETAEnumerator
        Return New ESTICANA_XLS_DETAEnumerator(Me)
    End Function

    Public Class ESTICANA_XLS_DETAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaESTICANA_XLS_DETA)
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
