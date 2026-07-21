''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_ENCA_TRANS',
''' es una representación en memoria de los registros de la tabla SOLIC_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_ENCA_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_ENCA_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_ENCA_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_ENCA_TRANS
        Get
            Return CType((List(index)), SOLIC_ENCA_TRANS)
        End Get
        Set(ByVal Value As SOLIC_ENCA_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_ENCA_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ENCA_TRANS = CType(List(i), SOLIC_ENCA_TRANS)
            If s.ID_SOLICITUD = value.ID_SOLICITUD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLICITUD As Int32) As SOLIC_ENCA_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ENCA_TRANS = CType(List(i), SOLIC_ENCA_TRANS)
            If s.ID_SOLICITUD = ID_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_ENCA_TRANSEnumerator
        Return New SOLIC_ENCA_TRANSEnumerator(Me)
    End Function

    Public Class SOLIC_ENCA_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_ENCA_TRANS)
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
