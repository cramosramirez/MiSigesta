Partial Public Class cSOLIC_AGRICOLA


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_AGRICOLA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32) As Integer
        Try
            mEntidad.ID_SOLICITUD = ID_SOLICITUD
            Return Me.EliminarSOLIC_AGRICOLA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_AGRICOLA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_AGRICOLA(ByVal aEntidad As SOLIC_AGRICOLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Verificar que la solicitud se encuentre provisionada para eliminarla
            Dim bContratoCtaProvi As New cCONTRATO_CTAS_PROVI
            Dim bSolicLote As New cSOLIC_AGRICOLA_LOTE
            Dim bSolicProducto As New cSOLIC_AGRICOLA_PRODUCTO
            Dim bSolicVuelo As New cSOLIC_AGRICOLA_VUELO
            Dim listaAplicaLote As listaSOLIC_APLICA_LOTE

            Dim lContratoCtaProvi As CONTRATO_CTAS_PROVI
            Dim listaContratoCtas As listaCONTRATO_CTAS_PROVI
            Dim lRet As Integer
            Dim uid As Guid

            aEntidad = Me.ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
            If aEntidad IsNot Nothing Then
                Dim listaSolicLotes As listaSOLIC_AGRICOLA_LOTE
                Dim listaSolicProductos As listaSOLIC_AGRICOLA_PRODUCTO
                Dim listaSolicVuelo As listaSOLIC_AGRICOLA_VUELO

                listaAplicaLote = (New cSOLIC_APLICA_LOTE).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                If listaAplicaLote IsNot Nothing AndAlso listaAplicaLote.Count > 0 Then
                    Me.sError = "La solicitud tiene aplicaciones de producto relacionadas"
                    Return -1
                End If

                uid = aEntidad.UID_SOLIC_AGRICOLA
                listaSolicLotes = (New cSOLIC_AGRICOLA_LOTE).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                listaSolicProductos = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                listaSolicVuelo = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                listaContratoCtas = (New cCONTRATO_CTAS_PROVI).ObtenerListaPorUID(aEntidad.UID_SOLIC_AGRICOLA)

                'Eliminar provision
                If listaContratoCtas IsNot Nothing AndAlso listaContratoCtas.Count > 0 Then
                    For Each lContratoCtaProvi In listaContratoCtas
                        bContratoCtaProvi.EliminarCONTRATO_CTAS_PROVI(lContratoCtaProvi.ID_CONTRATO_CTAS_PROVI)
                    Next
                End If

                'Eliminar lotes
                If listaSolicLotes IsNot Nothing AndAlso listaSolicLotes.Count > 0 Then
                    For Each lEntidad As SOLIC_AGRICOLA_LOTE In listaSolicLotes
                        bSolicLote.EliminarSOLIC_AGRICOLA_LOTE(lEntidad.ID_SOLIC_AGRI_LOTE)
                    Next
                End If

                'Eliminar productos
                If listaSolicProductos IsNot Nothing AndAlso listaSolicProductos.Count > 0 Then
                    For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO In listaSolicProductos
                        bSolicProducto.EliminarSOLIC_AGRICOLA_PRODUCTO(lEntidad.ID_SOLIC_AGRI_PROD)
                    Next
                End If

                'Eliminar vuelo
                If listaSolicVuelo IsNot Nothing AndAlso listaSolicVuelo.Count > 0 Then
                    For Each lEntidad As SOLIC_AGRICOLA_VUELO In listaSolicVuelo
                        bSolicVuelo.EliminarSOLIC_AGRICOLA_VUELO(lEntidad.ID_SOLIC_AGRI_VUELO)
                    Next
                End If
            End If

            lRet = mDb.Eliminar(aEntidad, aTipoConcurrencia)

            aEntidad = Me.ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
            If aEntidad Is Nothing OrElse aEntidad.ID_SOLICITUD = -1 OrElse aEntidad.ID_SOLICITUD = 0 Then
                'Eliminar de financiamientos
                Dim listaCreditoEnca As listaCREDITO_ENCA = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(uid)
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
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_AGRICOLA(ByVal aEntidad As SOLIC_AGRICOLA) As Integer
        Try
            Return Me.ActualizarSOLIC_AGRICOLA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	17/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_AGRICOLA(ByVal aEntidad As SOLIC_AGRICOLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bNuevo As Boolean = (aEntidad.ID_SOLICITUD = 0)
            Dim lRet As Int32
            Dim esAnulacion As Boolean = False
            Dim bSalBodeDeta As New cSALBODE_DETA
            Dim lstDetaSalBode As listaSALBODE_DETA

            If aEntidad.ID_SOLICITUD = 0 Then
                aEntidad.NUM_SOLICITUD = Me.ObtenerNoSolicitudPorZafra(aEntidad.ID_ZAFRA)
            Else
                Dim lSolicActual As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                If lSolicActual.ESTADO <> aEntidad.ESTADO AndAlso aEntidad.ESTADO = Enumeradores.EstadoSolicAgricola.Anulada Then
                    ' ***** ES ANULACION DE SOLICITUD
                    Dim lstOC As listaORDEN_COMPRA_AGRI
                    Dim lstCCFEnca As listaCCF_ENCA
                    Dim lstCCFDetaSalBode As listaCCF_DETA_SALBODE

                    Dim lstDocEntraBode As listaDOCUMENTO_ENTRADA_ENCA
                    Dim lstCrediEnca As listaCREDITO_ENCA
                    Dim lstCrediMov As listaCREDITO_MOV

                    lstOC = (New cORDEN_COMPRA_AGRI).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                    If lstOC IsNot Nothing AndAlso lstOC.Count > 0 Then
                        For i As Int32 = 0 To lstOC.Count - 1

                            'Verificar si las OC tienen referencia a CCF
                            lstCCFEnca = (New cCCF_ENCA).ObtenerListaPorORDEN_COMPRA_AGRI(lstOC(i).ID_ORDEN)
                            If lstCCFEnca IsNot Nothing AndAlso lstCCFEnca.Count > 0 Then
                                Me.sError = "Existen Credito(s) Fiscal(es)/Factura(s) con referencia a ordenes de compra emitidas para esta solicitud."
                                Return -1
                            End If

                            'Verificar si las OC tienen referencia a Ingreso de Bodega
                            lstDocEntraBode = (New cDOCUMENTO_ENTRADA_ENCA).ObtenerListaPorORDEN_COMPRA_AGRI(lstOC(i).ID_ORDEN)
                            If lstDocEntraBode IsNot Nothing AndAlso lstDocEntraBode.Count > 0 Then
                                Me.sError = "Existen Ingreso(s) de Bodega con referencia a ordenes de compra emitidas para esta solicitud."
                                Return -1
                            End If
                        Next
                    End If

                    'Verificar si hay entregas por salida de bodega asociadas
                    lstDetaSalBode = (New cSALBODE_DETA).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                    If lstDetaSalBode IsNot Nothing AndAlso lstDetaSalBode.Count > 0 Then
                        For h As Int32 = 0 To lstDetaSalBode.Count - 1
                            If lstDetaSalBode(h).CANT_ENTREGADA > 0 Then
                                Me.sError = "Existen entregas de producto consignado asociados a la solicitud."
                                Return -1
                            End If
                        Next
                    End If

                    'Verificar si la Solicitud tiene referencia a CCF por Salida de Bodega
                    lstCCFDetaSalBode = (New cCCF_DETA_SALBODE).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                    If lstCCFDetaSalBode IsNot Nothing AndAlso lstCCFDetaSalBode.Count > 0 Then
                        Me.sError = "Existen creditos fiscales por salida de producto consignado que hacen referencia a la solicitud."
                        Return -1
                    End If

                    'Verificar si existen movimientos financieros                 
                    lstCrediEnca = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_SOLIC_AGRICOLA)
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

                    esAnulacion = True
                    ' *****
                End If
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If esAnulacion Then

                'Anular las cantidades solicitadas en la Solicitud de Retiro de Bodega
                lstDetaSalBode = (New cSALBODE_DETA).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                If lstDetaSalBode IsNot Nothing AndAlso lstDetaSalBode.Count > 0 Then
                    For h As Int32 = 0 To lstDetaSalBode.Count - 1
                        lstDetaSalBode(h).CANT_ANULADA = lstDetaSalBode(h).CANTIDAD
                        lstDetaSalBode(h).USUARIO_ACT = aEntidad.USUARIO_ACT
                        lstDetaSalBode(h).FECHA_ACT = cFechaHora.ObtenerFechaHora
                        bSalBodeDeta.ActualizarSALBODE_DETA(lstDetaSalBode(h))
                    Next
                End If

                'Eliminar de financiamientos
                Dim listaCreditoEnca As listaCREDITO_ENCA = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_SOLIC_AGRICOLA)
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


    Public Function ObtenerPorUID(ByVal UID_SOLICITUD As Guid) As SOLIC_AGRICOLA
        Try
            Return mDb.ObtenerPorUID(UID_SOLICITUD)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_SOLICITUD As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NOMBLOTE As String, _
                                             ByVal FECHA_SOLICITUD As DateTime, _
                                             ByVal FECHA_APLICA As DateTime, _
                                             ByVal CODIAGRON As String) As listaSOLIC_AGRICOLA
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NUM_SOLICITUD, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBLOTE, FECHA_SOLICITUD, FECHA_APLICA, CODIAGRON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
