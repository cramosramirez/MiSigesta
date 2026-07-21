<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaORDEN_ROZA_DETA.ascx.vb" Inherits="controles_ucListaORDEN_ROZA_DETA" %>
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
	   	   <asp:TemplateField HeaderText="Id orden deta" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_DETA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_DETA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_DETA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_DETA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Orden roza enca">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ORDEN1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlORDEN_ROZA_ENCA id="ddlORDEN_ROZA_ENCAID_ORDEN1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlORDEN_ROZA_ENCA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ORDEN2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlORDEN_ROZA_ENCA id="ddlORDEN_ROZA_ENCAID_ORDEN2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlORDEN_ROZA_ENCA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Plan entrega cana">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PLAN_ENTREGA_CANA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_ENTREGA_CANA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLAN_ENTREGA_CANA id="ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPLAN_ENTREGA_CANA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PLAN_ENTREGA_CANA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_ENTREGA_CANA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLAN_ENTREGA_CANA id="ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPLAN_ENTREGA_CANA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="ACCESLOTE" HeaderText="Acceslote"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_DETA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
