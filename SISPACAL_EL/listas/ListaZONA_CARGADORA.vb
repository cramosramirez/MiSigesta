''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaZONA_CARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ZONA_CARGADORA',
''' es una representación en memoria de los registros de la tabla ZONA_CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaZONA_CARGADORA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaZONA_CARGADORA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ZONA_CARGADORA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ZONA_CARGADORA
        Get
            Return CType((List(index)), ZONA_CARGADORA)
        End Get
        Set(ByVal Value As ZONA_CARGADORA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ZONA_CARGADORA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZONA_CARGADORA = CType(List(i), ZONA_CARGADORA)
            If s.ID_ZONA_CARGA = value.ID_ZONA_CARGA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ZONA_CARGA As Int32) As ZONA_CARGADORA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ZONA_CARGADORA = CType(List(i), ZONA_CARGADORA)
            If s.ID_ZONA_CARGA = ID_ZONA_CARGA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ZONA_CARGADORAEnumerator
        Return New ZONA_CARGADORAEnumerator(Me)
    End Function

    Public Class ZONA_CARGADORAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaZONA_CARGADORA)
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
