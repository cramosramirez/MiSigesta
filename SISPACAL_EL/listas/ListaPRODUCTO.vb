''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PRODUCTO',
''' es una representación en memoria de los registros de la tabla PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPRODUCTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPRODUCTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PRODUCTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PRODUCTO
        Get
            Return CType((List(index)), PRODUCTO)
        End Get
        Set(ByVal Value As PRODUCTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PRODUCTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRODUCTO = CType(List(i), PRODUCTO)
            If s.ID_PRODUCTO = value.ID_PRODUCTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PRODUCTO As Int32) As PRODUCTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRODUCTO = CType(List(i), PRODUCTO)
            If s.ID_PRODUCTO = ID_PRODUCTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PRODUCTOEnumerator
        Return New PRODUCTOEnumerator(Me)
    End Function

    Public Class PRODUCTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPRODUCTO)
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
