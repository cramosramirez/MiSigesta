''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_INFOVARSXDIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_INFOVARSXDIA',
''' es una representación en memoria de los registros de la tabla LABFAB_INFOVARSXDIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_INFOVARSXDIA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_INFOVARSXDIA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_INFOVARSXDIA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_INFOVARSXDIA
        Get
            Return CType((List(index)), LABFAB_INFOVARSXDIA)
        End Get
        Set(ByVal Value As LABFAB_INFOVARSXDIA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_INFOVARSXDIA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_INFOVARSXDIA = CType(List(i), LABFAB_INFOVARSXDIA)
            If s.ID_INFOVARSXDIA = value.ID_INFOVARSXDIA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_INFOVARSXDIA As Int32) As LABFAB_INFOVARSXDIA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_INFOVARSXDIA = CType(List(i), LABFAB_INFOVARSXDIA)
            If s.ID_INFOVARSXDIA = ID_INFOVARSXDIA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_INFOVARSXDIAEnumerator
        Return New LABFAB_INFOVARSXDIAEnumerator(Me)
    End Function

    Public Class LABFAB_INFOVARSXDIAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_INFOVARSXDIA)
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
