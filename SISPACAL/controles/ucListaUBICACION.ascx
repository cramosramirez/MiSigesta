<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaUBICACION.ascx.vb" Inherits="controles_ucListaUBICACION" %>
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
	   	   <asp:TemplateField HeaderText="Codiubicacion" ItemStyle-HorizontalAlign="Left"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.CODIUBICACION") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.CODIUBICACION") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_CODIUBICACION" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIUBICACION") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Tarifa">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODITARIFA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODITARIFA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTARIFA id="ddlTARIFACODITARIFA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTARIFA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODITARIFA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODITARIFA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTARIFA id="ddlTARIFACODITARIFA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTARIFA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField Visible="False" DataField="DEPARTAMENTO" HeaderText="Departamento"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="MUNICIPIO" HeaderText="Municipio"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="CANTON" HeaderText="Canton"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="KILOMETRO" HeaderText="Kilometro"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="USER_CREA" HeaderText="User crea"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="USER_ACT" HeaderText="User act"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField Visible="False" DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.CODIUBICACION") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
