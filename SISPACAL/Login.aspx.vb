Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Web.Security

Partial Class Account_Login
    Inherits wfBase

    Protected Sub LoginUser_LoggingIn(sender As Object, e As System.Web.UI.WebControls.LoginCancelEventArgs) Handles LoginUser.LoggingIn
        Dim bUsuario As New cUSUARIO
        Dim ltl As Literal

        ltl = LoginUser.FindControl("FailureText")
        If bUsuario.ValidarUsuario(Me.LoginUser.UserName, Me.LoginUser.Password) Then
            ltl.Text = String.Empty
            FormsAuthentication.RedirectFromLoginPage(Me.LoginUser.UserName, False)
        Else
            ltl.Text = bUsuario.sError
            e.Cancel = True
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Request.IsAuthenticated Then
            Response.Redirect("Default.aspx")
        End If
    End Sub
End Class