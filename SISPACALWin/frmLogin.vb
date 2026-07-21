Public Class frmLogin

    Private _usuario As USUARIO
    Public ReadOnly Property UsuarioAutenticado As USUARIO
        Get
            Return _usuario
        End Get
    End Property

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim bUsuario As New cUSUARIO

        If bUsuario.ValidarUsuario(Me.txtUSUARIO.Text, Me.txtCLAVE.Text) Then
            _usuario = bUsuario.ObtenerUSUARIO(Me.txtUSUARIO.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show(bUsuario.sError, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtUSUARIO_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUSUARIO.TextChanged
        ConfigError(txtUSUARIO)
    End Sub

    Private Sub ConfigError(ByRef txt As TextBox)
        If txt.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txt, txt.Tag + " no puede estar vacio")
        Else
            Me.ErrorProvider1.SetError(txt, "")
        End If
    End Sub

    Private Sub txtUSUARIO_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUSUARIO.Validating
        ConfigError(txtUSUARIO)
    End Sub

    Private Sub txtCLAVE_TextChanged(sender As Object, e As System.EventArgs) Handles txtCLAVE.TextChanged
        ConfigError(txtCLAVE)
    End Sub

    Private Sub txtCLAVE_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCLAVE.Validating
        ConfigError(txtCLAVE)
    End Sub
End Class
