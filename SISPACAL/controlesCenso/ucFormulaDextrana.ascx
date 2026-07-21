<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFormulaDextrana.ascx.vb" Inherits="controlesCenso_ucFormulaDextrana" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tbody>
	       <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Fórmula de Dextrana</asp:Label></td>
		   </tr>
		   <tr>
			   <td align="center">
                   <dx:ASPxFormLayout ID="ucCriteriosAnalisisPrecosechaLayout" runat="server" SettingsItemCaptions-Location="Left" Name="glCriterios" Width="500px" >
                       <Items>
                           <dx:LayoutGroup ColCount="2" ShowCaption="false" GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Pre-Cosecha:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                               <dx:ASPxTextBox runat="server" ID="txtZAFRA" ClientEnabled="false" />   
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                   <dx:LayoutItem  ShowCaption="False" ColSpan="2">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                               <dx:ASPxLabel ID="lbl1" Text="DEXTRANA (ppm) = (CONSTANTE A + ABSORVANCIA) / CONSTANTE B"  runat="server" Font-Bold="true" />                                               
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                  
                                   <dx:LayoutItem Caption="Constante A">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                               <dx:ASPxSpinEdit ID="speCONSTANTE_A" runat="server" AutoPostBack="True" Width="120px">
                                                </dx:ASPxSpinEdit>  
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Constante B">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                               <dx:ASPxSpinEdit ID="speCONSTANTE_B" runat="server" AutoPostBack="True" Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                   
                               </Items>
                           </dx:LayoutGroup>
                       </Items>
                   </dx:ASPxFormLayout>

               </td>
		   </tr>	      
    </tbody>
</table>
