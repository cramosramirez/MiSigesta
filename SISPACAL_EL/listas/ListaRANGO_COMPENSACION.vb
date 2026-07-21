''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaRANGO_COMPENSACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'RANGO_COMPENSACION',
''' es una representación en memoria de los registros de la tabla RANGO_COMPENSACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaRANGO_COMPENSACION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaRANGO_COMPENSACION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As RANGO_COMPENSACION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As RANGO_COMPENSACION
        Get
            Return CType((List(index)), RANGO_COMPENSACION)
        End Get
        Set(ByVal Value As RANGO_COMPENSACION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As RANGO_COMPENSACION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RANGO_COMPENSACION = CType(List(i), RANGO_COMPENSACION)
            If s.ID_RANGO_COMPE = value.ID_RANGO_COMPE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_RANGO_COMPE As Int32) As RANGO_COMPENSACION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RANGO_COMPENSACION = CType(List(i), RANGO_COMPENSACION)
            If s.ID_RANGO_COMPE = ID_RANGO_COMPE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As RANGO_COMPENSACIONEnumerator
        Return New RANGO_COMPENSACIONEnumerator(Me)
    End Function

    Public Class RANGO_COMPENSACIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaRANGO_COMPENSACION)
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
