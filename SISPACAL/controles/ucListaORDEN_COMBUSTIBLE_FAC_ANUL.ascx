<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaORDEN_COMBUSTIBLE_FAC_ANUL.ascx.vb" Inherits="controles_ucListaORDEN_COMBUSTIBLE_FAC_ANUL" %>
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
	   	   <asp:TemplateField HeaderText="Id orden combus fac anul" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_FAC_ANUL") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_FAC_ANUL") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUS_FAC_ANUL" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_FAC_ANUL") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Orden combustible">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUS1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlORDEN_COMBUSTIBLE id="ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlORDEN_COMBUSTIBLE></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUS2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlORDEN_COMBUSTIBLE id="ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlORDEN_COMBUSTIBLE></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="NO_FACTURA_CCF" HeaderText="No factura ccf"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_DESPACHO" HeaderText="Fecha despacho"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ANULACION" HeaderText="Fecha anulacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="MOTIVO_ANULACION" HeaderText="Motivo anulacion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_FAC_ANUL") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
