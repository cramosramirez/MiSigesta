Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.DL
Imports System.Collections.Generic

Partial Class controles_ucAsignarCuentaContableProveedor
    Inherits ucBase


    Public Property ID_TIPO_PROVEEDOR As Integer
        Get
            If Me.ViewState("ID_TIPO_PROVEEDOR") Is Nothing Then Return 0
            Return Me.ViewState("ID_TIPO_PROVEEDOR")
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("ID_TIPO_PROVEEDOR") = value
        End Set
    End Property
    Public Property INDICE_SELECCIONADO As Integer
        Get
            If Me.ViewState("INDICE_SELECCIONADO") Is Nothing Then Return ""
            Return Me.ViewState("INDICE_SELECCIONADO")
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("INDICE_SELECCIONADO") = value
        End Set
    End Property

    Public Sub Inicializar()
        Me.lblTitulo.Text = "Asignación de Cuenta Contable a Proveedor"
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = True
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ddlTIPO_PROVEEDOR1.Recuperar()
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Public Sub CargarProveedoresPorCriterios()
        Dim ds As New DataSet
        Dim bCuentaProveedor As New cCUENTA_PROVEEDOR
        ds = bCuentaProveedor.ObtenerDataSetPorTipoProveedor(Me.ddlTIPO_PROVEEDOR1.SelectedValue, Me.txtCODIPROVEE.Text.Trim.ToUpper, Me.txtCODSOCIO.Text)
        If ds Is Nothing Then
            Me.grdProveedores.Visible = False
        End If
        Me.grdProveedores.SelectedIndex = -1
        Me.grdProveedores.Visible = True
        Me.grdProveedores.DataSource = ds
        Me.grdProveedores.DataBind()
        If bCuentaProveedor.sError <> "" Then
            AsignarMensaje("* Error en consulta: " + bCuentaProveedor.sError, True, False)
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_Guardar(sender As Object, e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim codigo As String
        Dim lista As New List(Of String)
        Dim bCuentaProveedor As New cCUENTA_PROVEEDOR
        Dim lCuentaProveedor As CUENTA_PROVEEDOR

        AsignarMensaje("", True)
        If grdProveedores.SelectedValue Is Nothing Then
            AsignarMensaje("* Seleccione un Proveedor", True)
            Return
        End If
        codigo = grdProveedores.SelectedDataKey.Value
        If Me.txtCUENTA_CONTABLE.Text.Trim = "" Then
            AsignarMensaje("* Ingrese el numero de cuenta contable", True)
            txtCUENTA_CONTABLE.Focus()
            Return
        End If

        lCuentaProveedor = bCuentaProveedor.ObtenerPorCODIGO_TIPO_PROVEEDOR(codigo, Me.ID_TIPO_PROVEEDOR)
        If lCuentaProveedor IsNot Nothing AndAlso lCuentaProveedor.ID_CUENTA_PROVEEDOR > 0 Then
            lCuentaProveedor.CUENTA = Me.txtCUENTA_CONTABLE.Text
            lCuentaProveedor.USUARIO_ACT = Me.ObtenerUsuario
            lCuentaProveedor.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            lCuentaProveedor = New CUENTA_PROVEEDOR
            lCuentaProveedor.CUENTA = Me.txtCUENTA_CONTABLE.Text.Trim
            lCuentaProveedor.CODIGO = codigo
            lCuentaProveedor.ID_CUENTA_PROVEEDOR = 0
            lCuentaProveedor.ID_TIPO_PROVEEDOR = Me.ID_TIPO_PROVEEDOR
            lCuentaProveedor.USUARIO_CREA = Me.ObtenerUsuario
            lCuentaProveedor.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lCuentaProveedor.USUARIO_ACT = Me.ObtenerUsuario
            lCuentaProveedor.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        bCuentaProveedor.ActualizarCUENTA_PROVEEDOR(lCuentaProveedor)
        Me.txtCUENTA_CONTABLE.Text = ""
        INDICE_SELECCIONADO = grdProveedores.SelectedIndex
        CargarProveedoresPorCriterios()
        grdProveedores.SelectedIndex = INDICE_SELECCIONADO
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        AsignarMensaje("", True, False)

        Select Case CommandName
            Case "Buscar"
                ObtenerProveedor()
                txtCUENTA_CONTABLE.Text = ""
                If Me.ddlTIPO_PROVEEDOR1.SelectedValue IsNot Nothing Then
                    Me.ID_TIPO_PROVEEDOR = Me.ddlTIPO_PROVEEDOR1.SelectedValue
                    CargarProveedoresPorCriterios()
                Else
                    AsignarMensaje("* Seleccione un Tipo de Proveedor", True)
                    Return
                End If
                If Me.grdProveedores.Rows.Count = 0 AndAlso (txtCODIPROVEE.Text <> "" OrElse txtCODSOCIO.Text <> "") Then
                    MostrarMensaje("Proveedor no existe", "Alerta")
                End If
                If Me.grdProveedores.Rows.Count = 0 AndAlso txtCODIPROVEE.Text = "" AndAlso txtCODSOCIO.Text = "" Then
                    MostrarMensaje("No existen proveedores con los criterios seleccionados", "Alerta")
                End If
        End Select
    End Sub

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.txtCODIPROVEE.Text.Trim = "" Then
            Return
        End If
        Select Case ddlTIPO_PROVEEDOR1.SelectedValue
            Case Enumeradores.TipoProveedor.Cañero
                Dim lProveedor As PROVEEDOR
                Dim Codiprovee As String = Utilerias.RellenarIzquierda(Me.txtCODIPROVEE.Text, 6)
                Dim Codisocio As String = Utilerias.RellenarIzquierda(Me.txtCODSOCIO.Text, 4)

                lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(Codiprovee + Codisocio)
                If lProveedor IsNot Nothing Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
                Else
                    Me.txtNOMBRE_PROVEEDOR.Text = ""
                End If

            Case Enumeradores.TipoProveedor.Transportista
                Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Convert.ToInt32(Me.txtCODIPROVEE.Text))
                If lTransportista IsNot Nothing Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lTransportista.NOMBRES.Trim + " " + lTransportista.APELLIDOS.Trim
                End If

            Case Enumeradores.TipoProveedor.FrenteRoza
                Dim lRozador As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPorCODIGO(Me.txtCODIPROVEE.Text.ToUpper.Trim)
                If lRozador IsNot Nothing Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lRozador.NOMBRE_PROVEEDOR_ROZA
                End If

            Case Enumeradores.TipoProveedor.Cargador
                Dim lProveeCarga As PROVEEDOR_CARGA = (New cPROVEEDOR_CARGA).ObtenerPROVEEDOR_CARGA(Convert.ToInt32(Me.txtCODIPROVEE.Text))
                If lProveeCarga IsNot Nothing Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lProveeCarga.NOMBRE_PROVEEDOR_CARGA
                End If

            Case Enumeradores.TipoProveedor.FrenteQuerqueo
                Dim lstQuerqueo As listaPROVEEDOR_QUERQUEO = (New cPROVEEDOR_QUERQUEO).ObtenerListaPorCODISIS(Me.txtCODIPROVEE.Text.ToUpper.Trim)
                If lstQuerqueo IsNot Nothing AndAlso lstQuerqueo.Count > 0 Then
                    Me.txtNOMBRE_PROVEEDOR.Text = lstQuerqueo(0).NOMBRES + " " + lstQuerqueo(0).APELLIDOS
                End If
        End Select
    End Sub

    Protected Sub txtCODIPROVEE_TextChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.TextChanged
        ObtenerProveedor()
    End Sub

    Protected Sub txtCODSOCIO_TextChanged(sender As Object, e As System.EventArgs) Handles txtCODSOCIO.TextChanged
        ObtenerProveedor()
    End Sub

    Protected Sub grdProveedores_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grdProveedores.PageIndexChanging
        Me.grdProveedores.PageIndex = e.NewPageIndex
        Me.CargarProveedoresPorCriterios()
    End Sub

    Protected Sub ddlTIPO_PROVEEDOR1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTIPO_PROVEEDOR1.SelectedIndexChanged
        Me.txtCODSOCIO.Enabled = (ddlTIPO_PROVEEDOR1.SelectedValue = Enumeradores.TipoProveedor.Cañero)
        Me.txtCODIPROVEE.Text = ""
        Me.txtCODSOCIO.Text = ""
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtCUENTA_CONTABLE.Text = ""
    End Sub
End Class
