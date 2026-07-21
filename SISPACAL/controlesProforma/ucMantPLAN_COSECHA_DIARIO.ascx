<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPLAN_COSECHA_DIARIO.ascx.vb" Inherits="controles_ucMantPLAN_COSECHA_DIARIO" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLAN_COSECHA_DIARIO" Src="~/controlesProforma/ucListaPLAN_COSECHA_DIARIO.ascx" %>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">    
	    <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </td>
		<tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Plan de Cosecha Diario</asp:Label></td>
		</tr>
		<tr>
			   <td><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
		</tr>
        <tr>           
                <td>
                     <dx:ASPxFormLayout ID="frmlyPLAN_COSECHA_DIARIO" runat="server" SettingsItemCaptions-Location="Left" Name="frmlyPLAN_COSECHA_DIARIO">
                       <Items>
                           <dx:LayoutGroup Caption="Información" ColCount="5" GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px"  >
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>   
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Zona">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                               </dx:ASPxComboBox>         
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Dia Zafra">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">                                              
                                                <dx:ASPxSpinEdit ID="speDIAZAFRA" runat="server" AllowNull="false" MinValue="1"  Width="120px" MaxValue="300">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>

                                    <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true"
                                                    Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                               <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  AllowNull="true"
                                                   Width="120px">
                                               </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:" ColSpan="3">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                               <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="200px">
                                               </dx:ASPxTextBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>  
                              </Items>
                        </dx:LayoutGroup>
                    </Items>
                    </dx:ASPxFormLayout>
                </td>
        </tr>
	    <tr>            
               <td><uc1:ucListaPLAN_COSECHA_DIARIO id="ucListaPLAN_COSECHA_DIARIO1" runat="server"
                    PermitirEdicionBatch="true" ScrollVisible="true" PermitirFilaDeFiltro="true"
                    PermitirFiltroEnEncabezado="false" PermitirEliminar="false" TamanoPagina="3000"         
                     VerticaScrollHeight="400" 
                    ></uc1:ucListaPLAN_COSECHA_DIARIO></td>                
        </tr>
</table>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
