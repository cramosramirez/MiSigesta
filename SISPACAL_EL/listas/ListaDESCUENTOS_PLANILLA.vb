''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDESCUENTOS_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DESCUENTOS_PLANILLA',
''' es una representación en memoria de los registros de la tabla DESCUENTOS_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDESCUENTOS_PLANILLA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDESCUENTOS_PLANILLA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DESCUENTOS_PLANILLA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DESCUENTOS_PLANILLA
        Get
            Return CType((List(index)), DESCUENTOS_PLANILLA)
        End Get
        Set(ByVal Value As DESCUENTOS_PLANILLA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DESCUENTOS_PLANILLA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DESCUENTOS_PLANILLA = CType(List(i), DESCUENTOS_PLANILLA)
            If s.ID_DESCUENTO_PLANILLA = value.ID_DESCUENTO_PLANILLA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DESCUENTO_PLANILLA As Int32) As DESCUENTOS_PLANILLA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DESCUENTOS_PLANILLA = CType(List(i), DESCUENTOS_PLANILLA)
            If s.ID_DESCUENTO_PLANILLA = ID_DESCUENTO_PLANILLA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DESCUENTOS_PLANILLAEnumerator
        Return New DESCUENTOS_PLANILLAEnumerator(Me)
    End Function

    Public Class DESCUENTOS_PLANILLAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDESCUENTOS_PLANILLA)
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
