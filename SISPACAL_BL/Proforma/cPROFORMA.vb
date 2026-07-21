''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPROFORMA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PROFORMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/02/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPROFORMA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPROFORMA()
    Private mEntidad as New PROFORMA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPROFORMA(ByRef aEntidad As PROFORMA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PROFORMA.
    ''' </summary>
    ''' <param name="ID_PROFORMA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPROFORMA(ByVal ID_PROFORMA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As PROFORMA
        Try
            Dim lEntidad As New PROFORMA
            lEntidad.ID_PROFORMA = ID_PROFORMA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
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
    ''' <param name="aTIPOS_GENERALES">Recuperar registro foraneo de la Entidad TIPOS_GENERALES.</param>
    ''' <param name="aCARGADORA">Recuperar registro foraneo de la Entidad CARGADORA.</param>
    ''' <param name="aSUPERVISOR">Recuperar registro foraneo de la Entidad SUPERVISOR.</param>
    ''' <param name="aPRODUCTO">Recuperar registro foraneo de la Entidad PRODUCTO.</param>
    ''' <param name="aTIPO_TRANSPORTE">Recuperar registro foraneo de la Entidad TIPO_TRANSPORTE.</param>
    ''' <param name="aPROVEEDOR_ROZA">Recuperar registro foraneo de la Entidad PROVEEDOR_ROZA.</param>
    ''' <param name="aCARGADOR">Recuperar registro foraneo de la Entidad CARGADOR.</param>
    ''' <param name="aENVIO">Recuperar registro foraneo de la Entidad ENVIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPROFORMAConForaneas(ByVal aEntidad As PROFORMA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False, Optional ByVal aCARGADORA As Boolean = False, Optional ByVal aSUPERVISOR As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False, Optional ByVal aTIPO_TRANSPORTE As Boolean = False, Optional ByVal aPROVEEDOR_ROZA As Boolean = False, Optional ByVal aCARGADOR As Boolean = False, Optional ByVal aENVIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aTIPOS_GENERALES, aCARGADORA, aSUPERVISOR, aPRODUCTO, aTIPO_TRANSPORTE, aPROVEEDOR_ROZA, aCARGADOR, aENVIO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROFORMA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PROFORMA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPROFORMA(ByVal ID_PROFORMA As Int32) As Integer
        Try
            mEntidad.ID_PROFORMA = ID_PROFORMA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROFORMA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPROFORMA(ByVal aEntidad As PROFORMA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarPROFORMA(ByVal ID_PROFORMA As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal NOPROFORMA As Int32, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal ACCESLOTE As String, ByVal CODTRANSPORT As Int32, ByVal NOMBRES_MOTORISTA As String, ByVal ID_TIPO_CANA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_SUPERVISOR As Int32, ByVal FECHA_QUEMA As DateTime, ByVal FECHA_CORTA As DateTime, ByVal QUEMAPROG As Boolean, ByVal QUEMANOPROG As Boolean, ByVal CANA_VERDE As Boolean, ByVal FECHA_ROZA As DateTime, ByVal FECHA_PATIO As DateTime, ByVal ID_PRODUCTO As Int32, ByVal FIN_LOTE As Boolean, ByVal PLACAVEHIC As String, ByVal ID_TIPOTRANS As Int32, ByVal SERVICIO_ROZA As Boolean, ByVal TRANSPORTE_PROPIO As Boolean, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_CARGADOR As Int32, ByVal TIPO_TARIFA_CARGADORA As Int32, ByVal ID_MOTORISTA As Int32, ByVal OBSERVACIONES As String, ByVal ID_ENVIO As Int32, ByVal ESTADO As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal TONELADAS As Decimal, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal FECHA_MADURANTE As DateTime, ByVal OBSERVA_ANUL As String, ByVal USUARIO_ANUL As String, ByVal FECHA_ANUL As DateTime, ByVal ES_QUERQUEO As Boolean, ByVal ES_BARRIDA As Boolean, ByVal ID_PROVEE_QQ As Integer) As Integer
        Try
            Dim lEntidad As New PROFORMA
            lEntidad.ID_PROFORMA = ID_PROFORMA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.NOPROFORMA = NOPROFORMA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_SUPERVISOR = ID_SUPERVISOR
            lEntidad.FECHA_QUEMA = FECHA_QUEMA
            lEntidad.FECHA_CORTA = FECHA_CORTA
            lEntidad.QUEMAPROG = QUEMAPROG
            lEntidad.QUEMANOPROG = QUEMANOPROG
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.FECHA_PATIO = FECHA_PATIO
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.FIN_LOTE = FIN_LOTE
            lEntidad.PLACAVEHIC = PLACAVEHIC
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.SERVICIO_ROZA = SERVICIO_ROZA
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.TIPO_TARIFA_CARGADORA = TIPO_TARIFA_CARGADORA
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.ESTADO = ESTADO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.TONELADAS = TONELADAS
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.FECHA_MADURANTE = FECHA_MADURANTE
            lEntidad.OBSERVA_ANUL = OBSERVA_ANUL
            lEntidad.USUARIO_ANUL = USUARIO_ANUL
            lEntidad.FECHA_ANUL = FECHA_ANUL
            lEntidad.ES_QUERQUEO = ES_QUERQUEO
            lEntidad.ES_BARRIDA = ES_BARRIDA
            lEntidad.ID_PROVEE_QQ = ID_PROVEE_QQ
            Return Me.ActualizarPROFORMA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarPROFORMA(ByVal ID_PROFORMA As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal NOPROFORMA As Int32, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal ACCESLOTE As String, ByVal CODTRANSPORT As Int32, ByVal NOMBRES_MOTORISTA As String, ByVal ID_TIPO_CANA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_SUPERVISOR As Int32, ByVal FECHA_QUEMA As DateTime, ByVal FECHA_CORTA As DateTime, ByVal QUEMAPROG As Boolean, ByVal QUEMANOPROG As Boolean, ByVal CANA_VERDE As Boolean, ByVal FECHA_ROZA As DateTime, ByVal FECHA_PATIO As DateTime, ByVal ID_PRODUCTO As Int32, ByVal FIN_LOTE As Boolean, ByVal PLACAVEHIC As String, ByVal ID_TIPOTRANS As Int32, ByVal SERVICIO_ROZA As Boolean, ByVal TRANSPORTE_PROPIO As Boolean, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_CARGADOR As Int32, ByVal TIPO_TARIFA_CARGADORA As Int32, ByVal ID_MOTORISTA As Int32, ByVal OBSERVACIONES As String, ByVal ID_ENVIO As Int32, ByVal ESTADO As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal TONELADAS As Decimal, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal FECHA_MADURANTE As DateTime, ByVal OBSERVA_ANUL As String, ByVal USUARIO_ANUL As String, ByVal FECHA_ANUL As DateTime, ByVal ES_QUERQUEO As Boolean, ByVal ES_BARRIDA As Boolean, ByVal ID_PROVEE_QQ As Integer) As Integer
        Try
            Dim lEntidad As New PROFORMA
            lEntidad.ID_PROFORMA = ID_PROFORMA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.NOPROFORMA = NOPROFORMA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_SUPERVISOR = ID_SUPERVISOR
            lEntidad.FECHA_QUEMA = FECHA_QUEMA
            lEntidad.FECHA_CORTA = FECHA_CORTA
            lEntidad.QUEMAPROG = QUEMAPROG
            lEntidad.QUEMANOPROG = QUEMANOPROG
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.FECHA_PATIO = FECHA_PATIO
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.FIN_LOTE = FIN_LOTE
            lEntidad.PLACAVEHIC = PLACAVEHIC
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.SERVICIO_ROZA = SERVICIO_ROZA
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.TIPO_TARIFA_CARGADORA = TIPO_TARIFA_CARGADORA
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.ESTADO = ESTADO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.TONELADAS = TONELADAS
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.FECHA_MADURANTE = FECHA_MADURANTE
            lEntidad.OBSERVA_ANUL = OBSERVA_ANUL
            lEntidad.USUARIO_ANUL = USUARIO_ANUL
            lEntidad.FECHA_ANUL = FECHA_ANUL
            lEntidad.ES_QUERQUEO = ES_QUERQUEO
            lEntidad.ES_BARRIDA = ES_BARRIDA
            lEntidad.ID_PROVEE_QQ = ID_PROVEE_QQ
            Return Me.ActualizarPROFORMA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	11/02/2018	Created
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
    ''' 	[GenApp]	11/02/2018	Created
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorTIPOS_GENERALES(ID_TIPO, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorCARGADORA(ID_CARGADORA, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSUPERVISOR(ByVal ID_SUPERVISOR As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorSUPERVISOR(ID_SUPERVISOR, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PRODUCTO .
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorPRODUCTO(ID_PRODUCTO, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_TRANSPORTE .
    ''' </summary>
    ''' <param name="ID_TIPOTRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_TRANSPORTE(ByVal ID_TIPOTRANS As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorTIPO_TRANSPORTE(ID_TIPOTRANS, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorPROVEEDOR_ROZA(ID_PROVEEDOR_ROZA, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCARGADOR(ByVal ID_CARGADOR As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorCARGADOR(ID_CARGADOR, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ENVIO .
    ''' </summary>
    ''' <param name="ID_ENVIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorENVIO(ByVal ID_ENVIO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROFORMA
        Try
            Dim mListaPROFORMA As New ListaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorENVIO(ID_ENVIO, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA in  mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PROFORMA )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_TIPO_CANA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_CARGADORA = (New cCARGADORA).ObtenerCARGADORA(aEntidad.ID_CARGADORA)
        aEntidad.fkID_SUPERVISOR = (New cSUPERVISOR).ObtenerSUPERVISOR(aEntidad.ID_SUPERVISOR)
        aEntidad.fkID_PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
        aEntidad.fkID_TIPOTRANS = (New cTIPO_TRANSPORTE).ObtenerTIPO_TRANSPORTE(aEntidad.ID_TIPOTRANS)
        aEntidad.fkID_PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(aEntidad.ID_PROVEEDOR_ROZA)
        aEntidad.fkID_CARGADOR = (New cCARGADOR).ObtenerCARGADOR(aEntidad.ID_CARGADOR)
        aEntidad.fkID_ENVIO = (New cENVIO).ObtenerENVIO(aEntidad.ID_ENVIO)
        aEntidad.fkID_TIPO_ROZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_ALZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
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
    ''' 	[GenApp]	11/02/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PROFORMA )
    End Sub

#End Region

End Class
