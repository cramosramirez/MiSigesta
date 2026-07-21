''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONDICION_SIEMBRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONDICION_SIEMBRA',
''' es una representación en memoria de los registros de la tabla CONDICION_SIEMBRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONDICION_SIEMBRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONDICION_SIEMBRA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONDICION_SIEMBRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONDICION_SIEMBRA
        Get
            Return CType((List(index)), CONDICION_SIEMBRA)
        End Get
        Set(ByVal Value As CONDICION_SIEMBRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONDICION_SIEMBRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONDICION_SIEMBRA = CType(List(i), CONDICION_SIEMBRA)
            If s.ID_COND_SIEMBRA = value.ID_COND_SIEMBRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_COND_SIEMBRA As Int32) As CONDICION_SIEMBRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONDICION_SIEMBRA = CType(List(i), CONDICION_SIEMBRA)
            If s.ID_COND_SIEMBRA = ID_COND_SIEMBRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONDICION_SIEMBRAEnumerator
        Return New CONDICION_SIEMBRAEnumerator(Me)
    End Function

    Public Class CONDICION_SIEMBRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONDICION_SIEMBRA)
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
