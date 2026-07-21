<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCATORCENA_ZAFRA.ascx.vb" Inherits="controles_ucListaCATORCENA_ZAFRA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<asp:GridView ID="gvLista" CssClass="Normal" DataKeyNames="ID_CATORCENA"  AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >
	   <FooterStyle CssClass="GridListFooter" />
	   <HeaderStyle CssClass="GridListHead" />
	   <RowStyle CssClass="GridListItem" />
	   <SelectedRowStyle CssClass="GridSelectedItem" />
	   <AlternatingRowStyle CssClass="GridListItemAlt" />
	   <Columns>
          <asp:TemplateField HeaderText="Generar Planilla" ItemStyle-HorizontalAlign="Center"> 
	   	   	<ItemTemplate> 
            <asp:ImageButton ID="imgbtnGenerarPlanilla" BorderStyle="None" ImageUrl="~/imagenes/run.png" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>' CommandName="GenerarPlanilla" runat="server" />
            </ItemTemplate>
         </asp:TemplateField>   
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id catorcena" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_CATORCENA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'>
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
	   	   <asp:BoundField DataField="CATORCENA" HeaderText="Catorcena" ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="AZUCAR_PRODUCIDA" HeaderText="Azucar producida"  DataFormatString="{0:n}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="AZUCAR_CALC1" HeaderText="Azucar efic 100%"  DataFormatString="{0:n}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="EFICIENCIA_REAL" HeaderText="Eficiencia catorcena" ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_INICIO" HeaderText="Fecha inicio"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_FIN" HeaderText="Fecha fin"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CIERRE" HeaderText="Usuario cierre"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CIERRE" HeaderText="Fecha cierre"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="RENDIMIENTO" HeaderText="Rendimiento" ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TONELADA_PRODUCIDA" HeaderText="Tonelada molida"  DataFormatString="{0:n}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="POL_CANA" HeaderText="Pol cana"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>	   	   
           <asp:TemplateField HeaderText="Fecha Pago" ItemStyle-HorizontalAlign="Center">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="lblFECHA_PAGO" runat="server" />
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_CATORCENA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
