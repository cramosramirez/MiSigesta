<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMAESTRO_LOTES.ascx.vb" Inherits="controles_ucVistaDetalleMAESTRO_LOTES" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>






<dx:ASPxFormLayout ID="ucVistaDetalleMAESTRO_LOTESLayout" ClientInstanceName="ucVistaDetalleMAESTRO_LOTESLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="3" Caption="Creando/Editando Lote" Name="lgVistaDetalleMAESTRO_LOTES" GroupBoxDecoration="HeadingLine">
            <Items>
                <dx:LayoutItem Caption="CUI:" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtCUI" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>               
                <dx:LayoutItem Caption="ID_MAESTRO:" ClientVisible="false">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                            <dx:ASPxTextBox ID="txtID_MAESTRO" runat="server" ClientVisible="false" Width="170px">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem> 
                <dx:LayoutItem Caption="Departamento:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO_ML" AutoPostBack="true" ClientInstanceName="cbxDEPARTAMENTO_ML" runat="server" DataSourceID="odsDepartamento" TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  >                           
                            <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" 
                                    RequiredField-ErrorText="Departamento obligatorio" >
<RequiredField IsRequired="True" ErrorText="Departamento obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Municipio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxComboBox ID="cbxMUNICIPIO_ML" ShowLoadingPanel="true" AutoPostBack="true" LoadingPanelText="Cargando..." ClientInstanceName="cbxMUNICIPIO_ML" TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio">                           
                            <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" 
                                    RequiredField-ErrorText="Municipio obligatorio" >
<RequiredField IsRequired="True" ErrorText="Municipio obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Canton:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxComboBox ID="cbxCANTON_ML" ShowLoadingPanel="true" AutoPostBack="true" LoadingPanelText="Cargando..." Width="230px" ClientInstanceName="cbxCANTON_ML" TextField="NOMBRE_CANTON" ValueField="CODI_CANTON"  runat="server" DataSourceID="odsCanton">                                
                                <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" 
                                    RequiredField-ErrorText="Cantón obligatorio" >
<RequiredField IsRequired="True" ErrorText="Cant&#243;n obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                 <dx:LayoutItem Caption="Zona:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                           <dx:ASPxTextBox ID="txtZONA_ML" runat="server">
                                 <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" >
                                    <RequiredField IsRequired="True" ErrorText="Zona obligatoria"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Sub Zona:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                            <dx:ASPxTextBox ID="txtSUB_ZONA_ML" runat="server">
                                 <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" >
                                    <RequiredField IsRequired="True" ErrorText="Sub Zona obligatoria"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:EmptyLayoutItem>
                </dx:EmptyLayoutItem>
                <dx:LayoutItem Caption="Cod. Proveedor:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxSpinEdit ID="txtCODIPROVEE_ML" runat="server" AutoPostBack="true" Width="170px" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_ML" >                                                        
                            <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" 
                                    RequiredField-ErrorText="Codigo obligatorio" >
                                    <RequiredField IsRequired="True" ErrorText="Codigo obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>               
                <dx:LayoutItem Caption="Cod. Socio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer999" runat="server">                            
                            <dx:ASPxSpinEdit ID="txtCODISOCIO_ML" runat="server" AutoPostBack="true" Width="170px" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODISOCIO_ML" >                                                                                      
                            </dx:ASPxSpinEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem> 
                <dx:LayoutItem Caption="Proveedor:" ColSpan="3" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>        
                 <dx:LayoutItem Caption="Hacienda:" ColSpan="3" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtHACIENDA" runat="server" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>       
                <dx:LayoutItem Caption="Nombre Comercial:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRE_COMER" runat="server" Width="170px">
                            <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" 
                                    RequiredField-ErrorText="Nombre comercial obligatorio" >
<RequiredField IsRequired="True" ErrorText="Nombre comercial obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Código Comercial:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxTextBox ID="txtCODILOTE_COMER" runat="server" Width="100px">
                            <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                    ErrorDisplayMode="ImageWithTooltip" 
                                    RequiredField-ErrorText="Codigo comercial obligatorio" >
<RequiredField IsRequired="True" ErrorText="Codigo comercial obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Derecho sobre Lote:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                            <dx:ASPxComboBox ID="cbxTIPO_DERECHO" ClientInstanceName="cbxTIPO_DERECHO" runat="server" ValueType="System.Int32" Width="100%">                           
                                <Items>
                                    <dx:ListEditItem Text="PROPIETARIO" Value="1" />
                                    <dx:ListEditItem Text="ARRENDATARIO" Value="2" />
                                    <dx:ListEditItem Text="ASIGNATARIO" Value="3" />
                                </Items>
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Derecho sobre lote obligatorio" IsRequired="True" />
                                </ValidationSettings>                               
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Técnico asignado:" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxComboBox ID="cbxAGRONOMO" ClientInstanceName="cbxAGRONOMO" Width="100%" DropDownStyle="DropDownList" runat="server" DataSourceID="odsAgronomo" 
                                ValueField="CODIAGRON" TextField="APELLIDO_AGRONOMO" ValueType="System.String" TextFormatString="{0} {1} {2}" IncrementalFilteringMode="Contains">
                                    <Columns>
                                    <dx:ListBoxColumn Caption="Codigo" FieldName="CODIAGRON" Width="80px" />
                                    <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDO_AGRONOMO" Width="120px" />
                                    <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRE_AGRONOMO" Width="120px" />                                                            
                                    </Columns>
                                <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                        RequiredField-ErrorText="Técnico obligatorio" >
                                    <RequiredField IsRequired="True" ErrorText="Técnico obligatorio"></RequiredField>
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>                        
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:EmptyLayoutItem>
                </dx:EmptyLayoutItem>
            </Items>
        </dx:LayoutGroup>
        
    </Items>
</dx:ASPxFormLayout>

<dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" 
    Width="100%" >
    <tabpages>
        <dx:TabPage Text="Información General">
            <contentcollection>
                <dx:ContentControl ID="ContentControl1" runat="server">
                    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                        <Items>
                                <dx:LayoutGroup Caption="Características" ColCount="4" GroupBoxDecoration="None">
                                        <Items>
                                            <dx:LayoutItem Caption="ha Cultivada:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                                        <dx:ASPxSpinEdit ID="txtMZ_CULTIVADA" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                
                                                            <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                                                    RequiredField-ErrorText="MZ Cultivada obligatorio" >
                                                                <RequiredField IsRequired="True" ErrorText="MZ Cultivada obligatorio"></RequiredField>
                                                            </ValidationSettings>
                                                        </dx:ASPxSpinEdit>                            
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Variedad:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                                        <dx:ASPxComboBox ID="cbxVARIEDAD_ML" DropDownStyle="DropDownList" ClientInstanceName="cbxVARIEDAD_ML" runat="server" DataSourceID="odsVariedad" 
                                                            ValueField="CODIVARIEDA" TextField="NOM_VARIEDAD" ValueType="System.String" TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains">    
                                                                <Columns>
                                                                    <dx:ListBoxColumn Caption="Codigo" FieldName="CODIVARIEDA" Width="80px" />
                                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="NOM_VARIEDAD" Width="180px" />
                                                                </Columns>
                                                                <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" 
                                                                    RequiredField-ErrorText="Variedad obligatorio" >
                                                                <RequiredField IsRequired="True" ErrorText="Variedad obligatorio"></RequiredField>
                                                            </ValidationSettings>
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Comportamiento:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                                        <dx:ASPxComboBox ID="cbxCOMPORTAMIENTO_ML" DropDownStyle="DropDownList" ClientInstanceName="cbxCOMPORTAMIENTO_ML" runat="server" DataSourceID="odsComportamiento" 
                                                            ValueField="ID_COMPOR" TextField="NOMBRE_COMPOR" ValueType="System.Int32" TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains">    
                                                                <Columns>
                                                                    <dx:ListBoxColumn Caption="Codigo" FieldName="ID_COMPOR" Width="40px" />
                                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="NOMBRE_COMPOR" Width="180px" />
                                                                </Columns>
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Tipo de suelo:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                                        <dx:ASPxComboBox ID="cbxTIPO_SUELO_ML" DropDownStyle="DropDownList" ClientInstanceName="cbxTIPO_SUELO_ML" runat="server" DataSourceID="odsTipoSuelo" 
                                                            ValueField="COD_TIPO_SUELO" TextField="NOMBRE_TIPO_SUELO" ValueType="System.String" TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains">    
                                                                <Columns>
                                                                    <dx:ListBoxColumn Caption="Codigo" FieldName="COD_TIPO_SUELO" Width="40px" />
                                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="NOMBRE_TIPO_SUELO" Width="180px" />
                                                                </Columns>
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Condición siembra:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                         <dx:ASPxComboBox ID="cbxCONDICION_SIEMBRA_ML" DropDownStyle="DropDownList" ClientInstanceName="cbxCONDICION_SIEMBRA_ML" runat="server" DataSourceID="odsCondicionSiembra" 
                                                            ValueField="ID_COND_SIEMBRA" TextField="NOMBRE_COND" ValueType="System.Int32"  TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains">    
                                                                <Columns>
                                                                    <dx:ListBoxColumn Caption="Codigo" FieldName="ID_COND_SIEMBRA" Width="40px" />
                                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="NOMBRE_COND" Width="180px" />
                                                                </Columns>
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Nivel humedad:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                                         <dx:ASPxComboBox ID="cbxNIVEL_HUMEDAD_ML" DropDownStyle="DropDownList" ClientInstanceName="cbxNIVEL_HUMEDAD_ML" runat="server" DataSourceID="odsNivelHumedad" 
                                                            ValueField="ID_NIVEL_HUMEDAD" TextField="NOMBRE_NIVEL_HUMEDAD" ValueType="System.Int32" TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains">    
                                                                <Columns>
                                                                    <dx:ListBoxColumn Caption="Codigo" FieldName="ID_NIVEL_HUMEDAD" Width="40px" />
                                                                    <dx:ListBoxColumn Caption="Descripcion" FieldName="NOMBRE_NIVEL_HUMEDAD" Width="180px" />
                                                                </Columns>
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="N° Corte:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                                         <dx:ASPxSpinEdit ID="txtNO_CORTE" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0" AllowUserInput="true" runat="server" >                                
                                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                                <RequiredField ErrorText="N° de corte obligatorio" IsRequired="True" />
<RequiredField IsRequired="True" ErrorText="N&#176; de corte obligatorio"></RequiredField>
                                                            </ValidationSettings>
                                                        </dx:ASPxSpinEdit>   
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="MSNM:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                                       <dx:ASPxSpinEdit ID="txtMSNM" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                                               
                                                        </dx:ASPxSpinEdit> 
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Kms. carretera:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">                            
                                                        <dx:ASPxSpinEdit ID="txtKMS_CARRETERA" AutoPostBack="true" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                
                                                        </dx:ASPxSpinEdit> 
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Kms. tierra">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">                            
                                                        <dx:ASPxSpinEdit ID="txtKMS_TIERRA" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                
                                                        </dx:ASPxSpinEdit> 
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Riesgo piedra:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                                                        <dx:ASPxCheckBox ID="chkRIESGO_PIEDRA" runat="server">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                             <dx:LayoutItem Caption="Reparar acceso:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer21" runat="server">
                                                        <dx:ASPxCheckBox ID="chkREPARA_ACCESO" runat="server">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Sin acceso propio:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer22" runat="server">
                                                        <dx:ASPxCheckBox ID="chkSIN_ACCESO_PROPIO" runat="server">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Prod. t">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer18" runat="server">
                                                        <dx:ASPxSpinEdit ID="txtPROD_TC" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                
                                                        </dx:ASPxSpinEdit>                             
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Prod. kg:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer19" runat="server">                           
                                                        <dx:ASPxSpinEdit ID="txtPROD_LBS" AllowNull="true" HorizontalAlign="Right" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                
                                                        </dx:ASPxSpinEdit>   
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="% Despoblación:">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer20" runat="server">             
                                                        <dx:ASPxSpinEdit ID="txtPORC_DESPOBLACION" AllowNull="true" HorizontalAlign="Right" MaxValue="100" DisplayFormatString="#,##0.00" AllowUserInput="true" DecimalPlaces="2" runat="server" >                                
                                                        </dx:ASPxSpinEdit> 
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                        <SettingsItems VerticalAlign="Middle" />

<SettingsItems VerticalAlign="Middle"></SettingsItems>
                                    </dx:LayoutGroup>        
                        </Items>
                    </dx:ASPxFormLayout>
                </dx:ContentControl>
            </contentcollection>
        </dx:TabPage>
        <dx:TabPage Text="Información de Cosecha">
            <contentcollection>
                <dx:ContentControl ID="ContentControl2" runat="server">
                    <dx:ASPxFormLayout ID="frlCosecha" runat="server">
                        <Items>
                            <dx:LayoutGroup GroupBoxDecoration="HeadingLine" ShowCaption="False" Name="gbInformacionCosecha" >
                                <Items>
                                    <dx:LayoutItem Caption="Fecha siembra:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                                                <dx:ASPxDateEdit ID="dteFECHA_SIEMBRA_ML" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true" HorizontalAlign="Right"   
                                                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px">                                
                                                </dx:ASPxDateEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Fecha roza:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server" >
                                                <dx:ASPxDateEdit ID="dteFECHA_CORTE_ML" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true" HorizontalAlign="Right"     
                                                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px">                                
                                                </dx:ASPxDateEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="ha a entregar:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxSpinEdit ID="speMZ_ENTREGAR" runat="server" DisplayFormatString="#,##0.00" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" AutoPostBack="true" Width="170px" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_ML" >                                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="MZ a entregar es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="MZ a entregar es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxSpinEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="TCH a entregar:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxSpinEdit ID="speTONEL_MZ_ENTREGAR" runat="server"  DisplayFormatString="#,##0.00" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" AutoPostBack="true" Width="170px" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_ML" >                                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="TC/MZ a entregar es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="TC/MZ a entregar es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxSpinEdit>                                               
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="t a entregar">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxSpinEdit ID="speTONEL_ENTREGAR" runat="server" DisplayFormatString="#,##0.00"  Width="170px" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_ML" >                                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="TONELADAS a entregar es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="TONELADAS a entregar es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxSpinEdit>                                                      
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:ASPxFormLayout>
                </dx:ContentControl>
            </contentcollection>
        </dx:TabPage>
        <dx:TabPage Text="Información del CAT">
            <contentcollection>
                <dx:ContentControl ID="ContentControl3" runat="server">
                    <dx:ASPxFormLayout ID="frlCAT" runat="server">
                        <Items>
                            <dx:LayoutGroup GroupBoxDecoration="None" ColCount="2" ShowCaption="False">
                                <Items>
                                    <dx:LayoutItem Caption="Tipo de Caña:" ColSpan="2" >
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxComboBox ID="cbxTIPO_CANA" DataSourceID="odsTipoCana" DropDownStyle="DropDownList" runat="server" AutoPostBack="true" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="300px" >
                                                     <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Caña es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Tipo de Caña es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxComboBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Tipo de Roza:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxComboBox ID="cbxTIPO_ROZA" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO"  Width="300px">
                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Roza es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Tipo de Roza es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxComboBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Tarifa Roza:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer  runat="server">
                                                <dx:ASPxSpinEdit ID="speTARIFA_ROZA" DecimalPlaces="4" DisplayFormatString="#,##0.0000" AllowNull="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>                                                    
                                                </dx:ASPxSpinEdit> 
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Tipo de Alza:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxComboBox ID="cbxTIPO_ALZA"  runat="server" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO"  Width="300px">
                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Alza es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Tipo de Alza es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxComboBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Tarifa Alza:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxSpinEdit ID="speTARIFA_ALZA" DecimalPlaces="2" DisplayFormatString="#,##0.00" AllowNull="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                </dx:ASPxSpinEdit> 
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Tipo de Transporte:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxTIPO_TRANS"  runat="server" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO"  Width="300px">
                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Transporte es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Tipo de Transporte es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxComboBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Tarifa Transporte:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <table width="100%">
                                                    <tr>
                                                        <td>Tarifa</td>
                                                        <td>Corta (Mecanizada)</td>
                                                        <td>Larga (Camión)</td>
                                                        <td>Larga (Rastra T3S3)</td>
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxSpinEdit ID="speTARIFA_TRANS" DecimalPlaces="4" DisplayFormatString="#,##0.00##" AllowNull="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                            </dx:ASPxSpinEdit> 
                                                        </td>
                                                        <td>
                                                            <dx:ASPxSpinEdit ID="speTARIFA_CORTA" DecimalPlaces="4" DisplayFormatString="#,##0.00##" AllowNull="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                            </dx:ASPxSpinEdit>
                                                        </td>
                                                        <td>
                                                            <dx:ASPxSpinEdit ID="speTARIFA_LARGA" DecimalPlaces="4" DisplayFormatString="#,##0.00##" AllowNull="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                            </dx:ASPxSpinEdit>
                                                        </td>
                                                        <td>
                                                            <dx:ASPxSpinEdit ID="speTARIFA_LARGA_T3S3" DecimalPlaces="4" DisplayFormatString="#,##0.00##" AllowNull="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                            </dx:ASPxSpinEdit>
                                                        </td>
                                                    </tr>
                                                </table>
                                                
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:ASPxFormLayout>
                </dx:ContentControl>
            </contentcollection>
        </dx:TabPage>
    </tabpages>
</dx:ASPxPageControl>

<dx:ASPxHiddenField ID="hfucVistaDetalleMAESTRO_LOTES" ClientInstanceName="hfucVistaDetalleMAESTRO_LOTES" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSubZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cSUB_ZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
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
<asp:ObjectDataSource ID="odsCanton" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cCANTON">
    <SelectParameters>       
        <asp:Parameter Name="CODI_DEPTO" Type="String" DefaultValue="" />
        <asp:Parameter Name="CODI_MUNI" Type="String" DefaultValue="" />
        <asp:Parameter Name="agregarVacio" Type="Boolean" DefaultValue="True" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
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
<asp:ObjectDataSource ID="odsComportamiento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cCOMPORTAMIENTO_CANA">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_COMPOR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsTipoSuelo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_SUELO">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="COD_TIPO_SUELO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCondicionSiembra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cCONDICION_SIEMBRA">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_COND_SIEMBRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsNivelHumedad" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cNIVEL_HUMEDAD">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_NIVEL_HUMEDAD" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
 <asp:ObjectDataSource ID="odsAgronomo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaContrato" 
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>        
        <asp:Parameter DefaultValue="APELLIDO_AGRONOMO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsTipoCana" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="False" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="15" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>

