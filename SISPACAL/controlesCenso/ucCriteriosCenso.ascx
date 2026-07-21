<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosCenso.ascx.vb" Inherits="controlesCenso_ucCriteriosCenso" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<style type="text/css">
    .style1 {
        height: 20px;
    }
</style>

<script type="text/javascript">
    var postponedCallbackRequired = false;
    var ultCenso = null;

    function CambiandoZafra() {
        if (cbxCENSO.InCallback())
            ultCenso = cbxZAFRA.GetValue().toString();
        else
            cbxCENSO.PerformCallback(cbxZAFRA.GetValue().toString());
    }
    function OnEndCallbackZafra(s, e) {
        if (ultCenso) {
            cbxCENSO.PerformCallback(ultCenso);
            ultCenso = null;
        }
    }    
    </script>
<table border="0" >
    <tr id="trID_ZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ZAFRA">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA" Theme="Office2010Blue" Width="118px" >               
            </dx:ASPxComboBox>
        </td>
        <td></td>
    </tr>
     <tr id="trDIA_ZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="DIA ZAFRA:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxDIA_ZAFRA" runat="server" ValueType="System.Int32"  
            ValueField="ID_DIA_ZAFRA" TextField="DIAZAFRA" Theme="Office2010Blue" Width="118px" >               
            </dx:ASPxComboBox>
        </td>
        <td></td>
    </tr>
    <tr id="trID_CENSO" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="CENSO">
            </dx:ASPxLabel>
        </td>
        <th colspan="5">
                <dx:ASPxComboBox ID="cbxCENSO" ClientInstanceName="cbxCENSO" runat="server" AutoPostBack="true" ValueType="System.Int32" DataSourceID="odsCenso"
                                 ValueField="ID_CENSO" TextFormatString="{0} {1}" Theme="Office2010Blue" Width="100%" ShowLoadingPanel="true"  LoadingPanelText="Cargando..."  >                                                                    
                    <Columns>
                    <dx:ListBoxColumn Caption="Fecha" FieldName="FECHA_CENSO" Width="42px" />
                    <dx:ListBoxColumn Caption="Censo" FieldName="NOMBRE_CENSO" Width="400px" />                
                    </Columns>
                </dx:ASPxComboBox>
        </th>        
    </tr>
    <tr id="trZONA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="ZONA">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsZonas"
                ValueField="ZONA" TextField="DESCRIP_ZONA" Theme="Office2010Blue" Width="118px" >
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="lblSubZona" runat="server" Text="SUB ZONA">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxSUB_ZONA" ClientInstanceName="cbxSUB_ZONA"  runat="server" ValueType="System.String" DataSourceID="odsSubZonas"
                ValueField="SUB_ZONA" TextField="SUB_ZONA" Theme="Office2010Blue" Width="200px" >
             </dx:ASPxComboBox>
        </td>
    </tr>    
    <tr id="trCANTON" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="DEPARTAMENTO">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxDEPARTAMENTO" ClientInstanceName="cbxDEPARTAMENTO" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsDepartamento"
                ValueField="CODI_DEPTO" TextField="NOMBRE_DEPTO" Theme="Office2010Blue" Width="118px" >
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="MUNICIPIO">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxMUNICIPIO" ClientInstanceName="cbxMUNICIPIO" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsMunicipio"
                ValueField="CODI_MUNI" TextField="NOMBRE_MUNI" Theme="Office2010Blue" Width="200px" >
             </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="CANTON">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxCANTON" ClientInstanceName="cbxCANTON"  runat="server" ValueType="System.String" DataSourceID="odsCanton"
                ValueField="CODI_CANTON" TextField="NOMBRE_CANTON" Theme="Office2010Blue" Width="200px" >
             </dx:ASPxComboBox>
        </td>
    </tr>    
    <tr id="trCODIPROVEEDOR" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="CODI. PROVEEDOR">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCODIPROVEE" runat="server" Width="100px" 
                Theme="Office2010Blue">
            </dx:ASPxTextBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="SOCIO">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCODISOCIO" runat="server" Width="50px" 
                Theme="Office2010Blue">
            </dx:ASPxTextBox>
        </td>
    </tr>   
    <tr id="trTIPO_DETALLE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="MOSTRAR POR:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxTipoDetalle" ClientInstanceName="cbxTipoDetalle" ValueType="System.Int32" runat="server" Theme="Office2010Blue" Width="175px" >
                <Items>
                    <dx:ListEditItem Text="Lote" Value="1" />
                    <dx:ListEditItem Text="Lote por Canton" Value="11" />
                    <dx:ListEditItem Text="Contrato" Value="2" />
                    <dx:ListEditItem Text="Zona" Value="3" />
                    <dx:ListEditItem Text="Zona y SubZona" Value="4" />
                    <dx:ListEditItem Text="Zona, SubZona y Canton" Value="5" />
                </Items>
            </dx:ASPxComboBox>           
        </th>       
    </tr>
    <tr id="trTC_ENTREGADA_ZA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="TC ENTREGADA 13/14:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxRangoEntrega" ClientInstanceName="cbxRangoEntrega" ValueType="System.Int32" runat="server" Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="Sin delimitar" Value="1" />
                    <dx:ListEditItem Text="Dentro de (+-) 20% contratado" Value="2" />
                    <dx:ListEditItem Text="Fuera de (+-) 20% contratado" Value="3" />                    
                </Items>
            </dx:ASPxComboBox>           
        </th>       
    </tr>
     <tr id="trENTREGA_CANA_CIERRE" runat="server" visible="false">       
        <th colspan="3" class="style1">
            <dx:ASPxCheckBox ID="chkEntregaCanaCierre" runat="server"  Text="ENTREGA DE CAÑA AL CIERRE:" TextAlign="Left" 
                Theme="Office2010Blue">
            </dx:ASPxCheckBox>
        </th>       
    </tr>
    <tr id="trUNIDAD_MEDIDA" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="UNIDAD DE MEDIDA:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxUnidadMedida" ValueType="System.Int32" runat="server" Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="TONELADAS METRICAS - TM" Value="1" />
                    <dx:ListEditItem Text="TONELADAS CORTAS - TC" Value="2" />                
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
    <tr id="trPERIODO" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="PERIODO:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxPERIODO" AutoPostBack="true" ValueType="System.Int32" runat="server" 
                Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="CORTE" Value="1" />
                    <dx:ListEditItem Text="ACUMULADO A LA FECHA" Value="2" />                
                    <dx:ListEditItem Text="RANGO DE FECHAS" Value="3" /> 
                </Items>
            </dx:ASPxComboBox>           
        </th>
        <td>
            <table>
                <tr id="trPERIODO_CORTE" runat="server" visible="false">
                    <td>
                        <dx:ASPxComboBox ID="cbxPeriodoCorte" ValueType="System.Int32" ValueField="ID_CATORCENA" TextField="CATORCENA" runat="server" Theme="Office2010Blue" Width="80px" >                                                    
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr id="trPERIODO_RANGO_FECHAS" runat="server" visible="false">
                    <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="DEL:" /></td>
                    <td>
                        <dx:ASPxDateEdit ID="dteFECHA_INI" EditFormatString="dd/MM/yyyy HH:mm" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy HH:mm" runat="server" Width="140px">
                            <TimeSectionProperties Visible="true" >
                                    <TimeEditProperties EditFormatString="HH:mm" />
                            </TimeSectionProperties>
                        </dx:ASPxDateEdit>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="AL:" /></td>
                    <td>
                        <dx:ASPxDateEdit ID="dteFECHA_FIN" EditFormatString="dd/MM/yyyy HH:mm" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy HH:mm" runat="server" Width="140px">
                            <TimeSectionProperties Visible="true" >
                                    <TimeEditProperties EditFormatString="HH:mm" />
                            </TimeSectionProperties>
                        </dx:ASPxDateEdit>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="trNIVEL" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="NIVEL:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxNivel" ValueType="System.Int32" runat="server" Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="COMPLETO" Value="1" />
                    <dx:ListEditItem Text="GENERAL" Value="2" />                
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
    <tr id="trMostrarPor01" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="MOSTRAR POR">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxMostrarPor01" ValueType="System.String" runat="server" Theme="Office2010Blue" Width="180px" >
                <Items>
                    <dx:ListEditItem Text="TODO" Value="TODO" Selected="true" />
                    <dx:ListEditItem Text="ROZA DIARIA" Value="ROZA DIARIA" />                                    
                    <dx:ListEditItem Text="SALDOS QUEMA" Value="SALDOS QUEMA" />   
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
    <tr id="trMostrarPor02" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="MOSTRAR POR">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxMostrarPor02" ValueType="System.String" runat="server" Theme="Office2010Blue" Width="180px" >
                <Items>
                    <dx:ListEditItem Text="TODO" Value="TODO" Selected="true" />
                    <dx:ListEditItem Text="ROZA DIARIA" Value="ROZA DIARIA" />                                    
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
    <tr id="trMostrarPor03" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="MOSTRAR POR">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxMostrarPor03" ValueType="System.String" runat="server" Theme="Office2010Blue" Width="180px" >
                <Items>
                    <dx:ListEditItem Text="TODO" Value="TODO" Selected="true"  />
                    <dx:ListEditItem Text="MOLIDA DIARIA" Value="MOLIDA DIARIA" />                
                    <dx:ListEditItem Text="INVENTARIO TOTAL" Value="INVENTARIO TOTAL" />                
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
    <tr id="trMostrarPor04" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="MOSTRAR POR:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxMostrarPor04" ValueType="System.String" runat="server" Theme="Office2010Blue" Width="230px" >
                <Items>
                    <dx:ListEditItem Text="TODO" Value="TODO" Selected="true" />
                    <dx:ListEditItem Text="ESTICAÑA SALDO MOLIENDA" Value="ESTICAÑA SALDO MOLIENDA" />
                    <dx:ListEditItem Text="ESTICAÑA SALDO POR ROZAR" Value="ESTICAÑA SALDO POR ROZAR" />                
                    <dx:ListEditItem Text="INVENTARIO CAÑA PIE Y ROZADA" Value="INVENTARIO CAÑA PIE Y ROZADA" />                
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
</table>
 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>
 <asp:ObjectDataSource ID="odsZonas" runat="server" TypeName="SISPACAL.BL.cZONAS" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="DESCRIP_ZONA" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>
  <asp:ObjectDataSource ID="odsSubZonas" runat="server" TypeName="SISPACAL.BL.cSUB_ZONAS" SelectMethod="Recuperar" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
      <asp:ControlParameter ControlID="cbxZONA" Name="ZONA" PropertyName="Value" Type="String" />
     <asp:Parameter Name="agregarVacio" DefaultValue="true" Type="Boolean" />
     <asp:Parameter Name="agregarTodos" DefaultValue="false" Type="Boolean" />
  </SelectParameters> 
  </asp:ObjectDataSource>
  <asp:ObjectDataSource ID="odsCenso" runat="server" 
    TypeName="SISPACAL.BL.cCENSO" SelectMethod="ObtenerListaPorZAFRA" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
      <asp:ControlParameter ControlID="cbxZAFRA" Name="ID_ZAFRA" PropertyName="Value" 
          Type="Int32" />
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="recuperarForaneas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="FECHA_CENSO" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>

  <asp:ObjectDataSource ID="odsDepartamento" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cMUNICIPIO">
    <SelectParameters>      
        <asp:ControlParameter ControlID="cbxDEPARTAMENTO" Name="CODI_DEPTO" PropertyName="Value" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCanton" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cCANTON">
    <SelectParameters>   
        <asp:ControlParameter ControlID="cbxDEPARTAMENTO" Name="CODI_DEPTO" PropertyName="Value" Type="String" />
        <asp:ControlParameter ControlID="cbxMUNICIPIO" Name="CODI_MUNI" PropertyName="Value" Type="String" /> 
        <asp:Parameter Name="agregarVacio" Type="Boolean" DefaultValue="True" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsVariedad" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cVARIEDAD">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIVARIEDA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>