''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPROYFIN_ING_LOTE
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PROYFIN_ING_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPROYFIN_ING_LOTE
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPROYFIN_ING_LOTE()
    Private mEntidad as New PROYFIN_ING_LOTE
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROYFIN_ING_LOTE
        Try
            Dim mListaPROYFIN_ING_LOTE As New ListaPROYFIN_ING_LOTE
            mListaPROYFIN_ING_LOTE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPROYFIN_ING_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROYFIN_ING_LOTE in  mListaPROYFIN_ING_LOTE
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROYFIN_ING_LOTE
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPROYFIN_ING_LOTE(ByRef aEntidad As PROYFIN_ING_LOTE, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PROYFIN_ING_LOTE.
    ''' </summary>
    ''' <param name="ID_PROYFIN_ING_LOTE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPROYFIN_ING_LOTE(ByVal ID_PROYFIN_ING_LOTE As Int32, ByVal Optional recuperarForaneas As Boolean = False) As PROYFIN_ING_LOTE
        Try
            Dim lEntidad As New PROYFIN_ING_LOTE
            lEntidad.ID_PROYFIN_ING_LOTE = ID_PROYFIN_ING_LOTE
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
    ''' <param name="aPROYFIN_ING">Recuperar registro foraneo de la Entidad PROYFIN_ING.</param>
    ''' <param name="aLOTES">Recuperar registro foraneo de la Entidad LOTES.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPROYFIN_ING_LOTEConForaneas(ByVal aEntidad As PROYFIN_ING_LOTE, Optional ByVal aPROYFIN_ING As Boolean = False, Optional ByVal aLOTES As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPROYFIN_ING, aLOTES)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROYFIN_ING_LOTE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PROYFIN_ING_LOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPROYFIN_ING_LOTE(ByVal ID_PROYFIN_ING_LOTE As Int32) As Integer
        Try
            mEntidad.ID_PROYFIN_ING_LOTE = ID_PROYFIN_ING_LOTE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROYFIN_ING_LOTE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPROYFIN_ING_LOTE(ByVal aEntidad As PROYFIN_ING_LOTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPROYFIN_ING_LOTE(ByVal ID_PROYFIN_ING_LOTE As Int32, ByVal ID_PROYFIN_ING As Int32, ByVal ACCESLOTE As String, ByVal NO_CONTRATO As Int32, ByVal CICLO As Int32, ByVal CICLO1 As Int32, ByVal MZ1 As Decimal, ByVal TC_MZ1 As Decimal, ByVal TC1 As Decimal, ByVal REND1 As Decimal, ByVal LBS1 As Decimal, ByVal CICLO2 As Int32, ByVal MZ2 As Decimal, ByVal TC_MZ2 As Decimal, ByVal TC2 As Decimal, ByVal REND2 As Decimal, ByVal LBS2 As Decimal, ByVal CICLO3 As Int32, ByVal MZ3 As Decimal, ByVal TC_MZ3 As Decimal, ByVal TC3 As Decimal, ByVal REND3 As Decimal, ByVal LBS3 As Decimal, ByVal CICLO4 As Int32, ByVal MZ4 As Decimal, ByVal TC_MZ4 As Decimal, ByVal TC4 As Decimal, ByVal REND4 As Decimal, ByVal LBS4 As Decimal, ByVal CICLO5 As Int32, ByVal MZ5 As Decimal, ByVal TC_MZ5 As Decimal, ByVal TC5 As Decimal, ByVal REND5 As Decimal, ByVal LBS5 As Decimal, ByVal CICLO6 As Int32, ByVal MZ6 As Decimal, ByVal TC_MZ6 As Decimal, ByVal TC6 As Decimal, ByVal REND6 As Decimal, ByVal LBS6 As Decimal, ByVal CICLO7 As Int32, ByVal MZ7 As Decimal, ByVal TC_MZ7 As Decimal, ByVal TC7 As Decimal, ByVal REND7 As Decimal, ByVal LBS7 As Decimal) As Integer
        Try
            Dim lEntidad As New PROYFIN_ING_LOTE
            lEntidad.ID_PROYFIN_ING_LOTE = ID_PROYFIN_ING_LOTE
            lEntidad.ID_PROYFIN_ING = ID_PROYFIN_ING
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.NO_CONTRATO = NO_CONTRATO
            lEntidad.CICLO = CICLO
            lEntidad.CICLO1 = CICLO1
            lEntidad.MZ1 = MZ1
            lEntidad.TC_MZ1 = TC_MZ1
            lEntidad.TC1 = TC1
            lEntidad.REND1 = REND1
            lEntidad.LBS1 = LBS1
            lEntidad.CICLO2 = CICLO2
            lEntidad.MZ2 = MZ2
            lEntidad.TC_MZ2 = TC_MZ2
            lEntidad.TC2 = TC2
            lEntidad.REND2 = REND2
            lEntidad.LBS2 = LBS2
            lEntidad.CICLO3 = CICLO3
            lEntidad.MZ3 = MZ3
            lEntidad.TC_MZ3 = TC_MZ3
            lEntidad.TC3 = TC3
            lEntidad.REND3 = REND3
            lEntidad.LBS3 = LBS3
            lEntidad.CICLO4 = CICLO4
            lEntidad.MZ4 = MZ4
            lEntidad.TC_MZ4 = TC_MZ4
            lEntidad.TC4 = TC4
            lEntidad.REND4 = REND4
            lEntidad.LBS4 = LBS4
            lEntidad.CICLO5 = CICLO5
            lEntidad.MZ5 = MZ5
            lEntidad.TC_MZ5 = TC_MZ5
            lEntidad.TC5 = TC5
            lEntidad.REND5 = REND5
            lEntidad.LBS5 = LBS5
            lEntidad.CICLO6 = CICLO6
            lEntidad.MZ6 = MZ6
            lEntidad.TC_MZ6 = TC_MZ6
            lEntidad.TC6 = TC6
            lEntidad.REND6 = REND6
            lEntidad.LBS6 = LBS6
            lEntidad.CICLO7 = CICLO7
            lEntidad.MZ7 = MZ7
            lEntidad.TC_MZ7 = TC_MZ7
            lEntidad.TC7 = TC7
            lEntidad.REND7 = REND7
            lEntidad.LBS7 = LBS7
            Return Me.ActualizarPROYFIN_ING_LOTE(lEntidad)
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROYFIN_ING_LOTE(ByVal aEntidad As PROYFIN_ING_LOTE) As Integer
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROYFIN_ING_LOTE(ByVal aEntidad As PROYFIN_ING_LOTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROYFIN_ING_LOTE(ByVal ID_PROYFIN_ING_LOTE As Int32, ByVal ID_PROYFIN_ING As Int32, ByVal ACCESLOTE As String, ByVal NO_CONTRATO As Int32, ByVal CICLO As Int32, ByVal CICLO1 As Int32, ByVal MZ1 As Decimal, ByVal TC_MZ1 As Decimal, ByVal TC1 As Decimal, ByVal REND1 As Decimal, ByVal LBS1 As Decimal, ByVal CICLO2 As Int32, ByVal MZ2 As Decimal, ByVal TC_MZ2 As Decimal, ByVal TC2 As Decimal, ByVal REND2 As Decimal, ByVal LBS2 As Decimal, ByVal CICLO3 As Int32, ByVal MZ3 As Decimal, ByVal TC_MZ3 As Decimal, ByVal TC3 As Decimal, ByVal REND3 As Decimal, ByVal LBS3 As Decimal, ByVal CICLO4 As Int32, ByVal MZ4 As Decimal, ByVal TC_MZ4 As Decimal, ByVal TC4 As Decimal, ByVal REND4 As Decimal, ByVal LBS4 As Decimal, ByVal CICLO5 As Int32, ByVal MZ5 As Decimal, ByVal TC_MZ5 As Decimal, ByVal TC5 As Decimal, ByVal REND5 As Decimal, ByVal LBS5 As Decimal, ByVal CICLO6 As Int32, ByVal MZ6 As Decimal, ByVal TC_MZ6 As Decimal, ByVal TC6 As Decimal, ByVal REND6 As Decimal, ByVal LBS6 As Decimal, ByVal CICLO7 As Int32, ByVal MZ7 As Decimal, ByVal TC_MZ7 As Decimal, ByVal TC7 As Decimal, ByVal REND7 As Decimal, ByVal LBS7 As Decimal) As Integer
        Try
            Dim lEntidad As New PROYFIN_ING_LOTE
            lEntidad.ID_PROYFIN_ING_LOTE = ID_PROYFIN_ING_LOTE
            lEntidad.ID_PROYFIN_ING = ID_PROYFIN_ING
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.NO_CONTRATO = NO_CONTRATO
            lEntidad.CICLO = CICLO
            lEntidad.CICLO1 = CICLO1
            lEntidad.MZ1 = MZ1
            lEntidad.TC_MZ1 = TC_MZ1
            lEntidad.TC1 = TC1
            lEntidad.REND1 = REND1
            lEntidad.LBS1 = LBS1
            lEntidad.CICLO2 = CICLO2
            lEntidad.MZ2 = MZ2
            lEntidad.TC_MZ2 = TC_MZ2
            lEntidad.TC2 = TC2
            lEntidad.REND2 = REND2
            lEntidad.LBS2 = LBS2
            lEntidad.CICLO3 = CICLO3
            lEntidad.MZ3 = MZ3
            lEntidad.TC_MZ3 = TC_MZ3
            lEntidad.TC3 = TC3
            lEntidad.REND3 = REND3
            lEntidad.LBS3 = LBS3
            lEntidad.CICLO4 = CICLO4
            lEntidad.MZ4 = MZ4
            lEntidad.TC_MZ4 = TC_MZ4
            lEntidad.TC4 = TC4
            lEntidad.REND4 = REND4
            lEntidad.LBS4 = LBS4
            lEntidad.CICLO5 = CICLO5
            lEntidad.MZ5 = MZ5
            lEntidad.TC_MZ5 = TC_MZ5
            lEntidad.TC5 = TC5
            lEntidad.REND5 = REND5
            lEntidad.LBS5 = LBS5
            lEntidad.CICLO6 = CICLO6
            lEntidad.MZ6 = MZ6
            lEntidad.TC_MZ6 = TC_MZ6
            lEntidad.TC6 = TC6
            lEntidad.REND6 = REND6
            lEntidad.LBS6 = LBS6
            lEntidad.CICLO7 = CICLO7
            lEntidad.MZ7 = MZ7
            lEntidad.TC_MZ7 = TC_MZ7
            lEntidad.TC7 = TC7
            lEntidad.REND7 = REND7
            lEntidad.LBS7 = LBS7
            Return Me.ActualizarPROYFIN_ING_LOTE(lEntidad)
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
    ''' 	[GenApp]	23/01/2020	Created
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
    ''' 	[GenApp]	23/01/2020	Created
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
    ''' la Tabla PROYFIN_ING .
    ''' </summary>
    ''' <param name="ID_PROYFIN_ING"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROYFIN_ING(ByVal ID_PROYFIN_ING As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROYFIN_ING_LOTE
        Try
            Dim mListaPROYFIN_ING_LOTE As New ListaPROYFIN_ING_LOTE
            mListaPROYFIN_ING_LOTE = mDb.ObtenerListaPorPROYFIN_ING(ID_PROYFIN_ING, asColumnaOrden, asTipoOrden)
            If Not mListaPROYFIN_ING_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROYFIN_ING_LOTE in  mListaPROYFIN_ING_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROYFIN_ING_LOTE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROYFIN_ING_LOTE
        Try
            Dim mListaPROYFIN_ING_LOTE As New ListaPROYFIN_ING_LOTE
            mListaPROYFIN_ING_LOTE = mDb.ObtenerListaPorLOTES(ACCESLOTE, asColumnaOrden, asTipoOrden)
            If Not mListaPROYFIN_ING_LOTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROYFIN_ING_LOTE in  mListaPROYFIN_ING_LOTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROYFIN_ING_LOTE
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PROYFIN_ING_LOTE )
        aEntidad.fkID_PROYFIN_ING = (New cPROYFIN_ING).ObtenerPROYFIN_ING(aEntidad.ID_PROYFIN_ING)
        aEntidad.fkACCESLOTE = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE)
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PROYFIN_ING_LOTE )
    End Sub

#End Region

End Class
