''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_ENCA_TRANS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_ENCA_TRANS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_ENCA_TRANS()
    Private mEntidad as New SOLIC_ENCA_TRANS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ENCA_TRANS
        Try
            Dim mListaSOLIC_ENCA_TRANS As New ListaSOLIC_ENCA_TRANS
            mListaSOLIC_ENCA_TRANS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ENCA_TRANS
            If Not mListaSOLIC_ENCA_TRANS Is Nothing Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ENCA_TRANS
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_ENCA_TRANS(ByRef aEntidad As SOLIC_ENCA_TRANS, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_ENCA_TRANS.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_ENCA_TRANS
        Try
            Dim lEntidad As New SOLIC_ENCA_TRANS
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
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
    ''' <param name="aCUENTA_FINAN">Recuperar registro foraneo de la Entidad CUENTA_FINAN.</param>
    ''' <param name="aTRANSPORTISTA">Recuperar registro foraneo de la Entidad TRANSPORTISTA.</param>
    ''' <param name="aESTADO_SOLIC">Recuperar registro foraneo de la Entidad ESTADO_SOLIC.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_ENCA_TRANSConForaneas(ByVal aEntidad As SOLIC_ENCA_TRANS, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aESTADO_SOLIC As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aCUENTA_FINAN, aTRANSPORTISTA, aESTADO_SOLIC)
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CONTRA_TRANS As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal CONDI_COMPRA As Int32, ByVal NUM_SOLIC_ZAFRA As Int32, ByVal CODTRANSPORT As Int32, ByVal ACTIVIDAD As String, ByVal FECHA_SOLIC As DateTime, ByVal ID_CONTRA_TRANS_VEHI As Int32, ByVal ID_TRANSPORTE As Int32, ByVal SUB_TOTAL As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal ID_ESTADO_SOLIC As Int32, ByVal UID_SOLIC_ENCA_TRANS As Guid, ByVal OBSERVACIONES As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal CESC As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_ENCA_TRANS
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CONTRA_TRANS = ID_CONTRA_TRANS
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.CONDI_COMPRA = CONDI_COMPRA
            lEntidad.NUM_SOLIC_ZAFRA = NUM_SOLIC_ZAFRA
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ACTIVIDAD = ACTIVIDAD
            lEntidad.FECHA_SOLIC = FECHA_SOLIC
            lEntidad.ID_CONTRA_TRANS_VEHI = ID_CONTRA_TRANS_VEHI
            lEntidad.ID_TRANSPORTE = ID_TRANSPORTE
            lEntidad.SUB_TOTAL = SUB_TOTAL
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.ID_ESTADO_SOLIC = ID_ESTADO_SOLIC
            lEntidad.UID_SOLIC_ENCA_TRANS = UID_SOLIC_ENCA_TRANS
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.CESC = CESC
            Return Me.ActualizarSOLIC_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CONTRA_TRANS As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal CONDI_COMPRA As Int32, ByVal NUM_SOLIC_ZAFRA As Int32, ByVal CODTRANSPORT As Int32, ByVal ACTIVIDAD As String, ByVal FECHA_SOLIC As DateTime, ByVal ID_CONTRA_TRANS_VEHI As Int32, ByVal ID_TRANSPORTE As Int32, ByVal SUB_TOTAL As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal ID_ESTADO_SOLIC As Int32, ByVal UID_SOLIC_ENCA_TRANS As Guid, ByVal OBSERVACIONES As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal CESC As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_ENCA_TRANS
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CONTRA_TRANS = ID_CONTRA_TRANS
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.CONDI_COMPRA = CONDI_COMPRA
            lEntidad.NUM_SOLIC_ZAFRA = NUM_SOLIC_ZAFRA
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ACTIVIDAD = ACTIVIDAD
            lEntidad.FECHA_SOLIC = FECHA_SOLIC
            lEntidad.ID_CONTRA_TRANS_VEHI = ID_CONTRA_TRANS_VEHI
            lEntidad.ID_TRANSPORTE = ID_TRANSPORTE
            lEntidad.SUB_TOTAL = SUB_TOTAL
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.ID_ESTADO_SOLIC = ID_ESTADO_SOLIC
            lEntidad.UID_SOLIC_ENCA_TRANS = UID_SOLIC_ENCA_TRANS
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.CESC = CESC
            Return Me.ActualizarSOLIC_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	23/10/2017	Created
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
    ''' 	[GenApp]	23/10/2017	Created
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ENCA_TRANS
        Try
            Dim mListaSOLIC_ENCA_TRANS As New ListaSOLIC_ENCA_TRANS
            mListaSOLIC_ENCA_TRANS = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ENCA_TRANS
            If Not mListaSOLIC_ENCA_TRANS Is Nothing Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ENCA_TRANS
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ENCA_TRANS
        Try
            Dim mListaSOLIC_ENCA_TRANS As New ListaSOLIC_ENCA_TRANS
            mListaSOLIC_ENCA_TRANS = mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ENCA_TRANS
            If Not mListaSOLIC_ENCA_TRANS Is Nothing Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ENCA_TRANS
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ENCA_TRANS
        Try
            Dim mListaSOLIC_ENCA_TRANS As New ListaSOLIC_ENCA_TRANS
            mListaSOLIC_ENCA_TRANS = mDb.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ENCA_TRANS
            If Not mListaSOLIC_ENCA_TRANS Is Nothing Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_SOLIC .
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLIC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_SOLIC(ByVal ID_ESTADO_SOLIC As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ENCA_TRANS
        Try
            Dim mListaSOLIC_ENCA_TRANS As New ListaSOLIC_ENCA_TRANS
            mListaSOLIC_ENCA_TRANS = mDb.ObtenerListaPorESTADO_SOLIC(ID_ESTADO_SOLIC, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ENCA_TRANS
            If Not mListaSOLIC_ENCA_TRANS Is Nothing Then
                For Each lEntidad As SOLIC_ENCA_TRANS in  mListaSOLIC_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ENCA_TRANS
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_ENCA_TRANS )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(aEntidad.ID_CUENTA_FINAN)
        aEntidad.fkCODTRANSPORT = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(aEntidad.CODTRANSPORT)
        aEntidad.fkID_ESTADO_SOLIC = (New cESTADO_SOLIC).ObtenerESTADO_SOLIC(aEntidad.ID_ESTADO_SOLIC)
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_ENCA_TRANS )
    End Sub

#End Region

End Class
