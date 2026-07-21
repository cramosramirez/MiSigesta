''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_QUEMANOPROG
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_QUEMANOPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_QUEMANOPROG
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_QUEMANOPROG()
    Private mEntidad as New SOLIC_QUEMANOPROG
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_QUEMANOPROG
        Try
            Dim mListaSOLIC_QUEMANOPROG As New ListaSOLIC_QUEMANOPROG
            mListaSOLIC_QUEMANOPROG = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_QUEMANOPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_QUEMANOPROG in  mListaSOLIC_QUEMANOPROG
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_QUEMANOPROG
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_QUEMANOPROG(ByRef aEntidad As SOLIC_QUEMANOPROG, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_QUEMANOPROG.
    ''' </summary>
    ''' <param name="ID_SOLIC_QUEMANOPROG"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_QUEMANOPROG(ByVal ID_SOLIC_QUEMANOPROG As Int32, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_QUEMANOPROG
        Try
            Dim lEntidad As New SOLIC_QUEMANOPROG
            lEntidad.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG
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
    ''' <param name="aPROVEEDOR">Recuperar registro foraneo de la Entidad PROVEEDOR.</param>
    ''' <param name="aVARIEDAD">Recuperar registro foraneo de la Entidad VARIEDAD.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_QUEMANOPROGConForaneas(ByVal aEntidad As SOLIC_QUEMANOPROG, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aVARIEDAD As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aLOTES, aPROVEEDOR, aVARIEDAD)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_QUEMANOPROG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_QUEMANOPROG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_QUEMANOPROG(ByVal ID_SOLIC_QUEMANOPROG As Int32) As Integer
        Try
            mEntidad.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_QUEMANOPROG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_QUEMANOPROG(ByVal aEntidad As SOLIC_QUEMANOPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_QUEMANOPROG(ByVal ID_SOLIC_QUEMANOPROG As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal FECHA_SOLIC As DateTime, ByVal NO_SOLICITUD As Int32, ByVal CODIPROVEEDOR As String, ByVal ZONA As String, ByVal FECHA_HORA_QUEMA As DateTime, ByVal AREA As Decimal, ByVal TONEL As Decimal, ByVal TIPO_QUEMA As String, ByVal CODIVARIEDA As String, ByVal BRECHAS As Boolean, ByVal RONDAS As Boolean, ByVal VIGILANCIA As Boolean, ByVal MADURANTE As Boolean, ByVal FECHA_APLICA As DateTime, ByVal PRE_MUESTRA As Boolean, ByVal FECHA_ROZA As DateTime, ByVal FECHA_INI_VENTANA As DateTime, ByVal FECHA_FIN_VENTANA As DateTime, ByVal OBSERVACIONES As String, ByVal CODIAGRON As String, ByVal CON_DENUNCIA As Boolean, ByVal ZAFRA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New SOLIC_QUEMANOPROG
            lEntidad.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.FECHA_SOLIC = FECHA_SOLIC
            lEntidad.NO_SOLICITUD = NO_SOLICITUD
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.ZONA = ZONA
            lEntidad.FECHA_HORA_QUEMA = FECHA_HORA_QUEMA
            lEntidad.AREA = AREA
            lEntidad.TONEL = TONEL
            lEntidad.TIPO_QUEMA = TIPO_QUEMA
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.BRECHAS = BRECHAS
            lEntidad.RONDAS = RONDAS
            lEntidad.VIGILANCIA = VIGILANCIA
            lEntidad.MADURANTE = MADURANTE
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.PRE_MUESTRA = PRE_MUESTRA
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.FECHA_INI_VENTANA = FECHA_INI_VENTANA
            lEntidad.FECHA_FIN_VENTANA = FECHA_FIN_VENTANA
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CON_DENUNCIA = CON_DENUNCIA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarSOLIC_QUEMANOPROG(lEntidad)
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_QUEMANOPROG(ByVal aEntidad As SOLIC_QUEMANOPROG) As Integer
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_QUEMANOPROG(ByVal aEntidad As SOLIC_QUEMANOPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_QUEMANOPROG(ByVal ID_SOLIC_QUEMANOPROG As Int32, ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal FECHA_SOLIC As DateTime, ByVal NO_SOLICITUD As Int32, ByVal CODIPROVEEDOR As String, ByVal ZONA As String, ByVal FECHA_HORA_QUEMA As DateTime, ByVal AREA As Decimal, ByVal TONEL As Decimal, ByVal TIPO_QUEMA As String, ByVal CODIVARIEDA As String, ByVal BRECHAS As Boolean, ByVal RONDAS As Boolean, ByVal VIGILANCIA As Boolean, ByVal MADURANTE As Boolean, ByVal FECHA_APLICA As DateTime, ByVal PRE_MUESTRA As Boolean, ByVal FECHA_ROZA As DateTime, ByVal FECHA_INI_VENTANA As DateTime, ByVal FECHA_FIN_VENTANA As DateTime, ByVal OBSERVACIONES As String, ByVal CODIAGRON As String, ByVal CON_DENUNCIA As Boolean, ByVal ZAFRA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New SOLIC_QUEMANOPROG
            lEntidad.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.FECHA_SOLIC = FECHA_SOLIC
            lEntidad.NO_SOLICITUD = NO_SOLICITUD
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.ZONA = ZONA
            lEntidad.FECHA_HORA_QUEMA = FECHA_HORA_QUEMA
            lEntidad.AREA = AREA
            lEntidad.TONEL = TONEL
            lEntidad.TIPO_QUEMA = TIPO_QUEMA
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.BRECHAS = BRECHAS
            lEntidad.RONDAS = RONDAS
            lEntidad.VIGILANCIA = VIGILANCIA
            lEntidad.MADURANTE = MADURANTE
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.PRE_MUESTRA = PRE_MUESTRA
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.FECHA_INI_VENTANA = FECHA_INI_VENTANA
            lEntidad.FECHA_FIN_VENTANA = FECHA_FIN_VENTANA
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CON_DENUNCIA = CON_DENUNCIA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarSOLIC_QUEMANOPROG(lEntidad)
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
    ''' 	[GenApp]	16/01/2015	Created
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
    ''' 	[GenApp]	16/01/2015	Created
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_QUEMANOPROG
        Try
            Dim mListaSOLIC_QUEMANOPROG As New ListaSOLIC_QUEMANOPROG
            mListaSOLIC_QUEMANOPROG = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_QUEMANOPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_QUEMANOPROG in  mListaSOLIC_QUEMANOPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_QUEMANOPROG
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_QUEMANOPROG
        Try
            Dim mListaSOLIC_QUEMANOPROG As New ListaSOLIC_QUEMANOPROG
            mListaSOLIC_QUEMANOPROG = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_QUEMANOPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_QUEMANOPROG in  mListaSOLIC_QUEMANOPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_QUEMANOPROG
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_QUEMANOPROG
        Try
            Dim mListaSOLIC_QUEMANOPROG As New ListaSOLIC_QUEMANOPROG
            mListaSOLIC_QUEMANOPROG = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_QUEMANOPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_QUEMANOPROG in  mListaSOLIC_QUEMANOPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_QUEMANOPROG
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla VARIEDAD .
    ''' </summary>
    ''' <param name="CODIVARIEDA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorVARIEDAD(ByVal CODIVARIEDA As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_QUEMANOPROG
        Try
            Dim mListaSOLIC_QUEMANOPROG As New ListaSOLIC_QUEMANOPROG
            mListaSOLIC_QUEMANOPROG = mDb.ObtenerListaPorVARIEDAD(CODIVARIEDA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_QUEMANOPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_QUEMANOPROG in  mListaSOLIC_QUEMANOPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_QUEMANOPROG
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_QUEMANOPROG )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
        aEntidad.fkCODIVARIEDA = (New cVARIEDAD).ObtenerVARIEDAD(aEntidad.CODIVARIEDA)
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
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_QUEMANOPROG )
    End Sub

#End Region

End Class
