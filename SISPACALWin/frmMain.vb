Imports SISPACAL.EL.Enumeradores
Imports System.Resources
Imports System.Globalization.CultureInfo

Public Class frmMain

#Region "Código para menú dinámico"
    'Private resourceMan As Global.System.Resources.ResourceManager
    'Private resourceCulture As Global.System.Globalization.CultureInfo

    'Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
    '    Get
    '        If Object.ReferenceEquals(resourceMan, Nothing) Then
    '            Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SISPACAL.Resources", GetType(My.Resources.Resources).Assembly)
    '            resourceMan = temp
    '        End If
    '        Return resourceMan
    '    End Get
    'End Property
    'Private Sub CargarMenu()
    '    Dim opcion As New ToolStripButton
    '    Dim objIcono As Object
    '    opcion.Name = "tbsMiOpcion"
    '    opcion.Text = "MiOpcion"
    '    opcion.ToolTipText = ""
    '    objIcono = ResourceManager.GetObject("balanzaOhausIco", resourceCulture)
    '    opcion.Image = CType(objIcono, System.Drawing.Image)
    '    opcion.ImageScaling = ToolStripItemImageScaling.None
    '    opcion.TextImageRelation = TextImageRelation.ImageAboveText
    '    opcion.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    '    ToolStrip1.Items.Add(opcion)
    'End Sub    
#End Region

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Dim lecturas As New listaTIPO_LECTURA
        Dim blectura As New cTIPO_LECTURA
        Dim lectura As TIPO_LECTURA

        Select Case e.ClickedItem.Name
            Case "tsbBASCULA"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BASCULA_PESO_BRUTO)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BASCULA_PESO_TARA)
                lecturas.Add(lectura)
                frmAnalisisPeso_Muestra.MdiParent = Me
                frmAnalisisPeso_Muestra.Show()
                frmAnalisisPeso_Muestra.CargarTiposLectura(lecturas)
                frmAnalisisPeso_Muestra.lblTitulo.Text = "CAPTURA DE PESO BRUTO Y TARA"
            Case "tsbPESO_MUESTRA"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.PESO_BAGAZO)
                lecturas.Add(lectura)
                frmAnalisisPeso_Muestra.MdiParent = Me
                frmAnalisisPeso_Muestra.Show()
                frmAnalisisPeso_Muestra.CargarTiposLectura(lecturas)
                frmAnalisisPeso_Muestra.lblTitulo.Text = "CAPTURA DE PESO DE MUESTRA DE CAÑA"
            Case "tsbPOL_BRIX"
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.POL_BRIX)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.POL)
                lecturas.Add(lectura)
                lectura = blectura.ObtenerTIPO_LECTURA(TipoLectura.BRIX)
                lecturas.Add(lectura)
                frmAnalisisPeso_Muestra.MdiParent = Me
                frmAnalisisPeso_Muestra.Show()
                frmAnalisisPeso_Muestra.CargarTiposLectura(lecturas)
                frmAnalisisPeso_Muestra.lblTitulo.Text = "CAPTURA DE POL/BRIX"
            Case "tsbDEXTRANA"
                frmDextrana.MdiParent = Me
                frmDextrana.Show()
            Case "tsbMATERIA_EXTRA"
                frmMateriaExtrana.MdiParent = Me
                frmMateriaExtrana.Show()
            Case "tsdbProcesos", "tsdbReportes"
                Return
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

    Public Sub Habilitar(ByVal modo As Boolean)
        tsbBASCULA.Enabled = modo
        tsbPESO_MUESTRA.Enabled = modo
        tsbPOL_BRIX.Enabled = modo
        tsbDEXTRANA.Enabled = modo
        tsbMATERIA_EXTRA.Enabled = modo
        tsdbProcesos.Enabled = modo
        tsdbReportes.Enabled = modo
        tsbCERRAR_SESION.Enabled = modo
        tsbSALIR.Enabled = modo
    End Sub

    Private Sub Inicializar()
        Me.Text = Application.ProductName
        tsbBASCULA.Visible = False
        tsbPESO_MUESTRA.Visible = False
        tsbPOL_BRIX.Visible = False
        tsbDEXTRANA.Visible = False
        tsbMATERIA_EXTRA.Visible = False
        tsdbProcesos.Visible = False
        tsdbReportes.Visible = False
        OrdenDeCombustibleToolStripMenuItem.Visible = False
        EntregaDeCañaBasculaCorteToolStripMenuItem.Visible = False
        EntregaDeCañaBasculaToolStripMenuItem.Visible = False
    End Sub

    Private Sub ConfigurarOpciones()
        Dim lecturasAutorizadas As listaLECTURA_POR_PERFIL = (New cLECTURA_POR_PERFIL).ObtenerListaPorPERFIL(configuracion.idPerfilUsuario)
        Dim lectura As LECTURA_POR_PERFIL

        If lecturasAutorizadas IsNot Nothing AndAlso lecturasAutorizadas.Count > 0 Then
            lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.BASCULA_PESO_BRUTO, False)
            If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                Me.tsbBASCULA.Visible = True
            Else
                lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.BASCULA_PESO_TARA, False)
                If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                    Me.tsbBASCULA.Visible = True
                End If
            End If

            lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.PESO_BAGAZO, False)
            If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                Me.tsbPESO_MUESTRA.Visible = True
            End If

            lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.POL_BRIX, False)
            If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                Me.tsbPOL_BRIX.Visible = True
            Else
                lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.POL, False)
                If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                    Me.tsbPOL_BRIX.Visible = True
                Else
                    lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.BRIX, False)
                    If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                        Me.tsbPOL_BRIX.Visible = True
                    End If
                End If
            End If

            lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.DEXTRANA, False)
            If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                Me.tsbDEXTRANA.Visible = True
            End If

            lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.MATERIA_EXTRAÑA, False)
            If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                Me.tsbMATERIA_EXTRA.Visible = True
            End If

            lectura = lecturasAutorizadas.BuscarPorColumna("ID_TIPO_LECTURA", TipoLectura.REPORTES_COMPROBANTES, False)
            If lectura IsNot Nothing AndAlso lectura.ID_LECTURA_PERFIL > 0 Then
                Me.tsdbProcesos.Visible = True
            End If
        End If

        If PermisoOpcion("ORDEN DE COMBUSTIBLE") Then
            Me.tsdbReportes.Visible = True
            Me.OrdenDeCombustibleToolStripMenuItem.Visible = True
        End If
        If PermisoOpcion("ENTREGA DE CAÑA EN BASCULA") Then
            Me.tsdbReportes.Visible = True
            Me.EntregaDeCañaBasculaToolStripMenuItem.Visible = True
        End If
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

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Login()
    End Sub

    Private Sub Login()
        Me.Inicializar()
        If Not Me.IniciarLogin() Then
            Application.Exit()
        End If
        Me.ConfigurarOpciones()
    End Sub

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

            Me.Text = Application.ProductName + " - Usuario (" + fLogin.UsuarioAutenticado.NOMBRE + ")"
            fLogin.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub ComprobantesToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ComprobantesToolStripMenuItem.Click
        frmReportesComprobante.MdiParent = Me
        frmReportesComprobante.Show()
    End Sub

    Private Sub ChequesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChequesToolStripMenuItem.Click
        frmCheques.MdiParent = Me
        frmCheques.Show()
    End Sub

    Private Sub GenerarArchivosParaPHToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarArchivosParaPHToolStripMenuItem.Click
        frmArchivosPH.MdiParent = Me
        frmArchivosPH.Show()
    End Sub

    Private Sub ReportesDePlanillaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportesDePlanillaToolStripMenuItem.Click
        frmReportesPlanilla.MdiParent = Me
        frmReportesPlanilla.Show()
    End Sub

    Private Sub GenerarPlantillaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarPlantillaToolStripMenuItem.Click
        frmGenerarPlantilla.MdiParent = Me
        frmGenerarPlantilla.Show()
    End Sub

    Private Sub CargarPlantillaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CargarPlantillaToolStripMenuItem.Click
        frmCargarPlantilla.MdiParent = Me
        frmCargarPlantilla.Show()
    End Sub

    Private Sub OrdenDeCombustibleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrdenDeCombustibleToolStripMenuItem.Click
        frmReportes.MdiParent = Me
        frmReportes.Show()
        frmReportes.Reporte = frmReportes.Reportes.OrdenCombustible
        Me.Habilitar(False)
    End Sub

    Private Sub EntregaDeCañaBasculaCorteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EntregaDeCañaBasculaCorteToolStripMenuItem.Click
        frmReportes.MdiParent = Me
        frmReportes.Show()
        frmReportes.Reporte = frmReportes.Reportes.EntregaCañaBasculaCorte
        Me.Habilitar(False)
    End Sub

    Private Sub EntregaDeCañaBasculaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EntregaDeCañaBasculaToolStripMenuItem.Click
        frmReportes.MdiParent = Me
        frmReportes.Show()
        frmReportes.Reporte = frmReportes.Reportes.EntregaCañaBascula
        Me.Habilitar(False)
    End Sub

    Private Sub GenerarArchivoParaCONSAAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarArchivoParaCONSAAToolStripMenuItem.Click
        frmArchivoEntregaCana.MdiParent = Me
        frmArchivoEntregaCana.Show()
    End Sub

End Class