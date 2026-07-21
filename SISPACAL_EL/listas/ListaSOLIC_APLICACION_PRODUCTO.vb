''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_APLICACION_PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_APLICACION_PRODUCTO',
''' es una representación en memoria de los registros de la tabla SOLIC_APLICACION_PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_APLICACION_PRODUCTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_APLICACION_PRODUCTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_APLICACION_PRODUCTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_APLICACION_PRODUCTO
        Get
            Return CType((List(index)), SOLIC_APLICACION_PRODUCTO)
        End Get
        Set(ByVal Value As SOLIC_APLICACION_PRODUCTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_APLICACION_PRODUCTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_APLICACION_PRODUCTO = CType(List(i), SOLIC_APLICACION_PRODUCTO)
            If s.ID_SOLIC_APLICACION_PROD = value.ID_SOLIC_APLICACION_PROD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLIC_APLICACION_PROD As Int32) As SOLIC_APLICACION_PRODUCTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_APLICACION_PRODUCTO = CType(List(i), SOLIC_APLICACION_PRODUCTO)
            If s.ID_SOLIC_APLICACION_PROD = ID_SOLIC_APLICACION_PROD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_APLICACION_PRODUCTOEnumerator
        Return New SOLIC_APLICACION_PRODUCTOEnumerator(Me)
    End Function

    Public Class SOLIC_APLICACION_PRODUCTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_APLICACION_PRODUCTO)
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
