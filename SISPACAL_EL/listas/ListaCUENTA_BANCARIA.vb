''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCUENTA_BANCARIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CUENTA_BANCARIA',
''' es una representación en memoria de los registros de la tabla CUENTA_BANCARIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCUENTA_BANCARIA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCUENTA_BANCARIA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CUENTA_BANCARIA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CUENTA_BANCARIA
        Get
            Return CType((List(index)), CUENTA_BANCARIA)
        End Get
        Set(ByVal Value As CUENTA_BANCARIA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CUENTA_BANCARIA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CUENTA_BANCARIA = CType(List(i), CUENTA_BANCARIA)
            If s.ID_CUENTA = value.ID_CUENTA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CUENTA As Int32) As CUENTA_BANCARIA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CUENTA_BANCARIA = CType(List(i), CUENTA_BANCARIA)
            If s.ID_CUENTA = ID_CUENTA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CUENTA_BANCARIAEnumerator
        Return New CUENTA_BANCARIAEnumerator(Me)
    End Function

    Public Class CUENTA_BANCARIAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCUENTA_BANCARIA)
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
