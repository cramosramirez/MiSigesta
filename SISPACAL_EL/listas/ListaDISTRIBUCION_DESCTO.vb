''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDISTRIBUCION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DISTRIBUCION_DESCTO',
''' es una representación en memoria de los registros de la tabla DISTRIBUCION_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDISTRIBUCION_DESCTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDISTRIBUCION_DESCTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DISTRIBUCION_DESCTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DISTRIBUCION_DESCTO
        Get
            Return CType((List(index)), DISTRIBUCION_DESCTO)
        End Get
        Set(ByVal Value As DISTRIBUCION_DESCTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DISTRIBUCION_DESCTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DISTRIBUCION_DESCTO = CType(List(i), DISTRIBUCION_DESCTO)
            If s.ID_DISTRIB_DESCTO = value.ID_DISTRIB_DESCTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DISTRIB_DESCTO As Int32) As DISTRIBUCION_DESCTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DISTRIBUCION_DESCTO = CType(List(i), DISTRIBUCION_DESCTO)
            If s.ID_DISTRIB_DESCTO = ID_DISTRIB_DESCTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DISTRIBUCION_DESCTOEnumerator
        Return New DISTRIBUCION_DESCTOEnumerator(Me)
    End Function

    Public Class DISTRIBUCION_DESCTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDISTRIBUCION_DESCTO)
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
