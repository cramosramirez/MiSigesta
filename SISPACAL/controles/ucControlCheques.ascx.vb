Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Collections.Generic

Partial Class controles_ucControlCheques
    Inherits ucBase

    Public Property TIPO_OPERACION As TipoOperacion
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacion.Emision
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacion)
            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacion.Emision Then
                Me.Nuevo()
                Me.grdCheques.Columns(0).Visible = True
                Me.divTituloEmisionCheques.Visible = True
                Me.divTituloAnulacionCheques.Visible = False

            ElseIf value = TipoOperacion.Anulacion Then
                Me.Nuevo()
                Me.grdCheques.Columns(0).Visible = False
                Me.divTituloEmisionCheques.Visible = False
                Me.divTituloAnulacionCheques.Visible = True
                Me.divChequera.Visible = False
            End If
        End Set
    End Property

    Public Function CargarChequesPlanilla() As Integer
        Dim idRangoCompe As Int32 = -1

        If Me.ddlCATORCENA_ZAFRA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una catorcena", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione un tipo de planilla", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso Me.ddlRANGO_COMPENSACION1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione el rango de compensacion", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso IsNumeric(Me.ddlRANGO_COMPENSACION1.SelectedValue) Then
            idRangoCompe = CInt(Me.ddlRANGO_COMPENSACION1.SelectedValue)
        End If

        Dim lPlanilla As listaPLANILLA
        Dim bPlanilla As New cPLANILLA
        lPlanilla = bPlanilla.ObtenerListaChequesPlanilla(CInt(Me.ddlCATORCENA_ZAFRA1.SelectedValue), _
                                                            CInt(Me.ddlTIPO_PLANILLA1.SelectedValue), _
                                                            CInt(Me.rdbContribuyente.SelectedValue), _
                                                            idRangoCompe)
        If lPlanilla Is Nothing Then
            Me.grdCheques.Visible = False
        End If
        Me.grdCheques.SelectedIndex = -1
        Me.grdCheques.Visible = True
        Me.grdCheques.DataSource = lPlanilla
        Me.grdCheques.DataBind()
        If bPlanilla.sError <> "" Then
            AsignarMensaje("* Error en consulta: " + bPlanilla.sError, True)
            Return -1
        End If
        Return 1
    End Function

    Public Function AnularCheques() As Integer
        Dim idRangoCompe As Int32 = -1

        If Me.ddlCATORCENA_ZAFRA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una catorcena", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione un tipo de planilla", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso Me.ddlRANGO_COMPENSACION1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione el rango de compensacion", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso IsNumeric(Me.ddlRANGO_COMPENSACION1.SelectedValue) Then
            idRangoCompe = CInt(Me.ddlRANGO_COMPENSACION1.SelectedValue)
        End If
        If Me.txtNO_CHEQUE_INICIAL.Text = "" Then
            AsignarMensaje("* Ingrese el No. de Cheque inicial", True)
            Return -1
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtNO_CHEQUE_INICIAL.Text) Then
            AsignarMensaje("* El No. de Cheque inicial debe ser un numero entero", True)
            Return -1
        End If
        If Me.txtNO_CHEQUE_FINAL.Text = "" Then
            AsignarMensaje("* Ingrese el No. de Cheque final", True)
            Return -1
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtNO_CHEQUE_FINAL.Text) Then
            AsignarMensaje("* El No. de Cheque final debe ser un numero entero", True)
            Return -1
        End If
        If Convert.ToInt32(Me.txtNO_CHEQUE_INICIAL.Text) > Convert.ToInt32(Me.txtNO_CHEQUE_FINAL.Text) Then
            AsignarMensaje("* El No. de Cheque inicial no puede ser mayor que el final", True)
            Return -1
        End If

        Dim lRet As Integer
        Dim bPlanilla As New cPLANILLA
        lRet = bPlanilla.AnularChequesPlanilla(Me.ddlCATORCENA_ZAFRA1.SelectedValue, Me.ddlTIPO_PLANILLA1.SelectedValue, _
                                        Me.rdbContribuyente.SelectedValue, _
                                        Convert.ToInt32(Me.txtNO_CHEQUE_INICIAL.Text), Convert.ToInt32(Me.txtNO_CHEQUE_FINAL.Text), idRangoCompe)
        If lRet = -1 Then
            AsignarMensaje("* Error en anulacion de cheques: " + bPlanilla.sError, True)
            Return -1
        End If

        MostrarMensaje("La anulacion de cheques se realizo con exito", "Informacion")
        Me.CargarChequesPlanilla()
        Me.txtNO_CHEQUE_INICIAL.Text = ""
        Me.txtNO_CHEQUE_FINAL.Text = ""
        Return 1
    End Function

    Public Function EmitirCheques() As Integer
        Dim idRangoCompe As Int32 = -1

        If Me.ddlCATORCENA_ZAFRA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una catorcena", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione un tipo de planilla", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso Me.ddlRANGO_COMPENSACION1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione el rango de compensacion", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso IsNumeric(Me.ddlRANGO_COMPENSACION1.SelectedValue) Then
            idRangoCompe = CInt(Me.ddlRANGO_COMPENSACION1.SelectedValue)
        End If
        If Me.ddlCHEQUERA_PLANILLA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una chequera", True)
            Return -1
        End If
        If Me.txtNO_CHEQUE_INICIAL_EMISION.Text = "" Then
            AsignarMensaje("* Ingrese el No. de Cheque inicial", True)
            Return -1
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtNO_CHEQUE_INICIAL_EMISION.Text) Then
            AsignarMensaje("* El No. de Cheque inicial debe ser un numero entero", True)
            Return -1
        End If
        If Me.txtNO_CHEQUE.Text = "" Then
            AsignarMensaje("* Seleccione hasta que N° Cheque emitira", True)
            Return -1
        End If

        Dim lRet As Integer
        Dim bPlanilla As New cPLANILLA
        lRet = bPlanilla.EmitirCheques(Me.ddlCATORCENA_ZAFRA1.SelectedValue, Me.ddlTIPO_PLANILLA1.SelectedValue, _
                                        Me.rdbContribuyente.SelectedValue, Me.ddlCUENTA_BANCARIA1.SelectedValue, _
                                        Me.ddlCHEQUERA_PLANILLA1.SelectedValue, _
                                        Convert.ToInt32(Me.txtNO_CHEQUE_INICIAL_EMISION.Text), Convert.ToInt32(Me.txtNO_CHEQUE.Text), Me.ObtenerUsuario, Now, idRangoCompe)
        If lRet = -1 Then
            AsignarMensaje("* Error en emision de cheques: " + bPlanilla.sError, True)
            Return -1
        End If

        MostrarMensaje("La emision de cheques se realizo con exito", "Informacion")
        If Not CInt(Me.ddlTIPO_PLANILLA1.SelectedValue) = Enumeradores.TipoPlanilla.AnticipoCaneros Then
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarEmisionCheques(" + lRet.ToString + ")", True)
        Else
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarEmisionChequesAnticipo(" + lRet.ToString + ")", True)
        End If
        Me.CargarChequesPendientesEmitir()
        Return 1
    End Function

    Public Function CargarChequesPendientesEmitir() As Integer
        Dim idRangoCompe As Int32 = -1

        If Me.ddlCATORCENA_ZAFRA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una catorcena", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione un tipo de planilla", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso Me.ddlRANGO_COMPENSACION1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione el rango de compensacion", True)
            Return -1
        End If
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana AndAlso IsNumeric(Me.ddlRANGO_COMPENSACION1.SelectedValue) Then
            idRangoCompe = CInt(Me.ddlRANGO_COMPENSACION1.SelectedValue)
        End If
        If Me.ddlCHEQUERA_PLANILLA1.SelectedValue = "" Then
            AsignarMensaje("* Seleccione una chequera", True)
            Return -1
        End If
        If Me.txtNO_CHEQUE_INICIAL_EMISION.Text = "" Then
            AsignarMensaje("* Ingrese el No. de Cheque inicial", True)
            Return -1
        End If
        If Not Utilerias.EsNumeroEntero(Me.txtNO_CHEQUE_INICIAL_EMISION.Text) Then
            AsignarMensaje("* El No. de Cheque inicial debe ser un numero entero", True)
            Return -1
        End If

        Me.txtNO_CHEQUE.Text = ""

        Dim lPlanilla As listaPLANILLA
        Dim bPlanilla As New cPLANILLA
        lPlanilla = bPlanilla.ObtenerListaChequesPendientesEmitir(CInt(Me.ddlCATORCENA_ZAFRA1.SelectedValue), _
                                                                  CInt(Me.ddlTIPO_PLANILLA1.SelectedValue), _
                                                                  CInt(Me.rdbContribuyente.SelectedValue), _
                                                                  CInt(Me.txtNO_CHEQUE_INICIAL_EMISION.Text), _
                                                                  idRangoCompe)

        If lPlanilla Is Nothing Then
            Me.grdCheques.Visible = False
        End If
        Me.grdCheques.SelectedIndex = -1
        Me.grdCheques.Visible = True
        Me.grdCheques.DataSource = lPlanilla
        Me.grdCheques.DataBind()
        If bPlanilla.sError <> "" Then
            AsignarMensaje("* Error en consulta: " + bPlanilla.sError, True)
            Return -1
        End If
        Return 1
    End Function

    Public Sub Nuevo()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        If lZafraActiva IsNot Nothing Then
            Me.ddlZAFRAID_ZAFRA.SelectedValue = lZafraActiva.ID_ZAFRA
        End If
        Me.ddlCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.ddlZAFRAID_ZAFRA.SelectedValue)
        Me.ddlTIPO_PLANILLA1.Recuperar()

        Me.ddlBANCOS1.Recuperar()
        If Me.ddlBANCOS1.SelectedValue = "" Then Me.ddlCUENTA_BANCARIA1.RecuperarPorBANCOS(-1) Else Me.ddlCUENTA_BANCARIA1.RecuperarPorBANCOS(Me.ddlBANCOS1.SelectedValue)
        If Me.ddlCUENTA_BANCARIA1.SelectedValue = "" Then Me.ddlCHEQUERA_PLANILLA1.RecuperarPorCUENTA_BANCARIA(-1) Else Me.ddlCHEQUERA_PLANILLA1.RecuperarPorCUENTA_BANCARIA(Me.ddlCUENTA_BANCARIA1.SelectedValue)

        Me.txtNO_CHEQUE.Text = ""
        Me.txtNO_CHEQUE_INICIAL_EMISION.Text = ""
        Me.txtNO_CHEQUE_INICIAL.Text = ""
        Me.txtNO_CHEQUE_FINAL.Text = ""

        Me.grdCheques.DataSource = Nothing
        Me.grdCheques.DataBind()
    End Sub

    Protected Sub ddlZAFRAID_ZAFRA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlZAFRAID_ZAFRA.SelectedIndexChanged
        Me.ddlCATORCENA_ZAFRA1.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue)
        LimpiarNumCheques()
    End Sub

    Protected Sub ddlBANCOS1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBANCOS1.SelectedIndexChanged
        Me.ddlCUENTA_BANCARIA1.RecuperarPorBANCOS(ddlBANCOS1.SelectedValue)
        If Me.ddlCUENTA_BANCARIA1.SelectedValue <> "" Then
            Me.ddlCHEQUERA_PLANILLA1.RecuperarPorCUENTA_BANCARIA(Me.ddlCUENTA_BANCARIA1.SelectedValue)
        Else
            Me.ddlCHEQUERA_PLANILLA1.RecuperarPorCUENTA_BANCARIA(-1)
        End If
    End Sub

    Protected Sub ddlCUENTA_BANCARIA1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCUENTA_BANCARIA1.SelectedIndexChanged
        Me.ddlCHEQUERA_PLANILLA1.RecuperarPorCUENTA_BANCARIA(Me.ddlCUENTA_BANCARIA1.SelectedValue)
    End Sub

    Protected Sub grdCheques_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grdCheques.PageIndexChanging
        Me.grdCheques.PageIndex = e.NewPageIndex
        Select Case TIPO_OPERACION
            Case TipoOperacion.Emision
                Me.CargarChequesPendientesEmitir()
            Case TipoOperacion.Anulacion
                Me.CargarChequesPlanilla()
        End Select
    End Sub

    Protected Sub grdCheques_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdCheques.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lFila As PLANILLA = CType(e.Row.DataItem, PLANILLA)

            Dim lblNO_CHEQUE As Label = CType(e.Row.FindControl("lblNO_CHEQUE"), Label)
            If lblNO_CHEQUE IsNot Nothing Then
                If lFila.NO_CHEQUE = -1 Then
                    lblNO_CHEQUE.Text = "<N/D>"
                Else
                    lblNO_CHEQUE.Text = lFila.NO_CHEQUE.ToString
                End If
            End If
        End If
    End Sub

    Protected Sub grdCheques_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCheques.SelectedIndexChanged
        Me.txtNO_CHEQUE.Text = ""
        Dim fila As GridViewRow = grdCheques.SelectedRow
        If fila IsNot Nothing Then
            Dim lblNO_CHEQUE As Label = CType(fila.FindControl("lblNO_CHEQUE"), Label)
            If lblNO_CHEQUE IsNot Nothing Then
                Me.txtNO_CHEQUE.Text = lblNO_CHEQUE.Text
            End If
        End If
    End Sub

    Protected Sub ddlCATORCENA_ZAFRA1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.LimpiarNumCheques()
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub LimpiarNumCheques()
        Me.txtNO_CHEQUE.Text = ""
        Me.txtNO_CHEQUE_INICIAL_EMISION.Text = ""
        Me.txtNO_CHEQUE_INICIAL.Text = ""
        Me.txtNO_CHEQUE_FINAL.Text = ""

        Me.grdCheques.DataSource = Nothing
        Me.grdCheques.DataBind()
    End Sub

    Protected Sub ddlTIPO_PLANILLA1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTIPO_PLANILLA1.SelectedIndexChanged
        Me.LimpiarNumCheques()
        Me.ConfigRangoCompensacion()
    End Sub

    Protected Sub rdbContribuyente_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles rdbContribuyente.SelectedIndexChanged
        Me.LimpiarNumCheques()
    End Sub

    Private Sub ConfigRangoCompensacion()
        If Me.ddlTIPO_PLANILLA1.SelectedValue = TipoPlanilla.CompensacionEntregaCana Then
            Me.trRANGO_COMPENSACION.Visible = True
            If Me.ddlCATORCENA_ZAFRA1.SelectedValue IsNot Nothing Then
                Me.ddlRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(Me.ddlCATORCENA_ZAFRA1.SelectedValue)
            Else
                Me.ddlRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(-1)
            End If
        Else
            Me.trRANGO_COMPENSACION.Visible = False
        End If
    End Sub
End Class
