<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCREFISCAL_PROVEEDOR.ascx.vb" Inherits="controles_ucVistaDetalleCREFISCAL_PROVEEDOR" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<style type="text/css">
    .auto-style1 {
        height: 28px;
    }
</style>


<table width="80%" >
    <tr>
        <td align="center">
            <br />
            <br />
            <br />
            <br />
            <dx:ASPxFormLayout ID="ucVistaDetalleCCF_ENCALayout" ClientInstanceName="ucVistaDetalleCCF_ENCALayout" runat="server" Theme="iOS" >
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgMembresiaGremial" Caption="Informacion de Credito Fiscal" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        
                                        <table>
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Contribuyente:" /></td>
                                                <td><dx:ASPxTextBox ID="txtCONTRIBUYENTE" runat="server" ForeColor="Black" Width="450px" ClientEnabled="false" Theme="iOS" Text="" Font-Bold="True"  >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td> 
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="NIT:" /></td>
                                                <td><dx:ASPxTextBox ID="txtNIT" runat="server" ForeColor="Black" Width="450px" ClientEnabled="false" Theme="iOS" Text="" Font-Bold="True"  >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td> 
                                            </tr>
                                             <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="No. Documento / Codigo de generacion:" /></td>
                                                <td class="auto-style1"><dx:ASPxTextBox ID="txtCODI_GENERACION" ForeColor="Black" runat="server" Width="450px" Theme="iOS" Text="" >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td>                                                                                                  
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Serie / Sello de recepcion:" /></td>
                                                <td><dx:ASPxTextBox ID="txtSELLO_RECEPCION" ForeColor="Black" runat="server" Width="450px" Theme="iOS" Text="" >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td>                                                                                                  
                                            </tr>       
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Resolucion / No. de Control:" /></td>
                                                <td><dx:ASPxTextBox ID="txtNUMERO" runat="server" ForeColor="Black" Width="450px" Theme="iOS" Text=""  >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td>                                                                                                  
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Fecha:"/></td>
                                                <td style="text-align:left">
                                                    <dx:ASPxDateEdit ID="dteFECHA" ForeColor="Black" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100%" Theme="iOS" >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit> 
                                                </td> 
                                               
                                            </tr>                                           
                                                                               
                                        </table>
                                       
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                                        
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>            
        </td>
    </tr> 
 </table>