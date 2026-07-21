''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaVARIEDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'VARIEDAD',
''' es una representación en memoria de los registros de la tabla VARIEDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaVARIEDAD
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaVARIEDAD )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As VARIEDAD)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As VARIEDAD
        Get
            Return CType((List(index)), VARIEDAD)
        End Get
        Set(ByVal Value As VARIEDAD)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As VARIEDAD) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As VARIEDAD = CType(List(i), VARIEDAD)
            If s.CODIVARIEDA = value.CODIVARIEDA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal CODIVARIEDA As String) As VARIEDAD
        Dim i As Integer = 0
        While i < List.Count
            Dim s As VARIEDAD = CType(List(i), VARIEDAD)
            If s.CODIVARIEDA = CODIVARIEDA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As VARIEDADEnumerator
        Return New VARIEDADEnumerator(Me)
    End Function

    Public Class VARIEDADEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaVARIEDAD)
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
