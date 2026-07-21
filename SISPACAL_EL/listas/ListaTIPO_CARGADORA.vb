''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_CARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_CARGADORA',
''' es una representación en memoria de los registros de la tabla TIPO_CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_CARGADORA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_CARGADORA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_CARGADORA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_CARGADORA
        Get
            Return CType((List(index)), TIPO_CARGADORA)
        End Get
        Set(ByVal Value As TIPO_CARGADORA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_CARGADORA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_CARGADORA = CType(List(i), TIPO_CARGADORA)
            If s.ID_TIPO_CARGADORA = value.ID_TIPO_CARGADORA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_CARGADORA As Int32) As TIPO_CARGADORA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_CARGADORA = CType(List(i), TIPO_CARGADORA)
            If s.ID_TIPO_CARGADORA = ID_TIPO_CARGADORA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_CARGADORAEnumerator
        Return New TIPO_CARGADORAEnumerator(Me)
    End Function

    Public Class TIPO_CARGADORAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_CARGADORA)
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
