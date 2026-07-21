 Imports System.Configuration.ConfigurationManager
Imports System.Web.UI.WebControls
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.ComponentModel
Imports System.Data

Public Class ucListaBase
    Inherits ucBase

    Public Event ComandoEjecutado(ByVal CommandName As String, ByVal CommandArgument As String)
    Protected WithEvents gvListaBase As GridView = Me.FindControl("gvLista")

    Private _PermitirSeleccionar As Boolean = False
    Public Overridable Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If gvListaBase Is Nothing Then Return

            gvListaBase = Me.FindControl("gvLista")
            If Not gvListaBase Is Nothing Then Me.gvListaBase.Columns(0).Visible = Value
            Me.ViewState("PermitirSeleccionar") = Value
        End Set
    End Property

    Public Sub CargarDatosPorDataSet(ByVal ds As DataSet)
        If gvListaBase Is Nothing Then Return

        Me.ViewState("PorDataSet") = True
        Me.ViewState("ds") = ds
        gvListaBase.DataSource = ds
        gvListaBase.DataBind()
    End Sub

    Public Sub AgregarHyperLinkField(ByVal DataNavigateUrlFields() As String, ByVal DataNavigateUrlFormatString As String, ByVal Text As String, ByVal Target As String)
        If gvListaBase Is Nothing Then Return

        Dim band As Boolean = True

        Dim i As Integer = gvListaBase.Columns.Count - 1
        Do

            If gvListaBase.Columns(i).GetType.Equals(GetType(HyperLinkField)) Then
                Dim columna As HyperLinkField = gvListaBase.Columns(i)
                If columna.Text = Text Then
                    gvListaBase.Columns(i).Visible = True
                    Return
                End If
                i -= 1
            Else
                band = False
            End If

        Loop While band

        Dim comando As New HyperLinkField
        comando.DataNavigateUrlFields = DataNavigateUrlFields
        comando.DataNavigateUrlFormatString = DataNavigateUrlFormatString
        comando.Text = Text
        comando.Visible = True
        comando.ItemStyle.HorizontalAlign = HorizontalAlign.Center
        comando.Target = Target
        gvListaBase.Columns.Add(comando)

    End Sub

    Public Sub EliminarHyperLinkField(ByVal Text As String)
        gvListaBase = Me.FindControl("gvLista")
        If gvListaBase Is Nothing Then Return

        Dim band As Boolean = True

        Dim i As Integer = gvListaBase.Columns.Count - 1
        Dim columna As HyperLinkField
        Do

            If gvListaBase.Columns(i).GetType.Equals(GetType(HyperLinkField)) Then
                columna = gvListaBase.Columns(i)
                If columna.Text = Text Then
                    gvListaBase.Columns(i).Visible = False
                    Return
                Else
                    i -= 1
                End If
            Else
                band = False
            End If

        Loop While band

    End Sub

    Protected Sub gvListaBase_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvListaBase.PageIndexChanging
        If Me.ViewState("PorDataSet") Then
            Me.CargarDatosPorDataSet(Me.ViewState("ds"))
        End If
    End Sub

    Private Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        gvListaBase = Me.FindControl("gvLista")
    End Sub

    Public Sub AsignarFilaSeleccionada(ByVal SelectedIndex As Integer)
        'gvListaBase = Me.FindControl("gvLista")
        If gvListaBase Is Nothing Then Return
        If SelectedIndex = -1 Then
            gvListaBase.SelectedIndex = SelectedIndex
            Return
        End If
        If gvListaBase.Rows.Count - 1 < SelectedIndex Then
            gvListaBase.SelectedIndex = SelectedIndex
        End If
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            If gvListaBase Is Nothing Then Return -1
            Return gvListaBase.Rows.Count
        End Get
    End Property

End Class

