''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCONTROL_QUEMA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTROL_QUEMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTROL_QUEMA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTROL_QUEMA()
    Private mEntidad as New CONTROL_QUEMA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_QUEMA
        Try
            Dim mListaCONTROL_QUEMA As New ListaCONTROL_QUEMA
            mListaCONTROL_QUEMA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_QUEMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_QUEMA
            If Not mListaCONTROL_QUEMA Is Nothing Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_QUEMA
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTROL_QUEMA(ByRef aEntidad As CONTROL_QUEMA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTROL_QUEMA.
    ''' </summary>
    ''' <param name="ID_CONTROL_QUEMA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTROL_QUEMA(ByVal ID_CONTROL_QUEMA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CONTROL_QUEMA
        Try
            Dim lEntidad As New CONTROL_QUEMA
            lEntidad.ID_CONTROL_QUEMA = ID_CONTROL_QUEMA
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
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <param name="aCONTROL_QUEMA">Recuperar registro foraneo de la Entidad CONTROL_QUEMA.</param>
    ''' <param name="aCONTROL_QUEMA_SALDO">Recuperar registro foraneo de la Entidad CONTROL_QUEMA_SALDO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCONTROL_QUEMAConForaneas(ByVal aEntidad As CONTROL_QUEMA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aCONTROL_QUEMA As Boolean = False, Optional ByVal aCONTROL_QUEMA_SALDO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aLOTES, aCONTROL_QUEMA, aCONTROL_QUEMA_SALDO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTROL_QUEMA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTROL_QUEMA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTROL_QUEMA(ByVal ID_CONTROL_QUEMA As Int32) As Integer
        Try
            mEntidad.ID_CONTROL_QUEMA = ID_CONTROL_QUEMA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTROL_QUEMA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTROL_QUEMA(ByVal aEntidad As CONTROL_QUEMA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTROL_QUEMA(ByVal ID_CONTROL_QUEMA As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal CONCEPTO As String, ByVal CODIGO_REF As String, ByVal ID_REF As Int32, ByVal ENTRADAS As Decimal, ByVal SALIDAS As Decimal, ByVal SALDO As Decimal, ByVal QUEMA_PROGRAMADA As Boolean, ByVal QUEMA_NOPROG As Boolean, ByVal CANA_VERDE As Boolean, ByVal FECHA_HORA_QUEMA As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_CONTROL_QUEMA_REF As Int32, ByVal ES_PROYECCION As Boolean, ByVal ID_QUEMA_SALDO As Int32) As Integer
        Try
            Dim lEntidad As New CONTROL_QUEMA
            lEntidad.ID_CONTROL_QUEMA = ID_CONTROL_QUEMA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.CODIGO_REF = CODIGO_REF
            lEntidad.ID_REF = ID_REF
            lEntidad.ENTRADAS = ENTRADAS
            lEntidad.SALIDAS = SALIDAS
            lEntidad.SALDO = SALDO
            lEntidad.QUEMA_PROGRAMADA = QUEMA_PROGRAMADA
            lEntidad.QUEMA_NOPROG = QUEMA_NOPROG
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_HORA_QUEMA = FECHA_HORA_QUEMA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_CONTROL_QUEMA_REF = ID_CONTROL_QUEMA_REF
            lEntidad.ES_PROYECCION = ES_PROYECCION
            lEntidad.ID_QUEMA_SALDO = ID_QUEMA_SALDO
            Return Me.ActualizarCONTROL_QUEMA(lEntidad)
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_QUEMA(ByVal ID_CONTROL_QUEMA As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal CONCEPTO As String, ByVal CODIGO_REF As String, ByVal ID_REF As Int32, ByVal ENTRADAS As Decimal, ByVal SALIDAS As Decimal, ByVal SALDO As Decimal, ByVal QUEMA_PROGRAMADA As Boolean, ByVal QUEMA_NOPROG As Boolean, ByVal CANA_VERDE As Boolean, ByVal FECHA_HORA_QUEMA As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_CONTROL_QUEMA_REF As Int32, ByVal ES_PROYECCION As Boolean, ByVal ID_QUEMA_SALDO As Int32) As Integer
        Try
            Dim lEntidad As New CONTROL_QUEMA
            lEntidad.ID_CONTROL_QUEMA = ID_CONTROL_QUEMA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.CODIGO_REF = CODIGO_REF
            lEntidad.ID_REF = ID_REF
            lEntidad.ENTRADAS = ENTRADAS
            lEntidad.SALIDAS = SALIDAS
            lEntidad.SALDO = SALDO
            lEntidad.QUEMA_PROGRAMADA = QUEMA_PROGRAMADA
            lEntidad.QUEMA_NOPROG = QUEMA_NOPROG
            lEntidad.CANA_VERDE = CANA_VERDE
            lEntidad.FECHA_HORA_QUEMA = FECHA_HORA_QUEMA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_CONTROL_QUEMA_REF = ID_CONTROL_QUEMA_REF
            lEntidad.ES_PROYECCION = ES_PROYECCION
            lEntidad.ID_QUEMA_SALDO = ID_QUEMA_SALDO
            Return Me.ActualizarCONTROL_QUEMA(lEntidad)
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
    ''' 	[GenApp]	10/11/2016	Created
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
    ''' 	[GenApp]	10/11/2016	Created
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_QUEMA
        Try
            Dim mListaCONTROL_QUEMA As New ListaCONTROL_QUEMA
            mListaCONTROL_QUEMA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_QUEMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_QUEMA
            If Not mListaCONTROL_QUEMA Is Nothing Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_QUEMA
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_QUEMA
        Try
            Dim mListaCONTROL_QUEMA As New ListaCONTROL_QUEMA
            mListaCONTROL_QUEMA = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_QUEMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_QUEMA
            If Not mListaCONTROL_QUEMA Is Nothing Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_QUEMA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONTROL_QUEMA_SALDO .
    ''' </summary>
    ''' <param name="ID_QUEMA_SALDO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTROL_QUEMA_SALDO(ByVal ID_QUEMA_SALDO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_QUEMA
        Try
            Dim mListaCONTROL_QUEMA As New ListaCONTROL_QUEMA
            mListaCONTROL_QUEMA = mDb.ObtenerListaPorCONTROL_QUEMA_SALDO(ID_QUEMA_SALDO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_QUEMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_QUEMA
            If Not mListaCONTROL_QUEMA Is Nothing Then
                For Each lEntidad As CONTROL_QUEMA in  mListaCONTROL_QUEMA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_QUEMA
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTROL_QUEMA )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkID_CONTROL_QUEMA_REF = (New cCONTROL_QUEMA).ObtenerCONTROL_QUEMA(aEntidad.ID_CONTROL_QUEMA_REF)
        aEntidad.fkID_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerCONTROL_QUEMA_SALDO(aEntidad.ID_QUEMA_SALDO)
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
    ''' 	[GenApp]	10/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTROL_QUEMA )
    End Sub

#End Region

End Class
