''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaGRUPO_DESCUENTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'GRUPO_DESCUENTOS',
''' es una representación en memoria de los registros de la tabla GRUPO_DESCUENTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaGRUPO_DESCUENTOS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaGRUPO_DESCUENTOS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As GRUPO_DESCUENTOS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As GRUPO_DESCUENTOS
        Get
            Return CType((List(index)), GRUPO_DESCUENTOS)
        End Get
        Set(ByVal Value As GRUPO_DESCUENTOS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As GRUPO_DESCUENTOS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As GRUPO_DESCUENTOS = CType(List(i), GRUPO_DESCUENTOS)
            If s.ID_GRUPO_DESC = value.ID_GRUPO_DESC Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_GRUPO_DESC As Int32) As GRUPO_DESCUENTOS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As GRUPO_DESCUENTOS = CType(List(i), GRUPO_DESCUENTOS)
            If s.ID_GRUPO_DESC = ID_GRUPO_DESC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As GRUPO_DESCUENTOSEnumerator
        Return New GRUPO_DESCUENTOSEnumerator(Me)
    End Function

    Public Class GRUPO_DESCUENTOSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaGRUPO_DESCUENTOS)
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
