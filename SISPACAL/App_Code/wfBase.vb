 Imports System.Configuration.ConfigurationManager
 Imports System.Web.UI.WebControls
 Public Class wfBase
    Inherits System.Web.UI.Page


    Public ReadOnly Property NombrePagina As String
        Get
            Dim s As String = Page.Request.Url.AbsolutePath
            s = s.Substring(s.LastIndexOf("/") + 1)
            Return s
        End Get
       
    End Property


 
     Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal EsError As Boolean = False, Optional ByVal EsAlerta As Boolean = False)
 
         If EsAlerta Then
             If EsError Then
                 Response.Write("<script language='JavaScript'>alert('Error : " + asMensaje + "')</script>")
             Else
                 Response.Write("<script language='JavaScript'>alert('" + asMensaje + "')</script>")
             End If
         End If
 
         Dim myLabel As Label
         Dim mEncabezado1 As Object
         mEncabezado1 = Page.FindControl("ucEncabezado1")
 
         If mEncabezado1 Is Nothing Then Return
         myLabel = mEncabezado1.FindControl("Label_Mensaje")
 
         If myLabel Is Nothing Then Return
 
         If EsError Then
             myLabel.CssClass = "MensajeError"
         Else
             myLabel.CssClass = "MensajeInformativo"
         End If
 
         myLabel.Text = asMensaje
 
     End Sub
 
     Public Function ObtenerUsuario() As String
         Return Context.User.Identity.Name
    End Function
 
     Public Overridable Sub LimpiarControles()
         Dim liCntrl As Integer
         Dim Cntrl As System.Web.UI.WebControls.TextBox
         Dim DDL As System.Web.UI.WebControls.DropDownList
 
         For liCntrl = 0 To Me.Controls.Count - 1
             Select Case Me.Controls(liCntrl).GetType().ToString
                 Case "System.Web.UI.WebControls.TextBox"
                     Cntrl = CType(Me.Controls(liCntrl), TextBox)
                     If Cntrl.Visible Then Cntrl.Text = ""
                 Case "System.Web.UI.WebControls.DropDownList"
                     Dim li As System.Web.UI.WebControls.ListItem
                     ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                     DDL = CType(Me.Controls(liCntrl), DropDownList)
                     li = DDL.Items.FindByValue("0")
 
                     If Not li Is Nothing Then DDL.SelectedValue = "0"
             End Select
 
             If Me.Controls(liCntrl).GetType().ToString().IndexOf("ucDDL") > 0 Then
                 Dim li As System.Web.UI.WebControls.ListItem
                 ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                 DDL = CType(Me.Controls(liCntrl), DropDownList)
                 li = DDL.Items.FindByValue("0")
 
                 If Not li Is Nothing Then DDL.SelectedValue = "0"
             End If
         Next
     End Sub
 
     Public Function ObtenerKeyValue(ByVal asKey As String) As String
         Return AppSettings(asKey)
    End Function
End Class
