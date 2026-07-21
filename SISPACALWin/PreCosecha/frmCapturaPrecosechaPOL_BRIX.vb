Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.EL.Enumeradores
Imports System.Text
Imports SISPACAL.DL
Imports System.ComponentModel
Imports System.Configuration
Imports SISPACAL.BL.cCREAR_ARCHIVO_LOG

Public Class frmCapturaPrecosechaBRIX_POL
    Private WithEvents RS232 As New System.IO.Ports.SerialPort
    Delegate Sub WriteDataDelegate(ByVal str As String)

    Private IdZafraActiva As Integer
    Public entidadPrecosecha As ANALISIS_PRECOSECHA

    Private Const formato As String = "#,##0.00"
    Private colorCaptura As System.Drawing.Color = Color.LightSkyBlue
    Private esCapturaPolBrixSimultanea As Boolean
    Private valorTipoLectura As TipoLectura
    Private iniciando As Boolean = False
    Private listaTipoLectura As New listaTIPO_LECTURA
    Private cambioDatos As Boolean = False
    Private bFechaHora As New cFechaHora
    Private log As New cCREAR_ARCHIVO_LOG
    Private archivoLog As String = ConfigurationManager.AppSettings("ARCHIVO_LOG_PRECOSECHA")
    Private directorioLog As String = ConfigurationManager.AppSettings("DIRECTORIO_LOG")

    Private Sub frmCapturaPrecosechaPOL_BRIX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciando = True
        log.DIRECTORIO_ARCHIVO = directorioLog
        ZafraActiva()
        LimpiarCampos()
        iniciando = False
    End Sub

    Private Sub frmCapturaPrecosechaPOL_BRIX_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Enum TipoLectura As Integer
        Pol_Brix = 2
        Brix = 3
        Pol = 4
        Ninguno = 0
    End Enum

    Private Sub ZafraActiva()
        Dim lZafra As ZAFRA
        lZafra = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            IdZafraActiva = lZafra.ID_ZAFRA
            esCapturaPolBrixSimultanea = lZafra.CAPTURA_POL_BRIX_SIMULTANEA
        Else
            MsgBox("No se encontró una Zafra activa", MsgBoxStyle.Critical, Application.ProductName)
            Application.Exit()
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Procedimiento que cierra la conexión con el puerto serial COM RS232
    Private Sub CerrarPuerto()
        If RS232 IsNot Nothing AndAlso RS232.IsOpen Then
            RS232.Close()
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtTACO.Text = String.Empty
        txtTACO.Enabled = True
        btnNuevo.Enabled = False
        lstLecturas.Items.Clear()
        btnLeerPuerto.Enabled = False
        btnCapturar.Enabled = False
        btnGuardar.Enabled = False
        gbAnalisisLab.Visible = False
        lblMADURANTE.Text = ""
        lblFECHA_APLICA_MADURANTE.Text = ""
        gbLecturas.Text = "..."

        For Each _control As Control In gbAnalisisLab.Controls
            If TypeOf (_control) Is TextBox Then
                Dim texto As TextBox = CType(_control, TextBox)
                If texto.Tag = "LecturaAparatos" Then
                    texto.Text = ""
                    texto.BackColor = Color.White
                    texto.Enabled = False
                End If
            End If
        Next
        For Each _control As Control In gbAnalisisLab.Controls
            If TypeOf (_control) Is Label Then
                Dim etiqueta As Label = CType(_control, Label)
                If etiqueta.Tag = "LecturaAparatos" Then
                    etiqueta.Text = ""
                    etiqueta.BackColor = Color.White
                End If
            End If
        Next
        txtTACO.Focus()
    End Sub

    Private Sub escribirEntero(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTACO.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send(vbTab)
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub escribirDecimal(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsDigit(e.KeyChar)) OrElse e.KeyChar = "."c Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTACO_Validating(sender As Object, e As CancelEventArgs) Handles txtTACO.Validating
        Dim lPrecosecha As ANALISIS_PRECOSECHA

        log.crea_archivo(archivoLog, "txtTACO_Validating", "Inicio - TACO: " + txtTACO.Text, Direccion.Input, "")
        txtTACO.Text = txtTACO.Text.Trim
        If txtTACO.Text.Length = 0 OrElse Not IsNumeric(txtTACO.Text) Then
            txtTACO.Text = String.Empty
            Return
        End If
        lPrecosecha = (New cANALISIS_PRECOSECHA).ObtenerPorZAFRA_NO_ANALISIS(IdZafraActiva, Convert.ToInt32(txtTACO.Text))
        If lPrecosecha IsNot Nothing Then
            Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lPrecosecha.ACCESLOTE)
            Me.lblVARIEDAD.Text = (New cVARIEDAD).ObtenerVARIEDAD(lLote.CODIVARIEDA).NOM_VARIEDAD
            entidadPrecosecha = lPrecosecha

            Dim lSolicitudesAplica As listaSOLIC_APLICA_LOTE = (New cSOLIC_APLICA_LOTE).ObtenerListaPorZAFRA_LOTE(entidadPrecosecha.ID_ZAFRA, entidadPrecosecha.ACCESLOTE)
            If lSolicitudesAplica IsNot Nothing AndAlso lSolicitudesAplica.Count > 0 Then
                Dim indice As Int32 = lSolicitudesAplica.Count - 1
                Me.lblMADURANTE.Text = lSolicitudesAplica(indice).NOMBRE_PRODUCTO
                Me.lblFECHA_APLICA_MADURANTE.Text = lSolicitudesAplica(indice).FECHA_APLICA.ToString("dd/MM/yyyy")
            End If

            'Obtener entidad analisis y bascula   
            If lPrecosecha.BAGAZO_BRUTO <> -1 Then Me.lblBAGAZO_BRUTO.Text = entidadPrecosecha.BAGAZO_BRUTO.ToString(formato)
            If lPrecosecha.BAGAZO_NETO <> -1 Then Me.lblBAGAZO_NETO.Text = entidadPrecosecha.BAGAZO_NETO.ToString(formato)
            If lPrecosecha.POL <> -1 Then Me.lblPOL.Text = entidadPrecosecha.POL.ToString(formato)
            If lPrecosecha.BRIX <> -1 Then Me.lblBRIX.Text = entidadPrecosecha.BRIX.ToString(formato)
            If lPrecosecha.POL_LECTURA <> -1 Then Me.lblPOL_Lectura.Text = entidadPrecosecha.POL_LECTURA.ToString
            If lPrecosecha.PH <> -1 Then Me.txtPH.Text = entidadPrecosecha.PH.ToString(formato)



            'Determinar el valor a capturar
            If esCapturaPolBrixSimultanea Then
                If lPrecosecha.POL = -1 Then
                    valorTipoLectura = TipoLectura.Pol_Brix
                    gbLecturas.Text = "SE PROCEDERA A LA CAPTURA DE BRIX Y POL"
                Else
                    valorTipoLectura = TipoLectura.Ninguno
                End If
            Else
                If lPrecosecha.BRIX = -1 Then
                    valorTipoLectura = TipoLectura.Brix
                    gbLecturas.Text = "SE PROCEDERA A LA CAPTURA DE BRIX"
                Else
                    valorTipoLectura = TipoLectura.Ninguno
                End If
            End If

            gbAnalisisLab.Visible = True
            Me.MostrarVariablesPolBrixAnalisis(True)

            txtTACO.Enabled = False
            btnNuevo.Enabled = True

            If entidadPrecosecha.BAGAZO_BRUTO = -1 OrElse entidadPrecosecha.BAGAZO_NETO = -1 Then
                MsgBox("Capture el peso del bagazo antes de capturar POL/BRIX", MsgBoxStyle.Critical, Application.ProductName)
                Return
            End If
            If entidadPrecosecha.POL <> -1 AndAlso entidadPrecosecha.BRIX <> -1 Then
                log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "El BRIX/POL han sido capturados No. Orden: " + txtTACO.Text + " BRIX: " + entidadPrecosecha.BRIX.ToString + " POL: " + entidadPrecosecha.POL.ToString, Direccion.Output, "")
                MsgBox("El BRIX/POL han sido capturados", MsgBoxStyle.Critical, Application.ProductName)
                Return
            End If
            Me.lblPOL.BackColor = colorCaptura
            Me.lblBRIX.BackColor = colorCaptura
            btnLeerPuerto.Enabled = True
        Else
            log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "El N° de Orden de Análisis " + txtTACO.Text + " no existe para esta Zafra", Direccion.Output, "")
            MsgBox("El N° de Orden de Análisis " + txtTACO.Text + " no existe para esta Zafra", MsgBoxStyle.Critical, Application.ProductName)
            txtTACO.Text = String.Empty
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        CerrarPuerto()
        Me.Close()
    End Sub

    Private Sub btnLeerPuerto_Click(sender As Object, e As EventArgs) Handles btnLeerPuerto.Click
        Try
            log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "Inicio - ID_TIPO_LECTURA: " + valorTipoLectura.ToString, 0, "")
            Me.btnCapturar.Enabled = False
            Me.lstLecturas.Items.Clear()

            Dim lTipoLectura As TIPO_LECTURA = (New cTIPO_LECTURA).ObtenerTIPO_LECTURA(valorTipoLectura)
            log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "Inicio - ID_EQUIPO: " + lTipoLectura.ID_EQUIPO.ToString, 0, "")
            Dim lEquipo As EQUIPO_MEDICION = (New cEQUIPO_MEDICION).ObtenerEQUIPO_MEDICION(lTipoLectura.ID_EQUIPO)
            If lEquipo IsNot Nothing Then
                Dim paridad As IO.Ports.Parity
                Dim bitsParada As IO.Ports.StopBits

                Select Case lEquipo.PARIDAD.ToUpper
                    Case "PAR"
                        paridad = IO.Ports.Parity.Even
                    Case "MARCADA"
                        paridad = IO.Ports.Parity.Mark
                    Case "IMPAR"
                        paridad = IO.Ports.Parity.Odd
                    Case "ESPACIADA"
                        paridad = IO.Ports.Parity.Space
                    Case "NINGUNO", "NINGUNA"
                        paridad = IO.Ports.Parity.None
                End Select

                Select Case lEquipo.BITS_PARADA
                    Case CDec(0)
                        bitsParada = IO.Ports.StopBits.None
                    Case CDec(1)
                        bitsParada = IO.Ports.StopBits.One
                    Case CDec(1.5)
                        bitsParada = IO.Ports.StopBits.OnePointFive
                    Case CDec(2)
                        bitsParada = IO.Ports.StopBits.Two
                End Select
                log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "OpenSerialPort - EQUIPO: " + lEquipo.NOMBRE_EQUIPO + " PUERTO: " + lEquipo.PUERTO + " BITS POR SEG: " + Convert.ToInt32(lEquipo.BITS_POR_SEGUNDO).ToString + " PARIDAD: " + paridad.ToString, 1, "")
                RS232 = My.Computer.Ports.OpenSerialPort(lEquipo.PUERTO, Convert.ToInt32(lEquipo.BITS_POR_SEGUNDO), paridad, Convert.ToInt32(lEquipo.BITS_DATOS), bitsParada)
                btnLeerPuerto.Enabled = False
                log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "PUERTO ABIERTO", 1, "")
                Timer1.Start()
                log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "TIMER1 INICIADO", 1, "")
            End If

        Catch ex As System.IO.IOException
            ExceptionManager.Publish(ex)
            log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "System.IO.IOException", Direccion.Output, ex.Message)
            MsgBox("Error abriendo el puerto: " & ex.Message)
        Catch ex As System.UnauthorizedAccessException
            log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "System.UnauthorizedAccessException", Direccion.Output, ex.Message)
            ExceptionManager.Publish(ex)
            MsgBox("El pueto ya esta abierto: " & ex.Message)
        Catch ex As System.Exception
            log.crea_archivo(archivoLog, "btnLeerPuerto_Click", "System.Exception", Direccion.Output, ex.Message)
            ExceptionManager.Publish(ex)
            MsgBox("Error general accediendo al puerto: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RS232.IsOpen Then
            log.crea_archivo(archivoLog, "Timer1_Tick", "RS232 ABIERTO (IsOpen = True)", 1, "")
            RS232.NewLine = vbCrLf
            RS232.WriteLine("r")
        Else
            log.crea_archivo(archivoLog, "Timer1_Tick", "RS232 CERRADO (IsOpen = false)", 1, "")
        End If
    End Sub

    Private Sub RS232_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles RS232.DataReceived

        Dim strData As String = RS232.ReadExisting
        log.crea_archivo(archivoLog, "RS232_DataReceived", "INICIANDO - RS232.ReadExisting: " + strData, Direccion.Output, "")
        Dim WriteInvoke As New WriteDataDelegate(AddressOf Me.WriteData)
        Me.Invoke(WriteInvoke, strData)
    End Sub

    Private Sub WriteData(ByVal str As String)
        Dim valor As String = str.Trim
        log.crea_archivo(archivoLog, "WriteData", "INICIANDO - str: " + valor, 1, "")
        If lstLecturas.Items.Count = 4 Then
            lstLecturas.Items.RemoveAt(0)
        End If
        If valorTipoLectura = TipoLectura.Brix OrElse valorTipoLectura = TipoLectura.Pol Then
            If IsNumeric(valor) Then
                lstLecturas.Items.Add(valor)
                lstLecturas.SelectedIndex = lstLecturas.Items.Count - 1

                btnCapturar.Enabled = True
            End If
        Else
            If valor <> "" Then
                lstLecturas.Items.Add(valor)
                lstLecturas.SelectedIndex = lstLecturas.Items.Count - 1

                btnCapturar.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
        RS232.Close()
        'lstLecturas.Items.Add("ISS-26 (TC),°Z,0.01,RI Brix,%Brix,0.14") '**************
        Dim bEquipo As New cEQUIPO_MEDICION
        Dim lTipoLectura As TIPO_LECTURA
        Dim lValores As List(Of Decimal)
        Dim sLecturaListBox As String = ""

        log.crea_archivo(archivoLog, "btnCapturar_Click", "INICIANDO - valorTipoLectura: " + valorTipoLectura.ToString, 1, "")
        log.crea_archivo(archivoLog, "btnCapturar_Click", "INICIANDO - lstLecturas.Items.Count: " + lstLecturas.Items.Count.ToString, 1, "")

        If valorTipoLectura = TipoLectura.Pol_Brix Then
            sLecturaListBox = ProcesarCapturaPolBrix(lstLecturas) ' Aqui se tienen los valores de Brix y Pol lectura
        ElseIf valorTipoLectura = TipoLectura.Brix OrElse valorTipoLectura = TipoLectura.Pol Then
            sLecturaListBox = lstLecturas.Items(lstLecturas.Items.Count - 1)
        End If
        log.crea_archivo(archivoLog, "btnCapturar_Click", "INICIANDO - sLecturaListBox: " + sLecturaListBox, 2, "")

        If lstLecturas.Items.Count = 0 Then
            MsgBox("No se ha realizado lectura correcta del equipo", MsgBoxStyle.Critical, Application.ProductName)
            btnLeerPuerto_Click(Me, e)
            Exit Sub
        End If
        If sLecturaListBox.Trim = "-" OrElse sLecturaListBox.Trim = "" Then
            MsgBox("No se ha realizado lectura correcta de Brix o Pol", MsgBoxStyle.Critical, Application.ProductName)
            btnLeerPuerto_Click(Me, e)
            Exit Sub
        End If

        lTipoLectura = (New cTIPO_LECTURA).ObtenerTIPO_LECTURA(valorTipoLectura)
        If valorTipoLectura = TipoLectura.Pol AndAlso Me.lblBRIX.Text <> "" AndAlso IsNumeric(Me.lblBRIX.Text) AndAlso Convert.ToDecimal(Me.lblBRIX.Text) > 0 Then
            log.crea_archivo(archivoLog, "btnCapturar_Click", "PROCESAR LECTURA POL - ID_EQUIPO: " + lTipoLectura.ID_EQUIPO.ToString + " LECTURA LISTBOX POL: " + sLecturaListBox + "LECTURA BRIX: " + Me.lblBRIX.Text, Direccion.Output, "")
            lValores = bEquipo.ProcesarLectura(lTipoLectura.ID_EQUIPO, sLecturaListBox, Convert.ToDecimal(Me.lblBRIX.Text))
        ElseIf valorTipoLectura = TipoLectura.Pol_Brix Then
            log.crea_archivo(archivoLog, "btnCapturar_Click", "PROCESAR LECTURA POL_BRIX - ID_EQUIPO: " + lTipoLectura.ID_EQUIPO.ToString + " LECTURA LISTBOX: " + sLecturaListBox, Direccion.Output, "")
            lValores = bEquipo.ProcesarLectura(lTipoLectura.ID_EQUIPO, sLecturaListBox)
        ElseIf valorTipoLectura = TipoLectura.Brix Then
            log.crea_archivo(archivoLog, "btnCapturar_Click", "PROCESAR LECTURA BRIX - ID_EQUIPO: " + lTipoLectura.ID_EQUIPO.ToString + " LECTURA LISTBOX: " + lstLecturas.Items(lstLecturas.Items.Count - 1).ToString, Direccion.Output, "")
            lValores = bEquipo.ProcesarLectura(lTipoLectura.ID_EQUIPO, lstLecturas.Items(lstLecturas.Items.Count - 1))
        End If

        If lValores Is Nothing OrElse lValores.Count = 0 Then
            MsgBox("No se logró procesar la lectura del equipo. Vuelva a realizar la captura", MsgBoxStyle.Critical, Application.ProductName)
            btnLeerPuerto_Click(Me, e)
            Exit Sub
        End If

        Select Case valorTipoLectura

            Case TipoLectura.Pol_Brix
                Me.lblPOL.Text = lValores(0).ToString(formato)
                Me.lblBRIX.Text = lValores(1).ToString(formato)
                Me.lblPOL_Lectura.Text = lValores(2).ToString
                btnCapturar.Enabled = False
                btnGuardar.Enabled = True
                Timer1.Stop()

            Case TipoLectura.Brix
                Me.lblBRIX.Text = lValores(0).ToString(formato)
                btnLeerPuerto.Enabled = True
                btnCapturar.Enabled = False
                btnGuardar.Enabled = False
                gbLecturas.Text = "SE PROCEDERA A LA CAPTURA DE POL"
                valorTipoLectura = TipoLectura.Pol
                Timer1.Stop()

            Case TipoLectura.Pol
                Me.lblPOL.Text = lValores(0).ToString(formato)
                Me.lblPOL_Lectura.Text = lValores(1).ToString
                btnCapturar.Enabled = False
                btnGuardar.Enabled = True
                Timer1.Stop()
        End Select

    End Sub

    Private Function ProcesarCapturaPolBrix(ByVal lst As ListBox) As String
        If lst.Items.Count > 0 Then
            Dim s As New StringBuilder
            For i As Int32 = 0 To lst.Items.Count - 1
                s.Append(lst.Items(i))
            Next
            If Strings.Left(s.ToString, 2).ToUpper = "C)" AndAlso (2 <= lst.Items.Count - 1) Then
                Return s.ToString
            End If
        End If

        Return "-"
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        RS232.Close()
        If btnGuardar.Enabled Then
            If MsgBox("¿Desea salir antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim bPrecosecha As New cANALISIS_PRECOSECHA
        Dim lRet As Integer

        Select Case valorTipoLectura

            Case TipoLectura.Pol_Brix
                If Me.txtPH.Text = String.Empty Then
                    MsgBox("Ingrese el PH de la muestra", MsgBoxStyle.Critical, Application.ProductName)
                    Return
                End If
                entidadPrecosecha.POL = Convert.ToDecimal(Me.lblPOL.Text)
                entidadPrecosecha.BRIX = Convert.ToDecimal(Me.lblBRIX.Text)
                entidadPrecosecha.PH = Convert.ToDecimal(Me.txtPH.Text)
                If Me.lblPOL_Lectura.Text <> "" Then entidadPrecosecha.POL_LECTURA = Convert.ToDecimal(Me.lblPOL_Lectura.Text)
                entidadPrecosecha.USUARIO_LEE_POL = configuracion.usuarioActualiza
                entidadPrecosecha.FECHA_LEE_POL = cFechaHora.ObtenerFechaHora
                entidadPrecosecha.USUARIO_LEE_BRIX = configuracion.usuarioActualiza
                entidadPrecosecha.FECHA_LEE_BRIX = cFechaHora.ObtenerFechaHora
                lRet = bPrecosecha.ActualizarANALISIS_PRECOSECHA(entidadPrecosecha)

            Case TipoLectura.Pol
                If Me.txtPH.Text = String.Empty AndAlso (Me.lblPOL.Text <> String.Empty AndAlso Me.lblBRIX.Text <> String.Empty) Then
                    MsgBox("Ingrese el PH de la muestra", MsgBoxStyle.Critical, Application.ProductName)
                    Return
                End If
                entidadPrecosecha.BRIX = Convert.ToDecimal(Me.lblBRIX.Text)
                entidadPrecosecha.POL = Convert.ToDecimal(Me.lblPOL.Text)
                entidadPrecosecha.PH = Convert.ToDecimal(Me.txtPH.Text)
                If Me.lblPOL_Lectura.Text <> "" Then entidadPrecosecha.POL_LECTURA = Convert.ToDecimal(Me.lblPOL_Lectura.Text)
                entidadPrecosecha.USUARIO_LEE_BRIX = configuracion.usuarioActualiza
                entidadPrecosecha.FECHA_LEE_BRIX = cFechaHora.ObtenerFechaHora
                entidadPrecosecha.USUARIO_LEE_POL = configuracion.usuarioActualiza
                entidadPrecosecha.FECHA_LEE_POL = cFechaHora.ObtenerFechaHora
                lRet = bPrecosecha.ActualizarANALISIS_PRECOSECHA(entidadPrecosecha)
        End Select

        If lRet > 0 Then
            Me.btnGuardar.Enabled = False
            MsgBox("La información se guardo con éxito!", MsgBoxStyle.Exclamation, Application.ProductName)
            Me.btnNuevo_Click(Me, e)
        Else
            MsgBox("Error al guardar captura: " + bPrecosecha.sError, MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Private Sub MostrarVariablesPolBrixAnalisis(ByVal modo As Boolean)
        etPolAjustado.Visible = modo
        lblPOL.Visible = modo
        etBrix.Visible = modo
        lblBRIX.Visible = modo
        etPH.Visible = modo
        txtPH.Visible = modo
        txtPH.Enabled = False
        If entidadPrecosecha IsNot Nothing AndAlso (entidadPrecosecha.POL = -1 OrElse entidadPrecosecha.BRIX = -1) Then
            txtPH.Enabled = True
        End If
    End Sub

    Private Sub txtTACO_TextChanged(sender As Object, e As EventArgs) Handles txtTACO.TextChanged

    End Sub

    'Private Function ObtenerBRIX_REFRACTOMETRO() As String
    '    Dim dt As New DS_DS1.SampleDataTable
    '    Dim adapter As New DS_DS1TableAdapters.SampleTableAdapter
    '    Dim lRet As String = "No se encontró BRIX para el N° de Orden"

    '    Try
    '        adapter.Fill(dt, Me.txtTACO.Text)
    '        If dt.Rows.Count > 0 Then
    '            If dt.Rows(0)(0) IsNot Nothing Then
    '                If IsNumeric(dt(0)) Then lRet = CStr(dt.Rows(0)(0))
    '            End If
    '        End If
    '        Return lRet

    '    Catch ex As Exception
    '        ExceptionManager.Publish(ex)
    '        Return ex.Message
    '    End Try
    'End Function
End Class