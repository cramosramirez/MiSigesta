''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaEQUIPO_MEDICION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EQUIPO_MEDICION',
''' es una representación en memoria de los registros de la tabla EQUIPO_MEDICION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEQUIPO_MEDICION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaEQUIPO_MEDICION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As EQUIPO_MEDICION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As EQUIPO_MEDICION
        Get
            Return CType((List(index)), EQUIPO_MEDICION)
        End Get
        Set(ByVal Value As EQUIPO_MEDICION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As EQUIPO_MEDICION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As EQUIPO_MEDICION = CType(List(i), EQUIPO_MEDICION)
            If s.ID_EQUIPO = value.ID_EQUIPO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_EQUIPO As Int32) As EQUIPO_MEDICION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As EQUIPO_MEDICION = CType(List(i), EQUIPO_MEDICION)
            If s.ID_EQUIPO = ID_EQUIPO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As EQUIPO_MEDICIONEnumerator
        Return New EQUIPO_MEDICIONEnumerator(Me)
    End Function

    Public Class EQUIPO_MEDICIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaEQUIPO_MEDICION)
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
