''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cREQENCA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cREQENCA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbREQENCA()
    Private mEntidad as New REQENCA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREQENCA
        Try
            Dim mListaREQENCA As New ListaREQENCA
            mListaREQENCA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaREQENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREQENCA
            If Not mListaREQENCA Is Nothing Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREQENCA
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerREQENCA(ByRef aEntidad As REQENCA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla REQENCA.
    ''' </summary>
    ''' <param name="ID_REQENCA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerREQENCA(ByVal ID_REQENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As REQENCA
        Try
            Dim lEntidad As New REQENCA
            lEntidad.ID_REQENCA = ID_REQENCA
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
    ''' <param name="aPERIODOREQ">Recuperar registro foraneo de la Entidad PERIODOREQ.</param>
    ''' <param name="aSECCION">Recuperar registro foraneo de la Entidad SECCION.</param>
    ''' <param name="aSOLICITANTE">Recuperar registro foraneo de la Entidad SOLICITANTE.</param>
    ''' <param name="aREQETAPA">Recuperar registro foraneo de la Entidad REQETAPA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerREQENCAConForaneas(ByVal aEntidad As REQENCA, Optional ByVal aPERIODOREQ As Boolean = False, Optional ByVal aSECCION As Boolean = False, Optional ByVal aSOLICITANTE As Boolean = False, Optional ByVal aREQETAPA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPERIODOREQ, aSECCION, aSOLICITANTE, aREQETAPA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla REQENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_REQENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarREQENCA(ByVal ID_REQENCA As Int32) As Integer
        Try
            mEntidad.ID_REQENCA = ID_REQENCA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla REQENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarREQENCA(ByVal aEntidad As REQENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarREQENCA(ByVal ID_REQENCA As Int32, ByVal ID_PERIODOREQ As Int32, ByVal ID_SECCION As Int32, ByVal ID_SOLICITANTE As Int32, ByVal NO_REQ As Int32, ByVal FECHA_EMISION As DateTime, ByVal NO_REQ_PH As String, ByVal FECHA_REQ_PH As DateTime, ByVal NO_ORDEN_PH As String, ByVal FECHA_ORDEN_PH As DateTime, ByVal TOTAL_ORDEN_PH As Decimal, ByVal AFECTO_ORDEN_PH As Decimal, ByVal IVA_ORDEN_PH As Decimal, ByVal NO_INGRESO_ALM As String, ByVal FECHA_INGRESO_ALM As DateTime, ByVal NO_QUEDAN As String, ByVal FECHA_QUEDAN As DateTime, ByVal USO As String, ByVal USUARIO_APROB As String, ByVal FECHA_APROB As DateTime, ByVal USUARIO_NOAPROB As String, ByVal FECHA_NOAPROB As DateTime, ByVal USUARIO_ANUL As String, ByVal FECHA_ANUL As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODI_REQ As String, ByVal ORDEN_LOCAL As Boolean, ByVal FECHA_INGRESO_EST As DateTime, ByVal COMENTARIO_EST As String, ByVal TOTAL_INGRESO_ALM As Decimal, ByVal AFECTO_INGRESO_ALM As Decimal, ByVal IVA_INGRESO_ALM As Decimal, ByVal TOTAL_QUEDAN As Decimal, ByVal AFECTO_QUEDAN As Decimal, ByVal IVA_QUEDAN As Decimal, ByVal SECCION As String, ByVal EQUIPO As String, ByVal PROPOSITO As Int32, ByVal COMPRA_LOCAL As Boolean, ByVal FECHA_MAX_SUMIN As DateTime, ByVal FECHA_RECIBOREQ As DateTime, ByVal PROVEE_INVITADOS As String, ByVal PROVEE_ADJUDICADO_ORDEN As String, ByVal FECHA_ESTI_INGRESO_ORDEN As DateTime, ByVal TIPO_DOCCOMPRA_ALM As Int32, ByVal NO_DOCCOMPRA_ALM As String, ByVal NO_CHEQUE_CHQ As String, ByVal BANCO_CHQ As String, ByVal FECHA_CHQ As DateTime, ByVal MONTO_CHQ As Decimal, ByVal ID_REQETAPA As Int32) As Integer
        Try
            Dim lEntidad As New REQENCA
            lEntidad.ID_REQENCA = ID_REQENCA
            lEntidad.ID_PERIODOREQ = ID_PERIODOREQ
            lEntidad.ID_SECCION = ID_SECCION
            lEntidad.ID_SOLICITANTE = ID_SOLICITANTE
            lEntidad.NO_REQ = NO_REQ
            lEntidad.FECHA_EMISION = FECHA_EMISION
            lEntidad.NO_REQ_PH = NO_REQ_PH
            lEntidad.FECHA_REQ_PH = FECHA_REQ_PH
            lEntidad.NO_ORDEN_PH = NO_ORDEN_PH
            lEntidad.FECHA_ORDEN_PH = FECHA_ORDEN_PH
            lEntidad.TOTAL_ORDEN_PH = TOTAL_ORDEN_PH
            lEntidad.AFECTO_ORDEN_PH = AFECTO_ORDEN_PH
            lEntidad.IVA_ORDEN_PH = IVA_ORDEN_PH
            lEntidad.NO_INGRESO_ALM = NO_INGRESO_ALM
            lEntidad.FECHA_INGRESO_ALM = FECHA_INGRESO_ALM
            lEntidad.NO_QUEDAN = NO_QUEDAN
            lEntidad.FECHA_QUEDAN = FECHA_QUEDAN
            lEntidad.USO = USO
            lEntidad.USUARIO_APROB = USUARIO_APROB
            lEntidad.FECHA_APROB = FECHA_APROB
            lEntidad.USUARIO_NOAPROB = USUARIO_NOAPROB
            lEntidad.FECHA_NOAPROB = FECHA_NOAPROB
            lEntidad.USUARIO_ANUL = USUARIO_ANUL
            lEntidad.FECHA_ANUL = FECHA_ANUL
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODI_REQ = CODI_REQ
            lEntidad.ORDEN_LOCAL = ORDEN_LOCAL
            lEntidad.FECHA_INGRESO_EST = FECHA_INGRESO_EST
            lEntidad.COMENTARIO_EST = COMENTARIO_EST
            lEntidad.TOTAL_INGRESO_ALM = TOTAL_INGRESO_ALM
            lEntidad.AFECTO_INGRESO_ALM = AFECTO_INGRESO_ALM
            lEntidad.IVA_INGRESO_ALM = IVA_INGRESO_ALM
            lEntidad.TOTAL_QUEDAN = TOTAL_QUEDAN
            lEntidad.AFECTO_QUEDAN = AFECTO_QUEDAN
            lEntidad.IVA_QUEDAN = IVA_QUEDAN
            lEntidad.SECCION = SECCION
            lEntidad.EQUIPO = EQUIPO
            lEntidad.PROPOSITO = PROPOSITO
            lEntidad.COMPRA_LOCAL = COMPRA_LOCAL
            lEntidad.FECHA_MAX_SUMIN = FECHA_MAX_SUMIN
            lEntidad.FECHA_RECIBOREQ = FECHA_RECIBOREQ
            lEntidad.PROVEE_INVITADOS = PROVEE_INVITADOS
            lEntidad.PROVEE_ADJUDICADO_ORDEN = PROVEE_ADJUDICADO_ORDEN
            lEntidad.FECHA_ESTI_INGRESO_ORDEN = FECHA_ESTI_INGRESO_ORDEN
            lEntidad.TIPO_DOCCOMPRA_ALM = TIPO_DOCCOMPRA_ALM
            lEntidad.NO_DOCCOMPRA_ALM = NO_DOCCOMPRA_ALM
            lEntidad.NO_CHEQUE_CHQ = NO_CHEQUE_CHQ
            lEntidad.BANCO_CHQ = BANCO_CHQ
            lEntidad.FECHA_CHQ = FECHA_CHQ
            lEntidad.MONTO_CHQ = MONTO_CHQ
            lEntidad.ID_REQETAPA = ID_REQETAPA
            Return Me.ActualizarREQENCA(lEntidad)
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarREQENCA(ByVal ID_REQENCA As Int32, ByVal ID_PERIODOREQ As Int32, ByVal ID_SECCION As Int32, ByVal ID_SOLICITANTE As Int32, ByVal NO_REQ As Int32, ByVal FECHA_EMISION As DateTime, ByVal NO_REQ_PH As String, ByVal FECHA_REQ_PH As DateTime, ByVal NO_ORDEN_PH As String, ByVal FECHA_ORDEN_PH As DateTime, ByVal TOTAL_ORDEN_PH As Decimal, ByVal AFECTO_ORDEN_PH As Decimal, ByVal IVA_ORDEN_PH As Decimal, ByVal NO_INGRESO_ALM As String, ByVal FECHA_INGRESO_ALM As DateTime, ByVal NO_QUEDAN As String, ByVal FECHA_QUEDAN As DateTime, ByVal USO As String, ByVal USUARIO_APROB As String, ByVal FECHA_APROB As DateTime, ByVal USUARIO_NOAPROB As String, ByVal FECHA_NOAPROB As DateTime, ByVal USUARIO_ANUL As String, ByVal FECHA_ANUL As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODI_REQ As String, ByVal ORDEN_LOCAL As Boolean, ByVal FECHA_INGRESO_EST As DateTime, ByVal COMENTARIO_EST As String, ByVal TOTAL_INGRESO_ALM As Decimal, ByVal AFECTO_INGRESO_ALM As Decimal, ByVal IVA_INGRESO_ALM As Decimal, ByVal TOTAL_QUEDAN As Decimal, ByVal AFECTO_QUEDAN As Decimal, ByVal IVA_QUEDAN As Decimal, ByVal SECCION As String, ByVal EQUIPO As String, ByVal PROPOSITO As Int32, ByVal COMPRA_LOCAL As Boolean, ByVal FECHA_MAX_SUMIN As DateTime, ByVal FECHA_RECIBOREQ As DateTime, ByVal PROVEE_INVITADOS As String, ByVal PROVEE_ADJUDICADO_ORDEN As String, ByVal FECHA_ESTI_INGRESO_ORDEN As DateTime, ByVal TIPO_DOCCOMPRA_ALM As Int32, ByVal NO_DOCCOMPRA_ALM As String, ByVal NO_CHEQUE_CHQ As String, ByVal BANCO_CHQ As String, ByVal FECHA_CHQ As DateTime, ByVal MONTO_CHQ As Decimal, ByVal ID_REQETAPA As Int32) As Integer
        Try
            Dim lEntidad As New REQENCA
            lEntidad.ID_REQENCA = ID_REQENCA
            lEntidad.ID_PERIODOREQ = ID_PERIODOREQ
            lEntidad.ID_SECCION = ID_SECCION
            lEntidad.ID_SOLICITANTE = ID_SOLICITANTE
            lEntidad.NO_REQ = NO_REQ
            lEntidad.FECHA_EMISION = FECHA_EMISION
            lEntidad.NO_REQ_PH = NO_REQ_PH
            lEntidad.FECHA_REQ_PH = FECHA_REQ_PH
            lEntidad.NO_ORDEN_PH = NO_ORDEN_PH
            lEntidad.FECHA_ORDEN_PH = FECHA_ORDEN_PH
            lEntidad.TOTAL_ORDEN_PH = TOTAL_ORDEN_PH
            lEntidad.AFECTO_ORDEN_PH = AFECTO_ORDEN_PH
            lEntidad.IVA_ORDEN_PH = IVA_ORDEN_PH
            lEntidad.NO_INGRESO_ALM = NO_INGRESO_ALM
            lEntidad.FECHA_INGRESO_ALM = FECHA_INGRESO_ALM
            lEntidad.NO_QUEDAN = NO_QUEDAN
            lEntidad.FECHA_QUEDAN = FECHA_QUEDAN
            lEntidad.USO = USO
            lEntidad.USUARIO_APROB = USUARIO_APROB
            lEntidad.FECHA_APROB = FECHA_APROB
            lEntidad.USUARIO_NOAPROB = USUARIO_NOAPROB
            lEntidad.FECHA_NOAPROB = FECHA_NOAPROB
            lEntidad.USUARIO_ANUL = USUARIO_ANUL
            lEntidad.FECHA_ANUL = FECHA_ANUL
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODI_REQ = CODI_REQ
            lEntidad.ORDEN_LOCAL = ORDEN_LOCAL
            lEntidad.FECHA_INGRESO_EST = FECHA_INGRESO_EST
            lEntidad.COMENTARIO_EST = COMENTARIO_EST
            lEntidad.TOTAL_INGRESO_ALM = TOTAL_INGRESO_ALM
            lEntidad.AFECTO_INGRESO_ALM = AFECTO_INGRESO_ALM
            lEntidad.IVA_INGRESO_ALM = IVA_INGRESO_ALM
            lEntidad.TOTAL_QUEDAN = TOTAL_QUEDAN
            lEntidad.AFECTO_QUEDAN = AFECTO_QUEDAN
            lEntidad.IVA_QUEDAN = IVA_QUEDAN
            lEntidad.SECCION = SECCION
            lEntidad.EQUIPO = EQUIPO
            lEntidad.PROPOSITO = PROPOSITO
            lEntidad.COMPRA_LOCAL = COMPRA_LOCAL
            lEntidad.FECHA_MAX_SUMIN = FECHA_MAX_SUMIN
            lEntidad.FECHA_RECIBOREQ = FECHA_RECIBOREQ
            lEntidad.PROVEE_INVITADOS = PROVEE_INVITADOS
            lEntidad.PROVEE_ADJUDICADO_ORDEN = PROVEE_ADJUDICADO_ORDEN
            lEntidad.FECHA_ESTI_INGRESO_ORDEN = FECHA_ESTI_INGRESO_ORDEN
            lEntidad.TIPO_DOCCOMPRA_ALM = TIPO_DOCCOMPRA_ALM
            lEntidad.NO_DOCCOMPRA_ALM = NO_DOCCOMPRA_ALM
            lEntidad.NO_CHEQUE_CHQ = NO_CHEQUE_CHQ
            lEntidad.BANCO_CHQ = BANCO_CHQ
            lEntidad.FECHA_CHQ = FECHA_CHQ
            lEntidad.MONTO_CHQ = MONTO_CHQ
            lEntidad.ID_REQETAPA = ID_REQETAPA
            Return Me.ActualizarREQENCA(lEntidad)
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
    ''' 	[GenApp]	10/06/2015	Created
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
    ''' 	[GenApp]	10/06/2015	Created
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
    ''' la Tabla PERIODOREQ .
    ''' </summary>
    ''' <param name="ID_PERIODOREQ"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPERIODOREQ(ByVal ID_PERIODOREQ As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREQENCA
        Try
            Dim mListaREQENCA As New ListaREQENCA
            mListaREQENCA = mDb.ObtenerListaPorPERIODOREQ(ID_PERIODOREQ, asColumnaOrden, asTipoOrden)
            If Not mListaREQENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREQENCA
            If Not mListaREQENCA Is Nothing Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREQENCA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SECCION .
    ''' </summary>
    ''' <param name="ID_SECCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSECCION(ByVal ID_SECCION As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREQENCA
        Try
            Dim mListaREQENCA As New ListaREQENCA
            mListaREQENCA = mDb.ObtenerListaPorSECCION(ID_SECCION, asColumnaOrden, asTipoOrden)
            If Not mListaREQENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREQENCA
            If Not mListaREQENCA Is Nothing Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREQENCA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLICITANTE .
    ''' </summary>
    ''' <param name="ID_SOLICITANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLICITANTE(ByVal ID_SOLICITANTE As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREQENCA
        Try
            Dim mListaREQENCA As New ListaREQENCA
            mListaREQENCA = mDb.ObtenerListaPorSOLICITANTE(ID_SOLICITANTE, asColumnaOrden, asTipoOrden)
            If Not mListaREQENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREQENCA
            If Not mListaREQENCA Is Nothing Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREQENCA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla REQETAPA .
    ''' </summary>
    ''' <param name="ID_REQETAPA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorREQETAPA(ByVal ID_REQETAPA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREQENCA
        Try
            Dim mListaREQENCA As New ListaREQENCA
            mListaREQENCA = mDb.ObtenerListaPorREQETAPA(ID_REQETAPA, asColumnaOrden, asTipoOrden)
            If Not mListaREQENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREQENCA
            If Not mListaREQENCA Is Nothing Then
                For Each lEntidad As REQENCA in  mListaREQENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREQENCA
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As REQENCA )
        aEntidad.fkID_PERIODOREQ = (New cPERIODOREQ).ObtenerPERIODOREQ(aEntidad.ID_PERIODOREQ)
        aEntidad.fkID_SECCION = (New cSECCION).ObtenerSECCION(aEntidad.ID_SECCION)
        aEntidad.fkID_SOLICITANTE = (New cSOLICITANTE).ObtenerSOLICITANTE(aEntidad.ID_SOLICITANTE)
        aEntidad.fkID_REQETAPA = (New cREQETAPA).ObtenerREQETAPA(aEntidad.ID_REQETAPA)
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As REQENCA )
    End Sub

#End Region

End Class
