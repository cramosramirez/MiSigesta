<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantOPCION_PERFIL.ascx.vb" Inherits="controles_ucMantOPCION_PERFIL" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaOPCION" Src="~/controles/ucListaOPCION.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<center>
<table id="TableMant" cellspacing="0" cellpadding="0" border="0">       
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de  Opciones por Perfil</asp:Label></td>
    </tr>
    <tr>
        <td><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Seleccione el Perfil para asignar, quitar o consultar opciones:"></dx:ASPxLabel></td>
    </tr>
    <tr>
        <td style="padding-bottom:10px"><dx:ASPxComboBox ID="cbxPERFIL" Font-Bold="true" AutoPostBack="true" ClientInstanceName="cbxPERFIL" Width="360px" DropDownStyle="DropDownList" runat="server" DataSourceID="odsPERFIL" 
            ValueField="ID_PERFIL" TextField="NOMBRE_PERFIL" ValueType="System.Int32" IncrementalFilteringMode="Contains">                            
        </dx:ASPxComboBox></td>
    </tr>
    <tr>
        <td><uc1:ucListaOPCION id="ucListaOPCION1"        
        PermitirEditar="false" PermitirAgregar="false" PermitirEliminar="false" 
        PermitirArrastrarOpcion="false" PermitirBajarOpcion="false" PermitirSubirOpcion="false" 
        PermitirSeleccionarPorCheckBox = "true"
        PermitirSeleccionarTodos="true"
        PermitirSeleccionarRecursivo="true"
        runat="server"></uc1:ucListaOPCION></td>
    </tr>    
</table>
</center>
<asp:ObjectDataSource ID="odsPERFIL" runat="server" 
    TypeName="SISPACAL.BL.cPERFIL" SelectMethod="ObtenerLista" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="recuperarHijas" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="asColumnaOrden" DefaultValue="NOMBRE_PERFIL" Type="String" />  
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />     
  </SelectParameters> 
 </asp:ObjectDataSource>