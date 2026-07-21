Partial Public Class cOPCION_PERFIL


    Public Function ActualizarOpcionesRecursivasEnPerfiles(ByVal lOpcion As OPCION, listaID_PERFIL As List(Of Int32)) As Int32
        Dim lOpcionPerfil As OPCION_PERFIL
        Dim bOpcionPerfil As New cOPCION_PERFIL
        Dim _Opcion As OPCION

        If lOpcion.ID_OPCION_PADRE = -1 Then
            For i As Int32 = 0 To listaID_PERFIL.Count - 1
                lOpcionPerfil = (New cOPCION_PERFIL).ObtenerOPCION_PERFILporOpcionPerfil(lOpcion.ID_OPCION, listaID_PERFIL(i))
                If lOpcionPerfil Is Nothing Then
                    lOpcionPerfil = New OPCION_PERFIL
                    lOpcionPerfil.ID_OPCION_PERFIL = 0
                    lOpcionPerfil.ID_OPCION = lOpcion.ID_OPCION
                    lOpcionPerfil.ID_PERFIL = listaID_PERFIL(i)
                    lOpcionPerfil.USUARIO_CREA = Utilerias.ObtenerUsuario
                    lOpcionPerfil.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lOpcionPerfil.USUARIO_ACT = Utilerias.ObtenerUsuario
                    lOpcionPerfil.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bOpcionPerfil.ActualizarOPCION_PERFIL(lOpcionPerfil)
                End If
            Next
        Else
            For i As Int32 = 0 To listaID_PERFIL.Count - 1
                lOpcionPerfil = (New cOPCION_PERFIL).ObtenerOPCION_PERFILporOpcionPerfil(lOpcion.ID_OPCION_PADRE, listaID_PERFIL(i))
                If lOpcionPerfil Is Nothing Then
                    lOpcionPerfil = New OPCION_PERFIL
                    lOpcionPerfil.ID_OPCION_PERFIL = 0
                    lOpcionPerfil.ID_OPCION = lOpcion.ID_OPCION_PADRE
                    lOpcionPerfil.ID_PERFIL = listaID_PERFIL(i)
                    lOpcionPerfil.USUARIO_CREA = Utilerias.ObtenerUsuario
                    lOpcionPerfil.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lOpcionPerfil.USUARIO_ACT = Utilerias.ObtenerUsuario
                    lOpcionPerfil.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bOpcionPerfil.ActualizarOPCION_PERFIL(lOpcionPerfil)
                End If
            Next
            _Opcion = (New cOPCION).ObtenerOPCION(lOpcion.ID_OPCION_PADRE)
            Me.ActualizarOpcionesRecursivasEnPerfiles(_Opcion, listaID_PERFIL)
        End If
    End Function

    Public Function ObtenerOPCION_PERFILporOpcionPerfil(ByVal ID_OPCION As Int32, ByVal ID_PERFIL As Int32) As OPCION_PERFIL
        Try
            Return mDb.ObtenerOPCION_PERFILporOpcionPerfil(ID_OPCION, ID_PERFIL)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarOPCION_PERFIL(ByVal aEntidad As OPCION_PERFIL) As Integer
        Try
            Return Me.ActualizarOPCION_PERFIL(aEntidad, EL.TipoConcurrencia.Pesimistica)
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
    Public Function ActualizarOPCION_PERFIL(ByVal aEntidad As OPCION_PERFIL, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Int32 = 0
            lRet = Me.ActualizarOPCION_PERFIL_RECURSIVA(aEntidad)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function ActualizarOPCION_PERFIL_RECURSIVA(ByVal aEntidad As OPCION_PERFIL) As Int32
        Try
            Dim bOpcion As New cOPCION
            Dim lOpcion As OPCION = (New cOPCION).ObtenerOPCION(aEntidad.ID_OPCION)
            Dim lRet As Int32 = 0

            If Me.ObtenerOPCION_PERFILporOpcionPerfil(aEntidad.ID_OPCION, aEntidad.ID_PERFIL) Is Nothing Then
                lRet = mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
                If lRet < 0 Then Return lRet
            End If
            If lOpcion.ID_OPCION_PADRE = -1 Then
                lRet = 1
            Else
                aEntidad.ID_OPCION_PERFIL = 0
                aEntidad.ID_OPCION = lOpcion.ID_OPCION_PADRE
                lRet = Me.ActualizarOPCION_PERFIL_RECURSIVA(aEntidad)
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla OPCION_PERFIL que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_OPCION_PERFIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarOPCION_PERFIL(ByVal ID_OPCION_PERFIL As Int32) As Integer
        Try
            mEntidad = Me.ObtenerOPCION_PERFIL(ID_OPCION_PERFIL)
            Return Me.EliminarOPCION_PERFIL(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla OPCION_PERFIL que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarOPCION_PERFIL(ByVal aEntidad As OPCION_PERFIL, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim aOpcion As OPCION = (New cOPCION).ObtenerOPCION(aEntidad.ID_OPCION)
            Dim listaSubOpciones As listaOPCION = (New cOPCION).ObtenerListaPorOPCION_PADRE_PERFIL(aEntidad.ID_OPCION, aEntidad.ID_PERFIL)

            If listaSubOpciones Is Nothing OrElse listaSubOpciones.Count = 0 Then
                Dim aOpcionPadre As OPCION = (New cOPCION).ObtenerOPCION(aOpcion.ID_OPCION_PADRE)

                mDb.Eliminar(aEntidad)
                If aOpcionPadre IsNot Nothing Then
                    aEntidad.ID_OPCION = aOpcionPadre.ID_OPCION
                    Me.EliminarOPCION_PERFIL(aEntidad, TipoConcurrencia.Pesimistica)
                End If
            End If
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function EliminarOPCION_PERFIL_SUB_OPCIONES(ByRef aEntidad As OPCION_PERFIL) As Int32
        Try
            Dim listaSubOpcionesxPerfil As listaOPCION = (New cOPCION).ObtenerListaPorOPCION_PADRE_PERFIL(aEntidad.ID_OPCION, aEntidad.ID_PERFIL)

            If listaSubOpcionesxPerfil IsNot Nothing AndAlso listaSubOpcionesxPerfil.Count > 0 Then
                For Each l As OPCION In listaSubOpcionesxPerfil
                    Dim lOpcionPerfil As New OPCION_PERFIL
                    lOpcionPerfil.ID_PERFIL = aEntidad.ID_PERFIL
                    lOpcionPerfil.ID_OPCION = l.ID_OPCION
                    Me.EliminarOPCION_PERFIL_SUB_OPCIONES(lOpcionPerfil)
                Next
            Else
                Return mDb.Eliminar(aEntidad)
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function EliminarOPCION_PERFIL_RECURSIVA(ByRef aEntidad As OPCION_PERFIL) As Int32
        Try
            Dim bOpcion As New cOPCION
            Dim lOpcion As OPCION = (New cOPCION).ObtenerOPCION(aEntidad.ID_OPCION)
            Dim lListaA As listaOPCION_PERFIL
            Dim lRet As Int32 = 0

            lListaA = mDb.ObtenerListaOPCION_PERFILporOpcionPadrePerfil(lOpcion.ID_OPCION, aEntidad.ID_PERFIL)
            If lListaA Is Nothing OrElse lListaA.Count = 0 Then
                Dim lOpcionPerfil As OPCION_PERFIL = Me.ObtenerOPCION_PERFILporOpcionPerfil(lOpcion.ID_OPCION_PADRE, aEntidad.ID_PERFIL)
                If lOpcionPerfil IsNot Nothing Then
                    mDb.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
                End If
            End If

            If lOpcion.ID_OPCION_PADRE = -1 Then
                lRet = 1
            Else
                aEntidad.ID_OPCION_PERFIL = 0
                aEntidad.ID_OPCION = lOpcion.ID_OPCION_PADRE
                lRet = Me.EliminarOPCION_PERFIL_RECURSIVA(aEntidad)
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
