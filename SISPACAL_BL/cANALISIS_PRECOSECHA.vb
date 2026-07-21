''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cANALISIS_PRECOSECHA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ANALISIS_PRECOSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cANALISIS_PRECOSECHA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbANALISIS_PRECOSECHA()
    Private mEntidad as New ANALISIS_PRECOSECHA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaANALISIS_PRECOSECHA
        Try
            Dim mListaANALISIS_PRECOSECHA As New ListaANALISIS_PRECOSECHA
            mListaANALISIS_PRECOSECHA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaANALISIS_PRECOSECHA
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
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerANALISIS_PRECOSECHA(ByRef aEntidad As ANALISIS_PRECOSECHA) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ANALISIS_PRECOSECHA.
    ''' </summary>
    ''' <param name="ID_ANALISIS_PRE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerANALISIS_PRECOSECHA(ByVal ID_ANALISIS_PRE As Int32) As ANALISIS_PRECOSECHA
        Try
            Dim lEntidad As New ANALISIS_PRECOSECHA
            lEntidad.ID_ANALISIS_PRE = ID_ANALISIS_PRE
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarANALISIS_PRECOSECHA(ByVal ID_ANALISIS_PRE As Int32, ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32, ByVal NO_ANALISIS As Int32, ByVal FECHA_MUESTRA As DateTime, ByVal NO_MUESTRA As Int32, ByVal AREA_MUESTRA As Decimal, ByVal BAGAZO_BRUTO As Decimal, ByVal BAGAZO_NETO As Decimal, ByVal POL As Decimal, ByVal BRIX As Decimal, ByVal FIBRA_CANA As Decimal, ByVal HUMEDAD As Decimal, ByVal POL_JUGO As Decimal, ByVal JUGO_CANA As Decimal, ByVal POL_CANA As Decimal, ByVal PUREZA_JUGO As Decimal, ByVal PUREZA_AZUCAR As Decimal, ByVal SJM As Decimal, ByVal RENDIA_CALC1 As Decimal, ByVal RENDIA_CALC2 As Decimal, ByVal POL_LECTURA As Decimal, ByVal PH As Decimal, ByVal AZUCAR_REDUCTORES As Decimal, ByVal CANT_JUGO_ML As Decimal, ByVal VOL_TITULANTE As Decimal, ByVal OBSERVACION As String, ByVal ALMIDON_JUGO As Decimal, ByVal ACIDEZ_JUGO As Decimal, ByVal ABSORVANCIA As Decimal, ByVal DEXTRANA As Decimal, ByVal USUARIO_LEE_BAGAZO_BRUTO As String, ByVal FECHA_LEE_BAGAZO_BRUTO As DateTime, ByVal USUARIO_LEE_BAGAZO_TARA As String, ByVal FECHA_LEE_BAGAZO_TARA As DateTime, ByVal USUARIO_LEE_POL As String, ByVal FECHA_LEE_POL As DateTime, ByVal USUARIO_LEE_BRIX As String, ByVal FECHA_LEE_BRIX As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_CT As DateTime, ByVal BRIX_DILU As Decimal, ByVal ABSORBANCIA_ALMIDON As Decimal, ByVal ID_SUBLOTES As Integer) As Integer
        Try
            Dim lEntidad As New ANALISIS_PRECOSECHA
            lEntidad.ID_ANALISIS_PRE = ID_ANALISIS_PRE
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NO_ANALISIS = NO_ANALISIS
            lEntidad.FECHA_MUESTRA = FECHA_MUESTRA
            lEntidad.NO_MUESTRA = NO_MUESTRA
            lEntidad.AREA_MUESTRA = AREA_MUESTRA
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
            lEntidad.POL_LECTURA = POL_LECTURA
            lEntidad.PH = PH
            lEntidad.AZUCAR_REDUCTORES = AZUCAR_REDUCTORES
            lEntidad.CANT_JUGO_ML = CANT_JUGO_ML
            lEntidad.VOL_TITULANTE = VOL_TITULANTE
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.ALMIDON_JUGO = ALMIDON_JUGO
            lEntidad.ACIDEZ_JUGO = ACIDEZ_JUGO
            lEntidad.ABSORVANCIA = ABSORVANCIA
            lEntidad.DEXTRANA = DEXTRANA
            lEntidad.USUARIO_LEE_BAGAZO_BRUTO = USUARIO_LEE_BAGAZO_BRUTO
            lEntidad.FECHA_LEE_BAGAZO_BRUTO = FECHA_LEE_BAGAZO_BRUTO
            lEntidad.USUARIO_LEE_BAGAZO_TARA = USUARIO_LEE_BAGAZO_TARA
            lEntidad.FECHA_LEE_BAGAZO_TARA = FECHA_LEE_BAGAZO_TARA
            lEntidad.USUARIO_LEE_POL = USUARIO_LEE_POL
            lEntidad.FECHA_LEE_POL = FECHA_LEE_POL
            lEntidad.USUARIO_LEE_BRIX = USUARIO_LEE_BRIX
            lEntidad.FECHA_LEE_BRIX = FECHA_LEE_BRIX
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_CT = FECHA_CT
            lEntidad.BRIX_DILU = BRIX_DILU
            lEntidad.ABSORBANCIA_ALMIDON = ABSORBANCIA_ALMIDON
            lEntidad.ID_SUBLOTES = ID_SUBLOTES
            Return Me.ActualizarANALISIS_PRECOSECHA(lEntidad)
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
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarANALISIS_PRECOSECHA(ByVal ID_ANALISIS_PRE As Int32, ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32, ByVal NO_ANALISIS As Int32, ByVal FECHA_MUESTRA As DateTime, ByVal NO_MUESTRA As Int32, ByVal AREA_MUESTRA As Decimal, ByVal BAGAZO_BRUTO As Decimal, ByVal BAGAZO_NETO As Decimal, ByVal POL As Decimal, ByVal BRIX As Decimal, ByVal FIBRA_CANA As Decimal, ByVal HUMEDAD As Decimal, ByVal POL_JUGO As Decimal, ByVal JUGO_CANA As Decimal, ByVal POL_CANA As Decimal, ByVal PUREZA_JUGO As Decimal, ByVal PUREZA_AZUCAR As Decimal, ByVal SJM As Decimal, ByVal RENDIA_CALC1 As Decimal, ByVal RENDIA_CALC2 As Decimal, ByVal POL_LECTURA As Decimal, ByVal PH As Decimal, ByVal AZUCAR_REDUCTORES As Decimal, ByVal CANT_JUGO_ML As Decimal, ByVal VOL_TITULANTE As Decimal, ByVal OBSERVACION As String, ByVal ALMIDON_JUGO As Decimal, ByVal ACIDEZ_JUGO As Decimal, ByVal ABSORVANCIA As Decimal, ByVal DEXTRANA As Decimal, ByVal USUARIO_LEE_BAGAZO_BRUTO As String, ByVal FECHA_LEE_BAGAZO_BRUTO As DateTime, ByVal USUARIO_LEE_BAGAZO_TARA As String, ByVal FECHA_LEE_BAGAZO_TARA As DateTime, ByVal USUARIO_LEE_POL As String, ByVal FECHA_LEE_POL As DateTime, ByVal USUARIO_LEE_BRIX As String, ByVal FECHA_LEE_BRIX As DateTime, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_CT As DateTime, ByVal BRIX_DILU As Decimal, ByVal ABSORBANCIA_ALMIDON As Decimal, ByVal ID_SUBLOTES As Integer) As Integer
        Try
            Dim lEntidad As New ANALISIS_PRECOSECHA
            lEntidad.ID_ANALISIS_PRE = ID_ANALISIS_PRE
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NO_ANALISIS = NO_ANALISIS
            lEntidad.FECHA_MUESTRA = FECHA_MUESTRA
            lEntidad.NO_MUESTRA = NO_MUESTRA
            lEntidad.AREA_MUESTRA = AREA_MUESTRA
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
            lEntidad.POL_LECTURA = POL_LECTURA
            lEntidad.PH = PH
            lEntidad.AZUCAR_REDUCTORES = AZUCAR_REDUCTORES
            lEntidad.CANT_JUGO_ML = CANT_JUGO_ML
            lEntidad.VOL_TITULANTE = VOL_TITULANTE
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.ALMIDON_JUGO = ALMIDON_JUGO
            lEntidad.ACIDEZ_JUGO = ACIDEZ_JUGO
            lEntidad.ABSORVANCIA = ABSORVANCIA
            lEntidad.DEXTRANA = DEXTRANA
            lEntidad.USUARIO_LEE_BAGAZO_BRUTO = USUARIO_LEE_BAGAZO_BRUTO
            lEntidad.FECHA_LEE_BAGAZO_BRUTO = FECHA_LEE_BAGAZO_BRUTO
            lEntidad.USUARIO_LEE_BAGAZO_TARA = USUARIO_LEE_BAGAZO_TARA
            lEntidad.FECHA_LEE_BAGAZO_TARA = FECHA_LEE_BAGAZO_TARA
            lEntidad.USUARIO_LEE_POL = USUARIO_LEE_POL
            lEntidad.FECHA_LEE_POL = FECHA_LEE_POL
            lEntidad.USUARIO_LEE_BRIX = USUARIO_LEE_BRIX
            lEntidad.FECHA_LEE_BRIX = FECHA_LEE_BRIX
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_CT = FECHA_CT
            lEntidad.BRIX_DILU = BRIX_DILU
            lEntidad.ABSORBANCIA_ALMIDON = ABSORBANCIA_ALMIDON
            lEntidad.ID_SUBLOTES = ID_SUBLOTES
            Return Me.ActualizarANALISIS_PRECOSECHA(lEntidad)
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
    ''' 	[GenApp]	24/09/2014	Created
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
    ''' 	[GenApp]	24/09/2014	Created
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
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ANALISIS_PRECOSECHA )
    End Sub

#End Region

End Class
