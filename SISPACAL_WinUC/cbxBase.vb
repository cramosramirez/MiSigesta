Imports System.ComponentModel
Imports System.Windows.Forms
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms.Layout
<Designer(GetType(Design.cbxBaseDesign))> _
Public Class cbxBase
    Inherits System.Windows.Forms.ComboBox

    Protected WithEvents txtCode As New System.Windows.Forms.TextBox
    Protected WithEvents btnFind As New System.Windows.Forms.Button
    Public listaCriteriosSeleccionados As List(Of Criteria)

#Region "Find Properties"

    Private _AllowFindByCode As Boolean = False
    <Description("Allow Find By Code in a TextBox"), Category("Find"), DefaultValue(False)> _
    Public Property AllowFindByCode() As Boolean
        Get
            Return Me._AllowFindByCode
        End Get
        Set(ByVal value As Boolean)
            Me._AllowFindByCode = value
            Me.ControlsLayout()
        End Set
    End Property

    Private _AllowFindByList As Boolean = False
    <Description("Allow Find By List in another window."), Category("Find"), DefaultValue(False)> _
    Public Property AllowFindByList() As Boolean
        Get
            Return Me._AllowFindByList
        End Get
        Set(ByVal value As Boolean)
            Me._AllowFindByList = value
            Me.ControlsLayout()
        End Set
    End Property

    Private _AllowFindMessageError As String = "Can't Find Code"
    <Description("Message Error for if not exists code in list"), Category("Find"), DefaultValue("Can't Find Code")> _
    Public Property AllowFindMessageError() As String
        Get
            Return Me._AllowFindMessageError
        End Get
        Set(ByVal value As String)
            Me._AllowFindMessageError = value
        End Set
    End Property

    Private _AllowFindEntityType As Type = Nothing
    <Description("Type Entity used for the Find"), Category("Find"), DefaultValue("")> _
    Public Property AllowFindEntityType() As Type
        Get
            Return Me._AllowFindEntityType
        End Get
        Set(ByVal value As Type)
            Me._AllowFindEntityType = value
        End Set
    End Property

    Private _AllowFindWidthTextBox As Integer = 25
    <Description("Code TextBox's Width"), Category("Find"), DefaultValue(25)> _
    Public Property AllowFindWidthTextBox() As Integer
        Get
            Return Me._AllowFindWidthTextBox
        End Get
        Set(ByVal value As Integer)
            Me._AllowFindWidthTextBox = value
            Me.txtCode.Width = value
        End Set
    End Property

    Private _AllowFindWidthButton As Integer = 25
    <Description("Find Button's Width"), Category("Find"), DefaultValue(25)> _
    Public Property AllowFindWidthButton() As Integer
        Get
            Return Me._AllowFindWidthButton
        End Get
        Set(ByVal value As Integer)
            Me._AllowFindWidthButton = value
            Me.btnFind.Width = value
        End Set
    End Property

    Private _AllowFindTextButton As String = "..."
    <Description("Find Button Text"), Category("Find"), DefaultValue("...")> _
    Public Property AllowFindTextButton() As String
        Get
            Return Me._AllowFindTextButton
        End Get
        Set(ByVal value As String)
            Me._AllowFindTextButton = value
            Me.btnFind.Text = value
        End Set
    End Property

    Private _AllowFindWidth As Integer = 490
    <Description("Find Window Width"), Category("Find"), DefaultValue(490)> _
    Public Property AllowFindWidth() As Integer
        Get
            Return Me._AllowFindWidth
        End Get
        Set(ByVal value As Integer)
            Me._AllowFindWidth = value
        End Set
    End Property

    Private _AllowFindHeight As Integer = 270
    <Description("Find Window Height"), Category("Find"), DefaultValue(270)> _
    Public Property AllowFindHeight() As Integer
        Get
            Return Me._AllowFindHeight
        End Get
        Set(ByVal value As Integer)
            Me._AllowFindHeight = value
        End Set
    End Property
#End Region

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As System.EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        If Me.AllowFindByCode Then
            If Me.SelectedValue <> Nothing Then
                If Me.txtCode.Text <> Me.SelectedValue.ToString Then
                    Me.txtCode.Text = Me.SelectedValue
                End If
            Else
                Me.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Try
                Me.SelectedValue = Me.txtCode.Text
            Catch ex As Exception
                Me.SelectedIndex = -1
                Me.txtCode.Focus()
                MessageBox.Show(Me._AllowFindMessageError, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Try
            If Me.SelectedValue.ToString <> Me.txtCode.Text Then Me.SelectedValue = Me.txtCode.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If Me.AllowFindEntityType Is Nothing Then Return
        Dim frm As New frmFind
        frm.Height = Me.AllowFindHeight
        frm.Width = Me.AllowFindWidth
        frm.entityType = Me.AllowFindEntityType
        frm.control = Me
        frm.listaDatos = Me.DataSource
        frm.Inicializar()
        frm.ShowDialog()
    End Sub

    Public Sub ControlsLayout()
        If Me.AllowFindByCode Then
            If Not Me.Parent Is Nothing AndAlso Me.Parent.Controls.IndexOf(Me.txtCode) = -1 Then
                Me.txtCode.Multiline = False
                Me.txtCode.Height = Me.Height
                Me.txtCode.Font = Me.Font
                Me.txtCode.ForeColor = Me.ForeColor
                Me.txtCode.BackColor = Me.BackColor
                Me.txtCode.Width = Me.AllowFindWidthTextBox
                Me.txtCode.Location = Me.Location
                Me.txtCode.Location = New Point(Me.Location.X - Me.AllowFindWidthTextBox, Me.Location.Y)
                Me.Parent.Controls.Add(Me.txtCode)
            ElseIf Not Me.Parent Is Nothing Then
                Me.txtCode.Multiline = False
                Me.txtCode.Height = Me.Height
                Me.txtCode.Font = Me.Font
                Me.txtCode.ForeColor = Me.ForeColor
                Me.txtCode.BackColor = Me.BackColor
                Me.txtCode.Width = Me.AllowFindWidthTextBox
                Me.txtCode.Location = New Point(Me.Location.X - Me.AllowFindWidthTextBox, Me.Location.Y)
            End If
        Else
            If Not Me.Parent Is Nothing AndAlso Me.Parent.Controls.IndexOf(Me.txtCode) >= 0 Then
                Me.Parent.Controls.Remove(Me.txtCode)
                Me.Location = New Point(Me.Location.X - Me.AllowFindWidthTextBox, Me.Location.Y)
                Me.Width += Me.AllowFindWidthTextBox
            End If
        End If
        If Me.AllowFindByList Then
            If Not Me.Parent Is Nothing AndAlso Me.Parent.Controls.IndexOf(Me.btnFind) = -1 Then
                Me.btnFind.Height = Me.Height
                Me.btnFind.Font = Me.Font
                Me.btnFind.ForeColor = Me.ForeColor
                Me.btnFind.Width = Me.AllowFindWidthButton
                Me.Width -= Me.AllowFindWidthButton
                Me.btnFind.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
                Me.btnFind.Text = Me.AllowFindTextButton
                Me.Parent.Controls.Add(Me.btnFind)
            ElseIf Not Me.Parent Is Nothing Then
                Me.btnFind.Height = Me.Height
                Me.btnFind.Font = Me.Font
                Me.btnFind.ForeColor = Me.ForeColor
                Me.btnFind.Width = Me.AllowFindWidthButton
                Me.btnFind.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
                Me.btnFind.Text = Me.AllowFindTextButton
            End If
        Else
            If Not Me.Parent Is Nothing AndAlso Me.Parent.Controls.IndexOf(Me.btnFind) >= 0 Then
                Me.Parent.Controls.Remove(Me.btnFind)
                Me.Width += Me.AllowFindWidthButton
            End If
        End If
    End Sub

    Protected Overrides Sub OnInvalidated(ByVal e As System.Windows.Forms.InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        Me.ControlsLayout()
    End Sub

    Protected Overrides Sub OnVisibleChanged(ByVal e As System.EventArgs)
        Me.txtCode.Visible = Me.Visible
        MyBase.OnVisibleChanged(e)
    End Sub

    Private _Enabled As Boolean = True
    <DefaultValue(True)> _
    Public Shadows Property Enabled() As Boolean
        Get
            Return _Enabled
        End Get
        Set(ByVal value As Boolean)
            MyBase.Enabled = value
            _Enabled = value
            For Each i As Control In Me.Controls
                i.Enabled = value
            Next
            Me.txtCode.Enabled = value
            Me.btnFind.Enabled = value
        End Set
    End Property

    Public Sub CargarPorLista(ByVal aLista As listaBase, Optional ByVal asDisplayMember As String = "", Optional ByVal asValueMember As String = "")
        If asDisplayMember <> "" Then Me.DisplayMember = asDisplayMember
        If asValueMember <> "" Then Me.ValueMember = asValueMember
        If aLista Is Nothing Then Return
        Me.DataSource = aLista
    End Sub

End Class

