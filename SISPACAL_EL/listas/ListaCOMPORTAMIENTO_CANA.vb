''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCOMPORTAMIENTO_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'COMPORTAMIENTO_CANA',
''' es una representación en memoria de los registros de la tabla COMPORTAMIENTO_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCOMPORTAMIENTO_CANA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCOMPORTAMIENTO_CANA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As COMPORTAMIENTO_CANA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As COMPORTAMIENTO_CANA
        Get
            Return CType((List(index)), COMPORTAMIENTO_CANA)
        End Get
        Set(ByVal Value As COMPORTAMIENTO_CANA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As COMPORTAMIENTO_CANA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As COMPORTAMIENTO_CANA = CType(List(i), COMPORTAMIENTO_CANA)
            If s.ID_COMPOR = value.ID_COMPOR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_COMPOR As Int32) As COMPORTAMIENTO_CANA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As COMPORTAMIENTO_CANA = CType(List(i), COMPORTAMIENTO_CANA)
            If s.ID_COMPOR = ID_COMPOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As COMPORTAMIENTO_CANAEnumerator
        Return New COMPORTAMIENTO_CANAEnumerator(Me)
    End Function

    Public Class COMPORTAMIENTO_CANAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCOMPORTAMIENTO_CANA)
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
