''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cMAESTRO_LOTES
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cMAESTRO_LOTES
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbMAESTRO_LOTES()
    Private mEntidad as New MAESTRO_LOTES
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMAESTRO_LOTES(ByRef aEntidad As MAESTRO_LOTES, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla MAESTRO_LOTES.
    ''' </summary>
    ''' <param name="ID_MAESTRO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As MAESTRO_LOTES
        Try
            Dim lEntidad As New MAESTRO_LOTES
            lEntidad.ID_MAESTRO = ID_MAESTRO
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
    ''' <param name="aCANTON">Recuperar registro foraneo de la Entidad CANTON.</param>
    ''' <param name="aZONAS">Recuperar registro foraneo de la Entidad ZONAS.</param>
    ''' <param name="aSUB_ZONAS">Recuperar registro foraneo de la Entidad SUB_ZONAS.</param>
    ''' <param name="aCOMPORTAMIENTO_CANA">Recuperar registro foraneo de la Entidad COMPORTAMIENTO_CANA.</param>
    ''' <param name="aTIPO_SUELO">Recuperar registro foraneo de la Entidad TIPO_SUELO.</param>
    ''' <param name="aCONDICION_SIEMBRA">Recuperar registro foraneo de la Entidad CONDICION_SIEMBRA.</param>
    ''' <param name="aNIVEL_HUMEDAD">Recuperar registro foraneo de la Entidad NIVEL_HUMEDAD.</param>
    ''' <param name="aTIPOS_GENERALES">Recuperar registro foraneo de la Entidad TIPOS_GENERALES.</param>
    ''' <param name="aAGRONOMO">Recuperar registro foraneo de la Entidad AGRONOMO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMAESTRO_LOTESConForaneas(ByVal aEntidad As MAESTRO_LOTES, Optional ByVal aCANTON As Boolean = False, Optional ByVal aZONAS As Boolean = False, Optional ByVal aSUB_ZONAS As Boolean = False, Optional ByVal aCOMPORTAMIENTO_CANA As Boolean = False, Optional ByVal aTIPO_SUELO As Boolean = False, Optional ByVal aCONDICION_SIEMBRA As Boolean = False, Optional ByVal aNIVEL_HUMEDAD As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False, Optional ByVal aAGRONOMO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCANTON, aZONAS, aSUB_ZONAS, aCOMPORTAMIENTO_CANA, aTIPO_SUELO, aCONDICION_SIEMBRA, aNIVEL_HUMEDAD, aTIPOS_GENERALES, aAGRONOMO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MAESTRO_LOTES que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_MAESTRO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarMAESTRO_LOTES(ByVal ID_MAESTRO As Int32) As Integer
        Try
            mEntidad.ID_MAESTRO = ID_MAESTRO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MAESTRO_LOTES que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarMAESTRO_LOTES(ByVal aEntidad As MAESTRO_LOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal CUI As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CORRELATIVO As String, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_COMER As String, ByVal CODILOTE_COMER As String, ByVal MZ_CULTIVADA As Decimal, ByVal CODIVARIEDA As String, ByVal ID_COMPOR As Int32, ByVal COD_TIPO_SUELO As String, ByVal ID_COND_SIEMBRA As Int32, ByVal ID_NIVEL_HUMEDAD As Int32, ByVal NO_CORTE As Int16, ByVal MSNM As Decimal, ByVal KM_CARRETERA As Decimal, ByVal KM_TIERRA As Decimal, ByVal RIESGO_PIEDRA As Boolean, ByVal FECHA_SIEMBRA As DateTime, ByVal FECHA_CORTE As DateTime, ByVal PROD_TC As Decimal, ByVal PROD_LB As Decimal, ByVal FACTOR_DESPOBLA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODICONTRATO As Int32, ByVal TIPO_DERECHO As Int32, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ID_TIPO_TRANS As Int32, ByVal CODIAGRON As String, ByVal TARIFA_ROZA As Decimal, ByVal TARIFA_ALZA As Decimal, ByVal TARIFA_TRANS As Decimal, ByVal TARIFA_CORTA As Decimal, ByVal TARIFA_LARGA As Decimal, ByVal REPARA_ACCESO As Boolean, ByVal SIN_ACCESO_PROPIO As Boolean, BYVAL HACIENDA AS STRING) As Integer
        Try
            Dim lEntidad As New MAESTRO_LOTES
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.CUI = CUI
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.CODI_CANTON = CODI_CANTON
            lEntidad.ZONA = ZONA
            lEntidad.SUB_ZONA = SUB_ZONA
            lEntidad.CORRELATIVO = CORRELATIVO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_COMER = NOMBRE_COMER
            lEntidad.CODILOTE_COMER = CODILOTE_COMER
            lEntidad.MZ_CULTIVADA = MZ_CULTIVADA
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.ID_COMPOR = ID_COMPOR
            lEntidad.COD_TIPO_SUELO = COD_TIPO_SUELO
            lEntidad.ID_COND_SIEMBRA = ID_COND_SIEMBRA
            lEntidad.ID_NIVEL_HUMEDAD = ID_NIVEL_HUMEDAD
            lEntidad.NO_CORTE = NO_CORTE
            lEntidad.MSNM = MSNM
            lEntidad.KM_CARRETERA = KM_CARRETERA
            lEntidad.KM_TIERRA = KM_TIERRA
            lEntidad.RIESGO_PIEDRA = RIESGO_PIEDRA
            lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRA
            lEntidad.FECHA_CORTE = FECHA_CORTE
            lEntidad.PROD_TC = PROD_TC
            lEntidad.PROD_LB = PROD_LB
            lEntidad.FACTOR_DESPOBLA = FACTOR_DESPOBLA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.TIPO_DERECHO = TIPO_DERECHO
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_TIPO_TRANS = ID_TIPO_TRANS
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.TARIFA_ROZA = TARIFA_ROZA
            lEntidad.TARIFA_ALZA = TARIFA_ALZA
            lEntidad.TARIFA_TRANS = TARIFA_TRANS
            lEntidad.TARIFA_CORTA = TARIFA_CORTA
            lEntidad.TARIFA_LARGA = TARIFA_LARGA
            lEntidad.REPARA_ACCESO = REPARA_ACCESO
            lEntidad.SIN_ACCESO_PROPIO = SIN_ACCESO_PROPIO
            lEntidad.HACIENDA = HACIENDA
            Return Me.ActualizarMAESTRO_LOTES(lEntidad)
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal CUI As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CORRELATIVO As String, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_COMER As String, ByVal CODILOTE_COMER As String, ByVal MZ_CULTIVADA As Decimal, ByVal CODIVARIEDA As String, ByVal ID_COMPOR As Int32, ByVal COD_TIPO_SUELO As String, ByVal ID_COND_SIEMBRA As Int32, ByVal ID_NIVEL_HUMEDAD As Int32, ByVal NO_CORTE As Int16, ByVal MSNM As Decimal, ByVal KM_CARRETERA As Decimal, ByVal KM_TIERRA As Decimal, ByVal RIESGO_PIEDRA As Boolean, ByVal FECHA_SIEMBRA As DateTime, ByVal FECHA_CORTE As DateTime, ByVal PROD_TC As Decimal, ByVal PROD_LB As Decimal, ByVal FACTOR_DESPOBLA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODICONTRATO As Int32, ByVal TIPO_DERECHO As Int32, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ID_TIPO_TRANS As Int32, ByVal CODIAGRON As String, ByVal TARIFA_ROZA As Decimal, ByVal TARIFA_ALZA As Decimal, ByVal TARIFA_TRANS As Decimal, ByVal TARIFA_CORTA As Decimal, ByVal TARIFA_LARGA As Decimal, ByVal REPARA_ACCESO As Boolean, ByVal SIN_ACCESO_PROPIO As Boolean, ByVal HACIENDA As String) As Integer
        Try
            Dim lEntidad As New MAESTRO_LOTES
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.CUI = CUI
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.CODI_CANTON = CODI_CANTON
            lEntidad.ZONA = ZONA
            lEntidad.SUB_ZONA = SUB_ZONA
            lEntidad.CORRELATIVO = CORRELATIVO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_COMER = NOMBRE_COMER
            lEntidad.CODILOTE_COMER = CODILOTE_COMER
            lEntidad.MZ_CULTIVADA = MZ_CULTIVADA
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.ID_COMPOR = ID_COMPOR
            lEntidad.COD_TIPO_SUELO = COD_TIPO_SUELO
            lEntidad.ID_COND_SIEMBRA = ID_COND_SIEMBRA
            lEntidad.ID_NIVEL_HUMEDAD = ID_NIVEL_HUMEDAD
            lEntidad.NO_CORTE = NO_CORTE
            lEntidad.MSNM = MSNM
            lEntidad.KM_CARRETERA = KM_CARRETERA
            lEntidad.KM_TIERRA = KM_TIERRA
            lEntidad.RIESGO_PIEDRA = RIESGO_PIEDRA
            lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRA
            lEntidad.FECHA_CORTE = FECHA_CORTE
            lEntidad.PROD_TC = PROD_TC
            lEntidad.PROD_LB = PROD_LB
            lEntidad.FACTOR_DESPOBLA = FACTOR_DESPOBLA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.TIPO_DERECHO = TIPO_DERECHO
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_TIPO_TRANS = ID_TIPO_TRANS
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.TARIFA_ROZA = TARIFA_ROZA
            lEntidad.TARIFA_ALZA = TARIFA_ALZA
            lEntidad.TARIFA_TRANS = TARIFA_TRANS
            lEntidad.TARIFA_CORTA = TARIFA_CORTA
            lEntidad.TARIFA_LARGA = TARIFA_LARGA
            lEntidad.REPARA_ACCESO = REPARA_ACCESO
            lEntidad.SIN_ACCESO_PROPIO = SIN_ACCESO_PROPIO
            lEntidad.HACIENDA = HACIENDA
            Return Me.ActualizarMAESTRO_LOTES(lEntidad)
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
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' la Tabla CANTON .
    ''' </summary>
    ''' <param name="CODI_CANTON"></param>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCANTON(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorCANTON(CODI_CANTON, CODI_DEPTO, CODI_MUNI, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ZONAS .
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZONAS(ByVal ZONA As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorZONAS(ZONA, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SUB_ZONAS .
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <param name="SUB_ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSUB_ZONAS(ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorSUB_ZONAS(ZONA, SUB_ZONA, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla COMPORTAMIENTO_CANA .
    ''' </summary>
    ''' <param name="ID_COMPOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCOMPORTAMIENTO_CANA(ByVal ID_COMPOR As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorCOMPORTAMIENTO_CANA(ID_COMPOR, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_SUELO .
    ''' </summary>
    ''' <param name="COD_TIPO_SUELO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_SUELO(ByVal COD_TIPO_SUELO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorTIPO_SUELO(COD_TIPO_SUELO, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONDICION_SIEMBRA .
    ''' </summary>
    ''' <param name="ID_COND_SIEMBRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONDICION_SIEMBRA(ByVal ID_COND_SIEMBRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorCONDICION_SIEMBRA(ID_COND_SIEMBRA, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla NIVEL_HUMEDAD .
    ''' </summary>
    ''' <param name="ID_NIVEL_HUMEDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorNIVEL_HUMEDAD(ByVal ID_NIVEL_HUMEDAD As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorNIVEL_HUMEDAD(ID_NIVEL_HUMEDAD, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorTIPOS_GENERALES(ID_TIPO, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla AGRONOMO .
    ''' </summary>
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorAGRONOMO(ByVal CODIAGRON As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorAGRONOMO(CODIAGRON, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES in  mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As MAESTRO_LOTES )
        aEntidad.fkCODI_DEPTO = (New cCANTON).ObtenerCANTON(aEntidad.CODI_CANTON, aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
        aEntidad.fkCODI_MUNI = (New cCANTON).ObtenerCANTON(aEntidad.CODI_CANTON, aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
        aEntidad.fkCODI_CANTON = (New cCANTON).ObtenerCANTON(aEntidad.CODI_CANTON, aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
        aEntidad.fkZONA = (New cZONAS).ObtenerZONAS(aEntidad.ZONA)
        aEntidad.fkSUB_ZONA = (New cSUB_ZONAS).ObtenerSUB_ZONAS(aEntidad.ZONA, aEntidad.SUB_ZONA)
        aEntidad.fkID_COMPOR = (New cCOMPORTAMIENTO_CANA).ObtenerCOMPORTAMIENTO_CANA(aEntidad.ID_COMPOR)
        aEntidad.fkCOD_TIPO_SUELO = (New cTIPO_SUELO).ObtenerTIPO_SUELO(aEntidad.COD_TIPO_SUELO)
        aEntidad.fkID_COND_SIEMBRA = (New cCONDICION_SIEMBRA).ObtenerCONDICION_SIEMBRA(aEntidad.ID_COND_SIEMBRA)
        aEntidad.fkID_NIVEL_HUMEDAD = (New cNIVEL_HUMEDAD).ObtenerNIVEL_HUMEDAD(aEntidad.ID_NIVEL_HUMEDAD)
        aEntidad.fkID_TIPO_CANA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_ROZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_ALZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_TRANS = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkCODIAGRON = (New cAGRONOMO).ObtenerAGRONOMO(aEntidad.CODIAGRON)
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As MAESTRO_LOTES )
    End Sub

#End Region

End Class
