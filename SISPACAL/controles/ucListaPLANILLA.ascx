<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPLANILLA.ascx.vb" Inherits="controles_ucListaPLANILLA" %>
<asp:GridView ID="gvLista" CssClass="NormalGrid" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >
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
	   	   <asp:TemplateField HeaderText="Codigo" ItemStyle-HorizontalAlign="Left"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR_TRANSPORTISTA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR_TRANSPORTISTA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_CODIPROVEEDOR_TRANSPORTISTA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR_TRANSPORTISTA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="NOMBRE_ZAFRA" HeaderText="Nombre zafra"  Visible="false" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIPROVEE" HeaderText="Codiprovee" Visible="false" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODISOCIO" HeaderText="Codisocio" Visible="false" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOMBRE_PROVEE_TRANS" HeaderText="Nombres" ItemStyle-HorizontalAlign="Left"></asp:BoundField>	   	   
	   	   <asp:BoundField DataField="CANT_RECIBOS" HeaderText="Recibos"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TONEL_CANA_ENTREGADA" HeaderText="Tonls."  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="AZUCAR_CATORCENA_REAL" HeaderText="Lbs. Azucar"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="VALOR" HeaderText="Valor US$"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="IVA" HeaderText="Iva"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="VALOR_BRUTO" HeaderText="Total US$"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="RENTA" HeaderText="Renta"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="RETENCION_IVA" HeaderText="Retencion 1%"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>           
           <asp:TemplateField HeaderText="Roza" ItemStyle-HorizontalAlign="Right" >
                <ItemTemplate>                                    
                    <asp:Label id="lblTOTAL_DESC_ROZA" runat="server" />
                </ItemTemplate>
           </asp:TemplateField>  
           <asp:TemplateField HeaderText="Carga" ItemStyle-HorizontalAlign="Right" >
                <ItemTemplate>                                    
                    <asp:Label id="lblTOTAL_DESC_CARGA" runat="server" />
                </ItemTemplate>
           </asp:TemplateField>            
           <asp:BoundField DataField="DESC_FLETE" HeaderText="Flete"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>             
           <asp:TemplateField HeaderText="Desc. Adicionales" ItemStyle-HorizontalAlign="Right" >
                <ItemTemplate>                                    
                    <asp:Label id="lblTOTAL_DESC_ADICIONALES" runat="server" />
                </ItemTemplate>
           </asp:TemplateField>               
           <asp:BoundField DataField="PAGO_NETO" HeaderText="Neto US$"  DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>	
           <asp:BoundField DataField="DESC_SERVICIO_ROZA" HeaderText="Desc. Roza" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_ROZA_SIN_TRIPULACION" HeaderText="Desc. Roza S/Trip." Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_ROZA_CON_TRIPULACION" HeaderText="Desc. Roza C/Trip." Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
           <asp:BoundField DataField="DESC_CARGA" HeaderText="Desc. Carga" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_CARGA_CONTRA" HeaderText="Desc. Carga Contra." Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_BANCOS" HeaderText="Desc bancos" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_COMBUSTIBLE" HeaderText="Desc combustible" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_ANTICIPO" HeaderText="Desc anticipo" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_INTERES" HeaderText="Desc interes" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_AGROQUIMICO" HeaderText="Desc agroquimico" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_SEGURO" HeaderText="Desc seguro" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_RESPUESTOS" HeaderText="Desc respuestos" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="DESC_OTROS" HeaderText="Desc otros" Visible="false" DataFormatString="{0:n2}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ES_CONTRIBUYENTE" HeaderText="Es contribuyente" Visible="false" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea" Visible="false" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea" Visible="false" DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act" Visible="false" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act" Visible="false" DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   
	   	   <asp:TemplateField Visible="false">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR_TRANSPORTISTA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
