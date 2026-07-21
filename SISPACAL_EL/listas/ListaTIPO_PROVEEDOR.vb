''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_PROVEEDOR',
''' es una representación en memoria de los registros de la tabla TIPO_PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_PROVEEDOR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_PROVEEDOR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_PROVEEDOR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_PROVEEDOR
        Get
            Return CType((List(index)), TIPO_PROVEEDOR)
        End Get
        Set(ByVal Value As TIPO_PROVEEDOR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_PROVEEDOR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_PROVEEDOR = CType(List(i), TIPO_PROVEEDOR)
            If s.ID_TIPO_PROVEEDOR = value.ID_TIPO_PROVEEDOR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_PROVEEDOR As Int32) As TIPO_PROVEEDOR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_PROVEEDOR = CType(List(i), TIPO_PROVEEDOR)
            If s.ID_TIPO_PROVEEDOR = ID_TIPO_PROVEEDOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_PROVEEDOREnumerator
        Return New TIPO_PROVEEDOREnumerator(Me)
    End Function

    Public Class TIPO_PROVEEDOREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_PROVEEDOR)
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
