Public Class frmMateriaExtrana
    Private IdZafraActiva As Integer
    Private entidadEnvio As ENVIO
    Private entidadDatosLab As DATOS_LABORATORIO
    Private cambioDatos As Boolean = False
    Private Const formato As String = "#,##0.00"
    Private bFechaHora As New cFechaHora

    Private Function DatosLaboratorio_Completados() As Boolean
        For Each _control As Control In Me.Controls
            If TypeOf (_control) Is TextBox Then
                Dim texto As TextBox = CType(_control, TextBox)
                If texto.Tag = "MateriaExtraña" AndAlso texto.Text.Trim = "" AndAlso _
                    texto.Name <> "txtOBSERVACION" AndAlso texto.Name <> "txtACIDEZ" AndAlso _
                    texto.Name <> "txtREDUCTORES" Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub Inicializar()
        Me.txtTACO.Text = ""
        Me.txtTACO.Enabled = True
        For Each _control As Control In Me.Controls
            If TypeOf (_control) Is Label Then
                Dim etiqueta As Label = CType(_control, Label)
                If etiqueta.Tag = "%MateriaExtraña" Then
                    etiqueta.Text = ""
                    etiqueta.BackColor = Color.White
                End If
            End If
        Next
        For Each _control As Control In Me.Controls
            If TypeOf (_control) Is TextBox AndAlso CType(_control, TextBox).Tag = "MateriaExtraña" Then
                Dim texto As TextBox = CType(_control, TextBox)
                texto.Text = ""
                texto.BackColor = Color.White
                texto.Enabled = False
            End If
        Next
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.txtTACO.Focus()
    End Sub

    Private Sub HabilitarCampos(ByVal modo As Boolean)
        For Each _control As Control In Me.Controls
            If TypeOf (_control) Is TextBox AndAlso CType(_control, TextBox).Tag = "MateriaExtraña" Then
                Dim texto As TextBox = CType(_control, TextBox)
                texto.Enabled = modo
            End If
        Next
    End Sub

    Private Sub frmMateriaExtrana_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmDatosLaboratorio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        ZafraActiva()
    End Sub

    Private Sub validarCamposNumericos(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
            Handles txtLBS_MUESTRA.Validating, txtLBS_PUNTAS_TIERNA.Validating, txtLBS_CANA_SECA.Validating, _
                txtLBS_MAMONES.Validating, txtLBS_BAJERA.Validating, txtLBS_TIERRA_RAICES.Validating, _
                txtLBS_PIEDRA.Validating, txtACIDEZ.Validating, txtREDUCTORES.Validating

        Dim campo As TextBox = CType(sender, TextBox)
        campo.Text = campo.Text.Trim
        If Not IsNumeric(campo.Text) AndAlso campo.Text <> String.Empty Then
            e.Cancel = True
            MsgBox("Se requiere un valor numérico.", vbCritical, Application.ProductName)
            campo.SelectAll()
            campo.Focus()
            Exit Sub
        End If
        CalcularPorcentajesDatosLaboratorio()
    End Sub

    Private Sub CalcularPorcentajesDatosLaboratorio()
        If txtLBS_MUESTRA.Text.Trim <> "" AndAlso Convert.ToDecimal(txtLBS_MUESTRA.Text) > 0 Then
            Dim divisor As Decimal = Convert.ToDecimal(txtLBS_MUESTRA.Text)
            Dim totalPorcMateriaExtra As Decimal = -1
            Dim totalMateriaExtra As Decimal = 0

            If txtLBS_PUNTAS_TIERNA.Text <> "" Then lblPORC_PUNTAS_TIERNA.Text = Math.Round(Convert.ToDecimal(txtLBS_PUNTAS_TIERNA.Text) / divisor * 100, 2).ToString("#,##0.00") Else txtLBS_PUNTAS_TIERNA.Text = ""
            If txtLBS_CANA_SECA.Text <> "" Then lblPORC_CANA_SECA.Text = Math.Round(Convert.ToDecimal(txtLBS_CANA_SECA.Text) / divisor * 100, 2).ToString("#,##0.00") Else txtLBS_CANA_SECA.Text = ""
            If txtLBS_MAMONES.Text <> "" Then lblPORC_MAMONES.Text = Math.Round(Convert.ToDecimal(txtLBS_MAMONES.Text) / divisor * 100, 2).ToString("#,##0.00") Else txtLBS_MAMONES.Text = ""
            If txtLBS_BAJERA.Text <> "" Then lblPORC_BAJERA.Text = Math.Round(Convert.ToDecimal(txtLBS_BAJERA.Text) / divisor * 100, 2).ToString("#,##0.00") Else txtLBS_BAJERA.Text = ""
            If txtLBS_TIERRA_RAICES.Text <> "" Then lblPORC_TIERRA_RAICES.Text = Math.Round(Convert.ToDecimal(txtLBS_TIERRA_RAICES.Text) / divisor * 100, 2).ToString("#,##0.00") Else txtLBS_TIERRA_RAICES.Text = ""
            If txtLBS_PIEDRA.Text <> "" Then lblPORC_PIEDRA.Text = Math.Round(Convert.ToDecimal(txtLBS_PIEDRA.Text) / divisor * 100, 2).ToString("#,##0.00") Else txtLBS_PIEDRA.Text = ""

            For Each _control As Control In Me.Controls
                If TypeOf (_control) Is Label Then
                    Dim etiqueta As Label = CType(_control, Label)
                    If etiqueta.Tag = "%MateriaExtraña" AndAlso etiqueta.Name <> "lblLBS_CANA_LIMPIA" AndAlso etiqueta.Name <> "lblPORC_CANA_LIMPIA" AndAlso etiqueta.Text <> "" AndAlso etiqueta.Name <> "lblPORC_MATERIA_EXTRA" Then
                        If totalPorcMateriaExtra = -1 Then totalPorcMateriaExtra = 0
                        totalPorcMateriaExtra += Convert.ToDecimal(etiqueta.Text)
                    End If
                End If
            Next
            If txtLBS_PUNTAS_TIERNA.Text.Trim <> "" Then totalMateriaExtra += Convert.ToDecimal(txtLBS_PUNTAS_TIERNA.Text)
            If txtLBS_CANA_SECA.Text.Trim <> "" Then totalMateriaExtra += Convert.ToDecimal(txtLBS_CANA_SECA.Text)
            If txtLBS_MAMONES.Text.Trim <> "" Then totalMateriaExtra += Convert.ToDecimal(txtLBS_MAMONES.Text)
            If txtLBS_BAJERA.Text.Trim <> "" Then totalMateriaExtra += Convert.ToDecimal(txtLBS_BAJERA.Text)
            If txtLBS_TIERRA_RAICES.Text.Trim <> "" Then totalMateriaExtra += Convert.ToDecimal(txtLBS_TIERRA_RAICES.Text)
            If txtLBS_PIEDRA.Text.Trim <> "" Then totalMateriaExtra += Convert.ToDecimal(txtLBS_PIEDRA.Text)

            If totalPorcMateriaExtra = -1 Then
                lblPORC_MATERIA_EXTRA.Text = ""
                lblLBS_CANA_LIMPIA.Text = ""
                lblPORC_CANA_LIMPIA.Text = ""
            Else
                lblPORC_MATERIA_EXTRA.Text = totalPorcMateriaExtra.ToString("#,##0.00")
                lblLBS_CANA_LIMPIA.Text = Convert.ToDecimal(txtLBS_MUESTRA.Text) - totalMateriaExtra
                lblPORC_CANA_LIMPIA.Text = Math.Round(100 - totalPorcMateriaExtra, 2).ToString(formato)
            End If
        Else
            For Each _control As Control In Me.Controls
                If TypeOf (_control) Is Label Then
                    Dim etiqueta As Label = CType(_control, Label)
                    If etiqueta.Tag = "%MateriaExtraña" Then etiqueta.Text = ""
                End If
            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim lRet As Integer
        Dim bDatos As New cDATOS_LABORATORIO

        If txtANALISTA.Text.Trim = "" Then
            MsgBox("Ingrese el nombre del analista.", vbCritical, Application.ProductName)
            txtANALISTA.Focus()
            Return
        End If
        If Not DatosLaboratorio_Completados() Then
            MsgBox("Los datos de Materia Extraña no se han completado.", vbCritical, Application.ProductName)
            Return
        End If
        'If Me.txtACIDEZ.Text.Trim = String.Empty Then
        '    MsgBox("Ingrese el valor de Acidez.", vbCritical, Application.ProductName)
        '    txtACIDEZ.Focus()
        '    Return
        'End If
        'If Me.txtREDUCTORES.Text.Trim = String.Empty Then
        '    MsgBox("Ingrese el valor de Reductores.", vbCritical, Application.ProductName)
        '    txtREDUCTORES.Focus()
        '    Return
        'End If
        entidadDatosLab.ANALISTA = Me.txtANALISTA.Text.Trim
        If Me.txtLBS_MUESTRA.Text <> String.Empty Then entidadDatosLab.LBS_MUESTRA = Convert.ToDecimal(Me.txtLBS_MUESTRA.Text)
        If Me.txtLBS_PUNTAS_TIERNA.Text <> String.Empty Then entidadDatosLab.LBS_PUNTAS_TIERNA = Convert.ToDecimal(Me.txtLBS_PUNTAS_TIERNA.Text)
        If Me.txtLBS_CANA_SECA.Text <> String.Empty Then entidadDatosLab.LBS_CANA_SECA = Convert.ToDecimal(Me.txtLBS_CANA_SECA.Text)
        If Me.txtLBS_MAMONES.Text <> String.Empty Then entidadDatosLab.LBS_MAMONES = Convert.ToDecimal(Me.txtLBS_MAMONES.Text)
        If Me.txtLBS_BAJERA.Text <> String.Empty Then entidadDatosLab.LBS_BAJERA = Convert.ToDecimal(Me.txtLBS_BAJERA.Text)
        If Me.txtLBS_TIERRA_RAICES.Text <> String.Empty Then entidadDatosLab.LBS_TIERRA_RAICES = Convert.ToDecimal(Me.txtLBS_TIERRA_RAICES.Text)
        If Me.txtLBS_PIEDRA.Text <> String.Empty Then entidadDatosLab.LBS_PIEDRA = Convert.ToDecimal(Me.txtLBS_PIEDRA.Text)
        If Me.lblLBS_CANA_LIMPIA.Text <> String.Empty Then entidadDatosLab.LBS_CANA_LIMPIA = Convert.ToDecimal(Me.lblLBS_CANA_LIMPIA.Text)
        If Me.lblPORC_PUNTAS_TIERNA.Text <> String.Empty Then entidadDatosLab.PORC_PUNTAS_TIERNA = Convert.ToDecimal(Me.lblPORC_PUNTAS_TIERNA.Text)
        If Me.lblPORC_CANA_SECA.Text <> String.Empty Then entidadDatosLab.PORC_CANA_SECA = Convert.ToDecimal(Me.lblPORC_CANA_SECA.Text)
        If Me.lblPORC_MAMONES.Text <> String.Empty Then entidadDatosLab.PORC_MAMONES = Convert.ToDecimal(Me.lblPORC_MAMONES.Text)
        If Me.lblPORC_BAJERA.Text <> String.Empty Then entidadDatosLab.PORC_BAJERA = Convert.ToDecimal(Me.lblPORC_BAJERA.Text)
        If Me.lblPORC_TIERRA_RAICES.Text <> String.Empty Then entidadDatosLab.PORC_TIERRA_RAICES = Convert.ToDecimal(Me.lblPORC_TIERRA_RAICES.Text)
        If Me.lblPORC_PIEDRA.Text <> String.Empty Then entidadDatosLab.PORC_PIEDRA = Convert.ToDecimal(Me.lblPORC_PIEDRA.Text)
        If Me.lblPORC_CANA_LIMPIA.Text <> String.Empty Then entidadDatosLab.PORC_CANA_LIMPIA = Convert.ToDecimal(Me.lblPORC_CANA_LIMPIA.Text)
        If Me.lblPORC_MATERIA_EXTRA.Text <> String.Empty Then entidadDatosLab.PORC_MATERIA_EXTRA = Convert.ToDecimal(lblPORC_MATERIA_EXTRA.Text)
        entidadDatosLab.OBSERVACION = Me.txtOBSERVACION.Text.Trim
        If Me.txtACIDEZ.Text <> String.Empty Then entidadDatosLab.ACIDEZ = Convert.ToDecimal(txtACIDEZ.Text)
        If Me.txtREDUCTORES.Text <> String.Empty Then entidadDatosLab.REDUCTORES = Convert.ToDecimal(txtREDUCTORES.Text)

        If entidadDatosLab.ID_DATOS_LAB = 0 Then
            entidadDatosLab.USUARIO_CREA = configuracion.usuarioActualiza
            entidadDatosLab.FECHA_CREA = bFechaHora.ObtenerFechaHora
        End If
        entidadDatosLab.USUARIO_ACT = configuracion.usuarioActualiza
        entidadDatosLab.FECHA_ACT = bFechaHora.ObtenerFechaHora

        lRet = bDatos.ActualizarDATOS_LABORATORIO(entidadDatosLab)
        If lRet > 0 Then
            Me.btnGuardar.Enabled = False
            MsgBox("La información se guardo con éxito!", MsgBoxStyle.Exclamation, Application.ProductName)
            Me.btnNuevo_Click(Me, e)
        Else
            MsgBox("Error al guardar: " + bDatos.sError, MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If btnGuardar.Enabled AndAlso cambioDatos Then
            If MsgBox("¿Desea salir antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        Me.Close()
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
                    txtANALISTA.Text = entidadDatosLab.ANALISTA
                    If entidadDatosLab.LBS_MUESTRA <> -1 Then Me.txtLBS_MUESTRA.Text = entidadDatosLab.LBS_MUESTRA.ToString
                    If entidadDatosLab.LBS_PUNTAS_TIERNA <> -1 Then Me.txtLBS_PUNTAS_TIERNA.Text = entidadDatosLab.LBS_PUNTAS_TIERNA.ToString
                    If entidadDatosLab.LBS_CANA_SECA <> -1 Then Me.txtLBS_CANA_SECA.Text = entidadDatosLab.LBS_CANA_SECA.ToString
                    If entidadDatosLab.LBS_MAMONES <> -1 Then Me.txtLBS_MAMONES.Text = entidadDatosLab.LBS_MAMONES.ToString
                    If entidadDatosLab.LBS_BAJERA <> -1 Then Me.txtLBS_BAJERA.Text = entidadDatosLab.LBS_BAJERA.ToString
                    If entidadDatosLab.LBS_TIERRA_RAICES <> -1 Then Me.txtLBS_TIERRA_RAICES.Text = entidadDatosLab.LBS_TIERRA_RAICES.ToString
                    If entidadDatosLab.LBS_PIEDRA <> -1 Then Me.txtLBS_PIEDRA.Text = entidadDatosLab.LBS_PIEDRA.ToString
                    If entidadDatosLab.LBS_CANA_LIMPIA <> -1 Then Me.lblLBS_CANA_LIMPIA.Text = entidadDatosLab.LBS_CANA_LIMPIA.ToString

                    If entidadDatosLab.PORC_PUNTAS_TIERNA <> -1 Then Me.lblPORC_PUNTAS_TIERNA.Text = entidadDatosLab.PORC_PUNTAS_TIERNA.ToString(formato)
                    If entidadDatosLab.PORC_CANA_SECA <> -1 Then Me.lblPORC_CANA_SECA.Text = entidadDatosLab.PORC_CANA_SECA.ToString(formato)
                    If entidadDatosLab.PORC_MAMONES <> -1 Then Me.lblPORC_MAMONES.Text = entidadDatosLab.PORC_MAMONES.ToString(formato)
                    If entidadDatosLab.PORC_BAJERA <> -1 Then Me.lblPORC_BAJERA.Text = entidadDatosLab.PORC_BAJERA.ToString(formato)
                    If entidadDatosLab.PORC_TIERRA_RAICES <> -1 Then Me.lblPORC_TIERRA_RAICES.Text = entidadDatosLab.PORC_TIERRA_RAICES.ToString(formato)
                    If entidadDatosLab.PORC_PIEDRA <> -1 Then Me.lblPORC_PIEDRA.Text = entidadDatosLab.PORC_PIEDRA.ToString(formato)
                    If entidadDatosLab.PORC_CANA_LIMPIA <> -1 Then Me.lblPORC_CANA_LIMPIA.Text = entidadDatosLab.PORC_CANA_LIMPIA.ToString(formato)
                    If entidadDatosLab.PORC_MATERIA_EXTRA <> -1 Then Me.lblPORC_MATERIA_EXTRA.Text = entidadDatosLab.PORC_MATERIA_EXTRA.ToString(formato)

                    If entidadDatosLab.OBSERVACION IsNot Nothing Then txtOBSERVACION.Text = entidadDatosLab.OBSERVACION

                    If entidadDatosLab.ACIDEZ <> -1 Then Me.txtACIDEZ.Text = Val(entidadDatosLab.ACIDEZ)
                    If entidadDatosLab.REDUCTORES <> -1 Then Me.txtREDUCTORES.Text = Val(entidadDatosLab.REDUCTORES)

                    If entidadDatosLab.LBS_MUESTRA > -1 Then
                        txtTACO.Enabled = False
                        Return
                    End If
                Else
                    entidadDatosLab.ID_DATOS_LAB = 0
                    entidadDatosLab.ID_ANALISIS = lAnalisis(0).ID_ANALISIS
                End If

                txtTACO.Enabled = False
                btnNuevo.Enabled = True
                btnGuardar.Enabled = True
                Me.HabilitarCampos(True)
                Me.txtANALISTA.Focus()
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

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        If btnGuardar.Enabled AndAlso cambioDatos Then
            If MsgBox("¿Desea ingresar otro taco antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        Inicializar()
    End Sub

   
End Class