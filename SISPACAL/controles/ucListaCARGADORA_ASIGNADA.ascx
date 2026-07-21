<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCARGADORA_ASIGNADA.ascx.vb" Inherits="controles_ucListaCARGADORA_ASIGNADA" %>
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
	   	   <asp:TemplateField HeaderText="Id cargadora asig" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADORA_ASIG") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADORA_ASIG") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_CARGADORA_ASIG" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADORA_ASIG") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Cargadora">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CARGADORA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADORA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCARGADORA id="ddlCARGADORAID_CARGADORA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCARGADORA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CARGADORA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADORA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCARGADORA id="ddlCARGADORAID_CARGADORA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCARGADORA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Cargador">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CARGADOR1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCARGADOR id="ddlCARGADORID_CARGADOR1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCARGADOR></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CARGADOR2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCARGADOR id="ddlCARGADORID_CARGADOR2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCARGADOR></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_CARGADORA_ASIG") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
