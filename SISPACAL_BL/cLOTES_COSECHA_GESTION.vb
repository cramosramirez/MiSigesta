''' -----------------------------------------------------------------------------
''' Project	 : INJIBOA_BL
''' Class	 : BL.cLOTES_COSECHA_GESTION
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla LOTES_COSECHA_GESTION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/09/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cLOTES_COSECHA_GESTION
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbLOTES_COSECHA_GESTION()
    Private mEntidad as New LOTES_COSECHA_GESTION
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES_COSECHA_GESTION
        Try
            Dim mListaLOTES_COSECHA_GESTION As New ListaLOTES_COSECHA_GESTION
            mListaLOTES_COSECHA_GESTION = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaLOTES_COSECHA_GESTION Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES_COSECHA_GESTION in  mListaLOTES_COSECHA_GESTION
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLOTES_COSECHA_GESTION
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLOTES_COSECHA_GESTION(ByRef aEntidad As LOTES_COSECHA_GESTION, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla LOTES_COSECHA_GESTION.
    ''' </summary>
    ''' <param name="ID_LOTE_COSE_GESTION"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLOTES_COSECHA_GESTION(ByVal ID_LOTE_COSE_GESTION As Int32, ByVal Optional recuperarForaneas As Boolean = False) As LOTES_COSECHA_GESTION
        Try
            Dim lEntidad As New LOTES_COSECHA_GESTION
            lEntidad.ID_LOTE_COSE_GESTION = ID_LOTE_COSE_GESTION
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
    ''' <param name="aLOTES_COSECHA">Recuperar registro foraneo de la Entidad LOTES_COSECHA.</param>
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerLOTES_COSECHA_GESTIONConForaneas(ByVal aEntidad As LOTES_COSECHA_GESTION, Optional ByVal aLOTES_COSECHA As Boolean = False, Optional ByVal aLOTES As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aLOTES_COSECHA, aLOTES)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES_COSECHA_GESTION que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_LOTE_COSE_GESTION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLOTES_COSECHA_GESTION(ByVal ID_LOTE_COSE_GESTION As Int32) As Integer
        Try
            mEntidad.ID_LOTE_COSE_GESTION = ID_LOTE_COSE_GESTION
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES_COSECHA_GESTION que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLOTES_COSECHA_GESTION(ByVal aEntidad As LOTES_COSECHA_GESTION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarLOTES_COSECHA_GESTION(ByVal ID_LOTE_COSE_GESTION As Int32, ByVal ID_LOTES_COSECHA As Int32, ByVal ACCESLOTE As String, ByVal OB_PROD_INTERNA As String, ByVal OB_PERSO_TEC As String, ByVal MZ_PERDIDA As Decimal, ByVal TC_PERDIDA As Decimal, ByVal RENOVACION As Decimal, ByVal SIEMBRA_NUEVA As Decimal, ByVal SIEMBRA_PROYE As Decimal, ByVal MZ_PENDIENTE As Decimal, ByVal TC_PENDIENTE As Decimal, ByVal TIPO_ROZA As String, ByVal TIPO_TRANSPORTE As String, ByVal TIPO_QUEMA As String, ByVal MAD_APLICAR As String, ByVal MAD_DOSIS As Decimal, ByVal MAD_FECHA_APLI As DateTime) As Integer
        Try
            Dim lEntidad As New LOTES_COSECHA_GESTION
            lEntidad.ID_LOTE_COSE_GESTION = ID_LOTE_COSE_GESTION
            lEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.OB_PROD_INTERNA = OB_PROD_INTERNA
            lEntidad.OB_PERSO_TEC = OB_PERSO_TEC
            lEntidad.MZ_PERDIDA = MZ_PERDIDA
            lEntidad.TC_PERDIDA = TC_PERDIDA
            lEntidad.RENOVACION = RENOVACION
            lEntidad.SIEMBRA_NUEVA = SIEMBRA_NUEVA
            lEntidad.SIEMBRA_PROYE = SIEMBRA_PROYE
            lEntidad.MZ_PENDIENTE = MZ_PENDIENTE
            lEntidad.TC_PENDIENTE = TC_PENDIENTE
            lEntidad.TIPO_ROZA = TIPO_ROZA
            lEntidad.TIPO_TRANSPORTE = TIPO_TRANSPORTE
            lEntidad.TIPO_QUEMA = TIPO_QUEMA
            lEntidad.MAD_APLICAR = MAD_APLICAR
            lEntidad.MAD_DOSIS = MAD_DOSIS
            lEntidad.MAD_FECHA_APLI = MAD_FECHA_APLI
            Return Me.ActualizarLOTES_COSECHA_GESTION(lEntidad)
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES_COSECHA_GESTION(ByVal aEntidad As LOTES_COSECHA_GESTION) As Integer
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES_COSECHA_GESTION(ByVal aEntidad As LOTES_COSECHA_GESTION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES_COSECHA_GESTION(ByVal ID_LOTE_COSE_GESTION As Int32, ByVal ID_LOTES_COSECHA As Int32, ByVal ACCESLOTE As String, ByVal OB_PROD_INTERNA As String, ByVal OB_PERSO_TEC As String, ByVal MZ_PERDIDA As Decimal, ByVal TC_PERDIDA As Decimal, ByVal RENOVACION As Decimal, ByVal SIEMBRA_NUEVA As Decimal, ByVal SIEMBRA_PROYE As Decimal, ByVal MZ_PENDIENTE As Decimal, ByVal TC_PENDIENTE As Decimal, ByVal TIPO_ROZA As String, ByVal TIPO_TRANSPORTE As String, ByVal TIPO_QUEMA As String, ByVal MAD_APLICAR As String, ByVal MAD_DOSIS As Decimal, ByVal MAD_FECHA_APLI As DateTime) As Integer
        Try
            Dim lEntidad As New LOTES_COSECHA_GESTION
            lEntidad.ID_LOTE_COSE_GESTION = ID_LOTE_COSE_GESTION
            lEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.OB_PROD_INTERNA = OB_PROD_INTERNA
            lEntidad.OB_PERSO_TEC = OB_PERSO_TEC
            lEntidad.MZ_PERDIDA = MZ_PERDIDA
            lEntidad.TC_PERDIDA = TC_PERDIDA
            lEntidad.RENOVACION = RENOVACION
            lEntidad.SIEMBRA_NUEVA = SIEMBRA_NUEVA
            lEntidad.SIEMBRA_PROYE = SIEMBRA_PROYE
            lEntidad.MZ_PENDIENTE = MZ_PENDIENTE
            lEntidad.TC_PENDIENTE = TC_PENDIENTE
            lEntidad.TIPO_ROZA = TIPO_ROZA
            lEntidad.TIPO_TRANSPORTE = TIPO_TRANSPORTE
            lEntidad.TIPO_QUEMA = TIPO_QUEMA
            lEntidad.MAD_APLICAR = MAD_APLICAR
            lEntidad.MAD_DOSIS = MAD_DOSIS
            lEntidad.MAD_FECHA_APLI = MAD_FECHA_APLI
            Return Me.ActualizarLOTES_COSECHA_GESTION(lEntidad)
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
    ''' 	[GenApp]	12/09/2022	Created
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
    ''' 	[GenApp]	12/09/2022	Created
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
    ''' la Tabla LOTES_COSECHA .
    ''' </summary>
    ''' <param name="ID_LOTES_COSECHA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES_COSECHA(ByVal ID_LOTES_COSECHA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES_COSECHA_GESTION
        Try
            Dim mListaLOTES_COSECHA_GESTION As New ListaLOTES_COSECHA_GESTION
            mListaLOTES_COSECHA_GESTION = mDb.ObtenerListaPorLOTES_COSECHA(ID_LOTES_COSECHA, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES_COSECHA_GESTION Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES_COSECHA_GESTION in  mListaLOTES_COSECHA_GESTION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLOTES_COSECHA_GESTION
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES_COSECHA_GESTION
        Try
            Dim mListaLOTES_COSECHA_GESTION As New ListaLOTES_COSECHA_GESTION
            mListaLOTES_COSECHA_GESTION = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES_COSECHA_GESTION Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES_COSECHA_GESTION in  mListaLOTES_COSECHA_GESTION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLOTES_COSECHA_GESTION
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As LOTES_COSECHA_GESTION )
        aEntidad.fkID_LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(aEntidad.ID_LOTES_COSECHA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
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
    ''' 	[GenApp]	12/09/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As LOTES_COSECHA_GESTION )
    End Sub

#End Region

End Class
