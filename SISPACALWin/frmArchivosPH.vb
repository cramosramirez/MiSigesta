Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports System.IO
Imports SISPACAL.DL

Public Class frmArchivosPH

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.rbtPlanillaNormal.Checked = True
        Me.lblRangoCompensacion.Visible = False
        Me.cbxRANGO_COMPENSACION1.Visible = False

        Me.cbxTipoDocumento.Items.Clear()
        Me.cbxTipoDocumento.Items.Add("CHEQUE")
        Me.cbxTipoDocumento.Items.Add("NOTA DE CARGO")
        Me.cbxTipoDocumento.SelectedIndex = 0
    End Sub

    Private Sub frmArchivosPH_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmArchivosPH_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Inicializar()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Sub GenerarArchivosPH_CHEQUES()
        Dim listaCheques As New listaCHEQUE_PLANILLA
        Dim bCheque As New cCHEQUE_PLANILLA
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
        Dim noPartidaPH As Integer
        Dim lRet As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Try

            'Asisnar número de partida
            noPartidaPH = Convert.ToInt32(Me.txtNO_PARTIDA_PH.Text)
            Select Case True
                Case rbtPlanillaNormal.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, False, False, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtAnticipo.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtComplemento.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtComplementoAdicional.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoVFP_Adicional, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtIncentivo.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtCompensacionTransporte.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoTransportistas, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtCompensacion.Checked
                    If Me.cbxRANGO_COMPENSACION1.SelectedValue IsNot Nothing Then
                        listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.CompensacionEntregaCana, CInt(Me.cbxRANGO_COMPENSACION1.SelectedValue), "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                    Else
                        MsgBox("Seleccione el rango de compensación", vbCritical, Application.ProductName)
                        Return
                    End If
                Case rbtFrenteRozaParticular.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteRozaParticular, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtFrenteRozaINJIBOA.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteRozaINJIBOA, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtFrenteQuerqueoParticular.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteQuerqueoParticular, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
                Case rbtFrenteQuerqueoINJIBOA.Checked
                    listaCheques = (New cCHEQUE_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA, "ID_TIPO_PLANILLA, NO_CHEQUE", "ASC")
            End Select
            If listaCheques Is Nothing OrElse (listaCheques IsNot Nothing AndAlso listaCheques.Count = 0) Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("No se encontraron cheques generados para la seleccion ingresada", vbInformation, Application.ProductName)
                Return
            End If
            For Each cheque As CHEQUE_PLANILLA In listaCheques
                cheque.NO_PARTIDA_PH = noPartidaPH
                lRet = bCheque.ActualizarCHEQUE_PLANILLA(cheque)
                noPartidaPH += 1

                If Not lRet >= 1 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al actualizar N° de partida del PH", vbCritical, Application.ProductName)
                    Return
                End If
            Next

            'Crear archivos para PH
            Dim dtMoviban As New DS_DS1.movibanDataTable
            Dim dtDetabank As New DS_DS1.detabankDataTable
            Dim daMoviban As New DS_DS1TableAdapters.movibanTableAdapter
            Dim daDetabank As New DS_DS1TableAdapters.detabankTableAdapter
            Dim strDirectorio As String = Me.txtDirectorio.Text.Trim
            Dim bRet As Boolean = False
            Dim nombreMoviban As String = ""
            Dim nombreDetabank As String = ""

            Select Case True
                Case rbtPlanillaNormal.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & ".xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & ".xlsx"
                    daMoviban.Fill(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue)
                Case rbtAnticipo.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Anticipo.xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Anticipo.xlsx"
                    daMoviban.FillPorAnticipo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros)
                Case rbtComplemento.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento Valor Final.xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento Valor Final.xlsx"
                    daMoviban.FillPorComplementoVFP(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago)
                Case rbtComplementoAdicional.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento VFP Adicional.xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento VFP Adicional.xlsx"
                    daMoviban.FillComplementoVFP_Adicional(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoVFP_Adicional)
                Case rbtCompensacion.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Compensacion Entrega Caña - " & Me.cbxRANGO_COMPENSACION1.Text.Replace("/", "-") & ".xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Compensacion Entrega Caña - " & Me.cbxRANGO_COMPENSACION1.Text.Replace("/", "-") & ".xlsx"
                    daMoviban.FillPorPlanillaBase(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.CompensacionEntregaCana, CInt(Me.cbxRANGO_COMPENSACION1.SelectedValue))
                Case rbtIncentivo.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Incentivo a Productores.xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Incentivo a Productores.xlsx"
                    daMoviban.FillPorIncentivo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores)
                Case rbtCompensacionTransporte.Checked
                    nombreMoviban = "moviban Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento a Transportistas.xlsx"
                    nombreDetabank = "detabank Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento a Transportistas.xlsx"
                    daMoviban.FillPorIncentivo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoTransportistas)
                Case rbtFrenteRozaParticular.Checked
                    nombreMoviban = "moviban Corte " & lCatorcena.CATORCENA.ToString & " Planilla Frente Roza Particular.xlsx"
                    nombreDetabank = "detabank Corte " & lCatorcena.CATORCENA.ToString & " Planilla Frente Roza Particular.xlsx"
                    daMoviban.FillPorIncentivo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteRozaParticular)
                Case rbtFrenteRozaINJIBOA.Checked
                    nombreMoviban = "moviban Corte " & lCatorcena.CATORCENA.ToString & " Planilla Frente Roza INJIBOA.xlsx"
                    nombreDetabank = "detabank Corte " & lCatorcena.CATORCENA.ToString & " Planilla Frente Roza INJIBOA.xlsx"
                    daMoviban.FillPorIncentivo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteRozaINJIBOA)
                Case rbtFrenteQuerqueoParticular.Checked
                    nombreMoviban = "moviban Corte " & lCatorcena.CATORCENA.ToString & " Planilla Querqueo Particular.xlsx"
                    nombreDetabank = "detabank Corte " & lCatorcena.CATORCENA.ToString & " Planilla Querqueo a Transportistas.xlsx"
                    daMoviban.FillPorIncentivo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteQuerqueoParticular)
                Case rbtFrenteQuerqueoINJIBOA.Checked
                    nombreMoviban = "moviban Corte " & lCatorcena.CATORCENA.ToString & " Planilla Querqueo INJIBOA.xlsx"
                    nombreDetabank = "detabank Corte " & lCatorcena.CATORCENA.ToString & " Planilla Querqueo INJIBOA.xlsx"
                    daMoviban.FillPorIncentivo(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA)
            End Select

            If Microsoft.VisualBasic.Right(strDirectorio, 1) <> "\" Then
                strDirectorio = strDirectorio & "\"
            End If

            If dtMoviban.Rows.Count > 0 Then
                bRet = Me.ExportarExcel(dtMoviban, strDirectorio & nombreMoviban, "moviban", True)
                If bRet Then
                    Select Case True
                        Case rbtPlanillaNormal.Checked
                            daDetabank.Fill(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue)
                        Case rbtAnticipo.Checked
                            daDetabank.FillPorAnticipo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros)
                        Case rbtComplemento.Checked
                            daDetabank.FillPorComplementoVFP(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago)
                        Case rbtComplementoAdicional.Checked
                            daDetabank.FillPorComplementoVFP_Adicional(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoVFP_Adicional)
                        Case rbtCompensacion.Checked
                            daDetabank.FillPorPlanillaBase(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.CompensacionEntregaCana, CInt(Me.cbxRANGO_COMPENSACION1.SelectedValue))
                        Case rbtIncentivo.Checked
                            daDetabank.FillPorIncentivo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores)
                        Case rbtCompensacionTransporte.Checked
                            daDetabank.FillPorIncentivo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoTransportistas)
                        Case rbtFrenteRozaParticular.Checked
                            daDetabank.FillPorIncentivo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteRozaParticular)
                        Case rbtFrenteRozaINJIBOA.Checked
                            daDetabank.FillPorIncentivo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteRozaINJIBOA)
                        Case rbtFrenteQuerqueoParticular.Checked
                            daDetabank.FillPorIncentivo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteQuerqueoParticular)
                        Case rbtFrenteQuerqueoINJIBOA.Checked
                            daDetabank.FillPorIncentivo(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.FrenteQuerqueoINJIBOA)
                    End Select

                    If dtDetabank.Rows.Count > 0 Then
                        bRet = Me.ExportarExcel(dtDetabank, strDirectorio & nombreDetabank, "detabank", False)
                        If bRet Then
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            Me.txtDirectorio.Text = ""
                            Me.txtNO_PARTIDA_PH.Text = ""
                            MsgBox("Los archivos para PH se generaron con éxito", vbInformation, Application.ProductName)
                        Else
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            MsgBox("Error al generar el archivo de detalle de PH", vbInformation, Application.ProductName)
                        End If
                    End If
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al generar el archivo de encabezado de PH", vbInformation, Application.ProductName)
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If


        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Private Sub GenerarArchivosPH_NOTACARGO()
        Dim listaNotaCargo As New ListaNOTACARGO_PLANILLA
        Dim bNotaCargo As New cNOTACARGO_PLANILLA
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
        Dim noPartidaPH As Integer
        Dim lRet As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Try

            'Asisnar número de partida
            noPartidaPH = Convert.ToInt32(Me.txtNO_PARTIDA_PH.Text)
            Select Case True
                Case rbtPlanillaNormal.Checked
                    listaNotaCargo = (New cNOTACARGO_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, -1, "ID_TIPO_PLANILLA, NUM_AUTORIZA_BCO", "ASC")
                Case rbtAnticipo.Checked
                    listaNotaCargo = (New cNOTACARGO_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros, "ID_TIPO_PLANILLA, NUM_AUTORIZA_BCO", "ASC")
                Case rbtComplemento.Checked
                    listaNotaCargo = (New cNOTACARGO_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago, "ID_TIPO_PLANILLA, NUM_AUTORIZA_BCO", "ASC")
                Case rbtComplementoAdicional.Checked
                    listaNotaCargo = (New cNOTACARGO_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoVFP_Adicional, "ID_TIPO_PLANILLA, NUM_AUTORIZA_BCO", "ASC")
                Case rbtIncentivo.Checked
                    listaNotaCargo = (New cNOTACARGO_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores, "ID_TIPO_PLANILLA, NUM_AUTORIZA_BCO", "ASC")
                Case rbtCompensacionTransporte.Checked
                    listaNotaCargo = (New cNOTACARGO_PLANILLA).ObtenerListaPorCATORCENA_TIPO_PLANILLA(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoTransportistas, "ID_TIPO_PLANILLA, NUM_AUTORIZA_BCO", "ASC")
            End Select
            If listaNotaCargo Is Nothing OrElse (listaNotaCargo IsNot Nothing AndAlso listaNotaCargo.Count = 0) Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("No se encontraron notas de cargo generados para la seleccion ingresada", vbInformation, Application.ProductName)
                Return
            End If
            For Each notaCargo As NOTACARGO_PLANILLA In listaNotaCargo
                If notaCargo.NUM_AUTORIZA_BCO > 0 Then
                    notaCargo.NO_PARTIDA_PH = noPartidaPH
                    lRet = bNotaCargo.ActualizarNOTACARGO_PLANILLA(notaCargo)
                    noPartidaPH += 1

                    If Not lRet >= 1 Then
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        MsgBox("Error al actualizar N° de partida del PH", vbCritical, Application.ProductName)
                        Return
                    End If
                End If
            Next

            'Crear archivos para PH
            Dim dtMoviban As New DS_DS1.movibanNCDataTable
            Dim dtDetabank As New DS_DS1.detabankNCDataTable
            Dim daMoviban As New DS_DS1TableAdapters.movibanNCTableAdapter
            Dim daDetabank As New DS_DS1TableAdapters.detabankNCTableAdapter
            Dim strDirectorio As String = Me.txtDirectorio.Text.Trim
            Dim bRet As Boolean = False
            Dim nombreMoviban As String = ""
            Dim nombreDetabank As String = ""

            Select Case True
                Case rbtPlanillaNormal.Checked
                    nombreMoviban = "moviban nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & ".xlsx"
                    nombreDetabank = "detabank nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & ".xlsx"
                    daMoviban.FillPorCriterios(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, -1)
                Case rbtAnticipo.Checked
                    nombreMoviban = "moviban nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Anticipo.xlsx"
                    nombreDetabank = "detabank nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Anticipo.xlsx"
                    daMoviban.FillPorCriterios(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros)
                Case rbtComplemento.Checked
                    nombreMoviban = "moviban nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento Valor Final.xlsx"
                    nombreDetabank = "detabank nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento Valor Final.xlsx"
                    daMoviban.FillPorCriterios(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago)
                Case rbtComplementoAdicional.Checked
                    nombreMoviban = "moviban nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento VFP Adicional.xlsx"
                    nombreDetabank = "detabank nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento VFP Adicional.xlsx"
                    daMoviban.FillPorCriterios(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoVFP_Adicional)
                Case rbtIncentivo.Checked
                    nombreMoviban = "moviban nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Incentivo a Productores.xlsx"
                    nombreDetabank = "detabank nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Incentivo a Productores.xlsx"
                    daMoviban.FillPorCriterios(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores)
                Case rbtCompensacionTransporte.Checked
                    nombreMoviban = "moviban nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento a Transportistas.xlsx"
                    nombreDetabank = "detabank nota cargo Catorcena " & lCatorcena.CATORCENA.ToString & " Planilla Complemento a Transportistas.xlsx"
                    daMoviban.FillPorCriterios(dtMoviban, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoTransportistas)
            End Select

            If Microsoft.VisualBasic.Right(strDirectorio, 1) <> "\" Then
                strDirectorio = strDirectorio & "\"
            End If

            If dtMoviban.Rows.Count > 0 Then
                bRet = Me.ExportarExcel(dtMoviban, strDirectorio & nombreMoviban, "moviban", True)
                If bRet Then
                    Select Case True
                        Case rbtPlanillaNormal.Checked
                            daDetabank.FillPorCriterios(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, -1)
                        Case rbtAnticipo.Checked
                            daDetabank.FillPorCriterios(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros)
                        Case rbtComplemento.Checked
                            daDetabank.FillPorCriterios(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago)
                        Case rbtComplementoAdicional.Checked
                            daDetabank.FillPorCriterios(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoVFP_Adicional)
                        Case rbtIncentivo.Checked
                            daDetabank.FillPorCriterios(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores)
                        Case rbtCompensacionTransporte.Checked
                            daDetabank.FillPorCriterios(dtDetabank, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoTransportistas)
                    End Select

                    If dtDetabank.Rows.Count > 0 Then
                        bRet = Me.ExportarExcel(dtDetabank, strDirectorio & nombreDetabank, "detabank", False)
                        If bRet Then
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            Me.txtDirectorio.Text = ""
                            Me.txtNO_PARTIDA_PH.Text = ""
                            MsgBox("Los archivos para PH se generaron con éxito", vbInformation, Application.ProductName)
                        Else
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            MsgBox("Error al generar el archivo de detalle de PH", vbInformation, Application.ProductName)
                        End If
                    End If
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al generar el archivo de encabezado de PH", vbInformation, Application.ProductName)
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If


        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Private Sub btnGenerarArchivos_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarArchivos.Click
        If txtNO_PARTIDA_PH.Text.Trim = "" Then
            MsgBox("Ingrese el No de Partida Inicial del PH", vbCritical, Application.ProductName)
            txtNO_PARTIDA_PH.Focus()
            Return
        End If
        If txtDirectorio.Text.Trim = "" Then
            MsgBox("Seleccione un directorio", vbCritical, Application.ProductName)
            txtDirectorio.Focus()
            Return
        End If
        If Not My.Computer.FileSystem.DirectoryExists(txtDirectorio.Text.Trim) Then
            MsgBox("El directorio no existe", vbCritical, Application.ProductName)
            txtDirectorio.Focus()
            Return
        End If

        If Me.cbxTipoDocumento.SelectedIndex = 0 Then
            'Cheques
            GenerarArchivosPH_CHEQUES()
        Else
            'Notas de Cargo
            GenerarArchivosPH_NOTACARGO()
        End If
    End Sub

    Private Sub btnSeleccionarDirectorio_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarDirectorio.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            txtDirectorio.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub txtNO_PARTIDA_PH_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNO_PARTIDA_PH.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Function ExportarExcel(ByVal DT As DataTable, ByVal nombreArchivo As String, ByVal nombreHoja As String, ByVal esEncabezado As Boolean) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exApp.DisplayAlerts = False
            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                My.Computer.FileSystem.DeleteFile(nombreArchivo)
            End If
            exLibro = exApp.Workbooks.Add
            exLibro.SaveAs(nombreArchivo)
            exLibro = Nothing
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            exHoja = exLibro.Worksheets.Add()
            exHoja.Name = nombreHoja

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DT.Columns.Count
            Dim NRow As Integer = DT.Rows.Count
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DT.Columns(i - 1).ColumnName.ToString
                'exHoja.Cells.AutoFormat(vFormato)
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If Col = 0 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "@"
                    End If
                    If Col = 4 AndAlso esEncabezado Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "dd/mm/yyyy"
                    End If
                    If Col = 10 AndAlso Not esEncabezado Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "dd/mm/yyyy"
                    End If
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DT.Rows(Fila).Item(Col).ToString()
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            'exApp.Application.Visible = True
            exLibro.Save()
            exLibro.Close()
            exApp.DisplayAlerts = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
            Return True

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            exApp.DisplayAlerts = True
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try
        Return True
    End Function

    Private Sub ConfigRangoCompensacion()
        If Me.rbtCompensacion.Checked Then
            If Me.CbxCATORCENA_ZAFRA1.SelectedValue IsNot Nothing Then
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
            Else
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(-1)
            End If
            Me.lblRangoCompensacion.Visible = True
            Me.cbxRANGO_COMPENSACION1.Visible = True
        Else
            Me.lblRangoCompensacion.Visible = False
            Me.cbxRANGO_COMPENSACION1.Visible = False
        End If
    End Sub

    Private Sub rbtCompensacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCompensacion.CheckedChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCompensacionTransporte.CheckedChanged

    End Sub


End Class