''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cORDEN_COMBUSTIBLE_FAC_ANUL
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ORDEN_COMBUSTIBLE_FAC_ANUL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cORDEN_COMBUSTIBLE_FAC_ANUL
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbORDEN_COMBUSTIBLE_FAC_ANUL()
    Private mEntidad as New ORDEN_COMBUSTIBLE_FAC_ANUL
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE_FAC_ANUL
        Try
            Dim mListaORDEN_COMBUSTIBLE_FAC_ANUL As New ListaORDEN_COMBUSTIBLE_FAC_ANUL
            mListaORDEN_COMBUSTIBLE_FAC_ANUL = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE_FAC_ANUL Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL in  mListaORDEN_COMBUSTIBLE_FAC_ANUL
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE_FAC_ANUL
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerORDEN_COMBUSTIBLE_FAC_ANUL(ByRef aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ORDEN_COMBUSTIBLE_FAC_ANUL.
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS_FAC_ANUL"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerORDEN_COMBUSTIBLE_FAC_ANUL(ByVal ID_ORDEN_COMBUS_FAC_ANUL As Int32, ByVal Optional recuperarForaneas As Boolean = False) As ORDEN_COMBUSTIBLE_FAC_ANUL
        Try
            Dim lEntidad As New ORDEN_COMBUSTIBLE_FAC_ANUL
            lEntidad.ID_ORDEN_COMBUS_FAC_ANUL = ID_ORDEN_COMBUS_FAC_ANUL
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
    ''' <param name="aORDEN_COMBUSTIBLE">Recuperar registro foraneo de la Entidad ORDEN_COMBUSTIBLE.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerORDEN_COMBUSTIBLE_FAC_ANULConForaneas(ByVal aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL, Optional ByVal aORDEN_COMBUSTIBLE As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aORDEN_COMBUSTIBLE)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ORDEN_COMBUSTIBLE_FAC_ANUL que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS_FAC_ANUL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal ID_ORDEN_COMBUS_FAC_ANUL As Int32) As Integer
        Try
            mEntidad.ID_ORDEN_COMBUS_FAC_ANUL = ID_ORDEN_COMBUS_FAC_ANUL
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ORDEN_COMBUSTIBLE_FAC_ANUL que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal ID_ORDEN_COMBUS_FAC_ANUL As Int32, ByVal ID_ORDEN_COMBUS As Int32, ByVal NO_FACTURA_CCF As String, ByVal FECHA_DESPACHO As DateTime, ByVal FECHA_ANULACION As DateTime, ByVal MOTIVO_ANULACION As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal MONTO_FACTURA As Decimal) As Integer
        Try
            Dim lEntidad As New ORDEN_COMBUSTIBLE_FAC_ANUL
            lEntidad.ID_ORDEN_COMBUS_FAC_ANUL = ID_ORDEN_COMBUS_FAC_ANUL
            lEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
            lEntidad.NO_FACTURA_CCF = NO_FACTURA_CCF
            lEntidad.FECHA_DESPACHO = FECHA_DESPACHO
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.MOTIVO_ANULACION = MOTIVO_ANULACION
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.MONTO_FACTURA = MONTO_FACTURA
            Return Me.ActualizarORDEN_COMBUSTIBLE_FAC_ANUL(lEntidad)
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL) As Integer
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal ID_ORDEN_COMBUS_FAC_ANUL As Int32, ByVal ID_ORDEN_COMBUS As Int32, ByVal NO_FACTURA_CCF As String, ByVal FECHA_DESPACHO As DateTime, ByVal FECHA_ANULACION As DateTime, ByVal MOTIVO_ANULACION As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal MONTO_FACTURA As Decimal) As Integer
        Try
            Dim lEntidad As New ORDEN_COMBUSTIBLE_FAC_ANUL
            lEntidad.ID_ORDEN_COMBUS_FAC_ANUL = ID_ORDEN_COMBUS_FAC_ANUL
            lEntidad.ID_ORDEN_COMBUS = ID_ORDEN_COMBUS
            lEntidad.NO_FACTURA_CCF = NO_FACTURA_CCF
            lEntidad.FECHA_DESPACHO = FECHA_DESPACHO
            lEntidad.FECHA_ANULACION = FECHA_ANULACION
            lEntidad.MOTIVO_ANULACION = MOTIVO_ANULACION
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.MONTO_FACTURA = MONTO_FACTURA
            Return Me.ActualizarORDEN_COMBUSTIBLE_FAC_ANUL(lEntidad)
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
    ''' 	[GenApp]	30/10/2018	Created
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
    ''' 	[GenApp]	30/10/2018	Created
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
    ''' la Tabla ORDEN_COMBUSTIBLE .
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaORDEN_COMBUSTIBLE_FAC_ANUL
        Try
            Dim mListaORDEN_COMBUSTIBLE_FAC_ANUL As New ListaORDEN_COMBUSTIBLE_FAC_ANUL
            mListaORDEN_COMBUSTIBLE_FAC_ANUL = mDb.ObtenerListaPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS, asColumnaOrden, asTipoOrden)
            If Not mListaORDEN_COMBUSTIBLE_FAC_ANUL Is Nothing And recuperarForaneas Then
                For Each lEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL in  mListaORDEN_COMBUSTIBLE_FAC_ANUL
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaORDEN_COMBUSTIBLE_FAC_ANUL
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL )
        aEntidad.fkID_ORDEN_COMBUS = (New cORDEN_COMBUSTIBLE).ObtenerORDEN_COMBUSTIBLE(aEntidad.ID_ORDEN_COMBUS)
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
    ''' 	[GenApp]	30/10/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL )
    End Sub

#End Region

End Class
