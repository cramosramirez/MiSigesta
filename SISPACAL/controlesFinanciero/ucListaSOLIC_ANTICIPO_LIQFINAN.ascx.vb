Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports DevExpress.Web.Data

Partial Class controlesFinanciero_ucListaSOLIC_ANTICIPO_LIQFINAN
    Inherits ucListaBase

    Private mComponente As New cLOTES_COSECHA
    Public Event Seleccionado(ByVal ID_ANTI_LIQ As Int32)
    Public Event Editando(ByVal ID_ANTI_LIQ As Int32)
    Public Event Liquidar(ByVal ID_ANTI_LIQ As Int32)

#Region "Propiedades"

    Public Property UID_REFERENCIA() As String
        Get
            Return Me.ViewState("UID_REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("UID_REFERENCIA") = value
        End Set
    End Property
    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
            dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
        End Set
        Get
            Return dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly
        End Get
    End Property
    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Public Property PermitirEditarInline2() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline2")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline2") = value
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = value
            Me.dxgvLista.Columns("Edicion2").Visible = Me.PermitirEditarInline2
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

#End Region

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
    End Sub

    Public WriteOnly Property SeleccionarFila() As Object
        Set(value As Object)
            Dim indice As Int32
            Me.dxgvLista.Selection.SelectRowByKey(value)
            indice = Me.dxgvLista.FindVisibleIndexByKeyValue(value)
            Me.dxgvLista.FocusedRowIndex = indice
        End Set
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LOTES_COSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.UID_REFERENCIA = nombreSesion
        Me.odsSOLIC_ANTICIPO_LIQFINANcache.SelectParameters("nombreSesion_ucListaSOLIC_ANTICIPO_LIQFINAN").DefaultValue = nombreSesion
        Me.odsSOLIC_ANTICIPO_LIQFINANcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsSOLIC_ANTICIPO_LIQFINANcache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        Me.dxgvLista.Columns("colEditar").Visible = Me.PermitirEditar OrElse Me.PermitirEditarInline

        If Me.PermitirEditarInline2 Then
            Me.dxgvLista.Columns("Edicion2").Visible = True
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = False
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline2
        Else
            Me.dxgvLista.Columns("Edicion2").Visible = False
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Liquidar" Then
            Dim b As New cSOLIC_ANTICIPO_LIQFINANcache

            b.Liquidar(e.KeyValue, Me.UID_REFERENCIA)
            Me.dxgvLista.DataBind()
            Me.CargarDatosCache(Me.UID_REFERENCIA)
            RaiseEvent Liquidar(e.KeyValue)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaSOLIC_ANTICIPO_LIQFINAN
        Dim mLista As New listaSOLIC_ANTICIPO_LIQFINAN
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ANTI_LIQ")
            Dim lEntidad As New SOLIC_ANTICIPO_LIQFINAN
            lEntidad.ID_ANTI_LIQ = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Static id_credito_enca As Integer
        Static lCredito As CREDITO_ENCA
        Static zafra As String
        Static financiamiento As String
        Static fecha As DateTime
        Static noComprob As String

        If id_credito_enca <> e.GetListSourceFieldValue("ID_CREDITO_ENCA") Then
            id_credito_enca = e.GetListSourceFieldValue("ID_CREDITO_ENCA")
            zafra = ""
            financiamiento = ""
            fecha = Nothing
            noComprob = ""

            lCredito = (New cCREDITO_ENCA).ObtenerCREDITO_ENCA(e.GetListSourceFieldValue("ID_CREDITO_ENCA"))

            If lCredito IsNot Nothing Then
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lCredito.ID_ZAFRA)
                If lZafra IsNot Nothing Then zafra = lZafra.NOMBRE_ZAFRA

                financiamiento = lCredito.DESCRIP_FINAN
                fecha = lCredito.FECHA
                noComprob = lCredito.NO_COMPROB
            End If
        End If

        If e.Column.FieldName = "ZAFRA" Then
            e.Value = zafra
        ElseIf e.Column.FieldName = "FINANCIAMIENTO" Then
            e.Value = financiamiento
        ElseIf e.Column.FieldName = "FECHA" Then
            If fecha = Nothing Then
                e.Value = ""
            Else
                e.Value = fecha.ToString("dd/MM/yyy")
            End If
        ElseIf e.Column.FieldName = "NO_COMPROB" Then
            e.Value = noComprob
        ElseIf e.Column.FieldName = "SALDO_TOTAL" Then
            e.Value = Convert.ToDecimal(e.GetListSourceFieldValue("SALDO_INI")) + Convert.ToDecimal(e.GetListSourceFieldValue("INTERES")) + Convert.ToDecimal(e.GetListSourceFieldValue("INTERES_IVA"))
        End If
    End Sub

    Protected Sub dxgvLista_InitNewRow(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles dxgvLista.InitNewRow
        e.NewValues("UID_REFERENCIA") = Me.UID_REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles dxgvLista.RowInserting
        e.NewValues("UID_REFERENCIA") = Me.UID_REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("UID_REFERENCIA") = Me.UID_REFERENCIA
    End Sub

    Private Sub dxgvLista_RowUpdated(sender As Object, e As ASPxDataUpdatedEventArgs) Handles dxgvLista.RowUpdated
        RaiseEvent Liquidar(0)
    End Sub
End Class
