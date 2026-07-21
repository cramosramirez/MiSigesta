''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaORDEN_COMBUSTIBLE_PROD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ORDEN_COMBUSTIBLE_PROD',
''' es una representación en memoria de los registros de la tabla ORDEN_COMBUSTIBLE_PROD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaORDEN_COMBUSTIBLE_PROD
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaORDEN_COMBUSTIBLE_PROD )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ORDEN_COMBUSTIBLE_PROD)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ORDEN_COMBUSTIBLE_PROD
        Get
            Return CType((List(index)), ORDEN_COMBUSTIBLE_PROD)
        End Get
        Set(ByVal Value As ORDEN_COMBUSTIBLE_PROD)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ORDEN_COMBUSTIBLE_PROD) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ORDEN_COMBUSTIBLE_PROD = CType(List(i), ORDEN_COMBUSTIBLE_PROD)
            If s.ID_ORDEN_COMBUSTIBLE_PROD = value.ID_ORDEN_COMBUSTIBLE_PROD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ORDEN_COMBUSTIBLE_PROD As Int32) As ORDEN_COMBUSTIBLE_PROD
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ORDEN_COMBUSTIBLE_PROD = CType(List(i), ORDEN_COMBUSTIBLE_PROD)
            If s.ID_ORDEN_COMBUSTIBLE_PROD = ID_ORDEN_COMBUSTIBLE_PROD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ORDEN_COMBUSTIBLE_PRODEnumerator
        Return New ORDEN_COMBUSTIBLE_PRODEnumerator(Me)
    End Function

    Public Class ORDEN_COMBUSTIBLE_PRODEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaORDEN_COMBUSTIBLE_PROD)
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
