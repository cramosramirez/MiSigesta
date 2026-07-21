''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaANTICIPO_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ANTICIPO_CANA',
''' es una representación en memoria de los registros de la tabla ANTICIPO_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaANTICIPO_CANA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaANTICIPO_CANA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ANTICIPO_CANA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ANTICIPO_CANA
        Get
            Return CType((List(index)), ANTICIPO_CANA)
        End Get
        Set(ByVal Value As ANTICIPO_CANA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ANTICIPO_CANA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ANTICIPO_CANA = CType(List(i), ANTICIPO_CANA)
            If s.ID_ANTICIPO_CANA = value.ID_ANTICIPO_CANA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANTICIPO_CANA As Int32) As ANTICIPO_CANA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ANTICIPO_CANA = CType(List(i), ANTICIPO_CANA)
            If s.ID_ANTICIPO_CANA = ID_ANTICIPO_CANA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ANTICIPO_CANAEnumerator
        Return New ANTICIPO_CANAEnumerator(Me)
    End Function

    Public Class ANTICIPO_CANAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaANTICIPO_CANA)
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
