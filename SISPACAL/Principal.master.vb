Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

Partial Class Principal
    Inherits System.Web.UI.MasterPage

    Dim lOpciones As listaOPCION

    Private Sub CargarMenu()
        Dim lOpciones As listaOPCION

        If Context.User.Identity.Name = String.Empty Then
            Exit Sub
        End If
        If Utilerias.ObtenerUsuario = "jm" OrElse Utilerias.ObtenerUsuario = "chris" Then
            lOpciones = (New cOPCION).ObtenerListaPorUSUARIO(Utilerias.ObtenerUsuario, True)
        Else
            lOpciones = (New cOPCION).ObtenerListaPorUSUARIO(Utilerias.ObtenerUsuario, False)
        End If
        Me.ASPxMenu1.Items.Clear()
        If lOpciones IsNot Nothing AndAlso lOpciones.Count > 0 Then
            For Each lOpcion As OPCION In lOpciones
                If lOpcion.ID_OPCION_PADRE.Equals(-1) Then
                    Dim mnuMenuItem As New MenuItem
                    mnuMenuItem.Name = lOpcion.ID_OPCION
                    mnuMenuItem.Text = lOpcion.NOMBRE_OPCION

                    'Agregar item al menú principal
                    Me.ASPxMenu1.Items.Add(mnuMenuItem)

                    'Generar el árbol de menú
                    AddMenuItem(mnuMenuItem, lOpciones)
                End If
            Next
        End If
    End Sub

    Private Sub AddMenuItem(ByRef mnuMenuItem As MenuItem, ByVal lOpciones As listaOPCION)
        'Recorremos cada elemento de la lista para poder determinar cuales son elementos hijos
        'del menuitem dado pasado como parametro ByRef.
        For Each lOpcion As OPCION In lOpciones
            If lOpcion.ID_OPCION_PADRE.ToString.Equals(mnuMenuItem.Name) Then
                Dim mnuNewMenuItem As New MenuItem
                mnuNewMenuItem.Name = lOpcion.ID_OPCION
                mnuNewMenuItem.Text = lOpcion.NOMBRE_OPCION
                mnuNewMenuItem.NavigateUrl = lOpcion.URL

                'Agregamos el Nuevo MenuItem al MenuItem que viene de un nivel superior.
                'If mnuMenuItem.ChildItems.Count = 0 Then mnuMenuItem.Text += " >>"
                mnuMenuItem.Items.Add(mnuNewMenuItem)

                'llamada recursiva para ver si el nuevo menú ítem aun tiene elementos hijos.
                AddMenuItem(mnuNewMenuItem, lOpciones)
            End If
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarMenu()
        Me.lblTituloApp.Text = ConfigurationManager.AppSettings("TituloApp")
    End Sub

    Protected Sub LoginStatus_LoggedOut(ByVal sender As Object, ByVal e As System.EventArgs)
        Session.RemoveAll()
        Session.Abandon()
    End Sub
End Class

