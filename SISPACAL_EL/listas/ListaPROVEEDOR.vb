''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR',
''' es una representación en memoria de los registros de la tabla PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR
        Get
            Return CType((List(index)), PROVEEDOR)
        End Get
        Set(ByVal Value As PROVEEDOR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR = CType(List(i), PROVEEDOR)
            If s.CODIPROVEEDOR = value.CODIPROVEEDOR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODIPROVEEDOR As String) As PROVEEDOR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR = CType(List(i), PROVEEDOR)
            If s.CODIPROVEEDOR = CODIPROVEEDOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOREnumerator
        Return New PROVEEDOREnumerator(Me)
    End Function

    Public Class PROVEEDOREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR)
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
