Partial Public Class cOPCION

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
    Public Function ActualizarOPCION(ByVal aEntidad As OPCION) As Integer
        Try
            Return Me.ActualizarOPCION(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function UsuarioTienePermiso(ByVal pUsuario As String, ByVal nombrePagina As String) As Boolean
        Try
            Return mDb.UsuarioTienePermiso(pUsuario, nombrePagina)
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
    Public Function ActualizarOPCION(ByVal aEntidad As OPCION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lOpcionesHijas As listaOPCION
            Dim lOpcionAntes As OPCION
            Dim lOpcionCambio As OPCION
            Dim listaOpciones As New listaOPCION
            Dim esNuevo As Boolean = (aEntidad.ID_OPCION = 0)
            Dim i As Int32 = 0
            Dim nuevoOrden As Int32 = 0
            Dim cantHijas As Int32 = 0
            Dim lRet As Int32 = 0
            Dim sube As Boolean = False
            Dim baja As Boolean = False
            Dim bOpcionPerfil As New cOPCION_PERFIL
            Dim lOpcionPerfiles As listaOPCION_PERFIL
            Dim listaID_PERFIL As New List(Of Int32)

            If Not esNuevo Then
                lOpcionPerfiles = bOpcionPerfil.ObtenerListaPorOPCION(aEntidad.ID_OPCION)
                If lOpcionPerfiles IsNot Nothing AndAlso lOpcionPerfiles.Count > 0 Then
                    For Each mEntidad As OPCION_PERFIL In lOpcionPerfiles
                        listaID_PERFIL.Add(mEntidad.ID_PERFIL)
                    Next
                End If

                lOpcionAntes = Me.ObtenerOPCION(aEntidad.ID_OPCION)
                If lOpcionAntes.ID_OPCION_PADRE <> aEntidad.ID_OPCION_PADRE Then
                    Dim lOpcionPadre As OPCION = (New cOPCION).ObtenerOPCION(aEntidad.ID_OPCION_PADRE)
                    If lOpcionPadre IsNot Nothing AndAlso lOpcionPadre.URL IsNot Nothing AndAlso lOpcionPadre.URL <> "" Then
                        Me.sError = "La opción no puede asignarse a un menú con funcion de pagina"
                        Return -1
                    End If
                End If

                If lOpcionAntes.ORDEN = aEntidad.ORDEN AndAlso lOpcionAntes.ID_OPCION_PADRE = aEntidad.ID_OPCION_PADRE Then
                    Return mDb.Actualizar(aEntidad)
                End If

                sube = (lOpcionAntes.ID_OPCION_PADRE = aEntidad.ID_OPCION_PADRE AndAlso lOpcionAntes.ORDEN > aEntidad.ORDEN)
                baja = (lOpcionAntes.ID_OPCION_PADRE = aEntidad.ID_OPCION_PADRE AndAlso lOpcionAntes.ORDEN < aEntidad.ORDEN)

                If lOpcionAntes IsNot Nothing AndAlso lOpcionAntes.ID_OPCION_PADRE <> aEntidad.ID_OPCION_PADRE Then
                    'Cambió menú padre: Reasignar el orden de las opciones en el menú padre anterior
                    lOpcionesHijas = Me.ObtenerListaPorOPCION_PADRE(lOpcionAntes.ID_OPCION_PADRE, "ORDEN", "ASC")
                    If lOpcionesHijas IsNot Nothing AndAlso lOpcionesHijas.Count > 0 Then
                        i = 1
                        For Each lOpcion As OPCION In lOpcionesHijas
                            If lOpcion.ID_OPCION <> aEntidad.ID_OPCION Then
                                lOpcion.ORDEN = i
                                mDb.Actualizar(lOpcion)
                                i += 1
                            End If
                        Next
                    End If
                End If
            End If

            lOpcionesHijas = Me.ObtenerListaPorOPCION_PADRE(aEntidad.ID_OPCION_PADRE, "ORDEN", "ASC")
            If lOpcionesHijas IsNot Nothing AndAlso lOpcionesHijas.Count > 0 Then
                'Reasignar el orden de las opciones en el menú padre actual
                i = 1
                For Each lOpcion As OPCION In lOpcionesHijas
                    lOpcion.ORDEN = i
                    mDb.Actualizar(lOpcion)
                    i += 1
                Next
            End If

            If esNuevo Then
                aEntidad.ORDEN = i
                lRet = mDb.Actualizar(aEntidad)
            Else
                lOpcionesHijas = Me.ObtenerListaPorOPCION_PADRE(aEntidad.ID_OPCION_PADRE, "ORDEN", "ASC")
                If lOpcionesHijas IsNot Nothing AndAlso lOpcionesHijas.Count > 0 Then
                    lOpcionCambio = lOpcionesHijas.BuscarPorId(aEntidad.ID_OPCION)
                    If lOpcionCambio Is Nothing Then
                        aEntidad.ORDEN = i
                        mDb.Actualizar(aEntidad)
                        bOpcionPerfil.ActualizarOpcionesRecursivasEnPerfiles(aEntidad, listaID_PERFIL)
                    Else
                        i = 1
                        nuevoOrden = lOpcionCambio.ORDEN
                        If sube AndAlso lOpcionCambio.ORDEN > 1 Then nuevoOrden = lOpcionCambio.ORDEN - 1
                        If Not sube AndAlso lOpcionCambio.ORDEN < lOpcionesHijas.Count Then nuevoOrden = lOpcionCambio.ORDEN + 1

                        lOpcionCambio.ORDEN = nuevoOrden
                        mDb.Actualizar(lOpcionCambio)
                        bOpcionPerfil.ActualizarOpcionesRecursivasEnPerfiles(lOpcionCambio, listaID_PERFIL)

                        For Each lOpcion As OPCION In lOpcionesHijas
                            If lOpcion.ID_OPCION <> lOpcionCambio.ID_OPCION Then
                                If i = nuevoOrden Then i += 1
                                lOpcion.ORDEN = i
                                mDb.Actualizar(lOpcion)
                                i += 1
                            End If
                        Next
                    End If
                Else
                    aEntidad.ORDEN = 1
                    lRet = mDb.Actualizar(aEntidad)
                    bOpcionPerfil.ActualizarOpcionesRecursivasEnPerfiles(aEntidad, listaID_PERFIL)
                End If
            End If

            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarOPCION(ByVal ID_OPCION As Int32, ByVal NOMBRE_OPCION As String, ByVal ORDEN As Int32, ByVal URL As String, ByVal ACTIVO As Boolean, ByVal ID_OPCION_PADRE As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New OPCION
            lEntidad.ID_OPCION = ID_OPCION
            lEntidad.NOMBRE_OPCION = NOMBRE_OPCION
            lEntidad.ORDEN = ORDEN
            lEntidad.URL = URL
            lEntidad.ACTIVO = ACTIVO
            lEntidad.ID_OPCION_PADRE = ID_OPCION_PADRE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarOPCION(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades filtrada por el USUARIO
    ''' </summary>
    ''' <param name="pUsuario">Usuario.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorUSUARIO(ByVal pUsuario As String, ByVal recuperarOcultas As Boolean) As listaOPCION
        Try
            Return mDb.ObtenerListaPorUSUARIO(pUsuario, recuperarOcultas)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal RecuperarOcultas As Boolean, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOPCION
        Try
            Dim mListaOPCION As New listaOPCION
            mListaOPCION = mDb.ObtenerListaPorID(RecuperarOcultas, asColumnaOrden, asTipoOrden)
            If Not mListaOPCION Is Nothing And recuperarForaneas Then
                For Each lEntidad As OPCION In mListaOPCION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaOPCION
            If Not mListaOPCION Is Nothing Then
                For Each lEntidad As OPCION In mListaOPCION
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaOPCION
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades filtrada por el USUARIO
    ''' </summary>
    ''' <param name="pIdOpcionPadre">ID_OPCION_PADRE.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorOPCION_PADRE(ByVal pIdOpcionPadre As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOPCION
        Try
            Return mDb.ObtenerListaPorOPCION_PADRE(pIdOpcionPadre, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades filtrada por el USUARIO
    ''' </summary>
    ''' <param name="pIdOpcionPadre">ID_OPCION_PADRE.</param>    
    ''' <history>
    ''' 	[cramos]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorOPCION_PADRE_PERFIL(ByVal pIdOpcionPadre As Int32, ByVal IdPerfil As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOPCION
        Try
            Return mDb.ObtenerListaPorOPCION_PADRE_PERFIL(pIdOpcionPadre, IdPerfil, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
