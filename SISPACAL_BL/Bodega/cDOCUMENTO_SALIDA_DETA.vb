''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cDOCUMENTO_SALIDA_DETA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla DOCUMENTO_SALIDA_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cDOCUMENTO_SALIDA_DETA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbDOCUMENTO_SALIDA_DETA()
    Private mEntidad as New DOCUMENTO_SALIDA_DETA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_DETA
        Try
            Dim mListaDOCUMENTO_SALIDA_DETA As New ListaDOCUMENTO_SALIDA_DETA
            mListaDOCUMENTO_SALIDA_DETA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_DETA in  mListaDOCUMENTO_SALIDA_DETA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_DETA
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDOCUMENTO_SALIDA_DETA(ByRef aEntidad As DOCUMENTO_SALIDA_DETA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla DOCUMENTO_SALIDA_DETA.
    ''' </summary>
    ''' <param name="ID_DOCSAL_ENCA_DETA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerDOCUMENTO_SALIDA_DETA(ByVal ID_DOCSAL_ENCA_DETA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As DOCUMENTO_SALIDA_DETA
        Try
            Dim lEntidad As New DOCUMENTO_SALIDA_DETA
            lEntidad.ID_DOCSAL_ENCA_DETA = ID_DOCSAL_ENCA_DETA
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
    ''' <param name="aDOCUMENTO_SALIDA_ENCA">Recuperar registro foraneo de la Entidad DOCUMENTO_SALIDA_ENCA.</param>
    ''' <param name="aPRODUCTO">Recuperar registro foraneo de la Entidad PRODUCTO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDOCUMENTO_SALIDA_DETAConForaneas(ByVal aEntidad As DOCUMENTO_SALIDA_DETA, Optional ByVal aDOCUMENTO_SALIDA_ENCA As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aDOCUMENTO_SALIDA_ENCA, aPRODUCTO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DOCUMENTO_SALIDA_DETA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DOCSAL_ENCA_DETA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDOCUMENTO_SALIDA_DETA(ByVal ID_DOCSAL_ENCA_DETA As Int32) As Integer
        Try
            mEntidad.ID_DOCSAL_ENCA_DETA = ID_DOCSAL_ENCA_DETA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DOCUMENTO_SALIDA_DETA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDOCUMENTO_SALIDA_DETA(ByVal aEntidad As DOCUMENTO_SALIDA_DETA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarDOCUMENTO_SALIDA_DETA(ByVal ID_DOCSAL_ENCA_DETA As Int32, ByVal ID_DOCSAL_ENCA As Int32, ByVal ID_PRODUCTO As Int32, ByVal CANTIDAD As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal, ByVal UNIDAD As String, ByVal PRESENTACION As String, ByVal NOMBRE_PRODUCTO As String, ByVal UID_DOCUMENTO_DETA As Guid) As Integer
        Try
            Dim lEntidad As New DOCUMENTO_SALIDA_DETA
            lEntidad.ID_DOCSAL_ENCA_DETA = ID_DOCSAL_ENCA_DETA
            lEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.TOTAL = TOTAL
            lEntidad.UNIDAD = UNIDAD
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.UID_DOCUMENTO_DETA = UID_DOCUMENTO_DETA
            Return Me.ActualizarDOCUMENTO_SALIDA_DETA(lEntidad)
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDOCUMENTO_SALIDA_DETA(ByVal aEntidad As DOCUMENTO_SALIDA_DETA) As Integer
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDOCUMENTO_SALIDA_DETA(ByVal aEntidad As DOCUMENTO_SALIDA_DETA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDOCUMENTO_SALIDA_DETA(ByVal ID_DOCSAL_ENCA_DETA As Int32, ByVal ID_DOCSAL_ENCA As Int32, ByVal ID_PRODUCTO As Int32, ByVal CANTIDAD As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal, ByVal UNIDAD As String, ByVal PRESENTACION As String, ByVal NOMBRE_PRODUCTO As String, ByVal UID_DOCUMENTO_DETA As Guid) As Integer
        Try
            Dim lEntidad As New DOCUMENTO_SALIDA_DETA
            lEntidad.ID_DOCSAL_ENCA_DETA = ID_DOCSAL_ENCA_DETA
            lEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.TOTAL = TOTAL
            lEntidad.UNIDAD = UNIDAD
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.UID_DOCUMENTO_DETA = UID_DOCUMENTO_DETA
            Return Me.ActualizarDOCUMENTO_SALIDA_DETA(lEntidad)
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
    ''' 	[GenApp]	03/07/2017	Created
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
    ''' 	[GenApp]	03/07/2017	Created
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
    ''' la Tabla DOCUMENTO_SALIDA_ENCA .
    ''' </summary>
    ''' <param name="ID_DOCSAL_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_DETA
        Try
            Dim mListaDOCUMENTO_SALIDA_DETA As New ListaDOCUMENTO_SALIDA_DETA
            mListaDOCUMENTO_SALIDA_DETA = mDb.ObtenerListaPorDOCUMENTO_SALIDA_ENCA(ID_DOCSAL_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_DETA in  mListaDOCUMENTO_SALIDA_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_DETA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PRODUCTO .
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDOCUMENTO_SALIDA_DETA
        Try
            Dim mListaDOCUMENTO_SALIDA_DETA As New ListaDOCUMENTO_SALIDA_DETA
            mListaDOCUMENTO_SALIDA_DETA = mDb.ObtenerListaPorPRODUCTO(ID_PRODUCTO, asColumnaOrden, asTipoOrden)
            If Not mListaDOCUMENTO_SALIDA_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DOCUMENTO_SALIDA_DETA in  mListaDOCUMENTO_SALIDA_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDOCUMENTO_SALIDA_DETA
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As DOCUMENTO_SALIDA_DETA )
        aEntidad.fkID_DOCSAL_ENCA = (New cDOCUMENTO_SALIDA_ENCA).ObtenerDOCUMENTO_SALIDA_ENCA(aEntidad.ID_DOCSAL_ENCA)
        aEntidad.fkID_PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
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
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As DOCUMENTO_SALIDA_DETA )
    End Sub

#End Region

End Class
