''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROVEEDOR_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_COMBUSTIBLE',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_COMBUSTIBLE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROVEEDOR_COMBUSTIBLE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROVEEDOR_COMBUSTIBLE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROVEEDOR_COMBUSTIBLE
        Get
            Return CType((List(index)), PROVEEDOR_COMBUSTIBLE)
        End Get
        Set(ByVal Value As PROVEEDOR_COMBUSTIBLE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROVEEDOR_COMBUSTIBLE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_COMBUSTIBLE = CType(List(i), PROVEEDOR_COMBUSTIBLE)
            If s.ID_PROVEEDOR_COMBUS = value.ID_PROVEEDOR_COMBUS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROVEEDOR_COMBUS As Int32) As PROVEEDOR_COMBUSTIBLE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROVEEDOR_COMBUSTIBLE = CType(List(i), PROVEEDOR_COMBUSTIBLE)
            If s.ID_PROVEEDOR_COMBUS = ID_PROVEEDOR_COMBUS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROVEEDOR_COMBUSTIBLEEnumerator
        Return New PROVEEDOR_COMBUSTIBLEEnumerator(Me)
    End Function

    Public Class PROVEEDOR_COMBUSTIBLEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROVEEDOR_COMBUSTIBLE)
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
