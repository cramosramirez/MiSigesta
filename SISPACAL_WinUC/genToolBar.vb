Imports System.Windows.Forms
Public Class genToolBar

    Public Sub AddOption(ByVal text As String, ByVal onClick As System.EventHandler)
        Me.AddOption(text, Nothing, onClick)
    End Sub

    Public Sub AddOption(ByVal text As String, ByVal image As System.Drawing.Image, ByVal onClick As System.EventHandler, Optional ByVal abViewText As Boolean = False)
        Dim lToolStripItem As ToolStripItem
        lToolStripItem = Me.Items.Add(text, image, onClick)
        If abViewText Then
            lToolStripItem.Text = text
        Else
            lToolStripItem.Text = ""
        End If
        lToolStripItem.ToolTipText = text
        lToolStripItem.Name = text
    End Sub

    Public Sub EnableToolBarOption(ByVal text As String)
        If Me.Items.IndexOfKey(text) > -1 Then
            Me.Items(Me.Items.IndexOfKey(text)).Enabled = True
        End If
    End Sub

    Public Sub DisableToolBarOption(ByVal text As String)
        If Me.Items.IndexOfKey(text) > -1 Then
            Me.Items(Me.Items.IndexOfKey(text)).Enabled = False
        End If
    End Sub

    'Public Sub AddItem(ByVal aGenItemType As genItemType)

    'End Sub

    Public Enum genItemType As Integer
        ToolStripSeparator = 1
        ToolStripButton = 2
        ToolStripComboBox = 3
        ToolStripDropDown = 4
        ToolStripDropDownButton = 5
        ToolStripDropDownMenu = 6
        ToolStripProgressBar = 7
        ToolStripTextBox = 8
    End Enum
End Class

