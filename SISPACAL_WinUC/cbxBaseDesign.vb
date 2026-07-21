Namespace Design

    Public Class cbxBaseDesign
        Inherits System.Windows.Forms.Design.ControlDesigner

        Public Overrides Sub Initialize(ByVal component As System.ComponentModel.IComponent)
            MyBase.Initialize(component)
        End Sub

        Protected Overrides Sub OnPaintAdornments(ByVal pe As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaintAdornments(pe)
            CType(Me.Control, cbxBase).ControlsLayout()
        End Sub
    End Class

End Namespace
