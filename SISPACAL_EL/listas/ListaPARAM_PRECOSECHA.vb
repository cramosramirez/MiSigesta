''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPARAM_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PARAM_PRECOSECHA',
''' es una representación en memoria de los registros de la tabla PARAM_PRECOSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPARAM_PRECOSECHA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPARAM_PRECOSECHA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PARAM_PRECOSECHA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PARAM_PRECOSECHA
        Get
            Return CType((List(index)), PARAM_PRECOSECHA)
        End Get
        Set(ByVal Value As PARAM_PRECOSECHA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PARAM_PRECOSECHA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PARAM_PRECOSECHA = CType(List(i), PARAM_PRECOSECHA)
            If s.ID_PARAM_PRECOSECHA = value.ID_PARAM_PRECOSECHA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PARAM_PRECOSECHA As Int32) As PARAM_PRECOSECHA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PARAM_PRECOSECHA = CType(List(i), PARAM_PRECOSECHA)
            If s.ID_PARAM_PRECOSECHA = ID_PARAM_PRECOSECHA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PARAM_PRECOSECHAEnumerator
        Return New PARAM_PRECOSECHAEnumerator(Me)
    End Function

    Public Class PARAM_PRECOSECHAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPARAM_PRECOSECHA)
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
