Partial Public Class cANALISIS_PRECOSECHA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPorZAFRA_NO_ANALISIS(ByVal ID_ZAFRA As Int32, NO_ANALISIS As Int32) As ANALISIS_PRECOSECHA
        Try
            Return mDb.ObtenerPorZAFRA_NO_ANALISIS(ID_ZAFRA, NO_ANALISIS)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	18/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarANALISIS_PRECOSECHA(ByVal aEntidad As ANALISIS_PRECOSECHA) As Integer
        Try
            Return Me.ActualizarANALISIS_PRECOSECHA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	18/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarANALISIS_PRECOSECHA(ByVal aEntidad As ANALISIS_PRECOSECHA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lAntesAct As ANALISIS_PRECOSECHA
            If aEntidad.ID_ANALISIS_PRE = 0 Then
                'Nueva orden
                'Establecer el N° de Análisis y N° de Muestra del Lote para esta zafra
                aEntidad.NO_MUESTRA = Me.ObtenerNoMuestraPorZafraLote(aEntidad.ID_ZAFRA, aEntidad.ACCESLOTE)
                aEntidad.NO_ANALISIS = Me.ObtenerNoAnalisisPorZafra(aEntidad.ID_ZAFRA)
            Else
                lAntesAct = (New cANALISIS_PRECOSECHA).ObtenerANALISIS_PRECOSECHA(aEntidad.ID_ANALISIS_PRE)
                If lAntesAct IsNot Nothing AndAlso lAntesAct.ACCESLOTE <> aEntidad.ACCESLOTE Then
                    Me.sError = "No se puede cambiar el lote de la Orden. Elimine esta Orden y emita una nueva"
                    Return -1
                End If
                If aEntidad.BAGAZO_BRUTO <> -1 AndAlso _
                    (aEntidad.FECHA_MUESTRA <> lAntesAct.FECHA_MUESTRA) Then
                    Me.sError = "No se puede actualizar la Orden debido a que la muestra ya posee análisis"
                    Return -1
                End If
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerNoAnalisisPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerNoAnalisisPorZafra(ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerNoMuestraPorZafraLote(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As Int32
        Try
            Return mDb.ObtenerNoMuestraPorZafraLote(ID_ZAFRA, ACCESLOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                            ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NO_CONTRATO As Int32, ByVal CODIAGRON As String) As listaANALISIS_PRECOSECHA
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ZONA, SUB_ZONA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NO_CONTRATO, CODIAGRON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ANALISIS_PRECOSECHA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ANALISIS_PRE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarANALISIS_PRECOSECHA(ByVal ID_ANALISIS_PRE As Int32) As Integer
        Try
            mEntidad.ID_ANALISIS_PRE = ID_ANALISIS_PRE
            Return Me.EliminarANALISIS_PRECOSECHA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ANALISIS_PRECOSECHA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarANALISIS_PRECOSECHA(ByVal aEntidad As ANALISIS_PRECOSECHA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lAntesAct As ANALISIS_PRECOSECHA = (New cANALISIS_PRECOSECHA).ObtenerANALISIS_PRECOSECHA(aEntidad.ID_ANALISIS_PRE)

            If lAntesAct IsNot Nothing AndAlso lAntesAct.BAGAZO_BRUTO <> -1 Then
                Me.sError = "No se puede eliminar la Orden debido a que la muestra ya posee análisis"
                Return -1
            End If
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
