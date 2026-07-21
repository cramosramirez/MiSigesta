''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCREDITO_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CREDITO_ENCA_TRANS',
''' es una representación en memoria de los registros de la tabla CREDITO_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCREDITO_ENCA_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCREDITO_ENCA_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CREDITO_ENCA_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CREDITO_ENCA_TRANS
        Get
            Return CType((List(index)), CREDITO_ENCA_TRANS)
        End Get
        Set(ByVal Value As CREDITO_ENCA_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CREDITO_ENCA_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREDITO_ENCA_TRANS = CType(List(i), CREDITO_ENCA_TRANS)
            If s.ID_CREDITO_ENCA = value.ID_CREDITO_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CREDITO_ENCA As Int32) As CREDITO_ENCA_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREDITO_ENCA_TRANS = CType(List(i), CREDITO_ENCA_TRANS)
            If s.ID_CREDITO_ENCA = ID_CREDITO_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CREDITO_ENCA_TRANSEnumerator
        Return New CREDITO_ENCA_TRANSEnumerator(Me)
    End Function

    Public Class CREDITO_ENCA_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCREDITO_ENCA_TRANS)
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
