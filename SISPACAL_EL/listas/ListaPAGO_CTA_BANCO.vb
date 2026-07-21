''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPAGO_CTA_BANCO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PAGO_CTA_BANCO',
''' es una representación en memoria de los registros de la tabla PAGO_CTA_BANCO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPAGO_CTA_BANCO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPAGO_CTA_BANCO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PAGO_CTA_BANCO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PAGO_CTA_BANCO
        Get
            Return CType((List(index)), PAGO_CTA_BANCO)
        End Get
        Set(ByVal Value As PAGO_CTA_BANCO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PAGO_CTA_BANCO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PAGO_CTA_BANCO = CType(List(i), PAGO_CTA_BANCO)
            If s.ID_PAGO_CTA_BANCO = value.ID_PAGO_CTA_BANCO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PAGO_CTA_BANCO As Int32) As PAGO_CTA_BANCO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PAGO_CTA_BANCO = CType(List(i), PAGO_CTA_BANCO)
            If s.ID_PAGO_CTA_BANCO = ID_PAGO_CTA_BANCO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PAGO_CTA_BANCOEnumerator
        Return New PAGO_CTA_BANCOEnumerator(Me)
    End Function

    Public Class PAGO_CTA_BANCOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPAGO_CTA_BANCO)
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
