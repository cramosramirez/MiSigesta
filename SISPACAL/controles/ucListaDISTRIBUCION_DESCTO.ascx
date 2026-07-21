<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDISTRIBUCION_DESCTO.ascx.vb" Inherits="controles_ucListaDISTRIBUCION_DESCTO" %>
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
	   	   <asp:TemplateField HeaderText="Id distrib descto" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_DISTRIB_DESCTO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DISTRIB_DESCTO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_DISTRIB_DESCTO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DISTRIB_DESCTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Contrato">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODICONTRATO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODICONTRATO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCONTRATO id="ddlCONTRATOCODICONTRATO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCONTRATO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODICONTRATO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODICONTRATO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCONTRATO id="ddlCONTRATOCODICONTRATO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCONTRATO></TD>
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
	   	   <asp:BoundField DataField="MONTO_DESCUENTO" HeaderText="Monto descuento"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_DISTRIB_DESCTO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
