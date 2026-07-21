<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosRequisicion.ascx.vb" Inherits="controlesRequisicion_ucCriteriosRequisicion" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<table>
    <tr>
        <td>
            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="PERIODO:" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxPERIODO" runat="server" DataSourceID="odsPeriodo" ValueField="ID_PERIODOREQ" TextField="DESCRIP_PERIODO" ValueType="System.Int32" Width="250px" >
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="AREA/DEPARTAMENTO:" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxID_SECCION" runat="server"  DataSourceID="odsSeccion" ValueField="ID_SECCION" TextField="NOMBRE_SECCION" TextFormatString="{0} {1}" ValueType="System.Int32" Width="250px" DropDownStyle="DropDownList" >                                                            
            <Columns>
                <dx:ListBoxColumn Caption="Codigo"  FieldName="CODIGO" Width="50px" />  
                <dx:ListBoxColumn Caption="Nombre"  FieldName="NOMBRE_SECCION" Width="300px" />  
            </Columns>
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
        <td>
            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="SOLICITANTE:" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxID_SOLICITANTE" runat="server"  DataSourceID="odsSolicitante" ValueField="ID_SOLICITANTE" TextField="NOMBRE_SOLICITANTE" TextFormatString="{0} {1}" ValueType="System.Int32" Width="250px" DropDownStyle="DropDownList" >                                                            
            <Columns>
                <dx:ListBoxColumn Caption="Codigo"  FieldName="CODIGO" Width="50px" />  
                <dx:ListBoxColumn Caption="Nombre"  FieldName="NOMBRE_SOLICITANTE" Width="300px" />  
            </Columns>
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
     <tr>
        <td>
            <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="N° SOLICITUD:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNUM_SOLICITUD" runat="server" Width="250px">
            </dx:ASPxTextBox>     
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="EMITIDO ENTRE:" /> 
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_EMISION_INI" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px">
                <TimeSectionProperties Visible="true" >
                        <TimeEditProperties EditFormatString="HH:mm" />
                </TimeSectionProperties>
            </dx:ASPxDateEdit>
        </td>
        <td>
            <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text=" Y " />
        </td> 
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_EMISION_FIN" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy"   runat="server" Width="120px" >            
                <TimeSectionProperties Visible="true">
                        <TimeEditProperties EditFormatString="HH:mm" />
                    </TimeSectionProperties>
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="ETAPA:" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxETAPA" runat="server" ValueType="System.Int32" Width="250px" >
                <Items>
                    <dx:ListEditItem Text="" Value="-1" />  
                    <dx:ListEditItem Text="APROBADA" Value="0" />  
                    <dx:ListEditItem Text="NO APROBADA" Value="-2" />  
                    <dx:ListEditItem Text="PENDIENTE EVALUAR" Value="1" />  
                    <dx:ListEditItem Text="PENDIENTE ASIGNAR REQUISICIÓN" Value="2" />
                    <dx:ListEditItem Text="PENDIENTE ORDEN DE COMPRA" Value="3" />
                    <dx:ListEditItem Text="PENDIENTE INGRESAR A ALMACEN" Value="4" />
                    <dx:ListEditItem Text="PENDIENTE ASIGNAR QUEDAN" Value="5" />
                </Items>
            </dx:ASPxComboBox>
        </td>
    </tr>
</table>


<asp:ObjectDataSource ID="odsPeriodo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPERIODOREQ">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="DESCRIP_PERIODO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSeccion" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSECCION">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIGO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSOLICITANTE" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSOLICITANTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIGO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>