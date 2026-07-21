''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_APLICA_LOTE
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_APLICA_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/12/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_APLICA_LOTE
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_APLICA_LOTE()
    Private mEntidad as New SOLIC_APLICA_LOTE
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_APLICA_LOTE
        Try
            Dim mListaSOLIC_APLICA_LOTE As New ListaSOLIC_APLICA_LOTE
            mListaSOLIC_APLICA_LOTE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_APLICA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_APLICA_LOTE in  mListaSOLIC_APLICA_LOTE
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_APLICA_LOTE
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_APLICA_LOTE(ByRef aEntidad As SOLIC_APLICA_LOTE, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_APLICA_LOTE.
    ''' </summary>
    ''' <param name="ID_SOLIC_APLICA_LOTE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_APLICA_LOTE(ByVal ID_SOLIC_APLICA_LOTE As Int32, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_APLICA_LOTE
        Try
            Dim lEntidad As New SOLIC_APLICA_LOTE
            lEntidad.ID_SOLIC_APLICA_LOTE = ID_SOLIC_APLICA_LOTE
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
    ''' <param name="aSOLIC_AGRICOLA">Recuperar registro foraneo de la Entidad SOLIC_AGRICOLA.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <param name="aMAESTRO_LOTES">Recuperar registro foraneo de la Entidad MAESTRO_LOTES.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_APLICA_LOTEConForaneas(ByVal aEntidad As SOLIC_APLICA_LOTE, Optional ByVal aLOTES_COSECHA As Boolean = False, Optional ByVal aSOLIC_AGRICOLA As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aMAESTRO_LOTES As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aLOTES_COSECHA, aSOLIC_AGRICOLA, aZAFRA, aLOTES, aMAESTRO_LOTES)
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_APLICA_LOTE(ByVal ID_SOLIC_APLICA_LOTE As Int32, ByVal ID_LOTES_COSECHA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal MZ As Decimal, ByVal FECHA_APLICA As DateTime, ByVal ID_PRODUCTO As Int32, ByVal CANT_X_MZ As Decimal, ByVal TOTAL_PRODUCTO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal ID_MAESTRO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal FECHA_INI_VENTANA As DateTime, ByVal FECHA_FIN_VENTANA As DateTime, ByVal FECHA_ROZA_MADURANTE As DateTime, ByVal TONELADAS As Decimal, ByVal UID_REFERENCIA As Guid) As Integer
        Try
            Dim lEntidad As New SOLIC_APLICA_LOTE
            lEntidad.ID_SOLIC_APLICA_LOTE = ID_SOLIC_APLICA_LOTE
            lEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ = MZ
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANT_X_MZ = CANT_X_MZ
            lEntidad.TOTAL_PRODUCTO = TOTAL_PRODUCTO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.FECHA_INI_VENTANA = FECHA_INI_VENTANA
            lEntidad.FECHA_FIN_VENTANA = FECHA_FIN_VENTANA
            lEntidad.FECHA_ROZA_MADURANTE = FECHA_ROZA_MADURANTE
            lEntidad.TONELADAS = TONELADAS
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            Return Me.ActualizarSOLIC_APLICA_LOTE(lEntidad)
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_APLICA_LOTE(ByVal ID_SOLIC_APLICA_LOTE As Int32, ByVal ID_LOTES_COSECHA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal MZ As Decimal, ByVal FECHA_APLICA As DateTime, ByVal ID_PRODUCTO As Int32, ByVal CANT_X_MZ As Decimal, ByVal TOTAL_PRODUCTO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal ID_MAESTRO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal FECHA_INI_VENTANA As DateTime, ByVal FECHA_FIN_VENTANA As DateTime, ByVal FECHA_ROZA_MADURANTE As DateTime, ByVal TONELADAS As Decimal, ByVal UID_REFERENCIA As Guid) As Integer
        Try
            Dim lEntidad As New SOLIC_APLICA_LOTE
            lEntidad.ID_SOLIC_APLICA_LOTE = ID_SOLIC_APLICA_LOTE
            lEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.MZ = MZ
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANT_X_MZ = CANT_X_MZ
            lEntidad.TOTAL_PRODUCTO = TOTAL_PRODUCTO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.FECHA_INI_VENTANA = FECHA_INI_VENTANA
            lEntidad.FECHA_FIN_VENTANA = FECHA_FIN_VENTANA
            lEntidad.FECHA_ROZA_MADURANTE = FECHA_ROZA_MADURANTE
            lEntidad.TONELADAS = TONELADAS
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            Return Me.ActualizarSOLIC_APLICA_LOTE(lEntidad)
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
    ''' 	[GenApp]	07/12/2018	Created
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
    ''' 	[GenApp]	07/12/2018	Created
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES_COSECHA(ByVal ID_LOTES_COSECHA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_APLICA_LOTE
        Try
            Dim mListaSOLIC_APLICA_LOTE As New ListaSOLIC_APLICA_LOTE
            mListaSOLIC_APLICA_LOTE = mDb.ObtenerListaPorLOTES_COSECHA(ID_LOTES_COSECHA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_APLICA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_APLICA_LOTE in  mListaSOLIC_APLICA_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_APLICA_LOTE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_APLICA_LOTE
        Try
            Dim mListaSOLIC_APLICA_LOTE As New ListaSOLIC_APLICA_LOTE
            mListaSOLIC_APLICA_LOTE = mDb.ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_APLICA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_APLICA_LOTE in  mListaSOLIC_APLICA_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_APLICA_LOTE
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_APLICA_LOTE
        Try
            Dim mListaSOLIC_APLICA_LOTE As New ListaSOLIC_APLICA_LOTE
            mListaSOLIC_APLICA_LOTE = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_APLICA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_APLICA_LOTE in  mListaSOLIC_APLICA_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_APLICA_LOTE
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_APLICA_LOTE
        Try
            Dim mListaSOLIC_APLICA_LOTE As New ListaSOLIC_APLICA_LOTE
            mListaSOLIC_APLICA_LOTE = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_APLICA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_APLICA_LOTE in  mListaSOLIC_APLICA_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_APLICA_LOTE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MAESTRO_LOTES .
    ''' </summary>
    ''' <param name="ID_MAESTRO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_APLICA_LOTE
        Try
            Dim mListaSOLIC_APLICA_LOTE As New ListaSOLIC_APLICA_LOTE
            mListaSOLIC_APLICA_LOTE = mDb.ObtenerListaPorMAESTRO_LOTES(ID_MAESTRO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_APLICA_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_APLICA_LOTE in  mListaSOLIC_APLICA_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_APLICA_LOTE
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_APLICA_LOTE )
        aEntidad.fkID_LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(aEntidad.ID_LOTES_COSECHA)
        aEntidad.fkID_SOLICITUD = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkID_MAESTRO = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(aEntidad.ID_MAESTRO)
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
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_APLICA_LOTE )
    End Sub

#End Region

End Class
