Imports System.Text

Partial Public Class cSALBODE_DETA


    Public Function ActualizarSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32, ByVal CANT_ENTREGADA As Decimal, ByVal CANT_ANULADA As Decimal) As Integer
        Try
            Dim lEntidad As SALBODE_DETA = Me.ObtenerSALBODE_DETA(ID_SALBODE_DETA)
            If lEntidad IsNot Nothing Then
                lEntidad.CANT_ENTREGADA = CANT_ENTREGADA
                lEntidad.CANT_ANULADA = CANT_ANULADA
            End If
            Return Me.ActualizarSALBODE_DETA(lEntidad)

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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSALBODE_DETA(ByVal aEntidad As SALBODE_DETA) As Integer
        Try
            Return Me.ActualizarSALBODE_DETA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	15/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSALBODE_DETA(ByVal aEntidad As SALBODE_DETA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lIdSalBodeEnca As Integer = 0
            Dim lRet As Int32 = 0

            If aEntidad.ID_SALBODE_DETA > 0 Then
                If aEntidad.CANTIDAD - aEntidad.CANT_ENTREGADA <> 0 AndAlso aEntidad.CANT_ENTREGADA > 0 Then
                    aEntidad.CANT_ANULADA = aEntidad.CANTIDAD - aEntidad.CANT_ENTREGADA
                End If
                aEntidad.ID_ESTADO = Enumeradores.EstadoSolicAgricola.Pendiente
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            'Actualizar el estado del producto en la Solicitud de Retiro
            Me.ActualizarEstadoProductoSolRetiro(aEntidad.ID_SALBODE_ENCA, aEntidad.ID_PRODUCTO)

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Private Sub ActualizarEstadoProductoSolRetiro(ByVal ID_SALBODE_ENCA As Int32, ByVal ID_PRODUCTO As Int32)
        'Validar que las entregas totales de productos sean ingresadas en cada producto sean igual a las entregas calculadas de bodega
        Dim listaDetalle As listaSALBODE_DETA
        Dim cantSolic As Decimal = 0
        Dim cantEntregadaProd As Decimal = 0
        Dim cantAnuladaProd As Decimal = 0
        Dim bSalBodeEnca As New cSALBODE_ENCA

        listaDetalle = (New cSALBODE_DETA).ObtenerListaPorSALBODE_ENCA(ID_SALBODE_ENCA)
        For Each lEntidad As SALBODE_DETA In listaDetalle
            If lEntidad.CANTIDAD > 0 AndAlso lEntidad.ID_PRODUCTO = ID_PRODUCTO Then
                cantSolic += lEntidad.CANTIDAD
                cantEntregadaProd += lEntidad.CANT_ENTREGADA
                cantAnuladaProd += lEntidad.CANT_ANULADA
            End If
        Next

        Dim dicCantEntregadaCalc As Dictionary(Of String, Decimal) = bSalBodeEnca.PROC_Calcular_Entrega_Producto(ID_SALBODE_ENCA, ID_PRODUCTO)
        If dicCantEntregadaCalc("ENTREGA") = cantEntregadaProd AndAlso (cantSolic - cantAnuladaProd - cantEntregadaProd) = 0 Then
            For Each lEntidad As SALBODE_DETA In listaDetalle
                If lEntidad.ID_PRODUCTO = ID_PRODUCTO Then
                    lEntidad.ID_ESTADO = Enumeradores.EstadoSolicAgricola.Finalizada
                    mDb.Actualizar(lEntidad, TipoConcurrencia.Pesimistica)
                End If
            Next
        End If
    End Sub

    Public Function ObtenerListaPRODUCTOS_SOLIC_CONSIGNACION(ByVal ID_ZAFRA As Int32, _
                                                     ByVal FECHA_INI As String, _
                                                     ByVal FECHA_FIN As String, _
                                                     ByVal NUM_SOLICITUD As Int32, _
                                                     ByVal NUM_SALBODE As Int32, _
                                                     ByVal CODIPROVEEDOR As String, _
                                                     ByVal ID_PROVEE As Int32, _
                                                     ByVal ID_CUENTA_FINAN As Int32, _
                                                     ByVal ID_ESTADO As Int32) As listaSALBODE_DETA
        Try
            Return mDb.ObtenerListaPRODUCTOS_SOLIC_CONSIGNACION(ID_ZAFRA, FECHA_INI, FECHA_FIN, NUM_SOLICITUD, NUM_SALBODE, CODIPROVEEDOR, ID_PROVEE, ID_CUENTA_FINAN, ID_ESTADO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
