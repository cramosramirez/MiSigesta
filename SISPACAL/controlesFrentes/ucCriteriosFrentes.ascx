<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosFrentes.ascx.vb" Inherits="controlesFrentes_ucCriteriosFrentes" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<table border="0" >
     <tr id="trZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Zafra:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA"  Width="118px" >               
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trTIPO_FRENTE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Tipo frente:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxTIPO_FRENTE" AutoPostBack="true" ClientInstanceName="ucCriteriosBodega_cbxTIPO_FRENTE" runat="server" ValueType="System.Int32" DataSourceID="odsTipoFrente" ValueField="ID_TIPO_PROVEEDOR" TextField="NOMBRE_TIPO_PROVEEDOR" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trFRENTE" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Cód. Frente:" />                
        </td>
        <td>  
               <dx:ASPxTextBox ID="txtCOD_FRENTE" AutoPostBack="true" runat="server" Width="300px"  />  
        </td>   
        <th colspan="4" >
            <table>
                <tr>
                    <td style="padding-left:15px">
                        <dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Nombre Frente:" />                
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtNOM_FRENTE" runat="server" Width="600px"  />                            
                    </td>  
                </tr>
            </table>
        </th>                
    </tr>
    <tr id="trCUENTA_FINANCIAMIENTO_FRENTE" runat="server" visible="false" >
        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Financiamiento:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxCUENTA_FINANCIAMIENTO_FRENTE" runat="server" ValueField="ID_CUENTA_FINAN" TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinanFrente">  
            </dx:ASPxComboBox>
        </td>
    </tr>
</table>

 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoFrente" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaFrentes" 
    TypeName="SISPACAL.BL.cTIPO_PROVEEDOR">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="ID_TIPO_PROVEEDOR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCuentaFinanFrente" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaSolicFrentes2" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="AgregarVacio" Type="Boolean" />        
    </SelectParameters>
</asp:ObjectDataSource>