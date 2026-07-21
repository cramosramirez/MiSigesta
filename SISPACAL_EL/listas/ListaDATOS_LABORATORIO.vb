''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaDATOS_LABORATORIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DATOS_LABORATORIO',
''' es una representación en memoria de los registros de la tabla DATOS_LABORATORIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDATOS_LABORATORIO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaDATOS_LABORATORIO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As DATOS_LABORATORIO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As DATOS_LABORATORIO
        Get
            Return CType((List(index)), DATOS_LABORATORIO)
        End Get
        Set(ByVal Value As DATOS_LABORATORIO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As DATOS_LABORATORIO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DATOS_LABORATORIO = CType(List(i), DATOS_LABORATORIO)
            If s.ID_DATOS_LAB = value.ID_DATOS_LAB Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_DATOS_LAB As Int32) As DATOS_LABORATORIO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As DATOS_LABORATORIO = CType(List(i), DATOS_LABORATORIO)
            If s.ID_DATOS_LAB = ID_DATOS_LAB Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As DATOS_LABORATORIOEnumerator
        Return New DATOS_LABORATORIOEnumerator(Me)
    End Function

    Public Class DATOS_LABORATORIOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaDATOS_LABORATORIO)
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
