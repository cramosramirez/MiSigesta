<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleTRANSPORTISTA.ascx.vb" Inherits="controles_ucVistaDetalleTRANSPORTISTA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaTRANSPORTE" Src="~/controles/ucListaTRANSPORTE.ascx" %>


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

<asp:ObjectDataSource ID="odsTipoTransporte" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_TRANSPORTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />       
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxFormLayout ID="ucVistaDetallePROVEEDORLayout" ClientInstanceName="ucVistaDetallePROVEEDORLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="3" Caption="Creando/Editando Transportista"
            Name="lgVistaDetallePROVEEDOR" GroupBoxDecoration="HeadingLine">
            <Items>

                <dx:LayoutItem Caption="Código:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                <dx:ASPxSpinEdit ID="speCODTRANSPORT" runat="server" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="speCODTRANSPORT" >
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
                            <dx:ASPxComboBox ID="cbxTIPO_PERSONA_T" AutoPostBack="true" runat="server" Font-Bold="true" DataSourceID="odsTipoPersona" 
                                TextField="DESCRIPCION" ValueField="ID_TIPO_PERSONA" ValueType="System.Int32"  Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Dui:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                            <dx:ASPxTextBox ID="txtDUI_T" Font-Bold="true" runat="server"  Width="100%">
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
                            <dx:ASPxTextBox ID="txtNIT_T" Font-Bold="true" runat="server" Width="100%">
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
                            <dx:ASPxTextBox ID="txtNOMBRES_T" Font-Bold="true" MaxLength="150" runat="server" Width="100%">
                                <DisabledStyle BackColor="WhiteSmoke" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Apellidos:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                            <dx:ASPxTextBox ID="txtAPELLIDOS_T" Font-Bold="true" MaxLength="150" runat="server"  Width="100%">
                                <DisabledStyle BackColor="WhiteSmoke" />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Dirección:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                            <dx:ASPxTextBox ID="txtDIRECCION_T" MaxLength="150" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Departamento:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO_T" AutoPostBack="true" runat="server" DataSourceID="odsDepartamento" 
                                TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Municipio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                            <dx:ASPxComboBox ID="cbxMUNICIPIO_T" ShowLoadingPanel="true" LoadingPanelText="Cargando..." 
                                TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio" Width="100%">
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Teléfono:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                            <dx:ASPxTextBox ID="txtTELEFONO_T" MaxLength="100" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Ncr:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                            <dx:ASPxTextBox ID="txtNRC_T" MaxLength="15" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Correo:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                            <dx:ASPxTextBox ID="txtCORREO_T" MaxLength="200" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Fecha nacimiento:" CaptionSettings-HorizontalAlign="Left">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer18" runat="server">
                           <dx:ASPxDateEdit ID="dteFECHA_NACIMIENTO"
                                ClientInstanceName="dteFECHA_NACIMIENTO" runat="server"
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom"
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" Width="100%">                                 
                            </dx:ASPxDateEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Actividad primaria:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                            <dx:ASPxTextBox ID="txtACTIVIDAD" MaxLength="300" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Actividad secundaria:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                            <dx:ASPxTextBox ID="txtACTIVIDAD2" MaxLength="300" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Actividad terciaria:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">
                            <dx:ASPxTextBox ID="txtACTIVIDAD3" MaxLength="300" runat="server"  Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Profesión:" CaptionSettings-HorizontalAlign="Left" ColSpan="3">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtPROFESION_T" runat="server" MaxLength="200" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                    <dx:LayoutItem Caption="Nombre en Cheque:" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxTextBox ID="txtNOMBRE_CH" runat="server" MaxLength="100" Width="100%">
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="Nombre segun NIT obligatorio" IsRequired="True" />                                    
                                    </ValidationSettings>                                
                                </dx:ASPxTextBox>
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
                    <dx:LayoutItem Caption="N° de Cuenta Contable">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxTextBox ID="txtNOCUENTA" runat="server" MaxLength="20">
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="N° de Cuenta Contable obligatorio" IsRequired="True" />                                    
                                    </ValidationSettings> 
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>                             
                    <dx:LayoutItem Caption="Código SIGASI:" Name="libCOD_SIGASI">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxSpinEdit ID="speCOD_SIGASI" runat="server" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="speCOD_SIGASI" >                                
                                </dx:ASPxSpinEdit>                             
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Código Combustible:" Name="libCOD_COMBUST">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="speCOD_COMBUST" runat="server" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="speCOD_COMBUST" >                                
                                </dx:ASPxSpinEdit>                             
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem> 
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<%--<uc1:ucListaTRANSPORTE id="ucListaTRANSPORTE1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaTRANSPORTE>    
    --%>

<table>
        <tr>
        <td>
            <hr />
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="aspxLabel18" runat="server" Text="Vehículos del Transportista" Font-Bold="true" />
        </td>
    </tr>
    <tr>
        <td>
            <table width="100%">
                <tr>
                    <td width="200px"><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="Placa" /></td>
                    <td width="270px"><dx:ASPxLabel ID="aspxLabel2" runat="server" Text="Tipo Transporte" /></td>
                    <td width="170px"><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Remolque" /></td>
                    <td width="220px"><dx:ASPxLabel ID="aspxLabel4" runat="server" Text="Marca" /></td>
                    <td width="160px" style="text-align:right"><dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Capacidad" /></td>
                    <td width="100px"><dx:ASPxLabel ID="aspxLabel6" runat="server" Text="Año" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxTextBox ID="txtPLACA" runat="server" MaxLength="100" Width="100%" >
                        </dx:ASPxTextBox> 
                    </td>
                    <td>
                        <dx:ASPxComboBox ID="cbxTIPO_TRANSPORTE" runat="server"  DataSourceID="odsTipoTransporte" ValueField="ID_TIPOTRANS" TextField="NOMBRE" ValueType="System.Int32" Width="100%">
                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxComboBox> 
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtREMOLQUE" runat="server" MaxLength="100" Width="100%" >
                        </dx:ASPxTextBox> 
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtMARCA" runat="server" MaxLength="50" Width="100%" >
                        </dx:ASPxTextBox>
                    </td>
                    <td><dx:ASPxSpinEdit ID="speCAPACIDAD" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" DisplayFormatString="#,###0.00"  SpinButtons-ShowIncrementButtons="false" Width="100%" >
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="speANIO" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###" Width="100px" >
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxButton ID="btnAgregarTransporte" CausesValidation="false" ToolTip="Agregar Transporte" Width="20px" Theme="RedWine" runat="server" Text="+"></dx:ASPxButton></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <uc1:ucListaTRANSPORTE id="ucListaTRANSPORTE1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaTRANSPORTE>                                                                                        
        </td>
    </tr>
</table>










































