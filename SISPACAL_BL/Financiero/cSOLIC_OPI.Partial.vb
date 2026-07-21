Imports System.Text

Partial Public Class cSOLIC_OPI


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal CORR_OPI As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal FECHA As DateTime) As listaSOLIC_OPI

        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, CORR_OPI, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, FECHA)
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
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_OPI(ByVal aEntidad As SOLIC_OPI) As Integer
        Try
            Return Me.ActualizarSOLIC_OPI(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_OPI(ByVal aEntidad As SOLIC_OPI, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim esAnulacion As Boolean = False
            Dim lRet As Int32

            If aEntidad.ID_OPI = 0 Then
                'Asignar N° de OPI  
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
                aEntidad.NUM_OPI_ZAFRA = mDb.ObtenerNoOPIPorZafra(aEntidad.ID_ZAFRA)
                aEntidad.REFERENCIA_GF = aEntidad.NUM_OPI_ZAFRA.ToString + "-" + lZafra.NOMBRE_ZAFRA.Replace("/", "-")
            Else
                Dim lEntidadActual As SOLIC_OPI = (New cSOLIC_OPI).ObtenerSOLIC_OPI(aEntidad.ID_OPI)
                If lEntidadActual.ID_ESTADO <> aEntidad.ID_ESTADO AndAlso aEntidad.ID_ESTADO = Enumeradores.EstadoSolicAgricola.Anulada Then
                    ' ***** ES ANULACION DE SOLICITUD
                    Dim lstCrediEnca As listaCREDITO_ENCA
                    Dim lstCrediMov As listaCREDITO_MOV

                    lstCrediEnca = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_OPI_CONTRATO)
                    If lstCrediEnca IsNot Nothing AndAlso lstCrediEnca.Count > 0 Then
                        For i As Int32 = 0 To lstCrediEnca.Count - 1

                            'Verificar si existen movimientos
                            lstCrediMov = (New cCREDITO_MOV).ObtenerListaPorCREDITO_ENCA(lstCrediEnca(i).ID_CREDITO_ENCA)
                            If lstCrediMov IsNot Nothing AndAlso lstCrediMov.Count > 0 Then
                                Me.sError = "Existen movimientos financieros relacionados a esta Solicitud."
                                Return -1
                            End If
                        Next
                    End If

                    aEntidad.ES_ACEPTADA = False
                    esAnulacion = True
                    ' *****
                End If
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If esAnulacion Then
                'Eliminar de financiamientos
                Dim listaCreditoEnca As listaCREDITO_ENCA = (New cCREDITO_ENCA).ObtenerListaPorUID_REFERENCIA(aEntidad.UID_OPI_CONTRATO)
                Dim bCreditoEnca As New cCREDITO_ENCA

                If listaCreditoEnca IsNot Nothing AndAlso listaCreditoEnca.Count > 0 Then
                    For i As Int32 = 0 To listaCreditoEnca.Count - 1
                        bCreditoEnca.EliminarCREDITO_ENCA(listaCreditoEnca(i).ID_CREDITO_ENCA)
                    Next
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
    ''' Función que Elimina un Registro de la Tabla SOLIC_OPI que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_OPI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_OPI(ByVal ID_OPI As Int32) As Integer
        Try
            mEntidad.ID_OPI = ID_OPI
            Return Me.EliminarSOLIC_OPI(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_OPI que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_OPI(ByVal aEntidad As SOLIC_OPI, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lista As listaSOLIC_OPI_CONTRATOS = (New cSOLIC_OPI_CONTRATOS).ObtenerListaPorSOLIC_OPI(aEntidad.ID_OPI)
            Dim lRet As Int32 = 0
            Dim bSolicOPIContra As New cSOLIC_OPI_CONTRATOS

            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                For i As Int32 = 0 To lista.Count - 1
                    bSolicOPIContra.EliminarSOLIC_OPI_CONTRATOS(lista(i).ID_OPI_CONTRATO)
                Next
            End If


            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
