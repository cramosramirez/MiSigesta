''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cORDEN_COMBUSTIBLE
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ORDEN_COMBUSTIBLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cORDEN_COMBUSTIBLE
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbORDEN_COMBUSTIBLE()
    Private mEntidad as New ORDEN_COMBUSTIBLE
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE
        Try
            Dim mListaORDEN_COMBUSTIBLE As New ListaORDEN_COMBUSTIBLE
            mListaORDEN_COMBUSTIBLE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaORDEN_COMBUSTIBLE
            If Not mListaORDEN_COMBUSTIBLE Is Nothing Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerORDEN_COMBUSTIBLE(ByRef aEntidad As ORDEN_COMBUSTIBLE, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ORDEN_COMBUSTIBLE.
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As ORDEN_COMBUSTIBLE
        Try
            Dim lEntidad As New ORDEN_COMBUSTIBLE
            lEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
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
    ''' <param name="aPROVEEDOR_COMBUSTIBLE">Recuperar registro foraneo de la Entidad PROVEEDOR_COMBUSTIBLE.</param>
    ''' <param name="aTIPO_PROVEEDOR">Recuperar registro foraneo de la Entidad TIPO_PROVEEDOR.</param>
    ''' <param name="aCATORCENA_ZAFRA">Recuperar registro foraneo de la Entidad CATORCENA_ZAFRA.</param>
    ''' <param name="aSECCION">Recuperar registro foraneo de la Entidad SECCION.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerORDEN_COMBUSTIBLEConForaneas(ByVal aEntidad As ORDEN_COMBUSTIBLE, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aPROVEEDOR_COMBUSTIBLE As Boolean = False, Optional ByVal aTIPO_PROVEEDOR As Boolean = False, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aSECCION As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aPROVEEDOR_COMBUSTIBLE, aTIPO_PROVEEDOR, aCATORCENA_ZAFRA, aSECCION)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ORDEN_COMBUSTIBLE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32) As Integer
        Try
            mEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ORDEN_COMBUSTIBLE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarORDEN_COMBUSTIBLE(ByVal aEntidad As ORDEN_COMBUSTIBLE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_PROVEEDOR_COMBUS As Int32, ByVal ID_TRANSPORTE As Int32, ByVal ID_MOTORISTA As Int32, ByVal FECHA_EMISION As DateTime, ByVal NOMBRES_MOTORISTA As String, ByVal APELLIDOS_MOTORISTA As String, ByVal PLACA As String, ByVal FECHA_DESPACHO As DateTime, ByVal NO_FACTURA_CCF As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DUI As String, ByVal LICENCIA As String, ByVal ESTADO As String, ByVal FECHA_ANULACION As DateTime, ByVal MOTIVO_ANULACION As String, ByVal NO_ORDEN As String, ByVal ID_ORDEN_COMBUSTIBLE_NUM As Int32, ByVal TOTAL As Decimal, ByVal CODIGO As String, ByVal ID_TIPO_PROVEEDOR As Int32, ByVal ID_CATORCENA As Int32, ByVal NIT As String, ByVal NRC As String, ByVal CODIBARRA As String, ByVal ID_SECCION As Int32, ByVal OBSERVACION As String, ByVal ID_MOTORISTA_VEHI As Int32) As Integer
        Try
            Dim lEntidad As New ORDEN_COMBUSTIBLE
            lEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_PROVEEDOR_COMBUS = ID_PROVEEDOR_COMBUS
            lEntidad.ID_TRANSPORTE = ID_TRANSPORTE
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.FECHA_EMISION = FECHA_EMISION
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.APELLIDOS_MOTORISTA = APELLIDOS_MOTORISTA
            lEntidad.PLACA = PLACA
            lEntidad.FECHA_DESPACHO = FECHA_DESPACHO
            lEntidad.NO_FACTURA_CCF = NO_FACTURA_CCF
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DUI = DUI
            lEntidad.LICENCIA = LICENCIA
            lEntidad.ESTADO = ESTADO
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.MOTIVO_ANULACION = MOTIVO_ANULACION
            lEntidad.NO_ORDEN = NO_ORDEN
            lEntidad.ID_ORDEN_COMBUSTIBLE_NUM = ID_ORDEN_COMBUSTIBLE_NUM
            lEntidad.TOTAL = TOTAL
            lEntidad.CODIGO = CODIGO
            lEntidad.ID_TIPO_PROVEEDOR = ID_TIPO_PROVEEDOR
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.NIT = NIT
            lEntidad.NRC = NRC
            lEntidad.CODIBARRA = CODIBARRA
            lEntidad.ID_SECCION = ID_SECCION
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI
            Return Me.ActualizarORDEN_COMBUSTIBLE(lEntidad)
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_PROVEEDOR_COMBUS As Int32, ByVal ID_TRANSPORTE As Int32, ByVal ID_MOTORISTA As Int32, ByVal FECHA_EMISION As DateTime, ByVal NOMBRES_MOTORISTA As String, ByVal APELLIDOS_MOTORISTA As String, ByVal PLACA As String, ByVal FECHA_DESPACHO As DateTime, ByVal NO_FACTURA_CCF As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DUI As String, ByVal LICENCIA As String, ByVal ESTADO As String, ByVal FECHA_ANULACION As DateTime, ByVal MOTIVO_ANULACION As String, ByVal NO_ORDEN As String, ByVal ID_ORDEN_COMBUSTIBLE_NUM As Int32, ByVal TOTAL As Decimal, ByVal CODIGO As String, ByVal ID_TIPO_PROVEEDOR As Int32, ByVal ID_CATORCENA As Int32, ByVal NIT As String, ByVal NRC As String, ByVal CODIBARRA As String, ByVal ID_SECCION As Int32, ByVal OBSERVACION As String, ID_MOTORISTA_VEHI As Int32) As Integer
        Try
            Dim lEntidad As New ORDEN_COMBUSTIBLE
            lEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_PROVEEDOR_COMBUS = ID_PROVEEDOR_COMBUS
            lEntidad.ID_TRANSPORTE = ID_TRANSPORTE
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.FECHA_EMISION = FECHA_EMISION
            lEntidad.NOMBRES_MOTORISTA = NOMBRES_MOTORISTA
            lEntidad.APELLIDOS_MOTORISTA = APELLIDOS_MOTORISTA
            lEntidad.PLACA = PLACA
            lEntidad.FECHA_DESPACHO = FECHA_DESPACHO
            lEntidad.NO_FACTURA_CCF = NO_FACTURA_CCF
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DUI = DUI
            lEntidad.LICENCIA = LICENCIA
            lEntidad.ESTADO = ESTADO
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.MOTIVO_ANULACION = MOTIVO_ANULACION
            lEntidad.NO_ORDEN = NO_ORDEN
            lEntidad.ID_ORDEN_COMBUSTIBLE_NUM = ID_ORDEN_COMBUSTIBLE_NUM
            lEntidad.TOTAL = TOTAL
            lEntidad.CODIGO = CODIGO
            lEntidad.ID_TIPO_PROVEEDOR = ID_TIPO_PROVEEDOR
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.NIT = NIT
            lEntidad.NRC = NRC
            lEntidad.CODIBARRA = CODIBARRA
            lEntidad.ID_SECCION = ID_SECCION
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI
            Return Me.ActualizarORDEN_COMBUSTIBLE(lEntidad)
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
    ''' 	[GenApp]	30/10/2018	Created
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
    ''' 	[GenApp]	30/10/2018	Created
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE
        Try
            Dim mListaORDEN_COMBUSTIBLE As New ListaORDEN_COMBUSTIBLE
            mListaORDEN_COMBUSTIBLE = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaORDEN_COMBUSTIBLE
            If Not mListaORDEN_COMBUSTIBLE Is Nothing Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_COMBUSTIBLE .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_COMBUSTIBLE(ByVal ID_PROVEEDOR_COMBUS As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE
        Try
            Dim mListaORDEN_COMBUSTIBLE As New ListaORDEN_COMBUSTIBLE
            mListaORDEN_COMBUSTIBLE = mDb.ObtenerListaPorPROVEEDOR_COMBUSTIBLE(ID_PROVEEDOR_COMBUS, asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaORDEN_COMBUSTIBLE
            If Not mListaORDEN_COMBUSTIBLE Is Nothing Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_PROVEEDOR .
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE
        Try
            Dim mListaORDEN_COMBUSTIBLE As New ListaORDEN_COMBUSTIBLE
            mListaORDEN_COMBUSTIBLE = mDb.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaORDEN_COMBUSTIBLE
            If Not mListaORDEN_COMBUSTIBLE Is Nothing Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE
        Try
            Dim mListaORDEN_COMBUSTIBLE As New ListaORDEN_COMBUSTIBLE
            mListaORDEN_COMBUSTIBLE = mDb.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA, asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaORDEN_COMBUSTIBLE
            If Not mListaORDEN_COMBUSTIBLE Is Nothing Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSECCION(ByVal ID_SECCION As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE
        Try
            Dim mListaORDEN_COMBUSTIBLE As New ListaORDEN_COMBUSTIBLE
            mListaORDEN_COMBUSTIBLE = mDb.ObtenerListaPorSECCION(ID_SECCION, asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaORDEN_COMBUSTIBLE
            If Not mListaORDEN_COMBUSTIBLE Is Nothing Then
                For Each lEntidad As ORDEN_COMBUSTIBLE in  mListaORDEN_COMBUSTIBLE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ORDEN_COMBUSTIBLE )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_PROVEEDOR_COMBUS = (New cPROVEEDOR_COMBUSTIBLE).ObtenerPROVEEDOR_COMBUSTIBLE(aEntidad.ID_PROVEEDOR_COMBUS)
        aEntidad.fkID_TIPO_PROVEEDOR = (New cTIPO_PROVEEDOR).ObtenerTIPO_PROVEEDOR(aEntidad.ID_TIPO_PROVEEDOR)
        aEntidad.fkID_CATORCENA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
        aEntidad.fkID_SECCION = (New cSECCION).ObtenerSECCION(aEntidad.ID_SECCION)
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ORDEN_COMBUSTIBLE )
    End Sub

#End Region

End Class
