<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCANTON.ascx.vb" Inherits="controles_ucListaCANTON" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="CODI_CANTON;CODI_DEPTO;CODI_MUNI" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="70px" Caption=" "  >
            <NewButton Visible="False" Image-ToolTip="Agregar" ></NewButton>      
            <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" ></EditButton>
            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" ></UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" ></CancelButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="false" >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("CODI_MUNI") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("CODI_MUNI") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODI_MUNI" Visible="false" ReadOnly="True" VisibleIndex="2" Caption="Codi muni" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO" VisibleIndex="3" Caption="Departamento" UnboundType="String" >
        <EditItemTemplate>
                 <dx:ASPxLabel ID="lblDEPARTAMENTO" runat="server" Text='<%# Eval("DEPARTAMENTO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO" VisibleIndex="3" Caption="Municipio" UnboundType="String" >
        <EditItemTemplate>
                 <dx:ASPxLabel ID="lblMUNICIPIO" runat="server" Text='<%# Eval("MUNICIPIO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CANTON" VisibleIndex="3" Caption="Cantón" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBRE_CANTON" runat="server" Text='<%# Eval("NOMBRE_CANTON") %>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="KILOMETROS" Visible="false" VisibleIndex="4" Caption="Kilometros" />
        <dx:GridViewDataTextColumn FieldName="POSICION_GEO" Visible="false" VisibleIndex="5" Caption="Posicion geo" />
        <dx:GridViewDataTextColumn FieldName="COORDENADAS" Visible="false" VisibleIndex="6" Caption="Coordenadas" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" Visible="false" VisibleIndex="7" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" Visible="false" VisibleIndex="8" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" Visible="false" VisibleIndex="9" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" Visible="false" VisibleIndex="10" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="11" Caption="Zona" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblZONA" runat="server" Text='<%# Eval("ZONA") %>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataComboBoxColumn FieldName="SUB_ZONA" VisibleIndex="12" Caption="Sub zona" >
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsSUBZONA" ValueField="SUB_ZONA" TextField="SUB_ZONA" ValueType="System.String" TextFormatString="{1}" IncrementalFilteringMode="Contains" >
            <Columns>
                <dx:ListBoxColumn Caption="Zona" FieldName="ZONA" Width="80px" />
                <dx:ListBoxColumn Caption="Sub Zona" FieldName="SUB_ZONA" Width="180px" />
            </Columns>
            </PropertiesComboBox> 
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="13">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" UpdateMethod="ActualizarCANTON" TypeName="SISPACAL.BL.cCANTON">
    <SelectParameters>
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />             
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />             
        <asp:Parameter Name="NOMBRE_CANTON" Type="String" />
        <asp:Parameter Name="KILOMETROS" Type="Decimal" />
        <asp:Parameter Name="POSICION_GEO" Type="String" />            
        <asp:Parameter Name="COORDENADAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA"  Type="DateTime" />            
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZONA" Type="String" />            
        <asp:Parameter Name="SUB_ZONA" Type="String" />            
    </UpdateParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSUBZONA" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSUB_ZONAS">    
</asp:ObjectDataSource>
