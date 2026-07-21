Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.EL
Imports SISPACAL.BL

Partial Class controlesBodega_ucSolicitudesProductoConsignado
    Inherits ucBase


#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SALBODE_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------


    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then
            Me.ucCriteriosSolicitudesProductoConsignacion1.ID_ZAFRA = lZafraActiva.ID_ZAFRA
        End If

        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("EntregadoIgualCantidad", "Aplicar Entregado igual a Solicitado", False, IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("AnularProducto", "Anular producto solicitado", False, IconoBarra.Anular, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("EntregadoIgualCantidad", True)
        Me.ucBarraNavegacion1.VerOpcion("AnularProducto", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
    End Sub
#End Region

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim mIdZafra As Int32 = Me.ucCriteriosSolicitudesProductoConsignacion1.ID_ZAFRA
                Dim mFechaIni As String
                Dim mFechaFin As String
                Dim mNumSolic As Int32 = Me.ucCriteriosSolicitudesProductoConsignacion1.NUM_SOLICITUD
                Dim mNumSalde As Int32 = Me.ucCriteriosSolicitudesProductoConsignacion1.NO_DOCUMENTO
                Dim mCodiProvee As String = Me.ucCriteriosSolicitudesProductoConsignacion1.CODIPROVEEDOR
                Dim mIdProveeAgri As Int32 = Me.ucCriteriosSolicitudesProductoConsignacion1.ID_PROVEEDOR_AGRICOLA
                Dim mIdCuentaFinan As Int32 = Me.ucCriteriosSolicitudesProductoConsignacion1.ID_CUENTA_FINAN
                Dim mIdEstado As Int32 = Me.ucCriteriosSolicitudesProductoConsignacion1.ID_ESTADO

                If Me.ucCriteriosSolicitudesProductoConsignacion1.PERIODO = 1 Then
                    mFechaIni = ""
                    mFechaFin = Today.ToString("dd/MM/yyyy")
                Else
                    mFechaIni = Me.ucCriteriosSolicitudesProductoConsignacion1.FECHA_INICIAL
                    mFechaFin = Me.ucCriteriosSolicitudesProductoConsignacion1.FECHA_FINAL
                End If
                Me.ucListaSALBODE_DETA1.CargarDatosPorCriterios(mIdZafra, mFechaIni, mFechaFin, mNumSolic, mNumSalde, mCodiProvee, mIdProveeAgri, mIdCuentaFinan, mIdEstado)


            Case "EntregadoIgualCantidad"
                Dim bSalBodeDeta As New cSALBODE_DETA
                Dim lista As listaSALBODE_DETA = Me.ucListaSALBODE_DETA1.DevolverSeleccionados
                If lista Is Nothing OrElse lista.Count = 0 Then
                    AsignarMensaje("Seleccione los productos", False, True)
                    Return
                End If
                For i As Int32 = 0 To lista.Count - 1
                    Dim lSolic As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(lista(i).ID_SOLICITUD)
                    If lSolic IsNot Nothing AndAlso lSolic.ESTADO <> EstadoSolicAgricola.Anulada Then
                        lista(i).CANT_ANULADA = 0
                        lista(i).CANT_ENTREGADA = lista(i).CANTIDAD
                        lista(i).USUARIO_ACT = Me.ObtenerUsuario
                        lista(i).FECHA_ACT = cFechaHora.ObtenerFechaHora
                        bSalBodeDeta.ActualizarSALBODE_DETA(lista(i))
                    End If
                Next
                Me.ucListaSALBODE_DETA1.QuitarSeleccion()
                Me.ucListaSALBODE_DETA1.DataBind()

            Case "AnularProducto"
                Dim bSalBodeDeta As New cSALBODE_DETA
                Dim lista As listaSALBODE_DETA = Me.ucListaSALBODE_DETA1.DevolverSeleccionados
                If lista Is Nothing OrElse lista.Count = 0 Then
                    AsignarMensaje("Seleccione los productos", False, True)
                    Return
                End If
                For i As Int32 = 0 To lista.Count - 1
                    Dim lSolic As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(lista(i).ID_SOLICITUD)
                    If lSolic IsNot Nothing AndAlso lSolic.ESTADO <> EstadoSolicAgricola.Anulada Then
                        lista(i).CANT_ANULADA = lista(i).CANTIDAD - lista(i).CANT_ENTREGADA
                        lista(i).USUARIO_ACT = Me.ObtenerUsuario
                        lista(i).FECHA_ACT = cFechaHora.ObtenerFechaHora
                        bSalBodeDeta.ActualizarSALBODE_DETA(lista(i))
                    End If
                Next
                Me.ucListaSALBODE_DETA1.QuitarSeleccion()
                Me.ucListaSALBODE_DETA1.DataBind()

            Case "Exportar"
                Me.ucListaSALBODE_DETA1.ExportarExcel()
        End Select

    End Sub
End Class
