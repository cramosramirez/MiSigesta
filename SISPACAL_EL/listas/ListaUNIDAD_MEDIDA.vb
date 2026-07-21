''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaUNIDAD_MEDIDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'UNIDAD_MEDIDA',
''' es una representación en memoria de los registros de la tabla UNIDAD_MEDIDA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaUNIDAD_MEDIDA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaUNIDAD_MEDIDA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As UNIDAD_MEDIDA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As UNIDAD_MEDIDA
        Get
            Return CType((List(index)), UNIDAD_MEDIDA)
        End Get
        Set(ByVal Value As UNIDAD_MEDIDA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As UNIDAD_MEDIDA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As UNIDAD_MEDIDA = CType(List(i), UNIDAD_MEDIDA)
            If s.ID_UNIDAD = value.ID_UNIDAD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_UNIDAD As Int32) As UNIDAD_MEDIDA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As UNIDAD_MEDIDA = CType(List(i), UNIDAD_MEDIDA)
            If s.ID_UNIDAD = ID_UNIDAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As UNIDAD_MEDIDAEnumerator
        Return New UNIDAD_MEDIDAEnumerator(Me)
    End Function

    Public Class UNIDAD_MEDIDAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaUNIDAD_MEDIDA)
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
