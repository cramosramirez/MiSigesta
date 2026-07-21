<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDESCUENTOS_PLANILLA.ascx.vb" Inherits="controles_ucListaDESCUENTOS_PLANILLA" %>
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
	   	   <asp:TemplateField HeaderText="Id descuento planilla" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_DESCUENTO_PLANILLA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DESCUENTO_PLANILLA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_DESCUENTO_PLANILLA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_DESCUENTO_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Catorcena zafra">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CATORCENA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCATORCENA_ZAFRA id="ddlCATORCENA_ZAFRAID_CATORCENA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCATORCENA_ZAFRA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CATORCENA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCATORCENA_ZAFRA id="ddlCATORCENA_ZAFRAID_CATORCENA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCATORCENA_ZAFRA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Codigo Provee/Transp">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIPROVEEDOR_TRANSPORTISTA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR_TRANSPORTISTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLANILLA id="ddlPLANILLACODIPROVEEDOR_TRANSPORTISTA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPLANILLA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIPROVEEDOR_TRANSPORTISTA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR_TRANSPORTISTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPLANILLA id="ddlPLANILLACODIPROVEEDOR_TRANSPORTISTA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPLANILLA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Tipo planilla">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_PLANILLA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_PLANILLA id="ddlTIPO_PLANILLAID_TIPO_PLANILLA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_PLANILLA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_PLANILLA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_PLANILLA id="ddlTIPO_PLANILLAID_TIPO_PLANILLA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_PLANILLA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Tipo descuento">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_DESCTO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_DESCTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_DESCUENTO id="ddlTIPO_DESCUENTOID_TIPO_DESCTO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_DESCUENTO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_DESCTO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_DESCTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_DESCUENTO id="ddlTIPO_DESCUENTOID_TIPO_DESCTO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_DESCUENTO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Aplicacion descto">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_APLICACION_DESCTO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_APLICACION_DESCTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlAPLICACION_DESCTO id="ddlAPLICACION_DESCTOID_APLICACION_DESCTO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlAPLICACION_DESCTO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_APLICACION_DESCTO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_APLICACION_DESCTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlAPLICACION_DESCTO id="ddlAPLICACION_DESCTOID_APLICACION_DESCTO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlAPLICACION_DESCTO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="MONTO_DESCUENTO" HeaderText="Monto descuento"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
           <asp:BoundField DataField="IVA" HeaderText="Iva"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_DESCUENTO_PLANILLA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
