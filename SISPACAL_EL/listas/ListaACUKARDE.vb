''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaACUKARDE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACUKARDE',
''' es una representación en memoria de los registros de la tabla ACUKARDE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACUKARDE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaACUKARDE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ACUKARDE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ACUKARDE
        Get
            Return CType((List(index)), ACUKARDE)
        End Get
        Set(ByVal Value As ACUKARDE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ACUKARDE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ACUKARDE = CType(List(i), ACUKARDE)
            If s.ID = value.ID Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID As Int32) As ACUKARDE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ACUKARDE = CType(List(i), ACUKARDE)
            If s.ID = ID Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ACUKARDEEnumerator
        Return New ACUKARDEEnumerator(Me)
    End Function

    Public Class ACUKARDEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaACUKARDE)
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
