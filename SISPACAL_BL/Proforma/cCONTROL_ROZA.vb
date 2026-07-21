''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCONTROL_ROZA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTROL_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTROL_ROZA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTROL_ROZA()
    Private mEntidad as New CONTROL_ROZA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New ListaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA in  mListaCONTROL_ROZA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTROL_ROZA(ByRef aEntidad As CONTROL_ROZA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTROL_ROZA.
    ''' </summary>
    ''' <param name="ID_CONTROL_ROZA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTROL_ROZA(ByVal ID_CONTROL_ROZA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As CONTROL_ROZA
        Try
            Dim lEntidad As New CONTROL_ROZA
            lEntidad.ID_CONTROL_ROZA = ID_CONTROL_ROZA
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
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <param name="aPROVEEDOR_ROZA">Recuperar registro foraneo de la Entidad PROVEEDOR_ROZA.</param>
    ''' <param name="aTIPOS_GENERALES">Recuperar registro foraneo de la Entidad TIPOS_GENERALES.</param>
    ''' <param name="aCONTROL_ROZA_SALDO">Recuperar registro foraneo de la Entidad CONTROL_ROZA_SALDO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCONTROL_ROZAConForaneas(ByVal aEntidad As CONTROL_ROZA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aPROVEEDOR_ROZA As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False, Optional ByVal aCONTROL_ROZA_SALDO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aLOTES, aPROVEEDOR_ROZA, aTIPOS_GENERALES, aCONTROL_ROZA_SALDO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTROL_ROZA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTROL_ROZA(ByVal aEntidad As CONTROL_ROZA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTROL_ROZA(ByVal ID_CONTROL_ROZA As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal DIAZAFRA As Int32, ByVal CONCEPTO As String, ByVal CODIGO_REF As String, ByVal ID_REF As Int32, ByVal ENTRADAS As Decimal, ByVal SALIDAS As Decimal, ByVal SALDO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_HORA_ROZA As DateTime, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal QUEMA_PROGRAMADA As Boolean, ByVal QUEMA_NOPROG As Boolean, ByVal CANA_VERDE As Boolean, ByVal FECHA_HORA_QUEMA As DateTime, ByVal ID_ROZA_SALDO As Int32, ByVal ES_PROYECCION As Boolean, ByVal ES_QUERQUEO As Boolean) As Integer
        Try
            Dim lEntidad As New CONTROL_ROZA
            lEntidad.ID_CONTROL_ROZA = ID_CONTROL_ROZA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.CODIGO_REF = CODIGO_REF
            lEntidad.ID_REF = ID_REF
            lEntidad.ENTRADAS = ENTRADAS
            lEntidad.SALIDAS = SALIDAS
            lEntidad.SALDO = SALDO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_HORA_ROZA = FECHA_HORA_ROZA
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.QUEMA_PROGRAMADA = QUEMA_PROGRAMADA
            lEntidad.QUEMA_NOPROG = QUEMA_NOPROG
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_HORA_QUEMA = FECHA_HORA_QUEMA
            lEntidad.ID_ROZA_SALDO = ID_ROZA_SALDO
            lEntidad.ES_PROYECCION = ES_PROYECCION
            lEntidad.ES_QUERQUEO = ES_QUERQUEO
            Return Me.ActualizarCONTROL_ROZA(lEntidad)
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_ROZA(ByVal ID_CONTROL_ROZA As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal DIAZAFRA As Int32, ByVal CONCEPTO As String, ByVal CODIGO_REF As String, ByVal ID_REF As Int32, ByVal ENTRADAS As Decimal, ByVal SALIDAS As Decimal, ByVal SALDO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_HORA_ROZA As DateTime, ByVal ID_PROVEEDOR_ROZA As Int32, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal QUEMA_PROGRAMADA As Boolean, ByVal QUEMA_NOPROG As Boolean, ByVal CANA_VERDE As Boolean, ByVal FECHA_HORA_QUEMA As DateTime, ByVal ID_ROZA_SALDO As Int32, ByVal ES_PROYECCION As Boolean, ByVal ES_QUERQUEO As Boolean) As Integer
        Try
            Dim lEntidad As New CONTROL_ROZA
            lEntidad.ID_CONTROL_ROZA = ID_CONTROL_ROZA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.CODIGO_REF = CODIGO_REF
            lEntidad.ID_REF = ID_REF
            lEntidad.ENTRADAS = ENTRADAS
            lEntidad.SALIDAS = SALIDAS
            lEntidad.SALDO = SALDO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_HORA_ROZA = FECHA_HORA_ROZA
            lEntidad.ID_PROVEEDOR_ROZA = ID_PROVEEDOR_ROZA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.QUEMA_PROGRAMADA = QUEMA_PROGRAMADA
            lEntidad.QUEMA_NOPROG = QUEMA_NOPROG
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_HORA_QUEMA = FECHA_HORA_QUEMA
            lEntidad.ID_ROZA_SALDO = ID_ROZA_SALDO
            lEntidad.ES_PROYECCION = ES_PROYECCION
            lEntidad.ES_QUERQUEO = ES_QUERQUEO
            Return Me.ActualizarCONTROL_ROZA(lEntidad)
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
    ''' 	[GenApp]	09/01/2018	Created
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
    ''' 	[GenApp]	09/01/2018	Created
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New ListaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA in  mListaCONTROL_ROZA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New ListaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA in  mListaCONTROL_ROZA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New ListaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorPROVEEDOR_ROZA(ID_PROVEEDOR_ROZA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA in  mListaCONTROL_ROZA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New ListaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorTIPOS_GENERALES(ID_TIPO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA in  mListaCONTROL_ROZA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONTROL_ROZA_SALDO .
    ''' </summary>
    ''' <param name="ID_ROZA_SALDO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTROL_ROZA_SALDO(ByVal ID_ROZA_SALDO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New ListaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorCONTROL_ROZA_SALDO(ID_ROZA_SALDO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA in  mListaCONTROL_ROZA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTROL_ROZA )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkID_PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(aEntidad.ID_PROVEEDOR_ROZA)
        aEntidad.fkID_TIPO_CANA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_ROZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(aEntidad.ID_ROZA_SALDO)
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTROL_ROZA )
    End Sub

#End Region

End Class
