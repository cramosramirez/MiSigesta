''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCENSO_LOTES
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CENSO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCENSO_LOTES
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCENSO_LOTES()
    Private mEntidad as New CENSO_LOTES
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCENSO_LOTES
        Try
            Dim mListaCENSO_LOTES As New ListaCENSO_LOTES
            mListaCENSO_LOTES = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCENSO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As CENSO_LOTES in  mListaCENSO_LOTES
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCENSO_LOTES
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCENSO_LOTES(ByRef aEntidad As CENSO_LOTES, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CENSO_LOTES.
    ''' </summary>
    ''' <param name="ID_CENSO_LOTES"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCENSO_LOTES(ByVal ID_CENSO_LOTES As Int32, ByVal Optional recuperarForaneas As Boolean = False) As CENSO_LOTES
        Try
            Dim lEntidad As New CENSO_LOTES
            lEntidad.ID_CENSO_LOTES = ID_CENSO_LOTES
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
    ''' <param name="aCENSO">Recuperar registro foraneo de la Entidad CENSO.</param>
    ''' <param name="aMOTIVO_VARIACION">Recuperar registro foraneo de la Entidad MOTIVO_VARIACION.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCENSO_LOTESConForaneas(ByVal aEntidad As CENSO_LOTES, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aCENSO As Boolean = False, Optional ByVal aMOTIVO_VARIACION As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aLOTES, aCENSO, aMOTIVO_VARIACION)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CENSO_LOTES que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CENSO_LOTES"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCENSO_LOTES(ByVal ID_CENSO_LOTES As Int32) As Integer
        Try
            mEntidad.ID_CENSO_LOTES = ID_CENSO_LOTES
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CENSO_LOTES que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCENSO_LOTES(ByVal aEntidad As CENSO_LOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCENSO_LOTES(ByVal ID_CENSO_LOTES As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal FECHA_VERIFICACION As DateTime, ByVal REND_HISTO As Decimal, ByVal MZ_ENTREGAR As Decimal, ByVal TONEL_MZ_ENTREGAR As Decimal, ByVal TONEL_ENTREGAR As Decimal, ByVal LBS_ENTREGAR As Decimal, ByVal VALOR_ENTREGAR As Decimal, ByVal MZ_ENTREGADA As Decimal, ByVal TONEL_MZ_ENTREGADA As Decimal, ByVal TONEL_ENTREGADA As Decimal, ByVal LBS_ENTREGADA As Decimal, ByVal VALOR_ENTREGADA As Decimal, ByVal MZ_CENSO As Decimal, ByVal TONEL_MZ_CENSO As Decimal, ByVal TONEL_CENSO As Decimal, ByVal LBS_CENSO As Decimal, ByVal VALOR_CENSO As Decimal, ByVal ID_CENSO As Int32, ByVal ID_MOTIVO_VARIACION As Int32, ByVal OBSERVACION As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New CENSO_LOTES
            lEntidad.ID_CENSO_LOTES = ID_CENSO_LOTES
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.FECHA_VERIFICACION = FECHA_VERIFICACION
            lEntidad.REND_HISTO = REND_HISTO
            lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
            lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
            lEntidad.TONEL_ENTREGAR = TONEL_ENTREGAR
            lEntidad.LBS_ENTREGAR = LBS_ENTREGAR
            lEntidad.VALOR_ENTREGAR = VALOR_ENTREGAR
            lEntidad.MZ_ENTREGADA = MZ_ENTREGADA
            lEntidad.TONEL_MZ_ENTREGADA = TONEL_MZ_ENTREGADA
            lEntidad.TONEL_ENTREGADA = TONEL_ENTREGADA
            lEntidad.LBS_ENTREGADA = LBS_ENTREGADA
            lEntidad.VALOR_ENTREGADA = VALOR_ENTREGADA
            lEntidad.MZ_CENSO = MZ_CENSO
            lEntidad.TONEL_MZ_CENSO = TONEL_MZ_CENSO
            lEntidad.TONEL_CENSO = TONEL_CENSO
            lEntidad.LBS_CENSO = LBS_CENSO
            lEntidad.VALOR_CENSO = VALOR_CENSO
            lEntidad.ID_CENSO = ID_CENSO
            lEntidad.ID_MOTIVO_VARIACION = ID_MOTIVO_VARIACION
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarCENSO_LOTES(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCENSO_LOTES(ByVal aEntidad As CENSO_LOTES) As Integer
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCENSO_LOTES(ByVal aEntidad As CENSO_LOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCENSO_LOTES(ByVal ID_CENSO_LOTES As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal FECHA_VERIFICACION As DateTime, ByVal REND_HISTO As Decimal, ByVal MZ_ENTREGAR As Decimal, ByVal TONEL_MZ_ENTREGAR As Decimal, ByVal TONEL_ENTREGAR As Decimal, ByVal LBS_ENTREGAR As Decimal, ByVal VALOR_ENTREGAR As Decimal, ByVal MZ_ENTREGADA As Decimal, ByVal TONEL_MZ_ENTREGADA As Decimal, ByVal TONEL_ENTREGADA As Decimal, ByVal LBS_ENTREGADA As Decimal, ByVal VALOR_ENTREGADA As Decimal, ByVal MZ_CENSO As Decimal, ByVal TONEL_MZ_CENSO As Decimal, ByVal TONEL_CENSO As Decimal, ByVal LBS_CENSO As Decimal, ByVal VALOR_CENSO As Decimal, ByVal ID_CENSO As Int32, ByVal ID_MOTIVO_VARIACION As Int32, ByVal OBSERVACION As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New CENSO_LOTES
            lEntidad.ID_CENSO_LOTES = ID_CENSO_LOTES
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.FECHA_VERIFICACION = FECHA_VERIFICACION
            lEntidad.REND_HISTO = REND_HISTO
            lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
            lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
            lEntidad.TONEL_ENTREGAR = TONEL_ENTREGAR
            lEntidad.LBS_ENTREGAR = LBS_ENTREGAR
            lEntidad.VALOR_ENTREGAR = VALOR_ENTREGAR
            lEntidad.MZ_ENTREGADA = MZ_ENTREGADA
            lEntidad.TONEL_MZ_ENTREGADA = TONEL_MZ_ENTREGADA
            lEntidad.TONEL_ENTREGADA = TONEL_ENTREGADA
            lEntidad.LBS_ENTREGADA = LBS_ENTREGADA
            lEntidad.VALOR_ENTREGADA = VALOR_ENTREGADA
            lEntidad.MZ_CENSO = MZ_CENSO
            lEntidad.TONEL_MZ_CENSO = TONEL_MZ_CENSO
            lEntidad.TONEL_CENSO = TONEL_CENSO
            lEntidad.LBS_CENSO = LBS_CENSO
            lEntidad.VALOR_CENSO = VALOR_CENSO
            lEntidad.ID_CENSO = ID_CENSO
            lEntidad.ID_MOTIVO_VARIACION = ID_MOTIVO_VARIACION
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarCENSO_LOTES(lEntidad)
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
    ''' 	[GenApp]	03/04/2014	Created
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
    ''' 	[GenApp]	03/04/2014	Created
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCENSO_LOTES
        Try
            Dim mListaCENSO_LOTES As New ListaCENSO_LOTES
            mListaCENSO_LOTES = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCENSO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As CENSO_LOTES in  mListaCENSO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCENSO_LOTES
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCENSO_LOTES
        Try
            Dim mListaCENSO_LOTES As New ListaCENSO_LOTES
            mListaCENSO_LOTES = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaCENSO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As CENSO_LOTES in  mListaCENSO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCENSO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CENSO .
    ''' </summary>
    ''' <param name="ID_CENSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCENSO(ByVal ID_CENSO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCENSO_LOTES
        Try
            Dim mListaCENSO_LOTES As New ListaCENSO_LOTES
            mListaCENSO_LOTES = mDb.ObtenerListaPorCENSO(ID_CENSO, asColumnaOrden, asTipoOrden)
            If Not mListaCENSO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As CENSO_LOTES in  mListaCENSO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCENSO_LOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MOTIVO_VARIACION .
    ''' </summary>
    ''' <param name="ID_MOTIVO_VARIACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTIVO_VARIACION(ByVal ID_MOTIVO_VARIACION As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCENSO_LOTES
        Try
            Dim mListaCENSO_LOTES As New ListaCENSO_LOTES
            mListaCENSO_LOTES = mDb.ObtenerListaPorMOTIVO_VARIACION(ID_MOTIVO_VARIACION, asColumnaOrden, asTipoOrden)
            If Not mListaCENSO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As CENSO_LOTES in  mListaCENSO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCENSO_LOTES
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CENSO_LOTES )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkID_CENSO = (New cCENSO).ObtenerCENSO(aEntidad.ID_CENSO)
        aEntidad.fkID_MOTIVO_VARIACION = (New cMOTIVO_VARIACION).ObtenerMOTIVO_VARIACION(aEntidad.ID_MOTIVO_VARIACION)
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
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CENSO_LOTES )
    End Sub

#End Region

End Class
