Partial Public Class cDIA_ZAFRA
    Public Function ObtenerPorFECHA(ByVal FECHA As DateTime) As DIA_ZAFRA
        Try
            Return mDb.ObtenerPorFECHA(FECHA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPorZAFRA_DIA(ByVal ID_ZAFRA As Integer, ByVal DIAZAFRA As Integer) As DIA_ZAFRA
        Try
            Return mDb.ObtenerPorZAFRA_DIA(ID_ZAFRA, DIAZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerDiaZafraActivo(ByVal ID_ZAFRA As Integer) As DIA_ZAFRA
        Try
            Dim lZafra As ZAFRA
            Dim lDias As listaDIA_ZAFRA
            lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)

            If lZafra IsNot Nothing Then
                Dim lEntidad As New DIA_ZAFRA

                lDias = mDb.ObtenerListaPorZAFRA(lZafra.ID_ZAFRA, "FECHA", "DESC")
                lEntidad.ID_DIA_ZAFRA = 0
                lEntidad.DIAZAFRA = lZafra.DIAZAFRA
                If lDias IsNot Nothing AndAlso lDias.Count > 0 Then
                    If lDias(0).FECHA.AddDays(1) > lZafra.FECHA_FINAL Then
                        lEntidad.FECHA = lZafra.FECHA_FINAL
                    Else
                        lEntidad.FECHA = lDias(0).FECHA.AddDays(1)
                    End If
                Else
                    lEntidad.FECHA = lZafra.FECHA_INICIO
                End If
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDIA_ZAFRA
        Try
            Dim mListaDIA_ZAFRA As New listaDIA_ZAFRA
            mListaDIA_ZAFRA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaDIA_ZAFRA Is Nothing And recuperarForaneas Then
                For Each lEntidad As DIA_ZAFRA In mListaDIA_ZAFRA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            For i As Integer = 0 To mListaDIA_ZAFRA.Count - 1
                mListaDIA_ZAFRA(i).DESCRIPCION_DIA = mListaDIA_ZAFRA(i).DIAZAFRA.ToString + " " + mListaDIA_ZAFRA(i).FECHA.ToString("dd/MM/yyyy")
            Next
            Return mListaDIA_ZAFRA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorZafraFechaCierre(ByVal ID_ZAFRA As Integer) As listaDIA_ZAFRA
        Try
            Dim lZafra As ZAFRA
            Dim lDias As listaDIA_ZAFRA
            Dim lDia As New DIA_ZAFRA
            lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)

            If lZafra IsNot Nothing Then
                Dim lEntidad As New DIA_ZAFRA

                lDias = mDb.ObtenerListaPorZAFRA(lZafra.ID_ZAFRA, "FECHA", "ASC")
                For i As Integer = 0 To lDias.Count - 1
                    lDias(i).DESCRIPCION_DIA = lDias(i).DIAZAFRA.ToString + " - " + lDias(i).HORA_CIERRE.ToString("dd/MM/yyyy HH:mm")
                Next
                lDia = New DIA_ZAFRA
                lDia.ID_DIA_ZAFRA = lDias(lDias.Count - 1).ID_DIA_ZAFRA + 1
                lDia.ID_ZAFRA = lZafra.ID_ZAFRA
                lDia.DIAZAFRA = lZafra.DIAZAFRA
                lDia.FECHA = Today
                lDia.DESCRIPCION_DIA = lZafra.DIAZAFRA.ToString + " - " + "(A LA FECHA/HORA ACTUAL)"

                lDias.Add(lDia)
                Return lDias
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
    Public Function ActualizarDIA_ZAFRA(ByVal aEntidad As DIA_ZAFRA) As Integer
        Try
            Return Me.ActualizarDIA_ZAFRA(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
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
    Public Function ActualizarDIA_ZAFRA(ByVal aEntidad As DIA_ZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Int32
            Dim bOrdenCombustible As New cORDEN_COMBUSTIBLE
            Dim bPlanCosechaDiario As New cPLAN_COSECHA_DIARIO

            'Actualizar las Ordenes de Combustible Facturadas
            bOrdenCombustible.ActualizarPorLoteORDEN_COMSUSTIBLE()

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            'Realizar ajustes en rendimientos
            mDb.AplicarAjusteRendimiento(aEntidad.ID_ZAFRA, aEntidad.DIAZAFRA)

            'Generar propuesta de cosecha diaria
            bPlanCosechaDiario.GenerarPropuestaCosechaDiaria(aEntidad.ID_ZAFRA, aEntidad.FECHA.AddDays(1), aEntidad.USUARIO_CIERRE, cFechaHora.ObtenerFechaHora)

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            sError = ex.Message
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
    Public Function ActualizarDIA_ZAFRA(ByVal ID_DIA_ZAFRA As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal FECHA As DateTime, ByVal AZUCAR_PRODUCIDA As Decimal, ByVal AZUCAR_CALC1 As Decimal, ByVal EFICIENCIA_REAL As Decimal, ByVal USUARIO_CIERRE As String, ByVal FECHA_CIERRE As DateTime, ByVal HORA_CIERRE As DateTime) As Integer
        Try
            Dim lEntidad As New DIA_ZAFRA
            lEntidad.ID_DIA_ZAFRA = ID_DIA_ZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.FECHA = FECHA
            lEntidad.AZUCAR_PRODUCIDA = AZUCAR_PRODUCIDA
            lEntidad.AZUCAR_CALC1 = AZUCAR_CALC1
            lEntidad.EFICIENCIA_REAL = EFICIENCIA_REAL
            lEntidad.USUARIO_CIERRE = USUARIO_CIERRE
            lEntidad.FECHA_CIERRE = FECHA_CIERRE
            lEntidad.HORA_CIERRE = HORA_CIERRE
            Return Me.ActualizarDIA_ZAFRA(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
