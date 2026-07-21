<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPLAN_SEMANAL.ascx.vb" Inherits="controles_ucListaPLAN_SEMANAL" %>
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
	   	   <asp:TemplateField HeaderText="Id plan semanal" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_SEMANAL") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_SEMANAL") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_PLAN_SEMANAL" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_SEMANAL") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Plan catorcena">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PLAN_CATORCENA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_CATORCENA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLAN_CATORCENA id="ddlPLAN_CATORCENAID_PLAN_CATORCENA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPLAN_CATORCENA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PLAN_CATORCENA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_CATORCENA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLAN_CATORCENA id="ddlPLAN_CATORCENAID_PLAN_CATORCENA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPLAN_CATORCENA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="NO_SEMANA" HeaderText="No semana"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_INICIO" HeaderText="Fecha inicio"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_FIN" HeaderText="Fecha fin"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_PLAN_SEMANAL") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
