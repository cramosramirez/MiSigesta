<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCHEQUE_PARTIDA.ascx.vb" Inherits="controles_ucListaCHEQUE_PARTIDA" %>
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
	   	   <asp:TemplateField HeaderText="Id cheque partida" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUE_PARTIDA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUE_PARTIDA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_CHEQUE_PARTIDA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUE_PARTIDA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Cheque planilla">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CHEQUE_PLANILLA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUE_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCHEQUE_PLANILLA id="ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCHEQUE_PLANILLA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CHEQUE_PLANILLA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUE_PLANILLA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCHEQUE_PLANILLA id="ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCHEQUE_PLANILLA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="ORDEN" HeaderText="Orden"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="CUENTA_CONTABLE" HeaderText="Cuenta contable"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DESCRIPCION_CUENTA" HeaderText="Descripcion cuenta"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DESCRIPCION_ADICIONAL" HeaderText="Descripcion adicional"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DEBE" HeaderText="Debe"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="HABER" HeaderText="Haber"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ANULACION" HeaderText="Fecha anulacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="MOTIVO_ANULACION" HeaderText="Motivo anulacion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUE_PARTIDA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
