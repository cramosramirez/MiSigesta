<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucOperacionCheques.ascx.vb" Inherits="controles_ucOperacionCheques" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucControlCheques" Src="~/controles/ucControlCheques.ascx" %>

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
    <table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
         <tbody>	       
                <tr>
		           <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Comprobante de Envío</asp:Label></td>
		       </tr>
                <tr>
                    <td>
                    <uc1:ucControlCheques ID="ucControlCheques1" runat="server" Visible="true" ></uc1:ucControlCheques>
                    </td>
                </tr>
        </tbody>
    </table>
</div>