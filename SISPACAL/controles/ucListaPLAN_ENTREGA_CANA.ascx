<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPLAN_ENTREGA_CANA.ascx.vb" Inherits="controles_ucListaPLAN_ENTREGA_CANA" %>
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
	   	   <asp:TemplateField HeaderText="Id plan entrega cana" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_ENTREGA_CANA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_ENTREGA_CANA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_PLAN_ENTREGA_CANA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_ENTREGA_CANA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Plan semanal">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PLAN_SEMANAL1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_SEMANAL") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLAN_SEMANAL id="ddlPLAN_SEMANALID_PLAN_SEMANAL1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPLAN_SEMANAL></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PLAN_SEMANAL2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_SEMANAL") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLAN_SEMANAL id="ddlPLAN_SEMANALID_PLAN_SEMANAL2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPLAN_SEMANAL></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Lotes">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ACCESLOTE1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ACCESLOTE") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlLOTES id="ddlLOTESACCESLOTE1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlLOTES></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ACCESLOTE2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ACCESLOTE") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlLOTES id="ddlLOTESACCESLOTE2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlLOTES></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="AREA_PROGRAMADA" HeaderText="Area programada"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TONEL_PROGRAMADA" HeaderText="Tonel programada"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_ENTREGA_CANA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
