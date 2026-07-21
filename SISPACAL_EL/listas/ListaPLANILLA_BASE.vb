''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLANILLA_BASE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLANILLA_BASE',
''' es una representación en memoria de los registros de la tabla PLANILLA_BASE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLANILLA_BASE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLANILLA_BASE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLANILLA_BASE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLANILLA_BASE
        Get
            Return CType((List(index)), PLANILLA_BASE)
        End Get
        Set(ByVal Value As PLANILLA_BASE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLANILLA_BASE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANILLA_BASE = CType(List(i), PLANILLA_BASE)
            If s.ID_PLANILLA_BASE = value.ID_PLANILLA_BASE Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLANILLA_BASE As Int32) As PLANILLA_BASE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANILLA_BASE = CType(List(i), PLANILLA_BASE)
            If s.ID_PLANILLA_BASE = ID_PLANILLA_BASE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLANILLA_BASEEnumerator
        Return New PLANILLA_BASEEnumerator(Me)
    End Function

    Public Class PLANILLA_BASEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLANILLA_BASE)
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
