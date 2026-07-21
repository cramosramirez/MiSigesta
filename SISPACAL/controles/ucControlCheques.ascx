<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucControlCheques.ascx.vb" Inherits="controles_ucControlCheques" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>

 <script type = "text/javascript">
     function MostrarEmisionCheques(valor) {
         window.open("../Reportes/wfReporteModalCatorcena.aspx?n=17&idgen=" + valor, "_blank", "")
     }
     function MostrarEmisionChequesAnticipo(valor) {
         window.open("../Reportes/wfReporteModalCatorcena.aspx?n=26&idgen=" + valor, "_blank", "")
     } 
</script>
<table>
    <tr>
        <td valign="top">
            <div class="ContenedorCamposOscuro" >
                    <asp:Label id="lblPaso1" class="NormalBold" runat="server">1. Seleccione la Planilla</asp:Label>
            </div>
            <div class="ContenedorCampos">
                <table>
                    <tr>
                        <td><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
                        <td><cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClassNormal" AutoPostBack="True"  
                                     Width="100px"></cc1:ddlZAFRA>
                        </td>
                        <td><asp:Label CssClass="Normal" id="Label7" runat="server">CATORCENA:</asp:Label></td>
                        <td>
                            <cc1:ddlCATORCENA_ZAFRA ID="ddlCATORCENA_ZAFRA1" runat="server" Width="100px" 
                                AutoPostBack="True">
                            </cc1:ddlCATORCENA_ZAFRA>
                        </td>
                    </tr>                                         
                    <tr>        
                        <td><asp:Label CssClass="Normal" id="Label9" runat="server">TIPO PLANILLA:</asp:Label></td>
                        <td>
                            <cc1:ddlTIPO_PLANILLA ID="ddlTIPO_PLANILLA1" runat="server" 
                                CssClass="DDLClassNormal" Width="300px" AutoPostBack="True">
                            </cc1:ddlTIPO_PLANILLA></td>
                        <th colspan="2">
                            <asp:RadioButtonList ID="rdbContribuyente" runat="server" CssClass="Normal"
                                RepeatDirection="Horizontal" AutoPostBack="True">
                                <asp:ListItem Value="-1" Selected="True">Todos</asp:ListItem>                
                                <asp:ListItem Value="1">Contribuyente</asp:ListItem>                
                                <asp:ListItem Value="0">No contribuyente</asp:ListItem>
                            </asp:RadioButtonList>
                        </th>
                    </tr>  
                    <tr runat="server" id="trRANGO_COMPENSACION" visible="false">
                        <td><asp:Label CssClass="Normal" id="Label1" runat="server">RANGO COMP.:</asp:Label></td>
                        <td>
                            <cc1:ddlRANGO_COMPENSACION ID="ddlRANGO_COMPENSACION1" runat="server" 
                                CssClass="DDLClassNormal" Width="300px">
                            </cc1:ddlRANGO_COMPENSACION></td>
                    </tr> 
                </table>
            </div>
        </td>
        <td valign="top">
            <div id="divChequera" runat="server">
                 <div class="ContenedorCamposOscuro" >
                        <asp:Label id="lblPaso2" class="NormalBold" runat="server">2. Elija la Chequera e ingrese el No. de Cheque inicial y  haga clic en Vista Previa</asp:Label>
                </div>
                <div class="ContenedorCampos">
                    <table>
                        <tr>
                            <td>
                                <asp:Label CssClass="Normal" id="Label3" runat="server">BANCO:</asp:Label>
                            </td>
                            <td>
                                <cc1:ddlBANCOS ID="ddlBANCOS1" Width="180px"  class="DDLClassNormal" runat="server" AutoPostBack="True">
                                </cc1:ddlBANCOS>
                            </td>
                            <td>
                                <asp:Label CssClass="Normal" id="Label4" runat="server">CUENTA:</asp:Label>
                            </td>
                            <td>
                                <cc1:ddlCUENTA_BANCARIA ID="ddlCUENTA_BANCARIA1" Width="120px"  class="DDLClassNormal" runat="server" AutoPostBack="True">
                                </cc1:ddlCUENTA_BANCARIA>
                            </td>
                        </tr>                    
                         <tr>
                            <td>
                                <asp:Label CssClass="Normal" id="Label5" runat="server">CHEQUERA:</asp:Label>
                            </td>
                            <td>
                                <cc1:ddlCHEQUERA_PLANILLA ID="ddlCHEQUERA_PLANILLA1"  class="DDLClassNormal" runat="server" Width="180px" >
                                </cc1:ddlCHEQUERA_PLANILLA>
                            </td>
                            <td>
                                <asp:Label CssClass="Normal" id="Label11" runat="server">N° de Cheque Inicial:</asp:Label>
                             </td>
                            <td><asp:TextBox ID="txtNO_CHEQUE_INICIAL_EMISION" CssClass="TextoDerechaNegrita" 
                                    runat="server" ></asp:TextBox>
                             </td>
                        </tr>
                    </table>
                </div>
            </div>
        </td>
    </tr>
</table>
    <div id="divTituloEmisionCheques" class="ContenedorCamposOscuro" runat="server" >
        <asp:Label id="lblTituloGeneracion" class="NormalBold" runat="server">3. Seleccione hasta que N° de Cheque emitirá: </asp:Label><asp:TextBox
            ID="txtNO_CHEQUE" CssClass="TextoDerechaNegrita" runat="server" ReadOnly="True"></asp:TextBox>
    </div> 
    <div id="divTituloAnulacionCheques" class="ContenedorCamposOscuro" runat="server" >
        <asp:Label id="Label6" class="NormalBold" runat="server">2. Indique el rango de N°'s de cheque que anulará: </asp:Label>
        <asp:Label id="Label10" class="NormalBold" runat="server" Text=" Del " />
        <asp:TextBox ID="txtNO_CHEQUE_INICIAL" CssClass="TextoDerecha" runat="server" />
        <asp:Label id="Label8" class="NormalBold" runat="server" Text=" al " />
        <asp:TextBox ID="txtNO_CHEQUE_FINAL" CssClass="TextoDerecha" runat="server" />
    </div> 
    <div class="ContenedorCampos">            
        <table width="100%">
            <tr>
                <td> 
                    <asp:Panel ID="Panel1" runat="server" Width="100%" Height="250px" 
                    ScrollBars="Auto" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="0px">   
                    <asp:GridView ID="grdCheques" runat="server" RowStyle-ForeColor="Black" 
                            AutoGenerateColumns="False" Width="100%" Font-Names="Arial" Font-Size="11px"
                        DataKeyNames="CODIPROVEEDOR_TRANSPORTISTA" BackColor="White" AllowPaging="True" 
                            PagerStyle-Font-Size="Small" PageSize="10" HorizontalAlign="Center" >                        
                        <Columns>                                                                                  
                           <asp:CommandField ButtonType="Image" SelectImageUrl="~/imagenes/play2.png" 
                                ShowSelectButton="True" HeaderStyle-BackColor="#CDE0FC" 
                                HeaderStyle-BorderColor="#999999" HeaderStyle-BorderStyle="Solid" 
                                HeaderStyle-BorderWidth="1px" HeaderStyle-ForeColor="Black" >
                            <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" Width="20px"  />
                            <ItemStyle HorizontalAlign="Center"  />
                            </asp:CommandField>
                            <asp:BoundField DataField="CODIGO_FORMATEADO" HeaderText="CODIGO" ReadOnly="True">
                                 <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" Width="100px"  
                                BorderWidth="1px" ForeColor="Black" />                                
                            </asp:BoundField>
                            <asp:BoundField DataField="NOMBRE_PROVEE_TRANS" HeaderText="NOMBRE" ReadOnly="True">
                                 <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" Width="400px"  
                                BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PAGO_NETO" HeaderText="MONTO" ReadOnly="True" DataFormatString="{0:n}" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Right" Width="90px" />
                            </asp:BoundField>  
                            <asp:TemplateField HeaderText="No. CHEQUE">
	   	   	                   <ItemTemplate>
	   	   	   	                   <asp:Label id="lblNO_CHEQUE" runat="server" />	   	   	   	  
                               </ItemTemplate>
                               <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                               <ItemStyle HorizontalAlign="Center" Width="60px" />
                           </asp:TemplateField>                                                            
                        </Columns>       
                        <SelectedRowStyle BackColor="#FFFFCC" forecolor="DarkBlue"  
                            BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>                 
                    </asp:GridView>
                     <asp:HiddenField ID="hfCount" runat="server" Value = "0" />
                </asp:Panel>         
                </td>
            </tr>
        </table>    
    </div>    
