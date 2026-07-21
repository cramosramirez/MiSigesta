<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDIA_ZAFRA.ascx.vb" Inherits="controles_ucMantDIA_ZAFRA" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDIA_ZAFRA" Src="~/controles/ucListaDIA_ZAFRA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDIA_ZAFRA" Src="~/controles/ucVistaDetalleDIA_ZAFRA.ascx" %>
<style type="text/css">  
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
</style>
<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<div class="centraTabla">
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>	       
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Ingreso de Producción Diaria</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
           <tr>
               <td>   
                   <table runat="server" id="tblZAFRA"  >
                       <tr>
                           <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zafra:"></dx:ASPxLabel> </td>
                           <td>
                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
                                ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA" Theme="Office2010Blue" Width="118px" >               
                                </dx:ASPxComboBox>
                           </td>
                       </tr>
                   </table>                                 
               </td>
           </tr>
	       <TR>
            <TD><uc1:ucListaDIA_ZAFRA id="ucListaDIA_ZAFRA1" runat="server" PermitirEditarInline="false"  PermitirEditar="false" PermitirEliminar="false"></uc1:ucListaDIA_ZAFRA>
                <uc1:ucVistaDetalleDIA_ZAFRA ID="ucVistaDetalleDIA_ZAFRA1" runat="server" Visible="false" 
                 VerUSUARIO_CIERRE="false"
                 VerFECHA_CIERRE="false" 
                /></TD>
        </TR>
    </TBODY>
</TABLE>
</div>
<asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>