''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaAPLICACION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'APLICACION_DESCTO',
''' es una representación en memoria de los registros de la tabla APLICACION_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAPLICACION_DESCTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaAPLICACION_DESCTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As APLICACION_DESCTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As APLICACION_DESCTO
        Get
            Return CType((List(index)), APLICACION_DESCTO)
        End Get
        Set(ByVal Value As APLICACION_DESCTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As APLICACION_DESCTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As APLICACION_DESCTO = CType(List(i), APLICACION_DESCTO)
            If s.ID_APLICACION_DESCTO = value.ID_APLICACION_DESCTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_APLICACION_DESCTO As Int32) As APLICACION_DESCTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As APLICACION_DESCTO = CType(List(i), APLICACION_DESCTO)
            If s.ID_APLICACION_DESCTO = ID_APLICACION_DESCTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As APLICACION_DESCTOEnumerator
        Return New APLICACION_DESCTOEnumerator(Me)
    End Function

    Public Class APLICACION_DESCTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaAPLICACION_DESCTO)
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
