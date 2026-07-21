<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosLabPrecosecha.ascx.vb" Inherits="controlesCenso_ucCriteriosLabPrecosecha" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<table>
    <tr id="trID_ZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="lblDescripZafra" runat="server" Text="PRECOSECHA">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA" HorizontalAlign="Right" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA"  Width="140px" >               
            </dx:ASPxComboBox>
        </td> 
        <td><dx:ASPxLabel ID="lblZAFRA_COMPARAR" runat="server" Text="COMPARAR CON ZAFRA:" Visible="false">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA_COMPARAR" HorizontalAlign="Right" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA_COMPARAR" 
            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA"  Width="140px" Visible="false" >               
            </dx:ASPxComboBox>
        </td>       
    </tr>        
    <tr id="trZONA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="ZONA:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsZonas"
                ValueField="ZONA" TextField="DESCRIP_ZONA"  Width="140px" >
             </dx:ASPxComboBox>
        </td>       
    </tr>     
    <tr id="trDIA_ZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="DIA ZAFRA:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxDIA_ZAFRA" ClientInstanceName="cbxDIA_ZAFRA" AutoPostBack="true" runat="server" ValueType="System.Int32" 
                ValueField="ID_DIA_ZAFRA" TextField="DIAZAFRA"  Width="140px" HorizontalAlign="Right" >
             </dx:ASPxComboBox>
        </td>       
    </tr>
    <tr id="trDIA_ZAFRA_CIERRE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="DIA ZAFRA CIERRE:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxDIA_ZAFRA_CIERRE" ClientInstanceName="cbxDIA_ZAFRA_CIERRE" runat="server" ValueType="System.Int32" 
                ValueField="ID_DIA_ZAFRA" TextField="USUARIO_CIERRE"  Width="140px" HorizontalAlign="Right" >
             </dx:ASPxComboBox>
        </td>       
    </tr>
    <tr id="trPERIODO_FECHA_HORA" runat="server" visible="false">
         <td>
            <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="FECHA/HORA INICIAL:" /> 
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFecha1" EditFormatString="dd/MM/yyyy HH:mm" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy HH:mm" runat="server" Width="140px">
                <TimeSectionProperties Visible="true" >
                        <TimeEditProperties EditFormatString="HH:mm" />
                </TimeSectionProperties>
            </dx:ASPxDateEdit>
        </td>
        <td>
            <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="FECHA/HORA FINAL" />
        </td> 
        <td>
            <dx:ASPxDateEdit ID="dteFecha2" EditFormatString="dd/MM/yyyy HH:mm" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy HH:mm"   runat="server" Width="140px" >            
                <TimeSectionProperties Visible="true">
                        <TimeEditProperties EditFormatString="HH:mm" />
                    </TimeSectionProperties>
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr id="trPERIODO_FECHA" runat="server" visible="false">
         <td>
            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="DEL:" /> 
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_INICIAL" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="140px">
            </dx:ASPxDateEdit>
        </td>
        <td>
            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="AL:" />
        </td> 
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_FINAL" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy"   runat="server" Width="140px" >            
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr id="trSEMANA_CATORCENA" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="CATORCENA:" />
        </td> 
        <td>
            <dx:ASPxComboBox ID="cbxCATORCENA" runat="server" ValueType="System.Int32" Width="140px" DropDownStyle="DropDown" AutoPostBack="true" />
        </td>
         <td>
            <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="SEMANA:" /> 
        </td>
        <td>
           <dx:ASPxComboBox ID="cbxSEMANA" runat="server" ValueType="System.String" Width="140px" DropDownStyle="DropDown" />
        </td>        
    </tr>
    <tr id="trFECHA_CORTE" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="FECHA CORTE:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_CORTE" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="140px" >            
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr id="trFECHA_HORA_CORTE" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="FECHA/HORA:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_HORA_CORTE" ClientInstanceName="dteFECHA_HORA_CORTE" runat="server" HorizontalAlign="Right" 
            DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True"  AutoPostBack="true"
            EditFormatString="dd/MM/yyyy HH:mm" Width="140px">
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            <TimeSectionProperties Visible="true">
                <TimeEditProperties EditFormatString="HH:mm" />
            </TimeSectionProperties>
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr id="trAUTORIZADO_ENTREGA_CANA" runat="server" visible="false">
        <th style="text-align:left" colspan="2">        
            <dx:ASPxRadioButtonList ID="rblAUTORIZADO_ENTREGA_CANA" RepeatDirection="Horizontal" ItemSpacing="10px" runat="server" ValueType="System.Int32" >
                <Items>
                <dx:ListEditItem Text="Ver Propuesta" Value="-1" />  
                <dx:ListEditItem Text="Ver lotes autorizados para entrega" Value="1" />
                </Items>
            </dx:ASPxRadioButtonList>
        </th>
    </tr>
    <tr id="trNROBOLETA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="N° TACO">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxSpinEdit ID="speNROBOLETA" HorizontalAlign="Right" runat="server" AllowNull="true" Width="140px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            </dx:ASPxSpinEdit> 
        </td>  
    </tr>      
    <tr id="trCODIPROVEEDOR_SOCIO" runat="server" visible="false">
         <td>
            <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="COD. PROVEE:" /> 
        </td>
        <td>
            <dx:ASPxSpinEdit ID="txtCODIPROVEE" HorizontalAlign="Right" runat="server" AllowNull="true" Width="140px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            </dx:ASPxSpinEdit> 
        </td>
        <td>
            <dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="COD. SOCIO:" />
        </td> 
        <td>
            <dx:ASPxSpinEdit ID="txtCODISOCIO" HorizontalAlign="Right" runat="server" AllowNull="true" Width="140px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            </dx:ASPxSpinEdit> 
        </td>
    </tr>  
    <tr id="trNOMBRE_PROVEEDOR" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="PRODUCTOR:">
            </dx:ASPxLabel>
        </td>
        <th colspan="3">
            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="370px">
            </dx:ASPxTextBox>
        </th>       
    </tr>
    <tr id="trNOMBLOTE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="LOTE:">
            </dx:ASPxLabel>
        </td>
        <th colspan="3">
            <dx:ASPxTextBox ID="txtNOMBLOTE" runat="server" Width="370px">
            </dx:ASPxTextBox>
        </th>       
    </tr>
    <tr id="trAGRONOMO" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="AGRONOMO:">
            </dx:ASPxLabel>
        </td>
        <th colspan="3">
            <dx:ASPxComboBox ID="cbxAGRONOMO" ClientInstanceName="cbxAGRONOMO" Width="100%" DropDownStyle="DropDownList" runat="server" DataSourceID="odsAgronomo" 
                ValueField="CODIAGRON" TextField="APELLIDO_AGRONOMO" ValueType="System.String" TextFormatString="{0} {1} {2}" IncrementalFilteringMode="Contains">
                    <Columns>
                    <dx:ListBoxColumn Caption="Codigo" FieldName="CODIAGRON" Width="80px" />
                    <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDO_AGRONOMO" Width="120px" />
                    <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRE_AGRONOMO" Width="120px" />                                                            
                    </Columns>                
            </dx:ASPxComboBox>
        </th>
    </tr>   
    <tr id="trCON_CUOTA_DIARIA" runat="server" visible="false">        
        <th colspan="4" style="text-align:left" >
                <dx:ASPxCheckBox runat="server" ID="chkCUOTA_DIARIA" Text="MOSTRAR SOLO LOTES CON CUOTA DIARIA:" TextAlign="Left"   >
                </dx:ASPxCheckBox>
        </th>       
    </tr>    
</table>
 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
    <SelectParameters>
        <asp:Parameter Name="recuperarHijas" Type="Boolean" DefaultValue="false" />
        <asp:Parameter Name="asColumnaOrden" Type="String" DefaultValue="NOMBRE_ZAFRA" />
        <asp:Parameter Name="asTipoOrden" Type="String" DefaultValue="ASC" />
    </SelectParameters>
 </asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsAgronomo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="RecuperarLista" 
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>
        <asp:Parameter DefaultValue="true" Name="AgregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="false" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="APELLIDO_AGRONOMO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZonas" runat="server" TypeName="SISPACAL.BL.cZONAS" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="DESCRIP_ZONA" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>