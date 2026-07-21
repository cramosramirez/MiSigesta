''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SECCION',
''' es una representación en memoria de los registros de la tabla SECCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSECCION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSECCION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SECCION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SECCION
        Get
            Return CType((List(index)), SECCION)
        End Get
        Set(ByVal Value As SECCION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SECCION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SECCION = CType(List(i), SECCION)
            If s.ID_SECCION = value.ID_SECCION Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SECCION As Int32) As SECCION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SECCION = CType(List(i), SECCION)
            If s.ID_SECCION = ID_SECCION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SECCIONEnumerator
        Return New SECCIONEnumerator(Me)
    End Function

    Public Class SECCIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSECCION)
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
