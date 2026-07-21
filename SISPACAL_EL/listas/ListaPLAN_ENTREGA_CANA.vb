''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLAN_ENTREGA_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLAN_ENTREGA_CANA',
''' es una representación en memoria de los registros de la tabla PLAN_ENTREGA_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLAN_ENTREGA_CANA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLAN_ENTREGA_CANA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLAN_ENTREGA_CANA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLAN_ENTREGA_CANA
        Get
            Return CType((List(index)), PLAN_ENTREGA_CANA)
        End Get
        Set(ByVal Value As PLAN_ENTREGA_CANA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLAN_ENTREGA_CANA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_ENTREGA_CANA = CType(List(i), PLAN_ENTREGA_CANA)
            If s.ID_PLAN_ENTREGA_CANA = value.ID_PLAN_ENTREGA_CANA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLAN_ENTREGA_CANA As Int32) As PLAN_ENTREGA_CANA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_ENTREGA_CANA = CType(List(i), PLAN_ENTREGA_CANA)
            If s.ID_PLAN_ENTREGA_CANA = ID_PLAN_ENTREGA_CANA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLAN_ENTREGA_CANAEnumerator
        Return New PLAN_ENTREGA_CANAEnumerator(Me)
    End Function

    Public Class PLAN_ENTREGA_CANAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLAN_ENTREGA_CANA)
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
