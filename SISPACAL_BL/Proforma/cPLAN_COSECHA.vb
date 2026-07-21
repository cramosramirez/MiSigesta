''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPLAN_COSECHA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PLAN_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPLAN_COSECHA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPLAN_COSECHA()
    Private mEntidad as New PLAN_COSECHA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLAN_COSECHA
        Try
            Dim mListaPLAN_COSECHA As New ListaPLAN_COSECHA
            mListaPLAN_COSECHA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPLAN_COSECHA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLAN_COSECHA in  mListaPLAN_COSECHA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPLAN_COSECHA
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPLAN_COSECHA(ByRef aEntidad As PLAN_COSECHA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PLAN_COSECHA.
    ''' </summary>
    ''' <param name="ID_PLAN_COSECHA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPLAN_COSECHA(ByVal ID_PLAN_COSECHA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As PLAN_COSECHA
        Try
            Dim lEntidad As New PLAN_COSECHA
            lEntidad.ID_PLAN_COSECHA = ID_PLAN_COSECHA
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
    ''' <param name="aCARGADORA">Recuperar registro foraneo de la Entidad CARGADORA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPLAN_COSECHAConForaneas(ByVal aEntidad As PLAN_COSECHA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aCARGADORA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aLOTES, aCARGADORA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLAN_COSECHA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PLAN_COSECHA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLAN_COSECHA(ByVal ID_PLAN_COSECHA As Int32) As Integer
        Try
            mEntidad.ID_PLAN_COSECHA = ID_PLAN_COSECHA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLAN_COSECHA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLAN_COSECHA(ByVal aEntidad As PLAN_COSECHA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPLAN_COSECHA(ByVal ID_PLAN_COSECHA As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal MZ_SALDO As Decimal, ByVal TONEL_SALDO As Decimal, ByVal MZ_COSECHA As Decimal, ByVal TONEL_MZ_COSECHA As Decimal, ByVal TONEL_COSECHA As Decimal, ByVal CUOTA_DIARIA As Decimal, ByVal FECHA_INI_COSECHA As DateTime, ByVal FECHA_FIN_COSECHA As DateTime, ByVal TOTAL_SEMANA As Decimal, ByVal QUEMA_PROGRAMADA As Boolean, ByVal QUEMA_NO_PROGRAMADA As Boolean, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_CARGADOR As Int32, ByVal ID_TIPOTRANS As Int32, ByVal TRANSPORTE_PROPIO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, _
                                        ByVal FECHA_ACT As DateTime, ByVal CANA_VERDE As Boolean, ByVal FECHA_ESTIM_QUEMA As DateTime, ByVal FECHA_REAL_QUEMA As DateTime, ByVal FECHA_QUEMA_NOPROG As DateTime, ByVal CATORCENA As Int32, ByVal SEMANA As Int32) As Integer
        Try
            Dim lEntidad As New PLAN_COSECHA
            lEntidad.ID_PLAN_COSECHA = ID_PLAN_COSECHA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ_SALDO = MZ_SALDO
            lEntidad.TONEL_SALDO = TONEL_SALDO
            lEntidad.MZ_COSECHA = MZ_COSECHA
            lEntidad.TONEL_MZ_COSECHA = TONEL_MZ_COSECHA
            lEntidad.TONEL_COSECHA = TONEL_COSECHA
            lEntidad.CUOTA_DIARIA = CUOTA_DIARIA
            lEntidad.FECHA_INI_COSECHA = FECHA_INI_COSECHA
            lEntidad.FECHA_FIN_COSECHA = FECHA_FIN_COSECHA
            lEntidad.TOTAL_SEMANA = TOTAL_SEMANA
            lEntidad.QUEMA_PROGRAMADA = QUEMA_PROGRAMADA
            lEntidad.QUEMA_NO_PROGRAMADA = QUEMA_NO_PROGRAMADA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_ESTIM_QUEMA = FECHA_ESTIM_QUEMA
            lEntidad.FECHA_REAL_QUEMA = FECHA_REAL_QUEMA
            lEntidad.FECHA_QUEMA_NOPROG = FECHA_QUEMA_NOPROG
            lEntidad.CATORCENA = CATORCENA
            lEntidad.SEMANA = SEMANA
            Return Me.ActualizarPLAN_COSECHA(lEntidad)
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLAN_COSECHA(ByVal ID_PLAN_COSECHA As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal MZ_SALDO As Decimal, ByVal TONEL_SALDO As Decimal, ByVal MZ_COSECHA As Decimal, ByVal TONEL_MZ_COSECHA As Decimal, ByVal TONEL_COSECHA As Decimal, ByVal CUOTA_DIARIA As Decimal, ByVal FECHA_INI_COSECHA As DateTime, ByVal FECHA_FIN_COSECHA As DateTime, ByVal TOTAL_SEMANA As Decimal, ByVal QUEMA_PROGRAMADA As Boolean, ByVal QUEMA_NO_PROGRAMADA As Boolean, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_CARGADOR As Int32, ByVal ID_TIPOTRANS As Int32, ByVal TRANSPORTE_PROPIO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, _
                                           ByVal FECHA_ACT As DateTime, ByVal CANA_VERDE As Boolean, ByVal FECHA_ESTIM_QUEMA As DateTime, ByVal FECHA_REAL_QUEMA As DateTime, ByVal FECHA_QUEMA_NOPROG As DateTime, ByVal CATORCENA As Int32, ByVal SEMANA As Int32) As Integer
        Try
            Dim lEntidad As New PLAN_COSECHA
            lEntidad.ID_PLAN_COSECHA = ID_PLAN_COSECHA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ_SALDO = MZ_SALDO
            lEntidad.TONEL_SALDO = TONEL_SALDO
            lEntidad.MZ_COSECHA = MZ_COSECHA
            lEntidad.TONEL_MZ_COSECHA = TONEL_MZ_COSECHA
            lEntidad.TONEL_COSECHA = TONEL_COSECHA
            lEntidad.CUOTA_DIARIA = CUOTA_DIARIA
            lEntidad.FECHA_INI_COSECHA = FECHA_INI_COSECHA
            lEntidad.FECHA_FIN_COSECHA = FECHA_FIN_COSECHA
            lEntidad.TOTAL_SEMANA = TOTAL_SEMANA
            lEntidad.QUEMA_PROGRAMADA = QUEMA_PROGRAMADA
            lEntidad.QUEMA_NO_PROGRAMADA = QUEMA_NO_PROGRAMADA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_CARGADOR = ID_CARGADOR
            lEntidad.ID_TIPOTRANS = ID_TIPOTRANS
            lEntidad.TRANSPORTE_PROPIO = TRANSPORTE_PROPIO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_ESTIM_QUEMA = FECHA_ESTIM_QUEMA
            lEntidad.FECHA_REAL_QUEMA = FECHA_REAL_QUEMA
            lEntidad.FECHA_QUEMA_NOPROG = FECHA_QUEMA_NOPROG
            lEntidad.CATORCENA = CATORCENA
            lEntidad.SEMANA = SEMANA
            Return Me.ActualizarPLAN_COSECHA(lEntidad)
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
    ''' 	[GenApp]	29/11/2014	Created
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
    ''' 	[GenApp]	29/11/2014	Created
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLAN_COSECHA
        Try
            Dim mListaPLAN_COSECHA As New ListaPLAN_COSECHA
            mListaPLAN_COSECHA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaPLAN_COSECHA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLAN_COSECHA in  mListaPLAN_COSECHA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPLAN_COSECHA
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLAN_COSECHA
        Try
            Dim mListaPLAN_COSECHA As New ListaPLAN_COSECHA
            mListaPLAN_COSECHA = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaPLAN_COSECHA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLAN_COSECHA in  mListaPLAN_COSECHA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPLAN_COSECHA
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLAN_COSECHA
        Try
            Dim mListaPLAN_COSECHA As New ListaPLAN_COSECHA
            mListaPLAN_COSECHA = mDb.ObtenerListaPorCARGADORA(ID_CARGADORA, asColumnaOrden, asTipoOrden)
            If Not mListaPLAN_COSECHA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLAN_COSECHA in  mListaPLAN_COSECHA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPLAN_COSECHA
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PLAN_COSECHA )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkID_CARGADORA = (New cCARGADORA).ObtenerCARGADORA(aEntidad.ID_CARGADORA)
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PLAN_COSECHA )
    End Sub

#End Region

End Class
