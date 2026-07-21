<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCONTROL_QUEMA.ascx.vb" Inherits="controles_ucVistaDetalleCONTROL_QUEMA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCONTROL_QUEMA" Src="~/controlesProforma/ucListaCONTROL_QUEMA.ascx" %>
<table width="100%" >
    <tr>
        <td align="center" style="margin-left: 40px">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <Items>
                    <dx:LayoutGroup Caption="Información de Quema ejecutada del lote" ColCount="4" >
                        <Items>                                                  
                            <dx:LayoutItem Caption="ID Control Quema:" ShowCaption="False" Visible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                        <dx:ASPxTextBox ID="txtID_CONTROL_QUEMA" runat="server" Width="120px">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>               
                            <dx:LayoutItem Caption="Zafra">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>           
                            <dx:LayoutItem Caption="Técnico de Zona" ColSpan="2" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                        <dx:ASPxTextBox ID="txtTECNICO_ZONA" runat="server" Width="100%" >
                                          <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                                                                                                                              
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                   
                            <dx:LayoutItem Caption="Codigo provee">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">                                        
                                        <dx:ASPxTextBox ID="txtCODIPROVEE" runat="server" Width="100px" HorizontalAlign="Right"
                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" >
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                
                            <dx:LayoutItem Caption="Codigo socio">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                                        <dx:ASPxTextBox ID="txtCODISOCIO" runat="server" Width="100px" HorizontalAlign="Right"
                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>    
                            <dx:LayoutItem Caption="Nombre proveedor">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Cod. Lote">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                        <dx:ASPxTextBox ID="txtCODILOTE" runat="server" Width="100px"  DisabledStyle-BackColor="WhiteSmoke" HorizontalAlign="Right" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Lote">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                        <dx:ASPxTextBox ID="txtNOMLOTE" runat="server" Width="200px"  
                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Variedad">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                        <dx:ASPxTextBox ID="txtVARIEDAD" runat="server" Width="300px"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Porción" ColSpan="4">
                                 <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                                        <dx:ASPxComboBox ID="cbxSUBLOTES" runat="server" DisplayFormatString="{0}  -  {1}" ValueField="ID_SUBLOTES" TextField="NOMBRE_PORCION" ValueType="System.Int32" Width="100%" >
                                            <Columns>                                                                            
                                                <dx:ListBoxColumn FieldName="CODIGO" Caption="CODIGO" Width="100px" />
                                                <dx:ListBoxColumn FieldName="NOMBRE_PORCION" Caption="PORCION" Width="350px" />                                                
                                            </Columns>  
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                                        <dx:ASPxCheckBox ID="chkES_PROYECCION" Text="Quema Proyectada" TextAlign="Left" runat="server">
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="False" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">                                        
                                        <dx:ASPxRadioButtonList ID="rblTIPO_QUEMA" ClientInstanceName="rblTIPO_QUEMA" runat="server" 
                                            ValueType="System.Int32" ItemSpacing="10px" RepeatDirection="Horizontal">
                                            <Items>
                                                <dx:ListEditItem Text="Quema Programada" Value="1" />
                                                <dx:ListEditItem Text="Quema no programada" Value="2" />                                                                                                                                                
                                            </Items>                                                                                 
                                        </dx:ASPxRadioButtonList>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Fecha/Hora">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">                                        
                                        <dx:ASPxDateEdit ID="dteFECHA_HORA_QUEMA" ClientInstanceName="dteFECHA_HORA_QUEMA" runat="server" HorizontalAlign="Right" 
                                        DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy hh:mm tt" Width="200px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        <TimeSectionProperties Visible="true">
                                            <TimeEditProperties EditFormatString="hh:mm tt" />
                                        </TimeSectionProperties>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Name="lyiDescripCosecha" Caption="Quema Ejecutada (t)">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                        <dx:ASPxSpinEdit ID="txtENTRADAS" runat="server" HorizontalAlign="Right" Width="100px" 
                                            SpinButtons-ShowIncrementButtons="false" Number="0" 
                                            DisplayFormatString="{0:F2}">
                                             <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                             <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Quemada ejecutada es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>   
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
        </td>
    </tr>
    <tr>
        <td align="center" style="margin-left: 40px">
            <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server" Width="98%" >
                <Items>
                    <dx:LayoutGroup Caption="Movimientos del Control de Quema" ColCount="1" >
                        <Items>
                            <dx:LayoutItem Caption="Saldo de Quema" ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table>
                                            <tr>
                                                <td><dx:ASPxLabel ID="Label101" runat="server" Text="Saldo Caña Quemada:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtSALDO_QUEMA" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                                        DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                                        SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Quema Programada:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtSALDO_QUEMA_PROGRAMADA" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                                        DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                                        SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Quema no Programada:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtSALDO_QUEMA_NOPROG" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                                        DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                                        SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Caña Verde:" ClientVisible="false" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtCANA_VERDE" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                                        DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" ClientVisible="false"
                                                        SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                            </tr>
                                            <tr id="trHORAS_QUEMA" runat="server" >
                                                <td></td>
                                                <td></td>
                                                <td>
                                                <dx:ASPxLabel runat="server" ID="ASPxLabel11" Text="Horas Quema Prog:" />
                                                 </td>
                                                 <td>
                                                    <dx:ASPxTextBox ID="txtHORAS_QUEMA_PROG" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" >                                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                 </td>
                                                 <td>
                                                 <dx:ASPxLabel runat="server" ID="ASPxLabel12" Text="Horas Quema no Prog.:" />
                                                 </td>
                                                 <td>
                                                    <dx:ASPxTextBox ID="txtHORAS_QUEMA_NOPROG" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" >                                                          
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                 </td>                    
                                            </tr>
                                        </table>
                                        
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <uc1:ucListaCONTROL_QUEMA id="ucListaCONTROL_QUEMA1" TamanoPagina="20" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditarInline="false" PermitirEliminar="false" runat="server" PermitirEditar="false"></uc1:ucListaCONTROL_QUEMA>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
        </td>
    </tr>
</table>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSUBLOTES" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorLOTES_COSECHA" 
    TypeName="SISPACAL.BL.cSUBLOTES">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="ID_LOTES_COSECHA" Type="Int32" />       
        <asp:Parameter DefaultValue="NOMBRE_PORCION" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>