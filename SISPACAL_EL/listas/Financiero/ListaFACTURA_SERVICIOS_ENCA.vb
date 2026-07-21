''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaFACTURA_SERVICIOS_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FACTURA_SERVICIOS_ENCA',
''' es una representación en memoria de los registros de la tabla FACTURA_SERVICIOS_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFACTURA_SERVICIOS_ENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaFACTURA_SERVICIOS_ENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As FACTURA_SERVICIOS_ENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As FACTURA_SERVICIOS_ENCA
        Get
            Return CType((List(index)), FACTURA_SERVICIOS_ENCA)
        End Get
        Set(ByVal Value As FACTURA_SERVICIOS_ENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As FACTURA_SERVICIOS_ENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As FACTURA_SERVICIOS_ENCA = CType(List(i), FACTURA_SERVICIOS_ENCA)
            If s.ID_FACTURA_SERVICIOS_ENCA = value.ID_FACTURA_SERVICIOS_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_FACTURA_SERVICIOS_ENCA As Int32) As FACTURA_SERVICIOS_ENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As FACTURA_SERVICIOS_ENCA = CType(List(i), FACTURA_SERVICIOS_ENCA)
            If s.ID_FACTURA_SERVICIOS_ENCA = ID_FACTURA_SERVICIOS_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As FACTURA_SERVICIOS_ENCAEnumerator
        Return New FACTURA_SERVICIOS_ENCAEnumerator(Me)
    End Function

    Public Class FACTURA_SERVICIOS_ENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaFACTURA_SERVICIOS_ENCA)
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
