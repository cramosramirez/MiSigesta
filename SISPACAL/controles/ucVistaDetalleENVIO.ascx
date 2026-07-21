<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleENVIO.ascx.vb" Inherits="controles_ucVistaDetalleENVIO" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>--%>
<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
    }
    .formato2
    {
        padding-right: 10px;
        margin-left: 80px;
        width: 170px;
    }
    div.centraTabla
    {
        font-size: small;     
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 15px; 
        padding-top: 10px;
        padding-left: 15px;
        padding-right: 15px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }  
      .seccion
    {
        background-color: #003366;
        color: White;  
        font-weight: bold;
        border: 2px;      
        text-align: center;  
        height: 20px; 
    }
</style>
<script language="javascript" type="text/javascript" >
    function abrirAppLaboratorio() {
        var taco = document.getElementById("<%=txtNROBOLETA.ClientID%>").value;
        alert(taco);
        var shell = new ActiveXObject("Wscript.shell");
        shell.run("c:\\zafra\\Zafrap\\acceso.exe");
    }
</script>       

<div class="centraTabla">    
    <table cellspacing="0" cellpadding="0" border="0">
        <tr id="trAnulacion" runat="server" visible="false">
            <th colspan="8" align="center" >
                <asp:Label id="lblMENSAJE_INFO" Font-Bold="true" Font-Size="Medium" Font-Names="Verdana" ForeColor="Red" runat="server"></asp:Label>
            </th>
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="lblID_ENVIO" runat="server">ID:</asp:Label></td>
            <td class="formato1">
                <asp:TextBox CssClass="TextoDerecha" id="txtID_ENVIO" 
                    runat="server" ReadOnly="True" Width="120px"></asp:Textbox></td>
            <td><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
            <td class="formato1"><cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" AutoPostBack="true" runat="server" CssClass="DDLClassNormal"  
                     Width="104px"></cc1:ddlZAFRA></td>
            <td><asp:Label  id="lblID_CATORCENA" CssClass="Normal" runat="server">CATORCENA:</asp:Label></td>
            <td class="formato1"><asp:TextBox CssClass="TextoDerecha" id="txtCATORCENA_ZAFRA" ReadOnly="True" runat="server" Width="100px" /></td>
            <td><asp:Label id="lblDIAZAFRA" CssClass="Normal" runat="server">DIA ZAFRA:</asp:Label></td>
            <td class="formato2"><asp:TextBox CssClass="TextoDerecha" id="txtDIAZAFRA" ReadOnly="True" runat="server" Width="100px"></asp:TextBox></td>            
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="lblNROBOLETA" runat="server">N° TACO:</asp:Label></td>
            <td class="formato1"><asp:TextBox CssClass="TextoNormalDerecha" id="txtNROBOLETA" AutoPostBack="true"  
                    runat="server" Width="120px"></asp:TextBox></td>
            <td><asp:Label CssClass="Normal" id="lblCOMPTENVIO" runat="server">N° ENVIO:</asp:Label></td>
		    <td class="formato1"><asp:TextBox  CssClass="TextoNormalDerecha" id="txtCOMPTENVIO" runat="server" Width="100px" AutoPostBack="true" ></asp:TextBox></td>
            <td><asp:Label CssClass="Normal" id="lblCONTRATO" runat="server">CONTRATO:</asp:Label></td>
		    <td class="formato1"><asp:TextBox CssClass="TextoNormalDerecha" id="txtCODICONTRATO" AutoPostBack="true" runat="server" Width="100px"></asp:TextBox></td>
            <th colspan="2">
            <asp:Label CssClass="TextoNormalIzquierda" id="lblOtrosContratos" runat="server"></asp:Label>
            </th>            
        </tr>                            
        <tr>
            <td><asp:Label CssClass="Normal" id="Label1" runat="server">PROVEEDOR:</asp:Label></td>
            <td class="formato1">
                <asp:TextBox id="txtCODIPROVEEDOR" runat="server" CssClass="NormalTextBox" ReadOnly="true" Width="120px"></asp:TextBox></td>
            <th colspan="6" class="formato1"><asp:TextBox id="txtNOMPROVEEDOR" runat="server" CssClass="NormalTextBox"  
                    Width="100%" ReadOnly="True"></asp:TextBox>          
            </th>            
        </tr>        
        <tr>        
            <th colspan="8" align="center">
                <asp:Label CssClass="Normal" id="Label6" runat="server">SELECCIONE UN LOTE DEL LISTADO</asp:Label>
               <asp:Panel ID="Panel1" runat="server" Width="100%" Height="110px" 
                    ScrollBars="Auto" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px">                    
                    <asp:GridView ID="grdLotes" runat="server" AutoGenerateColumns="False" Width="100%"  
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                        CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="11px"
                        DataKeyNames="ACCESLOTE" >
                        <Columns>  
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>                                                                        
                                    <asp:RadioButton ID="rbtnSeleccionar" AutoPostBack="true" runat="server" OnCheckedChanged="rbtnSeleccionar_CheckedChanged"  />
                                    <asp:Label id="lblACCESLOTE" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ACCESLOTE") %>' />                                                                     
                                </ItemTemplate>
                            </asp:TemplateField>                                                                                                                                                         
                            <asp:BoundField DataField="CODILOTE" HeaderText="Codigo" ReadOnly="True" />
                            <asp:BoundField DataField="NOMBLOTE" HeaderText="Nombre" ReadOnly="True" />
                            <asp:TemplateField HeaderText="Ubicacion" >
                                <ItemTemplate>                                    
                                    <asp:Label id="lblUBICACION" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>  
                            <asp:TemplateField HeaderText="Variedad" >
                                <ItemTemplate>                                    
                                    <asp:Label id="lblVARIEDAD" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>  
                             <asp:TemplateField HeaderText="Agronomo" >
                                <ItemTemplate>                                    
                                    <asp:Label id="lblAGRONOMO" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>                             
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    </asp:GridView>
                </asp:Panel>                                
			    <asp:CheckBox id="cbxQUEMAPROG" runat="server"  CssClass="Normal" Text="QUEMA PROGRAMADA" 
                    Font-Bold="False"></asp:CheckBox> 
            &nbsp;&nbsp;&nbsp;<asp:CheckBox id="cbxMADURANTE"  CssClass="Normal" runat="server" Text="MADURANTE" 
                    Font-Bold="False"></asp:CheckBox>            
            &nbsp;&nbsp;&nbsp;<asp:CheckBox id="chkTRANSPORTE_PROPIO"  CssClass="Normal" runat="server" Text="TRANSPORTE PROPIO" 
                    Font-Bold="False"></asp:CheckBox></th>            
        </tr> 
        <tr>
            <td><asp:Label CssClass="Normal" id="Label2" runat="server">CODIGO TRANSPORT.:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha"  
                    id="txtCODTRANSPORT" runat="server" AutoPostBack="true" Width="120px" ></asp:TextBox>
            </td>
            <th colspan="4" class="formato1">
                <asp:TextBox id="txtNOMBRE_TRANSPORTISTA" runat="server" CssClass="NormalTextBox" 
                    Width="100%" ReadOnly="True"></asp:TextBox></th>
            <td><asp:Label CssClass="Normal" id="Label4" runat="server">PLACA:</asp:Label></td>
            <td class="formato1">
                 <asp:TextBox id="txtPLACA_VEHIC" runat="server" CssClass="TextoNormalIzquierdaMayus" AutoPostBack="true"  
                    Width="100%" ></asp:TextBox>                                  
                <asp:Panel ID="panelPLACAS" runat="server" Width="175px" >
                    <asp:ListBox ID="lstTRANSPORTE" runat="server" CssClass="DDLClass" 
                        DataTextField="PLACA" DataValueField="PLACA"   
                        AutoPostBack="true" Width="175px"></asp:ListBox>                    
                </asp:Panel>                                           
            </td>            
        </tr>      
        <tr>            
            <td>
			    <asp:Label CssClass="Normal" id="lblMOTORISTA" runat="server">MOTORISTA:</asp:Label>
            </td>               
            <th colspan="5" class="formato1" >                                 
                 <asp:TextBox id="txtNOMBRES_MOTORISTA" runat="server" CssClass="TextoNormalIzquierdaMayus" AutoPostBack="true"  
                    Width="100%"></asp:TextBox>  
                 
                 <asp:Panel ID="panelMOTORISTA" runat="server" Width="560px" >
                    <asp:ListBox ID="lstMOTORISTA" runat="server" CssClass="DDLClass" 
                        DataTextField="NOMBRE_COMPLETO" DataValueField="NOMBRE_COMPLETO"   
                        AutoPostBack="true" Width="560px"></asp:ListBox>                    
                </asp:Panel> 
            </th>                        
            <td><asp:Label CssClass="Normal" id="lblID_TIPOTRANS" runat="server">TIPO TRANSPORTE:</asp:Label></td>
            <td class="formato1">
                <cc1:ddlTIPO_TRANSPORTE Width="100%" ID="ddlTIPO_TRANSPORTE1" runat="server" CssClass="DDLClass" >
                </cc1:ddlTIPO_TRANSPORTE>
            </td>            
        </tr>       
        <tr>
            <td><asp:Label CssClass="Normal" id="Label3" runat="server">CODIGO CARGADORA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtID_CARGADORA" runat="server" AutoPostBack="true" 
                    Width="120px" /></td>
            <th colspan="2" style="text-align:left" >
                <asp:TextBox CssClass="NormalTextBox"
                    id="txtNOMBRE_CARGADORA" runat="server" ReadOnly="True" Width="205px" />
            </th>
            <td><asp:Label CssClass="Normal" id="Label9" runat="server">TIPO CARGA:</asp:Label></td>
            <td class="formato1"><asp:DropDownList ID="ddlTipoTarifaCargadora" CssClass="DDLClass" runat="server" Width="100%"></asp:DropDownList></td>
            <td><asp:Label CssClass="Normal" id="Label5" runat="server">CARGADOR:</asp:Label></td>
            <td class="formato1"> 
                <table width="100%">
                    <tr>                    
                        <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtID_CARGADOR" runat="server" AutoPostBack="true" Width="40px" /></td>
                        <td><asp:TextBox CssClass="NormalTextBox" id="txtNOMBRE_CARGADOR" runat="server" ReadOnly="True" Width="200px" /></td>
                    </tr>
                </table>
            </td>            
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="lblID_TIPO_CANA" runat="server">TIPO CAÑA:</asp:Label></td>
            <td><cc1:ddlTIPO_CANA id="ddlTIPO_CANAID_TIPO_CANA" runat="server"  AutoPostBack="True" 
                    CssClass="DDLClass" Width="125px"></cc1:ddlTIPO_CANA></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="lblID_SUPERVISOR" runat="server">SUPERVISOR:</asp:Label></td>
            <th colspan="3" class="formato1">
			    <cc1:ddlSUPERVISOR id="ddlSUPERVISORID_SUPERVISOR" runat="server" CssClass="DDLClass" Width="100%"  ></cc1:ddlSUPERVISOR>
            </th>            
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="lblFECHA_QUEMA" runat="server">FECHA QUEMA:</asp:Label></td>
            <td>
                <asp:TextBox ID="txtFECHA_QUEMA" CssClass="TextoNormalIzquierdaMayus" runat="server" AutoPostBack="true"></asp:TextBox>             
                
            </td>
            <td><asp:Label CssClass="Normal" id="lblFECHA_CORTA" runat="server">FECHA CORTA:</asp:Label></td>
            <td>
                <asp:TextBox ID="txtFECHA_CORTA" CssClass="TextoNormalIzquierdaMayus" AutoPostBack="True" runat="server"></asp:TextBox>
               
            </td>
            <td><asp:Label CssClass="Normal" id="lblFECHA_CARGA" runat="server">FECHA CARGA:</asp:Label></td>
            <td>
                <asp:TextBox ID="txtFECHA_CARGA" CssClass="TextoNormalIzquierdaMayus" runat="server"></asp:TextBox>
                
            </td>
            <td><asp:Label CssClass="Normal" id="lblFECHA_PATIO" runat="server">FECHA PATIO:</asp:Label></td>
            <td class="formato1">
                <asp:TextBox ID="txtFECHA_PATIO" CssClass="TextoNormalIzquierdaMayus" runat="server"></asp:TextBox>
                
            </td>            
        </tr>
        <tr>
            <th colspan="9"><hr /></th>
        </tr>
        </table>
        <div class="ContenedorCampos">
            <table>
            <tr>            
                <th colspan="9">                
                    <asp:Label CssClass="NormalBold" id="Label21" runat="server">SERVICIO DE ROZA DE CAÑA</asp:Label>                
                </th>            
            </tr>
            <tr>
                <th colspan="2" style="padding-right:10px">
                    <asp:CheckBox id="chkSERVICIO_ROZA" runat="server" CssClass="Normal" 
                        Text="SERVICIO DE ROZA CONTRATADO" Font-Bold="False" AutoPostBack="True"></asp:CheckBox></th>            
                <td>&nbsp;</td>
                <td class="formato1"></td>
                <td><asp:Label CssClass="Normal" id="Label8" runat="server">PROVEEDOR DE ROZA:</asp:Label></td>
                <th colspan="3"><cc1:ddlPROVEEDOR_ROZA ID="ddlPROVEEDOR_ROZA1" runat="server" 
                        CssClass="DDLClass" Width="100%"></cc1:ddlPROVEEDOR_ROZA>
                </th>            
                <td></td>
            </tr>
            </table>    
        </div>
    <table> 
        <tr>
            <td>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREA" 
                runat="server" Width="100px" MaxLength="100" Visible="False"></asp:TextBox>
            </td>
            <td>
			<asp:TextBox id="txtFECHA_CREA" runat="server" Width="80px" 
                CssClass="TextoNormalCentrado" Visible="False"></asp:TextBox>
            </td>   
        </tr>      				
    </table> 
</div>