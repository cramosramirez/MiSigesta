<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaMOTORISTA_VEHICULO.ascx.vb" Inherits="controles_ucListaMOTORISTA_VEHICULO" %>
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
	   	   <asp:TemplateField HeaderText="Id motorista vehi" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_MOTORISTA_VEHI") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_MOTORISTA_VEHI") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_MOTORISTA_VEHI" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_MOTORISTA_VEHI") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Motorista">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_MOTORISTA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_MOTORISTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlMOTORISTA id="ddlMOTORISTAID_MOTORISTA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlMOTORISTA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_MOTORISTA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_MOTORISTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlMOTORISTA id="ddlMOTORISTAID_MOTORISTA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlMOTORISTA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Tipo transporte">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPOTRANS1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPOTRANS") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_TRANSPORTE id="ddlTIPO_TRANSPORTEID_TIPOTRANS1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_TRANSPORTE></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPOTRANS2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPOTRANS") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_TRANSPORTE id="ddlTIPO_TRANSPORTEID_TIPOTRANS2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_TRANSPORTE></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="PLACAVEHIC" HeaderText="Placavehic"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_MOTORISTA_VEHI") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
