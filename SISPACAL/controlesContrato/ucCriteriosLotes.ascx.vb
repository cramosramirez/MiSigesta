Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesMaestro_ucCriteriosLotes
    Inherits ucBase


#Region "Propiedades"
    Public ReadOnly Property CODI_DETO As String
        Get
            If Me.cbxDEPARTAMENTO.Value Is Nothing Then Return ""
            Return Me.cbxDEPARTAMENTO.Value
        End Get
    End Property

    Public ReadOnly Property CODI_MUNI As String
        Get
            If Me.cbxMUNICIPIO.Value Is Nothing Then Return ""
            Return Me.cbxMUNICIPIO.Value
        End Get
    End Property

    Public ReadOnly Property CODI_CANTON As String
        Get
            If Me.cbxCANTON.Value Is Nothing Then Return ""
            Return Me.cbxCANTON.Value
        End Get
    End Property

    Public ReadOnly Property ZONA As String
        Get
            If Me.cbxZONA.Value Is Nothing Then Return ""
            Return Me.cbxZONA.Value.ToString.Trim
        End Get
    End Property

    Public ReadOnly Property SUB_ZONA As String
        Get
            If Me.cbxSUB_ZONA.Value Is Nothing Then Return ""
            Return Me.cbxSUB_ZONA.Value
        End Get
    End Property

    Public ReadOnly Property CODIPROVEE As String
        Get
            If Me.txtCODIPROVEE.Value Is Nothing Then Return ""
            Return Me.txtCODIPROVEE.Value
        End Get
    End Property

    Public ReadOnly Property ID_ZAFRA As Integer
        Get
            If Me.cbxZAFRA.Value Is Nothing Then Return -1
            Return Convert.ToInt32(Me.cbxZAFRA.Value)
        End Get
    End Property

    Public ReadOnly Property CODISOCIO As String
        Get
            If Me.txtCODISOCIO.Value Is Nothing Then Return ""
            Return Me.txtCODISOCIO.Value
        End Get
    End Property

    Public ReadOnly Property NOMBRE_PROVEEDOR As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR.Value
        End Get
    End Property

    Public ReadOnly Property CODICONTRATO As Integer
        Get
            If Me.spnCONTRATO.Value Is Nothing OrElse Me.spnCONTRATO.Value = 0 Then
                Return -1
            Else
                Return Me.spnCONTRATO.Value
            End If
        End Get
    End Property
#End Region

#Region "CargaDatos"

    Private Sub CargarSubZonas()
        Me.odsSubZona.SelectParameters("ZONA").DefaultValue = cbxZONA.Value
        Me.odsSubZona.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsSubZona.SelectParameters("agregarTodos").DefaultValue = False
        Me.cbxSUB_ZONA.DataBind()
    End Sub

    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO.Value
        Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = True
        Me.cbxMUNICIPIO.DataBind()
    End Sub

    Private Sub CargarCantones()
        Me.odsCanton.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO.Value
        Me.odsCanton.SelectParameters("CODI_MUNI").DefaultValue = cbxMUNICIPIO.Value
        Me.odsCanton.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsCanton.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsCanton.SelectParameters("conPresencia").DefaultValue = True
        Me.cbxCANTON.DataBind()
    End Sub
#End Region

    Protected Sub cbxZONA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxZONA.SelectedIndexChanged
        Me.cbxSUB_ZONA.Text = ""
        CargarSubZonas()
    End Sub

    Protected Sub cbxDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxDEPARTAMENTO.SelectedIndexChanged
        Me.cbxMUNICIPIO.Text = ""
        Me.cbxCANTON.Text = ""
        CargarMunicipios()
    End Sub

    Protected Sub cbxMUNICIPIO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxMUNICIPIO.SelectedIndexChanged
        Me.cbxCANTON.Text = ""
        CargarCantones()
    End Sub

    Private Sub controlesMaestro_ucCriteriosLotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            If lZafra IsNot Nothing Then
                Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            End If
        End If
    End Sub
End Class
