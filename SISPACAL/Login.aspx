<%@ Page Title="Inicio de Sesion" Language="VB" MasterPageFile="~/Principal.Master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Account_Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="contenido">    
    <div style="text-align:center">
        <h3>
            Inicio de sesión
        </h3>
        <p>        Bienvenido! Por favor ingrese su nombre de usuario y contraseña a continuación.        
        </p>       
        <center>
        <asp:Login ID="LoginUser" runat="server" EnableViewState="false" DestinationPageUrl="~/Default.aspx"  
            RenderOuterTable="false" FailureText="El usuario o la clave no es correcta" >
            <LayoutTemplate>           
               <span class="alertaLogin"><asp:Literal ID="FailureText" runat="server"></asp:Literal></span>           
                <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server"  
                    ValidationGroup="LoginUserValidationGroup" CssClass="alertaLogin" />           
                <fieldset class="login">                   
                    <table>                        
                        <tr>
                            <td rowspan="2" >
                                <img src="imagenes/ImageResource.axd.png" />
                            </td>
                            <td align="left" style="padding-right: 5px">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry" Width="173px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                    ControlToValidate="UserName" CssClass="failureNotification" 
                                    ErrorMessage="Usuario es requerido." ToolTip="Usuario es requerido." 
                                    ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                            </td>
                           
                        </tr>
                        <tr>                            
                            <td align="left" valign="top"><asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label></td>
                            <td valign="top"><asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" 
                            TextMode="Password" Width="173px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                            CssClass="failureNotification" ErrorMessage="Clave es requerida." ToolTip="Clave es requerida." 
                            ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator> 
                            </td>
                        </tr>
                    </table>            
                </fieldset>                    
                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar sesión" 
                        ValidationGroup="LoginUserValidationGroup" Width="97px" />
            </LayoutTemplate>
        </asp:Login> 
        </center>       
    </div>
</asp:Content>