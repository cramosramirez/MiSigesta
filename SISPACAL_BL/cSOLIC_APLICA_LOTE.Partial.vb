Partial Public Class cSOLIC_APLICA_LOTE

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
    ''' 	[GenApp]	06/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_APLICA_LOTE(ByVal aEntidad As SOLIC_APLICA_LOTE) As Integer
        Try
            Return Me.ActualizarSOLIC_APLICA_LOTE(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	06/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_APLICA_LOTE(ByVal aEntidad As SOLIC_APLICA_LOTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lProducto As PRODUCTO

            'Si el producto es un genérico no agregarlo en la aplicación
            If aEntidad.ID_SOLIC_APLICA_LOTE = 0 Then
                lProducto = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
                If lProducto IsNot Nothing AndAlso lProducto.ID_CATEGORIA = Enumeradores.CategoriaProducto.Generico Then
                    Return 1
                End If
            End If

            'Recalcular fechas de ventana
            lProducto = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
            If lProducto IsNot Nothing Then
                If lProducto.VENTSEMA_INI > 0 Then
                    aEntidad.FECHA_INI_VENTANA = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1, aEntidad.FECHA_APLICA)
                    aEntidad.FECHA_FIN_VENTANA = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1 + ((lProducto.VENTSEMA_FIN - lProducto.VENTSEMA_INI + 1) * 7), aEntidad.FECHA_APLICA)
                    aEntidad.FECHA_ROZA_MADURANTE = DateAndTime.DateAdd(DateInterval.Day, (lProducto.VENTSEMA_INI - 1) * 7 + 1 + _
                                                                Math.Round(Convert.ToDecimal((lProducto.VENTSEMA_FIN - lProducto.VENTSEMA_INI + 1) * 7) / Convert.ToDecimal(2), 0), aEntidad.FECHA_APLICA)
                Else
                    Return 1
                End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMZ(ByVal ID_SOLIC_APLICA_LOTE As Integer, ByVal MZ As Decimal, ByVal FECHA_APLICA As DateTime) As Integer
        Try
            'Si el producto es un genérico no agregarlo en la aplicación
            Dim lEntidad As SOLIC_APLICA_LOTE = (New cSOLIC_APLICA_LOTE).ObtenerSOLIC_APLICA_LOTE(ID_SOLIC_APLICA_LOTE)
            Dim tcMz As Decimal = 0

            If lEntidad IsNot Nothing Then
                tcMz = Math.Round(lEntidad.TONELADAS / lEntidad.MZ, 2)
                lEntidad.MZ = MZ
                lEntidad.FECHA_APLICA = FECHA_APLICA
                lEntidad.TONELADAS = Math.Round(MZ * tcMz, 2)
            End If

            Return Me.ActualizarSOLIC_APLICA_LOTE(lEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	06/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE
        Try
            Return mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE_NO_GENERICO(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE
        Try
            Return mDb.ObtenerListaPorZAFRA_LOTE_NO_GENERICO(ID_ZAFRA, ACCESLOTE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE_CATEGORIA(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal ID_CATEGORIA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE
        Try
            Return mDb.ObtenerListaPorZAFRA_LOTE_CATEGORIA(ID_ZAFRA, ACCESLOTE, ID_CATEGORIA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal NUM_SOLICITUD As Int32, ByVal CODIPROVEEDOR As String, ByVal ZONA As String, ByVal ID_CUENTA_FINAN As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLIC_APLICA_LOTE
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ACCESLOTE, NUM_SOLICITUD, CODIPROVEEDOR, ZONA, ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_APLICA_LOTE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_APLICA_LOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_APLICA_LOTE(ByVal ID_SOLIC_APLICA_LOTE As Int32) As Integer
        Try
            mEntidad.ID_SOLIC_APLICA_LOTE = ID_SOLIC_APLICA_LOTE
            Return Me.EliminarSOLIC_APLICA_LOTE(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_APLICA_LOTE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/12/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_APLICA_LOTE(ByVal aEntidad As SOLIC_APLICA_LOTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Eliminar las aplicaciones relacionadas por el UID_REFERENCIA
            Dim lstSolicAplicacionLote As listaSOLIC_APLICACION_LOTE
            Dim lstSolicAplicacionProd As listaSOLIC_APLICACION_PRODUCTO
            Dim lstSolicAplicacionVuelo As listaSOLIC_APLICACION_VUELO
            Dim bAplicacionLote As New cSOLIC_APLICACION_LOTE
            Dim bAplicacionProducto As New cSOLIC_APLICACION_PRODUCTO
            Dim bAplicacionVuelo As New cSOLIC_APLICACION_VUELO

            If Not aEntidad.UID_REFERENCIA.ToString.Substring(0, 4) = "0000" Then
                lstSolicAplicacionLote = bAplicacionLote.ObtenerListaPorUID_REF(aEntidad.UID_REFERENCIA)
                If lstSolicAplicacionLote IsNot Nothing AndAlso lstSolicAplicacionLote.Count > 0 Then
                    For Each lEntidad As SOLIC_APLICACION_LOTE In lstSolicAplicacionLote
                        bAplicacionLote.EliminarSOLIC_APLICACION_LOTE(lEntidad.ID_SOLIC_APLICACION_LOTE)
                    Next
                End If

                lstSolicAplicacionProd = bAplicacionProducto.ObtenerListaPorUID_REF(aEntidad.UID_REFERENCIA)
                If lstSolicAplicacionProd IsNot Nothing AndAlso lstSolicAplicacionProd.Count > 0 Then
                    For Each lEntidad As SOLIC_APLICACION_PRODUCTO In lstSolicAplicacionProd
                        bAplicacionProducto.EliminarSOLIC_APLICACION_PRODUCTO(lEntidad.ID_SOLIC_APLICACION_PROD)
                    Next
                End If

                lstSolicAplicacionVuelo = bAplicacionVuelo.ObtenerListaPorUID_REF(aEntidad.UID_REFERENCIA)
                If lstSolicAplicacionVuelo IsNot Nothing AndAlso lstSolicAplicacionVuelo.Count > 0 Then
                    For Each lEntidad As SOLIC_APLICACION_VUELO In lstSolicAplicacionVuelo
                        bAplicacionVuelo.EliminarSOLIC_APLICACION_VUELO(lEntidad.ID_SOLIC_APLICACION_VUELO)
                    Next
                End If
            End If
            

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
