Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

Partial Class controlesCenso_ucCriteriosCenso
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

    Public Property VerDIA_ZAFRA() As Boolean
        Get
            Return Me.trDIA_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIA_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerID_CENSO() As Boolean
        Get
            Return Me.trID_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CENSO.Visible = value
        End Set
    End Property

    Public Property VerSUB_ZONA() As Boolean
        Get
            Return Me.lblSubZona.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblSubZona.ClientVisible = value
            Me.cbxSUB_ZONA.ClientVisible = value
        End Set
    End Property

    Public Property VerCANTON() As Boolean
        Get
            Return Me.trCANTON.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCANTON.Visible = value
        End Set
    End Property

    Public Property VerUNIDAD_MEDIDA() As Boolean
        Get
            Return Me.trUNIDAD_MEDIDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUNIDAD_MEDIDA.Visible = value
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
    Public Property VerNIVEL() As Boolean
        Get
            Return Me.trNIVEL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIVEL.Visible = value
        End Set
    End Property

    Public Property VerMOSTRAR_POR01() As Boolean
        Get
            Return Me.trMostrarPor01.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMostrarPor01.Visible = value
        End Set
    End Property
    Public Property VerMOSTRAR_POR02() As Boolean
        Get
            Return Me.trMostrarPor02.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMostrarPor02.Visible = value
        End Set
    End Property
    Public Property VerMOSTRAR_POR03() As Boolean
        Get
            Return Me.trMostrarPor03.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMostrarPor03.Visible = value
        End Set
    End Property
    Public Property VerMOSTRAR_POR04() As Boolean
        Get
            Return Me.trMostrarPor04.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMostrarPor04.Visible = value
        End Set
    End Property

   
    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Public Property VerTIPO_DETALLE() As Boolean
        Get
            Return Me.trTIPO_DETALLE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_DETALLE.Visible = value
        End Set
    End Property

    Public Property VerTC_ENTREGADA_ZA() As Boolean
        Get
            Return Me.trTC_ENTREGADA_ZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTC_ENTREGADA_ZA.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.trCODIPROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerENTREGA_CANA_CIERRE() As Boolean
        Get
            Return Me.trENTREGA_CANA_CIERRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trENTREGA_CANA_CIERRE.Visible = value
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


    Public Property ID_CENSO() As Integer
        Get
            If Me.cbxCENSO.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxCENSO.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxCENSO.Value = value
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

    Public Property UNIDAD_MEDIDA() As Integer
        Get
            If Me.cbxUnidadMedida.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxUnidadMedida.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxUnidadMedida.Value = value
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

    Public Property NIVEL() As Integer
        Get
            If Me.cbxNivel.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxNivel.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxNivel.Value = value
        End Set
    End Property

    Public Property MOSTRAR_POR01() As String
        Get
            If Me.cbxMostrarPor01.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxMostrarPor01.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxMostrarPor01.Value = value
        End Set
    End Property
    Public Property MOSTRAR_POR02() As String
        Get
            If Me.cbxMostrarPor02.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxMostrarPor02.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxMostrarPor02.Value = value
        End Set
    End Property
    Public Property MOSTRAR_POR03() As String
        Get
            If Me.cbxMostrarPor03.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxMostrarPor03.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxMostrarPor03.Value = value
        End Set
    End Property
    Public Property MOSTRAR_POR04() As String
        Get
            If Me.cbxMostrarPor04.Value Is Nothing Then
                Return ""
            Else
                Return Me.cbxMostrarPor04.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.cbxMostrarPor04.Value = value
        End Set
    End Property

    Public Property ZONA() As String
        Get
            If Me.cbxZONA.Value Is Nothing Then Return ""
            Return Me.cbxZONA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxZONA.Value = value.ToString()
        End Set
    End Property

    Public Property SUB_ZONA() As String
        Get
            If Me.cbxSUB_ZONA.Value Is Nothing Then Return ""
            Return Me.cbxSUB_ZONA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxSUB_ZONA.Value = value.ToString()
        End Set
    End Property

    Public Property CODI_DEPTO() As String
        Get
            If Me.cbxDEPARTAMENTO.Value Is Nothing Then Return ""
            Return Me.cbxDEPARTAMENTO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxDEPARTAMENTO.Value = value.ToString()
        End Set
    End Property
    Public Property CODI_MUNI() As String
        Get
            If Me.cbxMUNICIPIO.Value Is Nothing Then Return ""
            Return Me.cbxMUNICIPIO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxMUNICIPIO.Value = value.ToString()
        End Set
    End Property
    Public Property CODI_CANTON() As String
        Get
            If Me.cbxCANTON.Value Is Nothing Then Return ""
            Return Me.cbxCANTON.Value
        End Get
        Set(ByVal value As String)
            Me.cbxCANTON.Value = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            Return Me.txtCODIPROVEE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIPROVEE.Text = value.ToString()
        End Set
    End Property

    Public Property CODISOCIO() As String
        Get
            Return Me.txtCODISOCIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODISOCIO.Text = value.ToString()
        End Set
    End Property
   
    Public Property TIPO_DETALLE() As Integer
        Get
            If Me.cbxTipoDetalle.Value Is Nothing OrElse Not IsNumeric(Me.cbxTipoDetalle.Value) Then
                Return -1
            End If
            Return Me.cbxTipoDetalle.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxTipoDetalle.Value = value
        End Set
    End Property

    Public Property TC_ENTREGA_ZA() As Integer
        Get
            If Me.cbxRangoEntrega.Value Is Nothing OrElse Not IsNumeric(Me.cbxRangoEntrega.Value) Then
                Return -1
            End If
            Return Me.cbxRangoEntrega.Value
        End Get
        Set(ByVal value As Integer)
            Me.cbxRangoEntrega.Value = value
        End Set
    End Property

    Public Property ENTREGA_CANA_CIERRE() As Boolean
        Get
            Return Me.chkEntregaCanaCierre.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkEntregaCanaCierre.Checked = value
        End Set
    End Property

    Public Property ID_ZAFRA_AUTOPOSTBACK As Boolean
        Get
            Return Me.cbxZAFRA.AutoPostBack
        End Get
        Set(value As Boolean)
            Me.cbxZAFRA.AutoPostBack = value
        End Set
    End Property

#End Region


    ' Tercer commit
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.CargarDias()
            Me.CargarCatorcenas()
        End If
        Me.cbxTipoDetalle.SelectedIndex = -1
    End Sub

    Protected Sub cbxDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxDEPARTAMENTO.SelectedIndexChanged
        Me.cbxMUNICIPIO.Text = ""
        Me.cbxCANTON.Text = ""
    End Sub

    Protected Sub cbxMUNICIPIO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxMUNICIPIO.SelectedIndexChanged
        Me.cbxCANTON.Text = ""
    End Sub

    Protected Sub cbxZONA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxZONA.SelectedIndexChanged
        Me.cbxSUB_ZONA.Text = ""
    End Sub

    Protected Sub cbxCENSO_DataBound(sender As Object, e As System.EventArgs) Handles cbxCENSO.DataBound
        If cbxCENSO.Items.Count > 0 Then cbxCENSO.SelectedIndex = cbxCENSO.Items.Count - 1
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
                lista.Insertar(0, lDia)
            End If
        End If
        Me.cbxDIA_ZAFRA.DataSource = lista
        Me.cbxDIA_ZAFRA.DataBind()
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

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarDias()
        Me.CargarCatorcenas()
    End Sub

    Protected Sub cbxDIA_ZAFRA_DataBound(sender As Object, e As System.EventArgs) Handles cbxDIA_ZAFRA.DataBound
        If Me.cbxDIA_ZAFRA.Items.Count > 0 Then Me.cbxDIA_ZAFRA.SelectedIndex = 0
    End Sub

    Protected Sub cbxPeriodoCorte_DataBound(sender As Object, e As System.EventArgs) Handles cbxPeriodoCorte.DataBound
        If Me.cbxPeriodoCorte.Items.Count > 0 Then Me.cbxPeriodoCorte.SelectedIndex = 0
    End Sub

    Protected Sub cbxPERIODO_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxPERIODO.ValueChanged
        Select Case Me.cbxPERIODO.Value
            Case 1
                Me.trPERIODO_CORTE.Visible = True
                Me.trPERIODO_RANGO_FECHAS.Visible = False
            Case 2
                Me.trPERIODO_CORTE.Visible = False
                Me.trPERIODO_RANGO_FECHAS.Visible = False
            Case 3
                Me.trPERIODO_CORTE.Visible = False
                Me.trPERIODO_RANGO_FECHAS.Visible = True
                Me.dteFECHA_INI.Value = Nothing
                Me.dteFECHA_FIN.Value = Nothing
        End Select
    End Sub
End Class
