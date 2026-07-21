''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLANTILLA_TRANS_COLU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLANTILLA_TRANS_COLU',
''' es una representación en memoria de los registros de la tabla PLANTILLA_TRANS_COLU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLANTILLA_TRANS_COLU
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLANTILLA_TRANS_COLU )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLANTILLA_TRANS_COLU)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLANTILLA_TRANS_COLU
        Get
            Return CType((List(index)), PLANTILLA_TRANS_COLU)
        End Get
        Set(ByVal Value As PLANTILLA_TRANS_COLU)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLANTILLA_TRANS_COLU) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANTILLA_TRANS_COLU = CType(List(i), PLANTILLA_TRANS_COLU)
            If s.ID_PLANTI_COLU = value.ID_PLANTI_COLU Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PLANTI_COLU As Int32) As PLANTILLA_TRANS_COLU
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANTILLA_TRANS_COLU = CType(List(i), PLANTILLA_TRANS_COLU)
            If s.ID_PLANTI_COLU = ID_PLANTI_COLU Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLANTILLA_TRANS_COLUEnumerator
        Return New PLANTILLA_TRANS_COLUEnumerator(Me)
    End Function

    Public Class PLANTILLA_TRANS_COLUEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLANTILLA_TRANS_COLU)
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
