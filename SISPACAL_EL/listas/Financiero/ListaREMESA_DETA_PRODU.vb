''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaREMESA_DETA_PRODU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REMESA_DETA_PRODU',
''' es una representación en memoria de los registros de la tabla REMESA_DETA_PRODU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREMESA_DETA_PRODU
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaREMESA_DETA_PRODU )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As REMESA_DETA_PRODU)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As REMESA_DETA_PRODU
        Get
            Return CType((List(index)), REMESA_DETA_PRODU)
        End Get
        Set(ByVal Value As REMESA_DETA_PRODU)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As REMESA_DETA_PRODU) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REMESA_DETA_PRODU = CType(List(i), REMESA_DETA_PRODU)
            If s.ID_REMESA_DETA = value.ID_REMESA_DETA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_REMESA_DETA As Int32) As REMESA_DETA_PRODU
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REMESA_DETA_PRODU = CType(List(i), REMESA_DETA_PRODU)
            If s.ID_REMESA_DETA = ID_REMESA_DETA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As REMESA_DETA_PRODUEnumerator
        Return New REMESA_DETA_PRODUEnumerator(Me)
    End Function

    Public Class REMESA_DETA_PRODUEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaREMESA_DETA_PRODU)
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
