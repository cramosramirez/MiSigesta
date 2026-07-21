Partial Public Class cLABFAB_ANALISIS



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
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_ANALISIS(ByVal aEntidad As LABFAB_ANALISIS) As Integer
        Try
            Return Me.ActualizarLABFAB_ANALISIS(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_ANALISIS(ByVal aEntidad As LABFAB_ANALISIS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Int32 = 0
            Dim esNuevo As Boolean = False
            Dim lEntidadAntes As New LABFAB_ANALISIS

            If aEntidad.ID_ANALISIS = 0 Then
                esNuevo = True
            Else
                lEntidadAntes = Me.ObtenerLABFAB_ANALISIS(aEntidad.ID_ANALISIS)
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If esNuevo OrElse lEntidadAntes IsNot Nothing AndAlso lEntidadAntes.ID_ANALISIS > 0 AndAlso lEntidadAntes.FORMULA <> aEntidad.FORMULA Then
                mDb.GenerarActualizarVariables(aEntidad.ID_ANALISIS, aEntidad.USUARIO_ACT, aEntidad.FECHA_ACT)
            End If
            mDb.GenerarActualizarVariables(aEntidad.ID_ANALISIS, aEntidad.USUARIO_ACT, aEntidad.FECHA_ACT)

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla LABFAB_MUESTRA .
    ''' </summary>
    ''' <param name="ID_MUESTRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLABFAB_MUESTRA(ByVal ID_MUESTRA As Int32, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC", Optional agregarVacio As Boolean = False) As listaLABFAB_ANALISIS
        Try
            Dim mListaLABFAB_ANALISIS As New listaLABFAB_ANALISIS
            mListaLABFAB_ANALISIS = mDb.ObtenerListaPorLABFAB_MUESTRA(ID_MUESTRA, asColumnaOrden, asTipoOrden)
            If agregarVacio Then
                Dim lEntidad As New LABFAB_ANALISIS
                lEntidad.ID_ANALISIS = -1
                lEntidad.NOMBRE_ANALISIS = ""
                If mListaLABFAB_ANALISIS Is Nothing Then mListaLABFAB_ANALISIS = New listaLABFAB_ANALISIS
                mListaLABFAB_ANALISIS.Insertar(0, lEntidad)
            End If
            If Not mListaLABFAB_ANALISIS Is Nothing And recuperarForaneas Then
                For Each lEntidad As LABFAB_ANALISIS In mListaLABFAB_ANALISIS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLABFAB_ANALISIS
            If Not mListaLABFAB_ANALISIS Is Nothing Then
                For Each lEntidad As LABFAB_ANALISIS In mListaLABFAB_ANALISIS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLABFAB_ANALISIS
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
