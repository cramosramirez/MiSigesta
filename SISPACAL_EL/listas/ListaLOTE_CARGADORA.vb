''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLOTE_CARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LOTE_CARGADORA',
''' es una representación en memoria de los registros de la tabla LOTE_CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLOTE_CARGADORA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLOTE_CARGADORA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LOTE_CARGADORA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LOTE_CARGADORA
        Get
            Return CType((List(index)), LOTE_CARGADORA)
        End Get
        Set(ByVal Value As LOTE_CARGADORA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LOTE_CARGADORA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTE_CARGADORA = CType(List(i), LOTE_CARGADORA)
            If s.ID_ZONA_CARGA = value.ID_ZONA_CARGA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ZONA_CARGA As Int32) As LOTE_CARGADORA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LOTE_CARGADORA = CType(List(i), LOTE_CARGADORA)
            If s.ID_ZONA_CARGA = ID_ZONA_CARGA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LOTE_CARGADORAEnumerator
        Return New LOTE_CARGADORAEnumerator(Me)
    End Function

    Public Class LOTE_CARGADORAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLOTE_CARGADORA)
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
