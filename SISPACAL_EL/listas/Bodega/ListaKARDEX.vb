''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaKARDEX
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'KARDEX',
''' es una representación en memoria de los registros de la tabla KARDEX
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaKARDEX
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaKARDEX )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As KARDEX)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As KARDEX
        Get
            Return CType((List(index)), KARDEX)
        End Get
        Set(ByVal Value As KARDEX)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As KARDEX) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As KARDEX = CType(List(i), KARDEX)
            If s.ID_KARDEX = value.ID_KARDEX Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_KARDEX As Int32) As KARDEX
        Dim i As Integer = 0
        While i < List.Count
            Dim s As KARDEX = CType(List(i), KARDEX)
            If s.ID_KARDEX = ID_KARDEX Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As KARDEXEnumerator
        Return New KARDEXEnumerator(Me)
    End Function

    Public Class KARDEXEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaKARDEX)
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
