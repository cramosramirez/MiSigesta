''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_ANTICIPO_CONTRATOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_ANTICIPO_CONTRATOS',
''' es una representación en memoria de los registros de la tabla SOLIC_ANTICIPO_CONTRATOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_ANTICIPO_CONTRATOS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_ANTICIPO_CONTRATOS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_ANTICIPO_CONTRATOS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_ANTICIPO_CONTRATOS
        Get
            Return CType((List(index)), SOLIC_ANTICIPO_CONTRATOS)
        End Get
        Set(ByVal Value As SOLIC_ANTICIPO_CONTRATOS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_ANTICIPO_CONTRATOS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_CONTRATOS = CType(List(i), SOLIC_ANTICIPO_CONTRATOS)
            If s.ID_ANTI_CONTRATO = value.ID_ANTI_CONTRATO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANTI_CONTRATO As Int32) As SOLIC_ANTICIPO_CONTRATOS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_ANTICIPO_CONTRATOS = CType(List(i), SOLIC_ANTICIPO_CONTRATOS)
            If s.ID_ANTI_CONTRATO = ID_ANTI_CONTRATO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_ANTICIPO_CONTRATOSEnumerator
        Return New SOLIC_ANTICIPO_CONTRATOSEnumerator(Me)
    End Function

    Public Class SOLIC_ANTICIPO_CONTRATOSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_ANTICIPO_CONTRATOS)
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
