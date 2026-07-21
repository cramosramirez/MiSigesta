Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.XtraPrinting
Imports RestSharp

Partial Class controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans
    Inherits ucBase

    Private Shared progress As Double
    Private Log As New CrearLog

#Region "Inicializaciones Mantenimiento"
    Private Sub Inicializar()
        Me.ucCriteriosBodega1.VerZAFRA = True
        Me.ucCriteriosBodega1.VerCATORCENA = True
        Me.ucCriteriosBodega1.VerTIPO_PLANILLA = True
        Me.ucCriteriosBodega1.VerBODEGA = False
        Me.ucCriteriosBodega1.VerPRODUCTO = False
        Me.ucCriteriosBodega1.VerPERIODO_RANGO = False
    End Sub
#End Region

    Private Sub controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
            progress = 0
        End If
    End Sub

    Protected Sub ASPxCallback1_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
        Dim mensaje As New StringBuilder
        Log.DIRECTORIO_ARCHIVO = ConfigurationManager.AppSettings.Get("DIRECTORIO_LOG")
        mensaje.Clear()
        mensaje.Append("| ID_CATORCENA: " & ucCriteriosBodega1.ID_CATORCENA.ToString)
        mensaje.Append("| ID_TIPO_PLANILLA: " & ucCriteriosBodega1.ID_TIPO_PLANILLA.ToString)
        Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "ASPxCallback1_Callback| Obtener lista planilla contribuyentes", 0, mensaje.ToString, "")

        Dim count As Integer = 0
        Dim listaPlanilla As listaPLANILLA = (New cPLANILLA).ObtenerListaPorCRITERIOS(ucCriteriosBodega1.ID_CATORCENA, ucCriteriosBodega1.ID_TIPO_PLANILLA, "", "", True)
        Dim directorioPDF As String = ConfigurationManager.AppSettings.Get("DOCUMENTOS_PDF")
        Dim urlPDF As String = ConfigurationManager.AppSettings.Get("URL_PDF")
        Dim nombreArchivo As String
        Dim urlArchivo As String
        Dim pdfOptions As PdfExportOptions
        Dim lRet As Integer = 0
        Dim reporte As New DatosParaCCF_Cana_Transporte

        Dim grupoDJ As Integer = 0

        Try

            If listaPlanilla IsNot Nothing AndAlso listaPlanilla.Count > 0 Then
                count += listaPlanilla.Count

                For x As Integer = 0 To listaPlanilla.Count - 1
                    If listaPlanilla(x).CODIPROVEEDOR_TRANSPORTISTA = "0142870000" OrElse listaPlanilla(x).CODIPROVEEDOR_TRANSPORTISTA = "0150380000" Then
                        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ucCriteriosBodega1.ID_ZAFRA)
                        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ucCriteriosBodega1.ID_CATORCENA)

                        reporte = New DatosParaCCF_Cana_Transporte
                        pdfOptions = reporte.ExportOptions.Pdf
                        pdfOptions.ConvertImagesToJpeg = False
                        pdfOptions.ImageQuality = PdfJpegImageQuality.Medium
                        pdfOptions.PdfACompatibility = PdfACompatibility.None
                        pdfOptions.DocumentOptions.Application = "Test Application"
                        pdfOptions.DocumentOptions.Author = "INJIBOA S.A. DE C.V."
                        pdfOptions.DocumentOptions.Subject = "Formato para emision de CCF"
                        pdfOptions.DocumentOptions.Title = "Liquidacion zafra " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-") + " Corte " + lCatorcena.CATORCENA.ToString + " Codigo " + listaPlanilla(x).CODIPROVEEDOR_TRANSPORTISTA
                        nombreArchivo = directorioPDF + pdfOptions.DocumentOptions.Title & ".pdf"
                        urlArchivo = urlPDF + pdfOptions.DocumentOptions.Title & ".pdf"

                        mensaje.Clear()
                        mensaje.Append("| id_catorcena: " & listaPlanilla(x).ID_CATORCENA.ToString)
                        mensaje.Append("| id_tipo_planilla: " & listaPlanilla(x).ID_TIPO_PLANILLA.ToString)
                        mensaje.Append("| codiproveedor_transportista: " & listaPlanilla(x).CODIPROVEEDOR_TRANSPORTISTA)
                        Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "ASPxCallback1_Callback| Generar archivo pdf", 0, mensaje.ToString, "")

                        reporte.CargarDatos(listaPlanilla(x).ID_CATORCENA, listaPlanilla(x).ID_TIPO_PLANILLA, listaPlanilla(x).CODIPROVEEDOR_TRANSPORTISTA)
                        reporte.ResumeLayout()
                        reporte.ExportToPdf(nombreArchivo, pdfOptions)
                        reporte.Dispose()
                        reporte = Nothing
                        Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "ASPxCallback1_Callback| Archivo generado", 0, "ARCHIVO: " & nombreArchivo, "")

                        lRet = Me.EnviarNotificacionWhatsApp(listaPlanilla(x).CODIPROVEEDOR_TRANSPORTISTA, listaPlanilla(x).ID_TIPO_PLANILLA, urlArchivo)

                        System.IO.File.Delete(nombreArchivo)

                        progress = Convert.ToDouble(Math.Round(Convert.ToDouble(x) / Convert.ToDouble(count) * 100, 0))
                        'System.Threading.Thread.Sleep(100)
                        grupoDJ = grupoDJ + 1
                    End If

                    If grupoDJ = 2 Then Exit For
                Next
            End If

        Catch ex As Exception
            Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "ASPxCallback1_Callback", 1, "Exception", ex.Message)
        Finally
            If reporte IsNot Nothing Then
                reporte.Dispose()
                reporte = Nothing
            End If
        End Try
    End Sub
    Protected Sub ASPxCallback2_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
        e.Result = progress & "%"
    End Sub

    Private Function EnviarNotificacionWhatsApp(ByVal codigo As String, ByVal tipoPlanilla As Integer, ByVal url As String) As Integer
        Try
            'Dim archivoBase64 As String = Convert.ToBase64String(System.IO.File.ReadAllBytes(ruta))
            Dim msgLog As New StringBuilder
            msgLog.Append("| codigo: " & codigo)
            msgLog.Append("| tipoPlanilla: " & tipoPlanilla.ToString)
            msgLog.Append("| url: " & url)
            Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "EnviarNotificacionWhatsApp| Inicio", 0, msgLog.ToString, "")
            Dim token As String = ConfigurationManager.AppSettings.Get("TOKEN_WHATSAPP")
            Dim telefonos() As String
            Dim mensaje As New StringBuilder()

            If tipoPlanilla = Enumeradores.TipoProveedor.Cañero Then
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(codigo)
                If lProveedor IsNot Nothing AndAlso lProveedor.TELEFONO.Trim <> "" Then
                    telefonos = lProveedor.TELEFONO.Split("/")
                End If
            ElseIf tipoPlanilla = Enumeradores.TipoProveedor.Transportista Then
                Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(codigo)
                If lTransportista IsNot Nothing AndAlso lTransportista.TELEFONO.Trim <> "" Then
                    telefonos = lTransportista.TELEFONO.Split("/")
                End If
            End If
            telefonos = {"78401743"} ', "78504845", "78620093", "70695709", "78880560"

            If telefonos IsNot Nothing AndAlso telefonos.Count > 0 Then
                For j As Integer = 0 To telefonos.Count - 1
                    telefonos(j) = telefonos(j).Replace("-", "")
                    If Left(telefonos(j), 1) <> "2" AndAlso telefonos(j).Length = 8 Then
                        Dim telefDestino As String = "503" + telefonos(j)
                        If mensaje.ToString <> "" Then
                            mensaje.Append(",")
                        End If
                        mensaje.Append("{""numero"": """ & telefDestino & """,""url"": """ & url & """}")
                    End If
                Next

                Dim client = New RestClient("https://script.google.com/macros/s/AKfycbyoBhxuklU5D3LTguTcYAS85klwFINHxxd-FroauC4CmFVvS0ua/exec")
                Dim postRequest = New RestRequest("", Method.POST)
                postRequest.AddHeader("Content-Type", "application/json")
                postRequest.AddParameter("application/json",
                                     "{" & """op"":""sendmessage"",""token_qr"":""" & token & """," &
                                     """mensajes"":[" &
                                     mensaje.ToString() &
                                     "]}", ParameterType.RequestBody)
                Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "EnviarNotificacionWhatsApp| Consumo API", 0, postRequest.Parameters(0).Value.ToString(), "")

                'postRequest.AddParameter("application/json",
                '                     "{" & """op"":""sendmessage"",""token_qr"":""" & token & """," &
                '                     """mensajes"":[" &
                '                     "{""numero"": """ & telefDestino & """,""pdfbase64"": """ & archivoBase64 & """,""pdfnombre"": """ & mensaje & """}" &
                '                     "]}", ParameterType.RequestBody)
                Dim response1 = client.Execute(postRequest).Content.ToString()
                Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "EnviarNotificacionWhatsApp| Consumo API", 1, response1, "")
            End If
            Return 1

        Catch ex As Exception
            Log.crea_archivo("controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans", "EnviarNotificacionWhatsApp", 1, "Exception", ex.Message)
            Return 0

        End Try
    End Function


End Class

