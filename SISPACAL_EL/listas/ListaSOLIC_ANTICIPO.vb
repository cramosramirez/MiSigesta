''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_ANTICIPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_ANTICIPO',
''' es una representación en memoria de los registros de la tabla SOLIC_ANTICIPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_ANTICIPO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_ANTICIPO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_ANTICIPO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_ANTICIPO
        Get
            Return CType((List(index)), SOLIC_ANTICIPO)
        End Get
        Set(ByVal Value As SOLIC_ANTICIPO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_ANTICIPO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO = CType(List(i), SOLIC_ANTICIPO)
            If s.ID_ANTICIPO = value.ID_ANTICIPO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANTICIPO As Int32) As SOLIC_ANTICIPO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO = CType(List(i), SOLIC_ANTICIPO)
            If s.ID_ANTICIPO = ID_ANTICIPO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_ANTICIPOEnumerator
        Return New SOLIC_ANTICIPOEnumerator(Me)
    End Function

    Public Class SOLIC_ANTICIPOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_ANTICIPO)
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
