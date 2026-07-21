<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucOrdenCombustible.ascx.vb" Inherits="controles_ucOrdenCombustible" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleORDEN_COMBUSTIBLE" Src="~/controles/ucVistaDetalleORDEN_COMBUSTIBLE.ascx" %>

<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
    }
    .formato2
    {
        padding-right: 10px;
        margin-left: 80px;
        width: 170px;
    }
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
      .seccion
    {
        background-color: #003366;
        color: White;  
        font-weight: bold;
        border: 2px;      
        text-align: center;  
        height: 20px; 
    }
</style>
<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<div class="centraTabla">    
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
                        <uc1:ucVistaDetalleORDEN_COMBUSTIBLE ID="ucVistaDetalleORDEN_COMBUSTIBLE1" runat="server" Visible="true" ></uc1:ucVistaDetalleORDEN_COMBUSTIBLE>                      
                    </td>
                </tr>
        </tbody>
    </table>
</div>