<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCHEQUERA_PLANILLA.ascx.vb" Inherits="controles_ucListaCHEQUERA_PLANILLA" %>
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
	   	   <asp:TemplateField HeaderText="Id chequera" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUERA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUERA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_CHEQUERA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUERA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Cuenta bancaria">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CUENTA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CUENTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCUENTA_BANCARIA id="ddlCUENTA_BANCARIAID_CUENTA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCUENTA_BANCARIA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_CUENTA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CUENTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCUENTA_BANCARIA id="ddlCUENTA_BANCARIAID_CUENTA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCUENTA_BANCARIA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="SERIE" HeaderText="Serie"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_CHEQUE_INICIAL" HeaderText="No cheque inicial"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_CHEQUE_FINAL" HeaderText="No cheque final"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>	   	   
            <asp:TemplateField HeaderText="Ultimo cheque asignado" ItemStyle-HorizontalAlign="Right">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="lblULT_CHEQUE_ASIGNADO" runat="server" />
	   	   	   </ItemTemplate>	   
	   	   </asp:TemplateField>	 
	   	   <asp:BoundField DataField="ACTIVO" HeaderText="Activo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_CHEQUERA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
