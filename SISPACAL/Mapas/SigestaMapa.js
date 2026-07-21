//Definicion de objetos del mapa
var postponedCallbackValue = null;
var map;
var opcion = '';
var objetosMapa = [];
var posIngenio;  
    
var Area = new Object;
var Area = function () {
    this.codigo = "";
    this.nombre = "";
    this.icono = "";
    this.posicion = "";
    this.coordenadas = "";
    this.anchoBorde = 0;
    this.colorBorde = "";
    this.opacidadBorde = 0;
    this.colorRelleno = "";
    this.opacidadRelleno = 0;
    this.relacionOrigen = false;
    this.colorRelacion = "";
    this.tipo = "";
}

var Ingenio = {
    nombre: "INGENIO JIBOA",
    descripcion: "INGENIO CENTRAL AZUCARERO JIBOA",
    direccion: "",
    //imagen: "http://localhost:56071/SISPACAL/imagenes/mapa/map_jiboa.png",
    imagen: "http://192.168.1.198/SIGESTA/sispacal/imagenes/mapa/map_jiboa.png",
    posicion: "(13.583579,-88.778919)"    
}

function ObtenerColor(s) {
    switch(s){
        case 'gris':
            return "#CECECE";
            break;
        case 'gris_oscuro':
            return "#999999";
            break;
        case 'azul':
            return "#0066FF";
            break;
        case 'azul_oscuro':
            return "#000099";
            break; 
        case 'negro':
            return "#000000";
            break;
        case 'rojo':
            return "#FF0000";
            break;
        case 'verde':
            return "#009900";
            break;
        case 'amarillo':
            return "#FFFF00";
            break;
        case 'naranja':
            return "#FF9933";
            break;
        case 'beige':
            return "#FEF5D6";
            break;
    }
}

//Declaración de funciones para interactuar con el mapa
function InicializarMapa() {
    var latlng = new google.maps.LatLng(13.679469, -88.887851);
    var marca;
    var myOptions = {
        zoom: 9,
        center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        mapTypeControlOptions: {
            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR
        },
        navigationControlOptions: {
            style: google.maps.NavigationControlStyle.ZOOM_PAN
        }
    };
    map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);        
}

function AgregarArea(s) {
    var capa = new Array();
    for (var i in s) {        
        var e = s[i].split(';');
        var a = new Area();        
        a.codigo = e[0];
        a.nombre = e[1];
        a.icono = e[2];
        a.posicion = e[3];
        a.coordenadas = e[4];
        a.anchoBorde = e[5];
        a.colorBorde = ObtenerColor(e[6]);
        a.opacidadBorde = e[7];
        a.colorRelleno = ObtenerColor(e[8]);
        a.opacidadRelleno = e[9];
        a.relacionOrigen = e[10];
        a.colorRelacion = e[11];
        a.tipo = e[12];
        capa.push(a);
    }             
    var poligono;
    for (var i in capa) {
        if (capa[i].coordenadas != '') {
            poligono = new google.maps.Polygon({
                paths: ObtenerArrayLatLng(capa[i].coordenadas),
                strokeColor: capa[i].colorBorde,
                strokeOpacity: capa[i].opacidadBorde,
                fillColor: capa[i].colorRelleno,
                strokeWeight: capa[i].anchoBorde,
                fillOpacity: capa[i].opacidadRelleno
            });
            AgregarObjeto(poligono);
        }        
        
        if (capa[i].posicion != '') {
            var marca;
            marca = CrearMarca(capa[i].posicion, capa[i].icono, capa[i].nombre);
            PopupInfo(capa[i].tipo, capa[i].codigo, marca);
            if (capa[i].relacionOrigen)                
                CrearLinea(capa[i].posicion, Ingenio.posicion, capa[i].colorRelacion);            
        }
    }
}

function ObtenerPosRealMapa(p){
    var coordsLatLng = ObtenerArrayLatLng(p);
    return coordsLatLng[0];
}

function CrearLinea(posicion1, posicion2, colorLinea) {        
        var pos1 = ObtenerPosRealMapa(posicion1);
        var pos2 = ObtenerPosRealMapa(posicion2);
        var puntos = [pos1, pos2];
        var clinea;
        if (colorLinea == '') 
            clinea = ObtenerColor('negro');
        else
            clinea = ObtenerColor(colorLinea);
        var linea = new google.maps.Polyline({
            path: puntos,
            strokeColor: clinea,
            strokeOpacity: 0.8,
            strokeWeight: 1
        });
        AgregarObjeto(linea);
}

function CrearMarca(posicion, icono, nombre) {    
    var marca = new google.maps.Marker({
        position: ObtenerPosRealMapa(posicion),
        map: map,
        icon: icono,
        title: nombre
    });    
    AgregarObjeto(marca);   
    return marca
}

function PopupInfo(tipo, cod, marca) {    
    google.maps.event.addListener(marca, 'click', function () {
        InvocarPopupInfo(tipo, cod);
    });
}    

function ObtenerArrayLatLng(listaCoord) {
    var coordenadas = new Array();
    var coordenada;
    var latitud;
    var longitud;
    var posini = 0;
    var posfin = 0;
    var i = 0;

    while (posini <= listaCoord.toString().length - 1) {
        posini = listaCoord.toString().indexOf('(', posini);
        posfin = listaCoord.toString().indexOf(')', posini);

        coordenada = listaCoord.toString().substr(posini + 1, posfin - posini - 1).replace(/^\s+/g, '').replace(/\s+$/g, '');
        latitud = parseFloat(coordenada.toString().substr(0, coordenada.toString().indexOf(',') - 1).replace(/^\s+/g, '').replace(/\s+$/g, ''));
        longitud = parseFloat(coordenada.toString().substr(coordenada.toString().indexOf(',') + 1).replace(/^\s+/g, '').replace(/\s+$/g, ''));

        coordenadas[i++] = new google.maps.LatLng(latitud, longitud);
        posini = posfin + 1;
    }
    return coordenadas;
}

function AgregarObjeto(objeto) {
    objetosMapa.push(objeto);
    objeto.setMap(map);
}

function LimpiarMapa() {
    if (objetosMapa) {
        for (i in objetosMapa) {
            objetosMapa[i].setMap(null);
        }
        objetosMapa.length = 0;
    }
    CrearMarca(ObtenerPosRealMapa(Ingenio.posicion), Ingenio.imagen, Ingenio.nombre, map);
}

function InvocarPopupInfo(tipo, cod) {
    Cargando(true);
    cpMapa.PerformCallback('PopupInfo;' + tipo + ';' + cod);
}

function Cargando(e) {
    if (e)
        ldpCargando.Show();
    else
        ldpCargando.Hide();
}