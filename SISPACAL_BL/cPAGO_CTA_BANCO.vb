''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPAGO_CTA_BANCO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PAGO_CTA_BANCO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPAGO_CTA_BANCO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPAGO_CTA_BANCO()
    Private mEntidad as New PAGO_CTA_BANCO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPAGO_CTA_BANCO
        Try
            Dim mListaPAGO_CTA_BANCO As New ListaPAGO_CTA_BANCO
            mListaPAGO_CTA_BANCO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPAGO_CTA_BANCO Is Nothing And recuperarForaneas Then
                For Each lEntidad As PAGO_CTA_BANCO in  mListaPAGO_CTA_BANCO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPAGO_CTA_BANCO
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPAGO_CTA_BANCO(ByRef aEntidad As PAGO_CTA_BANCO, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PAGO_CTA_BANCO.
    ''' </summary>
    ''' <param name="ID_PAGO_CTA_BANCO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPAGO_CTA_BANCO(ByVal ID_PAGO_CTA_BANCO As Int32, ByVal Optional recuperarForaneas As Boolean = False) As PAGO_CTA_BANCO
        Try
            Dim lEntidad As New PAGO_CTA_BANCO
            lEntidad.ID_PAGO_CTA_BANCO = ID_PAGO_CTA_BANCO
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
    ''' <param name="aCATORCENA_ZAFRA">Recuperar registro foraneo de la Entidad CATORCENA_ZAFRA.</param>
    ''' <param name="aPLANILLA">Recuperar registro foraneo de la Entidad PLANILLA.</param>
    ''' <param name="aTIPO_PLANILLA">Recuperar registro foraneo de la Entidad TIPO_PLANILLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPAGO_CTA_BANCOConForaneas(ByVal aEntidad As PAGO_CTA_BANCO, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aPLANILLA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCATORCENA_ZAFRA, aPLANILLA, aTIPO_PLANILLA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PAGO_CTA_BANCO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PAGO_CTA_BANCO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPAGO_CTA_BANCO(ByVal ID_PAGO_CTA_BANCO As Int32) As Integer
        Try
            mEntidad.ID_PAGO_CTA_BANCO = ID_PAGO_CTA_BANCO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PAGO_CTA_BANCO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPAGO_CTA_BANCO(ByVal aEntidad As PAGO_CTA_BANCO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPAGO_CTA_BANCO(ByVal ID_PAGO_CTA_BANCO As Int32, ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal CODIBANCO As Int32, ByVal NUM_CUENTA As String, ByVal ES_CTA_CORRIENTE As Boolean, ByVal MONTO_PAGO As Decimal, ByVal ENTREGO_CCF As Boolean, ByVal PAGO_GENERADO As Boolean, ByVal FECHA_GENPAGO As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New PAGO_CTA_BANCO
            lEntidad.ID_PAGO_CTA_BANCO = ID_PAGO_CTA_BANCO
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.NUM_CUENTA = NUM_CUENTA
            lEntidad.ES_CTA_CORRIENTE = ES_CTA_CORRIENTE
            lEntidad.MONTO_PAGO = MONTO_PAGO
            lEntidad.ENTREGO_CCF = ENTREGO_CCF
            lEntidad.PAGO_GENERADO = PAGO_GENERADO
            lEntidad.FECHA_GENPAGO = FECHA_GENPAGO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarPAGO_CTA_BANCO(lEntidad)
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPAGO_CTA_BANCO(ByVal aEntidad As PAGO_CTA_BANCO) As Integer
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPAGO_CTA_BANCO(ByVal aEntidad As PAGO_CTA_BANCO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPAGO_CTA_BANCO(ByVal ID_PAGO_CTA_BANCO As Int32, ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal CODIBANCO As Int32, ByVal NUM_CUENTA As String, ByVal ES_CTA_CORRIENTE As Boolean, ByVal MONTO_PAGO As Decimal, ByVal ENTREGO_CCF As Boolean, ByVal PAGO_GENERADO As Boolean, ByVal FECHA_GENPAGO As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New PAGO_CTA_BANCO
            lEntidad.ID_PAGO_CTA_BANCO = ID_PAGO_CTA_BANCO
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.NUM_CUENTA = NUM_CUENTA
            lEntidad.ES_CTA_CORRIENTE = ES_CTA_CORRIENTE
            lEntidad.MONTO_PAGO = MONTO_PAGO
            lEntidad.ENTREGO_CCF = ENTREGO_CCF
            lEntidad.PAGO_GENERADO = PAGO_GENERADO
            lEntidad.FECHA_GENPAGO = FECHA_GENPAGO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarPAGO_CTA_BANCO(lEntidad)
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
    ''' 	[GenApp]	13/01/2017	Created
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
    ''' 	[GenApp]	13/01/2017	Created
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
    ''' la Tabla CATORCENA_ZAFRA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPAGO_CTA_BANCO
        Try
            Dim mListaPAGO_CTA_BANCO As New ListaPAGO_CTA_BANCO
            mListaPAGO_CTA_BANCO = mDb.ObtenerListaPorCATORCENA_ZAFRA(ID_CATORCENA, asColumnaOrden, asTipoOrden)
            If Not mListaPAGO_CTA_BANCO Is Nothing And recuperarForaneas Then
                For Each lEntidad As PAGO_CTA_BANCO in  mListaPAGO_CTA_BANCO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPAGO_CTA_BANCO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PLANILLA .
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPAGO_CTA_BANCO
        Try
            Dim mListaPAGO_CTA_BANCO As New ListaPAGO_CTA_BANCO
            mListaPAGO_CTA_BANCO = mDb.ObtenerListaPorPLANILLA(ID_CATORCENA, CODIPROVEEDOR_TRANSPORTISTA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaPAGO_CTA_BANCO Is Nothing And recuperarForaneas Then
                For Each lEntidad As PAGO_CTA_BANCO in  mListaPAGO_CTA_BANCO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPAGO_CTA_BANCO
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPAGO_CTA_BANCO
        Try
            Dim mListaPAGO_CTA_BANCO As New ListaPAGO_CTA_BANCO
            mListaPAGO_CTA_BANCO = mDb.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaPAGO_CTA_BANCO Is Nothing And recuperarForaneas Then
                For Each lEntidad As PAGO_CTA_BANCO in  mListaPAGO_CTA_BANCO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPAGO_CTA_BANCO
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PAGO_CTA_BANCO )
        aEntidad.fkID_CATORCENA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
        aEntidad.fkCODIPROVEEDOR_TRANSPORTISTA = (New cPLANILLA).ObtenerPLANILLA(aEntidad.ID_CATORCENA, aEntidad.CODIPROVEEDOR_TRANSPORTISTA, aEntidad.ID_TIPO_PLANILLA)
        aEntidad.fkID_TIPO_PLANILLA = (New cTIPO_PLANILLA).ObtenerTIPO_PLANILLA(aEntidad.ID_TIPO_PLANILLA)
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
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PAGO_CTA_BANCO )
    End Sub

#End Region

End Class
