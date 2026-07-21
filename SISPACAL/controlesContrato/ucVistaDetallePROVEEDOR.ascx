<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePROVEEDOR.ascx.vb" Inherits="controles_ucVistaDetallePROVEEDOR" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<script type="text/javascript">
    function Validacion_NIT(s, e) {
        var nit = e.value;
        if (nit == null)
            e.isValid = true;
        else if (nit.length > 0 && nit.length < 14)
            e.isValid = false;
    }

    function Validacion_DUI(s, e) {
        var dui = e.value;
        if (dui == null)
            e.isValid = true;
        else if (dui.length > 0 && dui.length < 9)
            e.isValid = false;
    }

    function Validacion_NIT_REPRESENTANTE(s, e) {
        var nit = e.value;
        if (nit == null)
            e.isValid = true;
        else if (nit.length > 0 && nit.length < 14)
            e.isValid = false;
    }
    function Validacion_DUI_REPRESENTANTE(s, e) {
        var dui = e.value;
        if (dui == null)
            e.isValid = true;
        else if (dui.length > 0 && dui.length < 9)
            e.isValid = false;
    }

    function Validacion_NRC(s, e) {
        var nrc = '';
        var tipo = -1;
        if (e.value != null)
            nrc = e.value;
        if (rdbTIPO_CONTRIBUYENTE_V.GetValue() != null)
            tipo = rdbTIPO_CONTRIBUYENTE_V.GetValue();
        if ((tipo == 1 || tipo == 2) && (nrc.trim() == ''))
            e.isValid = false;
    }

    function CalcularEdad(fechaNac) {
        var fechaActual = new Date();
        var edad = 0

        if (fechaNac == null)
            return "";

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
</script>

<asp:ObjectDataSource ID="odsDepartamento" runat="server"
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar"
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMunicipio" runat="server"
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar"
    TypeName="SISPACAL.BL.cMUNICIPIO">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="CODI_DEPTO" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsTipoPersona" runat="server"
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista"
    TypeName="SISPACAL.BL.cTIPO_PERSONA">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsBancos" runat="server"
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista"
    TypeName="SISPACAL.BL.cBANCOS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_BANCO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxFormLayout ID="ucVistaDetallePROVEEDORLayout" ClientInstanceName="ucVistaDetallePROVEEDORLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="3" Caption="Creando/Editando Proveedor"
            Name="lgVistaDetallePROVEEDOR" GroupBoxDecoration="HeadingLine">
            <Items>

                <dx:LayoutItem Caption="Cod. Proveedor:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                            <dx:ASPxSpinEdit ID="txtCODIPROVEE_V" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_V" Width="100%">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption=""  CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption=""  CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Tipo persona:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                            <dx:ASPxComboBox ID="cbxTIPO_PERSONA_V" AutoPostBack="true" runat="server" Font-Bold="true" DataSourceID="odsTipoPersona" 
                                TextField="DESCRIPCION" ValueField="ID_TIPO_PERSONA" ValueType="System.Int32"  Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Dui:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                            <dx:ASPxTextBox ID="txtDUI_V" Font-Bold="true" runat="server"  Width="100%">
                                                 <MaskSettings AllowMouseWheel="False" IncludeLiterals="None"
                                    Mask="99999999-9" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="DUI no valido">
                                </ValidationSettings>
                                <DisabledStyle BackColor="WhiteSmoke" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="NIT:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                            <dx:ASPxTextBox ID="txtNIT_V" Font-Bold="true" runat="server" Width="100%">
       <MaskSettings AllowMouseWheel="False" IncludeLiterals="None"
                                    Mask="9999-999999-999-9" ErrorText="NIT no valido" />
 <%--                               <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">
                                </ValidationSettings>--%>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
<%--                <dx:LayoutItem Caption="">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>--%>

                <dx:LayoutItem Caption="Nombres:"  CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRES_V" Font-Bold="true" MaxLength="150" runat="server" Width="100%">
                                <DisabledStyle BackColor="WhiteSmoke" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Apellidos:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                            <dx:ASPxTextBox ID="txtAPELLIDOS_V" Font-Bold="true" MaxLength="150" runat="server"  Width="100%">
                                <DisabledStyle BackColor="WhiteSmoke" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Dirección:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                            <dx:ASPxTextBox ID="txtDIRECCION_V" MaxLength="150" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Departamento:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO_V" AutoPostBack="true" runat="server" DataSourceID="odsDepartamento" 
                                TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Municipio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                            <dx:ASPxComboBox ID="cbxMUNICIPIO_V" ShowLoadingPanel="true" LoadingPanelText="Cargando..." 
                                TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio" Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Teléfono:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                            <dx:ASPxTextBox ID="txtTELEFONO_V" MaxLength="100" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Celular:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtCELULAR_V" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Tipo:" CaptionSettings-HorizontalAlign="Left" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxRadioButtonList ID="rdbTIPO_CONTRIBUYENTE_V" AutoPostBack="true" ClientInstanceName="rdbTIPO_CONTRIBUYENTE_V" runat="server"
                                SelectedIndex="0" ValueType="System.Int32" RepeatDirection="Horizontal"  Width="100%">
                                <Items>
                                    <dx:ListEditItem Selected="True" Text="No contribuyente" Value="0" />
                                    <dx:ListEditItem Text="Contribuyente" Value="1" />
                                    <dx:ListEditItem Text="Gran contribuyente" Value="2" />
                                </Items>
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Seleccione el tipo de contribuyente" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxRadioButtonList>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Ncr:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                            <dx:ASPxTextBox ID="txtNRC_V" MaxLength="15" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Correo:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                            <dx:ASPxTextBox ID="txtCORREO_V" MaxLength="200" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Actividad primaria:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer25" runat="server">
                            <dx:ASPxTextBox ID="txtACTIVIDAD" MaxLength="1000" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer23" runat="server">
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>

                <dx:LayoutItem Caption="Nombre s/NIT:" CaptionSettings-HorizontalAlign="Left" ColSpan="3" ClientVisible="false">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRENIT_V" runat="server" MaxLength="200" Width="100%">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Profesión:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtPROFESION_V" runat="server" MaxLength="200" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Fecha Nacimiento:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer18" runat="server">
                            <dx:ASPxDateEdit ID="dteFECHA_NACIMIENTO_V"
                                ClientInstanceName="dteFECHA_NACIMIENTO_V" runat="server"
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom"
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" Width="100%">
                                <ClientSideEvents DateChanged="function(s,e){                                                        
                                    txtEDAD_V.SetText(CalcularEdad(s.GetValue()));
                                }" />
                            </dx:ASPxDateEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Edad:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer19" runat="server">
                            <dx:ASPxTextBox ID="txtEDAD_V" ClientInstanceName="txtEDAD_V" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Nombre Representante:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRE_REPRESENTANTE_V" runat="server" ClientInstanceName="txtNOMBRE_REPRESENTANTE_V" MaxLength="72" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="DUI Representante" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                            <dx:ASPxTextBox ID="txtDUI_REPRESENTANTE_V" ClientInstanceName="txtDUI_txtDUI_REPRESENTANTE_V" runat="server" Width="100%">
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None"
                                    Mask="99999999-9" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="DUI no valido">
                                </ValidationSettings>
                             <%--   <ClientSideEvents Validation="Validacion_DUI_REPRESENTANTE" />--%>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="NIT Representante:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">
                            <dx:ASPxTextBox ID="txtNIT_REPRESENTANTE_V" runat="server" ClientInstanceName="txtNIT_REPRESENTANTE_V" Width="100%">
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None"
                                    Mask="9999-999999-999-9" ErrorText="NIT no valido" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">
                                </ValidationSettings>
                          <%--      <ClientSideEvents Validation="Validacion_NIT_REPRESENTANTE" />--%>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer24" runat="server">

                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Banco pago a cuenta:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer20" runat="server">
                            <dx:ASPxComboBox ID="cbxBANCO_PAGO_CTA" runat="server" DataSourceID="odsBancos" 
                                TextField="NOMBRE_BANCO" ValueField="CODIBANCO" ValueType="System.Int32"  Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="N° de Cuenta bancaria:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer21" runat="server">
                            <dx:ASPxTextBox ID="txtNUM_CUENTA" runat="server" ClientInstanceName="txtNUM_CUENTA_v" MaxLength="30" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Es Cuenta Corriente:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer22" runat="server">
                            <dx:ASPxCheckBox ID="chkES_CTA_CORRIENTE" runat="server"  Width="100%" />
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
              
                <dx:LayoutItem Caption="Codiproveedor" ClientVisible="false" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtCODIPROVEEDOR_V" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>

<dx:ASPxHiddenField ID="hfucVistaDetallePROVEEDOR" ClientInstanceName="hfucVistaDetallePROVEEDOR" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>

<%--<dx:ASPxFormLayout ID="ucVistaDetallePROVEEDORLayout" ClientInstanceName="ucVistaDetallePROVEEDORLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="4" Caption="Creando/Editando Proveedor"
            Name="lgVistaDetallePROVEEDOR" GroupBoxDecoration="HeadingLine">
            <Items>
                <dx:LayoutItem Caption="Cod. Proveedor:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                            <dx:ASPxSpinEdit ID="txtCODIPROVEE_V" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_V">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                <dx:EmptyLayoutItem>
                </dx:EmptyLayoutItem>
                <dx:EmptyLayoutItem>
                </dx:EmptyLayoutItem>
                <dx:LayoutItem Caption="Apellidos:" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                            <dx:ASPxTextBox ID="txtAPELLIDOS_V" ClientInstanceName="txtAPELLIDOS_V" MaxLength="36" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Nombres:" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRES_V" ClientInstanceName="txtNOMBRES_V" MaxLength="36" runat="server" Width="100%">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Nombres obligatorios" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Telefono:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtTELEFONO_V" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>

                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                <dx:LayoutItem Caption="DUI:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtDUI_V" ClientInstanceName="txtDUI_V" runat="server">
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None"
                                    Mask="99999999-9" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="DUI no valido">
                                </ValidationSettings>
                                <ClientSideEvents Validation="Validacion_DUI" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="NIT:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtNIT_V" runat="server" ClientInstanceName="txtNIT_V">
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None"
                                    Mask="9999-999999-999-9" ErrorText="NIT no valido" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">
                                </ValidationSettings>
                                <ClientSideEvents Validation="Validacion_NIT" /> 
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>





                <dx:LayoutItem Caption="NRC:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtNRC_V" ClientInstanceName="txtNRC_V" MaxLength="10" runat="server">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NRC obligatorio">
                                </ValidationSettings>
                                <ClientSideEvents Validation="Validacion_NRC" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
             
                <dx:LayoutItem Caption="Dirección:" ColSpan="4">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtDIRECCION_V" runat="server" ClientInstanceName="txtDIRECCION_V" MaxLength="250" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>


                <dx:LayoutItem Caption="Tipo Persona:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                            <dx:ASPxComboBox ID="cbxTIPO_PERSONA_V" ClientInstanceName="cbxTIPO_PERSONA_V" AutoPostBack="true" runat="server" ValueType="System.Int32" Width="144px">                           
                                <Items>
                                    <dx:ListEditItem Text="PERSONA NATURAL" Value="1" />
                                    <dx:ListEditItem Text="PERSONA JURÍDICA" Value="2" />
                                    <dx:ListEditItem Text="COOPERATIVA" Value="3" />
                                </Items>
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Tipo de persona obligatorio" IsRequired="True" />
                                </ValidationSettings>     
                                      </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>

                <dx:LayoutItem Caption="Departamento:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO_V" AutoPostBack="true" ClientInstanceName="cbxDEPARTAMENTO_V" runat="server" DataSourceID="odsDepartamento" TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO" OnTextChanged="cbxDEPARTAMENTO_V_TextChanged">
                                <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic"
                                    ErrorDisplayMode="ImageWithTooltip"
                                    RequiredField-ErrorText="Departamento obligatorio">
                                    <RequiredField IsRequired="True" ErrorText="Departamento obligatorio"></RequiredField>
                                </ValidationSettings>
                                </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>

                <dx:LayoutItem Caption="Municipio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxComboBox ID="cbxMUNICIPIO_V" ShowLoadingPanel="true" AutoPostBack="true" LoadingPanelText="Cargando..." ClientInstanceName="cbxMUNICIPIO_V" TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio">
                                <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic"
                                    ErrorDisplayMode="ImageWithTooltip"
                                    RequiredField-ErrorText="Municipio obligatorio">
                                    <RequiredField IsRequired="True" ErrorText="Municipio obligatorio"></RequiredField>
                                </ValidationSettings>
                                 </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Correo Electronico:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                            <dx:ASPxTextBox ID="txtCorreo_V" runat="server" ClientInstanceName="txtCorreo_V" MaxLength="30">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>


<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cMUNICIPIO">
    <SelectParameters>      
        <asp:Parameter DefaultValue="" Name="CODI_DEPTO" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>--%>



