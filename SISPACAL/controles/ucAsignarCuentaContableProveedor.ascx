<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsignarCuentaContableProveedor.ascx.vb" Inherits="controles_ucAsignarCuentaContableProveedor" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>

<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
    }
    div.centraTabla
    {
        font-size: small;     
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 15px; 
        padding-top: 10px;
        padding-left: 15px;
        padding-right: 15px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }  
      .seccion
    {
        background-color: #003366;
        color: White;  
        font-weight: bold;
        border: 2px;      
        text-align: center;  
        height: 20px; 
    }
    .style1
    {
        height: 26px;
    }
    .style2
    {
        height: 250px;
        vertical-align: bottom;
    }
</style>
<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td> 
    </tr>
    <tr>
       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Asignación de Cuenta Contable a Proveedor</asp:Label></td>		
    </tr>
</table>
<div class="centraTabla">  
    <div class="ContenedorCamposOscuro" >
        <asp:Label id="Label2" class="NormalBold" runat="server">Criterios de búsqueda</asp:Label>
    </div> 
    <div class="ContenedorCampos">      
        <table cellspacing="0" cellpadding="0" border="0">                   
            <tr>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label1" runat="server">TIPO PROVEEDOR:</asp:Label></td>
                <td style="padding-right:5px">
                    <cc1:ddlTIPO_PROVEEDOR ID="ddlTIPO_PROVEEDOR1" CssClass="DDLClassNormal" Width="130px" runat="server" AutoPostBack="true" />
                </td>                 
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label5" runat="server">CODIGO PROVEE/SOCIO:</asp:Label></td>
                <td style="padding-right:5px"><asp:TextBox CssClass="TextoDerecha" id="txtCODIPROVEE" runat="server" AutoPostBack="True" Width="80px" />
                                        <asp:TextBox CssClass="TextoDerecha" id="txtCODSOCIO" runat="server" AutoPostBack="True" Width="50px" /></td>        
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label6" runat="server">NOMBRE PROVEEDOR:</asp:Label></td>
                <td><asp:TextBox CssClass="NormalUPPER" id="txtNOMBRE_PROVEEDOR" runat="server" Width="200px" /></td>            
            </tr>                   
        </table>
    </div> 
    <div class="ContenedorCamposOscuro" >
        <asp:Label id="Label7" class="NormalBold" runat="server">ASIGNAR CUENTA CONTABLE <br/>(Seleccione un proveedor, ingrese ingrese el número de Cuenta Contable y haga clic en Guardar)</asp:Label>
    </div> 
    <div class="ContenedorCampos">            
        <table width="100%">
            <tr>
                <td class="style2"> 
                    <asp:Panel ID="Panel1" runat="server" Width="100%" Height="250px" 
                    ScrollBars="Auto" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="0px">   
                    <asp:GridView ID="grdProveedores" runat="server" RowStyle-ForeColor="Black" 
                            AutoGenerateColumns="False" Width="100%" Font-Names="Arial" Font-Size="11px"
                        DataKeyNames="CODIGO" BackColor="White" AllowPaging="True" PagerStyle-Font-Size="Small" PageSize="10" >                        
                        <Columns>
                            <asp:CommandField ButtonType="Image" SelectImageUrl="~/imagenes/play2.png" 
                                ShowSelectButton="True" HeaderStyle-BackColor="#CDE0FC" 
                                HeaderStyle-BorderColor="#999999" HeaderStyle-BorderStyle="Solid" 
                                HeaderStyle-BorderWidth="1px" HeaderStyle-ForeColor="Black" >
                            <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" Width="20px"  />
                            <ItemStyle HorizontalAlign="Center"  />
                            </asp:CommandField>                           
                            <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" ReadOnly="True">
                                 <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" Width="100px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOMBRE_COMPLETO" HeaderText="NOMBRE COMPLETO" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="500px" />
                            </asp:BoundField>                                             
                            <asp:BoundField DataField="CUENTA" HeaderText="CUENTA CONTABLE" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Left"/>
                            </asp:BoundField>                           
                        </Columns>
                        <SelectedRowStyle BackColor="#FFFFCC" forecolor="DarkBlue"  
                            BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>  
                    </asp:GridView>
                </asp:Panel>         
                </td>
            </tr>
        </table>    
    </div>    
    <div class="ContenedorCampos" >             
        <table>
            <tr>               
                <td class="style1"><asp:Label CssClass="Normal" id="Label8" runat="server">CUENTA CONTABLE:</asp:Label></td>
                <td class="style1"><asp:TextBox CssClass="TextoDerecha" id="txtCUENTA_CONTABLE" runat="server" Width="100px" /></td>                                
            </tr>            
        </table>        
    </div>
</div>
