''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCONTRATO_LG
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTRATO_LG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTRATO_LG
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTRATO_LG()
    Private mEntidad as New CONTRATO_LG
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_LG
        Try
            Dim mListaCONTRATO_LG As New ListaCONTRATO_LG
            mListaCONTRATO_LG = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_LG Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_LG in  mListaCONTRATO_LG
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_LG
            If Not mListaCONTRATO_LG Is Nothing Then
                For Each lEntidad As CONTRATO_LG in  mListaCONTRATO_LG
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_LG
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTRATO_LG(ByRef aEntidad As CONTRATO_LG, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTRATO_LG.
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTRATO_LG(ByVal CODICONTRATO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CONTRATO_LG
        Try
            Dim lEntidad As New CONTRATO_LG
            lEntidad.CODICONTRATO = CODICONTRATO
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCONTRATO_LGConForaneas(ByVal aEntidad As CONTRATO_LG, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aZAFRA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPROVEEDOR, aZAFRA)
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTRATO_LG(ByVal CODICONTRATO As String, ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, ByVal FECHA_CONTRATOCB As DateTime, ByVal ESTADO_CONTRATOCB As Int32, ByVal FINANCOADO As String, ByVal FINAN_NUMERO As String, ByVal TOTALMZ_CONTRATOCB As Decimal, ByVal TONELADAS_CONTRATOCB As Decimal, ByVal OBSERVACIONES_CONTRATOCB As String, ByVal USER_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As String, ByVal FECHA_ACT As DateTime, ByVal NO_REGISTRO As String, ByVal FECHA_REGISTRO As DateTime, ByVal APELLIDOS As String, ByVal NOMBRES As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal CELULAR As String, ByVal DUI As String, ByVal NIT As String, ByVal CREDITFISCAL As String, ByVal APODERADO As String, ByVal DUI_APODERADO As String, ByVal NIT_APODERADO As String, ByVal ID_ZAFRA As Int32, ByVal NO_CONTRATO As Int32, ByVal TIPO_CONTRATO As Int32, ByVal FECHA_CONTRA_LEGAL As DateTime, ByVal EDAD As Int32) As Integer
        Try
            Dim lEntidad As New CONTRATO_LG
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.ANIOZAFRA = ANIOZAFRA
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.FECHA_CONTRATOCB = FECHA_CONTRATOCB
            lEntidad.ESTADO_CONTRATOCB = ESTADO_CONTRATOCB
            lEntidad.FINANCOADO = FINANCOADO
            lEntidad.FINAN_NUMERO = FINAN_NUMERO
            lEntidad.TOTALMZ_CONTRATOCB = TOTALMZ_CONTRATOCB
            lEntidad.TONELADAS_CONTRATOCB = TONELADAS_CONTRATOCB
            lEntidad.OBSERVACIONES_CONTRATOCB = OBSERVACIONES_CONTRATOCB
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.NO_REGISTRO = NO_REGISTRO
            lEntidad.FECHA_REGISTRO = FECHA_REGISTRO
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.NOMBRES = NOMBRES
            lEntidad.DIRECCION = DIRECCION
            lEntidad.TELEFONO = TELEFONO
            lEntidad.CELULAR = CELULAR
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.CREDITFISCAL = CREDITFISCAL
            lEntidad.APODERADO = APODERADO
            lEntidad.DUI_APODERADO = DUI_APODERADO
            lEntidad.NIT_APODERADO = NIT_APODERADO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NO_CONTRATO = NO_CONTRATO
            lEntidad.TIPO_CONTRATO = TIPO_CONTRATO
            lEntidad.FECHA_CONTRA_LEGAL = FECHA_CONTRA_LEGAL
            lEntidad.EDAD = EDAD
            Return Me.AgregarCONTRATO_LG(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTRATO_LG(ByVal aEntidad As CONTRATO_LG) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_LG(ByVal CODICONTRATO As String, ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, ByVal FECHA_CONTRATOCB As DateTime, ByVal ESTADO_CONTRATOCB As Int32, ByVal FINANCOADO As String, ByVal FINAN_NUMERO As String, ByVal TOTALMZ_CONTRATOCB As Decimal, ByVal TONELADAS_CONTRATOCB As Decimal, ByVal OBSERVACIONES_CONTRATOCB As String, ByVal USER_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As String, ByVal FECHA_ACT As DateTime, ByVal NO_REGISTRO As String, ByVal FECHA_REGISTRO As DateTime, ByVal APELLIDOS As String, ByVal NOMBRES As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal CELULAR As String, ByVal DUI As String, ByVal NIT As String, ByVal CREDITFISCAL As String, ByVal APODERADO As String, ByVal DUI_APODERADO As String, ByVal NIT_APODERADO As String, ByVal ID_ZAFRA As Int32, ByVal NO_CONTRATO As Int32, ByVal TIPO_CONTRATO As Int32, ByVal FECHA_CONTRA_LEGAL As DateTime, ByVal EDAD As Int32) As Integer
        Try
            Dim lEntidad As New CONTRATO_LG
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.ANIOZAFRA = ANIOZAFRA
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.FECHA_CONTRATOCB = FECHA_CONTRATOCB
            lEntidad.ESTADO_CONTRATOCB = ESTADO_CONTRATOCB
            lEntidad.FINANCOADO = FINANCOADO
            lEntidad.FINAN_NUMERO = FINAN_NUMERO
            lEntidad.TOTALMZ_CONTRATOCB = TOTALMZ_CONTRATOCB
            lEntidad.TONELADAS_CONTRATOCB = TONELADAS_CONTRATOCB
            lEntidad.OBSERVACIONES_CONTRATOCB = OBSERVACIONES_CONTRATOCB
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.NO_REGISTRO = NO_REGISTRO
            lEntidad.FECHA_REGISTRO = FECHA_REGISTRO
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.NOMBRES = NOMBRES
            lEntidad.DIRECCION = DIRECCION
            lEntidad.TELEFONO = TELEFONO
            lEntidad.CELULAR = CELULAR
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.CREDITFISCAL = CREDITFISCAL
            lEntidad.APODERADO = APODERADO
            lEntidad.DUI_APODERADO = DUI_APODERADO
            lEntidad.NIT_APODERADO = NIT_APODERADO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NO_CONTRATO = NO_CONTRATO
            lEntidad.TIPO_CONTRATO = TIPO_CONTRATO
            lEntidad.FECHA_CONTRA_LEGAL = FECHA_CONTRA_LEGAL
            lEntidad.EDAD = EDAD
            Return Me.ActualizarCONTRATO_LG(lEntidad)
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
    ''' 	[GenApp]	10/08/2020	Created
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
    ''' 	[GenApp]	10/08/2020	Created
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_LG
        Try
            Dim mListaCONTRATO_LG As New ListaCONTRATO_LG
            mListaCONTRATO_LG = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_LG Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_LG in  mListaCONTRATO_LG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_LG
            If Not mListaCONTRATO_LG Is Nothing Then
                For Each lEntidad As CONTRATO_LG in  mListaCONTRATO_LG
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_LG
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_LG
        Try
            Dim mListaCONTRATO_LG As New ListaCONTRATO_LG
            mListaCONTRATO_LG = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_LG Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_LG in  mListaCONTRATO_LG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_LG
            If Not mListaCONTRATO_LG Is Nothing Then
                For Each lEntidad As CONTRATO_LG in  mListaCONTRATO_LG
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_LG
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTRATO_LG )
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTRATO_LG )
    End Sub

#End Region

End Class
