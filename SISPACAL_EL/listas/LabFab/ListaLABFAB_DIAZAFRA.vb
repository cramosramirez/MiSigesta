''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_DIAZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_DIAZAFRA',
''' es una representación en memoria de los registros de la tabla LABFAB_DIAZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_DIAZAFRA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_DIAZAFRA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_DIAZAFRA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_DIAZAFRA
        Get
            Return CType((List(index)), LABFAB_DIAZAFRA)
        End Get
        Set(ByVal Value As LABFAB_DIAZAFRA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_DIAZAFRA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_DIAZAFRA = CType(List(i), LABFAB_DIAZAFRA)
            If s.ID_DIAZAFRA = value.ID_DIAZAFRA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DIAZAFRA As Int32) As LABFAB_DIAZAFRA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_DIAZAFRA = CType(List(i), LABFAB_DIAZAFRA)
            If s.ID_DIAZAFRA = ID_DIAZAFRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_DIAZAFRAEnumerator
        Return New LABFAB_DIAZAFRAEnumerator(Me)
    End Function

    Public Class LABFAB_DIAZAFRAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_DIAZAFRA)
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
