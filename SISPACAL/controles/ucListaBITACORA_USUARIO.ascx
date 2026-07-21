<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaBITACORA_USUARIO.ascx.vb" Inherits="controles_ucListaBITACORA_USUARIO" %>
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
	   	   <asp:TemplateField HeaderText="Id bitacora" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_BITACORA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_BITACORA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_BITACORA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_BITACORA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Usuario">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_USUARIO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.USUARIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlUSUARIO id="ddlUSUARIOUSUARIO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlUSUARIO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_USUARIO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.USUARIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlUSUARIO id="ddlUSUARIOUSUARIO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlUSUARIO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField Visible="False" DataField="FECHA_ENTRADA" HeaderText="Fecha entrada"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="FECHA_SALIDA" HeaderText="Fecha salida"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_BITACORA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
