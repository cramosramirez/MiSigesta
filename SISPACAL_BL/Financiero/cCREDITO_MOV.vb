''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCREDITO_MOV
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CREDITO_MOV
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCREDITO_MOV
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCREDITO_MOV()
    Private mEntidad as New CREDITO_MOV
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_MOV
        Try
            Dim mListaCREDITO_MOV As New ListaCREDITO_MOV
            mListaCREDITO_MOV = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_MOV Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_MOV in  mListaCREDITO_MOV
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_MOV
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCREDITO_MOV(ByRef aEntidad As CREDITO_MOV, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CREDITO_MOV.
    ''' </summary>
    ''' <param name="ID_CREDITO_MOV"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCREDITO_MOV(ByVal ID_CREDITO_MOV As Int32, ByVal Optional recuperarForaneas As Boolean = False) As CREDITO_MOV
        Try
            Dim lEntidad As New CREDITO_MOV
            lEntidad.ID_CREDITO_MOV = ID_CREDITO_MOV
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
    ''' <param name="aCREDITO_ENCA">Recuperar registro foraneo de la Entidad CREDITO_ENCA.</param>
    ''' <param name="aPLANILLA_BASE">Recuperar registro foraneo de la Entidad PLANILLA_BASE.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCREDITO_MOVConForaneas(ByVal aEntidad As CREDITO_MOV, Optional ByVal aCREDITO_ENCA As Boolean = False, Optional ByVal aPLANILLA_BASE As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCREDITO_ENCA, aPLANILLA_BASE)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CREDITO_MOV que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CREDITO_MOV"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCREDITO_MOV(ByVal ID_CREDITO_MOV As Int32) As Integer
        Try
            mEntidad.ID_CREDITO_MOV = ID_CREDITO_MOV
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CREDITO_MOV que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCREDITO_MOV(ByVal aEntidad As CREDITO_MOV, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCREDITO_MOV(ByVal ID_CREDITO_MOV As Int32, ByVal ID_CREDITO_ENCA As Int32, ByVal FECHA As DateTime, ByVal UID_REFERENCIA As Guid, ByVal ID_CATORCENA As Int32, ByVal CARGO As Decimal, ByVal ABONO As Decimal, ByVal SALDO As Decimal, ByVal ABONO_IVA As Decimal, ByVal ABONO_INTERES As Decimal, ByVal ABONO_INTERES_IVA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODIBANCO As Int32, ByVal NO_DOCUMENTO As String, ByVal FECHA_ULTMOV As DateTime, ByVal TASAINT As Decimal, ByVal SALDO_INICIAL As Decimal, ByVal TIPO_INTERES As String, ByVal PLAZO_DIAS As Int32, ByVal ID_PLANILLA_BASE As Int32) As Integer
        Try
            Dim lEntidad As New CREDITO_MOV
            lEntidad.ID_CREDITO_MOV = ID_CREDITO_MOV
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.FECHA = FECHA
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CARGO = CARGO
            lEntidad.ABONO = ABONO
            lEntidad.SALDO = SALDO
            lEntidad.ABONO_IVA = ABONO_IVA
            lEntidad.ABONO_INTERES = ABONO_INTERES
            lEntidad.ABONO_INTERES_IVA = ABONO_INTERES_IVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.NO_DOCUMENTO = NO_DOCUMENTO
            lEntidad.FECHA_ULTMOV = FECHA_ULTMOV
            lEntidad.TASAINT = TASAINT
            lEntidad.SALDO_INICIAL = SALDO_INICIAL
            lEntidad.TIPO_INTERES = TIPO_INTERES
            lEntidad.PLAZO_DIAS = PLAZO_DIAS
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            Return Me.ActualizarCREDITO_MOV(lEntidad)
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCREDITO_MOV(ByVal aEntidad As CREDITO_MOV) As Integer
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCREDITO_MOV(ByVal aEntidad As CREDITO_MOV, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCREDITO_MOV(ByVal ID_CREDITO_MOV As Int32, ByVal ID_CREDITO_ENCA As Int32, ByVal FECHA As DateTime, ByVal UID_REFERENCIA As Guid, ByVal ID_CATORCENA As Int32, ByVal CARGO As Decimal, ByVal ABONO As Decimal, ByVal SALDO As Decimal, ByVal ABONO_IVA As Decimal, ByVal ABONO_INTERES As Decimal, ByVal ABONO_INTERES_IVA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODIBANCO As Int32, ByVal NO_DOCUMENTO As String, ByVal FECHA_ULTMOV As DateTime, ByVal TASAINT As Decimal, ByVal SALDO_INICIAL As Decimal, ByVal TIPO_INTERES As String, ByVal PLAZO_DIAS As Int32, ByVal ID_PLANILLA_BASE As Int32) As Integer
        Try
            Dim lEntidad As New CREDITO_MOV
            lEntidad.ID_CREDITO_MOV = ID_CREDITO_MOV
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.FECHA = FECHA
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.CARGO = CARGO
            lEntidad.ABONO = ABONO
            lEntidad.SALDO = SALDO
            lEntidad.ABONO_IVA = ABONO_IVA
            lEntidad.ABONO_INTERES = ABONO_INTERES
            lEntidad.ABONO_INTERES_IVA = ABONO_INTERES_IVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.NO_DOCUMENTO = NO_DOCUMENTO
            lEntidad.FECHA_ULTMOV = FECHA_ULTMOV
            lEntidad.TASAINT = TASAINT
            lEntidad.SALDO_INICIAL = SALDO_INICIAL
            lEntidad.TIPO_INTERES = TIPO_INTERES
            lEntidad.PLAZO_DIAS = PLAZO_DIAS
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            Return Me.ActualizarCREDITO_MOV(lEntidad)
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
    ''' 	[GenApp]	03/11/2017	Created
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
    ''' 	[GenApp]	03/11/2017	Created
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
    ''' la Tabla CREDITO_ENCA .
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCREDITO_ENCA(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_MOV
        Try
            Dim mListaCREDITO_MOV As New ListaCREDITO_MOV
            mListaCREDITO_MOV = mDb.ObtenerListaPorCREDITO_ENCA(ID_CREDITO_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_MOV Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_MOV in  mListaCREDITO_MOV
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_MOV
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PLANILLA_BASE .
    ''' </summary>
    ''' <param name="ID_PLANILLA_BASE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPLANILLA_BASE(ByVal ID_PLANILLA_BASE As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_MOV
        Try
            Dim mListaCREDITO_MOV As New ListaCREDITO_MOV
            mListaCREDITO_MOV = mDb.ObtenerListaPorPLANILLA_BASE(ID_PLANILLA_BASE, asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_MOV Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_MOV in  mListaCREDITO_MOV
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_MOV
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CREDITO_MOV )
        aEntidad.fkID_CREDITO_ENCA = (New cCREDITO_ENCA).ObtenerCREDITO_ENCA(aEntidad.ID_CREDITO_ENCA)
        aEntidad.fkID_PLANILLA_BASE = (New cPLANILLA_BASE).ObtenerPLANILLA_BASE(aEntidad.ID_PLANILLA_BASE)
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CREDITO_MOV )
    End Sub

#End Region

End Class
