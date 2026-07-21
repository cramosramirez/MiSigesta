<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaRECIBO_CANA_ANULADO.ascx.vb" Inherits="controles_ucListaRECIBO_CANA_ANULADO" %>
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
	   	   <asp:TemplateField HeaderText="Id recibo cana anul" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_RECIBO_CANA_ANUL") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_RECIBO_CANA_ANUL") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_RECIBO_CANA_ANUL" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_RECIBO_CANA_ANUL") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
           <asp:TemplateField HeaderText="Zafra">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ZAFRA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ZAFRA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlZAFRA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ZAFRA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ZAFRA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlZAFRA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="NUMRECIBO_CANA" HeaderText="Numrecibo cana"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ANULACION" HeaderText="Fecha anulacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="MOTIVO_ANULACION" HeaderText="Motivo anulacion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>	   	  
	   	   <asp:TemplateField HeaderText="N° Taco">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="lblNROBOLETA" runat="server" Visible="True">
	   	   	   	   </asp:Label>	   	   	   
	   	   	   </ItemTemplate>	   	   	  
	   	   </asp:TemplateField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_RECIBO_CANA_ANUL") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
