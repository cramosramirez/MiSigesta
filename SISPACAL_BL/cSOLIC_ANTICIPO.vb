''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_ANTICIPO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_ANTICIPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_ANTICIPO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_ANTICIPO()
    Private mEntidad as New SOLIC_ANTICIPO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ANTICIPO
        Try
            Dim mListaSOLIC_ANTICIPO As New ListaSOLIC_ANTICIPO
            mListaSOLIC_ANTICIPO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ANTICIPO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ANTICIPO
            If Not mListaSOLIC_ANTICIPO Is Nothing Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ANTICIPO
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
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_ANTICIPO(ByRef aEntidad As SOLIC_ANTICIPO, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_ANTICIPO.
    ''' </summary>
    ''' <param name="ID_ANTICIPO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_ANTICIPO
        Try
            Dim lEntidad As New SOLIC_ANTICIPO
            lEntidad.ID_ANTICIPO = ID_ANTICIPO
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
    ''' <param name="aPROVEEDOR">Recuperar registro foraneo de la Entidad PROVEEDOR.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aSOLIC_AGRICOLA_ESTADO">Recuperar registro foraneo de la Entidad SOLIC_AGRICOLA_ESTADO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_ANTICIPOConForaneas(ByVal aEntidad As SOLIC_ANTICIPO, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aSOLIC_AGRICOLA_ESTADO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPROVEEDOR, aZAFRA, aSOLIC_AGRICOLA_ESTADO)
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
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32, ByVal CODIPROVEEDOR As String, ByVal NUM_ANTICIPO As Int32, ByVal FECHA As DateTime, ByVal CONCEPTO As String, ByVal MONTO As Decimal, ByVal UID_ANTICIPO_CONTRATO As Guid, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_ZAFRA As Int32, ByVal ZAFRA As String, ByVal FECHA_CHEQUE As DateTime, ByVal PORC_INTERES As Decimal, ByVal ES_ACEPTADA As Boolean, ByVal CHQ_NO As String, ByVal ID_CUENTA_FINAN As Int32, ByVal PLAZO_MESES As Int32, ByVal FECHA_VENCE As DateTime, ByVal ID_ESTADO As Int32) As Integer
        Try
            Dim lEntidad As New SOLIC_ANTICIPO
            lEntidad.ID_ANTICIPO = ID_ANTICIPO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NUM_ANTICIPO = NUM_ANTICIPO
            lEntidad.FECHA = FECHA
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.MONTO = MONTO
            lEntidad.UID_ANTICIPO_CONTRATO = UID_ANTICIPO_CONTRATO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.FECHA_CHEQUE = FECHA_CHEQUE
            lEntidad.PORC_INTERES = PORC_INTERES
            lEntidad.ES_ACEPTADA = ES_ACEPTADA
            lEntidad.CHQ_NO = CHQ_NO
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.PLAZO_MESES = PLAZO_MESES
            lEntidad.FECHA_VENCE = FECHA_VENCE
            lEntidad.ID_ESTADO = ID_ESTADO
            Return Me.ActualizarSOLIC_ANTICIPO(lEntidad)
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
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32, ByVal CODIPROVEEDOR As String, ByVal NUM_ANTICIPO As Int32, ByVal FECHA As DateTime, ByVal CONCEPTO As String, ByVal MONTO As Decimal, ByVal UID_ANTICIPO_CONTRATO As Guid, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_ZAFRA As Int32, ByVal ZAFRA As String, ByVal FECHA_CHEQUE As DateTime, ByVal PORC_INTERES As Decimal, ByVal ES_ACEPTADA As Boolean, ByVal CHQ_NO As String, ByVal ID_CUENTA_FINAN As Int32, ByVal PLAZO_MESES As Int32, ByVal FECHA_VENCE As DateTime, ByVal ID_ESTADO As Int32) As Integer
        Try
            Dim lEntidad As New SOLIC_ANTICIPO
            lEntidad.ID_ANTICIPO = ID_ANTICIPO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NUM_ANTICIPO = NUM_ANTICIPO
            lEntidad.FECHA = FECHA
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.MONTO = MONTO
            lEntidad.UID_ANTICIPO_CONTRATO = UID_ANTICIPO_CONTRATO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.FECHA_CHEQUE = FECHA_CHEQUE
            lEntidad.PORC_INTERES = PORC_INTERES
            lEntidad.ES_ACEPTADA = ES_ACEPTADA
            lEntidad.CHQ_NO = CHQ_NO
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.PLAZO_MESES = PLAZO_MESES
            lEntidad.FECHA_VENCE = FECHA_VENCE
            lEntidad.ID_ESTADO = ID_ESTADO
            Return Me.ActualizarSOLIC_ANTICIPO(lEntidad)
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
    ''' 	[GenApp]	13/06/2018	Created
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
    ''' 	[GenApp]	13/06/2018	Created
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
    ''' la Tabla PROVEEDOR .
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ANTICIPO
        Try
            Dim mListaSOLIC_ANTICIPO As New ListaSOLIC_ANTICIPO
            mListaSOLIC_ANTICIPO = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ANTICIPO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ANTICIPO
            If Not mListaSOLIC_ANTICIPO Is Nothing Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ANTICIPO
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
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ANTICIPO
        Try
            Dim mListaSOLIC_ANTICIPO As New ListaSOLIC_ANTICIPO
            mListaSOLIC_ANTICIPO = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ANTICIPO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ANTICIPO
            If Not mListaSOLIC_ANTICIPO Is Nothing Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ANTICIPO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA_ESTADO .
    ''' </summary>
    ''' <param name="ID_SOLIC_ESTADO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA_ESTADO(ByVal ID_SOLIC_ESTADO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ANTICIPO
        Try
            Dim mListaSOLIC_ANTICIPO As New ListaSOLIC_ANTICIPO
            mListaSOLIC_ANTICIPO = mDb.ObtenerListaPorSOLIC_AGRICOLA_ESTADO(ID_SOLIC_ESTADO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_ANTICIPO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLIC_ANTICIPO
            If Not mListaSOLIC_ANTICIPO Is Nothing Then
                For Each lEntidad As SOLIC_ANTICIPO in  mListaSOLIC_ANTICIPO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_ANTICIPO
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
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_ANTICIPO )
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_ESTADO = (New cSOLIC_AGRICOLA_ESTADO).ObtenerSOLIC_AGRICOLA_ESTADO(aEntidad.ID_ESTADO)
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
    ''' 	[GenApp]	13/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_ANTICIPO )
    End Sub

#End Region

End Class
