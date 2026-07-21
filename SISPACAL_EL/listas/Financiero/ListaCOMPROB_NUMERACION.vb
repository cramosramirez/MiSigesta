''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCOMPROB_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'COMPROB_NUMERACION',
''' es una representación en memoria de los registros de la tabla COMPROB_NUMERACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/09/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCOMPROB_NUMERACION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCOMPROB_NUMERACION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As COMPROB_NUMERACION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As COMPROB_NUMERACION
        Get
            Return CType((List(index)), COMPROB_NUMERACION)
        End Get
        Set(ByVal Value As COMPROB_NUMERACION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As COMPROB_NUMERACION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As COMPROB_NUMERACION = CType(List(i), COMPROB_NUMERACION)
            If s.ID_COMPROB_NUME = value.ID_COMPROB_NUME Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_COMPROB_NUME As Int32) As COMPROB_NUMERACION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As COMPROB_NUMERACION = CType(List(i), COMPROB_NUMERACION)
            If s.ID_COMPROB_NUME = ID_COMPROB_NUME Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As COMPROB_NUMERACIONEnumerator
        Return New COMPROB_NUMERACIONEnumerator(Me)
    End Function

    Public Class COMPROB_NUMERACIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCOMPROB_NUMERACION)
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
