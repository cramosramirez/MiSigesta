''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_CATEGORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_CATEGORIA',
''' es una representación en memoria de los registros de la tabla LABFAB_CATEGORIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_CATEGORIA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_CATEGORIA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_CATEGORIA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_CATEGORIA
        Get
            Return CType((List(index)), LABFAB_CATEGORIA)
        End Get
        Set(ByVal Value As LABFAB_CATEGORIA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_CATEGORIA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_CATEGORIA = CType(List(i), LABFAB_CATEGORIA)
            If s.ID_CATEG = value.ID_CATEG Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CATEG As Int32) As LABFAB_CATEGORIA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_CATEGORIA = CType(List(i), LABFAB_CATEGORIA)
            If s.ID_CATEG = ID_CATEG Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_CATEGORIAEnumerator
        Return New LABFAB_CATEGORIAEnumerator(Me)
    End Function

    Public Class LABFAB_CATEGORIAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_CATEGORIA)
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
