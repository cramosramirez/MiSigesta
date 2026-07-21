<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosQuerqueoInjiboaRela.ascx.vb" Inherits="controlesCenso_ucCriteriosQuerqueoInjiboaRela" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

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
    </tr>
    <tr id="trPERIODO" runat="server" visible="false">
         <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="PERIODO:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxPERIODO" AutoPostBack="true" ValueType="System.Int32" runat="server" 
                Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="FECHAS" Value="1" />
                    <dx:ListEditItem Text="ACUMULADO A LA FECHA" Value="2" />                
                    <dx:ListEditItem Text="TODOS LOS CORTES" Value="3" /> 
                    <dx:ListEditItem Text="POR CORTE" Value="4" /> 
                </Items>
            </dx:ASPxComboBox>           
        </th>
        <td>
            <table>
                <tr id="trPERIODO_CORTE" runat="server" visible="false">
                    <td>
                        <dx:ASPxComboBox ID="cbxPeriodoCorte" AutoPostBack="true" ValueType="System.Int32" ValueField="ID_CATORCENA" TextField="CATORCENA" runat="server" Theme="Office2010Blue" Width="80px" >                                                    
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
                <tr id="trPERIODO_DIAS_ZAFRA" runat="server" visible="false">
                    <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="DEL:" /></td>
                    <td>
                        <dx:ASPxComboBox ID="cbxDIA_ZAFRA1" runat="server" ValueType="System.Int32"  
                            ValueField="ID_DIA_ZAFRA" TextField="DESCRIPCION_DIA" Theme="Office2010Blue" Width="140px" >               
                        </dx:ASPxComboBox>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="AL:" /></td>
                    <td>
                        <dx:ASPxComboBox ID="cbxDIA_ZAFRA2" runat="server" ValueType="System.Int32"  
                            ValueField="ID_DIA_ZAFRA" TextField="DESCRIPCION_DIA" Theme="Office2010Blue" Width="140px" >               
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="trPRODUCTOR" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="PRODUCTORES:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxPRODUCTOR" AutoPostBack="true" ValueType="System.String" runat="server" 
                Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="JUAN DIAZ" Value="0142870000" />
                    <dx:ListEditItem Text="AZDIA" Value="0145300000" />                
                    <dx:ListEditItem Text="INJIBOA" Value="0140150000" />
                    <dx:ListEditItem Text="GARDIA" Value="0150380000" />
                </Items>
            </dx:ASPxComboBox>           
        </th>
        <td>
            <table>
                <tr>
                    <td>
                        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="FRENTES:" />           
                    </td>
                    <td>
                        <dx:ASPxComboBox ID="cbxTIPO_FRENTE" AutoPostBack="true" ValueType="System.Int32" runat="server" 
                            Theme="Office2010Blue" Width="220px" >                            
                        </dx:ASPxComboBox>    
                    </td>
                    <td>
                        <table>
                               <tr id="trPROVEEDOR_QUERQUEO_PARTI" runat="server" visible="false">
                                   <td>
                                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="FRENTE DE QUERQUEO:" />           
                                   </td>
                                   <td>
                                        <dx:ASPxComboBox ID="cbxPROVEEDOR_QUERQUEO" ValueType="System.Int32" runat="server" 
                                             TextField="NOMBRES" ValueField="ID_PROVEE_QQ"
                                            Theme="Office2010Blue" Width="320px" >                                             
                                        </dx:ASPxComboBox>    
                                   </td>
                               </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="trTIPO_PRODUCTOR" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="TIPO DE PRODUCTOR:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxTIPO_PRODUCTOR" ValueType="System.String" runat="server" 
                Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="TOTAL PRODUCTORES" Value="1" />
                    <dx:ListEditItem Text="PRODUCTORES EXTERNOS" Value="2" />                
                    <dx:ListEditItem Text="INJIBOA, S.A. DE C.V. - GRUPO JD" Value="3" /> 
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>
    <tr id="trTIPO_PRODUCTOR2" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="PRODUCTORES:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2">
            <dx:ASPxComboBox ID="cbxTIPO_PRODUCTOR2" ValueType="System.String" runat="server" DropDownStyle="DropDownList" 
                Theme="Office2010Blue" Width="220px" >
                <Items>
                    <dx:ListEditItem Text="PRODUCTORES EXTERNOS" Selected="true" Value="PRODUCTORES EXTERNOS" /> 
                    <dx:ListEditItem Text="TODOS LOS PRODUCTORES" Value="TODOS LOS PRODUCTORES" />                    
                </Items>
            </dx:ASPxComboBox>           
        </th>
    </tr>   
    <tr id="trDETALLE_POR_PAGINA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="DETALLE POR PAGINA:">
            </dx:ASPxLabel>
        </td>
        <th colspan="2" style="text-align: left">
            <dx:ASPxCheckBox ID="chkDetallePorPagina" runat="server" />                            
        </th>
        <td>
            <table runat="server" id="tblAGRUPAR_LOTE" visible="false">
                <tr>                    
                    <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="AGRUPAR POR LOTE:" /></td>
                    <td><dx:ASPxCheckBox ID="chkAgruparLote" runat="server" /></td>
                </tr>
            </table> 
        </td>
    </tr>
</table>

<asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
</asp:ObjectDataSource>