<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTRANSPORTISTA.ascx.vb" Inherits="controles_ucMantTRANSPORTISTA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTRANSPORTISTA" Src="~/controles/ucListaTRANSPORTISTA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTRANSPORTISTA" Src="~/controles/ucVistaDetalleTRANSPORTISTA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Transportista</asp:Label></TD>
		   </TR>
		   <tr>
               <td>
                   <table>
                       <tr>
                           <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Zafra:" /></td>
                           <td><dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" /></td>
                       </tr> 
                   </table>                                
               </td>			  
		   </tr>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTRANSPORTISTA id="ucListaTRANSPORTISTA1" runat="server"></uc1:ucListaTRANSPORTISTA>
                <uc1:ucVistaDetalleTRANSPORTISTA ID="ucVistaDetalleTRANSPORTISTA1" runat="server" Visible="false" ></uc1:ucVistaDetalleTRANSPORTISTA></TD>
        </TR>
    </TBODY>
</TABLE>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
