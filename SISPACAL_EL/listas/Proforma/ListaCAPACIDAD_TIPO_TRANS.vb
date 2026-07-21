''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCAPACIDAD_TIPO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CAPACIDAD_TIPO_TRANS',
''' es una representación en memoria de los registros de la tabla CAPACIDAD_TIPO_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/12/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCAPACIDAD_TIPO_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCAPACIDAD_TIPO_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CAPACIDAD_TIPO_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CAPACIDAD_TIPO_TRANS
        Get
            Return CType((List(index)), CAPACIDAD_TIPO_TRANS)
        End Get
        Set(ByVal Value As CAPACIDAD_TIPO_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CAPACIDAD_TIPO_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CAPACIDAD_TIPO_TRANS = CType(List(i), CAPACIDAD_TIPO_TRANS)
            If s.ID_CAPACIDAD = value.ID_CAPACIDAD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CAPACIDAD As Int32) As CAPACIDAD_TIPO_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CAPACIDAD_TIPO_TRANS = CType(List(i), CAPACIDAD_TIPO_TRANS)
            If s.ID_CAPACIDAD = ID_CAPACIDAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CAPACIDAD_TIPO_TRANSEnumerator
        Return New CAPACIDAD_TIPO_TRANSEnumerator(Me)
    End Function

    Public Class CAPACIDAD_TIPO_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCAPACIDAD_TIPO_TRANS)
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
