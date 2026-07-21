<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaENVIO.ascx.vb" Inherits="controles_ucListaENVIO" %>
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
	   	   <asp:TemplateField HeaderText="Id envio" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ENVIO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ENVIO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ENVIO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ENVIO") %>'>
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
	   	   <asp:BoundField DataField="DIAZAFRA" HeaderText="Diazafra"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="CATORCENA" HeaderText="Catorcena"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
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
	   	   <asp:TemplateField HeaderText="Proveedor">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIPROVEEDOR1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR id="ddlPROVEEDORCODIPROVEEDOR1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPROVEEDOR></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIPROVEEDOR2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIPROVEEDOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR id="ddlPROVEEDORCODIPROVEEDOR2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROVEEDOR></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="COMPTENVIO" HeaderText="Comptenvio"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
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
	   	   <asp:TemplateField HeaderText="Transportista">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODTRANSPORT1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODTRANSPORT") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTRANSPORTISTA id="ddlTRANSPORTISTACODTRANSPORT1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTRANSPORTISTA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODTRANSPORT2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODTRANSPORT") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTRANSPORTISTA id="ddlTRANSPORTISTACODTRANSPORT2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTRANSPORTISTA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="NOMBRES_MOTORISTA" HeaderText="Nombres motorista"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="APELLIDOS_MOTORISTA" HeaderText="Apellidos motorista"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField HeaderText="Tipo cana">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_CANA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_CANA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_CANA id="ddlTIPO_CANAID_TIPO_CANA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_CANA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_CANA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_CANA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_CANA id="ddlTIPO_CANAID_TIPO_CANA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_CANA></TD>
	   	   	   </EditItemTemplate>
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
	   	   <asp:TemplateField HeaderText="Supervisor">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_SUPERVISOR1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlSUPERVISOR id="ddlSUPERVISORID_SUPERVISOR1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlSUPERVISOR></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_SUPERVISOR2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlSUPERVISOR id="ddlSUPERVISORID_SUPERVISOR2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlSUPERVISOR></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="FECHA_QUEMA" HeaderText="Fecha quema"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CORTA" HeaderText="Fecha corta"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="QUEMAPROG" HeaderText="Quemaprog"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CARGA" HeaderText="Fecha carga"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_PATIO" HeaderText="Fecha patio"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NROBOLETA" HeaderText="Nroboleta"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="MADURANTE" HeaderText="Madurante"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CERRADO" HeaderText="Cerrado"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ENTRADA" HeaderText="Fecha entrada"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="PLACAVEHIC" HeaderText="Placavehic"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ID_TIPOTRANS" HeaderText="Id tipotrans"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="SERVICIO_ROZA" HeaderText="Servicio roza"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TRANSPORTE_PROPIO" HeaderText="Transporte propio"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIPO_SERV_ROZA" HeaderText="Tipo serv roza"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:TemplateField HeaderText="Proveedor roza">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PROVEEDOR_ROZA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PROVEEDOR_ROZA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR_ROZA id="ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPROVEEDOR_ROZA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PROVEEDOR_ROZA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PROVEEDOR_ROZA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR_ROZA id="ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROVEEDOR_ROZA></TD>
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
	   	   <asp:BoundField DataField="NUMRECIBO_CANA" HeaderText="Numrecibo cana"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ENVIO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
