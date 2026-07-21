''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaRECIBO_CANA_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'RECIBO_CANA_NUMERACION',
''' es una representación en memoria de los registros de la tabla RECIBO_CANA_NUMERACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaRECIBO_CANA_NUMERACION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaRECIBO_CANA_NUMERACION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As RECIBO_CANA_NUMERACION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As RECIBO_CANA_NUMERACION
        Get
            Return CType((List(index)), RECIBO_CANA_NUMERACION)
        End Get
        Set(ByVal Value As RECIBO_CANA_NUMERACION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As RECIBO_CANA_NUMERACION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RECIBO_CANA_NUMERACION = CType(List(i), RECIBO_CANA_NUMERACION)
            If s.ID_RECIBO_CANA_NUM = value.ID_RECIBO_CANA_NUM Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_RECIBO_CANA_NUM As Int32) As RECIBO_CANA_NUMERACION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As RECIBO_CANA_NUMERACION = CType(List(i), RECIBO_CANA_NUMERACION)
            If s.ID_RECIBO_CANA_NUM = ID_RECIBO_CANA_NUM Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As RECIBO_CANA_NUMERACIONEnumerator
        Return New RECIBO_CANA_NUMERACIONEnumerator(Me)
    End Function

    Public Class RECIBO_CANA_NUMERACIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaRECIBO_CANA_NUMERACION)
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
