''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCOMPROB_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'COMPROB_ENCA',
''' es una representación en memoria de los registros de la tabla COMPROB_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCOMPROB_ENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCOMPROB_ENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As COMPROB_ENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As COMPROB_ENCA
        Get
            Return CType((List(index)), COMPROB_ENCA)
        End Get
        Set(ByVal Value As COMPROB_ENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As COMPROB_ENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As COMPROB_ENCA = CType(List(i), COMPROB_ENCA)
            If s.ID_COMPROB_ENCA = value.ID_COMPROB_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_COMPROB_ENCA As Int32) As COMPROB_ENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As COMPROB_ENCA = CType(List(i), COMPROB_ENCA)
            If s.ID_COMPROB_ENCA = ID_COMPROB_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As COMPROB_ENCAEnumerator
        Return New COMPROB_ENCAEnumerator(Me)
    End Function

    Public Class COMPROB_ENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCOMPROB_ENCA)
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
