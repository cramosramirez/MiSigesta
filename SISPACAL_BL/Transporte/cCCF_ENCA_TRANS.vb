''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCCF_ENCA_TRANS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CCF_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCCF_ENCA_TRANS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCCF_ENCA_TRANS()
    Private mEntidad as New CCF_ENCA_TRANS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCCF_ENCA_TRANS(ByRef aEntidad As CCF_ENCA_TRANS, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CCF_ENCA_TRANS.
    ''' </summary>
    ''' <param name="ID_CCF_TRANS"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCCF_ENCA_TRANS(ByVal ID_CCF_TRANS As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CCF_ENCA_TRANS
        Try
            Dim lEntidad As New CCF_ENCA_TRANS
            lEntidad.ID_CCF_TRANS = ID_CCF_TRANS
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
    ''' <param name="aTRANSPORTISTA">Recuperar registro foraneo de la Entidad TRANSPORTISTA.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aSOLIC_ENCA_TRANS">Recuperar registro foraneo de la Entidad SOLIC_ENCA_TRANS.</param>
    ''' <param name="aCUENTA_FINAN">Recuperar registro foraneo de la Entidad CUENTA_FINAN.</param>
    ''' <param name="aTIPO_COMPROB">Recuperar registro foraneo de la Entidad TIPO_COMPROB.</param>
    ''' <param name="aPROVEEDOR_AGRICOLA">Recuperar registro foraneo de la Entidad PROVEEDOR_AGRICOLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCCF_ENCA_TRANSConForaneas(ByVal aEntidad As CCF_ENCA_TRANS, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aSOLIC_ENCA_TRANS As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False, Optional ByVal aTIPO_COMPROB As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aTRANSPORTISTA, aZAFRA, aSOLIC_ENCA_TRANS, aCUENTA_FINAN, aTIPO_COMPROB, aPROVEEDOR_AGRICOLA)
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCCF_ENCA_TRANS(ByVal ID_CCF_TRANS As Int32, ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal ID_TIPO_COMPROB As Int32, ByVal ID_PROVEE As Int32, ByVal NO_CCF As String, ByVal CONDI_COMPRA As Int32, ByVal UID_CCF As Guid, ByVal FECHA As DateTime, ByVal SUB_TOTAL As Decimal, ByVal DESCTO_PORC As Decimal, ByVal DESCTO_MONTO As Decimal, ByVal SUMAS As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal CESC As Decimal) As Integer
        Try
            Dim lEntidad As New CCF_ENCA_TRANS
            lEntidad.ID_CCF_TRANS = ID_CCF_TRANS
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.ID_TIPO_COMPROB = ID_TIPO_COMPROB
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.NO_CCF = NO_CCF
            lEntidad.CONDI_COMPRA = CONDI_COMPRA
            lEntidad.UID_CCF = UID_CCF
            lEntidad.FECHA = FECHA
            lEntidad.SUB_TOTAL = SUB_TOTAL
            lEntidad.DESCTO_PORC = DESCTO_PORC
            lEntidad.DESCTO_MONTO = DESCTO_MONTO
            lEntidad.SUMAS = SUMAS
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.CESC = CESC
            Return Me.ActualizarCCF_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCCF_ENCA_TRANS(ByVal aEntidad As CCF_ENCA_TRANS) As Integer
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCCF_ENCA_TRANS(ByVal aEntidad As CCF_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCCF_ENCA_TRANS(ByVal ID_CCF_TRANS As Int32, ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal ID_TIPO_COMPROB As Int32, ByVal ID_PROVEE As Int32, ByVal NO_CCF As String, ByVal CONDI_COMPRA As Int32, ByVal UID_CCF As Guid, ByVal FECHA As DateTime, ByVal SUB_TOTAL As Decimal, ByVal DESCTO_PORC As Decimal, ByVal DESCTO_MONTO As Decimal, ByVal SUMAS As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal CESC As Decimal) As Integer
        Try
            Dim lEntidad As New CCF_ENCA_TRANS
            lEntidad.ID_CCF_TRANS = ID_CCF_TRANS
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.ID_TIPO_COMPROB = ID_TIPO_COMPROB
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.NO_CCF = NO_CCF
            lEntidad.CONDI_COMPRA = CONDI_COMPRA
            lEntidad.UID_CCF = UID_CCF
            lEntidad.FECHA = FECHA
            lEntidad.SUB_TOTAL = SUB_TOTAL
            lEntidad.DESCTO_PORC = DESCTO_PORC
            lEntidad.DESCTO_MONTO = DESCTO_MONTO
            lEntidad.SUMAS = SUMAS
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.CESC = CESC
            Return Me.ActualizarCCF_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	30/11/2017	Created
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
    ''' 	[GenApp]	30/11/2017	Created
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
    ''' la Tabla TRANSPORTISTA .
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT, asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_ENCA_TRANS .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorSOLIC_ENCA_TRANS(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CUENTA_FINAN .
    ''' </summary>
    ''' <param name="ID_CUENTA_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_COMPROB .
    ''' </summary>
    ''' <param name="ID_TIPO_COMPROB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_COMPROB(ByVal ID_TIPO_COMPROB As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorTIPO_COMPROB(ID_TIPO_COMPROB, asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_PROVEE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCCF_ENCA_TRANS
        Try
            Dim mListaCCF_ENCA_TRANS As New ListaCCF_ENCA_TRANS
            mListaCCF_ENCA_TRANS = mDb.ObtenerListaPorPROVEEDOR_AGRICOLA(ID_PROVEE, asColumnaOrden, asTipoOrden)
            If Not mListaCCF_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCCF_ENCA_TRANS
            If Not mListaCCF_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CCF_ENCA_TRANS in  mListaCCF_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCCF_ENCA_TRANS
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CCF_ENCA_TRANS )
        aEntidad.fkCODTRANSPORT = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(aEntidad.CODTRANSPORT)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_SOLICITUD = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(aEntidad.ID_CUENTA_FINAN)
        aEntidad.fkID_TIPO_COMPROB = (New cTIPO_COMPROB).ObtenerTIPO_COMPROB(aEntidad.ID_TIPO_COMPROB)
        aEntidad.fkID_PROVEE = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(aEntidad.ID_PROVEE)
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CCF_ENCA_TRANS )
    End Sub

#End Region

End Class
