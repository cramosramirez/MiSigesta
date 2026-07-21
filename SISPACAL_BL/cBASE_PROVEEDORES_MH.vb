''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cBASE_PROVEEDORES_MH
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla BASE_PROVEEDORES_MH
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cBASE_PROVEEDORES_MH
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbBASE_PROVEEDORES_MH()
    Private mEntidad as New BASE_PROVEEDORES_MH
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaBASE_PROVEEDORES_MH
        Try
            Dim mListaBASE_PROVEEDORES_MH As New ListaBASE_PROVEEDORES_MH
            mListaBASE_PROVEEDORES_MH = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaBASE_PROVEEDORES_MH Is Nothing And recuperarForaneas Then
                For Each lEntidad As BASE_PROVEEDORES_MH in  mListaBASE_PROVEEDORES_MH
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaBASE_PROVEEDORES_MH
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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerBASE_PROVEEDORES_MH(ByRef aEntidad As BASE_PROVEEDORES_MH, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla BASE_PROVEEDORES_MH.
    ''' </summary>
    ''' <param name="ID_BASE_PROVEE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerBASE_PROVEEDORES_MH(ByVal ID_BASE_PROVEE As Int32, ByVal Optional recuperarForaneas As Boolean = False) As BASE_PROVEEDORES_MH
        Try
            Dim lEntidad As New BASE_PROVEEDORES_MH
            lEntidad.ID_BASE_PROVEE = ID_BASE_PROVEE
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
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aTIPO_PERSONA">Recuperar registro foraneo de la Entidad TIPO_PERSONA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerBASE_PROVEEDORES_MHConForaneas(ByVal aEntidad As BASE_PROVEEDORES_MH, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aTIPO_PERSONA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aMUNICIPIO, aTIPO_PERSONA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla BASE_PROVEEDORES_MH que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_BASE_PROVEE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarBASE_PROVEEDORES_MH(ByVal ID_BASE_PROVEE As Int32) As Integer
        Try
            mEntidad.ID_BASE_PROVEE = ID_BASE_PROVEE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla BASE_PROVEEDORES_MH que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarBASE_PROVEEDORES_MH(ByVal aEntidad As BASE_PROVEEDORES_MH, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarBASE_PROVEEDORES_MH(ByVal ID_BASE_PROVEE As Int32, ByVal DUI As String, ByVal NIT As String, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal TELEFONO As String, ByVal DIRECCION As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CORREO As String, ByVal NRC As String, ByVal ID_TIPO_PERSONA As Int32, ByVal ACTIVIDAD As String) As Integer
        Try
            Dim lEntidad As New BASE_PROVEEDORES_MH
            lEntidad.ID_BASE_PROVEE = ID_BASE_PROVEE
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.TELEFONO = TELEFONO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.CORREO = CORREO
            lEntidad.NRC = NRC
            lEntidad.ID_TIPO_PERSONA = ID_TIPO_PERSONA
            lEntidad.ACTIVIDAD = ACTIVIDAD
            Return Me.ActualizarBASE_PROVEEDORES_MH(lEntidad)
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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarBASE_PROVEEDORES_MH(ByVal ID_BASE_PROVEE As Int32, ByVal DUI As String, ByVal NIT As String, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal TELEFONO As String, ByVal DIRECCION As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CORREO As String, ByVal NRC As String, ByVal ID_TIPO_PERSONA As Int32, ByVal ACTIVIDAD As String) As Integer
        Try
            Dim lEntidad As New BASE_PROVEEDORES_MH
            lEntidad.ID_BASE_PROVEE = ID_BASE_PROVEE
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.TELEFONO = TELEFONO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.CORREO = CORREO
            lEntidad.NRC = NRC
            lEntidad.ID_TIPO_PERSONA = ID_TIPO_PERSONA
            lEntidad.ACTIVIDAD = ACTIVIDAD
            Return Me.ActualizarBASE_PROVEEDORES_MH(lEntidad)
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
    ''' 	[GenApp]	13/10/2022	Created
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
    ''' 	[GenApp]	13/10/2022	Created
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
    ''' la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaBASE_PROVEEDORES_MH
        Try
            Dim mListaBASE_PROVEEDORES_MH As New ListaBASE_PROVEEDORES_MH
            mListaBASE_PROVEEDORES_MH = mDb.ObtenerListaPorMUNICIPIO(CODI_DEPTO, CODI_MUNI, asColumnaOrden, asTipoOrden)
            If Not mListaBASE_PROVEEDORES_MH Is Nothing And recuperarForaneas Then
                For Each lEntidad As BASE_PROVEEDORES_MH in  mListaBASE_PROVEEDORES_MH
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaBASE_PROVEEDORES_MH
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_PERSONA .
    ''' </summary>
    ''' <param name="ID_TIPO_PERSONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaBASE_PROVEEDORES_MH
        Try
            Dim mListaBASE_PROVEEDORES_MH As New ListaBASE_PROVEEDORES_MH
            mListaBASE_PROVEEDORES_MH = mDb.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA, asColumnaOrden, asTipoOrden)
            If Not mListaBASE_PROVEEDORES_MH Is Nothing And recuperarForaneas Then
                For Each lEntidad As BASE_PROVEEDORES_MH in  mListaBASE_PROVEEDORES_MH
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaBASE_PROVEEDORES_MH
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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As BASE_PROVEEDORES_MH )
        aEntidad.fkCODI_DEPTO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
        aEntidad.fkCODI_MUNI = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODI_DEPTO, aEntidad.CODI_DEPTO)
        aEntidad.fkID_TIPO_PERSONA = (New cTIPO_PERSONA).ObtenerTIPO_PERSONA(aEntidad.ID_TIPO_PERSONA)
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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As BASE_PROVEEDORES_MH )
    End Sub

#End Region

End Class
