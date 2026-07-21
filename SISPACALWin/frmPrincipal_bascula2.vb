Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.EL.Enumeradores
Imports System.Text
Imports SISPACAL.DL

Public Class frmPrincipal_bascula2
    Private WithEvents RS232 As New System.IO.Ports.SerialPort
    Delegate Sub WriteDataDelegate(ByVal str As String)

    Private IdZafraActiva As Integer

    Private entidadEnvio As ENVIO
    Public entidadAnalisis As ANALISIS
    Public entidadDatosLab As DATOS_LABORATORIO
    Private entidadBascula As BASCULA

    Private Const formato As String = "#,##0.00"
    Private colorCaptura As System.Drawing.Color = Color.LightSkyBlue
    Private valorCapturado As TipoCaptura
    Private iniciando As Boolean = False
    Private listaTipoLectura As New listaTIPO_LECTURA
    Private cambioDatos As Boolean = False
    Private bFechaHora As New cFechaHora

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Asignar los tipos de lectura actuales que utilizar� el usuario
    Public Sub CargarTiposLectura(ByVal value As listaTIPO_LECTURA)
        Dim lTipoLectura As New TIPO_LECTURA
        listaTipoLectura = value
        lTipoLectura.ID_TIPO_LECTURA = 0
        lTipoLectura.NOMBRE_TIPO_LECTURA = " "
        listaTipoLectura.Insertar(0, lTipoLectura)

        Me.cbxTipoLectura.ValueMember = "ID_TIPO_LECTURA"
        Me.cbxTipoLectura.DisplayMember = "NOMBRE_TIPO_LECTURA"
        Me.cbxTipoLectura.DataSource = listaTipoLectura
    End Sub

    Private Enum TipoCaptura As Integer
        BagazoBruto = 1
        BagazoTara = 2
        BasculaBruto = 3
        BasculaTara = 4
        Pol_Brix = 5
        Pol = 6
        Brix = 7
        Ninguno = 8
    End Enum

    Private Sub frmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        lblTonsRecibidas.Visible = False
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        iniciando = True
        ZafraActiva()
        LimpiarCampos()
        iniciando = False
    End Sub

    Private Sub LimpiarCampos()
        txtTACO.Text = String.Empty
        txtTACO.Enabled = True
        btnNuevo.Enabled = False
        cbxTipoLectura.SelectedIndex = -1
        cbxTipoLectura.Enabled = False
        lstLecturas.Items.Clear()
        btnLeerPuerto.Enabled = False
        btnCapturar.Enabled = False
        btnGuardar.Enabled = False
        btnVerRecibo.Visible = False
        gbAnalisisLab.Visible = False
        gbBascula.Visible = False
        chkQuemaProgramada.Checked = False
        chkQuemaProgramada.Enabled = False
        chkQuemaNoProgramada.Checked = False
        chkQuemaNoProgramada.Enabled = False
        lblMADURANTE.Text = ""
        lblFECHA_APLICA_MADURANTE.Text = ""
        gReciboCana.Visible = False
        lblTipoCana.Text = ""
        lblTipoTransporte.Text = ""
        lblFechaQuema.Text = ""
        lblFechaCorta.Text = ""
        lblFechaCarga.Text = ""
        lblFechaPatio.Text = ""

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
        For Each _control As Control In Me.gbBascula.Controls
            If TypeOf (_control) Is TextBox Then
                Dim texto As TextBox = CType(_control, TextBox)
                texto.Text = ""
                texto.BackColor = Color.White
                texto.ReadOnly = True
            End If
        Next
        txtTACO.Focus()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Procedimiento que establece la Zafra activa
    Private Sub ZafraActiva()
        Dim lZafra As ZAFRA
        lZafra = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            IdZafraActiva = lZafra.ID_ZAFRA
        Else
            MsgBox("No se encontro una Zafra activa", MsgBoxStyle.Critical, Application.ProductName)
            Application.Exit()
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Procedimiento que cierra la conexi�n con el puerto serial COM RS232
    Private Sub CerrarPuerto()
        If RS232 IsNot Nothing AndAlso RS232.IsOpen Then
            RS232.Close()
        End If
        'Timer1.Stop()
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

    Private Sub txtTACO_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTACO.Validating
        Dim Envios As listaENVIO
        Dim lAnalisis As listaANALISIS
        Dim lBascula As listaBASCULA

        'gbBascula.Location = gbAnalisisLab.Location
        txtTACO.Text = txtTACO.Text.Trim
        If txtTACO.Text.Length = 0 OrElse Not IsNumeric(txtTACO.Text) Then
            txtTACO.Text = String.Empty
            Return
        End If
        Envios = (New cENVIO).ObtenerListaPorBOLETA(IdZafraActiva, Convert.ToInt32(txtTACO.Text))
        If Envios IsNot Nothing AndAlso Envios.Count = 1 Then
            entidadEnvio = Envios(0)

            Me.lblTIPO_CAÑA.Text = (New cTIPO_CANA).ObtenerTIPO_CANA(entidadEnvio.ID_TIPO_CANA).NOMBRE_CANA
            If entidadEnvio.QUEMAPROG Then
                Me.chkQuemaProgramada.Checked = True
                Me.chkQuemaNoProgramada.Checked = False
            ElseIf entidadEnvio.ID_TIPO_CANA = 27 OrElse entidadEnvio.ID_TIPO_CANA = 43 Then
                Me.chkQuemaProgramada.Checked = False
                Me.chkQuemaNoProgramada.Checked = True
            End If
            Dim lSolicitudesAplica As listaSOLIC_APLICA_LOTE = (New cSOLIC_APLICA_LOTE).ObtenerListaPorZAFRA_LOTE(entidadEnvio.ID_ZAFRA, entidadEnvio.ACCESLOTE)
            If lSolicitudesAplica IsNot Nothing AndAlso lSolicitudesAplica.Count > 0 Then
                Dim indice As Int32 = lSolicitudesAplica.Count - 1
                Me.lblMADURANTE.Text = lSolicitudesAplica(indice).NOMBRE_PRODUCTO
                Me.lblFECHA_APLICA_MADURANTE.Text = lSolicitudesAplica(indice).FECHA_APLICA.ToString("dd/MM/yyyy")
            End If

            'Obtener entidad analisis y bascula
            lBascula = (New cBASCULA).ObtenerListaPorENVIO(entidadEnvio.ID_ENVIO)
            If lBascula Is Nothing OrElse lBascula.Count = 0 Then
                entidadBascula = New BASCULA
                entidadBascula.ID_ENVIO = entidadEnvio.ID_ENVIO
            Else
                entidadBascula = lBascula(0)
                If entidadBascula.BRUTO <> -1 Then Me.txtBASCULA_BRUTO.Text = entidadBascula.BRUTO.ToString(formato)
                If entidadBascula.TARA <> -1 Then Me.txtBASCULA_TARA.Text = entidadBascula.TARA.ToString(formato)
                If entidadBascula.NETOTONEL <> -1 Then
                    Me.txtBASCULA_NETOLibras.Text = entidadBascula.NETOLIBRAS.ToString(formato)
                    Me.txtBASCULA_NETOToneladas.Text = entidadBascula.NETOTONEL.ToString(formato)
                    Me.btnVerRecibo.Visible = True
                    If entidadEnvio.NUMRECIBO_CANA = -1 Then
                        If CargarCorrelativoReciboCaña() = -1 Then
                            MsgBox("No existe numeracion de recibos activa o no hay disponibilidad de correlativos", MsgBoxStyle.Exclamation, Application.ProductName)
                        End If
                    Else
                        Me.lblReciboCana.Text = entidadEnvio.NUMRECIBO_CANA.ToString
                        Me.gReciboCana.Visible = True
                    End If
                End If
            End If

            lAnalisis = (New cANALISIS).ObtenerListaPorENVIO(entidadEnvio.ID_ENVIO)
            If lAnalisis Is Nothing OrElse lAnalisis.Count = 0 Then
                entidadAnalisis = New ANALISIS
                entidadAnalisis.ID_ENVIO = entidadEnvio.ID_ENVIO
            Else
                entidadAnalisis = lAnalisis(0)
                If entidadAnalisis.BAGAZO_BRUTO <> -1 Then Me.lblBAGAZO_BRUTO.Text = entidadAnalisis.BAGAZO_BRUTO.ToString(formato)
                If entidadAnalisis.BAGAZO_NETO <> -1 Then Me.lblBAGAZO_NETO.Text = entidadAnalisis.BAGAZO_NETO.ToString(formato)
                If entidadAnalisis.POL <> -1 Then Me.lblPOL.Text = entidadAnalisis.POL.ToString(formato)
                If entidadAnalisis.BRIX <> -1 Then Me.lblBRIX.Text = entidadAnalisis.BRIX.ToString(formato)
                If entidadAnalisis.POL_LECTURA <> -1 Then Me.lblPOL_Lectura.Text = entidadAnalisis.POL_LECTURA.ToString
                If entidadAnalisis.PH <> -1 Then Me.txtPH.Text = entidadAnalisis.PH.ToString(formato)
            End If

            If listaTipoLectura.BuscarPorId(TipoLectura.BASCULA_PESO_BRUTO) IsNot Nothing OrElse
                listaTipoLectura.BuscarPorId(TipoLectura.BASCULA_PESO_TARA) IsNot Nothing Then
                CargarInfoEnvio(entidadEnvio.ID_ENVIO)
                gbBascula.Visible = True
                gbAnalisisLab.Visible = False
            ElseIf listaTipoLectura.BuscarPorId(TipoLectura.PESO_BAGAZO) IsNot Nothing OrElse
                   listaTipoLectura.BuscarPorId(TipoLectura.POL_BRIX) IsNot Nothing OrElse
                   listaTipoLectura.BuscarPorId(TipoLectura.POL) IsNot Nothing OrElse
                   listaTipoLectura.BuscarPorId(TipoLectura.BRIX) IsNot Nothing Then

                gbAnalisisLab.Visible = True
                gbBascula.Visible = False
                If listaTipoLectura.BuscarPorId(TipoLectura.POL_BRIX) IsNot Nothing OrElse
                   listaTipoLectura.BuscarPorId(TipoLectura.POL) IsNot Nothing OrElse
                   listaTipoLectura.BuscarPorId(TipoLectura.BRIX) IsNot Nothing Then
                    Me.MostrarVariablesPolBrixAnalisis(True)
                End If
            End If

            txtTACO.Enabled = False
            btnNuevo.Enabled = True
            cbxTipoLectura.Enabled = True
            If cbxTipoLectura.Items.Count > 0 Then cbxTipoLectura.SelectedIndex = 1
            cbxTipoLectura.Focus()
        Else
            MsgBox("El taco " + txtTACO.Text + " no existe para esta Zafra", MsgBoxStyle.Critical, Application.ProductName)
            txtTACO.Text = String.Empty
            e.Cancel = True
        End If
    End Sub

    Private Sub CargarInfoEnvio(ByVal ID_ENVIO As Integer)
        Dim lEnvio As ENVIO = (New cENVIO).ObtenerENVIO(ID_ENVIO)
        If lEnvio IsNot Nothing Then
            lblTipoCana.Text = (New cTIPO_CANA).ObtenerTIPO_CANA(lEnvio.ID_TIPO_CANA).NOMBRE_CANA
            lblTipoTransporte.Text = (New cTIPO_TRANSPORTE).ObtenerTIPO_TRANSPORTE(lEnvio.ID_TIPOTRANS).NOMBRE
            lblFechaQuema.Text = lEnvio.FECHA_QUEMA.ToString("dd/MM/yyyy hh:mm tt")
            lblFechaCorta.Text = lEnvio.FECHA_CORTA.ToString("dd/MM/yyyy hh:mm tt")
            lblFechaCarga.Text = lEnvio.FECHA_CARGA.ToString("dd/MM/yyyy hh:mm tt")
            lblFechaPatio.Text = lEnvio.FECHA_PATIO.ToString("dd/MM/yyyy hh:mm tt")
        Else
            lblTipoCana.Text = ""
            lblTipoTransporte.Text = ""
            lblFechaQuema.Text = ""
            lblFechaCorta.Text = ""
            lblFechaCarga.Text = ""
            lblFechaPatio.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        CerrarPuerto()
        Me.Close()
    End Sub

    Private Sub MostrarVariablesPolBrixAnalisis(ByVal modo As Boolean)
        etPolAjustado.Visible = modo
        lblPOL.Visible = modo
        etBrix.Visible = modo
        lblBRIX.Visible = modo
        etPH.Visible = modo
        txtPH.Visible = modo
        txtPH.Enabled = False
        If entidadAnalisis IsNot Nothing AndAlso (entidadAnalisis.POL = -1 OrElse entidadAnalisis.BRIX = -1) Then
            txtPH.Enabled = True
        End If
    End Sub

    Private Function CargarCorrelativoReciboCaña() As Integer
        Dim lProximoNoRecibo As Integer = (New cRECIBO_CANA_NUMERACION).ObtenerProximoNUMRECIBO_CANA

        If lProximoNoRecibo <> -1 Then
            Me.lblReciboCana.Text = lProximoNoRecibo
        Else
            Me.lblReciboCana.Text = ""
        End If
        gReciboCana.Visible = True
        Return lProximoNoRecibo
    End Function

    Private Sub cbxTipoLectura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoLectura.SelectedValueChanged
        If cbxTipoLectura.SelectedValue IsNot Nothing AndAlso cbxTipoLectura.SelectedValue <> -1 AndAlso Not iniciando Then
            valorCapturado = TipoCaptura.Ninguno
            If listaTipoLectura.BuscarPorId(TipoLectura.POL_BRIX) Is Nothing OrElse
                   listaTipoLectura.BuscarPorId(TipoLectura.POL) Is Nothing Then
                MostrarVariablesPolBrixAnalisis(False)
            End If
            btnLeerPuerto.Enabled = False

            If cbxTipoLectura.SelectedValue = 0 Then
                Return
            End If

            If cbxTipoLectura.SelectedValue = TipoLectura.BASCULA_PESO_BRUTO OrElse cbxTipoLectura.SelectedValue = TipoLectura.BASCULA_PESO_TARA Then
                If cbxTipoLectura.SelectedValue = TipoLectura.BASCULA_PESO_BRUTO AndAlso entidadBascula.BRUTO <> -1 Then
                    MsgBox("El peso bruto ya se capturo", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If cbxTipoLectura.SelectedValue = TipoLectura.BASCULA_PESO_TARA AndAlso entidadBascula.TARA <> -1 Then
                    MsgBox("El peso tara ya se capturo", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If cbxTipoLectura.SelectedValue = TipoLectura.BASCULA_PESO_TARA AndAlso entidadBascula.ID_BASCULA = 0 Then
                    MsgBox("Capture el peso bruto antes de capturar el peso tara", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                Dim bReciboCanaNumeracion As New cRECIBO_CANA_NUMERACION
                If cbxTipoLectura.SelectedValue = TipoLectura.BASCULA_PESO_TARA AndAlso Not bReciboCanaNumeracion.ExisteNumeracionReciboCana Then
                    MsgBox("Numeracion de Recibos de Caña no esta habilitada o no hay disponibilidad de correlativos", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If

                If entidadBascula.ID_BASCULA = 0 Then
                    Me.txtBASCULA_BRUTO.BackColor = colorCaptura
                    valorCapturado = TipoCaptura.BasculaBruto
                Else
                    If CargarCorrelativoReciboCaña() = -1 Then
                        MsgBox("No existe numeracion de recibos activa o no hay disponibilidad de correlativos", MsgBoxStyle.Exclamation, Application.ProductName)
                        cbxTipoLectura.SelectedValue = 0
                        Return
                    End If
                    Me.txtBASCULA_TARA.BackColor = colorCaptura
                    valorCapturado = TipoCaptura.BasculaTara
                End If

                gbBascula.Visible = True
                gbAnalisisLab.Visible = False
            Else
                If cbxTipoLectura.SelectedValue = TipoLectura.PESO_BAGAZO AndAlso (entidadAnalisis.BAGAZO_BRUTO <> -1 AndAlso entidadAnalisis.BAGAZO_NETO <> -1) Then
                    MsgBox("El peso del bagazo ha sido capturado", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If Not cbxTipoLectura.SelectedValue = TipoLectura.PESO_BAGAZO AndAlso (entidadAnalisis.BAGAZO_BRUTO = -1 OrElse entidadAnalisis.BAGAZO_NETO = -1) Then
                    MsgBox("Capture el peso del bagazo antes de capturar POL/BRIX", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If cbxTipoLectura.SelectedValue = TipoLectura.POL_BRIX AndAlso entidadAnalisis.POL <> -1 AndAlso entidadAnalisis.BRIX <> -1 Then
                    MsgBox("El POL/BRIX han sido capturados", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If cbxTipoLectura.SelectedValue = TipoLectura.POL AndAlso entidadAnalisis.POL <> -1 Then
                    MsgBox("El POL ha sido capturado", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If cbxTipoLectura.SelectedValue = TipoLectura.BRIX AndAlso entidadAnalisis.BRIX <> -1 Then
                    MsgBox("El BRIX ha sido capturado", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If
                If cbxTipoLectura.SelectedValue = TipoLectura.POL AndAlso entidadAnalisis.BRIX = -1 Then
                    MsgBox("Capture el BRIX antes de capturar el POL para calcular el POL CORREGIDO", MsgBoxStyle.Critical, Application.ProductName)
                    cbxTipoLectura.SelectedValue = 0
                    Return
                End If

                Select Case cbxTipoLectura.SelectedValue
                    Case TipoLectura.PESO_BAGAZO
                        If entidadAnalisis.BAGAZO_BRUTO = -1 Then
                            Me.lblBAGAZO_BRUTO.BackColor = colorCaptura
                            valorCapturado = TipoCaptura.BagazoBruto
                        ElseIf entidadAnalisis.BAGAZO_NETO = -1 Then
                            Me.lblBAGAZO_NETO.BackColor = colorCaptura
                            valorCapturado = TipoCaptura.BagazoTara
                        End If
                    Case TipoLectura.POL_BRIX
                        Me.lblPOL.BackColor = colorCaptura
                        Me.lblBRIX.BackColor = colorCaptura
                        valorCapturado = TipoCaptura.Pol_Brix
                    Case TipoLectura.POL
                        Me.lblPOL.BackColor = colorCaptura
                        valorCapturado = TipoCaptura.Pol
                    Case TipoLectura.BRIX
                        Me.lblBRIX.BackColor = colorCaptura
                        valorCapturado = TipoCaptura.Brix
                End Select

                If cbxTipoLectura.SelectedValue = TipoLectura.POL_BRIX OrElse
                    cbxTipoLectura.SelectedValue = TipoLectura.POL OrElse
                    cbxTipoLectura.SelectedValue = TipoLectura.BRIX Then
                    MostrarVariablesPolBrixAnalisis(True)
                End If
                gbAnalisisLab.Visible = True
                gbBascula.Visible = False
            End If
            btnLeerPuerto.Enabled = True
        End If
    End Sub

    Private Sub btnLeerPuerto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerPuerto.Click
        Try
            Me.btnCapturar.Enabled = False
            If cbxTipoLectura.SelectedValue IsNot Nothing Then
                Dim lTipoLectura As TIPO_LECTURA = (New cTIPO_LECTURA).ObtenerTIPO_LECTURA(CInt(cbxTipoLectura.SelectedValue))
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
                    RS232 = My.Computer.Ports.OpenSerialPort(lEquipo.PUERTO, Convert.ToInt32(lEquipo.BITS_POR_SEGUNDO), paridad, Convert.ToInt32(lEquipo.BITS_DATOS), bitsParada)
                    btnLeerPuerto.Enabled = False
                    cbxTipoLectura.Enabled = False

                    If valorCapturado = TipoCaptura.BasculaBruto OrElse valorCapturado = TipoCaptura.BasculaTara Then
                        If My.Computer.FileSystem.FileExists("c://bascula/bascula.txt") Then
                            My.Computer.FileSystem.DeleteFile("C:\bascula\bascula.txt")
                        End If
                        RS232.RtsEnable = True
                    End If
                    If lEquipo.ID_EQUIPO = 2 OrElse valorCapturado = TipoCaptura.Brix Then Timer1.Start()
                End If
            Else
                MsgBox("Seleccione un tipo de lectura ", vbCritical, Application.ProductName)
            End If

        Catch ex As System.IO.IOException
            ExceptionManager.Publish(ex)
            MsgBox("Error abriendo el puerto: " & ex.Message)
        Catch ex As System.UnauthorizedAccessException
            ExceptionManager.Publish(ex)
            MsgBox("El pueto ya esta abierto: " & ex.Message)
        Catch ex As System.Exception
            ExceptionManager.Publish(ex)
            MsgBox("Error general accediendo al puerto: " & ex.Message)
        End Try
    End Sub

    Private Sub RS232_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles RS232.DataReceived
        Dim strData As String = RS232.ReadExisting
        Dim WriteInvoke As New WriteDataDelegate(AddressOf Me.WriteData)
        Me.Invoke(WriteInvoke, strData)
    End Sub

    Private Sub WriteData(ByVal str As String)
        If valorCapturado = TipoCaptura.BasculaBruto OrElse valorCapturado = TipoCaptura.BasculaTara Then
            My.Computer.FileSystem.WriteAllText("C://bascula/bascula.txt", str, True)
        Else
            If lstLecturas.Items.Count = 4 Then
                lstLecturas.Items.RemoveAt(0)
            End If
            lstLecturas.Items.Add(str)
            lstLecturas.SelectedIndex = lstLecturas.Items.Count - 1
        End If
        btnCapturar.Enabled = True
    End Sub

    Private Function SetLecturaPolarimetro(ByVal str As String) As String
        Static c As String = ""
        Dim c_aux As String = ""

        ExceptionManager.Publish(New Exception(str))
        If Strings.Left(str, 3).ToUpper = "ISS" Then
            If c = "" Then
                c = str
            Else
                c_aux = c
                c = str
            End If
        ElseIf c <> "" Then
            c = c + str
        End If
        Return c_aux
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim bBascula As New cBASCULA
        Dim bAnalisis As New cANALISIS
        Dim bDatosLab As New cDATOS_LABORATORIO
        Dim lRet As Integer
        Dim mError As String = ""

        Select Case valorCapturado
            Case TipoCaptura.BasculaBruto
                entidadBascula.BRUTO = Convert.ToDecimal(Me.txtBASCULA_BRUTO.Text)
                If entidadBascula.TARA <> -1 Then
                    entidadBascula.NETOLIBRAS = entidadBascula.BRUTO - entidadBascula.TARA
                    entidadBascula.NETOTONEL = Math.Round(entidadBascula.NETOLIBRAS / 1000, 2)
                End If
                entidadBascula.USUARIO_LEE_BRUTO = configuracion.usuarioActualiza
                entidadBascula.FECHA_LEE_BRUTO = cFechaHora.ObtenerFechaHora
                lRet = bBascula.ActualizarBASCULA(entidadBascula)
                mError = bBascula.sError
                Me.ActualizarTonelasdasRecibidas()

            Case TipoCaptura.BasculaTara
                entidadBascula.TARA = Convert.ToDecimal(Me.txtBASCULA_TARA.Text)
                If entidadBascula.BRUTO <> -1 Then
                    Dim lProximoNumRecibo As Integer = (New cRECIBO_CANA_NUMERACION).ObtenerProximoNUMRECIBO_CANA

                    If lProximoNumRecibo = -1 Then
                        Me.lblReciboCana.Text = ""
                        MsgBox("Numeracion de Recibos de Caña no esta habilitada o no hay disponibilidad de correlativos. No es posible guardar", MsgBoxStyle.Critical, Application.ProductName)
                        Return
                    End If
                    If lProximoNumRecibo <> Convert.ToInt32(Me.lblReciboCana.Text) Then
                        If MsgBox("El No de Recibo ya no esta disponible. El nuevo numero es: " + lProximoNumRecibo.ToString + ". Desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, Application.ProductName) = MsgBoxResult.No Then
                            Return
                        End If
                        Me.lblReciboCana.Text = lProximoNumRecibo
                    End If
                    entidadBascula.NETOLIBRAS = entidadBascula.BRUTO - entidadBascula.TARA
                    entidadBascula.NETOTONEL = Math.Round(entidadBascula.NETOLIBRAS / 1000, 2)
                End If
                entidadBascula.USUARIO_LEE_TARA = configuracion.usuarioActualiza
                entidadBascula.FECHA_LEE_TARA = cFechaHora.ObtenerFechaHora
                lRet = bBascula.ActualizarBASCULA(entidadBascula)
                mError = bBascula.sError
                Me.ActualizarTonelasdasRecibidas()

            Case TipoCaptura.BagazoBruto
                entidadAnalisis.BAGAZO_BRUTO = Convert.ToDecimal(Me.lblBAGAZO_BRUTO.Text)
                entidadAnalisis.USUARIO_LEE_BAGAZO_BRUTO = configuracion.usuarioActualiza
                entidadAnalisis.FECHA_LEE_BAGAZO_BRUTO = cFechaHora.ObtenerFechaHora
                lRet = bAnalisis.ActualizarANALISIS(entidadAnalisis)

            Case TipoCaptura.BagazoTara
                entidadAnalisis.BAGAZO_NETO = Convert.ToDecimal(Me.lblBAGAZO_NETO.Text)
                entidadAnalisis.USUARIO_LEE_BAGAZO_TARA = configuracion.usuarioActualiza
                entidadAnalisis.FECHA_LEE_BAGAZO_TARA = cFechaHora.ObtenerFechaHora
                lRet = bAnalisis.ActualizarANALISIS(entidadAnalisis)

            Case TipoCaptura.Pol_Brix
                If Me.txtPH.Text = String.Empty Then
                    MsgBox("Ingrese el PH de la muestra", MsgBoxStyle.Critical, Application.ProductName)
                    Return
                End If
                entidadAnalisis.POL = Convert.ToDecimal(Me.lblPOL.Text)
                entidadAnalisis.BRIX = Convert.ToDecimal(Me.lblBRIX.Text)
                entidadAnalisis.PH = Convert.ToDecimal(Me.txtPH.Text)
                If Me.lblPOL_Lectura.Text <> "" Then entidadAnalisis.POL_LECTURA = Convert.ToDecimal(Me.lblPOL_Lectura.Text)
                entidadAnalisis.USUARIO_LEE_POL = configuracion.usuarioActualiza
                entidadAnalisis.FECHA_LEE_POL = cFechaHora.ObtenerFechaHora
                entidadAnalisis.USUARIO_LEE_BRIX = configuracion.usuarioActualiza
                entidadAnalisis.FECHA_LEE_BRIX = cFechaHora.ObtenerFechaHora
                lRet = bAnalisis.ActualizarANALISIS(entidadAnalisis)

            Case TipoCaptura.Pol
                If Me.txtPH.Text = String.Empty AndAlso (Me.lblPOL.Text <> String.Empty AndAlso Me.lblBRIX.Text <> String.Empty) Then
                    MsgBox("Ingrese el PH de la muestra", MsgBoxStyle.Critical, Application.ProductName)
                    Return
                End If
                entidadAnalisis.POL = Convert.ToDecimal(Me.lblPOL.Text)
                entidadAnalisis.PH = Convert.ToDecimal(Me.txtPH.Text)
                entidadAnalisis.USUARIO_LEE_POL = configuracion.usuarioActualiza
                entidadAnalisis.FECHA_LEE_POL = cFechaHora.ObtenerFechaHora
                lRet = bAnalisis.ActualizarANALISIS(entidadAnalisis)

            Case TipoCaptura.Brix
                If Me.txtPH.Text = String.Empty AndAlso (Me.lblPOL.Text <> String.Empty AndAlso Me.lblBRIX.Text <> String.Empty) Then
                    MsgBox("Ingrese el PH de la muestra", MsgBoxStyle.Critical, Application.ProductName)
                    Return
                End If
                entidadAnalisis.BRIX = Convert.ToDecimal(Me.lblBRIX.Text)
                entidadAnalisis.PH = Convert.ToDecimal(Me.txtPH.Text)
                entidadAnalisis.USUARIO_LEE_BRIX = configuracion.usuarioActualiza
                entidadAnalisis.FECHA_LEE_BRIX = cFechaHora.ObtenerFechaHora
                lRet = bAnalisis.ActualizarANALISIS(entidadAnalisis)
        End Select

        If lRet > 0 Then
            Me.btnGuardar.Enabled = False
            If valorCapturado = TipoCaptura.BasculaTara Then
                'Asignar n�mero de recibo al env�o
                If CargarCorrelativoReciboCaña() = -1 Then
                    MsgBox("No existe numeracion de recibos activa o no hay disponibilidad de correlativos", MsgBoxStyle.Exclamation, Application.ProductName)
                    Return
                End If
                If AsignarCorrelativoReciboCaña() = -1 Then
                    Return
                End If
                btnVerRecibo_Click(Me, e)
            Else
                MsgBox("La informacion se guardo con exito!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.btnNuevo_Click(Me, e)
            End If
        Else
            MsgBox("Error al guardar captura: " + mError, MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Public Sub ActualizarTonelasdasRecibidas()
        lblTonsRecibidas.Visible = True
        lblTonsRecibidas.Text = "Toneladas recibidas del dia: " + (New cBASCULA).ObtenerToneladasSinCorte.ToString("#,##0.00")
    End Sub

    Private Function AsignarCorrelativoReciboCaña() As Integer
        'Asignar n�mero de recibo al env�o
        Dim lReciboCana As RECIBO_CANA_NUMERACION
        Dim bReciboCana As New cRECIBO_CANA_NUMERACION
        Dim lEnvio As ENVIO
        Dim bEnvio As New cENVIO
        Dim lRet As Integer

        Try
            lReciboCana = bReciboCana.ObtenerReciboCanaActivo
            If lReciboCana IsNot Nothing Then
                lEnvio = bEnvio.ObtenerENVIO(entidadBascula.ID_ENVIO)
                lEnvio.NUMRECIBO_CANA = Convert.ToInt32(Me.lblReciboCana.Text)
                lEnvio.USUARIO_ACT = configuracion.usuarioActualiza
                lEnvio.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lRet = bEnvio.ActualizarENVIO(lEnvio)
                If lRet < 1 Then
                    MsgBox(bEnvio.sError, MsgBoxStyle.Critical, Application.ProductName)
                    Return -1
                End If

                lReciboCana.ULT_NUM_ASIGNADO = Convert.ToInt32(Me.lblReciboCana.Text)
                lReciboCana.USUARIO_ACT = configuracion.usuarioActualiza
                lReciboCana.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lRet = bReciboCana.ActualizarRECIBO_CANA_NUMERACION(lReciboCana)
            Else
                MsgBox("Numeracion de Recibos de Caña no esta habilitada o no hay disponibilidad de correlativos", MsgBoxStyle.Exclamation, Application.ProductName)
                Return -1
            End If
            Return lRet

        Catch ex As Exception
            MsgBox("Error al actualizar correlativo de recibo", MsgBoxStyle.Critical, Application.ProductName)
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If valorCapturado = TipoCaptura.Brix Then
            If lstLecturas.Items.Count = 4 Then
                lstLecturas.Items.RemoveAt(0)
            End If
            lstLecturas.Items.Add(Me.ObtenerBRIX_REFRACTOMETRO)
            lstLecturas.SelectedIndex = lstLecturas.Items.Count - 1
            btnCapturar.Enabled = True
        Else
            If RS232.IsOpen Then
                RS232.NewLine = vbCrLf
                RS232.WriteLine("r")
            End If
        End If
    End Sub


    'Private Function ProcesarCapturaPolBrix(ByVal lst As ListBox) As String
    '    If lst.Items.Count > 0 Then
    '        For i As Int32 = 0 To lst.Items.Count - 1
    '            If Strings.Left(lst.Items(i), 3).ToUpper = "ISS" AndAlso (i + 2 <= lst.Items.Count - 1) Then
    '                Return lst.Items(i) + lst.Items(i + 1) + lst.Items(i + 2)
    '            End If
    '        Next
    '    End If

    '    Return "-"
    'End Function

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


    Private Sub btnCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturar.Click
        RS232.Close()
        'lstLecturas.Items.Add("ISS-26 (TC),�Z,0.01,RI Brix,%Brix,0.14") '**************
        Dim bEquipo As New cEQUIPO_MEDICION
        Dim lTipoLectura As TIPO_LECTURA
        Dim lValores As List(Of Decimal)
        Dim sLecturaPolBrix As String = ""

        If valorCapturado = TipoCaptura.BasculaBruto OrElse valorCapturado = TipoCaptura.BasculaTara Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("C:\bascula\bascula.txt")
            fileReader = Trim(Mid(fileReader, 1, 8))
            'fileReader = Strings.Right(fileReader, 14)
            'fileReader = Strings.Replace(fileReader, "`", " ")
            'fileReader = Mid(fileReader, 1, fileReader.Length - 3).Trim
            lstLecturas.Items.Add(fileReader)
        End If

        If valorCapturado = TipoCaptura.Pol_Brix Then
            sLecturaPolBrix = ProcesarCapturaPolBrix(lstLecturas)
        End If

        If lstLecturas.Items.Count = 0 Then
            MsgBox("No se ha realizado lectura correcta del equipo", MsgBoxStyle.Critical, Application.ProductName)
            btnLeerPuerto_Click(Me, e)
            Exit Sub
        End If
        If sLecturaPolBrix = "-" Then
            MsgBox("No se ha realizado lectura correcta de Pol y Brix", MsgBoxStyle.Critical, Application.ProductName)
            btnLeerPuerto_Click(Me, e)
            Exit Sub
        End If

        lTipoLectura = (New cTIPO_LECTURA).ObtenerTIPO_LECTURA(cbxTipoLectura.SelectedValue)
        If valorCapturado = TipoCaptura.Pol AndAlso Me.lblBRIX.Text <> "" AndAlso IsNumeric(Me.lblBRIX.Text) AndAlso Convert.ToDecimal(Me.lblBRIX.Text) > 0 Then
            lValores = bEquipo.ProcesarLectura(lTipoLectura.ID_EQUIPO, lstLecturas.Items(lstLecturas.Items.Count - 1), Convert.ToDecimal(Me.lblBRIX.Text))
        ElseIf valorCapturado = TipoCaptura.Pol_Brix Then
            lValores = bEquipo.ProcesarLectura(lTipoLectura.ID_EQUIPO, sLecturaPolBrix)
        Else
            lValores = bEquipo.ProcesarLectura(lTipoLectura.ID_EQUIPO, lstLecturas.Items(lstLecturas.Items.Count - 1))
        End If

        If lValores Is Nothing OrElse lValores.Count = 0 Then
            MsgBox("No se logro procesar la lectura del equipo. Vuelva a realizar la captura", MsgBoxStyle.Critical, Application.ProductName)
            btnLeerPuerto_Click(Me, e)
            Exit Sub
        End If

        Select Case valorCapturado
            Case TipoCaptura.BasculaBruto
                If lValores(0) = 0D Then
                    MsgBox("El peso bruto no puede ser cero", MsgBoxStyle.Critical, Application.ProductName)
                    btnLeerPuerto_Click(Me, e)
                    Exit Sub
                End If
                Me.txtBASCULA_BRUTO.Text = lValores(0).ToString(formato)

            Case TipoCaptura.BasculaTara
                If lValores(0) = 0D Then
                    MsgBox("El peso tara no puede ser cero", MsgBoxStyle.Critical, Application.ProductName)
                    btnLeerPuerto_Click(Me, e)
                    Exit Sub
                End If
                If lValores(0) > Convert.ToDecimal(Me.txtBASCULA_BRUTO.Text) Then
                    MsgBox("El peso tara no puede ser mayor que peso bruto", MsgBoxStyle.Critical, Application.ProductName)
                    btnLeerPuerto_Click(Me, e)
                    Exit Sub
                End If
                Me.txtBASCULA_TARA.Text = lValores(0).ToString(formato)
                Me.txtBASCULA_NETOLibras.Text = Math.Round(Convert.ToDecimal(Me.txtBASCULA_BRUTO.Text) - Convert.ToDecimal(Me.txtBASCULA_TARA.Text), 2)
                Me.txtBASCULA_NETOToneladas.Text = Math.Round((Convert.ToDecimal(Me.txtBASCULA_BRUTO.Text) - Convert.ToDecimal(Me.txtBASCULA_TARA.Text)) / 1000, 2)

            Case TipoCaptura.BagazoBruto
                If Not (lValores(0) >= 500D AndAlso lValores(0) <= 501D) Then
                    MsgBox("El peso de la torta debe estar comprendido entre 500 y 501 gramos", MsgBoxStyle.Critical, Application.ProductName)
                    btnLeerPuerto_Click(Me, e)
                    Return
                End If
                Me.lblBAGAZO_BRUTO.Text = lValores(0).ToString(formato)

            Case TipoCaptura.BagazoTara
                If lValores(0) > Convert.ToDecimal(Me.lblBAGAZO_BRUTO.Text) Then
                    MsgBox("El peso de la torta no puede ser mayor que peso bagazo", MsgBoxStyle.Critical, Application.ProductName)
                    btnLeerPuerto_Click(Me, e)
                    Exit Sub
                End If
                If Not (lValores(0) >= 90D AndAlso lValores(0) <= 200D) Then
                    MsgBox("El peso de la torta debe estar comprendido entre 90 y 200 gramos", MsgBoxStyle.Critical, Application.ProductName)
                    btnLeerPuerto_Click(Me, e)
                    Exit Sub
                End If
                Me.lblBAGAZO_NETO.Text = lValores(0).ToString(formato)


            Case TipoCaptura.Pol_Brix
                Me.lblPOL.Text = lValores(0).ToString(formato)
                Me.lblBRIX.Text = lValores(1).ToString(formato)
                Me.lblPOL_Lectura.Text = lValores(2).ToString

            Case TipoCaptura.Pol
                If lValores.Count = 2 Then
                    Me.lblPOL.Text = lValores(0).ToString(formato)
                    Me.lblPOL_Lectura.Text = lValores(1).ToString(formato)
                Else
                    Me.lblPOL.Text = lValores(0).ToString(formato)
                End If

            Case TipoCaptura.Brix
                Me.lblBRIX.Text = lValores(0).ToString(formato)
        End Select
        btnCapturar.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Public Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        RS232.Close()
        If btnGuardar.Enabled Then
            If MsgBox("Desea salir antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        LimpiarCampos()
    End Sub

    Private Sub validarCamposNumericos(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
              Handles txtPH.Validating

        Dim campo As TextBox = CType(sender, TextBox)
        campo.Text = campo.Text.Trim
        If Not IsNumeric(campo.Text) AndAlso campo.Text <> String.Empty Then
            e.Cancel = True
            MsgBox("Se requiere un valor numerico.", vbCritical, Application.ProductName)
            campo.SelectAll()
            campo.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnDatosLaboratorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMateriaExtrana.ShowDialog()
    End Sub

    Private Sub btnVerRecibo_Click(sender As System.Object, e As System.EventArgs) Handles btnVerRecibo.Click
        'Mostrar recibo de caña
        entidadEnvio = (New cENVIO).ObtenerENVIO(entidadBascula.ID_ENVIO)
        If entidadEnvio IsNot Nothing AndAlso entidadEnvio.NUMRECIBO_CANA = -1 AndAlso entidadBascula.TARA > 0 Then
            If CargarCorrelativoReciboCaña() = -1 Then
                MsgBox("No existe numeracion de recibos activa o no hay disponibilidad de correlativos", MsgBoxStyle.Exclamation, Application.ProductName)
                Return
            End If
            If Me.AsignarCorrelativoReciboCaña = -1 Then
                Return
            End If
        End If
        frmReciboBascula.CargarReporte(entidadBascula.ID_ENVIO)
        frmReciboBascula.ShowDialog()
    End Sub

    Private Function ObtenerBRIX_REFRACTOMETRO() As String
        Dim dt As New DS_DS1.SampleDataTable
        Dim adapter As New DS_DS1TableAdapters.SampleTableAdapter
        Dim lRet As String = "No se encontro BRIX para el No de Taco"

        Try
            adapter.Fill(dt, Me.txtTACO.Text)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot Nothing Then
                    If IsNumeric(dt(0)) Then lRet = CStr(dt.Rows(0)(0))
                End If
            End If
            'adapter.Connection.Close()
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return ex.Message
        End Try
    End Function

    Private Sub tmrToneladas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ActualizarTonelasdasRecibidas()
    End Sub

    Private Sub lblTonsRecibidas_Click(sender As Object, e As EventArgs) Handles lblTonsRecibidas.Click

    End Sub
End Class
