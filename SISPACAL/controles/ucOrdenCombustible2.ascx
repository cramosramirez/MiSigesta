<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucOrdenCombustible2.ascx.vb" Inherits="controles_ucOrdenCombustible2" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleORDEN_COMBUSTIBLEV2" Src="~/controles/ucVistaDetalleORDEN_COMBUSTIBLEV2.ascx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion> 
<table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
        <tbody>	      
            <tr>
                <td style="text-align:center">
                <div class="ContenedorCamposOscuro"><asp:Label id="lblTitulo" class="NormalBold" runat="server">ORDEN DE ENTREGA DE COMBUSTIBLE</asp:Label>
                </div> 
                </td>
            </tr> 
            <tr>
                <td>                          
                    <uc1:ucVistaDetalleORDEN_COMBUSTIBLEV2 ID="ucVistaDetalleORDEN_COMBUSTIBLEV21" runat="server" Visible="true" ></uc1:ucVistaDetalleORDEN_COMBUSTIBLEV2>   
                </td>
            </tr>
    </tbody>
</table>
