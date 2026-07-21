''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_OIP_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_OIP_LOTE',
''' es una representación en memoria de los registros de la tabla SOLIC_OIP_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/07/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_OIP_LOTE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_OIP_LOTE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_OIP_LOTE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_OIP_LOTE
        Get
            Return CType((List(index)), SOLIC_OIP_LOTE)
        End Get
        Set(ByVal Value As SOLIC_OIP_LOTE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_OIP_LOTE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_OIP_LOTE = CType(List(i), SOLIC_OIP_LOTE)
            If s.ID_SOLI_LOTE = value.ID_SOLI_LOTE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLI_LOTE As Int32) As SOLIC_OIP_LOTE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_OIP_LOTE = CType(List(i), SOLIC_OIP_LOTE)
            If s.ID_SOLI_LOTE = ID_SOLI_LOTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_OIP_LOTEEnumerator
        Return New SOLIC_OIP_LOTEEnumerator(Me)
    End Function

    Public Class SOLIC_OIP_LOTEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_OIP_LOTE)
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
