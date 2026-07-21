<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleBASCULA.ascx.vb" Inherits="controles_ucVistaDetalleBASCULA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<center>
    <table> 
        <tr>
            <td><dx:ASPxLabel ID="Label101" runat="server" Text="Zafra:" /></td>        
            <td style="width:150px">
                <dx:ASPxComboBox ID="cbxZAFRA" HorizontalAlign="Right" Font-Bold="true" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>        
            <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Catorcena:" /></td>        
            <td style="width:150px">
                <dx:ASPxTextBox ID="txtCATORCENA_ZAFRA" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxTextBox>
            </td>        
            <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Día Zafra:" /></td>        
            <td style="width:150px">
                <dx:ASPxTextBox ID="txtDIAZAFRA" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100%">
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxTextBox>
            </td>           
        </tr>
        <tr>
            <td><dx:ASPxLabel ID="lblTaco" runat="server" Text="N° TACO:" /></td>        
            <td>
                <dx:ASPxSpinEdit ID="txtNROBOLETA" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxSpinEdit>
            </td>  
            <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="N° RECIBO:" /></td> 
            <td>
                <dx:ASPxSpinEdit ID="txtNUMRECIBO_CANA" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxSpinEdit>
            </td> 
            <td></td> 
            <td></td> 
        </tr>
        <tr>
            <th colspan="6">  
                <table>               
                    <tr><th colspan="6"><hr /></th></tr>
                    <tr>
                        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Peso Bruto (kg):" /></td>
                        <td>
                            <dx:ASPxSpinEdit ID="speBRUTO" AutoPostBack="true" DisplayFormatString="#,##0.00" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                            </dx:ASPxSpinEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Fecha/Hora Captura:" /></td>
                        <td>
                            <dx:ASPxDateEdit ID="dteFECHA_LEE_BRUTO" Font-Bold="true" runat="server" HorizontalAlign="Right" 
                            DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True" AllowNull="true" AllowUserInput="TRUE" 
                            EditFormatString="dd/MM/yyyy HH:mm" Width="180px">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
                            <TimeSectionProperties Visible="true" >
                                    <TimeEditProperties EditFormatString="HH:mm" />
                            </TimeSectionProperties>                          
                            </dx:ASPxDateEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Usuario:" /></td>
                        <td>
                            <dx:ASPxComboBox ID="cbxUSUARIO_BRUTO" Font-Bold="true" runat="server" DataSourceID="odsUsuarioPesoBruto" Width="250px" ValueField="USUARIO" TextField="NOMBRE" ValueType="System.String" />  
                        </td>
                    </tr>
                    <tr><th colspan="6"><hr /></th></tr>
                    <tr>
                        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Peso Tara (kg):" /></td>
                        <td>
                            <dx:ASPxSpinEdit ID="speTARA" AutoPostBack="true" DisplayFormatString="#,##0.00" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                            </dx:ASPxSpinEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Fecha/Hora Captura:" /></td>
                        <td>
                            <dx:ASPxDateEdit ID="dteFECHA_LEE_TARA" Font-Bold="true" runat="server" HorizontalAlign="Right" 
                            DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True" AllowNull="true" AllowUserInput="TRUE" 
                            EditFormatString="dd/MM/yyyy HH:mm" Width="180px">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                            <TimeSectionProperties Visible="true" >
                                    <TimeEditProperties EditFormatString="HH:mm" />
                            </TimeSectionProperties>
                            </dx:ASPxDateEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Usuario:" /></td>
                        <td>
                            <dx:ASPxComboBox ID="cbxUSUARIO_TARA" Font-Bold="true" DataSourceID="odsUsuarioPesoTara" Width="250px"  ValueField="USUARIO" TextField="NOMBRE" ValueType="System.String" runat="server" />  
                        </td>
                    </tr>
                    <tr><th colspan="6"><hr /></th></tr>
                    <tr>
                        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Peso Neto (kg):" /></td>
                        <td>
                            <dx:ASPxSpinEdit ID="speNETOLIBRAS" DisplayFormatString="#,##0.00" HorizontalAlign="Right" Font-Bold="true" ClientEnabled="false" runat="server" Width="100px">
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                            </dx:ASPxSpinEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Peso Neto (t):" /></td>
                        <td>
                            <dx:ASPxSpinEdit ID="speNETOTONEL" DisplayFormatString="#,##0.00" HorizontalAlign="Right" Font-Bold="true" ClientEnabled="false" runat="server" Width="100px">
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                            </dx:ASPxSpinEdit>
                        </td>
                    </tr>
                </table>               
            </th>
        </tr>    
    </table>
</center>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsUsuarioPesoBruto" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cUSUARIO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsUsuarioPesoTara" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cUSUARIO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
