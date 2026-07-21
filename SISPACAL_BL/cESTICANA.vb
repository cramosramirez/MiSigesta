


<System.ComponentModel.DataObject()>
Public Class cESTICANA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb As New dbESTICANA()
    Private mEntidad As New ESTICANA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaESTICANA
        Try
            Dim mListaESTICANA As New listaESTICANA
            mListaESTICANA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaESTICANA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaESTICANA
            If Not mListaESTICANA Is Nothing Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaESTICANA
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
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerESTICANA(ByRef aEntidad As ESTICANA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
                Catch ex As Exception
                End Try
            End If
            Return liRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ESTICANA.
    ''' </summary>
    ''' <param name="ID_ESTICANA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerESTICANA(ByVal ID_ESTICANA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As ESTICANA
        Try
            Dim lEntidad As New ESTICANA
            lEntidad.ID_ESTICANA = ID_ESTICANA
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
                Catch ex As Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
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
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aAGRONOMO">Recuperar registro foraneo de la Entidad AGRONOMO.</param>
    ''' <param name="aTIPOS_GENERALES">Recuperar registro foraneo de la Entidad TIPOS_GENERALES.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerESTICANAConForaneas(ByVal aEntidad As ESTICANA, Optional ByVal aLOTES As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aAGRONOMO As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aLOTES, aZAFRA, aAGRONOMO, aTIPOS_GENERALES)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ESTICANA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ESTICANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarESTICANA(ByVal ID_ESTICANA As Int32) As Integer
        Try
            mEntidad.ID_ESTICANA = ID_ESTICANA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ESTICANA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarESTICANA(ByVal aEntidad As ESTICANA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarESTICANA(ByVal ID_ESTICANA As Int32, ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32, ByVal FECHA_ROZA As DateTime, ByVal REND_COSECHA As Decimal, ByVal MZ_ENTREGAR As Decimal, ByVal TONEL_MZ_ENTREGAR As Decimal, ByVal TONEL_ENTREGAR As Decimal, ByVal LBS_ENTREGAR As Decimal, ByVal VALOR_ENTREGAR As Decimal, ByVal MZ_ENTREGADA As Decimal, ByVal TONEL_MZ_ENTREGADA As Decimal, ByVal TONEL_ENTREGADA As Decimal, ByVal LBS_ENTREGADA As Decimal, ByVal VALOR_ENTREGADA As Decimal, ByVal MZ_CENSO As Decimal, ByVal TONEL_MZ_CENSO As Decimal, ByVal TONEL_CENSO As Decimal, ByVal LBS_CENSO As Decimal, ByVal VALOR_CENSO As Decimal, ByVal FIN_LOTE As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODIAGRON As String, ByVal FECHA_SIEMBRA As DateTime, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32, ByVal ID_TIPO_ALZA As Int32, ByVal ID_TIPO_TRANS As Int32, ByVal FAB_SEMANA As Int32, ByVal FAB_CATORCENA As Int32, ByVal FAB_SUBTERCIO As String, ByVal FAB_TERCIO As Int32, ByVal TARIFA_ROZA As Decimal, ByVal TARIFA_ALZA As Decimal, ByVal TARIFA_TRANS As Decimal, ByVal TARIFA_CORTA As Decimal, ByVal TARIFA_LARGA As Decimal, ByVal SALDO_ROZA As Decimal, ByVal EDAD_LOTE As Int32, ByVal SALDO_QUEMA As Decimal, ByVal FECHA_ROZA_DISPO As DateTime, ByVal TONEL_SALDO_VAR As Decimal, ByVal TONEL_SEMILLA As Decimal, ByVal FECHA_CIERRE As DateTime, ByVal HORAS_GRACIA_ENTREGA As Int32) As Integer
        Try
            Dim lEntidad As New ESTICANA
            lEntidad.ID_ESTICANA = ID_ESTICANA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.REND_COSECHA = REND_COSECHA
            lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
            lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
            lEntidad.TONEL_ENTREGAR = TONEL_ENTREGAR
            lEntidad.LBS_ENTREGAR = LBS_ENTREGAR
            lEntidad.VALOR_ENTREGAR = VALOR_ENTREGAR
            lEntidad.MZ_ENTREGADA = MZ_ENTREGADA
            lEntidad.TONEL_MZ_ENTREGADA = TONEL_MZ_ENTREGADA
            lEntidad.TONEL_ENTREGADA = TONEL_ENTREGADA
            lEntidad.LBS_ENTREGADA = LBS_ENTREGADA
            lEntidad.VALOR_ENTREGADA = VALOR_ENTREGADA
            lEntidad.MZ_CENSO = MZ_CENSO
            lEntidad.TONEL_MZ_CENSO = TONEL_MZ_CENSO
            lEntidad.TONEL_CENSO = TONEL_CENSO
            lEntidad.LBS_CENSO = LBS_CENSO
            lEntidad.VALOR_CENSO = VALOR_CENSO
            lEntidad.FIN_LOTE = FIN_LOTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_TIPO_TRANS = ID_TIPO_TRANS
            lEntidad.FAB_SEMANA = FAB_SEMANA
            lEntidad.FAB_CATORCENA = FAB_CATORCENA
            lEntidad.FAB_SUBTERCIO = FAB_SUBTERCIO
            lEntidad.FAB_TERCIO = FAB_TERCIO
            lEntidad.TARIFA_ROZA = TARIFA_ROZA
            lEntidad.TARIFA_ALZA = TARIFA_ALZA
            lEntidad.TARIFA_TRANS = TARIFA_TRANS
            lEntidad.TARIFA_CORTA = TARIFA_CORTA
            lEntidad.TARIFA_LARGA = TARIFA_LARGA
            lEntidad.SALDO_ROZA = SALDO_ROZA
            lEntidad.EDAD_LOTE = EDAD_LOTE
            lEntidad.SALDO_QUEMA = SALDO_QUEMA
            lEntidad.FECHA_ROZA_DISPO = FECHA_ROZA_DISPO
            lEntidad.TONEL_SALDO_VAR = TONEL_SALDO_VAR
            lEntidad.TONEL_SEMILLA = TONEL_SEMILLA
            lEntidad.FECHA_CIERRE = FECHA_CIERRE
            lEntidad.HORAS_GRACIA_ENTREGA = HORAS_GRACIA_ENTREGA
            Return Me.ActualizarESTICANA(lEntidad)
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarESTICANA(ByVal ID_ESTICANA As Int32, ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32, ByVal FECHA_ROZA As DateTime, ByVal REND_COSECHA As Decimal,
                                            ByVal MZ_ENTREGAR As Decimal, ByVal TONEL_MZ_ENTREGAR As Decimal, ByVal TONEL_ENTREGAR As Decimal, ByVal LBS_ENTREGAR As Decimal,
                                            ByVal VALOR_ENTREGAR As Decimal, ByVal MZ_ENTREGADA As Decimal, ByVal TONEL_MZ_ENTREGADA As Decimal, ByVal TONEL_ENTREGADA As Decimal,
                                            ByVal LBS_ENTREGADA As Decimal, ByVal VALOR_ENTREGADA As Decimal, ByVal MZ_CENSO As Decimal, ByVal TONEL_MZ_CENSO As Decimal, ByVal TONEL_CENSO As Decimal,
                                            ByVal LBS_CENSO As Decimal, ByVal VALOR_CENSO As Decimal, ByVal FIN_LOTE As Boolean,
                                            ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime,
                                            ByVal CODIAGRON As String, ByVal FECHA_SIEMBRA As DateTime, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32,
                                            ByVal ID_TIPO_ALZA As Int32, ByVal ID_TIPO_TRANS As Int32, ByVal FAB_SEMANA As Int32, ByVal FAB_CATORCENA As Int32,
                                            ByVal FAB_SUBTERCIO As String, ByVal FAB_TERCIO As Int32, ByVal TARIFA_ROZA As Decimal, ByVal TARIFA_ALZA As Decimal,
                                            ByVal TARIFA_TRANS As Decimal, ByVal TARIFA_CORTA As Decimal, ByVal TARIFA_LARGA As Decimal, ByVal SALDO_ROZA As Decimal,
                                            ByVal EDAD_LOTE As Int32, ByVal SALDO_QUEMA As Decimal, ByVal FECHA_ROZA_DISPO As DateTime, ByVal TONEL_SALDO_VAR As Decimal,
                                            ByVal TONEL_SEMILLA As Decimal, ByVal FECHA_CIERRE As DateTime, ByVal HORAS_GRACIA_ENTREGA As Int32) As Integer
        Try
            Dim lEntidad As New ESTICANA
            lEntidad.ID_ESTICANA = ID_ESTICANA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.REND_COSECHA = REND_COSECHA
            lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
            lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
            lEntidad.TONEL_ENTREGAR = TONEL_ENTREGAR
            lEntidad.LBS_ENTREGAR = LBS_ENTREGAR
            lEntidad.VALOR_ENTREGAR = VALOR_ENTREGAR
            lEntidad.MZ_ENTREGADA = MZ_ENTREGADA
            lEntidad.TONEL_MZ_ENTREGADA = TONEL_MZ_ENTREGADA
            lEntidad.TONEL_ENTREGADA = TONEL_ENTREGADA
            lEntidad.LBS_ENTREGADA = LBS_ENTREGADA
            lEntidad.VALOR_ENTREGADA = VALOR_ENTREGADA
            lEntidad.MZ_CENSO = MZ_CENSO
            lEntidad.TONEL_MZ_CENSO = TONEL_MZ_CENSO
            lEntidad.TONEL_CENSO = TONEL_CENSO
            lEntidad.LBS_CENSO = LBS_CENSO
            lEntidad.VALOR_CENSO = VALOR_CENSO
            lEntidad.FIN_LOTE = FIN_LOTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_TIPO_TRANS = ID_TIPO_TRANS
            lEntidad.FAB_SEMANA = FAB_SEMANA
            lEntidad.FAB_CATORCENA = FAB_CATORCENA
            lEntidad.FAB_SUBTERCIO = FAB_SUBTERCIO
            lEntidad.FAB_TERCIO = FAB_TERCIO
            lEntidad.TARIFA_ROZA = TARIFA_ROZA
            lEntidad.TARIFA_ALZA = TARIFA_ALZA
            lEntidad.TARIFA_TRANS = TARIFA_TRANS
            lEntidad.TARIFA_CORTA = TARIFA_CORTA
            lEntidad.TARIFA_LARGA = TARIFA_LARGA
            lEntidad.SALDO_ROZA = SALDO_ROZA
            lEntidad.EDAD_LOTE = EDAD_LOTE
            lEntidad.SALDO_QUEMA = SALDO_QUEMA
            lEntidad.FECHA_ROZA_DISPO = FECHA_ROZA_DISPO
            lEntidad.TONEL_SALDO_VAR = TONEL_SALDO_VAR
            lEntidad.TONEL_SEMILLA = TONEL_SEMILLA
            lEntidad.FECHA_CIERRE = FECHA_CIERRE
            lEntidad.HORAS_GRACIA_ENTREGA = HORAS_GRACIA_ENTREGA
            Return Me.ActualizarESTICANA(lEntidad)
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerDataSetPorId(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex As Exception
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)>
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaESTICANA
        Try
            Dim mListaESTICANA As New listaESTICANA
            mListaESTICANA = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaESTICANA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaESTICANA
            If Not mListaESTICANA Is Nothing Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaESTICANA
        Catch ex As Exception
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaESTICANA
        Try
            Dim mListaESTICANA As New listaESTICANA
            mListaESTICANA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaESTICANA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaESTICANA
            If Not mListaESTICANA Is Nothing Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaESTICANA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla AGRONOMO .
    ''' </summary>
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorAGRONOMO(ByVal CODIAGRON As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaESTICANA
        Try
            Dim mListaESTICANA As New listaESTICANA
            mListaESTICANA = mDb.ObtenerListaPorAGRONOMO(CODIAGRON, asColumnaOrden, asTipoOrden)
            If Not mListaESTICANA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaESTICANA
            If Not mListaESTICANA Is Nothing Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaESTICANA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPOS_GENERALES .
    ''' </summary>
    ''' <param name="ID_TIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaESTICANA
        Try
            Dim mListaESTICANA As New listaESTICANA
            mListaESTICANA = mDb.ObtenerListaPorTIPOS_GENERALES(ID_TIPO, asColumnaOrden, asTipoOrden)
            If Not mListaESTICANA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaESTICANA
            If Not mListaESTICANA Is Nothing Then
                For Each lEntidad As ESTICANA In mListaESTICANA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaESTICANA
        Catch ex As Exception
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ESTICANA)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkCODIAGRON = (New cAGRONOMO).ObtenerAGRONOMO(aEntidad.CODIAGRON)
        aEntidad.fkID_TIPO_CANA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_ROZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_ALZA = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
        aEntidad.fkID_TIPO_TRANS = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(aEntidad.ID_TIPO_CANA)
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ESTICANA)
    End Sub

#End Region

End Class
