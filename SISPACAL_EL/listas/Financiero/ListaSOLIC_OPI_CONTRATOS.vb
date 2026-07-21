''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_OPI_CONTRATOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_OPI_CONTRATOS',
''' es una representación en memoria de los registros de la tabla SOLIC_OPI_CONTRATOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_OPI_CONTRATOS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_OPI_CONTRATOS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_OPI_CONTRATOS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_OPI_CONTRATOS
        Get
            Return CType((List(index)), SOLIC_OPI_CONTRATOS)
        End Get
        Set(ByVal Value As SOLIC_OPI_CONTRATOS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_OPI_CONTRATOS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_OPI_CONTRATOS = CType(List(i), SOLIC_OPI_CONTRATOS)
            If s.ID_OPI_CONTRATO = value.ID_OPI_CONTRATO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_OPI_CONTRATO As Int32) As SOLIC_OPI_CONTRATOS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_OPI_CONTRATOS = CType(List(i), SOLIC_OPI_CONTRATOS)
            If s.ID_OPI_CONTRATO = ID_OPI_CONTRATO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_OPI_CONTRATOSEnumerator
        Return New SOLIC_OPI_CONTRATOSEnumerator(Me)
    End Function

    Public Class SOLIC_OPI_CONTRATOSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_OPI_CONTRATOS)
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
