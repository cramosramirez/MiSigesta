''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCREFISCAL_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CREFISCAL_PROVEEDOR',
''' es una representación en memoria de los registros de la tabla CREFISCAL_PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCREFISCAL_PROVEEDOR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCREFISCAL_PROVEEDOR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CREFISCAL_PROVEEDOR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CREFISCAL_PROVEEDOR
        Get
            Return CType((List(index)), CREFISCAL_PROVEEDOR)
        End Get
        Set(ByVal Value As CREFISCAL_PROVEEDOR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CREFISCAL_PROVEEDOR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREFISCAL_PROVEEDOR = CType(List(i), CREFISCAL_PROVEEDOR)
            If s.ID_CCF = value.ID_CCF Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CCF As Int32) As CREFISCAL_PROVEEDOR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREFISCAL_PROVEEDOR = CType(List(i), CREFISCAL_PROVEEDOR)
            If s.ID_CCF = ID_CCF Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CREFISCAL_PROVEEDOREnumerator
        Return New CREFISCAL_PROVEEDOREnumerator(Me)
    End Function

    Public Class CREFISCAL_PROVEEDOREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCREFISCAL_PROVEEDOR)
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
