''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cMOTORISTA_VEHICULO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla MOTORISTA_VEHICULO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/11/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cMOTORISTA_VEHICULO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbMOTORISTA_VEHICULO()
    Private mEntidad as New MOTORISTA_VEHICULO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMOTORISTA_VEHICULO
        Try
            Dim mListaMOTORISTA_VEHICULO As New ListaMOTORISTA_VEHICULO
            mListaMOTORISTA_VEHICULO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaMOTORISTA_VEHICULO Is Nothing And recuperarForaneas Then
                For Each lEntidad As MOTORISTA_VEHICULO in  mListaMOTORISTA_VEHICULO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMOTORISTA_VEHICULO
            If Not mListaMOTORISTA_VEHICULO Is Nothing Then
                For Each lEntidad As MOTORISTA_VEHICULO in  mListaMOTORISTA_VEHICULO
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMOTORISTA_VEHICULO
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMOTORISTA_VEHICULO(ByRef aEntidad As MOTORISTA_VEHICULO, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla MOTORISTA_VEHICULO.
    ''' </summary>
    ''' <param name="ID_MOTORISTA_VEHI"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerMOTORISTA_VEHICULO(ByVal ID_MOTORISTA_VEHI As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As MOTORISTA_VEHICULO
        Try
            Dim lEntidad As New MOTORISTA_VEHICULO
            lEntidad.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI
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
    ''' <param name="aMOTORISTA">Recuperar registro foraneo de la Entidad MOTORISTA.</param>
    ''' <param name="aTRANSPORTE">Recuperar registro foraneo de la Entidad TRANSPORTE.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMOTORISTA_VEHICULOConForaneas(ByVal aEntidad As MOTORISTA_VEHICULO, Optional ByVal aMOTORISTA As Boolean = False, Optional ByVal aTRANSPORTE As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aMOTORISTA, aTRANSPORTE)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MOTORISTA_VEHICULO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_MOTORISTA_VEHI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarMOTORISTA_VEHICULO(ByVal ID_MOTORISTA_VEHI As Int32) As Integer
        Try
            mEntidad.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MOTORISTA_VEHICULO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarMOTORISTA_VEHICULO(ByVal aEntidad As MOTORISTA_VEHICULO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarMOTORISTA_VEHICULO(ByVal ID_MOTORISTA_VEHI As Int32, ByVal ID_MOTORISTA As Int32, ByVal ID_TRANSPORTE As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal ES_PARTICULAR As Boolean, ByVal VER_ORDEN_COMB As Boolean, ByVal VER_PROFORMA As Boolean, ByVal ID_LIC As Int32, ByVal ACTIVO As Boolean, ByVal CASTIGADO As Boolean, ByVal ID_ZAFRA As Int32, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_CARGADORA As Int32) As Integer
        Try
            Dim lEntidad As New MOTORISTA_VEHICULO
            lEntidad.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.ID_TRANSPORTE = ID_TRANSPORTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.ES_PARTICULAR = ES_PARTICULAR
            lEntidad.VER_ORDEN_COMB = VER_ORDEN_COMB
            lEntidad.VER_PROFORMA = VER_PROFORMA
            lEntidad.ID_LIC = ID_LIC
            lEntidad.ACTIVO = ACTIVO
            lEntidad.CASTIGADO = CASTIGADO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_CARGADORA = ID_CARGADORA
            Return Me.ActualizarMOTORISTA_VEHICULO(lEntidad)
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMOTORISTA_VEHICULO(ByVal aEntidad As MOTORISTA_VEHICULO) As Integer
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMOTORISTA_VEHICULO(ByVal aEntidad As MOTORISTA_VEHICULO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMOTORISTA_VEHICULO(ByVal ID_MOTORISTA_VEHI As Int32, ByVal ID_MOTORISTA As Int32, ByVal ID_TRANSPORTE As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal ES_PARTICULAR As Boolean, ByVal VER_ORDEN_COMB As Boolean, ByVal VER_PROFORMA As Boolean, ByVal ID_LIC As Int32, ByVal ACTIVO As Boolean, ByVal CASTIGADO As Boolean, ByVal ID_ZAFRA As Int32, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ID_CARGADORA As Int32) As Integer
        Try
            Dim lEntidad As New MOTORISTA_VEHICULO
            lEntidad.ID_MOTORISTA_VEHI = ID_MOTORISTA_VEHI
            lEntidad.ID_MOTORISTA = ID_MOTORISTA
            lEntidad.ID_TRANSPORTE = ID_TRANSPORTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.ES_PARTICULAR = ES_PARTICULAR
            lEntidad.VER_ORDEN_COMB = VER_ORDEN_COMB
            lEntidad.VER_PROFORMA = VER_PROFORMA
            lEntidad.ID_LIC = ID_LIC
            lEntidad.ACTIVO = ACTIVO
            lEntidad.CASTIGADO = CASTIGADO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_CARGADORA = ID_CARGADORA
            Return Me.ActualizarMOTORISTA_VEHICULO(lEntidad)
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
    ''' 	[GenApp]	26/11/2018	Created
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
    ''' 	[GenApp]	26/11/2018	Created
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
    ''' la Tabla MOTORISTA .
    ''' </summary>
    ''' <param name="ID_MOTORISTA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTORISTA(ByVal ID_MOTORISTA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMOTORISTA_VEHICULO
        Try
            Dim mListaMOTORISTA_VEHICULO As New ListaMOTORISTA_VEHICULO
            mListaMOTORISTA_VEHICULO = mDb.ObtenerListaPorMOTORISTA(ID_MOTORISTA, asColumnaOrden, asTipoOrden)
            If Not mListaMOTORISTA_VEHICULO Is Nothing And recuperarForaneas Then
                For Each lEntidad As MOTORISTA_VEHICULO in  mListaMOTORISTA_VEHICULO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMOTORISTA_VEHICULO
            If Not mListaMOTORISTA_VEHICULO Is Nothing Then
                For Each lEntidad As MOTORISTA_VEHICULO in  mListaMOTORISTA_VEHICULO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMOTORISTA_VEHICULO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TRANSPORTE .
    ''' </summary>
    ''' <param name="ID_TRANSPORTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMOTORISTA_VEHICULO
        Try
            Dim mListaMOTORISTA_VEHICULO As New ListaMOTORISTA_VEHICULO
            mListaMOTORISTA_VEHICULO = mDb.ObtenerListaPorTRANSPORTE(ID_TRANSPORTE, asColumnaOrden, asTipoOrden)
            If Not mListaMOTORISTA_VEHICULO Is Nothing And recuperarForaneas Then
                For Each lEntidad As MOTORISTA_VEHICULO in  mListaMOTORISTA_VEHICULO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMOTORISTA_VEHICULO
            If Not mListaMOTORISTA_VEHICULO Is Nothing Then
                For Each lEntidad As MOTORISTA_VEHICULO in  mListaMOTORISTA_VEHICULO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMOTORISTA_VEHICULO
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As MOTORISTA_VEHICULO )
        aEntidad.fkID_MOTORISTA = (New cMOTORISTA).ObtenerMOTORISTA(aEntidad.ID_MOTORISTA)
        aEntidad.fkID_TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTE(aEntidad.ID_TRANSPORTE)
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
    ''' 	[GenApp]	26/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As MOTORISTA_VEHICULO )
    End Sub

#End Region

End Class
