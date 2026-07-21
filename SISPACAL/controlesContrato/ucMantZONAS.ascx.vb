Imports DevExpress.Web
Imports SISPACAL.BL

Partial Class controlesMaestro_ucMantZONAS
    Inherits ucBase

#Region "Grid Principal"
    Private newValues As OrderedDictionary

    Protected Sub grid_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles grid.RowInserting
        e.NewValues("USER_CREA") = 1
        e.NewValues("FECHA_CREA") = cFechaHora.ObtenerFechaHora
        Actualizar(e.NewValues)
    End Sub

    Protected Sub grid_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles grid.RowUpdating
        If e.NewValues("FECHA_CREA") = #12:00:00 AM# Then
            e.NewValues("USER_CREA") = 1
            e.NewValues("FECHA_CREA") = cFechaHora.ObtenerFechaHora
        End If
        Actualizar(e.NewValues)
    End Sub

    Private Sub Actualizar(ByVal e As Object)
        Me.newValues = e
        Me.newValues("USER_ACT") = 1
        Me.newValues("FECHA_ACT") = cFechaHora.ObtenerFechaHora
        PopulateNewValues()
    End Sub

    Private Sub PopulateNewValues()
        Dim formLayout As ASPxFormLayout = CType(grid.FindEditFormTemplateControl("formLayout"), ASPxFormLayout)
        formLayout.ForEach(AddressOf ProcessItem)
    End Sub

    Private Sub ProcessItem(ByVal item As LayoutItemBase)
        Dim layoutItem As LayoutItem = TryCast(item, LayoutItem)
        If layoutItem IsNot Nothing Then
            Dim editBase As ASPxEditBase = TryCast(layoutItem.GetNestedControl(), ASPxEditBase)
            If editBase IsNot Nothing Then
                If TypeOf editBase Is ASPxTextBox AndAlso editBase IsNot Nothing Then
                    editBase.Value = editBase.Value.ToString.ToUpper
                End If
                Me.newValues(layoutItem.FieldName) = editBase.Value
            End If
        End If
    End Sub
#End Region

#Region "Grid Detalle"
    Protected Sub gd_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
        Session("ZONA") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue().ToString.Trim
    End Sub

    Protected Sub gd_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
        e.NewValues("NO_SUB_ZONA") = 0
        e.NewValues("USUARIO_CREA") = Me.ObtenerUsuario
        e.NewValues("FECHA_CREA") = cFechaHora.ObtenerFechaHora
        gd_Actualizar(sender, e.NewValues)
    End Sub

    Protected Sub gd_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
        If e.NewValues("NO_SUB_ZONA") = -1 Then
            e.NewValues("NO_SUB_ZONA") = 0
        End If
        gd_Actualizar(sender, e.NewValues)
    End Sub

    Private Sub gd_Actualizar(ByVal sender As Object, ByVal e As Object)
        Me.newValues = e
        Me.newValues("USUARIO_ACT") = Me.ObtenerUsuario
        Me.newValues("FECHA_ACT") = cFechaHora.ObtenerFechaHora
        gd_PopulateNewValues(sender)
    End Sub

    Private Sub gd_PopulateNewValues(ByVal sender As Object)
        Dim gd As ASPxGridView = TryCast(sender, ASPxGridView)
        If gd IsNot Nothing Then
            Dim formLayout As ASPxFormLayout = CType(gd.FindEditFormTemplateControl("gd_formLayout"), ASPxFormLayout)
            formLayout.ForEach(AddressOf ProcessItem)
        End If
    End Sub

    Protected Sub gd_HtmlEditFormCreated(sender As Object, e As DevExpress.Web.ASPxGridViewEditFormEventArgs)
        Dim gd As ASPxGridView = TryCast(sender, ASPxGridView)
        If gd IsNot Nothing Then
            'Inicializando valores para nuevos registros
            Dim formLayout As ASPxFormLayout = CType(gd.FindEditFormTemplateControl("gd_formLayout"), ASPxFormLayout)
            Dim item As ASPxTextBox = TryCast(formLayout.FindNestedControlByFieldName("ZONA"), ASPxTextBox)
            If item IsNot Nothing Then
                item.Value = gd.GetMasterRowKeyValue.ToString
            End If
        End If
    End Sub
#End Region

   
End Class
