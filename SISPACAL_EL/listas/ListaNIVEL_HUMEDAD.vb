''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaNIVEL_HUMEDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'NIVEL_HUMEDAD',
''' es una representación en memoria de los registros de la tabla NIVEL_HUMEDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaNIVEL_HUMEDAD
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaNIVEL_HUMEDAD )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As NIVEL_HUMEDAD)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As NIVEL_HUMEDAD
        Get
            Return CType((List(index)), NIVEL_HUMEDAD)
        End Get
        Set(ByVal Value As NIVEL_HUMEDAD)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As NIVEL_HUMEDAD) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As NIVEL_HUMEDAD = CType(List(i), NIVEL_HUMEDAD)
            If s.ID_NIVEL_HUMEDAD = value.ID_NIVEL_HUMEDAD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_NIVEL_HUMEDAD As Int32) As NIVEL_HUMEDAD
        Dim i As Integer = 0
        While i < List.Count
            Dim s As NIVEL_HUMEDAD = CType(List(i), NIVEL_HUMEDAD)
            If s.ID_NIVEL_HUMEDAD = ID_NIVEL_HUMEDAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As NIVEL_HUMEDADEnumerator
        Return New NIVEL_HUMEDADEnumerator(Me)
    End Function

    Public Class NIVEL_HUMEDADEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaNIVEL_HUMEDAD)
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
