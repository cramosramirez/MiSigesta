Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web.ASPxTreeList

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaOPCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla OPCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/12/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaOPCION
    Inherits ucListaBase

    Private mComponente As New cOPCION
    Public Event Seleccionado(ByVal ID_OPCION As Int32)
    Public Event Editando(ByVal ID_OPCION As Int32)


    Public Property ID_PERFIL As Int32
        Get
            If Me.ViewState("ID_PERFIL") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_PERFIL"))
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_PERFIL") = value
        End Set
    End Property

    Public Property PermitirSeleccionarPorCheckBox() As Boolean
        Get
            Return Me.trlOpcion.SettingsSelection.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.SettingsSelection.Enabled = value
        End Set
    End Property

    Public Property PermitirSeleccionarTodos() As Boolean
        Get
            Return Me.trlOpcion.SettingsSelection.AllowSelectAll
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.SettingsSelection.AllowSelectAll = value
        End Set
    End Property

    Public Property PermitirSeleccionarRecursivo() As Boolean
        Get
            Return Me.trlOpcion.SettingsSelection.Recursive
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.SettingsSelection.Recursive = value
        End Set
    End Property

    Public Property PermitirEditar() As Boolean
        Get
            Return Me.trlOpcion.Columns("colEditar").Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.Columns("colEditar").Visible = value
        End Set
    End Property

    Public Property PermitirArrastrarOpcion() As Boolean
        Get
            Return Me.trlOpcion.SettingsEditing.AllowNodeDragDrop
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.SettingsEditing.AllowNodeDragDrop = value
        End Set
    End Property

    Public Property PermitirAgregar() As Boolean
        Get
            Return Me.trlOpcion.Columns("colAgregar").Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.Columns("colAgregar").Visible = value
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.trlOpcion.Columns("colEliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.trlOpcion.Columns("colEliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirSubirOpcion() As Boolean
        Get
            Return Me.trlOpcion.Columns("colSubir").Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.Columns("colSubir").Visible = value
        End Set
    End Property

    Public Property PermitirBajarOpcion() As Boolean
        Get
            Return Me.trlOpcion.Columns("colBajar").Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trlOpcion.Columns("colBajar").Visible = value
        End Set
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla OPCION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("RecuperarOcultas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.trlOpcion.DataSourceID = "odsLista"
        Me.trlOpcion.Visible = True
        Me.trlOpcion.DataBind()
        Return 1
    End Function

    Public Sub SeleccionarOpcionesPorRol(ByVal ID_PERFIL As Int32)
        Me.trlOpcion.UnselectAll()
        Dim lOpcionesPorPerfil As listaOPCION_PERFIL = (New cOPCION_PERFIL).ObtenerListaPorPERFIL(ID_PERFIL)
        For Each lOpcionPerfil As OPCION_PERFIL In lOpcionesPorPerfil
            Dim lOpcion As OPCION = (New cOPCION).ObtenerOPCION(lOpcionPerfil.ID_OPCION)
            If lOpcion IsNot Nothing Then
                If lOpcion.URL IsNot Nothing AndAlso lOpcion.URL <> "" Then
                    Dim nodo As TreeListNode = Me.trlOpcion.FindNodeByKeyValue(lOpcion.ID_OPCION)
                    If nodo IsNot Nothing Then
                        nodo.Selected = True
                    End If
                End If
            End If
        Next
    End Sub

    Protected Sub trlOpcion_CommandColumnButtonInitialize(sender As Object, e As DevExpress.Web.ASPxTreeList.TreeListCommandColumnButtonEventArgs) Handles trlOpcion.CommandColumnButtonInitialize
        If e.ButtonType = DevExpress.Web.ASPxTreeList.TreeListCommandColumnButtonType.New AndAlso _
            e.CommandColumn.Name = "colAgregar" Then
            If e.NodeKey <> "" Then
                Dim lOpcion As OPCION = (New cOPCION).ObtenerOPCION(Convert.ToInt32(e.NodeKey))
                If lOpcion IsNot Nothing AndAlso (lOpcion.URL Is Nothing OrElse lOpcion.URL = "") Then
                    e.Visible = DevExpress.Utils.DefaultBoolean.True
                Else
                    e.Visible = DevExpress.Utils.DefaultBoolean.False
                End If
            End If
        End If
    End Sub

    Protected Sub trlOpcion_CustomCallback(sender As Object, e As DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs) Handles trlOpcion.CustomCallback
        Dim parametros As String() = e.Argument.Split(";")

        trlOpcion.JSProperties.Clear()

        Select Case parametros(0)
            Case "btnEliminar"
                Dim bOpcion As New cOPCION
                Dim idOpcion As Int32 = Convert.ToInt32(parametros(1))

                If bOpcion.EliminarOPCION(idOpcion) <= 0 Then
                    trlOpcion.JSProperties.Add("cpMensaje", "No se logro eliminar la opcion. Existen registros relacionados a la opcion.")
                    Return
                End If
                trlOpcion.DataBind()
                trlOpcion.JSProperties.Add("cpMensaje", "Opcion eliminada")

            Case "btnSubir"
                Dim bOpcion As New cOPCION
                Dim lOpcion As OPCION = bOpcion.ObtenerOPCION(Convert.ToInt32(parametros(1)))
                If lOpcion IsNot Nothing Then
                    If lOpcion.ORDEN - 1 > 0 Then
                        lOpcion.ORDEN -= 1
                        lOpcion.USUARIO_ACT = Me.ObtenerUsuario
                        lOpcion.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        If bOpcion.ActualizarOPCION(lOpcion) < 1 Then
                            trlOpcion.JSProperties.Add("cpMensaje", "No se logro actualizar la opcion")
                            Return
                        End If
                        trlOpcion.DataBind()
                    End If
                End If

            Case "btnBajar"
                Dim bOpcion As New cOPCION
                Dim lOpcion As OPCION = bOpcion.ObtenerOPCION(Convert.ToInt32(parametros(1)))
                If lOpcion IsNot Nothing Then
                    lOpcion.ORDEN += 1
                    lOpcion.USUARIO_ACT = Me.ObtenerUsuario
                    lOpcion.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    If bOpcion.ActualizarOPCION(lOpcion) < 1 Then
                        trlOpcion.JSProperties.Add("cpMensaje", "No se logro actualizar la opcion")
                        Return
                    End If
                    trlOpcion.DataBind()
                End If
        End Select
    End Sub

    Protected Sub odsLista_Inserting(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs) Handles odsLista.Inserting
        If e.InputParameters("ID_OPCION_PADRE") Is Nothing Then e.InputParameters("ID_OPCION_PADRE") = -1
        e.InputParameters("USUARIO_CREA") = Me.ObtenerUsuario
        e.InputParameters("FECHA_CREA") = cFechaHora.ObtenerFechaHora
        e.InputParameters("USUARIO_ACT") = Me.ObtenerUsuario
        e.InputParameters("FECHA_ACT") = cFechaHora.ObtenerFechaHora
    End Sub

    Protected Sub odsLista_Updating(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs) Handles odsLista.Updating
        If e.InputParameters("ID_OPCION_PADRE") Is Nothing Then e.InputParameters("ID_OPCION_PADRE") = -1
        e.InputParameters("USUARIO_ACT") = Me.ObtenerUsuario
        e.InputParameters("FECHA_ACT") = cFechaHora.ObtenerFechaHora
    End Sub

    Protected Sub trlOpcion_InitNewNode(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles trlOpcion.InitNewNode
        e.NewValues("ACTIVO") = True
    End Sub

    Protected Sub trlOpcion_ProcessDragNode(sender As Object, e As DevExpress.Web.ASPxTreeList.TreeListNodeDragEventArgs) Handles trlOpcion.ProcessDragNode
        If e.NewParentNode("URL") <> "" AndAlso e.NewParentNode("URL") IsNot Nothing Then
            e.Cancel = True
        End If
    End Sub

    Public Function Actualizar() As String
        Dim nodos As System.Collections.Generic.ICollection(Of TreeListNode) = Me.trlOpcion.GetAllNodes
        Dim lOpcionesPerfil As listaOPCION_PERFIL = (New cOPCION_PERFIL).ObtenerListaPorPERFIL(Me.ID_PERFIL)
        Dim lIdOpcionesEnPerfil As New List(Of Int32)
        Dim bOpcionPerfil As New cOPCION_PERFIL

        If lOpcionesPerfil IsNot Nothing AndAlso lOpcionesPerfil.Count > 0 Then
            For i As Int32 = 0 To lOpcionesPerfil.Count - 1
                lIdOpcionesEnPerfil.Add(lOpcionesPerfil(i).ID_OPCION)
            Next
        End If

        For i As Int32 = 0 To nodos.Count - 1
            Dim node As TreeListNode = nodos(i)

            If node.Selected Then
                If Not lIdOpcionesEnPerfil.Contains(CInt(node.Key)) Then
                    'Agregar permiso
                    Dim lEntidad As New OPCION_PERFIL
                    lEntidad.ID_OPCION_PERFIL = 0
                    lEntidad.ID_PERFIL = Me.ID_PERFIL
                    lEntidad.ID_OPCION = node.Key
                    lEntidad.USUARIO_CREA = Me.ObtenerUsuario
                    lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

                    If bOpcionPerfil.ActualizarOPCION_PERFIL_RECURSIVA(lEntidad) < 1 Then
                        Return "* No se asigno la opcion " + bOpcionPerfil.sError
                    End If
                End If
            Else
                If lIdOpcionesEnPerfil.Contains(CInt(node.Key)) Then
                    'Quitar permiso
                    Dim lOpcionPerfilBorrar As New OPCION_PERFIL

                    lOpcionPerfilBorrar = (New cOPCION_PERFIL).ObtenerOPCION_PERFILporOpcionPerfil(CInt(node.Key), Me.ID_PERFIL)
                    If CInt(node.Key) = 127 Then Stop
                    If lOpcionPerfilBorrar IsNot Nothing Then
                        bOpcionPerfil.EliminarOPCION_PERFIL(lOpcionPerfilBorrar, TipoConcurrencia.Pesimistica)
                    End If
                End If
            End If
        Next

        Return ""
    End Function

End Class
