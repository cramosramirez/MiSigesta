Imports System.Text

Partial Public Class cORDEN_COMPRA_AGRI

    Public Function PROC_GenerarORDEN_COMPRA_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal FECHA As Date, ByVal CCF_NOMBRE As String, ByVal LUGAR_ENTREGA As String, ByVal CONTACTO As String, ByVal USUARIO As String) As Integer
        Try
            Return mDb.PROC_GenerarORDEN_COMPRA_AGRICOLA(ID_SOLICITUD, FECHA, CCF_NOMBRE, LUGAR_ENTREGA, CONTACTO, USUARIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEE As Int32, ByVal CONDI_COMPRA As Int32, ByVal SOLO_ENTREGA_PENDIENTE As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaORDEN_COMPRA_AGRI
        Try

            Return mDb.ObtenerListaPorCriterios(ID_PROVEE, CONDI_COMPRA, SOLO_ENTREGA_PENDIENTE, asColumnaOrden, asTipoOrden)
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
    ''' 	[GenApp]	19/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMPRA_AGRI(ByVal aEntidad As ORDEN_COMPRA_AGRI) As Integer
        Try
            Return Me.ActualizarORDEN_COMPRA_AGRI(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	19/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMPRA_AGRI(ByVal aEntidad As ORDEN_COMPRA_AGRI, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_ORDEN = 0 Then
                Dim iNoOrden As Int32 = mDb.ObtenerNoOrdenCompraPorZafra(aEntidad.ID_ZAFRA, aEntidad.CONDI_COMPRA)
                aEntidad.NO_ORDEN = iNoOrden
                aEntidad.CODI_ORDEN = If(aEntidad.CONDI_COMPRA = 3, "C-", "") + iNoOrden.ToString
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    
End Class
