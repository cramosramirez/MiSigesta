Partial Public Class cSOLIC_ANTICIPO
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_ANTICIPO As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal FECHA As DateTime) As listaSOLIC_ANTICIPO

        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NUM_ANTICIPO, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, FECHA)
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
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_ANTICIPO(ByVal aEntidad As SOLIC_ANTICIPO) As Integer
        Try
            Return Me.ActualizarSOLIC_ANTICIPO(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_ANTICIPO(ByVal aEntidad As SOLIC_ANTICIPO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bNuevo As Boolean = (aEntidad.ID_ANTICIPO = 0)
            Dim lRet As Int32
            Dim esAnulacion As Boolean = False

            If aEntidad.ID_ANTICIPO = 0 Then
                aEntidad.NUM_ANTICIPO = Me.ObtenerNoSolicitudPorZafra(aEntidad.ID_ZAFRA)
            Else
                Dim lEntidadActual As SOLIC_ANTICIPO = (New cSOLIC_ANTICIPO).ObtenerSOLIC_ANTICIPO(aEntidad.ID_ANTICIPO)
                If lEntidadActual.ID_ESTADO <> aEntidad.ID_ESTADO AndAlso aEntidad.ID_ESTADO = Enumeradores.EstadoSolicAgricola.Anulada Then
                    If aEntidad.ID_ESTADO = Enumeradores.EstadoSolicAgricola.Aceptada Then
                        ' ***** ES ACEPTACION DE SOLICITUD


                    ElseIf aEntidad.ID_ESTADO = Enumeradores.EstadoSolicAgricola.Anulada Then
                        ' ***** ES ANULACION DE SOLICITUD
                        Dim lstCrediEnca As listaCREDITO_ENCA
                        Dim lstCrediMov As listaCREDITO_MOV

                        lstCrediEnca = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_ANTICIPO_CONTRATO)
                        If lstCrediEnca IsNot Nothing AndAlso lstCrediEnca.Count > 0 Then
                            For i As Int32 = 0 To lstCrediEnca.Count - 1

                                'Verificar si existen movimientos
                                lstCrediMov = (New cCREDITO_MOV).ObtenerListaPorCREDITO_ENCA(lstCrediEnca(i).ID_CREDITO_ENCA)
                                If lstCrediMov IsNot Nothing AndAlso lstCrediMov.Count > 0 Then
                                    Me.sError = "Existen movimientos financieros relacionados a esta Solicitud."
                                    Return -1
                                End If
                            Next
                        End If

                        aEntidad.ES_ACEPTADA = False
                        esAnulacion = True
                        ' *****
                    End If
                End If
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If esAnulacion Then
                'Eliminar de financiamientos
                Dim listaCreditoEnca As listaCREDITO_ENCA = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_ANTICIPO_CONTRATO)
                Dim bCreditoEnca As New cCREDITO_ENCA

                If listaCreditoEnca IsNot Nothing AndAlso listaCreditoEnca.Count > 0 Then
                    For i As Int32 = 0 To listaCreditoEnca.Count - 1
                        bCreditoEnca.EliminarCREDITO_ENCA(listaCreditoEnca(i).ID_CREDITO_ENCA)
                    Next
                End If
            End If
           
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerNoSolicitudPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerNoSolicitudPorZafra(ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_ANTICIPO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ANTICIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32) As Integer
        Try
            mEntidad.ID_ANTICIPO = ID_ANTICIPO
            Return Me.EliminarSOLIC_ANTICIPO(mEntidad, TipoConcurrencia.Pesimistica)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_ANTICIPO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_ANTICIPO(ByVal aEntidad As SOLIC_ANTICIPO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lista As listaSOLIC_ANTICIPO_CONTRATOS = (New cSOLIC_ANTICIPO_CONTRATOS).ObtenerListaPorSOLIC_ANTICIPO(aEntidad.ID_ANTICIPO)
            Dim listaZafra As listaSOLIC_ANTICIPO_ZAFRA = (New cSOLIC_ANTICIPO_ZAFRA).ObtenerListaPorSOLIC_ANTICIPO(aEntidad.ID_ANTICIPO)
            Dim lRet As Int32 = 0
            Dim bSolicAnticipoContra As New cSOLIC_ANTICIPO_CONTRATOS
            Dim bSolicAnticipoZafra As New cSOLIC_ANTICIPO_ZAFRA

            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                For i As Int32 = 0 To lista.Count - 1
                    bSolicAnticipoContra.EliminarSOLIC_ANTICIPO_CONTRATOS(lista(i).ID_ANTI_CONTRATO)
                Next
            End If

            If listaZafra IsNot Nothing AndAlso listaZafra.Count > 0 Then
                For i As Int32 = 0 To listaZafra.Count - 1
                    bSolicAnticipoZafra.EliminarSOLIC_ANTICIPO_ZAFRA(listaZafra(i).ID_ANTI_ZAFRA)
                Next
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
