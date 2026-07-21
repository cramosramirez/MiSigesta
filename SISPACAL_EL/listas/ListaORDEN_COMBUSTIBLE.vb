''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaORDEN_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ORDEN_COMBUSTIBLE',
''' es una representación en memoria de los registros de la tabla ORDEN_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaORDEN_COMBUSTIBLE
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaORDEN_COMBUSTIBLE )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ORDEN_COMBUSTIBLE)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ORDEN_COMBUSTIBLE
        Get
            Return CType((List(index)), ORDEN_COMBUSTIBLE)
        End Get
        Set(ByVal Value As ORDEN_COMBUSTIBLE)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ORDEN_COMBUSTIBLE) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ORDEN_COMBUSTIBLE = CType(List(i), ORDEN_COMBUSTIBLE)
            If s.ID_ORDEN_COMBUS = value.ID_ORDEN_COMBUS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ORDEN_COMBUS As Int32) As ORDEN_COMBUSTIBLE
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ORDEN_COMBUSTIBLE = CType(List(i), ORDEN_COMBUSTIBLE)
            If s.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ORDEN_COMBUSTIBLEEnumerator
        Return New ORDEN_COMBUSTIBLEEnumerator(Me)
    End Function

    Public Class ORDEN_COMBUSTIBLEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaORDEN_COMBUSTIBLE)
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
