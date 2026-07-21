<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCENSO.ascx.vb" Inherits="controles_ucMantCENSO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCENSO" Src="~/controlesCenso/ucListaCENSO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCENSO" Src="~/controlesCenso/ucVistaDetalleCENSO.ascx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">    
	       <tr>
			   <td></td>
           </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">Mantenimiento de Censo</asp:Label></td>
		   </tr>		   
           <tr>
                <td align="center" style="padding-top:20px; padding-bottom:20px">  
                    <table>
                        <tr id="trZAFRA" runat="server" >
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Zafra:"></asp:Label>                  
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cbxZAFRA" runat="server" AutoPostBack="true" DataSourceID="odsZafra" DropDownStyle="DropDownList" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32">
                                </dx:ASPxComboBox>
                            </td>
                        </tr>                    
                    </table>
                </td>
           </tr>
	       <tr>
                <td align="center">
                <uc1:ucListaCENSO id="ucListaCENSO1" runat="server" 
                VerID_ZAFRA="false" VerID_CENSO="false" 
                VerUSUARIO_CREA="False" VerUSUARIO_ACT="False" VerFECHA_ACT="false"></uc1:ucListaCENSO>
                <uc1:ucVistaDetalleCENSO ID="ucVistaDetalleCENSO1" runat="server" Visible="false" VerUSUARIO_CREA="False" VerFECHA_CREA="False" VerUSUARIO_ACT="False" VerFECHA_ACT="false"></uc1:ucVistaDetalleCENSO>
                </td>
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
