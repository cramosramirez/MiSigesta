''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMOTORISTA_VEHICULO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MOTORISTA_VEHICULO',
''' es una representación en memoria de los registros de la tabla MOTORISTA_VEHICULO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMOTORISTA_VEHICULO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMOTORISTA_VEHICULO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MOTORISTA_VEHICULO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MOTORISTA_VEHICULO
        Get
            Return CType((List(index)), MOTORISTA_VEHICULO)
        End Get
        Set(ByVal Value As MOTORISTA_VEHICULO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MOTORISTA_VEHICULO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MOTORISTA_VEHICULO = CType(List(i), MOTORISTA_VEHICULO)
            If s.ID_MOTORISTA_VEHI = value.ID_MOTORISTA_VEHI Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_MOTORISTA_VEHI As Int32) As MOTORISTA_VEHICULO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MOTORISTA_VEHICULO = CType(List(i), MOTORISTA_VEHICULO)
            If s.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MOTORISTA_VEHICULOEnumerator
        Return New MOTORISTA_VEHICULOEnumerator(Me)
    End Function

    Public Class MOTORISTA_VEHICULOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMOTORISTA_VEHICULO)
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
