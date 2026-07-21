Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web


Partial Class controlesCenso_ucCriteriosLabPrecosecha
    Inherits ucBase

#Region "Visibilidad"
    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerZAFRA_COMPARAR() As Boolean
        Get
            Return Me.lblZAFRA_COMPARAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblZAFRA_COMPARAR.Visible = value
            Me.cbxZAFRA_COMPARAR.Visible = value
        End Set
    End Property

    Public Property VerPERIODO_FECHA_HORA() As Boolean
        Get
            Return Me.trPERIODO_FECHA_HORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPERIODO_FECHA_HORA.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEE_SOCIO() As Boolean
        Get
            Return Me.trCODIPROVEEDOR_SOCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR_SOCIO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_LOTE() As Boolean
        Get
            Return Me.trNOMBLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBLOTE.Visible = value
        End Set
    End Property

    Public Property VerZONAS() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Public Property VerCON_CUOTA_DIARIA() As Boolean
        Get
            Return Me.trCON_CUOTA_DIARIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCON_CUOTA_DIARIA.Visible = value
        End Set
    End Property

    Public Property VerAGRONOMO() As Boolean
        Get
            Return Me.trAGRONOMO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAGRONOMO.Visible = value
        End Set
    End Property

    Public Property VerPERIODO_FECHA() As Boolean
        Get
            Return Me.trPERIODO_FECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPERIODO_FECHA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CORTE() As Boolean
        Get
            Return Me.trFECHA_CORTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CORTE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_HORA_CORTE() As Boolean
        Get
            Return Me.trFECHA_HORA_CORTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_HORA_CORTE.Visible = value
        End Set
    End Property

    Public Property VerDIA_ZAFRA() As Boolean
        Get
            Return Me.trDIA_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIA_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerDIA_ZAFRA_CIERRE() As Boolean
        Get
            Return Me.trDIA_ZAFRA_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIA_ZAFRA_CIERRE.Visible = value
        End Set
    End Property

    Public Property VerAUTORIZADO_ENTREGA_CANA() As Boolean
        Get
            Return Me.trAUTORIZADO_ENTREGA_CANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAUTORIZADO_ENTREGA_CANA.Visible = value
        End Set
    End Property

    Public Property VerSEMANA_CATORCENA() As Boolean
        Get
            Return Me.trSEMANA_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSEMANA_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerNROBOLETA() As Boolean
        Get
            Return Me.trNROBOLETA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNROBOLETA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.trNOMBRE_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_PROVEEDOR.Visible = value
        End Set
    End Property
#End Region

#Region "Valores"
    Public Property ID_ZAFRA() As Integer
        Get
            If Me.cbxZAFRA.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxZAFRA.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property DIA_ZAFRA() As Integer
        Get
            If Me.cbxDIA_ZAFRA.Text Is Nothing Then
                Return -1
            Else
                Return CInt(Me.cbxDIA_ZAFRA.Text)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxDIA_ZAFRA.Text = value
        End Set
    End Property

    Public Property DIA_ZAFRA_CIERRE() As Integer
        Get
            If Me.cbxDIA_ZAFRA_CIERRE.Text = "" Then
                Return -1
            Else
                Return CInt(Me.cbxDIA_ZAFRA_CIERRE.Text)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxDIA_ZAFRA_CIERRE.Text = value
        End Set
    End Property

    Public Property ID_ZAFRA_COMPARAR() As Integer
        Get
            If Me.cbxZAFRA_COMPARAR.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxZAFRA_COMPARAR.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxZAFRA_COMPARAR.Value = value
        End Set
    End Property

    Public Property CON_CUOTA_DIARIA() As Boolean
        Get
            Return chkCUOTA_DIARIA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkCUOTA_DIARIA.Checked = value
        End Set
    End Property

    Public Property FECHA1() As DateTime
        Get
            If dteFecha1.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFecha1.Date
        End Get
        Set(ByVal value As DateTime)
            Me.dteFecha1.Date = value
        End Set
    End Property

    Public Property FECHA2() As DateTime
        Get
            If dteFecha2.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFecha2.Date
        End Get
        Set(ByVal value As DateTime)
            Me.dteFecha2.Date = value
        End Set
    End Property

    Public Property FECHA_CORTE() As Date
        Get
            If dteFECHA_CORTE.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFECHA_CORTE.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFECHA_CORTE.Date = value
        End Set
    End Property

    Public Property FECHA_HORA_CORTE() As Date
        Get
            If dteFECHA_HORA_CORTE.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFECHA_HORA_CORTE.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFECHA_HORA_CORTE.Date = value
        End Set
    End Property

    Public Property FECHA_INICIAL() As Date
        Get
            If dteFECHA_INICIAL.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFECHA_INICIAL.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFECHA_INICIAL.Date = value
        End Set
    End Property

    Public Property FECHA_FINAL() As Date
        Get
            If dteFECHA_FINAL.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFECHA_FINAL.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFECHA_FINAL.Date = value
        End Set
    End Property

    Public Property DESCRIP_CAMPO_ZAFRA() As String
        Get
            Return lblDescripZafra.Text
        End Get
        Set(ByVal value As String)
            Me.lblDescripZafra.Text = value
        End Set
    End Property

    Public Property NOMBRE_LOTE() As String
        Get
            Return Me.txtNOMBLOTE.Text.ToUpper
        End Get
        Set(ByVal value As String)
            Me.txtNOMBLOTE.Text = value
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            Return Me.txtCODIPROVEE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEE.Text = value
        End Set
    End Property

    Public Property CODISOCIO() As String
        Get
            Return Me.txtCODISOCIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODISOCIO.Text = value
        End Set
    End Property

    Public Property SEMANA() As Int32
        Get
            If Me.cbxSEMANA.Value Is Nothing OrElse Not IsNumeric(Me.cbxSEMANA.Value) Then
                Return -1
            Else
                Return Me.cbxSEMANA.Value
            End If
        End Get
        Set(ByVal value As Int32)
            Me.cbxSEMANA.Value = value
        End Set
    End Property

    Public Property AUTORIZADO_ENTREGA() As Int32
        Get
            If Me.rblAUTORIZADO_ENTREGA_CANA.Value Is Nothing Then
                Return 0
            Else
                Return Me.rblAUTORIZADO_ENTREGA_CANA.Value
            End If
        End Get
        Set(ByVal value As Int32)
            Me.rblAUTORIZADO_ENTREGA_CANA.Value = value
        End Set
    End Property

    Public Property ZONA() As String
        Get
            If Me.cbxZONA.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxZONA.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxZONA.Value = value
        End Set
    End Property

    Public Property CATORCENA() As Int32
        Get
            If Me.cbxCATORCENA.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxCATORCENA.Value
            End If
        End Get
        Set(ByVal value As Int32)
            Me.cbxCATORCENA.Value = value
        End Set
    End Property

    Public Property NROBOLETA() As Int32
        Get
            If Me.speNROBOLETA.Value Is Nothing Then
                Return -1
            Else
                Return Me.speNROBOLETA.Value
            End If
        End Get
        Set(ByVal value As Int32)
            Me.speNROBOLETA.Value = value
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR.Text = value
        End Set
    End Property

    Public Property CODIAGRON() As String
        Get
            If Me.cbxAGRONOMO.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxAGRONOMO.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxAGRONOMO.Value = value
        End Set
    End Property

#End Region

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub CargarCatorcenas()
        Dim noCatorcenaPropuesta As Int32 = (New cPLAN_COSECHA).ObtenerUltimaCatorcenaPropuesta(Me.cbxZAFRA.Value)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerCatorcenasPorZAFRA_TIPO_CICLO(Me.cbxZAFRA.Value, 2)
        If lista Is Nothing Then lista = New List(Of Int32)
        Me.cbxCATORCENA.DataSource = lista
        Me.cbxCATORCENA.DataBind()
        If noCatorcenaPropuesta > 0 Then
            If Me.cbxCATORCENA.Items.FindByValue(noCatorcenaPropuesta) IsNot Nothing Then
                Me.cbxCATORCENA.SelectedItem = Me.cbxCATORCENA.Items.FindByValue(noCatorcenaPropuesta)
            End If
        End If
    End Sub

    Private Sub CargarSemanas()
        Dim listaCad As New List(Of String)
        Dim _Catorcena As Int32 = -1
        If Me.cbxCATORCENA.Text <> "" Then _Catorcena = CInt(Me.cbxCATORCENA.Text)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(Me.cbxZAFRA.Value, 2, _Catorcena)
        If lista Is Nothing Then lista = New List(Of Int32)

        listaCad.Add("[Todas]")
        For Each s As Int32 In lista
            listaCad.Add(s.ToString)
        Next
        Me.cbxSEMANA.DataSource = listaCad
        Me.cbxSEMANA.DataBind()
        If cbxSEMANA.Items.Count > 0 Then cbxSEMANA.SelectedItem = cbxSEMANA.Items.FindByValue("[Todas]")
    End Sub

    Private Sub CargarDiasZafra()
        Dim listaDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, "DIAZAFRA", "DESC")
        Dim lDiaZafra As DIA_ZAFRA

        If listaDiasZafra Is Nothing OrElse listaDiasZafra.Count = 0 Then
            lDiaZafra = New DIA_ZAFRA
            lDiaZafra.DIAZAFRA = 1
            lDiaZafra.ID_DIA_ZAFRA = -1
            listaDiasZafra.Add(lDiaZafra)
        ElseIf listaDiasZafra IsNot Nothing AndAlso listaDiasZafra.Count > 0 Then
            lDiaZafra = New DIA_ZAFRA
            lDiaZafra.DIAZAFRA = listaDiasZafra(0).DIAZAFRA + 1
            lDiaZafra.ID_DIA_ZAFRA = -1
            listaDiasZafra.Insertar(0, lDiaZafra)
        End If

        Me.cbxDIA_ZAFRA.DataSource = listaDiasZafra
        Me.cbxDIA_ZAFRA.DataBind()
        If cbxDIA_ZAFRA.Items.Count > 0 Then cbxDIA_ZAFRA.SelectedIndex = 0
    End Sub

    Private Sub CargarDiasZafraCierre()
        Dim listaDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, "DIAZAFRA", "DESC")
        Dim lDiaZafra As DIA_ZAFRA


        If listaDiasZafra Is Nothing Then listaDiasZafra = New listaDIA_ZAFRA
        If listaDiasZafra IsNot Nothing AndAlso listaDiasZafra.Count > 0 Then
            For i As Int32 = 0 To listaDiasZafra.Count - 1
                listaDiasZafra(i).USUARIO_CIERRE = listaDiasZafra(i).DIAZAFRA.ToString
            Next i
        End If
        lDiaZafra = New DIA_ZAFRA
        lDiaZafra.USUARIO_CIERRE = ""
        lDiaZafra.ID_DIA_ZAFRA = -1
        listaDiasZafra.Insertar(0, lDiaZafra)

        Me.cbxDIA_ZAFRA_CIERRE.DataSource = listaDiasZafra
        Me.cbxDIA_ZAFRA_CIERRE.DataBind()
        If cbxDIA_ZAFRA_CIERRE.Items.Count > 0 Then cbxDIA_ZAFRA_CIERRE.SelectedIndex = 0
    End Sub

    Private Sub ObtenerFechaHoraCierreDiaZafra()
        If cbxDIA_ZAFRA.Value IsNot Nothing AndAlso cbxDIA_ZAFRA.Value > 0 Then
            Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorZAFRA_DIA(Me.cbxZAFRA.Value, CInt(Me.cbxDIA_ZAFRA.Text))
            If lDiaZafra IsNot Nothing Then
                Me.dteFECHA_HORA_CORTE.Date = lDiaZafra.HORA_CIERRE
            End If
        Else
            Me.dteFECHA_HORA_CORTE.Date = cFechaHora.ObtenerFechaHora
        End If
    End Sub

    Private Sub ObtenerDiaZafra()
        Dim listaDiaZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, "DIAZAFRA", "ASC")
        Dim dia As Int32 = 1

        If listaDiaZafra IsNot Nothing AndAlso listaDiaZafra.Count > 0 Then
            For Each lDia As DIA_ZAFRA In listaDiaZafra
                If Me.dteFECHA_HORA_CORTE.Date > lDia.HORA_CIERRE Then
                    dia = lDia.DIAZAFRA
                ElseIf Me.dteFECHA_HORA_CORTE.Date = lDia.HORA_CIERRE Then
                    dia = lDia.DIAZAFRA
                    Exit For
                End If
            Next
        End If
        If Me.cbxDIA_ZAFRA.Items.FindByText(dia.ToString()) IsNot Nothing Then
            Me.cbxDIA_ZAFRA.SelectedItem = Me.cbxDIA_ZAFRA.Items.FindByText(dia.ToString())
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lCatorcena As CATORCENA_ZAFRA
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Dim listaDiaZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA, False, "FECHA", "DESC")
            If listaDiaZafra IsNot Nothing AndAlso listaDiaZafra.Count > 0 Then
                Me.dteFECHA_CORTE.Date = listaDiaZafra(0).FECHA
            End If
            lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCatorcenaActiva(lZafra.ID_ZAFRA)
            If lCatorcena IsNot Nothing Then

            End If
        End If

        Me.CargarCatorcenas()
        Me.CargarSemanas()
        Me.CargarDiasZafra()
        Me.CargarDiasZafraCierre()
    End Sub

    Protected Sub cbxCATORCENA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCATORCENA.ValueChanged
        Me.CargarSemanas()
    End Sub

    Protected Sub cbxDIA_ZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxDIA_ZAFRA.ValueChanged
        Me.ObtenerFechaHoraCierreDiaZafra()
    End Sub


    Protected Sub dteFECHA_HORA_CORTE_ValueChanged(sender As Object, e As System.EventArgs) Handles dteFECHA_HORA_CORTE.ValueChanged
         Me.ObtenerDiaZafra()
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarDiasZafra()
        Me.CargarDiasZafraCierre()
    End Sub
End Class
