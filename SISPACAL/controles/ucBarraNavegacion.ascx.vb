
Partial Class controles_ucBarraNavegacion
    Inherits System.Web.UI.UserControl

    Private Const strImagenesNuevo As String = "actions_new_16x16"
    Private Const strTextoAgregar As String = "Agregar"
    Private Const strNombreMenuAgregar As String = "miAgregar"
    Private Const strNombreMenuSalir As String = "miSalir"
    Private Const strGrupoMenuGeneral As String = "General"
    Private Const strImagenCancelar As String = "history_undo_16x16"
    Private Const strImagenEditar As String = "edit_edit_16x16"
    Private Const strImagenSalir As String = "navigation_home_16x16"
    Private Const strTextoCancelar As String = "Cancelar"
    Private Const strTextoEditar As String = "Editar"
    Private Const strNombreMenuEditar As String = "miEditar"
    Private Const strImagenGuardar As String = "save_save_16x16"
    Private Const strTextoGuardar As String = "Guardar"
    Private Const strTextoSalir As String = "Salir"
    Private Const strNombreMenuGuardar As String = "miGuardar"
    Private Const strImagenExcel As String = "~/imagenes/excel.gif"
    Private Const strTextoExportarAExcel As String = "Exportar a Excel"
    Private Const strNombreMenuExportarAExcel As String = "miExportarAExcel"
    Private Const strGrupoMenuExportar As String = "Exportar"
    Private Const strImagenPDF As String = "~/imagenes/pdf.gif"
    Private Const strTextoExportarAPDF As String = "Exportar a PDF"
    Private Const strNombreMenuExportarAPDF As String = "miExportarAPDF"

#Region "Exportacion Grids DevExpress"
    Public Property PermitirExportarAExcel() As Boolean
        Get
            Return ViewState("PermitirExportarAExcel")
        End Get
        Set(ByVal Value As Boolean)
            ViewState("PermitirExportarAExcel") = Value
            mDinamico.Items.FindByName(strNombreMenuExportarAExcel).Visible = Value
        End Set
    End Property

    Public Property PermitirExportarAPDF() As Boolean
        Get
            Return ViewState("PermitirExportarAPDF")
        End Get
        Set(ByVal Value As Boolean)
            ViewState("PermitirExportarAPDF") = Value
            mDinamico.Items.FindByName(strNombreMenuExportarAPDF).Visible = Value
        End Set
    End Property

    'Public WriteOnly Property GridViewControlName() As String
    '    Set(ByVal value As String)
    '        ASPxGridViewExporter1.GridViewID = value
    '    End Set
    'End Property

    'Public WriteOnly Property FileNameToExport() As String
    '    Set(ByVal value As String)
    '        ASPxGridViewExporter1.FileName = value
    '    End Set
    'End Property
#End Region

#Region "Opciones Estaticas"
    Private _HabilitarEdicion As Boolean = False
    Private ClientScript As String = "e.item.SetChecked(false);var validationResult = true;if(e.item.name=='miGuardar'){validationResult=ASPxClientEdit.ValidateGroup('', false);if(validationResult){if(typeof(Page_ClientValidate)=='function')validationResult=Page_ClientValidate('');}if(!validationResult){e.processOnServer=false;return false;}else{e.processOnServer=true;return true;}}"
    Private ClientScriptConCallBack As String = "e.item.SetChecked(false);var validationResult = true;if(e.item.name=='miGuardar'){validationResult=ASPxClientEdit.ValidateGroup('', false);if(validationResult){if(typeof(Page_ClientValidate)=='function')validationResult=Page_ClientValidate('');}if(!validationResult){e.processOnServer=false; return false;}else{e.processOnServer=true;return true;}}"

    Public Event Guardar As EventHandler
    Public Event Agregar As EventHandler
    Public Event Editar As EventHandler
    Public Event Cancelar As EventHandler
    Public Event Eliminar As EventHandler
    Public Event Inicio()
    Public Event Anterior(ByVal index As Int32)
    Public Event Siguiente(ByVal index As Int32)
    Public Event Fin()

    Public Property HabilitarCallBacks() As Boolean
        Get
            Return ViewState("HabilitarCallBacks")
        End Get
        Set(ByVal value As Boolean)
            ViewState("HabilitarCallBacks") = value
        End Set
    End Property

    Public Property PermitirAgregar() As Boolean
        Get
            Return ViewState("PermitirAgregar")
        End Get
        Set(ByVal Value As Boolean)
            ViewState("PermitirAgregar") = Value
            mDinamico.Items.FindByName(strNombreMenuAgregar).Visible = Value
        End Set
    End Property

    Public Property PermitirSalir() As Boolean
        Get
            Return ViewState("PermitirSalir")
        End Get
        Set(ByVal Value As Boolean)
            ViewState("PermitirSalir") = Value
            mDinamico.Items.FindByName(strNombreMenuSalir).Visible = Value
        End Set
    End Property

    Public Property PermitirEditar() As Boolean
        Get
            Return ViewState("PermitirEditar")
        End Get
        Set(ByVal Value As Boolean)
            ViewState("PermitirEditar") = Value
            mDinamico.Items.FindByName(strNombreMenuEditar).Visible = Value
            If Value Then
                PermitirGuardar = True
            End If
        End Set
    End Property

    Public Property PermitirGuardar() As Boolean
        Get
            Return ViewState("PermitirGuardar")
        End Get
        Set(ByVal Value As Boolean)
            ViewState("PermitirGuardar") = Value
            mDinamico.Items.FindByName(strNombreMenuGuardar).Visible = Value
        End Set
    End Property

    Private _PermitirNavegacion As Boolean = False
    Public Property PermitirNavegacion(Optional ByVal conTotales As Boolean = False, Optional ByVal conTexto As Boolean = True) As Boolean
        Get
            Return _PermitirNavegacion
        End Get
        Set(ByVal Value As Boolean)
            _PermitirNavegacion = Value
            If Not ViewState("PermitirNavegacion") Is Nothing Then ViewState.Remove("PermitirNavegacion")
            ViewState.Add("PermitirNavegacion", Value)
            If Value Then
                If conTotales Then Navegacion = Value
                'lblDe.Visible = conTexto
                'lblRegistroActual.Visible = conTexto
                'lblRegistros.Visible = conTexto
                'lblTotalRegistros.Visible = conTexto
            Else
                Navegacion = False
            End If
        End Set
    End Property

    Public Property Navegacion() As Boolean
        Get
            Return False 'lblTotalRegistros.Visible
        End Get
        Set(ByVal Value As Boolean)
            If Not Value Then
                '    ibtnInicio.Visible = False
                '    ibtnAnterior.Visible = False
                '    ibtnSiguiente.Visible = False
                '    ibtnFin.Visible = False
                '    lblDe.Visible = False
                '    lblRegistroActual.Visible = False
                '    lblRegistros.Visible = False
                '    lblTotalRegistros.Visible = False
                'Else
                '    ibtnInicio.Visible = True
                '    ibtnAnterior.Visible = True
                '    ibtnSiguiente.Visible = True
                '    ibtnFin.Visible = True
                '    lblDe.Visible = True
                '    lblRegistroActual.Visible = True
                '    lblRegistros.Visible = True
                '    lblTotalRegistros.Visible = True
            End If
        End Set
    End Property

    Public Property Indice() As Integer
        Get
            Return 0 'CInt(lblRegistroActual.Text)
        End Get
        Set(ByVal Value As Integer)
            'lblRegistroActual.Text = CStr(Value)
        End Set
    End Property

    Public Property Total() As Integer
        Get
            Return 0 'CInt(lblTotalRegistros.Text)
        End Get
        Set(ByVal Value As Integer)
            'lblTotalRegistros.Text = CStr(Value)
            If Value = 0 Then
                Indice = 0
                'ibtnEditarCancelar.Enabled = False
                'ibtnGuardar.Enabled = False
            Else
                Indice = 1
            End If
            HabilitarNavegacion()
        End Set
    End Property

    Private Sub HabilitarNavegacion()
        'If CInt(lblTotalRegistros.Text) > 1 Then
        '    If CInt(lblRegistroActual.Text) = 1 Then
        '        ibtnAnterior.Enabled = False
        '        ibtnInicio.Enabled = False
        '        ibtnSiguiente.Enabled = True
        '        ibtnFin.Enabled = True
        '    End If
        '    If CInt(lblRegistroActual.Text) = CInt(lblTotalRegistros.Text) Then
        '        ibtnAnterior.Enabled = True
        '        ibtnInicio.Enabled = True
        '        ibtnSiguiente.Enabled = False
        '        ibtnFin.Enabled = False
        '    End If
        'Else
        '    ibtnAnterior.Enabled = False
        '    ibtnInicio.Enabled = False
        '    ibtnSiguiente.Enabled = False
        '    ibtnFin.Enabled = False
        'End If
    End Sub

    Public Sub HabilitarEdicion(ByVal edicion As Boolean)
        _HabilitarEdicion = edicion
        Dim lMenuEditarCancelar As DevExpress.Web.MenuItem = mDinamico.Items.FindByName(strNombreMenuEditar)
        If edicion Then
            lMenuEditarCancelar.Image.IconID = strImagenCancelar
            lMenuEditarCancelar.Text = strTextoCancelar
        Else
            lMenuEditarCancelar.Image.IconID = strImagenEditar
            lMenuEditarCancelar.Text = strTextoEditar
        End If
        lMenuEditarCancelar.Enabled = True
        mDinamico.Items.FindByName(strNombreMenuAgregar).Enabled = Not edicion
        mDinamico.Items.FindByName(strNombreMenuGuardar).Enabled = edicion
    End Sub

#End Region

#Region "Opciones Dinamicas"
    Public Event OpcionSeleccionada(ByVal CommandName As String)
    Private mListaOpcionesBarra As New ListaOpcionesBarra

    Private _anchoBoton As Int32 = 18
    Public Property anchoBoton() As Int32
        Get
            Return _anchoBoton
        End Get
        Set(ByVal Value As Int32)
            _anchoBoton = Value
            SetearAnchoBotonesEstaticos()
            If Not ViewState("anchoBoton") Is Nothing Then ViewState.Remove("anchoBoton")
            ViewState.Add("anchoBoton", Value)
        End Set
    End Property

    Private Sub SetearAnchoBotonesEstaticos()
        'ibtnAgregar.Height = _anchoBoton
        'ibtnEditarCancelar.Height = _anchoBoton
        'ibtnGuardar.Height = _anchoBoton

        'ibtnInicio.Height = _anchoBoton
        'ibtnAnterior.Height = _anchoBoton
        'ibtnSiguiente.Height = _anchoBoton
        'ibtnFin.Height = _anchoBoton
    End Sub

    Public Sub CrearOpcion(ByVal CommandName As String, ByVal AlternateText As String, ByVal CausesValidation As Boolean, ByVal ImageUrl As String, Optional ByVal AtributoKey As String = "", Optional ByVal AtributoValue As String = "", Optional EsIconID As Boolean = False)
        If Not EsIconID Then
            Dim mEntidad As New OpcionesBarra() With {.CommandName = CommandName, .AlternateText = AlternateText, .CausesValidation = CausesValidation, .ImageUrl = ImageUrl, .AtributoKey = AtributoKey, .AtributoValue = AtributoValue}
            If mListaOpcionesBarra.Find(Function(a) a.CommandName = mEntidad.CommandName) Is Nothing Then mListaOpcionesBarra.Add(mEntidad)
        Else
            Dim mEntidad As New OpcionesBarra() With {.CommandName = CommandName, .AlternateText = AlternateText, .CausesValidation = CausesValidation, .IconID = ImageUrl, .AtributoKey = AtributoKey, .AtributoValue = AtributoValue}
            If mListaOpcionesBarra.Find(Function(a) a.CommandName = mEntidad.CommandName) Is Nothing Then mListaOpcionesBarra.Add(mEntidad)
        End If
    End Sub

    Public Sub VerOpcion(ByVal CommandName As String, ByVal EsVisible As Boolean)
        For Each lMenu As DevExpress.Web.MenuItem In mDinamico.Items
            If lMenu.Name = CommandName Then
                lMenu.Visible = EsVisible
                Return
            End If
        Next
    End Sub

    Public Sub HabilitarOpcion(ByVal CommandName As String, ByVal Enabled As Boolean)
        For Each lMenu As DevExpress.Web.MenuItem In mDinamico.Items
            If lMenu.Name = CommandName Then
                lMenu.Enabled = Enabled
                Return
            End If
        Next
    End Sub

    Private Sub CrearMenuAgregar()
        Dim lMenuAgregar As New DevExpress.Web.MenuItem
        lMenuAgregar.Image.IconID = strImagenesNuevo
        lMenuAgregar.Image.AlternateText = strTextoAgregar
        lMenuAgregar.Name = strNombreMenuAgregar
        lMenuAgregar.Text = strTextoAgregar
        lMenuAgregar.GroupName = strGrupoMenuGeneral
        lMenuAgregar.Visible = PermitirAgregar
        mDinamico.Items.Add(lMenuAgregar)
    End Sub

    Private Sub CrearMenuEditar()
        Dim lMenuEditar As New DevExpress.Web.MenuItem
        If _HabilitarEdicion Then
            lMenuEditar.Image.IconID = strImagenCancelar
            lMenuEditar.Text = strTextoCancelar
        Else
            lMenuEditar.Image.IconID = strImagenEditar
            lMenuEditar.Text = strTextoEditar
        End If
        lMenuEditar.Name = strNombreMenuEditar
        lMenuEditar.GroupName = strGrupoMenuGeneral
        lMenuEditar.Visible = PermitirEditar
        mDinamico.Items.Add(lMenuEditar)
    End Sub

    Private Sub CrearMenuGuardar()
        Dim lMenuGuardar As New DevExpress.Web.MenuItem
        lMenuGuardar.Image.IconID = strImagenGuardar
        lMenuGuardar.Image.AlternateText = strTextoGuardar
        lMenuGuardar.Name = strNombreMenuGuardar
        lMenuGuardar.Text = strTextoGuardar
        lMenuGuardar.GroupName = strGrupoMenuGeneral
        lMenuGuardar.Visible = PermitirGuardar
        mDinamico.Items.Add(lMenuGuardar)
    End Sub

    Private Sub CrearMenuSalir()
        Dim lMenuSalir As New DevExpress.Web.MenuItem
        lMenuSalir.Image.IconID = strImagenSalir
        lMenuSalir.Image.AlternateText = strTextoSalir
        lMenuSalir.Name = strNombreMenuSalir
        lMenuSalir.Text = strTextoSalir
        lMenuSalir.GroupName = strGrupoMenuGeneral
        lMenuSalir.Visible = True
        mDinamico.Items.Add(lMenuSalir)
    End Sub

    Private Sub CrearMenuExportarAExcel()
        Dim lMenuExportarAExcel As New DevExpress.Web.MenuItem
        lMenuExportarAExcel.Image.Url = strImagenExcel
        lMenuExportarAExcel.Image.AlternateText = strTextoExportarAExcel
        lMenuExportarAExcel.BeginGroup = True
        lMenuExportarAExcel.Name = strNombreMenuExportarAExcel
        lMenuExportarAExcel.Text = strTextoExportarAExcel
        lMenuExportarAExcel.GroupName = strGrupoMenuExportar
        lMenuExportarAExcel.Visible = PermitirExportarAExcel
        mDinamico.Items.Add(lMenuExportarAExcel)
    End Sub

    Private Sub CrearMenuExportarAPDF()
        Dim lMenuExportarAPDF As New DevExpress.Web.MenuItem
        lMenuExportarAPDF.Image.Url = strImagenPDF
        lMenuExportarAPDF.Image.AlternateText = strTextoExportarAPDF
        lMenuExportarAPDF.Name = strNombreMenuExportarAPDF
        lMenuExportarAPDF.Text = strTextoExportarAPDF
        lMenuExportarAPDF.GroupName = strGrupoMenuExportar
        lMenuExportarAPDF.Visible = PermitirExportarAPDF
        mDinamico.Items.Add(lMenuExportarAPDF)
    End Sub

    Public Sub CargarOpciones()
        Me.CargarOpciones(mListaOpcionesBarra)
    End Sub

    Public Sub CargarOpciones(ByVal aLista As ListaOpcionesBarra)
        If Not HabilitarCallBacks Then
            AddHandler mDinamico.ItemClick, AddressOf mDinamico_ItemClick
        End If

        mDinamico.Items.Clear()
        CrearMenuAgregar()
        CrearMenuEditar()
        CrearMenuGuardar()
        CrearMenuExportarAExcel()
        CrearMenuExportarAPDF()

        If HabilitarCallBacks Then
            mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScriptConCallBack)
        Else
            mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScript)
        End If

        Dim i As Integer = 0
        Dim nombreGrupoAnterior As String = strGrupoMenuGeneral
        For Each lOpcion As OpcionesBarra In aLista
            Dim lMenu As New DevExpress.Web.MenuItem
            If i = 0 Then
                lMenu.BeginGroup = True
                nombreGrupoAnterior = "Especificas"
            End If
            If lOpcion.IconID <> String.Empty AndAlso Not lOpcion.IconID Is Nothing Then
                lMenu.Image.IconID = lOpcion.IconID
            Else
                lMenu.Image.Url = lOpcion.ImageUrl
            End If
            lMenu.Image.AlternateText = lOpcion.AlternateText
            lMenu.Name = lOpcion.CommandName
            lMenu.Text = lOpcion.AlternateText
            lMenu.GroupName = nombreGrupoAnterior
            If lOpcion.CausesValidation And lOpcion.AtributoKey.ToLower <> "onclick" Then
                If HabilitarCallBacks Then
                    ClientScriptConCallBack += String.Format("if(e.item.name=='{0}'){{validationResult=ASPxClientEdit.ValidateGroup('', false);if(validationResult){{if(typeof(Page_ClientValidate)=='function')validationResult=Page_ClientValidate('');}} if(!validationResult){{e.processOnServer=false;return false;}}}}", lMenu.Name)
                    mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScriptConCallBack)
                Else
                    ClientScript += String.Format("if(e.item.name=='{0}'){{validationResult=ASPxClientEdit.ValidateGroup('', false);if(validationResult){{if(typeof(Page_ClientValidate)=='function')validationResult=Page_ClientValidate('');}} if(!validationResult){{e.processOnServer=false;return false;}}}}", lMenu.Name)
                    mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScript)
                End If
            ElseIf lOpcion.CausesValidation And lOpcion.AtributoKey.ToLower = "onclick" Then
                If HabilitarCallBacks Then
                    ClientScriptConCallBack += String.Format("if(e.item.name=='{0}'){{validationResult=ASPxClientEdit.ValidateGroup('', false);if(validationResult){{if(typeof(Page_ClientValidate)=='function')validationResult=Page_ClientValidate('');}} if(!validationResult){{e.processOnServer=false;return false;}}{1}}}", lMenu.Name, lOpcion.AtributoValue)
                    mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScriptConCallBack)
                Else
                    ClientScript += String.Format("if(e.item.name=='{0}'){{validationResult=ASPxClientEdit.ValidateGroup('', false);if(validationResult){{if(typeof(Page_ClientValidate)=='function')validationResult=Page_ClientValidate('');}} if(!validationResult){{e.processOnServer=false;return false;}}{1}}}", lMenu.Name, lOpcion.AtributoValue)
                    mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScript)
                End If
            ElseIf lOpcion.AtributoKey.ToLower = "onclick" Then
                If HabilitarCallBacks Then
                    ClientScriptConCallBack += String.Format("if(e.item.name=='{0}'){{{1}}}", lMenu.Name, lOpcion.AtributoValue)
                    mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0}}}", ClientScriptConCallBack)
                Else
                    ClientScript += String.Format("if(e.item.name=='{0}'){{{1}}}", lMenu.Name, lOpcion.AtributoValue)
                    mDinamico.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ {0} }}", ClientScript)
                End If
            End If

            mDinamico.Items.Add(lMenu)
            i += 1
        Next
        CrearMenuSalir()

    End Sub

    Public Sub LimpiarOpciones()
        mListaOpcionesBarra.Clear()
        CargarOpciones()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not ViewState("mListaOpcionesBarra") Is Nothing Then mListaOpcionesBarra = ViewState("mListaOpcionesBarra")
        If Not ViewState("anchoBoton") Is Nothing Then _anchoBoton = ViewState("anchoBoton")
    End Sub

    Protected Sub mDinamico_ItemClick(ByVal source As Object, ByVal e As DevExpress.Web.MenuItemEventArgs) Handles mDinamico.ItemClick
        e.Item.Checked = False
        If e.Item.Name = strNombreMenuAgregar Then
            HabilitarEdicion(True)
            RaiseEvent Agregar(Me, e)
            Return
        End If
        If e.Item.Name = strNombreMenuEditar Then
            If e.Item.Image.Url = strImagenEditar Then
                HabilitarEdicion(True)
                RaiseEvent Editar(Me, e)
            Else
                HabilitarEdicion(False)
                Try
                    If Not Total > 0 Then
                        e.Item.Enabled = False
                    End If
                Catch ex As Exception
                Finally
                    RaiseEvent Cancelar(Me, e)
                End Try
            End If
            Return
        End If
        If e.Item.Name = strNombreMenuGuardar Then
            RaiseEvent Guardar(Me, e)
            Return
        End If
        If e.Item.Name = strNombreMenuSalir Then
            Response.Redirect("~/Default.aspx")
            Return
        End If
        'If e.Item.Name = strNombreMenuExportarAExcel Then
        '    ASPxGridViewExporter1.WriteXlsToResponse(True)
        '    Return
        'End If
        'If e.Item.Name = strNombreMenuExportarAPDF Then
        '    ASPxGridViewExporter1.WritePdfToResponse()
        '    Return
        'End If
        RaiseEvent OpcionSeleccionada(e.Item.Name)
    End Sub
End Class
