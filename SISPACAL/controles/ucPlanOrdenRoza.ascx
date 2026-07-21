<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPlanOrdenRoza.ascx.vb" Inherits="controles_ucPlanOrdenRoza" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
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
    .style1
    {
        height: 26px;
    }
</style>

<script type = "text/javascript">
    function MostrarReporte(tipo, valor) {
        if (tipo == 1)
            window.open("../reportes/wfReporteModal.aspx?n=11&idgen=" + valor, "_blank", "")
        else
            window.open("../reportes/wfReporteModal.aspx?n=111&idplan=" + valor, "_blank", "")
    } 
    function Check_Click(objRef) {
        //Get the Row based on checkbox
        var row = objRef.parentNode.parentNode;

        //Get the reference of GridView
        var GridView = row.parentNode;

        //Get all input elements in Gridview
        var inputList = GridView.getElementsByTagName("input");

        for (var i = 0; i < inputList.length; i++) {
            //The First element is the Header Checkbox
            var headerCheckBox = inputList[0];

            //Based on all or none checkboxes
            //are checked check/uncheck Header Checkbox
            var checked = true;
            if (inputList[i].type == "checkbox" && inputList[i] != headerCheckBox) {
                if (!inputList[i].checked) {
                    checked = false;
                    break;
                }
            }
        }
        headerCheckBox.checked = checked;

    }
    function checkAll(objRef) {
        var GridView = objRef.parentNode.parentNode.parentNode;
        var inputList = GridView.getElementsByTagName("input");
        for (var i = 0; i < inputList.length; i++) {
            var row = inputList[i].parentNode.parentNode;
            if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
                if (objRef.checked) {
                    inputList[i].checked = true;
                }
                else {
//                    if (row.rowIndex % 2 == 0) {
//                        row.style.backgroundColor = "#C2D69B";
//                    }
//                    else {
//                        row.style.backgroundColor = "white";
//                    }
                    inputList[i].checked = false;
                }
            }
        }
    }
</script>

<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Generación de Orden de Roza</asp:Label></td>		
    </tr>
</table>
<div class="centraTabla">  
    <div class="ContenedorCamposOscuro" >
        <asp:Label id="Label2" class="NormalBold" runat="server">Criterios de búsqueda</asp:Label>
    </div> 
    <div class="ContenedorCampos">      
        <table cellspacing="0" cellpadding="0" border="0">        
            <tr>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label1" runat="server">ZONA:</asp:Label></td>
                <td style="padding-right:5px"><cc1:ddlZONAS ID="DdlZONAS1" runat="server" 
                        CssClass="DDLClass" Width="200px"></cc1:ddlZONAS></td>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label3" runat="server">SEMANA:</asp:Label></td>
                <td style="width:350px"><cc1:ddlPLAN_SEMANAL ID="DdlPLAN_SEMANAL1" CssClass="DDLClass" runat="server" Width="100%">
                                    </cc1:ddlPLAN_SEMANAL></td>
            </tr>         
            <tr>
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label5" runat="server">CODIGO PROVEE/SOCIO:</asp:Label></td>
                <td style="padding-right:5px"><asp:TextBox CssClass="TextoDerecha" id="txtCODIPROVEE" runat="server" AutoPostBack="True" Width="100px" />
                                        <asp:TextBox CssClass="TextoDerecha" id="txtCODSOCIO" runat="server" AutoPostBack="True" Width="80px" /></td>        
                <td style="padding-right:5px"><asp:Label CssClass="Normal" id="Label6" runat="server">NOMBRE PROVEEDOR:</asp:Label></td>
                <td><asp:TextBox CssClass="NormalUPPER" id="txtNOMBRE_PROVEEDOR" runat="server" Width="100%" /></td>            
            </tr>   
        </table>
    </div> 
    <div class="ContenedorCamposOscuro" >
        <asp:Label id="Label7" class="NormalBold" runat="server">GENERAR ORDEN DE ROZA <br/>(Seleccione los lotes a incluir en la Orden, ingrese fecha de orden, cuota diaria y haga clic en Ver Reporte)</asp:Label>
    </div> 
    <div class="ContenedorCampos">            
        <table width="100%">
            <tr>
                <td> 
                    <asp:Panel ID="Panel1" runat="server" Width="100%" Height="300px" 
                    ScrollBars="Auto" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="0px">   
                    <asp:GridView ID="grdLotes" runat="server" RowStyle-ForeColor="Black" 
                            AutoGenerateColumns="False" Width="100%" Font-Names="Arial" Font-Size="11px"
                        DataKeyNames="ACCESLOTE" BackColor="White" AllowPaging="True" PagerStyle-Font-Size="Small" PageSize="7" >                        
                        <Columns>                           
                            <asp:TemplateField>
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                    BorderWidth="1px" ForeColor="Black" Width="20px"  />
                                <ItemStyle HorizontalAlign="Center"  />
                                <HeaderTemplate>
                                    <asp:CheckBox ID="chkAll" runat="server" onclick = "checkAll(this);" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chk" runat="server" onclick = "Check_Click(this)"/>
                                </ItemTemplate>
                            </asp:TemplateField> 
                            <asp:TemplateField>
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                    BorderWidth="1px" ForeColor="Black" Width="20px"  />
                                <ItemStyle HorizontalAlign="Center"  />
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkOrdenRoza" runat="server" Visible="false" CommandName="VerOrden" CausesValidation="False" ToolTip="Con Orden de Roza">
	   	   	   	                    <asp:Image ID="imgOrdenRoza" AlternateText="Con Orden de Roza" runat="server" ImageUrl="~/imagenes/pagina.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="NOMBRE_PROVEEDOR" HeaderText="PROVEEDOR" ReadOnly="True">
                                 <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" />                                
                            </asp:BoundField>
                            <asp:BoundField DataField="CODILOTE" HeaderText="COD. LOTE" ReadOnly="True">
                                 <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" 
                                BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOMBLOTE" HeaderText="NOMBRE LOTE" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="90px" />
                            </asp:BoundField>                  
                            <asp:BoundField DataField="AREA" HeaderText="AREA/MZ" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="60px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TONELADAS" HeaderText="TON/MZ" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="60px"/>
                            </asp:BoundField>
                             <asp:BoundField DataField="TONEL_TC" HeaderText="TONELADAS CONTRATADAS" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TONELADAS_PROGRAMADAS" HeaderText="TONELADAS PROGRAMADAS" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="100px"  />
                            </asp:BoundField>                          
                            <asp:BoundField DataField="TONELADAS_ENTREGADAS" Visible="false" HeaderText="TONELADAS ENTREGADAS" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center"  />
                            </asp:BoundField> 
                            <asp:BoundField DataField="EDAD_LOTE" HeaderText="EDAD LOTE" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" Width="50px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CODIVARIEDA" HeaderText="COD. VARIEDAD" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="NOM_VARIEDAD" HeaderText="VARIEDAD" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CODIUBICACION" HeaderText="COD. UBICACION" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CANTON" HeaderText="CANTON" ReadOnly="True" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:BoundField>     
                            <asp:BoundField DataField="CODIPROVEEDOR" HeaderText="CODIPROVEEDOR" ReadOnly="True" Visible="false" >
                                <HeaderStyle BackColor="#CDE0FC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                            <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:BoundField>                       
                        </Columns>                       
                    </asp:GridView>
                     <asp:HiddenField ID="hfCount" runat="server" Value = "0" />
                </asp:Panel>         
                </td>
            </tr>
        </table>    
    </div>    
    <div class="ContenedorCampos" >             
        <table>
            <tr>               
                <td class="style1"><asp:Label CssClass="Normal" id="Label8" runat="server">FECHA ORDEN:</asp:Label></td>
                <td class="style1"><asp:TextBox ID="txtFECHA_ORDEN" CssClass="TextoIzquierda" runat="server" Width="100px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="txtFECHA_ORDEN_MaskedEditExtender" runat="server" 
                    AutoComplete="False" Mask="99/99/9999" 
                    MaskType="Date"  TargetControlID="txtFECHA_ORDEN" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True" 
                    UserDateFormat="DayMonthYear">
                </cc2:MaskedEditExtender></td>                
                <td><asp:Label CssClass="Normal" id="Label9" runat="server">CUOTA DIARIA (TONS.):</asp:Label></td>
                <td><asp:TextBox CssClass="TextoDerecha" id="txtTONEL_DIARIA" runat="server" Width="100px" /></td> 
            </tr>            
        </table>        
    </div>
</div>
