Partial Public Class cBASE_PROVEEDORES_MH



    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal NOMBRES As String, ByVal APELLIDOS As String,
                                             ByVal DUI As String,
                                             ByVal NIT As String,
                                             ByVal NRC As String) As listaBASE_PROVEEDORES_MH
        Try
            Return mDb.ObtenerListaPorCriterios(NOMBRES, APELLIDOS, DUI, NIT, NRC)

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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarBASE_PROVEEDORES_MH(ByVal aEntidad As BASE_PROVEEDORES_MH) As Integer
        Try
            Return Me.ActualizarBASE_PROVEEDORES_MH(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarBASE_PROVEEDORES_MH(ByVal aEntidad As BASE_PROVEEDORES_MH, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As String
            Dim lAct As Integer
            Dim esNuevo As Boolean

            If aEntidad.ID_BASE_PROVEE = 0 Then esNuevo = True Else esNuevo = False
            lRet = Validar(esNuevo, aEntidad)
            If lRet <> "" Then
                Me.sError = lRet
                Return -1
            End If

            lAct = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            Me.ACTUALIZAR_CATALOGOS_PROVEEDORES(aEntidad.DUI, aEntidad.NIT)

            Return lAct

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Private Function Validar(ByVal aNuevo As Boolean, ByVal aEntidad As BASE_PROVEEDORES_MH) As String
        If aEntidad.DUI <> String.Empty Then
            If Not Utilerias.EsDUI(aEntidad.DUI) Then
                Return "El numero de DUI no es valido"
            End If
        End If
        If aEntidad.ID_TIPO_PERSONA = Enumeradores.TipoPersona.Juridica AndAlso aEntidad.NIT <> String.Empty Then
            If Not Utilerias.EsNIT(aEntidad.NIT) Then
                Return "El numero de NIT no es valido"
            End If
        End If
        If aNuevo Then
            'Verificar si ya existe una entidad cn el mismo DUI / NIT / NRC
            Dim lBaseProveedores As listaBASE_PROVEEDORES_MH

            If aEntidad.DUI <> "" Then
                lBaseProveedores = Me.ObtenerListaPorCriterios("", "", aEntidad.DUI, "", "")
                If lBaseProveedores IsNot Nothing AndAlso lBaseProveedores.Count > 0 Then
                    Return "Ya existe un proveedor con el mismo numero de DUI"
                End If
            End If
            If aEntidad.ID_TIPO_PERSONA = Enumeradores.TipoPersona.Juridica AndAlso aEntidad.NIT <> "" Then
                lBaseProveedores = Me.ObtenerListaPorCriterios("", "", "", aEntidad.NIT, "")
                If lBaseProveedores IsNot Nothing AndAlso lBaseProveedores.Count > 0 Then
                    Return "Ya existe un proveedor con el mismo numero de NIT"
                End If
            End If

            If aEntidad.NRC <> "" Then
                lBaseProveedores = Me.ObtenerListaPorCriterios("", "", "", "", aEntidad.NRC)
                If lBaseProveedores IsNot Nothing AndAlso lBaseProveedores.Count > 0 Then
                    Return "Ya existe un proveedor con el mismo NRC"
                End If
            End If
        Else
            Dim lBaseProveedores As listaBASE_PROVEEDORES_MH

            If aEntidad.DUI <> "" Then
                lBaseProveedores = Me.ObtenerListaPorCriterios("", "", aEntidad.DUI, "", "")
                If lBaseProveedores IsNot Nothing AndAlso lBaseProveedores.Count > 0 Then
                    For Each ent As BASE_PROVEEDORES_MH In lBaseProveedores
                        If ent.ID_BASE_PROVEE <> aEntidad.ID_BASE_PROVEE Then
                            Return "Ya existe un proveedor con el mismo numero de DUI"
                        End If
                    Next
                End If
            End If
            If aEntidad.ID_TIPO_PERSONA = Enumeradores.TipoPersona.Juridica AndAlso aEntidad.NIT <> "" Then
                lBaseProveedores = Me.ObtenerListaPorCriterios("", "", "", aEntidad.NIT, "")
                If lBaseProveedores IsNot Nothing AndAlso lBaseProveedores.Count > 0 Then
                    For Each ent As BASE_PROVEEDORES_MH In lBaseProveedores
                        If ent.ID_BASE_PROVEE <> aEntidad.ID_BASE_PROVEE Then
                            Return "Ya existe un proveedor con el mismo numero de NIT"
                        End If
                    Next
                End If
            End If
            If aEntidad.NRC <> "" Then
                lBaseProveedores = Me.ObtenerListaPorCriterios("", "", "", "", aEntidad.NRC)
                If lBaseProveedores IsNot Nothing AndAlso lBaseProveedores.Count > 0 Then
                    For Each ent As BASE_PROVEEDORES_MH In lBaseProveedores
                        If ent.ID_BASE_PROVEE <> aEntidad.ID_BASE_PROVEE Then
                            Return "Ya existe un proveedor con el mismo NRC"
                        End If
                    Next
                End If
            End If
        End If
        Return ""
    End Function

    Public Function ACTUALIZAR_CATALOGOS_PROVEEDORES(ByVal DUI As String, ByVal NIT As String) As Int32
        Try
            Return mDb.ACTUALIZAR_CATALOGOS_PROVEEDORES(DUI, NIT)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return -1
        End Try
    End Function
End Class
