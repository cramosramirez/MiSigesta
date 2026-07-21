Partial Public Class cLABFAB_ANALISISXDIA

    Public Function ObtenerNoAnalisisDiaZafra(ByVal ID_ANALISIS As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerNoAnalisisDiaZafra(ID_ANALISIS, ID_ZAFRA, DIAZAFRA)

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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_ANALISISXDIA(ByVal aEntidad As LABFAB_ANALISISXDIA) As Integer
        Try
            Return Me.ActualizarLABFAB_ANALISISXDIA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_ANALISISXDIA(ByVal aEntidad As LABFAB_ANALISISXDIA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_ANALISISXDIA = 0 Then
                Dim lAnalisis As LABFAB_ANALISIS = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(aEntidad.ID_ANALISIS)
                Dim noAnalisis As Int32 = Me.ObtenerNoAnalisisDiaZafra(aEntidad.ID_ANALISIS, aEntidad.ID_ZAFRA, aEntidad.DIAZAFRA)

                If noAnalisis > lAnalisis.CANT_ANALISIS Then
                    Me.sError = "No se puede ingresar este analisis ya que sobrepasa la cantidad de analisis permitidos"
                    Return -1
                End If
                aEntidad.NO_ANALISIS = noAnalisis
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function GenerarValoresAnalisisEnSerie(ByVal ID_ANALISISXDIA As Int32) As Integer
        Try
            Return mDb.GenerarValoresAnalisisEnSerie(ID_ANALISISXDIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
