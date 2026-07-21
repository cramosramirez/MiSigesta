''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPLANTILLA_PRODU_DATOS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PLANTILLA_PRODU_DATOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPLANTILLA_PRODU_DATOS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPLANTILLA_PRODU_DATOS()
    Private mEntidad as New PLANTILLA_PRODU_DATOS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANTILLA_PRODU_DATOS
        Try
            Dim mListaPLANTILLA_PRODU_DATOS As New ListaPLANTILLA_PRODU_DATOS
            mListaPLANTILLA_PRODU_DATOS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaPLANTILLA_PRODU_DATOS
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPLANTILLA_PRODU_DATOS(ByRef aEntidad As PLANTILLA_PRODU_DATOS) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PLANTILLA_PRODU_DATOS.
    ''' </summary>
    ''' <param name="ID_PLANTI_DATOS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPLANTILLA_PRODU_DATOS(ByVal ID_PLANTI_DATOS As Int32) As PLANTILLA_PRODU_DATOS
        Try
            Dim lEntidad As New PLANTILLA_PRODU_DATOS
            lEntidad.ID_PLANTI_DATOS = ID_PLANTI_DATOS
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANTILLA_PRODU_DATOS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PLANTI_DATOS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLANTILLA_PRODU_DATOS(ByVal ID_PLANTI_DATOS As Int32) As Integer
        Try
            mEntidad.ID_PLANTI_DATOS = ID_PLANTI_DATOS
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANTILLA_PRODU_DATOS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLANTILLA_PRODU_DATOS(ByVal aEntidad As PLANTILLA_PRODU_DATOS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPLANTILLA_PRODU_DATOS(ByVal ID_PLANTI_DATOS As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal UID_REFERENCIA As Guid, ByVal PRODUCTOR As String, ByVal CODIPROVEEDOR As String, ByVal ID_CREDITO_ENCA As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal ID_PROVEE As Int32, ByVal CONCEPTO As String, ByVal PAGO As Decimal, ByVal SALDO_INI As Decimal, ByVal INTERES As Decimal, ByVal ABONO As Decimal, ByVal ABONO_INTERES As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal CODIPROVEE As Int32, ByVal FECHA_APLIC As DateTime, ByVal FECHA_ULTMOV As DateTime, ByVal TASAINT As Decimal, ByVal TIPO_INTERES As String, ByVal IVA_INTERES As Decimal, ByVal PORC_CANA_PEND As Decimal, ByVal MONTO_CANA_PEND As Decimal) As Integer
        Try
            Dim lEntidad As New PLANTILLA_PRODU_DATOS
            lEntidad.ID_PLANTI_DATOS = ID_PLANTI_DATOS
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.PRODUCTOR = PRODUCTOR
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.PAGO = PAGO
            lEntidad.SALDO_INI = SALDO_INI
            lEntidad.INTERES = INTERES
            lEntidad.ABONO = ABONO
            lEntidad.ABONO_INTERES = ABONO_INTERES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.CODIPROVEE = CODIPROVEE
            lEntidad.FECHA_APLIC = FECHA_APLIC
            lEntidad.FECHA_ULTMOV = FECHA_ULTMOV
            lEntidad.TASAINT = TASAINT
            lEntidad.TIPO_INTERES = TIPO_INTERES
            lEntidad.IVA_INTERES = IVA_INTERES
            lEntidad.PORC_CANA_PEND = PORC_CANA_PEND
            lEntidad.MONTO_CANA_PEND = MONTO_CANA_PEND
            Return Me.ActualizarPLANTILLA_PRODU_DATOS(lEntidad)
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
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANTILLA_PRODU_DATOS(ByVal aEntidad As PLANTILLA_PRODU_DATOS) As Integer
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
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANTILLA_PRODU_DATOS(ByVal aEntidad As PLANTILLA_PRODU_DATOS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANTILLA_PRODU_DATOS(ByVal ID_PLANTI_DATOS As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal UID_REFERENCIA As Guid, ByVal PRODUCTOR As String, ByVal CODIPROVEEDOR As String, ByVal ID_CREDITO_ENCA As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal ID_PROVEE As Int32, ByVal CONCEPTO As String, ByVal PAGO As Decimal, ByVal SALDO_INI As Decimal, ByVal INTERES As Decimal, ByVal ABONO As Decimal, ByVal ABONO_INTERES As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal CODIPROVEE As Int32, ByVal FECHA_APLIC As DateTime, ByVal FECHA_ULTMOV As DateTime, ByVal TASAINT As Decimal, ByVal TIPO_INTERES As String, ByVal IVA_INTERES As Decimal, ByVal PORC_CANA_PEND As Decimal, ByVal MONTO_CANA_PEND As Decimal) As Integer
        Try
            Dim lEntidad As New PLANTILLA_PRODU_DATOS
            lEntidad.ID_PLANTI_DATOS = ID_PLANTI_DATOS
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.PRODUCTOR = PRODUCTOR
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.PAGO = PAGO
            lEntidad.SALDO_INI = SALDO_INI
            lEntidad.INTERES = INTERES
            lEntidad.ABONO = ABONO
            lEntidad.ABONO_INTERES = ABONO_INTERES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.CODIPROVEE = CODIPROVEE
            lEntidad.FECHA_APLIC = FECHA_APLIC
            lEntidad.FECHA_ULTMOV = FECHA_ULTMOV
            lEntidad.TASAINT = TASAINT
            lEntidad.TIPO_INTERES = TIPO_INTERES
            lEntidad.IVA_INTERES = IVA_INTERES
            lEntidad.PORC_CANA_PEND = PORC_CANA_PEND
            lEntidad.MONTO_CANA_PEND = MONTO_CANA_PEND
            Return Me.ActualizarPLANTILLA_PRODU_DATOS(lEntidad)
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
    ''' 	[GenApp]	16/10/2017	Created
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
    ''' 	[GenApp]	16/10/2017	Created
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
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PLANTILLA_PRODU_DATOS )
    End Sub

#End Region

End Class
