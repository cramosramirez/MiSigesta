''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTROL_QUEMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTROL_QUEMA',
''' es una representación en memoria de los registros de la tabla CONTROL_QUEMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTROL_QUEMA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTROL_QUEMA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTROL_QUEMA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTROL_QUEMA
        Get
            Return CType((List(index)), CONTROL_QUEMA)
        End Get
        Set(ByVal Value As CONTROL_QUEMA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTROL_QUEMA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_QUEMA = CType(List(i), CONTROL_QUEMA)
            If s.ID_CONTROL_QUEMA = value.ID_CONTROL_QUEMA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTROL_QUEMA As Int32) As CONTROL_QUEMA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTROL_QUEMA = CType(List(i), CONTROL_QUEMA)
            If s.ID_CONTROL_QUEMA = ID_CONTROL_QUEMA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTROL_QUEMAEnumerator
        Return New CONTROL_QUEMAEnumerator(Me)
    End Function

    Public Class CONTROL_QUEMAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTROL_QUEMA)
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
