<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPlanEntregaCanaPorLote.ascx.vb" Inherits="controles_ucPlanEntregaCanaPorLote" %>
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
</style>
<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td> 
    </tr>
    <tr>
       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Laboratorio de Pago Calidad</asp:Label></td>		
    </tr>
</table>
<div class="centraTabla">  
    <div class="ContenedorCamposOscuro" >
        <asp:Label id="Label2" class="NormalBold" runat="server">Criterios de búsqueda</asp:Label>
    </div> 
    <div class="ContenedorCampos">      
        <table cellspacing="0" cellpadding="0" border="0">        
            <tr>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label1" runat="server">ZONA:</asp:Label></td>
                <td style="padding-right:5px"><cc1:ddlZONAS ID="DdlZONAS1" runat="server" 
                        CssClass="DDLClass" Width="200px"></cc1:ddlZONAS></td>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label3" runat="server">SEMANA:</asp:Label></td>
                <td style="width:350px"><cc1:ddlPLAN_SEMANAL ID="DdlPLAN_SEMANAL1" CssClass="DDLClass" runat="server" Width="100%">
                                    </cc1:ddlPLAN_SEMANAL></td>
            </tr>         
            <tr>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label5" runat="server">CODIGO PROVEE/SOCIO:</asp:Label></td>
                <td style="padding-right:5px"><asp:TextBox CssClass="TextoDerecha" id="txtCODIPROVEE" runat="server" AutoPostBack="True" Width="100px" />
                                        <asp:TextBox CssClass="TextoDerecha" id="txtCODSOCIO" runat="server" AutoPostBack="True" Width="80px" /></td>        
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label6" runat="server">NOMBRE PROVEEDOR:</asp:Label></td>
                <td><asp:TextBox CssClass="NormalUPPER" id="txtNOMBRE_PROVEEDOR" runat="server" Width="100%" /></td>            
            </tr>       
            <tr>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label4" runat="server">INCLUIR LOTES NO PROGRAMADOS EN<br />SEMANA SELECCIONADA:</asp:Label></td>
                <td>
                    <asp:CheckBox ID="chkINCLUIR_LOTES_NO_PROGRAMADOS" Checked="True" runat="server" />
                </td> 
                <td></td>
                <td></td>
            </tr>  
        </table>
    </div> 
    <div class="ContenedorCamposOscuro" >
        <asp:Label id="Label7" class="NormalBold" runat="server">PROGRAMAR ENTREGA <br/>(Seleccione un lote, ingrese manzanas y toneladas a programar y haga clic en Programar)</asp:Label>
    </div> 
    <div class="ContenedorCampos">            
        <table width="100%">
            <tr>
                <td> 
                    <asp:Panel ID="Panel1" runat="server" Width="100%" Height="300px" 
                    ScrollBars="Auto" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="0px">   
                    <asp:GridView ID="grdLotes" runat="server" RowStyle-ForeColor="Black" 
                            AutoGenerateColumns="False" Width="100%" Font-Names="Arial" Font-Size="11px"
                        DataKeyNames="ACCESLOTE" BackColor="White" AllowPaging="True" PagerStyle-Font-Size="Small" PageSize="7" >                        
                        <Columns>
                            <asp:CommandField ButtonType="Image" SelectImageUrl="~/imagenes/play2.png" 
                                ShowSelectButton="True" HeaderStyle-BackColor="#CDE0FC" 
                                HeaderStyle-BorderColor="#999999" HeaderStyle-BorderStyle="Solid" 
                                HeaderStyle-BorderWidth="1px" HeaderStyle-ForeColor="Black" >
                            <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" Width="20px"  />
                            <ItemStyle HorizontalAlign="Center"  />
                            </asp:CommandField>
                            <asp:BoundField DataField="CODILOTE" HeaderText="COD. LOTE" ReadOnly="True">
                                 <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOMBLOTE" HeaderText="NOMBRE LOTE" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="90px" />
                            </asp:BoundField>                  
                            <asp:BoundField DataField="AREA" HeaderText="AREA/MZ" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="60px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TONELADAS" HeaderText="TON/MZ" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="60px"/>
                            </asp:BoundField>
                             <asp:BoundField DataField="TONEL_TC" HeaderText="TONELADAS CONTRATADAS" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TONELADAS_PROGRAMADAS" HeaderText="TONELADAS PROGRAMADAS" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="100px"  />
                            </asp:BoundField>                          
                            <asp:BoundField DataField="TONELADAS_ENTREGADAS" HeaderText="TONELADAS ENTREGADAS" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center"  />
                            </asp:BoundField> 
                            <asp:BoundField DataField="EDAD_LOTE" HeaderText="EDAD LOTE" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="50px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CODIVARIEDA" HeaderText="COD. VARIEDAD" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOM_VARIEDAD" HeaderText="VARIEDAD" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CODIUBICACION" HeaderText="COD. UBICACION" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CANTON" HeaderText="CANTON" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="80px" />
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
                <td class="style1"><asp:Label CssClass="Normal" id="Label8" runat="server">MANZANAS:</asp:Label></td>
                <td class="style1"><asp:TextBox CssClass="TextoDerecha" id="txtMANZANAS_PROGRAMADAS" runat="server" Width="100px" /></td>                
                <td><asp:Label CssClass="Normal" id="Label9" runat="server">TONELADAS:</asp:Label></td>
                <td><asp:TextBox CssClass="TextoDerecha" id="txtTONELADAS_PROGRAMADAS" runat="server" Width="100px" /></td> 
            </tr>            
        </table>        
    </div>
</div>
