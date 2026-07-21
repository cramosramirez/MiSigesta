''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_CANA',
''' es una representación en memoria de los registros de la tabla TIPO_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_CANA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_CANA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_CANA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_CANA
        Get
            Return CType((List(index)), TIPO_CANA)
        End Get
        Set(ByVal Value As TIPO_CANA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_CANA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_CANA = CType(List(i), TIPO_CANA)
            If s.ID_TIPO_CANA = value.ID_TIPO_CANA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_CANA As Int32) As TIPO_CANA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_CANA = CType(List(i), TIPO_CANA)
            If s.ID_TIPO_CANA = ID_TIPO_CANA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_CANAEnumerator
        Return New TIPO_CANAEnumerator(Me)
    End Function

    Public Class TIPO_CANAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_CANA)
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
