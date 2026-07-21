''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCOMPROB_ENCA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla COMPROB_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCOMPROB_ENCA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCOMPROB_ENCA()
    Private mEntidad as New COMPROB_ENCA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCOMPROB_ENCA
        Try
            Dim mListaCOMPROB_ENCA As New ListaCOMPROB_ENCA
            mListaCOMPROB_ENCA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCOMPROB_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCOMPROB_ENCA
            If Not mListaCOMPROB_ENCA Is Nothing Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCOMPROB_ENCA
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCOMPROB_ENCA(ByRef aEntidad As COMPROB_ENCA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla COMPROB_ENCA.
    ''' </summary>
    ''' <param name="ID_COMPROB_ENCA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCOMPROB_ENCA(ByVal ID_COMPROB_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As COMPROB_ENCA
        Try
            Dim lEntidad As New COMPROB_ENCA
            lEntidad.ID_COMPROB_ENCA = ID_COMPROB_ENCA
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
    ''' <param name="aCATORCENA_ZAFRA">Recuperar registro foraneo de la Entidad CATORCENA_ZAFRA.</param>
    ''' <param name="aTIPO_PLANILLA">Recuperar registro foraneo de la Entidad TIPO_PLANILLA.</param>
    ''' <param name="aTIPO_COMPROB">Recuperar registro foraneo de la Entidad TIPO_COMPROB.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCOMPROB_ENCAConForaneas(ByVal aEntidad As COMPROB_ENCA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False, Optional ByVal aTIPO_COMPROB As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aCATORCENA_ZAFRA, aTIPO_PLANILLA, aTIPO_COMPROB, aMUNICIPIO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla COMPROB_ENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_COMPROB_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCOMPROB_ENCA(ByVal ID_COMPROB_ENCA As Int32) As Integer
        Try
            mEntidad.ID_COMPROB_ENCA = ID_COMPROB_ENCA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla COMPROB_ENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCOMPROB_ENCA(ByVal aEntidad As COMPROB_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCOMPROB_ENCA(ByVal ID_COMPROB_ENCA As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal ID_TIPO_COMPROB As Int32, ByVal SERIE As String, ByVal NUM_DOCTO As Int32, ByVal ESTADO As String, ByVal FECHA As DateTime, ByVal CODIGO As String, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DIRECCION As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal NIT As String, ByVal DUI As String, ByVal NRC As String, ByVal GIRO As String, ByVal CORREO As String, ByVal SUMAS As Decimal, ByVal IVA As Decimal, ByVal RENTA As Decimal, ByVal SUBTOTAL As Decimal, ByVal IVA_RETENIDO As Decimal, ByVal TOTAL As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal ID_PLANILLA_COMPROB As Int32) As Integer
        Try
            Dim lEntidad As New COMPROB_ENCA
            lEntidad.ID_COMPROB_ENCA = ID_COMPROB_ENCA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.ID_TIPO_COMPROB = ID_TIPO_COMPROB
            lEntidad.SERIE = SERIE
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.ESTADO = ESTADO
            lEntidad.FECHA = FECHA
            lEntidad.CODIGO = CODIGO
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.DIRECCION = DIRECCION
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.NIT = NIT
            lEntidad.DUI = DUI
            lEntidad.NRC = NRC
            lEntidad.GIRO = GIRO
            lEntidad.CORREO = CORREO
            lEntidad.SUMAS = SUMAS
            lEntidad.IVA = IVA
            lEntidad.RENTA = RENTA
            lEntidad.SUBTOTAL = SUBTOTAL
            lEntidad.IVA_RETENIDO = IVA_RETENIDO
            lEntidad.TOTAL = TOTAL
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.ID_PLANILLA_COMPROB = ID_PLANILLA_COMPROB
            Return Me.ActualizarCOMPROB_ENCA(lEntidad)
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCOMPROB_ENCA(ByVal aEntidad As COMPROB_ENCA) As Integer
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCOMPROB_ENCA(ByVal aEntidad As COMPROB_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCOMPROB_ENCA(ByVal ID_COMPROB_ENCA As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal ID_TIPO_COMPROB As Int32, ByVal SERIE As String, ByVal NUM_DOCTO As Int32, ByVal ESTADO As String, ByVal FECHA As DateTime, ByVal CODIGO As String, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DIRECCION As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal NIT As String, ByVal DUI As String, ByVal NRC As String, ByVal GIRO As String, ByVal CORREO As String, ByVal SUMAS As Decimal, ByVal IVA As Decimal, ByVal RENTA As Decimal, ByVal SUBTOTAL As Decimal, ByVal IVA_RETENIDO As Decimal, ByVal TOTAL As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal ID_PLANILLA_COMPROB As Int32) As Integer
        Try
            Dim lEntidad As New COMPROB_ENCA
            lEntidad.ID_COMPROB_ENCA = ID_COMPROB_ENCA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.ID_TIPO_COMPROB = ID_TIPO_COMPROB
            lEntidad.SERIE = SERIE
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.ESTADO = ESTADO
            lEntidad.FECHA = FECHA
            lEntidad.CODIGO = CODIGO
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.DIRECCION = DIRECCION
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.NIT = NIT
            lEntidad.DUI = DUI
            lEntidad.NRC = NRC
            lEntidad.GIRO = GIRO
            lEntidad.CORREO = CORREO
            lEntidad.SUMAS = SUMAS
            lEntidad.IVA = IVA
            lEntidad.RENTA = RENTA
            lEntidad.SUBTOTAL = SUBTOTAL
            lEntidad.IVA_RETENIDO = IVA_RETENIDO
            lEntidad.TOTAL = TOTAL
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.ID_PLANILLA_COMPROB = ID_PLANILLA_COMPROB
            Return Me.ActualizarCOMPROB_ENCA(lEntidad)
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
    ''' 	[GenApp]	02/11/2023	Created
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
    ''' 	[GenApp]	02/11/2023	Created
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCOMPROB_ENCA
        Try
            Dim mListaCOMPROB_ENCA As New ListaCOMPROB_ENCA
            mListaCOMPROB_ENCA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCOMPROB_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCOMPROB_ENCA
            If Not mListaCOMPROB_ENCA Is Nothing Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCOMPROB_ENCA
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCOMPROB_ENCA
        Try
            Dim mListaCOMPROB_ENCA As New ListaCOMPROB_ENCA
            mListaCOMPROB_ENCA = mDb.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA, asColumnaOrden, asTipoOrden)
            If Not mListaCOMPROB_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCOMPROB_ENCA
            If Not mListaCOMPROB_ENCA Is Nothing Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCOMPROB_ENCA
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCOMPROB_ENCA
        Try
            Dim mListaCOMPROB_ENCA As New ListaCOMPROB_ENCA
            mListaCOMPROB_ENCA = mDb.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaCOMPROB_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCOMPROB_ENCA
            If Not mListaCOMPROB_ENCA Is Nothing Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCOMPROB_ENCA
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_COMPROB(ByVal ID_TIPO_COMPROB As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCOMPROB_ENCA
        Try
            Dim mListaCOMPROB_ENCA As New ListaCOMPROB_ENCA
            mListaCOMPROB_ENCA = mDb.ObtenerListaPorTIPO_COMPROB(ID_TIPO_COMPROB, asColumnaOrden, asTipoOrden)
            If Not mListaCOMPROB_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCOMPROB_ENCA
            If Not mListaCOMPROB_ENCA Is Nothing Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCOMPROB_ENCA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCOMPROB_ENCA
        Try
            Dim mListaCOMPROB_ENCA As New ListaCOMPROB_ENCA
            mListaCOMPROB_ENCA = mDb.ObtenerListaPorMUNICIPIO(CODI_DEPTO, CODI_MUNI, asColumnaOrden, asTipoOrden)
            If Not mListaCOMPROB_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCOMPROB_ENCA
            If Not mListaCOMPROB_ENCA Is Nothing Then
                For Each lEntidad As COMPROB_ENCA in  mListaCOMPROB_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCOMPROB_ENCA
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As COMPROB_ENCA )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_CATORCENA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
        aEntidad.fkID_TIPO_PLANILLA = (New cTIPO_PLANILLA).ObtenerTIPO_PLANILLA(aEntidad.ID_TIPO_PLANILLA)
        aEntidad.fkID_TIPO_COMPROB = (New cTIPO_COMPROB).ObtenerTIPO_COMPROB(aEntidad.ID_TIPO_COMPROB)
        aEntidad.fkCODI_DEPTO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
        aEntidad.fkCODI_MUNI = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
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
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As COMPROB_ENCA )
    End Sub

#End Region

End Class
