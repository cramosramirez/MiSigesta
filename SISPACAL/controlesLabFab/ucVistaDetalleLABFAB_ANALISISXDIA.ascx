<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleLABFAB_ANALISISXDIA.ascx.vb" Inherits="controles_ucVistaDetalleLABFAB_ANALISISXDIA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaLABFAB_VARSXANALISIS" Src="~/controlesLabFab/ucListaLABFAB_VARSXANALISIS.ascx" %>

<center>
<TABLE id="VistaDetalle" border="0">
    <TR runat="server" id="trID_ANALISIS" visible="false" >
		<TD width="10"></TD>
		<TD><dx:ASPxLabel CssClass="Normal" id="lblID_ANALISIS" 
                runat="server" Text="Id analisis x Dia:"></dx:ASPxLabel></TD>
		<TD align="left">
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ANALISISXDIA" 
                runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>

    <TR runat="server" id="trZAFRA">
		<TD width="10"></TD>
		<TD><dx:ASPxLabel CssClass="Normal" id="ASPxLabel3" runat="server" Text="Zafra:"></dx:ASPxLabel></TD>
		<TD>
		    <dx:ASPxComboBox ID="cbxZAFRA" DropDownStyle="DropDownList" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="150px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Zafra es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>	
        </TD>				
		<TD style="width:140px" ><dx:ASPxLabel CssClass="Normal" id="ASPxLabel4" runat="server" Text="Día Zafra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="speDIAZAFRA" runat="server" HorizontalAlign="Right" Width="80px" Number="0" NumberType="Integer">			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
			</dx:ASPxSpinEdit>	
        </TD>
		<TD width="10"></TD>
	</TR>	

    <TR runat="server" id="trID_ETAPA">
		<TD width="10"></TD>
		<TD ><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Etapa:"></dx:ASPxLabel></TD>
		<TD>
		    <dx:ASPxComboBox ID="cbxLABFAB_ETAPA" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" DataSourceID="odsLABFAB_ETAPA" ValueField="ID_ETAPA" TextField="NOMBRE_ETAPA" ValueType="System.Int32" Width="260px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Etapa es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>	
        </TD>				
		<TD><dx:ASPxLabel CssClass="Normal" id="ASPxLabel2" runat="server" Text="Muestra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxLABFAB_MUESTRA" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" ValueField="ID_MUESTRA" TextField="NOMBRE_MUESTRA" ValueType="System.Int32" Width="350px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Muestra es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>	
        </TD>
		<TD width="10"></TD>
	</TR>	
	<TR runat="server" id="trNOMBRE_ANALISIS">
		<TD width="10"></TD>
		<TD><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_ANALISIS" runat="server" Text="Análisis:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxLABFAB_ANALISIS" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" ValueField="ID_ANALISIS" TextField="NOMBRE_ANALISIS" ValueType="System.Int32" Width="260px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Muestra es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>
        </TD>				
		<TD><dx:ASPxLabel CssClass="Normal" id="lblFORMULA" runat="server" Text="N° de Análisis del Día:"></dx:ASPxLabel></TD>
		<TD>    
            <dx:ASPxTextBox ID="txtNO_ANALISIS"  runat="server" HorizontalAlign="Right" Width="80px" >	
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>	
            </dx:ASPxTextBox>	    			
        </TD>
		<TD width="10"></TD>
	</TR>	
	<TR runat="server" id="trVALOR">    
		<TD width="10"></TD>
		<TD><dx:ASPxLabel CssClass="Normal" id="lblVALOR" runat="server" Text="Valor:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtVALOR" runat="server" Width="150px" HorizontalAlign="Right" NumberType="Float">
			   <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
			</dx:ASPxSpinEdit>
        </TD>
		<TD width="10"></TD>
	</TR>	
</TABLE>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<br />
<uc1:ucListaLABFAB_VARSXANALISIS id="ucListaLABFAB_VARSXANALISIS1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false" PermitirEliminarInline="false"  runat="server"></uc1:ucListaLABFAB_VARSXANALISIS>                                    
</center>


<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLABFAB_ETAPA" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cLABFAB_ETAPA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_ETAPA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>