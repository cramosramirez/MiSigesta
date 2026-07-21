''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaBRIX_SACAROSA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'BRIX_SACAROSA',
''' es una representación en memoria de los registros de la tabla BRIX_SACAROSA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaBRIX_SACAROSA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBRIX_SACAROSA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BRIX_SACAROSA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BRIX_SACAROSA
        Get
            Return CType((List(index)), BRIX_SACAROSA)
        End Get
        Set(ByVal Value As BRIX_SACAROSA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BRIX_SACAROSA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BRIX_SACAROSA = CType(List(i), BRIX_SACAROSA)
            If s.ID_BRIX_SACA = value.ID_BRIX_SACA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_BRIX_SACA As Int32) As BRIX_SACAROSA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BRIX_SACAROSA = CType(List(i), BRIX_SACAROSA)
            If s.ID_BRIX_SACA = ID_BRIX_SACA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BRIX_SACAROSAEnumerator
        Return New BRIX_SACAROSAEnumerator(Me)
    End Function

    Public Class BRIX_SACAROSAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBRIX_SACAROSA)
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
