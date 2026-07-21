<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPLANILLA.ascx.vb" Inherits="controles_ucMantPLANILLA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLANILLA" Src="~/controles/ucListaPLANILLA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePLANILLA" Src="~/controles/ucVistaDetallePLANILLA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDESCUENTOS_PLANILLA" Src="~/controles/ucVistaDetalleDESCUENTOS_PLANILLA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriterios" Src="~/controles/ucCriterios.ascx" %>

<style type="text/css">   
    div.centraTabla
    {
        font-size: medium;  
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 10px;        
        padding-left: 10px;
        padding-right: 10px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }     
</style>
    <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tbody>	    
                <tr>
		            <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
                </tr>       
		       <tr>
		            <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Planilla</asp:Label></td>
		       </tr>
		       <tr>
                    <td><uc1:ucCriterios id="ucCriterios1" runat="server"></uc1:ucCriterios></td>            
               </tr>        
               <tr>
                   <td><hr /></td>
               </tr>
        </tbody>
    </table> 
<div class="centraTabla"> 
     <table width="100%">
               <tr>
                    <td>
                    <uc1:ucListaPLANILLA id="ucListaPLANILLA1" runat="server"></uc1:ucListaPLANILLA>
                    <uc1:ucVistaDetallePLANILLA ID="ucVistaDetallePLANILLA1" runat="server" Visible="false" ></uc1:ucVistaDetallePLANILLA>
                    <uc1:ucVistaDetalleDESCUENTOS_PLANILLA ID="ucVistaDetalleDESCUENTOS_PLANILLA1" runat="server" Visible="false" ></uc1:ucVistaDetalleDESCUENTOS_PLANILLA>
                    </td>
              </tr>       
    </table>
</div>