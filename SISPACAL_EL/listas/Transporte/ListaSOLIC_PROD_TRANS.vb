''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_PROD_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_PROD_TRANS',
''' es una representación en memoria de los registros de la tabla SOLIC_PROD_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_PROD_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_PROD_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_PROD_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_PROD_TRANS
        Get
            Return CType((List(index)), SOLIC_PROD_TRANS)
        End Get
        Set(ByVal Value As SOLIC_PROD_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_PROD_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_PROD_TRANS = CType(List(i), SOLIC_PROD_TRANS)
            If s.ID_SOLIC_PROD_TRANS = value.ID_SOLIC_PROD_TRANS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLIC_PROD_TRANS As Int32) As SOLIC_PROD_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_PROD_TRANS = CType(List(i), SOLIC_PROD_TRANS)
            If s.ID_SOLIC_PROD_TRANS = ID_SOLIC_PROD_TRANS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_PROD_TRANSEnumerator
        Return New SOLIC_PROD_TRANSEnumerator(Me)
    End Function

    Public Class SOLIC_PROD_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_PROD_TRANS)
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
