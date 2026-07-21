<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOCIO.ascx.vb" Inherits="controlesContrato_ucVistaDetalleSOCIO" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>



<script type="text/javascript">
    function Validacion_NIT_SOCIO(s, e) {
        var nit = e.value;
        if (nit == null)
            e.isValid = true;
        else if (nit.length > 0 && nit.length < 14)
            e.isValid = false;
    }

    function Validacion_DUI_SOCIO(s, e) {
        var dui = e.value;
        if (dui == null)
            e.isValid = true;
        else if (dui.length > 0 && dui.length < 9)
            e.isValid = false;
    }

    function Validacion_NRC_SOCIO(s, e) {
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
<dx:ASPxFormLayout ID="ucVistaDetalleSOCIOLayout" ClientInstanceName="ucVistaDetalleSOCIOLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="4" Caption="Creando/Editando Socio" 
            Name="lgVistaDetalleSOCIO" GroupBoxDecoration="HeadingLine">
            <Items>
                <dx:LayoutItem Caption="Cod. Proveedor:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                            <dx:ASPxSpinEdit ID="txtCODIPROVEE_V" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE_V" >
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Codigo proveedor obligatorio" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>                             
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Cod. Socio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                            <dx:ASPxSpinEdit ID="txtCODISOCIO_V" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODISOCIO_V" >
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Codigo socio obligatorio" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxSpinEdit>                             
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>               
                <dx:EmptyLayoutItem>
                </dx:EmptyLayoutItem>
                <dx:EmptyLayoutItem>
                </dx:EmptyLayoutItem>
                <dx:LayoutItem Caption="Apellidos:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                            <dx:ASPxTextBox ID="txtAPELLIDOS_V" ClientInstanceName="txtAPELLIDOS_V" MaxLength="36" runat="server">
                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Apellidos obligatorios" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Nombres:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRES_V" ClientInstanceName="txtNOMBRES_V" MaxLength="36" runat="server">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField ErrorText="Nombres obligatorios" IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Telefono:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                            <dx:ASPxTextBox ID="txtTELEFONO_V" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Celular:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                            <dx:ASPxTextBox ID="txtCELULAR_V" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="DUI:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                            <dx:ASPxTextBox ID="txtDUI_V" ClientInstanceName="txtDUI_V" runat="server">
                                <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                    Mask="99999999-9" />
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="DUI no valido">                                                                        
                                </ValidationSettings>
                                <ClientSideEvents Validation="Validacion_DUI_SOCIO" /> 
                            </dx:ASPxTextBox>                            
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="NIT:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                            <dx:ASPxTextBox ID="txtNIT_V" runat="server" ClientInstanceName="txtNIT_V">
                                 <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                     Mask="9999-999999-999-9" ErrorText="NIT no valido"  />
                                 <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">                                    
                                </ValidationSettings>
                                <ClientSideEvents Validation="Validacion_NIT_SOCIO" /> 
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Nombre s/NIT:" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                            <dx:ASPxTextBox ID="txtNOMBRENIT_V" runat="server" Width="100%" MaxLength="72">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">                                    
                                </ValidationSettings>                                
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Tipo:" ColSpan="3" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                            <dx:ASPxRadioButtonList ID="rdbTIPO_CONTRIBUYENTE_V" ClientInstanceName="rdbTIPO_CONTRIBUYENTE_V" runat="server" 
                                SelectedIndex="0" ValueType="System.Int32" RepeatDirection="Horizontal" Width="100%">
                                <Items>
                                    <dx:ListEditItem Selected="True" Text="No contribuyente" Value="0" />
                                    <dx:ListEditItem Text="Contribuyente" Value="1" />
                                    <dx:ListEditItem Text="Gran contribuyente" Value="2" />
                                </Items>
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">                                                                      
                                </ValidationSettings> 
                                 <ClientSideEvents ValueChanged="function(s,e){                                                                      
                                    if (s.GetValue()==1 || s.GetValue()==2){                                        
                                        txtNRC_V.SetEnabled(true);
                                    }
                                    else{
                                        txtNRC_V.SetEnabled(false);
                                        txtNRC_V.SetText('');
                                    }
                                }"  />
                            </dx:ASPxRadioButtonList>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="NRC:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                            <dx:ASPxTextBox ID="txtNRC_V" ClientInstanceName="txtNRC_V" MaxLength="10" runat="server">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NRC obligatorio" >                                    
                                </ValidationSettings>  
                                <ClientSideEvents Validation="Validacion_NRC_SOCIO"  />
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Fecha Nacimiento:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                            <dx:ASPxDateEdit ID="dteFECHA_NACIMIENTO_V" 
                                ClientInstanceName="dteFECHA_NACIMIENTO_V" runat="server" 
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" 
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True">
                                <ClientSideEvents DateChanged="function(s,e){                                                        
                                    txtEDAD_V.SetText(CalcularEdad(s.GetValue()));
                                }"  />
                            </dx:ASPxDateEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Edad:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                            <dx:ASPxTextBox ID="txtEDAD_V" ClientInstanceName="txtEDAD_V" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Profesión:" ColSpan="2">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                            <dx:ASPxTextBox ID="txtPROFESION_V" runat="server" Width="100%" MaxLength="34">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Dirección:" ColSpan="4">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                            <dx:ASPxTextBox ID="txtDIRECCION_V" runat="server" ClientInstanceName="txtDIRECCION_V" MaxLength="250" Width="100%">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Codiproveedor" ClientVisible="false">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                            <dx:ASPxTextBox ID="txtCODIPROVEEDOR_V" runat="server">
                            </dx:ASPxTextBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>
<dx:ASPxHiddenField ID="hfucVistaDetalleSOCIO" ClientInstanceName="hfucVistaDetalleSOCIO" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>

