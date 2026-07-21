''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_VAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_VAR',
''' es una representación en memoria de los registros de la tabla LABFAB_VAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_VAR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_VAR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_VAR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_VAR
        Get
            Return CType((List(index)), LABFAB_VAR)
        End Get
        Set(ByVal Value As LABFAB_VAR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_VAR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_VAR = CType(List(i), LABFAB_VAR)
            If s.ID_VAR = value.ID_VAR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_VAR As Int32) As LABFAB_VAR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_VAR = CType(List(i), LABFAB_VAR)
            If s.ID_VAR = ID_VAR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_VAREnumerator
        Return New LABFAB_VAREnumerator(Me)
    End Function

    Public Class LABFAB_VAREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_VAR)
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
