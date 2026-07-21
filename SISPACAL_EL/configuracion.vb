Imports System.Configuration.ConfigurationManager
Imports System.Reflection
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.configuracion
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de configuración que sirve para proveer datos generales a todo el aplicativo
''' </summary>
''' <remarks>
''' ***
''' En esta clase se emulan las variables Globales mediante el uso de propiedades
''' estáticas, asi como también de funcionalidad genérica para el aplicativo.
''' </remarks>
''' <history>
''' 	[GenApp]	29/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class configuracion

    Private Shared _usuarioActualiza As String
    Private Shared _idPerfilUsuario As Integer
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Propiedad que representa el Usuario que esta conectado a la aplicación
    ''' </summary>
    ''' <value>Retorna el Usuario conectado al aplicativo.</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared Property usuarioActualiza() As String
        Get
            Return _usuarioActualiza
        End Get
        Set(ByVal Value As String)
            _usuarioActualiza = Value
        End Set
    End Property

    Public Shared Property idPerfilUsuario() As Integer
        Get
            Return _idPerfilUsuario
        End Get
        Set(ByVal Value As Integer)
            _idPerfilUsuario = Value
        End Set
    End Property

    Private Shared _tituloAplicacion As String = AppSettings("TituloAplicacion")
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Propiedad que retorna el Titulo del Aplicativo
    ''' </summary>
    ''' <value>Devuelve el Titulo del Aplicativo configurado en App.config</value>
    ''' <remarks>
    ''' 
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared ReadOnly Property tituloAplicacion() As String
        Get
            Return _tituloAplicacion
        End Get
    End Property

    Public Shared Function TipoAlza(ByVal id_tipo As Int32) As String
        Select Case id_tipo
            Case Enumeradores.CAT.TipoAlza.AlzaCargadoraJiboa, Enumeradores.CAT.TipoAlza.AlzaCosechadoraJiboa
                Return "INJIBOA"
            Case Enumeradores.CAT.TipoAlza.AlzaCargadoraParticular, Enumeradores.CAT.TipoAlza.AlzaCosechadoraParticular, Enumeradores.CAT.TipoAlza.AlzaManualParticular
                Return "PARTICULAR"
            Case Enumeradores.CAT.TipoAlza.AlzaCargadoraProductor, Enumeradores.CAT.TipoAlza.AlzaCosechadoraProductor, Enumeradores.CAT.TipoAlza.AlzaManualProductor
                Return "PRODUCTOR"
        End Select
        Return ""
    End Function

    Public Shared Function RozaEnTipoCana(ByVal tipoCana As Int32) As List(Of Int32)
        Dim lLista As New List(Of Int32)
       
        Select Case tipoCana
            Case Enumeradores.CAT.TipoCana.Corta, Enumeradores.CAT.TipoCana.Larga
                lLista.Add(Enumeradores.CAT.TipoRoza.RozaManualProductor)
                lLista.Add(Enumeradores.CAT.TipoRoza.RozaManualParticular)

            Case Enumeradores.CAT.TipoCana.PicadaMecanizada
                lLista.Add(Enumeradores.CAT.TipoRoza.RozaCosechadoraProductor)
                lLista.Add(Enumeradores.CAT.TipoRoza.RozaCosechadoraJiboa)
                lLista.Add(Enumeradores.CAT.TipoRoza.RozaCosechadoraParticular)
        End Select
        Return lLista
    End Function

    Public Shared Function AlzaEnTipoCana(ByVal tipoCana As Int32, Optional tipoRoza As Int32 = -1) As List(Of Int32)
        Dim lLista As New List(Of Int32)

        Select Case tipoCana
            Case Enumeradores.CAT.TipoCana.Corta
                lLista.Add(Enumeradores.CAT.TipoAlza.AlzaManualProductor)
                lLista.Add(Enumeradores.CAT.TipoAlza.AlzaManualParticular)

            Case Enumeradores.CAT.TipoCana.Larga
                lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCargadoraProductor)
                lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCargadoraJiboa)
                lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCargadoraParticular)

            Case Enumeradores.CAT.TipoCana.PicadaMecanizada
                If tipoRoza = -1 Then
                    lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCosechadoraProductor)
                    lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCosechadoraJiboa)
                    lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCosechadoraParticular)
                ElseIf tipoRoza = Enumeradores.CAT.TipoRoza.RozaCosechadoraProductor Then
                    lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCosechadoraProductor)
                ElseIf tipoRoza = Enumeradores.CAT.TipoRoza.RozaCosechadoraJiboa Then
                    lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCosechadoraJiboa)
                ElseIf tipoRoza = Enumeradores.CAT.TipoRoza.RozaCosechadoraParticular Then
                    lLista.Add(Enumeradores.CAT.TipoAlza.AlzaCosechadoraParticular)
                End If
        End Select
        Return lLista
    End Function

    Public Shared Function TransporteEnTipoCana(ByVal tipoCana As Int32) As List(Of Int32)
        Dim lLista As New List(Of Int32)

        Select Case tipoCana
            Case Enumeradores.CAT.TipoCana.Corta
                lLista.Add(Enumeradores.CAT.TipoTransporte.CamionProductor)
                lLista.Add(Enumeradores.CAT.TipoTransporte.CamionParticular)

            Case Enumeradores.CAT.TipoCana.PicadaMecanizada
                lLista.Add(Enumeradores.CAT.TipoTransporte.CamionProductor)
                lLista.Add(Enumeradores.CAT.TipoTransporte.CamionParticular)
                lLista.Add(Enumeradores.CAT.TipoTransporte._3EjesProductor)
                lLista.Add(Enumeradores.CAT.TipoTransporte._3EjesParticular)

            Case Enumeradores.CAT.TipoCana.Larga
                lLista.Add(Enumeradores.CAT.TipoTransporte.CamionProductor)
                lLista.Add(Enumeradores.CAT.TipoTransporte.CamionParticular)
                lLista.Add(Enumeradores.CAT.TipoTransporte._3EjesProductor)
                lLista.Add(Enumeradores.CAT.TipoTransporte._3EjesParticular)
                lLista.Add(Enumeradores.CAT.TipoTransporte.RastraProductor)
                lLista.Add(Enumeradores.CAT.TipoTransporte.RastraParticular)
        End Select
        Return lLista
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite Copiar todos los valores de las propiedades de la Clase "origen" 
    ''' a la clase "destino"
    ''' </summary>
    ''' <param name="origen">Objeto que contiene valores a ser duplicados</param>
    ''' <param name="destino">Objeto donde serán copiados los valores de las
    ''' propiedades del Objeto "origen"</param>
    ''' <remarks>
    ''' Es importante hacer notar que si la clase "origen" o "destino" trae el valor
    ''' Nothing no realiza ninguna operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared Sub MapearClase(ByVal origen As Object, ByRef destino As Object)

        If origen Is Nothing Or destino Is Nothing Then Return

        Dim tipoOrigen As Type = origen.GetType()
        Dim tipoDestino As Type = destino.GetType()

        If Not Equals(tipoOrigen, tipoDestino) Then Return

        For Each PropiedadOrigen As PropertyInfo In tipoOrigen.GetProperties()
            Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(PropiedadOrigen.Name)

            If Not PropiedadDestino Is Nothing Then
                PropiedadDestino.SetValue(destino, PropiedadOrigen.GetValue(origen, Nothing), Nothing)
            End If
        Next

    End Sub

End Class

Public Enum TipoConcurrencia As Integer
    Optimistica = 1
    Pesimistica = 2
End Enum


<Serializable()> Public Class Criteria
    Inherits entidadBase

    Private _ColumnName As String
    Private _p1 As String
    Private _p2 As String
    Private _p3 As String

    Sub New(p1 As String, p2 As String, p3 As String)
        ' TODO: Complete member initialization 
        _p1 = p1
        _p2 = p2
        _p3 = p3
    End Sub

    Public Property ColumnName() As String
        Get
            Return _ColumnName
        End Get
        Set(ByVal Value As String)
            _ColumnName = Value
        End Set
    End Property

    Private _Compare As String
    Public Property Compare() As String
        Get
            Return _Compare
        End Get
        Set(ByVal Value As String)
            _Compare = Value
        End Set
    End Property

    Private _DataValue As String
    Public Property DataValue() As String
        Get
            Return _DataValue
        End Get
        Set(ByVal Value As String)
            _DataValue = Value
        End Set
    End Property

    Private _QueryOperator As String
    Public Property QueryOperator() As String
        Get
            Return _QueryOperator
        End Get
        Set(ByVal Value As String)
            _QueryOperator = Value
        End Set
    End Property

    Private _TableAlias As String
    Public Property TableAlias() As String
        Get
            Return _TableAlias
        End Get
        Set(ByVal Value As String)
            _TableAlias = Value
        End Set
    End Property

    Public Sub New(ByVal asColumnName As String, ByVal asCompare As String, ByVal asDataValue As String, ByVal asQueryOperator As String)
        Me._ColumnName = asColumnName
        Me._Compare = asCompare
        Me._DataValue = asDataValue
        Me._QueryOperator = asQueryOperator
    End Sub

    Public Sub New(ByVal asColumnName As String, ByVal asTableAlias As String, ByVal asCompare As String, ByVal asDataValue As String, ByVal asQueryOperator As String)
        Me._ColumnName = asColumnName
        Me._Compare = asCompare
        Me._DataValue = asDataValue
        Me._QueryOperator = asQueryOperator
        Me._TableAlias = asTableAlias
    End Sub

End Class

''' -----------------------------------------------------------------------------
''' <summary>
''' Enumeración para Tipos de Ordenamiento
''' </summary>
''' <remarks>
''' Ascending : Ordenamiento Ascendente
''' Descending : Ordenamiento Descendente
''' None : No se aplica Ordenamiento
''' </remarks>
''' <history>
''' 	[GenApp]	29/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Enum SortOrder As Integer
    Ascending = 1
    Descending = 2
    None = 0
End Enum

''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de uso exclusivo de Busquedas y Ordenamiento
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[GenApp]	29/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class Comparador
    Implements IComparer

    Private _propiedadOrdenamiento As String
    Private _tipoOrdenamiento As SortOrder

    Private _propertyToSearch As String

    Public Sub New(ByVal propiedadOrdenamiento As String)
        Me.New(propiedadOrdenamiento, SortOrder.Ascending)
    End Sub

    Public Sub New(ByVal propiedadOrdenamiento As String, ByVal tipoOrdenamiento As SortOrder)
        MyBase.new()
        _propiedadOrdenamiento = propiedadOrdenamiento
        _tipoOrdenamiento = tipoOrdenamiento
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim prop As Reflection.PropertyInfo = x.GetType.GetProperty(Me.propiedadOrdenamiento)
        If Me.tipoOrdenamiento = SortOrder.None OrElse prop.GetValue(x, Nothing) = prop.GetValue(y, Nothing) Then
            Return 0
        Else
            If prop.GetValue(x, Nothing) > prop.GetValue(y, Nothing) Then
                If Me.tipoOrdenamiento = SortOrder.Ascending Then
                    Return 1
                Else
                    Return -1
                End If
            Else
                If Me.tipoOrdenamiento = SortOrder.Ascending Then
                    Return -1
                Else
                    Return 1
                End If
            End If
        End If
    End Function

    Public Property tipoOrdenamiento() As SortOrder
        Get
            Return _tipoOrdenamiento
        End Get
        Set(ByVal Value As SortOrder)
            _tipoOrdenamiento = Value
        End Set
    End Property

    Public Property propiedadOrdenamiento() As String
        Get
            Return _propiedadOrdenamiento
        End Get
        Set(ByVal Value As String)
            _propiedadOrdenamiento = Value
        End Set
    End Property
End Class

Namespace Enumeradores
    Public Enum TipoLectura
        PESO_BAGAZO = 1
        POL_BRIX = 2
        POL = 3
        BRIX = 4
        BASCULA_PESO_BRUTO = 5
        BASCULA_PESO_TARA = 6
        DEXTRANA = 7
        MATERIA_EXTRAÑA = 8
        REPORTES_COMPROBANTES = 9
        PESO_BAGAZO_PRECOSECHA = 10
        POL_BRIX_PRECOSECHA = 11
        BRIX_PRECOSECHA = 12
        POL_PRECOSECHA = 13
        ANALISIS_COMPLE_PRECOSECHA = 14
        OBSERVACIONES_PRECOSECHA = 15
        FORMULA_DEXTRA_PRECOSECHA = 16
        REPORTES_PRECOSECHA = 17
        ALMIDON_COSECHA = 18
        SEDIMENTO = 19
    End Enum

    Public Enum TipoPlanilla
        Cañeros = 1
        Transportistas = 2
        FrenteRozaParticular = 3
        Cargadoras = 4
        AnticipoCaneros = 5
        ComplementoValorFinalPago = 6
        CompensacionEntregaCana = 7
        IncentivoProductores = 8
        ComplementoTransportistas = 9
        ProductorINJIBOA = 10
        ComplementoVFP_Adicional = 11
        FrenteRozaINJIBOA = 12
        FrenteQuerqueoParticular = 13
        FrenteQuerqueoINJIBOA = 14
    End Enum

    Public Enum TipoIngresoQuemaRoza
        Ejecutada = 1
        Proyectada = 2
    End Enum

    Public Enum TipoProveedor
        Cañero = 1
        Transportista = 2
        FrenteRoza = 3
        Cargador = 4
        Motorista = 5
        FrenteQuerqueo = 6
    End Enum

    Public Enum TipoPersona
        Natural = 1
        Juridica = 2
    End Enum

    Public Enum TipoLabFabVariable
        MedicionDirecta = 1
        Digitado = 2
        ResultadoAnalisis = 3
        CalculadoEnFuncionAnalisis = 4
        Reporte = 5
    End Enum

    Public Enum TipoContribuyente As Int32
        NoContribuyente = 0
        Contribuyente = 1
        GranContribuyente = 2
    End Enum

    Public Enum CondicionCompra As Int32
        Credito = 1
        Contado = 2
        Consignacion = 3
    End Enum

    Public Enum EstadoSolicAgricola As Int32
        Pendiente = 1
        Aceptada = 2
        Anulada = 3
        Finalizada = 4
    End Enum

    Public Class EstadoProforma
        Public Const Transito As String = "TTO"
        Public Const Rueda As String = "RUEDA"
        Public Const Anulado As String = "ANUL"
        Public Const ConEnvio As String = "ENVIO"
        Public Const Patio As String = "PATIO"
        Public Const Tara As String = "TARA"
    End Class

    Public Enum CCFConcepto As Int32
        ProductosNoConsignados = 1
        ProductosConsignados = 2
        AplicacionVuelo = 3
        Ninguno = 99
    End Enum

    Public Enum TiposComprobantes As Int32
        ComprobanteCreditoFiscal = 1
        Factura = 2
        ComprobanteRetencion = 9
        FacturaSujetoExcluido = 10
    End Enum

    Namespace CAT
        Public Enum TipoCAT As Int32
            Roza = 19
            Alza = 24
            Transporte = 31
        End Enum

        Public Enum TipoCana As Int32
            Corta = 16
            Larga = 18
            PicadaMecanizada = 17
        End Enum

        Public Enum TipoRoza As Int32
            RozaManualProductor = 20
            RozaManualParticular = 21
            RozaCosechadoraProductor = 41
            RozaCosechadoraJiboa = 22
            RozaCosechadoraParticular = 23
        End Enum

        Public Enum TipoAlza As Int32
            AlzaManualProductor = 25
            AlzaManualParticular = 26
            AlzaCosechadoraJiboa = 27
            AlzaCosechadoraProductor = 39
            AlzaCosechadoraParticular = 28
            AlzaCargadoraJiboa = 29
            AlzaCargadoraProductor = 40
            AlzaCargadoraParticular = 30
        End Enum

        Public Enum TipoTransporte As Int32
            CamionProductor = 32
            CamionParticular = 33
            _3EjesProductor = 34
            _3EjesParticular = 35
            RastraProductor = 36
            RastraParticular = 37
            Camion7TonProductor = 46
            Camion7TonParticular = 47
        End Enum

    End Namespace

    Public Enum TipoCiclo As Int32
        Cosecha = 1
        Fabrica = 2
        Zafra = 3
    End Enum


    Public Enum TipoOperacion As Integer
        Recepcion = 0
        Edicion = 1
        Consulta = 2
        Emision = 3
        Facturacion = 4
        EdicionParcialBascula = 5
        Anulacion = 6
        Eliminacion = 7
        RegistroProforma = 8
        EmisionProforma = 9
        AnulacionProforma = 10
        ConsultaProforma = 11
        CambioFechaQuemaRoza = 12
    End Enum

    Public Enum TipoOperacionAnalisisFab As Integer
        Ingreso = 0
        Edicion = 1
        Consulta = 2
    End Enum

    Public Enum EtapaRequisicion As Integer
        Todas = -1
        Emitida = 1
        Aprobada = 2
        Rechazada = 3
        Anulada = 4
        RequisicionAsignada = 5
        CotizacionSolicitada = 6
        OrdenCompraAsignada = 7
        IngresoAlmacen = 8
        QuedanAsignado = 9
        Finalizado = 10
    End Enum

    Public Enum CategoriaProducto As Integer
        Madurante = 1
        Fertilizante = 2
        Insecticida = 3
        Inhibidor = 4
        Herbicida = 5
        Generico = 6
        CanaSemilla = 7
        Talonario = 8
        ServicioMaquinariaAgricola = 9
        HerramientasEPP = 10
        Transporte = 11
    End Enum

    Public Enum CuentaFinanciamiento As Integer
        OpisBancarias = 1
        ServicioMaquinariaAgricola = 3
        Anticipos = 5
        Mutuos = 6
        Fertilizantes = 7
        Plaguicidas = 9
        InhibidoresFloracion = 11
        VuelosAereosInhibidores = 13
        HerramientasEPP = 15
        Madurantes = 17
        VuelosAereosMadurantes = 19
        Asprocana = 21
        Combustible = 22
        CorteRoza = 23
        AlzaCargada = 24
        TransporteFlete = 25
        Herbicidas = 26
        Insecticidas = 28
        Generico = 30
        CanaSemilla = 31
        Talonario = 32
        Asprocarpa = 33
        Procana = 53
        SaldosInsolutos = 34
        AnticipoRoza = 35
        Otros = 36

        PolizaSeguroDanosTercero = 37
        Cables = 38
        KitSeguridad = 39
        GPS = 40
        RepuestosAccesorios = 41
        InsumosOperativos = 42
        DesctosPrevioAutorizados = 43
        RetencionPagosImpuestos = 44
        Carnet = 45
        OtrasCuentas = 46
        Querqueo = 47
        Plomeo = 48
        PlanillasPago = 49
        PagoIntereses = 50
        CajaChica = 51
        KitSanitario = 52
        ServiciosMotorizados = 54
        Bioestimulantes = 55
        Foliares = 56
    End Enum

    Public Enum TipoOperacionContrato As Integer
        Ingreso = 0
        Consulta = 1
    End Enum

    Public Enum AplicacionDescuento As Integer
        Todos = 0
        Contratos = 1
        Lotes = 2
    End Enum

    Public Enum TipoCargadora As Integer
        Cargadora = 1
        Cosechadora = 2
        Manual = 3
    End Enum

    Public Enum TipoContrato As Integer
        PersonaNatural = 1
        PersonaJuridica = 2
        Cooperativa = 3
    End Enum

    Public Enum TipoDerechoLote As Integer
        Propietario = 1
        Arrendatario = 2
        Asignatario = 3
    End Enum

    Public Enum TiposTabla As Integer
        TiposVariedad = 1
        SubTiposVariedad = 5
    End Enum

    Public Class Parametros
        Public Const HorasPostCierreEntrega As Int32 = 24
    End Class

    Public Class IconoBarra
        Public Const Guardar As String = "save_save_16x16"
        Public Const Editar As String = "edit_edit_16x16"
        Public Const Cancelar As String = "history_undo_16x16"
        Public Const Salir As String = "actions_close_16x16"
        Public Const Consulta As String = "actions_loadfrom_16x16"
        Public Const Buscar As String = "find_find_16x16"
        Public Const Eliminar As String = "edit_delete_16x16"
        Public Const Emitir As String = "actions_merge_16x16"
        Public Const VistaPrevia As String = "zoom_zoom_16x16"
        Public Const Programar As String = "scheduling_switchtimescalesto_16x16"
        Public Const Generar As String = "edit_copy_16x16"
        Public Const Reporte As String = "reports_insertheader_16x16"
        Public Const Agregar As String = "actions_add_16x16"
        Public Const Actualizar As String = "actions_convert_16x16"
        Public Const Proveedor As String = "people_customer_16x16"
        Public Const Socio As String = "people_usergroup_16x16"
        Public Const Lote As String = "scheduling_snaptocells_16x16"
        Public Const Cesion As String = "people_assignto_16x16"
        Public Const Aprobar As String = "content_checkbox_16x16"
        Public Const Validar As String = "content_checkbox_16x16"
        Public Const Aplicar As String = "content_checkbox_16x16"
        Public Const Anular As String = "actions_deletelist2_16x16"
        Public Const ExportarXlsx As String = "export_exporttoxlsx_16x16"
        Public Const ExportarXls As String = "export_exporttoxls_16x16"
    End Class

    Public Class ImpuestoGasolina
        Public Const Fovial As Decimal = 0.2
        Public Const Cotrans As Decimal = 0.1
    End Class
End Namespace

<Serializable()> _
Public Class CampoOrdenamiento
    Public Sub New()
    End Sub

    Public Sub New(ByVal pCampo As String, ByVal pDescripcion As String)
        _Campo = pCampo
        _Descripcion = pDescripcion
    End Sub

    Private _Campo As String
    Public Property Campo As String
        Set(value As String)
            _Campo = value
        End Set
        Get
            Return _Campo
        End Get
    End Property

    Private _Descripcion As String
    Public Property Descripcion As String
        Set(value As String)
            _Descripcion = value
        End Set
        Get
            Return _Descripcion
        End Get
    End Property
End Class

<Serializable()> _
Public Class TipoOrden
    Public Sub New()
    End Sub

    Public Sub New(ByVal pValor As Integer, ByVal pDescripcion As String)
        _Valor = pValor
        _Descripcion = pDescripcion
    End Sub

    Private _Valor As String
    Public Property Valor As Integer
        Set(value As Integer)
            _Valor = value
        End Set
        Get
            Return _Valor
        End Get
    End Property

    Private _Descripcion As String
    Public Property Descripcion As String
        Set(value As String)
            _Descripcion = value
        End Set
        Get
            Return _Descripcion
        End Get
    End Property
End Class