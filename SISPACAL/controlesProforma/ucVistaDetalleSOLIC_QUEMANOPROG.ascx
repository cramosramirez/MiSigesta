<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_QUEMANOPROG.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_QUEMANOPROG" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register tagprefix="uc1" tagname="ucListaLOTES" Src="~/controlesContrato/ucListaLOTES.ascx" %>

<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="flyucVistaDetalleSOLIC_QUEMANOPROG"  runat="server" Width="70%">
                <Items>
                    <dx:LayoutGroup ColCount="4" Name="lgSOLIC_QUEMANOPROG" Caption="Datos de la Solicitud" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem Caption="Id Solicitud" Visible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                        <dx:ASPxTextBox ID="txtID_SOLIC_QUEMANOPROG" runat="server" Width="170px" BackColor="WhiteSmoke">                               
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Zafra:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1"  runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Fecha de Solicitud:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_SOLIC"  runat="server" ClientEnabled="false" 
                                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy" Width="100px">
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Fecha de la muestra es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            <dx:LayoutItem Caption="N° Solicitud">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtNO_SOLICITUD" runat="server" Width="100px" >
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>    
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                                      
                            <dx:LayoutItem Caption="Cod. Proveedor:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" ClientInstanceName="txtCODIPROVEE" AutoPostBack="true" Width="100px"  >
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            <dx:LayoutItem Caption="Nombre del Productor:" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR" Width="100%" >  
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                             
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>      
                            <dx:LayoutItem Caption="Fecha/Hora Quema">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">                                        
                                        <dx:ASPxDateEdit ID="dteFECHA_HORA_QUEMA" ClientInstanceName="dteFECHA_HORA_QUEMA" runat="server" HorizontalAlign="Right" 
                                        DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy HH:mm" Width="170px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        <TimeSectionProperties Visible="true">
                                            <TimeEditProperties EditFormatString="HH:mm" />
                                        </TimeSectionProperties>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Area (MZ)">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                        <dx:ASPxSpinEdit ID="txtAREA" runat="server" Width="100px"  >   
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                         
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Toneladas">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                        <dx:ASPxSpinEdit ID="txtTONEL" runat="server" Width="100px"  >    
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                        
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Tipo de Quema">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">                                        
                                        <dx:ASPxRadioButtonList ID="rblTIPO_QUEMA" runat="server" 
                                            ValueType="System.Char" ItemSpacing="10px" RepeatDirection="Horizontal">
                                            <Items>
                                                <dx:ListEditItem Text="Accidental" Value="A" />
                                                <dx:ListEditItem Text="Intencional" Value="I" />                                                                                                
                                            </Items>
                                        </dx:ASPxRadioButtonList>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer  runat="server">                                        
                                        <table>
                                            <tr>
                                                <td style="padding-left:3px"><dx:ASPxCheckBox ID="chkBRECHAS" Text="Brechas" runat="server" 
                                                        TextAlign="Left" /></td>
                                                <td style="padding-left:3px"><dx:ASPxCheckBox ID="chkRONDAS" Text="Rondas" runat="server" TextAlign="Left" /></td>
                                                <td style="padding-left:3px"><dx:ASPxCheckBox ID="chkVIGILANCIA" Text="Vigilancia" runat="server" 
                                                        TextAlign="Left" /></td>
                                                <td style="padding-left:3px">
                                                    <dx:ASPxCheckBox ID="chkMADURANTE" Text="Madurante" runat="server" 
                                                        ClientEnabled="false" TextAlign="Left" >
                                                        <DisabledStyle BackColor="Transparent" ForeColor="Black"></DisabledStyle>  
                                                    </dx:ASPxCheckBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem  Caption="Fecha Aplicación" >
                                 <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">    
                                        <dx:ASPxDateEdit ID="dteFECHA_APLICACION"  runat="server" ClientEnabled="false" 
                                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy" Width="100px">
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                           
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem  Caption="Pre-Muestra" >
                                 <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">    
                                        <dx:ASPxCheckBox ID="chkPREMUESTRA" runat="server" 
                                            ClientEnabled="false" >
                                            <DisabledStyle BackColor="Transparent" ForeColor="Black"></DisabledStyle>  
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Denuncia Policial">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">                                        
                                        <dx:ASPxRadioButtonList ID="rblCON_DENUNCIA" runat="server" 
                                            ValueType="System.Boolean" ItemSpacing="10px" RepeatDirection="Horizontal">
                                            <Items>
                                                <dx:ListEditItem Text="Sí" Value="true" />
                                                <dx:ListEditItem Text="No" Value="false" />                                                                                                
                                            </Items>
                                        </dx:ASPxRadioButtonList>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Observaciones" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">                                        
                                        <dx:ASPxMemo ID="txtOBSERVACIONES" runat="server" Height="50px" Width="100%" 
                                            MaxLength="800">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxMemo>
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

<dx:ASPxLabel ID="lblDetalle" runat="server" Text="Seleccione el lote contratado en el que se efectuo la quema no programada" 
    ForeColor="#4881A2" Font-Bold="True" Font-Names="Arial" 
    Font-Size="Small" />
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<uc1:ucListaLOTES id="ucListaLOTES1" MostrarCheckUnaSeleccion="true" NombreGridCliente="ucListaLOTES1" PermitirEditarInline="false" TipoEdicion="0" TamanoPagina="7" PermitirEliminar="false" runat="server" VerCUI="false" VerCODISOCIO="false" VerANIOZAFRA="false" PermitirEditar="false"></uc1:ucListaLOTES>
<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="flyucVistaDetalleSOLIC_QUEMANOPROG_APLICA" runat="server" Width="70%">
                <Items>
                    <dx:LayoutGroup ColCount="4" Name="lygSOLIC_QUEMANOPROG_APLICA" Caption="Aplicación Real de Quema No Programada" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem Caption="Fecha/Hora Quema">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">                                        
                                        <dx:ASPxDateEdit ID="dteFECHA_HORA_QUEMA_REAL" ClientInstanceName="dteFECHA_HORA_QUEMA" runat="server" HorizontalAlign="Right" 
                                        DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy HH:mm" Width="170px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        <TimeSectionProperties Visible="true">
                                            <TimeEditProperties EditFormatString="HH:mm" />
                                        </TimeSectionProperties>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Area (MZ)">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                        <dx:ASPxSpinEdit ID="txtMZ_REAL" runat="server" Width="100px"  >   
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                         
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Toneladas">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                        <dx:ASPxSpinEdit ID="txtTONEL_REAL" runat="server" Width="100px"  >    
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                        
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


