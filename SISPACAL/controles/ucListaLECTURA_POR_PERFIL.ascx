<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLECTURA_POR_PERFIL.ascx.vb" Inherits="controles_ucListaLECTURA_POR_PERFIL" %>
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
	   	   <asp:TemplateField HeaderText="Id lectura perfil" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_LECTURA_PERFIL") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_LECTURA_PERFIL") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_LECTURA_PERFIL" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_LECTURA_PERFIL") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Perfil">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PERFIL1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PERFIL") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPERFIL id="ddlPERFILID_PERFIL1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPERFIL></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PERFIL2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PERFIL") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPERFIL id="ddlPERFILID_PERFIL2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPERFIL></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Tipo lectura">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_LECTURA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_LECTURA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_LECTURA id="ddlTIPO_LECTURAID_TIPO_LECTURA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_LECTURA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_LECTURA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_LECTURA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_LECTURA id="ddlTIPO_LECTURAID_TIPO_LECTURA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_LECTURA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField Visible="False" DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_LECTURA_PERFIL") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
