 <%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCONTRATO_LG.ascx.vb" Inherits="controles_ucVistaDetalleCONTRATO_LG" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>




<%@ Register tagprefix="uc1" tagname="ucListaLOTES_LG" Src="~/controlesContrato/ucListaLOTES_LG.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaMAESTRO_LOTES" Src="~/controlesContrato/ucListaMAESTRO_LOTES.ascx" %>

<script type="text/javascript">
    function Validacion_NIT(s, e) {
        var nit = e.value;
        if (nit == null) 
            e.isValid = false;            
        else if (nit.length > 0 && nit.length < 14)
            e.isValid = false;
    }
    function Validacion_TELEFONO(s, e) {
        var telef = e.value;
        if (telef == null)
            e.isValid = true;
        else if (telef.length > 0 && telef.length < 8)
            e.isValid = false;
    }

    function Validacion_DUI(s, e) {
        var dui = e.value;        
        if (dui == null)
            e.isValid = true;
        else if (dui.length > 0 && dui.length < 9)
            e.isValid = false;
    }

    function CalcularEdad() {       
        var fechaNac = dteFechaNac.GetValue()
        var fechaActual = dteFECHA_CONTRATO.GetValue()
        var edad = 0

        if (fechaNac == null || fechaActual==null) {
            return "";
        }      
        var anioActual = fechaActual.getFullYear();
        var mesActual = fechaActual.getMonth() + 1;
        var diaActual = fechaActual.getDate();

        var anioNac = fechaNac.getFullYear();
        var mesNac = fechaNac.getMonth() + 1;
        var diaNac = fechaNac.getDate();

        if (anioActual <= anioNac) {
            return edad;
        }
        edad = anioActual - anioNac;
        if (mesActual < mesNac) {
            edad -= 1;
        }
        else if (mesActual == mesNac) {
            if (diaActual < diaNac) {
                edad -= 1;
            }
        }
        return edad;
    }

    function SelecTipoContrato(s, e) {
        var tipoContrato = -1;
        if (cbxTIPO_CONTRATO.GetValue() != null)
            tipoContrato = cbxTIPO_CONTRATO.GetValue();
        if (tipoContrato == 1 || tipoContrato == 2) {
            txtNOMBRE_REPRESENTANTE.SetEnabled(true);
            txtDUI_REPRESENTANTE.SetEnabled(true);
            txtNIT_REPRESENTANTE.SetEnabled(true);
        }
        else {
            txtNOMBRE_REPRESENTANTE.SetValue('');
            txtDUI_REPRESENTANTE.SetValue('');
            txtNIT_REPRESENTANTE.SetValue('');
            txtNOMBRE_REPRESENTANTE.SetEnabled(false);
            txtDUI_REPRESENTANTE.SetEnabled(false);
            txtNIT_REPRESENTANTE.SetEnabled(false);
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
    }
    function SynchronizeListBoxValues(dropDown, args) {
        checkListBox.UnselectAll();
        var texts = dropDown.GetText().split(textSeparator);
        var values = GetValuesByTexts(texts);
        checkListBox.SelectValues(values);
        //UpdateSelectAllItemState();
        UpdateText(); // for remove non-existing texts
    }
    function GetSelectedItemsText(items) {
        var texts = [];
        for (var i = 0; i < items.length; i++)            
                texts.push(items[i].text);
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
</script>

<dx:ASPxFormLayout ID="ucVistaDetalleCONTRATOLayout" ClientInstanceName="ucVistaDetalleCONTRATOLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="5" Caption="Contrato"  
            Name="lgVistaDetalleCONTRATO" GroupBoxDecoration="None">
            <Items>
                <dx:LayoutItem Caption="Nombre completo:" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR" Width="100%" BackColor="WhiteSmoke">    
                               <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                              
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Fecha contrato:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                            <dx:ASPxDateEdit ID="dteFECHA_CONTRATO" ClientInstanceName="dteFECHA_CONTRATO" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100px">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Fecha del contrato obligatoria" IsRequired="True" />
                                </ValidationSettings>
                                <ClientSideEvents DateChanged="function(s,e){                                                        
                                    txtEDAD.SetText(CalcularEdad());
                                }"  />
                            </dx:ASPxDateEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Tipo contrato:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                            <dx:ASPxComboBox ID="cbxTIPO_CONTRATO" ClientInstanceName="cbxTIPO_CONTRATO" AutoPostBack="true" runat="server" ValueType="System.Int32" Width="144px">                           
                                <Items>
                                    <dx:ListEditItem Text="PERSONA NATURAL" Value="1" />
                                    <dx:ListEditItem Text="PERSONA JURÍDICA" Value="2" />
                                    <dx:ListEditItem Text="COOPERATIVA" Value="3" />
                                </Items>
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Tipo de contrato obligatorio" IsRequired="True" />
                                </ValidationSettings>                               
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Represent. Legal:" FieldName="NombreRepresentanteLegal" ColSpan="5">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                                    <dx:ASPxTextBox ID="txtNOMBRE_REPRESENTANTE" ClientInstanceName="txtNOMBRE_REPRESENTANTE" runat="server" Width="100%" >
                                    </dx:ASPxTextBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>               
                 <dx:LayoutItem Caption="Cod. Proveedor:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                            <dx:ASPxSpinEdit ID="txtCODIPROVEE_V" runat="server" ClientInstanceName="txtCODIPROVEE_V" AutoPostBack="true" Width="100%"  >
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Zafra:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                           <dx:ASPxDropDownEdit ClientInstanceName="checkComboBox" ID="cbxZAFRA" Width="230px" runat="server" AnimationType="None">
                                <DropDownWindowStyle BackColor="#EDEDED" />
                                <DropDownWindowTemplate>
                                    <dx:ASPxListBox AutoPostBack="true" Width="100%" ID="listBox" ClientInstanceName="checkListBox" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" SelectionMode="CheckColumn"
                                        runat="server">
                                        <Border BorderStyle="None" />
                                        <BorderBottom BorderStyle="Solid" BorderWidth="1px" BorderColor="#DCDCDC" />                                        
                                        <ClientSideEvents SelectedIndexChanged="OnListBoxSelectionChanged" />                                        
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
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>   
                 <dx:LayoutItem Caption="N° Contrato:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                            <dx:ASPxSpinEdit ID="txtNO_CONTRATO" runat="server" 
                                AllowNull="true" AllowUserInput="true" Width="80px" >
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="N° contrato obligatorio" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>                             
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>                     
                <dx:LayoutItem Caption="Activo:" ColSpan="2" FieldName="ContratoActivo" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxCheckBox ID="chkACTIVO" runat="server" 
                                CheckState="Unchecked">
                            </dx:ASPxCheckBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem> 
                <dx:LayoutItem FieldName="afterContratoActivo1" ShowCaption="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">                            
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem FieldName="afterContratoActivo2" ShowCaption="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">                            
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="N° Registro Fiscal:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                            <dx:ASPxTextBox ID="txtNRC_V" runat="server" ClientInstanceName="txtNRC_V" Width="140px" >                                                               
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>   
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                  
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                  
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                  
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>     
                <dx:LayoutItem Caption="Dirección:" ColSpan="5" FieldName="Direccion">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                            <dx:ASPxTextBox ID="txtDIRECCION_V" runat="server" 
                                Width="100%" ClientInstanceName="txtDIRECCION_V">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>             

                <dx:LayoutItem Caption="Años de edad:" FieldName="Edad">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer22" runat="server">
                            <dx:ASPxTextBox ID="txtEDAD" runat="server" ClientInstanceName="txtEDAD" Width="100%" BackColor="WhiteSmoke">                               
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Profesión:" ColSpan="2" FieldName="Profesion" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer21" runat="server">
                            <dx:ASPxTextBox ID="txtPROFESION" runat="server" 
                                Width="100%" ClientInstanceName="txtPROFESION_V">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem> 
                <dx:LayoutItem FieldName="afterProfesion1" ShowCaption="False"></dx:LayoutItem>
                <dx:LayoutItem FieldName="afterProfesion2" ShowCaption="False"></dx:LayoutItem>
                 <dx:LayoutItem Caption="DUI:" FieldName="Dui">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                            <dx:ASPxTextBox ID="txtDUI_V" ClientInstanceName="txtDUI_V" 
                                runat="server" Width="100%" >
                                <ClientSideEvents Validation="Validacion_DUI" />
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                    Mask="99999999-9" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                    ErrorText="DUI no valido" SetFocusOnError="True">                                    
                                </ValidationSettings>
                            </dx:ASPxTextBox>                            
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="NIT:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                            <dx:ASPxTextBox ID="txtNIT_V" runat="server" ClientInstanceName="txtNIT_V" Width="100%">
                                <%--<ClientSideEvents Validation="Validacion_NIT" />--%>
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="9999-999999-999-9" />
                                <%--<ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" ErrorText="NIT no valido" SetFocusOnError="True">
                                     <RequiredField ErrorText="NIT es obligatorio" IsRequired="True" />
                                </ValidationSettings>--%>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem> 
                <dx:LayoutItem Caption="NIT (Repres. Legal):" FieldName="NitRepresentanteLegal" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer19" runat="server">
                            <dx:ASPxTextBox ID="txtNIT_REPRESENTANTE" runat="server" 
                                ClientInstanceName="txtNIT_REPRESENTANTE" Width="100%">
                                <%--<ClientSideEvents Validation="Validacion_NIT" />--%>
                                <MaskSettings AllowMouseWheel="False" ErrorText="NIT no valido" 
                                    IncludeLiterals="None" Mask="9999-999999-999-9" />
                                <%--<ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                    ErrorText="NIT no valido" SetFocusOnError="True">
                                    <RequiredField ErrorText="NIT obligatorio" IsRequired="True" />
                                </ValidationSettings>--%>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>               
                <dx:LayoutItem Caption="DUI (Repres. Legal):" FieldName="DuiRepresentanteLegal" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer18" runat="server">
                            <dx:ASPxTextBox ID="txtDUI_REPRESENTANTE" runat="server" 
                                ClientInstanceName="txtDUI_REPRESENTANTE" Width="80px">
                                <ClientSideEvents Validation="Validacion_DUI" />
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                    Mask="99999999-9" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                    ErrorText="DUI no valido" SetFocusOnError="True">
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>               
                <dx:LayoutItem Caption="Telefono:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                            <dx:ASPxTextBox ID="txtTELEFONO_V" runat="server" Width="80px">
                            <ClientSideEvents Validation="Validacion_TELEFONO" />
                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                    Mask="9999-9999" />
                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                    ErrorText="Telefono no valido" SetFocusOnError="True" >
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                 <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                
                <dx:LayoutItem Caption="Financiado por:" ColSpan="2" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">                           
                             <dx:ASPxComboBox ID="cbxFINANCIAMIENTO" DropDownStyle="DropDown" runat="server" DataSourceID="odsFinanciamiento" ValueField="CODIBANCO" TextField="NOMBRE_BANCO" ValueType="System.Int32" Width="100%" >
                             </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="N°:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                            <dx:ASPxTextBox ID="txtNO_FINANCIAMIENTO" runat="server" 
                                Width="80px">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>                     
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                <dx:LayoutItem Caption="Area cultivada:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtAREA_CULTIVADA" Font-Bold="true" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Ton x Area:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtTON_AREA" Font-Bold="true" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem> 
                <dx:LayoutItem Caption="Observaciones:" ColSpan="5">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtOBSERVACIONES" runat="server" 
                                Width="100%">
                            </dx:ASPxTextBox>   
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Fec. contrato Legal:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer20" runat="server">
                            <dx:ASPxDateEdit ID="dteFECHA_CONTRA_LEGAL" runat="server" 
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" 
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" Width="100%" >
                            </dx:ASPxDateEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Fecha Reg. CONSAA:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxDateEdit ID="dteFECHA_REGISTRO" runat="server" 
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" 
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" Width="130px" >
                            </dx:ASPxDateEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="N° Reg. CONSAA:" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtNUM_REGISTRO" runat="server" Width="80px">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>                
                <dx:LayoutItem Caption="Codiproveedor" ClientVisible="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtCODIPROVEEDOR_V" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Codicontrato" ClientVisible="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                            <dx:ASPxTextBox ID="txtCODICONTRATO" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>
<dx:ASPxLabel ID="lblDetalle" runat="server" Text="Lotes del Contrato" 
    ForeColor="#4881A2" Font-Bold="True" Font-Names="Arial" 
    Font-Size="Small" />
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<uc1:ucListaLOTES_LG id="ucListaLOTES_LG1" NombreGridCliente="ucListaLOTES_LG1" PermitirEditarInline="true" TipoEdicion="0" TamanoPagina="7" PermitirEliminar="false" runat="server" 
        VerCUI="false" VerCODISOCIO="false" VerTIPO_CANA="true" VerTIPO_ROZA="true" VerTIPO_ALZA="true" VerTIPO_TRANS="true" VerEDITAR_LOTE_MAESTRO="true" VerANIOZAFRA="false" PermitirEditar="false"></uc1:ucListaLOTES_LG>
<dx:ASPxHiddenField ID="hfucVistaDetalleCONTRATO" ClientInstanceName="hfucVistaDetalleCONTRATO" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<dx:ASPxDateEdit ID="dteFechaNac" ClientInstanceName="dteFechaNac" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100px" ClientVisible="false" >                                                                
</dx:ASPxDateEdit>
<dx:ASPxPopupControl ID="pcLotesContratados" runat="server" CloseAction="CloseButton" Modal="True" Width="1000px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="TopSides" ClientInstanceName="pcLotesContratados"
        HeaderText="Lotes Contratados" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">
                        <dx:ASPxLabel ID="lblpcError" runat="server" Font-Bold="true" ForeColor="Red" /><br />                        
                        <table>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zafra:"  /></td>
                                <td style="padding-left:5px; padding-right:10px">
                                    <dx:ASPxComboBox ID="cbxZafraTraspaso" runat="server" Width="130px" DataSourceID="odsZafraTraspaso" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32">
                                    </dx:ASPxComboBox>
                                </td>
                                <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Contrato:"  /></td>
                                <td style="padding-left:5px; padding-right:10px">
                                    <dx:ASPxSpinEdit ID="txtNoContratoTraspaso" runat="server" AllowNull="true" Width="100px"  
                                        AllowUserInput="true" ClientInstanceName="txtNO_CONTRATO" HorizontalAlign="Right">
                                        <SpinButtons ShowIncrementButtons="false"></SpinButtons>                                         
                                    </dx:ASPxSpinEdit> 
                                </td>                                
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Derecho sobre Lote:"  />
                                </td>
                                <td style="padding-left:5px; padding-right:10px">
                                    <dx:ASPxComboBox ID="cbxTIPO_DERECHO" ClientInstanceName="cbxTIPO_DERECHO" runat="server" ValueType="System.Int32" Width="170px">                           
                                        <Items>
                                            <dx:ListEditItem Text="PROPIETARIO" Value="1" />
                                            <dx:ListEditItem Text="ARRENDATARIO" Value="2" />
                                            <dx:ListEditItem Text="ASIGNATARIO" Value="3" />
                                        </Items>
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Derecho sobre lote obligatorio" IsRequired="True" />
                                        </ValidationSettings>                               
                                    </dx:ASPxComboBox>
                                </td>
                                <td>
                                    <dx:ASPxButton runat="server" ID="btnBuscar" ToolTip="Buscar lotes" CausesValidation="false" AutoPostBack="true" Text="Buscar lotes">                                                             
                                        <Image IconID="find_find_16x16"></Image>
                                    </dx:ASPxButton>        
                                </td>
                            </tr>                                             
                        </table>
                        <hr />
                        <uc1:ucListaLOTES_LG id="ucListaLOTES_LG2" MostrarCheckUnaSeleccion="true" NombreGridCliente="ucListaLOTES_LG2" 
                        PermitirEditarInline="false" TipoEdicion="0" TamanoPagina="8" PermitirEliminar="false" 
                        VerAREA="false" VerTONELADAS="false" VerTONEL_TC="false" VerCANTON="false"
                        runat="server" VerNO_CONTRATO="true" VerCUI="false" VerCODISOCIO="false" VerANIOZAFRA="false"                     
                        PermitirEditar="false"></uc1:ucListaLOTES_LG>
                        <table>
                            <tr>
                                <td style="padding-left:15px">
                                    <dx:ASPxButton ID="btnSeleccionar" CausesValidation="false" runat="server" AutoPostBack="true" Text="Aceptar">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td style="padding-left:15px">  
                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcLotesContratados.Hide()}" /> 
                                    </dx:ASPxButton> 
                                </td>
                            </tr>                            
                        </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>

<asp:ObjectDataSource ID="odsZafraTraspaso" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsFinanciamiento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cBANCOS">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_BANCO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>



    
