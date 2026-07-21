''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPRODUCTO_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PRODUCTO_COMBUSTIBLE',
''' es una representación en memoria de los registros de la tabla PRODUCTO_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPRODUCTO_COMBUSTIBLE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPRODUCTO_COMBUSTIBLE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PRODUCTO_COMBUSTIBLE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PRODUCTO_COMBUSTIBLE
        Get
            Return CType((List(index)), PRODUCTO_COMBUSTIBLE)
        End Get
        Set(ByVal Value As PRODUCTO_COMBUSTIBLE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PRODUCTO_COMBUSTIBLE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRODUCTO_COMBUSTIBLE = CType(List(i), PRODUCTO_COMBUSTIBLE)
            If s.ID_PRODUCTO = value.ID_PRODUCTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PRODUCTO As Int32) As PRODUCTO_COMBUSTIBLE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRODUCTO_COMBUSTIBLE = CType(List(i), PRODUCTO_COMBUSTIBLE)
            If s.ID_PRODUCTO = ID_PRODUCTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PRODUCTO_COMBUSTIBLEEnumerator
        Return New PRODUCTO_COMBUSTIBLEEnumerator(Me)
    End Function

    Public Class PRODUCTO_COMBUSTIBLEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPRODUCTO_COMBUSTIBLE)
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
