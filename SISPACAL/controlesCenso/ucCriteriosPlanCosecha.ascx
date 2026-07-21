<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosPlanCosecha.ascx.vb" Inherits="controlesCenso_ucCriteriosPlanCosecha" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<style type="text/css">
    .style1 {
        height: 20px;
    }
</style>

<script type="text/javascript">
    var postponedCallbackRequired = false;
    var ultCenso = null;

    function CambiandoZafra() {
        if (cbxCENSO.InCallback())
            ultCenso = cbxZAFRA.GetValue().toString();
        else
            cbxCENSO.PerformCallback(cbxZAFRA.GetValue().toString());
    }
    function OnEndCallbackZafra(s, e) {
        if (ultCenso) {
            cbxCENSO.PerformCallback(ultCenso);
            ultCenso = null;
        }
    }

    var textSeparator = ",";
    function OnListBoxSelectionChanged(listBox, args) {
        UpdateText();
    }
    function UpdateSelectAllItemState() {
        IsAllSelected() ? checkListBox.SelectIndices([0]) : checkListBox.UnselectIndices([0]);
    }
    function IsAllSelected() {
        var selectedDataItemCount = checkListBox.GetItemCount() - (checkListBox.GetItem(0).selected ? 0 : 1);
        return checkListBox.GetSelectedItems().length == selectedDataItemCount;
    }
    function UpdateText() {
        var selectedItems = checkListBox.GetSelectedItems();
        checkComboBox.SetText(GetSelectedItemsText(selectedItems));
        hfCantones.Set('Cantones', GetSelectedItemsValue(selectedItems));
    }
    function SynchronizeListBoxValues(dropDown, args) {
        checkListBox.UnselectAll();
        if (hfCantones.Get('Cantones') == undefined)
            return true;
        //var texts = dropDown.GetText().split(textSeparator);
        var values = GetValuesByValues(hfCantones.Get('Cantones').split(textSeparator));
        //var values = GetValuesByTexts(texts);
        checkListBox.SelectValues(values);        
        UpdateText(); 
    }
    function GetSelectedItemsText(items) {
        var texts = [];
        var nombre = [];
        for (var i = 0; i < items.length; i++) {
            nombre = items[i].text.split(';');
            texts.push(nombre[2]);
            //texts.push(items[i].text);
        }
        return texts.join(textSeparator);
    }
    function GetSelectedItemsValue(items) {
        var texts = [];        
        for (var i = 0; i < items.length; i++) {            
            texts.push(items[i].value);
        }
        return texts.join(textSeparator);
    }    
    function GetValuesByTexts(texts) {
        var actualValues = [];
        var item;
        for (var i = 0; i < texts.length; i++) {
            item = checkListBox.FindItemByText(texts[i]);
            if (item != null)
                actualValues.push(item.value);
        }
        return actualValues;
    }
    function GetValuesByValues(values) {
        var actualValues = [];
        var item;
        for (var i = 0; i < values.length; i++) {
            item = checkListBox.FindItemByValue(values[i]);
            if (item != null)
                actualValues.push(item.value);
        }
        return actualValues;
    }
</script>
<table>
    <tr id="trID_ZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ZAFRA">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA"  Width="118px" >               
            </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="lblCENSO" runat="server" Text="PLAN DE COSECHA">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxCENSO" ClientInstanceName="cbxCENSO" runat="server" ValueType="System.Int32" DataSourceID="odsCenso"
                             ValueField="ID_CENSO" TextFormatString="{0}" Theme="Office2010Blue" Width="200px" ShowLoadingPanel="true"  LoadingPanelText="Cargando..."  >                                                                    
                <Columns>
                <dx:ListBoxColumn Caption="Fecha" FieldName="FECHA_CENSO" Width="65px" />
                <dx:ListBoxColumn Caption="Censo" FieldName="NOMBRE_CENSO" Width="400px" />                
                </Columns>
            </dx:ASPxComboBox>            
        </td>
    </tr>    
    <tr id="trZONA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="ZONA">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsZonas"
                ValueField="ZONA" TextField="DESCRIP_ZONA"  Width="118px" >
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="SUB ZONA">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxSUB_ZONA" ClientInstanceName="cbxSUB_ZONA"  runat="server" ValueType="System.String" DataSourceID="odsSubZonas"
                ValueField="SUB_ZONA" TextField="SUB_ZONA"  Width="200px" >
             </dx:ASPxComboBox>
        </td>
    </tr>    
    <tr id="trMULTICANTON1" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="DEPARTAMENTO">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxDEPARTAMENTO" ClientInstanceName="cbxDEPARTAMENTO" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsDepartamento"
                ValueField="CODI_DEPTO" TextField="NOMBRE_DEPTO"  Width="118px" >
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="MUNICIPIO">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxMUNICIPIO" ClientInstanceName="cbxMUNICIPIO" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsMunicipio"
                ValueField="CODI_MUNI" TextField="NOMBRE_MUNI"  Width="200px" >
             </dx:ASPxComboBox>
        </td>           
    </tr>
    <tr id="trMULTICANTON2" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel23" runat="server" Text="CANTON(ES)" /></td>
        <th colspan="6">
            <dx:ASPxDropDownEdit ClientInstanceName="checkComboBox" ID="cbxCANTONES" Width="100%" runat="server" AnimationType="None" Height="16px">
                <DropDownWindowStyle BackColor="#EDEDED" />
                <DropDownWindowTemplate>
                    <dx:ASPxListBox Width="100%" Height="200px" ID="listBox" EnableViewState="true" ClientInstanceName="checkListBox" ValueField="CODIUNICO" TextField="NOMBRE_CANTON" ValueType="System.String" SelectionMode="CheckColumn" runat="server">
                        <Border BorderStyle="None" />
                        <BorderBottom BorderStyle="Solid" BorderWidth="1px" BorderColor="#DCDCDC" />                                                                
                        <ClientSideEvents SelectedIndexChanged="OnListBoxSelectionChanged" />          
                        <Columns>                                                                        
                        <dx:ListBoxColumn Caption="Departamento" FieldName="NOMBRE_DEPTO" Width="100px" />
                        <dx:ListBoxColumn Caption="Municipio" FieldName="NOMBRE_MUNI" Width="100px" />
                        <dx:ListBoxColumn Caption="Cantón" FieldName="NOMBRE_CANTON" Width="200px" />
                        </Columns>                              
                    </dx:ASPxListBox>
                    <table style="width: 100%">
                        <tr>
                            <td style="padding: 4px">
                                <dx:ASPxButton ID="ASPxButton1" AutoPostBack="False" runat="server" Text="Cerrar" style="float: right">
                                    <ClientSideEvents Click="function(s, e){ checkComboBox.HideDropDown(); }" />
                                </dx:ASPxButton>
                            </td>
                        </tr>
                    </table>
                </DropDownWindowTemplate>
                <ClientSideEvents TextChanged="SynchronizeListBoxValues" DropDown="SynchronizeListBoxValues" />
            </dx:ASPxDropDownEdit>
            <dx:ASPxHiddenField runat="server" ClientInstanceName="hfCantones" ID="hfCantones" />
        </th> 
    </tr>    
    <tr id="trCODIPROVEEDOR" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="CODI. PROVEEDOR">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCODIPROVEE" runat="server" Width="100px" 
                >
            </dx:ASPxTextBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="SOCIO">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCODISOCIO" runat="server" Width="50px">
            </dx:ASPxTextBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="NOMBRE">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="200px">
            </dx:ASPxTextBox>
        </td>
    </tr>
     <tr id="trCODIGOS_RELACIONADOS" runat="server" visible="false">       
        <th colspan="3">
            <dx:ASPxCheckBox ID="chkCodigosRelacionados" TextAlign="Left" Text="VER CODIGOS RELACIONADOS"  runat="server">
            </dx:ASPxCheckBox> 
        </th>       
    </tr>

    <tr id="trVARIEDAD" runat="server" visible="false">
        <td><dx:ASPxLabel ID="lblCICLO" runat="server" Text="CICLO" /></td>
        <td><dx:ASPxComboBox ID="cbxCICLO" runat="server" ValueField="ID_CICLO" TextField="NOM_CICLO" ValueType="System.Int32" Width="320px" /></td>
        <td><dx:ASPxLabel ID="lblVARIEDAD" runat="server" Text="VARIEDAD" /></td>
        <td><dx:ASPxComboBox ID="cbxVARIEDAD" AutoPostBack="true" runat="server" DropDownStyle="DropDown" ValueField="CODIVARIEDA" TextField="NOM_VARIEDAD" ValueType="System.String" TextFormatString="{0} {1}" IncrementalFilteringMode="Contains" 
                Width="220px" >
               <Columns>
                <dx:ListBoxColumn Caption="Codigo" FieldName="CODIVARIEDA" Width="80px" />
                <dx:ListBoxColumn Caption="Descripcion" FieldName="NOM_VARIEDAD" Width="180px" />
                </Columns>
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="lblTIPO" runat="server" Text="TIPO">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox runat="server" ID="cbxTIPO" DataSourceID="odsTiposCana" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" AutoPostBack="true" Width="200px" >           
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="lblSUB_TIPO" runat="server" Text="SUB TIPO">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox runat="server" ID="cbxSUB_TIPO" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="200px" >           
             </dx:ASPxComboBox>
        </td>
    </tr> 
    <tr id="trFORMA_COSECHA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="FORMA DE COSECHA:" /></td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxFORMA_COSECHA" DataSourceID="odsFormaCosecha" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="320px" >           
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="ESTADO DE LOTE:" /></td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxESTADO_LOTE" ValueType="System.Int32" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="[Todos]" Value="-1" Selected="true"/>
                    <dx:ListEditItem Text="CERRADO" Value="1" />
                    <dx:ListEditItem Text="ABIERTO" Value="0" />                    
                </Items>
            </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="lblEDAD_LOTE" runat="server" Text="EDAD LOTE:" Visible="true" /></td>
        <td><dx:ASPxSpinEdit ID="speEDAD_LOTE" runat="server" Width="40px" SpinButtons-ShowIncrementButtons="false" AllowNull="true" AllowUserInput="true" Visible="true" /></td>
    </tr>
    <tr id="trTERCIO" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="PERIODO ROZA DEL:">
            </dx:ASPxLabel></td>
        <td>    
            <table>
                <tr>
                    <td>
                        <dx:ASPxDateEdit ID="dteFecha1" DisplayFormatString="dd/MM/yyyy" UseMaskBehavior="true"  NullText="  /  /    " runat="server" Width="100px">
                        </dx:ASPxDateEdit>
                    </td>
                    <td>
                       <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="AL:" /> 
                    </td>
                    <td>
                       <table>
                        <tr>
                        <td><dx:ASPxDateEdit ID="dteFecha2" DisplayFormatString="dd/MM/yyyy" UseMaskBehavior="true" NullText="  /  /    " runat="server" Width="90px" /></td>
                        <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Hrs. Ajuste" /></td> 
                        <td><dx:ASPxSpinEdit ID="txtHORAS_AJUSTE" runat="server" Width="50px" AllowNull="true" Increment="1" AllowUserInput="true" /></td> 
                        </tr>
                       </table>
                    </td>
                </tr>
            </table>   
        </td>     
        <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="SEMANA" /></td>     
        <th colspan="4">
            <table>
                <tr>                    
                    <td><dx:ASPxSpinEdit ID="txtSEMANA" runat="server" Width="50px" AllowNull="true" AllowUserInput="true" /></td>
                    <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="CORTE" /></td>
                    <td><dx:ASPxSpinEdit ID="txtCATORCENA" runat="server" Width="40px" AllowNull="true" AllowUserInput="true" /></td>                    
                    <td><dx:ASPxLabel ID="lblTERCIO" runat="server" Text="TERCIO" /></td>
                    <td>
                        <dx:ASPxComboBox runat="server" ID="cbxTERCIO" ValueType="System.Int32" Width="100px" >
                            <Items>
                                <dx:ListEditItem Text="[Todos]" Value="-1" Selected="true"/>
                                <dx:ListEditItem Text="1" Value="1" />
                                <dx:ListEditItem Text="2" Value="2" />
                                <dx:ListEditItem Text="3" Value="3" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>  
                    <td><dx:ASPxLabel ID="lblSUB_TERCIO" runat="server" Text="SUB TERCIO" /></td>                  
                    <td><dx:ASPxComboBox runat="server" ID="cbxSUB_TERCIO" Width="130px" /></td>                   
                </tr>
            </table>
        </th>       
    </tr>    
    <tr id="trTIPO_DETALLE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="MOSTRAR POR:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxTipoDetalle" ClientInstanceName="cbxTipoDetalle" ValueType="System.Int32" runat="server" Width="175px" >
                <Items>
                    <dx:ListEditItem Text="Ninguno" Value="0" Selected="true" />  
                    <dx:ListEditItem Text="Lote por Canton" Value="1" />                                        
                    <dx:ListEditItem Text="Zona" Value="2" />
                    <dx:ListEditItem Text="Zona y SubZona" Value="3" />
                    <dx:ListEditItem Text="Zona, SubZona y Canton" Value="4" />
                </Items>
            </dx:ASPxComboBox>                       
        </th>    
        <td>
            <dx:ASPxLabel ID="lblMoliendaDiaria" runat="server" 
                Text="MOLIENDA DIARIA AJUSTADA:">
            </dx:ASPxLabel>
        </td> 
        <th colspan="2">
            <dx:ASPxSpinEdit ID="txtMOLIENDA_DIARIA_AJUSTADA" runat="server" Width="150px" AllowNull="true" DecimalPlaces="2" DisplayFormatString="#0.00"  Increment="1" AllowUserInput="true" />
        </th> 
    </tr>
    <tr id="trTIPO_DETALLE2" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="MOSTRAR POR:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxTipoDetalle2" ClientInstanceName="cbxTipoDetalle2" ValueType="System.Int32" runat="server" Width="175px" >
                <Items>
                    <dx:ListEditItem Text="Ninguno" Value="0" Selected="true" />  
                    <dx:ListEditItem Text="Lote" Value="1" /> 
                    <dx:ListEditItem Text="Lote por Canton" Value="2" />                                        
                    <dx:ListEditItem Text="Zona" Value="3" />
                    <dx:ListEditItem Text="Zona y SubZona" Value="4" />
                    <dx:ListEditItem Text="Zona, SubZona y Canton" Value="5" />
                    <dx:ListEditItem Text="Zafra" Value="6" />  
                </Items>
            </dx:ASPxComboBox>           
        </th>       
    </tr>
</table>
 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>
 <asp:ObjectDataSource ID="odsZonas" runat="server" TypeName="SISPACAL.BL.cZONAS" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="DESCRIP_ZONA" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>
  <asp:ObjectDataSource ID="odsSubZonas" runat="server" TypeName="SISPACAL.BL.cSUB_ZONAS" SelectMethod="Recuperar" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
      <asp:ControlParameter ControlID="cbxZONA" Name="ZONA" PropertyName="Value" Type="String" />
     <asp:Parameter Name="agregarVacio" DefaultValue="true" Type="Boolean" />
     <asp:Parameter Name="agregarTodos" DefaultValue="false" Type="Boolean" />
  </SelectParameters> 
  </asp:ObjectDataSource>
  <asp:ObjectDataSource ID="odsCenso" runat="server" 
    TypeName="SISPACAL.BL.cCENSO" SelectMethod="ObtenerListaPorZAFRA" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
      <asp:ControlParameter ControlID="cbxZAFRA" Name="ID_ZAFRA" PropertyName="Value" 
          Type="Int32" />
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="recuperarForaneas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="FECHA_CENSO" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="DESC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>

  <asp:ObjectDataSource ID="odsDepartamento" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cMUNICIPIO">
    <SelectParameters>      
        <asp:ControlParameter ControlID="cbxDEPARTAMENTO" Name="CODI_DEPTO" PropertyName="Value" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCanton" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cCANTON">
    <SelectParameters>   
        <asp:ControlParameter ControlID="cbxDEPARTAMENTO" Name="CODI_DEPTO" PropertyName="Value" Type="String" />
        <asp:ControlParameter ControlID="cbxMUNICIPIO" Name="CODI_MUNI" PropertyName="Value" Type="String" /> 
        <asp:Parameter Name="agregarVacio" Type="Boolean" DefaultValue="True" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTiposCana" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="True" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>


 <asp:ObjectDataSource ID="odsFormaCosecha" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="True" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="15" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>
