''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cZAFRA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/11/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cZAFRA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbZAFRA()
    Private mEntidad as New ZAFRA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaZAFRA
        Try
            Dim mListaZAFRA As New ListaZAFRA
            mListaZAFRA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaZAFRA
            If Not mListaZAFRA Is Nothing Then
                For Each lEntidad As ZAFRA In mListaZAFRA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaZAFRA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaTodas(ByVal Optional elementoTodas As String = "", ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaZAFRA
        Try
            Dim lZafra As New ZAFRA
            Dim mListaZAFRA As New listaZAFRA
            mListaZAFRA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If mListaZAFRA Is Nothing Then
                mListaZAFRA = New listaZAFRA
            End If

            lZafra.ID_ZAFRA = -1
            lZafra.NOMBRE_ZAFRA = elementoTodas
            mListaZAFRA.Insertar(0, lZafra)
            Return mListaZAFRA
        Catch ex As Exception
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerZAFRA(ByRef aEntidad As ZAFRA, ByVal Optional recuperarHijas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ZAFRA.
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False) As ZAFRA
        Try
            Dim lEntidad As New ZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
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
    ''' Función que Elimina un Registro de la Tabla ZAFRA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Try
            mEntidad.ID_ZAFRA = ID_ZAFRA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ZAFRA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarZAFRA(ByVal aEntidad As ZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarZAFRA(ByVal ID_ZAFRA As Int32, ByVal NOMBRE_ZAFRA As String, ByVal DIAZAFRA As Int32, ByVal CATORCENA As Int32, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FINAL As DateTime, ByVal POL As Decimal, ByVal HUMEDAD As Decimal, ByVal PUREZA_MIEL As Decimal, ByVal EFICIENCIA As Decimal, ByVal PRECIO_LIBRA_AZUCAR As Decimal, ByVal CONSTANTE_A As Decimal, ByVal CONSTANTE_B As Decimal, ByVal CONSTANTE_D As Decimal, ByVal CONSTANTE_E As Decimal, ByVal ULTFECHA_CIERRE_DIARIO As DateTime, ByVal ACTIVA As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DISPO_INVE_ROZA As Decimal, ByVal REND_MODFINAN As Decimal, ByVal TARIFA_ROZA_MODFINAN As Decimal, ByVal TARIFA_ALZA_MODFINAN As Decimal, ByVal TARIFA_QUERQUEO As Decimal, ByVal PUREZA_AZUCAR As Decimal) As Integer
        Try
            Dim lEntidad As New ZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NOMBRE_ZAFRA = NOMBRE_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FINAL = FECHA_FINAL
            lEntidad.POL = POL
            lEntidad.HUMEDAD = HUMEDAD
            lEntidad.PUREZA_MIEL = PUREZA_MIEL
            lEntidad.EFICIENCIA = EFICIENCIA
            lEntidad.PRECIO_LIBRA_AZUCAR = PRECIO_LIBRA_AZUCAR
            lEntidad.CONSTANTE_A = CONSTANTE_A
            lEntidad.CONSTANTE_B = CONSTANTE_B
            lEntidad.CONSTANTE_D = CONSTANTE_D
            lEntidad.CONSTANTE_E = CONSTANTE_E
            lEntidad.ULTFECHA_CIERRE_DIARIO = ULTFECHA_CIERRE_DIARIO
            lEntidad.ACTIVA = ACTIVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DISPO_INVE_ROZA = DISPO_INVE_ROZA
            lEntidad.REND_MODFINAN = REND_MODFINAN
            lEntidad.TARIFA_ROZA_MODFINAN = TARIFA_ROZA_MODFINAN
            lEntidad.TARIFA_ALZA_MODFINAN = TARIFA_ALZA_MODFINAN
            lEntidad.TARIFA_QUERQUEO = TARIFA_QUERQUEO
            lEntidad.PUREZA_AZUCAR = PUREZA_AZUCAR
            Return Me.ActualizarZAFRA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZAFRA(ByVal ID_ZAFRA As Int32, ByVal NOMBRE_ZAFRA As String, ByVal DIAZAFRA As Int32, ByVal CATORCENA As Int32, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FINAL As DateTime, ByVal POL As Decimal, ByVal HUMEDAD As Decimal, ByVal PUREZA_MIEL As Decimal, ByVal EFICIENCIA As Decimal, ByVal PRECIO_LIBRA_AZUCAR As Decimal, ByVal CONSTANTE_A As Decimal, ByVal CONSTANTE_B As Decimal, ByVal CONSTANTE_D As Decimal, ByVal CONSTANTE_E As Decimal, ByVal ULTFECHA_CIERRE_DIARIO As DateTime, ByVal ACTIVA As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DISPO_INVE_ROZA As Decimal, ByVal REND_MODFINAN As Decimal, ByVal TARIFA_ROZA_MODFINAN As Decimal, ByVal TARIFA_ALZA_MODFINAN As Decimal, ByVal TARIFA_QUERQUEO As Decimal, ByVal PUREZA_AZUCAR As Decimal) As Integer
        Try
            Dim lEntidad As New ZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NOMBRE_ZAFRA = NOMBRE_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FINAL = FECHA_FINAL
            lEntidad.POL = POL
            lEntidad.HUMEDAD = HUMEDAD
            lEntidad.PUREZA_MIEL = PUREZA_MIEL
            lEntidad.EFICIENCIA = EFICIENCIA
            lEntidad.PRECIO_LIBRA_AZUCAR = PRECIO_LIBRA_AZUCAR
            lEntidad.CONSTANTE_A = CONSTANTE_A
            lEntidad.CONSTANTE_B = CONSTANTE_B
            lEntidad.CONSTANTE_D = CONSTANTE_D
            lEntidad.CONSTANTE_E = CONSTANTE_E
            lEntidad.ULTFECHA_CIERRE_DIARIO = ULTFECHA_CIERRE_DIARIO
            lEntidad.ACTIVA = ACTIVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DISPO_INVE_ROZA = DISPO_INVE_ROZA
            lEntidad.REND_MODFINAN = REND_MODFINAN
            lEntidad.TARIFA_ROZA_MODFINAN = TARIFA_ROZA_MODFINAN
            lEntidad.TARIFA_ALZA_MODFINAN = TARIFA_ALZA_MODFINAN
            lEntidad.TARIFA_QUERQUEO = TARIFA_QUERQUEO
            lEntidad.PUREZA_AZUCAR = PUREZA_AZUCAR
            Return Me.ActualizarZAFRA(lEntidad)
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
    ''' 	[GenApp]	30/11/2018	Created
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
    ''' 	[GenApp]	30/11/2018	Created
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
    ''' 	[GenApp]	30/11/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ZAFRA )
    End Sub

#End Region

End Class
