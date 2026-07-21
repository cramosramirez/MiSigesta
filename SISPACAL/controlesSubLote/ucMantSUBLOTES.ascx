<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSUBLOTES.ascx.vb" Inherits="controlesSubLote_ucMantSUBLOTES" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSUBLOTES" Src="~/controlesSubLote/ucListaSUBLOTES.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<style>
    .container {
        display: flex;
        flex-direction: column;
        justify-content: center; /* Centra horizontalmente */            
        border: 1px solid #ccc; /* Para ver los bordes del div contenedor */
    }
    .centered-div {
        padding: 10px;
        background-color: #c2e7fc;
        border: 2px solid silver; /* Borde del div centrado para visualizar */
        text-align: center; /* Centrar texto dentro del div */
        margin-bottom: 5px; /* Espacio debajo del div */        
        border-radius: 8px; /* Bordes redondeados */
    }
    .centered-div span {
        font-size: 18px; /* Tamaño del texto */
        font-weight: bold; /* Negrita */
        color: #235470; /* Color del texto */
        font-family:'Arial'; 
     }
    .custom-table {
        border-collapse: collapse;
        margin-left: 30px; /* Espacio izquierda */
        margin-right: 30px; /* Espacio derecha */
    }
    .label{
        font-size: 12px 
    }
    .labelmaestro{       
        font-size: 18px 
    }
    .labeltd {
        padding: 15px;
        text-align: left;
        width: 160px;        
    }
    .entrada {       
        text-align: left;
        width: 250px;        
    }    
</style>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<div class="container">
    <div class="centered-div">
            <span>REGISTRO DE PORCIONES DE LOTE</span>            
    </div>
    <table class="custom-table" border ="0" with="100%"> 
        <tr>                   
            <td>
                <dx:ASPxTextBox ID="NOMBRE_MAESTRO" CssClass="labelmaestro" HorizontalAlign="Center"  runat="server" Width="100%" Theme="MetropolisBlue" ClientEnabled="false"  >                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" Font-Bold="true" ></DisabledStyle>                                                                
                </dx:ASPxTextBox>
            </td>
        </tr>
    </table>
    <br />
    <table id="frmVistaSUBLOTES" runat="server" class="custom-table" border ="0" with="100%">        
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel1" runat="server" CssClass="label"  Text="Código:" />
            </td>
            <td class="entrada">
                <dx:ASPxTextBox ID="CODIGOtxt" runat="server" Width="100%" Theme="Moderno" ClientEnabled="false"  >                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" Font-Bold="true"></DisabledStyle>                                                                
                </dx:ASPxTextBox>
            </td>
            
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel3" runat="server" CssClass="label" Text="Correlativo:" />
            </td>
            <td class="entrada">
                <dx:ASPxTextBox ID="CORRELATIVOtxt" runat="server" Width="100%" Theme="Moderno" ClientEnabled="false" >                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" Font-Bold="true"></DisabledStyle>                 
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel4" runat="server" CssClass="label" Text="Nombre porción:"  />
            </td>
            <th colspan="3" >
                <dx:ASPxTextBox ID="NOMBRE_PORCIONtxt" runat="server" Text="" Font-Bold="true" Width="100%" Theme="Moderno">                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" Font-Bold="true"></DisabledStyle>                         
                </dx:ASPxTextBox>
            </th>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel5" runat="server" CssClass="label" Text="Variedad:"  />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="CODIVARIEDAcbx" runat="server" DataSourceID="odsVARIEDAD" TextField="NOM_VARIEDAD" ValueField="CODIVARIEDA" TextFormatString="{1}" ValueType="System.String" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                    <Columns>
                        <dx:ListBoxColumn FieldName="CODIVARIEDA" Caption="CODIGO" Width="50px" />
                        <dx:ListBoxColumn FieldName="NOM_VARIEDAD" Caption="NOMBRE" Width="100%" />                        
                    </Columns>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>        
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel6" runat="server" CssClass="label" Text="Tipo siembra:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_TIPO_SIEMBRAcbx" runat="server" DataSourceID="odsTIPO_SIEMBRA" ValueField="ID_TIPO_SIEMBRA" TextField="NOMBRE_TIPO"  ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel7" runat="server" CssClass="label" Text="Fecha siembra:" />
            </td>
            <td class="entrada">
                <dx:ASPxDateEdit ID="FECHA_SIEMBRAdte" DisplayFormatString="dd/MM/yyyy" Theme="Moderno" EditFormat="Custom" AllowNull="true"   
                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100%">               
                </dx:ASPxDateEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel8" runat="server" CssClass="label" Text="Distanciamiento:" />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="DISTANCIAMIENTOspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel9" runat="server" CssClass="label" Text="Ciclo:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="CICLOspin" runat="server" DisplayFormatString="#,##0" DecimalPlaces="0" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel10" runat="server" CssClass="label" Text="Zona ramsar:"  />
            </td>
            <td class="entrada">
                <dx:ASPxCheckBox ID="ZONA_RAMSARchk" runat="server" Theme="Moderno"  />
            </td>
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel11" runat="server" CssClass="label" Text="Longitud:"  />
            </td>
            <td class="entrada">
                <dx:ASPxTextBox ID="LONGITUDtxt" runat="server" Width="100%" Theme="Moderno">                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                </dx:ASPxTextBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel12" runat="server" CssClass="label" Text="Latitud:"  />
            </td>
            <td class="entrada">
                <dx:ASPxTextBox ID="LATITUDtxt" runat="server" Width="100%" Theme="Moderno">                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                </dx:ASPxTextBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel13" runat="server" CssClass="label" Text="Altitud:"  />
            </td>
            <td class="entrada">
                <dx:ASPxTextBox ID="ALTITUDtxt" runat="server" Width="100%" Theme="Moderno">                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel15" runat="server" CssClass="label" Text="Tipo de suelo:"  />
            </td>
            <th class="entrada" colspan="5" >
                <dx:ASPxComboBox ID="ID_TIPOSUELOcbx" runat="server" DataSourceID="odsTIPOSUELO" TextField="NOMBRE_TIPO_SUELO" ValueField="ID_TIPO_SUELO" ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </th>
           
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel17" runat="server" CssClass="label" Text="Riesgo piedra:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_RIESGO_PIEDRAcbx" runat="server" DataSourceID="odsRIESGO_PIEDRA" TextField="NOMBRE_RIESGO_PIEDRA" ValueField="ID_RIESGO_PIEDRA" ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel18" runat="server" CssClass="label" Text="Estrato:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_ESTRATOcbx" runat="server" DataSourceID="odsESTRATO" TextField="NOMBRE_ESTRATO" ValueField="ID_ESTRATO"  ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel19" runat="server" CssClass="label" Text="Topografia:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_TOPOGRAFIAcbx" runat="server" DataSourceID="odsTOPOGRAFIA" TextField="NOMBRE_TOPOGRAFIA" ValueField="ID_TOPOGRAFIA" ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel20" runat="server" CssClass="label" Text="Viabilidad de riego:"  />
            </td>
            <td class="entrada">
                <dx:ASPxCheckBox ID="VIABILIDAD_RIEGOchk" runat="server" Theme="Moderno"  />
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel21" runat="server" CssClass="label" Text="Area Contrato:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="AREA_CONTRATOspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel2" runat="server" CssClass="label" Text="Area Productiva:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="AREA_PRODUCTIVAspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>           
        </tr>
        <tr>           
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel24" runat="server" CssClass="label" Text="Area Efectiva:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="AREA_EFECspin" runat="server" AutoPostBack="true" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
             <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel25" runat="server" CssClass="label" Text="TM/HA Efectiva:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="TC_MZ_EFECspin" runat="server" AutoPostBack="true" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel26" runat="server" CssClass="label" Text="TM Efectiva:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="TC_EFECspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
        </tr>
        <tr>            
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel27" runat="server" CssClass="label" Text="Uso Madurante:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_USO_MADcbx" runat="server" DataSourceID="odsUSO_MADURANTE" TextField="NOMBRE_USO_MAD" ValueField="ID_USO_MAD" ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel28" runat="server" CssClass="label" Text="Tipo de caña:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_TIPOcbx" runat="server" DataSourceID="odsTIPO" TextField="NOM_TIPO" ValueField="ID_TIPO" ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
             <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel29" runat="server" CssClass="label" Text="Potencial Cosecha-Meca.:"  />
            </td>
            <td class="entrada">
                <dx:ASPxCheckBox ID="POTENCIAL_COSECHA_MECAchk" runat="server" Theme="Moderno"  />
            </td>
        </tr>
        <tr>           
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel30" runat="server" CssClass="label" Text="Tipo Quema:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="TIPO_QUEMAcbx" runat="server" ValueType="System.String" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" > 
                    <Items>
                        <dx:ListEditItem Text="QUEMADO" Value="Q" />
                        <dx:ListEditItem Text="VERDE" Value="V" />
                    </Items>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel31" runat="server" CssClass="label" Text="Tipo transporte VMT:" />
            </td>
            <td class="entrada">
                <dx:ASPxComboBox ID="ID_TIPO_TRANS_VMTcbx" runat="server" DataSourceID="odsTIPO_TRANS_VMT" TextField="NOMBRE_TIPO_TRANS_VMT" ValueField="ID_TIPO_TRANS_VMT" ValueType="System.Int32" Width="100%" Theme="Moderno" DropDownStyle="DropDownList" >                                                        
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                </dx:ASPxComboBox>
            </td>
             <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel16" runat="server" CssClass="label" Text="Lote cerrado:"  />
            </td>
            <td class="entrada">
                <dx:ASPxCheckBox ID="ES_CERRADOchk" runat="server" Theme="Moderno"  />
            </td>
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel32" runat="server" CssClass="label" Text="Circuito:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="CIRCUITOspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel33" runat="server" CssClass="label" Text="Tarifa:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="TARIFAspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel34" runat="server" CssClass="label" Text="Carretera principal:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="CARRET_PPALspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
        </tr>
        <tr>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel35" runat="server" CssClass="label" Text="Carretera secundaria:"  />
            </td>
            <td class="entrada">
                <dx:ASPxSpinEdit ID="CARRET_SECspin" runat="server" DisplayFormatString="#,##0.00##" Width="100%" HorizontalAlign="Right" Theme="Moderno" >	
                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			    </dx:ASPxSpinEdit>
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel36" runat="server" CssClass="label" Text="Repara acceso:"  />
            </td>
            <td class="entrada">
                <dx:ASPxCheckBox ID="REPARA_ACCESOchk" runat="server" Theme="Moderno"  />
            </td>
            <td class="labeltd" >
                <dx:ASPxLabel id="ASPxLabel14" runat="server" CssClass="label" Text="Fecha cosecha:" />
            </td>
            <td class="entrada">
                <dx:ASPxDateEdit ID="FECHA_COSECHAdte" DisplayFormatString="dd/MM/yyyy" Theme="Moderno" EditFormat="Custom" AllowNull="true"   
                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100%">               
                </dx:ASPxDateEdit>
            </td>
        </tr>
    </table>
    <uc1:ucListaSUBLOTES id="ucListaSUBLOTES1" runat="server" PermitirEditar="true" ></uc1:ucListaSUBLOTES>
</div> 

<asp:ObjectDataSource ID="odsVARIEDAD" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cVARIEDAD">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTIPO_SIEMBRA" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_SIEMBRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsRIESGO_PIEDRA" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cRIESGO_PIEDRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsESTRATO" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cESTRATO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTOPOGRAFIA" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTOPOGRAFIA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsUSO_MADURANTE" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cUSO_MADURANTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTIPOSUELO" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPOSUELO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTIPO_TRANS_VMT" runat="server" 
     SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_TRANS_VMT">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTIPO" runat="server" 
     SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES">  
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_TIPO" Type="Int32" />
        <asp:Parameter DefaultValue="15" Name="ID_TIPO_TABLA" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_TIPO_PADRE" Type="Int32" />
        
    </SelectParameters>
</asp:ObjectDataSource>