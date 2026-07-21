''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cANALISIS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ANALISIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/02/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cANALISIS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbANALISIS()
    Private mEntidad as New ANALISIS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaANALISIS
        Try
            Dim mListaANALISIS As New ListaANALISIS
            mListaANALISIS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaANALISIS Is Nothing And recuperarForaneas Then
                For Each lEntidad As ANALISIS in  mListaANALISIS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaANALISIS
            If Not mListaANALISIS Is Nothing Then
                For Each lEntidad As ANALISIS in  mListaANALISIS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaANALISIS
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerANALISIS(ByRef aEntidad As ANALISIS, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ANALISIS.
    ''' </summary>
    ''' <param name="ID_ANALISIS"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerANALISIS(ByVal ID_ANALISIS As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As ANALISIS
        Try
            Dim lEntidad As New ANALISIS
            lEntidad.ID_ANALISIS = ID_ANALISIS
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
    ''' <param name="aENVIO">Recuperar registro foraneo de la Entidad ENVIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerANALISISConForaneas(ByVal aEntidad As ANALISIS, Optional ByVal aENVIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aENVIO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ANALISIS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ANALISIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarANALISIS(ByVal ID_ANALISIS As Int32) As Integer
        Try
            mEntidad.ID_ANALISIS = ID_ANALISIS
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ANALISIS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarANALISIS(ByVal aEntidad As ANALISIS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarANALISIS(ByVal ID_ANALISIS As Int32, ByVal ID_ENVIO As Int32, ByVal BAGAZO_BRUTO As Decimal, ByVal BAGAZO_NETO As Decimal, ByVal POL As Decimal, ByVal BRIX As Decimal, ByVal FIBRA_CANA As Decimal, ByVal HUMEDAD As Decimal, ByVal POL_JUGO As Decimal, ByVal JUGO_CANA As Decimal, ByVal POL_CANA As Decimal, ByVal PUREZA_JUGO As Decimal, ByVal PUREZA_AZUCAR As Decimal, ByVal SJM As Decimal, ByVal RENDIA_CALC1 As Decimal, ByVal RENDIA_CALC2 As Decimal, ByVal RENDIA_REAL As Decimal, ByVal RENCATORCENA_REAL As Decimal, ByVal AZUCAR_CALC1 As Decimal, ByVal AZUCAR_CALC2 As Decimal, ByVal AZUCAR_REAL As Decimal, ByVal AZUCAR_CATORCENA_REAL As Decimal, ByVal PAGO_INI_CALC As Decimal, ByVal PAGO_INI_REAL As Decimal, ByVal PAGO_CATORCENA_REAL As Decimal, ByVal USUARIO_LEE_BAGAZO_BRUTO As String, ByVal FECHA_LEE_BAGAZO_BRUTO As DateTime, ByVal USUARIO_LEE_BAGAZO_TARA As String, ByVal FECHA_LEE_BAGAZO_TARA As DateTime, ByVal USUARIO_LEE_POL As String, ByVal FECHA_LEE_POL As DateTime, ByVal USUARIO_LEE_BRIX As String, ByVal FECHA_LEE_BRIX As DateTime, ByVal POL_LECTURA As Decimal, ByVal PH As Decimal, ByVal AZUCAR_REDUCTORES As Decimal, ByVal ES_ANOMALO As Boolean, ByVal RENDIA85_ANOMALO As Decimal, ByVal APLICAR_REND_DIA As Boolean) As Integer
        Try
            Dim lEntidad As New ANALISIS
            lEntidad.ID_ANALISIS = ID_ANALISIS
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.BAGAZO_BRUTO = BAGAZO_BRUTO
            lEntidad.BAGAZO_NETO = BAGAZO_NETO
            lEntidad.POL = POL
            lEntidad.BRIX = BRIX
            lEntidad.FIBRA_CANA = FIBRA_CANA
            lEntidad.HUMEDAD = HUMEDAD
            lEntidad.POL_JUGO = POL_JUGO
            lEntidad.JUGO_CANA = JUGO_CANA
            lEntidad.POL_CANA = POL_CANA
            lEntidad.PUREZA_JUGO = PUREZA_JUGO
            lEntidad.PUREZA_AZUCAR = PUREZA_AZUCAR
            lEntidad.SJM = SJM
            lEntidad.RENDIA_CALC1 = RENDIA_CALC1
            lEntidad.RENDIA_CALC2 = RENDIA_CALC2
            lEntidad.RENDIA_REAL = RENDIA_REAL
            lEntidad.RENCATORCENA_REAL = RENCATORCENA_REAL
            lEntidad.AZUCAR_CALC1 = AZUCAR_CALC1
            lEntidad.AZUCAR_CALC2 = AZUCAR_CALC2
            lEntidad.AZUCAR_REAL = AZUCAR_REAL
            lEntidad.AZUCAR_CATORCENA_REAL = AZUCAR_CATORCENA_REAL
            lEntidad.PAGO_INI_CALC = PAGO_INI_CALC
            lEntidad.PAGO_INI_REAL = PAGO_INI_REAL
            lEntidad.PAGO_CATORCENA_REAL = PAGO_CATORCENA_REAL
            lEntidad.USUARIO_LEE_BAGAZO_BRUTO = USUARIO_LEE_BAGAZO_BRUTO
            lEntidad.FECHA_LEE_BAGAZO_BRUTO = FECHA_LEE_BAGAZO_BRUTO
            lEntidad.USUARIO_LEE_BAGAZO_TARA = USUARIO_LEE_BAGAZO_TARA
            lEntidad.FECHA_LEE_BAGAZO_TARA = FECHA_LEE_BAGAZO_TARA
            lEntidad.USUARIO_LEE_POL = USUARIO_LEE_POL
            lEntidad.FECHA_LEE_POL = FECHA_LEE_POL
            lEntidad.USUARIO_LEE_BRIX = USUARIO_LEE_BRIX
            lEntidad.FECHA_LEE_BRIX = FECHA_LEE_BRIX
            lEntidad.POL_LECTURA = POL_LECTURA
            lEntidad.PH = PH
            lEntidad.AZUCAR_REDUCTORES = AZUCAR_REDUCTORES
            lEntidad.ES_ANOMALO = ES_ANOMALO
            lEntidad.RENDIA85_ANOMALO = RENDIA85_ANOMALO
            lEntidad.APLICAR_REND_DIA = APLICAR_REND_DIA
            Return Me.ActualizarANALISIS(lEntidad)
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarANALISIS(ByVal aEntidad As ANALISIS) As Integer
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarANALISIS(ByVal aEntidad As ANALISIS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarANALISIS(ByVal ID_ANALISIS As Int32, ByVal ID_ENVIO As Int32, ByVal BAGAZO_BRUTO As Decimal, ByVal BAGAZO_NETO As Decimal, ByVal POL As Decimal, ByVal BRIX As Decimal, ByVal FIBRA_CANA As Decimal, ByVal HUMEDAD As Decimal, ByVal POL_JUGO As Decimal, ByVal JUGO_CANA As Decimal, ByVal POL_CANA As Decimal, ByVal PUREZA_JUGO As Decimal, ByVal PUREZA_AZUCAR As Decimal, ByVal SJM As Decimal, ByVal RENDIA_CALC1 As Decimal, ByVal RENDIA_CALC2 As Decimal, ByVal RENDIA_REAL As Decimal, ByVal RENCATORCENA_REAL As Decimal, ByVal AZUCAR_CALC1 As Decimal, ByVal AZUCAR_CALC2 As Decimal, ByVal AZUCAR_REAL As Decimal, ByVal AZUCAR_CATORCENA_REAL As Decimal, ByVal PAGO_INI_CALC As Decimal, ByVal PAGO_INI_REAL As Decimal, ByVal PAGO_CATORCENA_REAL As Decimal, ByVal USUARIO_LEE_BAGAZO_BRUTO As String, ByVal FECHA_LEE_BAGAZO_BRUTO As DateTime, ByVal USUARIO_LEE_BAGAZO_TARA As String, ByVal FECHA_LEE_BAGAZO_TARA As DateTime, ByVal USUARIO_LEE_POL As String, ByVal FECHA_LEE_POL As DateTime, ByVal USUARIO_LEE_BRIX As String, ByVal FECHA_LEE_BRIX As DateTime, ByVal POL_LECTURA As Decimal, ByVal PH As Decimal, ByVal AZUCAR_REDUCTORES As Decimal, ByVal ES_ANOMALO As Boolean, ByVal RENDIA85_ANOMALO As Decimal, ByVal APLICAR_REND_DIA As Boolean) As Integer
        Try
            Dim lEntidad As New ANALISIS
            lEntidad.ID_ANALISIS = ID_ANALISIS
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.BAGAZO_BRUTO = BAGAZO_BRUTO
            lEntidad.BAGAZO_NETO = BAGAZO_NETO
            lEntidad.POL = POL
            lEntidad.BRIX = BRIX
            lEntidad.FIBRA_CANA = FIBRA_CANA
            lEntidad.HUMEDAD = HUMEDAD
            lEntidad.POL_JUGO = POL_JUGO
            lEntidad.JUGO_CANA = JUGO_CANA
            lEntidad.POL_CANA = POL_CANA
            lEntidad.PUREZA_JUGO = PUREZA_JUGO
            lEntidad.PUREZA_AZUCAR = PUREZA_AZUCAR
            lEntidad.SJM = SJM
            lEntidad.RENDIA_CALC1 = RENDIA_CALC1
            lEntidad.RENDIA_CALC2 = RENDIA_CALC2
            lEntidad.RENDIA_REAL = RENDIA_REAL
            lEntidad.RENCATORCENA_REAL = RENCATORCENA_REAL
            lEntidad.AZUCAR_CALC1 = AZUCAR_CALC1
            lEntidad.AZUCAR_CALC2 = AZUCAR_CALC2
            lEntidad.AZUCAR_REAL = AZUCAR_REAL
            lEntidad.AZUCAR_CATORCENA_REAL = AZUCAR_CATORCENA_REAL
            lEntidad.PAGO_INI_CALC = PAGO_INI_CALC
            lEntidad.PAGO_INI_REAL = PAGO_INI_REAL
            lEntidad.PAGO_CATORCENA_REAL = PAGO_CATORCENA_REAL
            lEntidad.USUARIO_LEE_BAGAZO_BRUTO = USUARIO_LEE_BAGAZO_BRUTO
            lEntidad.FECHA_LEE_BAGAZO_BRUTO = FECHA_LEE_BAGAZO_BRUTO
            lEntidad.USUARIO_LEE_BAGAZO_TARA = USUARIO_LEE_BAGAZO_TARA
            lEntidad.FECHA_LEE_BAGAZO_TARA = FECHA_LEE_BAGAZO_TARA
            lEntidad.USUARIO_LEE_POL = USUARIO_LEE_POL
            lEntidad.FECHA_LEE_POL = FECHA_LEE_POL
            lEntidad.USUARIO_LEE_BRIX = USUARIO_LEE_BRIX
            lEntidad.FECHA_LEE_BRIX = FECHA_LEE_BRIX
            lEntidad.POL_LECTURA = POL_LECTURA
            lEntidad.PH = PH
            lEntidad.AZUCAR_REDUCTORES = AZUCAR_REDUCTORES
            lEntidad.ES_ANOMALO = ES_ANOMALO
            lEntidad.RENDIA85_ANOMALO = RENDIA85_ANOMALO
            lEntidad.APLICAR_REND_DIA = APLICAR_REND_DIA
            Return Me.ActualizarANALISIS(lEntidad)
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
    ''' 	[GenApp]	21/02/2019	Created
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
    ''' 	[GenApp]	21/02/2019	Created
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
    ''' la Tabla ENVIO .
    ''' </summary>
    ''' <param name="ID_ENVIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorENVIO(ByVal ID_ENVIO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaANALISIS
        Try
            Dim mListaANALISIS As New ListaANALISIS
            mListaANALISIS = mDb.ObtenerListaPorENVIO(ID_ENVIO, asColumnaOrden, asTipoOrden)
            If Not mListaANALISIS Is Nothing And recuperarForaneas Then
                For Each lEntidad As ANALISIS in  mListaANALISIS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaANALISIS
            If Not mListaANALISIS Is Nothing Then
                For Each lEntidad As ANALISIS in  mListaANALISIS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaANALISIS
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ANALISIS )
        aEntidad.fkID_ENVIO = (New cENVIO).ObtenerENVIO(aEntidad.ID_ENVIO)
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
    ''' 	[GenApp]	21/02/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ANALISIS )
    End Sub

#End Region

End Class
