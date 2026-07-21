''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cDATOS_LABORATORIO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla DATOS_LABORATORIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cDATOS_LABORATORIO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbDATOS_LABORATORIO()
    Private mEntidad as New DATOS_LABORATORIO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDATOS_LABORATORIO
        Try
            Dim mListaDATOS_LABORATORIO As New ListaDATOS_LABORATORIO
            mListaDATOS_LABORATORIO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaDATOS_LABORATORIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As DATOS_LABORATORIO in  mListaDATOS_LABORATORIO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDATOS_LABORATORIO
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDATOS_LABORATORIO(ByRef aEntidad As DATOS_LABORATORIO, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla DATOS_LABORATORIO.
    ''' </summary>
    ''' <param name="ID_DATOS_LAB"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerDATOS_LABORATORIO(ByVal ID_DATOS_LAB As Int32, ByVal Optional recuperarForaneas As Boolean = False) As DATOS_LABORATORIO
        Try
            Dim lEntidad As New DATOS_LABORATORIO
            lEntidad.ID_DATOS_LAB = ID_DATOS_LAB
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
    ''' <param name="aANALISIS">Recuperar registro foraneo de la Entidad ANALISIS.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDATOS_LABORATORIOConForaneas(ByVal aEntidad As DATOS_LABORATORIO, Optional ByVal aANALISIS As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aANALISIS)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DATOS_LABORATORIO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DATOS_LAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDATOS_LABORATORIO(ByVal ID_DATOS_LAB As Int32) As Integer
        Try
            mEntidad.ID_DATOS_LAB = ID_DATOS_LAB
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DATOS_LABORATORIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDATOS_LABORATORIO(ByVal aEntidad As DATOS_LABORATORIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarDATOS_LABORATORIO(ByVal ID_DATOS_LAB As Int32, ByVal ID_ANALISIS As Int32, ByVal ANALISTA As String, ByVal LBS_MUESTRA As Decimal, ByVal LBS_PUNTAS_TIERNA As Decimal, ByVal LBS_CANA_SECA As Decimal, ByVal LBS_MAMONES As Decimal, ByVal LBS_BAJERA As Decimal, ByVal LBS_TIERRA_RAICES As Decimal, ByVal LBS_PIEDRA As Decimal, ByVal LBS_CANA_LIMPIA As Decimal, ByVal OBSERVACION As String, ByVal PORC_PUNTAS_TIERNA As Decimal, ByVal PORC_CANA_SECA As Decimal, ByVal PORC_MAMONES As Decimal, ByVal PORC_BAJERA As Decimal, ByVal PORC_TIERRA_RAICES As Decimal, ByVal PORC_PIEDRA As Decimal, ByVal PORC_CANA_LIMPIA As Decimal, ByVal PORC_MATERIA_EXTRA As Decimal, ByVal ABSORVANCIA As Decimal, ByVal DEXTRANA As Decimal, ByVal ACIDEZ As Decimal, ByVal REDUCTORES As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, _
                                                ByVal ABSORBANCIA_ALMIDON As Decimal, ByVal BRIX_DILU As Decimal, ByVal ALMIDON_JUGO As Decimal) As Integer
        Try
            Dim lEntidad As New DATOS_LABORATORIO
            lEntidad.ID_DATOS_LAB = ID_DATOS_LAB
            lEntidad.ID_ANALISIS = ID_ANALISIS
            lEntidad.ANALISTA = ANALISTA
            lEntidad.LBS_MUESTRA = LBS_MUESTRA
            lEntidad.LBS_PUNTAS_TIERNA = LBS_PUNTAS_TIERNA
            lEntidad.LBS_CANA_SECA = LBS_CANA_SECA
            lEntidad.LBS_MAMONES = LBS_MAMONES
            lEntidad.LBS_BAJERA = LBS_BAJERA
            lEntidad.LBS_TIERRA_RAICES = LBS_TIERRA_RAICES
            lEntidad.LBS_PIEDRA = LBS_PIEDRA
            lEntidad.LBS_CANA_LIMPIA = LBS_CANA_LIMPIA
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.PORC_PUNTAS_TIERNA = PORC_PUNTAS_TIERNA
            lEntidad.PORC_CANA_SECA = PORC_CANA_SECA
            lEntidad.PORC_MAMONES = PORC_MAMONES
            lEntidad.PORC_BAJERA = PORC_BAJERA
            lEntidad.PORC_TIERRA_RAICES = PORC_TIERRA_RAICES
            lEntidad.PORC_PIEDRA = PORC_PIEDRA
            lEntidad.PORC_CANA_LIMPIA = PORC_CANA_LIMPIA
            lEntidad.PORC_MATERIA_EXTRA = PORC_MATERIA_EXTRA
            lEntidad.ABSORVANCIA = ABSORVANCIA
            lEntidad.DEXTRANA = DEXTRANA
            lEntidad.ACIDEZ = ACIDEZ
            lEntidad.REDUCTORES = REDUCTORES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ABSORBANCIA_ALMIDON = ABSORBANCIA_ALMIDON
            lEntidad.BRIX_DILU = BRIX_DILU
            lEntidad.ALMIDON_JUGO = ALMIDON_JUGO
            Return Me.ActualizarDATOS_LABORATORIO(lEntidad)
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDATOS_LABORATORIO(ByVal aEntidad As DATOS_LABORATORIO) As Integer
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDATOS_LABORATORIO(ByVal aEntidad As DATOS_LABORATORIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDATOS_LABORATORIO(ByVal ID_DATOS_LAB As Int32, ByVal ID_ANALISIS As Int32, ByVal ANALISTA As String, ByVal LBS_MUESTRA As Decimal, ByVal LBS_PUNTAS_TIERNA As Decimal, ByVal LBS_CANA_SECA As Decimal, ByVal LBS_MAMONES As Decimal, ByVal LBS_BAJERA As Decimal, ByVal LBS_TIERRA_RAICES As Decimal, ByVal LBS_PIEDRA As Decimal, ByVal LBS_CANA_LIMPIA As Decimal, ByVal OBSERVACION As String, ByVal PORC_PUNTAS_TIERNA As Decimal, ByVal PORC_CANA_SECA As Decimal, ByVal PORC_MAMONES As Decimal, ByVal PORC_BAJERA As Decimal, ByVal PORC_TIERRA_RAICES As Decimal, ByVal PORC_PIEDRA As Decimal, ByVal PORC_CANA_LIMPIA As Decimal, ByVal PORC_MATERIA_EXTRA As Decimal, ByVal ABSORVANCIA As Decimal, ByVal DEXTRANA As Decimal, ByVal ACIDEZ As Decimal, ByVal REDUCTORES As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, _
                                                ByVal ABSORBANCIA_ALMIDON As Decimal, ByVal BRIX_DILU As Decimal, ByVal ALMIDON_JUGO As Decimal) As Integer

        Try
            Dim lEntidad As New DATOS_LABORATORIO
            lEntidad.ID_DATOS_LAB = ID_DATOS_LAB
            lEntidad.ID_ANALISIS = ID_ANALISIS
            lEntidad.ANALISTA = ANALISTA
            lEntidad.LBS_MUESTRA = LBS_MUESTRA
            lEntidad.LBS_PUNTAS_TIERNA = LBS_PUNTAS_TIERNA
            lEntidad.LBS_CANA_SECA = LBS_CANA_SECA
            lEntidad.LBS_MAMONES = LBS_MAMONES
            lEntidad.LBS_BAJERA = LBS_BAJERA
            lEntidad.LBS_TIERRA_RAICES = LBS_TIERRA_RAICES
            lEntidad.LBS_PIEDRA = LBS_PIEDRA
            lEntidad.LBS_CANA_LIMPIA = LBS_CANA_LIMPIA
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.PORC_PUNTAS_TIERNA = PORC_PUNTAS_TIERNA
            lEntidad.PORC_CANA_SECA = PORC_CANA_SECA
            lEntidad.PORC_MAMONES = PORC_MAMONES
            lEntidad.PORC_BAJERA = PORC_BAJERA
            lEntidad.PORC_TIERRA_RAICES = PORC_TIERRA_RAICES
            lEntidad.PORC_PIEDRA = PORC_PIEDRA
            lEntidad.PORC_CANA_LIMPIA = PORC_CANA_LIMPIA
            lEntidad.PORC_MATERIA_EXTRA = PORC_MATERIA_EXTRA
            lEntidad.ABSORVANCIA = ABSORVANCIA
            lEntidad.DEXTRANA = DEXTRANA
            lEntidad.ACIDEZ = ACIDEZ
            lEntidad.REDUCTORES = REDUCTORES
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ABSORBANCIA_ALMIDON = ABSORBANCIA_ALMIDON
            lEntidad.BRIX_DILU = BRIX_DILU
            lEntidad.ALMIDON_JUGO = ALMIDON_JUGO
            Return Me.ActualizarDATOS_LABORATORIO(lEntidad)
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
    ''' 	[GenApp]	29/10/2013	Created
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
    ''' 	[GenApp]	29/10/2013	Created
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
    ''' la Tabla ANALISIS .
    ''' </summary>
    ''' <param name="ID_ANALISIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorANALISIS(ByVal ID_ANALISIS As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDATOS_LABORATORIO
        Try
            Dim mListaDATOS_LABORATORIO As New ListaDATOS_LABORATORIO
            mListaDATOS_LABORATORIO = mDb.ObtenerListaPorANALISIS(ID_ANALISIS, asColumnaOrden, asTipoOrden)
            If Not mListaDATOS_LABORATORIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As DATOS_LABORATORIO in  mListaDATOS_LABORATORIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDATOS_LABORATORIO
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As DATOS_LABORATORIO )
        aEntidad.fkID_ANALISIS = (New cANALISIS).ObtenerANALISIS(aEntidad.ID_ANALISIS)
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As DATOS_LABORATORIO )
    End Sub

#End Region

End Class
