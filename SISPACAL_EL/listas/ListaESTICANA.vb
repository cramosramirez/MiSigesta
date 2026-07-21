''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaESTICANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTICANA',
''' es una representación en memoria de los registros de la tabla ESTICANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTICANA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaESTICANA)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ESTICANA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ESTICANA
        Get
            Return CType((List(index)), ESTICANA)
        End Get
        Set(ByVal Value As ESTICANA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ESTICANA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTICANA = CType(List(i), ESTICANA)
            If s.ID_ESTICANA = value.ID_ESTICANA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ESTICANA As Int32) As ESTICANA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ESTICANA = CType(List(i), ESTICANA)
            If s.ID_ESTICANA = ID_ESTICANA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ESTICANAEnumerator
        Return New ESTICANAEnumerator(Me)
    End Function

    Public Class ESTICANAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaESTICANA)
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
