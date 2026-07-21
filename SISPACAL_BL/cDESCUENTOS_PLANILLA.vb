''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cDESCUENTOS_PLANILLA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla DESCUENTOS_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cDESCUENTOS_PLANILLA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbDESCUENTOS_PLANILLA()
    Private mEntidad as New DESCUENTOS_PLANILLA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDESCUENTOS_PLANILLA(ByRef aEntidad As DESCUENTOS_PLANILLA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla DESCUENTOS_PLANILLA.
    ''' </summary>
    ''' <param name="ID_DESCUENTO_PLANILLA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As DESCUENTOS_PLANILLA
        Try
            Dim lEntidad As New DESCUENTOS_PLANILLA
            lEntidad.ID_DESCUENTO_PLANILLA = ID_DESCUENTO_PLANILLA
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
    ''' <param name="aCATORCENA_ZAFRA">Recuperar registro foraneo de la Entidad CATORCENA_ZAFRA.</param>
    ''' <param name="aPLANILLA">Recuperar registro foraneo de la Entidad PLANILLA.</param>
    ''' <param name="aTIPO_PLANILLA">Recuperar registro foraneo de la Entidad TIPO_PLANILLA.</param>
    ''' <param name="aTIPO_DESCUENTO">Recuperar registro foraneo de la Entidad TIPO_DESCUENTO.</param>
    ''' <param name="aAPLICACION_DESCTO">Recuperar registro foraneo de la Entidad APLICACION_DESCTO.</param>
    ''' <param name="aBANCOS">Recuperar registro foraneo de la Entidad BANCOS.</param>
    ''' <param name="aCREDITO_ENCA">Recuperar registro foraneo de la Entidad CREDITO_ENCA.</param>
    ''' <param name="aCREDITO_ENCA_TRANS">Recuperar registro foraneo de la Entidad CREDITO_ENCA_TRANS.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDESCUENTOS_PLANILLAConForaneas(ByVal aEntidad As DESCUENTOS_PLANILLA, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aPLANILLA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False, Optional ByVal aTIPO_DESCUENTO As Boolean = False, Optional ByVal aAPLICACION_DESCTO As Boolean = False, Optional ByVal aBANCOS As Boolean = False, Optional ByVal aCREDITO_ENCA As Boolean = False, Optional ByVal aCREDITO_ENCA_TRANS As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCATORCENA_ZAFRA, aPLANILLA, aTIPO_PLANILLA, aTIPO_DESCUENTO, aAPLICACION_DESCTO, aBANCOS, aCREDITO_ENCA, aCREDITO_ENCA_TRANS)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESCUENTOS_PLANILLA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DESCUENTO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32) As Integer
        Try
            mEntidad.ID_DESCUENTO_PLANILLA = ID_DESCUENTO_PLANILLA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESCUENTOS_PLANILLA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDESCUENTOS_PLANILLA(ByVal aEntidad As DESCUENTOS_PLANILLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32, ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal ID_TIPO_DESCTO As Int32, ByVal ID_APLICACION_DESCTO As Int32, ByVal MONTO_DESCUENTO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal IVA As Decimal, ByVal CODIBANCO As Int32, ByVal ID_CREDITO_ENCA As Int32, ByVal ID_CREDITO_ENCA_TRANS As Int32) As Integer
        Try
            Dim lEntidad As New DESCUENTOS_PLANILLA
            lEntidad.ID_DESCUENTO_PLANILLA = ID_DESCUENTO_PLANILLA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.ID_TIPO_DESCTO = ID_TIPO_DESCTO
            lEntidad.ID_APLICACION_DESCTO = ID_APLICACION_DESCTO
            lEntidad.MONTO_DESCUENTO = MONTO_DESCUENTO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.IVA = IVA
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.ID_CREDITO_ENCA_TRANS = ID_CREDITO_ENCA_TRANS
            Return Me.ActualizarDESCUENTOS_PLANILLA(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDESCUENTOS_PLANILLA(ByVal aEntidad As DESCUENTOS_PLANILLA) As Integer
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDESCUENTOS_PLANILLA(ByVal aEntidad As DESCUENTOS_PLANILLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDESCUENTOS_PLANILLA(ByVal ID_DESCUENTO_PLANILLA As Int32, ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal ID_TIPO_DESCTO As Int32, ByVal ID_APLICACION_DESCTO As Int32, ByVal MONTO_DESCUENTO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal IVA As Decimal, ByVal CODIBANCO As Int32, ByVal ID_CREDITO_ENCA As Int32, ByVal ID_CREDITO_ENCA_TRANS As Int32) As Integer
        Try
            Dim lEntidad As New DESCUENTOS_PLANILLA
            lEntidad.ID_DESCUENTO_PLANILLA = ID_DESCUENTO_PLANILLA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.ID_TIPO_DESCTO = ID_TIPO_DESCTO
            lEntidad.ID_APLICACION_DESCTO = ID_APLICACION_DESCTO
            lEntidad.MONTO_DESCUENTO = MONTO_DESCUENTO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.IVA = IVA
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.ID_CREDITO_ENCA_TRANS = ID_CREDITO_ENCA_TRANS
            Return Me.ActualizarDESCUENTOS_PLANILLA(lEntidad)
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
    ''' 	[GenApp]	16/11/2017	Created
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
    ''' 	[GenApp]	16/11/2017	Created
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
    ''' la Tabla CATORCENA_ZAFRA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PLANILLA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_DESCUENTO .
    ''' </summary>
    ''' <param name="ID_TIPO_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_DESCUENTO(ByVal ID_TIPO_DESCTO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorTIPO_DESCUENTO(ID_TIPO_DESCTO, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla APLICACION_DESCTO .
    ''' </summary>
    ''' <param name="ID_APLICACION_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorAPLICACION_DESCTO(ByVal ID_APLICACION_DESCTO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorAPLICACION_DESCTO(ID_APLICACION_DESCTO, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla BANCOS .
    ''' </summary>
    ''' <param name="CODIBANCO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorBANCOS(ByVal CODIBANCO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorBANCOS(CODIBANCO, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CREDITO_ENCA .
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCREDITO_ENCA(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorCREDITO_ENCA(ID_CREDITO_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CREDITO_ENCA_TRANS .
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESCUENTOS_PLANILLA
        Try
            Dim mListaDESCUENTOS_PLANILLA As New ListaDESCUENTOS_PLANILLA
            mListaDESCUENTOS_PLANILLA = mDb.ObtenerListaPorCREDITO_ENCA_TRANS(ID_CREDITO_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaDESCUENTOS_PLANILLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDESCUENTOS_PLANILLA
            If Not mListaDESCUENTOS_PLANILLA Is Nothing Then
                For Each lEntidad As DESCUENTOS_PLANILLA in  mListaDESCUENTOS_PLANILLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDESCUENTOS_PLANILLA
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As DESCUENTOS_PLANILLA )
        aEntidad.fkID_CATORCENA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
        aEntidad.fkCODIPROVEEDOR_TRANSPORTISTA = (New cPLANILLA).ObtenerPLANILLA(aEntidad.ID_CATORCENA, aEntidad.CODIPROVEEDOR_TRANSPORTISTA, aEntidad.ID_TIPO_PLANILLA)
        aEntidad.fkID_TIPO_PLANILLA = (New cTIPO_PLANILLA).ObtenerTIPO_PLANILLA(aEntidad.ID_TIPO_PLANILLA)
        aEntidad.fkID_TIPO_DESCTO = (New cTIPO_DESCUENTO).ObtenerTIPO_DESCUENTO(aEntidad.ID_TIPO_DESCTO)
        aEntidad.fkID_APLICACION_DESCTO = (New cAPLICACION_DESCTO).ObtenerAPLICACION_DESCTO(aEntidad.ID_APLICACION_DESCTO)
        aEntidad.fkCODIBANCO = (New cBANCOS).ObtenerBANCOS(aEntidad.CODIBANCO)
        aEntidad.fkID_CREDITO_ENCA = (New cCREDITO_ENCA).ObtenerCREDITO_ENCA(aEntidad.ID_CREDITO_ENCA)
        aEntidad.fkID_CREDITO_ENCA_TRANS = (New cCREDITO_ENCA_TRANS).ObtenerCREDITO_ENCA_TRANS(aEntidad.ID_CREDITO_ENCA_TRANS)
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As DESCUENTOS_PLANILLA )
    End Sub

#End Region

End Class
