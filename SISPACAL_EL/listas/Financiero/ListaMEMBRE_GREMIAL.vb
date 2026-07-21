''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaMEMBRE_GREMIAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MEMBRE_GREMIAL',
''' es una representación en memoria de los registros de la tabla MEMBRE_GREMIAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMEMBRE_GREMIAL
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaMEMBRE_GREMIAL )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As MEMBRE_GREMIAL)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As MEMBRE_GREMIAL
        Get
            Return CType((List(index)), MEMBRE_GREMIAL)
        End Get
        Set(ByVal Value As MEMBRE_GREMIAL)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As MEMBRE_GREMIAL) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MEMBRE_GREMIAL = CType(List(i), MEMBRE_GREMIAL)
            If s.ID_MEMBRE_GREMIAL = value.ID_MEMBRE_GREMIAL Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_MEMBRE_GREMIAL As Int32) As MEMBRE_GREMIAL
        Dim i As Integer = 0
        While i < List.Count
            Dim s As MEMBRE_GREMIAL = CType(List(i), MEMBRE_GREMIAL)
            If s.ID_MEMBRE_GREMIAL = ID_MEMBRE_GREMIAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As MEMBRE_GREMIALEnumerator
        Return New MEMBRE_GREMIALEnumerator(Me)
    End Function

    Public Class MEMBRE_GREMIALEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaMEMBRE_GREMIAL)
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
