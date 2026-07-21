Partial Public Class cZAFRA

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
    ''' 	[GenApp]	14/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZAFRA(ByVal aEntidad As ZAFRA) As Integer
        Try
            Return Me.ActualizarZAFRA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	14/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZAFRA(ByVal aEntidad As ZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lOld As New ZAFRA
            Dim lRet As Integer = 0
            Dim esNuevo As Boolean = (aEntidad.ID_ZAFRA = 0)

            If aEntidad.ID_ZAFRA = 0 Then
                Dim lZafraActiva As ZAFRA = Me.ObtenerZafraActiva

                If lZafraActiva IsNot Nothing Then
                    Me.sError = "Existe una zafra activa: " & lZafraActiva.NOMBRE_ZAFRA & ". Cierre la zafra activa para crear una nueva"
                    Return -1
                End If
                aEntidad.DIAZAFRA = 1
                aEntidad.CATORCENA = 1
                aEntidad.ACTIVA = True
            Else
                lOld = Me.ObtenerZAFRA(aEntidad.ID_ZAFRA)
            End If
            If aEntidad.DISPO_INVE_ROZA = 0 Then aEntidad.DISPO_INVE_ROZA = -1

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If Not esNuevo Then
                If lOld.POL <> aEntidad.POL OrElse lOld.HUMEDAD <> aEntidad.HUMEDAD OrElse lOld.PUREZA_MIEL <> aEntidad.PUREZA_MIEL OrElse _
                    lOld.EFICIENCIA <> aEntidad.EFICIENCIA Then

                    'Actualizar valores de análisis para los análisis de la catorcena actual
                    Dim listaEnvios As listaENVIO = (New cENVIO).ObtenerListaPorZAFRA_CATORCENA(aEntidad.ID_ZAFRA, aEntidad.CATORCENA)
                    Dim bAnalisis As New cANALISIS

                    If listaEnvios IsNot Nothing AndAlso listaEnvios.Count > 0 Then
                        For Each lEntidad As ENVIO In listaEnvios
                            Dim lstAnalisis As listaANALISIS = (New cANALISIS).ObtenerListaPorENVIO(lEntidad.ID_ENVIO)
                            If lstAnalisis IsNot Nothing AndAlso lstAnalisis.Count > 0 Then
                                For i As Int32 = 0 To lstAnalisis.Count - 1
                                    lstAnalisis(i).PAGO_INI_REAL = aEntidad.PUREZA_MIEL
                                    bAnalisis.ActualizarANALISIS(lstAnalisis(i))
                                Next
                            End If
                        Next
                    End If
                End If
            End If
            

            Return lRet
        Catch ex As Exception
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
    ''' 	[GenApp]	14/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZAFRA(ByVal ID_ZAFRA As Int32, ByVal NOMBRE_ZAFRA As String, ByVal DIAZAFRA As Int32, ByVal CATORCENA As Int32, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FINAL As DateTime, ByVal POL As Decimal, ByVal HUMEDAD As Decimal, ByVal PUREZA_MIEL As Decimal, ByVal EFICIENCIA As Decimal, ByVal PRECIO_LIBRA_AZUCAR As Decimal, ByVal CONSTANTE_A As Decimal, ByVal CONSTANTE_B As Decimal, ByVal CONSTANTE_D As Decimal, ByVal CONSTANTE_E As Decimal, ByVal ULTFECHA_CIERRE_DIARIO As DateTime, ByVal ACTIVA As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal DISPO_INVE_ROZA As Decimal) As Integer
        Try
            Dim lEntidad As New ZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.NOMBRE_ZAFRA = NOMBRE_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.CATORCENA = CATORCENA
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FINAL = FECHA_FINAL
            lEntidad.POL = POL
            lEntidad.HUMEDAD = HUMEDAD
            lEntidad.PUREZA_MIEL = PUREZA_MIEL
            lEntidad.EFICIENCIA = EFICIENCIA
            lEntidad.PRECIO_LIBRA_AZUCAR = PRECIO_LIBRA_AZUCAR
            lEntidad.CONSTANTE_A = CONSTANTE_A
            lEntidad.CONSTANTE_B = CONSTANTE_B
            lEntidad.CONSTANTE_D = CONSTANTE_D
            lEntidad.CONSTANTE_E = CONSTANTE_E
            lEntidad.ULTFECHA_CIERRE_DIARIO = ULTFECHA_CIERRE_DIARIO
            lEntidad.ACTIVA = ACTIVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.DISPO_INVE_ROZA = DISPO_INVE_ROZA
            Return Me.ActualizarZAFRA(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera la entidad ZAFRA que se encuentra ACTIVA.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerZafraActiva() As ZAFRA
        Try
            Return mDb.ObtenerZafraActiva

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerZafraAnterior(ByVal ID_ZAFRA_ACTUAL As Int32) As ZAFRA
        Try
            Return mDb.ObtenerZafraAnterior(ID_ZAFRA_ACTUAL)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera la entidad ZAFRA que se encuentra ACTIVA.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerUltimasDosZafras() As listaZAFRA
        Try
            Dim l As listaZAFRA = mDb.ObtenerListaPorID("NOMBRE_ZAFRA", "DESC")
            Dim lista As New listaZAFRA
            Dim i As Integer = 0

            For j As Integer = 0 To l.Count - 1
                If i <= 2 Then
                    lista.Add(l(j))
                Else
                    Exit For
                End If
            Next

            Return lista

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerPorNOMBRE_ZAFRA(ByVal NOMBRE_ZAFRA As String) As ZAFRA
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim lEntidad As New ZAFRA
            Dim lista As listaZAFRA

            lCriterios.Add(New Criteria("NOMBRE_ZAFRA", "=", NOMBRE_ZAFRA, ""))
            lEntidad.NOMBRE_ZAFRA = NOMBRE_ZAFRA

            lista = mDb.ObtenerListaPorBusqueda(lEntidad, lCriterios.ToArray)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Return lista(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
