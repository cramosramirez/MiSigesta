<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaORDEN_COMBUSTIBLE.ascx.vb" Inherits="controles_ucListaORDEN_COMBUSTIBLE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >
	   <FooterStyle CssClass="GridListFooter" />
	   <HeaderStyle CssClass="GridListHead" />
	   <RowStyle CssClass="GridListItem" />
	   <SelectedRowStyle CssClass="GridSelectedItem" />
	   <AlternatingRowStyle CssClass="GridListItemAlt" />
	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id orden combus" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUS" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Zafra">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ZAFRA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ZAFRA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlZAFRA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ZAFRA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ZAFRA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlZAFRA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Proveedor combustible">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PROVEEDOR_COMBUS1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PROVEEDOR_COMBUS") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR_COMBUSTIBLE id="ddlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPROVEEDOR_COMBUSTIBLE></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PROVEEDOR_COMBUS2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PROVEEDOR_COMBUS") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR_COMBUSTIBLE id="ddlPROVEEDOR_COMBUSTIBLEID_PROVEEDOR_COMBUS2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROVEEDOR_COMBUSTIBLE></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="ID_TRANSPORTE" HeaderText="Id transporte"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ID_MOTORISTA" HeaderText="Id motorista"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_EMISION" HeaderText="Fecha emision"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOMBRES_MOTORISTA" HeaderText="Nombres motorista"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="APELLIDOS_MOTORISTA" HeaderText="Apellidos motorista"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="PLACA" HeaderText="Placa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_DESPACHO" HeaderText="Fecha despacho"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_FACTURA_CCF" HeaderText="No factura ccf"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DUI" HeaderText="Dui"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LICENCIA" HeaderText="Licencia"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ESTADO" HeaderText="Estado"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ANULACION" HeaderText="Fecha anulacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="MOTIVO_ANULACION" HeaderText="Motivo anulacion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_ORDEN" HeaderText="No orden"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ID_ORDEN_COMBUSTIBLE_NUM" HeaderText="Id orden combustible num"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TOTAL" HeaderText="Total"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIGO" HeaderText="Codigo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField HeaderText="Tipo proveedor">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_PROVEEDOR1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_PROVEEDOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_PROVEEDOR id="ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_PROVEEDOR></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_PROVEEDOR2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_PROVEEDOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_PROVEEDOR id="ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_PROVEEDOR></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Catorcena zafra">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CATORCENA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCATORCENA_ZAFRA id="ddlCATORCENA_ZAFRAID_CATORCENA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCATORCENA_ZAFRA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CATORCENA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCATORCENA_ZAFRA id="ddlCATORCENA_ZAFRAID_CATORCENA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCATORCENA_ZAFRA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
