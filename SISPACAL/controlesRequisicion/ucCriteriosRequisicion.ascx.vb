Imports SISPACAL.EL
Imports SISPACAL.BL

Partial Class controlesRequisicion_ucCriteriosRequisicion
    Inherits ucBase



#Region "Valores"
    Public Property ID_PERIODOREQ() As Int32
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

    Public Property ID_SECCION() As Int32
        Get
            If Me.cbxID_SECCION.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxID_SECCION.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxID_SECCION.Value = value
        End Set
    End Property

    Public Property ID_SOLICITANTE() As Int32
        Get
            If Me.cbxID_SOLICITANTE.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxID_SOLICITANTE.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxID_SOLICITANTE.Value = value
        End Set
    End Property


    Public Property CODI_REQ() As String
        Get
            Me.txtNUM_SOLICITUD.Text = Me.txtNUM_SOLICITUD.Text.Trim.ToUpper
            If Me.txtNUM_SOLICITUD.Value Is Nothing Then
                Return ""
            Else
                Return Me.txtNUM_SOLICITUD.Value
            End If
        End Get
        Set(ByVal value As String)
            Me.txtNUM_SOLICITUD.Value = value
        End Set
    End Property

    Public Property FECHA_EMISION_INI() As DateTime
        Get
            If dteFECHA_EMISION_INI.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFECHA_EMISION_INI.Date
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_EMISION_INI.Date = value
        End Set
    End Property

    Public Property ETAPA() As Int32
        Get
            If Me.cbxETAPA.Value Is Nothing Then
                Return -1
            Else
                Return Me.cbxETAPA.Value
            End If
        End Get
        Set(ByVal value As Integer)
            Me.cbxETAPA.Value = value
        End Set
    End Property

    Public Property FECHA_EMISION_FIN() As Date
        Get
            If dteFECHA_EMISION_FIN.Value Is Nothing Then
                Return #12:00:00 AM#
            End If
            Return Me.dteFECHA_EMISION_FIN.Date
        End Get
        Set(ByVal value As Date)
            Me.dteFECHA_EMISION_FIN.Date = value
        End Set
    End Property

    Public Property HabilitarSECCION() As Boolean
        Get
            Return cbxID_SECCION.ClientEnabled
        End Get
        Set(ByVal value As Boolean)
            Me.cbxID_SECCION.Value = value
        End Set
    End Property


#End Region

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lPeriodo As PERIODOREQ = (New cPERIODOREQ).ObtenerPeriodoReqActivo
        If lPeriodo IsNot Nothing Then
            Me.cbxPERIODO.Value = lPeriodo.ID_PERIODOREQ
        End If
        Me.cbxETAPA.Value = -1
    End Sub
End Class
