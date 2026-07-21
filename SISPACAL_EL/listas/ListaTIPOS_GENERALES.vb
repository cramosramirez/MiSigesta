''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaTIPOS_GENERALES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPOS_GENERALES',
''' es una representación en memoria de los registros de la tabla TIPOS_GENERALES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPOS_GENERALES
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTIPOS_GENERALES )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TIPOS_GENERALES)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TIPOS_GENERALES
        Get
            Return CType((List(index)), TIPOS_GENERALES)
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TIPOS_GENERALES) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPOS_GENERALES = CType(List(i), TIPOS_GENERALES)
            If s.ID_TIPO = value.ID_TIPO Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_TIPO As Int32) As TIPOS_GENERALES
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TIPOS_GENERALES = CType(List(i), TIPOS_GENERALES)
            If s.ID_TIPO = ID_TIPO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TIPOS_GENERALESEnumerator
        Return New TIPOS_GENERALESEnumerator(Me)
    End Function

    Public Class TIPOS_GENERALESEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTIPOS_GENERALES)
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
