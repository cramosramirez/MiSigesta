Imports SISPACAL.BL
Imports SISPACAL.EL
Partial Class controlesCenso_ucCriteriosQuerqueoInjiboaRela
    Inherits ucBase

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerDETALLE_POR_PAGINA() As Boolean
        Get
            Return Me.trDETALLE_POR_PAGINA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDETALLE_POR_PAGINA.Visible = value
        End Set
    End Property

    Public Property VerAGRUPAR_POR_LOTE() As Boolean
        Get
            Return Me.tblAGRUPAR_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.tblAGRUPAR_LOTE.Visible = value
        End Set
    End Property

    Public Property VerTIPO_PRODUCTOR() As Boolean
        Get
            Return Me.trTIPO_PRODUCTOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_PRODUCTOR.Visible = value
        End Set
    End Property

    Public Property VerTIPO_PRODUCTOR2() As Boolean
        Get
            Return Me.trTIPO_PRODUCTOR2.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_PRODUCTOR2.Visible = value
        End Set
    End Property

    Public Property VerPERIODO() As Boolean
        Get
            Return Me.trPERIODO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPERIODO.Visible = value
        End Set
    End Property

    Public Property VerPRODUCTOR() As Boolean
        Get
            Return Me.trPRODUCTOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPRODUCTOR.Visible = value
        End Set
    End Property

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

    Public Property DETALLE_POR_PAGINA() As Boolean
        Get
            Return Me.chkDetallePorPagina.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkDetallePorPagina.Checked = value
        End Set
    End Property

    Public Property AGRUPAR_POR_LOTE() As Boolean
        Get
            Return Me.chkAgruparLote.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkAgruparLote.Checked = value
        End Set
    End Property

    Public Property TIPO_PRODUCTOR() As Integer
        Get
            If Me.cbxTIPO_PRODUCTOR.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxTIPO_PRODUCTOR.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxTIPO_PRODUCTOR.Value = value
        End Set
    End Property

    Public Property TIPO_PRODUCTOR2() As String
        Get
            If Me.cbxTIPO_PRODUCTOR2.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxTIPO_PRODUCTOR2.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxTIPO_PRODUCTOR2.Value = value
        End Set
    End Property

    Public Property ID_PROVEE_QQ() As Integer
        Get
            If Me.cbxPROVEEDOR_QUERQUEO.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxPROVEEDOR_QUERQUEO.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxPROVEEDOR_QUERQUEO.Value = value
        End Set
    End Property

    Public Property PERIODO() As Integer
        Get
            If Me.cbxPERIODO.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxPERIODO.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxPERIODO.Value = value
        End Set
    End Property

    Public Property TIPO_FRENTE() As Integer
        Get
            If Me.cbxTIPO_FRENTE.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxTIPO_FRENTE.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxTIPO_FRENTE.Value = value
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            If Me.cbxPRODUCTOR.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxPRODUCTOR.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxPRODUCTOR.Value = value
        End Set
    End Property

    Public Property CATORCENA() As Integer
        Get
            If Me.cbxPeriodoCorte.Value Is Nothing Then
                Return -1
            Else
                Return CInt(Me.cbxPeriodoCorte.Text)
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxPeriodoCorte.Text = value
        End Set
    End Property

    Public ReadOnly Property FECHA_INI() As String
        Get
            If Me.dteFECHA_INI.Value Is Nothing Then
                Return ""
            Else
                Return Me.dteFECHA_INI.Date.ToString("dd/MM/yyyy HH:mm")
            End If
        End Get
    End Property
    Public ReadOnly Property FECHA_FIN() As String
        Get
            If Me.dteFECHA_FIN.Value Is Nothing Then
                Return ""
            Else
                Return Me.dteFECHA_FIN.Date.ToString("dd/MM/yyyy HH:mm")
            End If
        End Get
    End Property

    Public ReadOnly Property DIA_ZAFRA1() As Integer
        Get
            If Me.cbxDIA_ZAFRA1.Value IsNot Nothing Then
                Dim s As String
                s = Mid(Me.cbxDIA_ZAFRA1.Text, 1, InStr(1, Me.cbxDIA_ZAFRA1.Text, " ") - 1)
                Return CInt(s)
            Else
                Return -1
            End If
        End Get
    End Property
    Public ReadOnly Property DIA_ZAFRA2() As Integer
        Get
            If Me.cbxDIA_ZAFRA2.Value IsNot Nothing Then
                Dim s As String
                s = Mid(Me.cbxDIA_ZAFRA2.Text, 1, InStr(1, Me.cbxDIA_ZAFRA2.Text, " ") - 1)
                Return CInt(s)
            Else
                Return -1
            End If
        End Get
    End Property

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.CargarCatorcenas()
            Me.CargarDias()
        End If
    End Sub

    Private Sub CargarDias()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
        Dim lista As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, "DIAZAFRA", "DESC")
        If lista Is Nothing Then lista = New listaDIA_ZAFRA
        If lZafra IsNot Nothing Then
            Dim poseeDia As Boolean = False
            For i As Int32 = 0 To lista.Count - 1
                If lista(i).DIAZAFRA = lZafra.DIAZAFRA Then
                    poseeDia = True
                    Exit For
                End If
            Next
            If Not poseeDia Then
                Dim lDia As New DIA_ZAFRA
                lDia.ID_DIA_ZAFRA = -1
                lDia.DIAZAFRA = lZafra.DIAZAFRA
                lDia.DESCRIPCION_DIA = lDia.DIAZAFRA.ToString + "  " + "(A LA FECHA/HORA ACTUAL)"
                lista.Insertar(0, lDia)
            End If
        End If
        Me.cbxDIA_ZAFRA1.DataSource = lista
        Me.cbxDIA_ZAFRA1.DataBind()

        Me.cbxDIA_ZAFRA2.DataSource = lista
        Me.cbxDIA_ZAFRA2.DataBind()
    End Sub

    Private Sub ConfigurarPeriodo()
        Dim Id As Integer = 0

        If Me.cbxPERIODO.Value IsNot Nothing Then
            Id = CInt(Me.cbxPERIODO.Value)
        End If
        If Id = 1 Then
            Me.trPERIODO_CORTE.Visible = False
            'Me.trPERIODO_RANGO_FECHAS.Visible = True
            Me.trPERIODO_DIAS_ZAFRA.Visible = True
            Me.dteFECHA_INI.Value = Nothing
            Me.dteFECHA_FIN.Value = Nothing
        ElseIf Id = 2 OrElse Id = 3 Then
            Me.trPERIODO_CORTE.Visible = False
            'Me.trPERIODO_RANGO_FECHAS.Visible = False
            Me.trPERIODO_DIAS_ZAFRA.Visible = False
        ElseIf Id = 4 Then
            Me.trPERIODO_CORTE.Visible = True
            'Me.trPERIODO_RANGO_FECHAS.Visible = False
            Me.trPERIODO_DIAS_ZAFRA.Visible = False
        Else
            Me.trPERIODO_CORTE.Visible = False
            'Me.trPERIODO_RANGO_FECHAS.Visible = False
            Me.trPERIODO_DIAS_ZAFRA.Visible = False
        End If
    End Sub

    Private Sub CargarTiposFrentes()
        Dim strCodiProveedor As String = ""

        If Me.cbxPRODUCTOR.Value IsNot Nothing Then
            strCodiProveedor = CStr(cbxPRODUCTOR.Value)
        End If

        Me.cbxTIPO_FRENTE.Items.Clear()

        Select Case strCodiProveedor
            Case "0142870000", "0145300000", "0150380000"
                Me.cbxTIPO_FRENTE.Items.Add("TODOS", 1)
                Me.cbxTIPO_FRENTE.Items.Add("PARTICULARES", 2)
                Me.cbxTIPO_FRENTE.Items.Add("QR004 INJIBOA", 3)
                Me.cbxTIPO_FRENTE.Items.Add("POR FRENTE", 5)

            Case "0140150000"
                Me.cbxTIPO_FRENTE.Items.Add("TODOS", 1)
                Me.cbxTIPO_FRENTE.Items.Add("PARTICULARES", 2)
                Me.cbxTIPO_FRENTE.Items.Add("QR099 PROPIO", 4)
                Me.cbxTIPO_FRENTE.Items.Add("POR FRENTE", 5)
        End Select
    End Sub

    Private Sub CargarCatorcenas()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
        Dim lista As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
        If lista Is Nothing Then lista = New listaCATORCENA_ZAFRA
        If lZafra IsNot Nothing Then
            Dim poseeCorte As Boolean = False
            For i As Int32 = 0 To lista.Count - 1
                If lista(i).CATORCENA = lZafra.CATORCENA Then
                    poseeCorte = True
                    Exit For
                End If
            Next
            If Not poseeCorte Then
                Dim lCatorcena As New CATORCENA_ZAFRA
                lCatorcena.ID_CATORCENA = -1
                lCatorcena.CATORCENA = lZafra.CATORCENA
                lista.Insertar(0, lCatorcena)
            End If
        End If
        Me.cbxPeriodoCorte.DataSource = lista
        Me.cbxPeriodoCorte.DataBind()
    End Sub

    Private Sub CargarProveedoresQuerqueoParti()
        Dim idZafra As Integer = -1
        Dim codiproveedor As String = ""
        Dim catorcena As Integer = -1
        Dim lista As listaPROVEEDOR_QUERQUEO

        Me.cbxPROVEEDOR_QUERQUEO.Text = ""
        If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = CInt(Me.cbxZAFRA.Value)
        If Me.cbxPRODUCTOR.Value IsNot Nothing Then codiproveedor = CStr(Me.cbxPRODUCTOR.Value)
        If Me.cbxPERIODO.Value IsNot Nothing AndAlso CInt(Me.cbxPERIODO.Value) = 4 Then
            catorcena = CInt(cbxPeriodoCorte.Value)
        End If
        lista = (New cPROVEEDOR_QUERQUEO).ObtenerListaPorREPORTE_QUERQUEO_INJIBOA_RELA(idZafra, codiproveedor, catorcena, "NOMBRES, APELLIDOS")
        If lista Is Nothing Then lista = New listaPROVEEDOR_QUERQUEO
        Me.cbxPROVEEDOR_QUERQUEO.DataSource = lista
        Me.cbxPROVEEDOR_QUERQUEO.DataBind()
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        CargarCatorcenas()
        CargarProveedoresQuerqueoParti()
        CargarDias()
    End Sub

    Protected Sub cbxPeriodoCorte_DataBound(sender As Object, e As System.EventArgs) Handles cbxPeriodoCorte.DataBound
        If Me.cbxPeriodoCorte.Items.Count > 0 Then Me.cbxPeriodoCorte.SelectedIndex = 0
    End Sub

    Protected Sub cbxPERIODO_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxPERIODO.ValueChanged
        ConfigurarPeriodo()
        CargarProveedoresQuerqueoParti()
    End Sub

    Private Sub cbxPRODUCTOR_ValueChanged(sender As Object, e As EventArgs) Handles cbxPRODUCTOR.ValueChanged
        CargarTiposFrentes()
        ConfigurarProveedorQuerqueoParti()
        CargarProveedoresQuerqueoParti()
    End Sub

    Private Sub cbxPeriodoCorte_ValueChanged(sender As Object, e As EventArgs) Handles cbxPeriodoCorte.ValueChanged
        CargarProveedoresQuerqueoParti()
    End Sub
    Private Sub cbxTIPO_FRENTE_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_FRENTE.ValueChanged
        ConfigurarProveedorQuerqueoParti()
    End Sub

    Private Sub ConfigurarProveedorQuerqueoParti()
        If cbxTIPO_FRENTE.Value IsNot Nothing AndAlso cbxTIPO_FRENTE.Value = 5 Then
            trPROVEEDOR_QUERQUEO_PARTI.Visible = True
        Else
            trPROVEEDOR_QUERQUEO_PARTI.Visible = False
        End If
    End Sub

End Class
