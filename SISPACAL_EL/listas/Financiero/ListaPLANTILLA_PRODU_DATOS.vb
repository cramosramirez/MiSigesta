''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLANTILLA_PRODU_DATOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLANTILLA_PRODU_DATOS',
''' es una representación en memoria de los registros de la tabla PLANTILLA_PRODU_DATOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLANTILLA_PRODU_DATOS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLANTILLA_PRODU_DATOS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLANTILLA_PRODU_DATOS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLANTILLA_PRODU_DATOS
        Get
            Return CType((List(index)), PLANTILLA_PRODU_DATOS)
        End Get
        Set(ByVal Value As PLANTILLA_PRODU_DATOS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLANTILLA_PRODU_DATOS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANTILLA_PRODU_DATOS = CType(List(i), PLANTILLA_PRODU_DATOS)
            If s.ID_PLANTI_DATOS = value.ID_PLANTI_DATOS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLANTI_DATOS As Int32) As PLANTILLA_PRODU_DATOS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANTILLA_PRODU_DATOS = CType(List(i), PLANTILLA_PRODU_DATOS)
            If s.ID_PLANTI_DATOS = ID_PLANTI_DATOS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLANTILLA_PRODU_DATOSEnumerator
        Return New PLANTILLA_PRODU_DATOSEnumerator(Me)
    End Function

    Public Class PLANTILLA_PRODU_DATOSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLANTILLA_PRODU_DATOS)
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
