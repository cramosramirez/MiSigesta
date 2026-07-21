''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_VARSXANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_VARSXANALISIS',
''' es una representación en memoria de los registros de la tabla LABFAB_VARSXANALISIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_VARSXANALISIS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_VARSXANALISIS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_VARSXANALISIS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_VARSXANALISIS
        Get
            Return CType((List(index)), LABFAB_VARSXANALISIS)
        End Get
        Set(ByVal Value As LABFAB_VARSXANALISIS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_VARSXANALISIS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_VARSXANALISIS = CType(List(i), LABFAB_VARSXANALISIS)
            If s.ID_VARXANALISIS = value.ID_VARXANALISIS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_VARXANALISIS As Int32) As LABFAB_VARSXANALISIS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_VARSXANALISIS = CType(List(i), LABFAB_VARSXANALISIS)
            If s.ID_VARXANALISIS = ID_VARXANALISIS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_VARSXANALISISEnumerator
        Return New LABFAB_VARSXANALISISEnumerator(Me)
    End Function

    Public Class LABFAB_VARSXANALISISEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_VARSXANALISIS)
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
