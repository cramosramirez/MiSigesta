''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDESCUENTOS_PLANILLA_OC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DESCUENTOS_PLANILLA_OC',
''' es una representación en memoria de los registros de la tabla DESCUENTOS_PLANILLA_OC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDESCUENTOS_PLANILLA_OC
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDESCUENTOS_PLANILLA_OC )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DESCUENTOS_PLANILLA_OC)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DESCUENTOS_PLANILLA_OC
        Get
            Return CType((List(index)), DESCUENTOS_PLANILLA_OC)
        End Get
        Set(ByVal Value As DESCUENTOS_PLANILLA_OC)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DESCUENTOS_PLANILLA_OC) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DESCUENTOS_PLANILLA_OC = CType(List(i), DESCUENTOS_PLANILLA_OC)
            If s.ID_DESC_PLA_OC = value.ID_DESC_PLA_OC Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DESC_PLA_OC As Int32) As DESCUENTOS_PLANILLA_OC
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DESCUENTOS_PLANILLA_OC = CType(List(i), DESCUENTOS_PLANILLA_OC)
            If s.ID_DESC_PLA_OC = ID_DESC_PLA_OC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DESCUENTOS_PLANILLA_OCEnumerator
        Return New DESCUENTOS_PLANILLA_OCEnumerator(Me)
    End Function

    Public Class DESCUENTOS_PLANILLA_OCEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDESCUENTOS_PLANILLA_OC)
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
