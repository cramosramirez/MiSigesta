''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDOCUMENTO_ENTRADA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DOCUMENTO_ENTRADA_DETA',
''' es una representación en memoria de los registros de la tabla DOCUMENTO_ENTRADA_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDOCUMENTO_ENTRADA_DETA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDOCUMENTO_ENTRADA_DETA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DOCUMENTO_ENTRADA_DETA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DOCUMENTO_ENTRADA_DETA
        Get
            Return CType((List(index)), DOCUMENTO_ENTRADA_DETA)
        End Get
        Set(ByVal Value As DOCUMENTO_ENTRADA_DETA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DOCUMENTO_ENTRADA_DETA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DOCUMENTO_ENTRADA_DETA = CType(List(i), DOCUMENTO_ENTRADA_DETA)
            If s.ID_DOCENTRA_ENCA_DETA = value.ID_DOCENTRA_ENCA_DETA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DOCENTRA_ENCA_DETA As Int32) As DOCUMENTO_ENTRADA_DETA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DOCUMENTO_ENTRADA_DETA = CType(List(i), DOCUMENTO_ENTRADA_DETA)
            If s.ID_DOCENTRA_ENCA_DETA = ID_DOCENTRA_ENCA_DETA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DOCUMENTO_ENTRADA_DETAEnumerator
        Return New DOCUMENTO_ENTRADA_DETAEnumerator(Me)
    End Function

    Public Class DOCUMENTO_ENTRADA_DETAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDOCUMENTO_ENTRADA_DETA)
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
