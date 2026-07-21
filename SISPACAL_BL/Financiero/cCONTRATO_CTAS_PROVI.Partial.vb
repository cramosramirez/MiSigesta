Imports SISPACAL.EL.Enumeradores

Partial Public Class cCONTRATO_CTAS_PROVI

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_CTAS_PROVI(ByVal objeto As Object) As Integer
        Try
            Dim lContratoFinan As CONTRATO_FINAN
            Dim lContratoCtasProvi As CONTRATO_CTAS_PROVI
            Dim lstSolicVuelo As listaSOLIC_AGRICOLA_VUELO
            Dim lCuentaFinan As CUENTA_FINAN
            Dim totalProductos As Decimal = 0
            Dim totalVuelo As Decimal = 0
            Dim total As Decimal = 0
            Dim lRet As Int32 = 0

            Select Case True
                Case TypeOf objeto Is SOLIC_AGRICOLA
                    Dim aEntidad As SOLIC_AGRICOLA = CType(objeto, SOLIC_AGRICOLA)
                    lContratoFinan = (New cCONTRATO_FINAN).ObtenerPorZAFRA_CONTRATO(aEntidad.ID_ZAFRA, aEntidad.CODICONTRATO)

                    If aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes OrElse aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.InhibidoresFloracion Then
                        'Recuperar productos
                        lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(aEntidad.ID_CUENTA_FINAN, aEntidad.UID_SOLIC_AGRICOLA)

                        If lContratoCtasProvi Is Nothing Then
                            Dim lstSolicProductos As listaSOLIC_AGRICOLA_PRODUCTO = (New cSOLIC_AGRICOLA_PRODUCTO).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                            lstSolicVuelo = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)

                            totalProductos = 0
                            If lstSolicVuelo Is Nothing OrElse lstSolicVuelo.Count = 0 Then
                                totalProductos = aEntidad.TOTAL
                            Else
                                If lstSolicProductos IsNot Nothing AndAlso lstSolicProductos.Count > 0 Then
                                    For Each prod As SOLIC_AGRICOLA_PRODUCTO In lstSolicProductos
                                        totalProductos += prod.PRECIO_TOTAL
                                    Next
                                End If
                                totalProductos += Math.Round(totalProductos * 0.13, 2)
                            End If
                            
                            If totalProductos > 0 Then
                                lContratoCtasProvi = New CONTRATO_CTAS_PROVI
                                lContratoCtasProvi.ID_CONTRATO_CTAS_PROVI = 0
                                lContratoCtasProvi.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                                lContratoCtasProvi.CODICONTRATO = aEntidad.CODICONTRATO
                                lContratoCtasProvi.ID_ZAFRA = aEntidad.ID_ZAFRA
                                lContratoCtasProvi.FECHA_APLICA = cFechaHora.ObtenerFecha
                                lContratoCtasProvi.CONCEPTO = If(aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes, "MADURANTES - SOLICITUD No. " + aEntidad.NUM_SOLICITUD.ToString + " ZAFRA " + aEntidad.ZAFRA, "INHIBIDORES DE FLORACION - SOLICITUD AGRICOLA N° " + aEntidad.NUM_SOLICITUD.ToString + " ZAFRA " + aEntidad.ZAFRA)
                                lContratoCtasProvi.PROVISION = totalProductos
                                lContratoCtasProvi.ID_CUENTA_FINAN = If(aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes, CuentaFinanciamiento.Madurantes, CuentaFinanciamiento.InhibidoresFloracion)
                                lContratoCtasProvi.UID_SOLICITUD = aEntidad.UID_SOLIC_AGRICOLA
                                lContratoCtasProvi.ZAFRA = aEntidad.ZAFRA
                                lContratoCtasProvi.USUARIO_CREA = Utilerias.ObtenerUsuario
                                lContratoCtasProvi.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                lContratoCtasProvi.USUARIO_ACT = Utilerias.ObtenerUsuario
                                lContratoCtasProvi.FECHA_ACT = cFechaHora.ObtenerFechaHora

                                lRet = Me.ActualizarCONTRATO_CTAS_PROVI(lContratoCtasProvi)
                                If lRet <= 0 Then
                                    Me.sError = "No se reservo la Solicitud Agricola No. " + aEntidad.NUM_SOLICITUD.ToString + "/" + aEntidad.ZAFRA
                                    Return -1
                                End If
                            End If
                        End If

                        'Recuperar vuelo
                        If aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes Then
                            lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(CuentaFinanciamiento.VuelosAereosMadurantes, aEntidad.UID_SOLIC_AGRICOLA)
                        ElseIf aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.InhibidoresFloracion Then
                            lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(CuentaFinanciamiento.VuelosAereosInhibidores, aEntidad.UID_SOLIC_AGRICOLA)
                        End If

                        If lContratoCtasProvi Is Nothing Then
                            lstSolicVuelo = (New cSOLIC_AGRICOLA_VUELO).ObtenerListaPorSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
                            If totalProductos > 0 Then
                                totalVuelo = aEntidad.TOTAL - totalProductos
                            Else
                                totalVuelo = aEntidad.TOTAL
                            End If
                            If totalVuelo > 0 Then
                                lContratoCtasProvi = New CONTRATO_CTAS_PROVI
                                lContratoCtasProvi.ID_CONTRATO_CTAS_PROVI = 0
                                lContratoCtasProvi.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                                lContratoCtasProvi.CODICONTRATO = aEntidad.CODICONTRATO
                                lContratoCtasProvi.ID_ZAFRA = aEntidad.ID_ZAFRA
                                lContratoCtasProvi.FECHA_APLICA = cFechaHora.ObtenerFecha
                                lContratoCtasProvi.CONCEPTO = If(aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes, "VUELO MADURANTES - SOLICITUD No. " + aEntidad.NUM_SOLICITUD.ToString + " ZAFRA " + aEntidad.ZAFRA, "VUELO INHIBIDORES - SOLICITUD AGRICOLA N° " + aEntidad.NUM_SOLICITUD.ToString + " ZAFRA " + aEntidad.ZAFRA)
                                lContratoCtasProvi.PROVISION = totalVuelo
                                lContratoCtasProvi.ID_CUENTA_FINAN = If(aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes, CuentaFinanciamiento.VuelosAereosMadurantes, CuentaFinanciamiento.VuelosAereosInhibidores)
                                lContratoCtasProvi.UID_SOLICITUD = aEntidad.UID_SOLIC_AGRICOLA
                                lContratoCtasProvi.ZAFRA = aEntidad.ZAFRA
                                lContratoCtasProvi.USUARIO_CREA = Utilerias.ObtenerUsuario
                                lContratoCtasProvi.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                lContratoCtasProvi.USUARIO_ACT = Utilerias.ObtenerUsuario
                                lContratoCtasProvi.FECHA_ACT = cFechaHora.ObtenerFechaHora

                                lRet = Me.ActualizarCONTRATO_CTAS_PROVI(lContratoCtasProvi)
                                If lRet <= 0 Then
                                    Me.sError = "No se reservo la Solicitud Agricola No. " + aEntidad.NUM_SOLICITUD.ToString + "/" + aEntidad.ZAFRA
                                    Return -1
                                End If
                            End If
                        End If
                    Else
                        'Otro tipo de producto
                        lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(aEntidad.ID_CUENTA_FINAN, aEntidad.UID_SOLIC_AGRICOLA)
                        lCuentaFinan = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(aEntidad.ID_CUENTA_FINAN)

                        If lContratoCtasProvi Is Nothing Then
                            lContratoCtasProvi = New CONTRATO_CTAS_PROVI
                            lContratoCtasProvi.ID_CONTRATO_CTAS_PROVI = 0
                            lContratoCtasProvi.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                            lContratoCtasProvi.CODICONTRATO = aEntidad.CODICONTRATO
                            lContratoCtasProvi.ID_ZAFRA = aEntidad.ID_ZAFRA
                            lContratoCtasProvi.FECHA_APLICA = cFechaHora.ObtenerFecha
                            lContratoCtasProvi.CONCEPTO = lCuentaFinan.NOMBRE_CUENTA.ToUpper + " SOLICITUD AGRICOLA No. " + aEntidad.NUM_SOLICITUD.ToString + " ZAFRA " + aEntidad.ZAFRA
                            lContratoCtasProvi.PROVISION = aEntidad.TOTAL
                            lContratoCtasProvi.ID_CUENTA_FINAN = If(aEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.Madurantes, CuentaFinanciamiento.Madurantes, CuentaFinanciamiento.InhibidoresFloracion)
                            lContratoCtasProvi.UID_SOLICITUD = aEntidad.UID_SOLIC_AGRICOLA
                            lContratoCtasProvi.ZAFRA = aEntidad.ZAFRA
                            lContratoCtasProvi.USUARIO_CREA = Utilerias.ObtenerUsuario
                            lContratoCtasProvi.FECHA_CREA = cFechaHora.ObtenerFechaHora
                            lContratoCtasProvi.USUARIO_ACT = Utilerias.ObtenerUsuario
                            lContratoCtasProvi.FECHA_ACT = cFechaHora.ObtenerFechaHora

                            lRet = Me.ActualizarCONTRATO_CTAS_PROVI(lContratoCtasProvi)
                            If lRet <= 0 Then
                                Me.sError = "No se reservo la Solicitud Agricola No. " + aEntidad.NUM_SOLICITUD.ToString + "/" + aEntidad.ZAFRA
                                Return -1
                            End If
                        End If
                    End If

                    'Case TypeOf objeto Is SOLIC_OPI
                    '    Dim aEntidad As SOLIC_OPI = CType(objeto, SOLIC_OPI)
                    '    lContratoFinan = (New cCONTRATO_FINAN).ObtenerPorZAFRA_CONTRATO(aEntidad.ID_ZAFRA, "")

                    '    lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(CuentaFinanciamiento.OpisBancarias, aEntidad.UID_OPI_CONTRATO)
                    '    lCuentaFinan = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(CuentaFinanciamiento.OpisBancarias)

                    '    If lContratoCtasProvi Is Nothing Then
                    '        lContratoCtasProvi = New CONTRATO_CTAS_PROVI
                    '        lContratoCtasProvi.ID_CONTRATO_CTAS_PROVI = 0
                    '        lContratoCtasProvi.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                    '        lContratoCtasProvi.CODICONTRATO = ""
                    '        lContratoCtasProvi.ID_ZAFRA = aEntidad.ID_ZAFRA
                    '        lContratoCtasProvi.FECHA_APLICA = cFechaHora.ObtenerFecha
                    '        lContratoCtasProvi.CONCEPTO = lCuentaFinan.NOMBRE_CUENTA.ToUpper + " SOLICITUD No. " + aEntidad.NUM_OPI_ZAFRA
                    '        lContratoCtasProvi.PROVISION = aEntidad.MONTO
                    '        lContratoCtasProvi.ID_CUENTA_FINAN = CuentaFinanciamiento.Anticipos
                    '        lContratoCtasProvi.UID_SOLICITUD = aEntidad.UID_OPI_CONTRATO
                    '        lContratoCtasProvi.ZAFRA = aEntidad.ZAFRA
                    '        lContratoCtasProvi.USUARIO_CREA = Utilerias.ObtenerUsuario
                    '        lContratoCtasProvi.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    '        lContratoCtasProvi.USUARIO_ACT = Utilerias.ObtenerUsuario
                    '        lContratoCtasProvi.FECHA_ACT = cFechaHora.ObtenerFechaHora

                    '        lRet = Me.ActualizarCONTRATO_CTAS_PROVI(lContratoCtasProvi)
                    '        If lRet <= 0 Then
                    '            Me.sError = "No se reservo la Solicitud de OPI No. " + aEntidad.NUM_OPI_ZAFRA.ToString + "/" + aEntidad.ZAFRA
                    '            Return -1
                    '        End If
                    '    End If

                    'Case TypeOf objeto Is SOLIC_ANTICIPO
                    '    Dim aEntidad As SOLIC_ANTICIPO = CType(objeto, SOLIC_ANTICIPO)
                    '    lContratoFinan = (New cCONTRATO_FINAN).ObtenerPorZAFRA_CONTRATO(aEntidad.ID_ZAFRA, aEntidad.CODICONTRATO)

                    '    lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(CuentaFinanciamiento.Anticipos, aEntidad.UID_ANTICIPO_CONTRATO)
                    '    lCuentaFinan = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(CuentaFinanciamiento.Anticipos)

                    '    If lContratoCtasProvi Is Nothing Then
                    '        lContratoCtasProvi = New CONTRATO_CTAS_PROVI
                    '        lContratoCtasProvi.ID_CONTRATO_CTAS_PROVI = 0
                    '        lContratoCtasProvi.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                    '        lContratoCtasProvi.CODICONTRATO = ""
                    '        lContratoCtasProvi.ID_ZAFRA = aEntidad.ID_ZAFRA
                    '        lContratoCtasProvi.FECHA_APLICA = cFechaHora.ObtenerFecha
                    '        lContratoCtasProvi.CONCEPTO = lCuentaFinan.NOMBRE_CUENTA.ToUpper + " SOLICITUD No. " + aEntidad.NUM_ANTICIPO.ToString + " ZAFRA " + aEntidad.ZAFRA
                    '        lContratoCtasProvi.PROVISION = aEntidad.MONTO
                    '        lContratoCtasProvi.ID_CUENTA_FINAN = CuentaFinanciamiento.Anticipos
                    '        lContratoCtasProvi.UID_SOLICITUD = aEntidad.UID_ANTICIPO_CONTRATO
                    '        lContratoCtasProvi.ZAFRA = aEntidad.ZAFRA
                    '        lContratoCtasProvi.USUARIO_CREA = Utilerias.ObtenerUsuario
                    '        lContratoCtasProvi.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    '        lContratoCtasProvi.USUARIO_ACT = Utilerias.ObtenerUsuario
                    '        lContratoCtasProvi.FECHA_ACT = cFechaHora.ObtenerFechaHora

                    '        lRet = Me.ActualizarCONTRATO_CTAS_PROVI(lContratoCtasProvi)
                    '        If lRet <= 0 Then
                    '            Me.sError = "No se reservo la Solicitud de Anticipo No. " + aEntidad.NUM_ANTICIPO.ToString + "/" + aEntidad.ZAFRA
                    '            Return -1
                    '        End If
                    '    End If

                    'Case TypeOf objeto Is MEMBRE_GREMIAL
                    '    Dim aEntidad As MEMBRE_GREMIAL = CType(objeto, MEMBRE_GREMIAL)
                    '    lContratoFinan = (New cCONTRATO_FINAN).ObtenerPorZAFRA_CONTRATO(aEntidad.ID_ZAFRA, aEntidad.CODICONTRATO)

                    '    lContratoCtasProvi = mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(CuentaFinanciamiento.Anticipos, aEntidad.UID_OPI_CONTRATO)
                    '    lCuentaFinan = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(CuentaFinanciamiento.Anticipos)

                    '    If lContratoCtasProvi Is Nothing Then
                    '        lContratoCtasProvi = New CONTRATO_CTAS_PROVI
                    '        lContratoCtasProvi.ID_CONTRATO_CTAS_PROVI = 0
                    '        lContratoCtasProvi.ID_CONTRATO_FINAN = lContratoFinan.ID_CONTRATO_FINAN
                    '        lContratoCtasProvi.CODICONTRATO = aEntidad.CODICONTRATO
                    '        lContratoCtasProvi.ID_ZAFRA = aEntidad.ID_ZAFRA
                    '        lContratoCtasProvi.FECHA_APLICA = cFechaHora.ObtenerFecha
                    '        lContratoCtasProvi.CONCEPTO = "PROVISION DE " + lCuentaFinan.NOMBRE_CUENTA.ToUpper + " SOLICITUD DE OPI No. " + aEntidad.NUM_OPI.ToString + "/" + aEntidad.ZAFRA
                    '        lContratoCtasProvi.PROVISION = aEntidad.MONTO
                    '        lContratoCtasProvi.ID_CUENTA_FINAN = CuentaFinanciamiento.Anticipos
                    '        lContratoCtasProvi.UID_SOLICITUD = aEntidad.UID_OPI_CONTRATO
                    '        lContratoCtasProvi.ZAFRA = aEntidad.ZAFRA
                    '        lContratoCtasProvi.USUARIO_CREA = Utilerias.ObtenerUsuario
                    '        lContratoCtasProvi.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    '        lContratoCtasProvi.USUARIO_ACT = Utilerias.ObtenerUsuario
                    '        lContratoCtasProvi.FECHA_ACT = cFechaHora.ObtenerFechaHora

                    '        lRet = Me.ActualizarCONTRATO_CTAS_PROVI(lContratoCtasProvi)
                    '        If lRet <= 0 Then
                    '            Me.sError = "No se provisiono la Solicitud de Anticipo No. " + aEntidad.NUM_OPI.ToString + "/" + aEntidad.ZAFRA
                    '            Return -1
                    '        End If
                    '    End If
            End Select

            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(ByVal ID_CUENTA_FINAN As Int32, ByVal UID_SOLICITUD As Guid) As CONTRATO_CTAS_PROVI
        Try
            Return mDb.ObtenerCONTRATO_CTAS_PROVIPorIdCuentaFinan_UID(ID_CUENTA_FINAN, UID_SOLICITUD)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal TIPO_CONTRIBUYENTE As Int32, ByVal CODIPROVEEDOR As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, ByVal ID_CUENTA_FINAN As Int32) As listaCONTRATO_CTAS_PROVI
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, TIPO_CONTRIBUYENTE, CODIPROVEEDOR, NOMBRE_PROVEEDOR, ID_CUENTA_FINAN)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorUID(ByVal UID_SOLICITUD As Guid) As listaCONTRATO_CTAS_PROVI
        Try
            Return mDb.ObtenerListaPorUID(UID_SOLICITUD)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
