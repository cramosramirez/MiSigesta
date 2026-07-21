Imports CrystalDecisions.CrystalReports.Engine
Imports SISPACAL.DL
Imports SISPACAL.RL

Public Class frmImpresiones

    Public Sub CargarCheques(ID_CATORCENA As Integer, ID_TIPO_PLANILLA As Integer, ByVal OPCION_CONTRIBUYENTE As Integer, ByVal CODIBANCO As Int32, Optional ID_RANGO_COMPE As Object = Nothing)
        Try

            Dim dsCatorcena As New DS_CATORCENA
            Dim dt As New DS_CATORCENA.CHEQUESDataTable
            Dim adapter As New DS_CATORCENATableAdapters.CHEQUESTableAdapter

            If ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.AnticipoCaneros AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoValorFinalPago AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.CompensacionEntregaCana AndAlso
                 ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoVFP_Adicional AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.IncentivoProductores Then
                adapter.FillBy(dt, ID_CATORCENA, ID_TIPO_PLANILLA, OPCION_CONTRIBUYENTE, CODIBANCO)
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                adapter.FillByAnticipo(dt, ID_CATORCENA, ID_TIPO_PLANILLA, OPCION_CONTRIBUYENTE, CODIBANCO)
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoValorFinalPago OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.IncentivoProductores OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoVFP_Adicional Then
                adapter.FillByComplementoVFP(dt, ID_CATORCENA, ID_TIPO_PLANILLA, OPCION_CONTRIBUYENTE, CODIBANCO)
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
                If ID_RANGO_COMPE IsNot Nothing AndAlso IsNumeric(ID_RANGO_COMPE) Then
                    adapter.FillPorPlanillaBase(dt, ID_CATORCENA, ID_TIPO_PLANILLA, OPCION_CONTRIBUYENTE, CInt(ID_RANGO_COMPE), CODIBANCO)
                End If
            End If

            dsCatorcena.Tables("CHEQUES").Merge(dt)

            Select Case CODIBANCO
                Case 16
                    'Dim reporte As New ChequeDAVIVIENDA
                    Dim reporte As New ChequeDAVIVIENDA_2
                    reporte.SetDataSource(dsCatorcena)
                    CrystalReportViewer1.ReportSource = reporte
                Case 6
                    Dim reporte As New ChequeBH
                    reporte.SetDataSource(dsCatorcena)
                    CrystalReportViewer1.ReportSource = reporte
                Case 4
                    Dim reporte As New ChequeBAC
                    reporte.SetDataSource(dsCatorcena)
                    CrystalReportViewer1.ReportSource = reporte
                Case 8
                    Dim reporte As New ChequePROMERICA
                    reporte.SetDataSource(dsCatorcena)
                    CrystalReportViewer1.ReportSource = reporte
                Case Else
                    MsgBox("No se ha configurado reporte de cheques para el banco seleccionado", vbCritical, Application.ProductName)
                    Return
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Sub

    Public Sub CargarPlanilla(ID_CATORCENA As Integer, ID_TIPO_PLANILLA As Integer, ByVal ES_CONTRIBUYENTE As Boolean, Optional RANGO_COMPENSACION As Object = Nothing, Optional TIPO_PAGO As Integer = -1)
        Try

            Dim dsPlanilla As New DS_DS1
            Dim dt As New DS_DS1.PlanillaDataTable
            Dim adapter As New DS_DS1TableAdapters.PlanillaTableAdapter

            If ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.AnticipoCaneros AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoValorFinalPago AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoVFP_Adicional AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.CompensacionEntregaCana AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.IncentivoProductores AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.FrenteRozaParticular AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.FrenteRozaINJIBOA AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.FrenteQuerqueoParticular AndAlso
                ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA Then
                adapter.FillPorCatorcena(dt, TIPO_PAGO, ID_CATORCENA, ES_CONTRIBUYENTE, ID_TIPO_PLANILLA)
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                adapter.FillParaAnticipo(dt, ID_CATORCENA, ES_CONTRIBUYENTE, ID_TIPO_PLANILLA)
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoValorFinalPago OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.IncentivoProductores OrElse
                ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoVFP_Adicional Then
                adapter.FillParaComplementoVFP(dt, -1, ID_CATORCENA, ES_CONTRIBUYENTE, ID_TIPO_PLANILLA)
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
                If RANGO_COMPENSACION IsNot Nothing AndAlso IsNumeric(RANGO_COMPENSACION) Then
                    adapter.FillPorPlanillaBase(dt, -1, ID_CATORCENA, ES_CONTRIBUYENTE, ID_TIPO_PLANILLA, CInt(RANGO_COMPENSACION))
                Else
                    Return
                End If
            ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.FrenteRozaParticular OrElse
                   ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.FrenteQuerqueoParticular OrElse
                   ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.FrenteRozaINJIBOA OrElse
                   ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA Then
                adapter.FillPorFrentes(dt, TIPO_PAGO, ID_CATORCENA, ES_CONTRIBUYENTE, ID_TIPO_PLANILLA)
            End If

            dsPlanilla.Tables("PLANILLA").Merge(dt)

            Select Case ID_TIPO_PLANILLA
                Case Enumeradores.TipoPlanilla.Cañeros
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaCanerosContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaCanerosNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.Transportistas, Enumeradores.TipoPlanilla.ComplementoTransportistas
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaTransportistasContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaTransportistasNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.Cargadoras
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaCargadorasContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaCargadorasNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.AnticipoCaneros
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaAnticipoCanerosContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaAnticipoCanerosNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.ComplementoValorFinalPago
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaComplementoVFPCanerosContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaComplementoVFPCanerosNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.ComplementoVFP_Adicional
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaComplementoVFP_Adicional_CanerosContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaComplementoVFP_Adicional_CanerosNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.CompensacionEntregaCana
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaCompensacionCanerosContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaCompensacionCanerosNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.IncentivoProductores
                    If ES_CONTRIBUYENTE Then
                        Dim reporte As New PlanillaIncentivoProductoresContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New PlanillaIncentivoProductoresNoContribuyentes
                        reporte.SetDataSource(dsPlanilla)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
                Case Enumeradores.TipoPlanilla.FrenteRozaParticular, Enumeradores.TipoPlanilla.FrenteQuerqueoParticular
                    Dim reporte As New PlanillaFrenteParticular
                    reporte.SetDataSource(dsPlanilla)
                    CrystalReportViewer1.ReportSource = reporte
                Case Enumeradores.TipoPlanilla.FrenteRozaINJIBOA, Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA
                    Dim reporte As New PlanillaFrenteJiboa
                    reporte.SetDataSource(dsPlanilla)
                    CrystalReportViewer1.ReportSource = reporte
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Sub

    Public Sub CargarComprobante(ID_CATORCENA As Integer, ID_TIPO_PLANILLA As Integer, ByVal TIPO_DOCUMENTO As Integer, ByVal ID_COMPROB_CONCE As Integer, ByVal NO_DOCTOini As Integer, ByVal NO_DOCTOfin As Integer, Optional ES_FACTURA_CONTINUA As Boolean = True, Optional ID_RANGO_COMPE As Object = Nothing)
        Try

            Dim dsComprobantes As New DS_COMPROBANTES

            Select Case TIPO_DOCUMENTO
                Case 1 'Comprobante de retención 1%
                    Dim dt As New DS_COMPROBANTES.COMPROBANTE_RETENCIONDataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.COMPROBANTE_RETENCIONTableAdapter
                    Dim reporte As New ComprobanteRetencion
                    If ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.AnticipoCaneros AndAlso
                        ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoValorFinalPago AndAlso
                         ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoVFP_Adicional AndAlso
                         ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.IncentivoProductores Then
                        adapter.Fill(dt, 1, ID_CATORCENA, ID_TIPO_PLANILLA, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                        adapter.FillPorAnticipo(dt, 1, ID_CATORCENA, ID_TIPO_PLANILLA, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoValorFinalPago OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.IncentivoProductores OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoVFP_Adicional Then
                        adapter.FillPorComplementoVFP(dt, 1, ID_CATORCENA, ID_TIPO_PLANILLA, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                        'ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
                        '    If ID_RANGO_COMPE IsNot Nothing AndAlso IsNumeric(ID_RANGO_COMPE) Then
                        '        adapter.FillPorCompensacion(dt, 1, ID_CATORCENA, ID_TIPO_PLANILLA, CInt(ID_RANGO_COMPE))
                        '    Else
                        '        Return
                        '    End If
                    End If
                    dsComprobantes.Tables("COMPROBANTE_RETENCION").Merge(dt)
                    reporte.SetDataSource(dsComprobantes)
                    CrystalReportViewer1.ReportSource = reporte

                Case 2 'Comprobante de retención NO CONTRIBUYENTES
                    Dim dt As New DS_COMPROBANTES.COMPROBANTE_RETENCIONDataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.COMPROBANTE_RETENCIONTableAdapter
                    Dim reporte As New ComprobanteRetencion
                    If ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.AnticipoCaneros AndAlso
                        ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.ComplementoValorFinalPago AndAlso
                         ID_TIPO_PLANILLA <> Enumeradores.TipoPlanilla.IncentivoProductores Then
                        adapter.Fill(dt, 2, ID_CATORCENA, ID_TIPO_PLANILLA, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.AnticipoCaneros Then
                        adapter.FillPorAnticipo(dt, 2, ID_CATORCENA, ID_TIPO_PLANILLA, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoValorFinalPago OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.IncentivoProductores OrElse ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.ComplementoVFP_Adicional Then
                        adapter.FillPorComplementoVFP(dt, 2, ID_CATORCENA, ID_TIPO_PLANILLA, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                        'ElseIf ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
                        '    If ID_RANGO_COMPE IsNot Nothing AndAlso IsNumeric(ID_RANGO_COMPE) Then
                        '        adapter.FillPorCompensacion(dt, 2, ID_CATORCENA, ID_TIPO_PLANILLA, CInt(ID_RANGO_COMPE))
                        '    Else
                        '        Return
                        '    End If
                    End If
                    dsComprobantes = New DS_COMPROBANTES
                    dsComprobantes.Tables("COMPROBANTE_RETENCION").Merge(dt)
                    reporte.SetDataSource(dsComprobantes)
                    CrystalReportViewer1.ReportSource = reporte

                Case 3 'Comprobante de credito fiscal
                    Dim dt As New DS_COMPROBANTES.FACTURACION_SERVICIOS_DEL__INGENIODataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.FACTURACION_SERVICIOS_DEL__INGENIOTableAdapter
                    Dim reporte As New CreditoFiscalServiciosIngenio
                    adapter.Fill(dt, ID_CATORCENA, ID_TIPO_PLANILLA, 1, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    dsComprobantes = New DS_COMPROBANTES
                    dsComprobantes.Tables("FACTURACION_SERVICIOS_DEL _INGENIO").Merge(dt)
                    reporte.SetDataSource(dsComprobantes)
                    CrystalReportViewer1.ReportSource = reporte

                Case 4 'Factura
                    Dim dt As New DS_COMPROBANTES.FACTURACION_SERVICIOS_DEL__INGENIODataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.FACTURACION_SERVICIOS_DEL__INGENIOTableAdapter
                    adapter.Fill(dt, ID_CATORCENA, ID_TIPO_PLANILLA, 0, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    dsComprobantes = New DS_COMPROBANTES
                    dsComprobantes.Tables("FACTURACION_SERVICIOS_DEL _INGENIO").Merge(dt)

                    If ES_FACTURA_CONTINUA Then
                        Dim reporte As New FacturaContinua
                        reporte.SetDataSource(dsComprobantes)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New FacturaLibre
                        reporte.SetDataSource(dsComprobantes)
                        CrystalReportViewer1.ReportSource = reporte
                    End If

                Case 5 'Factura de sujeto excluido
                    Dim dt As New DS_COMPROBANTES.COMPROBANTE_RETENCIONDataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.COMPROBANTE_RETENCIONTableAdapter
                    Dim reporte As New FacturaSujetoExcluido

                    adapter.FillPorSujetoExcluido(dt, ID_CATORCENA, ID_TIPO_PLANILLA, False, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    dsComprobantes = New DS_COMPROBANTES
                    dsComprobantes.Tables("COMPROBANTE_RETENCION").Merge(dt)
                    reporte.SetDataSource(dsComprobantes)
                    CrystalReportViewer1.ReportSource = reporte

                Case 6 'Comprobante de credito fiscal AT/SDV
                    Dim dt As New DS_COMPROBANTES.FACTURACION_SERVICIOS_DEL__INGENIODataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.FACTURACION_SERVICIOS_DEL__INGENIOTableAdapter
                    Dim reporte As New CreditoFiscalServiciosIngenio
                    adapter.FillServicioTransportista(dt, ID_CATORCENA, ID_TIPO_PLANILLA, 1, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    dsComprobantes = New DS_COMPROBANTES
                    dsComprobantes.Tables("FACTURACION_SERVICIOS_DEL _INGENIO").Merge(dt)
                    reporte.SetDataSource(dsComprobantes)
                    CrystalReportViewer1.ReportSource = reporte

                Case 7 'Factura AT/SDV
                    Dim dt As New DS_COMPROBANTES.FACTURACION_SERVICIOS_DEL__INGENIODataTable
                    Dim adapter As New DS_COMPROBANTESTableAdapters.FACTURACION_SERVICIOS_DEL__INGENIOTableAdapter
                    adapter.FillServicioTransportista(dt, ID_CATORCENA, ID_TIPO_PLANILLA, 0, ID_COMPROB_CONCE, NO_DOCTOini, NO_DOCTOfin)
                    dsComprobantes = New DS_COMPROBANTES
                    dsComprobantes.Tables("FACTURACION_SERVICIOS_DEL _INGENIO").Merge(dt)

                    If ES_FACTURA_CONTINUA Then
                        Dim reporte As New FacturaContinua
                        reporte.SetDataSource(dsComprobantes)
                        CrystalReportViewer1.ReportSource = reporte
                    Else
                        Dim reporte As New FacturaLibre
                        reporte.SetDataSource(dsComprobantes)
                        CrystalReportViewer1.ReportSource = reporte
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class