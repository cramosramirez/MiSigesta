<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleLABFAB_INFOVARSXDIA.ascx.vb" Inherits="controles_ucVistaDetalleLABFAB_INFOVARSXDIA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaLABFAB_INFOVARSXDIA" Src="~/controlesLabFab/ucListaLABFAB_INFOVARSXDIA.ascx" %>

<center>
<TABLE id="VistaDetalle" border="0">
    <TR runat="server" id="trID_ANALISIS" visible="false" >
		<TD width="10"></TD>
		<TD><dx:ASPxLabel CssClass="Normal" id="lblID_INFO" 
                runat="server" Text="Id analisis x Dia:"></dx:ASPxLabel></TD>
		<TD align="left">
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_INFO" 
                runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>

    <TR runat="server" id="trZAFRA">
		<TD width="10"></TD>
		<TD><dx:ASPxLabel CssClass="Normal" id="ASPxLabel3" runat="server" Text="Zafra:"></dx:ASPxLabel></TD>
		<TD align="left">
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

    <TR runat="server" id="trID_INFORME">
		<TD width="10"></TD>
		<TD ><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Informe:"></dx:ASPxLabel></TD>
		<TD>
		    <dx:ASPxComboBox ID="cbxLABFAB_INFORME" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" DataSourceID="odsLABFAB_INFORME" ValueField="ID_INFO" TextField="NOMBRE_INFO" ValueType="System.Int32" Width="260px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Informe es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>	
        </TD>
    </TR>
</TABLE>

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<br />
<uc1:ucListaLABFAB_INFOVARSXDIA id="ucListaLABFAB_INFOVARSXDIA1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false" PermitirEliminarInline="false"  runat="server"></uc1:ucListaLABFAB_INFOVARSXDIA>                                    
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

<asp:ObjectDataSource ID="odsLABFAB_INFORME" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cLABFAB_INFORME">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_INFO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>