Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Partial Class controlesFrentes_ucMantCCF_ENCA_FRENTE
    Inherits ucBase

    Public Property TIPO_PROVEEDOR() As Enumeradores.TipoProveedor
        Get
            If Me.ViewState("TIPO_PROVEEDOR") IsNot Nothing Then
                Return CInt(Me.ViewState("TIPO_PROVEEDOR"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Enumeradores.TipoProveedor)
            Me.ViewState("TIPO_PROVEEDOR") = Value
        End Set
    End Property

    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        If TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteRoza Then
            Me.lblTitulo.Text = "FRENTES DE ROZA - Comprobantes de Crédito Fiscal/Facturas"
        ElseIf TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteQuerqueo Then
            Me.lblTitulo.Text = "FRENTES DE QUERQUEO - Comprobantes de Crédito Fiscal/Facturas"
        End If
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaCCF_ENCA_FRENTE1.Visible = True
        Me.ucVistaDetalleCCF_ENCA_FRENTE1.Visible = False
    End Sub
    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", Not editarEmision)
        Me.ucListaCCF_ENCA_FRENTE1.Visible = False
        Me.ucVistaDetalleCCF_ENCA_FRENTE1.TIPO_PROVEEDOR = Me.TIPO_PROVEEDOR
        Me.ucVistaDetalleCCF_ENCA_FRENTE1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nuevo CCF/Factura", False, IconoBarra.Agregar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.CargarDatos()
    End Sub

    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarCCF_ENCA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarCCF_ENCA() As Integer
        If Me.ucListaCCF_ENCA_FRENTE1.CargarDatosPorTIPO_PROVEEDOR(TIPO_PROVEEDOR) <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaCCF_ENCA_FRENTE1_Editando(ByVal ID_CCF_ENCA As Int32) Handles ucListaCCF_ENCA_FRENTE1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleCCF_ENCA_FRENTE1.ID_CCF_ENCA = ID_CCF_ENCA
    End Sub

    Protected Sub cpMantCCF_ENCA_FRENTE_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantCCF_ENCA_FRENTE.Callback
        Me.ucVistaDetalleCCF_ENCA_FRENTE1.SetearSubTotalIvaTotal()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "Agregar"
                Me.ucVistaDetalleCCF_ENCA_FRENTE1.LimpiarControles()
                Me.ucVistaDetalleCCF_ENCA_FRENTE1.ID_CCF_ENCA = 0
                Me.InicializarDetalle()

            Case "Exportar"
                Me.ucListaCCF_ENCA_FRENTE1.ExportarExcel()

            Case "Guardar"
                Dim lRet As String

                lRet = Me.ucVistaDetalleCCF_ENCA_FRENTE1.Actualizar
                If lRet <> "" Then
                    Me.AsignarMensaje(lRet, True, False)
                    Exit Sub
                End If
                Me.ucVistaDetalleCCF_ENCA_FRENTE1.LimpiarControles()
                Me.ucVistaDetalleCCF_ENCA_FRENTE1.ID_CCF_ENCA = 0
                Me.InicializarLista()
                Me.ucListaCCF_ENCA_FRENTE1.DataBind()
                Me.AsignarMensaje("Se ha registrado la Facturacion", False, True, True)

                Me.AsignarMensaje("", True, False)

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.InicializarLista()
        End Select
    End Sub
End Class
