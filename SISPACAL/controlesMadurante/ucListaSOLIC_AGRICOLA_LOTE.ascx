<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_AGRICOLA_LOTE.ascx.vb" Inherits="controles_ucListaSOLIC_AGRICOLA_LOTE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<script type="text/javascript">
    var currentColumnName;

    function OnGridSelectionChanged(s, e) {
        cpVistaDetalleSOLIC_AGRICOLA.PerformCallback('TotalizarMZ');
    }
</script>
<dx:ASPxGridView ID="dxgvLista" runat="server" ClientInstanceName="grdSolicAgricolaLote" AutoGenerateColumns="False" KeyFieldName="ID_SOLIC_AGRI_LOTE" Font-Size="X-Small" Width="100%">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents SelectionChanged="OnGridSelectionChanged" EndCallback="OnGridSelectionChanged"  RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Caption=" " ButtonType="Image" Width="30px" Visible="False">
            <NewButton Visible="False" Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
            </NewButton>      
                        <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
            <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
                        </EditButton>            
                        <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
            <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
                        </UpdateButton>                     
                        <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
            <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>                
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>        
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_AGRI_LOTE" ReadOnly="True" VisibleIndex="2" Caption="Id solic agri lote" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" ReadOnly="True" VisibleIndex="3" Caption="Id solicitud" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" ReadOnly="True" VisibleIndex="4" Caption="Id zafra" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" ReadOnly="True" VisibleIndex="5" Caption="Acceslote" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="CONTRATO" UnboundType="String" VisibleIndex="5" Caption="Contrato" SortOrder="Ascending" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCONTRATO" Font-Size="X-Small" runat="server" Text='<%# Eval("CONTRATO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SOCIO" UnboundType="Integer"  VisibleIndex="5" Caption="Socio" SortOrder="Ascending" Width="70px"  >
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODILOTE" UnboundType="String" VisibleIndex="6" Caption="Codigo" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCODILOTE" Font-Size="X-Small" runat="server" Text='<%# Eval("CODILOTE") %>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="7" UnboundType="String" Caption="Nombre Lote" >          
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBLOTE" Font-Size="X-Small" runat="server" Text='<%# Eval("NOMBLOTE") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="MZ" VisibleIndex="8" Caption="Area ha" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesSpinEdit MinValue="0" MaxValue="9999" Style-HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" DisplayFormatString="#,##0.00"></PropertiesSpinEdit>  
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_ESTI" EditFormSettings-Visible="False" VisibleIndex="9" Caption="(t)Ton.Metricas Estim." >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTONEL_ESTI" Font-Size="X-Small" runat="server" Text='<%# Eval("TONEL_ESTI") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataComboBoxColumn FieldName="CODIVARIEDA" VisibleIndex="10" Caption="Variedad" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsVariedad" ValueField="CODIVARIEDA" TextField="NOM_VARIEDAD" ValueType="System.String" TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains" >
            <Columns>
                <dx:ListBoxColumn Caption="Codigo" FieldName="CODIVARIEDA" Width="80px" />
                <dx:ListBoxColumn Caption="Descripcion" FieldName="NOM_VARIEDAD" Width="180px" />
            </Columns>
            </PropertiesComboBox> 
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="UBICACION" UnboundType="String" VisibleIndex="11" Caption="Ubicación" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblUBICACION" Font-Size="X-Small" runat="server" Text='<%# Eval("UBICACION") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataCheckColumn FieldName="RIEGO_APLICADO" ReadOnly="True" VisibleIndex="12" Caption="Riego aplicado" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="13" Caption="Usuario crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="14" Caption="Fecha crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="15" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="16" Caption="Fecha act" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ZONA" UnboundType="String" VisibleIndex="16" Caption="Zona">
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblZONA" Font-Size="X-Small" runat="server" Text='<%# Eval("ZONA") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ZAFRA" ReadOnly="True" VisibleIndex="17" Caption="Zafra"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="REFERENCIA" VisibleIndex="18" Caption="Referencia" Visible="false"/>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Name="Eliminar" VisibleIndex="19">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsSolicLotesCache" runat="server" TypeName="cSOLIC_AGRICOLA_LOTEcache" SelectMethod="ObtenerLista" UpdateMethod="Actualizar">       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <UpdateParameters>    
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />       
        <asp:Parameter Name="CODIVARIEDA" Type="String" />       
        <asp:Parameter Name="REFERENCIA" Type="String" />        
    </UpdateParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO" runat="server" TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_LOTE" SelectMethod="ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO" >       
     <SelectParameters>       
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIAGRON" Type="String" />
     </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_AGRICOLA_LOTE" DeleteMethod="EliminarSOLIC_AGRICOLA_LOTE" UpdateMethod="ActualizarSOLIC_AGRICOLA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_LOTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarSOLIC_AGRICOLA_LOTE" DeleteMethod="EliminarSOLIC_AGRICOLA_LOTE" UpdateMethod="ActualizarSOLIC_AGRICOLA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_AGRICOLA_LOTE" DeleteMethod="EliminarSOLIC_AGRICOLA_LOTE" UpdateMethod="ActualizarSOLIC_AGRICOLA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarSOLIC_AGRICOLA_LOTE" DeleteMethod="EliminarSOLIC_AGRICOLA_LOTE" UpdateMethod="ActualizarSOLIC_AGRICOLA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="RIEGO_APLICADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsVariedad" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cVARIEDAD">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIVARIEDA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
