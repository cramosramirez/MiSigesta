Partial Public Class cPERFIL

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
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPERFIL(ByVal aEntidad As PERFIL) As Integer
        Try
            Return Me.ActualizarPERFIL(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPERFIL(ByVal aEntidad As PERFIL, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lstPerfiles As listaPERFIL = (New cPERFIL).ObtenerLista
            If aEntidad.ID_PERFIL = 0 Then
                For Each lPerfil As PERFIL In lstPerfiles
                    If lPerfil.NOMBRE_PERFIL.ToUpper.Trim = aEntidad.NOMBRE_PERFIL.ToUpper.Trim Then
                        Me.sError = "Nombre de Perfil ya existe"
                        Return -1
                    End If
                Next
            Else
                For Each lPerfil As PERFIL In lstPerfiles
                    If lPerfil.NOMBRE_PERFIL.ToUpper.Trim = aEntidad.NOMBRE_PERFIL.ToUpper.Trim AndAlso lPerfil.ID_PERFIL <> aEntidad.ID_PERFIL Then
                        Me.sError = "Nombre de Perfil ya existe"
                        Return -1
                    End If
                Next
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerPERFILES_SIN_OPCION(ByVal ID_OPCION As Int32) As listaPERFIL
        Try
            Return mDb.ObtenerPERFILES_SIN_OPCION(ID_OPCION)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPERFILPorUsuario(ByVal USUARIO As String) As PERFIL
        Try
            Return mDb.ObtenerPERFILPorUsuario(USUARIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function
End Class
