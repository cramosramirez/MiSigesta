''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSALBODE_DETA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SALBODE_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSALBODE_DETA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSALBODE_DETA()
    Private mEntidad as New SALBODE_DETA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSALBODE_DETA
        Try
            Dim mListaSALBODE_DETA As New ListaSALBODE_DETA
            mListaSALBODE_DETA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSALBODE_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSALBODE_DETA
            If Not mListaSALBODE_DETA Is Nothing Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSALBODE_DETA
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSALBODE_DETA(ByRef aEntidad As SALBODE_DETA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SALBODE_DETA.
    ''' </summary>
    ''' <param name="ID_SALBODE_DETA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SALBODE_DETA
        Try
            Dim lEntidad As New SALBODE_DETA
            lEntidad.ID_SALBODE_DETA = ID_SALBODE_DETA
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
    ''' <param name="aSALBODE_ENCA">Recuperar registro foraneo de la Entidad SALBODE_ENCA.</param>
    ''' <param name="aSOLIC_AGRICOLA">Recuperar registro foraneo de la Entidad SOLIC_AGRICOLA.</param>
    ''' <param name="aPRODUCTO">Recuperar registro foraneo de la Entidad PRODUCTO.</param>
    ''' <param name="aSOLIC_AGRICOLA_ESTADO">Recuperar registro foraneo de la Entidad SOLIC_AGRICOLA_ESTADO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSALBODE_DETAConForaneas(ByVal aEntidad As SALBODE_DETA, Optional ByVal aSALBODE_ENCA As Boolean = False, Optional ByVal aSOLIC_AGRICOLA As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False, Optional ByVal aSOLIC_AGRICOLA_ESTADO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSALBODE_ENCA, aSOLIC_AGRICOLA, aPRODUCTO, aSOLIC_AGRICOLA_ESTADO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SALBODE_DETA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SALBODE_DETA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32) As Integer
        Try
            mEntidad.ID_SALBODE_DETA = ID_SALBODE_DETA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SALBODE_DETA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSALBODE_DETA(ByVal aEntidad As SALBODE_DETA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32, ByVal ID_SALBODE_ENCA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PRODUCTO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal UNIDAD As String, ByVal PRESENTACION As String, ByVal CANTIDAD As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal, ByVal CANT_ENTREGADA As Decimal, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CANT_ANULADA As Decimal, ByVal ID_ESTADO As Int32) As Integer
        Try
            Dim lEntidad As New SALBODE_DETA
            lEntidad.ID_SALBODE_DETA = ID_SALBODE_DETA
            lEntidad.ID_SALBODE_ENCA = ID_SALBODE_ENCA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.UNIDAD = UNIDAD
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.TOTAL = TOTAL
            lEntidad.CANT_ENTREGADA = CANT_ENTREGADA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CANT_ANULADA = CANT_ANULADA
            lEntidad.ID_ESTADO = ID_ESTADO
            Return Me.ActualizarSALBODE_DETA(lEntidad)
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32, ByVal ID_SALBODE_ENCA As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PRODUCTO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal UNIDAD As String, ByVal PRESENTACION As String, ByVal CANTIDAD As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal TOTAL As Decimal, ByVal CANT_ENTREGADA As Decimal, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CANT_ANULADA As Decimal, ByVal ID_ESTADO As Int32) As Integer
        Try
            Dim lEntidad As New SALBODE_DETA
            lEntidad.ID_SALBODE_DETA = ID_SALBODE_DETA
            lEntidad.ID_SALBODE_ENCA = ID_SALBODE_ENCA
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.UNIDAD = UNIDAD
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.TOTAL = TOTAL
            lEntidad.CANT_ENTREGADA = CANT_ENTREGADA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CANT_ANULADA = CANT_ANULADA
            lEntidad.ID_ESTADO = ID_ESTADO
            Return Me.ActualizarSALBODE_DETA(lEntidad)
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
    ''' 	[GenApp]	15/06/2018	Created
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
    ''' 	[GenApp]	15/06/2018	Created
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
    ''' la Tabla SALBODE_ENCA .
    ''' </summary>
    ''' <param name="ID_SALBODE_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSALBODE_ENCA(ByVal ID_SALBODE_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSALBODE_DETA
        Try
            Dim mListaSALBODE_DETA As New ListaSALBODE_DETA
            mListaSALBODE_DETA = mDb.ObtenerListaPorSALBODE_ENCA(ID_SALBODE_ENCA, asColumnaOrden, asTipoOrden)
            If Not mListaSALBODE_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSALBODE_DETA
            If Not mListaSALBODE_DETA Is Nothing Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSALBODE_DETA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSALBODE_DETA
        Try
            Dim mListaSALBODE_DETA As New ListaSALBODE_DETA
            mListaSALBODE_DETA = mDb.ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSALBODE_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSALBODE_DETA
            If Not mListaSALBODE_DETA Is Nothing Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSALBODE_DETA
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSALBODE_DETA
        Try
            Dim mListaSALBODE_DETA As New ListaSALBODE_DETA
            mListaSALBODE_DETA = mDb.ObtenerListaPorPRODUCTO(ID_PRODUCTO, asColumnaOrden, asTipoOrden)
            If Not mListaSALBODE_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSALBODE_DETA
            If Not mListaSALBODE_DETA Is Nothing Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSALBODE_DETA
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA_ESTADO .
    ''' </summary>
    ''' <param name="ID_SOLIC_ESTADO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA_ESTADO(ByVal ID_SOLIC_ESTADO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSALBODE_DETA
        Try
            Dim mListaSALBODE_DETA As New ListaSALBODE_DETA
            mListaSALBODE_DETA = mDb.ObtenerListaPorSOLIC_AGRICOLA_ESTADO(ID_SOLIC_ESTADO, asColumnaOrden, asTipoOrden)
            If Not mListaSALBODE_DETA Is Nothing And recuperarForaneas Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSALBODE_DETA
            If Not mListaSALBODE_DETA Is Nothing Then
                For Each lEntidad As SALBODE_DETA in  mListaSALBODE_DETA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSALBODE_DETA
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SALBODE_DETA )
        aEntidad.fkID_SALBODE_ENCA = (New cSALBODE_ENCA).ObtenerSALBODE_ENCA(aEntidad.ID_SALBODE_ENCA)
        aEntidad.fkID_SOLICITUD = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
        aEntidad.fkID_ESTADO = (New cSOLIC_AGRICOLA_ESTADO).ObtenerSOLIC_AGRICOLA_ESTADO(aEntidad.ID_ESTADO)
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SALBODE_DETA )
    End Sub

#End Region

End Class
