<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPLANILLA_BASE.ascx.vb" Inherits="controles_ucMantPLANILLA_BASE" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLANILLA_BASE" Src="~/controles/ucListaPLANILLA_BASE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePLANILLA_BASE" Src="~/controles/ucVistaDetallePLANILLA_BASE.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Registro de Planillas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
        <tr id="trZAFRA" runat="server">
               <td>
                   <table>
                       <tr>
                           <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zafra:">
                                </dx:ASPxLabel>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" 
                                ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" Theme="Office2010Blue" Width="118px" >               
                                </dx:ASPxComboBox>
                            </td>
                       </tr>
                       <tr>
                           <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Tipo de Planilla:">
                                </dx:ASPxLabel>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cbxTIPO_PLANILLA" runat="server" ValueType="System.Int32" DataSourceID="odsTipoPlanilla"  
                                ValueField="ID_TIPO_PLANILLA" TextField="NOMBRE_TIPO_PLANILLA" Theme="Office2010Blue" Width="400px" >               
                                </dx:ASPxComboBox>
                            </td>
                       </tr>
                   </table>
               </td>
           </tr>
	       <TR>
            <TD><uc1:ucListaPLANILLA_BASE id="ucListaPLANILLA_BASE1" PermitirEliminar="false" runat="server"></uc1:ucListaPLANILLA_BASE>
                <uc1:ucVistaDetallePLANILLA_BASE ID="ucVistaDetallePLANILLA_BASE1" runat="server" Visible="false" ></uc1:ucVistaDetallePLANILLA_BASE></TD>
        </TR>
    </TBODY>
</TABLE>

 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>

 <asp:ObjectDataSource ID="odsTipoPlanilla" runat="server" TypeName="SISPACAL.BL.cTIPO_PLANILLA" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
     <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="ID_TIPO_PLANILLA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
     </SelectParameters>
 </asp:ObjectDataSource>