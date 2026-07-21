''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cDOCUMENTO_SALIDA_ENCA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla DOCUMENTO_SALIDA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cDOCUMENTO_SALIDA_ENCA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbDOCUMENTO_SALIDA_ENCA()
    Private mEntidad as New DOCUMENTO_SALIDA_ENCA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_ENCA
        Try
            Dim mListaDOCUMENTO_SALIDA_ENCA As New ListaDOCUMENTO_SALIDA_ENCA
            mListaDOCUMENTO_SALIDA_ENCA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDOCUMENTO_SALIDA_ENCA
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_ENCA
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDOCUMENTO_SALIDA_ENCA(ByRef aEntidad As DOCUMENTO_SALIDA_ENCA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla DOCUMENTO_SALIDA_ENCA.
    ''' </summary>
    ''' <param name="ID_DOCSAL_ENCA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As DOCUMENTO_SALIDA_ENCA
        Try
            Dim lEntidad As New DOCUMENTO_SALIDA_ENCA
            lEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA
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
    ''' <param name="aTIPO_MOVTO">Recuperar registro foraneo de la Entidad TIPO_MOVTO.</param>
    ''' <param name="aBODEGA">Recuperar registro foraneo de la Entidad BODEGA.</param>
    ''' <param name="aSALBODE_ENCA">Recuperar registro foraneo de la Entidad SALBODE_ENCA.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDOCUMENTO_SALIDA_ENCAConForaneas(ByVal aEntidad As DOCUMENTO_SALIDA_ENCA, Optional ByVal aTIPO_MOVTO As Boolean = False, Optional ByVal aBODEGA As Boolean = False, Optional ByVal aSALBODE_ENCA As Boolean = False, Optional ByVal aZAFRA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aTIPO_MOVTO, aBODEGA, aSALBODE_ENCA, aZAFRA)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32, ByVal NO_DOCUMENTO As Int32, ByVal ID_TIPO_MOVTO As Int32, ByVal FECHA_DOCTO As DateTime, ByVal UID_DOCUMENTO As Guid, ByVal ID_BODEGA As Int32, ByVal OBSERVACIONES As String, ByVal ENTREGADO As String, ByVal RECIBIDO As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_SALBODE_ENCA As Int32, ByVal ID_ZAFRA As Int32) As Integer
        Try
            Dim lEntidad As New DOCUMENTO_SALIDA_ENCA
            lEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA
            lEntidad.NO_DOCUMENTO = NO_DOCUMENTO
            lEntidad.ID_TIPO_MOVTO = ID_TIPO_MOVTO
            lEntidad.FECHA_DOCTO = FECHA_DOCTO
            lEntidad.UID_DOCUMENTO = UID_DOCUMENTO
            lEntidad.ID_BODEGA = ID_BODEGA
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.ENTREGADO = ENTREGADO
            lEntidad.RECIBIDO = RECIBIDO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_SALBODE_ENCA = ID_SALBODE_ENCA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            Return Me.ActualizarDOCUMENTO_SALIDA_ENCA(lEntidad)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32, ByVal NO_DOCUMENTO As Int32, ByVal ID_TIPO_MOVTO As Int32, ByVal FECHA_DOCTO As DateTime, ByVal UID_DOCUMENTO As Guid, ByVal ID_BODEGA As Int32, ByVal OBSERVACIONES As String, ByVal ENTREGADO As String, ByVal RECIBIDO As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_SALBODE_ENCA As Int32, ByVal ID_ZAFRA As Int32) As Integer
        Try
            Dim lEntidad As New DOCUMENTO_SALIDA_ENCA
            lEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA
            lEntidad.NO_DOCUMENTO = NO_DOCUMENTO
            lEntidad.ID_TIPO_MOVTO = ID_TIPO_MOVTO
            lEntidad.FECHA_DOCTO = FECHA_DOCTO
            lEntidad.UID_DOCUMENTO = UID_DOCUMENTO
            lEntidad.ID_BODEGA = ID_BODEGA
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.ENTREGADO = ENTREGADO
            lEntidad.RECIBIDO = RECIBIDO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_SALBODE_ENCA = ID_SALBODE_ENCA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            Return Me.ActualizarDOCUMENTO_SALIDA_ENCA(lEntidad)
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
    ''' 	[GenApp]	14/06/2018	Created
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
    ''' 	[GenApp]	14/06/2018	Created
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
    ''' la Tabla TIPO_MOVTO .
    ''' </summary>
    ''' <param name="ID_TIPO_MOVTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_MOVTO(ByVal ID_TIPO_MOVTO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_ENCA
        Try
            Dim mListaDOCUMENTO_SALIDA_ENCA As New ListaDOCUMENTO_SALIDA_ENCA
            mListaDOCUMENTO_SALIDA_ENCA = mDb.ObtenerListaPorTIPO_MOVTO(ID_TIPO_MOVTO, asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDOCUMENTO_SALIDA_ENCA
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_ENCA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla BODEGA .
    ''' </summary>
    ''' <param name="ID_BODEGA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorBODEGA(ByVal ID_BODEGA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_ENCA
        Try
            Dim mListaDOCUMENTO_SALIDA_ENCA As New ListaDOCUMENTO_SALIDA_ENCA
            mListaDOCUMENTO_SALIDA_ENCA = mDb.ObtenerListaPorBODEGA(ID_BODEGA, asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDOCUMENTO_SALIDA_ENCA
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_ENCA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SALBODE_ENCA .
    ''' </summary>
    ''' <param name="ID_SALBODE_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSALBODE_ENCA(ByVal ID_SALBODE_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_ENCA
        Try
            Dim mListaDOCUMENTO_SALIDA_ENCA As New ListaDOCUMENTO_SALIDA_ENCA
            mListaDOCUMENTO_SALIDA_ENCA = mDb.ObtenerListaPorSALBODE_ENCA(ID_SALBODE_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDOCUMENTO_SALIDA_ENCA
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_ENCA
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_ENCA
        Try
            Dim mListaDOCUMENTO_SALIDA_ENCA As New ListaDOCUMENTO_SALIDA_ENCA
            mListaDOCUMENTO_SALIDA_ENCA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDOCUMENTO_SALIDA_ENCA
            If Not mListaDOCUMENTO_SALIDA_ENCA Is Nothing Then
                For Each lEntidad As DOCUMENTO_SALIDA_ENCA in  mListaDOCUMENTO_SALIDA_ENCA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_ENCA
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As DOCUMENTO_SALIDA_ENCA )
        aEntidad.fkID_TIPO_MOVTO = (New cTIPO_MOVTO).ObtenerTIPO_MOVTO(aEntidad.ID_TIPO_MOVTO)
        aEntidad.fkID_BODEGA = (New cBODEGA).ObtenerBODEGA(aEntidad.ID_BODEGA)
        aEntidad.fkID_SALBODE_ENCA = (New cSALBODE_ENCA).ObtenerSALBODE_ENCA(aEntidad.ID_SALBODE_ENCA)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As DOCUMENTO_SALIDA_ENCA )
    End Sub

#End Region

End Class
