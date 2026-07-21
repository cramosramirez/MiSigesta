''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCUENTA_FINAN
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CUENTA_FINAN',
''' es una representación en memoria de los registros de la tabla CUENTA_FINAN
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCUENTA_FINAN
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCUENTA_FINAN )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CUENTA_FINAN)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CUENTA_FINAN
        Get
            Return CType((List(index)), CUENTA_FINAN)
        End Get
        Set(ByVal Value As CUENTA_FINAN)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CUENTA_FINAN) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CUENTA_FINAN = CType(List(i), CUENTA_FINAN)
            If s.ID_CUENTA_FINAN = value.ID_CUENTA_FINAN Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CUENTA_FINAN As Int32) As CUENTA_FINAN
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CUENTA_FINAN = CType(List(i), CUENTA_FINAN)
            If s.ID_CUENTA_FINAN = ID_CUENTA_FINAN Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CUENTA_FINANEnumerator
        Return New CUENTA_FINANEnumerator(Me)
    End Function

    Public Class CUENTA_FINANEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCUENTA_FINAN)
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
