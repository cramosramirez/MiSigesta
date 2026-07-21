''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cFACTURA_SERVICIOS_ENCA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla FACTURA_SERVICIOS_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cFACTURA_SERVICIOS_ENCA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbFACTURA_SERVICIOS_ENCA()
    Private mEntidad as New FACTURA_SERVICIOS_ENCA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACTURA_SERVICIOS_ENCA
        Try
            Dim mListaFACTURA_SERVICIOS_ENCA As New ListaFACTURA_SERVICIOS_ENCA
            mListaFACTURA_SERVICIOS_ENCA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaFACTURA_SERVICIOS_ENCA
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaFACTURA_SERVICIOS_ENCA
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerFACTURA_SERVICIOS_ENCA(ByRef aEntidad As FACTURA_SERVICIOS_ENCA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla FACTURA_SERVICIOS_ENCA.
    ''' </summary>
    ''' <param name="ID_FACTURA_SERVICIOS_ENCA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerFACTURA_SERVICIOS_ENCA(ByVal ID_FACTURA_SERVICIOS_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As FACTURA_SERVICIOS_ENCA
        Try
            Dim lEntidad As New FACTURA_SERVICIOS_ENCA
            lEntidad.ID_FACTURA_SERVICIOS_ENCA = ID_FACTURA_SERVICIOS_ENCA
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
    ''' <param name="aCONTRATO">Recuperar registro foraneo de la Entidad CONTRATO.</param>
    ''' <param name="aPROVEEDOR">Recuperar registro foraneo de la Entidad PROVEEDOR.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aCUENTA_FINAN">Recuperar registro foraneo de la Entidad CUENTA_FINAN.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerFACTURA_SERVICIOS_ENCAConForaneas(ByVal aEntidad As FACTURA_SERVICIOS_ENCA, Optional ByVal aCONTRATO As Boolean = False, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCONTRATO, aPROVEEDOR, aZAFRA, aCUENTA_FINAN)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla FACTURA_SERVICIOS_ENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_FACTURA_SERVICIOS_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarFACTURA_SERVICIOS_ENCA(ByVal ID_FACTURA_SERVICIOS_ENCA As Int32) As Integer
        Try
            mEntidad.ID_FACTURA_SERVICIOS_ENCA = ID_FACTURA_SERVICIOS_ENCA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla FACTURA_SERVICIOS_ENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarFACTURA_SERVICIOS_ENCA(ByVal aEntidad As FACTURA_SERVICIOS_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarFACTURA_SERVICIOS_ENCA(ByVal ID_FACTURA_SERVICIOS_ENCA As Int32, ByVal NO_DOCTO As Int32, ByVal TIPO_DOCTO As String, ByVal FECHA_EMISION As DateTime, ByVal ESTADO As String, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_PROVEEDOR As String, ByVal GIRO As String, ByVal DIRECCION As String, ByVal DUI As String, ByVal NIT As String, ByVal NRC As String, ByVal EXENTO As Decimal, ByVal AFECTO As Decimal, ByVal PORC_DESCUENTO As Decimal, ByVal DESCUENTO As Decimal, ByVal SUMAS As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal CANT_LETRAS As String, ByVal ID_ZAFRA As Int32, ByVal ZAFRA As String, ByVal UID_FACTURA_SERVICIOS As Guid, ByVal UID_REFERENCIA As Guid, ByVal ID_CUENTA_FINAN As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal USUARIO_ANUL As String, ByVal FECHA_ANUL As DateTime) As Integer
        Try
            Dim lEntidad As New FACTURA_SERVICIOS_ENCA
            lEntidad.ID_FACTURA_SERVICIOS_ENCA = ID_FACTURA_SERVICIOS_ENCA
            lEntidad.NO_DOCTO = NO_DOCTO
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.FECHA_EMISION = FECHA_EMISION
            lEntidad.ESTADO = ESTADO
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
            lEntidad.GIRO = GIRO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.NRC = NRC
            lEntidad.EXENTO = EXENTO
            lEntidad.AFECTO = AFECTO
            lEntidad.PORC_DESCUENTO = PORC_DESCUENTO
            lEntidad.DESCUENTO = DESCUENTO
            lEntidad.SUMAS = SUMAS
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.CANT_LETRAS = CANT_LETRAS
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.UID_FACTURA_SERVICIOS = UID_FACTURA_SERVICIOS
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.USUARIO_ANUL = USUARIO_ANUL
            lEntidad.FECHA_ANUL = FECHA_ANUL
            Return Me.ActualizarFACTURA_SERVICIOS_ENCA(lEntidad)
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACTURA_SERVICIOS_ENCA(ByVal aEntidad As FACTURA_SERVICIOS_ENCA) As Integer
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACTURA_SERVICIOS_ENCA(ByVal aEntidad As FACTURA_SERVICIOS_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACTURA_SERVICIOS_ENCA(ByVal ID_FACTURA_SERVICIOS_ENCA As Int32, ByVal NO_DOCTO As Int32, ByVal TIPO_DOCTO As String, ByVal FECHA_EMISION As DateTime, ByVal ESTADO As String, ByVal CODICONTRATO As String, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_PROVEEDOR As String, ByVal GIRO As String, ByVal DIRECCION As String, ByVal DUI As String, ByVal NIT As String, ByVal NRC As String, ByVal EXENTO As Decimal, ByVal AFECTO As Decimal, ByVal PORC_DESCUENTO As Decimal, ByVal DESCUENTO As Decimal, ByVal SUMAS As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal, ByVal CANT_LETRAS As String, ByVal ID_ZAFRA As Int32, ByVal ZAFRA As String, ByVal UID_FACTURA_SERVICIOS As Guid, ByVal UID_REFERENCIA As Guid, ByVal ID_CUENTA_FINAN As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal USUARIO_ANUL As String, ByVal FECHA_ANUL As DateTime) As Integer
        Try
            Dim lEntidad As New FACTURA_SERVICIOS_ENCA
            lEntidad.ID_FACTURA_SERVICIOS_ENCA = ID_FACTURA_SERVICIOS_ENCA
            lEntidad.NO_DOCTO = NO_DOCTO
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.FECHA_EMISION = FECHA_EMISION
            lEntidad.ESTADO = ESTADO
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
            lEntidad.GIRO = GIRO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.NRC = NRC
            lEntidad.EXENTO = EXENTO
            lEntidad.AFECTO = AFECTO
            lEntidad.PORC_DESCUENTO = PORC_DESCUENTO
            lEntidad.DESCUENTO = DESCUENTO
            lEntidad.SUMAS = SUMAS
            lEntidad.IVA = IVA
            lEntidad.TOTAL = TOTAL
            lEntidad.CANT_LETRAS = CANT_LETRAS
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.UID_FACTURA_SERVICIOS = UID_FACTURA_SERVICIOS
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.USUARIO_ANUL = USUARIO_ANUL
            lEntidad.FECHA_ANUL = FECHA_ANUL
            Return Me.ActualizarFACTURA_SERVICIOS_ENCA(lEntidad)
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
    ''' 	[GenApp]	15/07/2015	Created
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
    ''' 	[GenApp]	15/07/2015	Created
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
    ''' la Tabla CONTRATO .
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO(ByVal CODICONTRATO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACTURA_SERVICIOS_ENCA
        Try
            Dim mListaFACTURA_SERVICIOS_ENCA As New ListaFACTURA_SERVICIOS_ENCA
            mListaFACTURA_SERVICIOS_ENCA = mDb.ObtenerListaPorCONTRATO(CODICONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaFACTURA_SERVICIOS_ENCA
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaFACTURA_SERVICIOS_ENCA
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACTURA_SERVICIOS_ENCA
        Try
            Dim mListaFACTURA_SERVICIOS_ENCA As New ListaFACTURA_SERVICIOS_ENCA
            mListaFACTURA_SERVICIOS_ENCA = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaFACTURA_SERVICIOS_ENCA
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaFACTURA_SERVICIOS_ENCA
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACTURA_SERVICIOS_ENCA
        Try
            Dim mListaFACTURA_SERVICIOS_ENCA As New ListaFACTURA_SERVICIOS_ENCA
            mListaFACTURA_SERVICIOS_ENCA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaFACTURA_SERVICIOS_ENCA
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaFACTURA_SERVICIOS_ENCA
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACTURA_SERVICIOS_ENCA
        Try
            Dim mListaFACTURA_SERVICIOS_ENCA As New ListaFACTURA_SERVICIOS_ENCA
            mListaFACTURA_SERVICIOS_ENCA = mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaFACTURA_SERVICIOS_ENCA
            If Not mListaFACTURA_SERVICIOS_ENCA Is Nothing Then
                For Each lEntidad As FACTURA_SERVICIOS_ENCA in  mListaFACTURA_SERVICIOS_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaFACTURA_SERVICIOS_ENCA
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As FACTURA_SERVICIOS_ENCA )
        aEntidad.fkCODICONTRATO = (New cCONTRATO).ObtenerCONTRATO(aEntidad.CODICONTRATO)
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
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
    ''' 	[GenApp]	15/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As FACTURA_SERVICIOS_ENCA )
    End Sub

#End Region

End Class
