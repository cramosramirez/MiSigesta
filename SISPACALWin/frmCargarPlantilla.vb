Imports System.Data.OleDb
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.EL.Enumeradores
Imports System.Text
Imports Microsoft.Office.Interop
Imports SISPACAL.BL.cCREAR_ARCHIVO_LOG
Imports System.Configuration

Public Class frmCargarPlantilla
    Private NombrePlantilla As String
    Private NombrePlantillaDetalle As String
    Private log As New cCREAR_ARCHIVO_LOG
    Private archivoLog As String = ConfigurationManager.AppSettings("ARCHIVO_LOG_PLANTILLA")
    Private directorioLog As String = ConfigurationManager.AppSettings("DIRECTORIO_LOG")

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.CbxTIPO_PLANILLA1.Recuperar()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Sub frmCargarPlantilla_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmCargarPlantilla_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Inicializar()
    End Sub

    Private Sub btnSeleccionarPlantilla_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarPlantilla.Click
        OpenFileDialog1.Filter = "Archivo de Excel (.xlsx)|*.xlsx"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Me.NombrePlantilla = "DESCUENTOS"
            Me.NombrePlantillaDetalle = "DETALLE"
            txtDirectorio.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Function ObtenerIdCuentaFinanPorConcepto(ByVal Concepto As String) As Dictionary(Of String, Int32)
        Dim dicc As New Dictionary(Of String, Int32)
        Dim Id As Int32 = -1
        Dim ref As String = ""
        Dim cods As String()

        For i As Int32 = Concepto.Length - 1 To 0 Step -1
            If Trim(Concepto(i)) <> "" AndAlso Trim(Concepto(i)) <> vbCrLf Then
                ref = Concepto(i) + ref
            Else
                Exit For
            End If
        Next
        If ref <> "" Then
            cods = Split(ref, ".")
            dicc.Add("ID_CUENTA_FINAN", cods(0))
            dicc.Add("ID_PROVEE", cods(1))
        Else
            dicc = Nothing
        End If
        Return dicc
    End Function

    Private Function ObtenerIdCuentaFinan(ByVal ID_CREDITO_ENCA As Int32) As Int32
        Dim lEntidad As CREDITO_ENCA = (New cCREDITO_ENCA).ObtenerCREDITO_ENCA(ID_CREDITO_ENCA)
        Dim id As Int32 = -1

        If lEntidad IsNot Nothing AndAlso lEntidad.ID_CUENTA_FINAN > 0 Then
            id = lEntidad.ID_CUENTA_FINAN
        End If

        Return id
    End Function

    Private Function ObtenerIdCuentaFinanTrans(ByVal ID_CREDITO_ENCA As Int32) As Int32
        Dim lEntidad As CREDITO_ENCA_TRANS = (New cCREDITO_ENCA_TRANS).ObtenerCREDITO_ENCA_TRANS(ID_CREDITO_ENCA)
        Dim id As Int32 = -1

        If lEntidad IsNot Nothing AndAlso lEntidad.ID_CUENTA_FINAN > 0 Then
            id = lEntidad.ID_CUENTA_FINAN
        End If

        Return id
    End Function

    Private Function ObtenerIdProvee(ByVal ID_CREDITO_ENCA As Int32) As Int32
        Dim lEntidad As CREDITO_ENCA = (New cCREDITO_ENCA).ObtenerCREDITO_ENCA(ID_CREDITO_ENCA)
        Dim id As Int32 = -1

        If lEntidad IsNot Nothing Then
            id = lEntidad.ID_PROVEE
        End If

        Return id
    End Function

    Private Function ObtenerIdProveeTrans(ByVal ID_CREDITO_ENCA As Int32) As Int32
        Dim lEntidad As CREDITO_ENCA_TRANS = (New cCREDITO_ENCA_TRANS).ObtenerCREDITO_ENCA_TRANS(ID_CREDITO_ENCA)
        Dim id As Int32 = -1

        If lEntidad IsNot Nothing Then
            id = lEntidad.ID_PROVEE
        End If

        Return id
    End Function

    Private Function ObtenerEquivalenciaTipoDescto(ByVal ID_CUENTA_FINAN As Int32, Optional ByVal ID_PROVEE As Int32 = -1, Optional DESCRIP As String = "*") As Int32
        If ID_PROVEE <> 4 AndAlso ID_PROVEE > 0 Then
            Return 7
        End If
        Select Case True
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.OpisBancarias
                Return 1
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Anticipos AndAlso Not DESCRIP.Contains("0.35")
                Return 2
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Anticipos AndAlso DESCRIP.Contains("0.35")
                Return 29
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.AnticipoRoza
                Return 23
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Asprocana
                Return 4
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Asprocarpa
                Return 5
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Procana
                Return 44
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Combustible
                Return 6
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.CanaSemilla
                Return 28
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Mutuos
                Return 30
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Talonario
                Return 31
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Querqueo
                Return 40
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Plomeo
                Return 41
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.KitSanitario
                Return 45
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Querqueo
                Return 40
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Otros
                Return 14
            Case Else
                Return 14
        End Select
    End Function

    Private Function ObtenerEquivalenciaTipoDesctoTrans(ByVal ID_CUENTA_FINAN As Int32, Optional CONCEPTO As String = "") As Int32
        Select Case True
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.OpisBancarias
                Return 1
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.PolizaSeguroDanosTercero
                If CONCEPTO = "" Then
                    Return 36
                Else
                    If CONCEPTO.Contains("(POLIZA DE SEGURO DAÑOS A TERCERO)") Then
                        Return 36
                    ElseIf CONCEPTO.Contains("(SEGURO DE VIDA Y ACCIDENTES PERSONALES)") Then
                        Return 37
                    Else
                        Return 36
                    End If
                End If
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.KitSeguridad
                Return 25
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.KitSanitario
                Return 45
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.GPS
                If CONCEPTO = "" Then
                    Return 26
                Else
                    If CONCEPTO.Contains("ACTIVACION DEL APARATO DE GPS") Then
                        Return 35
                    ElseIf CONCEPTO.Contains("APARATO DE GPS") Then
                        Return 33
                    ElseIf CONCEPTO.Contains("MONITOREO DE GPS") Then
                        Return 34
                    Else
                        Return 26
                    End If
                End If
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.RepuestosAccesorios
                Return 22
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Combustible
                Return 6
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Carnet
                Return 38
            Case ID_CUENTA_FINAN = CuentaFinanciamiento.Cables
                Return 39
            Case Else
                Return 14
        End Select
    End Function

    Private Function CrearDataTableDETALLE()
        Dim dt As New DataTable
        dt.TableName = "DETALLE"
        dt.Columns.Add("CODIGO", GetType(String))
        dt.Columns.Add("CONCEPTO", GetType(String))
        dt.Columns.Add("SALDO", GetType(Decimal))
        dt.Columns.Add("FECHA_ULTMOV", GetType(DateTime))
        dt.Columns.Add("TASAINT", GetType(Decimal))
        dt.Columns.Add("TIPO_INTERES", GetType(String))
        dt.Columns.Add("DESCUENTO", GetType(Decimal))
        dt.Columns.Add("ABONO_INTERES", GetType(Decimal))
        dt.Columns.Add("ID_CREDITO_ENCA", GetType(Int32))
        Return dt
    End Function

    Private Function CrearDataTableDETALLE_TRANS()
        Dim dt As New DataTable
        dt.TableName = "DETALLE"
        dt.Columns.Add("CODIGO", GetType(String))
        dt.Columns.Add("CONCEPTO", GetType(String))
        dt.Columns.Add("SALDO", GetType(Decimal))
        dt.Columns.Add("FECHA_ULTMOV", GetType(DateTime))
        dt.Columns.Add("TASAINT", GetType(Decimal))
        dt.Columns.Add("TIPO_INTERES", GetType(String))
        dt.Columns.Add("DESCUENTO", GetType(Decimal))
        dt.Columns.Add("ABONO_INTERES", GetType(Decimal))
        dt.Columns.Add("ID_CREDITO_ENCA", GetType(Int32))
        dt.Columns.Add("CATORCENA_VENCIMIENTO", GetType(Int32))
        Return dt
    End Function


    Private Sub btnCargarPlantilla_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarPlantilla.Click
        Dim sCadenaConexion As String
        Dim Conexion As New OleDbConnection
        Dim Comando As New OleDbCommand
        Dim listaDescuentosEnPlanilla As New listaDESCUENTOS_PLANILLA
        Dim bDescPlanilla As New cDESCUENTOS_PLANILLA
        Dim lCatorcena As CATORCENA_ZAFRA
        Dim bCreditoEnca As New cCREDITO_ENCA
        Dim bCreditoMov As New cCREDITO_MOV
        Dim bCreditoEncaTrans As New cCREDITO_ENCA_TRANS
        Dim bCreditoMovTrans As New cCREDITO_MOV_TRANS
        Dim lstPlanillaBase As listaPLANILLA_BASE
        Dim TIPO As String

        If Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.Cañeros Then
            TIPO = "CAÑEROS"
        Else
            TIPO = "TRANSPORTISTAS"
        End If

        log.DIRECTORIO_ARCHIVO = directorioLog

        If txtDirectorio.Text.Trim = "" Then
            MsgBox("Ingrese la ruta completa del archivo", vbCritical, Application.ProductName)
            Return
        End If
        If Not My.Computer.FileSystem.FileExists(txtDirectorio.Text) Then
            MsgBox("El archivo no existe en la ruta especificada", vbCritical, Application.ProductName)
            Return
        End If

        Try
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHojaDescto As Microsoft.Office.Interop.Excel.Worksheet
            Dim col As Int32
            Dim fila As Int32

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            sCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" _
               & "Data Source=" & txtDirectorio.Text & ";" & "Extended Properties='Excel 12.0 Xml;HDR=YES;'"
            Conexion = New OleDbConnection(sCadenaConexion)
            Dim Adapter As New OleDbDataAdapter
            Dim mTabla As New DataTable
            Dim ds As New DataSet

            lstPlanillaBase = (New cPLANILLA_BASE).ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(Me.CbxZAFRA1.SelectedValue, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue)
            If lstPlanillaBase IsNot Nothing AndAlso
                    (Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.Cañeros OrElse Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.ComplementoValorFinalPago OrElse
                    Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana OrElse
                      Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.AnticipoCaneros) Then

                TIPO = "CAÑEROS"
                lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
                If lstPlanillaBase(0).FECHA_PAGO = Nothing Then
                    MsgBox("Debe ingresarse la fecha de pago para la planilla antes de cargar la información", vbCritical, Application.ProductName)
                    Return
                End If

                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "*** INICIO CARGA PLANTILLA " + TIPO + " ***", Direccion.Input, "")
                Conexion.Open()
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Conexión habilitada a la plantilla de Excel en el directorio " + txtDirectorio.Text, Direccion.Input, "")

                'Validar que no existan saldos negativos
                exLibro = exApp.Workbooks.Open(txtDirectorio.Text, False, True)
                exHojaDescto = exLibro.Worksheets(Me.NombrePlantilla)
                Dim sProveePagoNegativo As New StringBuilder
                Dim seguir = True
                Dim esNegativo As Boolean = False
                col = 4
                fila = 3

                While seguir
                    If exHojaDescto.Cells(1, col).Value2.ToString.Contains("PAGO") AndAlso exHojaDescto.Cells(1, col).Value2.ToString.Contains("MENOS") AndAlso
                        exHojaDescto.Cells(1, col).Value2.ToString.Contains("DESCUENTO") Then
                        While exHojaDescto.Cells(fila, 1).Value2 <> "" AndAlso exHojaDescto.Cells(fila, 1).Value2 <> "TOTALES"
                            If IsNumeric(exHojaDescto.Cells(fila, col).Value2) AndAlso CDec(exHojaDescto.Cells(fila, col).Value2) < 0 Then
                                sProveePagoNegativo.Append(Utilerias.RecuperarCODIPROVEE(exHojaDescto.Cells(fila, 1).Value2))
                                sProveePagoNegativo.Append(" ")
                                sProveePagoNegativo.Append(exHojaDescto.Cells(fila, 2).Value2)
                                sProveePagoNegativo.Append(" por ")
                                sProveePagoNegativo.AppendLine(exHojaDescto.Cells(fila, col).Text)
                            End If
                            fila += 1
                        End While
                        seguir = False
                    End If
                    If exHojaDescto.Cells(2, col).Value2 <> "" Then col += 4 Else col += 1
                End While
                If sProveePagoNegativo.ToString <> "" Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Los siguientes registros poseen liquidación negativa: " + sProveePagoNegativo.ToString + "Corrija antes de cargar la información", Direccion.Output, "VALIDACION")
                    MsgBox("Los siguientes registros poseen liquidación negativa:" + vbCrLf + vbCrLf + sProveePagoNegativo.ToString + vbCrLf + "Corrija antes de cargar la información", vbCritical, Application.ProductName)
                    Return
                End If

                exLibro.Close(False)
                exApp.DisplayAlerts = True
                exHojaDescto = Nothing
                exLibro = Nothing

                mTabla = CrearDataTableDETALLE()
                Comando = New OleDbCommand("SELECT CODIGO, CONCEPTO, SALDO, FECHA_ULTMOV, TASAINT, TIPO_INTERES, DESCUENTO, ABONO_INTERES, ID_CREDITO_ENCA FROM [" & Me.NombrePlantillaDetalle & "$] WHERE APLICAR = '*'", Conexion)
                Comando.CommandType = CommandType.Text
                Adapter.SelectCommand = Comando
                Adapter.Fill(mTabla)

                '***********************************************************
                '   Aplicar directamente pagos marcados en el detalle
                '***********************************************************
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  *** Inicio recorrido de hoja detalle cargada. Registros cargados: " + mTabla.Rows.Count.ToString, Direccion.Input, "")
                If mTabla IsNot Nothing AndAlso mTabla.Rows.Count > 0 Then
                    Dim dt As DataTable = mTabla

                    For i As Int32 = 0 To dt.Rows.Count - 1
                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  CODIGO: " + dt.Rows(i)("CODIGO").ToString + "| ID_CREDITO_ENCA: " + dt.Rows(i)("ID_CREDITO_ENCA").ToString + "| DESCUENTO: " + Convert.ToDecimal(dt.Rows(i)("DESCUENTO")).ToString("#,##0.00"), Direccion.Input, "")

                        Dim lCreditoMov As CREDITO_MOV
                        Dim lDescPlanilla As DESCUENTOS_PLANILLA
                        Dim dAbono As Decimal = 0
                        Dim dInt As Decimal = 0
                        Dim dIntIva As Decimal = 0
                        Dim IdCuentaFinan As Int32
                        Dim IdProvee As Int32

                        dAbono = Convert.ToDecimal(dt.Rows(i)("DESCUENTO"))
                        dInt = Math.Round(Convert.ToDecimal(dt.Rows(i)("ABONO_INTERES")) / (1 + Utilerias.TasaIva), 2)
                        dIntIva = Convert.ToDecimal(dt.Rows(i)("ABONO_INTERES")) - dInt

                        lCreditoMov = New CREDITO_MOV
                        lCreditoMov.ID_CREDITO_MOV = 0
                        lCreditoMov.ID_CREDITO_ENCA = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                        lCreditoMov.FECHA = lCatorcena.FECHA_PAGO
                        lCreditoMov.UID_REFERENCIA = Guid.NewGuid
                        lCreditoMov.ID_CATORCENA = lCatorcena.ID_CATORCENA
                        lCreditoMov.CARGO = 0
                        lCreditoMov.ABONO = dAbono
                        lCreditoMov.SALDO = Convert.ToDecimal(dt.Rows(i)("SALDO")) - dAbono
                        lCreditoMov.ABONO_IVA = 0
                        lCreditoMov.ABONO_INTERES = dInt
                        lCreditoMov.ABONO_INTERES_IVA = dIntIva
                        lCreditoMov.USUARIO_CREA = Utilerias.ObtenerUsuario
                        lCreditoMov.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lCreditoMov.USUARIO_ACT = Utilerias.ObtenerUsuario
                        lCreditoMov.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lCreditoMov.CODIBANCO = -1
                        lCreditoMov.NO_DOCUMENTO = "PLANILLA"

                        lCreditoMov.FECHA_ULTMOV = IIf(IsDate(dt.Rows(i)("FECHA_ULTMOV")), CDate(dt.Rows(i)("FECHA_ULTMOV")), Nothing)
                        lCreditoMov.TASAINT = Convert.ToDecimal(dt.Rows(i)("TASAINT"))
                        lCreditoMov.SALDO_INICIAL = Convert.ToDecimal(dt.Rows(i)("SALDO"))
                        lCreditoMov.TIPO_INTERES = Convert.ToString(dt.Rows(i)("TIPO_INTERES"))

                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Antes de ActualizarCREDITO_MOV ID_CREDITO_ENCA: " + dt.Rows(i)("ID_CREDITO_ENCA").ToString +
                                           "| UID_REFERENCIA: " + lCreditoMov.UID_REFERENCIA.ToString() +
                                           "| ID_CATORCENA: " + lCreditoMov.ID_CATORCENA.ToString +
                                           "| ABONO: " + lCreditoMov.ABONO.ToString() +
                                           "| ABONO_INTERES: " + lCreditoMov.ABONO_INTERES.ToString() +
                                           "| ID_PLANILLA_BASE: " + lstPlanillaBase(0).ID_PLANILLA_BASE, Direccion.Input, "")
                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Obteniendo plazo interes para ID_CREDITO_ENCA: " + dt.Rows(i)("ID_CREDITO_ENCA").ToString +
                                           "| FECHA_PAGO: " + lCatorcena.FECHA_PAGO.ToString("dd/MM/yyy"), Direccion.Input, "")

                        lCreditoMov.PLAZO_DIAS = bCreditoEnca.fObtenerPlazoInteres(Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA")), lCatorcena.FECHA_PAGO)
                        lCreditoMov.ID_PLANILLA_BASE = lstPlanillaBase(0).ID_PLANILLA_BASE
                        bCreditoMov.ActualizarCREDITO_MOV(lCreditoMov)
                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "ActualizarCREDITO_MOV realizada correctamente ", Direccion.Input, "")

                        If dAbono > 0 Then
                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "dAbono > 0 | dAbono: " + dAbono.ToString, Direccion.Input, "")
                            lDescPlanilla = New DESCUENTOS_PLANILLA
                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                            lDescPlanilla.ID_APLICACION_DESCTO = 1
                            IdCuentaFinan = Me.ObtenerIdCuentaFinan(dt.Rows(i)("ID_CREDITO_ENCA"))
                            IdProvee = Me.ObtenerIdProvee(dt.Rows(i)("ID_CREDITO_ENCA"))
                            If IdCuentaFinan <> -1 Then
                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "IdCuentaFinan <> -1 |  IdCuentaFinan: " + IdCuentaFinan.ToString, Direccion.Input, "")
                                lDescPlanilla.ID_TIPO_DESCTO = Me.ObtenerEquivalenciaTipoDescto(IdCuentaFinan, IdProvee, dt.Rows(i)("CONCEPTO"))
                                lDescPlanilla.MONTO_DESCUENTO = dAbono
                                lDescPlanilla.IVA = 0
                                lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                lDescPlanilla.ID_CREDITO_ENCA = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                                lDescPlanilla.ID_CREDITO_ENCA_TRANS = -1
                                lDescPlanilla.CODIBANCO = -1
                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizado bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                            End If
                        End If
                        If dInt > 0 Then
                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "dInt > 0 |  dInt: " + dInt.ToString, Direccion.Input, "")
                            lDescPlanilla = New DESCUENTOS_PLANILLA
                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                            lDescPlanilla.ID_APLICACION_DESCTO = 1
                            lDescPlanilla.ID_TIPO_DESCTO = If(IdProvee <> 4 AndAlso IdProvee > 0, 32, 3)
                            lDescPlanilla.MONTO_DESCUENTO = dInt
                            lDescPlanilla.IVA = dIntIva
                            lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                            lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                            lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                            lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                            lDescPlanilla.ID_CREDITO_ENCA = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                            lDescPlanilla.ID_CREDITO_ENCA_TRANS = -1
                            lDescPlanilla.CODIBANCO = -1
                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                            bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizado bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                        End If
                    Next
                End If
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  *** Fin del recorrido de la hoja detalle cargada", Direccion.Input, "")


                '***********************************************************
                '   Aplicar descuentos globales
                '***********************************************************               
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  *** Inicia recorrido de descuentos globales", Direccion.Input, "")
                Dim dDescuentoTotal As Decimal
                Dim dPagoInteresTotal As Decimal
                Dim encabezado As String
                Dim codiproveedor As String

                exLibro = exApp.Workbooks.Open(txtDirectorio.Text, False, True)
                exHojaDescto = exLibro.Worksheets(Me.NombrePlantilla)

                col = 4
                'Recorrer los encabezados
                While Strings.Left(exHojaDescto.Cells(1, col).Value2, 5) <> "TOTAL"
                    encabezado = exHojaDescto.Cells(1, col).Value2
                    encabezado = Replace(encabezado, vbCrLf, " ")
                    encabezado = Replace(encabezado, vbLf, " ")
                    encabezado = Replace(encabezado, vbCr, " ")


                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "*** INICIO - ENCABEZADO A DESCONTAR: " + encabezado + " ***", Direccion.Input, "")

                    fila = 3
                    'Recorrer todos los productores
                    While exHojaDescto.Cells(fila, 1).Value2 <> "TOTALES"
                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  *** INICIO " + TIPO + " - CODIGO: " + exHojaDescto.Cells(fila, 1).Value2 + " NOMBRE: " + exHojaDescto.Cells(fila, 2).Value2 + " ***", Direccion.Input, "")
                        codiproveedor = exHojaDescto.Cells(fila, 1).Value2
                        If IsNumeric(exHojaDescto.Cells(fila, col + 2).Value2) OrElse IsNumeric(exHojaDescto.Cells(fila, col + 3).Value2) Then
                            dDescuentoTotal = 0
                            dPagoInteresTotal = 0
                            If IsNumeric(exHojaDescto.Cells(fila, col + 2).Value2) Then
                                dDescuentoTotal = Convert.ToDecimal(exHojaDescto.Cells(fila, col + 2).Value2)
                            End If
                            If IsNumeric(exHojaDescto.Cells(fila, col + 3).Value2) Then
                                dPagoInteresTotal = Convert.ToDecimal(exHojaDescto.Cells(fila, col + 3).Value2)
                            End If

                            If dDescuentoTotal > 0 OrElse dPagoInteresTotal > 0 Then
                                'Verificar si existen pagos marcados para ese productor y rubro rubro
                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Verificando si existen pagos para marcados para ese productor y rubro", Direccion.Input, "")
                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "CODIGO: " + exHojaDescto.Cells(fila, 1).Value2 + "| CONCEPTO: " + encabezado, Direccion.Input, "")
                                Comando = New OleDbCommand(
                                    "SELECT CODIGO, CONCEPTO, SALDO, FECHA_ULTMOV, TASAINT, TIPO_INTERES, DESCUENTO, ABONO_INTERES, ID_CREDITO_ENCA FROM [" & Me.NombrePlantillaDetalle & "$] " &
                                    "WHERE CODIGO = '" & exHojaDescto.Cells(fila, 1).Value2 & "' AND CONCEPTO = '" & encabezado & "' AND APLICAR <> ''", Conexion)
                                Comando.CommandType = CommandType.Text
                                Adapter.SelectCommand = Comando
                                mTabla = CrearDataTableDETALLE()
                                Adapter.Fill(mTabla)

                                If Not (mTabla IsNot Nothing AndAlso mTabla.Rows.Count > 0) Then

                                    'No existen pagos marcados: Distribuir las cantidades en el detalle hasta que se agoten
                                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "No existen pagos marcados: Distribuir las cantidades en el detalle hasta que se agoten", Direccion.Input, "")
                                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "CODIGO: " + exHojaDescto.Cells(fila, 1).Value2 + "| CONCEPTO: " + encabezado, Direccion.Input, "")
                                    Comando = New OleDbCommand(
                                    "SELECT CODIGO, CONCEPTO, SALDO, FECHA_ULTMOV, TASAINT, TIPO_INTERES, DESCUENTO, ABONO_INTERES, ID_CREDITO_ENCA FROM [" & Me.NombrePlantillaDetalle & "$] " &
                                    "WHERE CODIGO = '" & exHojaDescto.Cells(fila, 1).Value2 & "' AND CONCEPTO = '" & encabezado & "' AND CONCEPTO <> 'ANTICIPO DE ROZA  35.0' AND CONCEPTO <> 'QUERQUEO  47.0'", Conexion)
                                    Comando.CommandType = CommandType.Text
                                    Adapter.SelectCommand = Comando
                                    mTabla = CrearDataTableDETALLE()
                                    Adapter.Fill(mTabla)

                                    If mTabla IsNot Nothing AndAlso mTabla.Rows.Count > 0 Then
                                        Dim dt As DataTable = mTabla

                                        For i As Int32 = 0 To dt.Rows.Count - 1
                                            Dim lCreditoMov As CREDITO_MOV
                                            Dim lDescPlanilla As DESCUENTOS_PLANILLA
                                            Dim dAbono As Decimal = 0
                                            Dim dInt As Decimal = 0
                                            Dim dAbonoA_PAGAR As Decimal = 0
                                            Dim dIntA_PAGAR As Decimal = 0
                                            Dim IdCuentaFinan As Int32
                                            Dim IdProvee As Int32

                                            dAbono = Convert.ToDecimal(dt.Rows(i)("DESCUENTO"))
                                            dInt = Convert.ToDecimal(dt.Rows(i)("ABONO_INTERES"))

                                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "i: " + i.ToString + "| dAbono: " + dAbono.ToString + "| dInt: " + dInt.ToString, Direccion.Input, "")

                                            If dDescuentoTotal > 0 OrElse dPagoInteresTotal > 0 Then
                                                If dPagoInteresTotal > 0 Then
                                                    If dPagoInteresTotal - dInt >= 0 Then
                                                        dIntA_PAGAR = dInt
                                                        dPagoInteresTotal -= dInt
                                                    End If
                                                End If
                                                If dDescuentoTotal > 0 Then
                                                    If dDescuentoTotal - dAbono >= 0 Then
                                                        dAbonoA_PAGAR = dAbono
                                                        dDescuentoTotal -= dAbono
                                                    Else
                                                        dAbonoA_PAGAR = dDescuentoTotal
                                                        dDescuentoTotal = 0
                                                    End If
                                                End If

                                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  If dIntA_PAGAR > 0 OrElse dAbonoA_PAGAR > 0 Then | dIntA_PAGAR: " + dIntA_PAGAR.ToString + "| dAbonoA_PAGAR:" + dAbonoA_PAGAR.ToString, Direccion.Input, "")
                                                If dIntA_PAGAR > 0 OrElse dAbonoA_PAGAR > 0 Then
                                                    lCreditoMov = New CREDITO_MOV
                                                    lCreditoMov.ID_CREDITO_MOV = 0
                                                    lCreditoMov.ID_CREDITO_ENCA = dt.Rows(i)("ID_CREDITO_ENCA")
                                                    lCreditoMov.FECHA = lCatorcena.FECHA_PAGO
                                                    lCreditoMov.UID_REFERENCIA = Guid.NewGuid
                                                    lCreditoMov.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                                    lCreditoMov.CARGO = 0
                                                    lCreditoMov.ABONO = dAbonoA_PAGAR
                                                    lCreditoMov.SALDO = Convert.ToDecimal(dt.Rows(i)("SALDO")) - dAbonoA_PAGAR
                                                    lCreditoMov.ABONO_IVA = 0
                                                    lCreditoMov.ABONO_INTERES = Math.Round(dIntA_PAGAR / (1 + Utilerias.TasaIva), 2)
                                                    lCreditoMov.ABONO_INTERES_IVA = dIntA_PAGAR - lCreditoMov.ABONO_INTERES
                                                    lCreditoMov.USUARIO_CREA = Utilerias.ObtenerUsuario
                                                    lCreditoMov.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                    lCreditoMov.USUARIO_ACT = Utilerias.ObtenerUsuario
                                                    lCreditoMov.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                    lCreditoMov.CODIBANCO = -1
                                                    lCreditoMov.NO_DOCUMENTO = "PLANILLA"

                                                    lCreditoMov.FECHA_ULTMOV = IIf(IsDate(dt.Rows(i)("FECHA_ULTMOV")), CDate(dt.Rows(i)("FECHA_ULTMOV")), Nothing)
                                                    lCreditoMov.TASAINT = Convert.ToDecimal(dt.Rows(i)("TASAINT"))
                                                    lCreditoMov.SALDO_INICIAL = Convert.ToDecimal(dt.Rows(i)("SALDO"))
                                                    lCreditoMov.TIPO_INTERES = Convert.ToString(dt.Rows(i)("TIPO_INTERES"))
                                                    lCreditoMov.PLAZO_DIAS = bCreditoEnca.fObtenerPlazoInteres(Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA")), lCatorcena.FECHA_PAGO)
                                                    lCreditoMov.ID_PLANILLA_BASE = lstPlanillaBase(0).ID_PLANILLA_BASE
                                                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bCreditoMov.ActualizarCREDITO_MOV(lCreditoMov)", Direccion.Input, "")
                                                    bCreditoMov.ActualizarCREDITO_MOV(lCreditoMov)
                                                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizando bCreditoMov.ActualizarCREDITO_MOV(lCreditoMov)", Direccion.Input, "")

                                                    IdProvee = Me.ObtenerIdProvee(dt.Rows(i)("ID_CREDITO_ENCA"))

                                                    If dIntA_PAGAR > 0 Then
                                                        lDescPlanilla = New DESCUENTOS_PLANILLA
                                                        lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                                        lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                                        lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                                                        lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                                        lDescPlanilla.ID_APLICACION_DESCTO = 1
                                                        lDescPlanilla.ID_TIPO_DESCTO = If(IdProvee <> 4 AndAlso IdProvee > 0, 32, 3)
                                                        lDescPlanilla.MONTO_DESCUENTO = Math.Round(dIntA_PAGAR / (1 + Utilerias.TasaIva), 2)
                                                        lDescPlanilla.IVA = dIntA_PAGAR - lDescPlanilla.MONTO_DESCUENTO
                                                        lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                                        lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                        lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                                        lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                        lDescPlanilla.ID_CREDITO_ENCA = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                                                        lDescPlanilla.ID_CREDITO_ENCA_TRANS = -1
                                                        lDescPlanilla.CODIBANCO = -1
                                                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                                        bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizado bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                                    End If
                                                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "dAbonoA_PAGAR: " + dAbonoA_PAGAR.ToString, Direccion.Input, "")
                                                    If dAbonoA_PAGAR > 0 Then
                                                        lDescPlanilla = New DESCUENTOS_PLANILLA
                                                        lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                                        lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                                        lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                                                        lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                                        lDescPlanilla.ID_APLICACION_DESCTO = 1

                                                        IdCuentaFinan = Me.ObtenerIdCuentaFinan(dt.Rows(i)("ID_CREDITO_ENCA"))
                                                        If IdCuentaFinan <> -1 Then
                                                            lDescPlanilla.ID_TIPO_DESCTO = Me.ObtenerEquivalenciaTipoDescto(IdCuentaFinan, IdProvee, encabezado)
                                                            lDescPlanilla.MONTO_DESCUENTO = dAbonoA_PAGAR
                                                            lDescPlanilla.IVA = 0
                                                            lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                                            lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                            lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                                            lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                            lDescPlanilla.ID_CREDITO_ENCA = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                                                            lDescPlanilla.ID_CREDITO_ENCA_TRANS = -1
                                                            lDescPlanilla.CODIBANCO = -1
                                                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                                            bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Next

                                    Else
                                        'No existe detalle para este concepto
                                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "No existe detalle para este concepto", Direccion.Input, "")
                                        Dim lDescPlanilla As DESCUENTOS_PLANILLA
                                        Dim IdCuentaFinan As Int32
                                        Dim dicc As New Dictionary(Of String, Int32)

                                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "dPagoInteresTotal: " + dPagoInteresTotal.ToString, Direccion.Input, "")
                                        If dPagoInteresTotal > 0 Then
                                            lDescPlanilla = New DESCUENTOS_PLANILLA
                                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = codiproveedor
                                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                            lDescPlanilla.ID_APLICACION_DESCTO = 1
                                            lDescPlanilla.ID_TIPO_DESCTO = 3
                                            lDescPlanilla.MONTO_DESCUENTO = Math.Round(dPagoInteresTotal / (1 + Utilerias.TasaIva), 2)
                                            lDescPlanilla.IVA = dPagoInteresTotal - lDescPlanilla.MONTO_DESCUENTO
                                            lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                            lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                            lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                            lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                            lDescPlanilla.ID_CREDITO_ENCA = -1
                                            lDescPlanilla.CODIBANCO = -1
                                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                            bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                        End If
                                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "dDescuentoTotal: " + dDescuentoTotal.ToString, Direccion.Input, "")
                                        If dDescuentoTotal > 0 Then
                                            lDescPlanilla = New DESCUENTOS_PLANILLA
                                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = codiproveedor
                                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                            lDescPlanilla.ID_APLICACION_DESCTO = 1

                                            dicc = Me.ObtenerIdCuentaFinanPorConcepto(encabezado)
                                            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "IdCuentaFinan: " + IdCuentaFinan.ToString, Direccion.Input, "")
                                            If IdCuentaFinan <> -1 Then
                                                lDescPlanilla.ID_TIPO_DESCTO = Me.ObtenerEquivalenciaTipoDescto(dicc("ID_CUENTA_FINAN"), dicc("ID_PROVEE"), encabezado)
                                                lDescPlanilla.MONTO_DESCUENTO = dDescuentoTotal
                                                lDescPlanilla.IVA = 0
                                                lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                                lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                                lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                lDescPlanilla.ID_CREDITO_ENCA = -1
                                                lDescPlanilla.ID_CREDITO_ENCA_TRANS = -1
                                                lDescPlanilla.CODIBANCO = -1
                                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                                bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizando bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)", Direccion.Input, "")
                                            End If
                                        End If

                                    End If

                                End If

                            End If

                        End If

                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  *** FIN " + TIPO + " - CODIGO: " + exHojaDescto.Cells(fila, 1).Value2 + " NOMBRE: " + exHojaDescto.Cells(fila, 2).Value2 + " ***", Direccion.Input, "")
                        fila += 1
                    End While


                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "*** FIN - ENCABEZADO A DESCONTAR: " + encabezado + " ***", Direccion.Input, "")
                    col += 4
                End While

                Conexion.Close()
                Conexion.Dispose()

                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Iniciando bCreditoEnca.PROC_Actualizar_Intereses_Productores("", -1)", Direccion.Input, "")
                bCreditoEnca.PROC_Actualizar_Intereses_Productores("", -1)
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "Finalizando bCreditoEnca.PROC_Actualizar_Intereses_Productores("", -1)", Direccion.Input, "")

                exLibro.Close(False)
                exApp.DisplayAlerts = True
                exHojaDescto = Nothing
                exLibro = Nothing
                exApp = Nothing

            ElseIf lstPlanillaBase IsNot Nothing AndAlso
                    Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.Transportistas OrElse Me.CbxTIPO_PLANILLA1.SelectedValue = TipoPlanilla.ComplementoTransportistas Then

                TIPO = "TRANSPORTISTAS"

                lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
                If lstPlanillaBase(0).FECHA_PAGO = Nothing Then
                    MsgBox("Debe ingresarse la fecha de pago para la planilla antes de cargar la información", vbCritical, Application.ProductName)
                    Return
                End If

                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "*** INICIO CARGA PLANTILLA " + TIPO + " ***", Direccion.Input, "")
                Conexion.Open()
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Conexión habilitada a la plantilla de Excel en el directorio " + txtDirectorio.Text, Direccion.Input, "")

                'Validar que no existan saldos negativos
                exLibro = exApp.Workbooks.Open(txtDirectorio.Text, False, True)
                exHojaDescto = exLibro.Worksheets(Me.NombrePlantilla)
                Dim sProveePagoNegativo As New StringBuilder
                Dim seguir = True
                Dim esNegativo As Boolean = False
                col = 4
                fila = 3

                While seguir
                    If exHojaDescto.Cells(1, col).Value2.ToString.Contains("PAGO") AndAlso exHojaDescto.Cells(1, col).Value2.ToString.Contains("MENOS") AndAlso
                        exHojaDescto.Cells(1, col).Value2.ToString.Contains("DESCUENTO") Then
                        While CStr(exHojaDescto.Cells(fila, 1).Value2) <> "" AndAlso CStr(exHojaDescto.Cells(fila, 1).Value2) <> "TOTALES"
                            If IsNumeric(exHojaDescto.Cells(fila, col).Value2) AndAlso CDec(exHojaDescto.Cells(fila, col).Value2) < 0 Then
                                sProveePagoNegativo.Append(exHojaDescto.Cells(fila, 1).Value2)
                                sProveePagoNegativo.Append(" ")
                                sProveePagoNegativo.Append(exHojaDescto.Cells(fila, 2).Value2)
                                sProveePagoNegativo.Append(" por ")
                                sProveePagoNegativo.AppendLine(exHojaDescto.Cells(fila, col).Text)
                            End If
                            fila += 1
                        End While
                        seguir = False
                    End If
                    If exHojaDescto.Cells(2, col).Value2 <> "" Then col += 4 Else col += 1
                End While
                If sProveePagoNegativo.ToString <> "" Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Los siguientes registros poseen liquidación negativa: " + sProveePagoNegativo.ToString + "Corrija antes de cargar la información", Direccion.Output, "VALIDACION")
                    MsgBox("Los siguientes registros poseen liquidación negativa:" + vbCrLf + vbCrLf + sProveePagoNegativo.ToString + vbCrLf + "Corrija antes de cargar la información", vbCritical, Application.ProductName)
                    Return
                End If

                exLibro.Close(False)
                exApp.DisplayAlerts = True
                exHojaDescto = Nothing
                exLibro = Nothing

                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", " Iniciando carga de los datos de la hoja DETALLE siempre que APLICAR = '*'", Direccion.Input, "")
                mTabla = CrearDataTableDETALLE_TRANS()
                Comando = New OleDbCommand("SELECT CODIGO, CONCEPTO, SALDO, FECHA_ULTMOV, TASAINT, TIPO_INTERES, DESCUENTO, ABONO_INTERES, ID_CREDITO_ENCA, CATORCENA_VENCIMIENTO FROM [" & Me.NombrePlantillaDetalle & "$] WHERE APLICAR = '*'", Conexion)
                Comando.CommandType = CommandType.Text
                Adapter.SelectCommand = Comando
                Adapter.Fill(mTabla)

                '***********************************************************
                '   Aplicar directamente pagos marcados en el detalle
                '***********************************************************
                log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  Carga de los datos de la hota detalle realizada sin error. Registros cargados: " + mTabla.Rows.Count.ToString, Direccion.Input, "")
                If mTabla IsNot Nothing AndAlso mTabla.Rows.Count > 0 Then
                    Dim dt As DataTable = mTabla

                    For i As Int32 = 0 To dt.Rows.Count - 1
                        log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "  CODIGO: " + dt.Rows(i)("CODIGO").ToString + "| ID_CREDITO_ENCA: " + dt.Rows(i)("ID_CREDITO_ENCA").ToString + "| DESCUENTO: " + Convert.ToDecimal(dt.Rows(i)("DESCUENTO")).ToString("#,##0.00"), Direccion.Input, "")

                        Dim lCreditoMov As CREDITO_MOV_TRANS
                        Dim lDescPlanilla As DESCUENTOS_PLANILLA
                        Dim dAbono As Decimal = 0
                        Dim dInt As Decimal = 0
                        Dim dIntIva As Decimal = 0
                        Dim IdCuentaFinan As Int32
                        Dim IdProvee As Int32

                        dAbono = Convert.ToDecimal(dt.Rows(i)("DESCUENTO"))
                        dInt = Math.Round(Convert.ToDecimal(dt.Rows(i)("ABONO_INTERES")) / (1 + Utilerias.TasaIva), 2)
                        dIntIva = Convert.ToDecimal(dt.Rows(i)("ABONO_INTERES")) - dInt

                        lCreditoMov = New CREDITO_MOV_TRANS
                        lCreditoMov.ID_CREDITO_MOV = 0
                        lCreditoMov.ID_CREDITO_ENCA = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                        lCreditoMov.FECHA = lstPlanillaBase(0).FECHA_PAGO
                        lCreditoMov.UID_REFERENCIA = Guid.NewGuid
                        lCreditoMov.ID_CATORCENA = lCatorcena.ID_CATORCENA
                        lCreditoMov.CARGO = 0
                        lCreditoMov.ABONO = dAbono
                        lCreditoMov.SALDO = Convert.ToDecimal(dt.Rows(i)("SALDO")) - dAbono
                        lCreditoMov.ABONO_IVA = 0
                        lCreditoMov.ABONO_INTERES = dInt
                        lCreditoMov.ABONO_INTERES_IVA = dIntIva
                        lCreditoMov.USUARIO_CREA = Utilerias.ObtenerUsuario
                        lCreditoMov.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lCreditoMov.USUARIO_ACT = Utilerias.ObtenerUsuario
                        lCreditoMov.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lCreditoMov.CODIBANCO = -1
                        lCreditoMov.NO_DOCUMENTO = "PLANILLA"

                        lCreditoMov.FECHA_ULTMOV = IIf(IsDate(dt.Rows(i)("FECHA_ULTMOV")), CDate(dt.Rows(i)("FECHA_ULTMOV")), Nothing)
                        lCreditoMov.TASAINT = Convert.ToDecimal(dt.Rows(i)("TASAINT"))
                        lCreditoMov.SALDO_INICIAL = Convert.ToDecimal(dt.Rows(i)("SALDO"))
                        lCreditoMov.TIPO_INTERES = Convert.ToString(dt.Rows(i)("TIPO_INTERES"))
                        lCreditoMov.PLAZO_DIAS = 0
                        lCreditoMov.ID_PLANILLA_BASE = lstPlanillaBase(0).ID_PLANILLA_BASE
                        If IsNumeric(dt.Rows(i)("CATORCENA_VENCIMIENTO")) AndAlso dt.Rows(i)("CATORCENA_VENCIMIENTO") > 0 Then
                            lCreditoMov.ID_CATORCENA_VTO = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRAPorZAFRA_NOCATORCENA(Me.CbxZAFRA1.SelectedValue, Convert.ToDecimal(dt.Rows(i)("CATORCENA_VENCIMIENTO"))).ID_CATORCENA
                        Else
                            lCreditoMov.ID_CATORCENA_VTO = -1
                        End If

                        bCreditoMovTrans.ActualizarCREDITO_MOV_TRANS(lCreditoMov)

                        If dAbono > 0 Then
                            lDescPlanilla = New DESCUENTOS_PLANILLA
                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                            lDescPlanilla.ID_APLICACION_DESCTO = 1
                            IdCuentaFinan = Me.ObtenerIdCuentaFinanTrans(dt.Rows(i)("ID_CREDITO_ENCA"))
                            IdProvee = Me.ObtenerIdProveeTrans(dt.Rows(i)("ID_CREDITO_ENCA"))
                            If IdCuentaFinan <> -1 Then
                                lDescPlanilla.ID_TIPO_DESCTO = Me.ObtenerEquivalenciaTipoDesctoTrans(IdCuentaFinan, dt.Rows(i)("CONCEPTO"))
                                lDescPlanilla.MONTO_DESCUENTO = dAbono
                                lDescPlanilla.IVA = 0
                                lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                lDescPlanilla.ID_CREDITO_ENCA = -1
                                lDescPlanilla.ID_CREDITO_ENCA_TRANS = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                                lDescPlanilla.CODIBANCO = -1
                                bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                            End If
                        End If
                        If dInt > 0 Then
                            lDescPlanilla = New DESCUENTOS_PLANILLA
                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                            lDescPlanilla.ID_APLICACION_DESCTO = 1
                            lDescPlanilla.ID_TIPO_DESCTO = If(IdProvee <> 4 AndAlso IdProvee > 0, 32, 3)
                            lDescPlanilla.MONTO_DESCUENTO = dInt
                            lDescPlanilla.IVA = dIntIva
                            lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                            lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                            lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                            lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                            lDescPlanilla.ID_CREDITO_ENCA = -1
                            lDescPlanilla.ID_CREDITO_ENCA_TRANS = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                            lDescPlanilla.CODIBANCO = -1
                            bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                        End If
                    Next
                End If



                '***********************************************************
                '   Aplicar descuentos globales
                '***********************************************************               
                Dim dDescuentoTotal As Decimal
                Dim dPagoInteresTotal As Decimal
                Dim encabezado As String
                Dim codiproveedor As String

                exLibro = exApp.Workbooks.Open(txtDirectorio.Text, False, True)
                exHojaDescto = exLibro.Worksheets(Me.NombrePlantilla)

                col = 4
                'Recorrer los encabezados
                While Strings.Left(exHojaDescto.Cells(1, col).Value2, 5) <> "TOTAL"
                    encabezado = exHojaDescto.Cells(1, col).Value2
                    encabezado = Replace(encabezado, vbCrLf, " ")
                    encabezado = Replace(encabezado, vbLf, " ")
                    encabezado = Replace(encabezado, vbCr, " ")

                    fila = 3
                    'Recorrer todos los productores
                    While CStr(exHojaDescto.Cells(fila, 1).Value2) <> "TOTALES"
                        codiproveedor = exHojaDescto.Cells(fila, 1).Value2
                        If IsNumeric(exHojaDescto.Cells(fila, col + 2).Value2) OrElse IsNumeric(exHojaDescto.Cells(fila, col + 3).Value2) Then
                            dDescuentoTotal = 0
                            dPagoInteresTotal = 0
                            If IsNumeric(exHojaDescto.Cells(fila, col + 2).Value2) Then
                                dDescuentoTotal = Convert.ToDecimal(exHojaDescto.Cells(fila, col + 2).Value2)
                            End If
                            If IsNumeric(exHojaDescto.Cells(fila, col + 3).Value2) Then
                                dPagoInteresTotal = Convert.ToDecimal(exHojaDescto.Cells(fila, col + 3).Value2)
                            End If

                            If dDescuentoTotal > 0 OrElse dPagoInteresTotal > 0 Then

                                'Verificar si existen pagos marcados para ese productor y rubro rubro
                                Comando = New OleDbCommand(
                                    "SELECT CODIGO, CONCEPTO, SALDO, FECHA_ULTMOV, TASAINT, TIPO_INTERES, DESCUENTO, ABONO_INTERES, ID_CREDITO_ENCA, CATORCENA_VENCIMIENTO FROM [" & Me.NombrePlantillaDetalle & "$] " &
                                    "WHERE CODIGO = '" & exHojaDescto.Cells(fila, 1).Value2 & "' AND CONCEPTO = '" & encabezado & "' AND APLICAR <> ''", Conexion)
                                Comando.CommandType = CommandType.Text
                                Adapter.SelectCommand = Comando
                                mTabla = CrearDataTableDETALLE_TRANS()
                                Adapter.Fill(mTabla)

                                If Not (mTabla IsNot Nothing AndAlso mTabla.Rows.Count > 0) Then

                                    'No existen pagos marcados: Distribuir las cantidades en el detalle hasta que se agoten
                                    Comando = New OleDbCommand(
                                    "SELECT CODIGO, CONCEPTO, SALDO, FECHA_ULTMOV, TASAINT, TIPO_INTERES, DESCUENTO, ABONO_INTERES, ID_CREDITO_ENCA, CATORCENA_VENCIMIENTO FROM [" & Me.NombrePlantillaDetalle & "$] " &
                                    "WHERE CODIGO = '" & exHojaDescto.Cells(fila, 1).Value2 & "' AND CONCEPTO = '" & encabezado & "'", Conexion)
                                    Comando.CommandType = CommandType.Text
                                    Adapter.SelectCommand = Comando
                                    mTabla = CrearDataTableDETALLE_TRANS()
                                    Adapter.Fill(mTabla)

                                    If mTabla IsNot Nothing AndAlso mTabla.Rows.Count > 0 Then
                                        Dim dt As DataTable = mTabla

                                        For i As Int32 = 0 To dt.Rows.Count - 1
                                            Dim lCreditoMov As CREDITO_MOV_TRANS
                                            Dim lDescPlanilla As DESCUENTOS_PLANILLA
                                            Dim dAbono As Decimal = 0
                                            Dim dInt As Decimal = 0
                                            Dim dAbonoA_PAGAR As Decimal = 0
                                            Dim dIntA_PAGAR As Decimal = 0
                                            Dim IdCuentaFinan As Int32
                                            Dim IdProvee As Int32

                                            dAbono = Convert.ToDecimal(dt.Rows(i)("DESCUENTO"))
                                            dInt = Convert.ToDecimal(dt.Rows(i)("ABONO_INTERES"))

                                            If dDescuentoTotal > 0 OrElse dPagoInteresTotal > 0 Then
                                                If dPagoInteresTotal > 0 Then
                                                    If dPagoInteresTotal - dInt >= 0 Then
                                                        dIntA_PAGAR = dInt
                                                        dPagoInteresTotal -= dInt
                                                    End If
                                                End If
                                                If dDescuentoTotal > 0 Then
                                                    If dDescuentoTotal - dAbono >= 0 Then
                                                        dAbonoA_PAGAR = dAbono
                                                        dDescuentoTotal -= dAbono
                                                    Else
                                                        dAbonoA_PAGAR = dDescuentoTotal
                                                        dDescuentoTotal = 0
                                                    End If
                                                End If

                                                If dIntA_PAGAR > 0 OrElse dAbonoA_PAGAR > 0 Then
                                                    lCreditoMov = New CREDITO_MOV_TRANS
                                                    lCreditoMov.ID_CREDITO_MOV = 0
                                                    lCreditoMov.ID_CREDITO_ENCA = dt.Rows(i)("ID_CREDITO_ENCA")
                                                    lCreditoMov.FECHA = lCatorcena.FECHA_PAGO
                                                    lCreditoMov.UID_REFERENCIA = Guid.NewGuid
                                                    lCreditoMov.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                                    lCreditoMov.CARGO = 0
                                                    lCreditoMov.ABONO = dAbonoA_PAGAR
                                                    lCreditoMov.SALDO = Convert.ToDecimal(dt.Rows(i)("SALDO")) - dAbonoA_PAGAR
                                                    lCreditoMov.ABONO_IVA = 0
                                                    lCreditoMov.ABONO_INTERES = Math.Round(dIntA_PAGAR / (1 + Utilerias.TasaIva), 2)
                                                    lCreditoMov.ABONO_INTERES_IVA = dIntA_PAGAR - lCreditoMov.ABONO_INTERES
                                                    lCreditoMov.USUARIO_CREA = Utilerias.ObtenerUsuario
                                                    lCreditoMov.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                    lCreditoMov.USUARIO_ACT = Utilerias.ObtenerUsuario
                                                    lCreditoMov.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                    lCreditoMov.CODIBANCO = -1
                                                    lCreditoMov.NO_DOCUMENTO = "PLANILLA"

                                                    lCreditoMov.FECHA_ULTMOV = IIf(IsDate(dt.Rows(i)("FECHA_ULTMOV")), CDate(dt.Rows(i)("FECHA_ULTMOV")), Nothing)
                                                    lCreditoMov.TASAINT = Convert.ToDecimal(dt.Rows(i)("TASAINT"))
                                                    lCreditoMov.SALDO_INICIAL = Convert.ToDecimal(dt.Rows(i)("SALDO"))
                                                    lCreditoMov.TIPO_INTERES = Convert.ToString(dt.Rows(i)("TIPO_INTERES"))
                                                    lCreditoMov.PLAZO_DIAS = bCreditoEnca.fObtenerPlazoInteres(Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA")), lCatorcena.FECHA_PAGO)
                                                    lCreditoMov.ID_PLANILLA_BASE = lstPlanillaBase(0).ID_PLANILLA_BASE
                                                    If IsNumeric(dt.Rows(i)("CATORCENA_VENCIMIENTO")) AndAlso dt.Rows(i)("CATORCENA_VENCIMIENTO") > 0 Then
                                                        lCreditoMov.ID_CATORCENA_VTO = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRAPorZAFRA_NOCATORCENA(Me.CbxZAFRA1.SelectedValue, Convert.ToDecimal(dt.Rows(i)("CATORCENA_VENCIMIENTO"))).ID_CATORCENA
                                                    Else
                                                        lCreditoMov.ID_CATORCENA_VTO = -1
                                                    End If
                                                    bCreditoMovTrans.ActualizarCREDITO_MOV_TRANS(lCreditoMov)

                                                    IdProvee = Me.ObtenerIdProveeTrans(dt.Rows(i)("ID_CREDITO_ENCA"))

                                                    If dIntA_PAGAR > 0 Then
                                                        lDescPlanilla = New DESCUENTOS_PLANILLA
                                                        lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                                        lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                                        lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                                                        lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                                        lDescPlanilla.ID_APLICACION_DESCTO = 1
                                                        lDescPlanilla.ID_TIPO_DESCTO = If(IdProvee <> 4 AndAlso IdProvee > 0, 32, 3)
                                                        lDescPlanilla.MONTO_DESCUENTO = Math.Round(dIntA_PAGAR / (1 + Utilerias.TasaIva), 2)
                                                        lDescPlanilla.IVA = dIntA_PAGAR - lDescPlanilla.MONTO_DESCUENTO
                                                        lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                                        lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                        lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                                        lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                        lDescPlanilla.ID_CREDITO_ENCA_TRANS = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                                                        lDescPlanilla.ID_CREDITO_ENCA = -1
                                                        lDescPlanilla.CODIBANCO = -1
                                                        bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                                    End If
                                                    If dAbonoA_PAGAR > 0 Then
                                                        lDescPlanilla = New DESCUENTOS_PLANILLA
                                                        lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                                        lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                                        lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = dt.Rows(i)("CODIGO")
                                                        lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                                        lDescPlanilla.ID_APLICACION_DESCTO = 1

                                                        IdCuentaFinan = Me.ObtenerIdCuentaFinanTrans(dt.Rows(i)("ID_CREDITO_ENCA"))
                                                        If IdCuentaFinan <> -1 Then
                                                            lDescPlanilla.ID_TIPO_DESCTO = Me.ObtenerEquivalenciaTipoDesctoTrans(IdCuentaFinan, dt.Rows(i)("CONCEPTO"))
                                                            lDescPlanilla.MONTO_DESCUENTO = dAbonoA_PAGAR
                                                            lDescPlanilla.IVA = 0
                                                            lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                                            lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                            lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                                            lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                            lDescPlanilla.ID_CREDITO_ENCA_TRANS = Convert.ToInt32(dt.Rows(i)("ID_CREDITO_ENCA"))
                                                            lDescPlanilla.ID_CREDITO_ENCA = -1
                                                            lDescPlanilla.CODIBANCO = -1
                                                            bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Next

                                    Else
                                        'No existe detalle para este concepto
                                        Dim lDescPlanilla As DESCUENTOS_PLANILLA
                                        Dim IdCuentaFinan As Int32
                                        Dim dicc As New Dictionary(Of String, Int32)

                                        If dPagoInteresTotal > 0 Then
                                            lDescPlanilla = New DESCUENTOS_PLANILLA
                                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = codiproveedor
                                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                            lDescPlanilla.ID_APLICACION_DESCTO = 1
                                            lDescPlanilla.ID_TIPO_DESCTO = 3
                                            lDescPlanilla.MONTO_DESCUENTO = Math.Round(dPagoInteresTotal / (1 + Utilerias.TasaIva), 2)
                                            lDescPlanilla.IVA = dPagoInteresTotal - lDescPlanilla.MONTO_DESCUENTO
                                            lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                            lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                            lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                            lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                            lDescPlanilla.ID_CREDITO_ENCA = -1
                                            lDescPlanilla.CODIBANCO = -1
                                            bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                        End If
                                        If dDescuentoTotal > 0 Then
                                            lDescPlanilla = New DESCUENTOS_PLANILLA
                                            lDescPlanilla.ID_DESCUENTO_PLANILLA = 0
                                            lDescPlanilla.ID_CATORCENA = lCatorcena.ID_CATORCENA
                                            lDescPlanilla.CODIPROVEEDOR_TRANSPORTISTA = codiproveedor
                                            lDescPlanilla.ID_TIPO_PLANILLA = Me.CbxTIPO_PLANILLA1.SelectedValue
                                            lDescPlanilla.ID_APLICACION_DESCTO = 1

                                            dicc = Me.ObtenerIdCuentaFinanPorConcepto(encabezado)
                                            If IdCuentaFinan <> -1 Then
                                                lDescPlanilla.ID_TIPO_DESCTO = Me.ObtenerEquivalenciaTipoDesctoTrans(dicc("ID_CUENTA_FINAN"), "")
                                                lDescPlanilla.MONTO_DESCUENTO = dDescuentoTotal
                                                lDescPlanilla.IVA = 0
                                                lDescPlanilla.USUARIO_CREA = configuracion.usuarioActualiza
                                                lDescPlanilla.FECHA_CREA = cFechaHora.ObtenerFechaHora
                                                lDescPlanilla.USUARIO_ACT = configuracion.usuarioActualiza
                                                lDescPlanilla.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                                lDescPlanilla.ID_CREDITO_ENCA = -1
                                                lDescPlanilla.ID_CREDITO_ENCA_TRANS = -1
                                                lDescPlanilla.CODIBANCO = -1
                                                bDescPlanilla.ActualizarDESCUENTOS_PLANILLA(lDescPlanilla, TipoConcurrencia.Pesimistica)
                                            End If
                                        End If

                                    End If

                                End If

                            End If

                        End If

                        fila += 1
                    End While

                    col += 4
                End While

                Conexion.Close()
                Conexion.Dispose()

                bCreditoEnca.PROC_Actualizar_Intereses_Productores("", -1)

                exLibro.Close(False)
                exApp.DisplayAlerts = True
                exHojaDescto = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If

            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", "*** PROCESO FINALIZADO CON EXITO ***", Direccion.Output, "")
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.txtDirectorio.Text = ""
            MsgBox("La carga de la plantilla se realizo con éxito", vbInformation, Application.ProductName)


        Catch ex As Exception
            log.crea_archivo(archivoLog, "btnCargarPlantilla_Click", " ERROR AL CARGAR PLANTILLA: " + ex.Message.ToString(), Direccion.Output, "")
            bCreditoEnca.PROC_Actualizar_Intereses_Productores("", -1)

            Me.Cursor = System.Windows.Forms.Cursors.Default
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
                Conexion.Dispose()
            End If
            MsgBox(ex.Message, vbCritical, Application.ProductName)
        End Try
    End Sub
End Class