Partial Public Class cCATORCENA_ZAFRA
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
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCATORCENA_ZAFRA(ByVal aEntidad As CATORCENA_ZAFRA) As Integer
        Try
            Return Me.ActualizarCATORCENA_ZAFRA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCATORCENA_ZAFRA(ByVal aEntidad As CATORCENA_ZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim esNueva As Boolean = (aEntidad.ID_CATORCENA = 0)
            Dim lRet As Int32 = 0

            If aEntidad.ID_CATORCENA = 0 Then
                If aEntidad.CATORCENA = 1 Then
                    Dim entZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
                    If entZafra IsNot Nothing Then aEntidad.FECHA_INICIO = entZafra.FECHA_INICIO
                Else
                    'Obtener la fecha fin de la catorcena anterior
                    Dim listaCatorcenaAnt As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(aEntidad.ID_ZAFRA, False, False, "FECHA_FIN", "DESC")
                    If listaCatorcenaAnt IsNot Nothing AndAlso listaCatorcenaAnt.Count > 0 Then
                        aEntidad.FECHA_INICIO = DateAndTime.DateAdd(DateInterval.Day, 1, listaCatorcenaAnt(0).FECHA_FIN)
                    Else
                        Me.sError = "No existe una catorcena anterior a la del cierre."
                        Return -1
                    End If
                End If
            End If
            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If esNueva AndAlso lRet > 0 Then
                'Generar planilla
                lRet = mDb.GENERAR_PLANILLA_CATORCENA(aEntidad.ID_ZAFRA, aEntidad.ID_CATORCENA, aEntidad.USUARIO_CIERRE, aEntidad.FECHA_CIERRE)
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return -1
        End Try
    End Function

    Public Function GENERAR_PLANILLA_CATORCENA(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Int32
        Try
            Return mDb.GENERAR_PLANILLA_CATORCENA(ID_ZAFRA, ID_CATORCENA, USUARIO_CREA, FECHA_CREA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
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
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Int32, ByVal AZUCAR_PRODUCIDA As Decimal, ByVal AZUCAR_CALC1 As Decimal, ByVal EFICIENCIA_REAL As Decimal, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FIN As DateTime, ByVal USUARIO_CIERRE As String, ByVal FECHA_CIERRE As DateTime) As Integer
        Try
            Dim lEntidad As New CATORCENA_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.AZUCAR_PRODUCIDA = AZUCAR_PRODUCIDA
            lEntidad.AZUCAR_CALC1 = AZUCAR_CALC1
            lEntidad.EFICIENCIA_REAL = EFICIENCIA_REAL
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FIN = FECHA_FIN
            lEntidad.USUARIO_CIERRE = USUARIO_CIERRE
            lEntidad.FECHA_CIERRE = FECHA_CIERRE
            Return Me.ActualizarCATORCENA_ZAFRA(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCATORCENA_ZAFRAPorZAFRA_NOCATORCENA(ByVal ID_ZAFRA As Integer, ByVal NO_CATORCENA As Integer) As CATORCENA_ZAFRA
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim listaCatorcena As listaCATORCENA_ZAFRA
            Dim lCatorcenaZafra As New CATORCENA_ZAFRA

            lCriterios.Add(New Criteria("ID_ZAFRA", "=", ID_ZAFRA, "AND"))
            lCriterios.Add(New Criteria("CATORCENA", "=", NO_CATORCENA, "AND"))
            lCatorcenaZafra.ID_ZAFRA = ID_ZAFRA
            lCatorcenaZafra.CATORCENA = NO_CATORCENA

            listaCatorcena = Me.ObtenerListaPorBusqueda(lCatorcenaZafra, lCriterios.ToArray)
            If listaCatorcena IsNot Nothing AndAlso listaCatorcena.Count > 0 Then
                Return listaCatorcena(0)
            End If

            Return Nothing

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerUltimaCatorcenaCerradaZafra(ByVal ID_ZAFRA As Integer) As CATORCENA_ZAFRA
        Try
            Return mDb.ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCatorcenaActiva(ByVal ID_ZAFRA As Integer) As CATORCENA_ZAFRA
        Try
            Dim lZafra As ZAFRA
            lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)

            If lZafra IsNot Nothing Then
                Dim lEntidad As New CATORCENA_ZAFRA
                lEntidad.ID_CATORCENA = 0
                lEntidad.CATORCENA = lZafra.CATORCENA
                Return lEntidad
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CATORCENA_ZAFRA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32) As Integer
        Try
            mEntidad.ID_CATORCENA = ID_CATORCENA
            Return Me.EliminarCATORCENA_ZAFRA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CATORCENA_ZAFRA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCATORCENA_ZAFRA(ByVal aEntidad As CATORCENA_ZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Si no es la última catorcena no se puede regenerar planilla
            Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
            Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(lCatorcena.ID_ZAFRA, False, False, "CATORCENA", "DESC")

            If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
                If lCatorcenas(0).CATORCENA <> lCatorcena.CATORCENA Then
                    Me.sError = "Solo puede eliminar la ultima catorcena generada"
                    Return -1
                End If
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
