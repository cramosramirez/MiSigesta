<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantREQENCA.ascx.vb" Inherits="controles_ucMantREQENCA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaREQENCA" Src="~/controlesRequisicion/ucListaREQENCA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleREQENCA" Src="~/controlesRequisicion/ucVistaDetalleREQENCA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Solicitud de Requisición</asp:Label> </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxFormLayout ID="ucCriteriosReqEncaLayout" ClientInstanceName="ucCriteriosReqEncaLayout" runat="server" EnableTheming="True" Width="200px" >
            <Items>
                <dx:LayoutGroup ColCount="3" Caption="Criterios de búsqueda"  
                    GroupBoxDecoration="HeadingLine" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                    <Items>
                        <dx:LayoutItem Caption="Periodo:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                    <dx:ASPxComboBox ID="cbxPERIODO" runat="server" DataSourceID="odsPeriodo" ValueField="ID_PERIODOREQ" TextField="DESCRIP_PERIODO" ValueType="System.Int32" Width="250px" >
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="N° Solicitud:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server"> 
                                    <dx:ASPxTextBox ID="txtNUM_SOLICITUD" runat="server" Width="170px">
                                    </dx:ASPxTextBox>                                                                 
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>        
                       </Items>
                    <SettingsItemCaptions HorizontalAlign="Left" Location="Left" 
                        VerticalAlign="Middle" />
                    <SettingsItems HorizontalAlign="Right" VerticalAlign="Middle" />
                </dx:LayoutGroup>
            </Items>
            <SettingsItems ShowCaption="True" />
        </dx:ASPxFormLayout>
        </td>
    </tr>		  
    <tr>
        <td><uc1:ucListaREQENCA id="ucListaREQENCA1" PermitirEliminar="false" runat="server"></uc1:ucListaREQENCA></td>
    </tr>
    <tr>
        <td><uc1:ucVistaDetalleREQENCA ID="ucVistaDetalleREQENCA1" runat="server" Visible="false" ></uc1:ucVistaDetalleREQENCA></td>
    </tr>                          
</table>

<asp:ObjectDataSource ID="odsPeriodo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPERIODOREQ">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="DESCRIP_PERIODO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

