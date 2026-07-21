''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPRE_ANALISIS_DETA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PRE_ANALISIS_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPRE_ANALISIS_DETA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPRE_ANALISIS_DETA()
    Private mEntidad as New PRE_ANALISIS_DETA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPRE_ANALISIS_DETA
        Try
            Dim mListaPRE_ANALISIS_DETA As New ListaPRE_ANALISIS_DETA
            mListaPRE_ANALISIS_DETA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPRE_ANALISIS_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PRE_ANALISIS_DETA in  mListaPRE_ANALISIS_DETA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPRE_ANALISIS_DETA
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPRE_ANALISIS_DETA(ByRef aEntidad As PRE_ANALISIS_DETA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PRE_ANALISIS_DETA.
    ''' </summary>
    ''' <param name="ID_DETA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPRE_ANALISIS_DETA(ByVal ID_DETA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As PRE_ANALISIS_DETA
        Try
            Dim lEntidad As New PRE_ANALISIS_DETA
            lEntidad.ID_DETA = ID_DETA
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
    ''' <param name="aPRE_ANALISIS_ENCA">Recuperar registro foraneo de la Entidad PRE_ANALISIS_ENCA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPRE_ANALISIS_DETAConForaneas(ByVal aEntidad As PRE_ANALISIS_DETA, Optional ByVal aPRE_ANALISIS_ENCA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPRE_ANALISIS_ENCA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PRE_ANALISIS_DETA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DETA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPRE_ANALISIS_DETA(ByVal ID_DETA As Int32) As Integer
        Try
            mEntidad.ID_DETA = ID_DETA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PRE_ANALISIS_DETA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPRE_ANALISIS_DETA(ByVal aEntidad As PRE_ANALISIS_DETA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPRE_ANALISIS_DETA(ByVal ID_DETA As Int32, ByVal ID_ENCA As Int32, ByVal UID_REF As String, ByVal ORDEN As Int32, ByVal NUMERO As String, ByVal DESCRIPCION As String, ByVal TARIFA_CAT As String, ByVal TARIFA_CAT_DESCRIP As String, ByVal ID_CATE As Int32, ByVal ID_CATE_REF As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal EDITAR As Boolean, ByVal NEGRITA As Boolean, ByVal MONTO1 As Decimal, ByVal MONTO2 As Decimal, ByVal MONTO3 As Decimal, ByVal MONTO4 As Decimal, ByVal MONTO5 As Decimal, ByVal MONTO6 As Decimal, ByVal TOTAL As Decimal) As Integer
        Try
            Dim lEntidad As New PRE_ANALISIS_DETA
            lEntidad.ID_DETA = ID_DETA
            lEntidad.ID_ENCA = ID_ENCA
            lEntidad.UID_REF = UID_REF
            lEntidad.ORDEN = ORDEN
            lEntidad.NUMERO = NUMERO
            lEntidad.DESCRIPCION = DESCRIPCION
            lEntidad.TARIFA_CAT = TARIFA_CAT
            lEntidad.TARIFA_CAT_DESCRIP = TARIFA_CAT_DESCRIP
            lEntidad.ID_CATE = ID_CATE
            lEntidad.ID_CATE_REF = ID_CATE_REF
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.EDITAR = EDITAR
            lEntidad.NEGRITA = NEGRITA
            lEntidad.MONTO1 = MONTO1
            lEntidad.MONTO2 = MONTO2
            lEntidad.MONTO3 = MONTO3
            lEntidad.MONTO4 = MONTO4
            lEntidad.MONTO5 = MONTO5
            lEntidad.MONTO6 = MONTO6
            lEntidad.TOTAL = TOTAL
            Return Me.ActualizarPRE_ANALISIS_DETA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPRE_ANALISIS_DETA(ByVal aEntidad As PRE_ANALISIS_DETA) As Integer
        Try
            Dim iRet As Integer = 0

            iRet = mDb.Actualizar(aEntidad)
            mDb.PROC_ACTUALIZAR_PRE_ANALISIS_DETA_RESULTADOS(aEntidad.UID_REF)

            Return iRet
        Catch ex As Exception
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPRE_ANALISIS_DETA(ByVal aEntidad As PRE_ANALISIS_DETA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPRE_ANALISIS_DETA(ByVal ID_DETA As Int32, ByVal ID_ENCA As Int32, ByVal UID_REF As String, ByVal ORDEN As Int32, ByVal NUMERO As String, ByVal DESCRIPCION As String, ByVal TARIFA_CAT As String, ByVal TARIFA_CAT_DESCRIP As String, ByVal ID_CATE As Int32, ByVal ID_CATE_REF As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal EDITAR As Boolean, ByVal NEGRITA As Boolean, ByVal MONTO1 As Decimal, ByVal MONTO2 As Decimal, ByVal MONTO3 As Decimal, ByVal MONTO4 As Decimal, ByVal MONTO5 As Decimal, ByVal MONTO6 As Decimal, ByVal TOTAL As Decimal) As Integer
        Try
            Dim lEntidad As New PRE_ANALISIS_DETA
            lEntidad.ID_DETA = ID_DETA
            lEntidad.ID_ENCA = ID_ENCA
            lEntidad.UID_REF = UID_REF
            lEntidad.ORDEN = ORDEN
            lEntidad.NUMERO = NUMERO
            lEntidad.DESCRIPCION = DESCRIPCION
            lEntidad.TARIFA_CAT = TARIFA_CAT
            lEntidad.TARIFA_CAT_DESCRIP = TARIFA_CAT_DESCRIP
            lEntidad.ID_CATE = ID_CATE
            lEntidad.ID_CATE_REF = ID_CATE_REF
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.EDITAR = EDITAR
            lEntidad.NEGRITA = NEGRITA
            lEntidad.MONTO1 = MONTO1
            lEntidad.MONTO2 = MONTO2
            lEntidad.MONTO3 = MONTO3
            lEntidad.MONTO4 = MONTO4
            lEntidad.MONTO5 = MONTO5
            lEntidad.MONTO6 = MONTO6
            lEntidad.TOTAL = TOTAL
            Return Me.ActualizarPRE_ANALISIS_DETA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	22/05/2017	Created
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
    ''' 	[GenApp]	22/05/2017	Created
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
    ''' la Tabla PRE_ANALISIS_ENCA .
    ''' </summary>
    ''' <param name="ID_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPRE_ANALISIS_ENCA(ByVal ID_ENCA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPRE_ANALISIS_DETA
        Try
            Dim mListaPRE_ANALISIS_DETA As New ListaPRE_ANALISIS_DETA
            mListaPRE_ANALISIS_DETA = mDb.ObtenerListaPorPRE_ANALISIS_ENCA(ID_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaPRE_ANALISIS_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PRE_ANALISIS_DETA in  mListaPRE_ANALISIS_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPRE_ANALISIS_DETA
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PRE_ANALISIS_DETA )
        aEntidad.fkID_ENCA = (New cPRE_ANALISIS_ENCA).ObtenerPRE_ANALISIS_ENCA(aEntidad.ID_ENCA)
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
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PRE_ANALISIS_DETA )
    End Sub

#End Region

End Class
