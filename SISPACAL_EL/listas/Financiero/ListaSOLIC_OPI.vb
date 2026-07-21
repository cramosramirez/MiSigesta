''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_OPI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_OPI',
''' es una representación en memoria de los registros de la tabla SOLIC_OPI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_OPI
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_OPI )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_OPI)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_OPI
        Get
            Return CType((List(index)), SOLIC_OPI)
        End Get
        Set(ByVal Value As SOLIC_OPI)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_OPI) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_OPI = CType(List(i), SOLIC_OPI)
            If s.ID_OPI = value.ID_OPI Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_OPI As Int32) As SOLIC_OPI
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_OPI = CType(List(i), SOLIC_OPI)
            If s.ID_OPI = ID_OPI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_OPIEnumerator
        Return New SOLIC_OPIEnumerator(Me)
    End Function

    Public Class SOLIC_OPIEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_OPI)
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
