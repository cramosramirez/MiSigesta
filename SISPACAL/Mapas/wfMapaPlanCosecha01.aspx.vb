Imports SISPACAL.BL
Imports SISPACAL.DL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports System.Configuration.ConfigurationManager
Imports System.Data

Partial Class Mapas_wfMapaPlanCosecha01
    Inherits System.Web.UI.Page

    Dim lOpciones As listaOPCION
    Dim Capas As New Dictionary(Of String, String)
    Dim CapaDepartamentos As New Dictionary(Of String, String)
    Dim CapaMunicipios As New Dictionary(Of String, String)
    Dim CapaCantones As New Dictionary(Of String, String)

    Private Sub CargarMenu()
        Dim lOpciones As listaOPCION

        If Context.User.Identity.Name = String.Empty Then
            Exit Sub
        End If
        If Utilerias.ObtenerUsuario = "jm" OrElse Utilerias.ObtenerUsuario = "chris" Then
            lOpciones = (New cOPCION).ObtenerListaPorUSUARIO(Utilerias.ObtenerUsuario, True)
        Else
            lOpciones = (New cOPCION).ObtenerListaPorUSUARIO(Utilerias.ObtenerUsuario, False)
        End If
        Me.ASPxMenu1.Items.Clear()
        If lOpciones IsNot Nothing AndAlso lOpciones.Count > 0 Then
            For Each lOpcion As OPCION In lOpciones
                If lOpcion.ID_OPCION_PADRE.Equals(-1) Then
                    Dim mnuMenuItem As New MenuItem
                    mnuMenuItem.Name = lOpcion.ID_OPCION
                    mnuMenuItem.Text = lOpcion.NOMBRE_OPCION

                    'Agregar item al menú principal
                    Me.ASPxMenu1.Items.Add(mnuMenuItem)

                    'Generar el árbol de menú
                    AddMenuItem(mnuMenuItem, lOpciones)
                End If
            Next
        End If
    End Sub

    Private Sub AddMenuItem(ByRef mnuMenuItem As MenuItem, ByVal lOpciones As listaOPCION)
        'Recorremos cada elemento de la lista para poder determinar cuales son elementos hijos
        'del menuitem dado pasado como parametro ByRef.
        For Each lOpcion As OPCION In lOpciones
            If lOpcion.ID_OPCION_PADRE.ToString.Equals(mnuMenuItem.Name) Then
                Dim mnuNewMenuItem As New MenuItem
                mnuNewMenuItem.Name = lOpcion.ID_OPCION
                mnuNewMenuItem.Text = lOpcion.NOMBRE_OPCION
                mnuNewMenuItem.NavigateUrl = lOpcion.URL

                'Agregamos el Nuevo MenuItem al MenuItem que viene de un nivel superior.
                'If mnuMenuItem.ChildItems.Count = 0 Then mnuMenuItem.Text += " >>"
                mnuMenuItem.Items.Add(mnuNewMenuItem)

                'llamada recursiva para ver si el nuevo menú ítem aun tiene elementos hijos.
                AddMenuItem(mnuNewMenuItem, lOpciones)
            End If
        Next
    End Sub

    Protected Sub LoginStatus_LoggedOut(ByVal sender As Object, ByVal e As System.EventArgs)
        Session.RemoveAll()
        Session.Abandon()
    End Sub

    Protected Sub cbxCENSO_DataBound(sender As Object, e As System.EventArgs) Handles cbxCENSO.DataBound
        Dim censos As ASPxComboBox = CType(sender, ASPxComboBox)
        If censos IsNot Nothing Then
            If censos.Items.Count > 0 Then
                For Each item As ListEditItem In censos.Items
                    If IsDate(item.Text) Then item.Text = Format(CDate(item.Text), "dd/MM/yyyy")
                Next
            Else
                Me.cbxCENSO.Text = ""
            End If
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.cbxTIPO.Value = -1
        If cbxSUB_TERCIO.Items.Count > 0 Then Me.cbxSUB_TERCIO.SelectedIndex = 0

        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("VerMapa", "Ver mapa", False, Enumeradores.IconoBarra.Generar, "onclick", "e.processOnServer=false;CargarMapa();", True)
        Me.ucBarraNavegacion1.VerOpcion("VerMapa", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Private Sub CargarSubTercios()
        Dim mListaSubTercios As listaTIPOS_GENERALES
        mListaSubTercios = (New cTIPOS_GENERALES).RecuperarPorTipo(False, True, -1, 12, -1)
        Me.cbxSUB_TERCIO.ValueField = "ID_TIPO"
        Me.cbxSUB_TERCIO.TextField = "NOM_TIPO"
        Me.cbxSUB_TERCIO.DataSource = mListaSubTercios
        Me.cbxSUB_TERCIO.DataBind()
    End Sub

    Private Sub CargarSubTiposCana(Optional ID_TIPO_PADRE As Int32 = 0)
        Dim mListaSubTipoCana As listaTIPOS_GENERALES
        Dim idSubTipo As Int32

        If Me.cbxSUB_TIPO.Value IsNot Nothing Then idSubTipo = Me.cbxSUB_TIPO.Value
        If ID_TIPO_PADRE = -1 Then ID_TIPO_PADRE = -5
        mListaSubTipoCana = (New cTIPOS_GENERALES).RecuperarPorTipo(False, True, -1, Enumeradores.TiposTabla.SubTiposVariedad, ID_TIPO_PADRE)
        Me.cbxSUB_TIPO.ValueField = "ID_TIPO"
        Me.cbxSUB_TIPO.TextField = "NOM_TIPO"
        Me.cbxSUB_TIPO.DataSource = mListaSubTipoCana
        Me.cbxSUB_TIPO.DataBind()
        If mListaSubTipoCana.Count > 0 Then
            If mListaSubTipoCana.BuscarPorId(idSubTipo) IsNot Nothing AndAlso idSubTipo <> -1 Then
                Me.cbxSUB_TIPO.SelectedItem = Me.cbxSUB_TIPO.Items.FindByValue(idSubTipo)
            Else
                Me.cbxSUB_TIPO.SelectedIndex = 0
            End If
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.CargarMenu()
        Me.CargarSubTercios()
        If Not IsPostBack Then
            Me.Inicializar()
        End If
        If Me.cbxTIPO.Value IsNot Nothing Then Me.CargarSubTiposCana(Me.cbxTIPO.Value) Else CargarSubTiposCana()
    End Sub

    Protected Sub cbxTIPO_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxTIPO.ValueChanged
        Me.CargarSubTiposCana(Me.cbxTIPO.Value)
    End Sub

    Protected Sub cpMapa_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMapa.Callback
        Dim Parametros As String()
        Parametros = e.Parameter.Split(";")
        cpMapa.JSProperties.Clear()
        If Not Me.cpMapa.JSProperties.ContainsKey("cpResultCallback") Then Me.cpMapa.JSProperties.Add("cpResultCallback", "") Else Me.cpMapa.JSProperties("cpResultCallback") = ""

        Select Case Parametros(0)

            Case "LlenarMapa"
                Dim dt As New DS_SIGESTA_MAPA.MapaTerciosDataTable
                Dim adapter As New DS_SIGESTA_MAPATableAdapters.MapaTerciosTableAdapter

                Dim cCodiCanton As String = "*"
                Dim cadena As String()
                Dim bAgregarCanton As Boolean = False
                Dim bFin As Boolean = False
                Dim sTercio As New StringBuilder
                Dim sIcono As New StringBuilder
                Dim strCad As New StringBuilder
                Dim dTonel As Decimal = 0
                Dim dTotalConsulta As Decimal = 0
                Dim dValor1 As Decimal = 0
                Dim dValor2 As Decimal = 0
                Dim i As Int32 = 0
                Dim j As Int32 = 0
                Dim conta As Int32
                Dim lCanton As CANTON
                Dim SubTercio As String = ""

                'Recuperando la URL del sitio
                Dim URL As String = Request.Url.AbsoluteUri.ToLower
                Dim indice As Int32 = URL.IndexOf("/mapas/")
                URL = URL.Substring(0, indice) + "/imagenes/mapa/"


                'Calculando Rangos de Valores
                If cbxTipoMapa.Value = 1 Then
                    adapter.FillTercioPorCriterios(dt, cbxTERCIO.Value, SubTercio, cbxTIPO.Value, cbxSUB_TIPO.Value, cbxCENSO.Value)
                Else
                    adapter.FillTipoCanaPorCriterios(dt, cbxTERCIO.Value, SubTercio, cbxTIPO.Value, cbxSUB_TIPO.Value, cbxCENSO.Value)
                End If
                For Each fila As DS_SIGESTA_MAPA.MapaTerciosRow In dt.Rows
                    dTotalConsulta += fila.TONEL
                Next
                dValor1 = Math.Round(dTotalConsulta / 3, 2)
                dValor2 = dValor1 * 2

                If cbxSUB_TERCIO.Value <> -1 Then SubTercio = cbxSUB_TERCIO.Text

                Capas = New Dictionary(Of String, String)
                CapaCantones = New Dictionary(Of String, String)
                For Each fila As DS_SIGESTA_MAPA.MapaTerciosRow In dt.Rows
                    i += 1
                    bFin = (i = dt.Rows.Count)
                    conta = 0

                    If fila.IsTERCIONull Then
                        fila.TERCIO = 1
                    End If


                    If cCodiCanton = "*" Then
                        cCodiCanton = fila.CODI_DEPTO + "." + fila.CODI_MUNI + "." + fila.CODI_CANTON
                        sTercio.Append(fila.TERCIO.ToString)
                        dTonel += fila.TONEL
                    ElseIf cCodiCanton = (fila.CODI_DEPTO + "." + fila.CODI_MUNI + "." + fila.CODI_CANTON) Then
                        If sTercio.ToString.Length < 2 Then
                            sTercio.Append(fila.TERCIO)
                            dTonel += fila.TONEL
                        End If
                    Else
                        bAgregarCanton = True
                    End If

                    ' *****************************
                    ' Verde: 1, Azul: 2, Rojo: 3
                    ' *****************************
                    While (bAgregarCanton OrElse (bFin AndAlso conta = 0))
                        conta += 1

                        sIcono = New StringBuilder(URL)

                        Select Case cbxTipoMapa.Value
                            Case 1
                                Select Case sTercio.ToString.Substring(0, 1)
                                    Case "1"
                                        sIcono.Append("punto_verde")
                                    Case "2"
                                        sIcono.Append("punto_azul")
                                    Case "3"
                                        sIcono.Append("punto_rojo")
                                End Select
                            Case 2
                                Select Case sTercio.ToString.Substring(0, 1)
                                    Case "2"
                                        sIcono.Append("punto_verde")
                                    Case "3"
                                        sIcono.Append("punto_azul")
                                    Case "4"
                                        sIcono.Append("punto_rojo")
                                End Select
                        End Select
                        Select Case dTonel
                            Case Is < dValor1
                                sIcono.Append("A")
                            Case dValor1 To dValor2
                                sIcono.Append("B")
                            Case Is > dValor2
                                sIcono.Append("C")
                        End Select

                        sIcono.Append(".png")

                        cadena = cCodiCanton.Split(".")
                        lCanton = (New cCANTON).ObtenerCANTON(cadena(2), cadena(0), cadena(1))
                        strCad = New StringBuilder()
                        strCad.Append(cCodiCanton + ";")
                        strCad.Append(lCanton.NOMBRE_CANTON + ";")
                        strCad.Append(sIcono.ToString + ";")
                        strCad.Append(lCanton.POSICION_GEO + ";")
                        strCad.Append(";")
                        strCad.Append("1;")
                        strCad.Append("negro;")
                        strCad.Append("0.5;")
                        strCad.Append("gris;")
                        strCad.Append("0.0;")
                        strCad.Append("0;")
                        strCad.Append("verde;")
                        strCad.Append("C")
                        CapaCantones.Add(j, strCad.ToString)
                        j += 1
                        '--------------------------

                        If bAgregarCanton Then
                            cCodiCanton = fila.CODI_DEPTO + "." + fila.CODI_MUNI + "." + fila.CODI_CANTON
                            sTercio = New StringBuilder
                            sTercio.Append(fila.TERCIO)
                            dTonel = 0
                            dTonel += fila.TONEL
                        End If

                        If bFin Then
                            If bAgregarCanton Then
                                conta -= 1
                                bAgregarCanton = False
                            End If
                        Else
                            bAgregarCanton = False
                        End If
                    End While
                Next
                Capas.Add(0, "CapaCantones")
                cpMapa.JSProperties.Add("cpCapas", Capas)
                cpMapa.JSProperties.Add("cpCapaCantones", CapaCantones)
                cpMapa.JSProperties.Add("cpImagenIngenio", URL + "map_jiboa.png")
                Me.cpMapa.JSProperties("cpResultCallback") = "LlenarMapa"


            Case "PopupInfo"
                Dim codigo As String()
                Dim lRet As New Dictionary(Of String, Object)

                Select Case Parametros(1)
                    Case "D"
                        lRet = (New cMapa).ObtenerInfoContratadoEntregado(Me.cbxCENSO.Value, Parametros(2), "", "", "", "")
                        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(Parametros(2))
                        Me.CargarGraficoEntregaCana(Me.cbxZAFRA.Text, Parametros(2), "", "", "", "")
                        Me.CargarGraficoRendimientoCana(Me.cbxZAFRA.Text, Parametros(2), "", "", "", "")
                        Me.CargarGraficoEntregaTercio(Me.cbxZAFRA.Value, Parametros(2), "", "", "", "")
                        Me.CargarGraficoRendimientoTercio(Me.cbxZAFRA.Value, Parametros(2), "", "", "", "")
                        Me.popupInfo.HeaderText = "DEPARTAMENTO: " + lDepto.NOMBRE_DEPTO

                    Case "M"
                        codigo = Parametros(2).Split(".")
                        lRet = (New cMapa).ObtenerInfoContratadoEntregado(Me.cbxCENSO.Value, codigo(0), codigo(1), "", "", "")
                        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(codigo(0))
                        Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(codigo(0), codigo(1))
                        Me.CargarGraficoEntregaCana(Me.cbxZAFRA.Text, codigo(0), codigo(1), "", "", "")
                        Me.CargarGraficoRendimientoCana(Me.cbxZAFRA.Text, codigo(0), codigo(1), "", "", "")
                        Me.CargarGraficoEntregaTercio(Me.cbxZAFRA.Value, codigo(0), codigo(1), "", "", "")
                        Me.CargarGraficoRendimientoTercio(Me.cbxZAFRA.Value, codigo(0), codigo(1), "", "", "")
                        Me.popupInfo.HeaderText = "MUNICIPIO: " + lMuni.NOMBRE_MUNI + ", " + lDepto.NOMBRE_DEPTO

                    Case "C"
                        codigo = Parametros(2).Split(".")
                        lRet = (New cMapa).ObtenerInfoContratadoEntregado(Me.cbxCENSO.Value, codigo(0), codigo(1), codigo(2), "", "")
                        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(codigo(0))
                        Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(codigo(0), codigo(1))
                        Dim lCanton As CANTON = (New cCANTON).ObtenerCANTON(codigo(2), codigo(0), codigo(1))
                        Me.CargarGraficoEntregaCana(Me.cbxZAFRA.Text, codigo(0), codigo(1), codigo(2), "", "")
                        Me.CargarGraficoRendimientoCana(Me.cbxZAFRA.Text, codigo(0), codigo(1), codigo(2), "", "")
                        Me.CargarGraficoEntregaTercio(Me.cbxZAFRA.Value, codigo(0), codigo(1), codigo(2), "", "")
                        Me.CargarGraficoRendimientoTercio(Me.cbxZAFRA.Value, codigo(0), codigo(1), codigo(2), "", "")
                        Me.popupInfo.HeaderText = "CANTON: " + lCanton.NOMBRE_CANTON + "," + lMuni.NOMBRE_MUNI + ", " + lDepto.NOMBRE_DEPTO
                End Select

                Me.lblCaneros.Text = ""
                Me.lblContratos.Text = ""
                Me.lblLotes.Text = ""
                Me.lblArea_Contratada.Text = ""
                Me.lblTc_Mz_Contratada.Text = ""
                Me.lblTC_Contratada.Text = ""
                Me.lblArea_Censo.Text = ""
                Me.lblTc_Mz_Censo.Text = ""
                Me.lblTC_Censo.Text = ""
                Me.lblArea_Entregada.Text = ""
                Me.lblTc_Mz_Entregada.Text = ""
                Me.lblTC_Entregada.Text = ""

                If lRet IsNot Nothing Then
                    Me.lblCaneros.Text = Format(lRet("CANEROS"), "#,##0")
                    Me.lblContratos.Text = Format(lRet("CONTRATOS"), "#,##0")
                    Me.lblLotes.Text = Format(lRet("LOTES"), "#,##0")
                    Me.lblArea_Contratada.Text = Format(lRet("MZ_CONTRATADO"), "#,##0.00")
                    Me.lblTc_Mz_Contratada.Text = Format(lRet("TC_MZ_CONTRATADO"), "#,##0.00")
                    Me.lblTC_Contratada.Text = Format(lRet("TONEL_CONTRATADO"), "#,##0.00")

                    Me.lblArea_Censo.Text = Format(lRet("MZ_CENSO"), "#,##0.00")
                    Me.lblTc_Mz_Censo.Text = Format(lRet("TC_MZ_CENSO"), "#,##0.00")
                    Me.lblTC_Censo.Text = Format(lRet("TONEL_CENSO"), "#,##0.00")

                    Me.lblArea_Entregada.Text = Format(lRet("MZ_ENTREGADO"), "#,##0.00")
                    Me.lblTc_Mz_Entregada.Text = Format(lRet("TC_MZ_ENTREGADO"), "#,##0.00")
                    Me.lblTC_Entregada.Text = Format(lRet("TONEL_ENTREGADO"), "#,##0.00")
                End If
                Me.cpMapa.JSProperties("cpResultCallback") = "PopupInfo"
        End Select

    End Sub

    Private Sub CargarGraficoEntregaCana(ByVal NOMBRE_ZAFRA As String, _
                                        ByVal CODI_DEPTO As String, _
                                        ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal ZONA As String, _
                                        ByVal SUB_ZONA As String)
        Me.odsGrafico.SelectParameters("NOMBRE_ZAFRA").DefaultValue = NOMBRE_ZAFRA
        Me.odsGrafico.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsGrafico.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsGrafico.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsGrafico.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsGrafico.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.chartEntregaCanaCatorcena.DataBind()
    End Sub

    Private Sub CargarGraficoRendimientoCana(ByVal NOMBRE_ZAFRA As String, _
                                        ByVal CODI_DEPTO As String, _
                                        ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal ZONA As String, _
                                        ByVal SUB_ZONA As String)
        Me.odsRendimiento.SelectParameters("NOMBRE_ZAFRA").DefaultValue = NOMBRE_ZAFRA
        Me.odsRendimiento.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsRendimiento.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsRendimiento.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsRendimiento.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsRendimiento.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.chartRendCatorcena.DataBind()
    End Sub

    Private Sub CargarGraficoEntregaTercio(ByVal ID_ZAFRA As Int32, _
                                        ByVal CODI_DEPTO As String, _
                                        ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal ZONA As String, _
                                        ByVal SUB_ZONA As String)
        Me.odsGraficoEntregaTercio.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsGraficoEntregaTercio.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsGraficoEntregaTercio.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsGraficoEntregaTercio.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsGraficoEntregaTercio.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsGraficoEntregaTercio.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.chartEntregaCanaTercio.DataBind()
    End Sub

    Private Sub CargarGraficoRendimientoTercio(ByVal ID_ZAFRA As Int32, _
                                        ByVal CODI_DEPTO As String, _
                                        ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal ZONA As String, _
                                        ByVal SUB_ZONA As String)
        Me.odsGraficoRendimientoTercio.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsGraficoRendimientoTercio.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsGraficoRendimientoTercio.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsGraficoRendimientoTercio.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsGraficoRendimientoTercio.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsGraficoRendimientoTercio.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.chartRendTercio.DataBind()
    End Sub

    Protected Sub cbxTipoMapa_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxTipoMapa.ValueChanged
        Select Case cbxTipoMapa.Value
            Case 1
                lblRepVerde.Text = "1° Tercio"
                lblRepAzul.Text = "2° Tercio"
                lblRepRojo.Text = "3° Tercio"
            Case 2
                lblRepVerde.Text = "Temprana"
                lblRepAzul.Text = "Intermedia"
                lblRepRojo.Text = "Tardia"
        End Select
    End Sub
End Class
