''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_QUEMANOPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_QUEMANOPROG',
''' es una representación en memoria de los registros de la tabla SOLIC_QUEMANOPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_QUEMANOPROG
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_QUEMANOPROG )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_QUEMANOPROG)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_QUEMANOPROG
        Get
            Return CType((List(index)), SOLIC_QUEMANOPROG)
        End Get
        Set(ByVal Value As SOLIC_QUEMANOPROG)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_QUEMANOPROG) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_QUEMANOPROG = CType(List(i), SOLIC_QUEMANOPROG)
            If s.ID_SOLIC_QUEMANOPROG = value.ID_SOLIC_QUEMANOPROG Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLIC_QUEMANOPROG As Int32) As SOLIC_QUEMANOPROG
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_QUEMANOPROG = CType(List(i), SOLIC_QUEMANOPROG)
            If s.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_QUEMANOPROGEnumerator
        Return New SOLIC_QUEMANOPROGEnumerator(Me)
    End Function

    Public Class SOLIC_QUEMANOPROGEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_QUEMANOPROG)
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
