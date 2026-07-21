''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPRE_ANALISIS_ENCA_TRANS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PRE_ANALISIS_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPRE_ANALISIS_ENCA_TRANS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPRE_ANALISIS_ENCA_TRANS()
    Private mEntidad as New PRE_ANALISIS_ENCA_TRANS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPRE_ANALISIS_ENCA_TRANS
        Try
            Dim mListaPRE_ANALISIS_ENCA_TRANS As New ListaPRE_ANALISIS_ENCA_TRANS
            mListaPRE_ANALISIS_ENCA_TRANS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaPRE_ANALISIS_ENCA_TRANS
            If Not mListaPRE_ANALISIS_ENCA_TRANS Is Nothing Then
                For Each lEntidad As PRE_ANALISIS_ENCA_TRANS in  mListaPRE_ANALISIS_ENCA_TRANS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPRE_ANALISIS_ENCA_TRANS
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPRE_ANALISIS_ENCA_TRANS(ByRef aEntidad As PRE_ANALISIS_ENCA_TRANS, ByVal Optional recuperarHijas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PRE_ANALISIS_ENCA_TRANS.
    ''' </summary>
    ''' <param name="ID_ENCA"></param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPRE_ANALISIS_ENCA_TRANS(ByVal ID_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False) As PRE_ANALISIS_ENCA_TRANS
        Try
            Dim lEntidad As New PRE_ANALISIS_ENCA_TRANS
            lEntidad.ID_ENCA = ID_ENCA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
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
    ''' Función que Elimina un Registro de la Tabla PRE_ANALISIS_ENCA_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPRE_ANALISIS_ENCA_TRANS(ByVal ID_ENCA As Int32) As Integer
        Try
            mEntidad.ID_ENCA = ID_ENCA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PRE_ANALISIS_ENCA_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPRE_ANALISIS_ENCA_TRANS(ByVal aEntidad As PRE_ANALISIS_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPRE_ANALISIS_ENCA_TRANS(ByVal ID_ENCA As Int32, ByVal UID_REF As String, ByVal ID_ZAFRA As Int32, ByVal FECHA As DateTime, ByVal CODTRANSPORT As Int32, ByVal NOMBRE_TRANSPORTISTA As String, ByVal UNIDADES As Int32, ByVal NO_VIAJES As Decimal, ByVal TC_PROM_VIAJE As Decimal, ByVal TC_TOTALES As Decimal, ByVal TC_FLETE As Decimal, ByVal VALOR_TOTAL As Decimal, ByVal COMENTARIO As String, ByVal IMPRESO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Integer
        Try
            Dim lEntidad As New PRE_ANALISIS_ENCA_TRANS
            lEntidad.ID_ENCA = ID_ENCA
            lEntidad.UID_REF = UID_REF
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA = FECHA
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRE_TRANSPORTISTA = NOMBRE_TRANSPORTISTA
            lEntidad.UNIDADES = UNIDADES
            lEntidad.NO_VIAJES = NO_VIAJES
            lEntidad.TC_PROM_VIAJE = TC_PROM_VIAJE
            lEntidad.TC_TOTALES = TC_TOTALES
            lEntidad.TC_FLETE = TC_FLETE
            lEntidad.VALOR_TOTAL = VALOR_TOTAL
            lEntidad.COMENTARIO = COMENTARIO
            lEntidad.IMPRESO = IMPRESO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            Return Me.ActualizarPRE_ANALISIS_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPRE_ANALISIS_ENCA_TRANS(ByVal aEntidad As PRE_ANALISIS_ENCA_TRANS) As Integer
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
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPRE_ANALISIS_ENCA_TRANS(ByVal aEntidad As PRE_ANALISIS_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPRE_ANALISIS_ENCA_TRANS(ByVal ID_ENCA As Int32, ByVal UID_REF As String, ByVal ID_ZAFRA As Int32, ByVal FECHA As DateTime, ByVal CODTRANSPORT As Int32, ByVal NOMBRE_TRANSPORTISTA As String, ByVal UNIDADES As Int32, ByVal NO_VIAJES As Decimal, ByVal TC_PROM_VIAJE As Decimal, ByVal TC_TOTALES As Decimal, ByVal TC_FLETE As Decimal, ByVal VALOR_TOTAL As Decimal, ByVal COMENTARIO As String, ByVal IMPRESO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Integer
        Try
            Dim lEntidad As New PRE_ANALISIS_ENCA_TRANS
            lEntidad.ID_ENCA = ID_ENCA
            lEntidad.UID_REF = UID_REF
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA = FECHA
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.NOMBRE_TRANSPORTISTA = NOMBRE_TRANSPORTISTA
            lEntidad.UNIDADES = UNIDADES
            lEntidad.NO_VIAJES = NO_VIAJES
            lEntidad.TC_PROM_VIAJE = TC_PROM_VIAJE
            lEntidad.TC_TOTALES = TC_TOTALES
            lEntidad.TC_FLETE = TC_FLETE
            lEntidad.VALOR_TOTAL = VALOR_TOTAL
            lEntidad.COMENTARIO = COMENTARIO
            lEntidad.IMPRESO = IMPRESO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            Return Me.ActualizarPRE_ANALISIS_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	06/11/2017	Created
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
    ''' 	[GenApp]	06/11/2017	Created
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
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PRE_ANALISIS_ENCA_TRANS )
    End Sub

#End Region

End Class
