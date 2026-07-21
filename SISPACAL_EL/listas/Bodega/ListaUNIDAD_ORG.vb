''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaUNIDAD_ORG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'UNIDAD_ORG',
''' es una representación en memoria de los registros de la tabla UNIDAD_ORG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaUNIDAD_ORG
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaUNIDAD_ORG )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As UNIDAD_ORG)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As UNIDAD_ORG
        Get
            Return CType((List(index)), UNIDAD_ORG)
        End Get
        Set(ByVal Value As UNIDAD_ORG)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As UNIDAD_ORG) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As UNIDAD_ORG = CType(List(i), UNIDAD_ORG)
            If s.ID_UNIDAD_ORG = value.ID_UNIDAD_ORG Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_UNIDAD_ORG As Int32) As UNIDAD_ORG
        Dim i As Integer = 0
        While i < List.Count
            Dim s As UNIDAD_ORG = CType(List(i), UNIDAD_ORG)
            If s.ID_UNIDAD_ORG = ID_UNIDAD_ORG Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As UNIDAD_ORGEnumerator
        Return New UNIDAD_ORGEnumerator(Me)
    End Function

    Public Class UNIDAD_ORGEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaUNIDAD_ORG)
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
