''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDOCUMENTO_SALIDA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DOCUMENTO_SALIDA_ENCA',
''' es una representación en memoria de los registros de la tabla DOCUMENTO_SALIDA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDOCUMENTO_SALIDA_ENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDOCUMENTO_SALIDA_ENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DOCUMENTO_SALIDA_ENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DOCUMENTO_SALIDA_ENCA
        Get
            Return CType((List(index)), DOCUMENTO_SALIDA_ENCA)
        End Get
        Set(ByVal Value As DOCUMENTO_SALIDA_ENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DOCUMENTO_SALIDA_ENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DOCUMENTO_SALIDA_ENCA = CType(List(i), DOCUMENTO_SALIDA_ENCA)
            If s.ID_DOCSAL_ENCA = value.ID_DOCSAL_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DOCSAL_ENCA As Int32) As DOCUMENTO_SALIDA_ENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DOCUMENTO_SALIDA_ENCA = CType(List(i), DOCUMENTO_SALIDA_ENCA)
            If s.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DOCUMENTO_SALIDA_ENCAEnumerator
        Return New DOCUMENTO_SALIDA_ENCAEnumerator(Me)
    End Function

    Public Class DOCUMENTO_SALIDA_ENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDOCUMENTO_SALIDA_ENCA)
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
