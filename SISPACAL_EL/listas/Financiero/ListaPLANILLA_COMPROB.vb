''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLANILLA_COMPROB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLANILLA_COMPROB',
''' es una representación en memoria de los registros de la tabla PLANILLA_COMPROB
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/09/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLANILLA_COMPROB
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLANILLA_COMPROB )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLANILLA_COMPROB)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLANILLA_COMPROB
        Get
            Return CType((List(index)), PLANILLA_COMPROB)
        End Get
        Set(ByVal Value As PLANILLA_COMPROB)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLANILLA_COMPROB) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANILLA_COMPROB = CType(List(i), PLANILLA_COMPROB)
            If s.ID_PLANILLA_COMPROB = value.ID_PLANILLA_COMPROB Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLANILLA_COMPROB As Int32) As PLANILLA_COMPROB
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANILLA_COMPROB = CType(List(i), PLANILLA_COMPROB)
            If s.ID_PLANILLA_COMPROB = ID_PLANILLA_COMPROB Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLANILLA_COMPROBEnumerator
        Return New PLANILLA_COMPROBEnumerator(Me)
    End Function

    Public Class PLANILLA_COMPROBEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLANILLA_COMPROB)
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
