''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_INFORME',
''' es una representación en memoria de los registros de la tabla LABFAB_INFORME
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_INFORME
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_INFORME )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_INFORME)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_INFORME
        Get
            Return CType((List(index)), LABFAB_INFORME)
        End Get
        Set(ByVal Value As LABFAB_INFORME)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_INFORME) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_INFORME = CType(List(i), LABFAB_INFORME)
            If s.ID_INFO = value.ID_INFO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_INFO As Int32) As LABFAB_INFORME
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_INFORME = CType(List(i), LABFAB_INFORME)
            If s.ID_INFO = ID_INFO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_INFORMEEnumerator
        Return New LABFAB_INFORMEEnumerator(Me)
    End Function

    Public Class LABFAB_INFORMEEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_INFORME)
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
