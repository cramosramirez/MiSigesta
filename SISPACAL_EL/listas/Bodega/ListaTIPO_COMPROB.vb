''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_COMPROB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_COMPROB',
''' es una representación en memoria de los registros de la tabla TIPO_COMPROB
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_COMPROB
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_COMPROB )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_COMPROB)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_COMPROB
        Get
            Return CType((List(index)), TIPO_COMPROB)
        End Get
        Set(ByVal Value As TIPO_COMPROB)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_COMPROB) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_COMPROB = CType(List(i), TIPO_COMPROB)
            If s.ID_TIPO_COMPROB = value.ID_TIPO_COMPROB Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_COMPROB As Int32) As TIPO_COMPROB
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_COMPROB = CType(List(i), TIPO_COMPROB)
            If s.ID_TIPO_COMPROB = ID_TIPO_COMPROB Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_COMPROBEnumerator
        Return New TIPO_COMPROBEnumerator(Me)
    End Function

    Public Class TIPO_COMPROBEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_COMPROB)
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
