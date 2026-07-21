''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMOTIVO_VARIACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MOTIVO_VARIACION',
''' es una representación en memoria de los registros de la tabla MOTIVO_VARIACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMOTIVO_VARIACION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMOTIVO_VARIACION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MOTIVO_VARIACION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MOTIVO_VARIACION
        Get
            Return CType((List(index)), MOTIVO_VARIACION)
        End Get
        Set(ByVal Value As MOTIVO_VARIACION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MOTIVO_VARIACION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MOTIVO_VARIACION = CType(List(i), MOTIVO_VARIACION)
            If s.ID_MOTIVO_VARIACION = value.ID_MOTIVO_VARIACION Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_MOTIVO_VARIACION As Int32) As MOTIVO_VARIACION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MOTIVO_VARIACION = CType(List(i), MOTIVO_VARIACION)
            If s.ID_MOTIVO_VARIACION = ID_MOTIVO_VARIACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MOTIVO_VARIACIONEnumerator
        Return New MOTIVO_VARIACIONEnumerator(Me)
    End Function

    Public Class MOTIVO_VARIACIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMOTIVO_VARIACION)
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
