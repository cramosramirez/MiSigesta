Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.EL.Enumeradores
Imports System.Text
Imports SISPACAL.DL
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel

Public Class frmPrincipalRibbon

    Private Sub frmPrincipalRibbon_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Login()
    End Sub

    Private Sub Login()
        Me.Inicializar()
        If Not Me.IniciarLogin() Then
            Application.Exit()
        End If
        Me.ConfigurarOpciones()
    End Sub

    Private Sub ConfigurarOpciones()
        Dim lecturasAutorizadas As listaLECTURA_POR_PERFIL = (New cLECTURA_POR_PERFIL).ObtenerListaPorPERFIL(configuracion.idPerfilUsuario)

        If lecturasAutorizadas IsNot Nothing AndAlso lecturasAutorizadas.Count > 0 Then
            For Each lectura As LECTURA_POR_PERFIL In lecturasAutorizadas
                Select Case lectura.ID_TIPO_LECTURA
                    Case TipoLectura.PESO_BAGAZO
                        Me.rbpCosecha.Visible = True
                        Me.btnPesoMuestraCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.POL_BRIX
                        Me.rbpCosecha.Visible = True
                        Me.btnAnalisisPolBrixCosecha.Visibility = BarItemVisibility.Never
                        Me.btnBRIX_POLZafra.Visibility = BarItemVisibility.Always
                    Case TipoLectura.POL
                        Me.rbpCosecha.Visible = True
                        Me.btnAnalisisPolBrixCosecha.Visibility = BarItemVisibility.Never
                        Me.btnBRIX_POLZafra.Visibility = BarItemVisibility.Always
                    Case TipoLectura.BRIX
                        Me.rbpCosecha.Visible = True
                        Me.btnAnalisisPolBrixCosecha.Visibility = BarItemVisibility.Never
                        Me.btnBRIX_POLZafra.Visibility = BarItemVisibility.Always
                    Case TipoLectura.BASCULA_PESO_BRUTO
                        Me.rbpBascula.Visible = True
                        Me.btnPesoNetoTaraBascula.Visibility = BarItemVisibility.Always
                        Me.btnPesoNetoTaraBascula2.Visibility = BarItemVisibility.Always
                    Case TipoLectura.BASCULA_PESO_TARA
                        Me.rbpBascula.Visible = True
                        Me.btnPesoNetoTaraBascula.Visibility = BarItemVisibility.Always
                        Me.btnPesoNetoTaraBascula2.Visibility = BarItemVisibility.Always
                    Case TipoLectura.DEXTRANA
                        Me.rbpCosecha.Visible = True
                        Me.btnDextranaCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.MATERIA_EXTRAÑA
                        Me.rbpCosecha.Visible = True
                        Me.btnMateriaExtranaCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.REPORTES_COMPROBANTES
                        Me.rbpPlanilla.Visible = True
                        Me.btnReportesPlanilla.Visibility = BarItemVisibility.Always
                        Me.btnDescuentosPlanilla.Visibility = BarItemVisibility.Always
                        Me.btnImpresionesPlanilla.Visibility = BarItemVisibility.Always
                        Me.btnGenerarPHPlanilla.Visibility = BarItemVisibility.Always
                        Me.btnArchivoEntregaCana.Visibility = BarItemVisibility.Always
                        Me.btnEmitirComprobantes.Visibility = BarItemVisibility.Always
                        Me.btnControlComprobantes.Visibility = BarItemVisibility.Always
                        Me.btnImpresionComprobantePlanilla.Visibility = BarItemVisibility.Always
                        Me.btnArchivoComprobantesExcel.Visibility = BarItemVisibility.Always
                    Case TipoLectura.PESO_BAGAZO_PRECOSECHA
                        Me.rbpPreCosecha.Visible = True
                        Me.btnPesoMuestraPreCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.POL_BRIX_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnAnalisisPolBrixPreCosecha.Visibility = BarItemVisibility.Never
                        Me.btnBRIX_POLPreCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.BRIX_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnAnalisisPolBrixPreCosecha.Visibility = BarItemVisibility.Never
                        Me.btnBRIX_POLPreCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.POL_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnAnalisisPolBrixPreCosecha.Visibility = BarItemVisibility.Never
                        Me.btnBRIX_POLPreCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.ANALISIS_COMPLE_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnAnalisisComplementarios.Visibility = BarItemVisibility.Always
                    Case TipoLectura.OBSERVACIONES_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnObservaciones.Visibility = BarItemVisibility.Always
                    Case TipoLectura.FORMULA_DEXTRA_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnFormulaDextrana.Visibility = BarItemVisibility.Always
                    Case TipoLectura.REPORTES_PRECOSECHA
                        rbpPreCosecha.Visible = True
                        Me.btnReportesPreCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.ALMIDON_COSECHA
                        Me.rbpCosecha.Visible = True
                        Me.btnAnalisisAlmidonCosecha.Visibility = BarItemVisibility.Always
                    Case TipoLectura.SEDIMENTO
                        Me.rbpCosecha.Visible = True
                        Me.btnSedimento.Visibility = BarItemVisibility.Always
                End Select
            Next
        End If

        If PermisoOpcion("ORDEN DE COMBUSTIBLE") Then
            Me.rbpBascula.Visible = True
            Me.btnReportesBascula.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
        If PermisoOpcion("ENTREGA DE CAÑA EN BASCULA") Then
            Me.rbpBascula.Visible = True
            Me.btnReportesBascula.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        For Each pagina As RibbonPage In RibbonControl.Pages
            If pagina.Visible Then
                RibbonControl.SelectedPage = pagina
                Exit For
            End If
        Next
        RibbonControl.Refresh()
    End Sub

    Private Function PermisoOpcion(ByVal nombreOpcion As String)
        Dim lOpcionesUsuario As listaOPCION = (New cOPCION).ObtenerListaPorUSUARIO(configuracion.usuarioActualiza, False)
        Dim i As Integer

        For i = 0 To lOpcionesUsuario.Count - 1
            If lOpcionesUsuario(i).NOMBRE_OPCION.Trim.ToUpper = nombreOpcion Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

    Private Sub Inicializar()
        UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver")
        Me.Text = Application.ProductName

        For Each rp As RibbonPage In RibbonControl.Pages
            rp.Visible = False
            For Each rpg As RibbonPageGroup In rp.Groups
                For Each item As BarItemLink In rpg.ItemLinks
                    item.Item.Visibility = BarItemVisibility.Never
                Next
            Next
        Next
    End Sub

    'Private Sub HabilitarOpcionesMantto(ByVal editar As Boolean)
    '    Me.btnNuevo.Enabled = Not editar
    '    Me.btnGuardar.Enabled = editar
    '    Me.btnEditar.Enabled = Not editar
    '    Me.btnImprimir.Enabled = Not editar
    '    Me.btnEliminar.Enabled = Not editar
    'End Sub

    Public Function IniciarLogin() As Boolean
        Dim fLogin As New frmLogin
        Dim usuario As String = String.Empty

        fLogin.ShowDialog(Me)
        If fLogin.DialogResult <> Windows.Forms.DialogResult.OK Then
            Me.Close()
            Return False
        End If

        Try
            Dim roles As String() = {(New cPERFIL).ObtenerPERFIL(fLogin.UsuarioAutenticado.ID_PERFIL).NOMBRE_PERFIL}
            System.Threading.Thread.CurrentPrincipal = New System.Security.Principal.GenericPrincipal(New System.Security.Principal.GenericIdentity(fLogin.UsuarioAutenticado.USUARIO), roles)

            'Valores de configuración
            configuracion.usuarioActualiza = fLogin.UsuarioAutenticado.USUARIO
            configuracion.idPerfilUsuario = fLogin.UsuarioAutenticado.ID_PERFIL

            Me.Text = Application.ProductName + " - Usuario [" + fLogin.UsuarioAutenticado.NOMBRE + "]" + " " + String.Format(" Versión {0}", My.Application.Info.Version.ToString)
            fLogin.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    Private Sub RibbonControl_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RibbonControl.ItemClick
        Dim lecturas As New listaTIPO_LECTURA
        Dim blectura As New cTIPO_LECTURA
        Dim lectura As TIPO_LECTURA

        Select Case e.Item.Name
            Case "btnPesoNetoTaraBascula"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BASCULA_PESO_BRUTO)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BASCULA_PESO_TARA)
                lecturas.Add(lectura)
                frmPrincipal.MdiParent = Me
                frmPrincipal.Show()
                frmPrincipal.CargarTiposLectura(lecturas)
                frmPrincipal.lblTitulo.Text = "CAPTURA DE PESO NETO Y TARA"
                frmPrincipal.ActualizarTonelasdasRecibidas()
                frmPesoLibras.Show()
            Case "btnPesoNetoTaraBascula2"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BASCULA_PESO_BRUTO)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BASCULA_PESO_TARA)
                lecturas.Add(lectura)
                frmPrincipal_bascula2.MdiParent = Me
                frmPrincipal_bascula2.Show()
                frmPrincipal_bascula2.CargarTiposLectura(lecturas)
                frmPrincipal_bascula2.lblTitulo.Text = "CAPTURA DE PESO NETO Y TARA"
                frmPrincipal_bascula2.ActualizarTonelasdasRecibidas()
                frmPesoLibras.Show()
            Case "btnPesoMuestraPreCosecha"
                 lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.PESO_BAGAZO)
                lecturas.Add(lectura)
                frmAnalisisPeso_Muestra.MdiParent = Me
                frmAnalisisPeso_Muestra.Show()
                frmAnalisisPeso_Muestra.CargarTiposLectura(lecturas)
                frmAnalisisPeso_Muestra.lblTitulo.Text = "PRE COSECHA - CAPTURA DE PESO DE MUESTRA DE CAÑA"
            Case "btnPesoMuestraCosecha"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.PESO_BAGAZO)
                lecturas.Add(lectura)
                frmPrincipal.MdiParent = Me
                frmPrincipal.Show()
                frmPrincipal.CargarTiposLectura(lecturas)
                frmPrincipal.lblTitulo.Text = "CAPTURA DE PESO DE MUESTRA DE CAÑA"
            Case "btnAnalisisPolBrixCosecha"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.POL_BRIX)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.POL)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BRIX)
                lecturas.Add(lectura)
                frmPrincipal.MdiParent = Me
                frmPrincipal.Show()
                frmPrincipal.CargarTiposLectura(lecturas)
                frmPrincipal.lblTitulo.Text = "CAPTURA DE POL/BRIX"
            Case "btnAnalisisPolBrixPreCosecha"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.POL_BRIX)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.POL)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BRIX)
                lecturas.Add(lectura)
                frmAnalisisPeso_Muestra.MdiParent = Me
                frmAnalisisPeso_Muestra.Show()
                frmAnalisisPeso_Muestra.CargarTiposLectura(lecturas)
                frmAnalisisPeso_Muestra.lblTitulo.Text = "PRE COSECHA - CAPTURA DE POL/BRIX"
            Case "btnBRIX_POLPreCosecha"
                frmCapturaPrecosechaBRIX_POL.MdiParent = Me
                frmCapturaPrecosechaBRIX_POL.Show()
                frmCapturaPrecosechaBRIX_POL.lblTitulo.Text = "PRE COSECHA - CAPTURA DE BRIX/POL"
            Case "btnBRIX_POLZafra"
                frmCapturaZafraBRIX_POL.MdiParent = Me
                frmCapturaZafraBRIX_POL.Show()
                frmCapturaZafraBRIX_POL.lblTitulo.Text = "ZAFRA - CAPTURA DE BRIX/POL"
            Case "btnDextranaCosecha"
                frmDextrana.MdiParent = Me
                frmDextrana.Show()
            Case "btnSedimento"
                frnSedimento.MdiParent = Me
                frnSedimento.Show()
            Case "btnAnalisisAlmidonCosecha"
                frmAlmidonCosecha.MdiParent = Me
                frmAlmidonCosecha.Show()
            Case "btnMateriaExtranaCosecha"
                frmMateriaExtrana.MdiParent = Me
                frmMateriaExtrana.Show()
            Case "btnRepPreCosechaDextrana"
                Dim fReporte As New frmReportesPrecosecha(1)
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnRepPreCosechaAlmidon"
                Dim fReporte As New frmReportesPrecosecha(2)
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnReportesPlanilla"
                frmReportesPlanilla.MdiParent = Me
                frmReportesPlanilla.Show()
            Case "btnGenerarPlantillaPlanilla"
                frmGenerarPlantilla.MdiParent = Me
                frmGenerarPlantilla.Show()
            Case "btnCargarPlantillaPlanilla"
                Dim fReporte As New frmCargarPlantilla
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnImpresionComprobantePlanilla"
                Dim fReporte As New frmReportesComprobante
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnEmitirComprobantes"
                Dim fReporte As New frmEmisionComprobantes
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnChequesPlanilla"
                Dim fReporte As New frmCheques
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnGenerarPHPlanilla"
                Dim fReporte As New frmArchivosPH
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnArchivoEntregaCana"
                Dim fReporte As New frmArchivoEntregaCana
                fReporte.MdiParent = Me
                fReporte.Show()
            Case "btnEntregaCanaBasculaCorte"
                frmReportes.MdiParent = Me
                frmReportes.Show()
                frmReportes.Reporte = frmReportes.Reportes.EntregaCañaBasculaCorte
            Case "btnEntregaCanaBascula"
                frmReportes.MdiParent = Me
                frmReportes.Show()
                frmReportes.Reporte = frmReportes.Reportes.EntregaCañaBascula
            Case "btnAnalisisComplementarios"
                frmAnalisisComplementarios.MdiParent = Me
                frmAnalisisComplementarios.Show()
            Case "btnFormulaDextrana"
                frmFormulaDextrana.MdiParent = Me
                frmFormulaDextrana.Show()
            Case "btnControlComprobantes"
                frmControlComprobantes.MdiParent = Me
                frmControlComprobantes.Show()
            Case "btnArchivoComprobantesExcel"
                frmComprobantesGenerarPH.MdiParent = Me
                frmComprobantesGenerarPH.Show()
            Case "tsbCERRAR_SESION"
                Me.Login()
                Return
            Case "tsbSALIR"
                Application.Exit()
            Case Else
                Return
        End Select
        Me.Habilitar(False)
    End Sub

    Private Sub AsociarOpcionesMtto(ByRef frm As frmBaseMtto)
        AddHandler Me.btnNuevo.ItemClick, AddressOf frm.Nuevo
        AddHandler Me.btnEditar.ItemClick, AddressOf frm.Editar
        AddHandler Me.btnGuardar.ItemClick, AddressOf frm.Guardar
        AddHandler Me.btnImprimir.ItemClick, AddressOf frm.Imprimir
        AddHandler Me.btnEliminar.ItemClick, AddressOf frm.Eliminar
        AddHandler frm.FormClosed, AddressOf Me.CerrarHijo
    End Sub

    Public Overridable Sub CerrarHijo(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As frmBaseMtto = TryCast(sender, frmBaseMtto)
        RemoveHandler Me.btnNuevo.ItemClick, AddressOf frm.Nuevo
        RemoveHandler Me.btnEditar.ItemClick, AddressOf frm.Editar
        RemoveHandler Me.btnGuardar.ItemClick, AddressOf frm.Guardar
        RemoveHandler Me.btnImprimir.ItemClick, AddressOf frm.Imprimir
        RemoveHandler Me.btnEliminar.ItemClick, AddressOf frm.Eliminar
        RemoveHandler frm.FormClosed, AddressOf Me.CerrarHijo
        Me.rbpcMantenimiento.Visible = False
        Me.rbpMantenimiento.Visible = False
        Me.RibbonControl.Refresh()
    End Sub

    Public Sub Habilitar(ByVal modo As Boolean)
        Me.rbpPreCosecha.Ribbon.Enabled = modo
        Me.rbpCosecha.Ribbon.Enabled = modo
        Me.rbpBascula.Ribbon.Enabled = modo
        Me.rbpPlanilla.Ribbon.Enabled = modo
        Me.RibbonControl.Refresh()
    End Sub

End Class