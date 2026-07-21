Partial Public Class cCENSO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CENSO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CENSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCENSO(ByVal ID_CENSO As Int32) As Integer
        Try
            Dim lRet As Int32

            mEntidad.ID_CENSO = ID_CENSO
            lRet = (New cCENSO_LOTES).EliminarListaPorCENSO(ID_CENSO)

            If lRet = 1 Then
                Return mDb.Eliminar(mEntidad)
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CENSO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCENSO(ByVal aEntidad As CENSO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return Me.EliminarCENSO(aEntidad.ID_CENSO)
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
    ''' 	[GenApp]	03/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCENSO(ByVal aEntidad As CENSO) As Integer
        Try
            Return Me.ActualizarCENSO(aEntidad, EL.TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	03/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCENSO(ByVal aEntidad As CENSO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bCensoLotes As New cCENSO_LOTES
            Dim bNuevo As Boolean = (aEntidad.ID_CENSO = 0)
            Dim lRet As Int32 = 0

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            If lRet > 0 Then
                lRet = bCensoLotes.GenerarCENSO_LOTES(aEntidad.ID_CENSO, aEntidad.USUARIO_CREA, aEntidad.FECHA_CREA)
                If lRet <> 1 Then
                    Me.sError = bCensoLotes.sError
                    Me.EliminarCENSO(aEntidad.ID_CENSO)
                    Return -1
                End If
            End If
            Return lRet

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_CENSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerNUM_CENSO(ByVal ID_CENSO As Int32) As Int32
        Try
            Dim i As Integer = 0

            Dim lEntidad As CENSO = (New cCENSO).ObtenerCENSO(ID_CENSO)
            If lEntidad IsNot Nothing Then
                Dim mListaCENSO As New listaCENSO
                mListaCENSO = mDb.ObtenerListaPorZAFRA(lEntidad.ID_ZAFRA, "FECHA_CENSO", "ASC")
                For Each lCenso As CENSO In mListaCENSO
                    i += 1
                    If lCenso.ID_CENSO = ID_CENSO Then
                        Exit For
                    End If
                Next
            End If

            Return i
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorFECHA(ByVal FECHA_CENSO As DateTime) As listaCENSO
        Try
            Return mDb.ObtenerListaPorFECHA(FECHA_CENSO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
