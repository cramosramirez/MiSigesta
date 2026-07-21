<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMOTORISTA.ascx.vb" Inherits="controles_ucVistaDetalleMOTORISTA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


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
</script>

<center>
<dx:ASPxFormLayout ID="ucVistaDetalleMOTORISTALayout" ClientInstanceName="ucVistaDetalleMOTORISTALayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="1" Caption="Creando/Editando Motorista" Name="lgVistaDetalleMOTORISTA" GroupBoxDecoration="HeadingLine">
            <Items>
                <dx:LayoutItem  ShowCaption="False" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                            <table width="100%" border="0" >
                                <tr>
                                    <td><dx:ASPxLabel ID="AspxLabel1" runat="server" Text="ID Motorista:" /></td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="txtID_MOTORISTA" runat="server" AllowNull="true" Width="100px"  AllowUserInput="true" >
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                            <SpinButtons ShowIncrementButtons="false">
                                            </SpinButtons>
                                        </dx:ASPxSpinEdit> 
                                    </td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel ID="AspxLabel2" runat="server" Text="Nombres:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtNOMBRES" MaxLength="60" runat="server" Width="250px" >
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Nombres obligatorios" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td><dx:ASPxLabel ID="AspxLabel3" runat="server" Text="Apellidos:" /></td>
                                    <td>                                        
                                        <dx:ASPxTextBox ID="txtAPELLIDOS" MaxLength="60" runat="server" Width="250px" >                            
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Nombres obligatorios" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>                        
                                    </td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel ID="AspxLabel4" runat="server" Text="DUI:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtDUI" runat="server" Width="250px" >
                                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                                Mask="99999999-9" />
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="DUI no valido">                                                                       
                                            </ValidationSettings>
                                            <ClientSideEvents Validation="Validacion_DUI" /> 
                                        </dx:ASPxTextBox>   
                                    </td>
                                    <td><dx:ASPxLabel ID="AspxLabel5" runat="server" Text="NIT:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtNIT" runat="server" Width="250px"  >
                                             <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                                 Mask="9999-999999-999-9" ErrorText="NIT no valido"  />
                                             <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">                                    
                                            </ValidationSettings>
                                            <ClientSideEvents Validation="Validacion_NIT" /> 
                                        </dx:ASPxTextBox> 
                                    </td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel ID="AspxLabel6" runat="server" Text="Licencia:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtLICENCIA" runat="server" Width="250px" >                                                                                       
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Licencia es obligatoria" IsRequired="True" />
                                            </ValidationSettings>                                         
                                        </dx:ASPxTextBox>   
                                    </td>
                                    <td><dx:ASPxLabel ID="AspxLabel7" runat="server" Text="Activo:" /></td>
                                    <td>
                                        <dx:ASPxCheckBox ID="chkActivo" runat="server" Text="" >
                                        </dx:ASPxCheckBox>
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
</center>