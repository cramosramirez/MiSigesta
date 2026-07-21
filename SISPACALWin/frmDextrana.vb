Public Class frmDextrana
    Private IdZafraActiva As Integer
    Private entidadEnvio As ENVIO
    Private entidadDatosLab As DATOS_LABORATORIO
    Private cambioDatos As Boolean = False

    Private Sub frmDextrana_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If btnGuardar.Enabled AndAlso cambioDatos Then
            If MsgBox("¿Desea salir antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        Me.Close()
    End Sub

    'Procedimiento que establece la Zafra activa
    Private Sub ZafraActiva()
        Dim lZafra As ZAFRA
        lZafra = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            IdZafraActiva = lZafra.ID_ZAFRA
        Else
            MsgBox("No se encontró una Zafra activa", MsgBoxStyle.Critical, Application.ProductName)
            Application.Exit()
        End If
    End Sub

    Private Sub validarCamposNumericos(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
            Handles txtABSORBANCIA.Validating

        cambioDatos = True
        Dim campo As TextBox = CType(sender, TextBox)
        campo.Text = campo.Text.Trim
        If Not IsNumeric(campo.Text) AndAlso campo.Text <> String.Empty Then
            If campo Is txtABSORBANCIA Then
                lblDEXTRANA.Text = String.Empty
            End If
            e.Cancel = True
            MsgBox("Se requiere un valor numérico.", vbCritical, Application.ProductName)
            campo.SelectAll()
            campo.Focus()
            Exit Sub
        End If
        If campo.Name = "txtABSORBANCIA" Then
            If Convert.ToDecimal(txtABSORBANCIA.Text) < 0 OrElse Convert.ToDecimal(txtABSORBANCIA.Text) > 2 Then
                MsgBox("El rango de absorbancia debe estar entre 0 y 2.", vbCritical, Application.ProductName)
                campo.SelectAll()
                campo.Focus()
                Exit Sub
            End If
            If txtABSORBANCIA.Text <> String.Empty Then lblDEXTRANA.Text = Math.Round(1615.3276D * Convert.ToDecimal(txtABSORBANCIA.Text) + 92.2032D, 2) Else lblDEXTRANA.Text = String.Empty
        End If
    End Sub

    Private Sub txtTACO_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTACO.Validating
        Dim Envios As listaENVIO
        Dim lAnalisis As listaANALISIS

        entidadDatosLab = New DATOS_LABORATORIO
        txtTACO.Text = txtTACO.Text.Trim
        If txtTACO.Text.Length = 0 OrElse Not IsNumeric(txtTACO.Text) Then
            txtTACO.Text = String.Empty
            Return
        End If
        Envios = (New cENVIO).ObtenerListaPorBOLETA(IdZafraActiva, Convert.ToInt32(txtTACO.Text))
        If Envios IsNot Nothing AndAlso Envios.Count = 1 Then
            entidadEnvio = Envios(0)
            lAnalisis = (New cANALISIS).ObtenerListaPorENVIO(entidadEnvio.ID_ENVIO)
            If lAnalisis IsNot Nothing AndAlso lAnalisis.Count > 0 Then
                Dim listaDatos As listaDATOS_LABORATORIO = (New cDATOS_LABORATORIO).ObtenerListaPorANALISIS(lAnalisis(0).ID_ANALISIS)
                If listaDatos IsNot Nothing AndAlso listaDatos.Count > 0 Then
                    entidadDatosLab = listaDatos(0)
                    If entidadDatosLab.ABSORVANCIA > -1 Then txtABSORBANCIA.Text = entidadDatosLab.ABSORVANCIA.ToString("#,##0.000")
                    If entidadDatosLab.DEXTRANA > -1 Then lblDEXTRANA.Text = entidadDatosLab.DEXTRANA.ToString("#,##0.00")
                Else
                    entidadDatosLab.ID_DATOS_LAB = 0
                    entidadDatosLab.ID_ANALISIS = lAnalisis(0).ID_ANALISIS
                End If

                txtTACO.Enabled = False
                btnNuevo.Enabled = True
                btnGuardar.Enabled = True
                txtABSORBANCIA.Enabled = True
                txtABSORBANCIA.Focus()
            Else
                MsgBox("El taco " + txtTACO.Text + " no tiene asociado capturas de peso, pol y brix", MsgBoxStyle.Critical, Application.ProductName)
                txtTACO.Text = String.Empty
                e.Cancel = True
            End If
        Else
            MsgBox("El taco " + txtTACO.Text + " no existe para esta Zafra", MsgBoxStyle.Critical, Application.ProductName)
            txtTACO.Text = String.Empty
            e.Cancel = True
        End If
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

    Private Sub frmDextrana_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Inicializar()
        ZafraActiva()
    End Sub

    Private Sub Inicializar()
        Me.txtTACO.Text = ""
        Me.txtABSORBANCIA.Text = ""
        Me.lblDEXTRANA.Text = ""

        Me.txtTACO.Enabled = True
        Me.txtABSORBANCIA.Enabled = False

        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.txtTACO.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim lRet As Integer
        Dim bDatos As New cDATOS_LABORATORIO

        If Me.txtABSORBANCIA.Text.Trim = "" Then
            MsgBox("Ingrese el valor de ABSORBANCIA", MsgBoxStyle.Critical, Application.ProductName)
            txtABSORBANCIA.Focus()
            Exit Sub
        End If
        entidadDatosLab.ABSORVANCIA = Convert.ToDecimal(Me.txtABSORBANCIA.Text)
        entidadDatosLab.DEXTRANA = Convert.ToDecimal(Me.lblDEXTRANA.Text)

        lRet = bDatos.ActualizarDATOS_LABORATORIO(entidadDatosLab)
        If lRet > 0 Then
            Me.btnGuardar.Enabled = False
            MsgBox("La información se guardo con éxito!", MsgBoxStyle.Exclamation, Application.ProductName)
            Me.btnNuevo_Click(Me, e)
        Else
            MsgBox("Error al guardar: " + bDatos.sError, MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        If btnGuardar.Enabled AndAlso cambioDatos Then
            If MsgBox("¿Desea ingresar otro taco antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        Inicializar()
    End Sub

End Class