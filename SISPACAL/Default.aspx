<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <script src="Scripts/prototype.js" type="text/javascript"></script>  
    <script src="Scripts/effects.js" type="text/javascript"></script>  
    <script src="Scripts/blender.js" type="text/javascript"></script>  
   
    
    <script type="text/javascript">

        Event.observe(window, "load", function () {
            var images = [
			        "imagenes/injiboa/ingenio.png",
			        "imagenes/injiboa/descarga.png",
			        "imagenes/injiboa/laboratorio.png",
			        "imagenes/injiboa/cargadora.png",
			        "imagenes/injiboa/calderas.png",
                    "imagenes/injiboa/molinos.png",
                    "imagenes/injiboa/centrifugas.png",
                    "imagenes/injiboa/alamcen.png"];

            new Blender("optionsDemo", images, {autosize: true});
        });


    </script>
    <table width="100%">
        <tr align="center" >
            <td valign="middle" style="width:50%">
                <img id='Img1' src='imagenes/nvoLogoINJIBOA.png' alt='injiboa' />
                <p>Es importante resaltar que el propósito de esta nueva aplicación es contar con un sistema robusto, ágil y confiable que garantice que la información de la zafra, que se utiliza para el pago por calidad, sea invulnerable, precisa y oportuna en la generación de la información para la toma de decisiones, destacando el cumplimiento de la ley y normativas establecidas por el CONSAA.</p>
            </td>
            <td valign="middle">
                <div style="position:relative;width:449px;height:282px;padding:1px;border:1px solid gray">  
                    <img id='optionsDemo' src='imagenes/injiboa/ingenio.png' alt='injiboa' width="449px"  />
                </div>
                <div style="position:relative;width:449px;height:50px;padding:1px;border:1px solid gray; background-color:#5F703A; font-family: Arial, Helvetica, sans-serif; font-size: x-large; color: #FFFFFF; text-align: center; vertical-align: middle;">
                    Sistema Integrado de INJIBOA</div>
            </td>
        </tr>
    </table>
    <hr />
    <div class="div_footer">
        Planta y Oficina San Vicente: Km. 68 ½, Carretera de San Vicente a Zacatecoluca, Cantón San Antonio Caminos, Teléfono 2399-4900, 2399-4906, Fax 2399-4998 <br />
        Oficina Central San Salvador: Calle los Abetos Pje 5  #7, Col. San Francisco, San Salvador, Teléfono 2224-5012, 2224-5005, 2224-5037      
    </div>
</asp:Content>

