Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlBase
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase Base para Controles DropDownList Web
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ddlBase
    Inherits System.Web.UI.WebControls.DropDownList

    Protected WithEvents txtCode As New System.Web.UI.WebControls.TextBox
    Protected WithEvents btnFind As New System.Web.UI.WebControls.Button

    <Description("Allow Find By Code in a TextBox"), DefaultValue(False)> _
    Public Property AllowFindByCode() As Boolean
        Get
            If Me.ViewState("AllowFindByCode") Is Nothing Then
                Return False
            Else
                Return CBool(Me.ViewState("AllowFindByCode"))
            End If
        End Get
        Set(ByVal value As Boolean)
            If Not Me.ViewState("AllowFindByCode") Is Nothing Then Me.ViewState.Remove("AllowFindByCode")
            Me.ViewState.Add("AllowFindByCode", value)
        End Set
    End Property

    <Description("Allow Find By List in another window."), DefaultValue(False)> _
    Public Property AllowFindByList() As Boolean
        Get
            If Me.ViewState("AllowFindByList") Is Nothing Then
                Return False
            Else
                Return CBool(Me.ViewState("AllowFindByList"))
            End If
        End Get
        Set(ByVal value As Boolean)
            If Not Me.ViewState("AllowFindByList") Is Nothing Then Me.ViewState.Remove("AllowFindByList")
            Me.ViewState.Add("AllowFindByList", value)
        End Set
    End Property

    <Description("Message Error if dont find a register with the enter code."), DefaultValue("Can't Find Code")> _
    Public Property AllowFindMessageError() As String
        Get
            If Me.ViewState("AllowFindMessageError") Is Nothing Then
                Return "Can't Find Code"
            Else
                Return Me.ViewState("AllowFindMessageError").ToString()
            End If
        End Get
        Set(ByVal value As String)
            If Not Me.ViewState("AllowFindMessageError") Is Nothing Then Me.ViewState.Remove("AllowFindMessageError")
            Me.ViewState.Add("AllowFindMessageError", value)
        End Set
    End Property

    <Description("Entity Name for the Find."), DefaultValue("")> _
    Public Property AllowFindEntityName() As String
        Get
            If Me.ViewState("AllowFindEntity") Is Nothing Then
                Return ""
            Else
                Return Me.ViewState("AllowFindEntity").ToString()
            End If
        End Get
        Set(ByVal value As String)
            If Not Me.ViewState("AllowFindEntity") Is Nothing Then Me.ViewState.Remove("AllowFindEntity")
            Me.ViewState.Add("AllowFindEntity", value)
        End Set
    End Property

    <Description("CSS Class for the TexBox Object for the Find by Code."), DefaultValue("TextoNormalDerecha")> _
    Public Property AllowFindCssClassTextBox() As String
        Get
            If Me.ViewState("AllowFindCssClassTextBox") Is Nothing Then
                Return "TextoNormalDerecha"
            Else
                Return Me.ViewState("AllowFindCssClassTextBox").ToString()
            End If
        End Get
        Set(ByVal value As String)
            If Not Me.ViewState("AllowFindCssClassTextBox") Is Nothing Then Me.ViewState.Remove("AllowFindCssClassTextBox")
            Me.ViewState.Add("AllowFindCssClassTextBox", value)
        End Set
    End Property

    Public Property AllowFindWidthTextBox() As System.Web.UI.WebControls.Unit
        Get
            If Me.ViewState("AllowFindWidthTextBox") Is Nothing Then
                Return New Unit("25px")
            Else
                Return CType(Me.ViewState("AllowFindWidthTextBox"), Unit)
            End If
        End Get
        Set(ByVal value As System.Web.UI.WebControls.Unit)
            If Not Me.ViewState("AllowFindWidthTextBox") Is Nothing Then Me.ViewState.Remove("AllowFindWidthTextBox")
            Me.ViewState.Add("AllowFindWidthTextBox", value)
        End Set
    End Property

    <Description("CSS Class for the Button Object for the Find by List."), DefaultValue("CommandButton")> _
    Public Property AllowFindCssClassButton() As String
        Get
            If Me.ViewState("AllowFindCssClassButton") Is Nothing Then
                Return "CommandButton"
            Else
                Return Me.ViewState("AllowFindCssClassButton").ToString()
            End If
        End Get
        Set(ByVal value As String)
            If Not Me.ViewState("AllowFindCssClassButton") Is Nothing Then Me.ViewState.Remove("AllowFindCssClassButton")
            Me.ViewState.Add("AllowFindCssClassButton", value)
        End Set
    End Property

    Public Property AllowFindWidthButton() As System.Web.UI.WebControls.Unit
        Get
            If Me.ViewState("AllowFindWidthButton") Is Nothing Then
                Return New Unit("25px")
            Else
                Return CType(Me.ViewState("AllowFindWidthButton"), Unit)
            End If
        End Get
        Set(ByVal value As System.Web.UI.WebControls.Unit)
            If Not Me.ViewState("AllowFindWidthButton") Is Nothing Then Me.ViewState.Remove("AllowFindWidthButton")
            Me.ViewState.Add("AllowFindWidthButton", value)
        End Set
    End Property

    <Description("Caption for the Text Button Object for the Find by List."), DefaultValue("...")> _
    Public Property AllowFindTextButton() As String
        Get
            If Me.ViewState("AllowFindTextButton") Is Nothing Then
                Return "..."
            Else
                Return Me.ViewState("AllowFindTextButton").ToString()
            End If
        End Get
        Set(ByVal value As String)
            If Not Me.ViewState("AllowFindTextButton") Is Nothing Then Me.ViewState.Remove("AllowFindTextButton")
            Me.ViewState.Add("AllowFindTextButton", value)
        End Set
    End Property

    Public Property AllowFindWidth() As System.Web.UI.WebControls.Unit
        Get
            If Me.ViewState("AllowFindWidth") Is Nothing Then
                Return New Unit("250px")
            Else
                Return CType(Me.ViewState("AllowFindWidth"), Unit)
            End If
        End Get
        Set(ByVal value As System.Web.UI.WebControls.Unit)
            If Not Me.ViewState("AllowFindWidth") Is Nothing Then Me.ViewState.Remove("AllowFindWidth")
            Me.ViewState.Add("AllowFindWidth", value)
        End Set
    End Property

    Public Property AllowFindHeight() As System.Web.UI.WebControls.Unit
        Get
            If Me.ViewState("AllowFindHeight") Is Nothing Then
                Return New Unit("250px")
            Else
                Return CType(Me.ViewState("AllowFindHeight"), Unit)
            End If
        End Get
        Set(ByVal value As System.Web.UI.WebControls.Unit)
            If Not Me.ViewState("AllowFindHeight") Is Nothing Then Me.ViewState.Remove("AllowFindHeight")
            Me.ViewState.Add("AllowFindHeight", value)
        End Set
    End Property

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        If Me.AllowFindByCode Then
            Me.txtCode.ID = Me.ID + "txt"
            Me.txtCode.CssClass = Me.AllowFindCssClassTextBox
            Me.txtCode.Width = Me.AllowFindWidthTextBox
            If Me.AutoPostBack Then
                Me.txtCode.Attributes.Add("onchange", "band = 0;lista=document.all['" + Me.ClientID + "'];for(i=0;i<lista.length;i++){if(lista.item(i).value==this.value){lista.item(i).selected=true;i=lista.length;band=1;setTimeout('__doPostBack(\'" + Me.ClientID.Replace("_", "$") + "\',\'\')', 0);}}if(band!=1){alert('" + Me.AllowFindMessageError.Replace("'", "") + "');this.focus();}")
            Else
                Me.txtCode.Attributes.Add("onchange", "band = 0;lista=document.all['" + Me.ClientID + "'];for(i=0;i<lista.length;i++){if(lista.item(i).value==this.value){lista.item(i).selected=true;i=lista.length;band=1;}}if(band!=1){alert('" + Me.AllowFindMessageError.Replace("'", "") + "');this.focus();}")
            End If
        End If
        If Me.AllowFindByList Then
            Me.btnFind.ID = Me.ID + "btn"
            Me.btnFind.CssClass = Me.AllowFindCssClassButton
            Me.btnFind.Width = Me.AllowFindWidthButton
            Me.btnFind.Attributes.Add("onclick", "window.open('wfFind.aspx?entity=" + Me.AllowFindEntityName + "&ddlControl=" + Me.ID + "','" + Me.ID + "Find','width=" + Me.AllowFindWidth.ToString() + ",height=" + Me.AllowFindHeight.ToString() + ",scrollbars=no,status=no,resizable=no')")
        End If
        If Not Me.Page.IsPostBack Then
            If Me.AllowFindByCode Then
                Me.Attributes.Add("onchange", "document.all['" + Me.txtCode.ClientID + "'].value=this.value")
            End If
        End If
    End Sub

    Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
        If Me.AllowFindByCode Then
            Me.txtCode.Text = Me.SelectedValue
            Me.txtCode.RenderControl(writer)
        End If
        MyBase.Render(writer)
        If Me.AllowFindByList Then
            Me.btnFind.Text = Me.AllowFindTextButton
            Me.btnFind.RenderControl(writer)
        End If
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As System.EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        If Me.AllowFindByCode Then
            Me.txtCode.Text = Me.SelectedValue
        End If
    End Sub

    Public Overrides Property Enabled() As Boolean
        Get
            Return MyBase.Enabled
        End Get
        Set(ByVal value As Boolean)
            MyBase.Enabled = value
            Me.txtCode.Enabled = value
            Me.btnFind.Enabled = value
        End Set
    End Property

    Public Sub CargarPorLista(ByVal aLista As listaBase, Optional ByVal asDataTextField As String = "", Optional ByVal asDataValueField As String = "")
        If asDataTextField <> "" Then Me.DataTextField = asDataTextField
        If asDataValueField <> "" Then Me.DataValueField = asDataValueField
        If aLista Is Nothing Then Return
        Me.DataSource = aLista
        Me.DataBind()
    End Sub

End Class
