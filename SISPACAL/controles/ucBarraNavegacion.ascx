<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="ucBarraNavegacion.ascx.vb" CodeFile="~/controles/ucBarraNavegacion.ascx.vb" ClassName="ucBarraNavegacion"  Inherits="controles_ucBarraNavegacion" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



    <div style="background: #7795BD url('../imagenes/fase2/fondo_menu.png') repeat-x; border-right: 1px solid #8BA0BC;" >     
            <dx:ASPxMenu ID="mDinamico" runat="server" ShowAsToolbar="True" ShowPopOutImages="True" >               
                <Items>
                    <dx:MenuItem GroupName="General" Name="miAgregar" Text="Agregar">                        
                        <Image AlternateText="Agregar" IconID="actions_new_16x16" ></Image>                        
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="General" Name="miEditar" Text="Editar">
                        <Image IconID="edit_edit_16x16" >
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="General" Name="miGuardar" Text="Guardar">
                        <Image AlternateText="Guardar" IconID="save_save_16x16">
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="General" Name="miSalir" Text="Salir">
                        <Image AlternateText="Salir del formulario" IconID="navigation_home_16x16" >
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem BeginGroup="true" GroupName="Exportar" Name="miExportarAExcel" Text="Exportar a Excel" Visible="False">
                        <Image AlternateText="Exportar a Excel"  Url="~/imagenes/excel.gif" >
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Exportar" Name="miExportarAPDF" Text="Exportar a PDF" Visible="False">
                        <Image AlternateText="Exportar a PDF"  Url="~/imagenes/pdf.gif" >
                        </Image>
                    </dx:MenuItem>
                </Items>
            </dx:ASPxMenu>
    </div>