''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPO_MOVTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_MOVTO',
''' es una representación en memoria de los registros de la tabla TIPO_MOVTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_MOVTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPO_MOVTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPO_MOVTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPO_MOVTO
        Get
            Return CType((List(index)), TIPO_MOVTO)
        End Get
        Set(ByVal Value As TIPO_MOVTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPO_MOVTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_MOVTO = CType(List(i), TIPO_MOVTO)
            If s.ID_TIPO_MOVTO = value.ID_TIPO_MOVTO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO_MOVTO As Int32) As TIPO_MOVTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPO_MOVTO = CType(List(i), TIPO_MOVTO)
            If s.ID_TIPO_MOVTO = ID_TIPO_MOVTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPO_MOVTOEnumerator
        Return New TIPO_MOVTOEnumerator(Me)
    End Function

    Public Class TIPO_MOVTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPO_MOVTO)
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
