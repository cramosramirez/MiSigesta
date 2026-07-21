''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cENVIO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ENVIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cENVIO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbENVIO()
    Private mEntidad as New ENVIO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerENVIO(ByRef aEntidad As ENVIO, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then Return liRet
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(aEntidad)
                Catch ex as Exception
                End Try
            End If
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ENVIO.
    ''' </summary>
    ''' <param name="ID_ENVIO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerENVIO(ByVal ID_ENVIO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As ENVIO
        Try
            Dim lEntidad As New ENVIO
            lEntidad.ID_ENVIO = ID_ENVIO
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then
                If liRet = 1 Then Return lEntidad
                Return Nothing
            End If
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(lEntidad)
                Catch ex as Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aCONTRATO">Recuperar registro foraneo de la Entidad CONTRATO.</param>
    ''' <param name="aPROVEEDOR">Recuperar registro foraneo de la Entidad PROVEEDOR.</param>
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <param name="aTRANSPORTISTA">Recuperar registro foraneo de la Entidad TRANSPORTISTA.</param>
    ''' <param name="aTIPO_CANA">Recuperar registro foraneo de la Entidad TIPO_CANA.</param>
    ''' <param name="aCARGADORA">Recuperar registro foraneo de la Entidad CARGADORA.</param>
    ''' <param name="aSUPERVISOR">Recuperar registro foraneo de la Entidad SUPERVISOR.</param>
    ''' <param name="aPROVEEDOR_ROZA">Recuperar registro foraneo de la Entidad PROVEEDOR_ROZA.</param>
    ''' <param name="aCARGADOR">Recuperar registro foraneo de la Entidad CARGADOR.</param>
    ''' <param name="aMOTORISTA">Recuperar registro foraneo de la Entidad MOTORISTA.</param>
    ''' <param name="aTIPOS_GENERALES">Recuperar registro foraneo de la Entidad TIPOS_GENERALES.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerENVIOConForaneas(ByVal aEntidad As ENVIO, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCONTRATO As Boolean = False, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aTIPO_CANA As Boolean = False, Optional ByVal aCARGADORA As Boolean = False, Optional ByVal aSUPERVISOR As Boolean = False, Optional ByVal aPROVEEDOR_ROZA As Boolean = False, Optional ByVal aCARGADOR As Boolean = False, Optional ByVal aMOTORISTA As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aCONTRATO, aPROVEEDOR, aLOTES, aTRANSPORTISTA, aTIPO_CANA, aCARGADORA, aSUPERVISOR, aPROVEEDOR_ROZA, aCARGADOR, aMOTORISTA, aTIPOS_GENERALES)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarENVIO(ByVal ID_ENVIO As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal CATORCENA As Int32, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal COMPTENVIO As Int32, ByVal ACCESLOTE As String, ByVal CODTRANSPORT As Int32, ByVal NOMBRES_MOTORISTA As String, ByVal ID_TIPO_CANA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_SUPERVISOR As Int32, ByVal FECHA_QUEMA As DateTime, ByVal FECHA_CORTA As DateTime, ByVal QUEMAPROG As Boolean, ByVal FECHA_CARGA As DateTime, ByVal FECHA_PATIO As DateTime, ByVal NROBOLETA As Int32, ByVal MADURANTE As Boolean, ByVal CERRADO As Boolean, ByVal FECHA_ENTRADA As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal PLACAVEHIC As String, ByVal ID_TIPOTRANS As Int32, ByVal SERVICIO_ROZA As Boolean, ByVal TRANSPORTE_PROPIO As Boolean, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_CARGADOR As Int32, ByVal NUMRECIBO_CANA As Int32, ByVal TIPO_TARIFA_CARGADORA As Int32, ByVal ID_MOTORISTA As Int32, ByVal HORAS_QUEMA As Decimal, ByVal ANULADO As Boolean, ByVal USUARIO_ANULACION As String, ByVal FECHA_ANULACION As DateTime, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ES_QUERQUEO As Boolean, ByVal ES_BARRIDO As Boolean, ByVal ES_PRIMERENVIO_TURNO As Boolean, ByVal ES_ULTENVIO_TURNO As Boolean) As Integer
        Try
            Dim lEntidad As New ENVIO
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.COMPTENVIO = COMPTENVIO
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_SUPERVISOR = ID_SUPERVISOR
            lEntidad.FECHA_QUEMA = FECHA_QUEMA
            lEntidad.FECHA_CORTA = FECHA_CORTA
            lEntidad.QUEMAPROG = QUEMAPROG
            lEntidad.FECHA_CARGA = FECHA_CARGA
            lEntidad.FECHA_PATIO = FECHA_PATIO
            lEntidad.NROBOLETA = NROBOLETA
            lEntidad.MADURANTE = MADURANTE
            lEntidad.CERRADO = CERRADO
            lEntidad.FECHA_ENTRADA = FECHA_ENTRADA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.PLACAVEHIC = PLACAVEHIC
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.SERVICIO_ROZA = SERVICIO_ROZA
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.NUMRECIBO_CANA = NUMRECIBO_CANA
            lEntidad.TIPO_TARIFA_CARGADORA = TIPO_TARIFA_CARGADORA
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.HORAS_QUEMA = HORAS_QUEMA
            lEntidad.ANULADO = ANULADO
            lEntidad.USUARIO_ANULACION = USUARIO_ANULACION
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ES_QUERQUEO = ES_QUERQUEO
            lEntidad.ES_BARRIDO = ES_BARRIDO
            lEntidad.ES_PRIMERENVIO_TURNO = ES_PRIMERENVIO_TURNO
            lEntidad.ES_ULTENVIO_TURNO = ES_ULTENVIO_TURNO
            Return Me.ActualizarENVIO(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarENVIO(ByVal ID_ENVIO As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal CATORCENA As Int32, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal COMPTENVIO As Int32, ByVal ACCESLOTE As String, ByVal CODTRANSPORT As Int32, ByVal NOMBRES_MOTORISTA As String, ByVal ID_TIPO_CANA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_SUPERVISOR As Int32, ByVal FECHA_QUEMA As DateTime, ByVal FECHA_CORTA As DateTime, ByVal QUEMAPROG As Boolean, ByVal FECHA_CARGA As DateTime, ByVal FECHA_PATIO As DateTime, ByVal NROBOLETA As Int32, ByVal MADURANTE As Boolean, ByVal CERRADO As Boolean, ByVal FECHA_ENTRADA As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal PLACAVEHIC As String, ByVal ID_TIPOTRANS As Int32, ByVal SERVICIO_ROZA As Boolean, ByVal TRANSPORTE_PROPIO As Boolean, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_CARGADOR As Int32, ByVal NUMRECIBO_CANA As Int32, ByVal TIPO_TARIFA_CARGADORA As Int32, ByVal ID_MOTORISTA As Int32, ByVal HORAS_QUEMA As Decimal, ByVal ANULADO As Boolean, ByVal USUARIO_ANULACION As String, ByVal FECHA_ANULACION As DateTime, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ES_QUERQUEO As Boolean, ByVal ES_BARRIDO As Boolean, ByVal ES_PRIMERENVIO_TURNO As Boolean, ByVal ES_ULTENVIO_TURNO As Boolean) As Integer
        Try
            Dim lEntidad As New ENVIO
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.COMPTENVIO = COMPTENVIO
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_SUPERVISOR = ID_SUPERVISOR
            lEntidad.FECHA_QUEMA = FECHA_QUEMA
            lEntidad.FECHA_CORTA = FECHA_CORTA
            lEntidad.QUEMAPROG = QUEMAPROG
            lEntidad.FECHA_CARGA = FECHA_CARGA
            lEntidad.FECHA_PATIO = FECHA_PATIO
            lEntidad.NROBOLETA = NROBOLETA
            lEntidad.MADURANTE = MADURANTE
            lEntidad.CERRADO = CERRADO
            lEntidad.FECHA_ENTRADA = FECHA_ENTRADA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.PLACAVEHIC = PLACAVEHIC
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.SERVICIO_ROZA = SERVICIO_ROZA
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.NUMRECIBO_CANA = NUMRECIBO_CANA
            lEntidad.TIPO_TARIFA_CARGADORA = TIPO_TARIFA_CARGADORA
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.HORAS_QUEMA = HORAS_QUEMA
            lEntidad.ANULADO = ANULADO
            lEntidad.USUARIO_ANULACION = USUARIO_ANULACION
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ES_QUERQUEO = ES_QUERQUEO
            lEntidad.ES_BARRIDO = ES_BARRIDO
            lEntidad.ES_PRIMERENVIO_TURNO = ES_PRIMERENVIO_TURNO
            lEntidad.ES_ULTENVIO_TURNO = ES_ULTENVIO_TURNO
            Return Me.ActualizarENVIO(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONTRATO .
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO(ByVal CODICONTRATO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorCONTRATO(CODICONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR .
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla LOTES .
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TRANSPORTISTA .
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_CANA .
    ''' </summary>
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorTIPO_CANA(ID_TIPO_CANA, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CARGADORA .
    ''' </summary>
    ''' <param name="ID_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorCARGADORA(ID_CARGADORA, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SUPERVISOR .
    ''' </summary>
    ''' <param name="ID_SUPERVISOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSUPERVISOR(ByVal ID_SUPERVISOR As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorSUPERVISOR(ID_SUPERVISOR, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_ROZA .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_ROZA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorPROVEEDOR_ROZA(ID_PROVEEDOR_ROZA, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CARGADOR .
    ''' </summary>
    ''' <param name="ID_CARGADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCARGADOR(ByVal ID_CARGADOR As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorCARGADOR(ID_CARGADOR, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MOTORISTA .
    ''' </summary>
    ''' <param name="ID_MOTORISTA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTORISTA(ByVal ID_MOTORISTA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorMOTORISTA(ID_MOTORISTA, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPOS_GENERALES .
    ''' </summary>
    ''' <param name="ID_TIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO
        Try
            Dim mListaENVIO As New ListaENVIO
            mListaENVIO = mDb.ObtenerListaPorTIPOS_GENERALES(ID_TIPO, asColumnaOrden, asTipoOrden)
            If Not mListaENVIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaENVIO
            If Not mListaENVIO Is Nothing Then
                For Each lEntidad As ENVIO in  mListaENVIO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaENVIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de la Tabla Foranea en la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ENVIO )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkCODICONTRATO = (New cCONTRATO).ObtenerCONTRATO(aEntidad.CODICONTRATO)
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkCODTRANSPORT = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(aEntidad.CODTRANSPORT)
        aEntidad.fkID_TIPO_CANA = (New cTIPO_CANA).ObtenerTIPO_CANA(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_CARGADORA = (New cCARGADORA).ObtenerCARGADORA(aEntidad.ID_CARGADORA)
        aEntidad.fkID_SUPERVISOR = (New cSUPERVISOR).ObtenerSUPERVISOR(aEntidad.ID_SUPERVISOR)
        aEntidad.fkID_PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(aEntidad.ID_PROVEEDOR_ROZA)
        aEntidad.fkID_CARGADOR = (New cCARGADOR).ObtenerCARGADOR(aEntidad.ID_CARGADOR)
        aEntidad.fkID_MOTORISTA = (New cMOTORISTA).ObtenerMOTORISTA(aEntidad.ID_MOTORISTA)
        aEntidad.fkID_TIPO_ROZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_ROZA)
        aEntidad.fkID_TIPO_ALZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_ROZA)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ENVIO )
    End Sub

#End Region

End Class
