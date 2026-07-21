<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDESCUENTOS_PLANILLA_OC.ascx.vb" Inherits="controles_ucListaDESCUENTOS_PLANILLA_OC" %>
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
	   	   <asp:TemplateField HeaderText="Id desc pla oc" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_DESC_PLA_OC") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DESC_PLA_OC") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_DESC_PLA_OC" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DESC_PLA_OC") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Descuentos planilla">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_DESCUENTO_PLANILLA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DESCUENTO_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlDESCUENTOS_PLANILLA id="ddlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlDESCUENTOS_PLANILLA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_DESCUENTO_PLANILLA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DESCUENTO_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlDESCUENTOS_PLANILLA id="ddlDESCUENTOS_PLANILLAID_DESCUENTO_PLANILLA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlDESCUENTOS_PLANILLA></TD>
	   	   	   </EditItemTemplate>
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
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_DESC_PLA_OC") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
