<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCCF_DETA_SALBODE.ascx.vb" Inherits="controles_ucListaCCF_DETA_SALBODE" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Theme="SoftOrange"  KeyFieldName="ID_CCF_DETA_SAL" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
       <PageSizeItemSettings ShowAllItem="true" Visible="false" />   
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="40px" VisibleIndex="0" />  
        <dx:GridViewDataTextColumn FieldName="ID_CCF_DETA_SAL" ReadOnly="True" VisibleIndex="2" Caption="Id ccf deta sal" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SALBODE_DETA" VisibleIndex="3" Caption="Id salbode deta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="4" Caption="Id solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUM_SOLICITUD" VisibleIndex="4" Caption="No. Solicitud" Width="100px"  UnboundType="Integer" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="5" Caption="Id Producto" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="6" Caption="Nombre producto" SortIndex="0" SortOrder="Ascending" />
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="7" Caption="Presentacion" Width="140px" />
        <dx:GridViewDataTextColumn FieldName="CANTIDAD_CCF" VisibleIndex="8" Caption="Cantidad Facturada" >
            <PropertiesTextEdit DisplayFormatString="#,###0.00##" />  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PRECIO_UNITARIO_CCF" VisibleIndex="9" Caption="Precio unitario ccf" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TOTAL_CCF" VisibleIndex="10" Caption="Total ccf" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Visible="false"  
            Name="Eliminar" VisibleIndex="11">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  VerticalScrollBarMode="Auto" VerticalScrollableHeight="300"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsCCF_DETA_SALBODEcache" runat="server" TypeName="cCCF_DETA_SALBODEcache"     
    SelectMethod="ObtenerLista" >       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaCCF_DETA_SALBODE" Type="String" />
     </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCCF_DETA_SALBODE" DeleteMethod="EliminarCCF_DETA_SALBODE" UpdateMethod="ActualizarCCF_DETA_SALBODE"
    TypeName="SISPACAL.BL.cCCF_DETA_SALBODE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSALBODE_DETA" runat="server" 
    SelectMethod="ObtenerListaPorSALBODE_DETA" InsertMethod="AgregarCCF_DETA_SALBODE" DeleteMethod="EliminarCCF_DETA_SALBODE" UpdateMethod="ActualizarCCF_DETA_SALBODE"
    TypeName="SISPACAL.BL.cCCF_DETA_SALBODE">
    <SelectParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarCCF_DETA_SALBODE" DeleteMethod="EliminarCCF_DETA_SALBODE" UpdateMethod="ActualizarCCF_DETA_SALBODE"
    TypeName="SISPACAL.BL.cCCF_DETA_SALBODE">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarCCF_DETA_SALBODE" DeleteMethod="EliminarCCF_DETA_SALBODE" UpdateMethod="ActualizarCCF_DETA_SALBODE"
    TypeName="SISPACAL.BL.cCCF_DETA_SALBODE">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD_CCF" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO_CCF" Type="Decimal" />
        <asp:Parameter Name="TOTAL_CCF" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_DETA_SAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
