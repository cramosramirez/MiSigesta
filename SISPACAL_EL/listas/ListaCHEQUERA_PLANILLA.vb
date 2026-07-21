''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCHEQUERA_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CHEQUERA_PLANILLA',
''' es una representación en memoria de los registros de la tabla CHEQUERA_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCHEQUERA_PLANILLA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCHEQUERA_PLANILLA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CHEQUERA_PLANILLA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CHEQUERA_PLANILLA
        Get
            Return CType((List(index)), CHEQUERA_PLANILLA)
        End Get
        Set(ByVal Value As CHEQUERA_PLANILLA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CHEQUERA_PLANILLA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CHEQUERA_PLANILLA = CType(List(i), CHEQUERA_PLANILLA)
            If s.ID_CHEQUERA = value.ID_CHEQUERA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CHEQUERA As Int32) As CHEQUERA_PLANILLA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CHEQUERA_PLANILLA = CType(List(i), CHEQUERA_PLANILLA)
            If s.ID_CHEQUERA = ID_CHEQUERA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CHEQUERA_PLANILLAEnumerator
        Return New CHEQUERA_PLANILLAEnumerator(Me)
    End Function

    Public Class CHEQUERA_PLANILLAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCHEQUERA_PLANILLA)
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
