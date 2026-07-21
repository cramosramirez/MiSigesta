Imports System.Web
Imports System.Text

Partial Public Class cUSUARIO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarUSUARIO(ByVal USUARIO As String, ByVal ID_PERFIL As Int32, ByVal NOMBRE As String, ByVal EMAIL As String, ByVal CLAVE As String, ByVal ACTIVO As Boolean, ByVal BLOQUEADO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_ULTACCESO As DateTime) As Integer
        Try
            Dim lEntidad As New USUARIO
            lEntidad.USUARIO = USUARIO
            lEntidad.ID_PERFIL = ID_PERFIL
            lEntidad.NOMBRE = NOMBRE
            lEntidad.EMAIL = EMAIL
            lEntidad.CLAVE = Utilerias.CifrarClave(CLAVE)
            lEntidad.ACTIVO = ACTIVO
            lEntidad.BLOQUEADO = BLOQUEADO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_ULTACCESO = FECHA_ULTACCESO
            Return Me.AgregarUSUARIO(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarUSUARIO(ByVal aEntidad As USUARIO) As Integer
        Try
            'Verificar que el usuario no exista
            Dim lEntidad As USUARIO = (New cUSUARIO).ObtenerUSUARIO(aEntidad.USUARIO)
            If lEntidad IsNot Nothing Then
                Me.sError = "Ya existe un usuario " + aEntidad.USUARIO
                Return -1
            End If
            aEntidad.CLAVE = Utilerias.CifrarClave(aEntidad.CLAVE)
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarUSUARIO(ByVal USUARIO As String, ByVal ID_PERFIL As Int32, ByVal NOMBRE As String, ByVal EMAIL As String, ByVal CLAVE As String, ByVal ACTIVO As Boolean, ByVal BLOQUEADO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_ULTACCESO As DateTime) As Integer
        Try
            Dim lEntidad As New USUARIO
            lEntidad.USUARIO = USUARIO
            lEntidad.ID_PERFIL = ID_PERFIL
            lEntidad.NOMBRE = NOMBRE
            lEntidad.EMAIL = EMAIL
            lEntidad.CLAVE = CLAVE
            lEntidad.ACTIVO = ACTIVO
            lEntidad.BLOQUEADO = BLOQUEADO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_ULTACCESO = FECHA_ULTACCESO
            Return Me.ActualizarUSUARIO(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarUSUARIO(ByVal aEntidad As USUARIO) As Integer
        Try
            Return Me.ActualizarUSUARIO(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarUSUARIO(ByVal aEntidad As USUARIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lEntidadActual As USUARIO = (New cUSUARIO).ObtenerUSUARIO(aEntidad.USUARIO)
            If lEntidadActual Is Nothing Then
                aEntidad.CLAVE = Utilerias.CifrarClave(aEntidad.CLAVE)
            Else
                If aEntidad.CLAVE <> lEntidadActual.CLAVE Then
                    aEntidad.CLAVE = Utilerias.CifrarClave(aEntidad.CLAVE)
                End If
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que valida las credenciales de un usuario.
    ''' </summary>
    ''' <param name="pUsuario">Usuario.</param>    
    ''' <param name="pClave">Clave.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ValidarUsuario(ByVal pUsuario As String, ByVal pClave As String) As Boolean
        Try
            Dim lEntidad As USUARIO
            Dim bUsuario As New cUSUARIO
            Dim esValido As Boolean = False

            Me.sError = ""
            lEntidad = Me.ObtenerUSUARIO(pUsuario)
            If lEntidad IsNot Nothing Then
                If lEntidad.USUARIO.Equals(pUsuario) Then
                    If lEntidad.ACTIVO Then
                        If lEntidad.ACTIVO AndAlso String.Equals(lEntidad.CLAVE, Utilerias.CifrarClave(pClave)) Then
                            lEntidad.FECHA_ULTACCESO = cFechaHora.ObtenerFechaHora
                            bUsuario.ActualizarUSUARIO(lEntidad)
                            esValido = True
                        End If
                    Else
                        Me.sError = "Usuario inactivo"
                    End If
                End If
            End If

            If Not esValido Then
                If Me.sError = "" Then Me.sError = "Credenciales inválidas"
            End If
            Return esValido

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
   
End Class
