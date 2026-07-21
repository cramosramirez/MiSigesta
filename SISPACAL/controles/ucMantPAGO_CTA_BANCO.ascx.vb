Imports ClosedXML.Excel
Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.DL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Data
Imports System.IO

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPAGO_CTA_BANCO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PAGO_CTA_BANCO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPAGO_CTA_BANCO
    Inherits ucBase

    Private Const DirectorioUpload As String = "~/SubidosExcelCosecha/"

#Region "Inicializaciones Mantenimiento"

    Public Property ID_CATORCENA As Integer
        Get
            If Session("pagoCtaID_CATORCENA") IsNot Nothing Then
                Return Session("pagoCtaID_CATORCENA")
            Else
                Return -1
            End If
        End Get
        Set(value As Integer)
            Session("pagoCtaID_CATORCENA") = value
        End Set
    End Property

    Public Property ID_TIPO_PLANILLA As Integer
        Get
            If Session("pagoCtaID_TIPO_PLANILLA") IsNot Nothing Then
                Return Session("pagoCtaID_TIPO_PLANILLA")
            Else
                Return -1
            End If
        End Get
        Set(value As Integer)
            Session("pagoCtaID_TIPO_PLANILLA") = value
        End Set
    End Property

    Public Property ES_REGISTRO_CCF As Boolean
        Get
            If Me.ViewState("ES_REGISTRO_CCF") IsNot Nothing Then
                Return Me.ViewState("ES_REGISTRO_CCF")
            Else
                Return True
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("ES_REGISTRO_CCF") = value
        End Set
    End Property

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar", False, IconoBarra.ExportarXls, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Actualizar", "Actualizar cuentas y Monto a Pagar", False, IconoBarra.Actualizar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarArchivo", "Generar archivo", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarArchivoFtoPlanilla", "Generar archivo en formato de planilla", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarNotasCargo", "1. Notas de Cargo - Emitir", False, IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("CargarTransferenciaBanco", "2. Notas de Cargo - Cargar transferencia del banco", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarCatorcenas()
        Me.cbxTIPO_PLANILLA.SelectedIndex = 0

        Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = ES_REGISTRO_CCF

        If ES_REGISTRO_CCF Then
            Me.lblTitulo.Text = "Registro de Comprobantes de Crédito Fiscal para Pago"
        Else
            Me.lblTitulo.Text = "Generacion de Pago a Cuenta Bancaria"
        End If
    End Sub

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarPAGO_CTA_BANCO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarPAGO_CTA_BANCO() As Integer
        If Me.ucListaPAGO_CTA_BANCO1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub CargarCatorcenas()
        Dim lista As listaCATORCENA_ZAFRA

        If Me.cbxZAFRA.Value IsNot Nothing Then
            lista = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
        Else
            lista = New listaCATORCENA_ZAFRA
        End If
        Me.cbxCATORCENA_ZAFRA.DataSource = lista
        Me.cbxCATORCENA_ZAFRA.DataBind()
        If Me.cbxCATORCENA_ZAFRA.Items.Count > 0 Then Me.cbxCATORCENA_ZAFRA.SelectedIndex = 0
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.Buscar()

            Case "Exportar"
                Me.ucListaPAGO_CTA_BANCO1.ExportarToXls(Me.cbxTIPO_PLANILLA.Text + " CORTE " + Me.cbxCATORCENA_ZAFRA.Text + " " + Me.cbxMOSTRAR_POR.Text)


            Case "Actualizar"
                Dim idCatorcena As Int32 = -2
                Dim idTipoPlanilla As Int32 = -2

                If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
                If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value

                Me.Buscar()
                Me.AsignarMensaje("La informacion de Cuentas Bancarias y Monto a Pagar se ha actualizado para los pagos no generados", False, True, True)

            Case "GenerarArchivoFtoPlanilla"
                If Me.rblTIPO_CONTRIBUYENTE.Value = -1 Then
                    AsignarMensaje("Para generar el archivo debe seleccionar solo un tipo de contribuyente", False, True, True)
                    Return
                End If

                Dim idCatorcena As Int32 = -2
                Dim idTipoPlanilla As Int32 = -2
                Dim iEsContibuyente As Int32 = -1
                Dim lstpagoCta As listaPAGO_CTA_BANCO
                Dim lPlanilla As PLANILLA

                If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
                If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
                If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
                    iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
                End If
                lstpagoCta = (New cPAGO_CTA_BANCO).ObtenerListaPorCriterios(idCatorcena, idTipoPlanilla, iEsContibuyente, -1, "APELLIDOS", "ASC", -1)


                Dim dt As New DataTable
                dt.Columns.Add("CODIGO", GetType(String))
                dt.Columns.Add("NOMBRE", GetType(String))
                dt.Columns.Add("VALOR_A_PAGAR", GetType(Decimal))

                If lstpagoCta IsNot Nothing AndAlso lstpagoCta.Count > 0 Then
                    For i As Integer = 0 To lstpagoCta.Count - 1

                        If lstpagoCta(i).ENTREGO_CCF AndAlso lstpagoCta(i).NUM_CUENTA <> Nothing AndAlso lstpagoCta(i).NUM_CUENTA <> "" Then
                            If lstpagoCta(i).ID_TIPO_PLANILLA = 2 Then
                                Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CInt(lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA))
                                If lTransportista IsNot Nothing Then
                                    lPlanilla = (New cPLANILLA).ObtenerPLANILLA(idCatorcena, lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA, lstpagoCta(i).ID_TIPO_PLANILLA, False, False)
                                    If lPlanilla IsNot Nothing Then
                                        dt.Rows.Add(lstpagoCta(i).CODIGO_SINFTO, Trim(lTransportista.APELLIDOS + " " + lTransportista.NOMBRES), lPlanilla.PAGO_NETO)
                                    End If
                                End If
                            Else
                                Dim lProductor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA)
                                If lProductor IsNot Nothing Then
                                    lPlanilla = (New cPLANILLA).ObtenerPLANILLA(idCatorcena, lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA, lstpagoCta(i).ID_TIPO_PLANILLA, False, False)
                                    If lPlanilla IsNot Nothing Then
                                        dt.Rows.Add(lstpagoCta(i).CODIGO_SINFTO, Trim(lProductor.APELLIDOS + " " + lProductor.NOMBRES), lPlanilla.PAGO_NETO)
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
                Me.ExportToExcelFtoPlanilla(dt, "PagoCuentaFormatoPlanilla" & cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy hh.mm.ss") & ".xls")

            Case "GenerarArchivo"
                If Me.rblTIPO_CONTRIBUYENTE.Value = -1 Then
                    AsignarMensaje("Para generar el archivo debe seleccionar solo un tipo de contribuyente", False, True, True)
                    Return
                End If
                Me.CargarBancos()
                pcGenerarArchivo.ShowOnPageLoad = True
                'Me.GenerarArchivo()

            Case "GenerarNotasCargo"
                lblConfirmacionNC.Text = "SE GENERARAN NOTAS DE CARGO PARA ZAFRA " & Me.cbxZAFRA.Text & " CORTE #" & Me.cbxCATORCENA_ZAFRA.Text & " " & Me.cbxTIPO_PLANILLA.Text & vbCrLf & " CONTRIBUYENTES Y NO CONTRIBUYENTES. ¿DESEA CONTINUAR?"
                Me.pcConfirmarNotasCargo.ShowOnPageLoad = True

            Case "CargarTransferenciaBanco"

                If Me.cbxCATORCENA_ZAFRA.Value Is Nothing Then
                    AsignarMensaje("Seleccione una catorcena", False, True, True)
                    Return
                End If
                If Me.cbxCATORCENA_ZAFRA.Value Is Nothing Then
                    AsignarMensaje("Seleccione un tipo de planilla", False, True, True)
                    Return
                End If
                Me.ID_CATORCENA = Me.cbxCATORCENA_ZAFRA.Value
                Me.ID_TIPO_PLANILLA = Me.cbxTIPO_PLANILLA.Value

                Me.pcSubirNumAutoBanco.ShowOnPageLoad = True
        End Select
    End Sub

    Private Sub uploadArchivo_FileUploadComplete(sender As Object, e As FileUploadCompleteEventArgs) Handles uploadArchivo.FileUploadComplete
        Dim ruta As String = Server.MapPath(DirectorioUpload) & e.UploadedFile.FileName
        Dim lResultado As KeyValuePair(Of Integer, String)

        If (Not String.IsNullOrEmpty(e.UploadedFile.FileName)) AndAlso e.UploadedFile.IsValid Then
            e.UploadedFile.SaveAs(ruta, True)
            lResultado = ImportarNumerosDeTransferencias(ruta)
            If lResultado.Key = 0 Then
                e.IsValid = True
                e.CallbackData = lResultado.Value
            Else
                e.IsValid = False
                e.ErrorText = lResultado.Value
            End If
        End If
    End Sub

    Private Function ImportarNumerosDeTransferencias(ByVal archivo As String) As KeyValuePair(Of Integer, String)

        Dim lResultado As KeyValuePair(Of Integer, String)
        Dim numeroFilaActual As Integer = 0
        Dim lRet As New StringBuilder

        Dim libro As XLWorkbook
        Dim hojaDatos As IXLRange
        Dim seTienenDatos As Boolean = False
        Dim sCuentaCargar As String = ""
        Dim monto As Decimal = 0
        Dim autorizacion As String = ""
        Dim nombreCta As String = ""
        Dim bNotaCargo As New cNOTACARGO_PLANILLA
        Dim ds As DataSet

        Try
            libro = New XLWorkbook(archivo)
            hojaDatos = libro.Worksheets(0).RangeUsed


            For Each fila In hojaDatos.Rows()
                numeroFilaActual = numeroFilaActual + 1
                'If numeroFilaActual = 143 Then Stop

                If seTienenDatos Then

                    autorizacion = fila.Cell("L").Value.ToString.Trim
                    If autorizacion <> "" Then
                        sCuentaCargar = fila.Cell("C").Value.ToString.Trim 'fila.Cell("B").Value.ToString.Trim
                        nombreCta = fila.Cell("D").Value.ToString.Trim
                        monto = Convert.ToDecimal(fila.Cell("E").Value.ToString.Trim)

                        'Actualizar referencia para la nota de cargo que coincida con el monto y la cuenta en la catorcena y planilla
                        ds = bNotaCargo.AsignarNUM_AUTO_BANCO(Me.ID_CATORCENA, Me.ID_TIPO_PLANILLA, monto, sCuentaCargar, Convert.ToInt32(autorizacion))
                        If ds IsNot Nothing Then
                            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows(0)("CODIGO") = "1" Then
                                'OK (ACTUALIACION EXITOSA)
                            Else
                                lRet.AppendLine("Resultado para la cuenta " + sCuentaCargar + " (" + nombreCta + ") " + ds.Tables(0).Rows(0)("MENSAJE"))
                            End If
                        Else
                            lRet.AppendLine("No se obtuvo ningun resultado en la actualizacion de la cuenta " + sCuentaCargar + " (" + nombreCta + ")")
                        End If
                    Else
                        Exit For
                    End If
                End If

                If fila.Cell("K").Value.ToString.Trim.ToLower = "estatus" Then
                    seTienenDatos = True
                End If
            Next

            If lRet.ToString <> "" Then
                lResultado = New KeyValuePair(Of Integer, String)(-1, "Error al asignar autorización del banco: " + lRet.ToString)
                Return lResultado
            End If

            lResultado = New KeyValuePair(Of Integer, String)(0, "Información subida al sistema exitosamente")
            Return lResultado

        Catch ex As Exception
            lResultado = New KeyValuePair(Of Integer, String)(-1, "Num. fila: " + numeroFilaActual.ToString + " " + ex.Message)
            Return lResultado

        End Try
    End Function


    Private Sub CargarBancos()
        Dim idCatorcena As Int32 = -2
        Dim idTipoPlanilla As Int32 = -2
        Dim iEsContibuyente As Int32 = -1

        If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
        If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
        If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
            iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
        End If
        Dim lista As listaBANCOS = (New cBANCOS).ObtenerListaParaGeneracionPAGO_CTA(idCatorcena, idTipoPlanilla, iEsContibuyente)
        If lista Is Nothing Then lista = New listaBANCOS
        Me.cbxBANCO.DataSource = lista
        Me.cbxBANCO.DataBind()
        Me.cbxBANCO.SelectedIndex = -1
    End Sub

    Private Sub GenerarArchivo()
        Dim idCatorcena As Int32 = -2
        Dim idTipoPlanilla As Int32 = -2
        Dim iEsContibuyente As Int32 = -1
        Dim iCodiBanco As Int32 = -1
        Dim iMostrarPor As Int32 = -1
        Dim lstpagoCta As listaPAGO_CTA_BANCO
        Dim bPagoCuenta As New cPAGO_CTA_BANCO
        Dim ms As New MemoryStream
        Dim tw As TextWriter = New StreamWriter(ms)
        Dim contador As Integer = 0

        If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
        If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
        If Me.cbxBANCO.Text <> "" Then iCodiBanco = Me.cbxBANCO.Value
        If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
            iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
        End If

        Me.ActualizarPlanilla(idCatorcena, idTipoPlanilla)
        lstpagoCta = bPagoCuenta.ObtenerListaPorCriterios(idCatorcena, idTipoPlanilla, iEsContibuyente, -1, "APELLIDOS", "ASC", iCodiBanco)

        If lstpagoCta IsNot Nothing AndAlso lstpagoCta.Count > 0 Then
            For Each lEntidad As PAGO_CTA_BANCO In lstpagoCta
                If lEntidad.ENTREGO_CCF AndAlso lEntidad.NUM_CUENTA <> Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                    lEntidad.PAGO_GENERADO = True
                    lEntidad.FECHA_GENPAGO = cFechaHora.ObtenerFechaHora
                    lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bPagoCuenta.ActualizarPAGO_CTA_BANCO(lEntidad)

                    If lEntidad.ID_TIPO_PLANILLA = 2 Then
                        Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CInt(lEntidad.CODIPROVEEDOR_TRANSPORTISTA))
                        If lTransportista IsNot Nothing Then
                            tw.WriteLine(lTransportista.NUM_CUENTA + "," + lEntidad.MONTO_PAGO.ToString("#0.00") + ",," + Trim(lTransportista.APELLIDOS + " " + lTransportista.NOMBRES) + ",")
                            contador += 1
                        End If
                    Else
                        Dim lProductor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidad.CODIPROVEEDOR_TRANSPORTISTA)
                        If lProductor IsNot Nothing Then
                            tw.WriteLine(lProductor.NUM_CUENTA + "," + lEntidad.MONTO_PAGO.ToString("#0.00") + ",," + Trim(lProductor.APELLIDOS + " " + lProductor.NOMBRES) + ",")
                            contador += 1
                        End If
                    End If
                End If
            Next
        End If
        tw.Flush()
        Dim b As Byte() = ms.ToArray
        ms.Close()

        If contador > 0 Then
            Response.Clear()
            Response.ContentType = "application/force-download"
            Response.AddHeader("content-disposition", "attachment;filename=" + "ZAFRA " + Me.cbxZAFRA.Text.Replace("/", "-") + " - BANCO " + Me.cbxBANCO.Text.Replace(".", "").Replace(",", " ") + " - PAGO DE " + Me.cbxTIPO_PLANILLA.Text + " - " + Utilerias.NombreTipoContribuyente(rblTIPO_CONTRIBUYENTE.Value) + ".txt")
            Response.BinaryWrite(b)
            Response.End()
        Else
            AsignarMensaje("No existen registros marcados con entrega de ccf para los criterios seleccionados", False, True, True)
        End If

    End Sub

    Private Sub Buscar()
        Dim idCatorcena As Int32 = -2
        Dim idTipoPlanilla As Int32 = -2
        Dim iEsContibuyente As Int32 = -1
        Dim iMostrarPor As Int32 = -1

        If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
        If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
        If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
            iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
        End If
        If Me.cbxMOSTRAR_POR.Text <> "" Then iMostrarPor = Me.cbxMOSTRAR_POR.Value

        Me.ActualizarPlanilla(idCatorcena, idTipoPlanilla)
        Me.ucListaPAGO_CTA_BANCO1.CargarDatosPorCriterios(idCatorcena, idTipoPlanilla, iEsContibuyente, iMostrarPor)

        Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = False
        Me.ucListaPAGO_CTA_BANCO1.EditarPAGO_GENERADO = False
        Me.ucListaPAGO_CTA_BANCO1.PermitirEditarInline = False

        If Me.cbxMOSTRAR_POR.Value = 0 Then
            Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = True
            Me.ucListaPAGO_CTA_BANCO1.EditarPAGO_GENERADO = False
            Me.ucListaPAGO_CTA_BANCO1.PermitirEditarInline = True

        ElseIf Me.cbxMOSTRAR_POR.Value = 1 Then
            Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = False
            Me.ucListaPAGO_CTA_BANCO1.EditarPAGO_GENERADO = False
            Me.ucListaPAGO_CTA_BANCO1.PermitirEditarInline = False
        End If

    End Sub

    Private Sub ActualizarPlanilla(ByVal ID_CATORCENA As Int32, ID_TIPO_PLANILLA As Int32)
        Dim lista As New listaPAGO_CTA_BANCO
        Dim bPagocta As New cPAGO_CTA_BANCO
        Dim lPagoCta As PAGO_CTA_BANCO
        Dim listaPlanilla As listaPLANILLA

        lista = bPagocta.ObtenerListaPorCriterios(ID_CATORCENA, ID_TIPO_PLANILLA, -1, -1)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Int32 = 0 To lista.Count - 1
                lPagoCta = New PAGO_CTA_BANCO
                lPagoCta = lista(i)

                If lPagoCta.NUM_CUENTA = "" Then
                    If lPagoCta.ID_TIPO_PLANILLA = TipoPlanilla.Cañeros Then
                        Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lPagoCta.CODIPROVEEDOR_TRANSPORTISTA)
                        If lEntidad IsNot Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                            'Actualizar cuenta y su tipo
                            lPagoCta.CODIBANCO = lEntidad.CODIBANCO
                            lPagoCta.NUM_CUENTA = lEntidad.NUM_CUENTA
                            lPagoCta.ES_CTA_CORRIENTE = lEntidad.ES_CTA_CORRIENTE
                        End If

                    ElseIf lPagoCta.ID_TIPO_PLANILLA = TipoPlanilla.Transportistas Then
                        Dim lEntidad As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lPagoCta.CODIPROVEEDOR_TRANSPORTISTA)
                        If lEntidad IsNot Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                            'Actualizar cuenta y su tipo
                            lPagoCta.CODIBANCO = lEntidad.CODIBANCO
                            lPagoCta.NUM_CUENTA = lEntidad.NUM_CUENTA
                            lPagoCta.ES_CTA_CORRIENTE = lEntidad.ES_CTA_CORRIENTE
                        End If
                    End If
                End If

                'Actualizar monto a pagar
                listaPlanilla = (New cPLANILLA).ObtenerListaPorCRITERIOS(ID_CATORCENA, ID_TIPO_PLANILLA, lPagoCta.CODIPROVEEDOR_TRANSPORTISTA, "")
                If listaPlanilla IsNot Nothing AndAlso listaPlanilla.Count > 0 Then
                    lPagoCta.MONTO_PAGO = listaPlanilla(0).PAGO_NETO
                End If

                If Not lPagoCta.PAGO_GENERADO Then
                    bPagocta.ActualizarPAGO_CTA_BANCO(lPagoCta)
                End If
            Next
        End If
    End Sub

    Protected Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If Me.cbxBANCO.Value Is Nothing Then
            AsignarMensaje("Seleccione un banco", False, True, True)
            Return
        End If

        Me.GenerarArchivo()

        'Dim lista As listaPAGO_CTA_BANCO
        'Dim bPagoCuenta As New cPAGO_CTA_BANCO
        'Dim dt As New DS_CATORCENA.PAGO_CTA_BANCODataTable
        'Dim adapter As New DS_CATORCENATableAdapters.PAGO_CTA_BANCOTableAdapter
        'Dim idTipoPlanillas As Int32 = -1

        'If rblTipoGeneracion.Value = 2 Then
        '    idTipoPlanillas = Me.cbxTIPO_PLANILLA.Value
        'End If
        'adapter.FillPorCriterios(dt, Me.cbxCATORCENA_ZAFRA.Value, idTipoPlanillas)

        ''Marcar como generado los pagos
        'lista = (New cPAGO_CTA_BANCO).ObtenerListaPorCriterios(Me.cbxCATORCENA_ZAFRA.Value, idTipoPlanillas, -1, -1)
        'If lista IsNot Nothing AndAlso lista.Count > 0 Then
        '    For Each lEntidad As PAGO_CTA_BANCO In lista
        '        If lEntidad.ENTREGO_CCF AndAlso lEntidad.NUM_CUENTA <> Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
        '            lEntidad.PAGO_GENERADO = True
        '            lEntidad.FECHA_GENPAGO = cFechaHora.ObtenerFechaHora
        '            lEntidad.USUARIO_ACT = Me.ObtenerUsuario
        '            lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        '            bPagoCuenta.ActualizarPAGO_CTA_BANCO(lEntidad)
        '        End If
        '    Next
        'End If

        'Me.ExportToExcel(dt, "PagoCuenta" & cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy hh.mm.ss") & ".csv")
    End Sub

    Sub ExportToExcel(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'Create a dummy GridView
        Dim GridView1 As New GridView()
        GridView1.AllowPaging = False
        GridView1.DataSource = dt
        GridView1.DataBind()

        Dim csv As String = String.Empty

        For Each column As DataColumn In dt.Columns
            'Add the Header row for CSV file.
            csv += column.ColumnName + ","c
        Next

        'Add new line.
        csv += vbCr & vbLf

        For Each row As DataRow In dt.Rows
            For Each column As DataColumn In dt.Columns
                'Add the Data rows.
                csv += row(column.ColumnName).ToString().Replace(",", ";") + ","c
            Next

            'Add new line.
            csv += vbCr & vbLf
        Next

        Response.Clear()
        Response.Buffer = True
        Response.AddHeader("content-disposition", "attachment;filename=" + nombreArchivo)
        Response.Charset = ""
        Response.ContentType = "application/text"
        Response.Output.Write(csv)
        Response.Flush()
        Response.End()
    End Sub

    Sub ExportToExcelFtoPlanilla(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'Create a dummy GridView
        Dim GridView1 As New GridView()
        GridView1.AllowPaging = False
        GridView1.DataSource = dt
        GridView1.DataBind()

        Response.Clear()
        Response.Buffer = True
        Response.AddHeader("content-disposition", "attachment;filename=" & nombreArchivo)
        Response.Charset = ""
        Response.ContentType = "application/vnd.ms-excel"
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)

        GridView1.RenderControl(hw)

        'style to format numbers to string
        Dim style As String = "<style> .textmode{mso-number-format:\@;}</style>"
        Response.Write(style)
        Response.Output.Write(sw.ToString())
        Response.Flush()
        Response.End()
    End Sub

    Private Sub btnGenerarNC_Click(sender As Object, e As EventArgs) Handles btnGenerarNC.Click
        Dim ds As DataSet
        Dim bNotaCargo As New cNOTACARGO_PLANILLA
        Dim sResulContrib As String
        Dim sResulNoContrib As String

        If Me.cbxCATORCENA_ZAFRA.Value = Nothing Then
            AsignarMensaje("Seleccione una catorcena", False, True, True)
            Return
        End If
        If Me.cbxTIPO_PLANILLA.Value = Nothing Then
            AsignarMensaje("Seleccione un tipo de planilla", False, True, True)
            Return
        End If


        ' * Generacion de notas de cargo Contribuyentes
        ds = bNotaCargo.EmitirNotasCargoPorPlanilla(Me.cbxCATORCENA_ZAFRA.Value, Me.cbxTIPO_PLANILLA.Value, 1, 5, Me.ObtenerUsuario, Today)
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0)(0) = "1" Then
                sResulContrib = "1"
            Else
                sResulContrib = ds.Tables(0).Rows(0)(1)
            End If
        Else
            AsignarMensaje("Error al generar notas de cargo para contribuyentes", False, True, True)
            Return
        End If
        ' * Generacion de notas de cargo No Contribuyentes
        ds = bNotaCargo.EmitirNotasCargoPorPlanilla(Me.cbxCATORCENA_ZAFRA.Value, Me.cbxTIPO_PLANILLA.Value, 0, 5, Me.ObtenerUsuario, Today)
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0)(0) = "1" Then
                sResulNoContrib = "1"
            Else
                sResulNoContrib = ds.Tables(0).Rows(0)(1)
            End If
        Else
            AsignarMensaje("Error al generar notas de cargo para no contribuyentes", False, True, True)
            Return
        End If

        If sResulContrib = "1" AndAlso sResulNoContrib = "1" Then
            AsignarMensaje("Notas de cargo generadas con exito para contribuyentes y no contribuyentes", False, True, True)
        Else
            Dim sError As New StringBuilder

            If sResulContrib <> "1" Then sError.AppendLine(sResulContrib)
            If sResulNoContrib <> "1" Then sError.AppendLine(vbCrLf & sResulNoContrib)

            AsignarMensaje("ERROR EN GENERACION: " + vbCrLf + sError.ToString, False, True, True)
        End If
    End Sub
End Class
