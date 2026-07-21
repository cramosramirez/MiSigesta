''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPROFORMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROFORMA',
''' es una representación en memoria de los registros de la tabla PROFORMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROFORMA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROFORMA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROFORMA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROFORMA
        Get
            Return CType((List(index)), PROFORMA)
        End Get
        Set(ByVal Value As PROFORMA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROFORMA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROFORMA = CType(List(i), PROFORMA)
            If s.ID_PROFORMA = value.ID_PROFORMA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PROFORMA As Int32) As PROFORMA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROFORMA = CType(List(i), PROFORMA)
            If s.ID_PROFORMA = ID_PROFORMA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROFORMAEnumerator
        Return New PROFORMAEnumerator(Me)
    End Function

    Public Class PROFORMAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROFORMA)
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
