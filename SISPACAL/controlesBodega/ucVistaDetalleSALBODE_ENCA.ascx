<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSALBODE_ENCA.ascx.vb" Inherits="controles_ucVistaDetalleSALBODE_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSALBODE_DETA" Src="~/controlesBodega/ucListaSALBODE_DETA.ascx" %>
<center>
<table width="100%" >
    <tr>
        <td> 
            <table border="0">
                <tr id="trIdDocentra" runat="server" visible="false"> 
                    <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Identificador:" /></td>    
                    <td>                           
                        <dx:ASPxTextBox ID="txtID_SALBODE_ENCA" runat="server" ClientVisible="false" Width="120px" BackColor="WhiteSmoke">                               
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>                        
                    </td>  
                    <td></td>
                    <td></td>                                                                 
                </tr>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Zafra:" /></td>
                    <td>
                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" ClientEnabled="false" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxComboBox>
                    </td>
                    <td></td>
                    <td></td>                  
                </tr>
                <tr> 
                    <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="N° Solicitud Retiro:" /></td>
                    <td><dx:ASPxTextBox ID="txtNO_DOCUMENTO" runat="server" ClientInstanceName="txtNO_DOCUMENTO" Width="120px" BackColor="WhiteSmoke">                               
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>     
                    </td>
                    <td></td>
                    <td></td> 
                </tr>
                <tr>                    
                    <td>                                                                                                         
                        <dx:ASPxLabel runat="server" Text="Fecha:" ID="ASPxLabel11"></dx:ASPxLabel>
                    </td>  
                    <td>
                        <dx:ASPxDateEdit runat="server" UseMaskBehavior="True" EditFormat="Custom" EditFormatString="dd/MM/yyyy" Width="120px" DisplayFormatString="dd/MM/yyyy" ClientEnabled="False" ID="dteFECHA_DOCTO">
                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxDateEdit>  
                    </td> 
                    <td></td>
                    <td></td>                                                                                                       
                </tr>  
                <tr>
                    <td>                                                                                                         
                        <dx:ASPxLabel runat="server" Text="Retiro en Bodega por el Productor:" ID="ASPxLabel1"></dx:ASPxLabel>
                    </td> 
                    <td><dx:ASPxCheckBox ID="chkRETIRO_PROD" runat="server"></dx:ASPxCheckBox></td>
                    <td></td>
                    <td></td>   
                </tr>                
                <tr>
                        <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="N° de Solicitudes:" /></td>
                        <th colspan="3">
                            <dx:ASPxTextBox ID="txtNUMS_SOLICITUDES" runat="server" Width="250px" MaxLength="200"  >                                        
                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                            </dx:ASPxTextBox>
                        </th>
                        <td>
                        <dx:ASPxButton ID="btnSolicIgualEntrega" Theme="RedWine" AutoPostBack="true" runat="server" Text="Solicitado = Entregado"></dx:ASPxButton>
                        </td>
               </tr>
            </table>
            <table width="100%">
                <tr>
                    <td>
                        <uc1:ucListaSALBODE_DETA id="ucListaSALBODE_DETA1" VerCANT_ANULADA="true" VerESTADO="true" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" runat="server"></uc1:ucListaSALBODE_DETA>
                    </td>
                </tr>
            </table>
        </td>                                       
    </tr>
</table>
</center>

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>