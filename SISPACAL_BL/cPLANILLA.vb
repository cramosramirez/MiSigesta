''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPLANILLA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPLANILLA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPLANILLA()
    Private mEntidad as New PLANILLA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA
        Try
            Dim mListaPLANILLA As New ListaPLANILLA
            mListaPLANILLA = mDb.ObtenerListaPorID(ID_CATORCENA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA
            If Not mListaPLANILLA Is Nothing Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPLANILLA(ByRef aEntidad As PLANILLA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PLANILLA.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As PLANILLA
        Try
            Return mDb.ObtenerPlanilla(ID_CATORCENA, ID_TIPO_PLANILLA, CODIPROVEEDOR_TRANSPORTISTA)
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
    ''' <param name="aCATORCENA_ZAFRA">Recuperar registro foraneo de la Entidad CATORCENA_ZAFRA.</param>
    ''' <param name="aTIPO_PLANILLA">Recuperar registro foraneo de la Entidad TIPO_PLANILLA.</param>
    ''' <param name="aCHEQUE_PLANILLA">Recuperar registro foraneo de la Entidad CHEQUE_PLANILLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPLANILLAConForaneas(ByVal aEntidad As PLANILLA, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False, Optional ByVal aCHEQUE_PLANILLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCATORCENA_ZAFRA, aTIPO_PLANILLA, aCHEQUE_PLANILLA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANILLA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) As Integer
        Try
            mEntidad.ID_CATORCENA = ID_CATORCENA
            mEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            mEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANILLA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLANILLA(ByVal aEntidad As PLANILLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal NOMBRE_ZAFRA As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CANT_RECIBOS As Int32, ByVal TONEL_CANA_ENTREGADA As Decimal, ByVal AZUCAR_CATORCENA_REAL As Decimal, ByVal VALOR As Decimal, ByVal IVA As Decimal, ByVal VALOR_BRUTO As Decimal, ByVal RENTA As Decimal, ByVal RETENCION_IVA As Decimal, ByVal DESC_FLETE As Decimal, ByVal DESC_CARGA As Decimal, ByVal DESC_CARGA_CONTRA As Decimal, ByVal DESC_BANCOS As Decimal, ByVal DESC_COMBUSTIBLE As Decimal, ByVal DESC_ANTICIPO As Decimal, ByVal DESC_INTERES As Decimal, ByVal DESC_AGROQUIMICO As Decimal, ByVal DESC_SEGURO As Decimal, ByVal DESC_RESPUESTOS As Decimal, ByVal DESC_OTROS As Decimal, ByVal PAGO_NETO As Decimal, ByVal ES_CONTRIBUYENTE As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DESC_SERVICIO_ROZA As Decimal, ByVal NOMBRE_PROVEE_TRANS As String, ByVal NO_CHEQUE As Int32, ByVal ID_CHEQUE_PLANILLA As Int32, ByVal ID_PLANILLA_BASE As Int32) As Integer
        Try
            Dim lEntidad As New PLANILLA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.NOMBRE_ZAFRA = NOMBRE_ZAFRA
            lEntidad.CODIPROVEE = CODIPROVEE
            lEntidad.CODISOCIO = CODISOCIO
            lEntidad.CANT_RECIBOS = CANT_RECIBOS
            lEntidad.TONEL_CANA_ENTREGADA = TONEL_CANA_ENTREGADA
            lEntidad.AZUCAR_CATORCENA_REAL = AZUCAR_CATORCENA_REAL
            lEntidad.VALOR = VALOR
            lEntidad.IVA = IVA
            lEntidad.VALOR_BRUTO = VALOR_BRUTO
            lEntidad.RENTA = RENTA
            lEntidad.RETENCION_IVA = RETENCION_IVA
            lEntidad.DESC_FLETE = DESC_FLETE
            lEntidad.DESC_CARGA = DESC_CARGA
            lEntidad.DESC_CARGA_CONTRA = DESC_CARGA_CONTRA
            lEntidad.DESC_BANCOS = DESC_BANCOS
            lEntidad.DESC_COMBUSTIBLE = DESC_COMBUSTIBLE
            lEntidad.DESC_ANTICIPO = DESC_ANTICIPO
            lEntidad.DESC_INTERES = DESC_INTERES
            lEntidad.DESC_AGROQUIMICO = DESC_AGROQUIMICO
            lEntidad.DESC_SEGURO = DESC_SEGURO
            lEntidad.DESC_RESPUESTOS = DESC_RESPUESTOS
            lEntidad.DESC_OTROS = DESC_OTROS
            lEntidad.PAGO_NETO = PAGO_NETO
            lEntidad.ES_CONTRIBUYENTE = ES_CONTRIBUYENTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DESC_SERVICIO_ROZA = DESC_SERVICIO_ROZA
            lEntidad.NOMBRE_PROVEE_TRANS = NOMBRE_PROVEE_TRANS
            lEntidad.NO_CHEQUE = NO_CHEQUE
            lEntidad.ID_CHEQUE_PLANILLA = ID_CHEQUE_PLANILLA
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            Return Me.AgregarPLANILLA(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPLANILLA(ByVal aEntidad As PLANILLA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANILLA(ByVal aEntidad As PLANILLA) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANILLA(ByVal aEntidad As PLANILLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal NOMBRE_ZAFRA As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CANT_RECIBOS As Int32, ByVal TONEL_CANA_ENTREGADA As Decimal, ByVal AZUCAR_CATORCENA_REAL As Decimal, ByVal VALOR As Decimal, ByVal IVA As Decimal, ByVal VALOR_BRUTO As Decimal, ByVal RENTA As Decimal, ByVal RETENCION_IVA As Decimal, ByVal DESC_FLETE As Decimal, ByVal DESC_CARGA As Decimal, ByVal DESC_CARGA_CONTRA As Decimal, ByVal DESC_BANCOS As Decimal, ByVal DESC_COMBUSTIBLE As Decimal, ByVal DESC_ANTICIPO As Decimal, ByVal DESC_INTERES As Decimal, ByVal DESC_AGROQUIMICO As Decimal, ByVal DESC_SEGURO As Decimal, ByVal DESC_RESPUESTOS As Decimal, ByVal DESC_OTROS As Decimal, ByVal PAGO_NETO As Decimal, ByVal ES_CONTRIBUYENTE As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DESC_SERVICIO_ROZA As Decimal, ByVal NOMBRE_PROVEE_TRANS As String, ByVal NO_CHEQUE As Int32, ByVal ID_CHEQUE_PLANILLA As Int32, ByVal ID_PLANILLA_BASE As Int32) As Integer
        Try
            Dim lEntidad As New PLANILLA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.NOMBRE_ZAFRA = NOMBRE_ZAFRA
            lEntidad.CODIPROVEE = CODIPROVEE
            lEntidad.CODISOCIO = CODISOCIO
            lEntidad.CANT_RECIBOS = CANT_RECIBOS
            lEntidad.TONEL_CANA_ENTREGADA = TONEL_CANA_ENTREGADA
            lEntidad.AZUCAR_CATORCENA_REAL = AZUCAR_CATORCENA_REAL
            lEntidad.VALOR = VALOR
            lEntidad.IVA = IVA
            lEntidad.VALOR_BRUTO = VALOR_BRUTO
            lEntidad.RENTA = RENTA
            lEntidad.RETENCION_IVA = RETENCION_IVA
            lEntidad.DESC_FLETE = DESC_FLETE
            lEntidad.DESC_CARGA = DESC_CARGA
            lEntidad.DESC_CARGA_CONTRA = DESC_CARGA_CONTRA
            lEntidad.DESC_BANCOS = DESC_BANCOS
            lEntidad.DESC_COMBUSTIBLE = DESC_COMBUSTIBLE
            lEntidad.DESC_ANTICIPO = DESC_ANTICIPO
            lEntidad.DESC_INTERES = DESC_INTERES
            lEntidad.DESC_AGROQUIMICO = DESC_AGROQUIMICO
            lEntidad.DESC_SEGURO = DESC_SEGURO
            lEntidad.DESC_RESPUESTOS = DESC_RESPUESTOS
            lEntidad.DESC_OTROS = DESC_OTROS
            lEntidad.PAGO_NETO = PAGO_NETO
            lEntidad.ES_CONTRIBUYENTE = ES_CONTRIBUYENTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DESC_SERVICIO_ROZA = DESC_SERVICIO_ROZA
            lEntidad.NOMBRE_PROVEE_TRANS = NOMBRE_PROVEE_TRANS
            lEntidad.NO_CHEQUE = NO_CHEQUE
            lEntidad.ID_CHEQUE_PLANILLA = ID_CHEQUE_PLANILLA
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            Return Me.ActualizarPLANILLA(lEntidad)
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
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(ID_CATORCENA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
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
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ID_CATORCENA, ID_TIPO_PLANILLA, ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CATORCENA_ZAFRA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA
        Try
            Dim mListaPLANILLA As New ListaPLANILLA
            mListaPLANILLA = mDb.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA, asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA
            If Not mListaPLANILLA Is Nothing Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_PLANILLA .
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA
        Try
            Dim mListaPLANILLA As New ListaPLANILLA
            mListaPLANILLA = mDb.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA
            If Not mListaPLANILLA Is Nothing Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CHEQUE_PLANILLA .
    ''' </summary>
    ''' <param name="ID_CHEQUE_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCHEQUE_PLANILLA(ByVal ID_CHEQUE_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA
        Try
            Dim mListaPLANILLA As New ListaPLANILLA
            mListaPLANILLA = mDb.ObtenerListaPorCHEQUE_PLANILLA(ID_CHEQUE_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA
            If Not mListaPLANILLA Is Nothing Then
                For Each lEntidad As PLANILLA in  mListaPLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PLANILLA )
        aEntidad.fkID_CATORCENA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
        aEntidad.fkID_TIPO_PLANILLA = (New cTIPO_PLANILLA).ObtenerTIPO_PLANILLA(aEntidad.ID_TIPO_PLANILLA)
        aEntidad.fkID_CHEQUE_PLANILLA = (New cCHEQUE_PLANILLA).ObtenerCHEQUE_PLANILLA(aEntidad.ID_CHEQUE_PLANILLA)
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PLANILLA )
    End Sub

#End Region

End Class
