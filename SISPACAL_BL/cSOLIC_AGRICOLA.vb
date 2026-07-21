''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_AGRICOLA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_AGRICOLA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_AGRICOLA()
    Private mEntidad as New SOLIC_AGRICOLA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA
        Try
            Dim mListaSOLIC_AGRICOLA As New ListaSOLIC_AGRICOLA
            mListaSOLIC_AGRICOLA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_AGRICOLA
            If Not mListaSOLIC_AGRICOLA Is Nothing Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_AGRICOLA(ByRef aEntidad As SOLIC_AGRICOLA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_AGRICOLA.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_AGRICOLA
        Try
            Dim lEntidad As New SOLIC_AGRICOLA
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
    ''' <param name="aPROVEEDOR">Recuperar registro foraneo de la Entidad PROVEEDOR.</param>
    ''' <param name="aCATEGORIA_PROD">Recuperar registro foraneo de la Entidad CATEGORIA_PROD.</param>
    ''' <param name="aCUENTA_FINAN">Recuperar registro foraneo de la Entidad CUENTA_FINAN.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_AGRICOLAConForaneas(ByVal aEntidad As SOLIC_AGRICOLA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aCATEGORIA_PROD As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aPROVEEDOR, aCATEGORIA_PROD, aCUENTA_FINAN)
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal ID_ZAFRA As Int32, ByVal NUM_SOLICITUD As Int32, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_PROVEEDOR As String, ByVal ACTIVIDAD As String, ByVal FECHA_SOLIC As DateTime, ByVal FECHA_APLICA As DateTime, ByVal DUI As String, ByVal NIT As String, ByVal NRC As String, ByVal TIPO_CONTRIBUYENTE As Int32, ByVal SUB_TOTAL As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal ESTADO As Int32, ByVal OBSERVACIONES As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal CODIAGRON As String, ByVal CODICONTRATO As String, ByVal UID_SOLIC_AGRICOLA As Guid, ByVal ID_CATEGORIA As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal CONDI_COMPRA As Int32, ByVal CONTRATOS As String, ByVal FOVIAL_COTRANS As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_AGRICOLA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NUM_SOLICITUD = NUM_SOLICITUD
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
            lEntidad.ACTIVIDAD = ACTIVIDAD
            lEntidad.FECHA_SOLIC = FECHA_SOLIC
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.NRC = NRC
            lEntidad.TIPO_CONTRIBUYENTE = TIPO_CONTRIBUYENTE
            lEntidad.SUB_TOTAL = SUB_TOTAL
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.ESTADO = ESTADO
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.UID_SOLIC_AGRICOLA = UID_SOLIC_AGRICOLA
            lEntidad.ID_CATEGORIA = ID_CATEGORIA
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.CONDI_COMPRA = CONDI_COMPRA
            lEntidad.CONTRATOS = CONTRATOS
            lEntidad.FOVIAL_COTRANS = FOVIAL_COTRANS
            Return Me.ActualizarSOLIC_AGRICOLA(lEntidad)
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal ID_ZAFRA As Int32, ByVal NUM_SOLICITUD As Int32, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_PROVEEDOR As String, ByVal ACTIVIDAD As String, ByVal FECHA_SOLIC As DateTime, ByVal FECHA_APLICA As DateTime, ByVal DUI As String, ByVal NIT As String, ByVal NRC As String, ByVal TIPO_CONTRIBUYENTE As Int32, ByVal SUB_TOTAL As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal ESTADO As Int32, ByVal OBSERVACIONES As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal CODIAGRON As String, ByVal CODICONTRATO As String, ByVal UID_SOLIC_AGRICOLA As Guid, ByVal ID_CATEGORIA As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal CONDI_COMPRA As Int32, ByVal CONTRATOS As String, ByVal FOVIAL_COTRANS As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_AGRICOLA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NUM_SOLICITUD = NUM_SOLICITUD
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
            lEntidad.ACTIVIDAD = ACTIVIDAD
            lEntidad.FECHA_SOLIC = FECHA_SOLIC
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.NRC = NRC
            lEntidad.TIPO_CONTRIBUYENTE = TIPO_CONTRIBUYENTE
            lEntidad.SUB_TOTAL = SUB_TOTAL
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.ESTADO = ESTADO
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.UID_SOLIC_AGRICOLA = UID_SOLIC_AGRICOLA
            lEntidad.ID_CATEGORIA = ID_CATEGORIA
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.CONDI_COMPRA = CONDI_COMPRA
            lEntidad.CONTRATOS = CONTRATOS
            lEntidad.FOVIAL_COTRANS = FOVIAL_COTRANS
            Return Me.ActualizarSOLIC_AGRICOLA(lEntidad)
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
    ''' 	[GenApp]	08/06/2017	Created
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
    ''' 	[GenApp]	08/06/2017	Created
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA
        Try
            Dim mListaSOLIC_AGRICOLA As New ListaSOLIC_AGRICOLA
            mListaSOLIC_AGRICOLA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_AGRICOLA
            If Not mListaSOLIC_AGRICOLA Is Nothing Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA
        Try
            Dim mListaSOLIC_AGRICOLA As New ListaSOLIC_AGRICOLA
            mListaSOLIC_AGRICOLA = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_AGRICOLA
            If Not mListaSOLIC_AGRICOLA Is Nothing Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CATEGORIA_PROD .
    ''' </summary>
    ''' <param name="ID_CATEGORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATEGORIA_PROD(ByVal ID_CATEGORIA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA
        Try
            Dim mListaSOLIC_AGRICOLA As New ListaSOLIC_AGRICOLA
            mListaSOLIC_AGRICOLA = mDb.ObtenerListaPorCATEGORIA_PROD(ID_CATEGORIA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_AGRICOLA
            If Not mListaSOLIC_AGRICOLA Is Nothing Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA
        Try
            Dim mListaSOLIC_AGRICOLA As New ListaSOLIC_AGRICOLA
            mListaSOLIC_AGRICOLA = mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_AGRICOLA
            If Not mListaSOLIC_AGRICOLA Is Nothing Then
                For Each lEntidad As SOLIC_AGRICOLA in  mListaSOLIC_AGRICOLA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_AGRICOLA )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
        aEntidad.fkID_CATEGORIA = (New cCATEGORIA_PROD).ObtenerCATEGORIA_PROD(aEntidad.ID_CATEGORIA)
        aEntidad.fkID_CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(aEntidad.ID_CUENTA_FINAN)
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
    ''' 	[GenApp]	08/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_AGRICOLA )
    End Sub

#End Region

End Class
