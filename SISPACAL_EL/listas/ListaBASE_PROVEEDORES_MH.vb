''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBASE_PROVEEDORES_MH
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'BASE_PROVEEDORES_MH',
''' es una representación en memoria de los registros de la tabla BASE_PROVEEDORES_MH
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaBASE_PROVEEDORES_MH
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBASE_PROVEEDORES_MH )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BASE_PROVEEDORES_MH)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BASE_PROVEEDORES_MH
        Get
            Return CType((List(index)), BASE_PROVEEDORES_MH)
        End Get
        Set(ByVal Value As BASE_PROVEEDORES_MH)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BASE_PROVEEDORES_MH) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BASE_PROVEEDORES_MH = CType(List(i), BASE_PROVEEDORES_MH)
            If s.ID_BASE_PROVEE = value.ID_BASE_PROVEE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_BASE_PROVEE As Int32) As BASE_PROVEEDORES_MH
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BASE_PROVEEDORES_MH = CType(List(i), BASE_PROVEEDORES_MH)
            If s.ID_BASE_PROVEE = ID_BASE_PROVEE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BASE_PROVEEDORES_MHEnumerator
        Return New BASE_PROVEEDORES_MHEnumerator(Me)
    End Function

    Public Class BASE_PROVEEDORES_MHEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBASE_PROVEEDORES_MH)
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
