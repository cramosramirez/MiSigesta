''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLAN_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLAN_COSECHA',
''' es una representación en memoria de los registros de la tabla PLAN_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLAN_COSECHA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLAN_COSECHA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLAN_COSECHA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLAN_COSECHA
        Get
            Return CType((List(index)), PLAN_COSECHA)
        End Get
        Set(ByVal Value As PLAN_COSECHA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLAN_COSECHA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_COSECHA = CType(List(i), PLAN_COSECHA)
            If s.ID_PLAN_COSECHA = value.ID_PLAN_COSECHA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLAN_COSECHA As Int32) As PLAN_COSECHA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLAN_COSECHA = CType(List(i), PLAN_COSECHA)
            If s.ID_PLAN_COSECHA = ID_PLAN_COSECHA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLAN_COSECHAEnumerator
        Return New PLAN_COSECHAEnumerator(Me)
    End Function

    Public Class PLAN_COSECHAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLAN_COSECHA)
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
