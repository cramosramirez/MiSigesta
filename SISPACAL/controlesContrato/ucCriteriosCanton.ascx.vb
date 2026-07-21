
Partial Class controlesContrato_ucCriteriosCanton
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

    
#End Region

#Region "CargaDatos"

    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO.Value
        Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = False
        Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxMUNICIPIO.DataBind()
    End Sub

    Private Sub CargarCantones()
        Me.odsCanton.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO.Value
        Me.odsCanton.SelectParameters("CODI_MUNI").DefaultValue = cbxMUNICIPIO.Value
        Me.odsCanton.SelectParameters("agregarVacio").DefaultValue = False
        Me.odsCanton.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsCanton.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxCANTON.DataBind()
    End Sub
#End Region

    Protected Sub cbxDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxDEPARTAMENTO.SelectedIndexChanged
        CargarMunicipios()
    End Sub

    Protected Sub cbxMUNICIPIO_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxMUNICIPIO.SelectedIndexChanged
        CargarCantones()
    End Sub

End Class
